using FluentAssertions;
using FluentAssertions.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Xunit;

namespace ActivityStreams.Primitives.Tests
{
	public class AdditionalTests
	{
		private readonly Collection<Note> innerStringMap = new Collection<Note>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's notes",
			TotalItems = 1,
			Items = new Note
			{
				Content = new Dictionary<string, string>
				{
					{ "en", "A <em>simple</em> note"},
					{ "es", "Una nota <em>sencilla</em>" },
					{ "zh-Hans", "一段<em>简单的</em>笔记" }
				}
			}
		};

		[Fact]
		public void InnerStringMap_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(innerStringMap, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Additional.InnerSringMap);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void InnerStringMap_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Note>>(SerializedJson.Additional.InnerSringMap, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(innerStringMap);
		}
	}
}
