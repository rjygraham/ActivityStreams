namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents a Web Page. 
	/// </summary>
	public class Page : Document
	{
		public Page()
		{
			Type = new ActivityStreamsObject(nameof(Page));
		}
	}
}
