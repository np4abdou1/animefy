using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Adcolonysdk
{
	// Token: 0x02000054 RID: 84
	[Register("com/adcolony/adcolonysdk/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0000CB40 File Offset: 0x0000AD40
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0000CB64 File Offset: 0x0000AD64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0000CB90 File Offset: 0x0000AD90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002128 File Offset: 0x00000328
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		[Register(".ctor", "()V", "")]
		public BuildConfig() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BuildConfig._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BuildConfig._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000130 RID: 304
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x04000131 RID: 305
		[Register("COLLECT_SIGNALS_DICT")]
		public const string CollectSignalsDict = "{\"origin_store\":\"google\",\"app_id\":\",\"bundle_id\":\",\"os_name\":\"android\",\"zone_ids\":[\"],\"carrier_name\":\",\"screen_width\":,\"screen_height\":,\"device_type\":\"phonetablet\",\"locale_language_code\":\",\"ln\":\",\"locale_country_code\":\",\"locale\":\",\"manufacturer\":\",\"device_brand\":\",\"device_model\":\",\"sdk_type\":\"android_native\",\"sdk_version\":\"4.\",\"network_type\":\"cellwifi\",\"os_version\":\",\"platform\":\"android\",\"app_bundle_name\":\",\"app_bundle_version\":\",\"battery_level\":,\"cell_service_country_code\":\",\"controller_version\":\",\"current_orientation\":,\"cleartext_permitted\":,\"available_stores\":[\"],\"advertiser_id\":\",\"limit_tracking\":false,\"adc_alt_id\":\",\"odt_payload\":{\"config\":{\"Q1\":[\",\\\"session_start\\\"\"],\"Q2\":[\",\\\"configure\\\"\"],\"Q3\":[\"],\"Q4\":[\"],\"Q5\":[\"],\"Q6\":[\"]},\"session\":{},\"events\":{},\"version\":},\"signals_count\":,\"device_audio\":true}";

		// Token: 0x04000132 RID: 306
		[Register("COLLECT_SIGNALS_DICT_ID")]
		public const string CollectSignalsDictId = "sa01";

		// Token: 0x04000133 RID: 307
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000134 RID: 308
		[Register("FLAVOR")]
		public const string Flavor = "prod";

		// Token: 0x04000135 RID: 309
		[Register("LAUNCH_REQ_DICT")]
		public const string LaunchReqDict = "\"iphoneos\"ipados\"cell\"tablet\"{\"carrier_name\":\",\"data_path\":\",\"device_api\":,\"screen_width\":,\"screen_height\":,\"display_dpi\":,\"device_type\":\"phone\",\"locale_language_code\":\",\"ln\":\",\"locale_country_code\":\",\"locale\":\",\"mac_address\":\"\",\"manufacturer\":\",\"device_brand\":\",\"media_path\":\",\"temp_storage_path\":\",\"memory_class\":,\"memory_used_mb\":,\"model\":\",\"device_model\":\",\"sdk_type\":\"android_native\",\"sdk_version\":\"4.\",\"network_type\":\"wifi\",\"os_version\":\",\"os_name\":\"android\",\"platform\":\"android\",\"arch\":\",\"user_id\":\"\",\"app_id\":\",\"app_bundle_name\":\",\"app_bundle_version\":\",\"battery_level\":1,\"cell_service_country_code\":\",\"timezone_ietf\":\",\"timezone_gmt_m\":,\"timezone_dst_m\":,\"controller_version\":\"3.\",\"current_orientation\":0,\"cleartext_permitted\":true,\"density\":,\"dark_mode\":false,\"available_stores\":[],\"advertiser_id\":\",\"limit_tracking\":false,\"adc_alt_id\":\"}";

		// Token: 0x04000136 RID: 310
		[Register("LAUNCH_REQ_DICT_ID")]
		public const string LaunchReqDictId = "la-req-01";

		// Token: 0x04000137 RID: 311
		[Register("LAUNCH_RESP_DICT")]
		public const string LaunchRespDict = "{\"controller\":{\"url\":\"https://adc-ad-assets.adtilt.com/launch/__controllers__/4.0.0/controller.js\",\"sha1\":,\"version\":\"3.\"},\"libraries\":[],\"item\":0,\"logging\":{\"log_private\":false,\"send_level\":1,\"enable_crash_reporting\":false,\"print_level\":3,\"report_interval_ms\":5000},\"metadata\":{\"controller_heartbeat_interval\":300000,\"controller_heartbeat_timeout\":15000,\"ad_request_timeout\":20000,\"iab_url\":\"https://adc-ad-assets.adtilt.com/launch/__libs__/omsdk/omsdk-v1.js\",\"odt_config\":{\"version\":,\"streams\":[{\"stream\":\"events\",\"request_types\":[\"start\",\"html5_interaction\",\"in_video_engagement\",\"download\",\"info\",\"viewable_impression\",\"complete\",\"skip\",\"continue\",\"midpoint\",\"first_quartile\",\"third_quartile\",\"reward_v4vc\"configure\"session_start\",\"session_end\",\"session_resume\",\"session_pause\"]\"table_name\"max_rows\": GROUP BY ]},\"calculate_odt_timeout\":500,\"async_odt_query\":false},\"status\":\"success\",\"pie\":\"}";

		// Token: 0x04000138 RID: 312
		[Register("LAUNCH_RESP_DICT_ID")]
		public const string LaunchRespDictId = "la-res-01";

		// Token: 0x04000139 RID: 313
		[Register("LAUNCH_URL")]
		public const string LaunchUrl = "https://adc3-launch.adcolony.com/v4/launch";

		// Token: 0x0400013A RID: 314
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.adcolony.adcolonysdk";

		// Token: 0x0400013B RID: 315
		[Register("LOCAL_CONTROLLER")]
		public const bool LocalController = false;

		// Token: 0x0400013C RID: 316
		[Register("PRIVATE_LOGGING_ENABLED")]
		public const bool PrivateLoggingEnabled = false;

		// Token: 0x0400013D RID: 317
		[Register("WEBVIEW_DEBUG_ENABLED")]
		public const bool WebviewDebugEnabled = false;

		// Token: 0x0400013E RID: 318
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/adcolonysdk/BuildConfig", typeof(BuildConfig));
	}
}
