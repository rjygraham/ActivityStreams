namespace ActivityStreams.Primitives
{
	public class Arrive : IntransitiveActivity
	{
		/// <summary>
		/// An IntransitiveActivity that indicates that the actor has arrived at the location.
		/// The origin can be used to identify the context from which the actor originated. The
		/// target typically has no defined meaning. 
		/// </summary>
		public Arrive()
		{
			Type = new ActivityStreamsObject(nameof(Arrive));
		}
	}
}
