namespace ActivityStreams.Primitives
{
	/// <summary>
	/// A specialization of Reject in which the rejection is considered tentative. 
	/// </summary>
	public class TentativeReject : Reject
	{
		public TentativeReject()
		{
			Type = new ActivityStreamsObject(nameof(TentativeReject));
		}
	}
}
