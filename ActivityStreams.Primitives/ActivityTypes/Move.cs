namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has moved object from origin to target. If the origin or target 
	/// are not specified, either can be determined by context. 
	/// </summary>
	public class Move : Activity
	{
		public Move()
		{
			Type = new ActivityStreamsObject(nameof(Move));
		}
	}
}
