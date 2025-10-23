using System;

namespace SQLite
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Property)]
	public class MaxLengthAttribute : Attribute
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000448E File Offset: 0x0000268E
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00004496 File Offset: 0x00002696
		public int Value { get; private set; }

		// Token: 0x060000BF RID: 191 RVA: 0x0000449F File Offset: 0x0000269F
		public MaxLengthAttribute(int length)
		{
			this.Value = length;
		}
	}
}
