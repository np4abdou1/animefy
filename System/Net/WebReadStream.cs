using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001D9 RID: 473
	internal abstract class WebReadStream : Stream
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0004362E File Offset: 0x0004182E
		public WebOperation Operation { get; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00043636 File Offset: 0x00041836
		protected Stream InnerStream { get; }

		// Token: 0x06000CEF RID: 3311 RVA: 0x0004363E File Offset: 0x0004183E
		public WebReadStream(WebOperation operation, Stream innerStream)
		{
			this.Operation = operation;
			this.InnerStream = innerStream;
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00009518 File Offset: 0x00007718
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00003E34 File Offset: 0x00002034
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00003E34 File Offset: 0x00002034
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00003E34 File Offset: 0x00002034
		public override void Flush()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00043654 File Offset: 0x00041854
		protected Exception GetException(Exception e)
		{
			e = HttpWebRequest.FlattenException(e);
			if (e is WebException)
			{
				return e;
			}
			if (this.Operation.Aborted || e is OperationCanceledException || e is ObjectDisposedException)
			{
				return HttpWebRequest.CreateRequestAbortedException();
			}
			return e;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0004368C File Offset: 0x0004188C
		public override int Read(byte[] buffer, int offset, int size)
		{
			if (!this.CanRead)
			{
				throw new NotSupportedException("The stream does not support reading.");
			}
			this.Operation.ThrowIfClosedOrDisposed();
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			int num = buffer.Length;
			if (offset < 0 || num < offset)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (size < 0 || num - offset < size)
			{
				throw new ArgumentOutOfRangeException("size");
			}
			int result;
			try
			{
				result = this.ReadAsync(buffer, offset, size, CancellationToken.None).Result;
			}
			catch (Exception e)
			{
				throw this.GetException(e);
			}
			return result;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00043724 File Offset: 0x00041924
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			if (!this.CanRead)
			{
				throw new NotSupportedException("The stream does not support reading.");
			}
			this.Operation.ThrowIfClosedOrDisposed();
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			int num = buffer.Length;
			if (offset < 0 || num < offset)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (size < 0 || num - offset < size)
			{
				throw new ArgumentOutOfRangeException("size");
			}
			return TaskToApm.Begin(this.ReadAsync(buffer, offset, size, CancellationToken.None), cb, state);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000437A0 File Offset: 0x000419A0
		public override int EndRead(IAsyncResult r)
		{
			if (r == null)
			{
				throw new ArgumentNullException("r");
			}
			int result;
			try
			{
				result = TaskToApm.End<int>(r);
			}
			catch (Exception e)
			{
				throw this.GetException(e);
			}
			return result;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000437E0 File Offset: 0x000419E0
		public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			WebReadStream.<ReadAsync>d__28 <ReadAsync>d__;
			<ReadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ReadAsync>d__.<>4__this = this;
			<ReadAsync>d__.buffer = buffer;
			<ReadAsync>d__.offset = offset;
			<ReadAsync>d__.size = size;
			<ReadAsync>d__.cancellationToken = cancellationToken;
			<ReadAsync>d__.<>1__state = -1;
			<ReadAsync>d__.<>t__builder.Start<WebReadStream.<ReadAsync>d__28>(ref <ReadAsync>d__);
			return <ReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000CFF RID: 3327
		protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

		// Token: 0x06000D00 RID: 3328 RVA: 0x00043844 File Offset: 0x00041A44
		internal virtual Task FinishReading(CancellationToken cancellationToken)
		{
			this.Operation.ThrowIfDisposed(cancellationToken);
			WebReadStream webReadStream = this.InnerStream as WebReadStream;
			if (webReadStream != null)
			{
				return webReadStream.FinishReading(cancellationToken);
			}
			return Task.CompletedTask;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00043879 File Offset: 0x00041A79
		protected override void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (this.InnerStream != null)
				{
					this.InnerStream.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x040009A1 RID: 2465
		private bool disposed;
	}
}
