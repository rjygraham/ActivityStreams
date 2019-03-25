namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents an audio document of any kind. 
	/// </summary>
	public class Audio : Document
	{
		public Audio()
		{
			Type = new ActivityStreamsObject(nameof(Audio));
		}
	}
}
