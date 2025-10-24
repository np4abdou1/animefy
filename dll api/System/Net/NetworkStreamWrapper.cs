using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x0200012D RID: 301
	internal class NetworkStreamWrapper : Stream
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x0003128E File Offset: 0x0002F48E
		internal NetworkStreamWrapper(TcpClient client)
		{
			this._client = client;
			this._networkStream = client.GetStream();
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x000312A9 File Offset: 0x0002F4A9
		protected bool UsingSecureStream
		{
			get
			{
				return this._networkStream is TlsStream;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000312B9 File Offset: 0x0002F4B9
		internal IPAddress ServerAddress
		{
			get
			{
				return ((IPEndPoint)this.Socket.RemoteEndPoint).Address;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000312D0 File Offset: 0x0002F4D0
		internal Socket Socket
		{
			get
			{
				return this._client.Client;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000312DD File Offset: 0x0002F4DD
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000312E5 File Offset: 0x0002F4E5
		internal NetworkStream NetworkStream
		{
			get
			{
				return this._networkStream;
			}
			set
			{
				this._networkStream = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000312EE File Offset: 0x0002F4EE
		public override bool CanRead
		{
			get
			{
				return this._networkStream.CanRead;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x000312FB File Offset: 0x0002F4FB
		public override bool CanSeek
		{
			get
			{
				return this._networkStream.CanSeek;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00031308 File Offset: 0x0002F508
		public override bool CanWrite
		{
			get
			{
				return this._networkStream.CanWrite;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00031315 File Offset: 0x0002F515
		public override bool CanTimeout
		{
			get
			{
				return this._networkStream.CanTimeout;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00031322 File Offset: 0x0002F522
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0003132F File Offset: 0x0002F52F
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

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0003133D File Offset: 0x0002F53D
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x0003134A File Offset: 0x0002F54A
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00031358 File Offset: 0x0002F558
		public override long Length
		{
			get
			{
				return this._networkStream.Length;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00031365 File Offset: 0x0002F565
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00031372 File Offset: 0x0002F572
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

		// Token: 0x060008C1 RID: 2241 RVA: 0x00031380 File Offset: 0x0002F580
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this._networkStream.Seek(offset, origin);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0003138F File Offset: 0x0002F58F
		public override int Read(byte[] buffer, int offset, int size)
		{
			return this._networkStream.Read(buffer, offset, size);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0003139F File Offset: 0x0002F59F
		public override void Write(byte[] buffer, int offset, int size)
		{
			this._networkStream.Write(buffer, offset, size);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x000313B0 File Offset: 0x0002F5B0
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					this.CloseSocket();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000313E0 File Offset: 0x0002F5E0
		internal void CloseSocket()
		{
			this._networkStream.Close();
			this._client.Dispose();
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000313F8 File Offset: 0x0002F5F8
		public void Close(int timeout)
		{
			this._networkStream.Close(timeout);
			this._client.Dispose();
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00031411 File Offset: 0x0002F611
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return this._networkStream.BeginRead(buffer, offset, size, callback, state);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00031425 File Offset: 0x0002F625
		public override int EndRead(IAsyncResult asyncResult)
		{
			return this._networkStream.EndRead(asyncResult);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00031433 File Offset: 0x0002F633
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this._networkStream.ReadAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00031445 File Offset: 0x0002F645
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return this._networkStream.BeginWrite(buffer, offset, size, callback, state);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00031459 File Offset: 0x0002F659
		public override void EndWrite(IAsyncResult asyncResult)
		{
			this._networkStream.EndWrite(asyncResult);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00031467 File Offset: 0x0002F667
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this._networkStream.WriteAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00031479 File Offset: 0x0002F679
		public override void Flush()
		{
			this._networkStream.Flush();
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00031486 File Offset: 0x0002F686
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return this._networkStream.FlushAsync(cancellationToken);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00031494 File Offset: 0x0002F694
		public override void SetLength(long value)
		{
			this._networkStream.SetLength(value);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000314A2 File Offset: 0x0002F6A2
		internal void SetSocketTimeoutOption(int timeout)
		{
			this._networkStream.ReadTimeout = timeout;
			this._networkStream.WriteTimeout = timeout;
		}

		// Token: 0x0400061F RID: 1567
		private TcpClient _client;

		// Token: 0x04000620 RID: 1568
		private NetworkStream _networkStream;
	}
}
