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
	// Token: 0x02000235 RID: 565
	[Register("com/unity3d/services/ads/adunit/WebPlayerHandler", DoNotGenerateAcw = true)]
	public class WebPlayerHandler : Java.Lang.Object, IAdUnitViewHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0004F690 File Offset: 0x0004D890
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayerHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x0004F6B4 File Offset: 0x0004D8B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayerHandler._members;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0004F6BC File Offset: 0x0004D8BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayerHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0004F6E0 File Offset: 0x0004D8E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayerHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebPlayerHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0004F6EC File Offset: 0x0004D8EC
		[Register(".ctor", "()V", "")]
		public WebPlayerHandler() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebPlayerHandler._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebPlayerHandler._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0004F75A File Offset: 0x0004D95A
		private static Delegate GetGetViewHandler()
		{
			if (WebPlayerHandler.cb_getView == null)
			{
				WebPlayerHandler.cb_getView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebPlayerHandler.n_GetView));
			}
			return WebPlayerHandler.cb_getView;
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0004F77E File Offset: 0x0004D97E
		private static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).View);
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0004F794 File Offset: 0x0004D994
		public virtual View View
		{
			[Register("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(WebPlayerHandler._members.InstanceMethods.InvokeVirtualObjectMethod("getView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0004F7C6 File Offset: 0x0004D9C6
		private static Delegate GetCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebPlayerHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebPlayerHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(WebPlayerHandler.n_Create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebPlayerHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0004F7EC File Offset: 0x0004D9EC
		private static bool n_Create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebPlayerHandler @object = Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			return @object.Create(object2);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0004F810 File Offset: 0x0004DA10
		[Register("create", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)Z", "GetCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual bool Create(AdUnitActivity activity)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				result = WebPlayerHandler._members.InstanceMethods.InvokeVirtualBooleanMethod("create.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return result;
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0004F878 File Offset: 0x0004DA78
		private static Delegate GetDestroyHandler()
		{
			if (WebPlayerHandler.cb_destroy == null)
			{
				WebPlayerHandler.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WebPlayerHandler.n_Destroy));
			}
			return WebPlayerHandler.cb_destroy;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0004F89C File Offset: 0x0004DA9C
		private static bool n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0004F8AB File Offset: 0x0004DAAB
		[Register("destroy", "()Z", "GetDestroyHandler")]
		public virtual bool Destroy()
		{
			return WebPlayerHandler._members.InstanceMethods.InvokeVirtualBooleanMethod("destroy.()Z", this, null);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0004F8C4 File Offset: 0x0004DAC4
		private static Delegate GetOnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_Handler()
		{
			if (WebPlayerHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ == null)
			{
				WebPlayerHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebPlayerHandler.n_OnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_));
			}
			return WebPlayerHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0004F8E8 File Offset: 0x0004DAE8
		private static void n_OnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
		{
			WebPlayerHandler @object = Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2, object3);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0004F914 File Offset: 0x0004DB14
		[Register("onCreate", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;Landroid/os/Bundle;)V", "GetOnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnCreate(AdUnitActivity activity, Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				WebPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onCreate.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0004F9A0 File Offset: 0x0004DBA0
		private static Delegate GetOnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebPlayerHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebPlayerHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerHandler.n_OnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebPlayerHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0004F9C4 File Offset: 0x0004DBC4
		private static void n_OnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebPlayerHandler @object = Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnDestroy(object2);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0004F9E8 File Offset: 0x0004DBE8
		[Register("onDestroy", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnDestroy(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0004FA4C File Offset: 0x0004DC4C
		private static Delegate GetOnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebPlayerHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebPlayerHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerHandler.n_OnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebPlayerHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0004FA70 File Offset: 0x0004DC70
		private static void n_OnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebPlayerHandler @object = Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnPause(object2);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0004FA94 File Offset: 0x0004DC94
		[Register("onPause", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnPause(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onPause.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0004FAF8 File Offset: 0x0004DCF8
		private static Delegate GetOnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebPlayerHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebPlayerHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerHandler.n_OnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebPlayerHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0004FB1C File Offset: 0x0004DD1C
		private static void n_OnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebPlayerHandler @object = Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnResume(object2);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0004FB40 File Offset: 0x0004DD40
		[Register("onResume", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnResume(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onResume.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0004FBA4 File Offset: 0x0004DDA4
		private static Delegate GetOnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebPlayerHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebPlayerHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerHandler.n_OnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebPlayerHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0004FBC8 File Offset: 0x0004DDC8
		private static void n_OnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebPlayerHandler @object = Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnStart(object2);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0004FBEC File Offset: 0x0004DDEC
		[Register("onStart", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnStart(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0004FC50 File Offset: 0x0004DE50
		private static Delegate GetOnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebPlayerHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebPlayerHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerHandler.n_OnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebPlayerHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0004FC74 File Offset: 0x0004DE74
		private static void n_OnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebPlayerHandler @object = Java.Lang.Object.GetObject<WebPlayerHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnStop(object2);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0004FC98 File Offset: 0x0004DE98
		[Register("onStop", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnStop(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebPlayerHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x040006AC RID: 1708
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/WebPlayerHandler", typeof(WebPlayerHandler));

		// Token: 0x040006AD RID: 1709
		private static Delegate cb_getView;

		// Token: 0x040006AE RID: 1710
		private static Delegate cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006AF RID: 1711
		private static Delegate cb_destroy;

		// Token: 0x040006B0 RID: 1712
		private static Delegate cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;

		// Token: 0x040006B1 RID: 1713
		private static Delegate cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006B2 RID: 1714
		private static Delegate cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006B3 RID: 1715
		private static Delegate cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006B4 RID: 1716
		private static Delegate cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006B5 RID: 1717
		private static Delegate cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
	}
}
