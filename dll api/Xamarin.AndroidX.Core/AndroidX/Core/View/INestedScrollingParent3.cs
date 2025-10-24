using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000AF RID: 175
	[Register("androidx/core/view/NestedScrollingParent3", "", "AndroidX.Core.View.INestedScrollingParent3Invoker")]
	public interface INestedScrollingParent3 : INestedScrollingParent2, INestedScrollingParent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060009CE RID: 2510
		[Register("onNestedScroll", "(Landroid/view/View;IIIII[I)V", "GetOnNestedScroll_Landroid_view_View_IIIIIarrayIHandler:AndroidX.Core.View.INestedScrollingParent3Invoker, Xamarin.AndroidX.Core")]
		void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed);
	}
}
