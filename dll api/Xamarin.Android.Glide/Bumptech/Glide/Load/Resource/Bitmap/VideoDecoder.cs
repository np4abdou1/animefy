using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x0200011C RID: 284
	[Register("com/bumptech/glide/load/resource/bitmap/VideoDecoder", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class VideoDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x0002D9D0 File Offset: 0x0002BBD0
		[Register("FRAME_OPTION")]
		public static Option FrameOption
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(VideoDecoder._members.StaticFields.GetObjectValue("FRAME_OPTION.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0002DA00 File Offset: 0x0002BC00
		[Register("TARGET_FRAME")]
		public static Option TargetFrame
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(VideoDecoder._members.StaticFields.GetObjectValue("TARGET_FRAME.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x0002DA30 File Offset: 0x0002BC30
		internal static IntPtr class_ref
		{
			get
			{
				return VideoDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x0002DA54 File Offset: 0x0002BC54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VideoDecoder._members;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0002DA5C File Offset: 0x0002BC5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VideoDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x0002DA80 File Offset: 0x0002BC80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VideoDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0002DA8C File Offset: 0x0002BC8C
		protected VideoDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0002DA98 File Offset: 0x0002BC98
		[Register("asset", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/ResourceDecoder;", "")]
		public unsafe static IResourceDecoder Asset(IBitmapPool bitmapPool)
		{
			IResourceDecoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				@object = Java.Lang.Object.GetObject<IResourceDecoder>(VideoDecoder._members.StaticMethods.InvokeObjectMethod("asset.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/ResourceDecoder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
			}
			return @object;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0002DB10 File Offset: 0x0002BD10
		[Register("byteBuffer", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/ResourceDecoder;", "")]
		public unsafe static IResourceDecoder ByteBuffer(IBitmapPool bitmapPool)
		{
			IResourceDecoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				@object = Java.Lang.Object.GetObject<IResourceDecoder>(VideoDecoder._members.StaticMethods.InvokeObjectMethod("byteBuffer.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/ResourceDecoder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
			}
			return @object;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0002DB88 File Offset: 0x0002BD88
		private static Delegate GetDecode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (VideoDecoder.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				VideoDecoder.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(VideoDecoder.n_Decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return VideoDecoder.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0002DBAC File Offset: 0x0002BDAC
		private static IntPtr n_Decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, int outWidth, int outHeight, IntPtr native_options)
		{
			VideoDecoder @object = Java.Lang.Object.GetObject<VideoDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_resource, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, outWidth, outHeight, object3));
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
		[Register("decode", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Decode(Java.Lang.Object resource, int outWidth, int outHeight, Options options)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(outWidth);
				ptr[2] = new JniArgumentValue(outHeight);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(VideoDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0002DCAC File Offset: 0x0002BEAC
		private static Delegate GetHandles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (VideoDecoder.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_ == null)
			{
				VideoDecoder.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(VideoDecoder.n_Handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_));
			}
			return VideoDecoder.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0002DCD0 File Offset: 0x0002BED0
		private static bool n_Handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_options)
		{
			VideoDecoder @object = Java.Lang.Object.GetObject<VideoDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_data, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0002DCFC File Offset: 0x0002BEFC
		[Register("handles", "(Ljava/lang/Object;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(Java.Lang.Object data, Options options)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(data);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = VideoDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/lang/Object;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x0002DD88 File Offset: 0x0002BF88
		[Register("parcel", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/ResourceDecoder;", "")]
		public unsafe static IResourceDecoder Parcel(IBitmapPool bitmapPool)
		{
			IResourceDecoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				@object = Java.Lang.Object.GetObject<IResourceDecoder>(VideoDecoder._members.StaticMethods.InvokeObjectMethod("parcel.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/ResourceDecoder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
			}
			return @object;
		}

		// Token: 0x0400034B RID: 843
		[Register("DEFAULT_FRAME")]
		public const long DefaultFrame = -1L;

		// Token: 0x0400034C RID: 844
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/VideoDecoder", typeof(VideoDecoder));

		// Token: 0x0400034D RID: 845
		private static Delegate cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x0400034E RID: 846
		private static Delegate cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_;
	}
}
