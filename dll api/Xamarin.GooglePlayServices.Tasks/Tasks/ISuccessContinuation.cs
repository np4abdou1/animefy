using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x02000019 RID: 25
	[Register("com/google/android/gms/tasks/SuccessContinuation", "", "Android.Gms.Tasks.ISuccessContinuationInvoker")]
	[JavaTypeParameters(new string[]
	{
		"TResult",
		"TContinuationResult"
	})]
	public interface ISuccessContinuation : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000E6 RID: 230
		[Register("then", "(Ljava/lang/Object;)Lcom/google/android/gms/tasks/Task;", "GetThen_Ljava_lang_Object_Handler:Android.Gms.Tasks.ISuccessContinuationInvoker, Xamarin.GooglePlayServices.Tasks")]
		Task Then(Java.Lang.Object result);
	}
}
