using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.AppCompat.View
{
	// Token: 0x0200008C RID: 140
	[Register("androidx/appcompat/view/CollapsibleActionView", "", "AndroidX.AppCompat.View.ICollapsibleActionViewInvoker")]
	public interface ICollapsibleActionView : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060009D6 RID: 2518
		[Register("onActionViewCollapsed", "()V", "GetOnActionViewCollapsedHandler:AndroidX.AppCompat.View.ICollapsibleActionViewInvoker, Xamarin.AndroidX.AppCompat")]
		void OnActionViewCollapsed();

		// Token: 0x060009D7 RID: 2519
		[Register("onActionViewExpanded", "()V", "GetOnActionViewExpandedHandler:AndroidX.AppCompat.View.ICollapsibleActionViewInvoker, Xamarin.AndroidX.AppCompat")]
		void OnActionViewExpanded();
	}
}
