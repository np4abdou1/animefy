using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000BD RID: 189
	[Register("com/applovin/mediation/MaxMediatedNetworkInfo", "", "Com.Applovin.Mediation.IMaxMediatedNetworkInfoInvoker")]
	public interface IMaxMediatedNetworkInfo : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000668 RID: 1640
		string AdapterClassName { [Register("getAdapterClassName", "()Ljava/lang/String;", "GetGetAdapterClassNameHandler:Com.Applovin.Mediation.IMaxMediatedNetworkInfoInvoker, AppLovin")] get; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000669 RID: 1641
		string AdapterVersion { [Register("getAdapterVersion", "()Ljava/lang/String;", "GetGetAdapterVersionHandler:Com.Applovin.Mediation.IMaxMediatedNetworkInfoInvoker, AppLovin")] get; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600066A RID: 1642
		string Name { [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Applovin.Mediation.IMaxMediatedNetworkInfoInvoker, AppLovin")] get; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600066B RID: 1643
		string SdkVersion { [Register("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler:Com.Applovin.Mediation.IMaxMediatedNetworkInfoInvoker, AppLovin")] get; }
	}
}
