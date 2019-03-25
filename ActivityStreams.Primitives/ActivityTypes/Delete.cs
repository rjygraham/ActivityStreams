﻿namespace ActivityStreams.Primitives
{
	/// <summary>
	/// Indicates that the actor has deleted the object. If specified, the origin indicates the
	/// context from which the object was deleted. 
	/// </summary>
	public class Delete : Activity
	{
		public Delete()
		{
			Type = new ActivityStreamsObject(nameof(Delete));
		}
	}
}
