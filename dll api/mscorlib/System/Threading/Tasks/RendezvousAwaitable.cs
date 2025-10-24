using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200020D RID: 525
	internal class RendezvousAwaitable<TResult> : ICriticalNotifyCompletion
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0004AB9A File Offset: 0x00048D9A
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x0004ABA2 File Offset: 0x00048DA2
		public bool RunContinuationsAsynchronously { get; set; } = true;

		// Token: 0x060012A0 RID: 4768 RVA: 0x0000245A File Offset: 0x0000065A
		public RendezvousAwaitable<TResult> GetAwaiter()
		{
			return this;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x0004ABAB File Offset: 0x00048DAB
		public bool IsCompleted
		{
			get
			{
				return Volatile.Read<Action>(ref this._continuation) != null;
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0004ABBC File Offset: 0x00048DBC
		public TResult GetResult()
		{
			this._continuation = null;
			ExceptionDispatchInfo error = this._error;
			if (error != null)
			{
				this._error = null;
				error.Throw();
			}
			TResult result = this._result;
			this._result = default(TResult);
			return result;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0004ABF9 File Offset: 0x00048DF9
		public void SetResult(TResult result)
		{
			this._result = result;
			this.NotifyAwaiter();
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0004AC08 File Offset: 0x00048E08
		private void NotifyAwaiter()
		{
			Action action = this._continuation ?? Interlocked.CompareExchange<Action>(ref this._continuation, RendezvousAwaitable<TResult>.s_completionSentinel, null);
			if (action != null)
			{
				if (this.RunContinuationsAsynchronously)
				{
					Task.Run(action);
					return;
				}
				action();
			}
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0004AC4A File Offset: 0x00048E4A
		public void OnCompleted(Action continuation)
		{
			if ((this._continuation ?? Interlocked.CompareExchange<Action>(ref this._continuation, continuation, null)) != null)
			{
				Task.Run(continuation);
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0004AC6C File Offset: 0x00048E6C
		public void UnsafeOnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x04000756 RID: 1878
		private static readonly Action s_completionSentinel = delegate()
		{
		};

		// Token: 0x04000757 RID: 1879
		private Action _continuation;

		// Token: 0x04000758 RID: 1880
		private ExceptionDispatchInfo _error;

		// Token: 0x04000759 RID: 1881
		private TResult _result;
	}
}
