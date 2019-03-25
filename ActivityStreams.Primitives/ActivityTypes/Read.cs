namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has read the object. 
	/// </summary>
	public class Read : Activity
	{
		public Read()
		{
			Type = new ActivityStreamsObject(nameof(Read));
		}
	}
}
