using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Applovin.Mediation.Adapters
{
	// Token: 0x020000F3 RID: 243
	[Register("com/applovin/mediation/adapters/MediationAdapterBase", DoNotGenerateAcw = true)]
	public abstract class MediationAdapterBase : Java.Lang.Object, IMaxAdapter, IJavaObject, IDisposable, IJavaPeerable, IMaxInterstitialAdViewAdapter, IMaxNativeAdAdapter, IMaxRewardedAdViewAdapter
	{
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0001AA10 File Offset: 0x00018C10
		internal static IntPtr class_ref
		{
			get
			{
				return MediationAdapterBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0001AA34 File Offset: 0x00018C34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediationAdapterBase._members;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0001AA3C File Offset: 0x00018C3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediationAdapterBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0001AA60 File Offset: 0x00018C60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediationAdapterBase._members.ManagedPeerType;
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MediationAdapterBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0001AA6C File Offset: 0x00018C6C
		[Register(".ctor", "(Lcom/applovin/sdk/AppLovinSdk;)V", "")]
		public unsafe MediationAdapterBase(AppLovinSdk p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(MediationAdapterBase._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MediationAdapterBase._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0001AB1C File Offset: 0x00018D1C
		private static Delegate GetGetApplicationContextHandler()
		{
			if (MediationAdapterBase.cb_getApplicationContext == null)
			{
				MediationAdapterBase.cb_getApplicationContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediationAdapterBase.n_GetApplicationContext));
			}
			return MediationAdapterBase.cb_getApplicationContext;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0001AB40 File Offset: 0x00018D40
		private static IntPtr n_GetApplicationContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ApplicationContext);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0001AB54 File Offset: 0x00018D54
		protected virtual Context ApplicationContext
		{
			[Register("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(MediationAdapterBase._members.InstanceMethods.InvokeVirtualObjectMethod("getApplicationContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0001AB86 File Offset: 0x00018D86
		private static Delegate GetGetCachingExecutorServiceHandler()
		{
			if (MediationAdapterBase.cb_getCachingExecutorService == null)
			{
				MediationAdapterBase.cb_getCachingExecutorService = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediationAdapterBase.n_GetCachingExecutorService));
			}
			return MediationAdapterBase.cb_getCachingExecutorService;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0001ABAA File Offset: 0x00018DAA
		private static IntPtr n_GetCachingExecutorService(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CachingExecutorService);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0001ABC0 File Offset: 0x00018DC0
		protected virtual IExecutorService CachingExecutorService
		{
			[Register("getCachingExecutorService", "()Ljava/util/concurrent/ExecutorService;", "GetGetCachingExecutorServiceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IExecutorService>(MediationAdapterBase._members.InstanceMethods.InvokeVirtualObjectMethod("getCachingExecutorService.()Ljava/util/concurrent/ExecutorService;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001ABF2 File Offset: 0x00018DF2
		private static Delegate GetIsBetaHandler()
		{
			if (MediationAdapterBase.cb_isBeta == null)
			{
				MediationAdapterBase.cb_isBeta = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MediationAdapterBase.n_IsBeta));
			}
			return MediationAdapterBase.cb_isBeta;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0001AC16 File Offset: 0x00018E16
		private static bool n_IsBeta(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsBeta;
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0001AC25 File Offset: 0x00018E25
		public virtual bool IsBeta
		{
			[Register("isBeta", "()Z", "GetIsBetaHandler")]
			get
			{
				return MediationAdapterBase._members.InstanceMethods.InvokeVirtualBooleanMethod("isBeta.()Z", this, null);
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0001AC3E File Offset: 0x00018E3E
		private static Delegate GetGetRewardHandler()
		{
			if (MediationAdapterBase.cb_getReward == null)
			{
				MediationAdapterBase.cb_getReward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediationAdapterBase.n_GetReward));
			}
			return MediationAdapterBase.cb_getReward;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0001AC62 File Offset: 0x00018E62
		private static IntPtr n_GetReward(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reward);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0001AC78 File Offset: 0x00018E78
		protected virtual IMaxReward Reward
		{
			[Register("getReward", "()Lcom/applovin/mediation/MaxReward;", "GetGetRewardHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMaxReward>(MediationAdapterBase._members.InstanceMethods.InvokeVirtualObjectMethod("getReward.()Lcom/applovin/mediation/MaxReward;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0001ACAA File Offset: 0x00018EAA
		private static Delegate GetGetWrappingSdkHandler()
		{
			if (MediationAdapterBase.cb_getWrappingSdk == null)
			{
				MediationAdapterBase.cb_getWrappingSdk = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediationAdapterBase.n_GetWrappingSdk));
			}
			return MediationAdapterBase.cb_getWrappingSdk;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0001ACCE File Offset: 0x00018ECE
		private static IntPtr n_GetWrappingSdk(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WrappingSdk);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		protected virtual AppLovinSdk WrappingSdk
		{
			[Register("getWrappingSdk", "()Lcom/applovin/sdk/AppLovinSdk;", "GetGetWrappingSdkHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinSdk>(MediationAdapterBase._members.InstanceMethods.InvokeVirtualObjectMethod("getWrappingSdk.()Lcom/applovin/sdk/AppLovinSdk;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0001AD16 File Offset: 0x00018F16
		private static Delegate GetCheckActivities_Landroid_content_Context_arrayLjava_lang_Class_Handler()
		{
			if (MediationAdapterBase.cb_checkActivities_Landroid_content_Context_arrayLjava_lang_Class_ == null)
			{
				MediationAdapterBase.cb_checkActivities_Landroid_content_Context_arrayLjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterBase.n_CheckActivities_Landroid_content_Context_arrayLjava_lang_Class_));
			}
			return MediationAdapterBase.cb_checkActivities_Landroid_content_Context_arrayLjava_lang_Class_;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0001AD3C File Offset: 0x00018F3C
		private static void n_CheckActivities_Landroid_content_Context_arrayLjava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			Class[] array = (Class[])JNIEnv.GetArray(native_p1, JniHandleOwnership.DoNotTransfer, typeof(Class));
			@object.CheckActivities(object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Class>(array, native_p1);
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0001AD84 File Offset: 0x00018F84
		[Register("checkActivities", "(Landroid/content/Context;[Ljava/lang/Class;)V", "GetCheckActivities_Landroid_content_Context_arrayLjava_lang_Class_Handler")]
		protected unsafe virtual void CheckActivities(Context p0, params Class[] p1)
		{
			IntPtr intPtr = JNIEnv.NewArray<Class>(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("checkActivities.(Landroid/content/Context;[Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				if (p1 != null)
				{
					JNIEnv.CopyArray<Class>(intPtr, p1);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0001AE18 File Offset: 0x00019018
		private static Delegate GetCheckExistence_arrayLjava_lang_Class_Handler()
		{
			if (MediationAdapterBase.cb_checkExistence_arrayLjava_lang_Class_ == null)
			{
				MediationAdapterBase.cb_checkExistence_arrayLjava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterBase.n_CheckExistence_arrayLjava_lang_Class_));
			}
			return MediationAdapterBase.cb_checkExistence_arrayLjava_lang_Class_;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0001AE3C File Offset: 0x0001903C
		private static void n_CheckExistence_arrayLjava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class[] array = (Class[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(Class));
			@object.CheckExistence(array);
			if (array != null)
			{
				JNIEnv.CopyArray<Class>(array, native_p0);
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001AE78 File Offset: 0x00019078
		[Register("checkExistence", "([Ljava/lang/Class;)V", "GetCheckExistence_arrayLjava_lang_Class_Handler")]
		protected unsafe virtual void CheckExistence(params Class[] p0)
		{
			IntPtr intPtr = JNIEnv.NewArray<Class>(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("checkExistence.([Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				if (p0 != null)
				{
					JNIEnv.CopyArray<Class>(intPtr, p0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0001AEE4 File Offset: 0x000190E4
		private static Delegate GetConfigureReward_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Handler()
		{
			if (MediationAdapterBase.cb_configureReward_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_ == null)
			{
				MediationAdapterBase.cb_configureReward_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterBase.n_ConfigureReward_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_));
			}
			return MediationAdapterBase.cb_configureReward_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0001AF08 File Offset: 0x00019108
		private static void n_ConfigureReward_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ConfigureReward(object2);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0001AF2C File Offset: 0x0001912C
		[Register("configureReward", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;)V", "GetConfigureReward_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Handler")]
		protected unsafe virtual void ConfigureReward(IMaxAdapterResponseParameters p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("configureReward.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0001AF94 File Offset: 0x00019194
		private static Delegate GetCreateDrawableFuture_Ljava_lang_String_Landroid_content_res_Resources_Handler()
		{
			if (MediationAdapterBase.cb_createDrawableFuture_Ljava_lang_String_Landroid_content_res_Resources_ == null)
			{
				MediationAdapterBase.cb_createDrawableFuture_Ljava_lang_String_Landroid_content_res_Resources_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(MediationAdapterBase.n_CreateDrawableFuture_Ljava_lang_String_Landroid_content_res_Resources_));
			}
			return MediationAdapterBase.cb_createDrawableFuture_Ljava_lang_String_Landroid_content_res_Resources_;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0001AFB8 File Offset: 0x000191B8
		private static IntPtr n_CreateDrawableFuture_Ljava_lang_String_Landroid_content_res_Resources_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Resources object2 = Java.Lang.Object.GetObject<Resources>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateDrawableFuture(@string, object2));
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0001AFEC File Offset: 0x000191EC
		[Register("createDrawableFuture", "(Ljava/lang/String;Landroid/content/res/Resources;)Ljava/util/concurrent/Future;", "GetCreateDrawableFuture_Ljava_lang_String_Landroid_content_res_Resources_Handler")]
		protected unsafe virtual IFuture CreateDrawableFuture(string p0, Resources p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<IFuture>(MediationAdapterBase._members.InstanceMethods.InvokeVirtualObjectMethod("createDrawableFuture.(Ljava/lang/String;Landroid/content/res/Resources;)Ljava/util/concurrent/Future;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0001B080 File Offset: 0x00019280
		private static Delegate GetD_Ljava_lang_String_Handler()
		{
			if (MediationAdapterBase.cb_d_Ljava_lang_String_ == null)
			{
				MediationAdapterBase.cb_d_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterBase.n_D_Ljava_lang_String_));
			}
			return MediationAdapterBase.cb_d_Ljava_lang_String_;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0001B0A4 File Offset: 0x000192A4
		private static void n_D_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.D(@string);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0001B0C8 File Offset: 0x000192C8
		[Register("d", "(Ljava/lang/String;)V", "GetD_Ljava_lang_String_Handler")]
		protected unsafe virtual void D(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("d.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0001B124 File Offset: 0x00019324
		private static Delegate GetE_Ljava_lang_String_Handler()
		{
			if (MediationAdapterBase.cb_e_Ljava_lang_String_ == null)
			{
				MediationAdapterBase.cb_e_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterBase.n_E_Ljava_lang_String_));
			}
			return MediationAdapterBase.cb_e_Ljava_lang_String_;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0001B148 File Offset: 0x00019348
		private static void n_E_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.E(@string);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0001B16C File Offset: 0x0001936C
		[Register("e", "(Ljava/lang/String;)V", "GetE_Ljava_lang_String_Handler")]
		protected unsafe virtual void E(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("e.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0001B1C8 File Offset: 0x000193C8
		private static Delegate GetE_Ljava_lang_String_Ljava_lang_Throwable_Handler()
		{
			if (MediationAdapterBase.cb_e_Ljava_lang_String_Ljava_lang_Throwable_ == null)
			{
				MediationAdapterBase.cb_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterBase.n_E_Ljava_lang_String_Ljava_lang_Throwable_));
			}
			return MediationAdapterBase.cb_e_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0001B1EC File Offset: 0x000193EC
		private static void n_E_Ljava_lang_String_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.E(@string, object2);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0001B218 File Offset: 0x00019418
		[Register("e", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetE_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		protected unsafe virtual void E(string p0, Throwable p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("e.(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0001B29C File Offset: 0x0001949C
		private static Delegate GetI_Ljava_lang_String_Handler()
		{
			if (MediationAdapterBase.cb_i_Ljava_lang_String_ == null)
			{
				MediationAdapterBase.cb_i_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterBase.n_I_Ljava_lang_String_));
			}
			return MediationAdapterBase.cb_i_Ljava_lang_String_;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0001B2C0 File Offset: 0x000194C0
		private static void n_I_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.I(@string);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0001B2E4 File Offset: 0x000194E4
		[Register("i", "(Ljava/lang/String;)V", "GetI_Ljava_lang_String_Handler")]
		protected unsafe virtual void I(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("i.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0001B340 File Offset: 0x00019540
		private static Delegate GetLoadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_Handler()
		{
			if (MediationAdapterBase.cb_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_ == null)
			{
				MediationAdapterBase.cb_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MediationAdapterBase.n_LoadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_));
			}
			return MediationAdapterBase.cb_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0001B364 File Offset: 0x00019564
		private static void n_LoadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxNativeAdAdapterListener object4 = Java.Lang.Object.GetObject<IMaxNativeAdAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadNativeAd(object2, object3, object4);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001B39C File Offset: 0x0001959C
		[Register("loadNativeAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxNativeAdAdapterListener;)V", "GetLoadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_Handler")]
		public unsafe virtual void LoadNativeAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxNativeAdAdapterListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("loadNativeAd.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxNativeAdAdapterListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001B45C File Offset: 0x0001965C
		private static Delegate GetLog_Ljava_lang_String_Handler()
		{
			if (MediationAdapterBase.cb_log_Ljava_lang_String_ == null)
			{
				MediationAdapterBase.cb_log_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterBase.n_Log_Ljava_lang_String_));
			}
			return MediationAdapterBase.cb_log_Ljava_lang_String_;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0001B480 File Offset: 0x00019680
		private static void n_Log_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Log(@string);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0001B4A4 File Offset: 0x000196A4
		[Register("log", "(Ljava/lang/String;)V", "GetLog_Ljava_lang_String_Handler")]
		protected unsafe virtual void Log(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("log.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0001B500 File Offset: 0x00019700
		private static Delegate GetLog_Ljava_lang_String_Ljava_lang_Throwable_Handler()
		{
			if (MediationAdapterBase.cb_log_Ljava_lang_String_Ljava_lang_Throwable_ == null)
			{
				MediationAdapterBase.cb_log_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterBase.n_Log_Ljava_lang_String_Ljava_lang_Throwable_));
			}
			return MediationAdapterBase.cb_log_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001B524 File Offset: 0x00019724
		private static void n_Log_Ljava_lang_String_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Log(@string, object2);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0001B550 File Offset: 0x00019750
		[Register("log", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		protected unsafe virtual void Log(string p0, Throwable p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("log.(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0001B5D4 File Offset: 0x000197D4
		[Register("mediationTag", "()Ljava/lang/String;", "")]
		protected static string MediationTag()
		{
			return JNIEnv.GetString(MediationAdapterBase._members.StaticMethods.InvokeObjectMethod("mediationTag.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0001B605 File Offset: 0x00019805
		private static Delegate GetShouldAlwaysRewardUserHandler()
		{
			if (MediationAdapterBase.cb_shouldAlwaysRewardUser == null)
			{
				MediationAdapterBase.cb_shouldAlwaysRewardUser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MediationAdapterBase.n_ShouldAlwaysRewardUser));
			}
			return MediationAdapterBase.cb_shouldAlwaysRewardUser;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0001B629 File Offset: 0x00019829
		private static bool n_ShouldAlwaysRewardUser(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldAlwaysRewardUser();
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0001B638 File Offset: 0x00019838
		[Register("shouldAlwaysRewardUser", "()Z", "GetShouldAlwaysRewardUserHandler")]
		protected virtual bool ShouldAlwaysRewardUser()
		{
			return MediationAdapterBase._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldAlwaysRewardUser.()Z", this, null);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0001B651 File Offset: 0x00019851
		private static Delegate GetUserError_Ljava_lang_String_Handler()
		{
			if (MediationAdapterBase.cb_userError_Ljava_lang_String_ == null)
			{
				MediationAdapterBase.cb_userError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterBase.n_UserError_Ljava_lang_String_));
			}
			return MediationAdapterBase.cb_userError_Ljava_lang_String_;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0001B678 File Offset: 0x00019878
		private static void n_UserError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.UserError(@string);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0001B69C File Offset: 0x0001989C
		[Register("userError", "(Ljava/lang/String;)V", "GetUserError_Ljava_lang_String_Handler")]
		protected unsafe virtual void UserError(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("userError.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0001B6F8 File Offset: 0x000198F8
		private static Delegate GetUserError_Ljava_lang_String_Ljava_lang_Throwable_Handler()
		{
			if (MediationAdapterBase.cb_userError_Ljava_lang_String_Ljava_lang_Throwable_ == null)
			{
				MediationAdapterBase.cb_userError_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MediationAdapterBase.n_UserError_Ljava_lang_String_Ljava_lang_Throwable_));
			}
			return MediationAdapterBase.cb_userError_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0001B71C File Offset: 0x0001991C
		private static void n_UserError_Ljava_lang_String_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.UserError(@string, object2);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0001B748 File Offset: 0x00019948
		[Register("userError", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetUserError_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		protected unsafe virtual void UserError(string p0, Throwable p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("userError.(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0001B7CC File Offset: 0x000199CC
		private static Delegate GetW_Ljava_lang_String_Handler()
		{
			if (MediationAdapterBase.cb_w_Ljava_lang_String_ == null)
			{
				MediationAdapterBase.cb_w_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationAdapterBase.n_W_Ljava_lang_String_));
			}
			return MediationAdapterBase.cb_w_Ljava_lang_String_;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0001B7F0 File Offset: 0x000199F0
		private static void n_W_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.W(@string);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0001B814 File Offset: 0x00019A14
		[Register("w", "(Ljava/lang/String;)V", "GetW_Ljava_lang_String_Handler")]
		protected unsafe virtual void W(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationAdapterBase._members.InstanceMethods.InvokeVirtualVoidMethod("w.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001B870 File Offset: 0x00019A70
		private static Delegate GetInitialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_Handler()
		{
			if (MediationAdapterBase.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_ == null)
			{
				MediationAdapterBase.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MediationAdapterBase.n_Initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_));
			}
			return MediationAdapterBase.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0001B894 File Offset: 0x00019A94
		private static void n_Initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			MediationAdapterBase @object = Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterInitializationParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterOnCompletionListener object4 = Java.Lang.Object.GetObject<IMaxAdapterOnCompletionListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, object3, object4);
		}

		// Token: 0x06000A32 RID: 2610
		[Register("initialize", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;)V", "GetInitialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_Handler")]
		public abstract void Initialize(IMaxAdapterInitializationParameters p0, Activity p1, IMaxAdapterOnCompletionListener p2);

		// Token: 0x06000A33 RID: 2611 RVA: 0x0001B8CA File Offset: 0x00019ACA
		private static Delegate GetOnDestroyHandler()
		{
			if (MediationAdapterBase.cb_onDestroy == null)
			{
				MediationAdapterBase.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MediationAdapterBase.n_OnDestroy));
			}
			return MediationAdapterBase.cb_onDestroy;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0001B8EE File Offset: 0x00019AEE
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x06000A35 RID: 2613
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public abstract void OnDestroy();

		// Token: 0x06000A36 RID: 2614 RVA: 0x0001B8FD File Offset: 0x00019AFD
		private static Delegate GetGetAdapterVersionHandler()
		{
			if (MediationAdapterBase.cb_getAdapterVersion == null)
			{
				MediationAdapterBase.cb_getAdapterVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediationAdapterBase.n_GetAdapterVersion));
			}
			return MediationAdapterBase.cb_getAdapterVersion;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0001B921 File Offset: 0x00019B21
		private static IntPtr n_GetAdapterVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdapterVersion);
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000A38 RID: 2616
		public abstract string AdapterVersion { [Register("getAdapterVersion", "()Ljava/lang/String;", "GetGetAdapterVersionHandler")] get; }

		// Token: 0x06000A39 RID: 2617 RVA: 0x0001B935 File Offset: 0x00019B35
		private static Delegate GetGetSdkVersionHandler()
		{
			if (MediationAdapterBase.cb_getSdkVersion == null)
			{
				MediationAdapterBase.cb_getSdkVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediationAdapterBase.n_GetSdkVersion));
			}
			return MediationAdapterBase.cb_getSdkVersion;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0001B959 File Offset: 0x00019B59
		private static IntPtr n_GetSdkVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MediationAdapterBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkVersion);
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000A3B RID: 2619
		public abstract string SdkVersion { [Register("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")] get; }

		// Token: 0x04000348 RID: 840
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapters/MediationAdapterBase", typeof(MediationAdapterBase));

		// Token: 0x04000349 RID: 841
		private static Delegate cb_getApplicationContext;

		// Token: 0x0400034A RID: 842
		private static Delegate cb_getCachingExecutorService;

		// Token: 0x0400034B RID: 843
		private static Delegate cb_isBeta;

		// Token: 0x0400034C RID: 844
		private static Delegate cb_getReward;

		// Token: 0x0400034D RID: 845
		private static Delegate cb_getWrappingSdk;

		// Token: 0x0400034E RID: 846
		private static Delegate cb_checkActivities_Landroid_content_Context_arrayLjava_lang_Class_;

		// Token: 0x0400034F RID: 847
		private static Delegate cb_checkExistence_arrayLjava_lang_Class_;

		// Token: 0x04000350 RID: 848
		private static Delegate cb_configureReward_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_;

		// Token: 0x04000351 RID: 849
		private static Delegate cb_createDrawableFuture_Ljava_lang_String_Landroid_content_res_Resources_;

		// Token: 0x04000352 RID: 850
		private static Delegate cb_d_Ljava_lang_String_;

		// Token: 0x04000353 RID: 851
		private static Delegate cb_e_Ljava_lang_String_;

		// Token: 0x04000354 RID: 852
		private static Delegate cb_e_Ljava_lang_String_Ljava_lang_Throwable_;

		// Token: 0x04000355 RID: 853
		private static Delegate cb_i_Ljava_lang_String_;

		// Token: 0x04000356 RID: 854
		private static Delegate cb_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_;

		// Token: 0x04000357 RID: 855
		private static Delegate cb_log_Ljava_lang_String_;

		// Token: 0x04000358 RID: 856
		private static Delegate cb_log_Ljava_lang_String_Ljava_lang_Throwable_;

		// Token: 0x04000359 RID: 857
		private static Delegate cb_shouldAlwaysRewardUser;

		// Token: 0x0400035A RID: 858
		private static Delegate cb_userError_Ljava_lang_String_;

		// Token: 0x0400035B RID: 859
		private static Delegate cb_userError_Ljava_lang_String_Ljava_lang_Throwable_;

		// Token: 0x0400035C RID: 860
		private static Delegate cb_w_Ljava_lang_String_;

		// Token: 0x0400035D RID: 861
		private static Delegate cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_;

		// Token: 0x0400035E RID: 862
		private static Delegate cb_onDestroy;

		// Token: 0x0400035F RID: 863
		private static Delegate cb_getAdapterVersion;

		// Token: 0x04000360 RID: 864
		private static Delegate cb_getSdkVersion;
	}
}
