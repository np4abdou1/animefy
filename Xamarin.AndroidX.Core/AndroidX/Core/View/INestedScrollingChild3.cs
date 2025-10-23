using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000AA RID: 170
	[Register("androidx/core/view/NestedScrollingChild3", "", "AndroidX.Core.View.INestedScrollingChild3Invoker")]
	public interface INestedScrollingChild3 : INestedScrollingChild2, INestedScrollingChild, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600093E RID: 2366
		[Register("dispatchNestedScroll", "(IIII[II[I)V", "GetDispatchNestedScroll_IIIIarrayIIarrayIHandler:AndroidX.Core.View.INestedScrollingChild3Invoker, Xamarin.AndroidX.Core")]
		void DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type, int[] consumed);
	}
}
