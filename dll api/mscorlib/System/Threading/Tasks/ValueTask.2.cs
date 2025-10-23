using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks
{
	// Token: 0x02000206 RID: 518
	[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<>))]
	[StructLayout(3)]
	public readonly struct ValueTask<TResult> : IEquatable<ValueTask<TResult>>
	{
		// Token: 0x0600127F RID: 4735 RVA: 0x0004A6B4 File Offset: 0x000488B4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(TResult result)
		{
			this._result = result;
			this._obj = null;
			this._continueOnCapturedContext = true;
			this._token = 0;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0004A6D2 File Offset: 0x000488D2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(Task<TResult> task)
		{
			if (task == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.task);
			}
			this._obj = task;
			this._result = default(TResult);
			this._continueOnCapturedContext = true;
			this._token = 0;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0004A6FF File Offset: 0x000488FF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(IValueTaskSource<TResult> source, short token)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			this._obj = source;
			this._token = token;
			this._result = default(TResult);
			this._continueOnCapturedContext = true;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0004A72C File Offset: 0x0004892C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ValueTask(object obj, TResult result, short token, bool continueOnCapturedContext)
		{
			this._obj = obj;
			this._result = result;
			this._token = token;
			this._continueOnCapturedContext = continueOnCapturedContext;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0004A74C File Offset: 0x0004894C
		public override int GetHashCode()
		{
			if (this._obj != null)
			{
				return this._obj.GetHashCode();
			}
			if (this._result == null)
			{
				return 0;
			}
			TResult result = this._result;
			return result.GetHashCode();
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0004A790 File Offset: 0x00048990
		public override bool Equals(object obj)
		{
			return obj is ValueTask<TResult> && this.Equals((ValueTask<TResult>)obj);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0004A7A8 File Offset: 0x000489A8
		public bool Equals(ValueTask<TResult> other)
		{
			if (this._obj == null && other._obj == null)
			{
				return EqualityComparer<TResult>.Default.Equals(this._result, other._result);
			}
			return this._obj == other._obj && this._token == other._token;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0004A7FC File Offset: 0x000489FC
		public Task<TResult> AsTask()
		{
			object obj = this._obj;
			if (obj == null)
			{
				return AsyncTaskMethodBuilder<TResult>.GetTaskForResult(this._result);
			}
			Task<TResult> task = obj as Task<TResult>;
			if (task != null)
			{
				return task;
			}
			return this.GetTaskForValueTaskSource(Unsafe.As<IValueTaskSource<TResult>>(obj));
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0004A838 File Offset: 0x00048A38
		private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t)
		{
			ValueTaskSourceStatus status = t.GetStatus(this._token);
			if (status != ValueTaskSourceStatus.Pending)
			{
				try
				{
					return AsyncTaskMethodBuilder<TResult>.GetTaskForResult(t.GetResult(this._token));
				}
				catch (Exception ex)
				{
					if (status != ValueTaskSourceStatus.Canceled)
					{
						return Task.FromException<TResult>(ex);
					}
					OperationCanceledException ex2 = ex as OperationCanceledException;
					if (ex2 != null)
					{
						Task<TResult> task = new Task<TResult>();
						task.TrySetCanceled(ex2.CancellationToken, ex2);
						return task;
					}
					Task<TResult> task2 = ValueTask<TResult>.s_canceledTask;
					if (task2 == null)
					{
						task2 = Task.FromCanceled<TResult>(new CancellationToken(true));
						ValueTask<TResult>.s_canceledTask = task2;
					}
					return task2;
				}
			}
			return new ValueTask<TResult>.ValueTaskSourceAsTask(t, this._token);
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0004A8DC File Offset: 0x00048ADC
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
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					return task.IsCompleted;
				}
				return Unsafe.As<IValueTaskSource<TResult>>(obj).GetStatus(this._token) > ValueTaskSourceStatus.Pending;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0004A91C File Offset: 0x00048B1C
		public bool IsCompletedSuccessfully
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return true;
				}
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					return task.IsCompletedSuccessfully;
				}
				return Unsafe.As<IValueTaskSource<TResult>>(obj).GetStatus(this._token) == ValueTaskSourceStatus.Succeeded;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x0004A95C File Offset: 0x00048B5C
		public TResult Result
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return this._result;
				}
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					TaskAwaiter.ValidateEnd(task);
					return task.ResultOnSuccess;
				}
				return Unsafe.As<IValueTaskSource<TResult>>(obj).GetResult(this._token);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0004A9A2 File Offset: 0x00048BA2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTaskAwaiter<TResult> GetAwaiter()
		{
			return new ValueTaskAwaiter<TResult>(this);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0004A9AF File Offset: 0x00048BAF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredValueTaskAwaitable<TResult>(new ValueTask<TResult>(this._obj, this._result, this._token, continueOnCapturedContext));
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0004A9D0 File Offset: 0x00048BD0
		public override string ToString()
		{
			if (this.IsCompletedSuccessfully)
			{
				TResult result = this.Result;
				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}

		// Token: 0x0400074A RID: 1866
		private static Task<TResult> s_canceledTask;

		// Token: 0x0400074B RID: 1867
		internal readonly object _obj;

		// Token: 0x0400074C RID: 1868
		internal readonly TResult _result;

		// Token: 0x0400074D RID: 1869
		internal readonly short _token;

		// Token: 0x0400074E RID: 1870
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x02000207 RID: 519
		private sealed class ValueTaskSourceAsTask : Task<TResult>
		{
			// Token: 0x0600128E RID: 4750 RVA: 0x0004AA07 File Offset: 0x00048C07
			public ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token)
			{
				this._source = source;
				this._token = token;
				source.OnCompleted(ValueTask<TResult>.ValueTaskSourceAsTask.s_completionAction, this, token, ValueTaskSourceOnCompletedFlags.None);
			}

			// Token: 0x0400074F RID: 1871
			private static readonly Action<object> s_completionAction = delegate(object state)
			{
				ValueTask<TResult>.ValueTaskSourceAsTask valueTaskSourceAsTask = state as ValueTask<TResult>.ValueTaskSourceAsTask;
				if (valueTaskSourceAsTask != null)
				{
					IValueTaskSource<TResult> source = valueTaskSourceAsTask._source;
					if (source != null)
					{
						valueTaskSourceAsTask._source = null;
						ValueTaskSourceStatus status = source.GetStatus(valueTaskSourceAsTask._token);
						try
						{
							valueTaskSourceAsTask.TrySetResult(source.GetResult(valueTaskSourceAsTask._token));
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

			// Token: 0x04000750 RID: 1872
			private IValueTaskSource<TResult> _source;

			// Token: 0x04000751 RID: 1873
			private readonly short _token;
		}
	}
}
