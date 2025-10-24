using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x02000234 RID: 564
	[Register("com/unity3d/services/ads/adunit/VideoPlayerHandler", DoNotGenerateAcw = true)]
	public class VideoPlayerHandler : Java.Lang.Object, IAdUnitViewHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0004F008 File Offset: 0x0004D208
		internal static IntPtr class_ref
		{
			get
			{
				return VideoPlayerHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0004F02C File Offset: 0x0004D22C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VideoPlayerHandler._members;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0004F034 File Offset: 0x0004D234
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VideoPlayerHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0004F058 File Offset: 0x0004D258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VideoPlayerHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000021E8 File Offset: 0x000003E8
		protected VideoPlayerHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0004F064 File Offset: 0x0004D264
		[Register(".ctor", "()V", "")]
		public VideoPlayerHandler() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(VideoPlayerHandler._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			VideoPlayerHandler._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0004F0D2 File Offset: 0x0004D2D2
		private static Delegate GetGetViewHandler()
		{
			if (VideoPlayerHandler.cb_getView == null)
			{
				VideoPlayerHandler.cb_getView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(VideoPlayerHandler.n_GetView));
			}
			return VideoPlayerHandler.cb_getView;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0004F0F6 File Offset: 0x0004D2F6
		private static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).View);
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0004F10C File Offset: 0x0004D30C
		public virtual View View
		{
			[Register("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(VideoPlayerHandler._members.InstanceMethods.InvokeVirtualObjectMethod("getView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0004F13E File Offset: 0x0004D33E
		private static Delegate GetCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (VideoPlayerHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				VideoPlayerHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(VideoPlayerHandler.n_Create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return VideoPlayerHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0004F164 File Offset: 0x0004D364
		private static bool n_Create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			VideoPlayerHandler @object = Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			return @object.Create(object2);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0004F188 File Offset: 0x0004D388
		[Register("create", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)Z", "GetCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual bool Create(AdUnitActivity activity)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				result = VideoPlayerHandler._members.InstanceMethods.InvokeVirtualBooleanMethod("create.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return result;
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0004F1F0 File Offset: 0x0004D3F0
		private static Delegate GetDestroyHandler()
		{
			if (VideoPlayerHandler.cb_destroy == null)
			{
				VideoPlayerHandler.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(VideoPlayerHandler.n_Destroy));
			}
			return VideoPlayerHandler.cb_destroy;
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0004F214 File Offset: 0x0004D414
		private static bool n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0004F223 File Offset: 0x0004D423
		[Register("destroy", "()Z", "GetDestroyHandler")]
		public virtual bool Destroy()
		{
			return VideoPlayerHandler._members.InstanceMethods.InvokeVirtualBooleanMethod("destroy.()Z", this, null);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0004F23C File Offset: 0x0004D43C
		private static Delegate GetOnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_Handler()
		{
			if (VideoPlayerHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ == null)
			{
				VideoPlayerHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(VideoPlayerHandler.n_OnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_));
			}
			return VideoPlayerHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0004F260 File Offset: 0x0004D460
		private static void n_OnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
		{
			VideoPlayerHandler @object = Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2, object3);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0004F28C File Offset: 0x0004D48C
		[Register("onCreate", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;Landroid/os/Bundle;)V", "GetOnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnCreate(AdUnitActivity activity, Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				VideoPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onCreate.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0004F318 File Offset: 0x0004D518
		private static Delegate GetOnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (VideoPlayerHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				VideoPlayerHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoPlayerHandler.n_OnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return VideoPlayerHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0004F33C File Offset: 0x0004D53C
		private static void n_OnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			VideoPlayerHandler @object = Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnDestroy(object2);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0004F360 File Offset: 0x0004D560
		[Register("onDestroy", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnDestroy(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				VideoPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0004F3C4 File Offset: 0x0004D5C4
		private static Delegate GetOnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (VideoPlayerHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				VideoPlayerHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoPlayerHandler.n_OnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return VideoPlayerHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0004F3E8 File Offset: 0x0004D5E8
		private static void n_OnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			VideoPlayerHandler @object = Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnPause(object2);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0004F40C File Offset: 0x0004D60C
		[Register("onPause", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnPause(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				VideoPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onPause.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0004F470 File Offset: 0x0004D670
		private static Delegate GetOnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (VideoPlayerHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				VideoPlayerHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoPlayerHandler.n_OnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return VideoPlayerHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0004F494 File Offset: 0x0004D694
		private static void n_OnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			VideoPlayerHandler @object = Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnResume(object2);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0004F4B8 File Offset: 0x0004D6B8
		[Register("onResume", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnResume(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				VideoPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onResume.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0004F51C File Offset: 0x0004D71C
		private static Delegate GetOnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (VideoPlayerHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				VideoPlayerHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoPlayerHandler.n_OnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return VideoPlayerHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0004F540 File Offset: 0x0004D740
		private static void n_OnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			VideoPlayerHandler @object = Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnStart(object2);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0004F564 File Offset: 0x0004D764
		[Register("onStart", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnStart(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				VideoPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0004F5C8 File Offset: 0x0004D7C8
		private static Delegate GetOnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (VideoPlayerHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				VideoPlayerHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VideoPlayerHandler.n_OnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return VideoPlayerHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0004F5EC File Offset: 0x0004D7EC
		private static void n_OnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			VideoPlayerHandler @object = Java.Lang.Object.GetObject<VideoPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnStop(object2);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0004F610 File Offset: 0x0004D810
		[Register("onStop", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnStop(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				VideoPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x040006A2 RID: 1698
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/VideoPlayerHandler", typeof(VideoPlayerHandler));

		// Token: 0x040006A3 RID: 1699
		private static Delegate cb_getView;

		// Token: 0x040006A4 RID: 1700
		private static Delegate cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006A5 RID: 1701
		private static Delegate cb_destroy;

		// Token: 0x040006A6 RID: 1702
		private static Delegate cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;

		// Token: 0x040006A7 RID: 1703
		private static Delegate cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006A8 RID: 1704
		private static Delegate cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006A9 RID: 1705
		private static Delegate cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006AA RID: 1706
		private static Delegate cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006AB RID: 1707
		private static Delegate cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
	}
}
