using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Internal.View
{
	// Token: 0x02000052 RID: 82
	[Register("androidx/core/internal/view/SupportMenu", DoNotGenerateAcw = true)]
	internal class ISupportMenuInvoker : Java.Lang.Object, ISupportMenu, IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002D04 File Offset: 0x00000F04
		private static IntPtr java_class_ref
		{
			get
			{
				return ISupportMenuInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002D28 File Offset: 0x00000F28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISupportMenuInvoker._members;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002D2F File Offset: 0x00000F2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002D37 File Offset: 0x00000F37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISupportMenuInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002D43 File Offset: 0x00000F43
		public static ISupportMenu GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISupportMenu>(handle, transfer);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002D4C File Offset: 0x00000F4C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISupportMenuInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.internal.view.SupportMenu'.");
			}
			return handle;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002D77 File Offset: 0x00000F77
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public ISupportMenuInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISupportMenuInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002DE0 File Offset: 0x00000FE0
		private static Delegate GetSetGroupDividerEnabled_ZHandler()
		{
			if (ISupportMenuInvoker.cb_setGroupDividerEnabled_Z == null)
			{
				ISupportMenuInvoker.cb_setGroupDividerEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ISupportMenuInvoker.n_SetGroupDividerEnabled_Z));
			}
			return ISupportMenuInvoker.cb_setGroupDividerEnabled_Z;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002E04 File Offset: 0x00001004
		private static void n_SetGroupDividerEnabled_Z(IntPtr jnienv, IntPtr native__this, bool isEnabled)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupDividerEnabled(isEnabled);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002E14 File Offset: 0x00001014
		public unsafe void SetGroupDividerEnabled(bool isEnabled)
		{
			if (this.id_setGroupDividerEnabled_Z == IntPtr.Zero)
			{
				this.id_setGroupDividerEnabled_Z = JNIEnv.GetMethodID(this.class_ref, "setGroupDividerEnabled", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(isEnabled);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setGroupDividerEnabled_Z, ptr);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002E78 File Offset: 0x00001078
		private static Delegate GetGetHasVisibleItemsHandler()
		{
			if (ISupportMenuInvoker.cb_hasVisibleItems == null)
			{
				ISupportMenuInvoker.cb_hasVisibleItems = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuInvoker.n_GetHasVisibleItems));
			}
			return ISupportMenuInvoker.cb_hasVisibleItems;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002E9C File Offset: 0x0000109C
		private static bool n_GetHasVisibleItems(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasVisibleItems;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002EAB File Offset: 0x000010AB
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

		// Token: 0x0600016C RID: 364 RVA: 0x00002EEB File Offset: 0x000010EB
		private static Delegate GetAdd_IHandler()
		{
			if (ISupportMenuInvoker.cb_add_I == null)
			{
				ISupportMenuInvoker.cb_add_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISupportMenuInvoker.n_Add_I));
			}
			return ISupportMenuInvoker.cb_add_I;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002F0F File Offset: 0x0000110F
		private static IntPtr n_Add_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Add(titleRes));
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002F24 File Offset: 0x00001124
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

		// Token: 0x0600016F RID: 367 RVA: 0x00002F8E File Offset: 0x0000118E
		private static Delegate GetAdd_IIIIHandler()
		{
			if (ISupportMenuInvoker.cb_add_IIII == null)
			{
				ISupportMenuInvoker.cb_add_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(ISupportMenuInvoker.n_Add_IIII));
			}
			return ISupportMenuInvoker.cb_add_IIII;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002FB2 File Offset: 0x000011B2
		private static IntPtr n_Add_IIII(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Add(groupId, itemId, order, titleRes));
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002FCC File Offset: 0x000011CC
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

		// Token: 0x06000172 RID: 370 RVA: 0x00003076 File Offset: 0x00001276
		private static Delegate GetAdd_IIILjava_lang_CharSequence_Handler()
		{
			if (ISupportMenuInvoker.cb_add_IIILjava_lang_CharSequence_ == null)
			{
				ISupportMenuInvoker.cb_add_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIL_L(ISupportMenuInvoker.n_Add_IIILjava_lang_CharSequence_));
			}
			return ISupportMenuInvoker.cb_add_IIILjava_lang_CharSequence_;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000309C File Offset: 0x0000129C
		private static IntPtr n_Add_IIILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, IntPtr native_title)
		{
			IMenu @object = Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(groupId, itemId, order, object2));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000030CC File Offset: 0x000012CC
		public unsafe IMenuItem Add(int groupId, int itemId, int order, ICharSequence title)
		{
			if (this.id_add_IIILjava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_add_IIILjava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(groupId);
			ptr[1] = new JValue(itemId);
			ptr[2] = new JValue(order);
			ptr[3] = new JValue((title == null) ? IntPtr.Zero : ((Java.Lang.Object)title).Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_add_IIILjava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000318B File Offset: 0x0000138B
		private static Delegate GetAdd_Ljava_lang_CharSequence_Handler()
		{
			if (ISupportMenuInvoker.cb_add_Ljava_lang_CharSequence_ == null)
			{
				ISupportMenuInvoker.cb_add_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuInvoker.n_Add_Ljava_lang_CharSequence_));
			}
			return ISupportMenuInvoker.cb_add_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000031B0 File Offset: 0x000013B0
		private static IntPtr n_Add_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IMenu @object = Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(object2));
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000031D8 File Offset: 0x000013D8
		public unsafe IMenuItem Add(ICharSequence title)
		{
			if (this.id_add_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_add_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((title == null) ? IntPtr.Zero : ((Java.Lang.Object)title).Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_add_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00003256 File Offset: 0x00001456
		private static Delegate GetAddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_Handler()
		{
			if (ISupportMenuInvoker.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_ == null)
			{
				ISupportMenuInvoker.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIILLLIL_I(ISupportMenuInvoker.n_AddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_));
			}
			return ISupportMenuInvoker.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000327C File Offset: 0x0000147C
		private static int n_AddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, IntPtr native_caller, IntPtr native_specifics, IntPtr native_intent, int native_flags, IntPtr native_outSpecificItems)
		{
			IMenu @object = Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Token: 0x0600017A RID: 378 RVA: 0x00003300 File Offset: 0x00001500
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

		// Token: 0x0600017B RID: 379 RVA: 0x00003452 File Offset: 0x00001652
		private static Delegate GetAddSubMenu_IHandler()
		{
			if (ISupportMenuInvoker.cb_addSubMenu_I == null)
			{
				ISupportMenuInvoker.cb_addSubMenu_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISupportMenuInvoker.n_AddSubMenu_I));
			}
			return ISupportMenuInvoker.cb_addSubMenu_I;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00003476 File Offset: 0x00001676
		private static IntPtr n_AddSubMenu_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddSubMenu(titleRes));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000348C File Offset: 0x0000168C
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

		// Token: 0x0600017E RID: 382 RVA: 0x000034F6 File Offset: 0x000016F6
		private static Delegate GetAddSubMenu_IIIIHandler()
		{
			if (ISupportMenuInvoker.cb_addSubMenu_IIII == null)
			{
				ISupportMenuInvoker.cb_addSubMenu_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(ISupportMenuInvoker.n_AddSubMenu_IIII));
			}
			return ISupportMenuInvoker.cb_addSubMenu_IIII;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000351A File Offset: 0x0000171A
		private static IntPtr n_AddSubMenu_IIII(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddSubMenu(groupId, itemId, order, titleRes));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00003534 File Offset: 0x00001734
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

		// Token: 0x06000181 RID: 385 RVA: 0x000035DE File Offset: 0x000017DE
		private static Delegate GetAddSubMenu_IIILjava_lang_CharSequence_Handler()
		{
			if (ISupportMenuInvoker.cb_addSubMenu_IIILjava_lang_CharSequence_ == null)
			{
				ISupportMenuInvoker.cb_addSubMenu_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIL_L(ISupportMenuInvoker.n_AddSubMenu_IIILjava_lang_CharSequence_));
			}
			return ISupportMenuInvoker.cb_addSubMenu_IIILjava_lang_CharSequence_;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00003604 File Offset: 0x00001804
		private static IntPtr n_AddSubMenu_IIILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int groupId, int itemId, int order, IntPtr native_title)
		{
			IMenu @object = Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddSubMenu(groupId, itemId, order, object2));
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00003634 File Offset: 0x00001834
		public unsafe ISubMenu AddSubMenu(int groupId, int itemId, int order, ICharSequence title)
		{
			if (this.id_addSubMenu_IIILjava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_addSubMenu_IIILjava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(groupId);
			ptr[1] = new JValue(itemId);
			ptr[2] = new JValue(order);
			ptr[3] = new JValue((title == null) ? IntPtr.Zero : ((Java.Lang.Object)title).Handle);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_addSubMenu_IIILjava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000036F3 File Offset: 0x000018F3
		private static Delegate GetAddSubMenu_Ljava_lang_CharSequence_Handler()
		{
			if (ISupportMenuInvoker.cb_addSubMenu_Ljava_lang_CharSequence_ == null)
			{
				ISupportMenuInvoker.cb_addSubMenu_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuInvoker.n_AddSubMenu_Ljava_lang_CharSequence_));
			}
			return ISupportMenuInvoker.cb_addSubMenu_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003718 File Offset: 0x00001918
		private static IntPtr n_AddSubMenu_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IMenu @object = Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddSubMenu(object2));
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003740 File Offset: 0x00001940
		public unsafe ISubMenu AddSubMenu(ICharSequence title)
		{
			if (this.id_addSubMenu_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_addSubMenu_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((title == null) ? IntPtr.Zero : ((Java.Lang.Object)title).Handle);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_addSubMenu_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000037BE File Offset: 0x000019BE
		private static Delegate GetClearHandler()
		{
			if (ISupportMenuInvoker.cb_clear == null)
			{
				ISupportMenuInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ISupportMenuInvoker.n_Clear));
			}
			return ISupportMenuInvoker.cb_clear;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000037E2 File Offset: 0x000019E2
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000037F1 File Offset: 0x000019F1
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003831 File Offset: 0x00001A31
		private static Delegate GetCloseHandler()
		{
			if (ISupportMenuInvoker.cb_close == null)
			{
				ISupportMenuInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ISupportMenuInvoker.n_Close));
			}
			return ISupportMenuInvoker.cb_close;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00003855 File Offset: 0x00001A55
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00003864 File Offset: 0x00001A64
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000038A4 File Offset: 0x00001AA4
		private static Delegate GetFindItem_IHandler()
		{
			if (ISupportMenuInvoker.cb_findItem_I == null)
			{
				ISupportMenuInvoker.cb_findItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISupportMenuInvoker.n_FindItem_I));
			}
			return ISupportMenuInvoker.cb_findItem_I;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000038C8 File Offset: 0x00001AC8
		private static IntPtr n_FindItem_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindItem(id));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000038E0 File Offset: 0x00001AE0
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

		// Token: 0x06000190 RID: 400 RVA: 0x0000394A File Offset: 0x00001B4A
		private static Delegate GetGetItem_IHandler()
		{
			if (ISupportMenuInvoker.cb_getItem_I == null)
			{
				ISupportMenuInvoker.cb_getItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISupportMenuInvoker.n_GetItem_I));
			}
			return ISupportMenuInvoker.cb_getItem_I;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000396E File Offset: 0x00001B6E
		private static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItem(index));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003984 File Offset: 0x00001B84
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

		// Token: 0x06000193 RID: 403 RVA: 0x000039EE File Offset: 0x00001BEE
		private static Delegate GetIsShortcutKey_ILandroid_view_KeyEvent_Handler()
		{
			if (ISupportMenuInvoker.cb_isShortcutKey_ILandroid_view_KeyEvent_ == null)
			{
				ISupportMenuInvoker.cb_isShortcutKey_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(ISupportMenuInvoker.n_IsShortcutKey_ILandroid_view_KeyEvent_));
			}
			return ISupportMenuInvoker.cb_isShortcutKey_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003A14 File Offset: 0x00001C14
		private static bool n_IsShortcutKey_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			IMenu @object = Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.IsShortcutKey((Keycode)native_keyCode, object2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003A3C File Offset: 0x00001C3C
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

		// Token: 0x06000196 RID: 406 RVA: 0x00003AC2 File Offset: 0x00001CC2
		private static Delegate GetPerformIdentifierAction_IIHandler()
		{
			if (ISupportMenuInvoker.cb_performIdentifierAction_II == null)
			{
				ISupportMenuInvoker.cb_performIdentifierAction_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(ISupportMenuInvoker.n_PerformIdentifierAction_II));
			}
			return ISupportMenuInvoker.cb_performIdentifierAction_II;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003AE8 File Offset: 0x00001CE8
		private static bool n_PerformIdentifierAction_II(IntPtr jnienv, IntPtr native__this, int id, int native_flags)
		{
			return Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PerformIdentifierAction(id, (MenuPerformFlags)native_flags);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003B08 File Offset: 0x00001D08
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

		// Token: 0x06000199 RID: 409 RVA: 0x00003B7F File Offset: 0x00001D7F
		private static Delegate GetPerformShortcut_ILandroid_view_KeyEvent_IHandler()
		{
			if (ISupportMenuInvoker.cb_performShortcut_ILandroid_view_KeyEvent_I == null)
			{
				ISupportMenuInvoker.cb_performShortcut_ILandroid_view_KeyEvent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILI_Z(ISupportMenuInvoker.n_PerformShortcut_ILandroid_view_KeyEvent_I));
			}
			return ISupportMenuInvoker.cb_performShortcut_ILandroid_view_KeyEvent_I;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003BA4 File Offset: 0x00001DA4
		private static bool n_PerformShortcut_ILandroid_view_KeyEvent_I(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e, int native_flags)
		{
			IMenu @object = Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.PerformShortcut((Keycode)native_keyCode, object2, (MenuPerformFlags)native_flags);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00003BD0 File Offset: 0x00001DD0
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

		// Token: 0x0600019C RID: 412 RVA: 0x00003C6C File Offset: 0x00001E6C
		private static Delegate GetRemoveGroup_IHandler()
		{
			if (ISupportMenuInvoker.cb_removeGroup_I == null)
			{
				ISupportMenuInvoker.cb_removeGroup_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ISupportMenuInvoker.n_RemoveGroup_I));
			}
			return ISupportMenuInvoker.cb_removeGroup_I;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00003C90 File Offset: 0x00001E90
		private static void n_RemoveGroup_I(IntPtr jnienv, IntPtr native__this, int groupId)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveGroup(groupId);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00003CA0 File Offset: 0x00001EA0
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

		// Token: 0x0600019F RID: 415 RVA: 0x00003D04 File Offset: 0x00001F04
		private static Delegate GetRemoveItem_IHandler()
		{
			if (ISupportMenuInvoker.cb_removeItem_I == null)
			{
				ISupportMenuInvoker.cb_removeItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ISupportMenuInvoker.n_RemoveItem_I));
			}
			return ISupportMenuInvoker.cb_removeItem_I;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00003D28 File Offset: 0x00001F28
		private static void n_RemoveItem_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveItem(id);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00003D38 File Offset: 0x00001F38
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

		// Token: 0x060001A2 RID: 418 RVA: 0x00003D9C File Offset: 0x00001F9C
		private static Delegate GetSetGroupCheckable_IZZHandler()
		{
			if (ISupportMenuInvoker.cb_setGroupCheckable_IZZ == null)
			{
				ISupportMenuInvoker.cb_setGroupCheckable_IZZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZZ_V(ISupportMenuInvoker.n_SetGroupCheckable_IZZ));
			}
			return ISupportMenuInvoker.cb_setGroupCheckable_IZZ;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00003DC0 File Offset: 0x00001FC0
		private static void n_SetGroupCheckable_IZZ(IntPtr jnienv, IntPtr native__this, int group, bool checkable, bool exclusive)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupCheckable(group, checkable, exclusive);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003DD4 File Offset: 0x00001FD4
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

		// Token: 0x060001A5 RID: 421 RVA: 0x00003E61 File Offset: 0x00002061
		private static Delegate GetSetGroupEnabled_IZHandler()
		{
			if (ISupportMenuInvoker.cb_setGroupEnabled_IZ == null)
			{
				ISupportMenuInvoker.cb_setGroupEnabled_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(ISupportMenuInvoker.n_SetGroupEnabled_IZ));
			}
			return ISupportMenuInvoker.cb_setGroupEnabled_IZ;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00003E85 File Offset: 0x00002085
		private static void n_SetGroupEnabled_IZ(IntPtr jnienv, IntPtr native__this, int group, bool enabled)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupEnabled(group, enabled);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00003E98 File Offset: 0x00002098
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

		// Token: 0x060001A8 RID: 424 RVA: 0x00003F0F File Offset: 0x0000210F
		private static Delegate GetSetGroupVisible_IZHandler()
		{
			if (ISupportMenuInvoker.cb_setGroupVisible_IZ == null)
			{
				ISupportMenuInvoker.cb_setGroupVisible_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(ISupportMenuInvoker.n_SetGroupVisible_IZ));
			}
			return ISupportMenuInvoker.cb_setGroupVisible_IZ;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00003F33 File Offset: 0x00002133
		private static void n_SetGroupVisible_IZ(IntPtr jnienv, IntPtr native__this, int group, bool visible)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupVisible(group, visible);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00003F44 File Offset: 0x00002144
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

		// Token: 0x060001AB RID: 427 RVA: 0x00003FBB File Offset: 0x000021BB
		private static Delegate GetSetQwertyMode_ZHandler()
		{
			if (ISupportMenuInvoker.cb_setQwertyMode_Z == null)
			{
				ISupportMenuInvoker.cb_setQwertyMode_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ISupportMenuInvoker.n_SetQwertyMode_Z));
			}
			return ISupportMenuInvoker.cb_setQwertyMode_Z;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00003FDF File Offset: 0x000021DF
		private static void n_SetQwertyMode_Z(IntPtr jnienv, IntPtr native__this, bool isQwerty)
		{
			Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetQwertyMode(isQwerty);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00003FF0 File Offset: 0x000021F0
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

		// Token: 0x060001AE RID: 430 RVA: 0x00004054 File Offset: 0x00002254
		private static Delegate GetSizeHandler()
		{
			if (ISupportMenuInvoker.cb_size == null)
			{
				ISupportMenuInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISupportMenuInvoker.n_Size));
			}
			return ISupportMenuInvoker.cb_size;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00004078 File Offset: 0x00002278
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00004087 File Offset: 0x00002287
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x04000010 RID: 16
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/internal/view/SupportMenu", typeof(ISupportMenuInvoker));

		// Token: 0x04000011 RID: 17
		private IntPtr class_ref;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_setGroupDividerEnabled_Z;

		// Token: 0x04000013 RID: 19
		private IntPtr id_setGroupDividerEnabled_Z;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_hasVisibleItems;

		// Token: 0x04000015 RID: 21
		private IntPtr id_hasVisibleItems;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_add_I;

		// Token: 0x04000017 RID: 23
		private IntPtr id_add_I;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_add_IIII;

		// Token: 0x04000019 RID: 25
		private IntPtr id_add_IIII;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_add_IIILjava_lang_CharSequence_;

		// Token: 0x0400001B RID: 27
		private IntPtr id_add_IIILjava_lang_CharSequence_;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_add_Ljava_lang_CharSequence_;

		// Token: 0x0400001D RID: 29
		private IntPtr id_add_Ljava_lang_CharSequence_;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;

		// Token: 0x0400001F RID: 31
		private IntPtr id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_addSubMenu_I;

		// Token: 0x04000021 RID: 33
		private IntPtr id_addSubMenu_I;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_addSubMenu_IIII;

		// Token: 0x04000023 RID: 35
		private IntPtr id_addSubMenu_IIII;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_addSubMenu_IIILjava_lang_CharSequence_;

		// Token: 0x04000025 RID: 37
		private IntPtr id_addSubMenu_IIILjava_lang_CharSequence_;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_addSubMenu_Ljava_lang_CharSequence_;

		// Token: 0x04000027 RID: 39
		private IntPtr id_addSubMenu_Ljava_lang_CharSequence_;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_clear;

		// Token: 0x04000029 RID: 41
		private IntPtr id_clear;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_close;

		// Token: 0x0400002B RID: 43
		private IntPtr id_close;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_findItem_I;

		// Token: 0x0400002D RID: 45
		private IntPtr id_findItem_I;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_getItem_I;

		// Token: 0x0400002F RID: 47
		private IntPtr id_getItem_I;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_isShortcutKey_ILandroid_view_KeyEvent_;

		// Token: 0x04000031 RID: 49
		private IntPtr id_isShortcutKey_ILandroid_view_KeyEvent_;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_performIdentifierAction_II;

		// Token: 0x04000033 RID: 51
		private IntPtr id_performIdentifierAction_II;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_performShortcut_ILandroid_view_KeyEvent_I;

		// Token: 0x04000035 RID: 53
		private IntPtr id_performShortcut_ILandroid_view_KeyEvent_I;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_removeGroup_I;

		// Token: 0x04000037 RID: 55
		private IntPtr id_removeGroup_I;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_removeItem_I;

		// Token: 0x04000039 RID: 57
		private IntPtr id_removeItem_I;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_setGroupCheckable_IZZ;

		// Token: 0x0400003B RID: 59
		private IntPtr id_setGroupCheckable_IZZ;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_setGroupEnabled_IZ;

		// Token: 0x0400003D RID: 61
		private IntPtr id_setGroupEnabled_IZ;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_setGroupVisible_IZ;

		// Token: 0x0400003F RID: 63
		private IntPtr id_setGroupVisible_IZ;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_setQwertyMode_Z;

		// Token: 0x04000041 RID: 65
		private IntPtr id_setQwertyMode_Z;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_size;

		// Token: 0x04000043 RID: 67
		private IntPtr id_size;
	}
}
