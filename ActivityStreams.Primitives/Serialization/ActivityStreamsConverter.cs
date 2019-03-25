using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace ActivityStreams.Primitives.Serialization
{
	/// <summary>
	/// Activity Streams converter required for proper serialization/deserialization within
	/// application code.
	/// </summary>
	public class ActivityStreamsConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return (typeof(ActivityStreamsBase).IsAssignableFrom(objectType));
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

			// Root level context is serialized as "@context" instead of "context." Replace 
			// property name before it's deserialized.
			var contextProperty = token.Children<JProperty>().FirstOrDefault(f => f.Name.Equals("@context", StringComparison.InvariantCultureIgnoreCase));
			if (contextProperty != null)
			{
				contextProperty.AddAfterSelf(new JProperty($"context", contextProperty.Value));
				contextProperty.Remove();
			}

			// Replace property names for all root level StringMap properties containing more than 
			// one value.
			var stringMapPropertyNames = token.Children<JProperty>().Where(f => Utils.StringMapReadProperties.Contains(f.Name)).Select(s => s.Name).ToArray();
			foreach (var stringMapPropertyName in stringMapPropertyNames)
			{
				var stringMapProperty = token.Children<JProperty>().SingleOrDefault(s => s.Name.Equals(stringMapPropertyName));

				stringMapProperty.AddAfterSelf(new JProperty(stringMapProperty.Name.Replace("Map", ""), stringMapProperty.Value));
				stringMapProperty.Remove();
			}

			// All other properties will be handled by InnerJsonConverter.
			return token.ToObject(objectType);
		}

		private object ReadObject(JToken token)
		{
			if (token.Type == JTokenType.String)
			{
				return new ActivityStreamsObject(token.Value<string>());
			}
			else
			{
				return token.ToObject<ActivityStreamsObject>();
			}
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var token = JToken.FromObject(value);

			// Root level context is serialized as "@context" instead of "context." Replace 
			// property name before it's written out.
			var contextProp = token.Children<JProperty>().FirstOrDefault(f => f.Name.Equals("context", StringComparison.InvariantCultureIgnoreCase));
			if (contextProp != null)
			{
				contextProp.AddAfterSelf(new JProperty($"@context", contextProp.Value));
				contextProp.Remove();
			}

			// Replace property names for all root level StringMap properties containing more than 
			// one value.
			var stringMapPropertyNames = token.Children<JProperty>().Where(f => Utils.StringMapWriteProperties.Contains(f.Name)).Select(s => s.Name).ToArray();
			foreach (var stringMapPropertyName in stringMapPropertyNames)
			{
				var stringMapProperty = token.Children<JProperty>().SingleOrDefault(s => s.Name.Equals(stringMapPropertyName));

				if (stringMapProperty?.Values().Count() > 1)
				{
					stringMapProperty.AddAfterSelf(new JProperty($"{stringMapProperty.Name}Map", stringMapProperty.Value));
					stringMapProperty.Remove();
				}
			}

			// All other properties will be handled by InnerJsonConverter.
			token.WriteTo(writer);
		}
	}
}
