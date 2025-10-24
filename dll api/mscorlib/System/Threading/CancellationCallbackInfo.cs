using System;

namespace System.Threading
{
	// Token: 0x020001C0 RID: 448
	internal class CancellationCallbackInfo
	{
		// Token: 0x060010C3 RID: 4291 RVA: 0x0004545C File Offset: 0x0004365C
		internal CancellationCallbackInfo(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
		{
			this.Callback = callback;
			this.StateForCallback = stateForCallback;
			this.TargetExecutionContext = targetExecutionContext;
			this.CancellationTokenSource = cancellationTokenSource;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00045484 File Offset: 0x00043684
		internal void ExecuteCallback()
		{
			if (this.TargetExecutionContext != null)
			{
				ContextCallback contextCallback = CancellationCallbackInfo.s_executionContextCallback;
				if (contextCallback == null)
				{
					contextCallback = (CancellationCallbackInfo.s_executionContextCallback = new ContextCallback(CancellationCallbackInfo.ExecutionContextCallback));
				}
				ExecutionContext.Run(this.TargetExecutionContext, contextCallback, this);
				return;
			}
			CancellationCallbackInfo.ExecutionContextCallback(this);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000454CC File Offset: 0x000436CC
		private static void ExecutionContextCallback(object obj)
		{
			CancellationCallbackInfo cancellationCallbackInfo = obj as CancellationCallbackInfo;
			cancellationCallbackInfo.Callback(cancellationCallbackInfo.StateForCallback);
		}

		// Token: 0x04000661 RID: 1633
		internal readonly Action<object> Callback;

		// Token: 0x04000662 RID: 1634
		internal readonly object StateForCallback;

		// Token: 0x04000663 RID: 1635
		internal readonly ExecutionContext TargetExecutionContext;

		// Token: 0x04000664 RID: 1636
		internal readonly CancellationTokenSource CancellationTokenSource;

		// Token: 0x04000665 RID: 1637
		private static ContextCallback s_executionContextCallback;

		// Token: 0x020001C1 RID: 449
		internal sealed class WithSyncContext : CancellationCallbackInfo
		{
			// Token: 0x060010C6 RID: 4294 RVA: 0x000454F1 File Offset: 0x000436F1
			internal WithSyncContext(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext) : base(callback, stateForCallback, targetExecutionContext, cancellationTokenSource)
			{
				this.TargetSyncContext = targetSyncContext;
			}

			// Token: 0x04000666 RID: 1638
			internal readonly SynchronizationContext TargetSyncContext;
		}
	}
}
