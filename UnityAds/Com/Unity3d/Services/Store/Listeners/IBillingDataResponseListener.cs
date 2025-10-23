using System;
using System.Collections;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;

namespace Com.Unity3d.Services.Store.Listeners
{
	// Token: 0x02000038 RID: 56
	[Register("com/unity3d/services/store/listeners/IBillingDataResponseListener", "", "Com.Unity3d.Services.Store.Listeners.IBillingDataResponseListenerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends com.unity3d.services.store.gpbl.IBillingResponse"
	})]
	public interface IBillingDataResponseListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600010D RID: 269
		[Register("onBillingResponse", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;Ljava/util/List;)V", "GetOnBillingResponse_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Ljava_util_List_Handler:Com.Unity3d.Services.Store.Listeners.IBillingDataResponseListenerInvoker, UnityAds")]
		void OnBillingResponse(BillingResultBridge p0, IList p1);
	}
}
