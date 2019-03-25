namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents any kind of event.
	/// </summary>
	public class Event : ActivityStreamsObject
	{
		public Event()
		{
			Type = new ActivityStreamsObject(nameof(Event));
		}
	}
}
