using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x0200009D RID: 157
	[Register("com/unity3d/services/core/request/CancelableThreadPoolExecutor", DoNotGenerateAcw = true)]
	public class CancelableThreadPoolExecutor : ThreadPoolExecutor
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00010374 File Offset: 0x0000E574
		internal static IntPtr class_ref
		{
			get
			{
				return CancelableThreadPoolExecutor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00010398 File Offset: 0x0000E598
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancelableThreadPoolExecutor._members;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x000103A0 File Offset: 0x0000E5A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CancelableThreadPoolExecutor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000103C4 File Offset: 0x0000E5C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancelableThreadPoolExecutor._members.ManagedPeerType;
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000103D0 File Offset: 0x0000E5D0
		protected CancelableThreadPoolExecutor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000103DC File Offset: 0x0000E5DC
		[Register(".ctor", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/LinkedBlockingQueue;)V", "")]
		public unsafe CancelableThreadPoolExecutor(int corePoolSize, int maximumPoolSize, long keepAliveTime, TimeUnit unit, LinkedBlockingQueue queue) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(corePoolSize);
				ptr[1] = new JniArgumentValue(maximumPoolSize);
				ptr[2] = new JniArgumentValue(keepAliveTime);
				ptr[3] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				ptr[4] = new JniArgumentValue((queue == null) ? IntPtr.Zero : queue.Handle);
				base.SetHandle(CancelableThreadPoolExecutor._members.InstanceMethods.StartCreateInstance("(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/LinkedBlockingQueue;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CancelableThreadPoolExecutor._members.InstanceMethods.FinishCreateInstance("(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/LinkedBlockingQueue;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
				GC.KeepAlive(queue);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000104FC File Offset: 0x0000E6FC
		private static Delegate GetCancelHandler()
		{
			if (CancelableThreadPoolExecutor.cb_cancel == null)
			{
				CancelableThreadPoolExecutor.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CancelableThreadPoolExecutor.n_Cancel));
			}
			return CancelableThreadPoolExecutor.cb_cancel;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00010520 File Offset: 0x0000E720
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CancelableThreadPoolExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001052F File Offset: 0x0000E72F
		[Register("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel()
		{
			CancelableThreadPoolExecutor._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x0400014D RID: 333
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/CancelableThreadPoolExecutor", typeof(CancelableThreadPoolExecutor));

		// Token: 0x0400014E RID: 334
		private static Delegate cb_cancel;
	}
}
