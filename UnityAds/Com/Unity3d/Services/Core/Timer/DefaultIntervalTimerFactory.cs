using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x0200008D RID: 141
	[Register("com/unity3d/services/core/timer/DefaultIntervalTimerFactory", DoNotGenerateAcw = true)]
	public class DefaultIntervalTimerFactory : Java.Lang.Object, IIntervalTimerFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		internal static IntPtr class_ref
		{
			get
			{
				return DefaultIntervalTimerFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DefaultIntervalTimerFactory._members;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DefaultIntervalTimerFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000EDFC File Offset: 0x0000CFFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DefaultIntervalTimerFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DefaultIntervalTimerFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Register(".ctor", "()V", "")]
		public DefaultIntervalTimerFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DefaultIntervalTimerFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DefaultIntervalTimerFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0000EE76 File Offset: 0x0000D076
		private static Delegate GetCreateTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_Handler()
		{
			if (DefaultIntervalTimerFactory.cb_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_ == null)
			{
				DefaultIntervalTimerFactory.cb_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(DefaultIntervalTimerFactory.n_CreateTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_));
			}
			return DefaultIntervalTimerFactory.cb_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0000EE9C File Offset: 0x0000D09C
		private static IntPtr n_CreateTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_totalDurationMs, IntPtr native_totalIntervals, IntPtr native_timerListener)
		{
			DefaultIntervalTimerFactory @object = Java.Lang.Object.GetObject<DefaultIntervalTimerFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Integer object2 = Java.Lang.Object.GetObject<Integer>(native_totalDurationMs, JniHandleOwnership.DoNotTransfer);
			Integer object3 = Java.Lang.Object.GetObject<Integer>(native_totalIntervals, JniHandleOwnership.DoNotTransfer);
			IIntervalTimerListener object4 = Java.Lang.Object.GetObject<IIntervalTimerListener>(native_timerListener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateTimer(object2, object3, object4));
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000EED8 File Offset: 0x0000D0D8
		[Register("createTimer", "(Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/timer/IIntervalTimerListener;)Lcom/unity3d/services/core/timer/IIntervalTimer;", "GetCreateTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_Handler")]
		public unsafe virtual IIntervalTimer CreateTimer(Integer totalDurationMs, Integer totalIntervals, IIntervalTimerListener timerListener)
		{
			IIntervalTimer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((totalDurationMs == null) ? IntPtr.Zero : totalDurationMs.Handle);
				ptr[1] = new JniArgumentValue((totalIntervals == null) ? IntPtr.Zero : totalIntervals.Handle);
				ptr[2] = new JniArgumentValue((timerListener == null) ? IntPtr.Zero : ((Java.Lang.Object)timerListener).Handle);
				@object = Java.Lang.Object.GetObject<IIntervalTimer>(DefaultIntervalTimerFactory._members.InstanceMethods.InvokeVirtualObjectMethod("createTimer.(Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/timer/IIntervalTimerListener;)Lcom/unity3d/services/core/timer/IIntervalTimer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(totalDurationMs);
				GC.KeepAlive(totalIntervals);
				GC.KeepAlive(timerListener);
			}
			return @object;
		}

		// Token: 0x0400011B RID: 283
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/timer/DefaultIntervalTimerFactory", typeof(DefaultIntervalTimerFactory));

		// Token: 0x0400011C RID: 284
		private static Delegate cb_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_;
	}
}
