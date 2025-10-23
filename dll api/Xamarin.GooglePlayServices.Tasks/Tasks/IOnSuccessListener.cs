using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x02000015 RID: 21
	[Register("com/google/android/gms/tasks/OnSuccessListener", "", "Android.Gms.Tasks.IOnSuccessListenerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"TResult"
	})]
	public interface IOnSuccessListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000CC RID: 204
		[Register("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Android.Gms.Tasks.IOnSuccessListenerInvoker, Xamarin.GooglePlayServices.Tasks")]
		void OnSuccess(Java.Lang.Object result);
	}
}
