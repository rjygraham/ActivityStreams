namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has viewed the object.
	/// </summary>
	public class View : Activity
	{
		public View()
		{
			Type = new ActivityStreamsObject(nameof(View));
		}
	}
}
