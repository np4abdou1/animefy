using System;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.RecyclerView.Widget
{
	// Token: 0x0200004D RID: 77
	[Register("androidx/recyclerview/widget/ItemTouchUIUtil", "", "AndroidX.RecyclerView.Widget.IItemTouchUIUtilInvoker")]
	public interface IItemTouchUIUtil : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600015A RID: 346
		[Register("clearView", "(Landroid/view/View;)V", "GetClearView_Landroid_view_View_Handler:AndroidX.RecyclerView.Widget.IItemTouchUIUtilInvoker, Xamarin.AndroidX.RecyclerView")]
		void ClearView(View p0);

		// Token: 0x0600015B RID: 347
		[Register("onDraw", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;FFIZ)V", "GetOnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZHandler:AndroidX.RecyclerView.Widget.IItemTouchUIUtilInvoker, Xamarin.AndroidX.RecyclerView")]
		void OnDraw(Canvas p0, RecyclerView p1, View p2, float p3, float p4, int p5, bool p6);

		// Token: 0x0600015C RID: 348
		[Register("onDrawOver", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;FFIZ)V", "GetOnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZHandler:AndroidX.RecyclerView.Widget.IItemTouchUIUtilInvoker, Xamarin.AndroidX.RecyclerView")]
		void OnDrawOver(Canvas p0, RecyclerView p1, View p2, float p3, float p4, int p5, bool p6);

		// Token: 0x0600015D RID: 349
		[Register("onSelected", "(Landroid/view/View;)V", "GetOnSelected_Landroid_view_View_Handler:AndroidX.RecyclerView.Widget.IItemTouchUIUtilInvoker, Xamarin.AndroidX.RecyclerView")]
		void OnSelected(View p0);
	}
}
