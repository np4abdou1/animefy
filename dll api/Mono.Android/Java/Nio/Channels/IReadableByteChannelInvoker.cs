using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x020003A2 RID: 930
	[Register("java/nio/channels/ReadableByteChannel", DoNotGenerateAcw = true)]
	internal class IReadableByteChannelInvoker : Java.Lang.Object, IReadableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x0007415C File Offset: 0x0007235C
		private static IntPtr java_class_ref
		{
			get
			{
				return IReadableByteChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x00074180 File Offset: 0x00072380
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IReadableByteChannelInvoker._members;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x00074187 File Offset: 0x00072387
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x0007418F File Offset: 0x0007238F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IReadableByteChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0007419B File Offset: 0x0007239B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReadableByteChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.channels.ReadableByteChannel'.");
			}
			return handle;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000741C6 File Offset: 0x000723C6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000741F8 File Offset: 0x000723F8
		public IReadableByteChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReadableByteChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00074230 File Offset: 0x00072430
		private static Delegate GetRead_Ljava_nio_ByteBuffer_Handler()
		{
			if (IReadableByteChannelInvoker.cb_read_Ljava_nio_ByteBuffer_ == null)
			{
				IReadableByteChannelInvoker.cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IReadableByteChannelInvoker.n_Read_Ljava_nio_ByteBuffer_));
			}
			return IReadableByteChannelInvoker.cb_read_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00074254 File Offset: 0x00072454
		private static int n_Read_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			IReadableByteChannel @object = Java.Lang.Object.GetObject<IReadableByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_dst, JniHandleOwnership.DoNotTransfer);
			return @object.Read(object2);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00074278 File Offset: 0x00072478
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x000742EB File Offset: 0x000724EB
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

		// Token: 0x06002925 RID: 10533 RVA: 0x0007432B File Offset: 0x0007252B
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x040010D9 RID: 4313
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/ReadableByteChannel", typeof(IReadableByteChannelInvoker));

		// Token: 0x040010DA RID: 4314
		private IntPtr class_ref;

		// Token: 0x040010DB RID: 4315
		private static Delegate cb_read_Ljava_nio_ByteBuffer_;

		// Token: 0x040010DC RID: 4316
		private IntPtr id_read_Ljava_nio_ByteBuffer_;

		// Token: 0x040010DD RID: 4317
		private IntPtr id_isOpen;

		// Token: 0x040010DE RID: 4318
		private IntPtr id_close;
	}
}
