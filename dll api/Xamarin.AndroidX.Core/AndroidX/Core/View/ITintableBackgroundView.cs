using System;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.View
{
	// Token: 0x020000B3 RID: 179
	[Register("androidx/core/view/TintableBackgroundView", "", "AndroidX.Core.View.ITintableBackgroundViewInvoker")]
	public interface ITintableBackgroundView : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A23 RID: 2595
		// (set) Token: 0x06000A24 RID: 2596
		ColorStateList SupportBackgroundTintList { [Register("getSupportBackgroundTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportBackgroundTintListHandler:AndroidX.Core.View.ITintableBackgroundViewInvoker, Xamarin.AndroidX.Core")] get; [Register("setSupportBackgroundTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportBackgroundTintList_Landroid_content_res_ColorStateList_Handler:AndroidX.Core.View.ITintableBackgroundViewInvoker, Xamarin.AndroidX.Core")] set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A25 RID: 2597
		// (set) Token: 0x06000A26 RID: 2598
		PorterDuff.Mode SupportBackgroundTintMode { [Register("getSupportBackgroundTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportBackgroundTintModeHandler:AndroidX.Core.View.ITintableBackgroundViewInvoker, Xamarin.AndroidX.Core")] get; [Register("setSupportBackgroundTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_Handler:AndroidX.Core.View.ITintableBackgroundViewInvoker, Xamarin.AndroidX.Core")] set; }
	}
}
