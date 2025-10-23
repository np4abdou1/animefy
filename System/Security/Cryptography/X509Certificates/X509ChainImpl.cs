using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000FD RID: 253
	internal abstract class X509ChainImpl : IDisposable
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000722 RID: 1826
		public abstract bool IsValid { get; }

		// Token: 0x06000723 RID: 1827 RVA: 0x00028F15 File Offset: 0x00027115
		protected void ThrowIfContextInvalid()
		{
			if (!this.IsValid)
			{
				throw X509Helper2.GetInvalidChainContextException();
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000724 RID: 1828
		public abstract X509ChainElementCollection ChainElements { get; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000725 RID: 1829
		public abstract X509ChainPolicy ChainPolicy { get; }

		// Token: 0x06000726 RID: 1830
		public abstract bool Build(X509Certificate2 certificate);

		// Token: 0x06000727 RID: 1831
		public abstract void AddStatus(X509ChainStatusFlags errorCode);

		// Token: 0x06000728 RID: 1832
		public abstract void Reset();

		// Token: 0x06000729 RID: 1833 RVA: 0x00028F25 File Offset: 0x00027125
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00004D67 File Offset: 0x00002F67
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00028F34 File Offset: 0x00027134
		~X509ChainImpl()
		{
			this.Dispose(false);
		}
	}
}
