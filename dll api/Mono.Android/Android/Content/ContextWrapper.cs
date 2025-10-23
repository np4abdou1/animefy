using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000286 RID: 646
	[Register("android/content/ContextWrapper", DoNotGenerateAcw = true)]
	public class ContextWrapper : Context
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0003FC2B File Offset: 0x0003DE2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContextWrapper._members;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0003FC34 File Offset: 0x0003DE34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContextWrapper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0003FC58 File Offset: 0x0003DE58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContextWrapper._members.ManagedPeerType;
			}
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0003F803 File Offset: 0x0003DA03
		protected ContextWrapper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0003FC64 File Offset: 0x0003DE64
		private static Delegate GetGetContentResolverHandler()
		{
			if (ContextWrapper.cb_getContentResolver == null)
			{
				ContextWrapper.cb_getContentResolver = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ContextWrapper.n_GetContentResolver));
			}
			return ContextWrapper.cb_getContentResolver;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0003FC88 File Offset: 0x0003DE88
		private static IntPtr n_GetContentResolver(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentResolver);
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x0003FC9C File Offset: 0x0003DE9C
		public override ContentResolver ContentResolver
		{
			get
			{
				return Java.Lang.Object.GetObject<ContentResolver>(ContextWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("getContentResolver.()Landroid/content/ContentResolver;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0003FCCE File Offset: 0x0003DECE
		private static Delegate GetGetMainLooperHandler()
		{
			if (ContextWrapper.cb_getMainLooper == null)
			{
				ContextWrapper.cb_getMainLooper = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ContextWrapper.n_GetMainLooper));
			}
			return ContextWrapper.cb_getMainLooper;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0003FCF2 File Offset: 0x0003DEF2
		private static IntPtr n_GetMainLooper(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MainLooper);
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x0003FD08 File Offset: 0x0003DF08
		public override Looper MainLooper
		{
			get
			{
				return Java.Lang.Object.GetObject<Looper>(ContextWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("getMainLooper.()Landroid/os/Looper;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0003FD3A File Offset: 0x0003DF3A
		private static Delegate GetGetPackageManagerHandler()
		{
			if (ContextWrapper.cb_getPackageManager == null)
			{
				ContextWrapper.cb_getPackageManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ContextWrapper.n_GetPackageManager));
			}
			return ContextWrapper.cb_getPackageManager;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0003FD5E File Offset: 0x0003DF5E
		private static IntPtr n_GetPackageManager(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PackageManager);
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0003FD74 File Offset: 0x0003DF74
		public override PackageManager PackageManager
		{
			get
			{
				return Java.Lang.Object.GetObject<PackageManager>(ContextWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("getPackageManager.()Landroid/content/pm/PackageManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0003FDA6 File Offset: 0x0003DFA6
		private static Delegate GetGetResourcesHandler()
		{
			if (ContextWrapper.cb_getResources == null)
			{
				ContextWrapper.cb_getResources = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ContextWrapper.n_GetResources));
			}
			return ContextWrapper.cb_getResources;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0003FDCA File Offset: 0x0003DFCA
		private static IntPtr n_GetResources(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Resources);
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0003FDE0 File Offset: 0x0003DFE0
		public override Resources Resources
		{
			get
			{
				return Java.Lang.Object.GetObject<Resources>(ContextWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("getResources.()Landroid/content/res/Resources;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0003FE12 File Offset: 0x0003E012
		private static Delegate GetGetThemeHandler()
		{
			if (ContextWrapper.cb_getTheme == null)
			{
				ContextWrapper.cb_getTheme = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ContextWrapper.n_GetTheme));
			}
			return ContextWrapper.cb_getTheme;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0003FE36 File Offset: 0x0003E036
		private static IntPtr n_GetTheme(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Theme);
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x0003FE4C File Offset: 0x0003E04C
		public override Resources.Theme Theme
		{
			get
			{
				return Java.Lang.Object.GetObject<Resources.Theme>(ContextWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("getTheme.()Landroid/content/res/Resources$Theme;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0003FE7E File Offset: 0x0003E07E
		private static Delegate GetAttachBaseContext_Landroid_content_Context_Handler()
		{
			if (ContextWrapper.cb_attachBaseContext_Landroid_content_Context_ == null)
			{
				ContextWrapper.cb_attachBaseContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ContextWrapper.n_AttachBaseContext_Landroid_content_Context_));
			}
			return ContextWrapper.cb_attachBaseContext_Landroid_content_Context_;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0003FEA4 File Offset: 0x0003E0A4
		private static void n_AttachBaseContext_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native__base)
		{
			ContextWrapper @object = Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native__base, JniHandleOwnership.DoNotTransfer);
			@object.AttachBaseContext(object2);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0003FEC8 File Offset: 0x0003E0C8
		protected unsafe virtual void AttachBaseContext(Context @base)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@base == null) ? IntPtr.Zero : @base.Handle);
				ContextWrapper._members.InstanceMethods.InvokeVirtualVoidMethod("attachBaseContext.(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@base);
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0003FF2C File Offset: 0x0003E12C
		private static Delegate GetCheckSelfPermission_Ljava_lang_String_Handler()
		{
			if (ContextWrapper.cb_checkSelfPermission_Ljava_lang_String_ == null)
			{
				ContextWrapper.cb_checkSelfPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ContextWrapper.n_CheckSelfPermission_Ljava_lang_String_));
			}
			return ContextWrapper.cb_checkSelfPermission_Ljava_lang_String_;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0003FF50 File Offset: 0x0003E150
		private static int n_CheckSelfPermission_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			Context @object = Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_permission, JniHandleOwnership.DoNotTransfer);
			return (int)@object.CheckSelfPermission(@string);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0003FF74 File Offset: 0x0003E174
		[return: GeneratedEnum]
		public unsafe override Permission CheckSelfPermission(string permission)
		{
			IntPtr intPtr = JNIEnv.NewString(permission);
			Permission result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (Permission)ContextWrapper._members.InstanceMethods.InvokeVirtualInt32Method("checkSelfPermission.(Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		private static Delegate GetCreateConfigurationContext_Landroid_content_res_Configuration_Handler()
		{
			if (ContextWrapper.cb_createConfigurationContext_Landroid_content_res_Configuration_ == null)
			{
				ContextWrapper.cb_createConfigurationContext_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ContextWrapper.n_CreateConfigurationContext_Landroid_content_res_Configuration_));
			}
			return ContextWrapper.cb_createConfigurationContext_Landroid_content_res_Configuration_;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0003FFF8 File Offset: 0x0003E1F8
		private static IntPtr n_CreateConfigurationContext_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_overrideConfiguration)
		{
			Context @object = Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_overrideConfiguration, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateConfigurationContext(object2));
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00040020 File Offset: 0x0003E220
		public unsafe override Context CreateConfigurationContext(Configuration overrideConfiguration)
		{
			Context @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((overrideConfiguration == null) ? IntPtr.Zero : overrideConfiguration.Handle);
				@object = Java.Lang.Object.GetObject<Context>(ContextWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("createConfigurationContext.(Landroid/content/res/Configuration;)Landroid/content/Context;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(overrideConfiguration);
			}
			return @object;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00040094 File Offset: 0x0003E294
		private static Delegate GetGetSharedPreferences_Ljava_lang_String_IHandler()
		{
			if (ContextWrapper.cb_getSharedPreferences_Ljava_lang_String_I == null)
			{
				ContextWrapper.cb_getSharedPreferences_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(ContextWrapper.n_GetSharedPreferences_Ljava_lang_String_I));
			}
			return ContextWrapper.cb_getSharedPreferences_Ljava_lang_String_I;
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000400B8 File Offset: 0x0003E2B8
		private static IntPtr n_GetSharedPreferences_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_name, int native_mode)
		{
			Context @object = Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetSharedPreferences(@string, (FileCreationMode)native_mode));
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000400E4 File Offset: 0x0003E2E4
		public unsafe override ISharedPreferences GetSharedPreferences(string name, [GeneratedEnum] FileCreationMode mode)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ISharedPreferences @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((int)mode);
				@object = Java.Lang.Object.GetObject<ISharedPreferences>(ContextWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("getSharedPreferences.(Ljava/lang/String;I)Landroid/content/SharedPreferences;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00040164 File Offset: 0x0003E364
		private static Delegate GetGetSystemService_Ljava_lang_String_Handler()
		{
			if (ContextWrapper.cb_getSystemService_Ljava_lang_String_ == null)
			{
				ContextWrapper.cb_getSystemService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ContextWrapper.n_GetSystemService_Ljava_lang_String_));
			}
			return ContextWrapper.cb_getSystemService_Ljava_lang_String_;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00040188 File Offset: 0x0003E388
		private static IntPtr n_GetSystemService_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			Context @object = Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetSystemService(@string));
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000401B0 File Offset: 0x0003E3B0
		public unsafe override Java.Lang.Object GetSystemService([StringDef(Type = "Android.Content.Context", Fields = new string[]
		{
			"PowerService",
			"WindowService",
			"LayoutInflaterService",
			"AccountService",
			"ActivityService",
			"AlarmService",
			"NotificationService",
			"AccessibilityService",
			"CaptioningService",
			"KeyguardService",
			"LocationService",
			"SearchService",
			"SensorService",
			"StorageService",
			"StorageStatsService",
			"WallpaperService",
			"VibratorManagerService",
			"VibratorService",
			"ConnectivityService",
			"IpsecService",
			"VpnManagementService",
			"NetworkStatsService",
			"WifiService",
			"WifiAwareService",
			"WifiP2pService",
			"WifiRttRangingService",
			"NsdService",
			"AudioService",
			"FingerprintService",
			"BiometricService",
			"MediaRouterService",
			"TelephonyService",
			"TelephonySubscriptionService",
			"CarrierConfigService",
			"EuiccService",
			"TelecomService",
			"ClipboardService",
			"InputMethodService",
			"TextServicesManagerService",
			"TextClassificationService",
			"AppwidgetService",
			"DropboxService",
			"DevicePolicyService",
			"UiModeService",
			"DownloadService",
			"NfcService",
			"BluetoothService",
			"UsbService",
			"LauncherAppsService",
			"InputService",
			"DisplayService",
			"UserService",
			"RestrictionsService",
			"AppOpsService",
			"RoleService",
			"CameraService",
			"PrintService",
			"ConsumerIrService",
			"TvInteractiveAppService",
			"TvInputService",
			"UsageStatsService",
			"MediaSessionService",
			"MediaCommunicationService",
			"BatteryService",
			"JobSchedulerService",
			"MediaProjectionService",
			"MidiService",
			"HardwarePropertiesService",
			"ShortcutService",
			"SystemHealthService",
			"CompanionDeviceService",
			"CrossProfileAppsService",
			"LocaleService",
			"MediaMetricsService",
			"DisplayHashService"
		})] [StringDef(Type = "Android.Content.Context", Fields = new string[]
		{
			"PowerService",
			"WindowService",
			"LayoutInflaterService",
			"AccountService",
			"ActivityService",
			"AlarmService",
			"NotificationService",
			"AccessibilityService",
			"CaptioningService",
			"KeyguardService",
			"LocationService",
			"SearchService",
			"SensorService",
			"StorageService",
			"StorageStatsService",
			"WallpaperService",
			"VibratorManagerService",
			"VibratorService",
			"ConnectivityService",
			"IpsecService",
			"VpnManagementService",
			"NetworkStatsService",
			"WifiService",
			"WifiAwareService",
			"WifiP2pService",
			"WifiRttRangingService",
			"NsdService",
			"AudioService",
			"FingerprintService",
			"BiometricService",
			"MediaRouterService",
			"TelephonyService",
			"TelephonySubscriptionService",
			"CarrierConfigService",
			"EuiccService",
			"TelecomService",
			"ClipboardService",
			"InputMethodService",
			"TextServicesManagerService",
			"TextClassificationService",
			"AppwidgetService",
			"DropboxService",
			"DevicePolicyService",
			"UiModeService",
			"DownloadService",
			"NfcService",
			"BluetoothService",
			"UsbService",
			"LauncherAppsService",
			"InputService",
			"DisplayService",
			"UserService",
			"RestrictionsService",
			"AppOpsService",
			"RoleService",
			"CameraService",
			"PrintService",
			"ConsumerIrService",
			"TvInteractiveAppService",
			"TvInputService",
			"UsageStatsService",
			"MediaSessionService",
			"MediaCommunicationService",
			"BatteryService",
			"JobSchedulerService",
			"MediaProjectionService",
			"MidiService",
			"HardwarePropertiesService",
			"ShortcutService",
			"SystemHealthService",
			"CompanionDeviceService",
			"CrossProfileAppsService",
			"LocaleService",
			"MediaMetricsService",
			"DisplayHashService"
		})] string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ContextWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("getSystemService.(Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0004021C File Offset: 0x0003E41C
		private static Delegate GetSetTheme_IHandler()
		{
			if (ContextWrapper.cb_setTheme_I == null)
			{
				ContextWrapper.cb_setTheme_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ContextWrapper.n_SetTheme_I));
			}
			return ContextWrapper.cb_setTheme_I;
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00040240 File Offset: 0x0003E440
		private static void n_SetTheme_I(IntPtr jnienv, IntPtr native__this, int resid)
		{
			Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTheme(resid);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00040250 File Offset: 0x0003E450
		public unsafe override void SetTheme(int resid)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resid);
			ContextWrapper._members.InstanceMethods.InvokeVirtualVoidMethod("setTheme.(I)V", this, ptr);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0004028B File Offset: 0x0003E48B
		private static Delegate GetStartActivity_Landroid_content_Intent_Handler()
		{
			if (ContextWrapper.cb_startActivity_Landroid_content_Intent_ == null)
			{
				ContextWrapper.cb_startActivity_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ContextWrapper.n_StartActivity_Landroid_content_Intent_));
			}
			return ContextWrapper.cb_startActivity_Landroid_content_Intent_;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000402B0 File Offset: 0x0003E4B0
		private static void n_StartActivity_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			Context @object = Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.StartActivity(object2);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000402D4 File Offset: 0x0003E4D4
		public unsafe override void StartActivity(Intent intent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ContextWrapper._members.InstanceMethods.InvokeVirtualVoidMethod("startActivity.(Landroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00040338 File Offset: 0x0003E538
		private static Delegate GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler()
		{
			if (ContextWrapper.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ == null)
			{
				ContextWrapper.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ContextWrapper.n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_));
			}
			return ContextWrapper.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0004035C File Offset: 0x0003E55C
		private static void n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_options)
		{
			Context @object = Java.Lang.Object.GetObject<ContextWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.StartActivity(object2, object3);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00040388 File Offset: 0x0003E588
		public unsafe override void StartActivity(Intent intent, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ContextWrapper._members.InstanceMethods.InvokeVirtualVoidMethod("startActivity.(Landroid/content/Intent;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x04000A65 RID: 2661
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ContextWrapper", typeof(ContextWrapper));

		// Token: 0x04000A66 RID: 2662
		private static Delegate cb_getContentResolver;

		// Token: 0x04000A67 RID: 2663
		private static Delegate cb_getMainLooper;

		// Token: 0x04000A68 RID: 2664
		private static Delegate cb_getPackageManager;

		// Token: 0x04000A69 RID: 2665
		private static Delegate cb_getResources;

		// Token: 0x04000A6A RID: 2666
		private static Delegate cb_getTheme;

		// Token: 0x04000A6B RID: 2667
		private static Delegate cb_attachBaseContext_Landroid_content_Context_;

		// Token: 0x04000A6C RID: 2668
		private static Delegate cb_checkSelfPermission_Ljava_lang_String_;

		// Token: 0x04000A6D RID: 2669
		private static Delegate cb_createConfigurationContext_Landroid_content_res_Configuration_;

		// Token: 0x04000A6E RID: 2670
		private static Delegate cb_getSharedPreferences_Ljava_lang_String_I;

		// Token: 0x04000A6F RID: 2671
		private static Delegate cb_getSystemService_Ljava_lang_String_;

		// Token: 0x04000A70 RID: 2672
		private static Delegate cb_setTheme_I;

		// Token: 0x04000A71 RID: 2673
		private static Delegate cb_startActivity_Landroid_content_Intent_;

		// Token: 0x04000A72 RID: 2674
		private static Delegate cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
	}
}
