using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000457 RID: 1111
	public readonly struct ValueTaskAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x06002022 RID: 8226 RVA: 0x00088036 File Offset: 0x00086236
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ValueTaskAwaiter(ValueTask value)
		{
			this._value = value;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x0008803F File Offset: 0x0008623F
		public bool IsCompleted
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this._value.IsCompleted;
			}
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0008804C File Offset: 0x0008624C
		[StackTraceHidden]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void GetResult()
		{
			this._value.ThrowIfCompletedUnsuccessfully();
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x0008805C File Offset: 0x0008625C
		public void UnsafeOnCompleted(Action continuation)
		{
			object obj = this._value._obj;
			Task task = obj as Task;
			if (task != null)
			{
				task.GetAwaiter().UnsafeOnCompleted(continuation);
				return;
			}
			if (obj != null)
			{
				Unsafe.As<IValueTaskSource>(obj).OnCompleted(ValueTaskAwaiter.s_invokeActionDelegate, continuation, this._value._token, ValueTaskSourceOnCompletedFlags.UseSchedulingContext);
				return;
			}
			ValueTask.CompletedTask.GetAwaiter().UnsafeOnCompleted(continuation);
		}

		// Token: 0x04000F4B RID: 3915
		internal static readonly Action<object> s_invokeActionDelegate = delegate(object state)
		{
			Action action = state as Action;
			if (action == null)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.state);
				return;
			}
			action();
		};

		// Token: 0x04000F4C RID: 3916
		private readonly ValueTask _value;
	}
}
