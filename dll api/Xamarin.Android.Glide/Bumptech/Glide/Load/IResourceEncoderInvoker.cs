using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000DA RID: 218
	[Register("com/bumptech/glide/load/ResourceEncoder", DoNotGenerateAcw = true)]
	internal class IResourceEncoderInvoker : Java.Lang.Object, IResourceEncoder, IEncoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x000220E4 File Offset: 0x000202E4
		private static IntPtr java_class_ref
		{
			get
			{
				return IResourceEncoderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00022108 File Offset: 0x00020308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IResourceEncoderInvoker._members;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0002210F File Offset: 0x0002030F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00022117 File Offset: 0x00020317
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IResourceEncoderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00022123 File Offset: 0x00020323
		public static IResourceEncoder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IResourceEncoder>(handle, transfer);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0002212C File Offset: 0x0002032C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IResourceEncoderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.ResourceEncoder'.");
			}
			return handle;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00022157 File Offset: 0x00020357
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00022188 File Offset: 0x00020388
		public IResourceEncoderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IResourceEncoderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000221C0 File Offset: 0x000203C0
		private static Delegate GetGetEncodeStrategy_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (IResourceEncoderInvoker.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ == null)
			{
				IResourceEncoderInvoker.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IResourceEncoderInvoker.n_GetEncodeStrategy_Lcom_bumptech_glide_load_Options_));
			}
			return IResourceEncoderInvoker.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000221E4 File Offset: 0x000203E4
		private static IntPtr n_GetEncodeStrategy_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IResourceEncoder @object = Java.Lang.Object.GetObject<IResourceEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetEncodeStrategy(object2));
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0002220C File Offset: 0x0002040C
		public unsafe EncodeStrategy GetEncodeStrategy(Options p0)
		{
			if (this.id_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ == IntPtr.Zero)
			{
				this.id_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ = JNIEnv.GetMethodID(this.class_ref, "getEncodeStrategy", "(Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/EncodeStrategy;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<EncodeStrategy>(JNIEnv.CallObjectMethod(base.Handle, this.id_getEncodeStrategy_Lcom_bumptech_glide_load_Options_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00022285 File Offset: 0x00020485
		private static Delegate GetEncode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (IResourceEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == null)
			{
				IResourceEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IResourceEncoderInvoker.n_Encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_));
			}
			return IResourceEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000222AC File Offset: 0x000204AC
		private static bool n_Encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IEncoder @object = Java.Lang.Object.GetObject<IResourceEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			File object3 = Java.Lang.Object.GetObject<File>(native_p1, JniHandleOwnership.DoNotTransfer);
			Options object4 = Java.Lang.Object.GetObject<Options>(native_p2, JniHandleOwnership.DoNotTransfer);
			return @object.Encode(object2, object3, object4);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000222E4 File Offset: 0x000204E4
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

		// Token: 0x040002B5 RID: 693
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/ResourceEncoder", typeof(IResourceEncoderInvoker));

		// Token: 0x040002B6 RID: 694
		private IntPtr class_ref;

		// Token: 0x040002B7 RID: 695
		private static Delegate cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;

		// Token: 0x040002B8 RID: 696
		private IntPtr id_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;

		// Token: 0x040002B9 RID: 697
		private static Delegate cb_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_;

		// Token: 0x040002BA RID: 698
		private IntPtr id_encode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
	}
}
