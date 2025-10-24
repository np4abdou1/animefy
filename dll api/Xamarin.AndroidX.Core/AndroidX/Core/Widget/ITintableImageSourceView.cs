using System;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.Widget
{
	// Token: 0x0200008D RID: 141
	[Register("androidx/core/widget/TintableImageSourceView", "", "AndroidX.Core.Widget.ITintableImageSourceViewInvoker")]
	public interface ITintableImageSourceView : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060007E6 RID: 2022
		// (set) Token: 0x060007E7 RID: 2023
		ColorStateList SupportImageTintList { [Register("getSupportImageTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportImageTintListHandler:AndroidX.Core.Widget.ITintableImageSourceViewInvoker, Xamarin.AndroidX.Core")] get; [Register("setSupportImageTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportImageTintList_Landroid_content_res_ColorStateList_Handler:AndroidX.Core.Widget.ITintableImageSourceViewInvoker, Xamarin.AndroidX.Core")] set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060007E8 RID: 2024
		// (set) Token: 0x060007E9 RID: 2025
		PorterDuff.Mode SupportImageTintMode { [Register("getSupportImageTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportImageTintModeHandler:AndroidX.Core.Widget.ITintableImageSourceViewInvoker, Xamarin.AndroidX.Core")] get; [Register("setSupportImageTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_Handler:AndroidX.Core.Widget.ITintableImageSourceViewInvoker, Xamarin.AndroidX.Core")] set; }
	}
}
