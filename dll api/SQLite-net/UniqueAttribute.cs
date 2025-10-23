using System;

namespace SQLite
{
	// Token: 0x0200001A RID: 26
	[AttributeUsage(AttributeTargets.Property)]
	public class UniqueAttribute : IndexedAttribute
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00004483 File Offset: 0x00002683
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000402B File Offset: 0x0000222B
		public override bool Unique
		{
			get
			{
				return true;
			}
			set
			{
			}
		}
	}
}
