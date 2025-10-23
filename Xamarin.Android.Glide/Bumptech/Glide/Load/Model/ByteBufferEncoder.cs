using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200012D RID: 301
	[Register("com/bumptech/glide/load/model/ByteBufferEncoder", DoNotGenerateAcw = true)]
	public class ByteBufferEncoder : Java.Lang.Object, IEncoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00031A50 File Offset: 0x0002FC50
		internal static IntPtr class_ref
		{
			get
			{
				return ByteBufferEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00031A74 File Offset: 0x0002FC74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBufferEncoder._members;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00031A7C File Offset: 0x0002FC7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteBufferEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00031AA0 File Offset: 0x0002FCA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBufferEncoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00031AAC File Offset: 0x0002FCAC
		protected ByteBufferEncoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00031AB8 File Offset: 0x0002FCB8
		[Register(".ctor", "()V", "")]
		public ByteBufferEncoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ByteBufferEncoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ByteBufferEncoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00031B26 File Offset: 0x0002FD26
		private static Delegate GetEncode_Ljava_nio_ByteBuffer_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (ByteBufferEncoder.cb_encode_Ljava_nio_ByteBuffer_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == null)
			{
				ByteBufferEncoder.cb_encode_Ljava_nio_ByteBuffer_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(ByteBufferEncoder.n_Encode_Ljava_nio_ByteBuffer_Ljava_io_File_Lcom_bumptech_glide_load_Options_));
			}
			return ByteBufferEncoder.cb_encode_Ljava_nio_ByteBuffer_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00031B4C File Offset: 0x0002FD4C
		private static bool n_Encode_Ljava_nio_ByteBuffer_Ljava_io_File_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_file, IntPtr native_options)
		{
			ByteBufferEncoder @object = Java.Lang.Object.GetObject<ByteBufferEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_data, JniHandleOwnership.DoNotTransfer);
			File object3 = Java.Lang.Object.GetObject<File>(native_file, JniHandleOwnership.DoNotTransfer);
			Options object4 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Encode(object2, object3, object4);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00031B84 File Offset: 0x0002FD84
		[Register("encode", "(Ljava/nio/ByteBuffer;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", "GetEncode_Ljava_nio_ByteBuffer_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Encode(ByteBuffer data, File file, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				ptr[1] = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = ByteBufferEncoder._members.InstanceMethods.InvokeVirtualBooleanMethod("encode.(Ljava/nio/ByteBuffer;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
				GC.KeepAlive(file);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00031C3C File Offset: 0x0002FE3C
		bool IEncoder.Encode(Java.Lang.Object p0, File p1, Options p2)
		{
			return this.Encode(p0.JavaCast<ByteBuffer>(), p1, p2);
		}

		// Token: 0x0400038F RID: 911
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ByteBufferEncoder", typeof(ByteBufferEncoder));

		// Token: 0x04000390 RID: 912
		private static Delegate cb_encode_Ljava_nio_ByteBuffer_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
	}
}
