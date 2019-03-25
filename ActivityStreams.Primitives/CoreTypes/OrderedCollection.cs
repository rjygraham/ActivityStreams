using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// A subtype of Collection in which members of the logical collection are assumed to always
	/// be strictly ordered.
	/// </summary>
	public class OrderedCollection<T> : CollectionBase<T>
		where T: ActivityStreamsBase
	{
		/// <summary>
		/// Identifies the items contained in a collection. The items might be ordered or 
		/// unordered. 
		/// </summary>
		[JsonProperty("orderedItems", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(InnerJsonConverter))]
		public List<T> OrderedItems { get; set; }

		public OrderedCollection()
		{
			Type = new ActivityStreamsObject(nameof(OrderedCollection<T>));
		}
	}
}
