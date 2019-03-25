namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Represents any kind of multi-paragraph written work.
	/// </summary>
	public class Article : ActivityStreamsObject
	{
		public Article()
		{
			Type = new ActivityStreamsObject(nameof(Article));
		}
	}
}
