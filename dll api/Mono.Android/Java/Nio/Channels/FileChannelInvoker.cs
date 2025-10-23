using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x02000398 RID: 920
	[Register("java/nio/channels/FileChannel", DoNotGenerateAcw = true)]
	internal class FileChannelInvoker : FileChannel
	{
		// Token: 0x060028D1 RID: 10449 RVA: 0x000734B8 File Offset: 0x000716B8
		public FileChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000734C2 File Offset: 0x000716C2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileChannelInvoker._members;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x000734C9 File Offset: 0x000716C9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000734D5 File Offset: 0x000716D5
		public override long Position()
		{
			return FileChannelInvoker._members.InstanceMethods.InvokeAbstractInt64Method("position.()J", this, null);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000734F0 File Offset: 0x000716F0
		public unsafe override FileChannel Position(long newPosition)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(newPosition);
			return Java.Lang.Object.GetObject<FileChannel>(FileChannelInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("position.(J)Ljava/nio/channels/FileChannel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0007353C File Offset: 0x0007173C
		public unsafe override int Read(ByteBuffer dst)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dst == null) ? IntPtr.Zero : dst.Handle);
				result = FileChannelInvoker._members.InstanceMethods.InvokeAbstractInt32Method("read.(Ljava/nio/ByteBuffer;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dst);
			}
			return result;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000735A4 File Offset: 0x000717A4
		public unsafe override long Read(ByteBuffer[] dsts, int offset, int length)
		{
			IntPtr intPtr = JNIEnv.NewArray<ByteBuffer>(dsts);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(offset);
				ptr[2] = new JniArgumentValue(length);
				result = FileChannelInvoker._members.InstanceMethods.InvokeAbstractInt64Method("read.([Ljava/nio/ByteBuffer;II)J", this, ptr);
			}
			finally
			{
				if (dsts != null)
				{
					JNIEnv.CopyArray<ByteBuffer>(intPtr, dsts);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(dsts);
			}
			return result;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0007363C File Offset: 0x0007183C
		public override long Size()
		{
			return FileChannelInvoker._members.InstanceMethods.InvokeAbstractInt64Method("size.()J", this, null);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00073658 File Offset: 0x00071858
		public unsafe override FileChannel Truncate(long size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return Java.Lang.Object.GetObject<FileChannel>(FileChannelInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("truncate.(J)Ljava/nio/channels/FileChannel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000736A4 File Offset: 0x000718A4
		public unsafe override int Write(ByteBuffer src)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((src == null) ? IntPtr.Zero : src.Handle);
				result = FileChannelInvoker._members.InstanceMethods.InvokeAbstractInt32Method("write.(Ljava/nio/ByteBuffer;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(src);
			}
			return result;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0007370C File Offset: 0x0007190C
		public unsafe override long Write(ByteBuffer[] srcs, int offset, int length)
		{
			IntPtr intPtr = JNIEnv.NewArray<ByteBuffer>(srcs);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(offset);
				ptr[2] = new JniArgumentValue(length);
				result = FileChannelInvoker._members.InstanceMethods.InvokeAbstractInt64Method("write.([Ljava/nio/ByteBuffer;II)J", this, ptr);
			}
			finally
			{
				if (srcs != null)
				{
					JNIEnv.CopyArray<ByteBuffer>(intPtr, srcs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(srcs);
			}
			return result;
		}

		// Token: 0x040010BE RID: 4286
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/FileChannel", typeof(FileChannelInvoker));
	}
}
