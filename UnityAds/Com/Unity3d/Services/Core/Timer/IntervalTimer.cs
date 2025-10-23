using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000097 RID: 151
	[Register("com/unity3d/services/core/timer/IntervalTimer", DoNotGenerateAcw = true)]
	public class IntervalTimer : BaseTimer, IIntervalTimer, IBaseTimer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0000FB34 File Offset: 0x0000DD34
		internal new static IntPtr class_ref
		{
			get
			{
				return IntervalTimer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0000FB58 File Offset: 0x0000DD58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntervalTimer._members;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0000FB60 File Offset: 0x0000DD60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntervalTimer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0000FB84 File Offset: 0x0000DD84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntervalTimer._members.ManagedPeerType;
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000FB90 File Offset: 0x0000DD90
		protected IntervalTimer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		[Register(".ctor", "(Ljava/lang/Integer;Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/IIntervalTimerListener;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", "")]
		public unsafe IntervalTimer(Integer totalDurationMs, Integer totalIntervals, bool useNewTimer, IIntervalTimerListener timerListener, LifecycleCache lifecycleCache) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((totalDurationMs == null) ? IntPtr.Zero : totalDurationMs.Handle);
				ptr[1] = new JniArgumentValue((totalIntervals == null) ? IntPtr.Zero : totalIntervals.Handle);
				ptr[2] = new JniArgumentValue(useNewTimer);
				ptr[3] = new JniArgumentValue((timerListener == null) ? IntPtr.Zero : ((Java.Lang.Object)timerListener).Handle);
				ptr[4] = new JniArgumentValue((lifecycleCache == null) ? IntPtr.Zero : lifecycleCache.Handle);
				base.SetHandle(IntervalTimer._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Integer;Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/IIntervalTimerListener;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				IntervalTimer._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Integer;Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/IIntervalTimerListener;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(totalDurationMs);
				GC.KeepAlive(totalIntervals);
				GC.KeepAlive(timerListener);
				GC.KeepAlive(lifecycleCache);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000FCE8 File Offset: 0x0000DEE8
		private static Delegate GetOnNextIntervalHandler()
		{
			if (IntervalTimer.cb_onNextInterval == null)
			{
				IntervalTimer.cb_onNextInterval = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IntervalTimer.n_OnNextInterval));
			}
			return IntervalTimer.cb_onNextInterval;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000FD0C File Offset: 0x0000DF0C
		private static void n_OnNextInterval(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IntervalTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNextInterval();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000FD1B File Offset: 0x0000DF1B
		[Register("onNextInterval", "()V", "GetOnNextIntervalHandler")]
		public virtual void OnNextInterval()
		{
			IntervalTimer._members.InstanceMethods.InvokeVirtualVoidMethod("onNextInterval.()V", this, null);
		}

		// Token: 0x04000141 RID: 321
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/timer/IntervalTimer", typeof(IntervalTimer));

		// Token: 0x04000142 RID: 322
		private static Delegate cb_onNextInterval;
	}
}
