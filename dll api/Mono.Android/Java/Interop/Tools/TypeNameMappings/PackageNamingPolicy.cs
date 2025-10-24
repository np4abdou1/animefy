using System;

namespace Java.Interop.Tools.TypeNameMappings
{
	// Token: 0x02000442 RID: 1090
	internal enum PackageNamingPolicy
	{
		// Token: 0x040012CD RID: 4813
		LowercaseHash,
		// Token: 0x040012CE RID: 4814
		Lowercase,
		// Token: 0x040012CF RID: 4815
		LowercaseWithAssemblyName,
		// Token: 0x040012D0 RID: 4816
		LowercaseMD5 = 0,
		// Token: 0x040012D1 RID: 4817
		LowercaseCrc64 = 3
	}
}
