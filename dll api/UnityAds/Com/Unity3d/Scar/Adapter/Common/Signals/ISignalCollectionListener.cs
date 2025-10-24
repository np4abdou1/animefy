using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002AF RID: 687
	[Register("com/unity3d/scar/adapter/common/signals/ISignalCollectionListener", "", "Com.Unity3d.Scar.Adapter.Common.Signals.ISignalCollectionListenerInvoker")]
	public interface ISignalCollectionListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002723 RID: 10019
		[Register("onSignalsCollected", "(Ljava/lang/String;)V", "GetOnSignalsCollected_Ljava_lang_String_Handler:Com.Unity3d.Scar.Adapter.Common.Signals.ISignalCollectionListenerInvoker, UnityAds")]
		void OnSignalsCollected(string p0);

		// Token: 0x06002724 RID: 10020
		[Register("onSignalsCollectionFailed", "(Ljava/lang/String;)V", "GetOnSignalsCollectionFailed_Ljava_lang_String_Handler:Com.Unity3d.Scar.Adapter.Common.Signals.ISignalCollectionListenerInvoker, UnityAds")]
		void OnSignalsCollectionFailed(string p0);
	}
}
