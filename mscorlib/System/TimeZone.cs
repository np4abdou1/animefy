using System;

namespace System
{
	/// <summary>Represents a time zone.</summary>
	// Token: 0x02000106 RID: 262
	[Serializable]
	public abstract class TimeZone
	{
		// Token: 0x06000982 RID: 2434 RVA: 0x00029CB6 File Offset: 0x00027EB6
		internal static void ClearCachedData()
		{
			TimeZone.currentTimeZone = null;
		}

		// Token: 0x04000380 RID: 896
		private static volatile TimeZone currentTimeZone;
	}
}
