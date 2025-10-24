using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono.Btls
{
	// Token: 0x02000035 RID: 53
	internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00005B28 File Offset: 0x00003D28
		public MonoBtlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) : base(parent, options)
		{
			if (base.IsServer && base.LocalServerCertificate != null)
			{
				this.nativeServerCertificate = MonoBtlsContext.GetPrivateCertificate(base.LocalServerCertificate);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005B54 File Offset: 0x00003D54
		private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate)
		{
			X509CertificateImplBtls x509CertificateImplBtls = certificate.Impl as X509CertificateImplBtls;
			if (x509CertificateImplBtls != null)
			{
				return (X509CertificateImplBtls)x509CertificateImplBtls.Clone();
			}
			string password = Guid.NewGuid().ToString();
			X509CertificateImplBtls result;
			using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(password))
			{
				result = new X509CertificateImplBtls(certificate.Export(X509ContentType.Pfx, password), safePasswordHandle, X509KeyStorageFlags.DefaultKeySet);
			}
			return result;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005BC8 File Offset: 0x00003DC8
		private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx)
		{
			int result;
			using (X509ChainImplBtls x509ChainImplBtls = new X509ChainImplBtls(storeCtx))
			{
				using (X509Chain x509Chain = new X509Chain(x509ChainImplBtls))
				{
					X509Certificate2 certificate = x509Chain.ChainElements[0].Certificate;
					bool flag = base.ValidateCertificate(certificate, x509Chain);
					this.certificateValidated = true;
					result = (flag ? 1 : 0);
				}
			}
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005C40 File Offset: 0x00003E40
		private int SelectCallback(string[] acceptableIssuers)
		{
			if (this.nativeClientCertificate != null)
			{
				return 1;
			}
			this.GetPeerCertificate();
			X509Certificate x509Certificate = base.SelectClientCertificate(acceptableIssuers);
			if (x509Certificate == null)
			{
				return 1;
			}
			this.nativeClientCertificate = MonoBtlsContext.GetPrivateCertificate(x509Certificate);
			this.clientCertificate = new X509Certificate(this.nativeClientCertificate);
			this.SetPrivateCertificate(this.nativeClientCertificate);
			return 1;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005C94 File Offset: 0x00003E94
		private int ServerNameCallback()
		{
			string serverName = this.ssl.GetServerName();
			X509Certificate x509Certificate = base.SelectServerCertificate(serverName);
			if (x509Certificate == null)
			{
				return 1;
			}
			this.nativeServerCertificate = MonoBtlsContext.GetPrivateCertificate(x509Certificate);
			this.SetPrivateCertificate(this.nativeServerCertificate);
			return 1;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005CD4 File Offset: 0x00003ED4
		public override void StartHandshake()
		{
			this.InitializeConnection();
			this.ssl = new MonoBtlsSsl(this.ctx);
			this.bio = new MonoBtlsBioMono(this);
			this.ssl.SetBio(this.bio);
			if (base.IsServer)
			{
				if (this.nativeServerCertificate != null)
				{
					this.SetPrivateCertificate(this.nativeServerCertificate);
				}
			}
			else
			{
				this.ssl.SetServerName(base.ServerName);
			}
			if (base.Options.AllowRenegotiation)
			{
				this.ssl.SetRenegotiateMode(MonoBtlsSslRenegotiateMode.FREELY);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005D60 File Offset: 0x00003F60
		private void SetPrivateCertificate(X509CertificateImplBtls privateCert)
		{
			this.ssl.SetCertificate(privateCert.X509);
			this.ssl.SetPrivateKey(privateCert.NativePrivateKey);
			X509CertificateImplCollection intermediateCertificates = privateCert.IntermediateCertificates;
			if (intermediateCertificates == null)
			{
				return;
			}
			for (int i = 0; i < intermediateCertificates.Count; i++)
			{
				X509CertificateImplBtls x509CertificateImplBtls = (X509CertificateImplBtls)intermediateCertificates[i];
				this.ssl.AddIntermediateCertificate(x509CertificateImplBtls.X509);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005DCC File Offset: 0x00003FCC
		private static Exception GetException(MonoBtlsSslError status)
		{
			string text;
			int num;
			int error = MonoBtlsError.GetError(out text, out num);
			if (error == 0)
			{
				return new MonoBtlsException(status);
			}
			int errorReason = MonoBtlsError.GetErrorReason(error);
			if (errorReason > 0)
			{
				return new TlsException((AlertDescription)errorReason);
			}
			string errorString = MonoBtlsError.GetErrorString(error);
			string message;
			if (text != null)
			{
				message = string.Format("{0} {1}\n  at {2}:{3}", new object[]
				{
					status,
					errorString,
					text,
					num
				});
			}
			else
			{
				message = string.Format("{0} {1}", status, errorString);
			}
			return new MonoBtlsException(message);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005E58 File Offset: 0x00004058
		public override bool ProcessHandshake()
		{
			bool flag = false;
			while (!flag)
			{
				MonoBtlsError.ClearError();
				MonoBtlsSslError monoBtlsSslError = this.DoProcessHandshake();
				if (monoBtlsSslError != MonoBtlsSslError.None)
				{
					if (monoBtlsSslError - MonoBtlsSslError.WantRead > 1)
					{
						this.ctx.CheckLastError("ProcessHandshake");
						throw MonoBtlsContext.GetException(monoBtlsSslError);
					}
					return false;
				}
				else if (this.connected)
				{
					flag = true;
				}
				else
				{
					this.connected = true;
				}
			}
			this.ssl.PrintErrors();
			return true;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00005EBD File Offset: 0x000040BD
		private MonoBtlsSslError DoProcessHandshake()
		{
			if (this.connected)
			{
				return this.ssl.Handshake();
			}
			if (base.IsServer)
			{
				return this.ssl.Accept();
			}
			return this.ssl.Connect();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005EF2 File Offset: 0x000040F2
		public override void FinishHandshake()
		{
			this.InitializeSession();
			this.isAuthenticated = true;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005F04 File Offset: 0x00004104
		private void InitializeConnection()
		{
			this.ctx = new MonoBtlsSslCtx();
			MonoBtlsProvider.SetupCertificateStore(this.ctx.CertificateStore, base.Settings, base.IsServer);
			if (!base.IsServer || base.AskForClientCertificate)
			{
				this.ctx.SetVerifyCallback(new MonoBtlsVerifyCallback(this.VerifyCallback), false);
			}
			if (!base.IsServer)
			{
				this.ctx.SetSelectCallback(new MonoBtlsSelectCallback(this.SelectCallback));
			}
			if (base.IsServer && (base.Options.ServerCertSelectionDelegate != null || base.Settings.ClientCertificateSelectionCallback != null))
			{
				this.ctx.SetServerNameCallback(new MonoBtlsServerNameCallback(this.ServerNameCallback));
			}
			this.ctx.SetVerifyParam(MonoBtlsProvider.GetVerifyParam(base.Settings, base.ServerName, base.IsServer));
			TlsProtocolCode? tlsProtocolCode;
			TlsProtocolCode? tlsProtocolCode2;
			base.GetProtocolVersions(out tlsProtocolCode, out tlsProtocolCode2);
			if (tlsProtocolCode != null)
			{
				this.ctx.SetMinVersion((int)tlsProtocolCode.Value);
			}
			if (tlsProtocolCode2 != null)
			{
				this.ctx.SetMaxVersion((int)tlsProtocolCode2.Value);
			}
			if (base.Settings != null && base.Settings.EnabledCiphers != null)
			{
				short[] array = new short[base.Settings.EnabledCiphers.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (short)base.Settings.EnabledCiphers[i];
				}
				this.ctx.SetCiphers(array, true);
			}
			if (base.IsServer)
			{
				MonoTlsSettings settings = base.Settings;
				if (((settings != null) ? settings.ClientCertificateIssuers : null) != null)
				{
					this.ctx.SetClientCertificateIssuers(base.Settings.ClientCertificateIssuers);
				}
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000060A0 File Offset: 0x000042A0
		private void GetPeerCertificate()
		{
			if (this.remoteCertificate != null)
			{
				return;
			}
			using (MonoBtlsX509 peerCertificate = this.ssl.GetPeerCertificate())
			{
				if (peerCertificate != null)
				{
					this.remoteCertificate = MonoBtlsProvider.CreateCertificate(peerCertificate);
				}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000060F0 File Offset: 0x000042F0
		private void InitializeSession()
		{
			this.GetPeerCertificate();
			if (base.IsServer && base.AskForClientCertificate && !this.certificateValidated && !base.ValidateCertificate(null, null))
			{
				throw new TlsException(AlertDescription.CertificateUnknown);
			}
			CipherSuiteCode cipherSuiteCode = (CipherSuiteCode)this.ssl.GetCipher();
			TlsProtocolCode protocol = (TlsProtocolCode)this.ssl.GetVersion();
			string serverName = this.ssl.GetServerName();
			this.connectionInfo = new MonoTlsConnectionInfo
			{
				CipherSuiteCode = cipherSuiteCode,
				ProtocolVersion = MonoBtlsContext.GetProtocol(protocol),
				PeerDomainName = serverName
			};
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006178 File Offset: 0x00004378
		private static TlsProtocols GetProtocol(TlsProtocolCode protocol)
		{
			switch (protocol)
			{
			case TlsProtocolCode.Tls10:
				return TlsProtocols.Tls10;
			case TlsProtocolCode.Tls11:
				return TlsProtocols.Tls11;
			case TlsProtocolCode.Tls12:
				return TlsProtocols.Tls12;
			default:
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000061AB File Offset: 0x000043AB
		public override void Flush()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000061B4 File Offset: 0x000043B4
		[return: TupleElementNames(new string[]
		{
			"ret",
			"wantMore"
		})]
		public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int size)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(size);
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			ValueTuple<int, bool> result;
			try
			{
				MonoBtlsError.ClearError();
				MonoBtlsSslError monoBtlsSslError = this.ssl.Read(intPtr, ref size);
				if (monoBtlsSslError == MonoBtlsSslError.WantRead)
				{
					result = new ValueTuple<int, bool>(0, true);
				}
				else if (monoBtlsSslError == MonoBtlsSslError.ZeroReturn)
				{
					result = new ValueTuple<int, bool>(size, false);
				}
				else
				{
					if (monoBtlsSslError != MonoBtlsSslError.None)
					{
						throw MonoBtlsContext.GetException(monoBtlsSslError);
					}
					if (size > 0)
					{
						Marshal.Copy(intPtr, buffer, offset, size);
					}
					result = new ValueTuple<int, bool>(size, false);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return result;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006248 File Offset: 0x00004448
		[return: TupleElementNames(new string[]
		{
			"ret",
			"wantMore"
		})]
		public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int size)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(size);
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			ValueTuple<int, bool> result;
			try
			{
				MonoBtlsError.ClearError();
				Marshal.Copy(buffer, offset, intPtr, size);
				MonoBtlsSslError monoBtlsSslError = this.ssl.Write(intPtr, ref size);
				if (monoBtlsSslError == MonoBtlsSslError.WantWrite)
				{
					result = new ValueTuple<int, bool>(0, true);
				}
				else
				{
					if (monoBtlsSslError != MonoBtlsSslError.None)
					{
						throw MonoBtlsContext.GetException(monoBtlsSslError);
					}
					result = new ValueTuple<int, bool>(size, false);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return result;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003E34 File Offset: 0x00002034
		public override void Renegotiate()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000062C8 File Offset: 0x000044C8
		public override bool PendingRenegotiation()
		{
			return this.ssl.RenegotiatePending();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000062D8 File Offset: 0x000044D8
		private void Dispose<T>(ref T disposable) where T : class, IDisposable
		{
			try
			{
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			catch
			{
			}
			finally
			{
				disposable = default(T);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006328 File Offset: 0x00004528
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					this.Dispose<MonoBtlsSsl>(ref this.ssl);
					this.Dispose<MonoBtlsSslCtx>(ref this.ctx);
					this.Dispose<X509Certificate2>(ref this.remoteCertificate);
					this.Dispose<X509CertificateImplBtls>(ref this.nativeServerCertificate);
					this.Dispose<X509CertificateImplBtls>(ref this.nativeClientCertificate);
					this.Dispose<X509Certificate>(ref this.clientCertificate);
					this.Dispose<MonoBtlsBio>(ref this.bio);
					this.Dispose<MonoBtlsBio>(ref this.errbio);
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000063B4 File Offset: 0x000045B4
		int IMonoBtlsBioMono.Read(byte[] buffer, int offset, int size, out bool wantMore)
		{
			return base.Parent.InternalRead(buffer, offset, size, out wantMore);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000063C6 File Offset: 0x000045C6
		bool IMonoBtlsBioMono.Write(byte[] buffer, int offset, int size)
		{
			return base.Parent.InternalWrite(buffer, offset, size);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004D67 File Offset: 0x00002F67
		void IMonoBtlsBioMono.Flush()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004D67 File Offset: 0x00002F67
		void IMonoBtlsBioMono.Close()
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000063D6 File Offset: 0x000045D6
		public override bool IsAuthenticated
		{
			get
			{
				return this.isAuthenticated;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000063DE File Offset: 0x000045DE
		internal override X509Certificate LocalClientCertificate
		{
			get
			{
				return this.clientCertificate;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000063E6 File Offset: 0x000045E6
		public override X509Certificate2 RemoteCertificate
		{
			get
			{
				return this.remoteCertificate;
			}
		}

		// Token: 0x040000AC RID: 172
		private X509Certificate2 remoteCertificate;

		// Token: 0x040000AD RID: 173
		private X509Certificate clientCertificate;

		// Token: 0x040000AE RID: 174
		private X509CertificateImplBtls nativeServerCertificate;

		// Token: 0x040000AF RID: 175
		private X509CertificateImplBtls nativeClientCertificate;

		// Token: 0x040000B0 RID: 176
		private MonoBtlsSslCtx ctx;

		// Token: 0x040000B1 RID: 177
		private MonoBtlsSsl ssl;

		// Token: 0x040000B2 RID: 178
		private MonoBtlsBio bio;

		// Token: 0x040000B3 RID: 179
		private MonoBtlsBio errbio;

		// Token: 0x040000B4 RID: 180
		private MonoTlsConnectionInfo connectionInfo;

		// Token: 0x040000B5 RID: 181
		private bool certificateValidated;

		// Token: 0x040000B6 RID: 182
		private bool isAuthenticated;

		// Token: 0x040000B7 RID: 183
		private bool connected;
	}
}
