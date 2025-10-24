using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	// Token: 0x02000111 RID: 273
	internal class TlsStream : NetworkStream
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x0002C18F File Offset: 0x0002A38F
		public TlsStream(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) : base(socket)
		{
			this._sslStream = new SslStream(stream, false, ServicePointManager.ServerCertificateValidationCallback);
			this._host = host;
			this._clientCertificates = clientCertificates;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0002C1B9 File Offset: 0x0002A3B9
		public void AuthenticateAsClient()
		{
			this._sslStream.AuthenticateAsClient(this._host, this._clientCertificates, (SslProtocols)ServicePointManager.SecurityProtocol, ServicePointManager.CheckCertificateRevocationList);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0002C1DC File Offset: 0x0002A3DC
		public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state)
		{
			return this._sslStream.BeginAuthenticateAsClient(this._host, this._clientCertificates, (SslProtocols)ServicePointManager.SecurityProtocol, ServicePointManager.CheckCertificateRevocationList, asyncCallback, state);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0002C201 File Offset: 0x0002A401
		public void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
			this._sslStream.EndAuthenticateAsClient(asyncResult);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0002C20F File Offset: 0x0002A40F
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return this._sslStream.BeginWrite(buffer, offset, size, callback, state);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0002C223 File Offset: 0x0002A423
		public override void EndWrite(IAsyncResult result)
		{
			this._sslStream.EndWrite(result);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0002C231 File Offset: 0x0002A431
		public override void Write(byte[] buffer, int offset, int size)
		{
			this._sslStream.Write(buffer, offset, size);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0002C241 File Offset: 0x0002A441
		public override int Read(byte[] buffer, int offset, int size)
		{
			return this._sslStream.Read(buffer, offset, size);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0002C251 File Offset: 0x0002A451
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this._sslStream.BeginRead(buffer, offset, count, callback, state);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0002C265 File Offset: 0x0002A465
		public override int EndRead(IAsyncResult asyncResult)
		{
			return this._sslStream.EndRead(asyncResult);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0002C273 File Offset: 0x0002A473
		public override void Close()
		{
			base.Close();
			if (this._sslStream != null)
			{
				this._sslStream.Close();
			}
		}

		// Token: 0x04000523 RID: 1315
		private SslStream _sslStream;

		// Token: 0x04000524 RID: 1316
		private string _host;

		// Token: 0x04000525 RID: 1317
		private X509CertificateCollection _clientCertificates;
	}
}
