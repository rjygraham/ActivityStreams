namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has created the object.
	/// </summary>
	public class Create : Activity
	{
		public Create()
		{
			Type = new ActivityStreamsObject(nameof(Create));
		}
	}
}
