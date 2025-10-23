using System;
using System.Diagnostics.CodeAnalysis;

namespace Java.Interop
{
	// Token: 0x02000428 RID: 1064
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public class ExportAttribute : Attribute
	{
		// Token: 0x06002E7D RID: 11901 RVA: 0x0000216A File Offset: 0x0000036A
		[DynamicDependency(DynamicallyAccessedMemberTypes.All, "Java.Interop.DynamicCallbackCodeGenerator", "Mono.Android.Export")]
		public ExportAttribute()
		{
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x0007EFA9 File Offset: 0x0007D1A9
		[DynamicDependency(DynamicallyAccessedMemberTypes.All, "Java.Interop.DynamicCallbackCodeGenerator", "Mono.Android.Export")]
		public ExportAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x0007EFB8 File Offset: 0x0007D1B8
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x0007EFC0 File Offset: 0x0007D1C0
		public string Name { get; private set; }

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x0007EFC9 File Offset: 0x0007D1C9
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x0007EFD1 File Offset: 0x0007D1D1
		public string SuperArgumentsString { get; set; }

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x0007EFDA File Offset: 0x0007D1DA
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x0007EFE2 File Offset: 0x0007D1E2
		public Type[] Throws { get; set; }

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x0007EFEB File Offset: 0x0007D1EB
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x0007EFF3 File Offset: 0x0007D1F3
		internal string[] ThrownNames { get; set; }
	}
}
