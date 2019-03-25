namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor is calling the target's attention the object. 
	/// The origin typically has no defined meaning.
	/// </summary>
	public class Announce : Activity
	{
		public Announce()
		{
			Type = new ActivityStreamsObject(nameof(Announce));
		}
	}
}
