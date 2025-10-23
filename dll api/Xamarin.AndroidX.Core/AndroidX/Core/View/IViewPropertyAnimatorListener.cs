using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000B5 RID: 181
	[Register("androidx/core/view/ViewPropertyAnimatorListener", "", "AndroidX.Core.View.IViewPropertyAnimatorListenerInvoker")]
	public interface IViewPropertyAnimatorListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000A3C RID: 2620
		[Register("onAnimationCancel", "(Landroid/view/View;)V", "GetOnAnimationCancel_Landroid_view_View_Handler:AndroidX.Core.View.IViewPropertyAnimatorListenerInvoker, Xamarin.AndroidX.Core")]
		void OnAnimationCancel(View view);

		// Token: 0x06000A3D RID: 2621
		[Register("onAnimationEnd", "(Landroid/view/View;)V", "GetOnAnimationEnd_Landroid_view_View_Handler:AndroidX.Core.View.IViewPropertyAnimatorListenerInvoker, Xamarin.AndroidX.Core")]
		void OnAnimationEnd(View view);

		// Token: 0x06000A3E RID: 2622
		[Register("onAnimationStart", "(Landroid/view/View;)V", "GetOnAnimationStart_Landroid_view_View_Handler:AndroidX.Core.View.IViewPropertyAnimatorListenerInvoker, Xamarin.AndroidX.Core")]
		void OnAnimationStart(View view);
	}
}
