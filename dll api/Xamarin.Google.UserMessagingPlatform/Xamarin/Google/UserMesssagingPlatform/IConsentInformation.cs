using System;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200002C RID: 44
	[Register("com/google/android/ump/ConsentInformation", "", "Xamarin.Google.UserMesssagingPlatform.IConsentInformationInvoker")]
	public interface IConsentInformation : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F8 RID: 248
		int ConsentStatus { [Register("getConsentStatus", "()I", "GetGetConsentStatusHandler:Xamarin.Google.UserMesssagingPlatform.IConsentInformationInvoker, Xamarin.Google.UserMessagingPlatform")] get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F9 RID: 249
		bool IsConsentFormAvailable { [Register("isConsentFormAvailable", "()Z", "GetIsConsentFormAvailableHandler:Xamarin.Google.UserMesssagingPlatform.IConsentInformationInvoker, Xamarin.Google.UserMessagingPlatform")] get; }

		// Token: 0x060000FA RID: 250
		[Register("requestConsentInfoUpdate", "(Landroid/app/Activity;Lcom/google/android/ump/ConsentRequestParameters;Lcom/google/android/ump/ConsentInformation$OnConsentInfoUpdateSuccessListener;Lcom/google/android/ump/ConsentInformation$OnConsentInfoUpdateFailureListener;)V", "GetRequestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_Handler:Xamarin.Google.UserMesssagingPlatform.IConsentInformationInvoker, Xamarin.Google.UserMessagingPlatform")]
		void RequestConsentInfoUpdate(Activity p0, ConsentRequestParameters p1, IConsentInformationOnConsentInfoUpdateSuccessListener p2, IConsentInformationOnConsentInfoUpdateFailureListener p3);

		// Token: 0x060000FB RID: 251
		[Register("reset", "()V", "GetResetHandler:Xamarin.Google.UserMesssagingPlatform.IConsentInformationInvoker, Xamarin.Google.UserMessagingPlatform")]
		void Reset();
	}
}
