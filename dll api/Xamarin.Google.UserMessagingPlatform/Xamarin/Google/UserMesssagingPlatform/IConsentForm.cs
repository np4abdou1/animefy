using System;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200001F RID: 31
	[Register("com/google/android/ump/ConsentForm", "", "Xamarin.Google.UserMesssagingPlatform.IConsentFormInvoker")]
	public interface IConsentForm : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000B2 RID: 178
		[Register("show", "(Landroid/app/Activity;Lcom/google/android/ump/ConsentForm$OnConsentFormDismissedListener;)V", "GetShow_Landroid_app_Activity_Lcom_google_android_ump_ConsentForm_OnConsentFormDismissedListener_Handler:Xamarin.Google.UserMesssagingPlatform.IConsentFormInvoker, Xamarin.Google.UserMessagingPlatform")]
		void Show(Activity p0, IConsentFormOnConsentFormDismissedListener p1);
	}
}
