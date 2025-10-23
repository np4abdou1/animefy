using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200011B RID: 283
	[Register("android/view/Menu", DoNotGenerateAcw = true)]
	internal class IMenuInvoker : Java.Lang.Object, IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00011628 File Offset: 0x0000F828
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0001164C File Offset: 0x0000F84C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuInvoker._members;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00011653 File Offset: 0x0000F853
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0001165B File Offset: 0x0000F85B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00011667 File Offset: 0x0000F867
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.Menu'.");
			}
			return handle;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00011692 File Offset: 0x0000F892
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000116C4 File Offset: 0x0000F8C4
		public IMenuInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000116FC File Offset: 0x0000F8FC
		private static Delegate GetHasVisibleItemsHandler()
		{
			if (IMenuInvoker.cb_hasVisibleItems == null)
			{
				IMenuInvoker.cb_hasVisibleItems = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuInvoker.n_HasVisibleItems));
			}
			return IMenuInvoker.cb_hasVisibleItems;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00011720 File Offset: 0x0000F920
		private static bool n_HasVisibleItems(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasVisibleItems;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0001172F File Offset: 0x0000F92F
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

		// Token: 0x06000789 RID: 1929 RVA: 0x0001176F File Offset: 0x0000F96F
		private static Delegate GetAdd_IHandler()
		{
			if (IMenuInvoker.cb_add_I == null)
			{
				IMenuInvoker.cb_add_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMenuInvoker.n_Add_I));
			}
			return IMenuInvoker.cb_add_I;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00011793 File Offset: 0x0000F993
		private static IntPtr n_Add_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Add(titleRes));
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000117A8 File Offset: 0x0000F9A8
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

		// Token: 0x0600078C RID: 1932 RVA: 0x00011812 File Offset: 0x0000FA12
		private static Delegate GetAdd_IIIIHandler()
		{
			if (IMenuInvoker.cb_add_IIII == null)
			{
				IMenuInvoker.cb_add_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(IMenuInvoker.n_Add_IIII));
			}
			return IMenuInvoker.cb_add_IIII;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00011836 File Offset: 0x0000FA36
		private static IntPtr n_Add_IIII(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Add(groupId, itemId, order, titleRes));
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00011850 File Offset: 0x0000FA50
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

		// Token: 0x0600078F RID: 1935 RVA: 0x000118FA File Offset: 0x0000FAFA
		private static Delegate GetAdd_IIILjava_lang_CharSequence_Handler()
		{
			if (IMenuInvoker.cb_add_IIILjava_lang_CharSequence_ == null)
			{
				IMenuInvoker.cb_add_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIL_L(IMenuInvoker.n_Add_IIILjava_lang_CharSequence_));
			}
			return IMenuInvoker.cb_add_IIILjava_lang_CharSequence_;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00011920 File Offset: 0x0000FB20
		private static IntPtr n_Add_IIILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, IntPtr native_title)
		{
			IMenu @object = Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(groupId, itemId, order, object2));
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00011950 File Offset: 0x0000FB50
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

		// Token: 0x06000792 RID: 1938 RVA: 0x00011A07 File Offset: 0x0000FC07
		private static Delegate GetAdd_Ljava_lang_CharSequence_Handler()
		{
			if (IMenuInvoker.cb_add_Ljava_lang_CharSequence_ == null)
			{
				IMenuInvoker.cb_add_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuInvoker.n_Add_Ljava_lang_CharSequence_));
			}
			return IMenuInvoker.cb_add_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00011A2C File Offset: 0x0000FC2C
		private static IntPtr n_Add_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IMenu @object = Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(object2));
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00011A54 File Offset: 0x0000FC54
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

		// Token: 0x06000795 RID: 1941 RVA: 0x00011ACB File Offset: 0x0000FCCB
		private static Delegate GetAddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_Handler()
		{
			if (IMenuInvoker.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_ == null)
			{
				IMenuInvoker.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIILLLIL_I(IMenuInvoker.n_AddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_));
			}
			return IMenuInvoker.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		private static int n_AddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, IntPtr native_caller, IntPtr native_specifics, IntPtr native_intent, int native_flags, IntPtr native_outSpecificItems)
		{
			IMenu @object = Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ComponentName object2 = Java.Lang.Object.GetObject<ComponentName>(native_caller, JniHandleOwnership.DoNotTransfer);
			Intent[] array = (Intent[])JNIEnv.GetArray(native_specifics, JniHandleOwnership.DoNotTransfer, typeof(Intent));
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			IMenuItem[] array2 = (IMenuItem[])JNIEnv.GetArray(native_outSpecificItems, JniHandleOwnership.DoNotTransfer, typeof(IMenuItem));
			int result = @object.AddIntentOptions(groupId, itemId, order, object2, array, object3, (MenuAppendFlags)native_flags, array2);
			if (array != null)
			{
				JNIEnv.CopyArray<Intent>(array, native_specifics);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray<IMenuItem>(array2, native_outSpecificItems);
			}
			return result;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00011B74 File Offset: 0x0000FD74
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

		// Token: 0x06000798 RID: 1944 RVA: 0x00011CC6 File Offset: 0x0000FEC6
		private static Delegate GetAddSubMenu_IHandler()
		{
			if (IMenuInvoker.cb_addSubMenu_I == null)
			{
				IMenuInvoker.cb_addSubMenu_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMenuInvoker.n_AddSubMenu_I));
			}
			return IMenuInvoker.cb_addSubMenu_I;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00011CEA File Offset: 0x0000FEEA
		private static IntPtr n_AddSubMenu_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddSubMenu(titleRes));
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00011D00 File Offset: 0x0000FF00
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

		// Token: 0x0600079B RID: 1947 RVA: 0x00011D6A File Offset: 0x0000FF6A
		private static Delegate GetAddSubMenu_IIIIHandler()
		{
			if (IMenuInvoker.cb_addSubMenu_IIII == null)
			{
				IMenuInvoker.cb_addSubMenu_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(IMenuInvoker.n_AddSubMenu_IIII));
			}
			return IMenuInvoker.cb_addSubMenu_IIII;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00011D8E File Offset: 0x0000FF8E
		private static IntPtr n_AddSubMenu_IIII(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddSubMenu(groupId, itemId, order, titleRes));
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00011DA8 File Offset: 0x0000FFA8
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

		// Token: 0x0600079E RID: 1950 RVA: 0x00011E52 File Offset: 0x00010052
		private static Delegate GetAddSubMenu_IIILjava_lang_CharSequence_Handler()
		{
			if (IMenuInvoker.cb_addSubMenu_IIILjava_lang_CharSequence_ == null)
			{
				IMenuInvoker.cb_addSubMenu_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIL_L(IMenuInvoker.n_AddSubMenu_IIILjava_lang_CharSequence_));
			}
			return IMenuInvoker.cb_addSubMenu_IIILjava_lang_CharSequence_;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00011E78 File Offset: 0x00010078
		private static IntPtr n_AddSubMenu_IIILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, IntPtr native_title)
		{
			IMenu @object = Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddSubMenu(groupId, itemId, order, object2));
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00011EA8 File Offset: 0x000100A8
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

		// Token: 0x060007A1 RID: 1953 RVA: 0x00011F5F File Offset: 0x0001015F
		private static Delegate GetAddSubMenu_Ljava_lang_CharSequence_Handler()
		{
			if (IMenuInvoker.cb_addSubMenu_Ljava_lang_CharSequence_ == null)
			{
				IMenuInvoker.cb_addSubMenu_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuInvoker.n_AddSubMenu_Ljava_lang_CharSequence_));
			}
			return IMenuInvoker.cb_addSubMenu_Ljava_lang_CharSequence_;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00011F84 File Offset: 0x00010184
		private static IntPtr n_AddSubMenu_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IMenu @object = Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddSubMenu(object2));
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00011FAC File Offset: 0x000101AC
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

		// Token: 0x060007A4 RID: 1956 RVA: 0x00012023 File Offset: 0x00010223
		private static Delegate GetClearHandler()
		{
			if (IMenuInvoker.cb_clear == null)
			{
				IMenuInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMenuInvoker.n_Clear));
			}
			return IMenuInvoker.cb_clear;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00012047 File Offset: 0x00010247
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00012056 File Offset: 0x00010256
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00012096 File Offset: 0x00010296
		private static Delegate GetCloseHandler()
		{
			if (IMenuInvoker.cb_close == null)
			{
				IMenuInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMenuInvoker.n_Close));
			}
			return IMenuInvoker.cb_close;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000120BA File Offset: 0x000102BA
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000120C9 File Offset: 0x000102C9
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00012109 File Offset: 0x00010309
		private static Delegate GetFindItem_IHandler()
		{
			if (IMenuInvoker.cb_findItem_I == null)
			{
				IMenuInvoker.cb_findItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMenuInvoker.n_FindItem_I));
			}
			return IMenuInvoker.cb_findItem_I;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0001212D File Offset: 0x0001032D
		private static IntPtr n_FindItem_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindItem(id));
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00012144 File Offset: 0x00010344
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

		// Token: 0x060007AD RID: 1965 RVA: 0x000121AE File Offset: 0x000103AE
		private static Delegate GetGetItem_IHandler()
		{
			if (IMenuInvoker.cb_getItem_I == null)
			{
				IMenuInvoker.cb_getItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMenuInvoker.n_GetItem_I));
			}
			return IMenuInvoker.cb_getItem_I;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000121D2 File Offset: 0x000103D2
		private static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItem(index));
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000121E8 File Offset: 0x000103E8
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

		// Token: 0x060007B0 RID: 1968 RVA: 0x00012252 File Offset: 0x00010452
		private static Delegate GetIsShortcutKey_ILandroid_view_KeyEvent_Handler()
		{
			if (IMenuInvoker.cb_isShortcutKey_ILandroid_view_KeyEvent_ == null)
			{
				IMenuInvoker.cb_isShortcutKey_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(IMenuInvoker.n_IsShortcutKey_ILandroid_view_KeyEvent_));
			}
			return IMenuInvoker.cb_isShortcutKey_ILandroid_view_KeyEvent_;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00012278 File Offset: 0x00010478
		private static bool n_IsShortcutKey_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			IMenu @object = Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.IsShortcutKey((Keycode)native_keyCode, object2);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000122A0 File Offset: 0x000104A0
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

		// Token: 0x060007B3 RID: 1971 RVA: 0x00012326 File Offset: 0x00010526
		private static Delegate GetPerformIdentifierAction_IIHandler()
		{
			if (IMenuInvoker.cb_performIdentifierAction_II == null)
			{
				IMenuInvoker.cb_performIdentifierAction_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(IMenuInvoker.n_PerformIdentifierAction_II));
			}
			return IMenuInvoker.cb_performIdentifierAction_II;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0001234C File Offset: 0x0001054C
		private static bool n_PerformIdentifierAction_II(IntPtr jnienv, IntPtr native__this, int id, int native_flags)
		{
			return Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PerformIdentifierAction(id, (MenuPerformFlags)native_flags);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0001236C File Offset: 0x0001056C
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

		// Token: 0x060007B6 RID: 1974 RVA: 0x000123E3 File Offset: 0x000105E3
		private static Delegate GetPerformShortcut_ILandroid_view_KeyEvent_IHandler()
		{
			if (IMenuInvoker.cb_performShortcut_ILandroid_view_KeyEvent_I == null)
			{
				IMenuInvoker.cb_performShortcut_ILandroid_view_KeyEvent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILI_Z(IMenuInvoker.n_PerformShortcut_ILandroid_view_KeyEvent_I));
			}
			return IMenuInvoker.cb_performShortcut_ILandroid_view_KeyEvent_I;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00012408 File Offset: 0x00010608
		private static bool n_PerformShortcut_ILandroid_view_KeyEvent_I(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e, int native_flags)
		{
			IMenu @object = Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.PerformShortcut((Keycode)native_keyCode, object2, (MenuPerformFlags)native_flags);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00012434 File Offset: 0x00010634
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

		// Token: 0x060007B9 RID: 1977 RVA: 0x000124D0 File Offset: 0x000106D0
		private static Delegate GetRemoveGroup_IHandler()
		{
			if (IMenuInvoker.cb_removeGroup_I == null)
			{
				IMenuInvoker.cb_removeGroup_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IMenuInvoker.n_RemoveGroup_I));
			}
			return IMenuInvoker.cb_removeGroup_I;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000124F4 File Offset: 0x000106F4
		private static void n_RemoveGroup_I(IntPtr jnienv, IntPtr native__this, int groupId)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveGroup(groupId);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00012504 File Offset: 0x00010704
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

		// Token: 0x060007BC RID: 1980 RVA: 0x00012568 File Offset: 0x00010768
		private static Delegate GetRemoveItem_IHandler()
		{
			if (IMenuInvoker.cb_removeItem_I == null)
			{
				IMenuInvoker.cb_removeItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IMenuInvoker.n_RemoveItem_I));
			}
			return IMenuInvoker.cb_removeItem_I;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0001258C File Offset: 0x0001078C
		private static void n_RemoveItem_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveItem(id);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0001259C File Offset: 0x0001079C
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

		// Token: 0x060007BF RID: 1983 RVA: 0x00012600 File Offset: 0x00010800
		private static Delegate GetSetGroupCheckable_IZZHandler()
		{
			if (IMenuInvoker.cb_setGroupCheckable_IZZ == null)
			{
				IMenuInvoker.cb_setGroupCheckable_IZZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZZ_V(IMenuInvoker.n_SetGroupCheckable_IZZ));
			}
			return IMenuInvoker.cb_setGroupCheckable_IZZ;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00012624 File Offset: 0x00010824
		private static void n_SetGroupCheckable_IZZ(IntPtr jnienv, IntPtr native__this, int group, bool checkable, bool exclusive)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupCheckable(group, checkable, exclusive);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00012638 File Offset: 0x00010838
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

		// Token: 0x060007C2 RID: 1986 RVA: 0x000126C5 File Offset: 0x000108C5
		private static Delegate GetSetGroupEnabled_IZHandler()
		{
			if (IMenuInvoker.cb_setGroupEnabled_IZ == null)
			{
				IMenuInvoker.cb_setGroupEnabled_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(IMenuInvoker.n_SetGroupEnabled_IZ));
			}
			return IMenuInvoker.cb_setGroupEnabled_IZ;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000126E9 File Offset: 0x000108E9
		private static void n_SetGroupEnabled_IZ(IntPtr jnienv, IntPtr native__this, int group, bool enabled)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupEnabled(group, enabled);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000126FC File Offset: 0x000108FC
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

		// Token: 0x060007C5 RID: 1989 RVA: 0x00012773 File Offset: 0x00010973
		private static Delegate GetSetGroupVisible_IZHandler()
		{
			if (IMenuInvoker.cb_setGroupVisible_IZ == null)
			{
				IMenuInvoker.cb_setGroupVisible_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(IMenuInvoker.n_SetGroupVisible_IZ));
			}
			return IMenuInvoker.cb_setGroupVisible_IZ;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00012797 File Offset: 0x00010997
		private static void n_SetGroupVisible_IZ(IntPtr jnienv, IntPtr native__this, int group, bool visible)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupVisible(group, visible);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000127A8 File Offset: 0x000109A8
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x0001281F File Offset: 0x00010A1F
		private static Delegate GetSetQwertyMode_ZHandler()
		{
			if (IMenuInvoker.cb_setQwertyMode_Z == null)
			{
				IMenuInvoker.cb_setQwertyMode_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IMenuInvoker.n_SetQwertyMode_Z));
			}
			return IMenuInvoker.cb_setQwertyMode_Z;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00012843 File Offset: 0x00010A43
		private static void n_SetQwertyMode_Z(IntPtr jnienv, IntPtr native__this, bool isQwerty)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetQwertyMode(isQwerty);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00012854 File Offset: 0x00010A54
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

		// Token: 0x060007CB RID: 1995 RVA: 0x000128B8 File Offset: 0x00010AB8
		private static Delegate GetSizeHandler()
		{
			if (IMenuInvoker.cb_size == null)
			{
				IMenuInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMenuInvoker.n_Size));
			}
			return IMenuInvoker.cb_size;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000128DC File Offset: 0x00010ADC
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000128EB File Offset: 0x00010AEB
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x04000204 RID: 516
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/Menu", typeof(IMenuInvoker));

		// Token: 0x04000205 RID: 517
		private IntPtr class_ref;

		// Token: 0x04000206 RID: 518
		private static Delegate cb_hasVisibleItems;

		// Token: 0x04000207 RID: 519
		private IntPtr id_hasVisibleItems;

		// Token: 0x04000208 RID: 520
		private static Delegate cb_add_I;

		// Token: 0x04000209 RID: 521
		private IntPtr id_add_I;

		// Token: 0x0400020A RID: 522
		private static Delegate cb_add_IIII;

		// Token: 0x0400020B RID: 523
		private IntPtr id_add_IIII;

		// Token: 0x0400020C RID: 524
		private static Delegate cb_add_IIILjava_lang_CharSequence_;

		// Token: 0x0400020D RID: 525
		private IntPtr id_add_IIILjava_lang_CharSequence_;

		// Token: 0x0400020E RID: 526
		private static Delegate cb_add_Ljava_lang_CharSequence_;

		// Token: 0x0400020F RID: 527
		private IntPtr id_add_Ljava_lang_CharSequence_;

		// Token: 0x04000210 RID: 528
		private static Delegate cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;

		// Token: 0x04000211 RID: 529
		private IntPtr id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;

		// Token: 0x04000212 RID: 530
		private static Delegate cb_addSubMenu_I;

		// Token: 0x04000213 RID: 531
		private IntPtr id_addSubMenu_I;

		// Token: 0x04000214 RID: 532
		private static Delegate cb_addSubMenu_IIII;

		// Token: 0x04000215 RID: 533
		private IntPtr id_addSubMenu_IIII;

		// Token: 0x04000216 RID: 534
		private static Delegate cb_addSubMenu_IIILjava_lang_CharSequence_;

		// Token: 0x04000217 RID: 535
		private IntPtr id_addSubMenu_IIILjava_lang_CharSequence_;

		// Token: 0x04000218 RID: 536
		private static Delegate cb_addSubMenu_Ljava_lang_CharSequence_;

		// Token: 0x04000219 RID: 537
		private IntPtr id_addSubMenu_Ljava_lang_CharSequence_;

		// Token: 0x0400021A RID: 538
		private static Delegate cb_clear;

		// Token: 0x0400021B RID: 539
		private IntPtr id_clear;

		// Token: 0x0400021C RID: 540
		private static Delegate cb_close;

		// Token: 0x0400021D RID: 541
		private IntPtr id_close;

		// Token: 0x0400021E RID: 542
		private static Delegate cb_findItem_I;

		// Token: 0x0400021F RID: 543
		private IntPtr id_findItem_I;

		// Token: 0x04000220 RID: 544
		private static Delegate cb_getItem_I;

		// Token: 0x04000221 RID: 545
		private IntPtr id_getItem_I;

		// Token: 0x04000222 RID: 546
		private static Delegate cb_isShortcutKey_ILandroid_view_KeyEvent_;

		// Token: 0x04000223 RID: 547
		private IntPtr id_isShortcutKey_ILandroid_view_KeyEvent_;

		// Token: 0x04000224 RID: 548
		private static Delegate cb_performIdentifierAction_II;

		// Token: 0x04000225 RID: 549
		private IntPtr id_performIdentifierAction_II;

		// Token: 0x04000226 RID: 550
		private static Delegate cb_performShortcut_ILandroid_view_KeyEvent_I;

		// Token: 0x04000227 RID: 551
		private IntPtr id_performShortcut_ILandroid_view_KeyEvent_I;

		// Token: 0x04000228 RID: 552
		private static Delegate cb_removeGroup_I;

		// Token: 0x04000229 RID: 553
		private IntPtr id_removeGroup_I;

		// Token: 0x0400022A RID: 554
		private static Delegate cb_removeItem_I;

		// Token: 0x0400022B RID: 555
		private IntPtr id_removeItem_I;

		// Token: 0x0400022C RID: 556
		private static Delegate cb_setGroupCheckable_IZZ;

		// Token: 0x0400022D RID: 557
		private IntPtr id_setGroupCheckable_IZZ;

		// Token: 0x0400022E RID: 558
		private static Delegate cb_setGroupEnabled_IZ;

		// Token: 0x0400022F RID: 559
		private IntPtr id_setGroupEnabled_IZ;

		// Token: 0x04000230 RID: 560
		private static Delegate cb_setGroupVisible_IZ;

		// Token: 0x04000231 RID: 561
		private IntPtr id_setGroupVisible_IZ;

		// Token: 0x04000232 RID: 562
		private static Delegate cb_setQwertyMode_Z;

		// Token: 0x04000233 RID: 563
		private IntPtr id_setQwertyMode_Z;

		// Token: 0x04000234 RID: 564
		private static Delegate cb_size;

		// Token: 0x04000235 RID: 565
		private IntPtr id_size;
	}
}
