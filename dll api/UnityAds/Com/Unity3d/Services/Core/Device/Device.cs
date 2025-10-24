using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.PM;
using Android.Hardware;
using Android.Media;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x0200011A RID: 282
	[Register("com/unity3d/services/core/device/Device", DoNotGenerateAcw = true)]
	public class Device : Java.Lang.Object
	{
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0001F11C File Offset: 0x0001D31C
		internal static IntPtr class_ref
		{
			get
			{
				return Device._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0001F140 File Offset: 0x0001D340
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Device._members;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0001F148 File Offset: 0x0001D348
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Device._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0001F16C File Offset: 0x0001D36C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Device._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Device(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0001F178 File Offset: 0x0001D378
		[Register(".ctor", "()V", "")]
		public Device() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Device._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Device._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0001F1E8 File Offset: 0x0001D3E8
		public static string AdvertisingTrackingId
		{
			[Register("getAdvertisingTrackingId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getAdvertisingTrackingId.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0001F219 File Offset: 0x0001D419
		public static int ApiLevel
		{
			[Register("getApiLevel", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getApiLevel.()I", null);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0001F234 File Offset: 0x0001D434
		public static string ApkDigest
		{
			[Register("getApkDigest", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getApkDigest.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0001F265 File Offset: 0x0001D465
		public static float BatteryLevel
		{
			[Register("getBatteryLevel", "()F", "")]
			get
			{
				return Device._members.StaticMethods.InvokeSingleMethod("getBatteryLevel.()F", null);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0001F27D File Offset: 0x0001D47D
		public static int BatteryStatus
		{
			[Register("getBatteryStatus", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getBatteryStatus.()I", null);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0001F298 File Offset: 0x0001D498
		public static string Board
		{
			[Register("getBoard", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getBoard.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0001F2CC File Offset: 0x0001D4CC
		public static string Bootloader
		{
			[Register("getBootloader", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getBootloader.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0001F300 File Offset: 0x0001D500
		public static string Brand
		{
			[Register("getBrand", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getBrand.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0001F334 File Offset: 0x0001D534
		public static string BuildId
		{
			[Register("getBuildId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getBuildId.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0001F368 File Offset: 0x0001D568
		public static string BuildVersionIncremental
		{
			[Register("getBuildVersionIncremental", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getBuildVersionIncremental.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0001F399 File Offset: 0x0001D599
		public static long CPUCount
		{
			[Register("getCPUCount", "()J", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt64Method("getCPUCount.()J", null);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0001F3B4 File Offset: 0x0001D5B4
		public static string CertificateFingerprint
		{
			[Register("getCertificateFingerprint", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getCertificateFingerprint.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0001F3E8 File Offset: 0x0001D5E8
		public static string ConnectionType
		{
			[Register("getConnectionType", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getConnectionType.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0001F419 File Offset: 0x0001D619
		public static float DisplayMetricDensity
		{
			[Register("getDisplayMetricDensity", "()F", "")]
			get
			{
				return Device._members.StaticMethods.InvokeSingleMethod("getDisplayMetricDensity.()F", null);
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0001F431 File Offset: 0x0001D631
		public static long ElapsedRealtime
		{
			[Register("getElapsedRealtime", "()J", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt64Method("getElapsedRealtime.()J", null);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0001F44C File Offset: 0x0001D64C
		public static string Fingerprint
		{
			[Register("getFingerprint", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getFingerprint.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0001F47D File Offset: 0x0001D67D
		public static long FreeMemory
		{
			[Register("getFreeMemory", "()J", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt64Method("getFreeMemory.()J", null);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0001F498 File Offset: 0x0001D698
		public static string GLVersion
		{
			[Register("getGLVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getGLVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0001F4CC File Offset: 0x0001D6CC
		public static string Hardware
		{
			[Register("getHardware", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getHardware.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0001F4FD File Offset: 0x0001D6FD
		public static bool HasX264Decoder
		{
			[Register("hasX264Decoder", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("hasX264Decoder.()Z", null);
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0001F515 File Offset: 0x0001D715
		public static bool HasX265Decoder
		{
			[Register("hasX265Decoder", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("hasX265Decoder.()Z", null);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0001F530 File Offset: 0x0001D730
		public static string Host
		{
			[Register("getHost", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getHost.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0001F564 File Offset: 0x0001D764
		public static string Idfi
		{
			[Register("getIdfi", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getIdfi.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0001F595 File Offset: 0x0001D795
		public static bool IsActiveNetworkConnected
		{
			[Register("isActiveNetworkConnected", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("isActiveNetworkConnected.()Z", null);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0001F5AD File Offset: 0x0001D7AD
		public static bool IsLimitAdTrackingEnabled
		{
			[Register("isLimitAdTrackingEnabled", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("isLimitAdTrackingEnabled.()Z", null);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0001F5C5 File Offset: 0x0001D7C5
		public static bool IsLimitOpenAdTrackingEnabled
		{
			[Register("isLimitOpenAdTrackingEnabled", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("isLimitOpenAdTrackingEnabled.()Z", null);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0001F5DD File Offset: 0x0001D7DD
		public static bool IsRooted
		{
			[Register("isRooted", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("isRooted.()Z", null);
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0001F5F5 File Offset: 0x0001D7F5
		public static bool IsUSBConnected
		{
			[Register("isUSBConnected", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("isUSBConnected.()Z", null);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0001F60D File Offset: 0x0001D80D
		public static bool IsUsingWifi
		{
			[Register("isUsingWifi", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("isUsingWifi.()Z", null);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0001F625 File Offset: 0x0001D825
		public static bool IsWiredHeadsetOn
		{
			[Register("isWiredHeadsetOn", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("isWiredHeadsetOn.()Z", null);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0001F640 File Offset: 0x0001D840
		public static string Manufacturer
		{
			[Register("getManufacturer", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getManufacturer.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0001F674 File Offset: 0x0001D874
		public static string Model
		{
			[Register("getModel", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getModel.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0001F6A8 File Offset: 0x0001D8A8
		public static string NetworkCountryISO
		{
			[Register("getNetworkCountryISO", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getNetworkCountryISO.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0001F6D9 File Offset: 0x0001D8D9
		public static bool NetworkMetered
		{
			[Register("getNetworkMetered", "()Z", "")]
			get
			{
				return Device._members.StaticMethods.InvokeBooleanMethod("getNetworkMetered.()Z", null);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0001F6F4 File Offset: 0x0001D8F4
		public static string NetworkOperator
		{
			[Register("getNetworkOperator", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getNetworkOperator.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0001F728 File Offset: 0x0001D928
		public static string NetworkOperatorName
		{
			[Register("getNetworkOperatorName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getNetworkOperatorName.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0001F759 File Offset: 0x0001D959
		public static int NetworkType
		{
			[Register("getNetworkType", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getNetworkType.()I", null);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0001F774 File Offset: 0x0001D974
		public static string OpenAdvertisingTrackingId
		{
			[Register("getOpenAdvertisingTrackingId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getOpenAdvertisingTrackingId.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
		public static string OsVersion
		{
			[Register("getOsVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getOsVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0001F7DC File Offset: 0x0001D9DC
		public static IDictionary<string, string> ProcessInfo
		{
			[Register("getProcessInfo", "()Ljava/util/Map;", "")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(Device._members.StaticMethods.InvokeObjectMethod("getProcessInfo.()Ljava/util/Map;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0001F810 File Offset: 0x0001DA10
		public static string Product
		{
			[Register("getProduct", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getProduct.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0001F841 File Offset: 0x0001DA41
		public static int RingerMode
		{
			[Register("getRingerMode", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getRingerMode.()I", null);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0001F859 File Offset: 0x0001DA59
		public static int ScreenBrightness
		{
			[Register("getScreenBrightness", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getScreenBrightness.()I", null);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0001F871 File Offset: 0x0001DA71
		public static int ScreenDensity
		{
			[Register("getScreenDensity", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getScreenDensity.()I", null);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0001F889 File Offset: 0x0001DA89
		public static int ScreenHeight
		{
			[Register("getScreenHeight", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getScreenHeight.()I", null);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0001F8A1 File Offset: 0x0001DAA1
		public static int ScreenLayout
		{
			[Register("getScreenLayout", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getScreenLayout.()I", null);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0001F8B9 File Offset: 0x0001DAB9
		public static int ScreenWidth
		{
			[Register("getScreenWidth", "()I", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt32Method("getScreenWidth.()I", null);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
		public static IList<Sensor> SensorList
		{
			[Register("getSensorList", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<Sensor>.FromJniHandle(Device._members.StaticMethods.InvokeObjectMethod("getSensorList.()Ljava/util/List;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0001F908 File Offset: 0x0001DB08
		public static IList<string> SupportedAbis
		{
			[Register("getSupportedAbis", "()Ljava/util/ArrayList;", "")]
			get
			{
				return JavaList<string>.FromJniHandle(Device._members.StaticMethods.InvokeObjectMethod("getSupportedAbis.()Ljava/util/ArrayList;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0001F939 File Offset: 0x0001DB39
		public static long TotalMemory
		{
			[Register("getTotalMemory", "()J", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt64Method("getTotalMemory.()J", null);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0001F954 File Offset: 0x0001DB54
		public static string UniqueEventId
		{
			[Register("getUniqueEventId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getUniqueEventId.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0001F985 File Offset: 0x0001DB85
		public static long Uptime
		{
			[Register("getUptime", "()J", "")]
			get
			{
				return Device._members.StaticMethods.InvokeInt64Method("getUptime.()J", null);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001F9A0 File Offset: 0x0001DBA0
		[Register("getDevice", "()Ljava/lang/String;", "")]
		public static string GetDevice()
		{
			return JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getDevice.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001F9D4 File Offset: 0x0001DBD4
		[Register("getFreeSpace", "(Ljava/io/File;)J", "")]
		public unsafe static long GetFreeSpace(File file)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				result = Device._members.StaticMethods.InvokeInt64Method("getFreeSpace.(Ljava/io/File;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(file);
			}
			return result;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0001FA38 File Offset: 0x0001DC38
		[Register("getPackageInfo", "(Landroid/content/pm/PackageManager;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject GetPackageInfo(PackageManager pm)
		{
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pm == null) ? IntPtr.Zero : pm.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(Device._members.StaticMethods.InvokeObjectMethod("getPackageInfo.(Landroid/content/pm/PackageManager;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pm);
			}
			return @object;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		[Register("getStreamMaxVolume", "(I)I", "")]
		public unsafe static int GetStreamMaxVolume(int streamType)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(streamType);
			return Device._members.StaticMethods.InvokeInt32Method("getStreamMaxVolume.(I)I", ptr);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
		[Register("getStreamVolume", "(I)I", "")]
		public unsafe static int GetStreamVolume(int streamType)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(streamType);
			return Device._members.StaticMethods.InvokeInt32Method("getStreamVolume.(I)I", ptr);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0001FB24 File Offset: 0x0001DD24
		[Register("getSystemProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string GetSystemProperty(string propertyName, string defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(propertyName);
			IntPtr intPtr2 = JNIEnv.NewString(defaultValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(Device._members.StaticMethods.InvokeObjectMethod("getSystemProperty.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		[Register("getTotalSpace", "(Ljava/io/File;)J", "")]
		public unsafe static long GetTotalSpace(File file)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				result = Device._members.StaticMethods.InvokeInt64Method("getTotalSpace.(Ljava/io/File;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(file);
			}
			return result;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0001FC14 File Offset: 0x0001DE14
		[Register("isAdbEnabled", "()Ljava/lang/Boolean;", "")]
		public static Java.Lang.Boolean IsAdbEnabled()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(Device._members.StaticMethods.InvokeObjectMethod("isAdbEnabled.()Ljava/lang/Boolean;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0001FC48 File Offset: 0x0001DE48
		[Register("selectAllDecodeCodecs", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe static IList<MediaCodecInfo> SelectAllDecodeCodecs(string mimeType)
		{
			IntPtr intPtr = JNIEnv.NewString(mimeType);
			IList<MediaCodecInfo> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<MediaCodecInfo>.FromJniHandle(Device._members.StaticMethods.InvokeObjectMethod("selectAllDecodeCodecs.(Ljava/lang/String;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0400028F RID: 655
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/Device", typeof(Device));

		// Token: 0x0200011B RID: 283
		[Register("com/unity3d/services/core/device/Device$MemoryInfoType", DoNotGenerateAcw = true)]
		public sealed class MemoryInfoType : Java.Lang.Enum
		{
			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0001FCD0 File Offset: 0x0001DED0
			[Register("FREE_MEMORY")]
			public static Device.MemoryInfoType FreeMemory
			{
				get
				{
					return Java.Lang.Object.GetObject<Device.MemoryInfoType>(Device.MemoryInfoType._members.StaticFields.GetObjectValue("FREE_MEMORY.Lcom/unity3d/services/core/device/Device$MemoryInfoType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0001FD00 File Offset: 0x0001DF00
			[Register("TOTAL_MEMORY")]
			public static Device.MemoryInfoType TotalMemory
			{
				get
				{
					return Java.Lang.Object.GetObject<Device.MemoryInfoType>(Device.MemoryInfoType._members.StaticFields.GetObjectValue("TOTAL_MEMORY.Lcom/unity3d/services/core/device/Device$MemoryInfoType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0001FD30 File Offset: 0x0001DF30
			internal static IntPtr class_ref
			{
				get
				{
					return Device.MemoryInfoType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0001FD54 File Offset: 0x0001DF54
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Device.MemoryInfoType._members;
				}
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0001FD5C File Offset: 0x0001DF5C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Device.MemoryInfoType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0001FD80 File Offset: 0x0001DF80
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Device.MemoryInfoType._members.ManagedPeerType;
				}
			}

			// Token: 0x06000B33 RID: 2867 RVA: 0x0000256C File Offset: 0x0000076C
			internal MemoryInfoType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000B34 RID: 2868 RVA: 0x0001FD8C File Offset: 0x0001DF8C
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/Device$MemoryInfoType;", "")]
			public unsafe static Device.MemoryInfoType ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				Device.MemoryInfoType @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Device.MemoryInfoType>(Device.MemoryInfoType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/device/Device$MemoryInfoType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000B35 RID: 2869 RVA: 0x0001FDF8 File Offset: 0x0001DFF8
			[Register("values", "()[Lcom/unity3d/services/core/device/Device$MemoryInfoType;", "")]
			public static Device.MemoryInfoType[] Values()
			{
				return (Device.MemoryInfoType[])JNIEnv.GetArray(Device.MemoryInfoType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/device/Device$MemoryInfoType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Device.MemoryInfoType));
			}

			// Token: 0x04000290 RID: 656
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/Device$MemoryInfoType", typeof(Device.MemoryInfoType));
		}
	}
}
