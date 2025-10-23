using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.OS;
using Android.Runtime;
using Com.Unity3d.Services.Store.Gpbl;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Core
{
	// Token: 0x02000069 RID: 105
	[Register("com/unity3d/services/store/core/StoreLifecycleListener", DoNotGenerateAcw = true)]
	public class StoreLifecycleListener : Java.Lang.Object, Application.IActivityLifecycleCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00008B74 File Offset: 0x00006D74
		internal static IntPtr class_ref
		{
			get
			{
				return StoreLifecycleListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00008B98 File Offset: 0x00006D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StoreLifecycleListener._members;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00008BA0 File Offset: 0x00006DA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StoreLifecycleListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StoreLifecycleListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000021E8 File Offset: 0x000003E8
		protected StoreLifecycleListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00008BD0 File Offset: 0x00006DD0
		[Register(".ctor", "(Ljava/util/ArrayList;Lcom/unity3d/services/store/gpbl/StoreBilling;)V", "")]
		public unsafe StoreLifecycleListener(IList<string> purchaseTypes, StoreBilling storeBilling) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(purchaseTypes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((storeBilling == null) ? IntPtr.Zero : storeBilling.Handle);
				base.SetHandle(StoreLifecycleListener._members.InstanceMethods.StartCreateInstance("(Ljava/util/ArrayList;Lcom/unity3d/services/store/gpbl/StoreBilling;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StoreLifecycleListener._members.InstanceMethods.FinishCreateInstance("(Ljava/util/ArrayList;Lcom/unity3d/services/store/gpbl/StoreBilling;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(purchaseTypes);
				GC.KeepAlive(storeBilling);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00008CA4 File Offset: 0x00006EA4
		private static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler()
		{
			if (StoreLifecycleListener.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
			{
				StoreLifecycleListener.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(StoreLifecycleListener.n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_));
			}
			return StoreLifecycleListener.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00008CC8 File Offset: 0x00006EC8
		private static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
		{
			StoreLifecycleListener @object = Java.Lang.Object.GetObject<StoreLifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityCreated(object2, object3);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00008CF4 File Offset: 0x00006EF4
		[Register("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnActivityCreated(Activity activity, Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				StoreLifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityCreated.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00008D80 File Offset: 0x00006F80
		private static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler()
		{
			if (StoreLifecycleListener.cb_onActivityDestroyed_Landroid_app_Activity_ == null)
			{
				StoreLifecycleListener.cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StoreLifecycleListener.n_OnActivityDestroyed_Landroid_app_Activity_));
			}
			return StoreLifecycleListener.cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00008DA4 File Offset: 0x00006FA4
		private static void n_OnActivityDestroyed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			StoreLifecycleListener @object = Java.Lang.Object.GetObject<StoreLifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityDestroyed(object2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00008DC8 File Offset: 0x00006FC8
		[Register("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityDestroyed(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				StoreLifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityDestroyed.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00008E2C File Offset: 0x0000702C
		private static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler()
		{
			if (StoreLifecycleListener.cb_onActivityPaused_Landroid_app_Activity_ == null)
			{
				StoreLifecycleListener.cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StoreLifecycleListener.n_OnActivityPaused_Landroid_app_Activity_));
			}
			return StoreLifecycleListener.cb_onActivityPaused_Landroid_app_Activity_;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00008E50 File Offset: 0x00007050
		private static void n_OnActivityPaused_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			StoreLifecycleListener @object = Java.Lang.Object.GetObject<StoreLifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityPaused(object2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00008E74 File Offset: 0x00007074
		[Register("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityPaused(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				StoreLifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPaused.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00008ED8 File Offset: 0x000070D8
		private static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler()
		{
			if (StoreLifecycleListener.cb_onActivityResumed_Landroid_app_Activity_ == null)
			{
				StoreLifecycleListener.cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StoreLifecycleListener.n_OnActivityResumed_Landroid_app_Activity_));
			}
			return StoreLifecycleListener.cb_onActivityResumed_Landroid_app_Activity_;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00008EFC File Offset: 0x000070FC
		private static void n_OnActivityResumed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			StoreLifecycleListener @object = Java.Lang.Object.GetObject<StoreLifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityResumed(object2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00008F20 File Offset: 0x00007120
		[Register("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityResumed(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				StoreLifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityResumed.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00008F84 File Offset: 0x00007184
		private static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler()
		{
			if (StoreLifecycleListener.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
			{
				StoreLifecycleListener.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(StoreLifecycleListener.n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_));
			}
			return StoreLifecycleListener.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00008FA8 File Offset: 0x000071A8
		private static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_outState)
		{
			StoreLifecycleListener @object = Java.Lang.Object.GetObject<StoreLifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
			@object.OnActivitySaveInstanceState(object2, object3);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00008FD4 File Offset: 0x000071D4
		[Register("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnActivitySaveInstanceState(Activity activity, Bundle outState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
				StoreLifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivitySaveInstanceState.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(outState);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00009060 File Offset: 0x00007260
		private static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler()
		{
			if (StoreLifecycleListener.cb_onActivityStarted_Landroid_app_Activity_ == null)
			{
				StoreLifecycleListener.cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StoreLifecycleListener.n_OnActivityStarted_Landroid_app_Activity_));
			}
			return StoreLifecycleListener.cb_onActivityStarted_Landroid_app_Activity_;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00009084 File Offset: 0x00007284
		private static void n_OnActivityStarted_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			StoreLifecycleListener @object = Java.Lang.Object.GetObject<StoreLifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityStarted(object2);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000090A8 File Offset: 0x000072A8
		[Register("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityStarted(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				StoreLifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityStarted.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000910C File Offset: 0x0000730C
		private static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler()
		{
			if (StoreLifecycleListener.cb_onActivityStopped_Landroid_app_Activity_ == null)
			{
				StoreLifecycleListener.cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StoreLifecycleListener.n_OnActivityStopped_Landroid_app_Activity_));
			}
			return StoreLifecycleListener.cb_onActivityStopped_Landroid_app_Activity_;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00009130 File Offset: 0x00007330
		private static void n_OnActivityStopped_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			StoreLifecycleListener @object = Java.Lang.Object.GetObject<StoreLifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityStopped(object2);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00009154 File Offset: 0x00007354
		[Register("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnActivityStopped(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				StoreLifecycleListener._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityStopped.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x0400009C RID: 156
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/core/StoreLifecycleListener", typeof(StoreLifecycleListener));

		// Token: 0x0400009D RID: 157
		private static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_onActivityPaused_Landroid_app_Activity_;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_onActivityResumed_Landroid_app_Activity_;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;

		// Token: 0x040000A2 RID: 162
		private static Delegate cb_onActivityStarted_Landroid_app_Activity_;

		// Token: 0x040000A3 RID: 163
		private static Delegate cb_onActivityStopped_Landroid_app_Activity_;
	}
}
