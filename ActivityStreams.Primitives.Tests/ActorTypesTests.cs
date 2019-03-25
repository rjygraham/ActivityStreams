using FluentAssertions;
using FluentAssertions.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace ActivityStreams.Primitives.Tests
{
	public class ActorTypesTests
	{
		private readonly Application ex42 = new Application
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Exampletron 3000"
		};

		[Fact]
		public void Example_42_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex42, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_42_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_42_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Application>(SerializedJson.Examples.Example_42_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex42);
		}

		private readonly Group ex43 = new Group
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Big Beards of Austin"
		};

		[Fact]
		public void Example_43_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex43, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_43_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_43_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Group>(SerializedJson.Examples.Example_43_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex43);
		}

		private readonly Organization ex44 = new Organization
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Example Co."
		};

		[Fact]
		public void Example_44_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex44, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_44_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_44_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Organization>(SerializedJson.Examples.Example_44_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex44);
		}

		private readonly Person ex45 = new Person
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Sally Smith"
		};

		[Fact]
		public void Example_45_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex45, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_45_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_45_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Person>(SerializedJson.Examples.Example_45_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex45);
		}

		private readonly Service ex46 = new Service
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Acme Web Service"
		};

		[Fact]
		public void Example_46_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex46, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_46_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_46_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Service>(SerializedJson.Examples.Example_46_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex46);
		}

	}
}
