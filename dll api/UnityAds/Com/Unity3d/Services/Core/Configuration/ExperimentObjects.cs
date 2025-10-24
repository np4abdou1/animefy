using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000158 RID: 344
	[Register("com/unity3d/services/core/configuration/ExperimentObjects", DoNotGenerateAcw = true)]
	public class ExperimentObjects : ExperimentsBase
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00027E80 File Offset: 0x00026080
		internal new static IntPtr class_ref
		{
			get
			{
				return ExperimentObjects._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00027EA4 File Offset: 0x000260A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExperimentObjects._members;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00027EAC File Offset: 0x000260AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExperimentObjects._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00027ED0 File Offset: 0x000260D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExperimentObjects._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00027EDC File Offset: 0x000260DC
		protected ExperimentObjects(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00027EE8 File Offset: 0x000260E8
		[Register(".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ExperimentObjects(JSONObject experimentObjects) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((experimentObjects == null) ? IntPtr.Zero : experimentObjects.Handle);
				base.SetHandle(ExperimentObjects._members.InstanceMethods.StartCreateInstance("(Lorg/json/JSONObject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExperimentObjects._members.InstanceMethods.FinishCreateInstance("(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(experimentObjects);
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00027F98 File Offset: 0x00026198
		private static Delegate GetGetCurrentSessionExperimentsHandler()
		{
			if (ExperimentObjects.cb_getCurrentSessionExperiments == null)
			{
				ExperimentObjects.cb_getCurrentSessionExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentObjects.n_GetCurrentSessionExperiments));
			}
			return ExperimentObjects.cb_getCurrentSessionExperiments;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00027FBC File Offset: 0x000261BC
		private static IntPtr n_GetCurrentSessionExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentSessionExperiments);
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00027FD0 File Offset: 0x000261D0
		public override JSONObject CurrentSessionExperiments
		{
			[Register("getCurrentSessionExperiments", "()Lorg/json/JSONObject;", "GetGetCurrentSessionExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(ExperimentObjects._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentSessionExperiments.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00028002 File Offset: 0x00026202
		private static Delegate GetGetExperimentTagsHandler()
		{
			if (ExperimentObjects.cb_getExperimentTags == null)
			{
				ExperimentObjects.cb_getExperimentTags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentObjects.n_GetExperimentTags));
			}
			return ExperimentObjects.cb_getExperimentTags;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00028026 File Offset: 0x00026226
		private static IntPtr n_GetExperimentTags(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentTags);
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0002803C File Offset: 0x0002623C
		public override IDictionary<string, string> ExperimentTags
		{
			[Register("getExperimentTags", "()Ljava/util/Map;", "GetGetExperimentTagsHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(ExperimentObjects._members.InstanceMethods.InvokeVirtualObjectMethod("getExperimentTags.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0002806E File Offset: 0x0002626E
		private static Delegate GetGetExperimentsAsJsonHandler()
		{
			if (ExperimentObjects.cb_getExperimentsAsJson == null)
			{
				ExperimentObjects.cb_getExperimentsAsJson = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentObjects.n_GetExperimentsAsJson));
			}
			return ExperimentObjects.cb_getExperimentsAsJson;
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00028092 File Offset: 0x00026292
		private static IntPtr n_GetExperimentsAsJson(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentsAsJson);
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000280A8 File Offset: 0x000262A8
		public override JSONObject ExperimentsAsJson
		{
			[Register("getExperimentsAsJson", "()Lorg/json/JSONObject;", "GetGetExperimentsAsJsonHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(ExperimentObjects._members.InstanceMethods.InvokeVirtualObjectMethod("getExperimentsAsJson.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000280DA File Offset: 0x000262DA
		private static Delegate GetIsForwardExperimentsToWebViewEnabledHandler()
		{
			if (ExperimentObjects.cb_isForwardExperimentsToWebViewEnabled == null)
			{
				ExperimentObjects.cb_isForwardExperimentsToWebViewEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsForwardExperimentsToWebViewEnabled));
			}
			return ExperimentObjects.cb_isForwardExperimentsToWebViewEnabled;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000280FE File Offset: 0x000262FE
		private static bool n_IsForwardExperimentsToWebViewEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsForwardExperimentsToWebViewEnabled;
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0002810D File Offset: 0x0002630D
		public override bool IsForwardExperimentsToWebViewEnabled
		{
			[Register("isForwardExperimentsToWebViewEnabled", "()Z", "GetIsForwardExperimentsToWebViewEnabledHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isForwardExperimentsToWebViewEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00028126 File Offset: 0x00026326
		private static Delegate GetIsNativeTokenEnabledHandler()
		{
			if (ExperimentObjects.cb_isNativeTokenEnabled == null)
			{
				ExperimentObjects.cb_isNativeTokenEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsNativeTokenEnabled));
			}
			return ExperimentObjects.cb_isNativeTokenEnabled;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0002814A File Offset: 0x0002634A
		private static bool n_IsNativeTokenEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeTokenEnabled;
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00028159 File Offset: 0x00026359
		public override bool IsNativeTokenEnabled
		{
			[Register("isNativeTokenEnabled", "()Z", "GetIsNativeTokenEnabledHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isNativeTokenEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00028172 File Offset: 0x00026372
		private static Delegate GetIsNativeWebViewCacheEnabledHandler()
		{
			if (ExperimentObjects.cb_isNativeWebViewCacheEnabled == null)
			{
				ExperimentObjects.cb_isNativeWebViewCacheEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsNativeWebViewCacheEnabled));
			}
			return ExperimentObjects.cb_isNativeWebViewCacheEnabled;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00028196 File Offset: 0x00026396
		private static bool n_IsNativeWebViewCacheEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeWebViewCacheEnabled;
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000281A5 File Offset: 0x000263A5
		public override bool IsNativeWebViewCacheEnabled
		{
			[Register("isNativeWebViewCacheEnabled", "()Z", "GetIsNativeWebViewCacheEnabledHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isNativeWebViewCacheEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x000281BE File Offset: 0x000263BE
		private static Delegate GetIsNewInitFlowEnabledHandler()
		{
			if (ExperimentObjects.cb_isNewInitFlowEnabled == null)
			{
				ExperimentObjects.cb_isNewInitFlowEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsNewInitFlowEnabled));
			}
			return ExperimentObjects.cb_isNewInitFlowEnabled;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000281E2 File Offset: 0x000263E2
		private static bool n_IsNewInitFlowEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNewInitFlowEnabled;
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x000281F1 File Offset: 0x000263F1
		public override bool IsNewInitFlowEnabled
		{
			[Register("isNewInitFlowEnabled", "()Z", "GetIsNewInitFlowEnabledHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isNewInitFlowEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0002820A File Offset: 0x0002640A
		private static Delegate GetIsNewLifecycleTimerHandler()
		{
			if (ExperimentObjects.cb_isNewLifecycleTimer == null)
			{
				ExperimentObjects.cb_isNewLifecycleTimer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsNewLifecycleTimer));
			}
			return ExperimentObjects.cb_isNewLifecycleTimer;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0002822E File Offset: 0x0002642E
		private static bool n_IsNewLifecycleTimer(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNewLifecycleTimer;
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0002823D File Offset: 0x0002643D
		public override bool IsNewLifecycleTimer
		{
			[Register("isNewLifecycleTimer", "()Z", "GetIsNewLifecycleTimerHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isNewLifecycleTimer.()Z", this, null);
			}
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00028256 File Offset: 0x00026456
		private static Delegate GetIsPrivacyRequestEnabledHandler()
		{
			if (ExperimentObjects.cb_isPrivacyRequestEnabled == null)
			{
				ExperimentObjects.cb_isPrivacyRequestEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsPrivacyRequestEnabled));
			}
			return ExperimentObjects.cb_isPrivacyRequestEnabled;
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0002827A File Offset: 0x0002647A
		private static bool n_IsPrivacyRequestEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPrivacyRequestEnabled;
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00028289 File Offset: 0x00026489
		public override bool IsPrivacyRequestEnabled
		{
			[Register("isPrivacyRequestEnabled", "()Z", "GetIsPrivacyRequestEnabledHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isPrivacyRequestEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000282A2 File Offset: 0x000264A2
		private static Delegate GetIsScarInitEnabledHandler()
		{
			if (ExperimentObjects.cb_isScarInitEnabled == null)
			{
				ExperimentObjects.cb_isScarInitEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsScarInitEnabled));
			}
			return ExperimentObjects.cb_isScarInitEnabled;
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000282C6 File Offset: 0x000264C6
		private static bool n_IsScarInitEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsScarInitEnabled;
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x000282D5 File Offset: 0x000264D5
		public override bool IsScarInitEnabled
		{
			[Register("isScarInitEnabled", "()Z", "GetIsScarInitEnabledHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isScarInitEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x000282EE File Offset: 0x000264EE
		private static Delegate GetIsTwoStageInitializationEnabledHandler()
		{
			if (ExperimentObjects.cb_isTwoStageInitializationEnabled == null)
			{
				ExperimentObjects.cb_isTwoStageInitializationEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsTwoStageInitializationEnabled));
			}
			return ExperimentObjects.cb_isTwoStageInitializationEnabled;
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00028312 File Offset: 0x00026512
		private static bool n_IsTwoStageInitializationEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTwoStageInitializationEnabled;
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00028321 File Offset: 0x00026521
		public override bool IsTwoStageInitializationEnabled
		{
			[Register("isTwoStageInitializationEnabled", "()Z", "GetIsTwoStageInitializationEnabledHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isTwoStageInitializationEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0002833A File Offset: 0x0002653A
		private static Delegate GetIsUpdatePiiFieldsHandler()
		{
			if (ExperimentObjects.cb_isUpdatePiiFields == null)
			{
				ExperimentObjects.cb_isUpdatePiiFields = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsUpdatePiiFields));
			}
			return ExperimentObjects.cb_isUpdatePiiFields;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0002835E File Offset: 0x0002655E
		private static bool n_IsUpdatePiiFields(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsUpdatePiiFields;
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0002836D File Offset: 0x0002656D
		public override bool IsUpdatePiiFields
		{
			[Register("isUpdatePiiFields", "()Z", "GetIsUpdatePiiFieldsHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isUpdatePiiFields.()Z", this, null);
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00028386 File Offset: 0x00026586
		private static Delegate GetIsWebAssetAdCachingHandler()
		{
			if (ExperimentObjects.cb_isWebAssetAdCaching == null)
			{
				ExperimentObjects.cb_isWebAssetAdCaching = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsWebAssetAdCaching));
			}
			return ExperimentObjects.cb_isWebAssetAdCaching;
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000283AA File Offset: 0x000265AA
		private static bool n_IsWebAssetAdCaching(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsWebAssetAdCaching;
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x000283B9 File Offset: 0x000265B9
		public override bool IsWebAssetAdCaching
		{
			[Register("isWebAssetAdCaching", "()Z", "GetIsWebAssetAdCachingHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isWebAssetAdCaching.()Z", this, null);
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000283D2 File Offset: 0x000265D2
		private static Delegate GetIsWebGestureNotRequiredHandler()
		{
			if (ExperimentObjects.cb_isWebGestureNotRequired == null)
			{
				ExperimentObjects.cb_isWebGestureNotRequired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_IsWebGestureNotRequired));
			}
			return ExperimentObjects.cb_isWebGestureNotRequired;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000283F6 File Offset: 0x000265F6
		private static bool n_IsWebGestureNotRequired(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsWebGestureNotRequired;
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x00028405 File Offset: 0x00026605
		public override bool IsWebGestureNotRequired
		{
			[Register("isWebGestureNotRequired", "()Z", "GetIsWebGestureNotRequiredHandler")]
			get
			{
				return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("isWebGestureNotRequired.()Z", this, null);
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0002841E File Offset: 0x0002661E
		private static Delegate GetGetNextSessionExperimentsHandler()
		{
			if (ExperimentObjects.cb_getNextSessionExperiments == null)
			{
				ExperimentObjects.cb_getNextSessionExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentObjects.n_GetNextSessionExperiments));
			}
			return ExperimentObjects.cb_getNextSessionExperiments;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00028442 File Offset: 0x00026642
		private static IntPtr n_GetNextSessionExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextSessionExperiments);
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00028458 File Offset: 0x00026658
		public override JSONObject NextSessionExperiments
		{
			[Register("getNextSessionExperiments", "()Lorg/json/JSONObject;", "GetGetNextSessionExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(ExperimentObjects._members.InstanceMethods.InvokeVirtualObjectMethod("getNextSessionExperiments.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0002848A File Offset: 0x0002668A
		private static Delegate GetGetExperimentObject_Ljava_lang_String_Handler()
		{
			if (ExperimentObjects.cb_getExperimentObject_Ljava_lang_String_ == null)
			{
				ExperimentObjects.cb_getExperimentObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ExperimentObjects.n_GetExperimentObject_Ljava_lang_String_));
			}
			return ExperimentObjects.cb_getExperimentObject_Ljava_lang_String_;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000284B0 File Offset: 0x000266B0
		private static IntPtr n_GetExperimentObject_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_experimentName)
		{
			ExperimentObjects @object = Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_experimentName, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetExperimentObject(@string));
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000284D8 File Offset: 0x000266D8
		[Register("getExperimentObject", "(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/ExperimentObject;", "GetGetExperimentObject_Ljava_lang_String_Handler")]
		public unsafe virtual ExperimentObject GetExperimentObject(string experimentName)
		{
			IntPtr intPtr = JNIEnv.NewString(experimentName);
			ExperimentObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ExperimentObject>(ExperimentObjects._members.InstanceMethods.InvokeVirtualObjectMethod("getExperimentObject.(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/ExperimentObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00028544 File Offset: 0x00026744
		private static Delegate GetShouldNativeTokenAwaitPrivacyHandler()
		{
			if (ExperimentObjects.cb_shouldNativeTokenAwaitPrivacy == null)
			{
				ExperimentObjects.cb_shouldNativeTokenAwaitPrivacy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObjects.n_ShouldNativeTokenAwaitPrivacy));
			}
			return ExperimentObjects.cb_shouldNativeTokenAwaitPrivacy;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00028568 File Offset: 0x00026768
		private static bool n_ShouldNativeTokenAwaitPrivacy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObjects>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldNativeTokenAwaitPrivacy();
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00028577 File Offset: 0x00026777
		[Register("shouldNativeTokenAwaitPrivacy", "()Z", "GetShouldNativeTokenAwaitPrivacyHandler")]
		public override bool ShouldNativeTokenAwaitPrivacy()
		{
			return ExperimentObjects._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldNativeTokenAwaitPrivacy.()Z", this, null);
		}

		// Token: 0x04000350 RID: 848
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ExperimentObjects", typeof(ExperimentObjects));

		// Token: 0x04000351 RID: 849
		private static Delegate cb_getCurrentSessionExperiments;

		// Token: 0x04000352 RID: 850
		private static Delegate cb_getExperimentTags;

		// Token: 0x04000353 RID: 851
		private static Delegate cb_getExperimentsAsJson;

		// Token: 0x04000354 RID: 852
		private static Delegate cb_isForwardExperimentsToWebViewEnabled;

		// Token: 0x04000355 RID: 853
		private static Delegate cb_isNativeTokenEnabled;

		// Token: 0x04000356 RID: 854
		private static Delegate cb_isNativeWebViewCacheEnabled;

		// Token: 0x04000357 RID: 855
		private static Delegate cb_isNewInitFlowEnabled;

		// Token: 0x04000358 RID: 856
		private static Delegate cb_isNewLifecycleTimer;

		// Token: 0x04000359 RID: 857
		private static Delegate cb_isPrivacyRequestEnabled;

		// Token: 0x0400035A RID: 858
		private static Delegate cb_isScarInitEnabled;

		// Token: 0x0400035B RID: 859
		private static Delegate cb_isTwoStageInitializationEnabled;

		// Token: 0x0400035C RID: 860
		private static Delegate cb_isUpdatePiiFields;

		// Token: 0x0400035D RID: 861
		private static Delegate cb_isWebAssetAdCaching;

		// Token: 0x0400035E RID: 862
		private static Delegate cb_isWebGestureNotRequired;

		// Token: 0x0400035F RID: 863
		private static Delegate cb_getNextSessionExperiments;

		// Token: 0x04000360 RID: 864
		private static Delegate cb_getExperimentObject_Ljava_lang_String_;

		// Token: 0x04000361 RID: 865
		private static Delegate cb_shouldNativeTokenAwaitPrivacy;
	}
}
