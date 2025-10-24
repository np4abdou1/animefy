using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks
{
	// Token: 0x02000203 RID: 515
	[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
	[StructLayout(3)]
	public readonly struct ValueTask : IEquatable<ValueTask>
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0004A3A6 File Offset: 0x000485A6
		internal static Task CompletedTask
		{
			get
			{
				return Task.CompletedTask;
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0004A3AD File Offset: 0x000485AD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(Task task)
		{
			if (task == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.task);
			}
			this._obj = task;
			this._continueOnCapturedContext = true;
			this._token = 0;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0004A3CE File Offset: 0x000485CE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(IValueTaskSource source, short token)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			this._obj = source;
			this._token = token;
			this._continueOnCapturedContext = true;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0004A3EF File Offset: 0x000485EF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ValueTask(object obj, short token, bool continueOnCapturedContext)
		{
			this._obj = obj;
			this._token = token;
			this._continueOnCapturedContext = continueOnCapturedContext;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0004A406 File Offset: 0x00048606
		public override int GetHashCode()
		{
			object obj = this._obj;
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0004A419 File Offset: 0x00048619
		public override bool Equals(object obj)
		{
			return obj is ValueTask && this.Equals((ValueTask)obj);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0004A431 File Offset: 0x00048631
		public bool Equals(ValueTask other)
		{
			return this._obj == other._obj && this._token == other._token;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0004A454 File Offset: 0x00048654
		public Task AsTask()
		{
			object obj = this._obj;
			Task result;
			if (obj != null)
			{
				if ((result = (obj as Task)) == null)
				{
					return this.GetTaskForValueTaskSource(Unsafe.As<IValueTaskSource>(obj));
				}
			}
			else
			{
				result = ValueTask.CompletedTask;
			}
			return result;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0004A488 File Offset: 0x00048688
		private Task GetTaskForValueTaskSource(IValueTaskSource t)
		{
			ValueTaskSourceStatus status = t.GetStatus(this._token);
			if (status != ValueTaskSourceStatus.Pending)
			{
				try
				{
					t.GetResult(this._token);
					return ValueTask.CompletedTask;
				}
				catch (Exception ex)
				{
					if (status != ValueTaskSourceStatus.Canceled)
					{
						return Task.FromException(ex);
					}
					OperationCanceledException ex2 = ex as OperationCanceledException;
					if (ex2 != null)
					{
						Task<VoidTaskResult> task = new Task<VoidTaskResult>();
						task.TrySetCanceled(ex2.CancellationToken, ex2);
						return task;
					}
					return ValueTask.s_canceledTask;
				}
			}
			return new ValueTask.ValueTaskSourceAsTask(t, this._token);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0004A510 File Offset: 0x00048710
		public bool IsCompleted
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return true;
				}
				Task task = obj as Task;
				if (task != null)
				{
					return task.IsCompleted;
				}
				return Unsafe.As<IValueTaskSource>(obj).GetStatus(this._token) > ValueTaskSourceStatus.Pending;
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0004A550 File Offset: 0x00048750
		[StackTraceHidden]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ThrowIfCompletedUnsuccessfully()
		{
			object obj = this._obj;
			if (obj != null)
			{
				Task task = obj as Task;
				if (task != null)
				{
					TaskAwaiter.ValidateEnd(task);
					return;
				}
				Unsafe.As<IValueTaskSource>(obj).GetResult(this._token);
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0004A589 File Offset: 0x00048789
		public ValueTaskAwaiter GetAwaiter()
		{
			return new ValueTaskAwaiter(this);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0004A596 File Offset: 0x00048796
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredValueTaskAwaitable(new ValueTask(this._obj, this._token, continueOnCapturedContext));
		}

		// Token: 0x04000742 RID: 1858
		private static readonly Task s_canceledTask = Task.FromCanceled(new CancellationToken(true));

		// Token: 0x04000743 RID: 1859
		internal readonly object _obj;

		// Token: 0x04000744 RID: 1860
		internal readonly short _token;

		// Token: 0x04000745 RID: 1861
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x02000204 RID: 516
		private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
		{
			// Token: 0x0600127A RID: 4730 RVA: 0x0004A5C1 File Offset: 0x000487C1
			public ValueTaskSourceAsTask(IValueTaskSource source, short token)
			{
				this._token = token;
				this._source = source;
				source.OnCompleted(ValueTask.ValueTaskSourceAsTask.s_completionAction, this, token, ValueTaskSourceOnCompletedFlags.None);
			}

			// Token: 0x04000746 RID: 1862
			private static readonly Action<object> s_completionAction = delegate(object state)
			{
				ValueTask.ValueTaskSourceAsTask valueTaskSourceAsTask = state as ValueTask.ValueTaskSourceAsTask;
				if (valueTaskSourceAsTask != null)
				{
					IValueTaskSource source = valueTaskSourceAsTask._source;
					if (source != null)
					{
						valueTaskSourceAsTask._source = null;
						ValueTaskSourceStatus status = source.GetStatus(valueTaskSourceAsTask._token);
						try
						{
							source.GetResult(valueTaskSourceAsTask._token);
							valueTaskSourceAsTask.TrySetResult(default(VoidTaskResult));
						}
						catch (Exception ex)
						{
							if (status == ValueTaskSourceStatus.Canceled)
							{
								OperationCanceledException ex2 = ex as OperationCanceledException;
								if (ex2 != null)
								{
									valueTaskSourceAsTask.TrySetCanceled(ex2.CancellationToken, ex2);
								}
								else
								{
									valueTaskSourceAsTask.TrySetCanceled(new CancellationToken(true));
								}
							}
							else
							{
								valueTaskSourceAsTask.TrySetException(ex);
							}
						}
						return;
					}
				}
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.state);
			};

			// Token: 0x04000747 RID: 1863
			private IValueTaskSource _source;

			// Token: 0x04000748 RID: 1864
			private readonly short _token;
		}
	}
}
