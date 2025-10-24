using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.Initialization
{
	// Token: 0x0200003B RID: 59
	[Register("com/google/android/gms/ads/initialization/InitializationStatus", "", "Android.Gms.Ads.Initialization.IInitializationStatusInvoker")]
	public interface IInitializationStatus : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000256 RID: 598
		IDictionary<string, IAdapterStatus> AdapterStatusMap { [Register("getAdapterStatusMap", "()Ljava/util/Map;", "GetGetAdapterStatusMapHandler:Android.Gms.Ads.Initialization.IInitializationStatusInvoker, Xamarin.GooglePlayServices.Ads.Lite")] get; }
	}
}
