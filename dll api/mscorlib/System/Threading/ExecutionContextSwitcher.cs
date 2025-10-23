using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security;

namespace System.Threading
{
	// Token: 0x020001D4 RID: 468
	internal struct ExecutionContextSwitcher
	{
		// Token: 0x06001119 RID: 4377 RVA: 0x00046EA8 File Offset: 0x000450A8
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[HandleProcessCorruptedStateExceptions]
		internal bool UndoNoThrow()
		{
			try
			{
				this.Undo();
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00046ED8 File Offset: 0x000450D8
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal void Undo()
		{
			if (this.thread == null)
			{
				return;
			}
			Thread thread = this.thread;
			ExecutionContext.Reader executionContextReader = thread.GetExecutionContextReader();
			thread.SetExecutionContext(this.outerEC, this.outerECBelongsToScope);
			this.thread = null;
			ExecutionContext.OnAsyncLocalContextChanged(executionContextReader.DangerousGetRawExecutionContext(), this.outerEC.DangerousGetRawExecutionContext());
		}

		// Token: 0x0400069A RID: 1690
		internal ExecutionContext.Reader outerEC;

		// Token: 0x0400069B RID: 1691
		internal bool outerECBelongsToScope;

		// Token: 0x0400069C RID: 1692
		internal object hecsw;

		// Token: 0x0400069D RID: 1693
		internal Thread thread;
	}
}
