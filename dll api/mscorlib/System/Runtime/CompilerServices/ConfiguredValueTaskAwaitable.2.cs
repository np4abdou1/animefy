using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200043E RID: 1086
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable<TResult>
	{
		// Token: 0x06001FF9 RID: 8185 RVA: 0x00087DD1 File Offset: 0x00085FD1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ConfiguredValueTaskAwaitable(ValueTask<TResult> value)
		{
			this._value = value;
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00087DDA File Offset: 0x00085FDA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			return new ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter(this._value);
		}

		// Token: 0x04000F3E RID: 3902
		private readonly ValueTask<TResult> _value;

		// Token: 0x0200043F RID: 1087
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06001FFB RID: 8187 RVA: 0x00087DE7 File Offset: 0x00085FE7
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal ConfiguredValueTaskAwaiter(ValueTask<TResult> value)
			{
				this._value = value;
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06001FFC RID: 8188 RVA: 0x00087DF0 File Offset: 0x00085FF0
			public bool IsCompleted
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return this._value.IsCompleted;
				}
			}

			// Token: 0x06001FFD RID: 8189 RVA: 0x00087DFD File Offset: 0x00085FFD
			[StackTraceHidden]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public TResult GetResult()
			{
				return this._value.Result;
			}

			// Token: 0x06001FFE RID: 8190 RVA: 0x00087E0C File Offset: 0x0008600C
			public void UnsafeOnCompleted(Action continuation)
			{
				object obj = this._value._obj;
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					task.ConfigureAwait(this._value._continueOnCapturedContext).GetAwaiter().UnsafeOnCompleted(continuation);
					return;
				}
				if (obj != null)
				{
					Unsafe.As<IValueTaskSource<TResult>>(obj).OnCompleted(ValueTaskAwaiter.s_invokeActionDelegate, continuation, this._value._token, this._value._continueOnCapturedContext ? ValueTaskSourceOnCompletedFlags.UseSchedulingContext : ValueTaskSourceOnCompletedFlags.None);
					return;
				}
				ValueTask.CompletedTask.ConfigureAwait(this._value._continueOnCapturedContext).GetAwaiter().UnsafeOnCompleted(continuation);
			}

			// Token: 0x04000F3F RID: 3903
			private readonly ValueTask<TResult> _value;
		}
	}
}
