using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x02000095 RID: 149
	[Register("androidx/appcompat/view/menu/MenuView", "", "AndroidX.AppCompat.View.Menu.IMenuViewInvoker")]
	public interface IMenuView : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000B27 RID: 2855
		int WindowAnimations { [Register("getWindowAnimations", "()I", "GetGetWindowAnimationsHandler:AndroidX.AppCompat.View.Menu.IMenuViewInvoker, Xamarin.AndroidX.AppCompat")] get; }

		// Token: 0x06000B28 RID: 2856
		[Register("initialize", "(Landroidx/appcompat/view/menu/MenuBuilder;)V", "GetInitialize_Landroidx_appcompat_view_menu_MenuBuilder_Handler:AndroidX.AppCompat.View.Menu.IMenuViewInvoker, Xamarin.AndroidX.AppCompat")]
		void Initialize(MenuBuilder p0);
	}
}
