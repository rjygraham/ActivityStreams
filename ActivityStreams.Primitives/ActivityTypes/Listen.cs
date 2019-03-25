namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has listened to the object. 
	/// </summary>
	public class Listen : Activity
	{
		public Listen()
		{
			Type = new ActivityStreamsObject(nameof(Listen));
		}
	}
}
