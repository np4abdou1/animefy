using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x0200001D RID: 29
	internal abstract class MobileTlsContext : IDisposable
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000048E4 File Offset: 0x00002AE4
		protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
		{
			this.Parent = parent;
			this.Options = options;
			this.IsServer = options.ServerMode;
			this.EnabledProtocols = options.EnabledSslProtocols;
			if (options.ServerMode)
			{
				this.LocalServerCertificate = options.ServerCertificate;
				this.AskForClientCertificate = options.ClientCertificateRequired;
			}
			else
			{
				this.ClientCertificates = options.ClientCertificates;
				this.TargetHost = options.TargetHost;
				this.ServerName = options.TargetHost;
				if (!string.IsNullOrEmpty(this.ServerName))
				{
					int num = this.ServerName.IndexOf(':');
					if (num > 0)
					{
						this.ServerName = this.ServerName.Substring(0, num);
					}
				}
			}
			this.certificateValidator = ChainValidationHelper.GetInternalValidator(parent.SslStream, parent.Provider, parent.Settings);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000049B2 File Offset: 0x00002BB2
		internal MonoSslAuthenticationOptions Options { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000049BA File Offset: 0x00002BBA
		internal MobileAuthenticatedStream Parent { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000049C2 File Offset: 0x00002BC2
		public MonoTlsSettings Settings
		{
			get
			{
				return this.Parent.Settings;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000099 RID: 153
		public abstract bool IsAuthenticated { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000049CF File Offset: 0x00002BCF
		public bool IsServer { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000049D7 File Offset: 0x00002BD7
		internal string TargetHost { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000049DF File Offset: 0x00002BDF
		protected string ServerName { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000049E7 File Offset: 0x00002BE7
		protected bool AskForClientCertificate { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000049EF File Offset: 0x00002BEF
		protected SslProtocols EnabledProtocols { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000049F7 File Offset: 0x00002BF7
		protected X509CertificateCollection ClientCertificates { get; }

		// Token: 0x060000A0 RID: 160 RVA: 0x00004A00 File Offset: 0x00002C00
		protected void GetProtocolVersions(out TlsProtocolCode? min, out TlsProtocolCode? max)
		{
			if ((this.EnabledProtocols & SslProtocols.Tls) != SslProtocols.None)
			{
				min = new TlsProtocolCode?(TlsProtocolCode.Tls10);
			}
			else if ((this.EnabledProtocols & SslProtocols.Tls11) != SslProtocols.None)
			{
				min = new TlsProtocolCode?(TlsProtocolCode.Tls11);
			}
			else if ((this.EnabledProtocols & SslProtocols.Tls12) != SslProtocols.None)
			{
				min = new TlsProtocolCode?(TlsProtocolCode.Tls12);
			}
			else
			{
				min = null;
			}
			if ((this.EnabledProtocols & SslProtocols.Tls12) != SslProtocols.None)
			{
				max = new TlsProtocolCode?(TlsProtocolCode.Tls12);
				return;
			}
			if ((this.EnabledProtocols & SslProtocols.Tls11) != SslProtocols.None)
			{
				max = new TlsProtocolCode?(TlsProtocolCode.Tls11);
				return;
			}
			if ((this.EnabledProtocols & SslProtocols.Tls) != SslProtocols.None)
			{
				max = new TlsProtocolCode?(TlsProtocolCode.Tls10);
				return;
			}
			max = null;
		}

		// Token: 0x060000A1 RID: 161
		public abstract void StartHandshake();

		// Token: 0x060000A2 RID: 162
		public abstract bool ProcessHandshake();

		// Token: 0x060000A3 RID: 163
		public abstract void FinishHandshake();

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004AD8 File Offset: 0x00002CD8
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00004AE0 File Offset: 0x00002CE0
		internal X509Certificate LocalServerCertificate { get; private set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A6 RID: 166
		internal abstract X509Certificate LocalClientCertificate { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A7 RID: 167
		public abstract X509Certificate2 RemoteCertificate { get; }

		// Token: 0x060000A8 RID: 168
		public abstract void Flush();

		// Token: 0x060000A9 RID: 169
		[return: TupleElementNames(new string[]
		{
			"ret",
			"wantMore"
		})]
		public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

		// Token: 0x060000AA RID: 170
		[return: TupleElementNames(new string[]
		{
			"ret",
			"wantMore"
		})]
		public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

		// Token: 0x060000AB RID: 171
		public abstract bool PendingRenegotiation();

		// Token: 0x060000AC RID: 172 RVA: 0x00004AEC File Offset: 0x00002CEC
		protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain)
		{
			ValidationResult validationResult = this.certificateValidator.ValidateCertificate(this.TargetHost, this.IsServer, leaf, chain);
			return validationResult != null && validationResult.Trusted && !validationResult.UserDenied;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004B2C File Offset: 0x00002D2C
		protected X509Certificate SelectServerCertificate(string serverIdentity)
		{
			if (this.Options.ServerCertSelectionDelegate != null)
			{
				this.LocalServerCertificate = this.Options.ServerCertSelectionDelegate(serverIdentity);
				if (this.LocalServerCertificate == null)
				{
					throw new AuthenticationException("The server mode SSL must use a certificate with the associated private key.");
				}
			}
			else if (this.Settings.ClientCertificateSelectionCallback != null)
			{
				X509CertificateCollection x509CertificateCollection = new X509CertificateCollection();
				x509CertificateCollection.Add(this.Options.ServerCertificate);
				this.LocalServerCertificate = this.Settings.ClientCertificateSelectionCallback(string.Empty, x509CertificateCollection, null, Array.Empty<string>());
			}
			else
			{
				this.LocalServerCertificate = this.Options.ServerCertificate;
			}
			if (this.LocalServerCertificate == null)
			{
				throw new NotSupportedException("The server mode SSL must use a certificate with the associated private key.");
			}
			return this.LocalServerCertificate;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004BE4 File Offset: 0x00002DE4
		protected X509Certificate SelectClientCertificate(string[] acceptableIssuers)
		{
			if (this.Settings.DisallowUnauthenticatedCertificateRequest && !this.IsAuthenticated)
			{
				return null;
			}
			if (this.RemoteCertificate == null)
			{
				throw new TlsException(AlertDescription.InternalError, "Cannot request client certificate before receiving one from the server.");
			}
			X509Certificate result;
			if (this.certificateValidator.SelectClientCertificate(this.TargetHost, this.ClientCertificates, this.IsAuthenticated ? this.RemoteCertificate : null, acceptableIssuers, out result))
			{
				return result;
			}
			if (this.ClientCertificates == null || this.ClientCertificates.Count == 0)
			{
				return null;
			}
			if (acceptableIssuers == null || acceptableIssuers.Length == 0)
			{
				return this.ClientCertificates[0];
			}
			for (int i = 0; i < this.ClientCertificates.Count; i++)
			{
				X509Certificate2 x509Certificate = this.ClientCertificates[i] as X509Certificate2;
				if (x509Certificate != null)
				{
					X509Chain x509Chain = null;
					try
					{
						x509Chain = new X509Chain();
						x509Chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
						x509Chain.ChainPolicy.VerificationFlags = X509VerificationFlags.IgnoreInvalidName;
						x509Chain.Build(x509Certificate);
						if (x509Chain.ChainElements.Count != 0)
						{
							for (int j = 0; j < x509Chain.ChainElements.Count; j++)
							{
								string issuer = x509Chain.ChainElements[j].Certificate.Issuer;
								if (Array.IndexOf<string>(acceptableIssuers, issuer) != -1)
								{
									return x509Certificate;
								}
							}
						}
					}
					catch
					{
					}
					finally
					{
						if (x509Chain != null)
						{
							x509Chain.Reset();
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060000AF RID: 175
		public abstract void Renegotiate();

		// Token: 0x060000B0 RID: 176 RVA: 0x00004D58 File Offset: 0x00002F58
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004D67 File Offset: 0x00002F67
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004D6C File Offset: 0x00002F6C
		~MobileTlsContext()
		{
			this.Dispose(false);
		}

		// Token: 0x04000077 RID: 119
		private ChainValidationHelper certificateValidator;
	}
}
