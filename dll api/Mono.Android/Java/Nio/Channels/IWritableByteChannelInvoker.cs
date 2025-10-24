using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x020003A8 RID: 936
	[Register("java/nio/channels/WritableByteChannel", DoNotGenerateAcw = true)]
	internal class IWritableByteChannelInvoker : Java.Lang.Object, IWritableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x00074C68 File Offset: 0x00072E68
		private static IntPtr java_class_ref
		{
			get
			{
				return IWritableByteChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x00074C8C File Offset: 0x00072E8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWritableByteChannelInvoker._members;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x00074C93 File Offset: 0x00072E93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x00074C9B File Offset: 0x00072E9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWritableByteChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00074CA7 File Offset: 0x00072EA7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWritableByteChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.channels.WritableByteChannel'.");
			}
			return handle;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00074CD2 File Offset: 0x00072ED2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00074D04 File Offset: 0x00072F04
		public IWritableByteChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWritableByteChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00074D3C File Offset: 0x00072F3C
		private static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler()
		{
			if (IWritableByteChannelInvoker.cb_write_Ljava_nio_ByteBuffer_ == null)
			{
				IWritableByteChannelInvoker.cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IWritableByteChannelInvoker.n_Write_Ljava_nio_ByteBuffer_));
			}
			return IWritableByteChannelInvoker.cb_write_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00074D60 File Offset: 0x00072F60
		private static int n_Write_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			IWritableByteChannel @object = Java.Lang.Object.GetObject<IWritableByteChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_src, JniHandleOwnership.DoNotTransfer);
			return @object.Write(object2);
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00074D84 File Offset: 0x00072F84
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

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x00074DF7 File Offset: 0x00072FF7
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

		// Token: 0x06002968 RID: 10600 RVA: 0x00074E37 File Offset: 0x00073037
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x040010F8 RID: 4344
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/WritableByteChannel", typeof(IWritableByteChannelInvoker));

		// Token: 0x040010F9 RID: 4345
		private IntPtr class_ref;

		// Token: 0x040010FA RID: 4346
		private static Delegate cb_write_Ljava_nio_ByteBuffer_;

		// Token: 0x040010FB RID: 4347
		private IntPtr id_write_Ljava_nio_ByteBuffer_;

		// Token: 0x040010FC RID: 4348
		private IntPtr id_isOpen;

		// Token: 0x040010FD RID: 4349
		private IntPtr id_close;
	}
}
