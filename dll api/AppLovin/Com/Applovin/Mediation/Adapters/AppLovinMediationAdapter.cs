using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapters
{
	// Token: 0x020000F2 RID: 242
	[Register("com/applovin/mediation/adapters/AppLovinMediationAdapter", DoNotGenerateAcw = true)]
	public class AppLovinMediationAdapter : MediationAdapterBase, IMaxAdViewAdapter, IJavaObject, IDisposable, IJavaPeerable, IMaxInterstitialAdapter, IMaxRewardedAdapter, IMaxRewardedInterstitialAdapter, IMaxSignalProvider
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00019D84 File Offset: 0x00017F84
		internal new static IntPtr class_ref
		{
			get
			{
				return AppLovinMediationAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00019DA8 File Offset: 0x00017FA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinMediationAdapter._members;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00019DB0 File Offset: 0x00017FB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinMediationAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00019DD4 File Offset: 0x00017FD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinMediationAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00019DE0 File Offset: 0x00017FE0
		protected AppLovinMediationAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00019DEC File Offset: 0x00017FEC
		[Register(".ctor", "(Lcom/applovin/sdk/AppLovinSdk;)V", "")]
		public unsafe AppLovinMediationAdapter(AppLovinSdk p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(AppLovinMediationAdapter._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinMediationAdapter._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00019E9C File Offset: 0x0001809C
		private static Delegate GetGetAdapterVersionHandler()
		{
			if (AppLovinMediationAdapter.cb_getAdapterVersion == null)
			{
				AppLovinMediationAdapter.cb_getAdapterVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinMediationAdapter.n_GetAdapterVersion));
			}
			return AppLovinMediationAdapter.cb_getAdapterVersion;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00019EC0 File Offset: 0x000180C0
		private static IntPtr n_GetAdapterVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdapterVersion);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00019ED4 File Offset: 0x000180D4
		public override string AdapterVersion
		{
			[Register("getAdapterVersion", "()Ljava/lang/String;", "GetGetAdapterVersionHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapterVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00019F06 File Offset: 0x00018106
		private static Delegate GetGetSdkVersionHandler()
		{
			if (AppLovinMediationAdapter.cb_getSdkVersion == null)
			{
				AppLovinMediationAdapter.cb_getSdkVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinMediationAdapter.n_GetSdkVersion));
			}
			return AppLovinMediationAdapter.cb_getSdkVersion;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00019F2A File Offset: 0x0001812A
		private static IntPtr n_GetSdkVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkVersion);
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00019F40 File Offset: 0x00018140
		public override string SdkVersion
		{
			[Register("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getSdkVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00019F72 File Offset: 0x00018172
		private static Delegate GetCollectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_ == null)
			{
				AppLovinMediationAdapter.cb_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinMediationAdapter.n_CollectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_));
			}
			return AppLovinMediationAdapter.cb_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00019F98 File Offset: 0x00018198
		private static void n_CollectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinMediationAdapter @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterSignalCollectionParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxSignalCollectionListener object4 = Java.Lang.Object.GetObject<IMaxSignalCollectionListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.CollectSignal(object2, object3, object4);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00019FD0 File Offset: 0x000181D0
		[Register("collectSignal", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterSignalCollectionParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxSignalCollectionListener;)V", "GetCollectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_Handler")]
		public unsafe virtual void CollectSignal(IMaxAdapterSignalCollectionParameters p0, Activity p1, IMaxSignalCollectionListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("collectSignal.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterSignalCollectionParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxSignalCollectionListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0001A090 File Offset: 0x00018290
		private static Delegate GetInitialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_ == null)
			{
				AppLovinMediationAdapter.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinMediationAdapter.n_Initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_));
			}
			return AppLovinMediationAdapter.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0001A0B4 File Offset: 0x000182B4
		private static void n_Initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterInitializationParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterOnCompletionListener object4 = Java.Lang.Object.GetObject<IMaxAdapterOnCompletionListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, object3, object4);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0001A0EC File Offset: 0x000182EC
		[Register("initialize", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;)V", "GetInitialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_Handler")]
		public unsafe override void Initialize(IMaxAdapterInitializationParameters p0, Activity p1, IMaxAdapterOnCompletionListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("initialize.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001A1AC File Offset: 0x000183AC
		private static Delegate GetLoadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_ == null)
			{
				AppLovinMediationAdapter.cb_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(AppLovinMediationAdapter.n_LoadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_));
			}
			return AppLovinMediationAdapter.cb_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001A1D0 File Offset: 0x000183D0
		private static void n_LoadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			AppLovinMediationAdapter @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			MaxAdFormat object3 = Java.Lang.Object.GetObject<MaxAdFormat>(native_p1, JniHandleOwnership.DoNotTransfer);
			Activity object4 = Java.Lang.Object.GetObject<Activity>(native_p2, JniHandleOwnership.DoNotTransfer);
			IMaxAdViewAdapterListener object5 = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.LoadAdViewAd(object2, object3, object4, object5);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001A210 File Offset: 0x00018410
		[Register("loadAdViewAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Lcom/applovin/mediation/MaxAdFormat;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener;)V", "GetLoadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Handler")]
		public unsafe virtual void LoadAdViewAd(IMaxAdapterResponseParameters p0, MaxAdFormat p1, Activity p2, IMaxAdViewAdapterListener p3)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("loadAdViewAd.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Lcom/applovin/mediation/MaxAdFormat;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0001A300 File Offset: 0x00018500
		private static Delegate GetLoadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ == null)
			{
				AppLovinMediationAdapter.cb_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinMediationAdapter.n_LoadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_));
			}
			return AppLovinMediationAdapter.cb_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0001A324 File Offset: 0x00018524
		private static void n_LoadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinMediationAdapter @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxInterstitialAdapterListener object4 = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadInterstitialAd(object2, object3, object4);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0001A35C File Offset: 0x0001855C
		[Register("loadInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;)V", "GetLoadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Handler")]
		public unsafe virtual void LoadInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxInterstitialAdapterListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("loadInterstitialAd.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0001A41C File Offset: 0x0001861C
		private static Delegate GetLoadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ == null)
			{
				AppLovinMediationAdapter.cb_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinMediationAdapter.n_LoadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_));
			}
			return AppLovinMediationAdapter.cb_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0001A440 File Offset: 0x00018640
		private static void n_LoadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinMediationAdapter @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedAdapterListener object4 = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedAd(object2, object3, object4);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0001A478 File Offset: 0x00018678
		[Register("loadRewardedAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;)V", "GetLoadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Handler")]
		public unsafe virtual void LoadRewardedAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedAdapterListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("loadRewardedAd.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0001A538 File Offset: 0x00018738
		private static Delegate GetLoadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ == null)
			{
				AppLovinMediationAdapter.cb_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinMediationAdapter.n_LoadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_));
			}
			return AppLovinMediationAdapter.cb_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0001A55C File Offset: 0x0001875C
		private static void n_LoadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinMediationAdapter @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedInterstitialAdapterListener object4 = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedInterstitialAd(object2, object3, object4);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0001A594 File Offset: 0x00018794
		[Register("loadRewardedInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener;)V", "GetLoadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_Handler")]
		public unsafe virtual void LoadRewardedInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedInterstitialAdapterListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("loadRewardedInterstitialAd.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0001A654 File Offset: 0x00018854
		private static Delegate GetOnDestroyHandler()
		{
			if (AppLovinMediationAdapter.cb_onDestroy == null)
			{
				AppLovinMediationAdapter.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinMediationAdapter.n_OnDestroy));
			}
			return AppLovinMediationAdapter.cb_onDestroy;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0001A678 File Offset: 0x00018878
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0001A687 File Offset: 0x00018887
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public override void OnDestroy()
		{
			AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0001A6A0 File Offset: 0x000188A0
		private static Delegate GetShowInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ == null)
			{
				AppLovinMediationAdapter.cb_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinMediationAdapter.n_ShowInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_));
			}
			return AppLovinMediationAdapter.cb_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0001A6C4 File Offset: 0x000188C4
		private static void n_ShowInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinMediationAdapter @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxInterstitialAdapterListener object4 = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.ShowInterstitialAd(object2, object3, object4);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0001A6FC File Offset: 0x000188FC
		[Register("showInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;)V", "GetShowInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Handler")]
		public unsafe virtual void ShowInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxInterstitialAdapterListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("showInterstitialAd.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0001A7BC File Offset: 0x000189BC
		private static Delegate GetShowRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ == null)
			{
				AppLovinMediationAdapter.cb_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinMediationAdapter.n_ShowRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_));
			}
			return AppLovinMediationAdapter.cb_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0001A7E0 File Offset: 0x000189E0
		private static void n_ShowRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinMediationAdapter @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedAdapterListener object4 = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.ShowRewardedAd(object2, object3, object4);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0001A818 File Offset: 0x00018A18
		[Register("showRewardedAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;)V", "GetShowRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Handler")]
		public unsafe virtual void ShowRewardedAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedAdapterListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("showRewardedAd.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		private static Delegate GetShowRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_Handler()
		{
			if (AppLovinMediationAdapter.cb_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ == null)
			{
				AppLovinMediationAdapter.cb_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinMediationAdapter.n_ShowRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_));
			}
			return AppLovinMediationAdapter.cb_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0001A8FC File Offset: 0x00018AFC
		private static void n_ShowRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinMediationAdapter @object = Java.Lang.Object.GetObject<AppLovinMediationAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedInterstitialAdapterListener object4 = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.ShowRewardedInterstitialAd(object2, object3, object4);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0001A934 File Offset: 0x00018B34
		[Register("showRewardedInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener;)V", "GetShowRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_Handler")]
		public unsafe virtual void ShowRewardedInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedInterstitialAdapterListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinMediationAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("showRewardedInterstitialAd.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0400033B RID: 827
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapters/AppLovinMediationAdapter", typeof(AppLovinMediationAdapter));

		// Token: 0x0400033C RID: 828
		private static Delegate cb_getAdapterVersion;

		// Token: 0x0400033D RID: 829
		private static Delegate cb_getSdkVersion;

		// Token: 0x0400033E RID: 830
		private static Delegate cb_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_;

		// Token: 0x0400033F RID: 831
		private static Delegate cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_;

		// Token: 0x04000340 RID: 832
		private static Delegate cb_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_;

		// Token: 0x04000341 RID: 833
		private static Delegate cb_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;

		// Token: 0x04000342 RID: 834
		private static Delegate cb_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;

		// Token: 0x04000343 RID: 835
		private static Delegate cb_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;

		// Token: 0x04000344 RID: 836
		private static Delegate cb_onDestroy;

		// Token: 0x04000345 RID: 837
		private static Delegate cb_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;

		// Token: 0x04000346 RID: 838
		private static Delegate cb_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;

		// Token: 0x04000347 RID: 839
		private static Delegate cb_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;
	}
}
