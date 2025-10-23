using System;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl.Bridges;
using Java.Interop;

namespace Com.Unity3d.Services.Store.Gpbl
{
	// Token: 0x02000046 RID: 70
	[Register("com/unity3d/services/store/gpbl/IBillingClientStateListener", "", "Com.Unity3d.Services.Store.Gpbl.IBillingClientStateListenerInvoker")]
	public interface IBillingClientStateListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600017A RID: 378
		[Register("onBillingServiceDisconnected", "()V", "GetOnBillingServiceDisconnectedHandler:Com.Unity3d.Services.Store.Gpbl.IBillingClientStateListenerInvoker, UnityAds")]
		void OnBillingServiceDisconnected();

		// Token: 0x0600017B RID: 379
		[Register("onBillingSetupFinished", "(Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;)V", "GetOnBillingSetupFinished_Lcom_unity3d_services_store_gpbl_bridges_BillingResultBridge_Handler:Com.Unity3d.Services.Store.Gpbl.IBillingClientStateListenerInvoker, UnityAds")]
		void OnBillingSetupFinished(BillingResultBridge p0);
	}
}
