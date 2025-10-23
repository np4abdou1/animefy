using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000CC RID: 204
	[Register("com/bumptech/glide/load/Encoder", DoNotGenerateAcw = true)]
	internal class IEncoderInvoker : Java.Lang.Object, IEncoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00020B9C File Offset: 0x0001ED9C
		private static IntPtr java_class_ref
		{
			get
			{
				return IEncoderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00020BC0 File Offset: 0x0001EDC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IEncoderInvoker._members;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00020BC7 File Offset: 0x0001EDC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00020BCF File Offset: 0x0001EDCF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IEncoderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00020BDB File Offset: 0x0001EDDB
		public static IEncoder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IEncoder>(handle, transfer);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00020BE4 File Offset: 0x0001EDE4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEncoderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.Encoder'.");
			}
			return handle;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00020C0F File Offset: 0x0001EE0F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00020C40 File Offset: 0x0001EE40
		public IEncoderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEncoderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00020C78 File Offset: 0x0001EE78
		private static Delegate GetEncode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (IEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == null)
			{
				IEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IEncoderInvoker.n_Encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_));
			}
			return IEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00020C9C File Offset: 0x0001EE9C
		private static bool n_Encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IEncoder @object = Java.Lang.Object.GetObject<IEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			File object3 = Java.Lang.Object.GetObject<File>(native_p1, JniHandleOwnership.DoNotTransfer);
			Options object4 = Java.Lang.Object.GetObject<Options>(native_p2, JniHandleOwnership.DoNotTransfer);
			return @object.Encode(object2, object3, object4);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00020CD4 File Offset: 0x0001EED4
		public unsafe bool Encode(Java.Lang.Object p0, File p1, Options p2)
		{
			if (this.id_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == IntPtr.Zero)
			{
				this.id_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNIEnv.GetMethodID(this.class_ref, "encode", "(Ljava/lang/Object;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x04000293 RID: 659
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/Encoder", typeof(IEncoderInvoker));

		// Token: 0x04000294 RID: 660
		private IntPtr class_ref;

		// Token: 0x04000295 RID: 661
		private static Delegate cb_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_;

		// Token: 0x04000296 RID: 662
		private IntPtr id_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
	}
}
