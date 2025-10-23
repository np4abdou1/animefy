using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Widget
{
	// Token: 0x0200008E RID: 142
	[Register("androidx/core/widget/TintableImageSourceView", DoNotGenerateAcw = true)]
	internal class ITintableImageSourceViewInvoker : Java.Lang.Object, ITintableImageSourceView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00018140 File Offset: 0x00016340
		private static IntPtr java_class_ref
		{
			get
			{
				return ITintableImageSourceViewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00018164 File Offset: 0x00016364
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITintableImageSourceViewInvoker._members;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001816B File Offset: 0x0001636B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00018173 File Offset: 0x00016373
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITintableImageSourceViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0001817F File Offset: 0x0001637F
		public static ITintableImageSourceView GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITintableImageSourceView>(handle, transfer);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00018188 File Offset: 0x00016388
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITintableImageSourceViewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.widget.TintableImageSourceView'.");
			}
			return handle;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000181B3 File Offset: 0x000163B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000181E4 File Offset: 0x000163E4
		public ITintableImageSourceViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITintableImageSourceViewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0001821C File Offset: 0x0001641C
		private static Delegate GetGetSupportImageTintListHandler()
		{
			if (ITintableImageSourceViewInvoker.cb_getSupportImageTintList == null)
			{
				ITintableImageSourceViewInvoker.cb_getSupportImageTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITintableImageSourceViewInvoker.n_GetSupportImageTintList));
			}
			return ITintableImageSourceViewInvoker.cb_getSupportImageTintList;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00018240 File Offset: 0x00016440
		private static IntPtr n_GetSupportImageTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITintableImageSourceView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportImageTintList);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00018254 File Offset: 0x00016454
		private static Delegate GetSetSupportImageTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (ITintableImageSourceViewInvoker.cb_setSupportImageTintList_Landroid_content_res_ColorStateList_ == null)
			{
				ITintableImageSourceViewInvoker.cb_setSupportImageTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITintableImageSourceViewInvoker.n_SetSupportImageTintList_Landroid_content_res_ColorStateList_));
			}
			return ITintableImageSourceViewInvoker.cb_setSupportImageTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00018278 File Offset: 0x00016478
		private static void n_SetSupportImageTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			ITintableImageSourceView @object = Java.Lang.Object.GetObject<ITintableImageSourceView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.SupportImageTintList = object2;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0001829C File Offset: 0x0001649C
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x000182F0 File Offset: 0x000164F0
		public unsafe ColorStateList SupportImageTintList
		{
			get
			{
				if (this.id_getSupportImageTintList == IntPtr.Zero)
				{
					this.id_getSupportImageTintList = JNIEnv.GetMethodID(this.class_ref, "getSupportImageTintList", "()Landroid/content/res/ColorStateList;");
				}
				return Java.Lang.Object.GetObject<ColorStateList>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportImageTintList), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSupportImageTintList_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				{
					this.id_setSupportImageTintList_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID(this.class_ref, "setSupportImageTintList", "(Landroid/content/res/ColorStateList;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSupportImageTintList_Landroid_content_res_ColorStateList_, ptr);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00018363 File Offset: 0x00016563
		private static Delegate GetGetSupportImageTintModeHandler()
		{
			if (ITintableImageSourceViewInvoker.cb_getSupportImageTintMode == null)
			{
				ITintableImageSourceViewInvoker.cb_getSupportImageTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITintableImageSourceViewInvoker.n_GetSupportImageTintMode));
			}
			return ITintableImageSourceViewInvoker.cb_getSupportImageTintMode;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00018387 File Offset: 0x00016587
		private static IntPtr n_GetSupportImageTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITintableImageSourceView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportImageTintMode);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0001839B File Offset: 0x0001659B
		private static Delegate GetSetSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (ITintableImageSourceViewInvoker.cb_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				ITintableImageSourceViewInvoker.cb_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITintableImageSourceViewInvoker.n_SetSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return ITintableImageSourceViewInvoker.cb_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000183C0 File Offset: 0x000165C0
		private static void n_SetSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			ITintableImageSourceView @object = Java.Lang.Object.GetObject<ITintableImageSourceView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportImageTintMode = object2;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x000183E4 File Offset: 0x000165E4
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00018438 File Offset: 0x00016638
		public unsafe PorterDuff.Mode SupportImageTintMode
		{
			get
			{
				if (this.id_getSupportImageTintMode == IntPtr.Zero)
				{
					this.id_getSupportImageTintMode = JNIEnv.GetMethodID(this.class_ref, "getSupportImageTintMode", "()Landroid/graphics/PorterDuff$Mode;");
				}
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportImageTintMode), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_ == IntPtr.Zero)
				{
					this.id_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_ = JNIEnv.GetMethodID(this.class_ref, "setSupportImageTintMode", "(Landroid/graphics/PorterDuff$Mode;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_, ptr);
			}
		}

		// Token: 0x0400020F RID: 527
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/widget/TintableImageSourceView", typeof(ITintableImageSourceViewInvoker));

		// Token: 0x04000210 RID: 528
		private IntPtr class_ref;

		// Token: 0x04000211 RID: 529
		private static Delegate cb_getSupportImageTintList;

		// Token: 0x04000212 RID: 530
		private static Delegate cb_setSupportImageTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000213 RID: 531
		private IntPtr id_getSupportImageTintList;

		// Token: 0x04000214 RID: 532
		private IntPtr id_setSupportImageTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000215 RID: 533
		private static Delegate cb_getSupportImageTintMode;

		// Token: 0x04000216 RID: 534
		private static Delegate cb_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x04000217 RID: 535
		private IntPtr id_getSupportImageTintMode;

		// Token: 0x04000218 RID: 536
		private IntPtr id_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_;
	}
}
