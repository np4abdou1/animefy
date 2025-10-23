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
	// Token: 0x02000236 RID: 566
	[Register("com/unity3d/services/ads/adunit/WebViewHandler", DoNotGenerateAcw = true)]
	public class WebViewHandler : Java.Lang.Object, IAdUnitViewHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0004FD18 File Offset: 0x0004DF18
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0004FD3C File Offset: 0x0004DF3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewHandler._members;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0004FD44 File Offset: 0x0004DF44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0004FD68 File Offset: 0x0004DF68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0004FD74 File Offset: 0x0004DF74
		[Register(".ctor", "()V", "")]
		public WebViewHandler() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebViewHandler._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebViewHandler._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0004FDE2 File Offset: 0x0004DFE2
		private static Delegate GetGetViewHandler()
		{
			if (WebViewHandler.cb_getView == null)
			{
				WebViewHandler.cb_getView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewHandler.n_GetView));
			}
			return WebViewHandler.cb_getView;
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0004FE06 File Offset: 0x0004E006
		private static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).View);
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x0004FE1C File Offset: 0x0004E01C
		public virtual View View
		{
			[Register("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(WebViewHandler._members.InstanceMethods.InvokeVirtualObjectMethod("getView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0004FE4E File Offset: 0x0004E04E
		private static Delegate GetCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebViewHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebViewHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(WebViewHandler.n_Create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebViewHandler.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0004FE74 File Offset: 0x0004E074
		private static bool n_Create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebViewHandler @object = Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			return @object.Create(object2);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0004FE98 File Offset: 0x0004E098
		[Register("create", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)Z", "GetCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual bool Create(AdUnitActivity activity)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				result = WebViewHandler._members.InstanceMethods.InvokeVirtualBooleanMethod("create.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return result;
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0004FF00 File Offset: 0x0004E100
		private static Delegate GetDestroyHandler()
		{
			if (WebViewHandler.cb_destroy == null)
			{
				WebViewHandler.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WebViewHandler.n_Destroy));
			}
			return WebViewHandler.cb_destroy;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0004FF24 File Offset: 0x0004E124
		private static bool n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0004FF33 File Offset: 0x0004E133
		[Register("destroy", "()Z", "GetDestroyHandler")]
		public virtual bool Destroy()
		{
			return WebViewHandler._members.InstanceMethods.InvokeVirtualBooleanMethod("destroy.()Z", this, null);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0004FF4C File Offset: 0x0004E14C
		private static Delegate GetOnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_Handler()
		{
			if (WebViewHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ == null)
			{
				WebViewHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebViewHandler.n_OnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_));
			}
			return WebViewHandler.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0004FF70 File Offset: 0x0004E170
		private static void n_OnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
		{
			WebViewHandler @object = Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2, object3);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0004FF9C File Offset: 0x0004E19C
		[Register("onCreate", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;Landroid/os/Bundle;)V", "GetOnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnCreate(AdUnitActivity activity, Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				WebViewHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onCreate.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00050028 File Offset: 0x0004E228
		private static Delegate GetOnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebViewHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebViewHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewHandler.n_OnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebViewHandler.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0005004C File Offset: 0x0004E24C
		private static void n_OnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebViewHandler @object = Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnDestroy(object2);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00050070 File Offset: 0x0004E270
		[Register("onDestroy", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnDestroy(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebViewHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x000500D4 File Offset: 0x0004E2D4
		private static Delegate GetOnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebViewHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebViewHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewHandler.n_OnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebViewHandler.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000500F8 File Offset: 0x0004E2F8
		private static void n_OnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebViewHandler @object = Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnPause(object2);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0005011C File Offset: 0x0004E31C
		[Register("onPause", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnPause(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebViewHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onPause.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00050180 File Offset: 0x0004E380
		private static Delegate GetOnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebViewHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebViewHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewHandler.n_OnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebViewHandler.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x000501A4 File Offset: 0x0004E3A4
		private static void n_OnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebViewHandler @object = Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnResume(object2);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x000501C8 File Offset: 0x0004E3C8
		[Register("onResume", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnResume(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebViewHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onResume.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0005022C File Offset: 0x0004E42C
		private static Delegate GetOnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebViewHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebViewHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewHandler.n_OnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebViewHandler.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x00050250 File Offset: 0x0004E450
		private static void n_OnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebViewHandler @object = Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnStart(object2);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00050274 File Offset: 0x0004E474
		[Register("onStart", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnStart(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebViewHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x000502D8 File Offset: 0x0004E4D8
		private static Delegate GetOnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (WebViewHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				WebViewHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewHandler.n_OnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return WebViewHandler.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x000502FC File Offset: 0x0004E4FC
		private static void n_OnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			WebViewHandler @object = Java.Lang.Object.GetObject<WebViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnStop(object2);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00050320 File Offset: 0x0004E520
		[Register("onStop", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "GetOnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler")]
		public unsafe virtual void OnStop(AdUnitActivity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				WebViewHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x040006B6 RID: 1718
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/WebViewHandler", typeof(WebViewHandler));

		// Token: 0x040006B7 RID: 1719
		private static Delegate cb_getView;

		// Token: 0x040006B8 RID: 1720
		private static Delegate cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006B9 RID: 1721
		private static Delegate cb_destroy;

		// Token: 0x040006BA RID: 1722
		private static Delegate cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;

		// Token: 0x040006BB RID: 1723
		private static Delegate cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006BC RID: 1724
		private static Delegate cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006BD RID: 1725
		private static Delegate cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006BE RID: 1726
		private static Delegate cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006BF RID: 1727
		private static Delegate cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
	}
}
