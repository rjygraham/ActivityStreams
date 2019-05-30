using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;
using System;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Describes a relationship between two individuals. The subject and object properties are
	/// used to identify the connected individuals. 
	/// 
	/// See 5.2 Representing Relationships Between Entities for additional information.
	/// </summary>
	public class Relationship : ActivityStreamsObject
	{
		/// <summary>
		/// On a Relationship object, the subject property identifies one of the connected 
		/// individuals.For instance, for a Relationship object describing "John is related to 
		/// Sally", subject would refer to John.
		/// </summary>
		[JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public ActivityStreamsBase Subject { get; set; }

		[JsonProperty("relationship", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public Relationship Relation { get; set; }

		[JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public ActivityStreamsObject Object { get; set; }

		public Relationship()
		{
			Type = new ActivityStreamsObject(nameof(Relationship));
		}

		public Relationship(string type)
		{
			Type = new ActivityStreamsObject(type);
		}
	}
}
