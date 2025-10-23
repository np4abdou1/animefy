using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x020003A6 RID: 934
	[Register("java/nio/channels/SeekableByteChannel", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class ISeekableByteChannelInvoker : Java.Lang.Object, ISeekableByteChannel, IByteChannel, IReadableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IWritableByteChannel
	{
		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x00074750 File Offset: 0x00072950
		private static IntPtr java_class_ref
		{
			get
			{
				return ISeekableByteChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x00074774 File Offset: 0x00072974
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISeekableByteChannelInvoker._members;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x0007477B File Offset: 0x0007297B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x00074783 File Offset: 0x00072983
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISeekableByteChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x0007478F File Offset: 0x0007298F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISeekableByteChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.channels.SeekableByteChannel'.");
			}
			return handle;
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000747BA File Offset: 0x000729BA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x000747EC File Offset: 0x000729EC
		public ISeekableByteChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISeekableByteChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00074824 File Offset: 0x00072A24
		private static Delegate GetPositionHandler()
		{
			if (ISeekableByteChannelInvoker.cb_position == null)
			{
				ISeekableByteChannelInvoker.cb_position = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(ISeekableByteChannelInvoker.n_Position));
			}
			return ISeekableByteChannelInvoker.cb_position;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00074848 File Offset: 0x00072A48
		private static long n_Position(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISeekableByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Position();
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00074857 File Offset: 0x00072A57
		public long Position()
		{
			if (this.id_position == IntPtr.Zero)
			{
				this.id_position = JNIEnv.GetMethodID(this.class_ref, "position", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_position);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00074897 File Offset: 0x00072A97
		private static Delegate GetPosition_JHandler()
		{
			if (ISeekableByteChannelInvoker.cb_position_J == null)
			{
				ISeekableByteChannelInvoker.cb_position_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(ISeekableByteChannelInvoker.n_Position_J));
			}
			return ISeekableByteChannelInvoker.cb_position_J;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000748BB File Offset: 0x00072ABB
		private static IntPtr n_Position_J(IntPtr jnienv, IntPtr native__this, long newPosition)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISeekableByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Position(newPosition));
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000748D0 File Offset: 0x00072AD0
		public unsafe ISeekableByteChannel Position(long newPosition)
		{
			if (this.id_position_J == IntPtr.Zero)
			{
				this.id_position_J = JNIEnv.GetMethodID(this.class_ref, "position", "(J)Ljava/nio/channels/SeekableByteChannel;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(newPosition);
			return Java.Lang.Object.GetObject<ISeekableByteChannel>(JNIEnv.CallObjectMethod(base.Handle, this.id_position_J, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0007493A File Offset: 0x00072B3A
		private static Delegate GetRead_Ljava_nio_ByteBuffer_Handler()
		{
			if (ISeekableByteChannelInvoker.cb_read_Ljava_nio_ByteBuffer_ == null)
			{
				ISeekableByteChannelInvoker.cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ISeekableByteChannelInvoker.n_Read_Ljava_nio_ByteBuffer_));
			}
			return ISeekableByteChannelInvoker.cb_read_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00074960 File Offset: 0x00072B60
		private static int n_Read_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			ISeekableByteChannel @object = Java.Lang.Object.GetObject<ISeekableByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_dst, JniHandleOwnership.DoNotTransfer);
			return @object.Read(object2);
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00074984 File Offset: 0x00072B84
		public unsafe int Read(ByteBuffer dst)
		{
			if (this.id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
			{
				this.id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID(this.class_ref, "read", "(Ljava/nio/ByteBuffer;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((dst == null) ? IntPtr.Zero : dst.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_read_Ljava_nio_ByteBuffer_, ptr);
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000749F7 File Offset: 0x00072BF7
		private static Delegate GetSizeHandler()
		{
			if (ISeekableByteChannelInvoker.cb_size == null)
			{
				ISeekableByteChannelInvoker.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(ISeekableByteChannelInvoker.n_Size));
			}
			return ISeekableByteChannelInvoker.cb_size;
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00074A1B File Offset: 0x00072C1B
		private static long n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISeekableByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00074A2A File Offset: 0x00072C2A
		public long Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_size);
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00074A6A File Offset: 0x00072C6A
		private static Delegate GetTruncate_JHandler()
		{
			if (ISeekableByteChannelInvoker.cb_truncate_J == null)
			{
				ISeekableByteChannelInvoker.cb_truncate_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(ISeekableByteChannelInvoker.n_Truncate_J));
			}
			return ISeekableByteChannelInvoker.cb_truncate_J;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00074A8E File Offset: 0x00072C8E
		private static IntPtr n_Truncate_J(IntPtr jnienv, IntPtr native__this, long size)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISeekableByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Truncate(size));
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00074AA4 File Offset: 0x00072CA4
		public unsafe ISeekableByteChannel Truncate(long size)
		{
			if (this.id_truncate_J == IntPtr.Zero)
			{
				this.id_truncate_J = JNIEnv.GetMethodID(this.class_ref, "truncate", "(J)Ljava/nio/channels/SeekableByteChannel;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(size);
			return Java.Lang.Object.GetObject<ISeekableByteChannel>(JNIEnv.CallObjectMethod(base.Handle, this.id_truncate_J, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00074B0E File Offset: 0x00072D0E
		private static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler()
		{
			if (ISeekableByteChannelInvoker.cb_write_Ljava_nio_ByteBuffer_ == null)
			{
				ISeekableByteChannelInvoker.cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ISeekableByteChannelInvoker.n_Write_Ljava_nio_ByteBuffer_));
			}
			return ISeekableByteChannelInvoker.cb_write_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00074B34 File Offset: 0x00072D34
		private static int n_Write_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			ISeekableByteChannel @object = Java.Lang.Object.GetObject<ISeekableByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_src, JniHandleOwnership.DoNotTransfer);
			return @object.Write(object2);
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00074B58 File Offset: 0x00072D58
		public unsafe int Write(ByteBuffer src)
		{
			if (this.id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
			{
				this.id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID(this.class_ref, "write", "(Ljava/nio/ByteBuffer;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((src == null) ? IntPtr.Zero : src.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_write_Ljava_nio_ByteBuffer_, ptr);
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x00074BCB File Offset: 0x00072DCB
		public bool IsOpen
		{
			get
			{
				if (this.id_isOpen == IntPtr.Zero)
				{
					this.id_isOpen = JNIEnv.GetMethodID(this.class_ref, "isOpen", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOpen);
			}
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00074C0B File Offset: 0x00072E0B
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x040010E8 RID: 4328
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/SeekableByteChannel", typeof(ISeekableByteChannelInvoker));

		// Token: 0x040010E9 RID: 4329
		private IntPtr class_ref;

		// Token: 0x040010EA RID: 4330
		private static Delegate cb_position;

		// Token: 0x040010EB RID: 4331
		private IntPtr id_position;

		// Token: 0x040010EC RID: 4332
		private static Delegate cb_position_J;

		// Token: 0x040010ED RID: 4333
		private IntPtr id_position_J;

		// Token: 0x040010EE RID: 4334
		private static Delegate cb_read_Ljava_nio_ByteBuffer_;

		// Token: 0x040010EF RID: 4335
		private IntPtr id_read_Ljava_nio_ByteBuffer_;

		// Token: 0x040010F0 RID: 4336
		private static Delegate cb_size;

		// Token: 0x040010F1 RID: 4337
		private IntPtr id_size;

		// Token: 0x040010F2 RID: 4338
		private static Delegate cb_truncate_J;

		// Token: 0x040010F3 RID: 4339
		private IntPtr id_truncate_J;

		// Token: 0x040010F4 RID: 4340
		private static Delegate cb_write_Ljava_nio_ByteBuffer_;

		// Token: 0x040010F5 RID: 4341
		private IntPtr id_write_Ljava_nio_ByteBuffer_;

		// Token: 0x040010F6 RID: 4342
		private IntPtr id_isOpen;

		// Token: 0x040010F7 RID: 4343
		private IntPtr id_close;
	}
}
