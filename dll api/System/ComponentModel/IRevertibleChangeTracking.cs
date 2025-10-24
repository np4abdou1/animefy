using System;

namespace System.ComponentModel
{
	/// <summary>Provides support for rolling back the changes</summary>
	// Token: 0x0200028F RID: 655
	public interface IRevertibleChangeTracking : IChangeTracking
	{
		/// <summary>Resets the object’s state to unchanged by rejecting the modifications.</summary>
		// Token: 0x06001172 RID: 4466
		void RejectChanges();
	}
}
