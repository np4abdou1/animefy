using System;
using Android.Runtime;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000021 RID: 33
	[Register("com/google/android/ump/ConsentInformation$ConsentStatus", DoNotGenerateAcw = true)]
	public abstract class ConsentInformationConsentStatus : Java.Lang.Object
	{
		// Token: 0x060000BF RID: 191 RVA: 0x000024C4 File Offset: 0x000006C4
		internal ConsentInformationConsentStatus()
		{
		}

		// Token: 0x04000036 RID: 54
		[Register("NOT_REQUIRED")]
		public const int NotRequired = 1;

		// Token: 0x04000037 RID: 55
		[Register("OBTAINED")]
		public const int Obtained = 3;

		// Token: 0x04000038 RID: 56
		[Register("REQUIRED")]
		public const int Required = 2;

		// Token: 0x04000039 RID: 57
		[Register("UNKNOWN")]
		public const int Unknown = 0;
	}
}
