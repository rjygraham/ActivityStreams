namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor is rejecting the object. The target and origin typically have no
	/// defined meaning. 
	/// </summary>
	public class Reject : Activity
	{
		public Reject()
		{
			Type = new ActivityStreamsObject(nameof(Reject));
		}
	}
}
