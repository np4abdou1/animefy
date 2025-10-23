using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001DB RID: 475
	internal class WebRequestStream : WebConnectionStream
	{
		// Token: 0x06000D04 RID: 3332 RVA: 0x00043AEC File Offset: 0x00041CEC
		public WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) : base(connection, operation)
		{
			this.InnerStream = stream;
			this.allowBuffering = operation.Request.InternalAllowBuffering;
			this.sendChunked = (operation.Request.SendChunked && operation.WriteBuffer == null);
			if (!this.sendChunked && this.allowBuffering && operation.WriteBuffer == null)
			{
				this.writeBuffer = new MemoryStream();
			}
			this.KeepAlive = base.Request.KeepAlive;
			if (((tunnel != null) ? tunnel.ProxyVersion : null) != null && ((tunnel != null) ? tunnel.ProxyVersion : null) != HttpVersion.Version11)
			{
				this.KeepAlive = 0;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00043BA3 File Offset: 0x00041DA3
		internal Stream InnerStream { get; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00043BAB File Offset: 0x00041DAB
		public bool KeepAlive { get; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00009518 File Offset: 0x00007718
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00043BB3 File Offset: 0x00041DB3
		internal bool HasWriteBuffer
		{
			get
			{
				return base.Operation.WriteBuffer != null || this.writeBuffer != null;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00043BCD File Offset: 0x00041DCD
		internal int WriteBufferLength
		{
			get
			{
				if (base.Operation.WriteBuffer != null)
				{
					return base.Operation.WriteBuffer.Size;
				}
				if (this.writeBuffer != null)
				{
					return (int)this.writeBuffer.Length;
				}
				return -1;
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00043C04 File Offset: 0x00041E04
		internal BufferOffsetSize GetWriteBuffer()
		{
			if (base.Operation.WriteBuffer != null)
			{
				return base.Operation.WriteBuffer;
			}
			if (this.writeBuffer == null || this.writeBuffer.Length == 0L)
			{
				return null;
			}
			return new BufferOffsetSize(this.writeBuffer.GetBuffer(), 0, (int)this.writeBuffer.Length, false);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00043C60 File Offset: 0x00041E60
		private Task FinishWriting(CancellationToken cancellationToken)
		{
			WebRequestStream.<FinishWriting>d__31 <FinishWriting>d__;
			<FinishWriting>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishWriting>d__.<>4__this = this;
			<FinishWriting>d__.cancellationToken = cancellationToken;
			<FinishWriting>d__.<>1__state = -1;
			<FinishWriting>d__.<>t__builder.Start<WebRequestStream.<FinishWriting>d__31>(ref <FinishWriting>d__);
			return <FinishWriting>d__.<>t__builder.Task;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00043CAC File Offset: 0x00041EAC
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			int num = buffer.Length;
			if (offset < 0 || num < offset)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || num - offset < count)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			base.Operation.ThrowIfClosedOrDisposed(cancellationToken);
			if (base.Operation.WriteBuffer != null)
			{
				throw new InvalidOperationException();
			}
			WebCompletionSource webCompletionSource = new WebCompletionSource();
			if (Interlocked.CompareExchange<WebCompletionSource>(ref this.pendingWrite, webCompletionSource, null) != null)
			{
				throw new InvalidOperationException(SR.GetString("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress."));
			}
			return this.WriteAsyncInner(buffer, offset, count, webCompletionSource, cancellationToken);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00043D58 File Offset: 0x00041F58
		private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken)
		{
			WebRequestStream.<WriteAsyncInner>d__33 <WriteAsyncInner>d__;
			<WriteAsyncInner>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncInner>d__.<>4__this = this;
			<WriteAsyncInner>d__.buffer = buffer;
			<WriteAsyncInner>d__.offset = offset;
			<WriteAsyncInner>d__.size = size;
			<WriteAsyncInner>d__.completion = completion;
			<WriteAsyncInner>d__.cancellationToken = cancellationToken;
			<WriteAsyncInner>d__.<>1__state = -1;
			<WriteAsyncInner>d__.<>t__builder.Start<WebRequestStream.<WriteAsyncInner>d__33>(ref <WriteAsyncInner>d__);
			return <WriteAsyncInner>d__.<>t__builder.Task;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00043DC8 File Offset: 0x00041FC8
		private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			WebRequestStream.<ProcessWrite>d__34 <ProcessWrite>d__;
			<ProcessWrite>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ProcessWrite>d__.<>4__this = this;
			<ProcessWrite>d__.buffer = buffer;
			<ProcessWrite>d__.offset = offset;
			<ProcessWrite>d__.size = size;
			<ProcessWrite>d__.cancellationToken = cancellationToken;
			<ProcessWrite>d__.<>1__state = -1;
			<ProcessWrite>d__.<>t__builder.Start<WebRequestStream.<ProcessWrite>d__34>(ref <ProcessWrite>d__);
			return <ProcessWrite>d__.<>t__builder.Task;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00043E2C File Offset: 0x0004202C
		private void CheckWriteOverflow(long contentLength, long totalWritten, long size)
		{
			if (contentLength == -1L)
			{
				return;
			}
			long num = contentLength - totalWritten;
			if (size > num)
			{
				this.KillBuffer();
				this.closed = true;
				ProtocolViolationException ex = new ProtocolViolationException("The number of bytes to be written is greater than the specified ContentLength.");
				base.Operation.CompleteRequestWritten(this, ex);
				throw ex;
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00043E70 File Offset: 0x00042070
		internal Task Initialize(CancellationToken cancellationToken)
		{
			WebRequestStream.<Initialize>d__36 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.cancellationToken = cancellationToken;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<WebRequestStream.<Initialize>d__36>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00043EBC File Offset: 0x000420BC
		private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken)
		{
			WebRequestStream.<SetHeadersAsync>d__37 <SetHeadersAsync>d__;
			<SetHeadersAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetHeadersAsync>d__.<>4__this = this;
			<SetHeadersAsync>d__.setInternalLength = setInternalLength;
			<SetHeadersAsync>d__.cancellationToken = cancellationToken;
			<SetHeadersAsync>d__.<>1__state = -1;
			<SetHeadersAsync>d__.<>t__builder.Start<WebRequestStream.<SetHeadersAsync>d__37>(ref <SetHeadersAsync>d__);
			return <SetHeadersAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00043F10 File Offset: 0x00042110
		internal Task WriteRequestAsync(CancellationToken cancellationToken)
		{
			WebRequestStream.<WriteRequestAsync>d__38 <WriteRequestAsync>d__;
			<WriteRequestAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteRequestAsync>d__.<>4__this = this;
			<WriteRequestAsync>d__.cancellationToken = cancellationToken;
			<WriteRequestAsync>d__.<>1__state = -1;
			<WriteRequestAsync>d__.<>t__builder.Start<WebRequestStream.<WriteRequestAsync>d__38>(ref <WriteRequestAsync>d__);
			return <WriteRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00043F5C File Offset: 0x0004215C
		private Task WriteChunkTrailer_inner(CancellationToken cancellationToken)
		{
			WebRequestStream.<WriteChunkTrailer_inner>d__39 <WriteChunkTrailer_inner>d__;
			<WriteChunkTrailer_inner>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteChunkTrailer_inner>d__.<>4__this = this;
			<WriteChunkTrailer_inner>d__.cancellationToken = cancellationToken;
			<WriteChunkTrailer_inner>d__.<>1__state = -1;
			<WriteChunkTrailer_inner>d__.<>t__builder.Start<WebRequestStream.<WriteChunkTrailer_inner>d__39>(ref <WriteChunkTrailer_inner>d__);
			return <WriteChunkTrailer_inner>d__.<>t__builder.Task;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00043FA8 File Offset: 0x000421A8
		private Task WriteChunkTrailer()
		{
			WebRequestStream.<WriteChunkTrailer>d__40 <WriteChunkTrailer>d__;
			<WriteChunkTrailer>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteChunkTrailer>d__.<>4__this = this;
			<WriteChunkTrailer>d__.<>1__state = -1;
			<WriteChunkTrailer>d__.<>t__builder.Start<WebRequestStream.<WriteChunkTrailer>d__40>(ref <WriteChunkTrailer>d__);
			return <WriteChunkTrailer>d__.<>t__builder.Task;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00043FEB File Offset: 0x000421EB
		internal void KillBuffer()
		{
			this.writeBuffer = null;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00043FF4 File Offset: 0x000421F4
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return Task.FromException<int>(new NotSupportedException("The stream does not support reading."));
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00044005 File Offset: 0x00042205
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0004400C File Offset: 0x0004220C
		protected override void Close_internal(ref bool disposed)
		{
			if (disposed)
			{
				return;
			}
			disposed = true;
			if (this.sendChunked)
			{
				this.WriteChunkTrailer().Wait();
				return;
			}
			if (!this.allowBuffering || this.requestWritten)
			{
				base.Operation.CompleteRequestWritten(this, null);
				return;
			}
			long contentLength = base.Request.ContentLength;
			if (!this.sendChunked && !base.Operation.IsNtlmChallenge && contentLength != -1L && this.totalWritten != contentLength)
			{
				IOException innerException = new IOException("Cannot close the stream until all bytes are written");
				this.closed = true;
				disposed = true;
				WebException ex = new WebException("Request was cancelled.", WebExceptionStatus.RequestCanceled, WebExceptionInternalStatus.RequestFatal, innerException);
				base.Operation.CompleteRequestWritten(this, ex);
				throw ex;
			}
			disposed = true;
			base.Operation.CompleteRequestWritten(this, null);
		}

		// Token: 0x040009AB RID: 2475
		private static byte[] crlf = new byte[]
		{
			13,
			10
		};

		// Token: 0x040009AC RID: 2476
		private MemoryStream writeBuffer;

		// Token: 0x040009AD RID: 2477
		private bool requestWritten;

		// Token: 0x040009AE RID: 2478
		private bool allowBuffering;

		// Token: 0x040009AF RID: 2479
		private bool sendChunked;

		// Token: 0x040009B0 RID: 2480
		private WebCompletionSource pendingWrite;

		// Token: 0x040009B1 RID: 2481
		private long totalWritten;

		// Token: 0x040009B2 RID: 2482
		private byte[] headers;

		// Token: 0x040009B3 RID: 2483
		private bool headersSent;

		// Token: 0x040009B4 RID: 2484
		private int completeRequestWritten;

		// Token: 0x040009B5 RID: 2485
		private int chunkTrailerWritten;
	}
}
