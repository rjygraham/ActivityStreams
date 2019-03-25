﻿namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has updated the object. Note, however, that this vocabulary does 
	/// not define a mechanism for describing the actual set of modifications made to object. 
	/// 
	/// The target and origin typically have no defined meaning.
	/// </summary>
	public class Update : Activity
	{
		public Update()
		{
			Type = new ActivityStreamsObject(nameof(Update));
		}
	}
}
