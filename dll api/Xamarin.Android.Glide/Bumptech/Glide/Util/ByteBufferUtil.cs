using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000044 RID: 68
	[Register("com/bumptech/glide/util/ByteBufferUtil", DoNotGenerateAcw = true)]
	public sealed class ByteBufferUtil : Java.Lang.Object
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000A50C File Offset: 0x0000870C
		internal static IntPtr class_ref
		{
			get
			{
				return ByteBufferUtil._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000A530 File Offset: 0x00008730
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBufferUtil._members;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000A538 File Offset: 0x00008738
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteBufferUtil._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000A55C File Offset: 0x0000875C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBufferUtil._members.ManagedPeerType;
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000A568 File Offset: 0x00008768
		internal ByteBufferUtil(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000A574 File Offset: 0x00008774
		[Register("fromFile", "(Ljava/io/File;)Ljava/nio/ByteBuffer;", "")]
		public unsafe static ByteBuffer FromFile(Java.IO.File file)
		{
			ByteBuffer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				@object = Java.Lang.Object.GetObject<ByteBuffer>(ByteBufferUtil._members.StaticMethods.InvokeObjectMethod("fromFile.(Ljava/io/File;)Ljava/nio/ByteBuffer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(file);
			}
			return @object;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000A5E8 File Offset: 0x000087E8
		[Register("fromStream", "(Ljava/io/InputStream;)Ljava/nio/ByteBuffer;", "")]
		public unsafe static ByteBuffer FromStream(Stream stream)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(stream);
			ByteBuffer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ByteBuffer>(ByteBufferUtil._members.StaticMethods.InvokeObjectMethod("fromStream.(Ljava/io/InputStream;)Ljava/nio/ByteBuffer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(stream);
			}
			return @object;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000A658 File Offset: 0x00008858
		[Register("rewind", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "")]
		public unsafe static ByteBuffer Rewind(ByteBuffer buffer)
		{
			ByteBuffer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				@object = Java.Lang.Object.GetObject<ByteBuffer>(ByteBufferUtil._members.StaticMethods.InvokeObjectMethod("rewind.(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(buffer);
			}
			return @object;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000A6CC File Offset: 0x000088CC
		[Register("toBytes", "(Ljava/nio/ByteBuffer;)[B", "")]
		public unsafe static byte[] ToBytes(ByteBuffer byteBuffer)
		{
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((byteBuffer == null) ? IntPtr.Zero : byteBuffer.Handle);
				result = (byte[])JNIEnv.GetArray(ByteBufferUtil._members.StaticMethods.InvokeObjectMethod("toBytes.(Ljava/nio/ByteBuffer;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				GC.KeepAlive(byteBuffer);
			}
			return result;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000A750 File Offset: 0x00008950
		[Register("toFile", "(Ljava/nio/ByteBuffer;Ljava/io/File;)V", "")]
		public unsafe static void ToFile(ByteBuffer buffer, Java.IO.File file)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				ptr[1] = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				ByteBufferUtil._members.StaticMethods.InvokeVoidMethod("toFile.(Ljava/nio/ByteBuffer;Ljava/io/File;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(buffer);
				GC.KeepAlive(file);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000A7DC File Offset: 0x000089DC
		[Register("toStream", "(Ljava/nio/ByteBuffer;)Ljava/io/InputStream;", "")]
		public unsafe static Stream ToStream(ByteBuffer buffer)
		{
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				result = InputStreamInvoker.FromJniHandle(ByteBufferUtil._members.StaticMethods.InvokeObjectMethod("toStream.(Ljava/nio/ByteBuffer;)Ljava/io/InputStream;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(buffer);
			}
			return result;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000A850 File Offset: 0x00008A50
		[Register("toStream", "(Ljava/nio/ByteBuffer;Ljava/io/OutputStream;)V", "")]
		public unsafe static void ToStream(ByteBuffer byteBuffer, Stream os)
		{
			IntPtr intPtr = OutputStreamAdapter.ToLocalJniHandle(os);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((byteBuffer == null) ? IntPtr.Zero : byteBuffer.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ByteBufferUtil._members.StaticMethods.InvokeVoidMethod("toStream.(Ljava/nio/ByteBuffer;Ljava/io/OutputStream;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(byteBuffer);
				GC.KeepAlive(os);
			}
		}

		// Token: 0x040000A4 RID: 164
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/ByteBufferUtil", typeof(ByteBufferUtil));
	}
}
