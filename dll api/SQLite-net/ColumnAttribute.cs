using System;

namespace SQLite
{
	// Token: 0x02000015 RID: 21
	[AttributeUsage(AttributeTargets.Property)]
	public class ColumnAttribute : Attribute
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00004412 File Offset: 0x00002612
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000441A File Offset: 0x0000261A
		public string Name { get; set; }

		// Token: 0x060000AE RID: 174 RVA: 0x00004423 File Offset: 0x00002623
		public ColumnAttribute(string name)
		{
			this.Name = name;
		}
	}
}
