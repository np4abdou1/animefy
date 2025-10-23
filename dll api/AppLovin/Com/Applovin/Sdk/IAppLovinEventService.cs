using System;
using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000085 RID: 133
	[Register("com/applovin/sdk/AppLovinEventService", "", "Com.Applovin.Sdk.IAppLovinEventServiceInvoker")]
	public interface IAppLovinEventService : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000451 RID: 1105
		IDictionary<string, Java.Lang.Object> SuperProperties { [Register("getSuperProperties", "()Ljava/util/Map;", "GetGetSuperPropertiesHandler:Com.Applovin.Sdk.IAppLovinEventServiceInvoker, AppLovin")] get; }

		// Token: 0x06000452 RID: 1106
		[Register("setSuperProperty", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetSetSuperProperty_Ljava_lang_Object_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinEventServiceInvoker, AppLovin")]
		void SetSuperProperty(Java.Lang.Object p0, string p1);

		// Token: 0x06000453 RID: 1107
		[Register("trackCheckout", "(Ljava/lang/String;Ljava/util/Map;)V", "GetTrackCheckout_Ljava_lang_String_Ljava_util_Map_Handler:Com.Applovin.Sdk.IAppLovinEventServiceInvoker, AppLovin")]
		void TrackCheckout(string p0, IDictionary<string, string> p1);

		// Token: 0x06000454 RID: 1108
		[Register("trackEvent", "(Ljava/lang/String;)V", "GetTrackEvent_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinEventServiceInvoker, AppLovin")]
		void TrackEvent(string p0);

		// Token: 0x06000455 RID: 1109
		[Register("trackEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetTrackEvent_Ljava_lang_String_Ljava_util_Map_Handler:Com.Applovin.Sdk.IAppLovinEventServiceInvoker, AppLovin")]
		void TrackEvent(string p0, IDictionary<string, string> p1);

		// Token: 0x06000456 RID: 1110
		[Register("trackInAppPurchase", "(Landroid/content/Intent;Ljava/util/Map;)V", "GetTrackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_Handler:Com.Applovin.Sdk.IAppLovinEventServiceInvoker, AppLovin")]
		void TrackInAppPurchase(Intent p0, IDictionary<string, string> p1);
	}
}
