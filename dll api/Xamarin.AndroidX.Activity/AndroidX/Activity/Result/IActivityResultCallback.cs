using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result
{
	// Token: 0x02000025 RID: 37
	[Register("androidx/activity/result/ActivityResultCallback", "", "AndroidX.Activity.Result.IActivityResultCallbackInvoker")]
	[JavaTypeParameters(new string[]
	{
		"O"
	})]
	public interface IActivityResultCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600011D RID: 285
		[Register("onActivityResult", "(Ljava/lang/Object;)V", "GetOnActivityResult_Ljava_lang_Object_Handler:AndroidX.Activity.Result.IActivityResultCallbackInvoker, Xamarin.AndroidX.Activity")]
		void OnActivityResult(Java.Lang.Object result);
	}
}
