using System;
using System.IO;

namespace Mono.Security.X509
{
	// Token: 0x02000019 RID: 25
	public sealed class X509StoreManager
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00007FA0 File Offset: 0x000061A0
		internal static string CurrentUserPath
		{
			get
			{
				if (X509StoreManager._userPath == null)
				{
					X509StoreManager._userPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".mono");
					X509StoreManager._userPath = Path.Combine(X509StoreManager._userPath, "certs");
				}
				return X509StoreManager._userPath;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00007FD8 File Offset: 0x000061D8
		internal static string LocalMachinePath
		{
			get
			{
				if (X509StoreManager._localMachinePath == null)
				{
					X509StoreManager._localMachinePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), ".mono");
					X509StoreManager._localMachinePath = Path.Combine(X509StoreManager._localMachinePath, "certs");
				}
				return X509StoreManager._localMachinePath;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00008010 File Offset: 0x00006210
		public static X509Stores CurrentUser
		{
			get
			{
				if (X509StoreManager._userStore == null)
				{
					X509StoreManager._userStore = new X509Stores(X509StoreManager.CurrentUserPath, false);
				}
				return X509StoreManager._userStore;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000802E File Offset: 0x0000622E
		public static X509Stores LocalMachine
		{
			get
			{
				if (X509StoreManager._machineStore == null)
				{
					X509StoreManager._machineStore = new X509Stores(X509StoreManager.LocalMachinePath, false);
				}
				return X509StoreManager._machineStore;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000804C File Offset: 0x0000624C
		public static X509CertificateCollection TrustedRootCertificates
		{
			get
			{
				X509CertificateCollection x509CertificateCollection = new X509CertificateCollection();
				x509CertificateCollection.AddRange(X509StoreManager.CurrentUser.TrustedRoot.Certificates);
				x509CertificateCollection.AddRange(X509StoreManager.LocalMachine.TrustedRoot.Certificates);
				return x509CertificateCollection;
			}
		}

		// Token: 0x04000078 RID: 120
		private static string _userPath;

		// Token: 0x04000079 RID: 121
		private static string _localMachinePath;

		// Token: 0x0400007A RID: 122
		private static X509Stores _userStore;

		// Token: 0x0400007B RID: 123
		private static X509Stores _machineStore;
	}
}
