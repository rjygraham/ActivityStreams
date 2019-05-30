using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;
using System;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Describes an object of any kind.The Object type serves as the base type for most of the 
	/// other kinds of objects defined in the Activity Vocabulary, including other Core types 
	/// such as Activity, IntransitiveActivity, Collection and OrderedCollection.
	/// </summary>
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class ActivityStreamsObject : ActivityStreamsBase
	{
		/// <summary>
		/// Identifies a resource attached or related to an object that potentially requires 
		/// special handling. The intent is to provide a model that is at least semantically 
		/// similar to attachments in email. 
		/// </summary>
		[JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Attachment { get; set; }

		/// <summary>
		/// Identifies one or more entities to which this object is attributed. The attributed 
		/// entities might not be Actors. For instance, an object might be attributed to the 
		/// completion of another activity. 
		/// </summary>
		[JsonProperty("attributedTo", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> AttributedTo { get; set; }

		/// <summary>
		/// Identifies one or more entities that represent the total population of entities for 
		/// which the object can considered to be relevant. 
		/// </summary>
		[JsonProperty("audience", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Audience { get; set; }

		/// <summary>
		/// The content or textual representation of the Object encoded as a JSON string. By 
		/// default, the value of content is HTML. The mediaType property can be used in the 
		/// object to indicate a different content type. 
		/// 
		/// The content MAY be expressed using multiple language-tagged values.
		/// </summary>
		[JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public StringMap Content { get; set; }

		/// <summary>
		/// The date and time describing the actual or expected ending time of the object. When used 
		/// with an Activity object, for instance, the endTime property specifies the moment the 
		/// activity concluded or is expected to conclude. 
		/// </summary>
		[JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? EndTime { get; set; }

		/// <summary>
		/// Identifies the entity (e.g. an application) that generated the object. 
		/// </summary>
		[JsonProperty("generator", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public ActivityStreamsBase Generator { get; set; }

		/// <summary>
		/// Indicates an entity that describes an icon for this object. The image should have an
		/// aspect ratio of one (horizontal) to one (vertical) and should be suitable for 
		/// presentation at a small size.
		/// </summary>
		[JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Icon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Image { get; set; }

		/// <summary>
		/// Indicates one or more entities for which this object is considered a response. 
		/// </summary>
		[JsonProperty("inReplyTo", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public ActivityStreamsBase InReplyTo { get; set; }

		/// <summary>
		/// Indicates one or more physical or logical locations associated with the object. 
		/// </summary>
		[JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Location { get; set; }

		/// <summary>
		/// Identifies an entity that provides a preview of this object. 
		/// </summary>
		[JsonProperty("preview", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public ActivityStreamsBase Preview { get; set; }

		/// <summary>
		/// The date and time at which the object was published
		/// </summary>
		[JsonProperty("published", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? Published { get; set; }

		/// <summary>
		/// Identifies a Collection containing objects considered to be responses to this object. 
		/// </summary>
		[JsonProperty("replies", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public Collection<ActivityStreamsObject> Replies { get; set; }

		/// <summary>
		/// The date and time describing the actual or expected starting time of the object. When 
		/// used with an Activity object, for instance, the startTime property specifies the 
		/// moment the activity began or is scheduled to begin.
		/// </summary>
		[JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? StartTime { get; set; }

		/// <summary>
		/// One or more "tags" that have been associated with an objects. A tag can be any kind of 
		/// Object. The key difference between attachment and tag is that the former implies 
		/// association by inclusion, while the latter implies associated by reference. 
		/// </summary>
		[JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Tag { get; set; }

		/// <summary>
		/// The date and time at which the object was updated.
		/// </summary>
		[JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? Updated { get; set; }

		/// <summary>
		/// Identifies one or more links to representations of the object 
		/// </summary>
		[JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<Link> Url { get; set; }

		/// <summary>
		/// Identifies an entity considered to be part of the public primary audience of an Object 
		/// </summary>
		[JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> To { get; set; }

		/// <summary>
		/// Identifies an Object that is part of the private primary audience of this Object. 
		/// </summary>
		[JsonProperty("bto", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Bto { get; set; }

		/// <summary>
		/// Identifies an Object that is part of the public secondary audience of this Object.
		/// </summary>
		[JsonProperty("cc", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Cc { get; set; }

		/// <summary>
		/// Identifies one or more Objects that are part of the private secondary audience of this 
		/// Object. 
		/// </summary>
		[JsonProperty("bcc", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<ActivityStreamsBase> Bcc { get; set; }

		/// <summary>
		/// When the object describes a time-bound resource, such as an audio or video, a meeting, etc,
		/// the duration property indicates the object's approximate duration. The value MUST be 
		/// expressed as an xsd:duration as defined by [ xmlschema11-2], section 3.3.6 (e.g. a 
		/// period of 5 seconds is represented as "PT5S"). 
		/// </summary>
		[JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public TimeSpan? Duration { get; set; }

		public ActivityStreamsObject()
		{
		}

		public ActivityStreamsObject(string id)
		{
			Id = id;
		}

		public ActivityStreamsObject(string id, string type)
			: this(id)
		{
			Type = new ActivityStreamsObject(type);
		}
	}
}