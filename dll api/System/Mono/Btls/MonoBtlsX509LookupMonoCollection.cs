using System;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Btls
{
	// Token: 0x0200005A RID: 90
	internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
	{
		// Token: 0x06000231 RID: 561 RVA: 0x0000834F File Offset: 0x0000654F
		internal MonoBtlsX509LookupMonoCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust)
		{
			this.collection = collection;
			this.trust = trust;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00008368 File Offset: 0x00006568
		private void Initialize()
		{
			if (this.certificates != null)
			{
				return;
			}
			this.hashes = new long[this.collection.Count];
			this.certificates = new MonoBtlsX509[this.collection.Count];
			for (int i = 0; i < this.collection.Count; i++)
			{
				byte[] rawCertData = this.collection[i].GetRawCertData();
				this.certificates[i] = MonoBtlsX509.LoadFromData(rawCertData, MonoBtlsX509Format.DER);
				this.certificates[i].AddExplicitTrust(this.trust);
				this.hashes[i] = this.certificates[i].GetSubjectNameHash();
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000840C File Offset: 0x0000660C
		protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name)
		{
			this.Initialize();
			long hash = name.GetHash();
			MonoBtlsX509 monoBtlsX = null;
			for (int i = 0; i < this.certificates.Length; i++)
			{
				if (this.hashes[i] == hash)
				{
					monoBtlsX = this.certificates[i];
					base.AddCertificate(monoBtlsX);
				}
			}
			return monoBtlsX;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00008458 File Offset: 0x00006658
		protected override void Close()
		{
			try
			{
				if (this.certificates != null)
				{
					for (int i = 0; i < this.certificates.Length; i++)
					{
						if (this.certificates[i] != null)
						{
							this.certificates[i].Dispose();
							this.certificates[i] = null;
						}
					}
					this.certificates = null;
					this.hashes = null;
				}
			}
			finally
			{
				base.Close();
			}
		}

		// Token: 0x04000129 RID: 297
		private long[] hashes;

		// Token: 0x0400012A RID: 298
		private MonoBtlsX509[] certificates;

		// Token: 0x0400012B RID: 299
		private X509CertificateCollection collection;

		// Token: 0x0400012C RID: 300
		private MonoBtlsX509TrustKind trust;
	}
}
