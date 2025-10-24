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
	// Token: 0x02000285 RID: 645
	[Register("android/content/Context", DoNotGenerateAcw = true)]
	internal class ContextInvoker : Context
	{
		// Token: 0x0600189A RID: 6298 RVA: 0x0003F803 File Offset: 0x0003DA03
		public ContextInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x0003F80D File Offset: 0x0003DA0D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContextInvoker._members;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0003F814 File Offset: 0x0003DA14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContextInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x0003F820 File Offset: 0x0003DA20
		public override ContentResolver ContentResolver
		{
			get
			{
				return Java.Lang.Object.GetObject<ContentResolver>(ContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getContentResolver.()Landroid/content/ContentResolver;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x0003F854 File Offset: 0x0003DA54
		public override Looper MainLooper
		{
			get
			{
				return Java.Lang.Object.GetObject<Looper>(ContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getMainLooper.()Landroid/os/Looper;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x0003F888 File Offset: 0x0003DA88
		public override PackageManager PackageManager
		{
			get
			{
				return Java.Lang.Object.GetObject<PackageManager>(ContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getPackageManager.()Landroid/content/pm/PackageManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x0003F8BC File Offset: 0x0003DABC
		public override Resources Resources
		{
			get
			{
				return Java.Lang.Object.GetObject<Resources>(ContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getResources.()Landroid/content/res/Resources;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0003F8F0 File Offset: 0x0003DAF0
		public override Resources.Theme Theme
		{
			get
			{
				return Java.Lang.Object.GetObject<Resources.Theme>(ContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTheme.()Landroid/content/res/Resources$Theme;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0003F924 File Offset: 0x0003DB24
		[return: GeneratedEnum]
		public unsafe override Permission CheckSelfPermission(string permission)
		{
			IntPtr intPtr = JNIEnv.NewString(permission);
			Permission result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (Permission)ContextInvoker._members.InstanceMethods.InvokeAbstractInt32Method("checkSelfPermission.(Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0003F984 File Offset: 0x0003DB84
		public unsafe override Context CreateConfigurationContext(Configuration overrideConfiguration)
		{
			Context @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((overrideConfiguration == null) ? IntPtr.Zero : overrideConfiguration.Handle);
				@object = Java.Lang.Object.GetObject<Context>(ContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("createConfigurationContext.(Landroid/content/res/Configuration;)Landroid/content/Context;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(overrideConfiguration);
			}
			return @object;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0003F9F8 File Offset: 0x0003DBF8
		public unsafe override ISharedPreferences GetSharedPreferences(string name, [GeneratedEnum] FileCreationMode mode)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ISharedPreferences @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((int)mode);
				@object = Java.Lang.Object.GetObject<ISharedPreferences>(ContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSharedPreferences.(Ljava/lang/String;I)Landroid/content/SharedPreferences;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0003FA78 File Offset: 0x0003DC78
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
		})] string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSystemService.(Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0003FAE4 File Offset: 0x0003DCE4
		public unsafe override void SetTheme(int resid)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resid);
			ContextInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setTheme.(I)V", this, ptr);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0003FB20 File Offset: 0x0003DD20
		public unsafe override void StartActivity(Intent intent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ContextInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("startActivity.(Landroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0003FB84 File Offset: 0x0003DD84
		public unsafe override void StartActivity(Intent intent, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ContextInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("startActivity.(Landroid/content/Intent;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x04000A64 RID: 2660
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/Context", typeof(ContextInvoker));
	}
}
