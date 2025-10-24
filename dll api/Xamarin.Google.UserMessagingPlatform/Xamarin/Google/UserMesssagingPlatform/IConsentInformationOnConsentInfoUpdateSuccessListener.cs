using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000029 RID: 41
	[Register("com/google/android/ump/ConsentInformation$OnConsentInfoUpdateSuccessListener", "", "Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker")]
	public interface IConsentInformationOnConsentInfoUpdateSuccessListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000E8 RID: 232
		[Register("onConsentInfoUpdateSuccess", "()V", "GetOnConsentInfoUpdateSuccessHandler:Xamarin.Google.UserMesssagingPlatform.IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker, Xamarin.Google.UserMessagingPlatform")]
		void OnConsentInfoUpdateSuccess();
	}
}
