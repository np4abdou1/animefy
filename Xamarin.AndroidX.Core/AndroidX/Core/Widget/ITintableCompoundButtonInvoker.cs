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
	// Token: 0x0200008A RID: 138
	[Register("androidx/core/widget/TintableCompoundButton", DoNotGenerateAcw = true)]
	internal class ITintableCompoundButtonInvoker : Java.Lang.Object, ITintableCompoundButton, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00017A30 File Offset: 0x00015C30
		private static IntPtr java_class_ref
		{
			get
			{
				return ITintableCompoundButtonInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00017A54 File Offset: 0x00015C54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITintableCompoundButtonInvoker._members;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00017A5B File Offset: 0x00015C5B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00017A63 File Offset: 0x00015C63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITintableCompoundButtonInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00017A6F File Offset: 0x00015C6F
		public static ITintableCompoundButton GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITintableCompoundButton>(handle, transfer);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00017A78 File Offset: 0x00015C78
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITintableCompoundButtonInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.widget.TintableCompoundButton'.");
			}
			return handle;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00017AA3 File Offset: 0x00015CA3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00017AD4 File Offset: 0x00015CD4
		public ITintableCompoundButtonInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITintableCompoundButtonInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00017B0C File Offset: 0x00015D0C
		private static Delegate GetGetSupportButtonTintListHandler()
		{
			if (ITintableCompoundButtonInvoker.cb_getSupportButtonTintList == null)
			{
				ITintableCompoundButtonInvoker.cb_getSupportButtonTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITintableCompoundButtonInvoker.n_GetSupportButtonTintList));
			}
			return ITintableCompoundButtonInvoker.cb_getSupportButtonTintList;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00017B30 File Offset: 0x00015D30
		private static IntPtr n_GetSupportButtonTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITintableCompoundButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportButtonTintList);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00017B44 File Offset: 0x00015D44
		private static Delegate GetSetSupportButtonTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (ITintableCompoundButtonInvoker.cb_setSupportButtonTintList_Landroid_content_res_ColorStateList_ == null)
			{
				ITintableCompoundButtonInvoker.cb_setSupportButtonTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITintableCompoundButtonInvoker.n_SetSupportButtonTintList_Landroid_content_res_ColorStateList_));
			}
			return ITintableCompoundButtonInvoker.cb_setSupportButtonTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00017B68 File Offset: 0x00015D68
		private static void n_SetSupportButtonTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			ITintableCompoundButton @object = Java.Lang.Object.GetObject<ITintableCompoundButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.SupportButtonTintList = object2;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00017B8C File Offset: 0x00015D8C
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00017BE0 File Offset: 0x00015DE0
		public unsafe ColorStateList SupportButtonTintList
		{
			get
			{
				if (this.id_getSupportButtonTintList == IntPtr.Zero)
				{
					this.id_getSupportButtonTintList = JNIEnv.GetMethodID(this.class_ref, "getSupportButtonTintList", "()Landroid/content/res/ColorStateList;");
				}
				return Java.Lang.Object.GetObject<ColorStateList>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportButtonTintList), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSupportButtonTintList_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				{
					this.id_setSupportButtonTintList_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID(this.class_ref, "setSupportButtonTintList", "(Landroid/content/res/ColorStateList;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSupportButtonTintList_Landroid_content_res_ColorStateList_, ptr);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00017C53 File Offset: 0x00015E53
		private static Delegate GetGetSupportButtonTintModeHandler()
		{
			if (ITintableCompoundButtonInvoker.cb_getSupportButtonTintMode == null)
			{
				ITintableCompoundButtonInvoker.cb_getSupportButtonTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITintableCompoundButtonInvoker.n_GetSupportButtonTintMode));
			}
			return ITintableCompoundButtonInvoker.cb_getSupportButtonTintMode;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00017C77 File Offset: 0x00015E77
		private static IntPtr n_GetSupportButtonTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITintableCompoundButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportButtonTintMode);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00017C8B File Offset: 0x00015E8B
		private static Delegate GetSetSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (ITintableCompoundButtonInvoker.cb_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				ITintableCompoundButtonInvoker.cb_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITintableCompoundButtonInvoker.n_SetSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return ITintableCompoundButtonInvoker.cb_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00017CB0 File Offset: 0x00015EB0
		private static void n_SetSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			ITintableCompoundButton @object = Java.Lang.Object.GetObject<ITintableCompoundButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportButtonTintMode = object2;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00017CD4 File Offset: 0x00015ED4
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00017D28 File Offset: 0x00015F28
		public unsafe PorterDuff.Mode SupportButtonTintMode
		{
			get
			{
				if (this.id_getSupportButtonTintMode == IntPtr.Zero)
				{
					this.id_getSupportButtonTintMode = JNIEnv.GetMethodID(this.class_ref, "getSupportButtonTintMode", "()Landroid/graphics/PorterDuff$Mode;");
				}
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportButtonTintMode), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_ == IntPtr.Zero)
				{
					this.id_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_ = JNIEnv.GetMethodID(this.class_ref, "setSupportButtonTintMode", "(Landroid/graphics/PorterDuff$Mode;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_, ptr);
			}
		}

		// Token: 0x040001FB RID: 507
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/widget/TintableCompoundButton", typeof(ITintableCompoundButtonInvoker));

		// Token: 0x040001FC RID: 508
		private IntPtr class_ref;

		// Token: 0x040001FD RID: 509
		private static Delegate cb_getSupportButtonTintList;

		// Token: 0x040001FE RID: 510
		private static Delegate cb_setSupportButtonTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040001FF RID: 511
		private IntPtr id_getSupportButtonTintList;

		// Token: 0x04000200 RID: 512
		private IntPtr id_setSupportButtonTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000201 RID: 513
		private static Delegate cb_getSupportButtonTintMode;

		// Token: 0x04000202 RID: 514
		private static Delegate cb_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x04000203 RID: 515
		private IntPtr id_getSupportButtonTintMode;

		// Token: 0x04000204 RID: 516
		private IntPtr id_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_;
	}
}
