using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x0200039E RID: 926
	[Register("java/nio/channels/GatheringByteChannel", DoNotGenerateAcw = true)]
	internal class IGatheringByteChannelInvoker : Java.Lang.Object, IGatheringByteChannel, IWritableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x00073BF0 File Offset: 0x00071DF0
		private static IntPtr java_class_ref
		{
			get
			{
				return IGatheringByteChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x00073C14 File Offset: 0x00071E14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGatheringByteChannelInvoker._members;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x00073C1B File Offset: 0x00071E1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x00073C23 File Offset: 0x00071E23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGatheringByteChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00073C2F File Offset: 0x00071E2F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGatheringByteChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.channels.GatheringByteChannel'.");
			}
			return handle;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00073C5A File Offset: 0x00071E5A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00073C8C File Offset: 0x00071E8C
		public IGatheringByteChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGatheringByteChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x00073CC4 File Offset: 0x00071EC4
		private static Delegate GetWrite_arrayLjava_nio_ByteBuffer_Handler()
		{
			if (IGatheringByteChannelInvoker.cb_write_arrayLjava_nio_ByteBuffer_ == null)
			{
				IGatheringByteChannelInvoker.cb_write_arrayLjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(IGatheringByteChannelInvoker.n_Write_arrayLjava_nio_ByteBuffer_));
			}
			return IGatheringByteChannelInvoker.cb_write_arrayLjava_nio_ByteBuffer_;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00073CE8 File Offset: 0x00071EE8
		private static long n_Write_arrayLjava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_srcs)
		{
			IGatheringByteChannel @object = Java.Lang.Object.GetObject<IGatheringByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer[] array = (ByteBuffer[])JNIEnv.GetArray(native_srcs, JniHandleOwnership.DoNotTransfer, typeof(ByteBuffer));
			long result = @object.Write(array);
			if (array != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(array, native_srcs);
			}
			return result;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00073D24 File Offset: 0x00071F24
		public unsafe long Write(ByteBuffer[] srcs)
		{
			if (this.id_write_arrayLjava_nio_ByteBuffer_ == IntPtr.Zero)
			{
				this.id_write_arrayLjava_nio_ByteBuffer_ = JNIEnv.GetMethodID(this.class_ref, "write", "([Ljava/nio/ByteBuffer;)J");
			}
			IntPtr intPtr = JNIEnv.NewArray<ByteBuffer>(srcs);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			long result = JNIEnv.CallLongMethod(base.Handle, this.id_write_arrayLjava_nio_ByteBuffer_, ptr);
			if (srcs != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(intPtr, srcs);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00073D9F File Offset: 0x00071F9F
		private static Delegate GetWrite_arrayLjava_nio_ByteBuffer_IIHandler()
		{
			if (IGatheringByteChannelInvoker.cb_write_arrayLjava_nio_ByteBuffer_II == null)
			{
				IGatheringByteChannelInvoker.cb_write_arrayLjava_nio_ByteBuffer_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_J(IGatheringByteChannelInvoker.n_Write_arrayLjava_nio_ByteBuffer_II));
			}
			return IGatheringByteChannelInvoker.cb_write_arrayLjava_nio_ByteBuffer_II;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00073DC4 File Offset: 0x00071FC4
		private static long n_Write_arrayLjava_nio_ByteBuffer_II(IntPtr jnienv, IntPtr native__this, IntPtr native_srcs, int offset, int length)
		{
			IGatheringByteChannel @object = Java.Lang.Object.GetObject<IGatheringByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer[] array = (ByteBuffer[])JNIEnv.GetArray(native_srcs, JniHandleOwnership.DoNotTransfer, typeof(ByteBuffer));
			long result = @object.Write(array, offset, length);
			if (array != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(array, native_srcs);
			}
			return result;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00073E04 File Offset: 0x00072004
		public unsafe long Write(ByteBuffer[] srcs, int offset, int length)
		{
			if (this.id_write_arrayLjava_nio_ByteBuffer_II == IntPtr.Zero)
			{
				this.id_write_arrayLjava_nio_ByteBuffer_II = JNIEnv.GetMethodID(this.class_ref, "write", "([Ljava/nio/ByteBuffer;II)J");
			}
			IntPtr intPtr = JNIEnv.NewArray<ByteBuffer>(srcs);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(offset);
			ptr[2] = new JValue(length);
			long result = JNIEnv.CallLongMethod(base.Handle, this.id_write_arrayLjava_nio_ByteBuffer_II, ptr);
			if (srcs != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(intPtr, srcs);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x00073EA8 File Offset: 0x000720A8
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

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x00073F1B File Offset: 0x0007211B
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

		// Token: 0x0600290A RID: 10506 RVA: 0x00073F5B File Offset: 0x0007215B
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x040010CB RID: 4299
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/GatheringByteChannel", typeof(IGatheringByteChannelInvoker));

		// Token: 0x040010CC RID: 4300
		private IntPtr class_ref;

		// Token: 0x040010CD RID: 4301
		private static Delegate cb_write_arrayLjava_nio_ByteBuffer_;

		// Token: 0x040010CE RID: 4302
		private IntPtr id_write_arrayLjava_nio_ByteBuffer_;

		// Token: 0x040010CF RID: 4303
		private static Delegate cb_write_arrayLjava_nio_ByteBuffer_II;

		// Token: 0x040010D0 RID: 4304
		private IntPtr id_write_arrayLjava_nio_ByteBuffer_II;

		// Token: 0x040010D1 RID: 4305
		private IntPtr id_write_Ljava_nio_ByteBuffer_;

		// Token: 0x040010D2 RID: 4306
		private IntPtr id_isOpen;

		// Token: 0x040010D3 RID: 4307
		private IntPtr id_close;
	}
}
