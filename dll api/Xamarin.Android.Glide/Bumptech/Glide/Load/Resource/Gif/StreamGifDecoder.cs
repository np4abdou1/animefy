using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x02000125 RID: 293
	[Register("com/bumptech/glide/load/resource/gif/StreamGifDecoder", DoNotGenerateAcw = true)]
	public class StreamGifDecoder : Java.Lang.Object
	{
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0002FFDC File Offset: 0x0002E1DC
		internal static IntPtr class_ref
		{
			get
			{
				return StreamGifDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00030000 File Offset: 0x0002E200
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StreamGifDecoder._members;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00030008 File Offset: 0x0002E208
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StreamGifDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0003002C File Offset: 0x0002E22C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StreamGifDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00030038 File Offset: 0x0002E238
		protected StreamGifDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00030044 File Offset: 0x0002E244
		[Register(".ctor", "(Ljava/util/List;Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe StreamGifDecoder(IList<IImageHeaderParser> parsers, IResourceDecoder byteBufferDecoder, IArrayPool byteArrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((byteBufferDecoder == null) ? IntPtr.Zero : ((Java.Lang.Object)byteBufferDecoder).Handle);
				ptr[2] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				base.SetHandle(StreamGifDecoder._members.InstanceMethods.StartCreateInstance("(Ljava/util/List;Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StreamGifDecoder._members.InstanceMethods.FinishCreateInstance("(Ljava/util/List;Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parsers);
				GC.KeepAlive(byteBufferDecoder);
				GC.KeepAlive(byteArrayPool);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0003014C File Offset: 0x0002E34C
		private static Delegate GetDecode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (StreamGifDecoder.cb_decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_ == null)
			{
				StreamGifDecoder.cb_decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(StreamGifDecoder.n_Decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_));
			}
			return StreamGifDecoder.cb_decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00030170 File Offset: 0x0002E370
		private static IntPtr n_Decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			StreamGifDecoder @object = Java.Lang.Object.GetObject<StreamGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream source = InputStreamInvoker.FromJniHandle(native_source, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(source, width, height, object2));
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x000301A8 File Offset: 0x0002E3A8
		[Register("decode", "(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Decode(Stream source, int width, int height, Options options)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(source);
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(StreamGifDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00030270 File Offset: 0x0002E470
		private static Delegate GetHandles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (StreamGifDecoder.cb_handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_ == null)
			{
				StreamGifDecoder.cb_handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(StreamGifDecoder.n_Handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_));
			}
			return StreamGifDecoder.cb_handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00030294 File Offset: 0x0002E494
		private static bool n_Handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			StreamGifDecoder @object = Java.Lang.Object.GetObject<StreamGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream source = InputStreamInvoker.FromJniHandle(native_source, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(source, object2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000302C0 File Offset: 0x0002E4C0
		[Register("handles", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(Stream source, Options options)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(source);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = StreamGifDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/io/InputStream;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x04000377 RID: 887
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/StreamGifDecoder", typeof(StreamGifDecoder));

		// Token: 0x04000378 RID: 888
		private static Delegate cb_decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000379 RID: 889
		private static Delegate cb_handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_;
	}
}
