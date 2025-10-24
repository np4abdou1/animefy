using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000200 RID: 512
	internal static class TaskToApm
	{
		// Token: 0x06001261 RID: 4705 RVA: 0x0004A234 File Offset: 0x00048434
		public static IAsyncResult Begin(Task task, AsyncCallback callback, object state)
		{
			IAsyncResult asyncResult;
			if (task.IsCompleted)
			{
				asyncResult = new TaskToApm.TaskWrapperAsyncResult(task, state, true);
				if (callback != null)
				{
					callback(asyncResult);
				}
			}
			else
			{
				IAsyncResult asyncResult3;
				if (task.AsyncState != state)
				{
					IAsyncResult asyncResult2 = new TaskToApm.TaskWrapperAsyncResult(task, state, false);
					asyncResult3 = asyncResult2;
				}
				else
				{
					asyncResult3 = task;
				}
				asyncResult = asyncResult3;
				if (callback != null)
				{
					TaskToApm.InvokeCallbackWhenTaskCompletes(task, callback, asyncResult);
				}
			}
			return asyncResult;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0004A284 File Offset: 0x00048484
		public static void End(IAsyncResult asyncResult)
		{
			TaskToApm.TaskWrapperAsyncResult taskWrapperAsyncResult = asyncResult as TaskToApm.TaskWrapperAsyncResult;
			Task task;
			if (taskWrapperAsyncResult != null)
			{
				task = taskWrapperAsyncResult.Task;
			}
			else
			{
				task = (asyncResult as Task);
			}
			if (task == null)
			{
				throw new ArgumentNullException();
			}
			task.GetAwaiter().GetResult();
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0004A2C4 File Offset: 0x000484C4
		public static TResult End<TResult>(IAsyncResult asyncResult)
		{
			TaskToApm.TaskWrapperAsyncResult taskWrapperAsyncResult = asyncResult as TaskToApm.TaskWrapperAsyncResult;
			Task<TResult> task;
			if (taskWrapperAsyncResult != null)
			{
				task = (taskWrapperAsyncResult.Task as Task<TResult>);
			}
			else
			{
				task = (asyncResult as Task<TResult>);
			}
			if (task == null)
			{
				throw new ArgumentNullException();
			}
			return task.GetAwaiter().GetResult();
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0004A308 File Offset: 0x00048508
		private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult)
		{
			antecedent.ConfigureAwait(false).GetAwaiter().OnCompleted(delegate
			{
				callback(asyncResult);
			});
		}

		// Token: 0x02000201 RID: 513
		private sealed class TaskWrapperAsyncResult : IAsyncResult
		{
			// Token: 0x06001265 RID: 4709 RVA: 0x0004A34C File Offset: 0x0004854C
			internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously)
			{
				this.Task = task;
				this._state = state;
				this._completedSynchronously = completedSynchronously;
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x06001266 RID: 4710 RVA: 0x0004A369 File Offset: 0x00048569
			object IAsyncResult.AsyncState
			{
				get
				{
					return this._state;
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x06001267 RID: 4711 RVA: 0x0004A371 File Offset: 0x00048571
			bool IAsyncResult.CompletedSynchronously
			{
				get
				{
					return this._completedSynchronously;
				}
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x06001268 RID: 4712 RVA: 0x0004A379 File Offset: 0x00048579
			bool IAsyncResult.IsCompleted
			{
				get
				{
					return this.Task.IsCompleted;
				}
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x06001269 RID: 4713 RVA: 0x0004A386 File Offset: 0x00048586
			WaitHandle IAsyncResult.AsyncWaitHandle
			{
				get
				{
					return ((IAsyncResult)this.Task).AsyncWaitHandle;
				}
			}

			// Token: 0x0400073D RID: 1853
			internal readonly Task Task;

			// Token: 0x0400073E RID: 1854
			private readonly object _state;

			// Token: 0x0400073F RID: 1855
			private readonly bool _completedSynchronously;
		}
	}
}
