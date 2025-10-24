using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;

namespace Com.Unity3d.Services.Store.Listeners
{
	// Token: 0x02000040 RID: 64
	[Register("com/unity3d/services/store/listeners/IPurchaseUpdatedResponseListener", "", "Com.Unity3d.Services.Store.Listeners.IPurchaseUpdatedResponseListenerInvoker")]
	public interface IPurchaseUpdatedResponseListener : IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600013C RID: 316
		[Register("onBillingResponse", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V", "GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler:Com.Unity3d.Services.Store.Listeners.IPurchaseUpdatedResponseListenerInvoker, UnityAds")]
		void OnBillingResponse(BillingResultBridge p0, IList<PurchaseBridge> p1);
	}
}
