using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000A6 RID: 166
	[Register("androidx/core/view/NestedScrollingChild", "", "AndroidX.Core.View.INestedScrollingChildInvoker")]
	public interface INestedScrollingChild : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060008D9 RID: 2265
		bool HasNestedScrollingParent { [Register("hasNestedScrollingParent", "()Z", "GetHasNestedScrollingParentHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060008DA RID: 2266
		// (set) Token: 0x060008DB RID: 2267
		bool NestedScrollingEnabled { [Register("isNestedScrollingEnabled", "()Z", "GetIsNestedScrollingEnabledHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")] get; [Register("setNestedScrollingEnabled", "(Z)V", "GetSetNestedScrollingEnabled_ZHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")] set; }

		// Token: 0x060008DC RID: 2268
		[Register("dispatchNestedFling", "(FFZ)Z", "GetDispatchNestedFling_FFZHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")]
		bool DispatchNestedFling(float velocityX, float velocityY, bool consumed);

		// Token: 0x060008DD RID: 2269
		[Register("dispatchNestedPreFling", "(FF)Z", "GetDispatchNestedPreFling_FFHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")]
		bool DispatchNestedPreFling(float velocityX, float velocityY);

		// Token: 0x060008DE RID: 2270
		[Register("dispatchNestedPreScroll", "(II[I[I)Z", "GetDispatchNestedPreScroll_IIarrayIarrayIHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")]
		bool DispatchNestedPreScroll(int dx, int dy, int[] consumed, int[] offsetInWindow);

		// Token: 0x060008DF RID: 2271
		[Register("dispatchNestedScroll", "(IIII[I)Z", "GetDispatchNestedScroll_IIIIarrayIHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")]
		bool DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow);

		// Token: 0x060008E0 RID: 2272
		[Register("startNestedScroll", "(I)Z", "GetStartNestedScroll_IHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")]
		bool StartNestedScroll([GeneratedEnum] ScrollAxis axes);

		// Token: 0x060008E1 RID: 2273
		[Register("stopNestedScroll", "()V", "GetStopNestedScrollHandler:AndroidX.Core.View.INestedScrollingChildInvoker, Xamarin.AndroidX.Core")]
		void StopNestedScroll();
	}
}
