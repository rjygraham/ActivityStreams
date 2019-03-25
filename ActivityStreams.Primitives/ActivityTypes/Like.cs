namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor likes, recommends or endorses the object. The target and origin 
	/// typically have no defined meaning.
	/// </summary>
	public class Like : Activity
	{
		public Like()
		{
			Type = new ActivityStreamsObject(nameof(Like));
		}
	}
}
