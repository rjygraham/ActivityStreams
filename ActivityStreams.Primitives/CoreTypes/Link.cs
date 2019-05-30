﻿using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// A Link is an indirect, qualified reference to a resource identified by a URL.The 
	/// fundamental model for links is established by [RFC5988]. Many of the properties 
	/// defined by the Activity Vocabulary allow values that are either instances of 
	/// Object or Link.When a Link is used, it establishes a qualified relation 
	/// connecting the subject (the containing object) to the resource identified by the
	/// href.Properties of the Link are properties of the reference as opposed to 
	/// properties of the resource.
	/// </summary>
	public class Link : ActivityStreamsBase
	{
		/// <summary>
		/// The target resource pointed to by a Link. 
		/// </summary>
		/// <example>
		/// http://example.org/abc
		/// </example>
		[JsonProperty("href")]
		public string Href { get; set; }

		/// <summary>
		/// Hints as to the language used by the target resource.
		/// Value MUST be a BCP47 Language-Tag. 
		/// </summary>
		/// <example>
		/// en
		/// </example>
		[JsonProperty("hreflang", NullValueHandling = NullValueHandling.Ignore)]
		public string HrefLang { get; set; }

		/// <summary>
		/// A link relation associated with a Link. The value MUST conform to 
		/// both the [HTML5] and [RFC5988] "link relation" definitions.
		/// 
		/// In the[HTML5], any string not containing the "space" U+0020, "tab" 
		/// (U+0009), "LF" (U+000A), "FF" (U+000C), "CR" (U+000D) or "," 
		/// (U+002C) characters can be used as a valid link relation.
		/// </summary>
		/// <example>
		/// canonical, preview
		/// </example>
		[JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public OneOrMany<string> Rel { get; set; }

		/// <summary>
		/// On a Link, specifies a hint as to the rendering height in 
		/// device-independent pixels of the linked resource. 
		/// </summary>
		/// <example>
		/// 100
		/// </example>
		[JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
		public int? Height { get; set; }

		/// <summary>
		/// On a Link, specifies a hint as to the rendering width in
		/// device-independent pixels of the linked resource.
		/// </summary>
		/// <example>
		/// 100
		/// </example>
		[JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
		public int? Width { get; set; }

		/// <summary>
		/// Identifies an entity that provides a preview of this object. 
		/// </summary>
		[JsonProperty("preview", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public ActivityStreamsObject Preview { get; set; }

		public Link()
		{
			Type = new ActivityStreamsObject(nameof(Link));
		}

		public Link(string href)
		{
			Href = href;
		}
	}
}
