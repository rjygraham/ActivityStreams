namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Describes a software application. 
	/// </summary>
	public class Application : ActivityStreamsObject
	{
		public Application()
		{
			Type = new ActivityStreamsObject(nameof(Application));
		}
	}
}
