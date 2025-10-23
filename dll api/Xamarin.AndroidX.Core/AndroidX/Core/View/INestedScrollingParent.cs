using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000AC RID: 172
	[Register("androidx/core/view/NestedScrollingParent", "", "AndroidX.Core.View.INestedScrollingParentInvoker")]
	public interface INestedScrollingParent : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000975 RID: 2421
		ScrollAxis NestedScrollAxes { [Register("getNestedScrollAxes", "()I", "GetGetNestedScrollAxesHandler:AndroidX.Core.View.INestedScrollingParentInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x06000976 RID: 2422
		[Register("onNestedFling", "(Landroid/view/View;FFZ)Z", "GetOnNestedFling_Landroid_view_View_FFZHandler:AndroidX.Core.View.INestedScrollingParentInvoker, Xamarin.AndroidX.Core")]
		bool OnNestedFling(View target, float velocityX, float velocityY, bool consumed);

		// Token: 0x06000977 RID: 2423
		[Register("onNestedPreFling", "(Landroid/view/View;FF)Z", "GetOnNestedPreFling_Landroid_view_View_FFHandler:AndroidX.Core.View.INestedScrollingParentInvoker, Xamarin.AndroidX.Core")]
		bool OnNestedPreFling(View target, float velocityX, float velocityY);

		// Token: 0x06000978 RID: 2424
		[Register("onNestedPreScroll", "(Landroid/view/View;II[I)V", "GetOnNestedPreScroll_Landroid_view_View_IIarrayIHandler:AndroidX.Core.View.INestedScrollingParentInvoker, Xamarin.AndroidX.Core")]
		void OnNestedPreScroll(View target, int dx, int dy, int[] consumed);

		// Token: 0x06000979 RID: 2425
		[Register("onNestedScroll", "(Landroid/view/View;IIII)V", "GetOnNestedScroll_Landroid_view_View_IIIIHandler:AndroidX.Core.View.INestedScrollingParentInvoker, Xamarin.AndroidX.Core")]
		void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed);

		// Token: 0x0600097A RID: 2426
		[Register("onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;I)V", "GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IHandler:AndroidX.Core.View.INestedScrollingParentInvoker, Xamarin.AndroidX.Core")]
		void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis axes);

		// Token: 0x0600097B RID: 2427
		[Register("onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;I)Z", "GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IHandler:AndroidX.Core.View.INestedScrollingParentInvoker, Xamarin.AndroidX.Core")]
		bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis axes);

		// Token: 0x0600097C RID: 2428
		[Register("onStopNestedScroll", "(Landroid/view/View;)V", "GetOnStopNestedScroll_Landroid_view_View_Handler:AndroidX.Core.View.INestedScrollingParentInvoker, Xamarin.AndroidX.Core")]
		void OnStopNestedScroll(View target);
	}
}
