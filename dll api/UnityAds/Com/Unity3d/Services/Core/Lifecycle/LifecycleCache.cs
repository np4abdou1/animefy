using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000F3 RID: 243
	[Register("com/unity3d/services/core/lifecycle/LifecycleCache", DoNotGenerateAcw = true)]
	public class LifecycleCache : Java.Lang.Object, Application.IActivityLifecycleCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0001BBDC File Offset: 0x00019DDC
		internal static IntPtr class_ref
		{
			get
			{
				return LifecycleCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0001BC00 File Offset: 0x00019E00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LifecycleCache._members;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0001BC08 File Offset: 0x00019E08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LifecycleCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0001BC2C File Offset: 0x00019E2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LifecycleCache._members.ManagedPeerType;
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000021E8 File Offset: 0x000003E8
		protected LifecycleCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0001BC38 File Offset: 0x00019E38
		[Register(".ctor", "()V", "")]
		public LifecycleCache() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LifecycleCache._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LifecycleCache._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0001BCA6 File Offset: 0x00019EA6
		private static Delegate GetGetCurrentStateHandler()
		{
			if (LifecycleCache.cb_getCurrentState == null)
			{
				LifecycleCache.cb_getCurrentState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LifecycleCache.n_GetCurrentState));
			}
			return LifecycleCache.cb_getCurrentState;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0001BCCA File Offset: 0x00019ECA
		private static IntPtr n_GetCurrentState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentState);
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0001BCE0 File Offset: 0x00019EE0
		public virtual LifecycleEvent CurrentState
		{
			[Register("getCurrentState", "()Lcom/unity3d/services/core/lifecycle/LifecycleEvent;", "GetGetCurrentStateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<LifecycleEvent>(LifecycleCache._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentState.()Lcom/unity3d/services/core/lifecycle/LifecycleEvent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001BD12 File Offset: 0x00019F12
		private static Delegate GetIsAppActiveHandler()
		{
			if (LifecycleCache.cb_isAppActive == null)
			{
				LifecycleCache.cb_isAppActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LifecycleCache.n_IsAppActive));
			}
			return LifecycleCache.cb_isAppActive;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0001BD36 File Offset: 0x00019F36
		private static bool n_IsAppActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAppActive;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0001BD45 File Offset: 0x00019F45
		public virtual bool IsAppActive
		{
			[Register("isAppActive", "()Z", "GetIsAppActiveHandler")]
			get
			{
				return LifecycleCache._members.InstanceMethods.InvokeVirtualBooleanMethod("isAppActive.()Z", this, null);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0001BD5E File Offset: 0x00019F5E
		private static Delegate GetAddActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_Handler()
		{
			if (LifecycleCache.cb_addActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_ == null)
			{
				LifecycleCache.cb_addActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_AddActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_));
			}
			return LifecycleCache.cb_addActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0001BD84 File Offset: 0x00019F84
		private static void n_AddActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppActiveListener object2 = Java.Lang.Object.GetObject<IAppActiveListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddActiveListener(object2);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0001BDA8 File Offset: 0x00019FA8
		[Register("addActiveListener", "(Lcom/unity3d/services/core/lifecycle/IAppActiveListener;)V", "GetAddActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_Handler")]
		public unsafe virtual void AddActiveListener(IAppActiveListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("addActiveListener.(Lcom/unity3d/services/core/lifecycle/IAppActiveListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0001BE10 File Offset: 0x0001A010
		private static Delegate GetAddStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_Handler()
		{
			if (LifecycleCache.cb_addStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_ == null)
			{
				LifecycleCache.cb_addStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_AddStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_));
			}
			return LifecycleCache.cb_addStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0001BE34 File Offset: 0x0001A034
		private static void n_AddStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppEventListener object2 = Java.Lang.Object.GetObject<IAppEventListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddStateListener(object2);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0001BE58 File Offset: 0x0001A058
		[Register("addStateListener", "(Lcom/unity3d/services/core/lifecycle/IAppEventListener;)V", "GetAddStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_Handler")]
		public unsafe virtual void AddStateListener(IAppEventListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("addStateListener.(Lcom/unity3d/services/core/lifecycle/IAppEventListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
		private static Delegate GetNotifyActiveListenersHandler()
		{
			if (LifecycleCache.cb_notifyActiveListeners == null)
			{
				LifecycleCache.cb_notifyActiveListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LifecycleCache.n_NotifyActiveListeners));
			}
			return LifecycleCache.cb_notifyActiveListeners;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
		private static void n_NotifyActiveListeners(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NotifyActiveListeners();
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0001BEF3 File Offset: 0x0001A0F3
		[Register("notifyActiveListeners", "()V", "GetNotifyActiveListenersHandler")]
		public virtual void NotifyActiveListeners()
		{
			LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("notifyActiveListeners.()V", this, null);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0001BF0C File Offset: 0x0001A10C
		private static Delegate GetNotifyStateListeners_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_Handler()
		{
			if (LifecycleCache.cb_notifyStateListeners_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_ == null)
			{
				LifecycleCache.cb_notifyStateListeners_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_NotifyStateListeners_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_));
			}
			return LifecycleCache.cb_notifyStateListeners_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0001BF30 File Offset: 0x0001A130
		private static void n_NotifyStateListeners_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LifecycleEvent object2 = Java.Lang.Object.GetObject<LifecycleEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.NotifyStateListeners(object2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0001BF54 File Offset: 0x0001A154
		[Register("notifyStateListeners", "(Lcom/unity3d/services/core/lifecycle/LifecycleEvent;)V", "GetNotifyStateListeners_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_Handler")]
		public unsafe virtual void NotifyStateListeners(LifecycleEvent e)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("notifyStateListeners.(Lcom/unity3d/services/core/lifecycle/LifecycleEvent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0001BFB8 File Offset: 0x0001A1B8
		private static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler()
		{
			if (LifecycleCache.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
			{
				LifecycleCache.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LifecycleCache.n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_));
			}
			return LifecycleCache.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0001BFDC File Offset: 0x0001A1DC
		private static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_bundle)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_bundle, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityCreated(object2, object3);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0001C008 File Offset: 0x0001A208
		[Register("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnActivityCreated(Activity activity, Bundle bundle)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityCreated.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(bundle);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0001C094 File Offset: 0x0001A294
		private static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler()
		{
			if (LifecycleCache.cb_onActivityDestroyed_Landroid_app_Activity_ == null)
			{
				LifecycleCache.cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_OnActivityDestroyed_Landroid_app_Activity_));
			}
			return LifecycleCache.cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		private static void n_OnActivityDestroyed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityDestroyed(object2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0001C0DC File Offset: 0x0001A2DC
		[Register("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityDestroyed(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityDestroyed.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0001C140 File Offset: 0x0001A340
		private static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler()
		{
			if (LifecycleCache.cb_onActivityPaused_Landroid_app_Activity_ == null)
			{
				LifecycleCache.cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_OnActivityPaused_Landroid_app_Activity_));
			}
			return LifecycleCache.cb_onActivityPaused_Landroid_app_Activity_;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001C164 File Offset: 0x0001A364
		private static void n_OnActivityPaused_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityPaused(object2);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0001C188 File Offset: 0x0001A388
		[Register("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityPaused(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPaused.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		private static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler()
		{
			if (LifecycleCache.cb_onActivityResumed_Landroid_app_Activity_ == null)
			{
				LifecycleCache.cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_OnActivityResumed_Landroid_app_Activity_));
			}
			return LifecycleCache.cb_onActivityResumed_Landroid_app_Activity_;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0001C210 File Offset: 0x0001A410
		private static void n_OnActivityResumed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityResumed(object2);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0001C234 File Offset: 0x0001A434
		[Register("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityResumed(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityResumed.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0001C298 File Offset: 0x0001A498
		private static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler()
		{
			if (LifecycleCache.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
			{
				LifecycleCache.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LifecycleCache.n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_));
			}
			return LifecycleCache.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0001C2BC File Offset: 0x0001A4BC
		private static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_bundle)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_bundle, JniHandleOwnership.DoNotTransfer);
			@object.OnActivitySaveInstanceState(object2, object3);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0001C2E8 File Offset: 0x0001A4E8
		[Register("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnActivitySaveInstanceState(Activity activity, Bundle bundle)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("onActivitySaveInstanceState.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(bundle);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0001C374 File Offset: 0x0001A574
		private static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler()
		{
			if (LifecycleCache.cb_onActivityStarted_Landroid_app_Activity_ == null)
			{
				LifecycleCache.cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_OnActivityStarted_Landroid_app_Activity_));
			}
			return LifecycleCache.cb_onActivityStarted_Landroid_app_Activity_;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0001C398 File Offset: 0x0001A598
		private static void n_OnActivityStarted_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityStarted(object2);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0001C3BC File Offset: 0x0001A5BC
		[Register("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityStarted(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityStarted.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0001C420 File Offset: 0x0001A620
		private static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler()
		{
			if (LifecycleCache.cb_onActivityStopped_Landroid_app_Activity_ == null)
			{
				LifecycleCache.cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_OnActivityStopped_Landroid_app_Activity_));
			}
			return LifecycleCache.cb_onActivityStopped_Landroid_app_Activity_;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0001C444 File Offset: 0x0001A644
		private static void n_OnActivityStopped_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityStopped(object2);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0001C468 File Offset: 0x0001A668
		[Register("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityStopped(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityStopped.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0001C4CC File Offset: 0x0001A6CC
		private static Delegate GetRemoveActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_Handler()
		{
			if (LifecycleCache.cb_removeActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_ == null)
			{
				LifecycleCache.cb_removeActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_RemoveActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_));
			}
			return LifecycleCache.cb_removeActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0001C4F0 File Offset: 0x0001A6F0
		private static void n_RemoveActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppActiveListener object2 = Java.Lang.Object.GetObject<IAppActiveListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveActiveListener(object2);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0001C514 File Offset: 0x0001A714
		[Register("removeActiveListener", "(Lcom/unity3d/services/core/lifecycle/IAppActiveListener;)V", "GetRemoveActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_Handler")]
		public unsafe virtual void RemoveActiveListener(IAppActiveListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("removeActiveListener.(Lcom/unity3d/services/core/lifecycle/IAppActiveListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0001C57C File Offset: 0x0001A77C
		private static Delegate GetRemoveStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_Handler()
		{
			if (LifecycleCache.cb_removeStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_ == null)
			{
				LifecycleCache.cb_removeStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCache.n_RemoveStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_));
			}
			return LifecycleCache.cb_removeStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
		private static void n_RemoveStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			LifecycleCache @object = Java.Lang.Object.GetObject<LifecycleCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppEventListener object2 = Java.Lang.Object.GetObject<IAppEventListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveStateListener(object2);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
		[Register("removeStateListener", "(Lcom/unity3d/services/core/lifecycle/IAppEventListener;)V", "GetRemoveStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_Handler")]
		public unsafe virtual void RemoveStateListener(IAppEventListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				LifecycleCache._members.InstanceMethods.InvokeVirtualVoidMethod("removeStateListener.(Lcom/unity3d/services/core/lifecycle/IAppEventListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060009BA RID: 2490 RVA: 0x0001C62C File Offset: 0x0001A82C
		// (remove) Token: 0x060009BB RID: 2491 RVA: 0x0001C678 File Offset: 0x0001A878
		public event EventHandler<AppActiveEventArgs> Active
		{
			add
			{
				EventHelper.AddEventHandler<IAppActiveListener, IAppActiveListenerImplementor>(ref this.weak_implementor_AddActiveListener, new Func<IAppActiveListenerImplementor>(this.__CreateIAppActiveListenerImplementor), new Action<IAppActiveListener>(this.AddActiveListener), delegate(IAppActiveListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppActiveEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppActiveListener, IAppActiveListenerImplementor>(ref this.weak_implementor_AddActiveListener, new Func<IAppActiveListenerImplementor, bool>(IAppActiveListenerImplementor.__IsEmpty), delegate(IAppActiveListener __v)
				{
					this.RemoveActiveListener(__v);
				}, delegate(IAppActiveListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppActiveEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
		private IAppActiveListenerImplementor __CreateIAppActiveListenerImplementor()
		{
			return new IAppActiveListenerImplementor(this);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060009BD RID: 2493 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
		// (remove) Token: 0x060009BE RID: 2494 RVA: 0x0001C71C File Offset: 0x0001A91C
		public event EventHandler<AppEventEventArgs> State
		{
			add
			{
				EventHelper.AddEventHandler<IAppEventListener, IAppEventListenerImplementor>(ref this.weak_implementor_AddStateListener, new Func<IAppEventListenerImplementor>(this.__CreateIAppEventListenerImplementor), new Action<IAppEventListener>(this.AddStateListener), delegate(IAppEventListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppEventEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppEventListener, IAppEventListenerImplementor>(ref this.weak_implementor_AddStateListener, new Func<IAppEventListenerImplementor, bool>(IAppEventListenerImplementor.__IsEmpty), delegate(IAppEventListener __v)
				{
					this.RemoveStateListener(__v);
				}, delegate(IAppEventListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppEventEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0001C76C File Offset: 0x0001A96C
		private IAppEventListenerImplementor __CreateIAppEventListenerImplementor()
		{
			return new IAppEventListenerImplementor(this);
		}

		// Token: 0x0400023F RID: 575
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/lifecycle/LifecycleCache", typeof(LifecycleCache));

		// Token: 0x04000240 RID: 576
		private static Delegate cb_getCurrentState;

		// Token: 0x04000241 RID: 577
		private static Delegate cb_isAppActive;

		// Token: 0x04000242 RID: 578
		private static Delegate cb_addActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_;

		// Token: 0x04000243 RID: 579
		private static Delegate cb_addStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_;

		// Token: 0x04000244 RID: 580
		private static Delegate cb_notifyActiveListeners;

		// Token: 0x04000245 RID: 581
		private static Delegate cb_notifyStateListeners_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_;

		// Token: 0x04000246 RID: 582
		private static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;

		// Token: 0x04000247 RID: 583
		private static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;

		// Token: 0x04000248 RID: 584
		private static Delegate cb_onActivityPaused_Landroid_app_Activity_;

		// Token: 0x04000249 RID: 585
		private static Delegate cb_onActivityResumed_Landroid_app_Activity_;

		// Token: 0x0400024A RID: 586
		private static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;

		// Token: 0x0400024B RID: 587
		private static Delegate cb_onActivityStarted_Landroid_app_Activity_;

		// Token: 0x0400024C RID: 588
		private static Delegate cb_onActivityStopped_Landroid_app_Activity_;

		// Token: 0x0400024D RID: 589
		private static Delegate cb_removeActiveListener_Lcom_unity3d_services_core_lifecycle_IAppActiveListener_;

		// Token: 0x0400024E RID: 590
		private static Delegate cb_removeStateListener_Lcom_unity3d_services_core_lifecycle_IAppEventListener_;

		// Token: 0x0400024F RID: 591
		private WeakReference weak_implementor_AddActiveListener;

		// Token: 0x04000250 RID: 592
		private WeakReference weak_implementor_AddStateListener;
	}
}
