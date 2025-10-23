using System;

namespace SQLite
{
	// Token: 0x0200001D RID: 29
	[AttributeUsage(AttributeTargets.Property)]
	public class CollationAttribute : Attribute
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000044AE File Offset: 0x000026AE
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x000044B6 File Offset: 0x000026B6
		public string Value { get; private set; }

		// Token: 0x060000C3 RID: 195 RVA: 0x000044BF File Offset: 0x000026BF
		public CollationAttribute(string collation)
		{
			this.Value = collation;
		}
	}
}
