using System;
using System.Collections.Generic;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000F8 RID: 248
	internal class X509CertificateImplCollection : IDisposable
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x000288BA File Offset: 0x00026ABA
		public X509CertificateImplCollection()
		{
			this.list = new List<X509CertificateImpl>();
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000288D0 File Offset: 0x00026AD0
		private X509CertificateImplCollection(X509CertificateImplCollection other)
		{
			this.list = new List<X509CertificateImpl>();
			foreach (X509CertificateImpl x509CertificateImpl in other.list)
			{
				this.list.Add(x509CertificateImpl.Clone());
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00028940 File Offset: 0x00026B40
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000123 RID: 291
		public X509CertificateImpl this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0002895B File Offset: 0x00026B5B
		public void Add(X509CertificateImpl impl, bool takeOwnership)
		{
			if (!takeOwnership)
			{
				impl = impl.Clone();
			}
			this.list.Add(impl);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00028974 File Offset: 0x00026B74
		public X509CertificateImplCollection Clone()
		{
			return new X509CertificateImplCollection(this);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0002897C File Offset: 0x00026B7C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0002898C File Offset: 0x00026B8C
		protected virtual void Dispose(bool disposing)
		{
			foreach (X509CertificateImpl x509CertificateImpl in this.list)
			{
				try
				{
					x509CertificateImpl.Dispose();
				}
				catch
				{
				}
			}
			this.list.Clear();
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000289FC File Offset: 0x00026BFC
		~X509CertificateImplCollection()
		{
			this.Dispose(false);
		}

		// Token: 0x040004DF RID: 1247
		private List<X509CertificateImpl> list;
	}
}
