using System;

namespace SQLite
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum CreateFlags
	{
		// Token: 0x04000011 RID: 17
		None = 0,
		// Token: 0x04000012 RID: 18
		ImplicitPK = 1,
		// Token: 0x04000013 RID: 19
		ImplicitIndex = 2,
		// Token: 0x04000014 RID: 20
		AllImplicit = 3,
		// Token: 0x04000015 RID: 21
		AutoIncPK = 4,
		// Token: 0x04000016 RID: 22
		FullTextSearch3 = 256,
		// Token: 0x04000017 RID: 23
		FullTextSearch4 = 512
	}
}
