using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000104 RID: 260
	[Register("com/bumptech/glide/load/resource/bitmap/ByteBufferBitmapDecoder", DoNotGenerateAcw = true)]
	public class ByteBufferBitmapDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00028F80 File Offset: 0x00027180
		internal static IntPtr class_ref
		{
			get
			{
				return ByteBufferBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00028FA4 File Offset: 0x000271A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBufferBitmapDecoder._members;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00028FAC File Offset: 0x000271AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteBufferBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00028FD0 File Offset: 0x000271D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBufferBitmapDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00028FDC File Offset: 0x000271DC
		protected ByteBufferBitmapDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00028FE8 File Offset: 0x000271E8
		[Register(".ctor", "(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;)V", "")]
		public unsafe ByteBufferBitmapDecoder(Downsampler downsampler) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((downsampler == null) ? IntPtr.Zero : downsampler.Handle);
				base.SetHandle(ByteBufferBitmapDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ByteBufferBitmapDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(downsampler);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00029098 File Offset: 0x00027298
		private static Delegate GetDecode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (ByteBufferBitmapDecoder.cb_decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_ == null)
			{
				ByteBufferBitmapDecoder.cb_decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(ByteBufferBitmapDecoder.n_Decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_));
			}
			return ByteBufferBitmapDecoder.cb_decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x000290BC File Offset: 0x000272BC
		private static IntPtr n_Decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			ByteBufferBitmapDecoder @object = Java.Lang.Object.GetObject<ByteBufferBitmapDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, width, height, object3));
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x000290F4 File Offset: 0x000272F4
		[Register("decode", "(Ljava/nio/ByteBuffer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Decode(ByteBuffer source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(ByteBufferBitmapDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Ljava/nio/ByteBuffer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x000291C0 File Offset: 0x000273C0
		private static Delegate GetHandles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (ByteBufferBitmapDecoder.cb_handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_ == null)
			{
				ByteBufferBitmapDecoder.cb_handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ByteBufferBitmapDecoder.n_Handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_));
			}
			return ByteBufferBitmapDecoder.cb_handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x000291E4 File Offset: 0x000273E4
		private static bool n_Handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			ByteBufferBitmapDecoder @object = Java.Lang.Object.GetObject<ByteBufferBitmapDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00029210 File Offset: 0x00027410
		[Register("handles", "(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(ByteBuffer source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = ByteBufferBitmapDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000292A0 File Offset: 0x000274A0
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<ByteBuffer>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000292B7 File Offset: 0x000274B7
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<ByteBuffer>(), p1);
		}

		// Token: 0x0400031C RID: 796
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/ByteBufferBitmapDecoder", typeof(ByteBufferBitmapDecoder));

		// Token: 0x0400031D RID: 797
		private static Delegate cb_decode_Ljava_nio_ByteBuffer_IILcom_bumptech_glide_load_Options_;

		// Token: 0x0400031E RID: 798
		private static Delegate cb_handles_Ljava_nio_ByteBuffer_Lcom_bumptech_glide_load_Options_;
	}
}
