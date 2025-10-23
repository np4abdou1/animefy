using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x0200039A RID: 922
	[Register("java/nio/channels/ByteChannel", DoNotGenerateAcw = true)]
	internal class IByteChannelInvoker : Java.Lang.Object, IByteChannel, IReadableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IWritableByteChannel
	{
		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x000737C0 File Offset: 0x000719C0
		private static IntPtr java_class_ref
		{
			get
			{
				return IByteChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x000737E4 File Offset: 0x000719E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IByteChannelInvoker._members;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x000737EB File Offset: 0x000719EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x000737F3 File Offset: 0x000719F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IByteChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000737FF File Offset: 0x000719FF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IByteChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.channels.ByteChannel'.");
			}
			return handle;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x0007382A File Offset: 0x00071A2A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x0007385C File Offset: 0x00071A5C
		public IByteChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IByteChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00073894 File Offset: 0x00071A94
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

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x00073907 File Offset: 0x00071B07
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

		// Token: 0x060028E6 RID: 10470 RVA: 0x00073947 File Offset: 0x00071B47
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00073988 File Offset: 0x00071B88
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

		// Token: 0x040010BF RID: 4287
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/ByteChannel", typeof(IByteChannelInvoker));

		// Token: 0x040010C0 RID: 4288
		private IntPtr class_ref;

		// Token: 0x040010C1 RID: 4289
		private IntPtr id_read_Ljava_nio_ByteBuffer_;

		// Token: 0x040010C2 RID: 4290
		private IntPtr id_isOpen;

		// Token: 0x040010C3 RID: 4291
		private IntPtr id_close;

		// Token: 0x040010C4 RID: 4292
		private IntPtr id_write_Ljava_nio_ByteBuffer_;
	}
}
