using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x0200008F RID: 143
	[Register("com/unity3d/services/core/timer/IBaseTimer", DoNotGenerateAcw = true)]
	internal class IBaseTimerInvoker : Java.Lang.Object, IBaseTimer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
		private static IntPtr java_class_ref
		{
			get
			{
				return IBaseTimerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBaseTimerInvoker._members;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0000EFEB File Offset: 0x0000D1EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000EFF3 File Offset: 0x0000D1F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBaseTimerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000EFFF File Offset: 0x0000D1FF
		public static IBaseTimer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBaseTimer>(handle, transfer);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000F008 File Offset: 0x0000D208
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBaseTimerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.timer.IBaseTimer'.");
			}
			return handle;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000F033 File Offset: 0x0000D233
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000F064 File Offset: 0x0000D264
		public IBaseTimerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBaseTimerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000F09C File Offset: 0x0000D29C
		private static Delegate GetKillHandler()
		{
			if (IBaseTimerInvoker.cb_kill == null)
			{
				IBaseTimerInvoker.cb_kill = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IBaseTimerInvoker.n_Kill));
			}
			return IBaseTimerInvoker.cb_kill;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		private static void n_Kill(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IBaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Kill();
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000F0CF File Offset: 0x0000D2CF
		public void Kill()
		{
			if (this.id_kill == IntPtr.Zero)
			{
				this.id_kill = JNIEnv.GetMethodID(this.class_ref, "kill", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_kill);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000F10F File Offset: 0x0000D30F
		private static Delegate GetPauseHandler()
		{
			if (IBaseTimerInvoker.cb_pause == null)
			{
				IBaseTimerInvoker.cb_pause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBaseTimerInvoker.n_Pause));
			}
			return IBaseTimerInvoker.cb_pause;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000F133 File Offset: 0x0000D333
		private static bool n_Pause(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pause();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000F142 File Offset: 0x0000D342
		public bool Pause()
		{
			if (this.id_pause == IntPtr.Zero)
			{
				this.id_pause = JNIEnv.GetMethodID(this.class_ref, "pause", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_pause);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000F182 File Offset: 0x0000D382
		private static Delegate GetResumeHandler()
		{
			if (IBaseTimerInvoker.cb_resume == null)
			{
				IBaseTimerInvoker.cb_resume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IBaseTimerInvoker.n_Resume));
			}
			return IBaseTimerInvoker.cb_resume;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000F1A6 File Offset: 0x0000D3A6
		private static bool n_Resume(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Resume();
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000F1B5 File Offset: 0x0000D3B5
		public bool Resume()
		{
			if (this.id_resume == IntPtr.Zero)
			{
				this.id_resume = JNIEnv.GetMethodID(this.class_ref, "resume", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_resume);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000F1F5 File Offset: 0x0000D3F5
		private static Delegate GetStart_Ljava_util_concurrent_ScheduledExecutorService_Handler()
		{
			if (IBaseTimerInvoker.cb_start_Ljava_util_concurrent_ScheduledExecutorService_ == null)
			{
				IBaseTimerInvoker.cb_start_Ljava_util_concurrent_ScheduledExecutorService_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IBaseTimerInvoker.n_Start_Ljava_util_concurrent_ScheduledExecutorService_));
			}
			return IBaseTimerInvoker.cb_start_Ljava_util_concurrent_ScheduledExecutorService_;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000F21C File Offset: 0x0000D41C
		private static void n_Start_Ljava_util_concurrent_ScheduledExecutorService_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBaseTimer @object = Java.Lang.Object.GetObject<IBaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScheduledExecutorService object2 = Java.Lang.Object.GetObject<IScheduledExecutorService>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Start(object2);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000F240 File Offset: 0x0000D440
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

		// Token: 0x06000548 RID: 1352 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		private static Delegate GetStopHandler()
		{
			if (IBaseTimerInvoker.cb_stop == null)
			{
				IBaseTimerInvoker.cb_stop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IBaseTimerInvoker.n_Stop));
			}
			return IBaseTimerInvoker.cb_stop;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		private static void n_Stop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IBaseTimer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Stop();
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000F2EB File Offset: 0x0000D4EB
		public void Stop()
		{
			if (this.id_stop == IntPtr.Zero)
			{
				this.id_stop = JNIEnv.GetMethodID(this.class_ref, "stop", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_stop);
		}

		// Token: 0x0400011D RID: 285
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/timer/IBaseTimer", typeof(IBaseTimerInvoker));

		// Token: 0x0400011E RID: 286
		private IntPtr class_ref;

		// Token: 0x0400011F RID: 287
		private static Delegate cb_kill;

		// Token: 0x04000120 RID: 288
		private IntPtr id_kill;

		// Token: 0x04000121 RID: 289
		private static Delegate cb_pause;

		// Token: 0x04000122 RID: 290
		private IntPtr id_pause;

		// Token: 0x04000123 RID: 291
		private static Delegate cb_resume;

		// Token: 0x04000124 RID: 292
		private IntPtr id_resume;

		// Token: 0x04000125 RID: 293
		private static Delegate cb_start_Ljava_util_concurrent_ScheduledExecutorService_;

		// Token: 0x04000126 RID: 294
		private IntPtr id_start_Ljava_util_concurrent_ScheduledExecutorService_;

		// Token: 0x04000127 RID: 295
		private static Delegate cb_stop;

		// Token: 0x04000128 RID: 296
		private IntPtr id_stop;
	}
}
