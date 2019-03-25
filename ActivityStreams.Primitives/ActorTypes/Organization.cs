namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents an organization. 
	/// </summary>
	public class Organization : ActivityStreamsObject
	{
		public Organization()
		{
			Type = new ActivityStreamsObject(nameof(Organization));
		}
	}
}
