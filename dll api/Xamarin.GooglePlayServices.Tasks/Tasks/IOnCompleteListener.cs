using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Tasks
{
	// Token: 0x02000011 RID: 17
	[Register("com/google/android/gms/tasks/OnCompleteListener", "", "Android.Gms.Tasks.IOnCompleteListenerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"TResult"
	})]
	public interface IOnCompleteListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000B2 RID: 178
		[Register("onComplete", "(Lcom/google/android/gms/tasks/Task;)V", "GetOnComplete_Lcom_google_android_gms_tasks_Task_Handler:Android.Gms.Tasks.IOnCompleteListenerInvoker, Xamarin.GooglePlayServices.Tasks")]
		void OnComplete(Task task);
	}
}
