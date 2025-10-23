using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000022 RID: 34
	internal class MonoTlsStream : IDisposable
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000508C File Offset: 0x0000328C
		internal HttpWebRequest Request
		{
			get
			{
				return this.request;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00005094 File Offset: 0x00003294
		internal WebExceptionStatus ExceptionStatus
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000509C File Offset: 0x0000329C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000050A4 File Offset: 0x000032A4
		internal bool CertificateValidationFailed { get; set; }

		// Token: 0x060000DE RID: 222 RVA: 0x000050B0 File Offset: 0x000032B0
		public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream)
		{
			this.request = request;
			this.networkStream = networkStream;
			this.settings = request.TlsSettings;
			this.provider = (request.TlsProvider ?? MonoTlsProviderFactory.GetProviderInternal());
			this.status = WebExceptionStatus.SecureChannelFailure;
			ChainValidationHelper.Create(this.provider, ref this.settings, this);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005118 File Offset: 0x00003318
		internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken)
		{
			MonoTlsStream.<CreateStream>d__18 <CreateStream>d__;
			<CreateStream>d__.<>t__builder = AsyncTaskMethodBuilder<Stream>.Create();
			<CreateStream>d__.<>4__this = this;
			<CreateStream>d__.tunnel = tunnel;
			<CreateStream>d__.cancellationToken = cancellationToken;
			<CreateStream>d__.<>1__state = -1;
			<CreateStream>d__.<>t__builder.Start<MonoTlsStream.<CreateStream>d__18>(ref <CreateStream>d__);
			return <CreateStream>d__.<>t__builder.Task;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000516B File Offset: 0x0000336B
		public void Dispose()
		{
			this.CloseSslStream();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005174 File Offset: 0x00003374
		private void CloseSslStream()
		{
			object obj = this.sslStreamLock;
			lock (obj)
			{
				if (this.sslStream != null)
				{
					this.sslStream.Dispose();
					this.sslStream = null;
				}
			}
		}

		// Token: 0x0400008A RID: 138
		private readonly MobileTlsProvider provider;

		// Token: 0x0400008B RID: 139
		private readonly NetworkStream networkStream;

		// Token: 0x0400008C RID: 140
		private readonly HttpWebRequest request;

		// Token: 0x0400008D RID: 141
		private readonly MonoTlsSettings settings;

		// Token: 0x0400008E RID: 142
		private SslStream sslStream;

		// Token: 0x0400008F RID: 143
		private readonly object sslStreamLock = new object();

		// Token: 0x04000090 RID: 144
		private WebExceptionStatus status;
	}
}
