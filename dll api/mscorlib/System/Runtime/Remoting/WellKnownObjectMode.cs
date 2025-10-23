using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Defines how well-known objects are activated.</summary>
	// Token: 0x0200031C RID: 796
	[ComVisible(true)]
	[Serializable]
	public enum WellKnownObjectMode
	{
		/// <summary>Every incoming message is serviced by the same object instance.</summary>
		// Token: 0x04000AE8 RID: 2792
		Singleton = 1,
		/// <summary>Every incoming message is serviced by a new object instance.</summary>
		// Token: 0x04000AE9 RID: 2793
		SingleCall
	}
}
