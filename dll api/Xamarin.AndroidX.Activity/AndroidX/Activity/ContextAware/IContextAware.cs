using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Activity.ContextAware
{
	// Token: 0x0200001B RID: 27
	[Register("androidx/activity/contextaware/ContextAware", "", "AndroidX.Activity.ContextAware.IContextAwareInvoker")]
	public interface IContextAware : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000C8 RID: 200
		[Register("addOnContextAvailableListener", "(Landroidx/activity/contextaware/OnContextAvailableListener;)V", "GetAddOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_Handler:AndroidX.Activity.ContextAware.IContextAwareInvoker, Xamarin.AndroidX.Activity")]
		void AddOnContextAvailableListener(IOnContextAvailableListener listener);

		// Token: 0x060000C9 RID: 201
		[Register("peekAvailableContext", "()Landroid/content/Context;", "GetPeekAvailableContextHandler:AndroidX.Activity.ContextAware.IContextAwareInvoker, Xamarin.AndroidX.Activity")]
		Context PeekAvailableContext();

		// Token: 0x060000CA RID: 202
		[Register("removeOnContextAvailableListener", "(Landroidx/activity/contextaware/OnContextAvailableListener;)V", "GetRemoveOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_Handler:AndroidX.Activity.ContextAware.IContextAwareInvoker, Xamarin.AndroidX.Activity")]
		void RemoveOnContextAvailableListener(IOnContextAvailableListener listener);
	}
}
