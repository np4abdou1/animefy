using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000FA RID: 250
	[Register("com/unity3d/services/core/lifecycle/LifecycleListener", DoNotGenerateAcw = true)]
	public class LifecycleListener : Java.Lang.Object, Application.IActivityLifecycleCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0001CC4C File Offset: 0x0001AE4C
		internal static IntPtr class_ref
		{
			get
			{
				return LifecycleListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0001CC70 File Offset: 0x0001AE70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LifecycleListener._members;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0001CC78 File Offset: 0x0001AE78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LifecycleListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0001CC9C File Offset: 0x0001AE9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LifecycleListener._members.ManagedPeerType;
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000021E8 File Offset: 0x000003E8
		protected LifecycleListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
		[Register(".ctor", "(Ljava/util/ArrayList;)V", "")]
		public unsafe LifecycleListener(IList<string> events) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(events);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(LifecycleListener._members.InstanceMethods.StartCreateInstance("(Ljava/util/ArrayList;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LifecycleListener._members.InstanceMethods.FinishCreateInstance("(Ljava/util/ArrayList;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(events);
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0001CD54 File Offset: 0x0001AF54
		private static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler()
		{
			if (LifecycleListener.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
			{
				LifecycleListener.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LifecycleListener.n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_));
			}
			return LifecycleListener.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0001CD78 File Offset: 0x0001AF78
		private static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_bundle)
		{
			LifecycleListener @object = Java.Lang.Object.GetObject<LifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_bundle, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityCreated(object2, object3);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0001CDA4 File Offset: 0x0001AFA4
		[Register("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnActivityCreated(Activity activity, Bundle bundle)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				LifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityCreated.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(bundle);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0001CE30 File Offset: 0x0001B030
		private static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler()
		{
			if (LifecycleListener.cb_onActivityDestroyed_Landroid_app_Activity_ == null)
			{
				LifecycleListener.cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleListener.n_OnActivityDestroyed_Landroid_app_Activity_));
			}
			return LifecycleListener.cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0001CE54 File Offset: 0x0001B054
		private static void n_OnActivityDestroyed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleListener @object = Java.Lang.Object.GetObject<LifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityDestroyed(object2);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0001CE78 File Offset: 0x0001B078
		[Register("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityDestroyed(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityDestroyed.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0001CEDC File Offset: 0x0001B0DC
		private static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler()
		{
			if (LifecycleListener.cb_onActivityPaused_Landroid_app_Activity_ == null)
			{
				LifecycleListener.cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleListener.n_OnActivityPaused_Landroid_app_Activity_));
			}
			return LifecycleListener.cb_onActivityPaused_Landroid_app_Activity_;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0001CF00 File Offset: 0x0001B100
		private static void n_OnActivityPaused_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleListener @object = Java.Lang.Object.GetObject<LifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityPaused(object2);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0001CF24 File Offset: 0x0001B124
		[Register("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityPaused(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPaused.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0001CF88 File Offset: 0x0001B188
		private static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler()
		{
			if (LifecycleListener.cb_onActivityResumed_Landroid_app_Activity_ == null)
			{
				LifecycleListener.cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleListener.n_OnActivityResumed_Landroid_app_Activity_));
			}
			return LifecycleListener.cb_onActivityResumed_Landroid_app_Activity_;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0001CFAC File Offset: 0x0001B1AC
		private static void n_OnActivityResumed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleListener @object = Java.Lang.Object.GetObject<LifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityResumed(object2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
		[Register("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityResumed(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityResumed.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0001D034 File Offset: 0x0001B234
		private static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler()
		{
			if (LifecycleListener.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
			{
				LifecycleListener.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LifecycleListener.n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_));
			}
			return LifecycleListener.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0001D058 File Offset: 0x0001B258
		private static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_bundle)
		{
			LifecycleListener @object = Java.Lang.Object.GetObject<LifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_bundle, JniHandleOwnership.DoNotTransfer);
			@object.OnActivitySaveInstanceState(object2, object3);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001D084 File Offset: 0x0001B284
		[Register("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnActivitySaveInstanceState(Activity activity, Bundle bundle)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				LifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivitySaveInstanceState.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(bundle);
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0001D110 File Offset: 0x0001B310
		private static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler()
		{
			if (LifecycleListener.cb_onActivityStarted_Landroid_app_Activity_ == null)
			{
				LifecycleListener.cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleListener.n_OnActivityStarted_Landroid_app_Activity_));
			}
			return LifecycleListener.cb_onActivityStarted_Landroid_app_Activity_;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0001D134 File Offset: 0x0001B334
		private static void n_OnActivityStarted_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleListener @object = Java.Lang.Object.GetObject<LifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityStarted(object2);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0001D158 File Offset: 0x0001B358
		[Register("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityStarted(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityStarted.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0001D1BC File Offset: 0x0001B3BC
		private static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler()
		{
			if (LifecycleListener.cb_onActivityStopped_Landroid_app_Activity_ == null)
			{
				LifecycleListener.cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleListener.n_OnActivityStopped_Landroid_app_Activity_));
			}
			return LifecycleListener.cb_onActivityStopped_Landroid_app_Activity_;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0001D1E0 File Offset: 0x0001B3E0
		private static void n_OnActivityStopped_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			LifecycleListener @object = Java.Lang.Object.GetObject<LifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityStopped(object2);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0001D204 File Offset: 0x0001B404
		[Register("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityStopped(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				LifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityStopped.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x04000259 RID: 601
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/lifecycle/LifecycleListener", typeof(LifecycleListener));

		// Token: 0x0400025A RID: 602
		private static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;

		// Token: 0x0400025B RID: 603
		private static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;

		// Token: 0x0400025C RID: 604
		private static Delegate cb_onActivityPaused_Landroid_app_Activity_;

		// Token: 0x0400025D RID: 605
		private static Delegate cb_onActivityResumed_Landroid_app_Activity_;

		// Token: 0x0400025E RID: 606
		private static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;

		// Token: 0x0400025F RID: 607
		private static Delegate cb_onActivityStarted_Landroid_app_Activity_;

		// Token: 0x04000260 RID: 608
		private static Delegate cb_onActivityStopped_Landroid_app_Activity_;
	}
}
