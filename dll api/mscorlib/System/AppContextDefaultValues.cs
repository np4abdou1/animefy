using System;

namespace System
{
	// Token: 0x0200015F RID: 351
	internal static class AppContextDefaultValues
	{
		// Token: 0x06000E08 RID: 3592 RVA: 0x00002A7D File Offset: 0x00000C7D
		public static void PopulateDefaultValues()
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0003BF1E File Offset: 0x0003A11E
		public static bool TryGetSwitchOverride(string switchName, out bool overrideValue)
		{
			overrideValue = false;
			return false;
		}
	}
}
