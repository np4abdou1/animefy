using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x02000091 RID: 145
	[Register("androidx/appcompat/view/menu/MenuPresenter$Callback", "", "AndroidX.AppCompat.View.Menu.IMenuPresenterCallbackInvoker")]
	public interface IMenuPresenterCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000ADD RID: 2781
		[Register("onCloseMenu", "(Landroidx/appcompat/view/menu/MenuBuilder;Z)V", "GetOnCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_ZHandler:AndroidX.AppCompat.View.Menu.IMenuPresenterCallbackInvoker, Xamarin.AndroidX.AppCompat")]
		void OnCloseMenu(MenuBuilder p0, bool p1);

		// Token: 0x06000ADE RID: 2782
		[Register("onOpenSubMenu", "(Landroidx/appcompat/view/menu/MenuBuilder;)Z", "GetOnOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_Handler:AndroidX.AppCompat.View.Menu.IMenuPresenterCallbackInvoker, Xamarin.AndroidX.AppCompat")]
		bool OnOpenSubMenu(MenuBuilder p0);
	}
}
