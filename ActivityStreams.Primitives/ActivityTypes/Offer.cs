namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor is offering the object. If specified, the target indicates the 
	/// entity to which the object is being offered. 
	/// </summary>
	public class Offer : Activity
	{
		public Offer()
		{
			Type = new ActivityStreamsObject(nameof(Offer));
		}
	}
}
