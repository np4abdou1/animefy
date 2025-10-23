using System;

namespace Mono
{
	// Token: 0x02000003 RID: 3
	internal class SystemDependencyProvider : ISystemDependencyProvider
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002241 File Offset: 0x00000441
		public static SystemDependencyProvider Instance
		{
			get
			{
				SystemDependencyProvider.Initialize();
				return SystemDependencyProvider.instance;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002250 File Offset: 0x00000450
		internal static void Initialize()
		{
			object obj = SystemDependencyProvider.syncRoot;
			lock (obj)
			{
				if (SystemDependencyProvider.instance == null)
				{
					SystemDependencyProvider.instance = new SystemDependencyProvider();
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000229C File Offset: 0x0000049C
		ISystemCertificateProvider ISystemDependencyProvider.CertificateProvider
		{
			get
			{
				return this.CertificateProvider;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000022A4 File Offset: 0x000004A4
		public SystemCertificateProvider CertificateProvider { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000022AC File Offset: 0x000004AC
		public X509PalImpl X509Pal
		{
			get
			{
				return this.CertificateProvider.X509Pal;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022B9 File Offset: 0x000004B9
		private SystemDependencyProvider()
		{
			this.CertificateProvider = new SystemCertificateProvider();
			DependencyInjector.Register(this);
		}

		// Token: 0x04000005 RID: 5
		private static SystemDependencyProvider instance;

		// Token: 0x04000006 RID: 6
		private static object syncRoot = new object();
	}
}
