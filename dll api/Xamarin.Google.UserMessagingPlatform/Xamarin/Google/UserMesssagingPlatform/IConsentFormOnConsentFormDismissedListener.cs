using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200001B RID: 27
	[Register("com/google/android/ump/ConsentForm$OnConsentFormDismissedListener", "", "Xamarin.Google.UserMesssagingPlatform.IConsentFormOnConsentFormDismissedListenerInvoker")]
	public interface IConsentFormOnConsentFormDismissedListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000A0 RID: 160
		[Register("onConsentFormDismissed", "(Lcom/google/android/ump/FormError;)V", "GetOnConsentFormDismissed_Lcom_google_android_ump_FormError_Handler:Xamarin.Google.UserMesssagingPlatform.IConsentFormOnConsentFormDismissedListenerInvoker, Xamarin.Google.UserMessagingPlatform")]
		void OnConsentFormDismissed(FormError p0);
	}
}
