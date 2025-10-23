using System;

namespace Java.Interop
{
	// Token: 0x0200042A RID: 1066
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public class ExportParameterAttribute : Attribute
	{
		// Token: 0x06002E8A RID: 11914 RVA: 0x0007F01C File Offset: 0x0007D21C
		public ExportParameterAttribute(ExportParameterKind kind)
		{
			this.Kind = kind;
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002E8B RID: 11915 RVA: 0x0007F02B File Offset: 0x0007D22B
		// (set) Token: 0x06002E8C RID: 11916 RVA: 0x0007F033 File Offset: 0x0007D233
		public ExportParameterKind Kind { get; private set; }
	}
}
