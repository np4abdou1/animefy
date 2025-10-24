using System;
using System.Security;

namespace System.Threading
{
	// Token: 0x020001E1 RID: 481
	internal interface IThreadPoolWorkItem
	{
		// Token: 0x060011A7 RID: 4519
		[SecurityCritical]
		void ExecuteWorkItem();

		// Token: 0x060011A8 RID: 4520
		[SecurityCritical]
		void MarkAborted(ThreadAbortException tae);
	}
}
