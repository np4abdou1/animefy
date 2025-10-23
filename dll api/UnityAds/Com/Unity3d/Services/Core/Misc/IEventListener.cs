using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000D7 RID: 215
	[Register("com/unity3d/services/core/misc/IEventListener", "", "Com.Unity3d.Services.Core.Misc.IEventListenerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IEventListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600087C RID: 2172
		[Register("onNextEvent", "(Ljava/lang/Object;)V", "GetOnNextEvent_Ljava_lang_Object_Handler:Com.Unity3d.Services.Core.Misc.IEventListenerInvoker, UnityAds")]
		void OnNextEvent(Java.Lang.Object p0);
	}
}
