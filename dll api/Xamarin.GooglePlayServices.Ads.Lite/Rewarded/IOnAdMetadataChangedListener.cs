using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x02000024 RID: 36
	[Register("com/google/android/gms/ads/rewarded/OnAdMetadataChangedListener", "", "Android.Gms.Ads.Rewarded.IOnAdMetadataChangedListenerInvoker")]
	public interface IOnAdMetadataChangedListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600016A RID: 362
		[Register("onAdMetadataChanged", "()V", "GetOnAdMetadataChangedHandler:Android.Gms.Ads.Rewarded.IOnAdMetadataChangedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite")]
		void OnAdMetadataChanged();
	}
}
