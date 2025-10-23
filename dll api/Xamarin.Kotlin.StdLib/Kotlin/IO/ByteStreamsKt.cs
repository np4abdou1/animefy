using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Kotlin.Collections;

namespace Kotlin.IO
{
	// Token: 0x0200021B RID: 539
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/ByteStreamsKt", DoNotGenerateAcw = true)]
	public sealed class ByteStreamsKt : Java.Lang.Object
	{
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00053684 File Offset: 0x00051884
		internal static IntPtr class_ref
		{
			get
			{
				return ByteStreamsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x000536A8 File Offset: 0x000518A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteStreamsKt._members;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x000536B0 File Offset: 0x000518B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteStreamsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x000536D4 File Offset: 0x000518D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteStreamsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x000536E0 File Offset: 0x000518E0
		internal ByteStreamsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000536EC File Offset: 0x000518EC
		[Register("copyTo", "(Ljava/io/InputStream;Ljava/io/OutputStream;I)J", "")]
		public unsafe static long CopyTo(Stream obj, Stream @out, int bufferSize)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(obj);
			IntPtr intPtr2 = OutputStreamAdapter.ToLocalJniHandle(@out);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(bufferSize);
				result = ByteStreamsKt._members.StaticMethods.InvokeInt64Method("copyTo.(Ljava/io/InputStream;Ljava/io/OutputStream;I)J", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(obj);
				GC.KeepAlive(@out);
			}
			return result;
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0005378C File Offset: 0x0005198C
		[Register("iterator", "(Ljava/io/BufferedInputStream;)Lkotlin/collections/ByteIterator;", "")]
		public unsafe static ByteIterator Iterator(BufferedInputStream obj)
		{
			ByteIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<ByteIterator>(ByteStreamsKt._members.StaticMethods.InvokeObjectMethod("iterator.(Ljava/io/BufferedInputStream;)Lkotlin/collections/ByteIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00053800 File Offset: 0x00051A00
		[Register("readBytes", "(Ljava/io/InputStream;)[B", "")]
		public unsafe static byte[] ReadBytes(Stream obj)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(obj);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(ByteStreamsKt._members.StaticMethods.InvokeObjectMethod("readBytes.(Ljava/io/InputStream;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00053880 File Offset: 0x00051A80
		[Obsolete("deprecated")]
		[Register("readBytes", "(Ljava/io/InputStream;I)[B", "")]
		public unsafe static byte[] ReadBytes(Stream obj, int estimatedSize)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(obj);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(estimatedSize);
				result = (byte[])JNIEnv.GetArray(ByteStreamsKt._members.StaticMethods.InvokeObjectMethod("readBytes.(Ljava/io/InputStream;I)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x040007CB RID: 1995
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/ByteStreamsKt", typeof(ByteStreamsKt));
	}
}
