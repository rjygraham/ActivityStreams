namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents a video document of any kind. 
	/// </summary>
	public class Video : Document
	{
		public Video()
		{
			Type = new ActivityStreamsObject(nameof(Video));
		}
	}
}
