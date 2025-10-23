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
	// Token: 0x02000284 RID: 644
	[Register("android/content/Context", DoNotGenerateAcw = true)]
	public abstract class Context : Java.Lang.Object
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x0003F433 File Offset: 0x0003D633
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Context._members;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0003F43C File Offset: 0x0003D63C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Context._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0003F460 File Offset: 0x0003D660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Context._members.ManagedPeerType;
			}
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Context(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0003F46C File Offset: 0x0003D66C
		private static Delegate GetGetContentResolverHandler()
		{
			if (Context.cb_getContentResolver == null)
			{
				Context.cb_getContentResolver = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Context.n_GetContentResolver));
			}
			return Context.cb_getContentResolver;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0003F490 File Offset: 0x0003D690
		private static IntPtr n_GetContentResolver(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentResolver);
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001875 RID: 6261
		public abstract ContentResolver ContentResolver { get; }

		// Token: 0x06001876 RID: 6262 RVA: 0x0003F4A4 File Offset: 0x0003D6A4
		private static Delegate GetGetMainLooperHandler()
		{
			if (Context.cb_getMainLooper == null)
			{
				Context.cb_getMainLooper = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Context.n_GetMainLooper));
			}
			return Context.cb_getMainLooper;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0003F4C8 File Offset: 0x0003D6C8
		private static IntPtr n_GetMainLooper(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MainLooper);
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001878 RID: 6264
		public abstract Looper MainLooper { get; }

		// Token: 0x06001879 RID: 6265 RVA: 0x0003F4DC File Offset: 0x0003D6DC
		private static Delegate GetGetPackageManagerHandler()
		{
			if (Context.cb_getPackageManager == null)
			{
				Context.cb_getPackageManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Context.n_GetPackageManager));
			}
			return Context.cb_getPackageManager;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0003F500 File Offset: 0x0003D700
		private static IntPtr n_GetPackageManager(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PackageManager);
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600187B RID: 6267
		public abstract PackageManager PackageManager { get; }

		// Token: 0x0600187C RID: 6268 RVA: 0x0003F514 File Offset: 0x0003D714
		private static Delegate GetGetResourcesHandler()
		{
			if (Context.cb_getResources == null)
			{
				Context.cb_getResources = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Context.n_GetResources));
			}
			return Context.cb_getResources;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0003F538 File Offset: 0x0003D738
		private static IntPtr n_GetResources(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Resources);
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600187E RID: 6270
		public abstract Resources Resources { get; }

		// Token: 0x0600187F RID: 6271 RVA: 0x0003F54C File Offset: 0x0003D74C
		private static Delegate GetGetThemeHandler()
		{
			if (Context.cb_getTheme == null)
			{
				Context.cb_getTheme = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Context.n_GetTheme));
			}
			return Context.cb_getTheme;
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0003F570 File Offset: 0x0003D770
		private static IntPtr n_GetTheme(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Theme);
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001881 RID: 6273
		public abstract Resources.Theme Theme { get; }

		// Token: 0x06001882 RID: 6274 RVA: 0x0003F584 File Offset: 0x0003D784
		private static Delegate GetCheckSelfPermission_Ljava_lang_String_Handler()
		{
			if (Context.cb_checkSelfPermission_Ljava_lang_String_ == null)
			{
				Context.cb_checkSelfPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(Context.n_CheckSelfPermission_Ljava_lang_String_));
			}
			return Context.cb_checkSelfPermission_Ljava_lang_String_;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0003F5A8 File Offset: 0x0003D7A8
		private static int n_CheckSelfPermission_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			Context @object = Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_permission, JniHandleOwnership.DoNotTransfer);
			return (int)@object.CheckSelfPermission(@string);
		}

		// Token: 0x06001884 RID: 6276
		public abstract Permission CheckSelfPermission(string permission);

		// Token: 0x06001885 RID: 6277 RVA: 0x0003F5CB File Offset: 0x0003D7CB
		private static Delegate GetCreateConfigurationContext_Landroid_content_res_Configuration_Handler()
		{
			if (Context.cb_createConfigurationContext_Landroid_content_res_Configuration_ == null)
			{
				Context.cb_createConfigurationContext_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Context.n_CreateConfigurationContext_Landroid_content_res_Configuration_));
			}
			return Context.cb_createConfigurationContext_Landroid_content_res_Configuration_;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0003F5F0 File Offset: 0x0003D7F0
		private static IntPtr n_CreateConfigurationContext_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_overrideConfiguration)
		{
			Context @object = Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_overrideConfiguration, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateConfigurationContext(object2));
		}

		// Token: 0x06001887 RID: 6279
		public abstract Context CreateConfigurationContext(Configuration overrideConfiguration);

		// Token: 0x06001888 RID: 6280 RVA: 0x0003F618 File Offset: 0x0003D818
		private static Delegate GetGetSharedPreferences_Ljava_lang_String_IHandler()
		{
			if (Context.cb_getSharedPreferences_Ljava_lang_String_I == null)
			{
				Context.cb_getSharedPreferences_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(Context.n_GetSharedPreferences_Ljava_lang_String_I));
			}
			return Context.cb_getSharedPreferences_Ljava_lang_String_I;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0003F63C File Offset: 0x0003D83C
		private static IntPtr n_GetSharedPreferences_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_name, int native_mode)
		{
			Context @object = Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetSharedPreferences(@string, (FileCreationMode)native_mode));
		}

		// Token: 0x0600188A RID: 6282
		public abstract ISharedPreferences GetSharedPreferences(string name, [GeneratedEnum] FileCreationMode mode);

		// Token: 0x0600188B RID: 6283 RVA: 0x0003F668 File Offset: 0x0003D868
		public unsafe string GetString(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			return JNIEnv.GetString(Context._members.InstanceMethods.InvokeNonvirtualObjectMethod("getString.(I)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0003F6B1 File Offset: 0x0003D8B1
		private static Delegate GetGetSystemService_Ljava_lang_String_Handler()
		{
			if (Context.cb_getSystemService_Ljava_lang_String_ == null)
			{
				Context.cb_getSystemService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Context.n_GetSystemService_Ljava_lang_String_));
			}
			return Context.cb_getSystemService_Ljava_lang_String_;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0003F6D8 File Offset: 0x0003D8D8
		private static IntPtr n_GetSystemService_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			Context @object = Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetSystemService(@string));
		}

		// Token: 0x0600188E RID: 6286
		public abstract Java.Lang.Object GetSystemService([StringDef(Type = "Android.Content.Context", Fields = new string[]
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
		})] string name);

		// Token: 0x0600188F RID: 6287 RVA: 0x0003F700 File Offset: 0x0003D900
		private static Delegate GetSetTheme_IHandler()
		{
			if (Context.cb_setTheme_I == null)
			{
				Context.cb_setTheme_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Context.n_SetTheme_I));
			}
			return Context.cb_setTheme_I;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0003F724 File Offset: 0x0003D924
		private static void n_SetTheme_I(IntPtr jnienv, IntPtr native__this, int resid)
		{
			Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTheme(resid);
		}

		// Token: 0x06001891 RID: 6289
		public abstract void SetTheme(int resid);

		// Token: 0x06001892 RID: 6290 RVA: 0x0003F734 File Offset: 0x0003D934
		private static Delegate GetStartActivity_Landroid_content_Intent_Handler()
		{
			if (Context.cb_startActivity_Landroid_content_Intent_ == null)
			{
				Context.cb_startActivity_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Context.n_StartActivity_Landroid_content_Intent_));
			}
			return Context.cb_startActivity_Landroid_content_Intent_;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0003F758 File Offset: 0x0003D958
		private static void n_StartActivity_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			Context @object = Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.StartActivity(object2);
		}

		// Token: 0x06001894 RID: 6292
		public abstract void StartActivity(Intent intent);

		// Token: 0x06001895 RID: 6293 RVA: 0x0003F77B File Offset: 0x0003D97B
		private static Delegate GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler()
		{
			if (Context.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ == null)
			{
				Context.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Context.n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_));
			}
			return Context.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0003F7A0 File Offset: 0x0003D9A0
		private static void n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_options)
		{
			Context @object = Java.Lang.Object.GetObject<Context>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.StartActivity(object2, object3);
		}

		// Token: 0x06001897 RID: 6295
		public abstract void StartActivity(Intent intent, Bundle options);

		// Token: 0x06001898 RID: 6296 RVA: 0x0003F7CC File Offset: 0x0003D9CC
		public void StartActivity(Type type)
		{
			Intent intent = new Intent(this, type);
			this.StartActivity(intent);
		}

		// Token: 0x04000A57 RID: 2647
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/Context", typeof(Context));

		// Token: 0x04000A58 RID: 2648
		private static Delegate cb_getContentResolver;

		// Token: 0x04000A59 RID: 2649
		private static Delegate cb_getMainLooper;

		// Token: 0x04000A5A RID: 2650
		private static Delegate cb_getPackageManager;

		// Token: 0x04000A5B RID: 2651
		private static Delegate cb_getResources;

		// Token: 0x04000A5C RID: 2652
		private static Delegate cb_getTheme;

		// Token: 0x04000A5D RID: 2653
		private static Delegate cb_checkSelfPermission_Ljava_lang_String_;

		// Token: 0x04000A5E RID: 2654
		private static Delegate cb_createConfigurationContext_Landroid_content_res_Configuration_;

		// Token: 0x04000A5F RID: 2655
		private static Delegate cb_getSharedPreferences_Ljava_lang_String_I;

		// Token: 0x04000A60 RID: 2656
		private static Delegate cb_getSystemService_Ljava_lang_String_;

		// Token: 0x04000A61 RID: 2657
		private static Delegate cb_setTheme_I;

		// Token: 0x04000A62 RID: 2658
		private static Delegate cb_startActivity_Landroid_content_Intent_;

		// Token: 0x04000A63 RID: 2659
		private static Delegate cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
	}
}
