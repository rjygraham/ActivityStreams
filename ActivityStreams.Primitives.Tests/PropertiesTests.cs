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
	public class PropertiesTests
	{
		private readonly ActivityStreamsObject ex61 = new ActivityStreamsObject("http://example.org/foo")
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Foo"
		};

		[Fact]
		public void Example_61_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex61, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_61_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_61_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<ActivityStreamsObject>(SerializedJson.Examples.Example_61_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex61);
		}

		private readonly ActivityStreamsObject ex62 = new ActivityStreamsObject(null, "http://example.org/Foo")
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A foo"
		};

		[Fact]
		public void Example_62_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex62, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_62_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_62_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<ActivityStreamsObject>(SerializedJson.Examples.Example_62_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex62);
		}

		private readonly Offer ex63 = new Offer
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered the Foo object",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/foo")
		};

		[Fact]
		public void Example_63_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex63, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_63_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_63_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_63_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex63);
		}

		private readonly Offer ex64 = new Offer
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered the Foo object",
			Actor = new Person
			{
				Id = "http://sally.example.org",
				Summary = "Sally"
			},
			Object = new ActivityStreamsObject("http://example.org/foo")
		};

		[Fact]
		public void Example_64_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex64, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_64_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_64_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_64_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex64);
		}

		private readonly Offer ex65 = new Offer
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally and Joe offered the Foo object",
			Actor = new ActivityStreamsBase[]
			{
				new ActivityStreamsObject("http://joe.example.org"),
				new Person
				{
					Id = "http://sally.example.org",
					Name = "Sally"
				}
			},
			Object = new ActivityStreamsObject("http://example.org/foo")
		};

		[Fact]
		public void Example_65_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex65, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_65_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_65_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_65_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex65);
		}

		private readonly Note ex66 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Have you seen my cat?",
			Attachment = new Image
			{
				Content = "This is what he looks like.",
				Url = new Link("http://example.org/cat.jpeg")
			}
		};

		[Fact]
		public void Example_66_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex66, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_66_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_66_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_66_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex66);
		}

		private readonly Image ex67 = new Image
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "My cat taking a nap",
			Url = new Link("http://example.org/cat.jpeg"),
			AttributedTo = new Person { Name = "Sally" }
		};

		[Fact]
		public void Example_67_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex67, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_67_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_67_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Image>(SerializedJson.Examples.Example_67_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex67);
		}

		private readonly Image ex68 = new Image
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "My cat taking a nap",
			Url = new Link("http://example.org/cat.jpeg"),
			AttributedTo = new ActivityStreamsBase[]
			{
				new ActivityStreamsObject("http://joe.example.org"),
				new Person { Name = "Sally" }
			}
		};

		[Fact]
		public void Example_68_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex68, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_68_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_68_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Image>(SerializedJson.Examples.Example_68_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex68);
		}

		private readonly Note ex69 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Holiday announcement",
			Content = "Thursday will be a company-wide holiday. Enjoy your day off!",
			Audience = new ActivityStreamsObject(null, "http://example.org/Organization") { Name = "ExampleCo LLC" }
		};

		[Fact]
		public void Example_69_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex69, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_69_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_69_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_69_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex69);
		}

		private readonly Offer ex70 = new Offer
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered a post to John",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1"),
			Target = new ActivityStreamsObject("http://john.example.org"),
			Bcc = new ActivityStreamsObject("http://joe.example.org")
		};

		[Fact]
		public void Example_70_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex70, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_70_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_70_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_70_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex70);
		}

		private readonly Offer ex71 = new Offer
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered a post to John",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1"),
			Target = new ActivityStreamsObject("http://john.example.org"),
			Bto = new ActivityStreamsObject("http://joe.example.org")
		};

		[Fact]
		public void Example_71_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex71, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_71_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_71_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_71_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex71);
		}

		private readonly Offer ex72 = new Offer
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered a post to John",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1"),
			Target = new ActivityStreamsObject("http://john.example.org"),
			Cc = new ActivityStreamsObject("http://joe.example.org")
		};

		[Fact]
		public void Example_72_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex72, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_72_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_72_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_72_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex72);
		}

		private readonly Collection<ActivityStreamsBase> ex73 = new Collection<ActivityStreamsBase>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Activities in context 1",
			Items = new ActivityStreamsBase[]
			{
				new Offer
				{
					Actor = new ActivityStreamsObject("http://sally.example.org"),
					Object = new ActivityStreamsObject("http://example.org/posts/1"),
					Target = new ActivityStreamsObject("http://john.example.org"),
					Context = new ActivityStreamsObject("http://example.org/contexts/1")
				},
				new Like
				{
					Actor = new ActivityStreamsObject("http://joe.example.org"),
					Object = new ActivityStreamsObject("http://example.org/posts/2"),
					Context = new ActivityStreamsObject("http://example.org/contexts/1")
				}
			}
		};

		[Fact]
		public void Example_73_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex73, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_73_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_73_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<ActivityStreamsBase>>(SerializedJson.Examples.Example_73_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex73);
		}

		private readonly Collection<Link> ex74 = new Collection<Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's blog posts",
			TotalItems = 3,
			Current = new Link("http://example.org/collection"),
			Items = new Link[]
			{
				new Link("http://example.org/posts/1"),
				new Link("http://example.org/posts/2"),
				new Link("http://example.org/posts/3")
			}
		};

		[Fact]
		public void Example_74_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex74, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_74_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_74_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Link>>(SerializedJson.Examples.Example_74_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex74);
		}

		private readonly Collection<Link> ex75 = new Collection<Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's blog posts",
			TotalItems = 3,
			Current = new Link
			{
				Summary = "Most Recent Items",
				Href = "http://example.org/collection"
			},
			Items = new Link[]
			{
				new Link("http://example.org/posts/1"),
				new Link("http://example.org/posts/2"),
				new Link("http://example.org/posts/3")
			}
		};

		[Fact]
		public void Example_75_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex75, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_75_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_75_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Link>>(SerializedJson.Examples.Example_75_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex75);
		}

		private readonly Collection<Link> ex76 = new Collection<Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's blog posts",
			TotalItems = 3,
			First = new Link("http://example.org/collection?page=0")
		};

		[Fact]
		public void Example_76_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex76, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_76_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_76_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Link>>(SerializedJson.Examples.Example_76_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex76);
		}

		private readonly Collection<Link> ex77 = new Collection<Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's blog posts",
			TotalItems = 3,
			First = new Link
			{
				Href = "http://example.org/collection?page=0",
				Summary = "First Page"
			}
		};

		[Fact]
		public void Example_77_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex77, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_77_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_77_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Link>>(SerializedJson.Examples.Example_77_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex77);
		}

		private readonly Note ex78 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Content = "This is all there is.",
			Generator = new Application { Name = "Exampletron 3000" }
		};

		[Fact]
		public void Example_78_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex78, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_78_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_78_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_78_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex78);
		}

		private readonly Note ex79 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Content = "This is all there is.",
			Icon = new Image
			{
				Name = "Note icon",
				Url = new Link("http://example.org/note.png"),
				Height = 16,
				Width = 16
			}
		};

		[Fact]
		public void Example_79_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex79, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_79_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_79_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_79_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex79);
		}

		private readonly Note ex80 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Content = "A simple note",
			Icon = new ActivityStreamsBase[]
			{
				new Image
				{
					Summary = "Note (16x16)",
					Url = new Link("http://example.org/note1.png"),
					Height = 16,
					Width = 16
				},
				new Image
				{
					Summary = "Note (32x32)",
					Url = new Link("http://example.org/note2.png"),
					Height = 32,
					Width = 32
				}
			}
		};

		[Fact]
		public void Example_80_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex80, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_80_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_80_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_80_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex80);
		}

		private readonly Note ex81 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A simple note",
			Content = "This is all there is.",
			Image = new Image
			{
				Name = "A Cat",
				Url = new Link("http://example.org/cat.png")
			}
		};

		[Fact]
		public void Example_81_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex81, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_81_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_81_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_81_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex81);
		}

		private readonly Note ex82 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A simple note",
			Content = "This is all there is.",
			Image = new ActivityStreamsBase[]
			{
				new Image
				{
					Name = "Cat 1",
					Url = new Link("http://example.org/cat1.png")
				},
				new Image
				{
					Name = "Cat 2",
					Url = new Link("http://example.org/cat2.png")
				}
			}
		};

		[Fact]
		public void Example_82_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex82, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_82_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_82_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_82_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex82);
		}

		private readonly Note ex83 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Content = "This is all there is.",
			InReplyTo = new Note
			{
				Summary = "Previous note",
				Content = "What else is there?"
			}
		};

		[Fact]
		public void Example_83_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex83, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_83_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_83_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_83_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex83);
		}

		private readonly Note ex84 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Content = "This is all there is.",
			InReplyTo = new ActivityStreamsObject("http://example.org/posts/1")
		};

		[Fact]
		public void Example_84_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex84, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_84_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_84_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_84_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex84);
		}

		private readonly Listen ex85 = new Listen
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally listened to a piece of music on the Acme Music Service",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/foo.mp3"),
			Instrument = new Service { Name = "Acme Music Service" }
		};

		[Fact]
		public void Example_85_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex85, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_85_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_85_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Listen>(SerializedJson.Examples.Example_85_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex85);
		}

		private readonly Collection<Link> ex86 = new Collection<Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A collection",
			TotalItems = 3,
			Last = new Link("http://example.org/collection?page=1")
		};

		[Fact]
		public void Example_86_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex86, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_86_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_86_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Link>>(SerializedJson.Examples.Example_86_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex86);
		}

		private readonly Collection<Link> ex87 = new Collection<Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A collection",
			TotalItems = 5,
			Last = new Link
			{
				Summary = "Last Page",
				Href = "http://example.org/collection?page=1"
			}
		};

		[Fact]
		public void Example_87_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex87, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_87_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_87_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Link>>(SerializedJson.Examples.Example_87_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex87);
		}

		private readonly Person ex88 = new Person
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Sally",
			Location = new Place
			{
				Name = "Over the Arabian Sea, east of Socotra Island Nature Sanctuary",
				Longitude = 12.34,
				Latitude = 56.78,
				Altitude = 90,
				Units = Units.Meters
			}
		};

		[Fact]
		public void Example_88_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex88, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_88_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_88_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Person>(SerializedJson.Examples.Example_88_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex88);
		}

		private readonly Collection<Note> ex89 = new Collection<Note>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's notes",
			TotalItems = 2,
			Items = new Note[]
			{
				new Note { Name = "Reminder for Going-Away Party" },
				new Note { Name = "Meeting 2016-11-17" }
			}
		};

		[Fact]
		public void Example_89_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex89, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_89_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_89_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Note>>(SerializedJson.Examples.Example_89_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex89);
		}

		private readonly OrderedCollection<Note> ex90 = new OrderedCollection<Note>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's notes",
			TotalItems = 2,
			OrderedItems = new List<Note>
			{
				new Note { Name = "Meeting 2016-11-17" },
				new Note { Name = "Reminder for Going-Away Party" }
			}
		};

		[Fact]
		public void Example_90_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex90, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_90_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_90_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<OrderedCollection<Note>>(SerializedJson.Examples.Example_90_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex90);
		}

		private readonly Question ex91 = new Question
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "What is the answer?",
			OneOf = new ActivityStreamsBase[]
			{
				new Note { Name = "Option A" },
				new Note { Name = "Option B" }
			}
		};

		[Fact]
		public void Example_91_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex91, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_91_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_91_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Question>(SerializedJson.Examples.Example_91_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex91);
		}

		private readonly Question ex92 = new Question
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "What is the answer?",
			AnyOf = new ActivityStreamsBase[]
			{
				new Note { Name = "Option A" },
				new Note { Name = "Option B" }
			}
		};

		[Fact]
		public void Example_92_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex92, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_92_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_92_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Question>(SerializedJson.Examples.Example_92_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex92);
		}

		private readonly Question ex93 = new Question
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "What is the answer?",
			Closed = new ActivityStreamsDateTime(DateTimeOffset.Parse("2016-05-10T00:00:00Z", null).DateTime)
		};

		[Fact]
		public void Example_93_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex93, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_93_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_93_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Question>(SerializedJson.Examples.Example_93_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex93);
		}

		private readonly Move ex94 = new Move
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally moved a post from List A to List B",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1"),
			Target = new Collection<Link> { Name = "List B" },
			Origin = new Collection<Link> { Name = "List A" }
		};

		[Fact]
		public void Example_94_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex94, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_94_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_94_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Move>(SerializedJson.Examples.Example_94_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex94);
		}

		private readonly CollectionPage<Link, Link> ex95 = new CollectionPage<Link, Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Page 2 of Sally's blog posts",
			Next = new Link("http://example.org/collection?page=2"),
			Items = new Link[]
			{
				new Link("http://example.org/posts/1"),
				new Link("http://example.org/posts/2"),
				new Link("http://example.org/posts/3")
			}
		};

		[Fact]
		public void Example_95_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex95, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_95_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_95_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<CollectionPage<Link, Link>>(SerializedJson.Examples.Example_95_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex95);
		}

		private readonly CollectionPage<Link, Link> ex96 = new CollectionPage<Link, Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Page 2 of Sally's blog posts",
			Next = new Link()
			{
				Name = "Next Page",
				Href = "http://example.org/collection?page=2"
			},
			Items = new Link[]
			{
				new Link("http://example.org/posts/1"),
				new Link("http://example.org/posts/2"),
				new Link("http://example.org/posts/3")
			}
		};

		[Fact]
		public void Example_96_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex96, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_96_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_96_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<CollectionPage<Link, Link>>(SerializedJson.Examples.Example_96_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex96);
		}

		private readonly Like ex97 = new Like
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally liked a post",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1")
		};

		[Fact]
		public void Example_97_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex97, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_97_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_97_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Like>(SerializedJson.Examples.Example_97_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex97);
		}

		private readonly Like ex98 = new Like
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new Note { Content = "A simple note" }
		};

		[Fact]
		public void Example_98_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex98, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_98_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_98_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Like>(SerializedJson.Examples.Example_98_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex98);
		}

		private readonly Like ex99 = new Like
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally liked a note",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject[]
			{
				new ActivityStreamsObject("http://example.org/posts/1"),
				new Note
				{
					Summary = "A simple note",
					Content = "That is a tree."
				}
			}
		};

		[Fact]
		public void Example_99_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex99, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_99_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_99_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Like>(SerializedJson.Examples.Example_99_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex99);
		}

		private readonly CollectionPage<Link, Link> ex100 = new CollectionPage<Link, Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Page 1 of Sally's blog posts",
			Prev = new Link("http://example.org/collection?page=1"),
			Items = new Link[]
			{
				new Link("http://example.org/posts/1"),
				new Link("http://example.org/posts/2"),
				new Link("http://example.org/posts/3")
			}
		};

		[Fact]
		public void Example_100_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex100, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_100_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_100_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<CollectionPage<Link, Link>>(SerializedJson.Examples.Example_100_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex100);
		}

		private readonly CollectionPage<Link, Link> ex101 = new CollectionPage<Link, Link>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Page 1 of Sally's blog posts",
			Prev = new Link { Href = "http://example.org/collection?page=1", Name = "Previous Page" },
			Items = new Link[]
			{
				new Link("http://example.org/posts/1"),
				new Link("http://example.org/posts/2"),
				new Link("http://example.org/posts/3")
			}
		};

		[Fact]
		public void Example_101_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex101, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_101_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_101_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<CollectionPage<Link, Link>>(SerializedJson.Examples.Example_101_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex101);
		}

		private readonly Video ex102 = new Video
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Cool New Movie",
			Duration = XmlConvert.ToTimeSpan("PT2H30M"),
			Preview = new Video
			{
				Name = "Trailer",
				Duration = XmlConvert.ToTimeSpan("PT1M"),
				Url =  new Link("http://example.org/trailer.mkv") { MediaType = "video/mkv" }
			}
		};

		[Fact]
		public void Example_102_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex102, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_102_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_102_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<CollectionPage<Link, Link>>(SerializedJson.Examples.Example_102_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex102);
		}

		private readonly Activity ex103 = new Activity(new ActivityStreamsObject(nameof(Activity)), new ActivityStreamsObject("http://www.verbs.example/Check"))
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally checked that her flight was on time",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/flights/1"),
			Result = new ActivityStreamsObject(null, "http://www.types.example/flightstatus") { Name = "On Time" }
		};

		[Fact]
		public void Example_103_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex103, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_103_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_103_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Activity>(SerializedJson.Examples.Example_103_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex103);
		}

		private readonly Note ex104 = new Note()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Id = "http://www.test.example/notes/1",
			Content = "I am fine.",
			Replies = new Collection<ActivityStreamsObject>
			{
				TotalItems = 1,
				Items = new Note
				{
					Summary = "A response to the note",
					Content = "I am glad to hear it.",
					InReplyTo = new ActivityStreamsObject("http://www.test.example/notes/1")
				}
			}
		};

		[Fact]
		public void Example_104_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex104, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_104_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_104_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_104_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex104);
		}

		private readonly Image ex105 = new Image()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Picture of Sally",
			Url = new Link("http://example.org/sally.jpg"),
			Tag = new Person { Id = "http://sally.example.org", Name = "Sally" }
		};

		[Fact]
		public void Example_105_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex105, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_105_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_105_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Image>(SerializedJson.Examples.Example_105_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex105);
		}

		private readonly Offer ex106 = new Offer()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered the post to John",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1"),
			Target = new ActivityStreamsObject("http://john.example.org")
		};

		[Fact]
		public void Example_106_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex106, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_106_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_106_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_106_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex106);
		}

		private readonly Offer ex107 = new Offer()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered the post to John",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1"),
			Target = new Person { Name = "John" }
		};

		[Fact]
		public void Example_107_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex107, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_107_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_107_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_107_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex107);
		}

		private readonly Offer ex108 = new Offer()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered the post to John",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1"),
			Target = new ActivityStreamsObject("http://john.example.org"),
			To = new ActivityStreamsObject("http://joe.example.org")
		};

		[Fact]
		public void Example_108_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex108, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_108_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_108_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_108_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex108);
		}

		private readonly Document ex109 = new Document()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "4Q Sales Forecast",
			Url = new Link("http://example.org/4q-sales-forecast.pdf")
		};

		[Fact]
		public void Example_109_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex109, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_109_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_109_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Document>(SerializedJson.Examples.Example_109_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex109);
		}

		private readonly Document ex110 = new Document()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "4Q Sales Forecast",
			Url = new Link { Href = "http://example.org/4q-sales-forecast.pdf" }
		};

		[Fact]
		public void Example_110_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex110, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_110_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_110_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Document>(SerializedJson.Examples.Example_110_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex110);
		}

		private readonly Document ex111 = new Document()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "4Q Sales Forecast",
			Url = new Link[]
			{ 
				new Link { Href = "http://example.org/4q-sales-forecast.pdf", MediaType = "application/pdf" },
				new Link { Href = "http://example.org/4q-sales-forecast.html", MediaType = "text/html" }
			}
		};

		[Fact]
		public void Example_111_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex111, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_111_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_111_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Document>(SerializedJson.Examples.Example_111_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex111);
		}

		private readonly Place ex112 = new Place()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Liu Gu Lu Cun, Pingdu, Qingdao, Shandong, China",
			Latitude = 36.75,
			Longitude = 119.7667,
			Accuracy = 94.5
		};

		[Fact]
		public void Example_112_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex112, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_112_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_112_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_112_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex112);
		}

		private readonly Place ex113 = new Place()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Fresno Area",
			Altitude = 15.0,
			Latitude = 36.75,
			Longitude = 119.7667,
			Units = Units.Miles
		};

		[Fact]
		public void Example_113_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex113, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_113_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_113_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_113_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex113);
		}

		private readonly Note ex114 = new Note()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Content = "A <em>simple</em> note"
		};

		[Fact]
		public void Example_114_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex114, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_114_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_114_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_114_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex114);
		}

		private readonly Note ex115 = new Note()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Content = new Dictionary<string, string>
			{
				{ "en", "A <em>simple</em> note"},
				{ "es", "Una nota <em>sencilla</em>" },
				{ "zh-Hans", "一段<em>简单的</em>笔记" }
			}
		};

		[Fact]
		public void Example_115_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex115, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_115_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_115_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_115_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex115);
		}

		private readonly Note ex116 = new Note()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			MediaType = "text/markdown",
			Content = "## A simple note\nA simple markdown `note`"
		};

		[Fact]
		public void Example_116_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex116, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_116_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_116_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_116_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex116);
		}

		private readonly Note ex117 = new Note()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A simple note"
		};

		[Fact]
		public void Example_117_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex117, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_117_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_117_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_117_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex117);
		}

		private readonly Note ex118 = new Note()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = new Dictionary<string, string>
			{
				{ "en", "A simple note" },
				{ "es", "Una nota sencilla" },
				{ "zh-Hans", "一段简单的笔记" }
			}
		};

		[Fact]
		public void Example_118_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex118, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_118_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_118_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_118_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex118);
		}

		private readonly Video ex119 = new Video()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Birds Flying",
			Url = new Link("http://example.org/video.mkv"),
			Duration = XmlConvert.ToTimeSpan("PT2H")
		};

		[Fact]
		public void Example_119_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex119, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_119_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_119_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Video>(SerializedJson.Examples.Example_119_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex119);
		}

		private readonly Link ex120 = new Link()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Href = "http://example.org/image.png",
			Height = 100,
			Width = 100
		};

		[Fact]
		public void Example_120_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex120, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_120_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_120_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Link>(SerializedJson.Examples.Example_120_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex120);
		}

		private readonly Link ex121 = new Link()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Href = "http://example.org/abc",
			MediaType = "text/html",
			Name = "Previous"
		};

		[Fact]
		public void Example_121_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex121, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_121_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_121_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Link>(SerializedJson.Examples.Example_121_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex121);
		}

		private readonly Link ex122 = new Link()
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Href = "http://example.org/abc",
			HrefLang = "en",
			MediaType = "text/html",
			Name = "Previous"
		};

		[Fact]
		public void Example_122_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex122, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_122_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_122_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Link>(SerializedJson.Examples.Example_122_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex122);
		}

		private readonly CollectionPage<Note, ActivityStreamsObject> ex123 = new CollectionPage<Note, ActivityStreamsObject>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Page 1 of Sally's notes",
			Id = "http://example.org/collection?page=1",
			PartOf = new ActivityStreamsObject("http://example.org/collection"),
			Items = new Note[]
			{
				new Note { Name = "Pizza Toppings to Try" },
				new Note { Name = "Thought about California" },
			}
		};

		[Fact]
		public void Example_123_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex123, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_123_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_123_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<CollectionPage<Note, Link>>(SerializedJson.Examples.Example_123_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex123);
		}

		private readonly Place ex124 = new Place
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Fresno Area",
			Latitude = 36.75,
			Longitude = 119.7667,
			Radius = 15,
			Units = Units.Miles
		};

		[Fact]
		public void Example_124_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex124, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_124_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_124_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_124_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex124);
		}

		private readonly Place ex125 = new Place
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Fresno Area",
			Latitude = 36.75,
			Longitude = 119.7667,
			Radius = 15,
			Units = Units.Miles
		};

		[Fact]
		public void Example_125_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex125, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_125_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_125_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_125_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex125);
		}

		private readonly Link ex126 = new Link
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Next",
			Href = "http://example.org/abc",
			HrefLang = "en",
			MediaType = "text/html",
		};

		[Fact]
		public void Example_126_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex126, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_126_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_126_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Link>(SerializedJson.Examples.Example_126_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex126);
		}

		private readonly Event ex127 = new Event
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Going-Away Party for Jim",
			StartTime = DateTime.Parse("2014-12-31T23:00:00-08:00"),
			EndTime = DateTime.Parse("2015-01-01T06:00:00-08:00")
		};

		[Fact]
		public void Example_127_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex127, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_127_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_127_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Event>(SerializedJson.Examples.Example_127_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex127);
		}

		private readonly Note ex128 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "A simple note",
			Content = "Fish swim.",
			Published = DateTimeOffset.Parse("2014-12-12T12:12:12Z", null).DateTime
		};

		[Fact]
		public void Example_128_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex128, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_128_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_128_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_128_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex128);
		}

		private readonly Event ex129 = new Event
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Going-Away Party for Jim",
			StartTime = DateTime.Parse("2014-12-31T23:00:00-08:00"),
			EndTime = DateTime.Parse("2015-01-01T06:00:00-08:00")
		};

		[Fact]
		public void Example_129_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex129, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_129_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_129_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Event>(SerializedJson.Examples.Example_129_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex129);
		}

		private readonly Place ex130 = new Place
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Fresno Area",
			Latitude = 36.75,
			Longitude = 119.7667,
			Radius = 15,
			Units = Units.Miles
		};

		[Fact]
		public void Example_130_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex130, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_130_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_130_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_130_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex130);
		}

		private readonly Link ex131 = new Link
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Preview",
			Href = "http://example.org/abc",
			HrefLang = "en",
			MediaType = "text/html",
			Rel = new string[] { "canonical", "preview" }
		};

		[Fact]
		public void Example_131_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex131, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_131_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_131_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Link>(SerializedJson.Examples.Example_131_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex131);
		}

		private readonly OrderedCollectionPage<Note, ActivityStreamsObject> ex132 = new OrderedCollectionPage<Note, ActivityStreamsObject>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Page 1 of Sally's notes",
			StartIndex = 0,
			OrderedItems = new List<Note>
			{
				new Note { Name = "Density of Water" },
				new Note { Name = "Air Mattress Idea" }
			}
		};

		[Fact]
		public void Example_132_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex132, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_132_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_132_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<OrderedCollectionPage<Note, ActivityStreamsObject>>(SerializedJson.Examples.Example_132_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex132);
		}

		private readonly Note ex133 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Cane Sugar Processing",
			Summary = "A simple <em>note</em>"
		};

		[Fact]
		public void Example_133_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex133, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_133_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_133_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_133_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex133);
		}

		private readonly Note ex134 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Cane Sugar Processing",
			Summary = new Dictionary<string, string>
			{
				{ "en", "A simple <em>note</em>" },
				{ "es", "Una <em>nota</em> sencilla" },
				{  "zh-Hans", "一段<em>简单的</em>笔记" }
			}
		};

		[Fact]
		public void Example_134_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex134, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_134_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_134_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_134_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex134);
		}

		private readonly Collection<Note> ex135 = new Collection<Note>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's notes",
			TotalItems = 2,
			Items = new Note[]
			{
				new Note { Name = "Which Staircase Should I Use" },
				new Note { Name = "Something to Remember" }
			}
		};

		[Fact]
		public void Example_135_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex135, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_135_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_135_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Note>>(SerializedJson.Examples.Example_135_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex135);
		}

		private readonly Place ex136 = new Place
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Fresno Area",
			Latitude = 36.75,
			Longitude = 119.7667,
			Radius = 15,
			Units = Units.Miles
		};

		[Fact]
		public void Example_136_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex136, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_136_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_136_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_136_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex136);
		}

		private readonly Note ex137 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "Cranberry Sauce Idea",
			Content = "Mush it up so it does not have the same shape as the can.",
			Updated = DateTimeOffset.Parse("2014-12-12T12:12:12Z", null).DateTime
		};

		[Fact]
		public void Example_137_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex137, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_137_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_137_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_137_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex137);
		}

		private readonly Link ex138 = new Link
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Href = "http://example.org/image.png",
			Height = 100,
			Width = 100
		};

		[Fact]
		public void Example_138_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex138, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_138_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_138_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Link>(SerializedJson.Examples.Example_138_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex138);
		}

		private readonly Relationship ex139 = new Relationship
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally is an acquaintance of John's",
			Subject = new Person { Name = "Sally" },
			Relation = new Relationship("http://purl.org/vocab/relationship/acquaintanceOf"),
			Object = new Person { Name = "John" }
		};

		[Fact]
		public void Example_139_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex139, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_139_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_139_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Relationship>(SerializedJson.Examples.Example_139_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex139);
		}

		private readonly Relationship ex140 = new Relationship
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally is an acquaintance of John's",
			Subject = new Person { Name = "Sally" },
			Relation = new Relationship("http://purl.org/vocab/relationship/acquaintanceOf"),
			Object = new Person { Name = "John" }
		};

		[Fact]
		public void Example_140_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex140, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_140_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_140_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Relationship>(SerializedJson.Examples.Example_140_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex140);
		}

		private readonly Profile ex141 = new Profile
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's profile",
			Describes = new Person { Name = "Sally" },
			Url = new Link ("http://sally.example.org")
		};

		[Fact]
		public void Example_141_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex141, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_141_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_141_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Profile>(SerializedJson.Examples.Example_141_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex141);
		}

		private readonly Tombstone ex142 = new Tombstone
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary ="This image has been deleted",
			FormerType = new ActivityStreamsObject("Image"),
			Url = new Link("http://example.org/image/2")
		};

		[Fact]
		public void Example_142_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex142, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_142_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_142_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Tombstone>(SerializedJson.Examples.Example_142_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex142);
		}

		private readonly Tombstone ex143 = new Tombstone
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "This image has been deleted",
			Deleted = DateTimeOffset.Parse("2016-05-03T00:00:00Z", null).DateTime
		};

		[Fact]
		public void Example_143_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex143, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_143_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_143_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Tombstone>(SerializedJson.Examples.Example_143_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex143);
		}
	}
}
