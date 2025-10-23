using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x02000094 RID: 148
	[Register("androidx/appcompat/view/menu/MenuPresenter", DoNotGenerateAcw = true)]
	internal class IMenuPresenterInvoker : Java.Lang.Object, IMenuPresenter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0001C960 File Offset: 0x0001AB60
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuPresenterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0001C984 File Offset: 0x0001AB84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuPresenterInvoker._members;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0001C98B File Offset: 0x0001AB8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0001C993 File Offset: 0x0001AB93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuPresenterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0001C99F File Offset: 0x0001AB9F
		public static IMenuPresenter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMenuPresenter>(handle, transfer);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuPresenterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.view.menu.MenuPresenter'.");
			}
			return handle;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001C9D3 File Offset: 0x0001ABD3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0001CA04 File Offset: 0x0001AC04
		public IMenuPresenterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuPresenterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0001CA3C File Offset: 0x0001AC3C
		private static Delegate GetGetIdHandler()
		{
			if (IMenuPresenterInvoker.cb_getId == null)
			{
				IMenuPresenterInvoker.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMenuPresenterInvoker.n_GetId));
			}
			return IMenuPresenterInvoker.cb_getId;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0001CA60 File Offset: 0x0001AC60
		private static int n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0001CA6F File Offset: 0x0001AC6F
		public int Id
		{
			get
			{
				if (this.id_getId == IntPtr.Zero)
				{
					this.id_getId = JNIEnv.GetMethodID(this.class_ref, "getId", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getId);
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0001CAAF File Offset: 0x0001ACAF
		private static Delegate GetCollapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_Handler()
		{
			if (IMenuPresenterInvoker.cb_collapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_ == null)
			{
				IMenuPresenterInvoker.cb_collapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IMenuPresenterInvoker.n_CollapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_));
			}
			return IMenuPresenterInvoker.cb_collapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
		private static bool n_CollapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMenuPresenter @object = Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuBuilder object2 = Java.Lang.Object.GetObject<MenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
			MenuItemImpl object3 = Java.Lang.Object.GetObject<MenuItemImpl>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.CollapseItemActionView(object2, object3);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0001CB00 File Offset: 0x0001AD00
		public unsafe bool CollapseItemActionView(MenuBuilder p0, MenuItemImpl p1)
		{
			if (this.id_collapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_ == IntPtr.Zero)
			{
				this.id_collapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_ = JNIEnv.GetMethodID(this.class_ref, "collapseItemActionView", "(Landroidx/appcompat/view/menu/MenuBuilder;Landroidx/appcompat/view/menu/MenuItemImpl;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_collapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_, ptr);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0001CB95 File Offset: 0x0001AD95
		private static Delegate GetExpandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_Handler()
		{
			if (IMenuPresenterInvoker.cb_expandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_ == null)
			{
				IMenuPresenterInvoker.cb_expandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IMenuPresenterInvoker.n_ExpandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_));
			}
			return IMenuPresenterInvoker.cb_expandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001CBBC File Offset: 0x0001ADBC
		private static bool n_ExpandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMenuPresenter @object = Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuBuilder object2 = Java.Lang.Object.GetObject<MenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
			MenuItemImpl object3 = Java.Lang.Object.GetObject<MenuItemImpl>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.ExpandItemActionView(object2, object3);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0001CBE8 File Offset: 0x0001ADE8
		public unsafe bool ExpandItemActionView(MenuBuilder p0, MenuItemImpl p1)
		{
			if (this.id_expandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_ == IntPtr.Zero)
			{
				this.id_expandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_ = JNIEnv.GetMethodID(this.class_ref, "expandItemActionView", "(Landroidx/appcompat/view/menu/MenuBuilder;Landroidx/appcompat/view/menu/MenuItemImpl;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_expandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_, ptr);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0001CC7D File Offset: 0x0001AE7D
		private static Delegate GetFlagActionItemsHandler()
		{
			if (IMenuPresenterInvoker.cb_flagActionItems == null)
			{
				IMenuPresenterInvoker.cb_flagActionItems = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuPresenterInvoker.n_FlagActionItems));
			}
			return IMenuPresenterInvoker.cb_flagActionItems;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0001CCA1 File Offset: 0x0001AEA1
		private static bool n_FlagActionItems(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FlagActionItems();
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		public bool FlagActionItems()
		{
			if (this.id_flagActionItems == IntPtr.Zero)
			{
				this.id_flagActionItems = JNIEnv.GetMethodID(this.class_ref, "flagActionItems", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_flagActionItems);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001CCF0 File Offset: 0x0001AEF0
		private static Delegate GetGetMenuView_Landroid_view_ViewGroup_Handler()
		{
			if (IMenuPresenterInvoker.cb_getMenuView_Landroid_view_ViewGroup_ == null)
			{
				IMenuPresenterInvoker.cb_getMenuView_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuPresenterInvoker.n_GetMenuView_Landroid_view_ViewGroup_));
			}
			return IMenuPresenterInvoker.cb_getMenuView_Landroid_view_ViewGroup_;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0001CD14 File Offset: 0x0001AF14
		private static IntPtr n_GetMenuView_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuPresenter @object = Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetMenuView(object2));
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0001CD3C File Offset: 0x0001AF3C
		public unsafe IMenuView GetMenuView(ViewGroup p0)
		{
			if (this.id_getMenuView_Landroid_view_ViewGroup_ == IntPtr.Zero)
			{
				this.id_getMenuView_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID(this.class_ref, "getMenuView", "(Landroid/view/ViewGroup;)Landroidx/appcompat/view/menu/MenuView;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<IMenuView>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMenuView_Landroid_view_ViewGroup_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0001CDB5 File Offset: 0x0001AFB5
		private static Delegate GetInitForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_Handler()
		{
			if (IMenuPresenterInvoker.cb_initForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_ == null)
			{
				IMenuPresenterInvoker.cb_initForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMenuPresenterInvoker.n_InitForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_));
			}
			return IMenuPresenterInvoker.cb_initForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0001CDDC File Offset: 0x0001AFDC
		private static void n_InitForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMenuPresenter @object = Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			MenuBuilder object3 = Java.Lang.Object.GetObject<MenuBuilder>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.InitForMenu(object2, object3);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0001CE08 File Offset: 0x0001B008
		public unsafe void InitForMenu(Context p0, MenuBuilder p1)
		{
			if (this.id_initForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_ == IntPtr.Zero)
			{
				this.id_initForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_ = JNIEnv.GetMethodID(this.class_ref, "initForMenu", "(Landroid/content/Context;Landroidx/appcompat/view/menu/MenuBuilder;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_initForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_, ptr);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0001CE9D File Offset: 0x0001B09D
		private static Delegate GetOnCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_ZHandler()
		{
			if (IMenuPresenterInvoker.cb_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z == null)
			{
				IMenuPresenterInvoker.cb_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(IMenuPresenterInvoker.n_OnCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z));
			}
			return IMenuPresenterInvoker.cb_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
		private static void n_OnCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			IMenuPresenter @object = Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuBuilder object2 = Java.Lang.Object.GetObject<MenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnCloseMenu(object2, p1);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0001CEE8 File Offset: 0x0001B0E8
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

		// Token: 0x06000B17 RID: 2839 RVA: 0x0001CF6E File Offset: 0x0001B16E
		private static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler()
		{
			if (IMenuPresenterInvoker.cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
			{
				IMenuPresenterInvoker.cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMenuPresenterInvoker.n_OnRestoreInstanceState_Landroid_os_Parcelable_));
			}
			return IMenuPresenterInvoker.cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0001CF94 File Offset: 0x0001B194
		private static void n_OnRestoreInstanceState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuPresenter @object = Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRestoreInstanceState(object2);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		public unsafe void OnRestoreInstanceState(IParcelable p0)
		{
			if (this.id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
			{
				this.id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID(this.class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRestoreInstanceState_Landroid_os_Parcelable_, ptr);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0001D030 File Offset: 0x0001B230
		private static Delegate GetOnSaveInstanceStateHandler()
		{
			if (IMenuPresenterInvoker.cb_onSaveInstanceState == null)
			{
				IMenuPresenterInvoker.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuPresenterInvoker.n_OnSaveInstanceState));
			}
			return IMenuPresenterInvoker.cb_onSaveInstanceState;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0001D054 File Offset: 0x0001B254
		private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0001D068 File Offset: 0x0001B268
		public IParcelable OnSaveInstanceState()
		{
			if (this.id_onSaveInstanceState == IntPtr.Zero)
			{
				this.id_onSaveInstanceState = JNIEnv.GetMethodID(this.class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			}
			return Java.Lang.Object.GetObject<IParcelable>(JNIEnv.CallObjectMethod(base.Handle, this.id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0001D0B9 File Offset: 0x0001B2B9
		private static Delegate GetOnSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_Handler()
		{
			if (IMenuPresenterInvoker.cb_onSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_ == null)
			{
				IMenuPresenterInvoker.cb_onSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMenuPresenterInvoker.n_OnSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_));
			}
			return IMenuPresenterInvoker.cb_onSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
		private static bool n_OnSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuPresenter @object = Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SubMenuBuilder object2 = Java.Lang.Object.GetObject<SubMenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.OnSubMenuSelected(object2);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0001D104 File Offset: 0x0001B304
		public unsafe bool OnSubMenuSelected(SubMenuBuilder p0)
		{
			if (this.id_onSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_ == IntPtr.Zero)
			{
				this.id_onSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_ = JNIEnv.GetMethodID(this.class_ref, "onSubMenuSelected", "(Landroidx/appcompat/view/menu/SubMenuBuilder;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_, ptr);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0001D177 File Offset: 0x0001B377
		private static Delegate GetSetCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Handler()
		{
			if (IMenuPresenterInvoker.cb_setCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_ == null)
			{
				IMenuPresenterInvoker.cb_setCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMenuPresenterInvoker.n_SetCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_));
			}
			return IMenuPresenterInvoker.cb_setCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0001D19C File Offset: 0x0001B39C
		private static void n_SetCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuPresenter @object = Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuPresenterCallback object2 = Java.Lang.Object.GetObject<IMenuPresenterCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetCallback(object2);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		public unsafe void SetCallback(IMenuPresenterCallback p0)
		{
			if (this.id_setCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_ == IntPtr.Zero)
			{
				this.id_setCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_ = JNIEnv.GetMethodID(this.class_ref, "setCallback", "(Landroidx/appcompat/view/menu/MenuPresenter$Callback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_, ptr);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001D238 File Offset: 0x0001B438
		private static Delegate GetUpdateMenuView_ZHandler()
		{
			if (IMenuPresenterInvoker.cb_updateMenuView_Z == null)
			{
				IMenuPresenterInvoker.cb_updateMenuView_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IMenuPresenterInvoker.n_UpdateMenuView_Z));
			}
			return IMenuPresenterInvoker.cb_updateMenuView_Z;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001D25C File Offset: 0x0001B45C
		private static void n_UpdateMenuView_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IMenuPresenter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UpdateMenuView(p0);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0001D26C File Offset: 0x0001B46C
		public unsafe void UpdateMenuView(bool p0)
		{
			if (this.id_updateMenuView_Z == IntPtr.Zero)
			{
				this.id_updateMenuView_Z = JNIEnv.GetMethodID(this.class_ref, "updateMenuView", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_updateMenuView_Z, ptr);
		}

		// Token: 0x0400033F RID: 831
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/menu/MenuPresenter", typeof(IMenuPresenterInvoker));

		// Token: 0x04000340 RID: 832
		private IntPtr class_ref;

		// Token: 0x04000341 RID: 833
		private static Delegate cb_getId;

		// Token: 0x04000342 RID: 834
		private IntPtr id_getId;

		// Token: 0x04000343 RID: 835
		private static Delegate cb_collapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_;

		// Token: 0x04000344 RID: 836
		private IntPtr id_collapseItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_;

		// Token: 0x04000345 RID: 837
		private static Delegate cb_expandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_;

		// Token: 0x04000346 RID: 838
		private IntPtr id_expandItemActionView_Landroidx_appcompat_view_menu_MenuBuilder_Landroidx_appcompat_view_menu_MenuItemImpl_;

		// Token: 0x04000347 RID: 839
		private static Delegate cb_flagActionItems;

		// Token: 0x04000348 RID: 840
		private IntPtr id_flagActionItems;

		// Token: 0x04000349 RID: 841
		private static Delegate cb_getMenuView_Landroid_view_ViewGroup_;

		// Token: 0x0400034A RID: 842
		private IntPtr id_getMenuView_Landroid_view_ViewGroup_;

		// Token: 0x0400034B RID: 843
		private static Delegate cb_initForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_;

		// Token: 0x0400034C RID: 844
		private IntPtr id_initForMenu_Landroid_content_Context_Landroidx_appcompat_view_menu_MenuBuilder_;

		// Token: 0x0400034D RID: 845
		private static Delegate cb_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z;

		// Token: 0x0400034E RID: 846
		private IntPtr id_onCloseMenu_Landroidx_appcompat_view_menu_MenuBuilder_Z;

		// Token: 0x0400034F RID: 847
		private static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;

		// Token: 0x04000350 RID: 848
		private IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;

		// Token: 0x04000351 RID: 849
		private static Delegate cb_onSaveInstanceState;

		// Token: 0x04000352 RID: 850
		private IntPtr id_onSaveInstanceState;

		// Token: 0x04000353 RID: 851
		private static Delegate cb_onSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_;

		// Token: 0x04000354 RID: 852
		private IntPtr id_onSubMenuSelected_Landroidx_appcompat_view_menu_SubMenuBuilder_;

		// Token: 0x04000355 RID: 853
		private static Delegate cb_setCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_;

		// Token: 0x04000356 RID: 854
		private IntPtr id_setCallback_Landroidx_appcompat_view_menu_MenuPresenter_Callback_;

		// Token: 0x04000357 RID: 855
		private static Delegate cb_updateMenuView_Z;

		// Token: 0x04000358 RID: 856
		private IntPtr id_updateMenuView_Z;
	}
}
