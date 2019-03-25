using FluentAssertions;
using FluentAssertions.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Xunit;

namespace ActivityStreams.Primitives.Tests
{
	public class CoreTypesTests
	{
		private readonly ActivityStreamsObject ex1 = new ActivityStreamsObject("http://www.test.example/object/1", "Object")
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A Simple, non-specific object"
		};

		[Fact]
		public void Example_1_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex1, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_1_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_1_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<ActivityStreamsObject>(SerializedJson.Examples.Example_1_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex1);
		}

		private readonly Link ex2 = new Link
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Href = "http://example.org/abc",
			HrefLang = "en",
			MediaType = "text/html",
			Name = "An example link"
		};

		[Fact]
		public void Example_2_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex2, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_2_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_2_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Link>(SerializedJson.Examples.Example_2_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex2);
		}

		private readonly Activity ex3 = new Activity
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally did something to a note",
			Actor = new Person { Name = "Sally" },
			Object = new Note { Name = "A Note" }
		};

		[Fact]
		public void Example_3_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex3, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_3_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_3_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Activity>(SerializedJson.Examples.Example_3_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex3);
		}

		private readonly Travel ex4 = new Travel
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary ="Sally went to work",
			Actor = new Person { Name = "Sally" },
			Target = new Place { Name = "Work" }
		};

		[Fact]
		public void Example_4_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex4, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_4_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_4_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Travel>(SerializedJson.Examples.Example_4_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex4);
		}

		private readonly Collection<Note> ex5 = new Collection<Note>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's notes",
			TotalItems = 2,
			Items = new Note[]
			{
				new Note
				{
					Name = "A Simple Note"
				},
				new Note
				{
					Name = "Another Simple Note"
				}
			}
		};

		[Fact]
		public void Example_5_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex5, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_5_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_5_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Note>>(SerializedJson.Examples.Example_5_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex5);
		}

		private readonly OrderedCollection<Note> ex6 = new OrderedCollection<Note>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's notes",
			TotalItems = 2,
			OrderedItems = new List<Note>
			{
				new Note
				{
					Name = "A Simple Note"
				},
				new Note
				{
					Name = "Another Simple Note"
				}
			}
		};

		[Fact]
		public void Example_6_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex6, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_6_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_6_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<OrderedCollection<Note>>(SerializedJson.Examples.Example_6_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex6);
		}

		private readonly CollectionPage<Note, ActivityStreamsBase> ex7 = new CollectionPage<Note, ActivityStreamsBase>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Page 1 of Sally's notes",
			Id = "http://example.org/foo?page=1",
			PartOf = new ActivityStreamsObject("http://example.org/foo"),
			Items = new Note[]
			{
				new Note
				{
					Name = "A Simple Note"
				},
				new Note
				{
					Name = "Another Simple Note"
				}
			}
		};

		[Fact]
		public void Example_7_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex7, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_7_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_7_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<CollectionPage<Note, ActivityStreamsBase>>(SerializedJson.Examples.Example_7_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex7);
		}

		private readonly OrderedCollectionPage<Note, ActivityStreamsBase> ex8 = new OrderedCollectionPage<Note, ActivityStreamsBase>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Page 1 of Sally's notes",
			Id = "http://example.org/foo?page=1",
			PartOf = "http://example.org/foo",
			OrderedItems = new List<Note>
			{
				new Note
				{
					Name = "A Simple Note"
				},
				new Note
				{
					Name = "Another Simple Note"
				}
			}
		};

		[Fact]
		public void Example_8_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex8, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_8_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_8_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<OrderedCollectionPage<Note, ActivityStreamsBase>>(SerializedJson.Examples.Example_8_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex8);
		}
	}
}
