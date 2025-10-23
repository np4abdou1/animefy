using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Gms.Common.Api.Internal;
using Android.Gms.Common.Apis.Internal;
using Android.Gms.Tasks;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200005E RID: 94
	[Register("com/google/android/gms/common/api/GoogleApi", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"O extends com.google.android.gms.common.api.Api.ApiOptions"
	})]
	public abstract class GoogleApi : Java.Lang.Object, IHasApiKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000BB3C File Offset: 0x00009D3C
		internal static IntPtr class_ref
		{
			get
			{
				return GoogleApi._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000BB60 File Offset: 0x00009D60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleApi._members;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000BB68 File Offset: 0x00009D68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GoogleApi._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000BB8C File Offset: 0x00009D8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleApi._members.ManagedPeerType;
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003280 File Offset: 0x00001480
		protected GoogleApi(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Register(".ctor", "(Landroid/app/Activity;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/GoogleApi$Settings;)V", "")]
		public unsafe GoogleApi(Activity activity, Api api, Java.Lang.Object options, GoogleApi.Settings settings) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(options);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((api == null) ? IntPtr.Zero : api.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((settings == null) ? IntPtr.Zero : settings.Handle);
				base.SetHandle(GoogleApi._members.InstanceMethods.StartCreateInstance("(Landroid/app/Activity;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/GoogleApi$Settings;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GoogleApi._members.InstanceMethods.FinishCreateInstance("(Landroid/app/Activity;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/GoogleApi$Settings;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(api);
				GC.KeepAlive(options);
				GC.KeepAlive(settings);
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		[Register(".ctor", "(Landroid/app/Activity;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", "")]
		public unsafe GoogleApi(Activity activity, Api api, Java.Lang.Object options, IStatusExceptionMapper mapper) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(options);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((api == null) ? IntPtr.Zero : api.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((mapper == null) ? IntPtr.Zero : ((Java.Lang.Object)mapper).Handle);
				base.SetHandle(GoogleApi._members.InstanceMethods.StartCreateInstance("(Landroid/app/Activity;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GoogleApi._members.InstanceMethods.FinishCreateInstance("(Landroid/app/Activity;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(api);
				GC.KeepAlive(options);
				GC.KeepAlive(mapper);
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		[Register(".ctor", "(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Landroid/os/Looper;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", "")]
		public unsafe GoogleApi(Context context, Api api, Java.Lang.Object options, Looper looper, IStatusExceptionMapper mapper) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(options);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((api == null) ? IntPtr.Zero : api.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((looper == null) ? IntPtr.Zero : looper.Handle);
				ptr[4] = new JniArgumentValue((mapper == null) ? IntPtr.Zero : ((Java.Lang.Object)mapper).Handle);
				base.SetHandle(GoogleApi._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Landroid/os/Looper;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GoogleApi._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Landroid/os/Looper;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(api);
				GC.KeepAlive(options);
				GC.KeepAlive(looper);
				GC.KeepAlive(mapper);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000BF54 File Offset: 0x0000A154
		[Register(".ctor", "(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/GoogleApi$Settings;)V", "")]
		public unsafe GoogleApi(Context context, Api api, Java.Lang.Object options, GoogleApi.Settings settings) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(options);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((api == null) ? IntPtr.Zero : api.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((settings == null) ? IntPtr.Zero : settings.Handle);
				base.SetHandle(GoogleApi._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/GoogleApi$Settings;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GoogleApi._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/GoogleApi$Settings;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(api);
				GC.KeepAlive(options);
				GC.KeepAlive(settings);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000C080 File Offset: 0x0000A280
		[Register(".ctor", "(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", "")]
		public unsafe GoogleApi(Context context, Api api, Java.Lang.Object options, IStatusExceptionMapper mapper) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(options);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((api == null) ? IntPtr.Zero : api.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((mapper == null) ? IntPtr.Zero : ((Java.Lang.Object)mapper).Handle);
				base.SetHandle(GoogleApi._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GoogleApi._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(api);
				GC.KeepAlive(options);
				GC.KeepAlive(mapper);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		public ApiKey ApiKey
		{
			[Register("getApiKey", "()Lcom/google/android/gms/common/api/internal/ApiKey;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ApiKey>(GoogleApi._members.InstanceMethods.InvokeNonvirtualObjectMethod("getApiKey.()Lcom/google/android/gms/common/api/internal/ApiKey;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000C1E2 File Offset: 0x0000A3E2
		private static Delegate GetGetApiOptionsHandler()
		{
			if (GoogleApi.cb_getApiOptions == null)
			{
				GoogleApi.cb_getApiOptions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApi.n_GetApiOptions));
			}
			return GoogleApi.cb_getApiOptions;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000C206 File Offset: 0x0000A406
		private static IntPtr n_GetApiOptions(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ApiOptions);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000C21C File Offset: 0x0000A41C
		public virtual Java.Lang.Object ApiOptions
		{
			[Register("getApiOptions", "()Lcom/google/android/gms/common/api/Api$ApiOptions;", "GetGetApiOptionsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("getApiOptions.()Lcom/google/android/gms/common/api/Api$ApiOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000C24E File Offset: 0x0000A44E
		private static Delegate GetGetApplicationContextHandler()
		{
			if (GoogleApi.cb_getApplicationContext == null)
			{
				GoogleApi.cb_getApplicationContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApi.n_GetApplicationContext));
			}
			return GoogleApi.cb_getApplicationContext;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000C272 File Offset: 0x0000A472
		private static IntPtr n_GetApplicationContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ApplicationContext);
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000C288 File Offset: 0x0000A488
		public virtual Context ApplicationContext
		{
			[Register("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("getApplicationContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000C2BA File Offset: 0x0000A4BA
		private static Delegate GetGetContextAttributionTagHandler()
		{
			if (GoogleApi.cb_getContextAttributionTag == null)
			{
				GoogleApi.cb_getContextAttributionTag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApi.n_GetContextAttributionTag));
			}
			return GoogleApi.cb_getContextAttributionTag;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000C2DE File Offset: 0x0000A4DE
		private static IntPtr n_GetContextAttributionTag(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContextAttributionTag);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
		protected virtual string ContextAttributionTag
		{
			[Register("getContextAttributionTag", "()Ljava/lang/String;", "GetGetContextAttributionTagHandler")]
			get
			{
				return JNIEnv.GetString(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("getContextAttributionTag.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000C326 File Offset: 0x0000A526
		private static Delegate GetGetContextFeatureIdHandler()
		{
			if (GoogleApi.cb_getContextFeatureId == null)
			{
				GoogleApi.cb_getContextFeatureId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApi.n_GetContextFeatureId));
			}
			return GoogleApi.cb_getContextFeatureId;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000C34A File Offset: 0x0000A54A
		private static IntPtr n_GetContextFeatureId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContextFeatureId);
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0000C360 File Offset: 0x0000A560
		protected virtual string ContextFeatureId
		{
			[Register("getContextFeatureId", "()Ljava/lang/String;", "GetGetContextFeatureIdHandler")]
			get
			{
				return JNIEnv.GetString(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("getContextFeatureId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000C392 File Offset: 0x0000A592
		private static Delegate GetGetLooperHandler()
		{
			if (GoogleApi.cb_getLooper == null)
			{
				GoogleApi.cb_getLooper = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApi.n_GetLooper));
			}
			return GoogleApi.cb_getLooper;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000C3B6 File Offset: 0x0000A5B6
		private static IntPtr n_GetLooper(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Looper);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		public virtual Looper Looper
		{
			[Register("getLooper", "()Landroid/os/Looper;", "GetGetLooperHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Looper>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("getLooper.()Landroid/os/Looper;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000C3FE File Offset: 0x0000A5FE
		private static Delegate GetAsGoogleApiClientHandler()
		{
			if (GoogleApi.cb_asGoogleApiClient == null)
			{
				GoogleApi.cb_asGoogleApiClient = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApi.n_AsGoogleApiClient));
			}
			return GoogleApi.cb_asGoogleApiClient;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000C422 File Offset: 0x0000A622
		private static IntPtr n_AsGoogleApiClient(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsGoogleApiClient());
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000C438 File Offset: 0x0000A638
		[Register("asGoogleApiClient", "()Lcom/google/android/gms/common/api/GoogleApiClient;", "GetAsGoogleApiClientHandler")]
		public virtual GoogleApiClient AsGoogleApiClient()
		{
			return Java.Lang.Object.GetObject<GoogleApiClient>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("asGoogleApiClient.()Lcom/google/android/gms/common/api/GoogleApiClient;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000C46A File Offset: 0x0000A66A
		private static Delegate GetDisconnectServiceHandler()
		{
			if (GoogleApi.cb_disconnectService == null)
			{
				GoogleApi.cb_disconnectService = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleApi.n_DisconnectService));
			}
			return GoogleApi.cb_disconnectService;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000C48E File Offset: 0x0000A68E
		private static IntPtr n_DisconnectService(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisconnectService());
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		[Register("disconnectService", "()Lcom/google/android/gms/tasks/Task;", "GetDisconnectServiceHandler")]
		protected virtual Task DisconnectService()
		{
			return Java.Lang.Object.GetObject<Task>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("disconnectService.()Lcom/google/android/gms/tasks/Task;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000C4D6 File Offset: 0x0000A6D6
		private static Delegate GetDoBestEffortWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_Handler()
		{
			if (GoogleApi.cb_doBestEffortWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_ == null)
			{
				GoogleApi.cb_doBestEffortWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApi.n_DoBestEffortWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_));
			}
			return GoogleApi.cb_doBestEffortWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000C4FC File Offset: 0x0000A6FC
		private static IntPtr n_DoBestEffortWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_(IntPtr jnienv, IntPtr native__this, IntPtr native_methodImpl)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TaskApiCall object2 = Java.Lang.Object.GetObject<TaskApiCall>(native_methodImpl, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoBestEffortWrite(object2));
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000C524 File Offset: 0x0000A724
		[Register("doBestEffortWrite", "(Lcom/google/android/gms/common/api/internal/TaskApiCall;)Lcom/google/android/gms/tasks/Task;", "GetDoBestEffortWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TResult",
			"A extends com.google.android.gms.common.api.Api.AnyClient"
		})]
		public unsafe virtual Task DoBestEffortWrite(TaskApiCall methodImpl)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((methodImpl == null) ? IntPtr.Zero : methodImpl.Handle);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doBestEffortWrite.(Lcom/google/android/gms/common/api/internal/TaskApiCall;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(methodImpl);
			}
			return @object;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000C598 File Offset: 0x0000A798
		private static Delegate GetDoBestEffortWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler()
		{
			if (GoogleApi.cb_doBestEffortWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ == null)
			{
				GoogleApi.cb_doBestEffortWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApi.n_DoBestEffortWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_));
			}
			return GoogleApi.cb_doBestEffortWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		private static IntPtr n_DoBestEffortWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_methodImpl)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_methodImpl, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoBestEffortWrite(object2));
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		[Register("doBestEffortWrite", "(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", "GetDoBestEffortWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"T extends com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl<? extends com.google.android.gms.common.api.Result, A>"
		})]
		public unsafe virtual Java.Lang.Object DoBestEffortWrite(Java.Lang.Object methodImpl)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(methodImpl);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doBestEffortWrite.(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(methodImpl);
			}
			return @object;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000C658 File Offset: 0x0000A858
		private static Delegate GetDoRead_Lcom_google_android_gms_common_api_internal_TaskApiCall_Handler()
		{
			if (GoogleApi.cb_doRead_Lcom_google_android_gms_common_api_internal_TaskApiCall_ == null)
			{
				GoogleApi.cb_doRead_Lcom_google_android_gms_common_api_internal_TaskApiCall_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApi.n_DoRead_Lcom_google_android_gms_common_api_internal_TaskApiCall_));
			}
			return GoogleApi.cb_doRead_Lcom_google_android_gms_common_api_internal_TaskApiCall_;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000C67C File Offset: 0x0000A87C
		private static IntPtr n_DoRead_Lcom_google_android_gms_common_api_internal_TaskApiCall_(IntPtr jnienv, IntPtr native__this, IntPtr native_methodImpl)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TaskApiCall object2 = Java.Lang.Object.GetObject<TaskApiCall>(native_methodImpl, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoRead(object2));
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		[Register("doRead", "(Lcom/google/android/gms/common/api/internal/TaskApiCall;)Lcom/google/android/gms/tasks/Task;", "GetDoRead_Lcom_google_android_gms_common_api_internal_TaskApiCall_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TResult",
			"A extends com.google.android.gms.common.api.Api.AnyClient"
		})]
		public unsafe virtual Task DoRead(TaskApiCall methodImpl)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((methodImpl == null) ? IntPtr.Zero : methodImpl.Handle);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doRead.(Lcom/google/android/gms/common/api/internal/TaskApiCall;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(methodImpl);
			}
			return @object;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000C718 File Offset: 0x0000A918
		private static Delegate GetDoRead_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler()
		{
			if (GoogleApi.cb_doRead_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ == null)
			{
				GoogleApi.cb_doRead_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApi.n_DoRead_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_));
			}
			return GoogleApi.cb_doRead_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000C73C File Offset: 0x0000A93C
		private static IntPtr n_DoRead_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_methodImpl)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_methodImpl, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoRead(object2));
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000C764 File Offset: 0x0000A964
		[Register("doRead", "(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", "GetDoRead_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"T extends com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl<? extends com.google.android.gms.common.api.Result, A>"
		})]
		public unsafe virtual Java.Lang.Object DoRead(Java.Lang.Object methodImpl)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(methodImpl);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doRead.(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(methodImpl);
			}
			return @object;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
		private static Delegate GetDoRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegistrationMethods_Handler()
		{
			if (GoogleApi.cb_doRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegistrationMethods_ == null)
			{
				GoogleApi.cb_doRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegistrationMethods_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApi.n_DoRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegistrationMethods_));
			}
			return GoogleApi.cb_doRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegistrationMethods_;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000C7FC File Offset: 0x0000A9FC
		private static IntPtr n_DoRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegistrationMethods_(IntPtr jnienv, IntPtr native__this, IntPtr native_methods)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RegistrationMethods object2 = Java.Lang.Object.GetObject<RegistrationMethods>(native_methods, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoRegisterEventListener(object2));
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000C824 File Offset: 0x0000AA24
		[Register("doRegisterEventListener", "(Lcom/google/android/gms/common/api/internal/RegistrationMethods;)Lcom/google/android/gms/tasks/Task;", "GetDoRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegistrationMethods_Handler")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient"
		})]
		public unsafe virtual Task DoRegisterEventListener(RegistrationMethods methods)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((methods == null) ? IntPtr.Zero : methods.Handle);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doRegisterEventListener.(Lcom/google/android/gms/common/api/internal/RegistrationMethods;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(methods);
			}
			return @object;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000C898 File Offset: 0x0000AA98
		private static Delegate GetDoRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegisterListenerMethod_Lcom_google_android_gms_common_api_internal_UnregisterListenerMethod_Handler()
		{
			if (GoogleApi.cb_doRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegisterListenerMethod_Lcom_google_android_gms_common_api_internal_UnregisterListenerMethod_ == null)
			{
				GoogleApi.cb_doRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegisterListenerMethod_Lcom_google_android_gms_common_api_internal_UnregisterListenerMethod_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(GoogleApi.n_DoRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegisterListenerMethod_Lcom_google_android_gms_common_api_internal_UnregisterListenerMethod_));
			}
			return GoogleApi.cb_doRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegisterListenerMethod_Lcom_google_android_gms_common_api_internal_UnregisterListenerMethod_;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000C8BC File Offset: 0x0000AABC
		private static IntPtr n_DoRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegisterListenerMethod_Lcom_google_android_gms_common_api_internal_UnregisterListenerMethod_(IntPtr jnienv, IntPtr native__this, IntPtr native_registerMethod, IntPtr native_unregisterMethod)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_registerMethod, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_unregisterMethod, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoRegisterEventListener(object2, object3));
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		[Register("doRegisterEventListener", "(Lcom/google/android/gms/common/api/internal/RegisterListenerMethod;Lcom/google/android/gms/common/api/internal/UnregisterListenerMethod;)Lcom/google/android/gms/tasks/Task;", "GetDoRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegisterListenerMethod_Lcom_google_android_gms_common_api_internal_UnregisterListenerMethod_Handler")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"T extends com.google.android.gms.common.api.internal.RegisterListenerMethod<A, ?>",
			"U extends com.google.android.gms.common.api.internal.UnregisterListenerMethod<A, ?>"
		})]
		public unsafe virtual Task DoRegisterEventListener(Java.Lang.Object registerMethod, Java.Lang.Object unregisterMethod)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(registerMethod);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(unregisterMethod);
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doRegisterEventListener.(Lcom/google/android/gms/common/api/internal/RegisterListenerMethod;Lcom/google/android/gms/common/api/internal/UnregisterListenerMethod;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(registerMethod);
				GC.KeepAlive(unregisterMethod);
			}
			return @object;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000C98C File Offset: 0x0000AB8C
		private static Delegate GetDoUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_Handler()
		{
			if (GoogleApi.cb_doUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_ == null)
			{
				GoogleApi.cb_doUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApi.n_DoUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_));
			}
			return GoogleApi.cb_doUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		private static IntPtr n_DoUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_(IntPtr jnienv, IntPtr native__this, IntPtr native_listenerKey)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ListenerHolder.ListenerKey object2 = Java.Lang.Object.GetObject<ListenerHolder.ListenerKey>(native_listenerKey, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoUnregisterEventListener(object2));
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Register("doUnregisterEventListener", "(Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;)Lcom/google/android/gms/tasks/Task;", "GetDoUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_Handler")]
		public unsafe virtual Task DoUnregisterEventListener(ListenerHolder.ListenerKey listenerKey)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listenerKey == null) ? IntPtr.Zero : listenerKey.Handle);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doUnregisterEventListener.(Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(listenerKey);
			}
			return @object;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		private static Delegate GetDoUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_IHandler()
		{
			if (GoogleApi.cb_doUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_I == null)
			{
				GoogleApi.cb_doUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(GoogleApi.n_DoUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_I));
			}
			return GoogleApi.cb_doUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_I;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000CA70 File Offset: 0x0000AC70
		private static IntPtr n_DoUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_I(IntPtr jnienv, IntPtr native__this, IntPtr native_listenerKey, int methodKey)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ListenerHolder.ListenerKey object2 = Java.Lang.Object.GetObject<ListenerHolder.ListenerKey>(native_listenerKey, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoUnregisterEventListener(object2, methodKey));
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		[Register("doUnregisterEventListener", "(Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;I)Lcom/google/android/gms/tasks/Task;", "GetDoUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_IHandler")]
		public unsafe virtual Task DoUnregisterEventListener(ListenerHolder.ListenerKey listenerKey, int methodKey)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listenerKey == null) ? IntPtr.Zero : listenerKey.Handle);
				ptr[1] = new JniArgumentValue(methodKey);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doUnregisterEventListener.(Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;I)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(listenerKey);
			}
			return @object;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000CB24 File Offset: 0x0000AD24
		private static Delegate GetDoWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_Handler()
		{
			if (GoogleApi.cb_doWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_ == null)
			{
				GoogleApi.cb_doWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApi.n_DoWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_));
			}
			return GoogleApi.cb_doWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000CB48 File Offset: 0x0000AD48
		private static IntPtr n_DoWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_(IntPtr jnienv, IntPtr native__this, IntPtr native_methodImpl)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TaskApiCall object2 = Java.Lang.Object.GetObject<TaskApiCall>(native_methodImpl, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoWrite(object2));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Register("doWrite", "(Lcom/google/android/gms/common/api/internal/TaskApiCall;)Lcom/google/android/gms/tasks/Task;", "GetDoWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TResult",
			"A extends com.google.android.gms.common.api.Api.AnyClient"
		})]
		public unsafe virtual Task DoWrite(TaskApiCall methodImpl)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((methodImpl == null) ? IntPtr.Zero : methodImpl.Handle);
				@object = Java.Lang.Object.GetObject<Task>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doWrite.(Lcom/google/android/gms/common/api/internal/TaskApiCall;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(methodImpl);
			}
			return @object;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000CBE4 File Offset: 0x0000ADE4
		private static Delegate GetDoWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler()
		{
			if (GoogleApi.cb_doWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ == null)
			{
				GoogleApi.cb_doWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleApi.n_DoWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_));
			}
			return GoogleApi.cb_doWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000CC08 File Offset: 0x0000AE08
		private static IntPtr n_DoWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_methodImpl)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_methodImpl, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DoWrite(object2));
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[Register("doWrite", "(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", "GetDoWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_Handler")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"T extends com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl<? extends com.google.android.gms.common.api.Result, A>"
		})]
		public unsafe virtual Java.Lang.Object DoWrite(Java.Lang.Object methodImpl)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(methodImpl);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("doWrite.(Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;)Lcom/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(methodImpl);
			}
			return @object;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		private static Delegate GetRegisterListener_Ljava_lang_Object_Ljava_lang_String_Handler()
		{
			if (GoogleApi.cb_registerListener_Ljava_lang_Object_Ljava_lang_String_ == null)
			{
				GoogleApi.cb_registerListener_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(GoogleApi.n_RegisterListener_Ljava_lang_Object_Ljava_lang_String_));
			}
			return GoogleApi.cb_registerListener_Ljava_lang_Object_Ljava_lang_String_;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		private static IntPtr n_RegisterListener_Ljava_lang_Object_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener, IntPtr native_listenerType)
		{
			GoogleApi @object = Java.Lang.Object.GetObject<GoogleApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_listener, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_listenerType, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RegisterListener(object2, @string));
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		[Register("registerListener", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/google/android/gms/common/api/internal/ListenerHolder;", "GetRegisterListener_Ljava_lang_Object_Ljava_lang_String_Handler")]
		[JavaTypeParameters(new string[]
		{
			"L"
		})]
		public unsafe virtual ListenerHolder RegisterListener(Java.Lang.Object listener, string listenerType)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(listener);
			IntPtr intPtr2 = JNIEnv.NewString(listenerType);
			ListenerHolder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ListenerHolder>(GoogleApi._members.InstanceMethods.InvokeVirtualObjectMethod("registerListener.(Ljava/lang/Object;Ljava/lang/String;)Lcom/google/android/gms/common/api/internal/ListenerHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(listener);
			}
			return @object;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000CD90 File Offset: 0x0000AF90
		[Register("zaa", "()I", "")]
		public int Zaa()
		{
			return GoogleApi._members.InstanceMethods.InvokeNonvirtualInt32Method("zaa.()I", this, null);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000CDAC File Offset: 0x0000AFAC
		[Register("zab", "(Landroid/os/Looper;Lcom/google/android/gms/common/api/internal/zabq;)Lcom/google/android/gms/common/api/Api$Client;", "")]
		public unsafe Api.IClient Zab(Looper p0, Zabq p1)
		{
			Api.IClient @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<Api.IClient>(GoogleApi._members.InstanceMethods.InvokeNonvirtualObjectMethod("zab.(Landroid/os/Looper;Lcom/google/android/gms/common/api/internal/zabq;)Lcom/google/android/gms/common/api/Api$Client;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x040000ED RID: 237
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/GoogleApi", typeof(GoogleApi));

		// Token: 0x040000EE RID: 238
		private static Delegate cb_getApiOptions;

		// Token: 0x040000EF RID: 239
		private static Delegate cb_getApplicationContext;

		// Token: 0x040000F0 RID: 240
		private static Delegate cb_getContextAttributionTag;

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_getContextFeatureId;

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_getLooper;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_asGoogleApiClient;

		// Token: 0x040000F4 RID: 244
		private static Delegate cb_disconnectService;

		// Token: 0x040000F5 RID: 245
		private static Delegate cb_doBestEffortWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_;

		// Token: 0x040000F6 RID: 246
		private static Delegate cb_doBestEffortWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_doRead_Lcom_google_android_gms_common_api_internal_TaskApiCall_;

		// Token: 0x040000F8 RID: 248
		private static Delegate cb_doRead_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;

		// Token: 0x040000F9 RID: 249
		private static Delegate cb_doRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegistrationMethods_;

		// Token: 0x040000FA RID: 250
		private static Delegate cb_doRegisterEventListener_Lcom_google_android_gms_common_api_internal_RegisterListenerMethod_Lcom_google_android_gms_common_api_internal_UnregisterListenerMethod_;

		// Token: 0x040000FB RID: 251
		private static Delegate cb_doUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_;

		// Token: 0x040000FC RID: 252
		private static Delegate cb_doUnregisterEventListener_Lcom_google_android_gms_common_api_internal_ListenerHolder_ListenerKey_I;

		// Token: 0x040000FD RID: 253
		private static Delegate cb_doWrite_Lcom_google_android_gms_common_api_internal_TaskApiCall_;

		// Token: 0x040000FE RID: 254
		private static Delegate cb_doWrite_Lcom_google_android_gms_common_api_internal_BaseImplementation_ApiMethodImpl_;

		// Token: 0x040000FF RID: 255
		private static Delegate cb_registerListener_Ljava_lang_Object_Ljava_lang_String_;

		// Token: 0x0200005F RID: 95
		[Register("com/google/android/gms/common/api/GoogleApi$Settings", DoNotGenerateAcw = true)]
		public class Settings : Java.Lang.Object
		{
			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000CE64 File Offset: 0x0000B064
			[Register("DEFAULT_SETTINGS")]
			public static GoogleApi.Settings DefaultSettings
			{
				get
				{
					return Java.Lang.Object.GetObject<GoogleApi.Settings>(GoogleApi.Settings._members.StaticFields.GetObjectValue("DEFAULT_SETTINGS.Lcom/google/android/gms/common/api/GoogleApi$Settings;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000CE94 File Offset: 0x0000B094
			// (set) Token: 0x06000436 RID: 1078 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
			[Register("zaa")]
			public IStatusExceptionMapper Zaa
			{
				get
				{
					return Java.Lang.Object.GetObject<IStatusExceptionMapper>(GoogleApi.Settings._members.InstanceFields.GetObjectValue("zaa.Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						GoogleApi.Settings._members.InstanceFields.SetValue("zaa.Lcom/google/android/gms/common/api/internal/StatusExceptionMapper;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x0000CF10 File Offset: 0x0000B110
			// (set) Token: 0x06000438 RID: 1080 RVA: 0x0000CF40 File Offset: 0x0000B140
			[Register("zab")]
			public Looper Zab
			{
				get
				{
					return Java.Lang.Object.GetObject<Looper>(GoogleApi.Settings._members.InstanceFields.GetObjectValue("zab.Landroid/os/Looper;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						GoogleApi.Settings._members.InstanceFields.SetValue("zab.Landroid/os/Looper;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x0000CF8C File Offset: 0x0000B18C
			internal static IntPtr class_ref
			{
				get
				{
					return GoogleApi.Settings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000CFB0 File Offset: 0x0000B1B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GoogleApi.Settings._members;
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return GoogleApi.Settings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000CFDC File Offset: 0x0000B1DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GoogleApi.Settings._members.ManagedPeerType;
				}
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00003280 File Offset: 0x00001480
			protected Settings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000100 RID: 256
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/GoogleApi$Settings", typeof(GoogleApi.Settings));
		}
	}
}
