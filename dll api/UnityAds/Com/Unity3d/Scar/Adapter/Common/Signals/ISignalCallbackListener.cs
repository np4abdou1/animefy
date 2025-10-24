using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002AA RID: 682
	[Register("com/unity3d/scar/adapter/common/signals/ISignalCallbackListener", "", "Com.Unity3d.Scar.Adapter.Common.Signals.ISignalCallbackListenerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ISignalCallbackListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002708 RID: 9992
		[Register("onFailure", "(Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Handler:Com.Unity3d.Scar.Adapter.Common.Signals.ISignalCallbackListenerInvoker, UnityAds")]
		void OnFailure(string p0);

		// Token: 0x06002709 RID: 9993
		[Register("onSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Unity3d.Scar.Adapter.Common.Signals.ISignalCallbackListenerInvoker, UnityAds")]
		void OnSuccess(string p0, string p1, Java.Lang.Object p2);
	}
}
