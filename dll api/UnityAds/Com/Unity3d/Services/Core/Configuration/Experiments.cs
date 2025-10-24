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
	// Token: 0x02000159 RID: 345
	[Register("com/unity3d/services/core/configuration/Experiments", DoNotGenerateAcw = true)]
	public class Experiments : ExperimentsBase
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x000285AC File Offset: 0x000267AC
		internal new static IntPtr class_ref
		{
			get
			{
				return Experiments._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000285D0 File Offset: 0x000267D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Experiments._members;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x000285D8 File Offset: 0x000267D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Experiments._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x000285FC File Offset: 0x000267FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Experiments._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00027EDC File Offset: 0x000260DC
		protected Experiments(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00028608 File Offset: 0x00026808
		[Register(".ctor", "()V", "")]
		public Experiments() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Experiments._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Experiments._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00028678 File Offset: 0x00026878
		[Register(".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe Experiments(JSONObject experimentData) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((experimentData == null) ? IntPtr.Zero : experimentData.Handle);
				base.SetHandle(Experiments._members.InstanceMethods.StartCreateInstance("(Lorg/json/JSONObject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Experiments._members.InstanceMethods.FinishCreateInstance("(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(experimentData);
			}
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00028728 File Offset: 0x00026928
		private static Delegate GetGetCurrentSessionExperimentsHandler()
		{
			if (Experiments.cb_getCurrentSessionExperiments == null)
			{
				Experiments.cb_getCurrentSessionExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Experiments.n_GetCurrentSessionExperiments));
			}
			return Experiments.cb_getCurrentSessionExperiments;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0002874C File Offset: 0x0002694C
		private static IntPtr n_GetCurrentSessionExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentSessionExperiments);
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00028760 File Offset: 0x00026960
		public override JSONObject CurrentSessionExperiments
		{
			[Register("getCurrentSessionExperiments", "()Lorg/json/JSONObject;", "GetGetCurrentSessionExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(Experiments._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentSessionExperiments.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00028792 File Offset: 0x00026992
		private static Delegate GetGetExperimentTagsHandler()
		{
			if (Experiments.cb_getExperimentTags == null)
			{
				Experiments.cb_getExperimentTags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Experiments.n_GetExperimentTags));
			}
			return Experiments.cb_getExperimentTags;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000287B6 File Offset: 0x000269B6
		private static IntPtr n_GetExperimentTags(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentTags);
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x000287CC File Offset: 0x000269CC
		public override IDictionary<string, string> ExperimentTags
		{
			[Register("getExperimentTags", "()Ljava/util/Map;", "GetGetExperimentTagsHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(Experiments._members.InstanceMethods.InvokeVirtualObjectMethod("getExperimentTags.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000287FE File Offset: 0x000269FE
		private static Delegate GetGetExperimentsAsJsonHandler()
		{
			if (Experiments.cb_getExperimentsAsJson == null)
			{
				Experiments.cb_getExperimentsAsJson = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Experiments.n_GetExperimentsAsJson));
			}
			return Experiments.cb_getExperimentsAsJson;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00028822 File Offset: 0x00026A22
		private static IntPtr n_GetExperimentsAsJson(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentsAsJson);
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00028838 File Offset: 0x00026A38
		public override JSONObject ExperimentsAsJson
		{
			[Register("getExperimentsAsJson", "()Lorg/json/JSONObject;", "GetGetExperimentsAsJsonHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(Experiments._members.InstanceMethods.InvokeVirtualObjectMethod("getExperimentsAsJson.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0002886A File Offset: 0x00026A6A
		private static Delegate GetIsForwardExperimentsToWebViewEnabledHandler()
		{
			if (Experiments.cb_isForwardExperimentsToWebViewEnabled == null)
			{
				Experiments.cb_isForwardExperimentsToWebViewEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsForwardExperimentsToWebViewEnabled));
			}
			return Experiments.cb_isForwardExperimentsToWebViewEnabled;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0002888E File Offset: 0x00026A8E
		private static bool n_IsForwardExperimentsToWebViewEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsForwardExperimentsToWebViewEnabled;
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0002889D File Offset: 0x00026A9D
		public override bool IsForwardExperimentsToWebViewEnabled
		{
			[Register("isForwardExperimentsToWebViewEnabled", "()Z", "GetIsForwardExperimentsToWebViewEnabledHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isForwardExperimentsToWebViewEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x000288B6 File Offset: 0x00026AB6
		private static Delegate GetIsNativeTokenEnabledHandler()
		{
			if (Experiments.cb_isNativeTokenEnabled == null)
			{
				Experiments.cb_isNativeTokenEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsNativeTokenEnabled));
			}
			return Experiments.cb_isNativeTokenEnabled;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000288DA File Offset: 0x00026ADA
		private static bool n_IsNativeTokenEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeTokenEnabled;
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000288E9 File Offset: 0x00026AE9
		public override bool IsNativeTokenEnabled
		{
			[Register("isNativeTokenEnabled", "()Z", "GetIsNativeTokenEnabledHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isNativeTokenEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00028902 File Offset: 0x00026B02
		private static Delegate GetIsNativeWebViewCacheEnabledHandler()
		{
			if (Experiments.cb_isNativeWebViewCacheEnabled == null)
			{
				Experiments.cb_isNativeWebViewCacheEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsNativeWebViewCacheEnabled));
			}
			return Experiments.cb_isNativeWebViewCacheEnabled;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00028926 File Offset: 0x00026B26
		private static bool n_IsNativeWebViewCacheEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeWebViewCacheEnabled;
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00028935 File Offset: 0x00026B35
		public override bool IsNativeWebViewCacheEnabled
		{
			[Register("isNativeWebViewCacheEnabled", "()Z", "GetIsNativeWebViewCacheEnabledHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isNativeWebViewCacheEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0002894E File Offset: 0x00026B4E
		private static Delegate GetIsNewInitFlowEnabledHandler()
		{
			if (Experiments.cb_isNewInitFlowEnabled == null)
			{
				Experiments.cb_isNewInitFlowEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsNewInitFlowEnabled));
			}
			return Experiments.cb_isNewInitFlowEnabled;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00028972 File Offset: 0x00026B72
		private static bool n_IsNewInitFlowEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNewInitFlowEnabled;
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00028981 File Offset: 0x00026B81
		public override bool IsNewInitFlowEnabled
		{
			[Register("isNewInitFlowEnabled", "()Z", "GetIsNewInitFlowEnabledHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isNewInitFlowEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0002899A File Offset: 0x00026B9A
		private static Delegate GetIsNewLifecycleTimerHandler()
		{
			if (Experiments.cb_isNewLifecycleTimer == null)
			{
				Experiments.cb_isNewLifecycleTimer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsNewLifecycleTimer));
			}
			return Experiments.cb_isNewLifecycleTimer;
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000289BE File Offset: 0x00026BBE
		private static bool n_IsNewLifecycleTimer(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNewLifecycleTimer;
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x000289CD File Offset: 0x00026BCD
		public override bool IsNewLifecycleTimer
		{
			[Register("isNewLifecycleTimer", "()Z", "GetIsNewLifecycleTimerHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isNewLifecycleTimer.()Z", this, null);
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000289E6 File Offset: 0x00026BE6
		private static Delegate GetIsPrivacyRequestEnabledHandler()
		{
			if (Experiments.cb_isPrivacyRequestEnabled == null)
			{
				Experiments.cb_isPrivacyRequestEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsPrivacyRequestEnabled));
			}
			return Experiments.cb_isPrivacyRequestEnabled;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00028A0A File Offset: 0x00026C0A
		private static bool n_IsPrivacyRequestEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPrivacyRequestEnabled;
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00028A19 File Offset: 0x00026C19
		public override bool IsPrivacyRequestEnabled
		{
			[Register("isPrivacyRequestEnabled", "()Z", "GetIsPrivacyRequestEnabledHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isPrivacyRequestEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00028A32 File Offset: 0x00026C32
		private static Delegate GetIsScarInitEnabledHandler()
		{
			if (Experiments.cb_isScarInitEnabled == null)
			{
				Experiments.cb_isScarInitEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsScarInitEnabled));
			}
			return Experiments.cb_isScarInitEnabled;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00028A56 File Offset: 0x00026C56
		private static bool n_IsScarInitEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsScarInitEnabled;
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00028A65 File Offset: 0x00026C65
		public override bool IsScarInitEnabled
		{
			[Register("isScarInitEnabled", "()Z", "GetIsScarInitEnabledHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isScarInitEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00028A7E File Offset: 0x00026C7E
		private static Delegate GetIsTwoStageInitializationEnabledHandler()
		{
			if (Experiments.cb_isTwoStageInitializationEnabled == null)
			{
				Experiments.cb_isTwoStageInitializationEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsTwoStageInitializationEnabled));
			}
			return Experiments.cb_isTwoStageInitializationEnabled;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00028AA2 File Offset: 0x00026CA2
		private static bool n_IsTwoStageInitializationEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTwoStageInitializationEnabled;
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00028AB1 File Offset: 0x00026CB1
		public override bool IsTwoStageInitializationEnabled
		{
			[Register("isTwoStageInitializationEnabled", "()Z", "GetIsTwoStageInitializationEnabledHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isTwoStageInitializationEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00028ACA File Offset: 0x00026CCA
		private static Delegate GetIsUpdatePiiFieldsHandler()
		{
			if (Experiments.cb_isUpdatePiiFields == null)
			{
				Experiments.cb_isUpdatePiiFields = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsUpdatePiiFields));
			}
			return Experiments.cb_isUpdatePiiFields;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00028AEE File Offset: 0x00026CEE
		private static bool n_IsUpdatePiiFields(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsUpdatePiiFields;
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00028AFD File Offset: 0x00026CFD
		public override bool IsUpdatePiiFields
		{
			[Register("isUpdatePiiFields", "()Z", "GetIsUpdatePiiFieldsHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isUpdatePiiFields.()Z", this, null);
			}
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00028B16 File Offset: 0x00026D16
		private static Delegate GetIsWebAssetAdCachingHandler()
		{
			if (Experiments.cb_isWebAssetAdCaching == null)
			{
				Experiments.cb_isWebAssetAdCaching = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsWebAssetAdCaching));
			}
			return Experiments.cb_isWebAssetAdCaching;
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00028B3A File Offset: 0x00026D3A
		private static bool n_IsWebAssetAdCaching(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsWebAssetAdCaching;
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00028B49 File Offset: 0x00026D49
		public override bool IsWebAssetAdCaching
		{
			[Register("isWebAssetAdCaching", "()Z", "GetIsWebAssetAdCachingHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isWebAssetAdCaching.()Z", this, null);
			}
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00028B62 File Offset: 0x00026D62
		private static Delegate GetIsWebGestureNotRequiredHandler()
		{
			if (Experiments.cb_isWebGestureNotRequired == null)
			{
				Experiments.cb_isWebGestureNotRequired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_IsWebGestureNotRequired));
			}
			return Experiments.cb_isWebGestureNotRequired;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00028B86 File Offset: 0x00026D86
		private static bool n_IsWebGestureNotRequired(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsWebGestureNotRequired;
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00028B95 File Offset: 0x00026D95
		public override bool IsWebGestureNotRequired
		{
			[Register("isWebGestureNotRequired", "()Z", "GetIsWebGestureNotRequiredHandler")]
			get
			{
				return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isWebGestureNotRequired.()Z", this, null);
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00028BAE File Offset: 0x00026DAE
		private static Delegate GetGetNextSessionExperimentsHandler()
		{
			if (Experiments.cb_getNextSessionExperiments == null)
			{
				Experiments.cb_getNextSessionExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Experiments.n_GetNextSessionExperiments));
			}
			return Experiments.cb_getNextSessionExperiments;
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00028BD2 File Offset: 0x00026DD2
		private static IntPtr n_GetNextSessionExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextSessionExperiments);
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00028BE8 File Offset: 0x00026DE8
		public override JSONObject NextSessionExperiments
		{
			[Register("getNextSessionExperiments", "()Lorg/json/JSONObject;", "GetGetNextSessionExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(Experiments._members.InstanceMethods.InvokeVirtualObjectMethod("getNextSessionExperiments.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00028C1A File Offset: 0x00026E1A
		private static Delegate GetShouldNativeTokenAwaitPrivacyHandler()
		{
			if (Experiments.cb_shouldNativeTokenAwaitPrivacy == null)
			{
				Experiments.cb_shouldNativeTokenAwaitPrivacy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Experiments.n_ShouldNativeTokenAwaitPrivacy));
			}
			return Experiments.cb_shouldNativeTokenAwaitPrivacy;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00028C3E File Offset: 0x00026E3E
		private static bool n_ShouldNativeTokenAwaitPrivacy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Experiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldNativeTokenAwaitPrivacy();
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00028C4D File Offset: 0x00026E4D
		[Register("shouldNativeTokenAwaitPrivacy", "()Z", "GetShouldNativeTokenAwaitPrivacyHandler")]
		public override bool ShouldNativeTokenAwaitPrivacy()
		{
			return Experiments._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldNativeTokenAwaitPrivacy.()Z", this, null);
		}

		// Token: 0x04000362 RID: 866
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/Experiments", typeof(Experiments));

		// Token: 0x04000363 RID: 867
		private static Delegate cb_getCurrentSessionExperiments;

		// Token: 0x04000364 RID: 868
		private static Delegate cb_getExperimentTags;

		// Token: 0x04000365 RID: 869
		private static Delegate cb_getExperimentsAsJson;

		// Token: 0x04000366 RID: 870
		private static Delegate cb_isForwardExperimentsToWebViewEnabled;

		// Token: 0x04000367 RID: 871
		private static Delegate cb_isNativeTokenEnabled;

		// Token: 0x04000368 RID: 872
		private static Delegate cb_isNativeWebViewCacheEnabled;

		// Token: 0x04000369 RID: 873
		private static Delegate cb_isNewInitFlowEnabled;

		// Token: 0x0400036A RID: 874
		private static Delegate cb_isNewLifecycleTimer;

		// Token: 0x0400036B RID: 875
		private static Delegate cb_isPrivacyRequestEnabled;

		// Token: 0x0400036C RID: 876
		private static Delegate cb_isScarInitEnabled;

		// Token: 0x0400036D RID: 877
		private static Delegate cb_isTwoStageInitializationEnabled;

		// Token: 0x0400036E RID: 878
		private static Delegate cb_isUpdatePiiFields;

		// Token: 0x0400036F RID: 879
		private static Delegate cb_isWebAssetAdCaching;

		// Token: 0x04000370 RID: 880
		private static Delegate cb_isWebGestureNotRequired;

		// Token: 0x04000371 RID: 881
		private static Delegate cb_getNextSessionExperiments;

		// Token: 0x04000372 RID: 882
		private static Delegate cb_shouldNativeTokenAwaitPrivacy;
	}
}
