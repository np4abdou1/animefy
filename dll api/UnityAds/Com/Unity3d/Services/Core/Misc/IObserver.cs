using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000DD RID: 221
	[Register("com/unity3d/services/core/misc/IObserver", "", "Com.Unity3d.Services.Core.Misc.IObserverInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IObserver : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600089F RID: 2207
		[Register("updated", "(Ljava/lang/Object;)V", "GetUpdated_Ljava_lang_Object_Handler:Com.Unity3d.Services.Core.Misc.IObserverInvoker, UnityAds")]
		void Updated(Java.Lang.Object p0);
	}
}
