using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000B7 RID: 183
	[Register("androidx/core/view/ViewPropertyAnimatorUpdateListener", "", "AndroidX.Core.View.IViewPropertyAnimatorUpdateListenerInvoker")]
	public interface IViewPropertyAnimatorUpdateListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000A51 RID: 2641
		[Register("onAnimationUpdate", "(Landroid/view/View;)V", "GetOnAnimationUpdate_Landroid_view_View_Handler:AndroidX.Core.View.IViewPropertyAnimatorUpdateListenerInvoker, Xamarin.AndroidX.Core")]
		void OnAnimationUpdate(View view);
	}
}
