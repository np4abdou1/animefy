using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B4 RID: 692
	[Register("com/unity3d/scar/adapter/common/signals/ISignalsCollector", "", "Com.Unity3d.Scar.Adapter.Common.Signals.ISignalsCollectorInvoker")]
	public interface ISignalsCollector : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600273C RID: 10044
		[Register("getSCARSignal", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", "GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler:Com.Unity3d.Scar.Adapter.Common.Signals.ISignalsCollectorInvoker, UnityAds")]
		void GetSCARSignal(Context p0, string p1, bool p2, DispatchGroup p3, SignalsResult p4);

		// Token: 0x0600273D RID: 10045
		[Register("getSCARSignals", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Lcom/unity3d/scar/adapter/common/signals/ISignalCollectionListener;)V", "GetGetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_Handler:Com.Unity3d.Scar.Adapter.Common.Signals.ISignalsCollectorInvoker, UnityAds")]
		void GetSCARSignals(Context p0, string[] p1, string[] p2, ISignalCollectionListener p3);
	}
}
