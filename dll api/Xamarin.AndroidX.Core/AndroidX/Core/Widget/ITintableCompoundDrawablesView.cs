using System;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.Widget
{
	// Token: 0x0200008B RID: 139
	[Register("androidx/core/widget/TintableCompoundDrawablesView", "", "AndroidX.Core.Widget.ITintableCompoundDrawablesViewInvoker")]
	public interface ITintableCompoundDrawablesView : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060007CD RID: 1997
		// (set) Token: 0x060007CE RID: 1998
		ColorStateList SupportCompoundDrawablesTintList { [Register("getSupportCompoundDrawablesTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportCompoundDrawablesTintListHandler:AndroidX.Core.Widget.ITintableCompoundDrawablesViewInvoker, Xamarin.AndroidX.Core")] get; [Register("setSupportCompoundDrawablesTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_Handler:AndroidX.Core.Widget.ITintableCompoundDrawablesViewInvoker, Xamarin.AndroidX.Core")] set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060007CF RID: 1999
		// (set) Token: 0x060007D0 RID: 2000
		PorterDuff.Mode SupportCompoundDrawablesTintMode { [Register("getSupportCompoundDrawablesTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportCompoundDrawablesTintModeHandler:AndroidX.Core.Widget.ITintableCompoundDrawablesViewInvoker, Xamarin.AndroidX.Core")] get; [Register("setSupportCompoundDrawablesTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_Handler:AndroidX.Core.Widget.ITintableCompoundDrawablesViewInvoker, Xamarin.AndroidX.Core")] set; }
	}
}
