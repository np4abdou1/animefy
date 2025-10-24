using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000099 RID: 153
	[Register("com/unity3d/services/core/timer/ITimerListener", DoNotGenerateAcw = true)]
	internal class ITimerListenerInvoker : Java.Lang.Object, ITimerListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000FD50 File Offset: 0x0000DF50
		private static IntPtr java_class_ref
		{
			get
			{
				return ITimerListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000FD74 File Offset: 0x0000DF74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITimerListenerInvoker._members;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0000FD7B File Offset: 0x0000DF7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0000FD83 File Offset: 0x0000DF83
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITimerListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000FD8F File Offset: 0x0000DF8F
		public static ITimerListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITimerListener>(handle, transfer);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000FD98 File Offset: 0x0000DF98
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITimerListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.timer.ITimerListener'.");
			}
			return handle;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000FDC3 File Offset: 0x0000DFC3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
		public ITimerListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITimerListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000FE2C File Offset: 0x0000E02C
		private static Delegate GetOnTimerFinishedHandler()
		{
			if (ITimerListenerInvoker.cb_onTimerFinished == null)
			{
				ITimerListenerInvoker.cb_onTimerFinished = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ITimerListenerInvoker.n_OnTimerFinished));
			}
			return ITimerListenerInvoker.cb_onTimerFinished;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000FE50 File Offset: 0x0000E050
		private static void n_OnTimerFinished(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ITimerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTimerFinished();
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000FE5F File Offset: 0x0000E05F
		public void OnTimerFinished()
		{
			if (this.id_onTimerFinished == IntPtr.Zero)
			{
				this.id_onTimerFinished = JNIEnv.GetMethodID(this.class_ref, "onTimerFinished", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onTimerFinished);
		}

		// Token: 0x04000143 RID: 323
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/timer/ITimerListener", typeof(ITimerListenerInvoker));

		// Token: 0x04000144 RID: 324
		private IntPtr class_ref;

		// Token: 0x04000145 RID: 325
		private static Delegate cb_onTimerFinished;

		// Token: 0x04000146 RID: 326
		private IntPtr id_onTimerFinished;
	}
}
