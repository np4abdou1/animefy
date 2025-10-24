using System;

namespace Android.Runtime
{
	// Token: 0x020002C3 RID: 707
	public class AnnotationAttribute : Attribute
	{
		// Token: 0x06001AE9 RID: 6889 RVA: 0x000464FA File Offset: 0x000446FA
		public AnnotationAttribute(string javaName)
		{
			this.JavaName = javaName;
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00046509 File Offset: 0x00044709
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x00046511 File Offset: 0x00044711
		public string JavaName { get; private set; }
	}
}
