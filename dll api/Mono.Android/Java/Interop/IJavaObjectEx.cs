using System;

namespace Java.Interop
{
	// Token: 0x02000432 RID: 1074
	internal interface IJavaObjectEx
	{
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002ED1 RID: 11985
		// (set) Token: 0x06002ED2 RID: 11986
		IntPtr KeyHandle { get; set; }

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002ED3 RID: 11987
		// (set) Token: 0x06002ED4 RID: 11988
		bool IsProxy { get; set; }

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06002ED5 RID: 11989
		// (set) Token: 0x06002ED6 RID: 11990
		bool NeedsActivation { get; set; }

		// Token: 0x06002ED7 RID: 11991
		IntPtr ToLocalJniHandle();
	}
}
