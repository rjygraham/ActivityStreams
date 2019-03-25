namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor dislikes the object. 
	/// </summary>
	public class Dislike : Activity
	{
		public Dislike()
		{
			Type = new ActivityStreamsObject(nameof(Dislike));
		}
	}
}
