using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x020003A0 RID: 928
	[Register("java/nio/channels/InterruptibleChannel", DoNotGenerateAcw = true)]
	internal class IInterruptibleChannelInvoker : Java.Lang.Object, IInterruptibleChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x00073FB8 File Offset: 0x000721B8
		private static IntPtr java_class_ref
		{
			get
			{
				return IInterruptibleChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x00073FDC File Offset: 0x000721DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInterruptibleChannelInvoker._members;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x00073FE3 File Offset: 0x000721E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x00073FEB File Offset: 0x000721EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInterruptibleChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00073FF7 File Offset: 0x000721F7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInterruptibleChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.channels.InterruptibleChannel'.");
			}
			return handle;
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00074022 File Offset: 0x00072222
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00074054 File Offset: 0x00072254
		public IInterruptibleChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInterruptibleChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x0007408C File Offset: 0x0007228C
		private static Delegate GetCloseHandler()
		{
			if (IInterruptibleChannelInvoker.cb_close == null)
			{
				IInterruptibleChannelInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInterruptibleChannelInvoker.n_Close));
			}
			return IInterruptibleChannelInvoker.cb_close;
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000740B0 File Offset: 0x000722B0
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInterruptibleChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000740BF File Offset: 0x000722BF
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000740FF File Offset: 0x000722FF
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

		// Token: 0x040010D4 RID: 4308
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/InterruptibleChannel", typeof(IInterruptibleChannelInvoker));

		// Token: 0x040010D5 RID: 4309
		private IntPtr class_ref;

		// Token: 0x040010D6 RID: 4310
		private static Delegate cb_close;

		// Token: 0x040010D7 RID: 4311
		private IntPtr id_close;

		// Token: 0x040010D8 RID: 4312
		private IntPtr id_isOpen;
	}
}
