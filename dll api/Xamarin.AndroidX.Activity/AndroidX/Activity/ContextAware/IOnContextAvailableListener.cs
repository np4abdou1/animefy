using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Activity.ContextAware
{
	// Token: 0x0200001D RID: 29
	[Register("androidx/activity/contextaware/OnContextAvailableListener", "", "AndroidX.Activity.ContextAware.IOnContextAvailableListenerInvoker")]
	public interface IOnContextAvailableListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000DD RID: 221
		[Register("onContextAvailable", "(Landroid/content/Context;)V", "GetOnContextAvailable_Landroid_content_Context_Handler:AndroidX.Activity.ContextAware.IOnContextAvailableListenerInvoker, Xamarin.AndroidX.Activity")]
		void OnContextAvailable(Context context);
	}
}
