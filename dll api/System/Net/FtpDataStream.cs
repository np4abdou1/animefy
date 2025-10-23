using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Net
{
	// Token: 0x02000122 RID: 290
	internal class FtpDataStream : Stream, ICloseEx
	{
		// Token: 0x0600084A RID: 2122 RVA: 0x0002F0DC File Offset: 0x0002D2DC
		internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, null, ".ctor");
			}
			this._readable = true;
			this._writeable = true;
			if (writeOnly == TriState.True)
			{
				this._readable = false;
			}
			else if (writeOnly == TriState.False)
			{
				this._writeable = false;
			}
			this._networkStream = networkStream;
			this._request = request;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0002F138 File Offset: 0x0002D338
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					((ICloseEx)this).CloseEx(CloseExState.Normal);
				}
				else
				{
					((ICloseEx)this).CloseEx(CloseExState.Abort | CloseExState.Silent);
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0002F174 File Offset: 0x0002D374
		void ICloseEx.CloseEx(CloseExState closeState)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, FormattableStringFactory.Create("state = {0}", new object[]
				{
					closeState
				}), "CloseEx");
			}
			lock (this)
			{
				if (this._closing)
				{
					return;
				}
				this._closing = true;
				this._writeable = false;
				this._readable = false;
			}
			try
			{
				try
				{
					if ((closeState & CloseExState.Abort) == CloseExState.Normal)
					{
						this._networkStream.Close(-1);
					}
					else
					{
						this._networkStream.Close(0);
					}
				}
				finally
				{
					this._request.DataStreamClosed(closeState);
				}
			}
			catch (Exception ex)
			{
				bool flag2 = true;
				WebException ex2 = ex as WebException;
				if (ex2 != null)
				{
					FtpWebResponse ftpWebResponse = ex2.Response as FtpWebResponse;
					if (ftpWebResponse != null && !this._isFullyRead && ftpWebResponse.StatusCode == FtpStatusCode.ConnectionClosed)
					{
						flag2 = false;
					}
				}
				if (flag2 && (closeState & CloseExState.Silent) == CloseExState.Normal)
				{
					throw;
				}
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0002F280 File Offset: 0x0002D480
		private void CheckError()
		{
			if (this._request.Aborted)
			{
				throw ExceptionHelper.RequestAbortedException;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0002F295 File Offset: 0x0002D495
		public override bool CanRead
		{
			get
			{
				return this._readable;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0002F29D File Offset: 0x0002D49D
		public override bool CanSeek
		{
			get
			{
				return this._networkStream.CanSeek;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x0002F2AA File Offset: 0x0002D4AA
		public override bool CanWrite
		{
			get
			{
				return this._writeable;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0002F2B2 File Offset: 0x0002D4B2
		public override long Length
		{
			get
			{
				return this._networkStream.Length;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0002F2BF File Offset: 0x0002D4BF
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x0002F2CC File Offset: 0x0002D4CC
		public override long Position
		{
			get
			{
				return this._networkStream.Position;
			}
			set
			{
				this._networkStream.Position = value;
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0002F2DC File Offset: 0x0002D4DC
		public override long Seek(long offset, SeekOrigin origin)
		{
			this.CheckError();
			long result;
			try
			{
				result = this._networkStream.Seek(offset, origin);
			}
			catch
			{
				this.CheckError();
				throw;
			}
			return result;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0002F31C File Offset: 0x0002D51C
		public override int Read(byte[] buffer, int offset, int size)
		{
			this.CheckError();
			int num;
			try
			{
				num = this._networkStream.Read(buffer, offset, size);
			}
			catch
			{
				this.CheckError();
				throw;
			}
			if (num == 0)
			{
				this._isFullyRead = true;
				this.Close();
			}
			return num;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0002F36C File Offset: 0x0002D56C
		public override void Write(byte[] buffer, int offset, int size)
		{
			this.CheckError();
			try
			{
				this._networkStream.Write(buffer, offset, size);
			}
			catch
			{
				this.CheckError();
				throw;
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0002F3A8 File Offset: 0x0002D5A8
		private void AsyncReadCallback(IAsyncResult ar)
		{
			LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)ar.AsyncState;
			try
			{
				try
				{
					int num = this._networkStream.EndRead(ar);
					if (num == 0)
					{
						this._isFullyRead = true;
						this.Close();
					}
					lazyAsyncResult.InvokeCallback(num);
				}
				catch (Exception result)
				{
					if (!lazyAsyncResult.IsCompleted)
					{
						lazyAsyncResult.InvokeCallback(result);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0002F420 File Offset: 0x0002D620
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			this.CheckError();
			LazyAsyncResult lazyAsyncResult = new LazyAsyncResult(this, state, callback);
			try
			{
				this._networkStream.BeginRead(buffer, offset, size, new AsyncCallback(this.AsyncReadCallback), lazyAsyncResult);
			}
			catch
			{
				this.CheckError();
				throw;
			}
			return lazyAsyncResult;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0002F478 File Offset: 0x0002D678
		public override int EndRead(IAsyncResult ar)
		{
			int result;
			try
			{
				object obj = ((LazyAsyncResult)ar).InternalWaitForCompletion();
				Exception ex = obj as Exception;
				if (ex != null)
				{
					ExceptionDispatchInfo.Throw(ex);
				}
				result = (int)obj;
			}
			finally
			{
				this.CheckError();
			}
			return result;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			this.CheckError();
			IAsyncResult result;
			try
			{
				result = this._networkStream.BeginWrite(buffer, offset, size, callback, state);
			}
			catch
			{
				this.CheckError();
				throw;
			}
			return result;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0002F504 File Offset: 0x0002D704
		public override void EndWrite(IAsyncResult asyncResult)
		{
			try
			{
				this._networkStream.EndWrite(asyncResult);
			}
			finally
			{
				this.CheckError();
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0002F538 File Offset: 0x0002D738
		public override void Flush()
		{
			this._networkStream.Flush();
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0002F545 File Offset: 0x0002D745
		public override void SetLength(long value)
		{
			this._networkStream.SetLength(value);
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0002F553 File Offset: 0x0002D753
		public override bool CanTimeout
		{
			get
			{
				return this._networkStream.CanTimeout;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0002F560 File Offset: 0x0002D760
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x0002F56D File Offset: 0x0002D76D
		public override int ReadTimeout
		{
			get
			{
				return this._networkStream.ReadTimeout;
			}
			set
			{
				this._networkStream.ReadTimeout = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0002F57B File Offset: 0x0002D77B
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x0002F588 File Offset: 0x0002D788
		public override int WriteTimeout
		{
			get
			{
				return this._networkStream.WriteTimeout;
			}
			set
			{
				this._networkStream.WriteTimeout = value;
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0002F596 File Offset: 0x0002D796
		internal void SetSocketTimeoutOption(int timeout)
		{
			this._networkStream.ReadTimeout = timeout;
			this._networkStream.WriteTimeout = timeout;
		}

		// Token: 0x040005C1 RID: 1473
		private FtpWebRequest _request;

		// Token: 0x040005C2 RID: 1474
		private NetworkStream _networkStream;

		// Token: 0x040005C3 RID: 1475
		private bool _writeable;

		// Token: 0x040005C4 RID: 1476
		private bool _readable;

		// Token: 0x040005C5 RID: 1477
		private bool _isFullyRead;

		// Token: 0x040005C6 RID: 1478
		private bool _closing;
	}
}
