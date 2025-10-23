using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000B1 RID: 177
	[Register("androidx/core/view/ScrollingView", "", "AndroidX.Core.View.IScrollingViewInvoker")]
	public interface IScrollingView : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000A02 RID: 2562
		[Register("computeHorizontalScrollExtent", "()I", "GetComputeHorizontalScrollExtentHandler:AndroidX.Core.View.IScrollingViewInvoker, Xamarin.AndroidX.Core")]
		int ComputeHorizontalScrollExtent();

		// Token: 0x06000A03 RID: 2563
		[Register("computeHorizontalScrollOffset", "()I", "GetComputeHorizontalScrollOffsetHandler:AndroidX.Core.View.IScrollingViewInvoker, Xamarin.AndroidX.Core")]
		int ComputeHorizontalScrollOffset();

		// Token: 0x06000A04 RID: 2564
		[Register("computeHorizontalScrollRange", "()I", "GetComputeHorizontalScrollRangeHandler:AndroidX.Core.View.IScrollingViewInvoker, Xamarin.AndroidX.Core")]
		int ComputeHorizontalScrollRange();

		// Token: 0x06000A05 RID: 2565
		[Register("computeVerticalScrollExtent", "()I", "GetComputeVerticalScrollExtentHandler:AndroidX.Core.View.IScrollingViewInvoker, Xamarin.AndroidX.Core")]
		int ComputeVerticalScrollExtent();

		// Token: 0x06000A06 RID: 2566
		[Register("computeVerticalScrollOffset", "()I", "GetComputeVerticalScrollOffsetHandler:AndroidX.Core.View.IScrollingViewInvoker, Xamarin.AndroidX.Core")]
		int ComputeVerticalScrollOffset();

		// Token: 0x06000A07 RID: 2567
		[Register("computeVerticalScrollRange", "()I", "GetComputeVerticalScrollRangeHandler:AndroidX.Core.View.IScrollingViewInvoker, Xamarin.AndroidX.Core")]
		int ComputeVerticalScrollRange();
	}
}
