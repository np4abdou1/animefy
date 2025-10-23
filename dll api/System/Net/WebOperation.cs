using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001D6 RID: 470
	internal class WebOperation
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00042D16 File Offset: 0x00040F16
		public HttpWebRequest Request { get; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00042D1E File Offset: 0x00040F1E
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00042D26 File Offset: 0x00040F26
		public WebConnection Connection { get; private set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00042D2F File Offset: 0x00040F2F
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00042D37 File Offset: 0x00040F37
		public ServicePoint ServicePoint { get; private set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00042D40 File Offset: 0x00040F40
		public BufferOffsetSize WriteBuffer { get; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00042D48 File Offset: 0x00040F48
		public bool IsNtlmChallenge { get; }

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00042D50 File Offset: 0x00040F50
		public WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken)
		{
			this.Request = request;
			this.WriteBuffer = writeBuffer;
			this.IsNtlmChallenge = isNtlmChallenge;
			this.cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			this.requestTask = new WebCompletionSource<WebRequestStream>(true);
			this.requestWrittenTask = new WebCompletionSource<WebRequestStream>(true);
			this.responseTask = new WebCompletionSource<WebResponseStream>(true);
			this.finishedTask = new WebCompletionSource<ValueTuple<bool, WebOperation>>(true);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00042DB5 File Offset: 0x00040FB5
		public bool Aborted
		{
			get
			{
				return this.disposedInfo != null || this.Request.Aborted || (this.cts != null && this.cts.IsCancellationRequested);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00042DE6 File Offset: 0x00040FE6
		public bool Closed
		{
			get
			{
				return this.Aborted || this.closedInfo != null;
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00042DFB File Offset: 0x00040FFB
		public void Abort()
		{
			if (!this.SetDisposed(ref this.disposedInfo).Item2)
			{
				return;
			}
			CancellationTokenSource cancellationTokenSource = this.cts;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
			this.SetCanceled();
			this.Close();
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00042E30 File Offset: 0x00041030
		public void Close()
		{
			if (!this.SetDisposed(ref this.closedInfo).Item2)
			{
				return;
			}
			WebRequestStream webRequestStream = Interlocked.Exchange<WebRequestStream>(ref this.writeStream, null);
			if (webRequestStream != null)
			{
				try
				{
					webRequestStream.Close();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00042E7C File Offset: 0x0004107C
		private void SetCanceled()
		{
			OperationCanceledException error = new OperationCanceledException();
			this.requestTask.TrySetCanceled(error);
			this.requestWrittenTask.TrySetCanceled(error);
			this.responseTask.TrySetCanceled(error);
			this.Finish(false, error);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00042EBE File Offset: 0x000410BE
		private void SetError(Exception error)
		{
			this.requestTask.TrySetException(error);
			this.requestWrittenTask.TrySetException(error);
			this.responseTask.TrySetException(error);
			this.Finish(false, error);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00042EF0 File Offset: 0x000410F0
		private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field)
		{
			ExceptionDispatchInfo exceptionDispatchInfo = ExceptionDispatchInfo.Capture(new WebException(SR.GetString("The request was canceled"), WebExceptionStatus.RequestCanceled));
			ExceptionDispatchInfo exceptionDispatchInfo2 = Interlocked.CompareExchange<ExceptionDispatchInfo>(ref field, exceptionDispatchInfo, null);
			return new ValueTuple<ExceptionDispatchInfo, bool>(exceptionDispatchInfo2 ?? exceptionDispatchInfo, exceptionDispatchInfo2 == null);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00042F2B File Offset: 0x0004112B
		internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken)
		{
			if (this.Aborted || cancellationToken.IsCancellationRequested)
			{
				return this.CheckThrowDisposed(false, ref this.disposedInfo);
			}
			return null;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00042F4D File Offset: 0x0004114D
		internal void ThrowIfDisposed()
		{
			this.ThrowIfDisposed(CancellationToken.None);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00042F5A File Offset: 0x0004115A
		internal void ThrowIfDisposed(CancellationToken cancellationToken)
		{
			if (this.Aborted || cancellationToken.IsCancellationRequested)
			{
				this.CheckThrowDisposed(true, ref this.disposedInfo);
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00042F7B File Offset: 0x0004117B
		internal void ThrowIfClosedOrDisposed()
		{
			this.ThrowIfClosedOrDisposed(CancellationToken.None);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00042F88 File Offset: 0x00041188
		internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken)
		{
			if (this.Closed || cancellationToken.IsCancellationRequested)
			{
				this.CheckThrowDisposed(true, ref this.closedInfo);
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00042FAC File Offset: 0x000411AC
		private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field)
		{
			ValueTuple<ExceptionDispatchInfo, bool> valueTuple = this.SetDisposed(ref field);
			ExceptionDispatchInfo item = valueTuple.Item1;
			if (valueTuple.Item2)
			{
				CancellationTokenSource cancellationTokenSource = this.cts;
				if (cancellationTokenSource != null)
				{
					cancellationTokenSource.Cancel();
				}
			}
			if (throwIt)
			{
				item.Throw();
			}
			return item;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00042FEC File Offset: 0x000411EC
		internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection)
		{
			if (servicePoint == null)
			{
				throw new ArgumentNullException("servicePoint");
			}
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			lock (this)
			{
				if (Interlocked.CompareExchange(ref this.requestSent, 1, 0) != 0)
				{
					throw new InvalidOperationException("Invalid nested call.");
				}
				this.ServicePoint = servicePoint;
				this.Connection = connection;
			}
			this.cts.Token.Register(delegate()
			{
				this.Request.FinishedReading = true;
				this.SetDisposed(ref this.disposedInfo);
			});
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00043088 File Offset: 0x00041288
		public void SetPriorityRequest(WebOperation operation)
		{
			lock (this)
			{
				if (this.requestSent != 1 || this.ServicePoint == null || this.finished != 0)
				{
					throw new InvalidOperationException("Should never happen.");
				}
				if (Interlocked.CompareExchange<WebOperation>(ref this.priorityRequest, operation, null) != null)
				{
					throw new InvalidOperationException("Invalid nested request.");
				}
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000430FC File Offset: 0x000412FC
		public Task<Stream> GetRequestStream()
		{
			WebOperation.<GetRequestStream>d__50 <GetRequestStream>d__;
			<GetRequestStream>d__.<>t__builder = AsyncTaskMethodBuilder<Stream>.Create();
			<GetRequestStream>d__.<>4__this = this;
			<GetRequestStream>d__.<>1__state = -1;
			<GetRequestStream>d__.<>t__builder.Start<WebOperation.<GetRequestStream>d__50>(ref <GetRequestStream>d__);
			return <GetRequestStream>d__.<>t__builder.Task;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0004313F File Offset: 0x0004133F
		internal Task<WebRequestStream> GetRequestStreamInternal()
		{
			return this.requestTask.WaitForCompletion();
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0004314C File Offset: 0x0004134C
		public WebRequestStream WriteStream
		{
			get
			{
				this.ThrowIfDisposed();
				return this.writeStream;
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0004315A File Offset: 0x0004135A
		public Task<WebResponseStream> GetResponseStream()
		{
			return this.responseTask.WaitForCompletion();
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00043167 File Offset: 0x00041367
		internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished
		{
			get
			{
				return this.finishedTask;
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00043170 File Offset: 0x00041370
		internal void Run()
		{
			WebOperation.<Run>d__58 <Run>d__;
			<Run>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<WebOperation.<Run>d__58>(ref <Run>d__);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000431A7 File Offset: 0x000413A7
		internal void CompleteRequestWritten(WebRequestStream stream, Exception error = null)
		{
			if (error != null)
			{
				this.SetError(error);
				return;
			}
			this.requestWrittenTask.TrySetCompleted(stream);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000431C4 File Offset: 0x000413C4
		internal void Finish(bool ok, Exception error = null)
		{
			if (Interlocked.CompareExchange(ref this.finished, 1, 0) != 0)
			{
				return;
			}
			WebResponseStream webResponseStream;
			WebOperation webOperation;
			lock (this)
			{
				webResponseStream = Interlocked.Exchange<WebResponseStream>(ref this.responseStream, null);
				webOperation = Interlocked.Exchange<WebOperation>(ref this.priorityRequest, null);
				this.Request.FinishedReading = true;
			}
			if (error != null)
			{
				if (webOperation != null)
				{
					webOperation.SetError(error);
				}
				this.finishedTask.TrySetException(error);
				return;
			}
			bool item = !this.Aborted && ok && webResponseStream != null && webResponseStream.KeepAlive;
			if (webOperation != null && webOperation.Aborted)
			{
				webOperation = null;
				item = false;
			}
			this.finishedTask.TrySetCompleted(new ValueTuple<bool, WebOperation>(item, webOperation));
		}

		// Token: 0x04000988 RID: 2440
		private CancellationTokenSource cts;

		// Token: 0x04000989 RID: 2441
		private WebCompletionSource<WebRequestStream> requestTask;

		// Token: 0x0400098A RID: 2442
		private WebCompletionSource<WebRequestStream> requestWrittenTask;

		// Token: 0x0400098B RID: 2443
		private WebCompletionSource<WebResponseStream> responseTask;

		// Token: 0x0400098C RID: 2444
		private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask;

		// Token: 0x0400098D RID: 2445
		private WebRequestStream writeStream;

		// Token: 0x0400098E RID: 2446
		private WebResponseStream responseStream;

		// Token: 0x0400098F RID: 2447
		private ExceptionDispatchInfo disposedInfo;

		// Token: 0x04000990 RID: 2448
		private ExceptionDispatchInfo closedInfo;

		// Token: 0x04000991 RID: 2449
		private WebOperation priorityRequest;

		// Token: 0x04000992 RID: 2450
		private int requestSent;

		// Token: 0x04000993 RID: 2451
		private int finished;
	}
}
