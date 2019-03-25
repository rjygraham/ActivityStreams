namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents a short written work typically less than a single paragraph in length. 
	/// </summary>
	public class Note : ActivityStreamsObject
	{
		public Note()
		{
			Type = new ActivityStreamsObject(nameof(Note));
		}
	}
}
