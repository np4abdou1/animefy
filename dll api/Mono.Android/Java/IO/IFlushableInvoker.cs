using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x0200041A RID: 1050
	[Register("java/io/Flushable", DoNotGenerateAcw = true)]
	internal class IFlushableInvoker : Java.Lang.Object, IFlushable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x0007DE50 File Offset: 0x0007C050
		private static IntPtr java_class_ref
		{
			get
			{
				return IFlushableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x0007DE74 File Offset: 0x0007C074
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFlushableInvoker._members;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x0007DE7B File Offset: 0x0007C07B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x0007DE83 File Offset: 0x0007C083
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFlushableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x0007DE8F File Offset: 0x0007C08F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFlushableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.io.Flushable'.");
			}
			return handle;
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x0007DEBA File Offset: 0x0007C0BA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x0007DEEC File Offset: 0x0007C0EC
		public IFlushableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFlushableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x0007DF24 File Offset: 0x0007C124
		private static Delegate GetFlushHandler()
		{
			if (IFlushableInvoker.cb_flush == null)
			{
				IFlushableInvoker.cb_flush = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IFlushableInvoker.n_Flush));
			}
			return IFlushableInvoker.cb_flush;
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x0007DF48 File Offset: 0x0007C148
		private static void n_Flush(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IFlushable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Flush();
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x0007DF57 File Offset: 0x0007C157
		public void Flush()
		{
			if (this.id_flush == IntPtr.Zero)
			{
				this.id_flush = JNIEnv.GetMethodID(this.class_ref, "flush", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_flush);
		}

		// Token: 0x04001212 RID: 4626
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/Flushable", typeof(IFlushableInvoker));

		// Token: 0x04001213 RID: 4627
		private IntPtr class_ref;

		// Token: 0x04001214 RID: 4628
		private static Delegate cb_flush;

		// Token: 0x04001215 RID: 4629
		private IntPtr id_flush;
	}
}
