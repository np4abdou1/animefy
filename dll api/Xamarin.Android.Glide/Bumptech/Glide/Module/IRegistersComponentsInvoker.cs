using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Module
{
	// Token: 0x0200006C RID: 108
	[Register("com/bumptech/glide/module/RegistersComponents", DoNotGenerateAcw = true)]
	internal class IRegistersComponentsInvoker : Java.Lang.Object, IRegistersComponents, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00010138 File Offset: 0x0000E338
		private static IntPtr java_class_ref
		{
			get
			{
				return IRegistersComponentsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0001015C File Offset: 0x0000E35C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRegistersComponentsInvoker._members;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00010163 File Offset: 0x0000E363
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0001016B File Offset: 0x0000E36B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRegistersComponentsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00010177 File Offset: 0x0000E377
		public static IRegistersComponents GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRegistersComponents>(handle, transfer);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00010180 File Offset: 0x0000E380
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRegistersComponentsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.module.RegistersComponents'.");
			}
			return handle;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000101AB File Offset: 0x0000E3AB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000101DC File Offset: 0x0000E3DC
		public IRegistersComponentsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRegistersComponentsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00010214 File Offset: 0x0000E414
		private static Delegate GetRegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_Handler()
		{
			if (IRegistersComponentsInvoker.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_ == null)
			{
				IRegistersComponentsInvoker.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IRegistersComponentsInvoker.n_RegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_));
			}
			return IRegistersComponentsInvoker.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00010238 File Offset: 0x0000E438
		private static void n_RegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IRegistersComponents @object = Java.Lang.Object.GetObject<IRegistersComponents>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			Glide object3 = Java.Lang.Object.GetObject<Glide>(native_p1, JniHandleOwnership.DoNotTransfer);
			Registry object4 = Java.Lang.Object.GetObject<Registry>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.RegisterComponents(object2, object3, object4);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00010270 File Offset: 0x0000E470
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

		// Token: 0x04000102 RID: 258
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/module/RegistersComponents", typeof(IRegistersComponentsInvoker));

		// Token: 0x04000103 RID: 259
		private IntPtr class_ref;

		// Token: 0x04000104 RID: 260
		private static Delegate cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_;

		// Token: 0x04000105 RID: 261
		private IntPtr id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_;
	}
}
