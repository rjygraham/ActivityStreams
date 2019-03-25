using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ActivityStreams.Primitives.Serialization
{
	/// <summary>
	/// Converter that handles the really messy/ugly serialization/deserialization of Activity 
	/// Streams object properties.
	/// </summary>
	internal class InnerJsonConverter : JsonConverter
	{
		private static Type activityStreamsBaseType = typeof(ActivityStreamsBase);

		public override bool CanConvert(Type objectType)
		{
			return true;
		}

		public override bool CanWrite
		{
			get { return true; }
		}

		public override bool CanRead
		{
			get { return true; }
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var token = JToken.Load(reader);

			if (typeof(IValue).IsAssignableFrom(objectType))
			{
				return ReadIValue(token, objectType);
			}
			else if (objectType.IsGenericType && typeof(List<>) == objectType.GetGenericTypeDefinition())
			{
				var targetType = objectType.GenericTypeArguments[0];
				return ReadList(token, targetType);
			}
			else if (objectType == typeof(TimeSpan?))
			{
				return ReadTimeSpan(token);
			}
			else if (token.Type == JTokenType.String)
			{
				return ReadString(token, objectType);
			}
			else if ((token.Type == JTokenType.Boolean || token.Type == JTokenType.Date) && typeof(IActivityStreamsType).IsAssignableFrom(objectType))
			{
				return ReadActivityStreamsType(token, objectType);
			}

			return token.ToObject(objectType);
		}

		private object ReadString(JToken token, Type objectType)
		{
			if (objectType == typeof(Link))
			{
				return new Link(token.Value<string>());
			}
			else if (objectType == typeof(Relationship))
			{
				return new Relationship(token.Value<string>());
			}
			else if (objectType == typeof(string))
			{
				return token.Value<string>();
			}
			else
			{
				return new ActivityStreamsObject(token.Value<string>());
			}
		}

		private object ReadActivityStreamsType(JToken token, Type objectType)
		{
			switch (token.Type)
			{
				case JTokenType.Boolean:
					return new ActivityStreamsBoolean(token.Value<bool>());
				case JTokenType.Date:
					return new ActivityStreamsDateTime(token.Value<DateTime>());
				default:
					return ReadOne(token, objectType);
			}
		}

		private object ReadIValue(JToken token, Type objectType)
		{
			if (objectType == typeof(StringMap))
			{
				if (token.Type == JTokenType.String)
				{
					return token.ToObject(objectType);
				}
				else
				{
					return new StringMap(token.ToObject<Dictionary<string, string>>());
				}
			}
			else
			{
				var genericArgumentType = objectType.GenericTypeArguments[0];

				switch (token.Type)
				{
					case JTokenType.Object:
					case JTokenType.String:
						var oneOrManyType = typeof(OneOrMany<>).MakeGenericType(genericArgumentType);
						return Activator.CreateInstance(oneOrManyType, ReadOne(token, genericArgumentType));
					default:
						return ReadMany(token, genericArgumentType);
				}
			}
		}

		private object ReadList(JToken token, Type objectType)
		{
			var listType = typeof(List<>).MakeGenericType(objectType);
			var list = (IList)Activator.CreateInstance(listType);

			foreach (var item in token.ToArray())
			{
				list.Add(ReadOne(item, objectType));
			}

			return list;
		}

		private object ReadTimeSpan(JToken token)
		{
			return XmlConvert.ToTimeSpan(token.Value<string>());
		}

		private object ReadOne(JToken token, Type objectType)
		{
			var targetType = token.TryGetValue("type", out string tokenType)
				? Type.GetType($"ActivityStreams.Primitives.{tokenType}") ?? objectType
				: objectType;

			var stringMapPropertyNames = token.Children<JProperty>().Where(f => Utils.StringMapReadProperties.Contains(f.Name)).Select(s => s.Name).ToArray();
			foreach (var stringMapPropertyName in stringMapPropertyNames)
			{
				var stringMapProperty = token.Children<JProperty>().SingleOrDefault(s => s.Name.Equals(stringMapPropertyName));

				stringMapProperty.AddAfterSelf(new JProperty(stringMapProperty.Name.Replace("Map", ""), stringMapProperty.Value));
				stringMapProperty.Remove();
			}

			if (token.Type == JTokenType.String)
			{
				return ReadString(token, objectType);
			}
			else
			{
				return token.ToObject(targetType);
			}
		}

		private object ReadMany(JToken token, Type objectType)
		{
			IList list = new ArrayList();

			foreach (var item in token.ToArray())
			{
				list.Add(ReadOne(item, objectType));
			}

			var array = Array.CreateInstance(objectType, list.Count);
			list.CopyTo(array, 0);

			var oneOrManyType = typeof(OneOrMany<>).MakeGenericType(objectType);
			return Activator.CreateInstance(oneOrManyType, array);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			value = WriteValue(value);
			serializer.Serialize(writer, value);
		}

		private object WriteValue(object value)
		{
			switch (value)
			{
				case ActivityStreamsObject @base:
					return WriteObject(@base);
				case Link link:
					return WriteObject(link);
				case IValue ivalue:
					return WriteIValue(ivalue);
				case IActivityStreamsType astype:
					return WriteActivityStreamType(astype);
				case TimeSpan timeSpan:
					return WriteTimeSpan(timeSpan);
				default:
					return value;
			}
		}

		private object WriteObject(object value)
		{
			var @object = JObject.FromObject(value);
			var isStringMapReplaced = false;

			// Replace property names for all root level StringMap properties containing more than 
			// one value.
			var stringMapPropertyNames = @object.Children<JProperty>().Where(f => Utils.StringMapWriteProperties.Contains(f.Name)).Select(s => s.Name).ToArray();
			foreach (var stringMapPropertyName in stringMapPropertyNames)
			{
				var stringMapProperty = @object.Children<JProperty>().SingleOrDefault(s => s.Name.Equals(stringMapPropertyName));

				if (stringMapProperty?.Values().Count() > 1)
				{
					isStringMapReplaced = true;
					stringMapProperty.AddAfterSelf(new JProperty($"{stringMapProperty.Name}Map", stringMapProperty.Value));
					stringMapProperty.Remove();
				}
			}

			// Some types that have single property value set serialize as simple string.
			if (@object.Values().Count() == 1)
			{
				JToken token;
				if (@object.TryGetValue("id", out token))
				{
					value = token.Value<string>();
				}
				else if (@object.TryGetValue("type", out token))
				{
					value = token.Value<string>();
				}
				else if (@object.TryGetValue("href", out token))
				{
					value = token.Value<string>();
				}
			}
			else if (isStringMapReplaced)
			{
				value = @object;
			}

			return value;
		}

		private object WriteIValue(IValue value)
		{
			if (value.GetType() == typeof(StringMap))
			{
				return value.Value;
			}
			else
			{
				if (value.Count == 1)
				{
					return WriteObject(value.Value);
				}
				else if (value.Value != null)
				{
					return GetYield((IEnumerable<object>)value.Value);
				}
				else
				{
					return null;
				}
			}
		}

		private object WriteActivityStreamType(IActivityStreamsType astype)
		{
			switch (astype)
			{
				case ActivityStreamsBoolean @bool:
					return @bool.Value;
				case ActivityStreamsDateTime dateTime:
					return dateTime.Value;
				default:
					return astype;
			}
		}

		private IEnumerable<object> GetYield(IEnumerable<object> value)
		{
			foreach (var item in value)
			{
				yield return WriteValue(item);
			}
		}

		private object WriteTimeSpan(TimeSpan timeSpan)
		{
			return XmlConvert.ToString(timeSpan);
		}
	}
}
