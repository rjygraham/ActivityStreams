using System.Collections.Generic;

namespace ActivityStreams.Primitives.Serialization
{
	internal class Utils
	{
		internal static HashSet<string> StringMapWriteProperties = new HashSet<string> { "content", "name", "summary" };
		internal static HashSet<string> StringMapReadProperties = new HashSet<string> { "contentMap", "nameMap", "summaryMap" };
	}
}
