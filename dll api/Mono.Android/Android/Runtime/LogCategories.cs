using System;

namespace Android.Runtime
{
	// Token: 0x020002ED RID: 749
	[Flags]
	internal enum LogCategories
	{
		// Token: 0x04000C54 RID: 3156
		None = 0,
		// Token: 0x04000C55 RID: 3157
		Default = 1,
		// Token: 0x04000C56 RID: 3158
		Assembly = 2,
		// Token: 0x04000C57 RID: 3159
		Debugger = 4,
		// Token: 0x04000C58 RID: 3160
		GC = 8,
		// Token: 0x04000C59 RID: 3161
		GlobalRef = 16,
		// Token: 0x04000C5A RID: 3162
		LocalRef = 32,
		// Token: 0x04000C5B RID: 3163
		Timing = 64,
		// Token: 0x04000C5C RID: 3164
		Bundle = 128,
		// Token: 0x04000C5D RID: 3165
		Net = 256,
		// Token: 0x04000C5E RID: 3166
		Netlink = 512
	}
}
