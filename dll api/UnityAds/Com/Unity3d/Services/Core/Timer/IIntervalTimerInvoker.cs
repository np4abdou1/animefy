using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000091 RID: 145
	[Register("com/unity3d/services/core/timer/IIntervalTimer", DoNotGenerateAcw = true)]
	internal class IIntervalTimerInvoker : Java.Lang.Object, IIntervalTimer, IBaseTimer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000F348 File Offset: 0x0000D548
		private static IntPtr java_class_ref
		{
			get
			{
				return IIntervalTimerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0000F36C File Offset: 0x0000D56C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIntervalTimerInvoker._members;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0000F373 File Offset: 0x0000D573
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0000F37B File Offset: 0x0000D57B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIntervalTimerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000F387 File Offset: 0x0000D587
		public static IIntervalTimer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IIntervalTimer>(handle, transfer);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000F390 File Offset: 0x0000D590
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIntervalTimerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.timer.IIntervalTimer'.");
			}
			return handle;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000F3BB File Offset: 0x0000D5BB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		public IIntervalTimerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIntervalTimerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000F424 File Offset: 0x0000D624
		private static Delegate GetOnNextIntervalHandler()
		{
			if (IIntervalTimerInvoker.cb_onNextInterval == null)
			{
				IIntervalTimerInvoker.cb_onNextInterval = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IIntervalTimerInvoker.n_OnNextInterval));
			}
			return IIntervalTimerInvoker.cb_onNextInterval;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000F448 File Offset: 0x0000D648
		private static void n_OnNextInterval(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IIntervalTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNextInterval();
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000F457 File Offset: 0x0000D657
		public void OnNextInterval()
		{
			if (this.id_onNextInterval == IntPtr.Zero)
			{
				this.id_onNextInterval = JNIEnv.GetMethodID(this.class_ref, "onNextInterval", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNextInterval);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000F497 File Offset: 0x0000D697
		private static Delegate GetKillHandler()
		{
			if (IIntervalTimerInvoker.cb_kill == null)
			{
				IIntervalTimerInvoker.cb_kill = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IIntervalTimerInvoker.n_Kill));
			}
			return IIntervalTimerInvoker.cb_kill;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000F4BB File Offset: 0x0000D6BB
		private static void n_Kill(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IIntervalTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Kill();
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000F4CA File Offset: 0x0000D6CA
		public void Kill()
		{
			if (this.id_kill == IntPtr.Zero)
			{
				this.id_kill = JNIEnv.GetMethodID(this.class_ref, "kill", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_kill);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000F50A File Offset: 0x0000D70A
		private static Delegate GetPauseHandler()
		{
			if (IIntervalTimerInvoker.cb_pause == null)
			{
				IIntervalTimerInvoker.cb_pause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IIntervalTimerInvoker.n_Pause));
			}
			return IIntervalTimerInvoker.cb_pause;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000F52E File Offset: 0x0000D72E
		private static bool n_Pause(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIntervalTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pause();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000F53D File Offset: 0x0000D73D
		public bool Pause()
		{
			if (this.id_pause == IntPtr.Zero)
			{
				this.id_pause = JNIEnv.GetMethodID(this.class_ref, "pause", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_pause);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000F57D File Offset: 0x0000D77D
		private static Delegate GetResumeHandler()
		{
			if (IIntervalTimerInvoker.cb_resume == null)
			{
				IIntervalTimerInvoker.cb_resume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IIntervalTimerInvoker.n_Resume));
			}
			return IIntervalTimerInvoker.cb_resume;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000F5A1 File Offset: 0x0000D7A1
		private static bool n_Resume(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIntervalTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Resume();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
		public bool Resume()
		{
			if (this.id_resume == IntPtr.Zero)
			{
				this.id_resume = JNIEnv.GetMethodID(this.class_ref, "resume", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_resume);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
		private static Delegate GetStart_Ljava_util_concurrent_ScheduledExecutorService_Handler()
		{
			if (IIntervalTimerInvoker.cb_start_Ljava_util_concurrent_ScheduledExecutorService_ == null)
			{
				IIntervalTimerInvoker.cb_start_Ljava_util_concurrent_ScheduledExecutorService_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IIntervalTimerInvoker.n_Start_Ljava_util_concurrent_ScheduledExecutorService_));
			}
			return IIntervalTimerInvoker.cb_start_Ljava_util_concurrent_ScheduledExecutorService_;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000F614 File Offset: 0x0000D814
		private static void n_Start_Ljava_util_concurrent_ScheduledExecutorService_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBaseTimer @object = Java.Lang.Object.GetObject<IIntervalTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScheduledExecutorService object2 = Java.Lang.Object.GetObject<IScheduledExecutorService>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Start(object2);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0000F638 File Offset: 0x0000D838
		public unsafe void Start(IScheduledExecutorService p0)
		{
			if (this.id_start_Ljava_util_concurrent_ScheduledExecutorService_ == IntPtr.Zero)
			{
				this.id_start_Ljava_util_concurrent_ScheduledExecutorService_ = JNIEnv.GetMethodID(this.class_ref, "start", "(Ljava/util/concurrent/ScheduledExecutorService;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_start_Ljava_util_concurrent_ScheduledExecutorService_, ptr);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		private static Delegate GetStopHandler()
		{
			if (IIntervalTimerInvoker.cb_stop == null)
			{
				IIntervalTimerInvoker.cb_stop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IIntervalTimerInvoker.n_Stop));
			}
			return IIntervalTimerInvoker.cb_stop;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		private static void n_Stop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IIntervalTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Stop();
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000F6E3 File Offset: 0x0000D8E3
		public void Stop()
		{
			if (this.id_stop == IntPtr.Zero)
			{
				this.id_stop = JNIEnv.GetMethodID(this.class_ref, "stop", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_stop);
		}

		// Token: 0x04000129 RID: 297
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/timer/IIntervalTimer", typeof(IIntervalTimerInvoker));

		// Token: 0x0400012A RID: 298
		private IntPtr class_ref;

		// Token: 0x0400012B RID: 299
		private static Delegate cb_onNextInterval;

		// Token: 0x0400012C RID: 300
		private IntPtr id_onNextInterval;

		// Token: 0x0400012D RID: 301
		private static Delegate cb_kill;

		// Token: 0x0400012E RID: 302
		private IntPtr id_kill;

		// Token: 0x0400012F RID: 303
		private static Delegate cb_pause;

		// Token: 0x04000130 RID: 304
		private IntPtr id_pause;

		// Token: 0x04000131 RID: 305
		private static Delegate cb_resume;

		// Token: 0x04000132 RID: 306
		private IntPtr id_resume;

		// Token: 0x04000133 RID: 307
		private static Delegate cb_start_Ljava_util_concurrent_ScheduledExecutorService_;

		// Token: 0x04000134 RID: 308
		private IntPtr id_start_Ljava_util_concurrent_ScheduledExecutorService_;

		// Token: 0x04000135 RID: 309
		private static Delegate cb_stop;

		// Token: 0x04000136 RID: 310
		private IntPtr id_stop;
	}
}
