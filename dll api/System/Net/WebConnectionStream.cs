using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001D1 RID: 465
	internal abstract class WebConnectionStream : Stream
	{
		// Token: 0x06000C93 RID: 3219 RVA: 0x00041F94 File Offset: 0x00040194
		protected WebConnectionStream(WebConnection cnc, WebOperation operation)
		{
			this.Connection = cnc;
			this.Operation = operation;
			this.Request = operation.Request;
			this.read_timeout = this.Request.ReadWriteTimeout;
			this.write_timeout = this.read_timeout;
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00041FE9 File Offset: 0x000401E9
		internal HttpWebRequest Request { get; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00041FF1 File Offset: 0x000401F1
		internal WebConnection Connection { get; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00041FF9 File Offset: 0x000401F9
		internal WebOperation Operation { get; }

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00042001 File Offset: 0x00040201
		internal ServicePoint ServicePoint
		{
			get
			{
				return this.Connection.ServicePoint;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00009518 File Offset: 0x00007718
		public override bool CanTimeout
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0004200E File Offset: 0x0004020E
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00042016 File Offset: 0x00040216
		public override int ReadTimeout
		{
			get
			{
				return this.read_timeout;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.read_timeout = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0004202E File Offset: 0x0004022E
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00042036 File Offset: 0x00040236
		public override int WriteTimeout
		{
			get
			{
				return this.write_timeout;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.write_timeout = value;
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0004204E File Offset: 0x0004024E
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

		// Token: 0x06000C9E RID: 3230
		protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

		// Token: 0x06000C9F RID: 3231 RVA: 0x00042088 File Offset: 0x00040288
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (!this.CanRead)
			{
				throw new NotSupportedException("The stream does not support reading.");
			}
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
			int result;
			if (this.TryReadFromBufferedContent(buffer, offset, count, out result))
			{
				return result;
			}
			this.Operation.ThrowIfClosedOrDisposed();
			int result2;
			try
			{
				result2 = this.ReadAsync(buffer, offset, count, CancellationToken.None).Result;
			}
			catch (Exception e)
			{
				throw this.GetException(e);
			}
			return result2;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0004212C File Offset: 0x0004032C
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
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
			if (count < 0 || num - offset < count)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			return TaskToApm.Begin(this.ReadAsync(buffer, offset, count, CancellationToken.None), cb, state);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000421A8 File Offset: 0x000403A8
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

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000421E8 File Offset: 0x000403E8
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
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
			if (!this.CanWrite)
			{
				throw new NotSupportedException("The stream does not support writing.");
			}
			this.Operation.ThrowIfClosedOrDisposed();
			return TaskToApm.Begin(this.WriteAsync(buffer, offset, count, CancellationToken.None), cb, state);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00042264 File Offset: 0x00040464
		public override void EndWrite(IAsyncResult r)
		{
			if (r == null)
			{
				throw new ArgumentNullException("r");
			}
			try
			{
				TaskToApm.End(r);
			}
			catch (Exception e)
			{
				throw this.GetException(e);
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000422A4 File Offset: 0x000404A4
		public override void Write(byte[] buffer, int offset, int count)
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
			if (!this.CanWrite)
			{
				throw new NotSupportedException("The stream does not support writing.");
			}
			this.Operation.ThrowIfClosedOrDisposed();
			try
			{
				base.WriteAsync(buffer, offset, count).Wait();
			}
			catch (Exception e)
			{
				throw this.GetException(e);
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00004D67 File Offset: 0x00002F67
		public override void Flush()
		{
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00042334 File Offset: 0x00040534
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return Task.CompletedTask;
			}
			return Task.FromCancellation(cancellationToken);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0004234B File Offset: 0x0004054B
		internal void InternalClose()
		{
			this.disposed = true;
		}

		// Token: 0x06000CA8 RID: 3240
		protected abstract void Close_internal(ref bool disposed);

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00042354 File Offset: 0x00040554
		public override void Close()
		{
			this.Close_internal(ref this.disposed);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00042362 File Offset: 0x00040562
		public override long Seek(long a, SeekOrigin b)
		{
			throw new NotSupportedException("This stream does not support seek operations.");
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00042362 File Offset: 0x00040562
		public override void SetLength(long a)
		{
			throw new NotSupportedException("This stream does not support seek operations.");
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00042362 File Offset: 0x00040562
		public override long Length
		{
			get
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00042362 File Offset: 0x00040562
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00042362 File Offset: 0x00040562
		public override long Position
		{
			get
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
			set
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
		}

		// Token: 0x04000959 RID: 2393
		protected bool closed;

		// Token: 0x0400095A RID: 2394
		private bool disposed;

		// Token: 0x0400095B RID: 2395
		private object locker = new object();

		// Token: 0x0400095C RID: 2396
		private int read_timeout;

		// Token: 0x0400095D RID: 2397
		private int write_timeout;
	}
}
