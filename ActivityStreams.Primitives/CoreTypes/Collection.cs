using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// A Collection is a subtype of Object that represents ordered or unordered sets of Object or
	/// Link instances. Refer to the Activity Streams 2.0 Core specification for a complete 
	/// description of the Collection type.
	/// </summary>
	public class Collection<T> : CollectionBase<T>
		where T : IActivityStreamsType
	{
		/// <summary>
		/// Identifies the items contained in a collection. The items might be ordered or 
		/// unordered. 
		/// </summary>
		[JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(InnerJsonConverter))]
		public OneOrMany<T> Items { get; set; }

		public Collection()
		{
			Type = new ActivityStreamsObject(nameof(Collection<T>));
		}
	}
}
