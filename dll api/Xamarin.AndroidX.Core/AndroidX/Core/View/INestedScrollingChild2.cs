using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000A8 RID: 168
	[Register("androidx/core/view/NestedScrollingChild2", "", "AndroidX.Core.View.INestedScrollingChild2Invoker")]
	public interface INestedScrollingChild2 : INestedScrollingChild, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000906 RID: 2310
		[Register("dispatchNestedPreScroll", "(II[I[II)Z", "GetDispatchNestedPreScroll_IIarrayIarrayIIHandler:AndroidX.Core.View.INestedScrollingChild2Invoker, Xamarin.AndroidX.Core")]
		bool DispatchNestedPreScroll(int dx, int dy, int[] consumed, int[] offsetInWindow, int type);

		// Token: 0x06000907 RID: 2311
		[Register("dispatchNestedScroll", "(IIII[II)Z", "GetDispatchNestedScroll_IIIIarrayIIHandler:AndroidX.Core.View.INestedScrollingChild2Invoker, Xamarin.AndroidX.Core")]
		bool DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type);

		// Token: 0x06000908 RID: 2312
		[Register("hasNestedScrollingParent", "(I)Z", "GetInvokeHasNestedScrollingParent_IHandler:AndroidX.Core.View.INestedScrollingChild2Invoker, Xamarin.AndroidX.Core")]
		bool InvokeHasNestedScrollingParent(int type);

		// Token: 0x06000909 RID: 2313
		[Register("startNestedScroll", "(II)Z", "GetStartNestedScroll_IIHandler:AndroidX.Core.View.INestedScrollingChild2Invoker, Xamarin.AndroidX.Core")]
		bool StartNestedScroll([GeneratedEnum] ScrollAxis axes, int type);

		// Token: 0x0600090A RID: 2314
		[Register("stopNestedScroll", "(I)V", "GetStopNestedScroll_IHandler:AndroidX.Core.View.INestedScrollingChild2Invoker, Xamarin.AndroidX.Core")]
		void StopNestedScroll(int type);
	}
}
