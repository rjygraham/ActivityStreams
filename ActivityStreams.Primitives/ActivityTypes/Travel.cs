namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor is traveling to target from origin. Travel is an 
	/// IntransitiveObject whose actor specifies the direct object. If the target or origin are not
	/// specified, either can be determined by context. 
	/// </summary>
	public class Travel : IntransitiveActivity
	{
		public Travel()
		{
			Type = new ActivityStreamsObject(nameof(Travel));
		}
	}
}
