namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has left the object. The target and origin typically have no meaning.
	/// </summary>
	public class Leave : Activity
	{
		public Leave()
		{
			Type = new ActivityStreamsObject(nameof(Leave));
		}
	}
}
