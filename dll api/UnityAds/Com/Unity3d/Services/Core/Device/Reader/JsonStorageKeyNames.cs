using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200013F RID: 319
	[Register("com/unity3d/services/core/device/reader/JsonStorageKeyNames", DoNotGenerateAcw = true)]
	public class JsonStorageKeyNames : Java.Lang.Object
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00023C98 File Offset: 0x00021E98
		internal static IntPtr class_ref
		{
			get
			{
				return JsonStorageKeyNames._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00023CBC File Offset: 0x00021EBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JsonStorageKeyNames._members;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00023CC4 File Offset: 0x00021EC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JsonStorageKeyNames._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00023CE8 File Offset: 0x00021EE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JsonStorageKeyNames._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000021E8 File Offset: 0x000003E8
		protected JsonStorageKeyNames(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00023CF4 File Offset: 0x00021EF4
		[Register(".ctor", "()V", "")]
		public JsonStorageKeyNames() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(JsonStorageKeyNames._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			JsonStorageKeyNames._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x040002E8 RID: 744
		[Register("ADVERTISING_TRACKING_ID_KEY")]
		public const string AdvertisingTrackingIdKey = "advertisingTrackingId";

		// Token: 0x040002E9 RID: 745
		[Register("ADVERTISING_TRACKING_ID_NORMALIZED_KEY")]
		public const string AdvertisingTrackingIdNormalizedKey = "unifiedconfig.pii.advertisingTrackingId";

		// Token: 0x040002EA RID: 746
		[Register("DATA_KEY")]
		public const string DataKey = "data";

		// Token: 0x040002EB RID: 747
		[Register("GAME_SESSION_ID_KEY")]
		public const string GameSessionIdKey = "gameSessionId";

		// Token: 0x040002EC RID: 748
		[Register("GAME_SESSION_ID_NORMALIZED_KEY")]
		public const string GameSessionIdNormalizedKey = "unifiedconfig.data.gameSessionId";

		// Token: 0x040002ED RID: 749
		[Register("PRIVACY_MODE_KEY")]
		public const string PrivacyModeKey = "privacy.mode.value";

		// Token: 0x040002EE RID: 750
		[Register("PRIVACY_SPM_KEY")]
		public const string PrivacySpmKey = "privacy.spm.value";

		// Token: 0x040002EF RID: 751
		[Register("UNIFIED_CONFIG_KEY")]
		public const string UnifiedConfigKey = "unifiedconfig";

		// Token: 0x040002F0 RID: 752
		[Register("UNIFIED_CONFIG_PII_KEY")]
		public const string UnifiedConfigPiiKey = "unifiedconfig.pii";

		// Token: 0x040002F1 RID: 753
		[Register("USER_NON_BEHAVIORAL_KEY")]
		public const string UserNonBehavioralKey = "user.nonBehavioral";

		// Token: 0x040002F2 RID: 754
		[Register("USER_NON_BEHAVIORAL_VALUE_ALT_KEY")]
		public const string UserNonBehavioralValueAltKey = "user.nonBehavioral.value";

		// Token: 0x040002F3 RID: 755
		[Register("USER_NON_BEHAVIORAL_VALUE_KEY")]
		public const string UserNonBehavioralValueKey = "user.nonbehavioral.value";

		// Token: 0x040002F4 RID: 756
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/JsonStorageKeyNames", typeof(JsonStorageKeyNames));
	}
}
