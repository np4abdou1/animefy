using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000119 RID: 281
	[Register("android/view/ContextMenu", DoNotGenerateAcw = true)]
	internal class IContextMenuInvoker : Java.Lang.Object, IContextMenu, IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00010498 File Offset: 0x0000E698
		private static IntPtr java_class_ref
		{
			get
			{
				return IContextMenuInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000104BC File Offset: 0x0000E6BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContextMenuInvoker._members;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x000104C3 File Offset: 0x0000E6C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000104CB File Offset: 0x0000E6CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContextMenuInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000104D7 File Offset: 0x0000E6D7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContextMenuInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ContextMenu'.");
			}
			return handle;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00010502 File Offset: 0x0000E702
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00010534 File Offset: 0x0000E734
		public IContextMenuInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContextMenuInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001056C File Offset: 0x0000E76C
		private static Delegate GetClearHeaderHandler()
		{
			if (IContextMenuInvoker.cb_clearHeader == null)
			{
				IContextMenuInvoker.cb_clearHeader = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IContextMenuInvoker.n_ClearHeader));
			}
			return IContextMenuInvoker.cb_clearHeader;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00010590 File Offset: 0x0000E790
		private static void n_ClearHeader(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IContextMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearHeader();
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001059F File Offset: 0x0000E79F
		public void ClearHeader()
		{
			if (this.id_clearHeader == IntPtr.Zero)
			{
				this.id_clearHeader = JNIEnv.GetMethodID(this.class_ref, "clearHeader", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearHeader);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000105DF File Offset: 0x0000E7DF
		private static Delegate GetSetHeaderIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IContextMenuInvoker.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				IContextMenuInvoker.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContextMenuInvoker.n_SetHeaderIcon_Landroid_graphics_drawable_Drawable_));
			}
			return IContextMenuInvoker.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00010604 File Offset: 0x0000E804
		private static IntPtr n_SetHeaderIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			IContextMenu @object = Java.Lang.Object.GetObject<IContextMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderIcon(object2));
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001062C File Offset: 0x0000E82C
		public unsafe IContextMenu SetHeaderIcon(Drawable icon)
		{
			if (this.id_setHeaderIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setHeaderIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((icon == null) ? IntPtr.Zero : icon.Handle);
			return Java.Lang.Object.GetObject<IContextMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderIcon_Landroid_graphics_drawable_Drawable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000106A5 File Offset: 0x0000E8A5
		private static Delegate GetSetHeaderIcon_IHandler()
		{
			if (IContextMenuInvoker.cb_setHeaderIcon_I == null)
			{
				IContextMenuInvoker.cb_setHeaderIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IContextMenuInvoker.n_SetHeaderIcon_I));
			}
			return IContextMenuInvoker.cb_setHeaderIcon_I;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000106C9 File Offset: 0x0000E8C9
		private static IntPtr n_SetHeaderIcon_I(IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContextMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHeaderIcon(iconRes));
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000106E0 File Offset: 0x0000E8E0
		public unsafe IContextMenu SetHeaderIcon(int iconRes)
		{
			if (this.id_setHeaderIcon_I == IntPtr.Zero)
			{
				this.id_setHeaderIcon_I = JNIEnv.GetMethodID(this.class_ref, "setHeaderIcon", "(I)Landroid/view/ContextMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(iconRes);
			return Java.Lang.Object.GetObject<IContextMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderIcon_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0001074A File Offset: 0x0000E94A
		private static Delegate GetSetHeaderTitle_IHandler()
		{
			if (IContextMenuInvoker.cb_setHeaderTitle_I == null)
			{
				IContextMenuInvoker.cb_setHeaderTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IContextMenuInvoker.n_SetHeaderTitle_I));
			}
			return IContextMenuInvoker.cb_setHeaderTitle_I;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001076E File Offset: 0x0000E96E
		private static IntPtr n_SetHeaderTitle_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContextMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHeaderTitle(titleRes));
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00010784 File Offset: 0x0000E984
		public unsafe IContextMenu SetHeaderTitle(int titleRes)
		{
			if (this.id_setHeaderTitle_I == IntPtr.Zero)
			{
				this.id_setHeaderTitle_I = JNIEnv.GetMethodID(this.class_ref, "setHeaderTitle", "(I)Landroid/view/ContextMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(titleRes);
			return Java.Lang.Object.GetObject<IContextMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderTitle_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000107EE File Offset: 0x0000E9EE
		private static Delegate GetSetHeaderTitle_Ljava_lang_CharSequence_Handler()
		{
			if (IContextMenuInvoker.cb_setHeaderTitle_Ljava_lang_CharSequence_ == null)
			{
				IContextMenuInvoker.cb_setHeaderTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContextMenuInvoker.n_SetHeaderTitle_Ljava_lang_CharSequence_));
			}
			return IContextMenuInvoker.cb_setHeaderTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00010814 File Offset: 0x0000EA14
		private static IntPtr n_SetHeaderTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IContextMenu @object = Java.Lang.Object.GetObject<IContextMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderTitle(object2));
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0001083C File Offset: 0x0000EA3C
		public unsafe IContextMenu SetHeaderTitle(ICharSequence title)
		{
			if (this.id_setHeaderTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setHeaderTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IContextMenu @object = Java.Lang.Object.GetObject<IContextMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderTitle_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000108B3 File Offset: 0x0000EAB3
		private static Delegate GetSetHeaderView_Landroid_view_View_Handler()
		{
			if (IContextMenuInvoker.cb_setHeaderView_Landroid_view_View_ == null)
			{
				IContextMenuInvoker.cb_setHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContextMenuInvoker.n_SetHeaderView_Landroid_view_View_));
			}
			return IContextMenuInvoker.cb_setHeaderView_Landroid_view_View_;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000108D8 File Offset: 0x0000EAD8
		private static IntPtr n_SetHeaderView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			IContextMenu @object = Java.Lang.Object.GetObject<IContextMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderView(object2));
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00010900 File Offset: 0x0000EB00
		public unsafe IContextMenu SetHeaderView(View view)
		{
			if (this.id_setHeaderView_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_setHeaderView_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			return Java.Lang.Object.GetObject<IContextMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderView_Landroid_view_View_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00010979 File Offset: 0x0000EB79
		public bool HasVisibleItems
		{
			get
			{
				if (this.id_hasVisibleItems == IntPtr.Zero)
				{
					this.id_hasVisibleItems = JNIEnv.GetMethodID(this.class_ref, "hasVisibleItems", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasVisibleItems);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000109BC File Offset: 0x0000EBBC
		public unsafe IMenuItem Add(int titleRes)
		{
			if (this.id_add_I == IntPtr.Zero)
			{
				this.id_add_I = JNIEnv.GetMethodID(this.class_ref, "add", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(titleRes);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_add_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00010A28 File Offset: 0x0000EC28
		public unsafe IMenuItem Add(int groupId, int itemId, int order, int titleRes)
		{
			if (this.id_add_IIII == IntPtr.Zero)
			{
				this.id_add_IIII = JNIEnv.GetMethodID(this.class_ref, "add", "(IIII)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(groupId);
			ptr[1] = new JValue(itemId);
			ptr[2] = new JValue(order);
			ptr[3] = new JValue(titleRes);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_add_IIII, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		public unsafe IMenuItem Add(int groupId, int itemId, int order, ICharSequence title)
		{
			if (this.id_add_IIILjava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_add_IIILjava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(groupId);
			ptr[1] = new JValue(itemId);
			ptr[2] = new JValue(order);
			ptr[3] = new JValue(intPtr);
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_add_IIILjava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00010B8C File Offset: 0x0000ED8C
		public unsafe IMenuItem Add(ICharSequence title)
		{
			if (this.id_add_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_add_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_add_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00010C04 File Offset: 0x0000EE04
		public unsafe int AddIntentOptions(int groupId, int itemId, int order, ComponentName caller, Intent[] specifics, Intent intent, [GeneratedEnum] MenuAppendFlags flags, IMenuItem[] outSpecificItems)
		{
			if (this.id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_ == IntPtr.Zero)
			{
				this.id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			}
			IntPtr intPtr = JNIEnv.NewArray<Intent>(specifics);
			IntPtr intPtr2 = JNIEnv.NewArray<IMenuItem>(outSpecificItems);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(groupId);
			ptr[1] = new JValue(itemId);
			ptr[2] = new JValue(order);
			ptr[3] = new JValue((caller == null) ? IntPtr.Zero : caller.Handle);
			ptr[4] = new JValue(intPtr);
			ptr[5] = new JValue((intent == null) ? IntPtr.Zero : intent.Handle);
			ptr[6] = new JValue((int)flags);
			ptr[7] = new JValue(intPtr2);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_, ptr);
			if (specifics != null)
			{
				JNIEnv.CopyArray<Intent>(intPtr, specifics);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			if (outSpecificItems != null)
			{
				JNIEnv.CopyArray<IMenuItem>(intPtr2, outSpecificItems);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00010D58 File Offset: 0x0000EF58
		public unsafe ISubMenu AddSubMenu(int titleRes)
		{
			if (this.id_addSubMenu_I == IntPtr.Zero)
			{
				this.id_addSubMenu_I = JNIEnv.GetMethodID(this.class_ref, "addSubMenu", "(I)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(titleRes);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_addSubMenu_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		public unsafe ISubMenu AddSubMenu(int groupId, int itemId, int order, int titleRes)
		{
			if (this.id_addSubMenu_IIII == IntPtr.Zero)
			{
				this.id_addSubMenu_IIII = JNIEnv.GetMethodID(this.class_ref, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(groupId);
			ptr[1] = new JValue(itemId);
			ptr[2] = new JValue(order);
			ptr[3] = new JValue(titleRes);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_addSubMenu_IIII, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00010E70 File Offset: 0x0000F070
		public unsafe ISubMenu AddSubMenu(int groupId, int itemId, int order, ICharSequence title)
		{
			if (this.id_addSubMenu_IIILjava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_addSubMenu_IIILjava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(groupId);
			ptr[1] = new JValue(itemId);
			ptr[2] = new JValue(order);
			ptr[3] = new JValue(intPtr);
			ISubMenu @object = Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_addSubMenu_IIILjava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00010F28 File Offset: 0x0000F128
		public unsafe ISubMenu AddSubMenu(ICharSequence title)
		{
			if (this.id_addSubMenu_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_addSubMenu_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISubMenu @object = Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_addSubMenu_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00010F9F File Offset: 0x0000F19F
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00010FDF File Offset: 0x0000F1DF
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00011020 File Offset: 0x0000F220
		public unsafe IMenuItem FindItem(int id)
		{
			if (this.id_findItem_I == IntPtr.Zero)
			{
				this.id_findItem_I = JNIEnv.GetMethodID(this.class_ref, "findItem", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(id);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_findItem_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0001108C File Offset: 0x0000F28C
		public unsafe IMenuItem GetItem(int index)
		{
			if (this.id_getItem_I == IntPtr.Zero)
			{
				this.id_getItem_I = JNIEnv.GetMethodID(this.class_ref, "getItem", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_getItem_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public unsafe bool IsShortcutKey([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			if (this.id_isShortcutKey_ILandroid_view_KeyEvent_ == IntPtr.Zero)
			{
				this.id_isShortcutKey_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)keyCode);
			ptr[1] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_isShortcutKey_ILandroid_view_KeyEvent_, ptr);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00011180 File Offset: 0x0000F380
		public unsafe bool PerformIdentifierAction(int id, [GeneratedEnum] MenuPerformFlags flags)
		{
			if (this.id_performIdentifierAction_II == IntPtr.Zero)
			{
				this.id_performIdentifierAction_II = JNIEnv.GetMethodID(this.class_ref, "performIdentifierAction", "(II)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(id);
			ptr[1] = new JValue((int)flags);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_performIdentifierAction_II, ptr);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000111F8 File Offset: 0x0000F3F8
		public unsafe bool PerformShortcut([GeneratedEnum] Keycode keyCode, KeyEvent e, [GeneratedEnum] MenuPerformFlags flags)
		{
			if (this.id_performShortcut_ILandroid_view_KeyEvent_I == IntPtr.Zero)
			{
				this.id_performShortcut_ILandroid_view_KeyEvent_I = JNIEnv.GetMethodID(this.class_ref, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)keyCode);
			ptr[1] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			ptr[2] = new JValue((int)flags);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_performShortcut_ILandroid_view_KeyEvent_I, ptr);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00011294 File Offset: 0x0000F494
		public unsafe void RemoveGroup(int groupId)
		{
			if (this.id_removeGroup_I == IntPtr.Zero)
			{
				this.id_removeGroup_I = JNIEnv.GetMethodID(this.class_ref, "removeGroup", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(groupId);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeGroup_I, ptr);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000112F8 File Offset: 0x0000F4F8
		public unsafe void RemoveItem(int id)
		{
			if (this.id_removeItem_I == IntPtr.Zero)
			{
				this.id_removeItem_I = JNIEnv.GetMethodID(this.class_ref, "removeItem", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(id);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeItem_I, ptr);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0001135C File Offset: 0x0000F55C
		public unsafe void SetGroupCheckable(int group, bool checkable, bool exclusive)
		{
			if (this.id_setGroupCheckable_IZZ == IntPtr.Zero)
			{
				this.id_setGroupCheckable_IZZ = JNIEnv.GetMethodID(this.class_ref, "setGroupCheckable", "(IZZ)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(group);
			ptr[1] = new JValue(checkable);
			ptr[2] = new JValue(exclusive);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setGroupCheckable_IZZ, ptr);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000113EC File Offset: 0x0000F5EC
		public unsafe void SetGroupEnabled(int group, bool enabled)
		{
			if (this.id_setGroupEnabled_IZ == IntPtr.Zero)
			{
				this.id_setGroupEnabled_IZ = JNIEnv.GetMethodID(this.class_ref, "setGroupEnabled", "(IZ)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(group);
			ptr[1] = new JValue(enabled);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setGroupEnabled_IZ, ptr);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00011464 File Offset: 0x0000F664
		public unsafe void SetGroupVisible(int group, bool visible)
		{
			if (this.id_setGroupVisible_IZ == IntPtr.Zero)
			{
				this.id_setGroupVisible_IZ = JNIEnv.GetMethodID(this.class_ref, "setGroupVisible", "(IZ)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(group);
			ptr[1] = new JValue(visible);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setGroupVisible_IZ, ptr);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000114DC File Offset: 0x0000F6DC
		public unsafe void SetQwertyMode(bool isQwerty)
		{
			if (this.id_setQwertyMode_Z == IntPtr.Zero)
			{
				this.id_setQwertyMode_Z = JNIEnv.GetMethodID(this.class_ref, "setQwertyMode", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(isQwerty);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setQwertyMode_Z, ptr);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00011540 File Offset: 0x0000F740
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x040001DC RID: 476
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ContextMenu", typeof(IContextMenuInvoker));

		// Token: 0x040001DD RID: 477
		private IntPtr class_ref;

		// Token: 0x040001DE RID: 478
		private static Delegate cb_clearHeader;

		// Token: 0x040001DF RID: 479
		private IntPtr id_clearHeader;

		// Token: 0x040001E0 RID: 480
		private static Delegate cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001E1 RID: 481
		private IntPtr id_setHeaderIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001E2 RID: 482
		private static Delegate cb_setHeaderIcon_I;

		// Token: 0x040001E3 RID: 483
		private IntPtr id_setHeaderIcon_I;

		// Token: 0x040001E4 RID: 484
		private static Delegate cb_setHeaderTitle_I;

		// Token: 0x040001E5 RID: 485
		private IntPtr id_setHeaderTitle_I;

		// Token: 0x040001E6 RID: 486
		private static Delegate cb_setHeaderTitle_Ljava_lang_CharSequence_;

		// Token: 0x040001E7 RID: 487
		private IntPtr id_setHeaderTitle_Ljava_lang_CharSequence_;

		// Token: 0x040001E8 RID: 488
		private static Delegate cb_setHeaderView_Landroid_view_View_;

		// Token: 0x040001E9 RID: 489
		private IntPtr id_setHeaderView_Landroid_view_View_;

		// Token: 0x040001EA RID: 490
		private IntPtr id_hasVisibleItems;

		// Token: 0x040001EB RID: 491
		private IntPtr id_add_I;

		// Token: 0x040001EC RID: 492
		private IntPtr id_add_IIII;

		// Token: 0x040001ED RID: 493
		private IntPtr id_add_IIILjava_lang_CharSequence_;

		// Token: 0x040001EE RID: 494
		private IntPtr id_add_Ljava_lang_CharSequence_;

		// Token: 0x040001EF RID: 495
		private IntPtr id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;

		// Token: 0x040001F0 RID: 496
		private IntPtr id_addSubMenu_I;

		// Token: 0x040001F1 RID: 497
		private IntPtr id_addSubMenu_IIII;

		// Token: 0x040001F2 RID: 498
		private IntPtr id_addSubMenu_IIILjava_lang_CharSequence_;

		// Token: 0x040001F3 RID: 499
		private IntPtr id_addSubMenu_Ljava_lang_CharSequence_;

		// Token: 0x040001F4 RID: 500
		private IntPtr id_clear;

		// Token: 0x040001F5 RID: 501
		private IntPtr id_close;

		// Token: 0x040001F6 RID: 502
		private IntPtr id_findItem_I;

		// Token: 0x040001F7 RID: 503
		private IntPtr id_getItem_I;

		// Token: 0x040001F8 RID: 504
		private IntPtr id_isShortcutKey_ILandroid_view_KeyEvent_;

		// Token: 0x040001F9 RID: 505
		private IntPtr id_performIdentifierAction_II;

		// Token: 0x040001FA RID: 506
		private IntPtr id_performShortcut_ILandroid_view_KeyEvent_I;

		// Token: 0x040001FB RID: 507
		private IntPtr id_removeGroup_I;

		// Token: 0x040001FC RID: 508
		private IntPtr id_removeItem_I;

		// Token: 0x040001FD RID: 509
		private IntPtr id_setGroupCheckable_IZZ;

		// Token: 0x040001FE RID: 510
		private IntPtr id_setGroupEnabled_IZ;

		// Token: 0x040001FF RID: 511
		private IntPtr id_setGroupVisible_IZ;

		// Token: 0x04000200 RID: 512
		private IntPtr id_setQwertyMode_Z;

		// Token: 0x04000201 RID: 513
		private IntPtr id_size;
	}
}
