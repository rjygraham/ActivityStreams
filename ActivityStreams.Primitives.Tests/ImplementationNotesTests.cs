using FluentAssertions;
using FluentAssertions.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using Xunit;

namespace ActivityStreams.Primitives.Tests
{
	public class ImplementationNotesTests
	{
		private readonly Collection<ActivityStreamsObject> ex144 = new Collection<ActivityStreamsObject>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Activities in Project XYZ",
			Items = new ActivityStreamsObject[]
			{
				new Create
				{
					Summary = "Sally created a note",
					Id = "http://activities.example.com/1",
					Actor = new ActivityStreamsObject("http://sally.example.org"),
					Object = new Note
					{
						Summary = "A note",
						Id = "http://notes.example.com/1",
						Content = "A note"
					},
					Context = new ActivityStreamsObject(null, "http://example.org/Project")
					{
						Name = new StringMap("Project XYZ")
					},
					Audience = new Group { Name = "Project XYZ Working Group" },
					To = new ActivityStreamsObject("http://john.example.org")
				},
				new Like
				{
					Summary = "John liked Sally's note",
					Id = "http://activities.example.com/1",
					Actor = new ActivityStreamsObject("http://john.example.org"),
					Object = new ActivityStreamsObject("http://notes.example.com/1"),
					Context = new ActivityStreamsObject(null, "http://example.org/Project")
					{
						Name = "Project XYZ"
					},
					Audience = new Group { Name = "Project XYZ Working Group" },
					To = new ActivityStreamsObject("http://sally.example.org")
				}
			}
		};

		[Fact]
		public void Example_144_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex144, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_144_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_144_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<ActivityStreamsObject>>(SerializedJson.Examples.Example_144_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex144);
		}

		private readonly Collection<Relationship> ex145 = new Collection<Relationship>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally's friends list",
			Items = new Relationship[]
			{
				new Relationship
				{
					Summary = "Sally is influenced by Joe",
					Subject = new Person { Name = "Sally" },
					Relation = new Relationship("http://purl.org/vocab/relationship/influencedBy"),
					Object = new Person { Name = "Joe" }
				},
				new Relationship
				{
					Summary = "Sally is a friend of Jane",
					Subject = new Person { Name = "Sally" },
					Relation = new Relationship("http://purl.org/vocab/relationship/friendOf"),
					Object = new Person { Name = "Jane" }
				}
			}
		};

		[Fact]
		public void Example_145_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex145, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_145_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_145_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<Relationship>>(SerializedJson.Examples.Example_145_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex145);
		}

		private readonly Create ex146 = new Create
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally became a friend of Matt",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new Relationship
			{
				Subject = new ActivityStreamsObject("http://sally.example.org"),
				Relation = new Relationship("http://purl.org/vocab/relationship/friendOf"),
				Object = new ActivityStreamsObject("http://matt.example.org"),
				StartTime = DateTimeOffset.Parse("2015-04-21T12:34:56", null).DateTime
			}
		};

		[Fact]
		public void Example_146_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex146, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_146_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_146_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Create>(SerializedJson.Examples.Example_146_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex146);
		}

		private readonly Offer ex147 = new Offer
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Id = "http://example.org/connection-requests/123",
			Summary = "Sally requested to be a friend of John",
			Actor = new ActivityStreamsObject("acct:sally@example.org"),
			Object = new Relationship
			{
				Summary = "Sally and John's friendship",
				Id = "http://example.org/connections/123",
				Subject = new ActivityStreamsObject("acct:sally@example.org"),
				Relation = new Relationship("http://purl.org/vocab/relationship/friendOf"),
				Object = new ActivityStreamsObject("acct:john@example.org")
			},
			Target = new ActivityStreamsObject("acct:john@example.org")
		};

		[Fact]
		public void Example_147_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex147, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_147_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_147_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Offer>(SerializedJson.Examples.Example_147_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex147);
		}

		private readonly Collection<ActivityStreamsObject> ex148 = new Collection<ActivityStreamsObject>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally and John's relationship history",
			Items = new ActivityStreamsObject[]
			{
				new Accept
				{
					Summary = "John accepted Sally's friend request",
					Id = "http://example.org/activities/122",
					Actor = new ActivityStreamsObject("acct:john@example.org"),
					Object = new ActivityStreamsObject("http://example.org/connection-requests/123"),
					InReplyTo = new ActivityStreamsObject("http://example.org/connection-requests/123"),
					Context = new ActivityStreamsObject("http://example.org/connections/123"),
					Result = new ActivityStreamsObject[]
					{
						new ActivityStreamsObject("http://example.org/activities/123"),
						new ActivityStreamsObject("http://example.org/activities/124"),
						new ActivityStreamsObject("http://example.org/activities/125"),
						new ActivityStreamsObject("http://example.org/activities/126")
					}
				},
				new Follow
				{
					Summary = new StringMap("John followed Sally"),
					Id = "http://example.org/activities/123",
					Actor = new ActivityStreamsObject("acct:john@example.org"),
					Object = new ActivityStreamsObject("acct:sally@example.org"),
					Context = new ActivityStreamsObject("http://example.org/connections/123")
				},
				new Follow
				{
					Summary = "Sally followed John",
					Id = "http://example.org/activities/124",
					Actor = new ActivityStreamsObject("acct:sally@example.org"),
					Object = new ActivityStreamsObject("acct:john@example.org"),
					Context = new ActivityStreamsObject("http://example.org/connections/123")
				},
				new Add
				{
					Summary = "John added Sally to his friends list",
					Id = "http://example.org/activities/125",
					Actor = new ActivityStreamsObject("acct:john@example.org"),
					Object = new ActivityStreamsObject("http://example.org/connections/123"),
					Target = new ActivityStreamsBase[]
					{ 
						new Collection<ActivityStreamsObject> { Summary = "John's Connections" }
					},
					Context = new ActivityStreamsObject("http://example.org/connections/123")
				},
				new Add
				{
					Summary = "Sally added John to her friends list",
					Id = "http://example.org/activities/126",
					Actor = new ActivityStreamsObject("acct:sally@example.org"),
					Object = new ActivityStreamsObject("http://example.org/connections/123"),
					Target = new Collection<ActivityStreamsObject> { Summary ="Sally's Connections" },
					Context = new ActivityStreamsObject("http://example.org/connections/123")
				}
			}
		};

		[Fact]
		public void Example_148_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex148, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_148_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_148_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<ActivityStreamsObject>>(SerializedJson.Examples.Example_148_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex148);
		}

		private readonly Place ex149 = new Place
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "San Francisco, CA"
		};

		[Fact]
		public void Example_149_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex149, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_149_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_149_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_149_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex149);
		}

		private readonly Place ex150 = new Place
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "San Francisco, CA",
			Longitude = 122.4167,
			Latitude = 37.7833
		};

		[Fact]
		public void Example_150_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex150, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_150_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_150_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Place>(SerializedJson.Examples.Example_150_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex150);
		}

		private readonly Question ex151 = new Question
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A question about robots",
			Id = "http://help.example.org/question/1",
			Content = "I'd like to build a robot to feed my cat. Should I use Arduino or Raspberry Pi?"
		};

		[Fact]
		public void Example_151_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex151, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_151_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_151_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Question>(SerializedJson.Examples.Example_151_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex151);
		}

		private readonly Question ex152 = new Question
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A question about robots",
			Id = "http://polls.example.org/question/1",
			Content = "I'd like to build a robot to feed my cat. Which platform is best?",
			OneOf = new ActivityStreamsBase[]
			{
				new ActivityStreamsObject { Name = "arduino" },
				new ActivityStreamsObject { Name = "raspberry pi" }
			}
		};

		[Fact]
		public void Example_152_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex152, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_152_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_152_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Question>(SerializedJson.Examples.Example_152_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex152);
		}

		private readonly ActivityStreamsObject ex153 = new ActivityStreamsObject
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			AttributedTo = new ActivityStreamsObject("http://sally.example.org"),
			InReplyTo = new ActivityStreamsObject("http://polls.example.org/question/1"),
			Name = "arduino"
		};

		[Fact]
		public void Example_153_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex153, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_153_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_153_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<ActivityStreamsObject>(SerializedJson.Examples.Example_153_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex153);
		}

		private readonly Question ex154 = new Question
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A question about robots",
			Id = "http://polls.example.org/question/1",
			Content = "I'd like to build a robot to feed my cat. Which platform is best?",
			OneOf = new ActivityStreamsBase[]
			{
				new ActivityStreamsObject { Name = "arduino" },
				new ActivityStreamsObject { Name = "raspberry pi" }
			},
			Replies = new Collection<ActivityStreamsObject>
			{
				TotalItems = 3,
				Items = new ActivityStreamsObject[]
				{
					new ActivityStreamsObject
					{
						AttributedTo = new ActivityStreamsObject("http://sally.example.org"),
						InReplyTo = new ActivityStreamsObject("http://polls.example.org/question/1"),
						Name = "arduino"
					},
					new ActivityStreamsObject
					{
						AttributedTo = new ActivityStreamsObject("http://joe.example.org"),
						InReplyTo = new ActivityStreamsObject("http://polls.example.org/question/1"),
						Name = "arduino"
					},
					new ActivityStreamsObject
					{
						AttributedTo = new ActivityStreamsObject("http://john.example.org"),
						InReplyTo = new ActivityStreamsObject("http://polls.example.org/question/1"),
						Name = "raspberry pi"
					}
				}
			},
			Result = new Note { Content = "Users are favoriting &quot;arduino&quot; by a 33% margin." }
		};

		[Fact]
		public void Example_154_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex154, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_154_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_154_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Question>(SerializedJson.Examples.Example_154_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex154);
		}

		private readonly Collection<ActivityStreamsObject> ex155 = new Collection<ActivityStreamsObject>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "History of John's note",
			Items = new ActivityStreamsObject[]
			{
				new Like
				{
					Summary = "Sally liked John's note",
					Actor = new ActivityStreamsObject("http://sally.example.org"),
					Id = "http://activities.example.com/1",
					Published = DateTimeOffset.Parse("2015-11-12T12:34:56Z", null).DateTime,
					Object = new Note
					{
						Summary = "John's note",
						Id = "http://notes.example.com/1",
						AttributedTo = new ActivityStreamsObject("http://john.example.org"),
						Content = "My note"
					}
				},
				new Dislike
				{
					Summary ="Sally disliked John's note",
					Actor = new ActivityStreamsObject("http://sally.example.org"),
					Id = "http://activities.example.com/2",
					Published = DateTimeOffset.Parse("2015-12-11T21:43:56Z", null).DateTime,
					Object = new Note
					{
						Summary = "John's note",
						Id = "http://notes.example.com/1",
						AttributedTo = new ActivityStreamsObject("http://john.example.org"),
						Content = "My note"
					}
				}
			}
		};

		[Fact]
		public void Example_155_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex155, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_155_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_155_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<ActivityStreamsObject>>(SerializedJson.Examples.Example_155_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex155);
		}

		private readonly Collection<ActivityStreamsObject> ex156 = new Collection<ActivityStreamsObject>
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "History of John's note",
			Items = new ActivityStreamsObject[]
			{
				new Like
				{
					Summary = "Sally liked John's note",
					Actor = new ActivityStreamsObject("http://sally.example.org"),
					Id = "http://activities.example.com/1",
					Published = DateTimeOffset.Parse("2015-11-12T12:34:56Z", null).DateTime,
					Object = new Note
					{
						Summary = "John's note",
						Id = "http://notes.example.com/1",
						AttributedTo = new ActivityStreamsObject("http://john.example.org"),
						Content = "My note"
					}
				},
				new Undo
				{
					Summary = "Sally no longer likes John's note",
					Id = "http://activities.example.com/2",
					Actor = new ActivityStreamsObject("http://sally.example.org"),
					Published = DateTimeOffset.Parse("2015-12-11T21:43:56Z", null).DateTime,
					Object = new ActivityStreamsObject("http://activities.example.com/1")
				}
			}
		};

		[Fact]
		public void Example_156_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex156, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_156_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_156_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Collection<ActivityStreamsObject>>(SerializedJson.Examples.Example_156_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex156);
		}

		private readonly Note ex157 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A thank-you note",
			Content = "Thank you <a href='http://sally.example.org'>@sally</a> for all your hard work! <a href='http://example.org/tags/givingthanks'>#givingthanks</a>",
			To = new Person { Id = "http://sally.example.org", Name = "Sally" },
			Tag = new ActivityStreamsObject { Id = "http://example.org/tags/givingthanks", Name = "#givingthanks" }
		};

		[Fact]
		public void Example_157_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex157, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_157_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_157_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_157_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex157);
		}

		private readonly Note ex158 = new Note
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Name = "A thank-you note",
			Content = "Thank you @sally for all your hard work! #givingthanks",
			Tag = new ActivityStreamsBase[]
			{
				new Mention { Href = "http://example.org/people/sally", Name = "@sally" },
				new ActivityStreamsObject { Id = "http://example.org/tags/givingthanks", Name = "#givingthanks" }
			}
		};

		[Fact]
		public void Example_158_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex158, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_158_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_158_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Note>(SerializedJson.Examples.Example_158_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex158);
		}

		private readonly Move ex159 = new Move
		{
			Context = new ActivityStreamsObject("https://www.w3.org/ns/activitystreams"),
			Summary = "Sally moved the sales figures from Folder A to Folder B",
			Actor = new ActivityStreamsObject("http://sally.example.org"),
			Object = new Document { Name = "sales figures" },
			Origin = new Collection<ActivityStreamsObject> { Name = "Folder A" },
			Target = new Collection<ActivityStreamsObject> { Name = "Folder B" }
		};

		[Fact]
		public void Example_159_Serialize()
		{
			var actual = JObject.Parse(JsonConvert.SerializeObject(ex159, Utils.SerializerSettings));
			var expected = JObject.Parse(SerializedJson.Examples.Example_159_Json);

			actual.Should().BeEquivalentTo(expected);
		}

		[Fact]
		public void Example_159_Deserialize()
		{
			var actual = JsonConvert.DeserializeObject<Move>(SerializedJson.Examples.Example_159_Json, Utils.SerializerSettings);

			actual.Should().BeEquivalentTo(ex159);
		}
	}
}
