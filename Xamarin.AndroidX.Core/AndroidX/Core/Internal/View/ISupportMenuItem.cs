using System;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Internal.View
{
	// Token: 0x02000053 RID: 83
	[Register("androidx/core/internal/view/SupportMenuItem", "", "AndroidX.Core.Internal.View.ISupportMenuItemInvoker")]
	public interface ISupportMenuItem : IMenuItem, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001B2 RID: 434
		View ActionView { [Register("getActionView", "()Landroid/view/View;", "GetGetActionViewHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001B3 RID: 435
		int AlphabeticModifiers { [Register("getAlphabeticModifiers", "()I", "GetGetAlphabeticModifiersHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001B4 RID: 436
		ICharSequence ContentDescriptionFormatted { [Register("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001B5 RID: 437
		ColorStateList IconTintList { [Register("getIconTintList", "()Landroid/content/res/ColorStateList;", "GetGetIconTintListHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001B6 RID: 438
		PorterDuff.Mode IconTintMode { [Register("getIconTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetIconTintModeHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001B7 RID: 439
		bool IsActionViewExpanded { [Register("isActionViewExpanded", "()Z", "GetIsActionViewExpandedHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001B8 RID: 440
		int NumericModifiers { [Register("getNumericModifiers", "()I", "GetGetNumericModifiersHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001B9 RID: 441
		AndroidX.Core.View.ActionProvider SupportActionProvider { [Register("getSupportActionProvider", "()Landroidx/core/view/ActionProvider;", "GetGetSupportActionProviderHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001BA RID: 442
		ICharSequence TooltipTextFormatted { [Register("getTooltipText", "()Ljava/lang/CharSequence;", "GetGetTooltipTextHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")] get; }

		// Token: 0x060001BB RID: 443
		[Register("collapseActionView", "()Z", "GetCollapseActionViewHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		bool CollapseActionView();

		// Token: 0x060001BC RID: 444
		[Register("expandActionView", "()Z", "GetExpandActionViewHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		bool ExpandActionView();

		// Token: 0x060001BD RID: 445
		[Register("requiresActionButton", "()Z", "GetRequiresActionButtonHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		bool RequiresActionButton();

		// Token: 0x060001BE RID: 446
		[Register("requiresOverflow", "()Z", "GetRequiresOverflowHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		bool RequiresOverflow();

		// Token: 0x060001BF RID: 447
		[Register("setActionView", "(Landroid/view/View;)Landroid/view/MenuItem;", "GetSetActionView_Landroid_view_View_Handler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		IMenuItem SetActionView(View view);

		// Token: 0x060001C0 RID: 448
		[Register("setActionView", "(I)Landroid/view/MenuItem;", "GetSetActionView_IHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		IMenuItem SetActionView(int resId);

		// Token: 0x060001C1 RID: 449
		[Register("setAlphabeticShortcut", "(CI)Landroid/view/MenuItem;", "GetSetAlphabeticShortcut_CIHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		IMenuItem SetAlphabeticShortcut(char alphaChar, int alphaModifiers);

		// Token: 0x060001C2 RID: 450
		[Register("setContentDescription", "(Ljava/lang/CharSequence;)Landroidx/core/internal/view/SupportMenuItem;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		ISupportMenuItem SetContentDescription(ICharSequence contentDescription);

		// Token: 0x060001C3 RID: 451
		[Register("setIconTintList", "(Landroid/content/res/ColorStateList;)Landroid/view/MenuItem;", "GetSetIconTintList_Landroid_content_res_ColorStateList_Handler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		IMenuItem SetIconTintList(ColorStateList tint);

		// Token: 0x060001C4 RID: 452
		[Register("setIconTintMode", "(Landroid/graphics/PorterDuff$Mode;)Landroid/view/MenuItem;", "GetSetIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		IMenuItem SetIconTintMode(PorterDuff.Mode tintMode);

		// Token: 0x060001C5 RID: 453
		[Register("setNumericShortcut", "(CI)Landroid/view/MenuItem;", "GetSetNumericShortcut_CIHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		IMenuItem SetNumericShortcut(char numericChar, int numericModifiers);

		// Token: 0x060001C6 RID: 454
		[Register("setShortcut", "(CCII)Landroid/view/MenuItem;", "GetSetShortcut_CCIIHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		IMenuItem SetShortcut(char numericChar, char alphaChar, int numericModifiers, int alphaModifiers);

		// Token: 0x060001C7 RID: 455
		[Register("setShowAsAction", "(I)V", "GetSetShowAsAction_IHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		void SetShowAsAction([GeneratedEnum] ShowAsAction actionEnum);

		// Token: 0x060001C8 RID: 456
		[Register("setShowAsActionFlags", "(I)Landroid/view/MenuItem;", "GetSetShowAsActionFlags_IHandler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		IMenuItem SetShowAsActionFlags([GeneratedEnum] ShowAsAction actionEnum);

		// Token: 0x060001C9 RID: 457
		[Register("setSupportActionProvider", "(Landroidx/core/view/ActionProvider;)Landroidx/core/internal/view/SupportMenuItem;", "GetSetSupportActionProvider_Landroidx_core_view_ActionProvider_Handler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		ISupportMenuItem SetSupportActionProvider(AndroidX.Core.View.ActionProvider actionProvider);

		// Token: 0x060001CA RID: 458
		[Register("setTooltipText", "(Ljava/lang/CharSequence;)Landroidx/core/internal/view/SupportMenuItem;", "GetSetTooltipText_Ljava_lang_CharSequence_Handler:AndroidX.Core.Internal.View.ISupportMenuItemInvoker, Xamarin.AndroidX.Core")]
		ISupportMenuItem SetTooltipText(ICharSequence tooltipText);
	}
}
