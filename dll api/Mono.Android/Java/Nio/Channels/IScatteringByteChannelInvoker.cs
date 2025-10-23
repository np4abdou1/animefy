using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x020003A4 RID: 932
	[Register("java/nio/channels/ScatteringByteChannel", DoNotGenerateAcw = true)]
	internal class IScatteringByteChannelInvoker : Java.Lang.Object, IScatteringByteChannel, IReadableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x00074388 File Offset: 0x00072588
		private static IntPtr java_class_ref
		{
			get
			{
				return IScatteringByteChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x000743AC File Offset: 0x000725AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScatteringByteChannelInvoker._members;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x000743B3 File Offset: 0x000725B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000743BB File Offset: 0x000725BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScatteringByteChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000743C7 File Offset: 0x000725C7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScatteringByteChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.channels.ScatteringByteChannel'.");
			}
			return handle;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000743F2 File Offset: 0x000725F2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00074424 File Offset: 0x00072624
		public IScatteringByteChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScatteringByteChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x0007445C File Offset: 0x0007265C
		private static Delegate GetRead_arrayLjava_nio_ByteBuffer_Handler()
		{
			if (IScatteringByteChannelInvoker.cb_read_arrayLjava_nio_ByteBuffer_ == null)
			{
				IScatteringByteChannelInvoker.cb_read_arrayLjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(IScatteringByteChannelInvoker.n_Read_arrayLjava_nio_ByteBuffer_));
			}
			return IScatteringByteChannelInvoker.cb_read_arrayLjava_nio_ByteBuffer_;
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00074480 File Offset: 0x00072680
		private static long n_Read_arrayLjava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_dsts)
		{
			IScatteringByteChannel @object = Java.Lang.Object.GetObject<IScatteringByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer[] array = (ByteBuffer[])JNIEnv.GetArray(native_dsts, JniHandleOwnership.DoNotTransfer, typeof(ByteBuffer));
			long result = @object.Read(array);
			if (array != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(array, native_dsts);
			}
			return result;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x000744BC File Offset: 0x000726BC
		public unsafe long Read(ByteBuffer[] dsts)
		{
			if (this.id_read_arrayLjava_nio_ByteBuffer_ == IntPtr.Zero)
			{
				this.id_read_arrayLjava_nio_ByteBuffer_ = JNIEnv.GetMethodID(this.class_ref, "read", "([Ljava/nio/ByteBuffer;)J");
			}
			IntPtr intPtr = JNIEnv.NewArray<ByteBuffer>(dsts);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			long result = JNIEnv.CallLongMethod(base.Handle, this.id_read_arrayLjava_nio_ByteBuffer_, ptr);
			if (dsts != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(intPtr, dsts);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00074537 File Offset: 0x00072737
		private static Delegate GetRead_arrayLjava_nio_ByteBuffer_IIHandler()
		{
			if (IScatteringByteChannelInvoker.cb_read_arrayLjava_nio_ByteBuffer_II == null)
			{
				IScatteringByteChannelInvoker.cb_read_arrayLjava_nio_ByteBuffer_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_J(IScatteringByteChannelInvoker.n_Read_arrayLjava_nio_ByteBuffer_II));
			}
			return IScatteringByteChannelInvoker.cb_read_arrayLjava_nio_ByteBuffer_II;
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x0007455C File Offset: 0x0007275C
		private static long n_Read_arrayLjava_nio_ByteBuffer_II(IntPtr jnienv, IntPtr native__this, IntPtr native_dsts, int offset, int length)
		{
			IScatteringByteChannel @object = Java.Lang.Object.GetObject<IScatteringByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer[] array = (ByteBuffer[])JNIEnv.GetArray(native_dsts, JniHandleOwnership.DoNotTransfer, typeof(ByteBuffer));
			long result = @object.Read(array, offset, length);
			if (array != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(array, native_dsts);
			}
			return result;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0007459C File Offset: 0x0007279C
		public unsafe long Read(ByteBuffer[] dsts, int offset, int length)
		{
			if (this.id_read_arrayLjava_nio_ByteBuffer_II == IntPtr.Zero)
			{
				this.id_read_arrayLjava_nio_ByteBuffer_II = JNIEnv.GetMethodID(this.class_ref, "read", "([Ljava/nio/ByteBuffer;II)J");
			}
			IntPtr intPtr = JNIEnv.NewArray<ByteBuffer>(dsts);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(offset);
			ptr[2] = new JValue(length);
			long result = JNIEnv.CallLongMethod(base.Handle, this.id_read_arrayLjava_nio_ByteBuffer_II, ptr);
			if (dsts != null)
			{
				JNIEnv.CopyArray<ByteBuffer>(intPtr, dsts);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x00074640 File Offset: 0x00072840
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

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x000746B3 File Offset: 0x000728B3
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

		// Token: 0x06002938 RID: 10552 RVA: 0x000746F3 File Offset: 0x000728F3
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x040010DF RID: 4319
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/ScatteringByteChannel", typeof(IScatteringByteChannelInvoker));

		// Token: 0x040010E0 RID: 4320
		private IntPtr class_ref;

		// Token: 0x040010E1 RID: 4321
		private static Delegate cb_read_arrayLjava_nio_ByteBuffer_;

		// Token: 0x040010E2 RID: 4322
		private IntPtr id_read_arrayLjava_nio_ByteBuffer_;

		// Token: 0x040010E3 RID: 4323
		private static Delegate cb_read_arrayLjava_nio_ByteBuffer_II;

		// Token: 0x040010E4 RID: 4324
		private IntPtr id_read_arrayLjava_nio_ByteBuffer_II;

		// Token: 0x040010E5 RID: 4325
		private IntPtr id_read_Ljava_nio_ByteBuffer_;

		// Token: 0x040010E6 RID: 4326
		private IntPtr id_isOpen;

		// Token: 0x040010E7 RID: 4327
		private IntPtr id_close;
	}
}
