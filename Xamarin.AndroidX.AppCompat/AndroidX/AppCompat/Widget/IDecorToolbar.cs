using System;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.View.Menu;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x02000066 RID: 102
	[Register("androidx/appcompat/widget/DecorToolbar", "", "AndroidX.AppCompat.Widget.IDecorToolbarInvoker")]
	public interface IDecorToolbar : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000693 RID: 1683
		Context Context { [Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000694 RID: 1684
		// (set) Token: 0x06000695 RID: 1685
		View CustomView { [Register("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; [Register("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000696 RID: 1686
		// (set) Token: 0x06000697 RID: 1687
		int DisplayOptions { [Register("getDisplayOptions", "()I", "GetGetDisplayOptionsHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; [Register("setDisplayOptions", "(I)V", "GetSetDisplayOptions_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000698 RID: 1688
		int DropdownItemCount { [Register("getDropdownItemCount", "()I", "GetGetDropdownItemCountHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000699 RID: 1689
		// (set) Token: 0x0600069A RID: 1690
		int DropdownSelectedPosition { [Register("getDropdownSelectedPosition", "()I", "GetGetDropdownSelectedPositionHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; [Register("setDropdownSelectedPosition", "(I)V", "GetSetDropdownSelectedPosition_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600069B RID: 1691
		bool HasEmbeddedTabs { [Register("hasEmbeddedTabs", "()Z", "GetHasEmbeddedTabsHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600069C RID: 1692
		bool HasExpandedActionView { [Register("hasExpandedActionView", "()Z", "GetHasExpandedActionViewHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600069D RID: 1693
		bool HasIcon { [Register("hasIcon", "()Z", "GetHasIconHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600069E RID: 1694
		bool HasLogo { [Register("hasLogo", "()Z", "GetHasLogoHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600069F RID: 1695
		int Height { [Register("getHeight", "()I", "GetGetHeightHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060006A0 RID: 1696
		bool IsOverflowMenuShowPending { [Register("isOverflowMenuShowPending", "()Z", "GetIsOverflowMenuShowPendingHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060006A1 RID: 1697
		bool IsOverflowMenuShowing { [Register("isOverflowMenuShowing", "()Z", "GetIsOverflowMenuShowingHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060006A2 RID: 1698
		bool IsTitleTruncated { [Register("isTitleTruncated", "()Z", "GetIsTitleTruncatedHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060006A3 RID: 1699
		IMenu Menu { [Register("getMenu", "()Landroid/view/Menu;", "GetGetMenuHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060006A4 RID: 1700
		// (set) Token: 0x060006A5 RID: 1701
		int NavigationMode { [Register("getNavigationMode", "()I", "GetGetNavigationModeHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; [Register("setNavigationMode", "(I)V", "GetSetNavigationMode_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060006A6 RID: 1702
		// (set) Token: 0x060006A7 RID: 1703
		ICharSequence SubtitleFormatted { [Register("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; [Register("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060006A8 RID: 1704
		// (set) Token: 0x060006A9 RID: 1705
		ICharSequence TitleFormatted { [Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; [Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060006AA RID: 1706
		ViewGroup ViewGroup { [Register("getViewGroup", "()Landroid/view/ViewGroup;", "GetGetViewGroupHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060006AB RID: 1707
		// (set) Token: 0x060006AC RID: 1708
		int Visibility { [Register("getVisibility", "()I", "GetGetVisibilityHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] get; [Register("setVisibility", "(I)V", "GetSetVisibility_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")] set; }

		// Token: 0x060006AD RID: 1709
		[Register("animateToVisibility", "(I)V", "GetAnimateToVisibility_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void AnimateToVisibility(int p0);

		// Token: 0x060006AE RID: 1710
		[Register("canShowOverflowMenu", "()Z", "GetCanShowOverflowMenuHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		bool CanShowOverflowMenu();

		// Token: 0x060006AF RID: 1711
		[Register("collapseActionView", "()V", "GetCollapseActionViewHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void CollapseActionView();

		// Token: 0x060006B0 RID: 1712
		[Register("dismissPopupMenus", "()V", "GetDismissPopupMenusHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void DismissPopupMenus();

		// Token: 0x060006B1 RID: 1713
		[Register("hideOverflowMenu", "()Z", "GetHideOverflowMenuHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		bool HideOverflowMenu();

		// Token: 0x060006B2 RID: 1714
		[Register("initIndeterminateProgress", "()V", "GetInitIndeterminateProgressHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void InitIndeterminateProgress();

		// Token: 0x060006B3 RID: 1715
		[Register("initProgress", "()V", "GetInitProgressHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void InitProgress();

		// Token: 0x060006B4 RID: 1716
		[Register("restoreHierarchyState", "(Landroid/util/SparseArray;)V", "GetRestoreHierarchyState_Landroid_util_SparseArray_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void RestoreHierarchyState(SparseArray p0);

		// Token: 0x060006B5 RID: 1717
		[Register("saveHierarchyState", "(Landroid/util/SparseArray;)V", "GetSaveHierarchyState_Landroid_util_SparseArray_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SaveHierarchyState(SparseArray p0);

		// Token: 0x060006B6 RID: 1718
		[Register("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetBackgroundDrawable(Drawable p0);

		// Token: 0x060006B7 RID: 1719
		[Register("setCollapsible", "(Z)V", "GetSetCollapsible_ZHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetCollapsible(bool p0);

		// Token: 0x060006B8 RID: 1720
		[Register("setDefaultNavigationContentDescription", "(I)V", "GetSetDefaultNavigationContentDescription_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetDefaultNavigationContentDescription(int p0);

		// Token: 0x060006B9 RID: 1721
		[Register("setDefaultNavigationIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetDefaultNavigationIcon(Drawable p0);

		// Token: 0x060006BA RID: 1722
		[Register("setDropdownParams", "(Landroid/widget/SpinnerAdapter;Landroid/widget/AdapterView$OnItemSelectedListener;)V", "GetSetDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetDropdownParams(ISpinnerAdapter p0, AdapterView.IOnItemSelectedListener p1);

		// Token: 0x060006BB RID: 1723
		[Register("setEmbeddedTabView", "(Landroidx/appcompat/widget/ScrollingTabContainerView;)V", "GetSetEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetEmbeddedTabView(ScrollingTabContainerView p0);

		// Token: 0x060006BC RID: 1724
		[Register("setHomeButtonEnabled", "(Z)V", "GetSetHomeButtonEnabled_ZHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetHomeButtonEnabled(bool p0);

		// Token: 0x060006BD RID: 1725
		[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetIcon(Drawable p0);

		// Token: 0x060006BE RID: 1726
		[Register("setIcon", "(I)V", "GetSetIcon_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetIcon(int p0);

		// Token: 0x060006BF RID: 1727
		[Register("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetLogo(Drawable p0);

		// Token: 0x060006C0 RID: 1728
		[Register("setLogo", "(I)V", "GetSetLogo_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetLogo(int p0);

		// Token: 0x060006C1 RID: 1729
		[Register("setMenu", "(Landroid/view/Menu;Landroidx/appcompat/view/menu/MenuPresenter$Callback;)V", "GetSetMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetMenu(IMenu p0, IMenuPresenterCallback p1);

		// Token: 0x060006C2 RID: 1730
		[Register("setMenuCallbacks", "(Landroidx/appcompat/view/menu/MenuPresenter$Callback;Landroidx/appcompat/view/menu/MenuBuilder$Callback;)V", "GetSetMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetMenuCallbacks(IMenuPresenterCallback p0, MenuBuilder.ICallback p1);

		// Token: 0x060006C3 RID: 1731
		[Register("setMenuPrepared", "()V", "GetSetMenuPreparedHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetMenuPrepared();

		// Token: 0x060006C4 RID: 1732
		[Register("setNavigationContentDescription", "(I)V", "GetSetNavigationContentDescription_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetNavigationContentDescription(int p0);

		// Token: 0x060006C5 RID: 1733
		[Register("setNavigationContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetNavigationContentDescription_Ljava_lang_CharSequence_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetNavigationContentDescription(ICharSequence p0);

		// Token: 0x060006C6 RID: 1734
		[Register("setNavigationIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetNavigationIcon_Landroid_graphics_drawable_Drawable_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetNavigationIcon(Drawable p0);

		// Token: 0x060006C7 RID: 1735
		[Register("setNavigationIcon", "(I)V", "GetSetNavigationIcon_IHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetNavigationIcon(int p0);

		// Token: 0x060006C8 RID: 1736
		[Register("setWindowCallback", "(Landroid/view/Window$Callback;)V", "GetSetWindowCallback_Landroid_view_Window_Callback_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetWindowCallback(Window.ICallback p0);

		// Token: 0x060006C9 RID: 1737
		[Register("setWindowTitle", "(Ljava/lang/CharSequence;)V", "GetSetWindowTitle_Ljava_lang_CharSequence_Handler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		void SetWindowTitle(ICharSequence p0);

		// Token: 0x060006CA RID: 1738
		[Register("setupAnimatorToVisibility", "(IJ)Landroidx/core/view/ViewPropertyAnimatorCompat;", "GetSetupAnimatorToVisibility_IJHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		ViewPropertyAnimatorCompat SetupAnimatorToVisibility(int p0, long p1);

		// Token: 0x060006CB RID: 1739
		[Register("showOverflowMenu", "()Z", "GetShowOverflowMenuHandler:AndroidX.AppCompat.Widget.IDecorToolbarInvoker, Xamarin.AndroidX.AppCompat")]
		bool ShowOverflowMenu();
	}
}
