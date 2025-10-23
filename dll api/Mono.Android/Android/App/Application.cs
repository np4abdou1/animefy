using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x0200025B RID: 603
	[Register("android/app/Application", DoNotGenerateAcw = true)]
	public class Application : ContextWrapper, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable, IComponentCallbacks2
	{
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00039E7B File Offset: 0x0003807B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Application._members;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00039E84 File Offset: 0x00038084
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Application._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x00039EA8 File Offset: 0x000380A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Application._members.ManagedPeerType;
			}
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00010120 File Offset: 0x0000E320
		protected Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00039EB4 File Offset: 0x000380B4
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (Application.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				Application.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return Application.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00039ED8 File Offset: 0x000380D8
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			Application @object = Java.Lang.Object.GetObject<Application>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00039EFC File Offset: 0x000380FC
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				Application._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00039F60 File Offset: 0x00038160
		private static Delegate GetOnLowMemoryHandler()
		{
			if (Application.cb_onLowMemory == null)
			{
				Application.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Application.n_OnLowMemory));
			}
			return Application.cb_onLowMemory;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00039F84 File Offset: 0x00038184
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Application>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00039F93 File Offset: 0x00038193
		public virtual void OnLowMemory()
		{
			Application._members.InstanceMethods.InvokeVirtualVoidMethod("onLowMemory.()V", this, null);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00039FAC File Offset: 0x000381AC
		private static Delegate GetOnTrimMemory_IHandler()
		{
			if (Application.cb_onTrimMemory_I == null)
			{
				Application.cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Application.n_OnTrimMemory_I));
			}
			return Application.cb_onTrimMemory_I;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00039FD0 File Offset: 0x000381D0
		private static void n_OnTrimMemory_I(IntPtr jnienv, IntPtr native__this, int native_level)
		{
			Java.Lang.Object.GetObject<Application>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTrimMemory((TrimMemory)native_level);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00039FF0 File Offset: 0x000381F0
		public unsafe virtual void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)level);
			Application._members.InstanceMethods.InvokeVirtualVoidMethod("onTrimMemory.(I)V", this, ptr);
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x0003A02C File Offset: 0x0003822C
		public static Context Context
		{
			get
			{
				if (Application._context != null)
				{
					return Application._context;
				}
				IntPtr intPtr = JNIEnv.FindClass("mono/MonoPackageManager");
				Context result;
				try
				{
					IntPtr staticFieldID = JNIEnv.GetStaticFieldID(intPtr, "Context", "Landroid/content/Context;");
					result = (Application._context = Java.Lang.Object.GetObject<Context>(JNIEnv.GetStaticObjectField(intPtr, staticFieldID), JniHandleOwnership.TransferLocalRef));
				}
				finally
				{
					JNIEnv.DeleteGlobalRef(intPtr);
				}
				return result;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x0003A090 File Offset: 0x00038290
		public static SynchronizationContext SynchronizationContext
		{
			get
			{
				if (Application._sync == null)
				{
					Application._sync = new SyncContext();
				}
				return Application._sync;
			}
		}

		// Token: 0x040009B3 RID: 2483
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Application", typeof(Application));

		// Token: 0x040009B4 RID: 2484
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x040009B5 RID: 2485
		private static Delegate cb_onLowMemory;

		// Token: 0x040009B6 RID: 2486
		private static Delegate cb_onTrimMemory_I;

		// Token: 0x040009B7 RID: 2487
		private static Context _context;

		// Token: 0x040009B8 RID: 2488
		private static SyncContext _sync;

		// Token: 0x0200025C RID: 604
		[Register("android/app/Application$ActivityLifecycleCallbacks", "", "Android.App.Application/IActivityLifecycleCallbacksInvoker")]
		public interface IActivityLifecycleCallbacks : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001689 RID: 5769
			[Register("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler:Android.App.Application/IActivityLifecycleCallbacksInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActivityCreated(Activity activity, Bundle savedInstanceState);

			// Token: 0x0600168A RID: 5770
			[Register("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacksInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActivityDestroyed(Activity activity);

			// Token: 0x0600168B RID: 5771
			[Register("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacksInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActivityPaused(Activity activity);

			// Token: 0x0600168C RID: 5772
			[Register("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacksInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActivityResumed(Activity activity);

			// Token: 0x0600168D RID: 5773
			[Register("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler:Android.App.Application/IActivityLifecycleCallbacksInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActivitySaveInstanceState(Activity activity, Bundle outState);

			// Token: 0x0600168E RID: 5774
			[Register("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacksInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActivityStarted(Activity activity);

			// Token: 0x0600168F RID: 5775
			[Register("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacksInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnActivityStopped(Activity activity);

			// Token: 0x06001690 RID: 5776 RVA: 0x0003A0C3 File Offset: 0x000382C3
			private static Delegate GetOnActivityPostCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPostCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPostCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPostCreated_Landroid_app_Activity_Landroid_os_Bundle_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPostCreated_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			// Token: 0x06001691 RID: 5777 RVA: 0x0003A0E8 File Offset: 0x000382E8
			private static void n_OnActivityPostCreated_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPostCreated(object2, object3);
			}

			// Token: 0x06001692 RID: 5778 RVA: 0x0003A114 File Offset: 0x00038314
			[Register("onActivityPostCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityPostCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPostCreated(Activity activity, Bundle savedInstanceState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					ptr[1] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPostCreated.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
					GC.KeepAlive(savedInstanceState);
				}
			}

			// Token: 0x06001693 RID: 5779 RVA: 0x0003A1A0 File Offset: 0x000383A0
			private static Delegate GetOnActivityPostDestroyed_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPostDestroyed_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPostDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPostDestroyed_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPostDestroyed_Landroid_app_Activity_;
			}

			// Token: 0x06001694 RID: 5780 RVA: 0x0003A1C4 File Offset: 0x000383C4
			private static void n_OnActivityPostDestroyed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPostDestroyed(object2);
			}

			// Token: 0x06001695 RID: 5781 RVA: 0x0003A1E8 File Offset: 0x000383E8
			[Register("onActivityPostDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityPostDestroyed_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPostDestroyed(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPostDestroyed.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x06001696 RID: 5782 RVA: 0x0003A24C File Offset: 0x0003844C
			private static Delegate GetOnActivityPostPaused_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPostPaused_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPostPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPostPaused_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPostPaused_Landroid_app_Activity_;
			}

			// Token: 0x06001697 RID: 5783 RVA: 0x0003A270 File Offset: 0x00038470
			private static void n_OnActivityPostPaused_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPostPaused(object2);
			}

			// Token: 0x06001698 RID: 5784 RVA: 0x0003A294 File Offset: 0x00038494
			[Register("onActivityPostPaused", "(Landroid/app/Activity;)V", "GetOnActivityPostPaused_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPostPaused(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPostPaused.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x06001699 RID: 5785 RVA: 0x0003A2F8 File Offset: 0x000384F8
			private static Delegate GetOnActivityPostResumed_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPostResumed_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPostResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPostResumed_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPostResumed_Landroid_app_Activity_;
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x0003A31C File Offset: 0x0003851C
			private static void n_OnActivityPostResumed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPostResumed(object2);
			}

			// Token: 0x0600169B RID: 5787 RVA: 0x0003A340 File Offset: 0x00038540
			[Register("onActivityPostResumed", "(Landroid/app/Activity;)V", "GetOnActivityPostResumed_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPostResumed(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPostResumed.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x0600169C RID: 5788 RVA: 0x0003A3A4 File Offset: 0x000385A4
			private static Delegate GetOnActivityPostSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPostSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPostSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPostSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPostSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			// Token: 0x0600169D RID: 5789 RVA: 0x0003A3C8 File Offset: 0x000385C8
			private static void n_OnActivityPostSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_outState)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPostSaveInstanceState(object2, object3);
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x0003A3F4 File Offset: 0x000385F4
			[Register("onActivityPostSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityPostSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPostSaveInstanceState(Activity activity, Bundle outState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					ptr[1] = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPostSaveInstanceState.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
					GC.KeepAlive(outState);
				}
			}

			// Token: 0x0600169F RID: 5791 RVA: 0x0003A480 File Offset: 0x00038680
			private static Delegate GetOnActivityPostStarted_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPostStarted_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPostStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPostStarted_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPostStarted_Landroid_app_Activity_;
			}

			// Token: 0x060016A0 RID: 5792 RVA: 0x0003A4A4 File Offset: 0x000386A4
			private static void n_OnActivityPostStarted_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPostStarted(object2);
			}

			// Token: 0x060016A1 RID: 5793 RVA: 0x0003A4C8 File Offset: 0x000386C8
			[Register("onActivityPostStarted", "(Landroid/app/Activity;)V", "GetOnActivityPostStarted_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPostStarted(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPostStarted.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x060016A2 RID: 5794 RVA: 0x0003A52C File Offset: 0x0003872C
			private static Delegate GetOnActivityPostStopped_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPostStopped_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPostStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPostStopped_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPostStopped_Landroid_app_Activity_;
			}

			// Token: 0x060016A3 RID: 5795 RVA: 0x0003A550 File Offset: 0x00038750
			private static void n_OnActivityPostStopped_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPostStopped(object2);
			}

			// Token: 0x060016A4 RID: 5796 RVA: 0x0003A574 File Offset: 0x00038774
			[Register("onActivityPostStopped", "(Landroid/app/Activity;)V", "GetOnActivityPostStopped_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPostStopped(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPostStopped.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x060016A5 RID: 5797 RVA: 0x0003A5D8 File Offset: 0x000387D8
			private static Delegate GetOnActivityPreCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPreCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPreCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPreCreated_Landroid_app_Activity_Landroid_os_Bundle_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPreCreated_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			// Token: 0x060016A6 RID: 5798 RVA: 0x0003A5FC File Offset: 0x000387FC
			private static void n_OnActivityPreCreated_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPreCreated(object2, object3);
			}

			// Token: 0x060016A7 RID: 5799 RVA: 0x0003A628 File Offset: 0x00038828
			[Register("onActivityPreCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityPreCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPreCreated(Activity activity, Bundle savedInstanceState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					ptr[1] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPreCreated.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
					GC.KeepAlive(savedInstanceState);
				}
			}

			// Token: 0x060016A8 RID: 5800 RVA: 0x0003A6B4 File Offset: 0x000388B4
			private static Delegate GetOnActivityPreDestroyed_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPreDestroyed_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPreDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPreDestroyed_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPreDestroyed_Landroid_app_Activity_;
			}

			// Token: 0x060016A9 RID: 5801 RVA: 0x0003A6D8 File Offset: 0x000388D8
			private static void n_OnActivityPreDestroyed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPreDestroyed(object2);
			}

			// Token: 0x060016AA RID: 5802 RVA: 0x0003A6FC File Offset: 0x000388FC
			[Register("onActivityPreDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityPreDestroyed_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPreDestroyed(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPreDestroyed.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x060016AB RID: 5803 RVA: 0x0003A760 File Offset: 0x00038960
			private static Delegate GetOnActivityPrePaused_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPrePaused_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPrePaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPrePaused_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPrePaused_Landroid_app_Activity_;
			}

			// Token: 0x060016AC RID: 5804 RVA: 0x0003A784 File Offset: 0x00038984
			private static void n_OnActivityPrePaused_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPrePaused(object2);
			}

			// Token: 0x060016AD RID: 5805 RVA: 0x0003A7A8 File Offset: 0x000389A8
			[Register("onActivityPrePaused", "(Landroid/app/Activity;)V", "GetOnActivityPrePaused_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPrePaused(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPrePaused.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x060016AE RID: 5806 RVA: 0x0003A80C File Offset: 0x00038A0C
			private static Delegate GetOnActivityPreResumed_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPreResumed_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPreResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPreResumed_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPreResumed_Landroid_app_Activity_;
			}

			// Token: 0x060016AF RID: 5807 RVA: 0x0003A830 File Offset: 0x00038A30
			private static void n_OnActivityPreResumed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPreResumed(object2);
			}

			// Token: 0x060016B0 RID: 5808 RVA: 0x0003A854 File Offset: 0x00038A54
			[Register("onActivityPreResumed", "(Landroid/app/Activity;)V", "GetOnActivityPreResumed_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPreResumed(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPreResumed.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x060016B1 RID: 5809 RVA: 0x0003A8B8 File Offset: 0x00038AB8
			private static Delegate GetOnActivityPreSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPreSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPreSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPreSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPreSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			// Token: 0x060016B2 RID: 5810 RVA: 0x0003A8DC File Offset: 0x00038ADC
			private static void n_OnActivityPreSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_outState)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPreSaveInstanceState(object2, object3);
			}

			// Token: 0x060016B3 RID: 5811 RVA: 0x0003A908 File Offset: 0x00038B08
			[Register("onActivityPreSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityPreSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPreSaveInstanceState(Activity activity, Bundle outState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					ptr[1] = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPreSaveInstanceState.(Landroid/app/Activity;Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
					GC.KeepAlive(outState);
				}
			}

			// Token: 0x060016B4 RID: 5812 RVA: 0x0003A994 File Offset: 0x00038B94
			private static Delegate GetOnActivityPreStarted_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPreStarted_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPreStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPreStarted_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPreStarted_Landroid_app_Activity_;
			}

			// Token: 0x060016B5 RID: 5813 RVA: 0x0003A9B8 File Offset: 0x00038BB8
			private static void n_OnActivityPreStarted_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPreStarted(object2);
			}

			// Token: 0x060016B6 RID: 5814 RVA: 0x0003A9DC File Offset: 0x00038BDC
			[Register("onActivityPreStarted", "(Landroid/app/Activity;)V", "GetOnActivityPreStarted_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPreStarted(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPreStarted.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x060016B7 RID: 5815 RVA: 0x0003AA40 File Offset: 0x00038C40
			private static Delegate GetOnActivityPreStopped_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacks.cb_onActivityPreStopped_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacks.cb_onActivityPreStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacks.n_OnActivityPreStopped_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacks.cb_onActivityPreStopped_Landroid_app_Activity_;
			}

			// Token: 0x060016B8 RID: 5816 RVA: 0x0003AA64 File Offset: 0x00038C64
			private static void n_OnActivityPreStopped_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPreStopped(object2);
			}

			// Token: 0x060016B9 RID: 5817 RVA: 0x0003AA88 File Offset: 0x00038C88
			[Register("onActivityPreStopped", "(Landroid/app/Activity;)V", "GetOnActivityPreStopped_Landroid_app_Activity_Handler:Android.App.Application/IActivityLifecycleCallbacks, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 29)]
			unsafe void OnActivityPreStopped(Activity activity)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
					Application.IActivityLifecycleCallbacks._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityPreStopped.(Landroid/app/Activity;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(activity);
				}
			}

			// Token: 0x040009B9 RID: 2489
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Application$ActivityLifecycleCallbacks", typeof(Application.IActivityLifecycleCallbacks), true);

			// Token: 0x040009BA RID: 2490
			private static Delegate cb_onActivityPostCreated_Landroid_app_Activity_Landroid_os_Bundle_;

			// Token: 0x040009BB RID: 2491
			private static Delegate cb_onActivityPostDestroyed_Landroid_app_Activity_;

			// Token: 0x040009BC RID: 2492
			private static Delegate cb_onActivityPostPaused_Landroid_app_Activity_;

			// Token: 0x040009BD RID: 2493
			private static Delegate cb_onActivityPostResumed_Landroid_app_Activity_;

			// Token: 0x040009BE RID: 2494
			private static Delegate cb_onActivityPostSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;

			// Token: 0x040009BF RID: 2495
			private static Delegate cb_onActivityPostStarted_Landroid_app_Activity_;

			// Token: 0x040009C0 RID: 2496
			private static Delegate cb_onActivityPostStopped_Landroid_app_Activity_;

			// Token: 0x040009C1 RID: 2497
			private static Delegate cb_onActivityPreCreated_Landroid_app_Activity_Landroid_os_Bundle_;

			// Token: 0x040009C2 RID: 2498
			private static Delegate cb_onActivityPreDestroyed_Landroid_app_Activity_;

			// Token: 0x040009C3 RID: 2499
			private static Delegate cb_onActivityPrePaused_Landroid_app_Activity_;

			// Token: 0x040009C4 RID: 2500
			private static Delegate cb_onActivityPreResumed_Landroid_app_Activity_;

			// Token: 0x040009C5 RID: 2501
			private static Delegate cb_onActivityPreSaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;

			// Token: 0x040009C6 RID: 2502
			private static Delegate cb_onActivityPreStarted_Landroid_app_Activity_;

			// Token: 0x040009C7 RID: 2503
			private static Delegate cb_onActivityPreStopped_Landroid_app_Activity_;
		}

		// Token: 0x0200025D RID: 605
		[Register("android/app/Application$ActivityLifecycleCallbacks", DoNotGenerateAcw = true)]
		internal class IActivityLifecycleCallbacksInvoker : Java.Lang.Object, Application.IActivityLifecycleCallbacks, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170004E2 RID: 1250
			// (get) Token: 0x060016BB RID: 5819 RVA: 0x0003AB08 File Offset: 0x00038D08
			private static IntPtr java_class_ref
			{
				get
				{
					return Application.IActivityLifecycleCallbacksInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170004E3 RID: 1251
			// (get) Token: 0x060016BC RID: 5820 RVA: 0x0003AB2C File Offset: 0x00038D2C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Application.IActivityLifecycleCallbacksInvoker._members;
				}
			}

			// Token: 0x170004E4 RID: 1252
			// (get) Token: 0x060016BD RID: 5821 RVA: 0x0003AB33 File Offset: 0x00038D33
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170004E5 RID: 1253
			// (get) Token: 0x060016BE RID: 5822 RVA: 0x0003AB3B File Offset: 0x00038D3B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Application.IActivityLifecycleCallbacksInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060016BF RID: 5823 RVA: 0x0003AB47 File Offset: 0x00038D47
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Application.IActivityLifecycleCallbacksInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.app.Application.ActivityLifecycleCallbacks'.");
				}
				return handle;
			}

			// Token: 0x060016C0 RID: 5824 RVA: 0x0003AB72 File Offset: 0x00038D72
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060016C1 RID: 5825 RVA: 0x0003ABA4 File Offset: 0x00038DA4
			public IActivityLifecycleCallbacksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Application.IActivityLifecycleCallbacksInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060016C2 RID: 5826 RVA: 0x0003ABDC File Offset: 0x00038DDC
			private static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler()
			{
				if (Application.IActivityLifecycleCallbacksInvoker.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				{
					Application.IActivityLifecycleCallbacksInvoker.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Application.IActivityLifecycleCallbacksInvoker.n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_));
				}
				return Application.IActivityLifecycleCallbacksInvoker.cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x0003AC00 File Offset: 0x00038E00
			private static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityCreated(object2, object3);
			}

			// Token: 0x060016C4 RID: 5828 RVA: 0x0003AC2C File Offset: 0x00038E2C
			public unsafe void OnActivityCreated(Activity activity, Bundle savedInstanceState)
			{
				if (this.id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				{
					this.id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_, ptr);
			}

			// Token: 0x060016C5 RID: 5829 RVA: 0x0003ACC1 File Offset: 0x00038EC1
			private static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacksInvoker.cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacksInvoker.cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacksInvoker.n_OnActivityDestroyed_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacksInvoker.cb_onActivityDestroyed_Landroid_app_Activity_;
			}

			// Token: 0x060016C6 RID: 5830 RVA: 0x0003ACE8 File Offset: 0x00038EE8
			private static void n_OnActivityDestroyed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityDestroyed(object2);
			}

			// Token: 0x060016C7 RID: 5831 RVA: 0x0003AD0C File Offset: 0x00038F0C
			public unsafe void OnActivityDestroyed(Activity activity)
			{
				if (this.id_onActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
				{
					this.id_onActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetMethodID(this.class_ref, "onActivityDestroyed", "(Landroid/app/Activity;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActivityDestroyed_Landroid_app_Activity_, ptr);
			}

			// Token: 0x060016C8 RID: 5832 RVA: 0x0003AD7F File Offset: 0x00038F7F
			private static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacksInvoker.cb_onActivityPaused_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacksInvoker.cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacksInvoker.n_OnActivityPaused_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacksInvoker.cb_onActivityPaused_Landroid_app_Activity_;
			}

			// Token: 0x060016C9 RID: 5833 RVA: 0x0003ADA4 File Offset: 0x00038FA4
			private static void n_OnActivityPaused_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityPaused(object2);
			}

			// Token: 0x060016CA RID: 5834 RVA: 0x0003ADC8 File Offset: 0x00038FC8
			public unsafe void OnActivityPaused(Activity activity)
			{
				if (this.id_onActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
				{
					this.id_onActivityPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID(this.class_ref, "onActivityPaused", "(Landroid/app/Activity;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActivityPaused_Landroid_app_Activity_, ptr);
			}

			// Token: 0x060016CB RID: 5835 RVA: 0x0003AE3B File Offset: 0x0003903B
			private static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacksInvoker.cb_onActivityResumed_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacksInvoker.cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacksInvoker.n_OnActivityResumed_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacksInvoker.cb_onActivityResumed_Landroid_app_Activity_;
			}

			// Token: 0x060016CC RID: 5836 RVA: 0x0003AE60 File Offset: 0x00039060
			private static void n_OnActivityResumed_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityResumed(object2);
			}

			// Token: 0x060016CD RID: 5837 RVA: 0x0003AE84 File Offset: 0x00039084
			public unsafe void OnActivityResumed(Activity activity)
			{
				if (this.id_onActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
				{
					this.id_onActivityResumed_Landroid_app_Activity_ = JNIEnv.GetMethodID(this.class_ref, "onActivityResumed", "(Landroid/app/Activity;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActivityResumed_Landroid_app_Activity_, ptr);
			}

			// Token: 0x060016CE RID: 5838 RVA: 0x0003AEF7 File Offset: 0x000390F7
			private static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler()
			{
				if (Application.IActivityLifecycleCallbacksInvoker.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				{
					Application.IActivityLifecycleCallbacksInvoker.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Application.IActivityLifecycleCallbacksInvoker.n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_));
				}
				return Application.IActivityLifecycleCallbacksInvoker.cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			// Token: 0x060016CF RID: 5839 RVA: 0x0003AF1C File Offset: 0x0003911C
			private static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_outState)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
				@object.OnActivitySaveInstanceState(object2, object3);
			}

			// Token: 0x060016D0 RID: 5840 RVA: 0x0003AF48 File Offset: 0x00039148
			public unsafe void OnActivitySaveInstanceState(Activity activity, Bundle outState)
			{
				if (this.id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				{
					this.id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JValue((outState == null) ? IntPtr.Zero : outState.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_, ptr);
			}

			// Token: 0x060016D1 RID: 5841 RVA: 0x0003AFDD File Offset: 0x000391DD
			private static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacksInvoker.cb_onActivityStarted_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacksInvoker.cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacksInvoker.n_OnActivityStarted_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacksInvoker.cb_onActivityStarted_Landroid_app_Activity_;
			}

			// Token: 0x060016D2 RID: 5842 RVA: 0x0003B004 File Offset: 0x00039204
			private static void n_OnActivityStarted_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityStarted(object2);
			}

			// Token: 0x060016D3 RID: 5843 RVA: 0x0003B028 File Offset: 0x00039228
			public unsafe void OnActivityStarted(Activity activity)
			{
				if (this.id_onActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				{
					this.id_onActivityStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID(this.class_ref, "onActivityStarted", "(Landroid/app/Activity;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActivityStarted_Landroid_app_Activity_, ptr);
			}

			// Token: 0x060016D4 RID: 5844 RVA: 0x0003B09B File Offset: 0x0003929B
			private static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler()
			{
				if (Application.IActivityLifecycleCallbacksInvoker.cb_onActivityStopped_Landroid_app_Activity_ == null)
				{
					Application.IActivityLifecycleCallbacksInvoker.cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Application.IActivityLifecycleCallbacksInvoker.n_OnActivityStopped_Landroid_app_Activity_));
				}
				return Application.IActivityLifecycleCallbacksInvoker.cb_onActivityStopped_Landroid_app_Activity_;
			}

			// Token: 0x060016D5 RID: 5845 RVA: 0x0003B0C0 File Offset: 0x000392C0
			private static void n_OnActivityStopped_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
			{
				Application.IActivityLifecycleCallbacks @object = Java.Lang.Object.GetObject<Application.IActivityLifecycleCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				@object.OnActivityStopped(object2);
			}

			// Token: 0x060016D6 RID: 5846 RVA: 0x0003B0E4 File Offset: 0x000392E4
			public unsafe void OnActivityStopped(Activity activity)
			{
				if (this.id_onActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				{
					this.id_onActivityStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID(this.class_ref, "onActivityStopped", "(Landroid/app/Activity;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActivityStopped_Landroid_app_Activity_, ptr);
			}

			// Token: 0x040009C8 RID: 2504
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Application$ActivityLifecycleCallbacks", typeof(Application.IActivityLifecycleCallbacksInvoker));

			// Token: 0x040009C9 RID: 2505
			private IntPtr class_ref;

			// Token: 0x040009CA RID: 2506
			private static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;

			// Token: 0x040009CB RID: 2507
			private IntPtr id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;

			// Token: 0x040009CC RID: 2508
			private static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;

			// Token: 0x040009CD RID: 2509
			private IntPtr id_onActivityDestroyed_Landroid_app_Activity_;

			// Token: 0x040009CE RID: 2510
			private static Delegate cb_onActivityPaused_Landroid_app_Activity_;

			// Token: 0x040009CF RID: 2511
			private IntPtr id_onActivityPaused_Landroid_app_Activity_;

			// Token: 0x040009D0 RID: 2512
			private static Delegate cb_onActivityResumed_Landroid_app_Activity_;

			// Token: 0x040009D1 RID: 2513
			private IntPtr id_onActivityResumed_Landroid_app_Activity_;

			// Token: 0x040009D2 RID: 2514
			private static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;

			// Token: 0x040009D3 RID: 2515
			private IntPtr id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;

			// Token: 0x040009D4 RID: 2516
			private static Delegate cb_onActivityStarted_Landroid_app_Activity_;

			// Token: 0x040009D5 RID: 2517
			private IntPtr id_onActivityStarted_Landroid_app_Activity_;

			// Token: 0x040009D6 RID: 2518
			private static Delegate cb_onActivityStopped_Landroid_app_Activity_;

			// Token: 0x040009D7 RID: 2519
			private IntPtr id_onActivityStopped_Landroid_app_Activity_;
		}
	}
}
