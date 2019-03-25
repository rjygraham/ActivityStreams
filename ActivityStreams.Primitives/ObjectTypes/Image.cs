using Newtonsoft.Json;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// An image document of any kind 
	/// </summary>
	public class Image : Document
	{
		[JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
		public int? Height { get; set; }

		[JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
		public int? Width { get; set; }

		public Image()
		{
			Type = new ActivityStreamsObject(nameof(Image));
		}
	}
}
