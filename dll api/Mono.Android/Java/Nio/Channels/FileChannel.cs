using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Nio.Channels.Spi;

namespace Java.Nio.Channels
{
	// Token: 0x02000397 RID: 919
	[Register("java/nio/channels/FileChannel", DoNotGenerateAcw = true)]
	public abstract class FileChannel : AbstractInterruptibleChannel, IByteChannel, IReadableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IWritableByteChannel, IGatheringByteChannel, IScatteringByteChannel, ISeekableByteChannel
	{
		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x00073137 File Offset: 0x00071337
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileChannel._members;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x00073140 File Offset: 0x00071340
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileChannel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x00073164 File Offset: 0x00071364
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileChannel._members.ManagedPeerType;
			}
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00073170 File Offset: 0x00071370
		protected FileChannel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0007317A File Offset: 0x0007137A
		private static Delegate GetPositionHandler()
		{
			if (FileChannel.cb_position == null)
			{
				FileChannel.cb_position = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(FileChannel.n_Position));
			}
			return FileChannel.cb_position;
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x0007319E File Offset: 0x0007139E
		private static long n_Position(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FileChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Position();
		}

		// Token: 0x060028B6 RID: 10422
		public abstract long Position();

		// Token: 0x060028B7 RID: 10423 RVA: 0x000731AD File Offset: 0x000713AD
		private static Delegate GetPosition_JHandler()
		{
			if (FileChannel.cb_position_J == null)
			{
				FileChannel.cb_position_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(FileChannel.n_Position_J));
			}
			return FileChannel.cb_position_J;
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000731D1 File Offset: 0x000713D1
		private static IntPtr n_Position_J(IntPtr jnienv, IntPtr native__this, long newPosition)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FileChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Position(newPosition));
		}

		// Token: 0x060028B9 RID: 10425
		public abstract FileChannel Position(long newPosition);

		// Token: 0x060028BA RID: 10426 RVA: 0x000731E6 File Offset: 0x000713E6
		private static Delegate GetRead_Ljava_nio_ByteBuffer_Handler()
		{
			if (FileChannel.cb_read_Ljava_nio_ByteBuffer_ == null)
			{
				FileChannel.cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(FileChannel.n_Read_Ljava_nio_ByteBuffer_));
			}
			return FileChannel.cb_read_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0007320C File Offset: 0x0007140C
		private static int n_Read_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			FileChannel @object = Java.Lang.Object.GetObject<FileChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_dst, JniHandleOwnership.DoNotTransfer);
			return @object.Read(object2);
		}

		// Token: 0x060028BC RID: 10428
		public abstract int Read(ByteBuffer dst);

		// Token: 0x060028BD RID: 10429 RVA: 0x00073230 File Offset: 0x00071430
		public unsafe long Read(ByteBuffer[] dsts)
		{
			IntPtr intPtr = JNIEnv.NewArray<ByteBuffer>(dsts);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = FileChannel._members.InstanceMethods.InvokeNonvirtualInt64Method("read.([Ljava/nio/ByteBuffer;)J", this, ptr);
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

		// Token: 0x060028BE RID: 10430 RVA: 0x000732A0 File Offset: 0x000714A0
		private static Delegate GetRead_arrayLjava_nio_ByteBuffer_IIHandler()
		{
			if (FileChannel.cb_read_arrayLjava_nio_ByteBuffer_II == null)
			{
				FileChannel.cb_read_arrayLjava_nio_ByteBuffer_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_J(FileChannel.n_Read_arrayLjava_nio_ByteBuffer_II));
			}
			return FileChannel.cb_read_arrayLjava_nio_ByteBuffer_II;
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000732C4 File Offset: 0x000714C4
		private static long n_Read_arrayLjava_nio_ByteBuffer_II(IntPtr jnienv, IntPtr native__this, IntPtr native_dsts, int offset, int length)
		{
			FileChannel @object = Java.Lang.Object.GetObject<FileChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer[] array = (ByteBuffer[])JNIEnv.GetArray(native_dsts, JniHandleOwnership.DoNotTransfer, typeof(ByteBuffer));
			long result = @object.Read(array, offset, length);
			if (array != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(array, native_dsts);
			}
			return result;
		}

		// Token: 0x060028C0 RID: 10432
		public abstract long Read(ByteBuffer[] dsts, int offset, int length);

		// Token: 0x060028C1 RID: 10433 RVA: 0x00073303 File Offset: 0x00071503
		private static Delegate GetSizeHandler()
		{
			if (FileChannel.cb_size == null)
			{
				FileChannel.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(FileChannel.n_Size));
			}
			return FileChannel.cb_size;
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x00073327 File Offset: 0x00071527
		private static long n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FileChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x060028C3 RID: 10435
		public abstract long Size();

		// Token: 0x060028C4 RID: 10436 RVA: 0x00073336 File Offset: 0x00071536
		private static Delegate GetTruncate_JHandler()
		{
			if (FileChannel.cb_truncate_J == null)
			{
				FileChannel.cb_truncate_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(FileChannel.n_Truncate_J));
			}
			return FileChannel.cb_truncate_J;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x0007335A File Offset: 0x0007155A
		private static IntPtr n_Truncate_J(IntPtr jnienv, IntPtr native__this, long size)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FileChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Truncate(size));
		}

		// Token: 0x060028C6 RID: 10438
		public abstract FileChannel Truncate(long size);

		// Token: 0x060028C7 RID: 10439 RVA: 0x0007336F File Offset: 0x0007156F
		private static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler()
		{
			if (FileChannel.cb_write_Ljava_nio_ByteBuffer_ == null)
			{
				FileChannel.cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(FileChannel.n_Write_Ljava_nio_ByteBuffer_));
			}
			return FileChannel.cb_write_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00073394 File Offset: 0x00071594
		private static int n_Write_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			FileChannel @object = Java.Lang.Object.GetObject<FileChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_src, JniHandleOwnership.DoNotTransfer);
			return @object.Write(object2);
		}

		// Token: 0x060028C9 RID: 10441
		public abstract int Write(ByteBuffer src);

		// Token: 0x060028CA RID: 10442 RVA: 0x000733B8 File Offset: 0x000715B8
		public unsafe long Write(ByteBuffer[] srcs)
		{
			IntPtr intPtr = JNIEnv.NewArray<ByteBuffer>(srcs);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = FileChannel._members.InstanceMethods.InvokeNonvirtualInt64Method("write.([Ljava/nio/ByteBuffer;)J", this, ptr);
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

		// Token: 0x060028CB RID: 10443 RVA: 0x00073428 File Offset: 0x00071628
		private static Delegate GetWrite_arrayLjava_nio_ByteBuffer_IIHandler()
		{
			if (FileChannel.cb_write_arrayLjava_nio_ByteBuffer_II == null)
			{
				FileChannel.cb_write_arrayLjava_nio_ByteBuffer_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_J(FileChannel.n_Write_arrayLjava_nio_ByteBuffer_II));
			}
			return FileChannel.cb_write_arrayLjava_nio_ByteBuffer_II;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0007344C File Offset: 0x0007164C
		private static long n_Write_arrayLjava_nio_ByteBuffer_II(IntPtr jnienv, IntPtr native__this, IntPtr native_srcs, int offset, int length)
		{
			FileChannel @object = Java.Lang.Object.GetObject<FileChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer[] array = (ByteBuffer[])JNIEnv.GetArray(native_srcs, JniHandleOwnership.DoNotTransfer, typeof(ByteBuffer));
			long result = @object.Write(array, offset, length);
			if (array != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(array, native_srcs);
			}
			return result;
		}

		// Token: 0x060028CD RID: 10445
		public abstract long Write(ByteBuffer[] srcs, int offset, int length);

		// Token: 0x060028CE RID: 10446 RVA: 0x0007348B File Offset: 0x0007168B
		ISeekableByteChannel ISeekableByteChannel.Position(long newPosition)
		{
			return this.Position(newPosition);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00073494 File Offset: 0x00071694
		ISeekableByteChannel ISeekableByteChannel.Truncate(long size)
		{
			return this.Truncate(size);
		}

		// Token: 0x040010B5 RID: 4277
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/FileChannel", typeof(FileChannel));

		// Token: 0x040010B6 RID: 4278
		private static Delegate cb_position;

		// Token: 0x040010B7 RID: 4279
		private static Delegate cb_position_J;

		// Token: 0x040010B8 RID: 4280
		private static Delegate cb_read_Ljava_nio_ByteBuffer_;

		// Token: 0x040010B9 RID: 4281
		private static Delegate cb_read_arrayLjava_nio_ByteBuffer_II;

		// Token: 0x040010BA RID: 4282
		private static Delegate cb_size;

		// Token: 0x040010BB RID: 4283
		private static Delegate cb_truncate_J;

		// Token: 0x040010BC RID: 4284
		private static Delegate cb_write_Ljava_nio_ByteBuffer_;

		// Token: 0x040010BD RID: 4285
		private static Delegate cb_write_arrayLjava_nio_ByteBuffer_II;
	}
}
