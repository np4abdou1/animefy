using System;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.Widget
{
	// Token: 0x02000089 RID: 137
	[Register("androidx/core/widget/TintableCompoundButton", "", "AndroidX.Core.Widget.ITintableCompoundButtonInvoker")]
	public interface ITintableCompoundButton : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060007B4 RID: 1972
		// (set) Token: 0x060007B5 RID: 1973
		ColorStateList SupportButtonTintList { [Register("getSupportButtonTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportButtonTintListHandler:AndroidX.Core.Widget.ITintableCompoundButtonInvoker, Xamarin.AndroidX.Core")] get; [Register("setSupportButtonTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportButtonTintList_Landroid_content_res_ColorStateList_Handler:AndroidX.Core.Widget.ITintableCompoundButtonInvoker, Xamarin.AndroidX.Core")] set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060007B6 RID: 1974
		// (set) Token: 0x060007B7 RID: 1975
		PorterDuff.Mode SupportButtonTintMode { [Register("getSupportButtonTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportButtonTintModeHandler:AndroidX.Core.Widget.ITintableCompoundButtonInvoker, Xamarin.AndroidX.Core")] get; [Register("setSupportButtonTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_Handler:AndroidX.Core.Widget.ITintableCompoundButtonInvoker, Xamarin.AndroidX.Core")] set; }
	}
}
