using System;
using Android.Runtime;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B9 RID: 185
	[Register("com/applovin/mediation/MaxErrorCode", DoNotGenerateAcw = true)]
	public abstract class MaxErrorCode : Java.Lang.Object
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x000105C8 File Offset: 0x0000E7C8
		internal MaxErrorCode()
		{
		}

		// Token: 0x04000218 RID: 536
		[Register("AD_LOAD_FAILED")]
		public const int AdLoadFailed = -5001;

		// Token: 0x04000219 RID: 537
		[Register("DONT_KEEP_ACTIVITIES_ENABLED")]
		public const int DontKeepActivitiesEnabled = -5602;

		// Token: 0x0400021A RID: 538
		[Register("FULLSCREEN_AD_ALREADY_SHOWING")]
		public const int FullscreenAdAlreadyShowing = -23;

		// Token: 0x0400021B RID: 539
		[Register("FULLSCREEN_AD_NOT_READY")]
		public const int FullscreenAdNotReady = -24;

		// Token: 0x0400021C RID: 540
		[Register("NETWORK_ERROR")]
		public const int NetworkError = -1000;

		// Token: 0x0400021D RID: 541
		[Register("NETWORK_TIMEOUT")]
		public const int NetworkTimeout = -1001;

		// Token: 0x0400021E RID: 542
		[Register("NO_ACTIVITY")]
		public const int NoActivity = -5601;

		// Token: 0x0400021F RID: 543
		[Register("NO_FILL")]
		public const int NoFill = 204;

		// Token: 0x04000220 RID: 544
		[Register("NO_NETWORK")]
		public const int NoNetwork = -1009;

		// Token: 0x04000221 RID: 545
		[Register("UNSPECIFIED")]
		public const int Unspecified = -1;
	}
}
