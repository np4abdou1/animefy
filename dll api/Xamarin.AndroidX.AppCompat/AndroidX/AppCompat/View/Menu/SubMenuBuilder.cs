using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x02000098 RID: 152
	[Register("androidx/appcompat/view/menu/SubMenuBuilder", DoNotGenerateAcw = true)]
	public class SubMenuBuilder : MenuBuilder, ISubMenu, IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0001E814 File Offset: 0x0001CA14
		internal new static IntPtr class_ref
		{
			get
			{
				return SubMenuBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0001E838 File Offset: 0x0001CA38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SubMenuBuilder._members;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0001E840 File Offset: 0x0001CA40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SubMenuBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0001E864 File Offset: 0x0001CA64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SubMenuBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0001E870 File Offset: 0x0001CA70
		protected SubMenuBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0001E87C File Offset: 0x0001CA7C
		[Register(".ctor", "(Landroid/content/Context;Landroidx/appcompat/view/menu/MenuBuilder;Landroidx/appcompat/view/menu/MenuItemImpl;)V", "")]
		public unsafe SubMenuBuilder(Context context, MenuBuilder parentMenu, MenuItemImpl item) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((parentMenu == null) ? IntPtr.Zero : parentMenu.Handle);
				ptr[2] = new JniArgumentValue((item == null) ? IntPtr.Zero : item.Handle);
				base.SetHandle(SubMenuBuilder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroidx/appcompat/view/menu/MenuBuilder;Landroidx/appcompat/view/menu/MenuItemImpl;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SubMenuBuilder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroidx/appcompat/view/menu/MenuBuilder;Landroidx/appcompat/view/menu/MenuItemImpl;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(parentMenu);
				GC.KeepAlive(item);
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0001E97C File Offset: 0x0001CB7C
		private static Delegate GetGetActionViewStatesKeyHandler()
		{
			if (SubMenuBuilder.cb_getActionViewStatesKey == null)
			{
				SubMenuBuilder.cb_getActionViewStatesKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SubMenuBuilder.n_GetActionViewStatesKey));
			}
			return SubMenuBuilder.cb_getActionViewStatesKey;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0001E9A0 File Offset: 0x0001CBA0
		private static IntPtr n_GetActionViewStatesKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionViewStatesKey);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
		protected override string ActionViewStatesKey
		{
			[Register("getActionViewStatesKey", "()Ljava/lang/String;", "GetGetActionViewStatesKeyHandler")]
			get
			{
				return JNIEnv.GetString(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getActionViewStatesKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0001E9E6 File Offset: 0x0001CBE6
		private static Delegate GetIsQwertyModeHandler()
		{
			if (SubMenuBuilder.cb_isQwertyMode == null)
			{
				SubMenuBuilder.cb_isQwertyMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SubMenuBuilder.n_IsQwertyMode));
			}
			return SubMenuBuilder.cb_isQwertyMode;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0001EA0A File Offset: 0x0001CC0A
		private static bool n_IsQwertyMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsQwertyMode;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0001EA19 File Offset: 0x0001CC19
		public virtual bool IsQwertyMode
		{
			[Register("isQwertyMode", "()Z", "GetIsQwertyModeHandler")]
			get
			{
				return SubMenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("isQwertyMode.()Z", this, null);
			}
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0001EA32 File Offset: 0x0001CC32
		private static Delegate GetGetItemHandler()
		{
			if (SubMenuBuilder.cb_getItem == null)
			{
				SubMenuBuilder.cb_getItem = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SubMenuBuilder.n_GetItem));
			}
			return SubMenuBuilder.cb_getItem;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0001EA56 File Offset: 0x0001CC56
		private static IntPtr n_GetItem(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Item);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0001EA6C File Offset: 0x0001CC6C
		public virtual IMenuItem Item
		{
			[Register("getItem", "()Landroid/view/MenuItem;", "GetGetItemHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMenuItem>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getItem.()Landroid/view/MenuItem;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0001EA9E File Offset: 0x0001CC9E
		private static Delegate GetGetParentMenuHandler()
		{
			if (SubMenuBuilder.cb_getParentMenu == null)
			{
				SubMenuBuilder.cb_getParentMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SubMenuBuilder.n_GetParentMenu));
			}
			return SubMenuBuilder.cb_getParentMenu;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0001EAC2 File Offset: 0x0001CCC2
		private static IntPtr n_GetParentMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ParentMenu);
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0001EAD8 File Offset: 0x0001CCD8
		public virtual IMenu ParentMenu
		{
			[Register("getParentMenu", "()Landroid/view/Menu;", "GetGetParentMenuHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMenu>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getParentMenu.()Landroid/view/Menu;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0001EB0A File Offset: 0x0001CD0A
		private static Delegate GetSetHeaderIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (SubMenuBuilder.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				SubMenuBuilder.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SubMenuBuilder.n_SetHeaderIcon_Landroid_graphics_drawable_Drawable_));
			}
			return SubMenuBuilder.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0001EB30 File Offset: 0x0001CD30
		private static IntPtr n_SetHeaderIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			SubMenuBuilder @object = Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderIcon(object2));
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0001EB58 File Offset: 0x0001CD58
		[Register("setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", "GetSetHeaderIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual ISubMenu SetHeaderIcon(Drawable icon)
		{
			ISubMenu @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				@object = Java.Lang.Object.GetObject<ISubMenu>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderIcon.(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(icon);
			}
			return @object;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0001EBCC File Offset: 0x0001CDCC
		private static Delegate GetSetHeaderIcon_IHandler()
		{
			if (SubMenuBuilder.cb_setHeaderIcon_I == null)
			{
				SubMenuBuilder.cb_setHeaderIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(SubMenuBuilder.n_SetHeaderIcon_I));
			}
			return SubMenuBuilder.cb_setHeaderIcon_I;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		private static IntPtr n_SetHeaderIcon_I(IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHeaderIcon(iconRes));
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0001EC08 File Offset: 0x0001CE08
		[Register("setHeaderIcon", "(I)Landroid/view/SubMenu;", "GetSetHeaderIcon_IHandler")]
		public unsafe virtual ISubMenu SetHeaderIcon(int iconRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(iconRes);
			return Java.Lang.Object.GetObject<ISubMenu>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderIcon.(I)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0001EC51 File Offset: 0x0001CE51
		private static Delegate GetSetHeaderTitle_IHandler()
		{
			if (SubMenuBuilder.cb_setHeaderTitle_I == null)
			{
				SubMenuBuilder.cb_setHeaderTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(SubMenuBuilder.n_SetHeaderTitle_I));
			}
			return SubMenuBuilder.cb_setHeaderTitle_I;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0001EC75 File Offset: 0x0001CE75
		private static IntPtr n_SetHeaderTitle_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHeaderTitle(titleRes));
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0001EC8C File Offset: 0x0001CE8C
		[Register("setHeaderTitle", "(I)Landroid/view/SubMenu;", "GetSetHeaderTitle_IHandler")]
		public unsafe virtual ISubMenu SetHeaderTitle(int titleRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(titleRes);
			return Java.Lang.Object.GetObject<ISubMenu>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderTitle.(I)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0001ECD5 File Offset: 0x0001CED5
		private static Delegate GetSetHeaderTitle_Ljava_lang_CharSequence_Handler()
		{
			if (SubMenuBuilder.cb_setHeaderTitle_Ljava_lang_CharSequence_ == null)
			{
				SubMenuBuilder.cb_setHeaderTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SubMenuBuilder.n_SetHeaderTitle_Ljava_lang_CharSequence_));
			}
			return SubMenuBuilder.cb_setHeaderTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0001ECFC File Offset: 0x0001CEFC
		private static IntPtr n_SetHeaderTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			SubMenuBuilder @object = Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderTitle(object2));
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0001ED24 File Offset: 0x0001CF24
		[Register("setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", "GetSetHeaderTitle_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual ISubMenu SetHeaderTitle(ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			ISubMenu @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISubMenu>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderTitle.(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0001ED98 File Offset: 0x0001CF98
		public ISubMenu SetHeaderTitle(string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			ISubMenu result = this.SetHeaderTitle(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0001EDC2 File Offset: 0x0001CFC2
		private static Delegate GetSetHeaderView_Landroid_view_View_Handler()
		{
			if (SubMenuBuilder.cb_setHeaderView_Landroid_view_View_ == null)
			{
				SubMenuBuilder.cb_setHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SubMenuBuilder.n_SetHeaderView_Landroid_view_View_));
			}
			return SubMenuBuilder.cb_setHeaderView_Landroid_view_View_;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0001EDE8 File Offset: 0x0001CFE8
		private static IntPtr n_SetHeaderView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			SubMenuBuilder @object = Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderView(object2));
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0001EE10 File Offset: 0x0001D010
		[Register("setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;", "GetSetHeaderView_Landroid_view_View_Handler")]
		public unsafe virtual ISubMenu SetHeaderView(View view)
		{
			ISubMenu @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<ISubMenu>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderView.(Landroid/view/View;)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0001EE84 File Offset: 0x0001D084
		private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (SubMenuBuilder.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				SubMenuBuilder.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SubMenuBuilder.n_SetIcon_Landroid_graphics_drawable_Drawable_));
			}
			return SubMenuBuilder.cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
		private static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			SubMenuBuilder @object = Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0001EED0 File Offset: 0x0001D0D0
		[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual ISubMenu SetIcon(Drawable icon)
		{
			ISubMenu @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				@object = Java.Lang.Object.GetObject<ISubMenu>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setIcon.(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(icon);
			}
			return @object;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0001EF44 File Offset: 0x0001D144
		private static Delegate GetSetIcon_IHandler()
		{
			if (SubMenuBuilder.cb_setIcon_I == null)
			{
				SubMenuBuilder.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(SubMenuBuilder.n_SetIcon_I));
			}
			return SubMenuBuilder.cb_setIcon_I;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0001EF68 File Offset: 0x0001D168
		private static IntPtr n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SubMenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(iconRes));
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0001EF80 File Offset: 0x0001D180
		[Register("setIcon", "(I)Landroid/view/SubMenu;", "GetSetIcon_IHandler")]
		public unsafe virtual ISubMenu SetIcon(int iconRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(iconRes);
			return Java.Lang.Object.GetObject<ISubMenu>(SubMenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setIcon.(I)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000360 RID: 864
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/menu/SubMenuBuilder", typeof(SubMenuBuilder));

		// Token: 0x04000361 RID: 865
		private static Delegate cb_getActionViewStatesKey;

		// Token: 0x04000362 RID: 866
		private static Delegate cb_isQwertyMode;

		// Token: 0x04000363 RID: 867
		private static Delegate cb_getItem;

		// Token: 0x04000364 RID: 868
		private static Delegate cb_getParentMenu;

		// Token: 0x04000365 RID: 869
		private static Delegate cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000366 RID: 870
		private static Delegate cb_setHeaderIcon_I;

		// Token: 0x04000367 RID: 871
		private static Delegate cb_setHeaderTitle_I;

		// Token: 0x04000368 RID: 872
		private static Delegate cb_setHeaderTitle_Ljava_lang_CharSequence_;

		// Token: 0x04000369 RID: 873
		private static Delegate cb_setHeaderView_Landroid_view_View_;

		// Token: 0x0400036A RID: 874
		private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400036B RID: 875
		private static Delegate cb_setIcon_I;
	}
}
