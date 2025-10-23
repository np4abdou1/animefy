using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000348 RID: 840
	[Register("java/util/concurrent/Callable", DoNotGenerateAcw = true)]
	internal class ICallableInvoker : Java.Lang.Object, ICallable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x00067670 File Offset: 0x00065870
		private static IntPtr java_class_ref
		{
			get
			{
				return ICallableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x00067694 File Offset: 0x00065894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICallableInvoker._members;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x0006769B File Offset: 0x0006589B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x000676A3 File Offset: 0x000658A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICallableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x000676AF File Offset: 0x000658AF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICallableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.Callable'.");
			}
			return handle;
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x000676DA File Offset: 0x000658DA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x0006770C File Offset: 0x0006590C
		public ICallableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICallableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00067744 File Offset: 0x00065944
		private static Delegate GetCallHandler()
		{
			if (ICallableInvoker.cb_call == null)
			{
				ICallableInvoker.cb_call = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICallableInvoker.n_Call));
			}
			return ICallableInvoker.cb_call;
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00067768 File Offset: 0x00065968
		private static IntPtr n_Call(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICallable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Call());
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0006777C File Offset: 0x0006597C
		public Java.Lang.Object Call()
		{
			if (this.id_call == IntPtr.Zero)
			{
				this.id_call = JNIEnv.GetMethodID(this.class_ref, "call", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_call), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000EF0 RID: 3824
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/Callable", typeof(ICallableInvoker));

		// Token: 0x04000EF1 RID: 3825
		private IntPtr class_ref;

		// Token: 0x04000EF2 RID: 3826
		private static Delegate cb_call;

		// Token: 0x04000EF3 RID: 3827
		private IntPtr id_call;
	}
}
