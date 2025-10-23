using System;

namespace System.Runtime.ConstrainedExecution
{
	/// <summary>Specifies a reliability contract.</summary>
	// Token: 0x02000432 RID: 1074
	public enum Consistency
	{
		/// <summary>In the face of exceptional conditions, the CLR makes no guarantees regarding state consistency; that is, the condition might corrupt the process.</summary>
		// Token: 0x04000F2E RID: 3886
		MayCorruptProcess,
		/// <summary>In the face of exceptional conditions, the common language runtime (CLR) makes no guarantees regarding state consistency in the current application domain.</summary>
		// Token: 0x04000F2F RID: 3887
		MayCorruptAppDomain,
		/// <summary>In the face of exceptional conditions, the method is guaranteed to limit state corruption to the current instance.</summary>
		// Token: 0x04000F30 RID: 3888
		MayCorruptInstance,
		/// <summary>In the face of exceptional conditions, the method is guaranteed not to corrupt state. </summary>
		// Token: 0x04000F31 RID: 3889
		WillNotCorruptState
	}
}
