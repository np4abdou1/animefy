using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x020000FB RID: 251
	[Register("com/bumptech/glide/load/resource/bitmap/StreamBitmapDecoder", DoNotGenerateAcw = true)]
	public class StreamBitmapDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C83 RID: 3203 RVA: 0x000271AC File Offset: 0x000253AC
		IResource IResourceDecoder.Decode(Java.Lang.Object source, int width, int height, Options options)
		{
			Stream source2 = InputStreamInvoker.FromJniHandle(source.Handle, JniHandleOwnership.DoNotTransfer);
			return this.Decode(source2, width, height, options);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000271D4 File Offset: 0x000253D4
		bool IResourceDecoder.Handles(Java.Lang.Object source, Options options)
		{
			Stream source2 = InputStreamInvoker.FromJniHandle(source.Handle, JniHandleOwnership.DoNotTransfer);
			return this.Handles(source2, options);
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x000271F8 File Offset: 0x000253F8
		internal static IntPtr class_ref
		{
			get
			{
				return StreamBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0002721C File Offset: 0x0002541C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StreamBitmapDecoder._members;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00027224 File Offset: 0x00025424
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StreamBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00027248 File Offset: 0x00025448
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StreamBitmapDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00027254 File Offset: 0x00025454
		protected StreamBitmapDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00027260 File Offset: 0x00025460
		[Register(".ctor", "(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe StreamBitmapDecoder(Downsampler downsampler, IArrayPool byteArrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((downsampler == null) ? IntPtr.Zero : downsampler.Handle);
				ptr[1] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				base.SetHandle(StreamBitmapDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StreamBitmapDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(downsampler);
				GC.KeepAlive(byteArrayPool);
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0002733C File Offset: 0x0002553C
		private static Delegate GetDecode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (StreamBitmapDecoder.cb_decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_ == null)
			{
				StreamBitmapDecoder.cb_decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(StreamBitmapDecoder.n_Decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_));
			}
			return StreamBitmapDecoder.cb_decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00027360 File Offset: 0x00025560
		private static IntPtr n_Decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			StreamBitmapDecoder @object = Java.Lang.Object.GetObject<StreamBitmapDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream source = InputStreamInvoker.FromJniHandle(native_source, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(source, width, height, object2));
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00027398 File Offset: 0x00025598
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
				@object = Java.Lang.Object.GetObject<IResource>(StreamBitmapDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00027460 File Offset: 0x00025660
		private static Delegate GetHandles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (StreamBitmapDecoder.cb_handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_ == null)
			{
				StreamBitmapDecoder.cb_handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(StreamBitmapDecoder.n_Handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_));
			}
			return StreamBitmapDecoder.cb_handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00027484 File Offset: 0x00025684
		private static bool n_Handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			StreamBitmapDecoder @object = Java.Lang.Object.GetObject<StreamBitmapDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream source = InputStreamInvoker.FromJniHandle(native_source, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(source, object2);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000274B0 File Offset: 0x000256B0
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
				result = StreamBitmapDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/io/InputStream;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x04000303 RID: 771
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/StreamBitmapDecoder", typeof(StreamBitmapDecoder));

		// Token: 0x04000304 RID: 772
		private static Delegate cb_decode_Ljava_io_InputStream_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000305 RID: 773
		private static Delegate cb_handles_Ljava_io_InputStream_Lcom_bumptech_glide_load_Options_;
	}
}
