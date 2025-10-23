using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D1 RID: 209
	[Register("com/bumptech/glide/load/ImageHeaderParser", DoNotGenerateAcw = true)]
	internal class IImageHeaderParserInvoker : Java.Lang.Object, IImageHeaderParser, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00021128 File Offset: 0x0001F328
		private static IntPtr java_class_ref
		{
			get
			{
				return IImageHeaderParserInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0002114C File Offset: 0x0001F34C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IImageHeaderParserInvoker._members;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00021153 File Offset: 0x0001F353
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002115B File Offset: 0x0001F35B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IImageHeaderParserInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00021167 File Offset: 0x0001F367
		public static IImageHeaderParser GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IImageHeaderParser>(handle, transfer);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00021170 File Offset: 0x0001F370
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IImageHeaderParserInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.ImageHeaderParser'.");
			}
			return handle;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0002119B File Offset: 0x0001F39B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x000211CC File Offset: 0x0001F3CC
		public IImageHeaderParserInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IImageHeaderParserInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00021204 File Offset: 0x0001F404
		private static Delegate GetGetOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_Handler()
		{
			if (IImageHeaderParserInvoker.cb_getOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_ == null)
			{
				IImageHeaderParserInvoker.cb_getOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(IImageHeaderParserInvoker.n_GetOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_));
			}
			return IImageHeaderParserInvoker.cb_getOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00021228 File Offset: 0x0001F428
		private static int n_GetOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IImageHeaderParser @object = Java.Lang.Object.GetObject<IImageHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream p = InputStreamInvoker.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			IArrayPool object2 = Java.Lang.Object.GetObject<IArrayPool>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.GetOrientation(p, object2);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00021254 File Offset: 0x0001F454
		public unsafe int GetOrientation(Stream p0, IArrayPool p1)
		{
			if (this.id_getOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_ == IntPtr.Zero)
			{
				this.id_getOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_ = JNIEnv.GetMethodID(this.class_ref, "getOrientation", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I");
			}
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_getOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x000212EC File Offset: 0x0001F4EC
		private static Delegate GetGetOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_Handler()
		{
			if (IImageHeaderParserInvoker.cb_getOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_ == null)
			{
				IImageHeaderParserInvoker.cb_getOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(IImageHeaderParserInvoker.n_GetOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_));
			}
			return IImageHeaderParserInvoker.cb_getOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00021310 File Offset: 0x0001F510
		private static int n_GetOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IImageHeaderParser @object = Java.Lang.Object.GetObject<IImageHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_p0, JniHandleOwnership.DoNotTransfer);
			IArrayPool object3 = Java.Lang.Object.GetObject<IArrayPool>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.GetOrientation(object2, object3);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0002133C File Offset: 0x0001F53C
		public unsafe int GetOrientation(ByteBuffer p0, IArrayPool p1)
		{
			if (this.id_getOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_ == IntPtr.Zero)
			{
				this.id_getOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_ = JNIEnv.GetMethodID(this.class_ref, "getOrientation", "(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_, ptr);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x000213D6 File Offset: 0x0001F5D6
		private static Delegate GetGetType_Ljava_io_InputStream_Handler()
		{
			if (IImageHeaderParserInvoker.cb_getType_Ljava_io_InputStream_ == null)
			{
				IImageHeaderParserInvoker.cb_getType_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IImageHeaderParserInvoker.n_GetType_Ljava_io_InputStream_));
			}
			return IImageHeaderParserInvoker.cb_getType_Ljava_io_InputStream_;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x000213FC File Offset: 0x0001F5FC
		private static IntPtr n_GetType_Ljava_io_InputStream_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IImageHeaderParser @object = Java.Lang.Object.GetObject<IImageHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream p = InputStreamInvoker.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetType(p));
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00021424 File Offset: 0x0001F624
		public unsafe ImageHeaderParserImageType GetType(Stream p0)
		{
			if (this.id_getType_Ljava_io_InputStream_ == IntPtr.Zero)
			{
				this.id_getType_Ljava_io_InputStream_ = JNIEnv.GetMethodID(this.class_ref, "getType", "(Ljava/io/InputStream;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;");
			}
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ImageHeaderParserImageType @object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(JNIEnv.CallObjectMethod(base.Handle, this.id_getType_Ljava_io_InputStream_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0002149B File Offset: 0x0001F69B
		private static Delegate GetGetType_Ljava_nio_ByteBuffer_Handler()
		{
			if (IImageHeaderParserInvoker.cb_getType_Ljava_nio_ByteBuffer_ == null)
			{
				IImageHeaderParserInvoker.cb_getType_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IImageHeaderParserInvoker.n_GetType_Ljava_nio_ByteBuffer_));
			}
			return IImageHeaderParserInvoker.cb_getType_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000214C0 File Offset: 0x0001F6C0
		private static IntPtr n_GetType_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IImageHeaderParser @object = Java.Lang.Object.GetObject<IImageHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetType(object2));
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000214E8 File Offset: 0x0001F6E8
		public unsafe ImageHeaderParserImageType GetType(ByteBuffer p0)
		{
			if (this.id_getType_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
			{
				this.id_getType_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID(this.class_ref, "getType", "(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(JNIEnv.CallObjectMethod(base.Handle, this.id_getType_Ljava_nio_ByteBuffer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000299 RID: 665
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/ImageHeaderParser", typeof(IImageHeaderParserInvoker));

		// Token: 0x0400029A RID: 666
		private IntPtr class_ref;

		// Token: 0x0400029B RID: 667
		private static Delegate cb_getOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_;

		// Token: 0x0400029C RID: 668
		private IntPtr id_getOrientation_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_;

		// Token: 0x0400029D RID: 669
		private static Delegate cb_getOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_;

		// Token: 0x0400029E RID: 670
		private IntPtr id_getOrientation_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_ArrayPool_;

		// Token: 0x0400029F RID: 671
		private static Delegate cb_getType_Ljava_io_InputStream_;

		// Token: 0x040002A0 RID: 672
		private IntPtr id_getType_Ljava_io_InputStream_;

		// Token: 0x040002A1 RID: 673
		private static Delegate cb_getType_Ljava_nio_ByteBuffer_;

		// Token: 0x040002A2 RID: 674
		private IntPtr id_getType_Ljava_nio_ByteBuffer_;
	}
}
