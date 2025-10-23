using System;
using System.Diagnostics.CodeAnalysis;

namespace Java.Interop
{
	// Token: 0x02000429 RID: 1065
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public class ExportFieldAttribute : Attribute
	{
		// Token: 0x06002E87 RID: 11911 RVA: 0x0007EFFC File Offset: 0x0007D1FC
		[DynamicDependency(DynamicallyAccessedMemberTypes.All, "Java.Interop.DynamicCallbackCodeGenerator", "Mono.Android.Export")]
		public ExportFieldAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x0007F00B File Offset: 0x0007D20B
		// (set) Token: 0x06002E89 RID: 11913 RVA: 0x0007F013 File Offset: 0x0007D213
		public string Name { get; set; }
	}
}
