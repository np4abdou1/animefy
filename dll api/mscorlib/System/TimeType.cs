using System;

namespace System
{
	// Token: 0x02000185 RID: 389
	internal class TimeType
	{
		// Token: 0x06000F40 RID: 3904 RVA: 0x00040036 File Offset: 0x0003E236
		public TimeType(int offset, bool is_dst, string abbrev)
		{
			this.Offset = offset;
			this.IsDst = is_dst;
			this.Name = abbrev;
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00040054 File Offset: 0x0003E254
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"offset: ",
				this.Offset.ToString(),
				"s, is_dst: ",
				this.IsDst.ToString(),
				", zone name: ",
				this.Name
			});
		}

		// Token: 0x040005C5 RID: 1477
		public readonly int Offset;

		// Token: 0x040005C6 RID: 1478
		public readonly bool IsDst;

		// Token: 0x040005C7 RID: 1479
		public string Name;
	}
}
