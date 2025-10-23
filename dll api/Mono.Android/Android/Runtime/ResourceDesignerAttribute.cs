using System;

namespace Android.Runtime
{
	// Token: 0x020002F3 RID: 755
	[AttributeUsage(AttributeTargets.Assembly)]
	public class ResourceDesignerAttribute : Attribute
	{
		// Token: 0x06001DE8 RID: 7656 RVA: 0x00051E05 File Offset: 0x00050005
		public ResourceDesignerAttribute(string fullName)
		{
			this.FullName = fullName;
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00051E14 File Offset: 0x00050014
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x00051E1C File Offset: 0x0005001C
		public string FullName { get; set; }

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00051E25 File Offset: 0x00050025
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x00051E2D File Offset: 0x0005002D
		public bool IsApplication { get; set; }
	}
}
