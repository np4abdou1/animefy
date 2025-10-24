using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000418 RID: 1048
	[Register("java/io/Closeable", DoNotGenerateAcw = true)]
	internal class ICloseableInvoker : Java.Lang.Object, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x0007DCEC File Offset: 0x0007BEEC
		private static IntPtr java_class_ref
		{
			get
			{
				return ICloseableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x0007DD10 File Offset: 0x0007BF10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICloseableInvoker._members;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x0007DD17 File Offset: 0x0007BF17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x0007DD1F File Offset: 0x0007BF1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICloseableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x0007DD2B File Offset: 0x0007BF2B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICloseableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.io.Closeable'.");
			}
			return handle;
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x0007DD56 File Offset: 0x0007BF56
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x0007DD88 File Offset: 0x0007BF88
		public ICloseableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICloseableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x0007DDC0 File Offset: 0x0007BFC0
		private static Delegate GetCloseHandler()
		{
			if (ICloseableInvoker.cb_close == null)
			{
				ICloseableInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICloseableInvoker.n_Close));
			}
			return ICloseableInvoker.cb_close;
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x0007DDE4 File Offset: 0x0007BFE4
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICloseable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x0007DDF3 File Offset: 0x0007BFF3
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x0400120E RID: 4622
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/Closeable", typeof(ICloseableInvoker));

		// Token: 0x0400120F RID: 4623
		private IntPtr class_ref;

		// Token: 0x04001210 RID: 4624
		private static Delegate cb_close;

		// Token: 0x04001211 RID: 4625
		private IntPtr id_close;
	}
}
