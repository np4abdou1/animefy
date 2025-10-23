using System;
using System.Security;

namespace System.Threading
{
	// Token: 0x020001EB RID: 491
	internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
	{
		// Token: 0x060011CF RID: 4559 RVA: 0x00048B13 File Offset: 0x00046D13
		[SecurityCritical]
		internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark)
		{
			this.callback = waitCallback;
			this.state = stateObj;
			if (compressStack && !ExecutionContext.IsFlowSuppressed())
			{
				this.context = ExecutionContext.Capture(ref stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx | ExecutionContext.CaptureOptions.OptimizeDefaultCase);
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00048B41 File Offset: 0x00046D41
		[SecurityCritical]
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			if (this.context == null)
			{
				WaitCallback waitCallback = this.callback;
				this.callback = null;
				waitCallback(this.state);
				return;
			}
			ExecutionContext.Run(this.context, QueueUserWorkItemCallback.ccb, this, true);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00002A7D File Offset: 0x00000C7D
		[SecurityCritical]
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00048B78 File Offset: 0x00046D78
		[SecurityCritical]
		private static void WaitCallback_Context(object state)
		{
			QueueUserWorkItemCallback queueUserWorkItemCallback = (QueueUserWorkItemCallback)state;
			queueUserWorkItemCallback.callback(queueUserWorkItemCallback.state);
		}

		// Token: 0x040006E2 RID: 1762
		private WaitCallback callback;

		// Token: 0x040006E3 RID: 1763
		private ExecutionContext context;

		// Token: 0x040006E4 RID: 1764
		private object state;

		// Token: 0x040006E5 RID: 1765
		[SecurityCritical]
		internal static ContextCallback ccb = new ContextCallback(QueueUserWorkItemCallback.WaitCallback_Context);
	}
}
