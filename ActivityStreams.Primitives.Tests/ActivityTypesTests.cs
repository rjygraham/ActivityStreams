using FluentAssertions;
using FluentAssertions.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using Xunit;

namespace ActivityStreams.Primitives.Tests
{
	public class ActivityTypesTests
	{
		private readonly Accept ex9 = new Accept
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally accepted an invitation to a party",
			Actor = new Person { Name = "Sally" },
			Object = new Invite
			{
				Actor = new Link("http://john.example.org"),
				Object = new Event { Name ="Going-Away Party for Jim" }
			}
		};

		[Fact]
		public void Example_9_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex9, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_9_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_9_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Accept>(SerializedJson.Examples.Example_9_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex9);
		}

		private readonly Accept ex10 = new Accept
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally accepted Joe into the club",
			Actor = new Person { Name = "Sally" },
			Object = new Person { Name = "Joe" },
			Target = new Group { Name = "The Club" }
		};

		[Fact]
		public void Example_10_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex10, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_10_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_10_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Accept>(SerializedJson.Examples.Example_10_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex10);
		}

		private readonly TentativeAccept ex11 = new TentativeAccept
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary ="Sally tentatively accepted an invitation to a party",
			Actor = new Person { Name = "Sally" },
			Object = new Invite
			{
				Actor = new Link("http://john.example.org"),
				Object = new Event { Name = "Going-Away Party for Jim" }
			}
		};

		[Fact]
		public void Example_11_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex11, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_11_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_11_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Accept>(SerializedJson.Examples.Example_11_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex11);
		}

		private readonly Add ex12 = new Add
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally added an object",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/abc")
		};

		[Fact]
		public void Example_12_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex12, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_12_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_12_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Add>(SerializedJson.Examples.Example_12_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex12);
		}

		private readonly Add ex13 = new Add
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally added a picture of her cat to her cat picture collection",
			Actor = new Person { Name = "Sally" },
			Object = new Image
			{
				Name = "A picture of my cat",
				Url = new Link("http://example.org/img/cat.png")
			},
			Origin = new Collection<ActivityStreamsObject> { Name = "Camera Roll" },
			Target = new Collection<ActivityStreamsObject> { Name = "My Cat Pictures" }
		};

		[Fact]
		public void Example_13_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex13, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_13_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_13_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Add>(SerializedJson.Examples.Example_13_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex13);
		}

		private readonly Arrive ex14 = new Arrive
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally arrived at work",
			Actor = new Person { Name = "Sally" },
			Location = new Place { Name = "Work" },
			Origin = new Place { Name = "Home" }
		};

		[Fact]
		public void Example_14_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex14, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_14_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_14_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Arrive>(SerializedJson.Examples.Example_14_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex14);
		}

		private readonly Create ex15 = new Create
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally created a note",
			Actor = new Person { Name = "Sally" },
			Object = new Note
			{
				Name = "A Simple Note",
				Content = "This is a simple note"
			}
		};

		[Fact]
		public void Example_15_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex15, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_15_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_15_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Create>(SerializedJson.Examples.Example_15_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex15);
		}

		private readonly Delete ex16 = new Delete
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally deleted a note",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/notes/1"),
			Origin = new Collection<ActivityStreamsObject> { Name ="Sally's Notes" }
		};

		[Fact]
		public void Example_16_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex16, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_16_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_16_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Delete>(SerializedJson.Examples.Example_16_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex16);
		}

		private readonly Follow ex17 = new Follow
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally followed John",
			Actor = new Person { Name = "Sally" },
			Object = new Person { Name = "John" }
		};

		[Fact]
		public void Example_17_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex17, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_17_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_17_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Follow>(SerializedJson.Examples.Example_17_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex17);
		}

		private readonly Ignore ex18 = new Ignore
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally ignored a note",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/notes/1")
		};

		[Fact]
		public void Example_18_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex18, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_18_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_18_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Ignore>(SerializedJson.Examples.Example_18_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex18);
		}

		private readonly Join ex19 = new Join
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally joined a group",
			Actor = new Person { Name = "Sally" },
			Object = new Group { Name = "A Simple Group" }
		};

		[Fact]
		public void Example_19_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex19, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_19_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_19_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Join>(SerializedJson.Examples.Example_19_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex19);
		}

		private readonly Leave ex20 = new Leave
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally left work",
			Actor = new Person { Name = "Sally" },
			Object = new Place { Name = "Work" }
		};

		[Fact]
		public void Example_20_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex20, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_20_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_20_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Leave>(SerializedJson.Examples.Example_20_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex20);
		}

		private readonly Leave ex21 = new Leave
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally left a group",
			Actor = new Person { Name = "Sally" },
			Object = new Group { Name = "A Simple Group" }
		};

		[Fact]
		public void Example_21_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex21, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_21_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_21_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Leave>(SerializedJson.Examples.Example_21_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex21);
		}

		private readonly Like ex22 = new Like
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally liked a note",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/notes/1")
		};

		[Fact]
		public void Example_22_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex22, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_22_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_22_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Like>(SerializedJson.Examples.Example_22_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex22);
		}

		private readonly Offer ex23 = new Offer
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally offered 50% off to Lewis",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject(null, "http://www.types.example/ProductOffer") { Name = "50% Off!" },
			Target = new Person { Name = new StringMap("Lewis") }
		};

		[Fact]
		public void Example_23_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex23, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_23_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_23_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_23_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex23);
		}

		private readonly Invite ex24 = new Invite
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally invited John and Lisa to a party",
			Actor = new Person { Name = "Sally" },
			Object = new Event { Name = "A Party" },
			Target = new Person[]
			{
				new Person { Name = new StringMap("John") },
				new Person { Name = new StringMap("Lisa") }
			}
		};

		[Fact]
		public void Example_24_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex24, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_24_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_24_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Invite>(SerializedJson.Examples.Example_24_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex24);
		}

		private readonly Reject ex25 = new Reject
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally rejected an invitation to a party",
			Actor = new Person { Name = "Sally" },
			Object = new Invite
			{
				Actor = new ActivityStreamsObject("http://john.example.org"),
				Object = new Event { Name = "Going-Away Party for Jim" }
			}
		};

		[Fact]
		public void Example_25_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex25, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_25_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_25_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Reject>(SerializedJson.Examples.Example_25_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex25);
		}

		private readonly TentativeReject ex26 = new TentativeReject
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally tentatively rejected an invitation to a party",
			Actor = new Person { Name = "Sally" },
			Object = new Invite
			{
				Actor = new ActivityStreamsObject("http://john.example.org"),
				Object = new Event { Name = "Going-Away Party for Jim" }
			}
		};

		[Fact]
		public void Example_26_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex26, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_26_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_26_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<TentativeReject>(SerializedJson.Examples.Example_26_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex26);
		}

		private readonly Remove ex27 = new Remove
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally removed a note from her notes folder",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/notes/1"),
			Target = new Collection<Link> { Name = "Notes Folder" }
		};

		[Fact]
		public void Example_27_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex27, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_27_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_27_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Remove>(SerializedJson.Examples.Example_27_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex27);
		}

		private readonly Remove ex28 = new Remove
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "The moderator removed Sally from a group",
			Actor = new ActivityStreamsObject(null, "http://example.org/Role") { Name = "The Moderator" },
			Object = new Person { Name = "Sally" },
			Origin = new Group { Name = "A Simple Group" }
		};

		[Fact]
		public void Example_28_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex28, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_28_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_28_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Remove>(SerializedJson.Examples.Example_28_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex28);
		}

		private readonly Undo ex29 = new Undo
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally retracted her offer to John",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new Offer
			{
				Actor = new ActivityStreamsObject("http://sally.example.org"),
				Object = new ActivityStreamsObject("http://example.org/posts/1"),
				Target = new ActivityStreamsObject("http://john.example.org")
			}
		};

		[Fact]
		public void Example_29_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex29, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_29_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_29_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Undo>(SerializedJson.Examples.Example_29_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex29);
		}

		private readonly Update ex30 = new Update
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally updated her note",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/notes/1")
		};

		[Fact]
		public void Example_30_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex30, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_30_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_30_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Update>(SerializedJson.Examples.Example_30_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex30);
		}

		private readonly View ex31 = new View
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally read an article",
			Actor = new Person { Name = "Sally" },
			Object = new Article { Name = "What You Should Know About Activity Streams" }
		};

		[Fact]
		public void Example_31_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex31, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_31_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_31_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<View>(SerializedJson.Examples.Example_31_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex31);
		}

		private readonly Listen ex32 = new Listen
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally listened to a piece of music",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/music.mp3")
		};

		[Fact]
		public void Example_32_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex32, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_32_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_32_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Listen>(SerializedJson.Examples.Example_32_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex32);
		}

		private readonly Read ex33 = new Read
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally read a blog post",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/posts/1")
		};

		[Fact]
		public void Example_33_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex33, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_33_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_33_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Read>(SerializedJson.Examples.Example_33_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex33);
		}

		private readonly Move ex34 = new Move
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally moved a post from List A to List B",
			Actor = new Person { Name = "Sally" },
			Object = new ActivityStreamsObject("http://example.org/posts/1"),
			Target = new Collection<Link> { Name = "List B" },
			Origin = new Collection<Link> { Name = "List A" }
		};

		[Fact]
		public void Example_34_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex34, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_34_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_34_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Move>(SerializedJson.Examples.Example_34_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex34);
		}

		private readonly Travel ex35 = new Travel
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally went home from work",
			Actor = new Person { Name = "Sally" },
			Target = new Place { Name = "Home" },
			Origin = new Place { Name = "Work" }
		};

		[Fact]
		public void Example_35_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex35, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_35_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_35_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Travel>(SerializedJson.Examples.Example_35_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex35);
		}

		private readonly Announce ex36 = new Announce
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally announced that she had arrived at work",
			Actor = new Person { Id = "http://sally.example.org", Name = "Sally" },
			Object = new Arrive
			{
				Actor = new ActivityStreamsObject("http://sally.example.org"),
				Location = new Place { Name = "Work" }
			}
		};

		[Fact]
		public void Example_36_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex36, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_36_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_36_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Announce>(SerializedJson.Examples.Example_36_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex36);
		}

		private readonly Block ex37 = new Block
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally blocked Joe",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://joe.example.org")
		};

		[Fact]
		public void Example_37_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex37, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_37_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_37_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Block>(SerializedJson.Examples.Example_37_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex37);
		}

		private readonly Flag ex38 = new Flag
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally flagged an inappropriate note",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new Note { Content = "An inappropriate note" }
		};

		[Fact]
		public void Example_38_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex38, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_38_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_38_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Flag>(SerializedJson.Examples.Example_38_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex38);
		}

		private readonly Dislike ex39 = new Dislike
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally disliked a post",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new ActivityStreamsObject("http://example.org/posts/1")
		};

		[Fact]
		public void Example_39_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex39, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_39_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_39_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Dislike>(SerializedJson.Examples.Example_39_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex39);
		}

		private readonly Question ex40 = new Question
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "What is the answer?",
			OneOf = new Note[]
			{
				new Note { Name = "Option A" },
				new Note { Name = "Option B" }
			}
		};

		[Fact]
		public void Example_40_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex40, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_40_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_40_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Question>(SerializedJson.Examples.Example_40_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex40);
		}

		private readonly Question ex41 = new Question
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = new StringMap("What is the answer?"),
			Closed = new ActivityStreamsDateTime(DateTimeOffset.Parse("2016-05-10T00:00:00Z", null).DateTime)
		};

		[Fact]
		public void Example_41_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex41, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_41_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_41_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Question>(SerializedJson.Examples.Example_41_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex41);
		}
	}
}
