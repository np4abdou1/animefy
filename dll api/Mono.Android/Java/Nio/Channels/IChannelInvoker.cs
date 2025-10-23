using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels
{
	// Token: 0x0200039C RID: 924
	[Register("java/nio/channels/Channel", DoNotGenerateAcw = true)]
	internal class IChannelInvoker : Java.Lang.Object, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x00073A18 File Offset: 0x00071C18
		private static IntPtr java_class_ref
		{
			get
			{
				return IChannelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x00073A3C File Offset: 0x00071C3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IChannelInvoker._members;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x00073A43 File Offset: 0x00071C43
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x00073A4B File Offset: 0x00071C4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00073A57 File Offset: 0x00071C57
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IChannelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.channels.Channel'.");
			}
			return handle;
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00073A82 File Offset: 0x00071C82
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00073AB4 File Offset: 0x00071CB4
		public IChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IChannelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00073AEC File Offset: 0x00071CEC
		private static Delegate GetIsOpenHandler()
		{
			if (IChannelInvoker.cb_isOpen == null)
			{
				IChannelInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IChannelInvoker.n_IsOpen));
			}
			return IChannelInvoker.cb_isOpen;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00073B10 File Offset: 0x00071D10
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x00073B1F File Offset: 0x00071D1F
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

		// Token: 0x060028F5 RID: 10485 RVA: 0x00073B5F File Offset: 0x00071D5F
		private static Delegate GetCloseHandler()
		{
			if (IChannelInvoker.cb_close == null)
			{
				IChannelInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IChannelInvoker.n_Close));
			}
			return IChannelInvoker.cb_close;
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00073B83 File Offset: 0x00071D83
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IChannel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00073B92 File Offset: 0x00071D92
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x040010C5 RID: 4293
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/Channel", typeof(IChannelInvoker));

		// Token: 0x040010C6 RID: 4294
		private IntPtr class_ref;

		// Token: 0x040010C7 RID: 4295
		private static Delegate cb_isOpen;

		// Token: 0x040010C8 RID: 4296
		private IntPtr id_isOpen;

		// Token: 0x040010C9 RID: 4297
		private static Delegate cb_close;

		// Token: 0x040010CA RID: 4298
		private IntPtr id_close;
	}
}
