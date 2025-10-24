using System;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient
{
	// Token: 0x0200005C RID: 92
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient", "", "Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientInvoker")]
	public interface IBillingClient : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000276 RID: 630
		bool IsReady { [Register("isReady", "()Z", "GetIsReadyHandler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientInvoker, UnityAds")] get; }

		// Token: 0x06000277 RID: 631
		[Register("isFeatureSupported", "(Ljava/lang/String;)Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", "GetIsFeatureSupported_Ljava_lang_String_Handler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientInvoker, UnityAds")]
		BillingResultResponseCode IsFeatureSupported(string p0);

		// Token: 0x06000278 RID: 632
		[Register("queryPurchaseHistoryAsync", "(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchaseHistoryResponseListenerProxy;)V", "GetQueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchaseHistoryResponseListenerProxy_Handler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientInvoker, UnityAds")]
		void QueryPurchaseHistoryAsync(string p0, PurchaseHistoryResponseListenerProxy p1);

		// Token: 0x06000279 RID: 633
		[Register("queryPurchasesAsync", "(Ljava/lang/String;Lcom/unity3d/services/store/gpbl/proxies/PurchasesResponseListenerProxy;)V", "GetQueryPurchasesAsync_Ljava_lang_String_Lcom_unity3d_services_store_gpbl_proxies_PurchasesResponseListenerProxy_Handler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientInvoker, UnityAds")]
		void QueryPurchasesAsync(string p0, PurchasesResponseListenerProxy p1);

		// Token: 0x0600027A RID: 634
		[Register("querySkuDetailsAsync", "(Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge;Lcom/unity3d/services/store/gpbl/proxies/SkuDetailsResponseListenerProxy;)V", "GetQuerySkuDetailsAsync_Lcom_unity3d_services_store_gpbl_bridges_SkuDetailsParamsBridge_Lcom_unity3d_services_store_gpbl_proxies_SkuDetailsResponseListenerProxy_Handler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientInvoker, UnityAds")]
		void QuerySkuDetailsAsync(SkuDetailsParamsBridge p0, SkuDetailsResponseListenerProxy p1);

		// Token: 0x0600027B RID: 635
		[Register("startConnection", "(Lcom/unity3d/services/store/gpbl/proxies/BillingClientStateListenerProxy;)V", "GetStartConnection_Lcom_unity3d_services_store_gpbl_proxies_BillingClientStateListenerProxy_Handler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientInvoker, UnityAds")]
		void StartConnection(BillingClientStateListenerProxy p0);
	}
}
