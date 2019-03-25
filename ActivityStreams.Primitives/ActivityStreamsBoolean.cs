using ActivityStreams.Primitives.Serialization;
using Newtonsoft.Json;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Bool type used to provide strong typing in instances where a value can be an 
	/// ActivityStreamsBase, bool, or DateTime.
	/// </summary>
	public class ActivityStreamsBoolean : IActivityStreamsType
	{
		[JsonConverter(typeof(InnerJsonConverter))]
		public bool? Value { get; set; }

		public ActivityStreamsBoolean() { }

		public ActivityStreamsBoolean(bool value)
		{
			Value = value;
		}
	}
}
