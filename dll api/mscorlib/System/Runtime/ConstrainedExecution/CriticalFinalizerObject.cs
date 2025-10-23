using System;

namespace System.Runtime.ConstrainedExecution
{
	/// <summary>Ensures that all finalization code in derived classes is marked as critical.</summary>
	// Token: 0x02000435 RID: 1077
	public abstract class CriticalFinalizerObject
	{
		/// <summary>Releases all the resources used by the <see cref="T:System.Runtime.ConstrainedExecution.CriticalFinalizerObject" /> class.</summary>
		// Token: 0x06001FE7 RID: 8167 RVA: 0x00087C10 File Offset: 0x00085E10
		~CriticalFinalizerObject()
		{
		}
	}
}
