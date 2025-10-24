using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000095 RID: 149
	[Register("com/unity3d/services/core/timer/IIntervalTimerListener", DoNotGenerateAcw = true)]
	internal class IIntervalTimerListenerInvoker : Java.Lang.Object, IIntervalTimerListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0000F95C File Offset: 0x0000DB5C
		private static IntPtr java_class_ref
		{
			get
			{
				return IIntervalTimerListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0000F980 File Offset: 0x0000DB80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIntervalTimerListenerInvoker._members;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0000F987 File Offset: 0x0000DB87
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000F98F File Offset: 0x0000DB8F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIntervalTimerListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000F99B File Offset: 0x0000DB9B
		public static IIntervalTimerListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IIntervalTimerListener>(handle, transfer);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIntervalTimerListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.timer.IIntervalTimerListener'.");
			}
			return handle;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000F9CF File Offset: 0x0000DBCF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000FA00 File Offset: 0x0000DC00
		public IIntervalTimerListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIntervalTimerListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000FA38 File Offset: 0x0000DC38
		private static Delegate GetOnNextIntervalTriggeredHandler()
		{
			if (IIntervalTimerListenerInvoker.cb_onNextIntervalTriggered == null)
			{
				IIntervalTimerListenerInvoker.cb_onNextIntervalTriggered = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IIntervalTimerListenerInvoker.n_OnNextIntervalTriggered));
			}
			return IIntervalTimerListenerInvoker.cb_onNextIntervalTriggered;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000FA5C File Offset: 0x0000DC5C
		private static void n_OnNextIntervalTriggered(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IIntervalTimerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNextIntervalTriggered();
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000FA6B File Offset: 0x0000DC6B
		public void OnNextIntervalTriggered()
		{
			if (this.id_onNextIntervalTriggered == IntPtr.Zero)
			{
				this.id_onNextIntervalTriggered = JNIEnv.GetMethodID(this.class_ref, "onNextIntervalTriggered", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNextIntervalTriggered);
		}

		// Token: 0x0400013B RID: 315
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/timer/IIntervalTimerListener", typeof(IIntervalTimerListenerInvoker));

		// Token: 0x0400013C RID: 316
		private IntPtr class_ref;

		// Token: 0x0400013D RID: 317
		private static Delegate cb_onNextIntervalTriggered;

		// Token: 0x0400013E RID: 318
		private IntPtr id_onNextIntervalTriggered;
	}
}
