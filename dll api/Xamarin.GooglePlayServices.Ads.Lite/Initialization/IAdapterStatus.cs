using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.Initialization
{
	// Token: 0x02000039 RID: 57
	[Register("com/google/android/gms/ads/initialization/AdapterStatus", "", "Android.Gms.Ads.Initialization.IAdapterStatusInvoker")]
	public interface IAdapterStatus : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000241 RID: 577
		string Description { [Register("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Android.Gms.Ads.Initialization.IAdapterStatusInvoker, Xamarin.GooglePlayServices.Ads.Lite")] get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000242 RID: 578
		AdapterStatusState InitializationState { [Register("getInitializationState", "()Lcom/google/android/gms/ads/initialization/AdapterStatus$State;", "GetGetInitializationStateHandler:Android.Gms.Ads.Initialization.IAdapterStatusInvoker, Xamarin.GooglePlayServices.Ads.Lite")] get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000243 RID: 579
		int Latency { [Register("getLatency", "()I", "GetGetLatencyHandler:Android.Gms.Ads.Initialization.IAdapterStatusInvoker, Xamarin.GooglePlayServices.Ads.Lite")] get; }
	}
}
