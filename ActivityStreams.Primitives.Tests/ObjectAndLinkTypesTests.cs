using FluentAssertions;
using FluentAssertions.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Xml;
using Xunit;

namespace ActivityStreams.Primitives.Tests
{
	public class ObjectAndLinkTypesTests
	{
		private readonly Relationship ex47 = new Relationship
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally is an acquaintance of John",
			Subject = new Person { Name = "Sally" },
			Relation = new Relationship("http://purl.org/vocab/relationship/acquaintanceOf"),
			Object = new Person { Name = "John" }
		};

		[Fact]
		public void Example_47_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex47, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_47_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_47_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Relationship>(SerializedJson.Examples.Example_47_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex47);
		}

		private readonly Article ex48 = new Article
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "What a Crazy Day I Had",
			Content = "<div>... you will never believe ...</div>",
			AttributedTo = new ActivityStreamsObject("http://sally.example.org")
		};

		[Fact]
		public void Example_48_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex48, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_48_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_48_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Article>(SerializedJson.Examples.Example_48_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex48);
		}

		private readonly Document ex49 = new Document
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "4Q Sales Forecast",
			Url = new Link("http://example.org/4q-sales-forecast.pdf")
		};

		[Fact]
		public void Example_49_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex49, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_49_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_49_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Document>(SerializedJson.Examples.Example_49_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex49);
		}

		private readonly Audio ex50 = new Audio
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Interview With A Famous Technologist",
			Url = new Link { Href = "http://example.org/podcast.mp3", MediaType = "audio/mp3" }
		};

		[Fact]
		public void Example_50_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex50, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_50_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_50_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Audio>(SerializedJson.Examples.Example_50_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex50);
		}

		private readonly Image ex51 = new Image
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Cat Jumping on Wagon",
			Url = new Link[]
			{
				new Link
				{
					 Href = "http://example.org/image.jpeg",
					 MediaType = "image/jpeg"
				},
				new Link
				{
					 Href = "http://example.org/image.png",
					 MediaType = "image/png"
				}
			}
		};

		[Fact]
		public void Example_51_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex51, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_51_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_51_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Image>(SerializedJson.Examples.Example_51_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex51);
		}

		private readonly Video ex52 = new Video
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Puppy Plays With Ball",
			Url = new Link("http://example.org/video.mkv"),
			Duration = XmlConvert.ToTimeSpan("PT2H")
		};

		[Fact]
		public void Example_52_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex52, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_52_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_52_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Video>(SerializedJson.Examples.Example_52_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex52);
		}

		private readonly Note ex53 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A Word of Warning",
			Content = "Looks like it is going to rain today. Bring an umbrella!"
		};

		[Fact]
		public void Example_53_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex53, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_53_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_53_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_53_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex53);
		}

		private readonly Page ex54 = new Page
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name ="Omaha Weather Report",
			Url = new Link("http://example.org/weather-in-omaha.html")
		};

		[Fact]
		public void Example_54_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex54, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_54_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_54_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Page>(SerializedJson.Examples.Example_54_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex54);
		}

		private readonly Event ex55 = new Event
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Going-Away Party for Jim",
			StartTime = DateTime.Parse("2014-12-31T23:00:00-08:00"),
			EndTime = DateTime.Parse("2015-01-01T06:00:00-08:00")
		};

		[Fact]
		public void Example_55_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex55, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_55_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_55_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Event>(SerializedJson.Examples.Example_55_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex55);
		}

		private readonly Place ex56 = new Place
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Work"
		};

		[Fact]
		public void Example_56_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex56, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_56_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_56_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_56_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex56);
		}

		private readonly Place ex57 = new Place
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Fresno Area",
			Latitude = 36.75,
			Longitude = 119.7667,
			Radius = 15,
			Units = Units.Miles
		};

		[Fact]
		public void Example_57_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex57, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_57_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_57_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_57_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex57);
		}

		private readonly Mention ex58 = new Mention
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Mention of Joe by Carrie in her note",
			Href = "http://example.org/joe",
			Name = "Joe"
		};

		[Fact]
		public void Example_58_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex58, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_58_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_58_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Mention>(SerializedJson.Examples.Example_58_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex58);
		}

		private readonly Profile ex59 = new Profile
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's Profile",
			Describes = new Person { Name = "Sally Smith" }
		};

		[Fact]
		public void Example_59_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex59, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_59_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_59_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Profile>(SerializedJson.Examples.Example_59_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex59);
		}

		private readonly OrderedCollection<ActivityStreamsBase> ex60 = new OrderedCollection<ActivityStreamsBase>
		{
			Name = "Vacation photos 2016",
			TotalItems = 3,
			OrderedItems = new List<ActivityStreamsBase>
			{
				new Image
				{
					Id = "http://image.example/1"
				},
				new Tombstone
				{
					FormerType = new Image(),
					Id = "http://image.example/2",
					Deleted = DateTimeOffset.Parse("2016-03-17T00:00:00Z", null).DateTime
				},
				new Image
				{
					Id = "http://image.example/3"
				}
			}
		};

		[Fact]
		public void Example_60_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex60, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_60_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_60_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<OrderedCollection<ActivityStreamsBase>>(SerializedJson.Examples.Example_60_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex60);
		}

	}
}
