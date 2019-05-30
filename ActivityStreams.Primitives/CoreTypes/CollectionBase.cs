using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;

namespace ActivityStreams.Primitives
{
	public abstract class CollectionBase<T> : ActivityStreamsObject
		where T : IActivityStreamsType
	{
		/// <summary>
		/// A non-negative integer specifying the total number of objects contained by the logical 
		/// view of the collection. This number might not reflect the actual number of items 
		/// serialized within the Collection object instance. 
		/// </summary>
		/// <example>
		/// 2
		/// </example>
		[JsonProperty("totalItems", NullValueHandling = NullValueHandling.Ignore)]
		public int? TotalItems { get; set; }

		/// <summary>
		/// In a paged Collection, indicates the page that contains the most recently updated 
		/// member items. 
		/// </summary>
		/// <example>
		/// http://example.org/collection
		/// </example>
		[JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public T Current { get; set; }

		/// <summary>
		/// In a paged Collection, indicates the furthest preceeding page of items in the 
		/// collection. 
		/// </summary>
		/// <example>
		/// http://example.org/collection?page=0
		/// </example>
		[JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public T First { get; set; }

		/// <summary>
		/// In a paged Collection, indicates the furthest proceeding page of the collection. 
		/// </summary>
		/// <example>
		/// http://example.org/collection?page=1
		/// </example>
		[JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ActivityStreamsPropertyJsonConverter))]
		public T Last { get; set; }
	}
}
