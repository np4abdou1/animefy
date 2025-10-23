using System;
using Android.Runtime;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C2 RID: 194
	[Register("com/applovin/mediation/MaxReward", DoNotGenerateAcw = true)]
	public abstract class MaxReward : Java.Lang.Object
	{
		// Token: 0x060006A9 RID: 1705 RVA: 0x000105C8 File Offset: 0x0000E7C8
		internal MaxReward()
		{
		}

		// Token: 0x0400023B RID: 571
		[Register("DEFAULT_AMOUNT")]
		public const int DefaultAmount = 0;

		// Token: 0x0400023C RID: 572
		[Register("DEFAULT_LABEL")]
		public const string DefaultLabel = "";
	}
}
