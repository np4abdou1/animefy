using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Module
{
	// Token: 0x02000068 RID: 104
	[Register("com/bumptech/glide/module/AppliesOptions", DoNotGenerateAcw = true)]
	internal class IAppliesOptionsInvoker : Java.Lang.Object, IAppliesOptions, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000FC64 File Offset: 0x0000DE64
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppliesOptionsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000FC88 File Offset: 0x0000DE88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppliesOptionsInvoker._members;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0000FC8F File Offset: 0x0000DE8F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0000FC97 File Offset: 0x0000DE97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppliesOptionsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000FCA3 File Offset: 0x0000DEA3
		public static IAppliesOptions GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppliesOptions>(handle, transfer);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000FCAC File Offset: 0x0000DEAC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppliesOptionsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.module.AppliesOptions'.");
			}
			return handle;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000FCD7 File Offset: 0x0000DED7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000FD08 File Offset: 0x0000DF08
		public IAppliesOptionsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppliesOptionsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000FD40 File Offset: 0x0000DF40
		private static Delegate GetApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_Handler()
		{
			if (IAppliesOptionsInvoker.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ == null)
			{
				IAppliesOptionsInvoker.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppliesOptionsInvoker.n_ApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_));
			}
			return IAppliesOptionsInvoker.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000FD64 File Offset: 0x0000DF64
		private static void n_ApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppliesOptions @object = Java.Lang.Object.GetObject<IAppliesOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			GlideBuilder object3 = Java.Lang.Object.GetObject<GlideBuilder>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ApplyOptions(object2, object3);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000FD90 File Offset: 0x0000DF90
		public unsafe void ApplyOptions(Context p0, GlideBuilder p1)
		{
			if (this.id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ == IntPtr.Zero)
			{
				this.id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ = JNIEnv.GetMethodID(this.class_ref, "applyOptions", "(Landroid/content/Context;Lcom/bumptech/glide/GlideBuilder;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_, ptr);
		}

		// Token: 0x040000F8 RID: 248
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/module/AppliesOptions", typeof(IAppliesOptionsInvoker));

		// Token: 0x040000F9 RID: 249
		private IntPtr class_ref;

		// Token: 0x040000FA RID: 250
		private static Delegate cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;

		// Token: 0x040000FB RID: 251
		private IntPtr id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;
	}
}
