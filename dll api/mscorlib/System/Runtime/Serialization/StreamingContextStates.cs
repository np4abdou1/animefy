using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Defines a set of flags that specifies the source or destination context for the stream during serialization.</summary>
	// Token: 0x020003B8 RID: 952
	[Flags]
	[ComVisible(true)]
	[Serializable]
	public enum StreamingContextStates
	{
		/// <summary>Specifies that the source or destination context is a different process on the same computer.</summary>
		// Token: 0x04000C52 RID: 3154
		CrossProcess = 1,
		/// <summary>Specifies that the source or destination context is a different computer.</summary>
		// Token: 0x04000C53 RID: 3155
		CrossMachine = 2,
		/// <summary>Specifies that the source or destination context is a file. Users can assume that files will last longer than the process that created them and not serialize objects in such a way that deserialization will require accessing any data from the current process.</summary>
		// Token: 0x04000C54 RID: 3156
		File = 4,
		/// <summary>Specifies that the source or destination context is a persisted store, which could include databases, files, or other backing stores. Users can assume that persisted data will last longer than the process that created the data and not serialize objects so that deserialization will require accessing any data from the current process.</summary>
		// Token: 0x04000C55 RID: 3157
		Persistence = 8,
		/// <summary>Specifies that the data is remoted to a context in an unknown location. Users cannot make any assumptions whether this is on the same computer.</summary>
		// Token: 0x04000C56 RID: 3158
		Remoting = 16,
		/// <summary>Specifies that the serialization context is unknown.</summary>
		// Token: 0x04000C57 RID: 3159
		Other = 32,
		/// <summary>Specifies that the object graph is being cloned. Users can assume that the cloned graph will continue to exist within the same process and be safe to access handles or other references to unmanaged resources.</summary>
		// Token: 0x04000C58 RID: 3160
		Clone = 64,
		/// <summary>Specifies that the source or destination context is a different AppDomain. (For a description of AppDomains, see Application Domains).</summary>
		// Token: 0x04000C59 RID: 3161
		CrossAppDomain = 128,
		/// <summary>Specifies that the serialized data can be transmitted to or received from any of the other contexts.</summary>
		// Token: 0x04000C5A RID: 3162
		All = 255
	}
}
