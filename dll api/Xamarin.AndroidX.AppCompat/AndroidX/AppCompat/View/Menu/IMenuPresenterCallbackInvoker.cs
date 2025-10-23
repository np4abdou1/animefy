using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x02000092 RID: 146
	[Register("androidx/appcompat/view/menu/MenuPresenter$Callback", DoNotGenerateAcw = true)]
	internal class IMenuPresenterCallbackInvoker : Java.Lang.Object, IMenuPresenterCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0001C6DC File Offset: 0x0001A8DC
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuPresenterCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0001C700 File Offset: 0x0001A900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuPresenterCallbackInvoker._members;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0001C707 File Offset: 0x0001A907
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0001C70F File Offset: 0x0001A90F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuPresenterCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0001C71B File Offset: 0x0001A91B
		public static IMenuPresenterCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMenuPresenterCallback>(handle, transfer);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001C724 File Offset: 0x0001A924
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuPresenterCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.view.menu.MenuPresenter.Callback'.");
			}
			return handle;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0001C74F File Offset: 0x0001A94F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0001C780 File Offset: 0x0001A980
		public IMenuPresenterCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuPresenterCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		private static Delegate GetOnCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_ZHandler()
		{
			if (IMenuPresenterCallbackInvoker.cb_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z == null)
			{
				IMenuPresenterCallbackInvoker.cb_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(IMenuPresenterCallbackInvoker.n_OnCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z));
			}
			return IMenuPresenterCallbackInvoker.cb_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0001C7DC File Offset: 0x0001A9DC
		private static void n_OnCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			IMenuPresenterCallback @object = Java.Lang.Object.GetObject<IMenuPresenterCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuBuilder object2 = Java.Lang.Object.GetObject<MenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnCloseMenu(object2, p1);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0001C800 File Offset: 0x0001AA00
		public unsafe void OnCloseMenu(MenuBuilder p0, bool p1)
		{
			if (this.id_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z == IntPtr.Zero)
			{
				this.id_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z = JNIEnv.GetMethodID(this.class_ref, "onCloseMenu", "(Landroidx/appcompat/view/menu/MenuBuilder;Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z, ptr);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001C886 File Offset: 0x0001AA86
		private static Delegate GetOnOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_Handler()
		{
			if (IMenuPresenterCallbackInvoker.cb_onOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_ == null)
			{
				IMenuPresenterCallbackInvoker.cb_onOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMenuPresenterCallbackInvoker.n_OnOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_));
			}
			return IMenuPresenterCallbackInvoker.cb_onOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0001C8AC File Offset: 0x0001AAAC
		private static bool n_OnOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuPresenterCallback @object = Java.Lang.Object.GetObject<IMenuPresenterCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuBuilder object2 = Java.Lang.Object.GetObject<MenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.OnOpenSubMenu(object2);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
		public unsafe bool OnOpenSubMenu(MenuBuilder p0)
		{
			if (this.id_onOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_ == IntPtr.Zero)
			{
				this.id_onOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_ = JNIEnv.GetMethodID(this.class_ref, "onOpenSubMenu", "(Landroidx/appcompat/view/menu/MenuBuilder;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_, ptr);
		}

		// Token: 0x04000339 RID: 825
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/menu/MenuPresenter$Callback", typeof(IMenuPresenterCallbackInvoker));

		// Token: 0x0400033A RID: 826
		private IntPtr class_ref;

		// Token: 0x0400033B RID: 827
		private static Delegate cb_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z;

		// Token: 0x0400033C RID: 828
		private IntPtr id_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z;

		// Token: 0x0400033D RID: 829
		private static Delegate cb_onOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_;

		// Token: 0x0400033E RID: 830
		private IntPtr id_onOpenSubMenu_Landroidx_appcompat_view_menu_MenuBuilder_;
	}
}
