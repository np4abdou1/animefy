using System;

namespace System.Globalization
{
	// Token: 0x0200059A RID: 1434
	internal static class GlobalizationMode
	{
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x000AD218 File Offset: 0x000AB418
		internal static bool Invariant { get; } = GlobalizationMode.GetGlobalizationInvariantMode();

		// Token: 0x06002AC0 RID: 10944 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		private static bool GetGlobalizationInvariantMode()
		{
			return false;
		}
	}
}
