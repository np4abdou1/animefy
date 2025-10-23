using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000459 RID: 1113
	public readonly struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion
	{
		// Token: 0x0600202A RID: 8234 RVA: 0x0008810D File Offset: 0x0008630D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ValueTaskAwaiter(ValueTask<TResult> value)
		{
			this._value = value;
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x00088116 File Offset: 0x00086316
		public bool IsCompleted
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this._value.IsCompleted;
			}
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00088123 File Offset: 0x00086323
		[StackTraceHidden]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TResult GetResult()
		{
			return this._value.Result;
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00088130 File Offset: 0x00086330
		public void UnsafeOnCompleted(Action continuation)
		{
			object obj = this._value._obj;
			Task<TResult> task = obj as Task<TResult>;
			if (task != null)
			{
				task.GetAwaiter().UnsafeOnCompleted(continuation);
				return;
			}
			if (obj != null)
			{
				Unsafe.As<IValueTaskSource<TResult>>(obj).OnCompleted(ValueTaskAwaiter.s_invokeActionDelegate, continuation, this._value._token, ValueTaskSourceOnCompletedFlags.UseSchedulingContext);
				return;
			}
			ValueTask.CompletedTask.GetAwaiter().UnsafeOnCompleted(continuation);
		}

		// Token: 0x04000F4E RID: 3918
		private readonly ValueTask<TResult> _value;
	}
}
