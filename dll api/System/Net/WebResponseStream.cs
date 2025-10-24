using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001E4 RID: 484
	internal class WebResponseStream : WebConnectionStream
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000451CE File Offset: 0x000433CE
		public WebRequestStream RequestStream { get; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x000451D6 File Offset: 0x000433D6
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x000451DE File Offset: 0x000433DE
		public WebHeaderCollection Headers { get; private set; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x000451E7 File Offset: 0x000433E7
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x000451EF File Offset: 0x000433EF
		public HttpStatusCode StatusCode { get; private set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x000451F8 File Offset: 0x000433F8
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00045200 File Offset: 0x00043400
		public string StatusDescription { get; private set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00045209 File Offset: 0x00043409
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00045211 File Offset: 0x00043411
		public Version Version { get; private set; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0004521A File Offset: 0x0004341A
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00045222 File Offset: 0x00043422
		public bool KeepAlive { get; private set; }

		// Token: 0x06000D36 RID: 3382 RVA: 0x0004522B File Offset: 0x0004342B
		public WebResponseStream(WebRequestStream request) : base(request.Connection, request.Operation)
		{
			this.RequestStream = request;
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00009518 File Offset: 0x00007718
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00045251 File Offset: 0x00043451
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00045259 File Offset: 0x00043459
		private bool ChunkedRead { get; set; }

		// Token: 0x06000D3B RID: 3387 RVA: 0x00045264 File Offset: 0x00043464
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			WebResponseStream.<ReadAsync>d__40 <ReadAsync>d__;
			<ReadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ReadAsync>d__.<>4__this = this;
			<ReadAsync>d__.buffer = buffer;
			<ReadAsync>d__.offset = offset;
			<ReadAsync>d__.count = count;
			<ReadAsync>d__.cancellationToken = cancellationToken;
			<ReadAsync>d__.<>1__state = -1;
			<ReadAsync>d__.<>t__builder.Start<WebResponseStream.<ReadAsync>d__40>(ref <ReadAsync>d__);
			return <ReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000452C8 File Offset: 0x000434C8
		private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			if (this.read_eof)
			{
				return Task.FromResult<int>(0);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			return HttpWebRequest.RunWithTimeout<int>((CancellationToken ct) => this.innerStream.ReadAsync(buffer, offset, size, ct), this.ReadTimeout, delegate()
			{
				this.Operation.Abort();
				this.innerStream.Dispose();
			}, () => this.Operation.Aborted, cancellationToken);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00045348 File Offset: 0x00043548
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result)
		{
			if (this.bufferedEntireContent)
			{
				BufferedReadStream bufferedReadStream = this.innerStream as BufferedReadStream;
				if (bufferedReadStream != null)
				{
					return bufferedReadStream.TryReadFromBuffer(buffer, offset, count, out result);
				}
			}
			result = 0;
			return false;
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00045380 File Offset: 0x00043580
		private bool ExpectContent
		{
			get
			{
				return !(base.Request.Method == "HEAD") && (this.StatusCode >= HttpStatusCode.OK && this.StatusCode != HttpStatusCode.NoContent) && this.StatusCode != HttpStatusCode.NotModified;
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x000453D4 File Offset: 0x000435D4
		private void Initialize(BufferOffsetSize buffer)
		{
			string text = this.Headers["Transfer-Encoding"];
			bool flag = text != null && text.IndexOf("chunked", StringComparison.OrdinalIgnoreCase) != -1;
			string text2 = this.Headers["Content-Length"];
			long maxValue;
			if (!flag && !string.IsNullOrEmpty(text2))
			{
				if (!long.TryParse(text2, out maxValue))
				{
					maxValue = long.MaxValue;
				}
			}
			else
			{
				maxValue = long.MaxValue;
			}
			string text3 = null;
			if (this.ExpectContent)
			{
				text3 = this.Headers["Transfer-Encoding"];
			}
			this.ChunkedRead = (text3 != null && text3.IndexOf("chunked", StringComparison.OrdinalIgnoreCase) != -1);
			if (this.Version == HttpVersion.Version11 && this.RequestStream.KeepAlive)
			{
				this.KeepAlive = true;
				string text4 = this.Headers[base.ServicePoint.UsesProxy ? "Proxy-Connection" : "Connection"];
				if (text4 != null)
				{
					text4 = text4.ToLower();
					this.KeepAlive = (text4.IndexOf("keep-alive", StringComparison.Ordinal) != -1);
					if (text4.IndexOf("close", StringComparison.Ordinal) != -1)
					{
						this.KeepAlive = false;
					}
				}
				if (!this.ChunkedRead && maxValue == 9223372036854775807L)
				{
					this.KeepAlive = false;
				}
			}
			Stream stream;
			if (!this.ExpectContent || (!this.ChunkedRead && (long)buffer.Size >= maxValue))
			{
				this.bufferedEntireContent = true;
				this.innerStream = new BufferedReadStream(base.Operation, null, buffer);
				stream = this.innerStream;
			}
			else if (buffer.Size > 0)
			{
				stream = new BufferedReadStream(base.Operation, this.RequestStream.InnerStream, buffer);
			}
			else
			{
				stream = this.RequestStream.InnerStream;
			}
			if (this.ChunkedRead)
			{
				this.innerStream = new MonoChunkStream(base.Operation, stream, this.Headers);
			}
			else if (!this.bufferedEntireContent)
			{
				if (maxValue != 9223372036854775807L)
				{
					this.innerStream = new FixedSizeReadStream(base.Operation, stream, maxValue);
				}
				else
				{
					this.innerStream = new BufferedReadStream(base.Operation, stream, null);
				}
			}
			string a = this.Headers["Content-Encoding"];
			if (a == "gzip" && (base.Request.AutomaticDecompression & DecompressionMethods.GZip) != DecompressionMethods.None)
			{
				this.innerStream = ContentDecodeStream.Create(base.Operation, this.innerStream, ContentDecodeStream.Mode.GZip);
				this.Headers.Remove(HttpRequestHeader.ContentEncoding);
			}
			else if (a == "deflate" && (base.Request.AutomaticDecompression & DecompressionMethods.Deflate) != DecompressionMethods.None)
			{
				this.innerStream = ContentDecodeStream.Create(base.Operation, this.innerStream, ContentDecodeStream.Mode.Deflate);
				this.Headers.Remove(HttpRequestHeader.ContentEncoding);
			}
			if (!this.ExpectContent)
			{
				this.nextReadCalled = true;
				base.Operation.Finish(true, null);
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000456AC File Offset: 0x000438AC
		private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken)
		{
			WebResponseStream.<ReadAllAsyncInner>d__47 <ReadAllAsyncInner>d__;
			<ReadAllAsyncInner>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<ReadAllAsyncInner>d__.<>4__this = this;
			<ReadAllAsyncInner>d__.cancellationToken = cancellationToken;
			<ReadAllAsyncInner>d__.<>1__state = -1;
			<ReadAllAsyncInner>d__.<>t__builder.Start<WebResponseStream.<ReadAllAsyncInner>d__47>(ref <ReadAllAsyncInner>d__);
			return <ReadAllAsyncInner>d__.<>t__builder.Task;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x000456F8 File Offset: 0x000438F8
		internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken)
		{
			WebResponseStream.<ReadAllAsync>d__48 <ReadAllAsync>d__;
			<ReadAllAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ReadAllAsync>d__.<>4__this = this;
			<ReadAllAsync>d__.resending = resending;
			<ReadAllAsync>d__.cancellationToken = cancellationToken;
			<ReadAllAsync>d__.<>1__state = -1;
			<ReadAllAsync>d__.<>t__builder.Start<WebResponseStream.<ReadAllAsync>d__48>(ref <ReadAllAsync>d__);
			return <ReadAllAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0004574B File Offset: 0x0004394B
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return Task.FromException(new NotSupportedException("The stream does not support writing."));
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0004575C File Offset: 0x0004395C
		protected override void Close_internal(ref bool disposed)
		{
			if (!this.closed && !this.nextReadCalled)
			{
				this.nextReadCalled = true;
				if (this.read_eof || this.bufferedEntireContent)
				{
					disposed = true;
					WebReadStream webReadStream = this.innerStream;
					if (webReadStream != null)
					{
						webReadStream.Dispose();
					}
					this.innerStream = null;
					base.Operation.Finish(true, null);
					return;
				}
				this.closed = true;
				disposed = true;
				base.Operation.Finish(false, null);
			}
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000457D0 File Offset: 0x000439D0
		private WebException GetReadException(WebExceptionStatus status, Exception error, string where)
		{
			error = base.GetException(error);
			string.Format("Error getting response stream ({0}): {1}", where, status);
			if (error == null)
			{
				return new WebException(string.Format("Error getting response stream ({0}): {1}", where, status), status);
			}
			WebException ex = error as WebException;
			if (ex != null)
			{
				return ex;
			}
			if (base.Operation.Aborted || error is OperationCanceledException || error is ObjectDisposedException)
			{
				return HttpWebRequest.CreateRequestAbortedException();
			}
			return new WebException(string.Format("Error getting response stream ({0}): {1} {2}", where, status, error.Message), status, WebExceptionInternalStatus.RequestFatal, error);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00045864 File Offset: 0x00043A64
		internal Task InitReadAsync(CancellationToken cancellationToken)
		{
			WebResponseStream.<InitReadAsync>d__52 <InitReadAsync>d__;
			<InitReadAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InitReadAsync>d__.<>4__this = this;
			<InitReadAsync>d__.cancellationToken = cancellationToken;
			<InitReadAsync>d__.<>1__state = -1;
			<InitReadAsync>d__.<>t__builder.Start<WebResponseStream.<InitReadAsync>d__52>(ref <InitReadAsync>d__);
			return <InitReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x000458B0 File Offset: 0x00043AB0
		private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state)
		{
			string text = null;
			bool flag = false;
			bool flag2 = false;
			while (state != ReadState.Aborted)
			{
				if (state != ReadState.None)
				{
					goto IL_F2;
				}
				if (!WebConnection.ReadLine(buffer.Buffer, ref pos, buffer.Offset, ref text))
				{
					return false;
				}
				if (text == null)
				{
					flag2 = true;
				}
				else
				{
					flag2 = false;
					state = ReadState.Status;
					string[] array = text.Split(' ', StringSplitOptions.None);
					if (array.Length < 2)
					{
						throw this.GetReadException(WebExceptionStatus.ServerProtocolViolation, null, "GetResponse");
					}
					if (string.Compare(array[0], "HTTP/1.1", true) == 0)
					{
						this.Version = HttpVersion.Version11;
						base.ServicePoint.SetVersion(HttpVersion.Version11);
					}
					else
					{
						this.Version = HttpVersion.Version10;
						base.ServicePoint.SetVersion(HttpVersion.Version10);
					}
					this.StatusCode = (HttpStatusCode)uint.Parse(array[1]);
					if (array.Length >= 3)
					{
						this.StatusDescription = string.Join(" ", array, 2, array.Length - 2);
					}
					else
					{
						this.StatusDescription = string.Empty;
					}
					if (pos >= buffer.Offset)
					{
						return true;
					}
					goto IL_F2;
				}
				IL_27F:
				if (!flag2 && !flag)
				{
					throw this.GetReadException(WebExceptionStatus.ServerProtocolViolation, null, "GetResponse");
				}
				continue;
				IL_F2:
				flag2 = false;
				if (state != ReadState.Status)
				{
					goto IL_27F;
				}
				state = ReadState.Headers;
				this.Headers = new WebHeaderCollection();
				List<string> list = new List<string>();
				bool flag3 = false;
				while (!flag3 && WebConnection.ReadLine(buffer.Buffer, ref pos, buffer.Offset, ref text))
				{
					if (text == null)
					{
						flag3 = true;
					}
					else if (text.Length > 0 && (text[0] == ' ' || text[0] == '\t'))
					{
						int num = list.Count - 1;
						if (num < 0)
						{
							break;
						}
						string value = list[num] + text;
						list[num] = value;
					}
					else
					{
						list.Add(text);
					}
				}
				if (!flag3)
				{
					return false;
				}
				foreach (string text2 in list)
				{
					int num2 = text2.IndexOf(':');
					if (num2 == -1)
					{
						throw new ArgumentException("no colon found", "header");
					}
					string name = text2.Substring(0, num2);
					string value2 = text2.Substring(num2 + 1).Trim();
					if (WebHeaderCollection.AllowMultiValues(name))
					{
						this.Headers.AddInternal(name, value2);
					}
					else
					{
						this.Headers.SetInternal(name, value2);
					}
				}
				if (this.StatusCode != HttpStatusCode.Continue)
				{
					state = ReadState.Content;
					return true;
				}
				base.ServicePoint.SendContinue = true;
				if (pos >= buffer.Offset)
				{
					return true;
				}
				if (base.Request.ExpectContinue)
				{
					base.Request.DoContinueDelegate((int)this.StatusCode, this.Headers);
					base.Request.ExpectContinue = false;
				}
				state = ReadState.None;
				flag = true;
				goto IL_27F;
			}
			throw this.GetReadException(WebExceptionStatus.RequestCanceled, null, "GetResponse");
		}

		// Token: 0x040009EE RID: 2542
		private WebReadStream innerStream;

		// Token: 0x040009EF RID: 2543
		private bool nextReadCalled;

		// Token: 0x040009F0 RID: 2544
		private bool bufferedEntireContent;

		// Token: 0x040009F1 RID: 2545
		private WebCompletionSource pendingRead;

		// Token: 0x040009F2 RID: 2546
		private object locker = new object();

		// Token: 0x040009F3 RID: 2547
		private int nestedRead;

		// Token: 0x040009F4 RID: 2548
		private bool read_eof;
	}
}
