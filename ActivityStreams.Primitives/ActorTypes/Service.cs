namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents a service of any kind. 
	/// </summary>
	public class Service : ActivityStreamsObject
	{
		public Service()
		{
			Type = new ActivityStreamsObject(nameof(Service));
		}
	}
}
