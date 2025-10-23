using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001C6 RID: 454
	internal class WebCompletionSource<T>
	{
		// Token: 0x06000C5B RID: 3163 RVA: 0x00040CCE File Offset: 0x0003EECE
		public WebCompletionSource(bool runAsync = true)
		{
			this.completion = new TaskCompletionSource<WebCompletionSource<T>.Result>(runAsync ? TaskCreationOptions.RunContinuationsAsynchronously : TaskCreationOptions.None);
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00040CE9 File Offset: 0x0003EEE9
		internal WebCompletionSource<T>.Result CurrentResult
		{
			get
			{
				return this.currentResult;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00040CF1 File Offset: 0x0003EEF1
		internal Task Task
		{
			get
			{
				return this.completion.Task;
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00040D00 File Offset: 0x0003EF00
		public bool TrySetCompleted(T argument)
		{
			WebCompletionSource<T>.Result result = new WebCompletionSource<T>.Result(argument);
			return Interlocked.CompareExchange<WebCompletionSource<T>.Result>(ref this.currentResult, result, null) == null && this.completion.TrySetResult(result);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00040D34 File Offset: 0x0003EF34
		public bool TrySetCompleted()
		{
			WebCompletionSource<T>.Result result = new WebCompletionSource<T>.Result(WebCompletionSource<T>.Status.Completed, null);
			return Interlocked.CompareExchange<WebCompletionSource<T>.Result>(ref this.currentResult, result, null) == null && this.completion.TrySetResult(result);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00040D66 File Offset: 0x0003EF66
		public bool TrySetCanceled()
		{
			return this.TrySetCanceled(new OperationCanceledException());
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00040D74 File Offset: 0x0003EF74
		public bool TrySetCanceled(OperationCanceledException error)
		{
			WebCompletionSource<T>.Result result = new WebCompletionSource<T>.Result(WebCompletionSource<T>.Status.Canceled, ExceptionDispatchInfo.Capture(error));
			return Interlocked.CompareExchange<WebCompletionSource<T>.Result>(ref this.currentResult, result, null) == null && this.completion.TrySetResult(result);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00040DAC File Offset: 0x0003EFAC
		public bool TrySetException(Exception error)
		{
			WebCompletionSource<T>.Result result = new WebCompletionSource<T>.Result(WebCompletionSource<T>.Status.Faulted, ExceptionDispatchInfo.Capture(error));
			return Interlocked.CompareExchange<WebCompletionSource<T>.Result>(ref this.currentResult, result, null) == null && this.completion.TrySetResult(result);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00040DE3 File Offset: 0x0003EFE3
		public void ThrowOnError()
		{
			if (!this.completion.Task.IsCompleted)
			{
				return;
			}
			ExceptionDispatchInfo error = this.completion.Task.Result.Error;
			if (error == null)
			{
				return;
			}
			error.Throw();
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00040E18 File Offset: 0x0003F018
		public Task<T> WaitForCompletion()
		{
			WebCompletionSource<T>.<WaitForCompletion>d__15 <WaitForCompletion>d__;
			<WaitForCompletion>d__.<>t__builder = AsyncTaskMethodBuilder<T>.Create();
			<WaitForCompletion>d__.<>4__this = this;
			<WaitForCompletion>d__.<>1__state = -1;
			<WaitForCompletion>d__.<>t__builder.Start<WebCompletionSource<T>.<WaitForCompletion>d__15>(ref <WaitForCompletion>d__);
			return <WaitForCompletion>d__.<>t__builder.Task;
		}

		// Token: 0x0400091D RID: 2333
		private TaskCompletionSource<WebCompletionSource<T>.Result> completion;

		// Token: 0x0400091E RID: 2334
		private WebCompletionSource<T>.Result currentResult;

		// Token: 0x020001C7 RID: 455
		internal enum Status
		{
			// Token: 0x04000920 RID: 2336
			Running,
			// Token: 0x04000921 RID: 2337
			Completed,
			// Token: 0x04000922 RID: 2338
			Canceled,
			// Token: 0x04000923 RID: 2339
			Faulted
		}

		// Token: 0x020001C8 RID: 456
		internal class Result
		{
			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00040E5B File Offset: 0x0003F05B
			public WebCompletionSource<T>.Status Status { get; }

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00040E63 File Offset: 0x0003F063
			public bool Success
			{
				get
				{
					return this.Status == WebCompletionSource<T>.Status.Completed;
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00040E6E File Offset: 0x0003F06E
			public ExceptionDispatchInfo Error { get; }

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00040E76 File Offset: 0x0003F076
			public T Argument { get; }

			// Token: 0x06000C69 RID: 3177 RVA: 0x00040E7E File Offset: 0x0003F07E
			public Result(T argument)
			{
				this.Status = 1;
				this.Argument = argument;
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x00040E94 File Offset: 0x0003F094
			public Result(WebCompletionSource<T>.Status state, ExceptionDispatchInfo error)
			{
				this.Status = state;
				this.Error = error;
			}
		}
	}
}
