using System;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x02000093 RID: 147
	[Register("androidx/appcompat/view/menu/MenuPresenter", "", "AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker")]
	public interface IMenuPresenter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000AEE RID: 2798
		int Id { [Register("getId", "()I", "GetGetIdHandler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x06000AEF RID: 2799
		[Register("collapseItemActionView", "(Landroidx/appcompat/view/menu/MenuBuilder;Landroidx/appcompat/view/menu/MenuItemImpl;)Z", "GetCollapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_Handler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		bool CollapseItemActionView(MenuBuilder p0, MenuItemImpl p1);

		// Token: 0x06000AF0 RID: 2800
		[Register("expandItemActionView", "(Landroidx/appcompat/view/menu/MenuBuilder;Landroidx/appcompat/view/menu/MenuItemImpl;)Z", "GetExpandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_Handler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		bool ExpandItemActionView(MenuBuilder p0, MenuItemImpl p1);

		// Token: 0x06000AF1 RID: 2801
		[Register("flagActionItems", "()Z", "GetFlagActionItemsHandler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		bool FlagActionItems();

		// Token: 0x06000AF2 RID: 2802
		[Register("getMenuView", "(Landroid/view/ViewGroup;)Landroidx/appcompat/view/menu/MenuView;", "GetGetMenuView_Landroid_view_ViewGroup_Handler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		IMenuView GetMenuView(ViewGroup p0);

		// Token: 0x06000AF3 RID: 2803
		[Register("initForMenu", "(Landroid/content/Context;Landroidx/appcompat/view/menu/MenuBuilder;)V", "GetInitForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_Handler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		void InitForMenu(Context p0, MenuBuilder p1);

		// Token: 0x06000AF4 RID: 2804
		[Register("onCloseMenu", "(Landroidx/appcompat/view/menu/MenuBuilder;Z)V", "GetOnCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_ZHandler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		void OnCloseMenu(MenuBuilder p0, bool p1);

		// Token: 0x06000AF5 RID: 2805
		[Register("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		void OnRestoreInstanceState(IParcelable p0);

		// Token: 0x06000AF6 RID: 2806
		[Register("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		IParcelable OnSaveInstanceState();

		// Token: 0x06000AF7 RID: 2807
		[Register("onSubMenuSelected", "(Landroidx/appcompat/view/menu/SubMenuBuilder;)Z", "GetOnSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_Handler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		bool OnSubMenuSelected(SubMenuBuilder p0);

		// Token: 0x06000AF8 RID: 2808
		[Register("setCallback", "(Landroidx/appcompat/view/menu/MenuPresenter$Callback;)V", "GetSetCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Handler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		void SetCallback(IMenuPresenterCallback p0);

		// Token: 0x06000AF9 RID: 2809
		[Register("updateMenuView", "(Z)V", "GetUpdateMenuView_ZHandler:AndroidX.AppCompat.View.Menu.IMenuPresenterInvoker, Xamarin.AndroidX.AppCompat")]
		void UpdateMenuView(bool p0);
	}
}
