using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x0200008F RID: 143
	[Register("androidx/core/view/NestedScrollingParent2", "", "AndroidX.Core.View.INestedScrollingParent2Invoker")]
	public interface INestedScrollingParent2 : INestedScrollingParent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x000184C8 File Offset: 0x000166C8
		void OnNestedScrollAccepted(View child, View target, int axis, int type)
		{
			this.OnNestedScrollAccepted(child, target, (ScrollAxis)axis, type);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000184E4 File Offset: 0x000166E4
		bool OnStartNestedScroll(View child, View target, int axis, int type)
		{
			return this.OnStartNestedScroll(child, target, (ScrollAxis)axis, type);
		}

		// Token: 0x06000801 RID: 2049
		[Register("onNestedPreScroll", "(Landroid/view/View;II[II)V", "GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler:AndroidX.Core.View.INestedScrollingParent2Invoker, Xamarin.AndroidX.Core")]
		void OnNestedPreScroll(View target, int dx, int dy, int[] consumed, int type);

		// Token: 0x06000802 RID: 2050
		[Register("onNestedScroll", "(Landroid/view/View;IIIII)V", "GetOnNestedScroll_Landroid_view_View_IIIIIHandler:AndroidX.Core.View.INestedScrollingParent2Invoker, Xamarin.AndroidX.Core")]
		void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type);

		// Token: 0x06000803 RID: 2051
		[Register("onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;II)V", "GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler:AndroidX.Core.View.INestedScrollingParent2Invoker, Xamarin.AndroidX.Core")]
		void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis axes, int type);

		// Token: 0x06000804 RID: 2052
		[Register("onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;II)Z", "GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler:AndroidX.Core.View.INestedScrollingParent2Invoker, Xamarin.AndroidX.Core")]
		bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis axes, int type);

		// Token: 0x06000805 RID: 2053
		[Register("onStopNestedScroll", "(Landroid/view/View;I)V", "GetOnStopNestedScroll_Landroid_view_View_IHandler:AndroidX.Core.View.INestedScrollingParent2Invoker, Xamarin.AndroidX.Core")]
		void OnStopNestedScroll(View target, int type);
	}
}
