namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents a formal or informal collective of Actors. 
	/// </summary>
	public class Group : ActivityStreamsObject
	{
		public Group()
		{
			Type = new ActivityStreamsObject(nameof(Group));
		}
	}
}
