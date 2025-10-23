using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000A4 RID: 164
	[Register("androidx/core/view/MenuProvider", "", "AndroidX.Core.View.IMenuProviderInvoker")]
	public interface IMenuProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060008C1 RID: 2241
		[Register("onCreateMenu", "(Landroid/view/Menu;Landroid/view/MenuInflater;)V", "GetOnCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_Handler:AndroidX.Core.View.IMenuProviderInvoker, Xamarin.AndroidX.Core")]
		void OnCreateMenu(IMenu p0, MenuInflater p1);

		// Token: 0x060008C2 RID: 2242
		[Register("onMenuItemSelected", "(Landroid/view/MenuItem;)Z", "GetOnMenuItemSelected_Landroid_view_MenuItem_Handler:AndroidX.Core.View.IMenuProviderInvoker, Xamarin.AndroidX.Core")]
		bool OnMenuItemSelected(IMenuItem p0);

		// Token: 0x060008C3 RID: 2243 RVA: 0x0001A5B3 File Offset: 0x000187B3
		private static Delegate GetOnMenuClosed_Landroid_view_Menu_Handler()
		{
			if (IMenuProvider.cb_onMenuClosed_Landroid_view_Menu_ == null)
			{
				IMenuProvider.cb_onMenuClosed_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMenuProvider.n_OnMenuClosed_Landroid_view_Menu_));
			}
			return IMenuProvider.cb_onMenuClosed_Landroid_view_Menu_;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0001A5D8 File Offset: 0x000187D8
		private static void n_OnMenuClosed_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
		{
			IMenuProvider @object = Java.Lang.Object.GetObject<IMenuProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.OnMenuClosed(object2);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0001A5FC File Offset: 0x000187FC
		[Register("onMenuClosed", "(Landroid/view/Menu;)V", "GetOnMenuClosed_Landroid_view_Menu_Handler:AndroidX.Core.View.IMenuProvider, Xamarin.AndroidX.Core")]
		unsafe void OnMenuClosed(IMenu menu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				IMenuProvider._members.InstanceMethods.InvokeVirtualVoidMethod("onMenuClosed.(Landroid/view/Menu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001A664 File Offset: 0x00018864
		private static Delegate GetOnPrepareMenu_Landroid_view_Menu_Handler()
		{
			if (IMenuProvider.cb_onPrepareMenu_Landroid_view_Menu_ == null)
			{
				IMenuProvider.cb_onPrepareMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMenuProvider.n_OnPrepareMenu_Landroid_view_Menu_));
			}
			return IMenuProvider.cb_onPrepareMenu_Landroid_view_Menu_;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0001A688 File Offset: 0x00018888
		private static void n_OnPrepareMenu_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
		{
			IMenuProvider @object = Java.Lang.Object.GetObject<IMenuProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.OnPrepareMenu(object2);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0001A6AC File Offset: 0x000188AC
		[Register("onPrepareMenu", "(Landroid/view/Menu;)V", "GetOnPrepareMenu_Landroid_view_Menu_Handler:AndroidX.Core.View.IMenuProvider, Xamarin.AndroidX.Core")]
		unsafe void OnPrepareMenu(IMenu menu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				IMenuProvider._members.InstanceMethods.InvokeVirtualVoidMethod("onPrepareMenu.(Landroid/view/Menu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x04000258 RID: 600
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/MenuProvider", typeof(IMenuProvider), true);

		// Token: 0x04000259 RID: 601
		private static Delegate cb_onMenuClosed_Landroid_view_Menu_;

		// Token: 0x0400025A RID: 602
		private static Delegate cb_onPrepareMenu_Landroid_view_Menu_;
	}
}
