namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor is ignoring the object. The target and origin typically have no
	/// defined meaning.
	/// </summary>
	public class Ignore : Activity
	{
		public Ignore()
		{
			Type = new ActivityStreamsObject(nameof(Ignore));
		}
	}
}
