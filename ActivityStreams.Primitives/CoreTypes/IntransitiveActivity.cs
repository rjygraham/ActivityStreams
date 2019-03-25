using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Instances of IntransitiveActivity are a subtype of Activity representing intransitive 
	/// actions. The object property is therefore inappropriate for these activities. 
	/// </summary>
	public class IntransitiveActivity : ActivityStreamsObject
	{
		/// <summary>
		/// Describes one or more entities that either performed or are 
		/// expected to perform the activity. Any single activity can 
		/// have multiple actors. The actor MAY be specified using an 
		/// indirect Link. 
		/// </summary>
		/// <example>
		/// http://sally.example.org
		/// </example>
		[JsonProperty("actor", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(InnerJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Actor { get; set; }

		/// <summary>
		/// Describes the indirect object, or target, of the activity. The precise meaning of the 
		/// target is largely dependent on the type of action being described but will often be 
		/// the object of the English preposition "to". For instance, in the activity "John added 
		/// a movie to his wishlist", the target of the activity is John's wishlist. An activity 
		/// can have more than one target. 
		/// </summary>
		[JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(InnerJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Target { get; set; }

		/// <summary>
		/// Describes the result of the activity. For instance, if a particular action results in 
		/// the creation of a new resource, the result property can be used to describe that new 
		/// resource. 
		/// </summary>
		[JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(InnerJsonConverter))]
		public OneOrMany<ActivityStreamsObject> Result { get; set; }

		/// <summary>
		/// Describes an indirect object of the activity from which the activity is directed. The 
		/// precise meaning of the origin is the object of the English preposition "from". For 
		/// instance, in the activity "John moved an item to List B from List A", the origin of the
		/// activity is "List A". 
		/// </summary>
		[JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(InnerJsonConverter))]
		public ActivityStreamsObject Origin { get; set; }

		/// <summary>
		/// Identifies one or more objects used (or to be used) in the completion of an Activity. 
		/// </summary>
		[JsonProperty("instrument", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(InnerJsonConverter))]
		public ActivityStreamsObject Instrument { get; set; }

		public IntransitiveActivity()
		{
			Type = new ActivityStreamsObject(nameof(IntransitiveActivity));
		}
	}
}
