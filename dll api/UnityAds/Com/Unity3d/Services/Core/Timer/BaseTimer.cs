using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Lifecycle;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x0200008C RID: 140
	[Register("com/unity3d/services/core/timer/BaseTimer", DoNotGenerateAcw = true)]
	public class BaseTimer : Java.Lang.Object, IBaseTimer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0000E7FC File Offset: 0x0000C9FC
		internal static IntPtr class_ref
		{
			get
			{
				return BaseTimer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0000E820 File Offset: 0x0000CA20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseTimer._members;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0000E828 File Offset: 0x0000CA28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseTimer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000E84C File Offset: 0x0000CA4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseTimer._members.ManagedPeerType;
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BaseTimer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000E858 File Offset: 0x0000CA58
		[Register(".ctor", "(Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/ITimerListener;)V", "")]
		public unsafe BaseTimer(Integer totalDurationMs, bool useNewTimer, ITimerListener timerListener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((totalDurationMs == null) ? IntPtr.Zero : totalDurationMs.Handle);
				ptr[1] = new JniArgumentValue(useNewTimer);
				ptr[2] = new JniArgumentValue((timerListener == null) ? IntPtr.Zero : ((Java.Lang.Object)timerListener).Handle);
				base.SetHandle(BaseTimer._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/ITimerListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BaseTimer._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/ITimerListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(totalDurationMs);
				GC.KeepAlive(timerListener);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000E948 File Offset: 0x0000CB48
		[Register(".ctor", "(Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/ITimerListener;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", "")]
		public unsafe BaseTimer(Integer totalDurationMs, bool useNewTimer, ITimerListener timerListener, LifecycleCache lifecycleCache) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((totalDurationMs == null) ? IntPtr.Zero : totalDurationMs.Handle);
				ptr[1] = new JniArgumentValue(useNewTimer);
				ptr[2] = new JniArgumentValue((timerListener == null) ? IntPtr.Zero : ((Java.Lang.Object)timerListener).Handle);
				ptr[3] = new JniArgumentValue((lifecycleCache == null) ? IntPtr.Zero : lifecycleCache.Handle);
				base.SetHandle(BaseTimer._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/ITimerListener;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BaseTimer._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Integer;ZLcom/unity3d/services/core/timer/ITimerListener;Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(totalDurationMs);
				GC.KeepAlive(timerListener);
				GC.KeepAlive(lifecycleCache);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000EA68 File Offset: 0x0000CC68
		private static Delegate GetIsRunningHandler()
		{
			if (BaseTimer.cb_isRunning == null)
			{
				BaseTimer.cb_isRunning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseTimer.n_IsRunning));
			}
			return BaseTimer.cb_isRunning;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRunning;
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000EA9B File Offset: 0x0000CC9B
		public virtual bool IsRunning
		{
			[Register("isRunning", "()Z", "GetIsRunningHandler")]
			get
			{
				return BaseTimer._members.InstanceMethods.InvokeVirtualBooleanMethod("isRunning.()Z", this, null);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000EAB4 File Offset: 0x0000CCB4
		private static Delegate GetKillHandler()
		{
			if (BaseTimer.cb_kill == null)
			{
				BaseTimer.cb_kill = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BaseTimer.n_Kill));
			}
			return BaseTimer.cb_kill;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		private static void n_Kill(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Kill();
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000EAE7 File Offset: 0x0000CCE7
		[Register("kill", "()V", "GetKillHandler")]
		public virtual void Kill()
		{
			BaseTimer._members.InstanceMethods.InvokeVirtualVoidMethod("kill.()V", this, null);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000EB00 File Offset: 0x0000CD00
		private static Delegate GetOnStepHandler()
		{
			if (BaseTimer.cb_onStep == null)
			{
				BaseTimer.cb_onStep = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BaseTimer.n_OnStep));
			}
			return BaseTimer.cb_onStep;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000EB24 File Offset: 0x0000CD24
		private static void n_OnStep(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStep();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000EB33 File Offset: 0x0000CD33
		[Register("onStep", "()V", "GetOnStepHandler")]
		public virtual void OnStep()
		{
			BaseTimer._members.InstanceMethods.InvokeVirtualVoidMethod("onStep.()V", this, null);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		private static Delegate GetPauseHandler()
		{
			if (BaseTimer.cb_pause == null)
			{
				BaseTimer.cb_pause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseTimer.n_Pause));
			}
			return BaseTimer.cb_pause;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000EB70 File Offset: 0x0000CD70
		private static bool n_Pause(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pause();
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0000EB7F File Offset: 0x0000CD7F
		[Register("pause", "()Z", "GetPauseHandler")]
		public virtual bool Pause()
		{
			return BaseTimer._members.InstanceMethods.InvokeVirtualBooleanMethod("pause.()Z", this, null);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000EB98 File Offset: 0x0000CD98
		private static Delegate GetRestart_Ljava_util_concurrent_ScheduledExecutorService_Handler()
		{
			if (BaseTimer.cb_restart_Ljava_util_concurrent_ScheduledExecutorService_ == null)
			{
				BaseTimer.cb_restart_Ljava_util_concurrent_ScheduledExecutorService_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTimer.n_Restart_Ljava_util_concurrent_ScheduledExecutorService_));
			}
			return BaseTimer.cb_restart_Ljava_util_concurrent_ScheduledExecutorService_;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		private static void n_Restart_Ljava_util_concurrent_ScheduledExecutorService_(IntPtr jnienv, IntPtr native__this, IntPtr native_timerService)
		{
			BaseTimer @object = Java.Lang.Object.GetObject<BaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScheduledExecutorService object2 = Java.Lang.Object.GetObject<IScheduledExecutorService>(native_timerService, JniHandleOwnership.DoNotTransfer);
			@object.Restart(object2);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Register("restart", "(Ljava/util/concurrent/ScheduledExecutorService;)V", "GetRestart_Ljava_util_concurrent_ScheduledExecutorService_Handler")]
		public unsafe virtual void Restart(IScheduledExecutorService timerService)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((timerService == null) ? IntPtr.Zero : ((Java.Lang.Object)timerService).Handle);
				BaseTimer._members.InstanceMethods.InvokeVirtualVoidMethod("restart.(Ljava/util/concurrent/ScheduledExecutorService;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(timerService);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000EC48 File Offset: 0x0000CE48
		private static Delegate GetResumeHandler()
		{
			if (BaseTimer.cb_resume == null)
			{
				BaseTimer.cb_resume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseTimer.n_Resume));
			}
			return BaseTimer.cb_resume;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		private static bool n_Resume(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Resume();
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000EC7B File Offset: 0x0000CE7B
		[Register("resume", "()Z", "GetResumeHandler")]
		public virtual bool Resume()
		{
			return BaseTimer._members.InstanceMethods.InvokeVirtualBooleanMethod("resume.()Z", this, null);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0000EC94 File Offset: 0x0000CE94
		private static Delegate GetStart_Ljava_util_concurrent_ScheduledExecutorService_Handler()
		{
			if (BaseTimer.cb_start_Ljava_util_concurrent_ScheduledExecutorService_ == null)
			{
				BaseTimer.cb_start_Ljava_util_concurrent_ScheduledExecutorService_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTimer.n_Start_Ljava_util_concurrent_ScheduledExecutorService_));
			}
			return BaseTimer.cb_start_Ljava_util_concurrent_ScheduledExecutorService_;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		private static void n_Start_Ljava_util_concurrent_ScheduledExecutorService_(IntPtr jnienv, IntPtr native__this, IntPtr native_timerService)
		{
			BaseTimer @object = Java.Lang.Object.GetObject<BaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScheduledExecutorService object2 = Java.Lang.Object.GetObject<IScheduledExecutorService>(native_timerService, JniHandleOwnership.DoNotTransfer);
			@object.Start(object2);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		[Register("start", "(Ljava/util/concurrent/ScheduledExecutorService;)V", "GetStart_Ljava_util_concurrent_ScheduledExecutorService_Handler")]
		public unsafe virtual void Start(IScheduledExecutorService timerService)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((timerService == null) ? IntPtr.Zero : ((Java.Lang.Object)timerService).Handle);
				BaseTimer._members.InstanceMethods.InvokeVirtualVoidMethod("start.(Ljava/util/concurrent/ScheduledExecutorService;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(timerService);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000ED44 File Offset: 0x0000CF44
		private static Delegate GetStopHandler()
		{
			if (BaseTimer.cb_stop == null)
			{
				BaseTimer.cb_stop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BaseTimer.n_Stop));
			}
			return BaseTimer.cb_stop;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000ED68 File Offset: 0x0000CF68
		private static void n_Stop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Stop();
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000ED77 File Offset: 0x0000CF77
		[Register("stop", "()V", "GetStopHandler")]
		public virtual void Stop()
		{
			BaseTimer._members.InstanceMethods.InvokeVirtualVoidMethod("stop.()V", this, null);
		}

		// Token: 0x04000112 RID: 274
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/timer/BaseTimer", typeof(BaseTimer));

		// Token: 0x04000113 RID: 275
		private static Delegate cb_isRunning;

		// Token: 0x04000114 RID: 276
		private static Delegate cb_kill;

		// Token: 0x04000115 RID: 277
		private static Delegate cb_onStep;

		// Token: 0x04000116 RID: 278
		private static Delegate cb_pause;

		// Token: 0x04000117 RID: 279
		private static Delegate cb_restart_Ljava_util_concurrent_ScheduledExecutorService_;

		// Token: 0x04000118 RID: 280
		private static Delegate cb_resume;

		// Token: 0x04000119 RID: 281
		private static Delegate cb_start_Ljava_util_concurrent_ScheduledExecutorService_;

		// Token: 0x0400011A RID: 282
		private static Delegate cb_stop;
	}
}
