namespace ActivityStreams.Primitives.Tests
{
	internal class SerializedJson
	{
		internal class Examples
		{
			internal const string Example_1_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Object"",
		  ""id"": ""http://www.test.example/object/1"",
		  ""name"": ""A Simple, non-specific object""
		}";

			internal const string Example_2_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Link"",
		  ""href"": ""http://example.org/abc"",
		  ""hreflang"": ""en"",
		  ""mediaType"": ""text/html"",
		  ""name"": ""An example link""
		}";

			internal const string Example_3_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Activity"",
		  ""summary"": ""Sally did something to a note"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Note"",
			""name"": ""A Note""
		  }
		}";

			internal const string Example_4_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Travel"",
		  ""summary"": ""Sally went to work"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""target"": {
			""type"": ""Place"",
			""name"": ""Work""
		  }
		}";

			internal const string Example_5_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's notes"",
		  ""type"": ""Collection"",
		  ""totalItems"": 2,
		  ""items"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""A Simple Note""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Another Simple Note""
			}
		  ]
		}";

			internal const string Example_6_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's notes"",
		  ""type"": ""OrderedCollection"",
		  ""totalItems"": 2,
		  ""orderedItems"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""A Simple Note""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Another Simple Note""
			}
		  ]
		}";

			internal const string Example_7_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Page 1 of Sally's notes"",
		  ""type"": ""CollectionPage"",
		  ""id"": ""http://example.org/foo?page=1"",
		  ""partOf"": ""http://example.org/foo"",
		  ""items"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""A Simple Note""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Another Simple Note""
			}
		  ]
		}";

			internal const string Example_8_Json = @"
		{
		""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Page 1 of Sally's notes"",
		  ""type"": ""OrderedCollectionPage"",
		  ""id"": ""http://example.org/foo?page=1"",
		  ""partOf"": ""http://example.org/foo"",
		  ""orderedItems"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""A Simple Note""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Another Simple Note""
			}
		  ]
		}";

			internal const string Example_9_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally accepted an invitation to a party"",
		  ""type"": ""Accept"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Invite"",
			""actor"": ""http://john.example.org"",
			""object"": {
			  ""type"": ""Event"",
			  ""name"": ""Going-Away Party for Jim""
			}
		  }
		}";

			internal const string Example_10_Json = @"
		{
			""@context"": ""https://www.w3.org/ns/activitystreams"",
			""summary"": ""Sally accepted Joe into the club"",
			""type"": ""Accept"",
			""actor"": {
			  ""type"": ""Person"",
			  ""name"": ""Sally""
			},
			""object"": {
			  ""type"": ""Person"",
			  ""name"": ""Joe""
			},
			""target"": {
			  ""type"": ""Group"",
			  ""name"": ""The Club""
			}
		  }";

			internal const string Example_11_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally tentatively accepted an invitation to a party"",
		  ""type"": ""TentativeAccept"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Invite"",
			""actor"": ""http://john.example.org"",
			""object"": {
			  ""type"": ""Event"",
			  ""name"": ""Going-Away Party for Jim""
			}
		  }
		}";

			internal const string Example_12_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally added an object"",
		  ""type"": ""Add"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/abc""
		}";

			internal const string Example_13_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally added a picture of her cat to her cat picture collection"",
		  ""type"": ""Add"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Image"",
			""name"": ""A picture of my cat"",
			""url"": ""http://example.org/img/cat.png""
		  },
		  ""origin"": {
			""type"": ""Collection"",
			""name"": ""Camera Roll""
		  },
		  ""target"": {
			""type"": ""Collection"",
			""name"": ""My Cat Pictures""
		  }
		}";

			internal const string Example_14_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally arrived at work"",
		  ""type"": ""Arrive"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""location"": {
			""type"": ""Place"",
			""name"": ""Work""
		  },
		  ""origin"": {
			""type"": ""Place"",
			""name"": ""Home""
		  }
		}";

			internal const string Example_15_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally created a note"",
		  ""type"": ""Create"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Note"",
			""name"": ""A Simple Note"",
			""content"": ""This is a simple note""
		  }
		}";

			internal const string Example_16_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally deleted a note"",
		  ""type"": ""Delete"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/notes/1"",
		  ""origin"": {
			""type"": ""Collection"",
			""name"": ""Sally's Notes""
		  }
		}";

			internal const string Example_17_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally followed John"",
		  ""type"": ""Follow"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Person"",
			""name"": ""John""
		  }
		}";

			internal const string Example_18_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally ignored a note"",
		  ""type"": ""Ignore"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/notes/1""
		}";

			internal const string Example_19_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally joined a group"",
		  ""type"": ""Join"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Group"",
			""name"": ""A Simple Group""
		  }
		}";

			internal const string Example_20_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally left work"",
		  ""type"": ""Leave"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Place"",
			""name"": ""Work""
		  }
		}";

			internal const string Example_21_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally left a group"",
		  ""type"": ""Leave"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Group"",
			""name"": ""A Simple Group""
		  }
		}";

			internal const string Example_22_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally liked a note"",
		  ""type"": ""Like"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/notes/1""
		}";

			internal const string Example_23_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered 50% off to Lewis"",
		  ""type"": ""Offer"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""http://www.types.example/ProductOffer"",
			""name"": ""50% Off!""
		  },
		  ""target"": {
			""type"": ""Person"",
			""name"": ""Lewis""
		  }
		}";

			internal const string Example_24_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally invited John and Lisa to a party"",
		  ""type"": ""Invite"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Event"",
			""name"": ""A Party""
		  },
		  ""target"": [
			{
			  ""type"": ""Person"",
			  ""name"": ""John""
			},
			{
			  ""type"": ""Person"",
			  ""name"": ""Lisa""
			}
		  ]
		}";

			internal const string Example_25_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally rejected an invitation to a party"",
		  ""type"": ""Reject"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Invite"",
			""actor"": ""http://john.example.org"",
			""object"": {
			  ""type"": ""Event"",
			  ""name"": ""Going-Away Party for Jim""
			}
		  }
		}";

			internal const string Example_26_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally tentatively rejected an invitation to a party"",
		  ""type"": ""TentativeReject"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Invite"",
			""actor"": ""http://john.example.org"",
			""object"": {
			  ""type"": ""Event"",
			  ""name"": ""Going-Away Party for Jim""
			}
		  }
		}";

			internal const string Example_27_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally removed a note from her notes folder"",
		  ""type"": ""Remove"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/notes/1"",
		  ""target"": {
			""type"": ""Collection"",
			""name"": ""Notes Folder""
		  }
		}";

			internal const string Example_28_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""The moderator removed Sally from a group"",
		  ""type"": ""Remove"",
		  ""actor"": {
			""type"": ""http://example.org/Role"",
			""name"": ""The Moderator""
		  },
		  ""object"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""origin"": {
			""type"": ""Group"",
			""name"": ""A Simple Group""
		  }
		}";

			internal const string Example_29_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally retracted her offer to John"",
		  ""type"": ""Undo"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": {
			""type"": ""Offer"",
			""actor"": ""http://sally.example.org"",
			""object"": ""http://example.org/posts/1"",
			""target"": ""http://john.example.org""
		  }
		}";

			internal const string Example_30_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally updated her note"",
		  ""type"": ""Update"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/notes/1""
		}";

			internal const string Example_31_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally read an article"",
		  ""type"": ""View"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Article"",
			""name"": ""What You Should Know About Activity Streams""
		  }
		}";

			internal const string Example_32_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally listened to a piece of music"",
		  ""type"": ""Listen"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/music.mp3""
		}";

			internal const string Example_33_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally read a blog post"",
		  ""type"": ""Read"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/posts/1""
		}";

			internal const string Example_34_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally moved a post from List A to List B"",
		  ""type"": ""Move"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/posts/1"",
		  ""target"": {
			""type"": ""Collection"",
			""name"": ""List B""
		  },
		  ""origin"": {
			""type"": ""Collection"",
			""name"": ""List A""
		  }
		}";

			internal const string Example_35_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally went home from work"",
		  ""type"": ""Travel"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""target"": {
			""type"": ""Place"",
			""name"": ""Home""
		  },
		  ""origin"": {
			""type"": ""Place"",
			""name"": ""Work""
		  }
		}";

			internal const string Example_36_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally announced that she had arrived at work"",
		  ""type"": ""Announce"",
		  ""actor"": {
			""type"": ""Person"",
			""id"": ""http://sally.example.org"",
			""name"": ""Sally""
		  },
		  ""object"": {
			""type"": ""Arrive"",
			""actor"": ""http://sally.example.org"",
			""location"": {
			  ""type"": ""Place"",
			  ""name"": ""Work""
			}
		  }
		}";

			internal const string Example_37_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally blocked Joe"",
		  ""type"": ""Block"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://joe.example.org""
		}";

			internal const string Example_38_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally flagged an inappropriate note"",
		  ""type"": ""Flag"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": {
			""type"": ""Note"",
			""content"": ""An inappropriate note""
		  }
		}";

			internal const string Example_39_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally disliked a post"",
		  ""type"": ""Dislike"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1""
		}";

			internal const string Example_40_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Question"",
		  ""name"": ""What is the answer?"",
		  ""oneOf"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""Option A""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Option B""
			}
		  ]
		}";

			internal const string Example_41_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Question"",
		  ""name"": ""What is the answer?"",
		  ""closed"": ""2016-05-10T00:00:00Z""
		}";

			internal const string Example_42_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Application"",
		  ""name"": ""Exampletron 3000""
		}";

			internal const string Example_43_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Group"",
		  ""name"": ""Big Beards of Austin""
		}";

			internal const string Example_44_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Organization"",
		  ""name"": ""Example Co.""
		}";

			internal const string Example_45_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Person"",
		  ""name"": ""Sally Smith""
		}";

			internal const string Example_46_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Service"",
		  ""name"": ""Acme Web Service""
		}";

			internal const string Example_47_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally is an acquaintance of John"",
		  ""type"": ""Relationship"",
		  ""subject"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""relationship"": ""http://purl.org/vocab/relationship/acquaintanceOf"",
		  ""object"": {
			""type"": ""Person"",
			""name"": ""John""
		  }
		}";

			internal const string Example_48_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Article"",
		  ""name"": ""What a Crazy Day I Had"",
		  ""content"": ""<div>... you will never believe ...</div>"",
		  ""attributedTo"": ""http://sally.example.org""
		}";

			internal const string Example_49_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Document"",
		  ""name"": ""4Q Sales Forecast"",
		  ""url"": ""http://example.org/4q-sales-forecast.pdf""
		}";

			internal const string Example_50_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Audio"",
		  ""name"": ""Interview With A Famous Technologist"",
		  ""url"": {
			""type"": ""Link"",
			""href"": ""http://example.org/podcast.mp3"",
			""mediaType"": ""audio/mp3""
		  }
		}";

			internal const string Example_51_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Image"",
		  ""name"": ""Cat Jumping on Wagon"",
		  ""url"": [
			{
			  ""type"": ""Link"",
			  ""href"": ""http://example.org/image.jpeg"",
			  ""mediaType"": ""image/jpeg""
			},
			{
			  ""type"": ""Link"",
			  ""href"": ""http://example.org/image.png"",
			  ""mediaType"": ""image/png""
			}
		  ]
		}";

			internal const string Example_52_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Video"",
		  ""name"": ""Puppy Plays With Ball"",
		  ""url"": ""http://example.org/video.mkv"",
		  ""duration"": ""PT2H""
		}";

			internal const string Example_53_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Note"",
		  ""name"": ""A Word of Warning"",
		  ""content"": ""Looks like it is going to rain today. Bring an umbrella!""
		}";

			internal const string Example_54_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Page"",
		  ""name"": ""Omaha Weather Report"",
		  ""url"": ""http://example.org/weather-in-omaha.html""
		}";

			internal const string Example_55_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Event"",
		  ""name"": ""Going-Away Party for Jim"",
		  ""startTime"": ""2014-12-31T23:00:00-08:00"",
		  ""endTime"": ""2015-01-01T06:00:00-08:00""
		}";

			internal const string Example_56_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""Work""
		}";

			internal const string Example_57_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""Fresno Area"",
		  ""latitude"": 36.75,
		  ""longitude"": 119.7667,
		  ""radius"": 15.0,
		  ""units"": ""miles""
		}";

			internal const string Example_58_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Mention of Joe by Carrie in her note"",
		  ""type"": ""Mention"",
		  ""href"": ""http://example.org/joe"",
		  ""name"": ""Joe""
		}";

			internal const string Example_59_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Profile"",
		  ""summary"": ""Sally's Profile"",
		  ""describes"": {
			""type"": ""Person"",
			""name"": ""Sally Smith""
		  }
		}";

			internal const string Example_60_Json = @"
		{
		  ""type"": ""OrderedCollection"",
		  ""totalItems"": 3,
		  ""name"": ""Vacation photos 2016"",
		  ""orderedItems"": [
			{
			  ""type"": ""Image"",
			  ""id"": ""http://image.example/1""
			},
			{
			  ""type"": ""Tombstone"",
			  ""formerType"": ""Image"",
			  ""id"": ""http://image.example/2"",
			  ""deleted"": ""2016-03-17T00:00:00Z""
			},
			{
			  ""type"": ""Image"",
			  ""id"": ""http://image.example/3""
			}
		  ]
		}";

			internal const string Example_61_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""Foo"",
		  ""id"": ""http://example.org/foo""
		}";

			internal const string Example_62_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A foo"",
		  ""type"": ""http://example.org/Foo""
		}";

			internal const string Example_63_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered the Foo object"",
		  ""type"": ""Offer"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/foo""
		}";

			internal const string Example_64_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered the Foo object"",
		  ""type"": ""Offer"",
		  ""actor"": {
			""type"": ""Person"",
			""id"": ""http://sally.example.org"",
			""summary"": ""Sally""
		  },
		  ""object"": ""http://example.org/foo""
		}";

			internal const string Example_65_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally and Joe offered the Foo object"",
		  ""type"": ""Offer"",
		  ""actor"": [
			""http://joe.example.org"",
			{
			  ""type"": ""Person"",
			  ""id"": ""http://sally.example.org"",
			  ""name"": ""Sally""
			}
		  ],
		  ""object"": ""http://example.org/foo""
		}";

			internal const string Example_66_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Note"",
		  ""name"": ""Have you seen my cat?"",
		  ""attachment"": {
				""type"": ""Image"",
				""content"": ""This is what he looks like."",
				""url"": ""http://example.org/cat.jpeg""
			}
		}";

			internal const string Example_67_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Image"",
		  ""name"": ""My cat taking a nap"",
		  ""url"": ""http://example.org/cat.jpeg"",
		  ""attributedTo"": {
			  ""type"": ""Person"",
			  ""name"": ""Sally""
			}
		}";

			internal const string Example_68_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Image"",
		  ""name"": ""My cat taking a nap"",
		  ""url"": ""http://example.org/cat.jpeg"",
		  ""attributedTo"": [
			""http://joe.example.org"",
			{
			  ""type"": ""Person"",
			  ""name"": ""Sally""
			}
		  ]
		}";

			internal const string Example_69_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""Holiday announcement"",
		  ""type"": ""Note"",
		  ""content"": ""Thursday will be a company-wide holiday. Enjoy your day off!"",
		  ""audience"": {
			""type"": ""http://example.org/Organization"",
			""name"": ""ExampleCo LLC""
		  }
		}";

			internal const string Example_70_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered a post to John"",
		  ""type"": ""Offer"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1"",
		  ""target"": ""http://john.example.org"",
		  ""bcc"": ""http://joe.example.org""
		}";

			internal const string Example_71_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered a post to John"",
		  ""type"": ""Offer"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1"",
		  ""target"": ""http://john.example.org"",
		  ""bto"": ""http://joe.example.org""
		}";

			internal const string Example_72_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered a post to John"",
		  ""type"": ""Offer"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1"",
		  ""target"": ""http://john.example.org"",
		  ""cc"": ""http://joe.example.org""
		}";

			internal const string Example_73_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Activities in context 1"",
		  ""type"": ""Collection"",
		  ""items"": [
			{
			  ""type"": ""Offer"",
			  ""actor"": ""http://sally.example.org"",
			  ""object"": ""http://example.org/posts/1"",
			  ""target"": ""http://john.example.org"",
			  ""context"": ""http://example.org/contexts/1""
			},
			{
			  ""type"": ""Like"",
			  ""actor"": ""http://joe.example.org"",
			  ""object"": ""http://example.org/posts/2"",
			  ""context"": ""http://example.org/contexts/1""
			}
		  ]
		}";

			internal const string Example_74_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's blog posts"",
		  ""type"": ""Collection"",
		  ""totalItems"": 3,
		  ""current"": ""http://example.org/collection"",
		  ""items"": [
			""http://example.org/posts/1"",
			""http://example.org/posts/2"",
			""http://example.org/posts/3""
		  ]
		}";

			internal const string Example_75_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's blog posts"",
		  ""type"": ""Collection"",
		  ""totalItems"": 3,
		  ""current"": {
			""type"": ""Link"",
			""summary"": ""Most Recent Items"",
			""href"": ""http://example.org/collection""
		  },
		  ""items"": [
			""http://example.org/posts/1"",
			""http://example.org/posts/2"",
			""http://example.org/posts/3""
		  ]
		}";

			internal const string Example_76_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's blog posts"",
		  ""type"": ""Collection"",
		  ""totalItems"": 3,
		  ""first"": ""http://example.org/collection?page=0""
		}";

			internal const string Example_77_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's blog posts"",
		  ""type"": ""Collection"",
		  ""totalItems"": 3,
		  ""first"": {
			""type"": ""Link"",
			""summary"": ""First Page"",
			""href"": ""http://example.org/collection?page=0""
		  }
		}";

			internal const string Example_78_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""This is all there is."",
		  ""generator"": {
			""type"": ""Application"",
			""name"": ""Exampletron 3000""
		  }
		}";

			internal const string Example_79_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""This is all there is."",
		  ""icon"": {
			""type"": ""Image"",
			""name"": ""Note icon"",
			""url"": ""http://example.org/note.png"",
			""width"": 16,
			""height"": 16
		  }
		}";

			internal const string Example_80_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""A simple note"",
		  ""icon"": [
			{
			  ""type"": ""Image"",
			  ""summary"": ""Note (16x16)"",
			  ""url"": ""http://example.org/note1.png"",
			  ""width"": 16,
			  ""height"": 16
			},
			{
			  ""type"": ""Image"",
			  ""summary"": ""Note (32x32)"",
			  ""url"": ""http://example.org/note2.png"",
			  ""width"": 32,
			  ""height"": 32
			}
		  ]
		}";

			internal const string Example_81_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""This is all there is."",
		  ""image"": {
			""type"": ""Image"",
			""name"": ""A Cat"",
			""url"": ""http://example.org/cat.png""
		  }
		}";

			internal const string Example_82_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""This is all there is."",
		  ""image"": [
			{
			  ""type"": ""Image"",
			  ""name"": ""Cat 1"",
			  ""url"": ""http://example.org/cat1.png""
			},
			{
			  ""type"": ""Image"",
			  ""name"": ""Cat 2"",
			  ""url"": ""http://example.org/cat2.png""
			}
		  ]
		}";

			internal const string Example_83_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""This is all there is."",
		  ""inReplyTo"": {
			""summary"": ""Previous note"",
			""type"": ""Note"",
			""content"": ""What else is there?""
		  }
		}";

			internal const string Example_84_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""This is all there is."",
		  ""inReplyTo"": ""http://example.org/posts/1""
		}";

			internal const string Example_85_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally listened to a piece of music on the Acme Music Service"",
		  ""type"": ""Listen"",
		  ""actor"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""object"": ""http://example.org/foo.mp3"",
		  ""instrument"": {
			""type"": ""Service"",
			""name"": ""Acme Music Service""
		  }
		}";

			internal const string Example_86_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A collection"",
		  ""type"": ""Collection"",
		  ""totalItems"": 3,
		  ""last"": ""http://example.org/collection?page=1""
		}";

			internal const string Example_87_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A collection"",
		  ""type"": ""Collection"",
		  ""totalItems"": 5,
		  ""last"": {
			""type"": ""Link"",
			""summary"": ""Last Page"",
			""href"": ""http://example.org/collection?page=1""
		  }
		}";

			internal const string Example_88_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Person"",
		  ""name"": ""Sally"",
		  ""location"": {
			""name"": ""Over the Arabian Sea, east of Socotra Island Nature Sanctuary"",
			""type"": ""Place"",
			""longitude"": 12.34,
			""latitude"": 56.78,
			""altitude"": 90.0,
			""units"": ""m""
		  }
		}";

			internal const string Example_89_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's notes"",
		  ""type"": ""Collection"",
		  ""totalItems"": 2,
		  ""items"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""Reminder for Going-Away Party""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Meeting 2016-11-17""
			}
		  ]
		}";

			internal const string Example_90_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's notes"",
		  ""type"": ""OrderedCollection"",
		  ""totalItems"": 2,
		  ""orderedItems"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""Meeting 2016-11-17""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Reminder for Going-Away Party""
			}
		  ]
		}";

			internal const string Example_91_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Question"",
		  ""name"": ""What is the answer?"",
		  ""oneOf"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""Option A""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Option B""
			}
		  ]
		}";

			internal const string Example_92_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Question"",
		  ""name"": ""What is the answer?"",
		  ""anyOf"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""Option A""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Option B""
			}
		  ]
		}";

			internal const string Example_93_Json = @"
		{
			""@context"": ""https://www.w3.org/ns/activitystreams"",
			""type"": ""Question"",
			""name"": ""What is the answer?"",
			""closed"": ""2016-05-10T00:00:00Z""
		}";

			internal const string Example_94_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally moved a post from List A to List B"",
		  ""type"": ""Move"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1"",
		  ""target"": {
			""type"": ""Collection"",
			""name"": ""List B""
		  },
		  ""origin"": {
			""type"": ""Collection"",
			""name"": ""List A""
		  }
		}";

			internal const string Example_95_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Page 2 of Sally's blog posts"",
		  ""type"": ""CollectionPage"",
		  ""next"": ""http://example.org/collection?page=2"",
		  ""items"": [
			""http://example.org/posts/1"",
			""http://example.org/posts/2"",
			""http://example.org/posts/3""
		  ]
		}";

			internal const string Example_96_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Page 2 of Sally's blog posts"",
		  ""type"": ""CollectionPage"",
		  ""next"": {
			""type"": ""Link"",
			""name"": ""Next Page"",
			""href"": ""http://example.org/collection?page=2""
		  },
		  ""items"": [
			""http://example.org/posts/1"",
			""http://example.org/posts/2"",
			""http://example.org/posts/3""
		  ]
		}";

			internal const string Example_97_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally liked a post"",
		  ""type"": ""Like"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1""
		}";

			internal const string Example_98_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Like"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": {
			""type"": ""Note"",
			""content"": ""A simple note""
		  }
		}";

			internal const string Example_99_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally liked a note"",
		  ""type"": ""Like"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": [
			""http://example.org/posts/1"",
			{
			  ""type"": ""Note"",
			  ""summary"": ""A simple note"",
			  ""content"": ""That is a tree.""
			}
		  ]
		}";

			internal const string Example_100_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Page 1 of Sally's blog posts"",
		  ""type"": ""CollectionPage"",
		  ""prev"": ""http://example.org/collection?page=1"",
		  ""items"": [
			""http://example.org/posts/1"",
			""http://example.org/posts/2"",
			""http://example.org/posts/3""
		  ]
		}";

			internal const string Example_101_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Page 1 of Sally's blog posts"",
		  ""type"": ""CollectionPage"",
		  ""prev"": {
			""type"": ""Link"",
			""name"": ""Previous Page"",
			""href"": ""http://example.org/collection?page=1""
		  },
		  ""items"": [
			""http://example.org/posts/1"",
			""http://example.org/posts/2"",
			""http://example.org/posts/3""
		  ]
		}";

			internal const string Example_102_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Video"",
		  ""name"": ""Cool New Movie"",
		  ""duration"": ""PT2H30M"",
		  ""preview"": {
			""type"": ""Video"",
			""name"": ""Trailer"",
			""duration"": ""PT1M"",
			""url"": {
			  ""href"": ""http://example.org/trailer.mkv"",
			  ""mediaType"": ""video/mkv""
			}
		  }
		}";

			internal const string Example_103_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally checked that her flight was on time"",
		  ""type"": [""Activity"", ""http://www.verbs.example/Check""],
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/flights/1"",
		  ""result"": {
			""type"": ""http://www.types.example/flightstatus"",
			""name"": ""On Time""
		  }
		}";

			internal const string Example_104_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""id"": ""http://www.test.example/notes/1"",
		  ""content"": ""I am fine."",
		  ""replies"": {
			""type"": ""Collection"",
			""totalItems"": 1,
			""items"": {
				""summary"": ""A response to the note"",
				""type"": ""Note"",
				""content"": ""I am glad to hear it."",
				""inReplyTo"": ""http://www.test.example/notes/1""
			}
		  }
		}";

			internal const string Example_105_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Image"",
		  ""summary"": ""Picture of Sally"",
		  ""url"": ""http://example.org/sally.jpg"",
		  ""tag"": {
			  ""type"": ""Person"",
			  ""id"": ""http://sally.example.org"",
			  ""name"": ""Sally""
			}
		}";

			internal const string Example_106_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered the post to John"",
		  ""type"": ""Offer"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1"",
		  ""target"": ""http://john.example.org""
		}";

			internal const string Example_107_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered the post to John"",
		  ""type"": ""Offer"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1"",
		  ""target"": {
			""type"": ""Person"",
			""name"": ""John""
		  }
		}";

			internal const string Example_108_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally offered the post to John"",
		  ""type"": ""Offer"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": ""http://example.org/posts/1"",
		  ""target"": ""http://john.example.org"",
		  ""to"": ""http://joe.example.org"" 
		}";

			internal const string Example_109_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Document"",
		  ""name"": ""4Q Sales Forecast"",
		  ""url"": ""http://example.org/4q-sales-forecast.pdf""
		}";

			internal const string Example_110_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Document"",
		  ""name"": ""4Q Sales Forecast"",
		  ""url"": {
			""type"": ""Link"",
			""href"": ""http://example.org/4q-sales-forecast.pdf""
		  }
		}";

			internal const string Example_111_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Document"",
		  ""name"": ""4Q Sales Forecast"",
		  ""url"": [
			{
			  ""type"": ""Link"",
			  ""href"": ""http://example.org/4q-sales-forecast.pdf"",
			  ""mediaType"": ""application/pdf""
			},
			{
			  ""type"": ""Link"",
			  ""href"": ""http://example.org/4q-sales-forecast.html"",
			  ""mediaType"": ""text/html""
			}
		  ]
		}";

			internal const string Example_112_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""Liu Gu Lu Cun, Pingdu, Qingdao, Shandong, China"",
		  ""type"": ""Place"",
		  ""latitude"": 36.75,
		  ""longitude"": 119.7667,
		  ""accuracy"": 94.5
		}";

			internal const string Example_113_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""Fresno Area"",
		  ""altitude"": 15.0,
		  ""latitude"": 36.75,
		  ""longitude"": 119.7667,
		  ""units"": ""miles""
		}";

			internal const string Example_114_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""A <em>simple</em> note""
		}";

			internal const string Example_115_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""contentMap"": {
			""en"": ""A <em>simple</em> note"",
			""es"": ""Una nota <em>sencilla</em>"",
			""zh-Hans"": ""一段<em>简单的</em>笔记""
		  }
		}";

			internal const string Example_116_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""mediaType"": ""text/markdown"",
		  ""content"": ""## A simple note\nA simple markdown `note`""
		}";

			internal const string Example_117_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Note"",
		  ""name"": ""A simple note""
		}";

			internal const string Example_118_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Note"",
		  ""nameMap"": {
			""en"": ""A simple note"",
			""es"": ""Una nota sencilla"",
			""zh-Hans"": ""一段简单的笔记""
		  }
		}";

			internal const string Example_119_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Video"",
		  ""name"": ""Birds Flying"",
		  ""url"": ""http://example.org/video.mkv"",
		  ""duration"": ""PT2H""
		}";

			internal const string Example_120_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Link"",
		  ""href"": ""http://example.org/image.png"",
		  ""height"": 100,
		  ""width"": 100
		}";

			internal const string Example_121_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Link"",
		  ""href"": ""http://example.org/abc"",
		  ""mediaType"": ""text/html"",
		  ""name"": ""Previous""
		}";

			internal const string Example_122_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Link"",
		  ""href"": ""http://example.org/abc"",
		  ""hreflang"": ""en"",
		  ""mediaType"": ""text/html"",
		  ""name"": ""Previous""
		}";

			internal const string Example_123_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Page 1 of Sally's notes"",
		  ""type"": ""CollectionPage"",
		  ""id"": ""http://example.org/collection?page=1"",
		  ""partOf"": ""http://example.org/collection"",
		  ""items"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""Pizza Toppings to Try""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Thought about California""
			}
		  ]
		}";

			internal const string Example_124_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""Fresno Area"",
		  ""latitude"": 36.75,
		  ""longitude"": 119.7667,
		  ""radius"": 15.0,
		  ""units"": ""miles""
		}";

			internal const string Example_125_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""Fresno Area"",
		  ""latitude"": 36.75,
		  ""longitude"": 119.7667,
		  ""radius"": 15.0,
		  ""units"": ""miles""
		}";

			internal const string Example_126_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Link"",
		  ""href"": ""http://example.org/abc"",
		  ""hreflang"": ""en"",
		  ""mediaType"": ""text/html"",
		  ""name"": ""Next""
		}";

			internal const string Example_127_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Event"",
		  ""name"": ""Going-Away Party for Jim"",
		  ""startTime"": ""2014-12-31T23:00:00-08:00"",
		  ""endTime"": ""2015-01-01T06:00:00-08:00""
		}";

			internal const string Example_128_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""A simple note"",
		  ""type"": ""Note"",
		  ""content"": ""Fish swim."",
		  ""published"": ""2014-12-12T12:12:12Z""
		}";

			internal const string Example_129_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Event"",
		  ""name"": ""Going-Away Party for Jim"",
		  ""startTime"": ""2014-12-31T23:00:00-08:00"",
		  ""endTime"": ""2015-01-01T06:00:00-08:00""
		}";

			internal const string Example_130_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""Fresno Area"",
		  ""latitude"": 36.75,
		  ""longitude"": 119.7667,
		  ""radius"": 15.0,
		  ""units"": ""miles""
		}";

			internal const string Example_131_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Link"",
		  ""href"": ""http://example.org/abc"",
		  ""hreflang"": ""en"",
		  ""mediaType"": ""text/html"",
		  ""name"": ""Preview"",
		  ""rel"": [""canonical"", ""preview""]
		}";

			internal const string Example_132_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Page 1 of Sally's notes"",
		  ""type"": ""OrderedCollectionPage"",
		  ""startIndex"": 0,
		  ""orderedItems"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""Density of Water""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Air Mattress Idea""
			}
		  ]
		}";

			internal const string Example_133_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""Cane Sugar Processing"",
		  ""type"": ""Note"",
		  ""summary"": ""A simple <em>note</em>""
		}";

			internal const string Example_134_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""Cane Sugar Processing"",
		  ""type"": ""Note"",
		  ""summaryMap"": {
			""en"": ""A simple <em>note</em>"",
			""es"": ""Una <em>nota</em> sencilla"",
			""zh-Hans"": ""一段<em>简单的</em>笔记""
		  }
		}";

			internal const string Example_135_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's notes"",
		  ""type"": ""Collection"",
		  ""totalItems"": 2,
		  ""items"": [
			{
			  ""type"": ""Note"",
			  ""name"": ""Which Staircase Should I Use""
			},
			{
			  ""type"": ""Note"",
			  ""name"": ""Something to Remember""
			}
		  ]
		}";

			internal const string Example_136_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""Fresno Area"",
		  ""latitude"": 36.75,
		  ""longitude"": 119.7667,
		  ""radius"": 15.0,
		  ""units"": ""miles""
		}";

			internal const string Example_137_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""Cranberry Sauce Idea"",
		  ""type"": ""Note"",
		  ""content"": ""Mush it up so it does not have the same shape as the can."",
		  ""updated"": ""2014-12-12T12:12:12Z""
		}";

			internal const string Example_138_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Link"",
		  ""href"": ""http://example.org/image.png"",
		  ""height"": 100,
		  ""width"": 100
		}";

			internal const string Example_139_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally is an acquaintance of John's"",
		  ""type"": ""Relationship"",
		  ""subject"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""relationship"": ""http://purl.org/vocab/relationship/acquaintanceOf"",
		  ""object"": {
			""type"": ""Person"",
			""name"": ""John""
		  }
		}";

			internal const string Example_140_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally is an acquaintance of John's"",
		  ""type"": ""Relationship"",
		  ""subject"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""relationship"": ""http://purl.org/vocab/relationship/acquaintanceOf"",
		  ""object"": {
			""type"": ""Person"",
			""name"": ""John""
		  }
		}";

			internal const string Example_141_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's profile"",
		  ""type"": ""Profile"",
		  ""describes"": {
			""type"": ""Person"",
			""name"": ""Sally""
		  },
		  ""url"": ""http://sally.example.org""
		}";

			internal const string Example_142_Json = @"
		{
		""@context"": ""https://www.w3.org/ns/activitystreams"",
		""summary"": ""This image has been deleted"",
		""type"": ""Tombstone"",
		""formerType"": ""Image"",
		""url"": ""http://example.org/image/2""
		}";

			internal const string Example_143_Json = @"
		{
		""@context"": ""https://www.w3.org/ns/activitystreams"",
		""summary"": ""This image has been deleted"",
		""type"": ""Tombstone"",
		""deleted"": ""2016-05-03T00:00:00Z""
		}";

			internal const string Example_144_Json = @"
		{
		 ""@context"": ""https://www.w3.org/ns/activitystreams"",
		 ""summary"": ""Activities in Project XYZ"",
		 ""type"": ""Collection"",
		 ""items"": [
		   {
			 ""summary"": ""Sally created a note"",
			 ""type"": ""Create"",
			 ""id"": ""http://activities.example.com/1"",
			 ""actor"": ""http://sally.example.org"",
			 ""object"": {
			  ""summary"": ""A note"",
			   ""type"": ""Note"",
			   ""id"": ""http://notes.example.com/1"",
			   ""content"": ""A note""
			 },
			 ""context"": {
			   ""type"": ""http://example.org/Project"",
			   ""name"": ""Project XYZ""
			 },
			 ""audience"": {
			   ""type"": ""Group"",
			   ""name"": ""Project XYZ Working Group""
			 },
			 ""to"": ""http://john.example.org""
		   },
		   {
			 ""summary"": ""John liked Sally's note"",
			 ""type"": ""Like"",
			 ""id"": ""http://activities.example.com/1"",
			 ""actor"": ""http://john.example.org"",
			 ""object"": ""http://notes.example.com/1"",
			 ""context"": {
			   ""type"": ""http://example.org/Project"",
			   ""name"": ""Project XYZ""
			 },
			 ""audience"": {
			   ""type"": ""Group"",
			   ""name"": ""Project XYZ Working Group""
			 },
			 ""to"": ""http://sally.example.org""
		   }
		 ]
		}";

			internal const string Example_145_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally's friends list"",
		  ""type"": ""Collection"",
		  ""items"": [
			{
			  ""summary"": ""Sally is influenced by Joe"",
			  ""type"": ""Relationship"",
			  ""subject"": {
				""type"": ""Person"",
				""name"": ""Sally""
			  },
			  ""relationship"": ""http://purl.org/vocab/relationship/influencedBy"",
			  ""object"": {
				""type"": ""Person"",
				""name"": ""Joe""
			  }
			},
			{
			  ""summary"": ""Sally is a friend of Jane"",
			  ""type"": ""Relationship"",
			  ""subject"": {
				""type"": ""Person"",
				""name"": ""Sally""
			  },
			  ""relationship"": ""http://purl.org/vocab/relationship/friendOf"",
			  ""object"": {
				""type"": ""Person"",
				""name"": ""Jane""
			  }
			}
		  ]
		}";

			internal const string Example_146_Json = @"{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally became a friend of Matt"",
		  ""type"": ""Create"",
		  ""actor"": ""http://sally.example.org"",
		  ""object"": {
			""type"": ""Relationship"",
			""subject"": ""http://sally.example.org"",
			""relationship"": ""http://purl.org/vocab/relationship/friendOf"",
			""object"": ""http://matt.example.org"",
			""startTime"": ""2015-04-21T12:34:56""
		  }
		}";

			internal const string Example_147_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""id"": ""http://example.org/connection-requests/123"",
		  ""summary"": ""Sally requested to be a friend of John"",
		  ""type"": ""Offer"",
		  ""actor"": ""acct:sally@example.org"",
		  ""object"": {
			""summary"": ""Sally and John's friendship"",
			""id"": ""http://example.org/connections/123"",
			""type"": ""Relationship"",
			""subject"": ""acct:sally@example.org"",
			""relationship"": ""http://purl.org/vocab/relationship/friendOf"",
			""object"": ""acct:john@example.org""
		  },
		  ""target"": ""acct:john@example.org""
		}";

			internal const string Example_148_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""Sally and John's relationship history"",
		  ""type"": ""Collection"",
		  ""items"": [
			{
			  ""summary"": ""John accepted Sally's friend request"",
			  ""id"": ""http://example.org/activities/122"",
			  ""type"": ""Accept"",
			  ""actor"": ""acct:john@example.org"",
			  ""object"": ""http://example.org/connection-requests/123"",
			  ""inReplyTo"": ""http://example.org/connection-requests/123"",
			  ""context"": ""http://example.org/connections/123"",
			  ""result"": [
				""http://example.org/activities/123"",
				""http://example.org/activities/124"",
				""http://example.org/activities/125"",
				""http://example.org/activities/126""
			  ]
			},
			{
			  ""summary"": ""John followed Sally"",
			  ""id"": ""http://example.org/activities/123"",
			  ""type"": ""Follow"",
			  ""actor"": ""acct:john@example.org"",
			  ""object"": ""acct:sally@example.org"",
			  ""context"": ""http://example.org/connections/123""
			},
			{
			  ""summary"": ""Sally followed John"",
			  ""id"": ""http://example.org/activities/124"",
			  ""type"": ""Follow"",
			  ""actor"": ""acct:sally@example.org"",
			  ""object"": ""acct:john@example.org"",
			  ""context"": ""http://example.org/connections/123""
			},
			{
			  ""summary"": ""John added Sally to his friends list"",
			  ""id"": ""http://example.org/activities/125"",
			  ""type"": ""Add"",
			  ""actor"": ""acct:john@example.org"",
			  ""object"": ""http://example.org/connections/123"",
			  ""target"": {
				""type"": ""Collection"",
				""summary"": ""John's Connections""
			  },
			  ""context"": ""http://example.org/connections/123""
			},
			{
			  ""summary"": ""Sally added John to her friends list"",
			  ""id"": ""http://example.org/activities/126"",
			  ""type"": ""Add"",
			  ""actor"": ""acct:sally@example.org"",
			  ""object"": ""http://example.org/connections/123"",
			  ""target"": {
				""type"": ""Collection"",
				""summary"": ""Sally's Connections""
			  },
			  ""context"": ""http://example.org/connections/123""
			}
		  ]
		}";

			internal const string Example_149_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""San Francisco, CA""
		}";

			internal const string Example_150_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""type"": ""Place"",
		  ""name"": ""San Francisco, CA"",
		  ""longitude"": 122.4167,
		  ""latitude"": 37.7833
		}";

			internal const string Example_151_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""A question about robots"",
		  ""id"": ""http://help.example.org/question/1"",
		  ""type"": ""Question"",
		  ""content"": ""I'd like to build a robot to feed my cat. Should I use Arduino or Raspberry Pi?""
		}";

			internal const string Example_152_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""id"": ""http://polls.example.org/question/1"",
		  ""name"": ""A question about robots"",
		  ""type"": ""Question"",
		   ""content"": ""I'd like to build a robot to feed my cat. Which platform is best?"",
		   ""oneOf"": [
			 {""name"": ""arduino""},
			 {""name"": ""raspberry pi""}
		   ]
		 }";

			internal const string Example_153_Json = @"
		{
		 ""@context"": ""https://www.w3.org/ns/activitystreams"",
		 ""attributedTo"": ""http://sally.example.org"",
		 ""inReplyTo"": ""http://polls.example.org/question/1"",
		 ""name"": ""arduino""
		}";

			internal const string Example_154_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""A question about robots"",
		  ""id"": ""http://polls.example.org/question/1"",
		  ""type"": ""Question"",
		   ""content"": ""I'd like to build a robot to feed my cat. Which platform is best?"",
		   ""oneOf"": [
			 {""name"": ""arduino""},
			 {""name"": ""raspberry pi""}
		   ],
		   ""replies"": {
			 ""type"": ""Collection"",
			 ""totalItems"": 3,
			 ""items"": [
			   {
				 ""attributedTo"": ""http://sally.example.org"",
				 ""inReplyTo"": ""http://polls.example.org/question/1"",
				 ""name"": ""arduino""
			   },
			   {
				 ""attributedTo"": ""http://joe.example.org"",
				 ""inReplyTo"": ""http://polls.example.org/question/1"",
				 ""name"": ""arduino""
			   },
			   {
				 ""attributedTo"": ""http://john.example.org"",
				 ""inReplyTo"": ""http://polls.example.org/question/1"",
				 ""name"": ""raspberry pi""
			   }
			 ]
		   },
		   ""result"": {
			 ""type"": ""Note"",
			 ""content"": ""Users are favoriting &quot;arduino&quot; by a 33% margin.""
		   }
		 }";

			internal const string Example_155_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""summary"": ""History of John's note"",
		  ""type"": ""Collection"",
		  ""items"": [
			{
			  ""summary"": ""Sally liked John's note"",
			  ""type"": ""Like"",
			  ""actor"": ""http://sally.example.org"",
			  ""id"": ""http://activities.example.com/1"",
			  ""published"": ""2015-11-12T12:34:56Z"",
			  ""object"": {
				""summary"": ""John's note"",
				""type"": ""Note"",
				""id"": ""http://notes.example.com/1"",
				""attributedTo"": ""http://john.example.org"",
				""content"": ""My note""
			  }
			},
			{
			  ""summary"": ""Sally disliked John's note"",
			  ""type"": ""Dislike"",
			  ""actor"": ""http://sally.example.org"",
			  ""id"": ""http://activities.example.com/2"",
			  ""published"": ""2015-12-11T21:43:56Z"",
			  ""object"": {
				""summary"": ""John's note"",
				""type"": ""Note"",
				""id"": ""http://notes.example.com/1"",
				""attributedTo"": ""http://john.example.org"",
				""content"": ""My note""
			  }
			}
		  ]
		 }";

			internal const string Example_156_Json = @"
		{
		 ""@context"": ""https://www.w3.org/ns/activitystreams"",
		 ""summary"": ""History of John's note"",
		 ""type"": ""Collection"",
		 ""items"": [
		   {
			 ""summary"": ""Sally liked John's note"",
			 ""type"": ""Like"",
			 ""id"": ""http://activities.example.com/1"",
			 ""actor"": ""http://sally.example.org"",
			 ""published"": ""2015-11-12T12:34:56Z"",
			 ""object"": {
			   ""summary"": ""John's note"",
			   ""type"": ""Note"",
			   ""id"": ""http://notes.example.com/1"",
			   ""attributedTo"": ""http://john.example.org"",
			   ""content"": ""My note""
			 }
		   },
		   {
			 ""summary"": ""Sally no longer likes John's note"",
			 ""type"": ""Undo"",
			 ""id"": ""http://activities.example.com/2"",
			 ""actor"": ""http://sally.example.org"",
			 ""published"": ""2015-12-11T21:43:56Z"",
			 ""object"": ""http://activities.example.com/1""
		   }
		 ]
		}";

			internal const string Example_157_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""A thank-you note"",
		  ""type"": ""Note"",
		  ""content"": ""Thank you <a href='http://sally.example.org'>@sally</a> for all your hard work! <a href='http://example.org/tags/givingthanks'>#givingthanks</a>"",
		  ""to"": {
			""name"": ""Sally"",
			""type"": ""Person"",
			""id"": ""http://sally.example.org""
		  },
		  ""tag"": {
			""id"": ""http://example.org/tags/givingthanks"",
			""name"": ""#givingthanks""
		  }
		}";

			internal const string Example_158_Json = @"
		{
		  ""@context"": ""https://www.w3.org/ns/activitystreams"",
		  ""name"": ""A thank-you note"",
		  ""type"": ""Note"",
		  ""content"": ""Thank you @sally for all your hard work! #givingthanks"",
		  ""tag"": [
			{
			  ""type"": ""Mention"",
			  ""href"": ""http://example.org/people/sally"",
			  ""name"": ""@sally""
			},
			{
			  ""id"": ""http://example.org/tags/givingthanks"",
			  ""name"": ""#givingthanks""
			}
		  ]
		}";

			internal const string Example_159_Json = @"
		{
			""@context"": ""https://www.w3.org/ns/activitystreams"",
			""summary"": ""Sally moved the sales figures from Folder A to Folder B"",
			""type"": ""Move"",
			""actor"": ""http://sally.example.org"",
			""object"": {
			  ""type"": ""Document"",
			  ""name"": ""sales figures""
			},
			""origin"": {
			  ""type"": ""Collection"",
			  ""name"": ""Folder A""
			},
			""target"": {
			  ""type"": ""Collection"",
			  ""name"": ""Folder B""
			}
		}";

		}

		internal class Additional
		{
			internal const string InnerSringMap = @"
			{
			  ""@context"": ""https://www.w3.org/ns/activitystreams"",
			  ""summary"": ""Sally's notes"",
			  ""type"": ""Collection"",
			  ""totalItems"": 1,
			  ""items"": {
				  ""type"": ""Note"",
				  ""contentMap"": {
					""en"": ""A <em>simple</em> note"",
					""es"": ""Una nota <em>sencilla</em>"",
					""zh-Hans"": ""一段<em>简单的</em>笔记""
					}
				}
			}";
		}
	}
}
