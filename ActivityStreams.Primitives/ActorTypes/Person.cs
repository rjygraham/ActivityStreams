namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents an individual person.
	/// </summary>
	public class Person : ActivityStreamsObject
	{
		public Person()
		{
			Type = new ActivityStreamsObject(nameof(Person));
		}
	}
}
