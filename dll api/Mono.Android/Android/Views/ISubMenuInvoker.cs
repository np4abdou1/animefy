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
	// Token: 0x02000126 RID: 294
	[Register("android/view/SubMenu", DoNotGenerateAcw = true)]
	internal class ISubMenuInvoker : Java.Lang.Object, ISubMenu, IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00015174 File Offset: 0x00013374
		private static IntPtr java_class_ref
		{
			get
			{
				return ISubMenuInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00015198 File Offset: 0x00013398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISubMenuInvoker._members;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0001519F File Offset: 0x0001339F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000151A7 File Offset: 0x000133A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISubMenuInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000151B3 File Offset: 0x000133B3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISubMenuInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.SubMenu'.");
			}
			return handle;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000151DE File Offset: 0x000133DE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00015210 File Offset: 0x00013410
		public ISubMenuInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISubMenuInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00015248 File Offset: 0x00013448
		private static Delegate GetGetItemHandler()
		{
			if (ISubMenuInvoker.cb_getItem == null)
			{
				ISubMenuInvoker.cb_getItem = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubMenuInvoker.n_GetItem));
			}
			return ISubMenuInvoker.cb_getItem;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0001526C File Offset: 0x0001346C
		private static IntPtr n_GetItem(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Item);
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00015280 File Offset: 0x00013480
		public IMenuItem Item
		{
			get
			{
				if (this.id_getItem == IntPtr.Zero)
				{
					this.id_getItem = JNIEnv.GetMethodID(this.class_ref, "getItem", "()Landroid/view/MenuItem;");
				}
				return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_getItem), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000152D1 File Offset: 0x000134D1
		private static Delegate GetClearHeaderHandler()
		{
			if (ISubMenuInvoker.cb_clearHeader == null)
			{
				ISubMenuInvoker.cb_clearHeader = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ISubMenuInvoker.n_ClearHeader));
			}
			return ISubMenuInvoker.cb_clearHeader;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000152F5 File Offset: 0x000134F5
		private static void n_ClearHeader(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearHeader();
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00015304 File Offset: 0x00013504
		public void ClearHeader()
		{
			if (this.id_clearHeader == IntPtr.Zero)
			{
				this.id_clearHeader = JNIEnv.GetMethodID(this.class_ref, "clearHeader", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearHeader);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00015344 File Offset: 0x00013544
		private static Delegate GetSetHeaderIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ISubMenuInvoker.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				ISubMenuInvoker.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISubMenuInvoker.n_SetHeaderIcon_Landroid_graphics_drawable_Drawable_));
			}
			return ISubMenuInvoker.cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00015368 File Offset: 0x00013568
		private static IntPtr n_SetHeaderIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			ISubMenu @object = Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderIcon(object2));
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00015390 File Offset: 0x00013590
		public unsafe ISubMenu SetHeaderIcon(Drawable icon)
		{
			if (this.id_setHeaderIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setHeaderIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((icon == null) ? IntPtr.Zero : icon.Handle);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderIcon_Landroid_graphics_drawable_Drawable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00015409 File Offset: 0x00013609
		private static Delegate GetSetHeaderIcon_IHandler()
		{
			if (ISubMenuInvoker.cb_setHeaderIcon_I == null)
			{
				ISubMenuInvoker.cb_setHeaderIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISubMenuInvoker.n_SetHeaderIcon_I));
			}
			return ISubMenuInvoker.cb_setHeaderIcon_I;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0001542D File Offset: 0x0001362D
		private static IntPtr n_SetHeaderIcon_I(IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHeaderIcon(iconRes));
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00015444 File Offset: 0x00013644
		public unsafe ISubMenu SetHeaderIcon(int iconRes)
		{
			if (this.id_setHeaderIcon_I == IntPtr.Zero)
			{
				this.id_setHeaderIcon_I = JNIEnv.GetMethodID(this.class_ref, "setHeaderIcon", "(I)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(iconRes);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderIcon_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000154AE File Offset: 0x000136AE
		private static Delegate GetSetHeaderTitle_IHandler()
		{
			if (ISubMenuInvoker.cb_setHeaderTitle_I == null)
			{
				ISubMenuInvoker.cb_setHeaderTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISubMenuInvoker.n_SetHeaderTitle_I));
			}
			return ISubMenuInvoker.cb_setHeaderTitle_I;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x000154D2 File Offset: 0x000136D2
		private static IntPtr n_SetHeaderTitle_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHeaderTitle(titleRes));
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000154E8 File Offset: 0x000136E8
		public unsafe ISubMenu SetHeaderTitle(int titleRes)
		{
			if (this.id_setHeaderTitle_I == IntPtr.Zero)
			{
				this.id_setHeaderTitle_I = JNIEnv.GetMethodID(this.class_ref, "setHeaderTitle", "(I)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(titleRes);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderTitle_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00015552 File Offset: 0x00013752
		private static Delegate GetSetHeaderTitle_Ljava_lang_CharSequence_Handler()
		{
			if (ISubMenuInvoker.cb_setHeaderTitle_Ljava_lang_CharSequence_ == null)
			{
				ISubMenuInvoker.cb_setHeaderTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISubMenuInvoker.n_SetHeaderTitle_Ljava_lang_CharSequence_));
			}
			return ISubMenuInvoker.cb_setHeaderTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00015578 File Offset: 0x00013778
		private static IntPtr n_SetHeaderTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			ISubMenu @object = Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderTitle(object2));
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000155A0 File Offset: 0x000137A0
		public unsafe ISubMenu SetHeaderTitle(ICharSequence title)
		{
			if (this.id_setHeaderTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setHeaderTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISubMenu @object = Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderTitle_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00015617 File Offset: 0x00013817
		private static Delegate GetSetHeaderView_Landroid_view_View_Handler()
		{
			if (ISubMenuInvoker.cb_setHeaderView_Landroid_view_View_ == null)
			{
				ISubMenuInvoker.cb_setHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISubMenuInvoker.n_SetHeaderView_Landroid_view_View_));
			}
			return ISubMenuInvoker.cb_setHeaderView_Landroid_view_View_;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0001563C File Offset: 0x0001383C
		private static IntPtr n_SetHeaderView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			ISubMenu @object = Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderView(object2));
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00015664 File Offset: 0x00013864
		public unsafe ISubMenu SetHeaderView(View view)
		{
			if (this.id_setHeaderView_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_setHeaderView_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setHeaderView_Landroid_view_View_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000156DD File Offset: 0x000138DD
		private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ISubMenuInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				ISubMenuInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISubMenuInvoker.n_SetIcon_Landroid_graphics_drawable_Drawable_));
			}
			return ISubMenuInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00015704 File Offset: 0x00013904
		private static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			ISubMenu @object = Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001572C File Offset: 0x0001392C
		public unsafe ISubMenu SetIcon(Drawable icon)
		{
			if (this.id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((icon == null) ? IntPtr.Zero : icon.Handle);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIcon_Landroid_graphics_drawable_Drawable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000157A5 File Offset: 0x000139A5
		private static Delegate GetSetIcon_IHandler()
		{
			if (ISubMenuInvoker.cb_setIcon_I == null)
			{
				ISubMenuInvoker.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISubMenuInvoker.n_SetIcon_I));
			}
			return ISubMenuInvoker.cb_setIcon_I;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000157C9 File Offset: 0x000139C9
		private static IntPtr n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(iconRes));
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000157E0 File Offset: 0x000139E0
		public unsafe ISubMenu SetIcon(int iconRes)
		{
			if (this.id_setIcon_I == IntPtr.Zero)
			{
				this.id_setIcon_I = JNIEnv.GetMethodID(this.class_ref, "setIcon", "(I)Landroid/view/SubMenu;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(iconRes);
			return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIcon_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0001584A File Offset: 0x00013A4A
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

		// Token: 0x06000906 RID: 2310 RVA: 0x0001588C File Offset: 0x00013A8C
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

		// Token: 0x06000907 RID: 2311 RVA: 0x000158F8 File Offset: 0x00013AF8
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

		// Token: 0x06000908 RID: 2312 RVA: 0x000159A4 File Offset: 0x00013BA4
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

		// Token: 0x06000909 RID: 2313 RVA: 0x00015A5C File Offset: 0x00013C5C
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

		// Token: 0x0600090A RID: 2314 RVA: 0x00015AD4 File Offset: 0x00013CD4
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

		// Token: 0x0600090B RID: 2315 RVA: 0x00015C28 File Offset: 0x00013E28
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

		// Token: 0x0600090C RID: 2316 RVA: 0x00015C94 File Offset: 0x00013E94
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

		// Token: 0x0600090D RID: 2317 RVA: 0x00015D40 File Offset: 0x00013F40
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

		// Token: 0x0600090E RID: 2318 RVA: 0x00015DF8 File Offset: 0x00013FF8
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

		// Token: 0x0600090F RID: 2319 RVA: 0x00015E6F File Offset: 0x0001406F
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00015EAF File Offset: 0x000140AF
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00015EF0 File Offset: 0x000140F0
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

		// Token: 0x06000912 RID: 2322 RVA: 0x00015F5C File Offset: 0x0001415C
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

		// Token: 0x06000913 RID: 2323 RVA: 0x00015FC8 File Offset: 0x000141C8
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

		// Token: 0x06000914 RID: 2324 RVA: 0x00016050 File Offset: 0x00014250
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

		// Token: 0x06000915 RID: 2325 RVA: 0x000160C8 File Offset: 0x000142C8
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

		// Token: 0x06000916 RID: 2326 RVA: 0x00016164 File Offset: 0x00014364
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

		// Token: 0x06000917 RID: 2327 RVA: 0x000161C8 File Offset: 0x000143C8
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

		// Token: 0x06000918 RID: 2328 RVA: 0x0001622C File Offset: 0x0001442C
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

		// Token: 0x06000919 RID: 2329 RVA: 0x000162BC File Offset: 0x000144BC
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

		// Token: 0x0600091A RID: 2330 RVA: 0x00016334 File Offset: 0x00014534
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

		// Token: 0x0600091B RID: 2331 RVA: 0x000163AC File Offset: 0x000145AC
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

		// Token: 0x0600091C RID: 2332 RVA: 0x00016410 File Offset: 0x00014610
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x040002A8 RID: 680
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/SubMenu", typeof(ISubMenuInvoker));

		// Token: 0x040002A9 RID: 681
		private IntPtr class_ref;

		// Token: 0x040002AA RID: 682
		private static Delegate cb_getItem;

		// Token: 0x040002AB RID: 683
		private IntPtr id_getItem;

		// Token: 0x040002AC RID: 684
		private static Delegate cb_clearHeader;

		// Token: 0x040002AD RID: 685
		private IntPtr id_clearHeader;

		// Token: 0x040002AE RID: 686
		private static Delegate cb_setHeaderIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040002AF RID: 687
		private IntPtr id_setHeaderIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040002B0 RID: 688
		private static Delegate cb_setHeaderIcon_I;

		// Token: 0x040002B1 RID: 689
		private IntPtr id_setHeaderIcon_I;

		// Token: 0x040002B2 RID: 690
		private static Delegate cb_setHeaderTitle_I;

		// Token: 0x040002B3 RID: 691
		private IntPtr id_setHeaderTitle_I;

		// Token: 0x040002B4 RID: 692
		private static Delegate cb_setHeaderTitle_Ljava_lang_CharSequence_;

		// Token: 0x040002B5 RID: 693
		private IntPtr id_setHeaderTitle_Ljava_lang_CharSequence_;

		// Token: 0x040002B6 RID: 694
		private static Delegate cb_setHeaderView_Landroid_view_View_;

		// Token: 0x040002B7 RID: 695
		private IntPtr id_setHeaderView_Landroid_view_View_;

		// Token: 0x040002B8 RID: 696
		private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040002B9 RID: 697
		private IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040002BA RID: 698
		private static Delegate cb_setIcon_I;

		// Token: 0x040002BB RID: 699
		private IntPtr id_setIcon_I;

		// Token: 0x040002BC RID: 700
		private IntPtr id_hasVisibleItems;

		// Token: 0x040002BD RID: 701
		private IntPtr id_add_I;

		// Token: 0x040002BE RID: 702
		private IntPtr id_add_IIII;

		// Token: 0x040002BF RID: 703
		private IntPtr id_add_IIILjava_lang_CharSequence_;

		// Token: 0x040002C0 RID: 704
		private IntPtr id_add_Ljava_lang_CharSequence_;

		// Token: 0x040002C1 RID: 705
		private IntPtr id_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;

		// Token: 0x040002C2 RID: 706
		private IntPtr id_addSubMenu_I;

		// Token: 0x040002C3 RID: 707
		private IntPtr id_addSubMenu_IIII;

		// Token: 0x040002C4 RID: 708
		private IntPtr id_addSubMenu_IIILjava_lang_CharSequence_;

		// Token: 0x040002C5 RID: 709
		private IntPtr id_addSubMenu_Ljava_lang_CharSequence_;

		// Token: 0x040002C6 RID: 710
		private IntPtr id_clear;

		// Token: 0x040002C7 RID: 711
		private IntPtr id_close;

		// Token: 0x040002C8 RID: 712
		private IntPtr id_findItem_I;

		// Token: 0x040002C9 RID: 713
		private IntPtr id_getItem_I;

		// Token: 0x040002CA RID: 714
		private IntPtr id_isShortcutKey_ILandroid_view_KeyEvent_;

		// Token: 0x040002CB RID: 715
		private IntPtr id_performIdentifierAction_II;

		// Token: 0x040002CC RID: 716
		private IntPtr id_performShortcut_ILandroid_view_KeyEvent_I;

		// Token: 0x040002CD RID: 717
		private IntPtr id_removeGroup_I;

		// Token: 0x040002CE RID: 718
		private IntPtr id_removeItem_I;

		// Token: 0x040002CF RID: 719
		private IntPtr id_setGroupCheckable_IZZ;

		// Token: 0x040002D0 RID: 720
		private IntPtr id_setGroupEnabled_IZ;

		// Token: 0x040002D1 RID: 721
		private IntPtr id_setGroupVisible_IZ;

		// Token: 0x040002D2 RID: 722
		private IntPtr id_setQwertyMode_Z;

		// Token: 0x040002D3 RID: 723
		private IntPtr id_size;
	}
}
