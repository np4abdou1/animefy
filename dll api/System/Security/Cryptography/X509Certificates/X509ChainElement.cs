using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents an element of an X.509 chain.</summary>
	// Token: 0x020000FA RID: 250
	public class X509ChainElement
	{
		// Token: 0x0600070A RID: 1802 RVA: 0x00028B14 File Offset: 0x00026D14
		internal X509ChainElement(X509Certificate2 certificate)
		{
			this.certificate = certificate;
			this.info = string.Empty;
		}

		/// <summary>Gets the X.509 certificate at a particular chain element.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</returns>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00028B2E File Offset: 0x00026D2E
		public X509Certificate2 Certificate
		{
			get
			{
				return this.certificate;
			}
		}

		/// <summary>Gets the error status of the current X.509 certificate in a chain.</summary>
		/// <returns>An array of <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainStatus" /> objects.</returns>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00028B36 File Offset: 0x00026D36
		public X509ChainStatus[] ChainElementStatus
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00028B3E File Offset: 0x00026D3E
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00028B46 File Offset: 0x00026D46
		internal X509ChainStatusFlags StatusFlags
		{
			get
			{
				return this.compressed_status_flags;
			}
			set
			{
				this.compressed_status_flags = value;
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00028B50 File Offset: 0x00026D50
		private int Count(X509ChainStatusFlags flags)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 1;
			while (num2++ < 32)
			{
				if ((flags & (X509ChainStatusFlags)num3) == (X509ChainStatusFlags)num3)
				{
					num++;
				}
				num3 <<= 1;
			}
			return num;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00028B7F File Offset: 0x00026D7F
		private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask)
		{
			if ((flags & mask) != X509ChainStatusFlags.NoError)
			{
				status[position].Status = mask;
				status[position].StatusInformation = X509ChainStatus.GetInformation(mask);
				position++;
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00028BB0 File Offset: 0x00026DB0
		internal void UncompressFlags()
		{
			if (this.compressed_status_flags == X509ChainStatusFlags.NoError)
			{
				this.status = new X509ChainStatus[0];
				return;
			}
			int num = this.Count(this.compressed_status_flags);
			this.status = new X509ChainStatus[num];
			int num2 = 0;
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.UntrustedRoot);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NotTimeValid);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NotTimeNested);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.Revoked);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NotSignatureValid);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NotValidForUsage);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.RevocationStatusUnknown);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.Cyclic);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.InvalidExtension);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.InvalidPolicyConstraints);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.InvalidBasicConstraints);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.InvalidNameConstraints);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.HasNotSupportedNameConstraint);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.HasNotDefinedNameConstraint);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.HasNotPermittedNameConstraint);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.HasExcludedNameConstraint);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.PartialChain);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.CtlNotTimeValid);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.CtlNotSignatureValid);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.CtlNotValidForUsage);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.OfflineRevocation);
			this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NoIssuanceChainPolicy);
		}

		// Token: 0x040004E1 RID: 1249
		private X509Certificate2 certificate;

		// Token: 0x040004E2 RID: 1250
		private X509ChainStatus[] status;

		// Token: 0x040004E3 RID: 1251
		private string info;

		// Token: 0x040004E4 RID: 1252
		private X509ChainStatusFlags compressed_status_flags;
	}
}
