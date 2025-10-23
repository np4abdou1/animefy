using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200043C RID: 1084
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable
	{
		// Token: 0x06001FF3 RID: 8179 RVA: 0x00087CF8 File Offset: 0x00085EF8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ConfiguredValueTaskAwaitable(ValueTask value)
		{
			this._value = value;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00087D01 File Offset: 0x00085F01
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(this._value);
		}

		// Token: 0x04000F3C RID: 3900
		private readonly ValueTask _value;

		// Token: 0x0200043D RID: 1085
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06001FF5 RID: 8181 RVA: 0x00087D0E File Offset: 0x00085F0E
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal ConfiguredValueTaskAwaiter(ValueTask value)
			{
				this._value = value;
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x00087D17 File Offset: 0x00085F17
			public bool IsCompleted
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return this._value.IsCompleted;
				}
			}

			// Token: 0x06001FF7 RID: 8183 RVA: 0x00087D24 File Offset: 0x00085F24
			[StackTraceHidden]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void GetResult()
			{
				this._value.ThrowIfCompletedUnsuccessfully();
			}

			// Token: 0x06001FF8 RID: 8184 RVA: 0x00087D34 File Offset: 0x00085F34
			public void UnsafeOnCompleted(Action continuation)
			{
				object obj = this._value._obj;
				Task task = obj as Task;
				if (task != null)
				{
					task.ConfigureAwait(this._value._continueOnCapturedContext).GetAwaiter().UnsafeOnCompleted(continuation);
					return;
				}
				if (obj != null)
				{
					Unsafe.As<IValueTaskSource>(obj).OnCompleted(ValueTaskAwaiter.s_invokeActionDelegate, continuation, this._value._token, this._value._continueOnCapturedContext ? ValueTaskSourceOnCompletedFlags.UseSchedulingContext : ValueTaskSourceOnCompletedFlags.None);
					return;
				}
				ValueTask.CompletedTask.ConfigureAwait(this._value._continueOnCapturedContext).GetAwaiter().UnsafeOnCompleted(continuation);
			}

			// Token: 0x04000F3D RID: 3901
			private readonly ValueTask _value;
		}
	}
}
