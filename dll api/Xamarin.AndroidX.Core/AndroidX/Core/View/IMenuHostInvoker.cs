using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000A3 RID: 163
	[Register("androidx/core/view/MenuHost", DoNotGenerateAcw = true)]
	internal class IMenuHostInvoker : Java.Lang.Object, IMenuHost, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0001A0B8 File Offset: 0x000182B8
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuHostInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0001A0DC File Offset: 0x000182DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuHostInvoker._members;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0001A0E3 File Offset: 0x000182E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0001A0EB File Offset: 0x000182EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuHostInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0001A0F7 File Offset: 0x000182F7
		public static IMenuHost GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMenuHost>(handle, transfer);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0001A100 File Offset: 0x00018300
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuHostInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.MenuHost'.");
			}
			return handle;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0001A12B File Offset: 0x0001832B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0001A15C File Offset: 0x0001835C
		public IMenuHostInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuHostInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0001A194 File Offset: 0x00018394
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Handler()
		{
			if (IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_ == null)
			{
				IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMenuHostInvoker.n_AddMenuProvider_Landroidx_core_view_MenuProvider_));
			}
			return IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0001A1B8 File Offset: 0x000183B8
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuHost @object = Java.Lang.Object.GetObject<IMenuHost>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0001A1DC File Offset: 0x000183DC
		public unsafe void AddMenuProvider(IMenuProvider p0)
		{
			if (this.id_addMenuProvider_Landroidx_core_view_MenuProvider_ == IntPtr.Zero)
			{
				this.id_addMenuProvider_Landroidx_core_view_MenuProvider_ = JNIEnv.GetMethodID(this.class_ref, "addMenuProvider", "(Landroidx/core/view/MenuProvider;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addMenuProvider_Landroidx_core_view_MenuProvider_, ptr);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0001A254 File Offset: 0x00018454
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Handler()
		{
			if (IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_ == null)
			{
				IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMenuHostInvoker.n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_));
			}
			return IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0001A278 File Offset: 0x00018478
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMenuHost @object = Java.Lang.Object.GetObject<IMenuHost>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_p0, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object3 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2, object3);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0001A2A4 File Offset: 0x000184A4
		public unsafe void AddMenuProvider(IMenuProvider p0, ILifecycleOwner p1)
		{
			if (this.id_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_ == IntPtr.Zero)
			{
				this.id_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_ = JNIEnv.GetMethodID(this.class_ref, "addMenuProvider", "(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_, ptr);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0001A343 File Offset: 0x00018543
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_Handler()
		{
			if (IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_ == null)
			{
				IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMenuHostInvoker.n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_));
			}
			return IMenuHostInvoker.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0001A368 File Offset: 0x00018568
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMenuHost @object = Java.Lang.Object.GetObject<IMenuHost>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_p0, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object3 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_p1, JniHandleOwnership.DoNotTransfer);
			Lifecycle.State object4 = Java.Lang.Object.GetObject<Lifecycle.State>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2, object3, object4);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0001A3A0 File Offset: 0x000185A0
		public unsafe void AddMenuProvider(IMenuProvider p0, ILifecycleOwner p1, Lifecycle.State p2)
		{
			if (this.id_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_ == IntPtr.Zero)
			{
				this.id_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_ = JNIEnv.GetMethodID(this.class_ref, "addMenuProvider", "(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Lifecycle$State;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_, ptr);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0001A464 File Offset: 0x00018664
		private static Delegate GetInvalidateMenuHandler()
		{
			if (IMenuHostInvoker.cb_invalidateMenu == null)
			{
				IMenuHostInvoker.cb_invalidateMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMenuHostInvoker.n_InvalidateMenu));
			}
			return IMenuHostInvoker.cb_invalidateMenu;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0001A488 File Offset: 0x00018688
		private static void n_InvalidateMenu(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMenuHost>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvalidateMenu();
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0001A497 File Offset: 0x00018697
		public void InvalidateMenu()
		{
			if (this.id_invalidateMenu == IntPtr.Zero)
			{
				this.id_invalidateMenu = JNIEnv.GetMethodID(this.class_ref, "invalidateMenu", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_invalidateMenu);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0001A4D7 File Offset: 0x000186D7
		private static Delegate GetRemoveMenuProvider_Landroidx_core_view_MenuProvider_Handler()
		{
			if (IMenuHostInvoker.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_ == null)
			{
				IMenuHostInvoker.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMenuHostInvoker.n_RemoveMenuProvider_Landroidx_core_view_MenuProvider_));
			}
			return IMenuHostInvoker.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0001A4FC File Offset: 0x000186FC
		private static void n_RemoveMenuProvider_Landroidx_core_view_MenuProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuHost @object = Java.Lang.Object.GetObject<IMenuHost>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveMenuProvider(object2);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0001A520 File Offset: 0x00018720
		public unsafe void RemoveMenuProvider(IMenuProvider p0)
		{
			if (this.id_removeMenuProvider_Landroidx_core_view_MenuProvider_ == IntPtr.Zero)
			{
				this.id_removeMenuProvider_Landroidx_core_view_MenuProvider_ = JNIEnv.GetMethodID(this.class_ref, "removeMenuProvider", "(Landroidx/core/view/MenuProvider;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeMenuProvider_Landroidx_core_view_MenuProvider_, ptr);
		}

		// Token: 0x0400024C RID: 588
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/MenuHost", typeof(IMenuHostInvoker));

		// Token: 0x0400024D RID: 589
		private IntPtr class_ref;

		// Token: 0x0400024E RID: 590
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_;

		// Token: 0x0400024F RID: 591
		private IntPtr id_addMenuProvider_Landroidx_core_view_MenuProvider_;

		// Token: 0x04000250 RID: 592
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_;

		// Token: 0x04000251 RID: 593
		private IntPtr id_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_;

		// Token: 0x04000252 RID: 594
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_;

		// Token: 0x04000253 RID: 595
		private IntPtr id_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_;

		// Token: 0x04000254 RID: 596
		private static Delegate cb_invalidateMenu;

		// Token: 0x04000255 RID: 597
		private IntPtr id_invalidateMenu;

		// Token: 0x04000256 RID: 598
		private static Delegate cb_removeMenuProvider_Landroidx_core_view_MenuProvider_;

		// Token: 0x04000257 RID: 599
		private IntPtr id_removeMenuProvider_Landroidx_core_view_MenuProvider_;
	}
}
