using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Btls
{
	// Token: 0x02000067 RID: 103
	internal class X509ChainImplBtls : X509ChainImpl
	{
		// Token: 0x06000298 RID: 664 RVA: 0x000090F4 File Offset: 0x000072F4
		internal X509ChainImplBtls(MonoBtlsX509Chain chain)
		{
			this.chain = chain.Copy();
			this.policy = new X509ChainPolicy();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00009114 File Offset: 0x00007314
		internal X509ChainImplBtls(MonoBtlsX509StoreCtx storeCtx)
		{
			this.storeCtx = storeCtx.Copy();
			this.chain = storeCtx.GetChain();
			this.policy = new X509ChainPolicy();
			this.untrustedChain = storeCtx.GetUntrusted();
			if (this.untrustedChain != null)
			{
				this.untrusted = new X509Certificate2Collection();
				this.policy.ExtraStore = this.untrusted;
				for (int i = 0; i < this.untrustedChain.Count; i++)
				{
					using (X509CertificateImplBtls x509CertificateImplBtls = new X509CertificateImplBtls(this.untrustedChain.GetCertificate(i)))
					{
						this.untrusted.Add(new X509Certificate2(x509CertificateImplBtls));
					}
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000091D0 File Offset: 0x000073D0
		public override bool IsValid
		{
			get
			{
				return this.chain != null && this.chain.IsValid;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000091E7 File Offset: 0x000073E7
		internal MonoBtlsX509StoreCtx StoreCtx
		{
			get
			{
				base.ThrowIfContextInvalid();
				return this.storeCtx;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000091F8 File Offset: 0x000073F8
		public override X509ChainElementCollection ChainElements
		{
			get
			{
				base.ThrowIfContextInvalid();
				if (this.elements != null)
				{
					return this.elements;
				}
				this.elements = new X509ChainElementCollection();
				this.certificates = new X509Certificate2[this.chain.Count];
				for (int i = 0; i < this.certificates.Length; i++)
				{
					using (X509CertificateImplBtls x509CertificateImplBtls = new X509CertificateImplBtls(this.chain.GetCertificate(i)))
					{
						this.certificates[i] = new X509Certificate2(x509CertificateImplBtls);
					}
					this.elements.Add(this.certificates[i]);
				}
				return this.elements;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600029D RID: 669 RVA: 0x000092A4 File Offset: 0x000074A4
		public override X509ChainPolicy ChainPolicy
		{
			get
			{
				return this.policy;
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000092AC File Offset: 0x000074AC
		public override void AddStatus(X509ChainStatusFlags errorCode)
		{
			if (this.chainStatusList == null)
			{
				this.chainStatusList = new List<X509ChainStatus>();
			}
			this.chainStatusList.Add(new X509ChainStatus(errorCode));
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool Build(X509Certificate2 certificate)
		{
			return false;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000092D4 File Offset: 0x000074D4
		public override void Reset()
		{
			if (this.certificates != null)
			{
				X509Certificate2[] array = this.certificates;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Dispose();
				}
				this.certificates = null;
			}
			if (this.elements != null)
			{
				this.elements.Clear();
				this.elements = null;
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00009328 File Offset: 0x00007528
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.chain != null)
				{
					this.chain.Dispose();
					this.chain = null;
				}
				if (this.storeCtx != null)
				{
					this.storeCtx.Dispose();
					this.storeCtx = null;
				}
				if (this.untrustedChain != null)
				{
					this.untrustedChain.Dispose();
					this.untrustedChain = null;
				}
				if (this.untrusted != null)
				{
					foreach (X509Certificate2 x509Certificate in this.untrusted)
					{
						x509Certificate.Dispose();
					}
					this.untrusted = null;
				}
				if (this.certificates != null)
				{
					X509Certificate2[] array = this.certificates;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].Dispose();
					}
					this.certificates = null;
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000153 RID: 339
		private MonoBtlsX509StoreCtx storeCtx;

		// Token: 0x04000154 RID: 340
		private MonoBtlsX509Chain chain;

		// Token: 0x04000155 RID: 341
		private MonoBtlsX509Chain untrustedChain;

		// Token: 0x04000156 RID: 342
		private X509ChainElementCollection elements;

		// Token: 0x04000157 RID: 343
		private X509Certificate2Collection untrusted;

		// Token: 0x04000158 RID: 344
		private X509Certificate2[] certificates;

		// Token: 0x04000159 RID: 345
		private X509ChainPolicy policy;

		// Token: 0x0400015A RID: 346
		private List<X509ChainStatus> chainStatusList;
	}
}
