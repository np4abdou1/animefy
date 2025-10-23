using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Extensions
{
	// Token: 0x0200001D RID: 29
	internal class AwaitableTaskCompleteListener<TResult> : Java.Lang.Object, IOnCompleteListener, IJavaObject, IDisposable, IJavaPeerable where TResult : class, IJavaObject
	{
		// Token: 0x06000105 RID: 261 RVA: 0x000046DD File Offset: 0x000028DD
		public AwaitableTaskCompleteListener()
		{
			this.taskCompletionSource = new TaskCompletionSource<TResult>();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000046F0 File Offset: 0x000028F0
		public void OnComplete(Android.Gms.Tasks.Task task)
		{
			if (task.IsSuccessful)
			{
				TaskCompletionSource<TResult> taskCompletionSource = this.taskCompletionSource;
				TResult result;
				if (task == null)
				{
					result = default(TResult);
				}
				else
				{
					Java.Lang.Object result2 = task.Result;
					result = ((result2 != null) ? result2.JavaCast<TResult>() : default(TResult));
				}
				taskCompletionSource.SetResult(result);
				return;
			}
			this.taskCompletionSource.SetException(task.Exception);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000474A File Offset: 0x0000294A
		public Task<TResult> AwaitAsync()
		{
			return this.taskCompletionSource.Task;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004757 File Offset: 0x00002957
		public TaskAwaiter<TResult> GetAwaiter()
		{
			return this.taskCompletionSource.Task.GetAwaiter();
		}

		// Token: 0x04000041 RID: 65
		private TaskCompletionSource<TResult> taskCompletionSource;
	}
}
