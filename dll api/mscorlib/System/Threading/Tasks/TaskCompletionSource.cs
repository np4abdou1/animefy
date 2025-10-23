using System;

namespace System.Threading.Tasks
{
	/// <summary>Represents the producer side of a <see cref="T:System.Threading.Tasks.Task`1" /> unbound to a delegate, providing access to the consumer side through the <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> property.</summary>
	/// <typeparam name="TResult">The type of the result value assocatied with this <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</typeparam>
	// Token: 0x020001FE RID: 510
	public class TaskCompletionSource<TResult>
	{
		/// <summary>Creates a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</summary>
		// Token: 0x06001254 RID: 4692 RVA: 0x0004A131 File Offset: 0x00048331
		public TaskCompletionSource()
		{
			this._task = new Task<TResult>();
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> with the specified options.</summary>
		/// <param name="creationOptions">The options to use when creating the underlying <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> represent options invalid for use with a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</exception>
		// Token: 0x06001255 RID: 4693 RVA: 0x0004A144 File Offset: 0x00048344
		public TaskCompletionSource(TaskCreationOptions creationOptions) : this(null, creationOptions)
		{
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> with the specified state.</summary>
		/// <param name="state">The state to use as the underlying <see cref="T:System.Threading.Tasks.Task`1" />'s AsyncState.</param>
		// Token: 0x06001256 RID: 4694 RVA: 0x0004A14E File Offset: 0x0004834E
		public TaskCompletionSource(object state) : this(state, TaskCreationOptions.None)
		{
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> with the specified state and options.</summary>
		/// <param name="state">The state to use as the underlying <see cref="T:System.Threading.Tasks.Task`1" />'s AsyncState.</param>
		/// <param name="creationOptions">The options to use when creating the underlying <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> represent options invalid for use with a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</exception>
		// Token: 0x06001257 RID: 4695 RVA: 0x0004A158 File Offset: 0x00048358
		public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
		{
			this._task = new Task<TResult>(state, creationOptions);
		}

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.Task`1" /> created by this <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</summary>
		/// <returns>Returns the <see cref="T:System.Threading.Tasks.Task`1" /> created by this <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</returns>
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0004A16D File Offset: 0x0004836D
		public Task<TResult> Task
		{
			get
			{
				return this._task;
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0004A178 File Offset: 0x00048378
		private void SpinUntilCompleted()
		{
			SpinWait spinWait = default(SpinWait);
			while (!this._task.IsCompleted)
			{
				spinWait.SpinOnce();
			}
		}

		/// <summary>Attempts to transition the underlying <see cref="T:System.Threading.Tasks.Task`1" /> into the <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> state and binds it to a specified exception.</summary>
		/// <param name="exception">The exception to bind to this <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <returns>True if the operation was successful; otherwise, false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> was disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="exception" /> argument is null.</exception>
		// Token: 0x0600125A RID: 4698 RVA: 0x0004A1A3 File Offset: 0x000483A3
		public bool TrySetException(Exception exception)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			bool flag = this._task.TrySetException(exception);
			if (!flag && !this._task.IsCompleted)
			{
				this.SpinUntilCompleted();
			}
			return flag;
		}

		/// <summary>Transitions the underlying <see cref="T:System.Threading.Tasks.Task`1" /> into the <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> state and binds it to a specified exception.</summary>
		/// <param name="exception">The exception to bind to this <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> was disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="exception" /> argument is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The underlying <see cref="T:System.Threading.Tasks.Task`1" /> is already in one of the three final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x0600125B RID: 4699 RVA: 0x0004A1D1 File Offset: 0x000483D1
		public void SetException(Exception exception)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			if (!this.TrySetException(exception))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		/// <summary>Attempts to transition the underlying <see cref="T:System.Threading.Tasks.Task`1" /> into the <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" /> state.</summary>
		/// <param name="result">The result value to bind to this <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <returns>True if the operation was successful; otherwise, false. </returns>
		// Token: 0x0600125C RID: 4700 RVA: 0x0004A1ED File Offset: 0x000483ED
		public bool TrySetResult(TResult result)
		{
			bool flag = this._task.TrySetResult(result);
			if (!flag)
			{
				this.SpinUntilCompleted();
			}
			return flag;
		}

		/// <summary>Transitions the underlying <see cref="T:System.Threading.Tasks.Task`1" /> into the <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" /> state.</summary>
		/// <param name="result">The result value to bind to this <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> was disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The underlying <see cref="T:System.Threading.Tasks.Task`1" /> is already in one of the three final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x0600125D RID: 4701 RVA: 0x0004A204 File Offset: 0x00048404
		public void SetResult(TResult result)
		{
			if (!this.TrySetResult(result))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x0400073C RID: 1852
		private readonly Task<TResult> _task;
	}
}
