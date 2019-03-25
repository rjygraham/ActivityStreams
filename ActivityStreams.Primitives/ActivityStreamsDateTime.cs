using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;
using System;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// DateTime type used to provide strong typing in instances where a value can be an 
	/// ActivityStreamsBase, bool, or DateTime.
	/// </summary>
	public class ActivityStreamsDateTime : IActivityStreamsType
	{
		[JsonConverter(typeof(InnerJsonConverter))]
		public DateTime? Value { get; set; }

		public ActivityStreamsDateTime() { }

		public ActivityStreamsDateTime(DateTime value)
		{
			Value = value;
		}
	}
}
