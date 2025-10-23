using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.GifDecoder
{
	// Token: 0x02000015 RID: 21
	[Register("com/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider", DoNotGenerateAcw = true)]
	internal class IGifDecoderBitmapProviderInvoker : Java.Lang.Object, IGifDecoderBitmapProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000026A4 File Offset: 0x000008A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IGifDecoderBitmapProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000026C8 File Offset: 0x000008C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGifDecoderBitmapProviderInvoker._members;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000026CF File Offset: 0x000008CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000026D7 File Offset: 0x000008D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGifDecoderBitmapProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000026E3 File Offset: 0x000008E3
		public static IGifDecoderBitmapProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGifDecoderBitmapProvider>(handle, transfer);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000026EC File Offset: 0x000008EC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGifDecoderBitmapProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.gifdecoder.GifDecoder.BitmapProvider'.");
			}
			return handle;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002717 File Offset: 0x00000917
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002748 File Offset: 0x00000948
		public IGifDecoderBitmapProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGifDecoderBitmapProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002780 File Offset: 0x00000980
		private static Delegate GetObtain_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (IGifDecoderBitmapProviderInvoker.cb_obtain_IILandroid_graphics_Bitmap_Config_ == null)
			{
				IGifDecoderBitmapProviderInvoker.cb_obtain_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(IGifDecoderBitmapProviderInvoker.n_Obtain_IILandroid_graphics_Bitmap_Config_));
			}
			return IGifDecoderBitmapProviderInvoker.cb_obtain_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000027A4 File Offset: 0x000009A4
		private static IntPtr n_Obtain_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			IGifDecoderBitmapProvider @object = Java.Lang.Object.GetObject<IGifDecoderBitmapProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Obtain(p0, p1, object2));
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000027D0 File Offset: 0x000009D0
		public unsafe Bitmap Obtain(int p0, int p1, Bitmap.Config p2)
		{
			if (this.id_obtain_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
			{
				this.id_obtain_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID(this.class_ref, "obtain", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			return Java.Lang.Object.GetObject<Bitmap>(JNIEnv.CallObjectMethod(base.Handle, this.id_obtain_IILandroid_graphics_Bitmap_Config_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002872 File Offset: 0x00000A72
		private static Delegate GetObtainByteArray_IHandler()
		{
			if (IGifDecoderBitmapProviderInvoker.cb_obtainByteArray_I == null)
			{
				IGifDecoderBitmapProviderInvoker.cb_obtainByteArray_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IGifDecoderBitmapProviderInvoker.n_ObtainByteArray_I));
			}
			return IGifDecoderBitmapProviderInvoker.cb_obtainByteArray_I;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002896 File Offset: 0x00000A96
		private static IntPtr n_ObtainByteArray_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IGifDecoderBitmapProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ObtainByteArray(p0));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000028AC File Offset: 0x00000AAC
		public unsafe byte[] ObtainByteArray(int p0)
		{
			if (this.id_obtainByteArray_I == IntPtr.Zero)
			{
				this.id_obtainByteArray_I = JNIEnv.GetMethodID(this.class_ref, "obtainByteArray", "(I)[B");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_obtainByteArray_I, ptr), JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002925 File Offset: 0x00000B25
		private static Delegate GetObtainIntArray_IHandler()
		{
			if (IGifDecoderBitmapProviderInvoker.cb_obtainIntArray_I == null)
			{
				IGifDecoderBitmapProviderInvoker.cb_obtainIntArray_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IGifDecoderBitmapProviderInvoker.n_ObtainIntArray_I));
			}
			return IGifDecoderBitmapProviderInvoker.cb_obtainIntArray_I;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002949 File Offset: 0x00000B49
		private static IntPtr n_ObtainIntArray_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IGifDecoderBitmapProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ObtainIntArray(p0));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002960 File Offset: 0x00000B60
		public unsafe int[] ObtainIntArray(int p0)
		{
			if (this.id_obtainIntArray_I == IntPtr.Zero)
			{
				this.id_obtainIntArray_I = JNIEnv.GetMethodID(this.class_ref, "obtainIntArray", "(I)[I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return (int[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_obtainIntArray_I, ptr), JniHandleOwnership.TransferLocalRef, typeof(int));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000029D9 File Offset: 0x00000BD9
		private static Delegate GetRelease_Landroid_graphics_Bitmap_Handler()
		{
			if (IGifDecoderBitmapProviderInvoker.cb_release_Landroid_graphics_Bitmap_ == null)
			{
				IGifDecoderBitmapProviderInvoker.cb_release_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IGifDecoderBitmapProviderInvoker.n_Release_Landroid_graphics_Bitmap_));
			}
			return IGifDecoderBitmapProviderInvoker.cb_release_Landroid_graphics_Bitmap_;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002A00 File Offset: 0x00000C00
		private static void n_Release_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IGifDecoderBitmapProvider @object = Java.Lang.Object.GetObject<IGifDecoderBitmapProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Release(object2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002A24 File Offset: 0x00000C24
		public unsafe void Release(Bitmap p0)
		{
			if (this.id_release_Landroid_graphics_Bitmap_ == IntPtr.Zero)
			{
				this.id_release_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID(this.class_ref, "release", "(Landroid/graphics/Bitmap;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_release_Landroid_graphics_Bitmap_, ptr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002A97 File Offset: 0x00000C97
		private static Delegate GetRelease_arrayBHandler()
		{
			if (IGifDecoderBitmapProviderInvoker.cb_release_arrayB == null)
			{
				IGifDecoderBitmapProviderInvoker.cb_release_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IGifDecoderBitmapProviderInvoker.n_Release_arrayB));
			}
			return IGifDecoderBitmapProviderInvoker.cb_release_arrayB;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002ABC File Offset: 0x00000CBC
		private static void n_Release_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IGifDecoderBitmapProvider @object = Java.Lang.Object.GetObject<IGifDecoderBitmapProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
			@object.Release(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p0);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public unsafe void Release(byte[] p0)
		{
			if (this.id_release_arrayB == IntPtr.Zero)
			{
				this.id_release_arrayB = JNIEnv.GetMethodID(this.class_ref, "release", "([B)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_release_arrayB, ptr);
			if (p0 != null)
			{
				JNIEnv.CopyArray(intPtr, p0);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002B73 File Offset: 0x00000D73
		private static Delegate GetRelease_arrayIHandler()
		{
			if (IGifDecoderBitmapProviderInvoker.cb_release_arrayI == null)
			{
				IGifDecoderBitmapProviderInvoker.cb_release_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IGifDecoderBitmapProviderInvoker.n_Release_arrayI));
			}
			return IGifDecoderBitmapProviderInvoker.cb_release_arrayI;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002B98 File Offset: 0x00000D98
		private static void n_Release_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IGifDecoderBitmapProvider @object = Java.Lang.Object.GetObject<IGifDecoderBitmapProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.Release(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p0);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002BD4 File Offset: 0x00000DD4
		public unsafe void Release(int[] p0)
		{
			if (this.id_release_arrayI == IntPtr.Zero)
			{
				this.id_release_arrayI = JNIEnv.GetMethodID(this.class_ref, "release", "([I)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_release_arrayI, ptr);
			if (p0 != null)
			{
				JNIEnv.CopyArray(intPtr, p0);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider", typeof(IGifDecoderBitmapProviderInvoker));

		// Token: 0x04000010 RID: 16
		private IntPtr class_ref;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_obtain_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000012 RID: 18
		private IntPtr id_obtain_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_obtainByteArray_I;

		// Token: 0x04000014 RID: 20
		private IntPtr id_obtainByteArray_I;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_obtainIntArray_I;

		// Token: 0x04000016 RID: 22
		private IntPtr id_obtainIntArray_I;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_release_Landroid_graphics_Bitmap_;

		// Token: 0x04000018 RID: 24
		private IntPtr id_release_Landroid_graphics_Bitmap_;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_release_arrayB;

		// Token: 0x0400001A RID: 26
		private IntPtr id_release_arrayB;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_release_arrayI;

		// Token: 0x0400001C RID: 28
		private IntPtr id_release_arrayI;
	}
}
