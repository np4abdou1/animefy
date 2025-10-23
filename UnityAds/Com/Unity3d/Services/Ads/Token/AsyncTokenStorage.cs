using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Configuration;
using Com.Unity3d.Services.Core.Request.Metrics;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001D8 RID: 472
	[Register("com/unity3d/services/ads/token/AsyncTokenStorage", DoNotGenerateAcw = true)]
	public class AsyncTokenStorage : Java.Lang.Object
	{
		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x0003E2CC File Offset: 0x0003C4CC
		internal static IntPtr class_ref
		{
			get
			{
				return AsyncTokenStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x0003E2F0 File Offset: 0x0003C4F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AsyncTokenStorage._members;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x0003E2F8 File Offset: 0x0003C4F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AsyncTokenStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x0003E31C File Offset: 0x0003C51C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AsyncTokenStorage._members.ManagedPeerType;
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AsyncTokenStorage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0003E328 File Offset: 0x0003C528
		[Register(".ctor", "(Lcom/unity3d/services/ads/token/INativeTokenGenerator;Landroid/os/Handler;Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", "")]
		public unsafe AsyncTokenStorage(INativeTokenGenerator nativeTokenGenerator, Handler handler, ISDKMetrics sdkMetrics) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((nativeTokenGenerator == null) ? IntPtr.Zero : ((Java.Lang.Object)nativeTokenGenerator).Handle);
				ptr[1] = new JniArgumentValue((handler == null) ? IntPtr.Zero : handler.Handle);
				ptr[2] = new JniArgumentValue((sdkMetrics == null) ? IntPtr.Zero : ((Java.Lang.Object)sdkMetrics).Handle);
				base.SetHandle(AsyncTokenStorage._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/token/INativeTokenGenerator;Landroid/os/Handler;Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AsyncTokenStorage._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/token/INativeTokenGenerator;Landroid/os/Handler;Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(nativeTokenGenerator);
				GC.KeepAlive(handler);
				GC.KeepAlive(sdkMetrics);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x0003E434 File Offset: 0x0003C634
		public static AsyncTokenStorage Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/ads/token/AsyncTokenStorage;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AsyncTokenStorage>(AsyncTokenStorage._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/ads/token/AsyncTokenStorage;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0003E465 File Offset: 0x0003C665
		private static Delegate GetGetToken_Lcom_unity3d_ads_IUnityAdsTokenListener_Handler()
		{
			if (AsyncTokenStorage.cb_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_ == null)
			{
				AsyncTokenStorage.cb_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AsyncTokenStorage.n_GetToken_Lcom_unity3d_ads_IUnityAdsTokenListener_));
			}
			return AsyncTokenStorage.cb_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_;
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0003E48C File Offset: 0x0003C68C
		private static void n_GetToken_Lcom_unity3d_ads_IUnityAdsTokenListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			AsyncTokenStorage @object = Java.Lang.Object.GetObject<AsyncTokenStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IUnityAdsTokenListener object2 = Java.Lang.Object.GetObject<IUnityAdsTokenListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.GetToken(object2);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0003E4B0 File Offset: 0x0003C6B0
		[Register("getToken", "(Lcom/unity3d/ads/IUnityAdsTokenListener;)V", "GetGetToken_Lcom_unity3d_ads_IUnityAdsTokenListener_Handler")]
		public unsafe virtual void GetToken(IUnityAdsTokenListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				AsyncTokenStorage._members.InstanceMethods.InvokeVirtualVoidMethod("getToken.(Lcom/unity3d/ads/IUnityAdsTokenListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0003E518 File Offset: 0x0003C718
		private static Delegate GetOnTokenAvailableHandler()
		{
			if (AsyncTokenStorage.cb_onTokenAvailable == null)
			{
				AsyncTokenStorage.cb_onTokenAvailable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AsyncTokenStorage.n_OnTokenAvailable));
			}
			return AsyncTokenStorage.cb_onTokenAvailable;
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0003E53C File Offset: 0x0003C73C
		private static void n_OnTokenAvailable(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AsyncTokenStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTokenAvailable();
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0003E54B File Offset: 0x0003C74B
		[Register("onTokenAvailable", "()V", "GetOnTokenAvailableHandler")]
		public virtual void OnTokenAvailable()
		{
			AsyncTokenStorage._members.InstanceMethods.InvokeVirtualVoidMethod("onTokenAvailable.()V", this, null);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0003E564 File Offset: 0x0003C764
		private static Delegate GetSetConfiguration_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (AsyncTokenStorage.cb_setConfiguration_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				AsyncTokenStorage.cb_setConfiguration_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AsyncTokenStorage.n_SetConfiguration_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return AsyncTokenStorage.cb_setConfiguration_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0003E588 File Offset: 0x0003C788
		private static void n_SetConfiguration_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			AsyncTokenStorage @object = Java.Lang.Object.GetObject<AsyncTokenStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			@object.SetConfiguration(object2);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0003E5AC File Offset: 0x0003C7AC
		[Register("setConfiguration", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "GetSetConfiguration_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual void SetConfiguration(Configuration configuration)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				AsyncTokenStorage._members.InstanceMethods.InvokeVirtualVoidMethod("setConfiguration.(Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x04000522 RID: 1314
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/token/AsyncTokenStorage", typeof(AsyncTokenStorage));

		// Token: 0x04000523 RID: 1315
		private static Delegate cb_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_;

		// Token: 0x04000524 RID: 1316
		private static Delegate cb_onTokenAvailable;

		// Token: 0x04000525 RID: 1317
		private static Delegate cb_setConfiguration_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
