using System;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020002F1 RID: 753
	internal abstract class X509CertificateImpl : IDisposable
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060018EB RID: 6379
		public abstract bool IsValid { get; }

		// Token: 0x060018EC RID: 6380 RVA: 0x0006D543 File Offset: 0x0006B743
		protected void ThrowIfContextInvalid()
		{
			if (!this.IsValid)
			{
				throw X509Helper.GetInvalidContextException();
			}
		}

		// Token: 0x060018ED RID: 6381
		public abstract X509CertificateImpl Clone();

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060018EE RID: 6382
		public abstract string Issuer { get; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060018EF RID: 6383
		public abstract string Subject { get; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060018F0 RID: 6384
		public abstract byte[] RawData { get; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060018F1 RID: 6385
		public abstract DateTime NotAfter { get; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060018F2 RID: 6386
		public abstract DateTime NotBefore { get; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060018F3 RID: 6387
		public abstract byte[] Thumbprint { get; }

		// Token: 0x060018F4 RID: 6388 RVA: 0x0006D554 File Offset: 0x0006B754
		public sealed override int GetHashCode()
		{
			if (!this.IsValid)
			{
				return 0;
			}
			byte[] thumbprint = this.Thumbprint;
			int num = 0;
			int num2 = 0;
			while (num2 < thumbprint.Length && num2 < 4)
			{
				num = (num << 8 | (int)thumbprint[num2]);
				num2++;
			}
			return num;
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060018F5 RID: 6389
		public abstract string KeyAlgorithm { get; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060018F6 RID: 6390
		public abstract byte[] KeyAlgorithmParameters { get; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060018F7 RID: 6391
		public abstract byte[] PublicKeyValue { get; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060018F8 RID: 6392
		public abstract byte[] SerialNumber { get; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060018F9 RID: 6393
		public abstract bool HasPrivateKey { get; }

		// Token: 0x060018FA RID: 6394
		public abstract byte[] Export(X509ContentType contentType, SafePasswordHandle password);

		// Token: 0x060018FB RID: 6395 RVA: 0x0006D590 File Offset: 0x0006B790
		public sealed override bool Equals(object obj)
		{
			X509CertificateImpl x509CertificateImpl = obj as X509CertificateImpl;
			if (x509CertificateImpl == null)
			{
				return false;
			}
			if (!this.IsValid || !x509CertificateImpl.IsValid)
			{
				return false;
			}
			if (!this.Issuer.Equals(x509CertificateImpl.Issuer))
			{
				return false;
			}
			byte[] serialNumber = this.SerialNumber;
			byte[] serialNumber2 = x509CertificateImpl.SerialNumber;
			if (serialNumber.Length != serialNumber2.Length)
			{
				return false;
			}
			for (int i = 0; i < serialNumber.Length; i++)
			{
				if (serialNumber[i] != serialNumber2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0006D601 File Offset: 0x0006B801
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0006D610 File Offset: 0x0006B810
		~X509CertificateImpl()
		{
			this.Dispose(false);
		}
	}
}
