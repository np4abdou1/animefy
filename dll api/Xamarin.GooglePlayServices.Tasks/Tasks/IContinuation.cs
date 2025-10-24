using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x0200000D RID: 13
	[Register("com/google/android/gms/tasks/Continuation", "", "Android.Gms.Tasks.IContinuationInvoker")]
	[JavaTypeParameters(new string[]
	{
		"TResult",
		"TContinuationResult"
	})]
	public interface IContinuation : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000098 RID: 152
		[Register("then", "(Lcom/google/android/gms/tasks/Task;)Ljava/lang/Object;", "GetThen_Lcom_google_android_gms_tasks_Task_Handler:Android.Gms.Tasks.IContinuationInvoker, Xamarin.GooglePlayServices.Tasks")]
		Java.Lang.Object Then(Task task);
	}
}
