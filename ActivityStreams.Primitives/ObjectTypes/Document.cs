namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents a document of any kind. 
	/// </summary>
	public class Document : ActivityStreamsObject
	{
		public Document()
		{
			Type = new ActivityStreamsObject(nameof(Document));
		}
	}
}
