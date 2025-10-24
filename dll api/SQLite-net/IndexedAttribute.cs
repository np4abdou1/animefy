using System;

namespace SQLite
{
	// Token: 0x02000018 RID: 24
	[AttributeUsage(AttributeTargets.Property)]
	public class IndexedAttribute : Attribute
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000443A File Offset: 0x0000263A
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00004442 File Offset: 0x00002642
		public string Name { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000444B File Offset: 0x0000264B
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00004453 File Offset: 0x00002653
		public int Order { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000445C File Offset: 0x0000265C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00004464 File Offset: 0x00002664
		public virtual bool Unique { get; set; }

		// Token: 0x060000B7 RID: 183 RVA: 0x00004432 File Offset: 0x00002632
		public IndexedAttribute()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000446D File Offset: 0x0000266D
		public IndexedAttribute(string name, int order)
		{
			this.Name = name;
			this.Order = order;
		}
	}
}
