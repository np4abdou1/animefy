using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x0200011E RID: 286
	[Register("com/bumptech/glide/load/resource/gif/ByteBufferGifDecoder", DoNotGenerateAcw = true)]
	public class ByteBufferGifDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0002E0FC File Offset: 0x0002C2FC
		internal static IntPtr class_ref
		{
			get
			{
				return ByteBufferGifDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0002E120 File Offset: 0x0002C320
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBufferGifDecoder._members;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0002E128 File Offset: 0x0002C328
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteBufferGifDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0002E14C File Offset: 0x0002C34C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBufferGifDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0002E158 File Offset: 0x0002C358
		protected ByteBufferGifDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0002E164 File Offset: 0x0002C364
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ByteBufferGifDecoder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ByteBufferGifDecoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ByteBufferGifDecoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0002E214 File Offset: 0x0002C414
		[Register(".ctor", "(Landroid/content/Context;Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe ByteBufferGifDecoder(Context context, IList<IImageHeaderParser> parsers, IBitmapPool bitmapPool, IArrayPool arrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[3] = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				base.SetHandle(ByteBufferGifDecoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ByteBufferGifDecoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(parsers);
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(arrayPool);
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0002E34C File Offset: 0x0002C54C
		private static Delegate GetDecode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (ByteBufferGifDecoder.cb_decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_ == null)
			{
				ByteBufferGifDecoder.cb_decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(ByteBufferGifDecoder.n_Decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_));
			}
			return ByteBufferGifDecoder.cb_decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0002E370 File Offset: 0x0002C570
		private static IntPtr n_Decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			ByteBufferGifDecoder @object = Java.Lang.Object.GetObject<ByteBufferGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, width, height, object3));
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0002E3A8 File Offset: 0x0002C5A8
		[Register("decode", "(Ljava/nio/ByteBuffer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/resource/gif/GifDrawableResource;", "GetDecode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual GifDrawableResource Decode(ByteBuffer source, int width, int height, Options options)
		{
			GifDrawableResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<GifDrawableResource>(ByteBufferGifDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Ljava/nio/ByteBuffer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/resource/gif/GifDrawableResource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0002E474 File Offset: 0x0002C674
		private static Delegate GetHandles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (ByteBufferGifDecoder.cb_handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_ == null)
			{
				ByteBufferGifDecoder.cb_handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ByteBufferGifDecoder.n_Handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_));
			}
			return ByteBufferGifDecoder.cb_handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0002E498 File Offset: 0x0002C698
		private static bool n_Handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			ByteBufferGifDecoder @object = Java.Lang.Object.GetObject<ByteBufferGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0002E4C4 File Offset: 0x0002C6C4
		[Register("handles", "(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(ByteBuffer source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = ByteBufferGifDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0002E554 File Offset: 0x0002C754
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<ByteBuffer>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0002E56B File Offset: 0x0002C76B
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<ByteBuffer>(), p1);
		}

		// Token: 0x04000352 RID: 850
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/ByteBufferGifDecoder", typeof(ByteBufferGifDecoder));

		// Token: 0x04000353 RID: 851
		private static Delegate cb_decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000354 RID: 852
		private static Delegate cb_handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_;
	}
}
