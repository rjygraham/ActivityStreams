namespace ActivityStreams.Primitives
{
	/// <summary>
	/// A specialized Link that represents an @mention. 
	/// </summary>
	public class Mention : Link
	{
		public Mention()
		{
			Type = new ActivityStreamsObject(nameof(Mention));
		}
	}
}
