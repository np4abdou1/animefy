using System;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Proxies;
using Java.Interop;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient
{
	// Token: 0x0200005E RID: 94
	[Register("com/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge", "", "Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientBuilderBridgeInvoker")]
	public interface IBillingClientBuilderBridge : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000297 RID: 663
		[Register("build", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClient;", "GetBuildHandler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientBuilderBridgeInvoker, UnityAds")]
		IBillingClient Build();

		// Token: 0x06000298 RID: 664
		[Register("enablePendingPurchases", "()Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;", "GetEnablePendingPurchasesHandler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientBuilderBridgeInvoker, UnityAds")]
		IBillingClientBuilderBridge EnablePendingPurchases();

		// Token: 0x06000299 RID: 665
		[Register("setListener", "(Lcom/unity3d/services/store/gpbl/proxies/PurchaseUpdatedListenerProxy;)Lcom/unity3d/services/store/gpbl/bridges/billingclient/IBillingClientBuilderBridge;", "GetSetListener_Lcom_unity3d_services_store_gpbl_proxies_PurchaseUpdatedListenerProxy_Handler:Com.Unity3d.Services.Store.Gpbl.Bridges.Billingclient.IBillingClientBuilderBridgeInvoker, UnityAds")]
		IBillingClientBuilderBridge SetListener(PurchaseUpdatedListenerProxy p0);
	}
}
