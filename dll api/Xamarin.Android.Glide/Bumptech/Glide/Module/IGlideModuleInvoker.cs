using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Module
{
	// Token: 0x0200006A RID: 106
	[Register("com/bumptech/glide/module/GlideModule", DoNotGenerateAcw = true)]
	internal class IGlideModuleInvoker : Java.Lang.Object, IGlideModule, IAppliesOptions, IJavaObject, IDisposable, IJavaPeerable, IRegistersComponents
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0000FE40 File Offset: 0x0000E040
		private static IntPtr java_class_ref
		{
			get
			{
				return IGlideModuleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0000FE64 File Offset: 0x0000E064
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGlideModuleInvoker._members;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0000FE6B File Offset: 0x0000E06B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000FE73 File Offset: 0x0000E073
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGlideModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000FE7F File Offset: 0x0000E07F
		public static IGlideModule GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGlideModule>(handle, transfer);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000FE88 File Offset: 0x0000E088
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGlideModuleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.module.GlideModule'.");
			}
			return handle;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000FEB3 File Offset: 0x0000E0B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000FEE4 File Offset: 0x0000E0E4
		public IGlideModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGlideModuleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000FF1C File Offset: 0x0000E11C
		private static Delegate GetApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_Handler()
		{
			if (IGlideModuleInvoker.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ == null)
			{
				IGlideModuleInvoker.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IGlideModuleInvoker.n_ApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_));
			}
			return IGlideModuleInvoker.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000FF40 File Offset: 0x0000E140
		private static void n_ApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppliesOptions @object = Java.Lang.Object.GetObject<IGlideModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			GlideBuilder object3 = Java.Lang.Object.GetObject<GlideBuilder>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ApplyOptions(object2, object3);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000FF6C File Offset: 0x0000E16C
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

		// Token: 0x060004C2 RID: 1218 RVA: 0x00010001 File Offset: 0x0000E201
		private static Delegate GetRegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_Handler()
		{
			if (IGlideModuleInvoker.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_ == null)
			{
				IGlideModuleInvoker.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IGlideModuleInvoker.n_RegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_));
			}
			return IGlideModuleInvoker.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00010028 File Offset: 0x0000E228
		private static void n_RegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IRegistersComponents @object = Java.Lang.Object.GetObject<IGlideModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			Glide object3 = Java.Lang.Object.GetObject<Glide>(native_p1, JniHandleOwnership.DoNotTransfer);
			Registry object4 = Java.Lang.Object.GetObject<Registry>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.RegisterComponents(object2, object3, object4);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00010060 File Offset: 0x0000E260
		public unsafe void RegisterComponents(Context p0, Glide p1, Registry p2)
		{
			if (this.id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_ == IntPtr.Zero)
			{
				this.id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_ = JNIEnv.GetMethodID(this.class_ref, "registerComponents", "(Landroid/content/Context;Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/Registry;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_, ptr);
		}

		// Token: 0x040000FC RID: 252
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/module/GlideModule", typeof(IGlideModuleInvoker));

		// Token: 0x040000FD RID: 253
		private IntPtr class_ref;

		// Token: 0x040000FE RID: 254
		private static Delegate cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;

		// Token: 0x040000FF RID: 255
		private IntPtr id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;

		// Token: 0x04000100 RID: 256
		private static Delegate cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_;

		// Token: 0x04000101 RID: 257
		private IntPtr id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_;
	}
}
