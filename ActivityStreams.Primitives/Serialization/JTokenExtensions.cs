using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityStreams.Primitives.Serialization
{
	
	public static class JTokenExtensions
	{
		/// <summary>
		/// Extension method to try return single value from JToken.
		/// </summary>
		/// <typeparam name="T">Type of value to be returned.</typeparam>
		/// <param name="key">Key of the object to be returned.</param>
		/// <param name="value">Return value.</param>
		/// <returns></returns>
		public static bool TryGetValue<T>(this JToken token, object key, out T value)
		{
			value = default(T);

			try
			{
				value = token.Value<T>(key);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
