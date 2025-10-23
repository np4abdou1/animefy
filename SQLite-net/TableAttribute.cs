using System;

namespace SQLite
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Class)]
	public class TableAttribute : Attribute
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000043E1 File Offset: 0x000025E1
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000043E9 File Offset: 0x000025E9
		public string Name { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000043F2 File Offset: 0x000025F2
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000043FA File Offset: 0x000025FA
		public bool WithoutRowId { get; set; }

		// Token: 0x060000AB RID: 171 RVA: 0x00004403 File Offset: 0x00002603
		public TableAttribute(string name)
		{
			this.Name = name;
		}
	}
}
