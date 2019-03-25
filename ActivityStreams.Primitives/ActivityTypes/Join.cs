namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has joined the object. The target and origin typically have no 
	/// defined meaning. 
	/// </summary>
	public class Join : Activity
	{
		public Join()
		{
			Type = new ActivityStreamsObject(nameof(Join));
		}
	}
}
