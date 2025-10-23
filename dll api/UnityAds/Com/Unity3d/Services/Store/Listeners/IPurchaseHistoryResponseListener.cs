using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;

namespace Com.Unity3d.Services.Store.Listeners
{
	// Token: 0x0200003C RID: 60
	[Register("com/unity3d/services/store/listeners/IPurchaseHistoryResponseListener", "", "Com.Unity3d.Services.Store.Listeners.IPurchaseHistoryResponseListenerInvoker")]
	public interface IPurchaseHistoryResponseListener : IBillingDataResponseListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000120 RID: 288
		[Register("onBillingResponse", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V", "GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler:Com.Unity3d.Services.Store.Listeners.IPurchaseHistoryResponseListenerInvoker, UnityAds")]
		void OnBillingResponse(BillingResultBridge p0, IList<PurchaseHistoryRecordBridge> p1);
	}
}
