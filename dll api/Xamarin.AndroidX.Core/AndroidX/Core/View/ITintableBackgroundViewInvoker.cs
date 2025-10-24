using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000B4 RID: 180
	[Register("androidx/core/view/TintableBackgroundView", DoNotGenerateAcw = true)]
	internal class ITintableBackgroundViewInvoker : Java.Lang.Object, ITintableBackgroundView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0001F564 File Offset: 0x0001D764
		private static IntPtr java_class_ref
		{
			get
			{
				return ITintableBackgroundViewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0001F588 File Offset: 0x0001D788
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITintableBackgroundViewInvoker._members;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0001F58F File Offset: 0x0001D78F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0001F597 File Offset: 0x0001D797
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITintableBackgroundViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0001F5A3 File Offset: 0x0001D7A3
		public static ITintableBackgroundView GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITintableBackgroundView>(handle, transfer);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0001F5AC File Offset: 0x0001D7AC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITintableBackgroundViewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.TintableBackgroundView'.");
			}
			return handle;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0001F5D7 File Offset: 0x0001D7D7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0001F608 File Offset: 0x0001D808
		public ITintableBackgroundViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITintableBackgroundViewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0001F640 File Offset: 0x0001D840
		private static Delegate GetGetSupportBackgroundTintListHandler()
		{
			if (ITintableBackgroundViewInvoker.cb_getSupportBackgroundTintList == null)
			{
				ITintableBackgroundViewInvoker.cb_getSupportBackgroundTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITintableBackgroundViewInvoker.n_GetSupportBackgroundTintList));
			}
			return ITintableBackgroundViewInvoker.cb_getSupportBackgroundTintList;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001F664 File Offset: 0x0001D864
		private static IntPtr n_GetSupportBackgroundTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITintableBackgroundView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportBackgroundTintList);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0001F678 File Offset: 0x0001D878
		private static Delegate GetSetSupportBackgroundTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (ITintableBackgroundViewInvoker.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_ == null)
			{
				ITintableBackgroundViewInvoker.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITintableBackgroundViewInvoker.n_SetSupportBackgroundTintList_Landroid_content_res_ColorStateList_));
			}
			return ITintableBackgroundViewInvoker.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0001F69C File Offset: 0x0001D89C
		private static void n_SetSupportBackgroundTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			ITintableBackgroundView @object = Java.Lang.Object.GetObject<ITintableBackgroundView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.SupportBackgroundTintList = object2;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0001F6C0 File Offset: 0x0001D8C0
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x0001F714 File Offset: 0x0001D914
		public unsafe ColorStateList SupportBackgroundTintList
		{
			get
			{
				if (this.id_getSupportBackgroundTintList == IntPtr.Zero)
				{
					this.id_getSupportBackgroundTintList = JNIEnv.GetMethodID(this.class_ref, "getSupportBackgroundTintList", "()Landroid/content/res/ColorStateList;");
				}
				return Java.Lang.Object.GetObject<ColorStateList>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportBackgroundTintList), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				{
					this.id_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID(this.class_ref, "setSupportBackgroundTintList", "(Landroid/content/res/ColorStateList;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_, ptr);
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0001F787 File Offset: 0x0001D987
		private static Delegate GetGetSupportBackgroundTintModeHandler()
		{
			if (ITintableBackgroundViewInvoker.cb_getSupportBackgroundTintMode == null)
			{
				ITintableBackgroundViewInvoker.cb_getSupportBackgroundTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITintableBackgroundViewInvoker.n_GetSupportBackgroundTintMode));
			}
			return ITintableBackgroundViewInvoker.cb_getSupportBackgroundTintMode;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0001F7AB File Offset: 0x0001D9AB
		private static IntPtr n_GetSupportBackgroundTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITintableBackgroundView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportBackgroundTintMode);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0001F7BF File Offset: 0x0001D9BF
		private static Delegate GetSetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (ITintableBackgroundViewInvoker.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				ITintableBackgroundViewInvoker.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITintableBackgroundViewInvoker.n_SetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return ITintableBackgroundViewInvoker.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		private static void n_SetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			ITintableBackgroundView @object = Java.Lang.Object.GetObject<ITintableBackgroundView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportBackgroundTintMode = object2;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0001F808 File Offset: 0x0001DA08
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0001F85C File Offset: 0x0001DA5C
		public unsafe PorterDuff.Mode SupportBackgroundTintMode
		{
			get
			{
				if (this.id_getSupportBackgroundTintMode == IntPtr.Zero)
				{
					this.id_getSupportBackgroundTintMode = JNIEnv.GetMethodID(this.class_ref, "getSupportBackgroundTintMode", "()Landroid/graphics/PorterDuff$Mode;");
				}
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportBackgroundTintMode), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ == IntPtr.Zero)
				{
					this.id_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ = JNIEnv.GetMethodID(this.class_ref, "setSupportBackgroundTintMode", "(Landroid/graphics/PorterDuff$Mode;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_, ptr);
			}
		}

		// Token: 0x0400030D RID: 781
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/TintableBackgroundView", typeof(ITintableBackgroundViewInvoker));

		// Token: 0x0400030E RID: 782
		private IntPtr class_ref;

		// Token: 0x0400030F RID: 783
		private static Delegate cb_getSupportBackgroundTintList;

		// Token: 0x04000310 RID: 784
		private static Delegate cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000311 RID: 785
		private IntPtr id_getSupportBackgroundTintList;

		// Token: 0x04000312 RID: 786
		private IntPtr id_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000313 RID: 787
		private static Delegate cb_getSupportBackgroundTintMode;

		// Token: 0x04000314 RID: 788
		private static Delegate cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x04000315 RID: 789
		private IntPtr id_getSupportBackgroundTintMode;

		// Token: 0x04000316 RID: 790
		private IntPtr id_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;
	}
}
