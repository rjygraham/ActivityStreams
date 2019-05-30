using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ActivityStreams.Primitives.Tests
{
	internal static class Utils
	{
		internal static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
		{
			Converters = new List<JsonConverter>()
			{
				new ActivityStreamsJsonConverter()
			}
		};
	}
}