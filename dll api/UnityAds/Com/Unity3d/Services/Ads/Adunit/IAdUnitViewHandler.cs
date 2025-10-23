using System;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x02000231 RID: 561
	[Register("com/unity3d/services/ads/adunit/IAdUnitViewHandler", "", "Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker")]
	public interface IAdUnitViewHandler : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001AD6 RID: 6870
		View View { [Register("getView", "()Landroid/view/View;", "GetGetViewHandler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")] get; }

		// Token: 0x06001AD7 RID: 6871
		[Register("create", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)Z", "GetCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")]
		bool Create(AdUnitActivity p0);

		// Token: 0x06001AD8 RID: 6872
		[Register("destroy", "()Z", "GetDestroyHandler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")]
		bool Destroy();

		// Token: 0x06001AD9 RID: 6873
		[Register("onCreate", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;Landroid/os/Bundle;)V", "GetOnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_Handler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")]
		void OnCreate(AdUnitActivity p0, Bundle p1);

		// Token: 0x06001ADA RID: 6874
		[Register("onDestroy", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")]
		void OnDestroy(AdUnitActivity p0);

		// Token: 0x06001ADB RID: 6875
		[Register("onPause", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")]
		void OnPause(AdUnitActivity p0);

		// Token: 0x06001ADC RID: 6876
		[Register("onResume", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")]
		void OnResume(AdUnitActivity p0);

		// Token: 0x06001ADD RID: 6877
		[Register("onStart", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")]
		void OnStart(AdUnitActivity p0);

		// Token: 0x06001ADE RID: 6878
		[Register("onStop", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler:Com.Unity3d.Services.Ads.Adunit.IAdUnitViewHandlerInvoker, UnityAds")]
		void OnStop(AdUnitActivity p0);
	}
}
