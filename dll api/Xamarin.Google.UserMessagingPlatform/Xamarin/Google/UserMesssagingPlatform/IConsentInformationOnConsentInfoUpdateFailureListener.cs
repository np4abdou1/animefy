using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000025 RID: 37
	[Register("com/google/android/ump/ConsentInformation$OnConsentInfoUpdateFailureListener", "", "Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateFailureListenerInvoker")]
	public interface IConsentInformationOnConsentInfoUpdateFailureListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000D6 RID: 214
		[Register("onConsentInfoUpdateFailure", "(Lcom/google/android/ump/FormError;)V", "GetOnConsentInfoUpdateFailure_Lcom_google_android_ump_FormError_Handler:Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateFailureListenerInvoker, Xamarin.Google.UserMessagingPlatform")]
		void OnConsentInfoUpdateFailure(FormError p0);
	}
}
