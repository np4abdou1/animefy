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
	// Token: 0x0200015A RID: 346
	[Register("com/unity3d/services/core/configuration/ExperimentsBase", DoNotGenerateAcw = true)]
	public abstract class ExperimentsBase : Java.Lang.Object, IExperiments, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00028C84 File Offset: 0x00026E84
		internal static IntPtr class_ref
		{
			get
			{
				return ExperimentsBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00028CA8 File Offset: 0x00026EA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExperimentsBase._members;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00028CB0 File Offset: 0x00026EB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExperimentsBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00028CD4 File Offset: 0x00026ED4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExperimentsBase._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ExperimentsBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00028CE0 File Offset: 0x00026EE0
		[Register(".ctor", "()V", "")]
		public ExperimentsBase() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ExperimentsBase._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ExperimentsBase._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00028D4E File Offset: 0x00026F4E
		private static Delegate GetShouldNativeTokenAwaitPrivacyHandler()
		{
			if (ExperimentsBase.cb_shouldNativeTokenAwaitPrivacy == null)
			{
				ExperimentsBase.cb_shouldNativeTokenAwaitPrivacy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_ShouldNativeTokenAwaitPrivacy));
			}
			return ExperimentsBase.cb_shouldNativeTokenAwaitPrivacy;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00028D72 File Offset: 0x00026F72
		private static bool n_ShouldNativeTokenAwaitPrivacy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldNativeTokenAwaitPrivacy();
		}

		// Token: 0x06000ED0 RID: 3792
		[Register("shouldNativeTokenAwaitPrivacy", "()Z", "GetShouldNativeTokenAwaitPrivacyHandler")]
		public abstract bool ShouldNativeTokenAwaitPrivacy();

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00028D81 File Offset: 0x00026F81
		private static Delegate GetGetCurrentSessionExperimentsHandler()
		{
			if (ExperimentsBase.cb_getCurrentSessionExperiments == null)
			{
				ExperimentsBase.cb_getCurrentSessionExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentsBase.n_GetCurrentSessionExperiments));
			}
			return ExperimentsBase.cb_getCurrentSessionExperiments;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00028DA5 File Offset: 0x00026FA5
		private static IntPtr n_GetCurrentSessionExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentSessionExperiments);
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000ED3 RID: 3795
		public abstract JSONObject CurrentSessionExperiments { [Register("getCurrentSessionExperiments", "()Lorg/json/JSONObject;", "GetGetCurrentSessionExperimentsHandler")] get; }

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00028DB9 File Offset: 0x00026FB9
		private static Delegate GetGetExperimentTagsHandler()
		{
			if (ExperimentsBase.cb_getExperimentTags == null)
			{
				ExperimentsBase.cb_getExperimentTags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentsBase.n_GetExperimentTags));
			}
			return ExperimentsBase.cb_getExperimentTags;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00028DDD File Offset: 0x00026FDD
		private static IntPtr n_GetExperimentTags(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentTags);
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000ED6 RID: 3798
		public abstract IDictionary<string, string> ExperimentTags { [Register("getExperimentTags", "()Ljava/util/Map;", "GetGetExperimentTagsHandler")] get; }

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00028DF1 File Offset: 0x00026FF1
		private static Delegate GetGetExperimentsAsJsonHandler()
		{
			if (ExperimentsBase.cb_getExperimentsAsJson == null)
			{
				ExperimentsBase.cb_getExperimentsAsJson = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentsBase.n_GetExperimentsAsJson));
			}
			return ExperimentsBase.cb_getExperimentsAsJson;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00028E15 File Offset: 0x00027015
		private static IntPtr n_GetExperimentsAsJson(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentsAsJson);
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000ED9 RID: 3801
		public abstract JSONObject ExperimentsAsJson { [Register("getExperimentsAsJson", "()Lorg/json/JSONObject;", "GetGetExperimentsAsJsonHandler")] get; }

		// Token: 0x06000EDA RID: 3802 RVA: 0x00028E29 File Offset: 0x00027029
		private static Delegate GetIsForwardExperimentsToWebViewEnabledHandler()
		{
			if (ExperimentsBase.cb_isForwardExperimentsToWebViewEnabled == null)
			{
				ExperimentsBase.cb_isForwardExperimentsToWebViewEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsForwardExperimentsToWebViewEnabled));
			}
			return ExperimentsBase.cb_isForwardExperimentsToWebViewEnabled;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00028E4D File Offset: 0x0002704D
		private static bool n_IsForwardExperimentsToWebViewEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsForwardExperimentsToWebViewEnabled;
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000EDC RID: 3804
		public abstract bool IsForwardExperimentsToWebViewEnabled { [Register("isForwardExperimentsToWebViewEnabled", "()Z", "GetIsForwardExperimentsToWebViewEnabledHandler")] get; }

		// Token: 0x06000EDD RID: 3805 RVA: 0x00028E5C File Offset: 0x0002705C
		private static Delegate GetIsNativeTokenEnabledHandler()
		{
			if (ExperimentsBase.cb_isNativeTokenEnabled == null)
			{
				ExperimentsBase.cb_isNativeTokenEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsNativeTokenEnabled));
			}
			return ExperimentsBase.cb_isNativeTokenEnabled;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00028E80 File Offset: 0x00027080
		private static bool n_IsNativeTokenEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeTokenEnabled;
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000EDF RID: 3807
		public abstract bool IsNativeTokenEnabled { [Register("isNativeTokenEnabled", "()Z", "GetIsNativeTokenEnabledHandler")] get; }

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00028E8F File Offset: 0x0002708F
		private static Delegate GetIsNativeWebViewCacheEnabledHandler()
		{
			if (ExperimentsBase.cb_isNativeWebViewCacheEnabled == null)
			{
				ExperimentsBase.cb_isNativeWebViewCacheEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsNativeWebViewCacheEnabled));
			}
			return ExperimentsBase.cb_isNativeWebViewCacheEnabled;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00028EB3 File Offset: 0x000270B3
		private static bool n_IsNativeWebViewCacheEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeWebViewCacheEnabled;
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000EE2 RID: 3810
		public abstract bool IsNativeWebViewCacheEnabled { [Register("isNativeWebViewCacheEnabled", "()Z", "GetIsNativeWebViewCacheEnabledHandler")] get; }

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00028EC2 File Offset: 0x000270C2
		private static Delegate GetIsNewInitFlowEnabledHandler()
		{
			if (ExperimentsBase.cb_isNewInitFlowEnabled == null)
			{
				ExperimentsBase.cb_isNewInitFlowEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsNewInitFlowEnabled));
			}
			return ExperimentsBase.cb_isNewInitFlowEnabled;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00028EE6 File Offset: 0x000270E6
		private static bool n_IsNewInitFlowEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNewInitFlowEnabled;
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000EE5 RID: 3813
		public abstract bool IsNewInitFlowEnabled { [Register("isNewInitFlowEnabled", "()Z", "GetIsNewInitFlowEnabledHandler")] get; }

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00028EF5 File Offset: 0x000270F5
		private static Delegate GetIsNewLifecycleTimerHandler()
		{
			if (ExperimentsBase.cb_isNewLifecycleTimer == null)
			{
				ExperimentsBase.cb_isNewLifecycleTimer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsNewLifecycleTimer));
			}
			return ExperimentsBase.cb_isNewLifecycleTimer;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00028F19 File Offset: 0x00027119
		private static bool n_IsNewLifecycleTimer(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNewLifecycleTimer;
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000EE8 RID: 3816
		public abstract bool IsNewLifecycleTimer { [Register("isNewLifecycleTimer", "()Z", "GetIsNewLifecycleTimerHandler")] get; }

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00028F28 File Offset: 0x00027128
		private static Delegate GetIsPrivacyRequestEnabledHandler()
		{
			if (ExperimentsBase.cb_isPrivacyRequestEnabled == null)
			{
				ExperimentsBase.cb_isPrivacyRequestEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsPrivacyRequestEnabled));
			}
			return ExperimentsBase.cb_isPrivacyRequestEnabled;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00028F4C File Offset: 0x0002714C
		private static bool n_IsPrivacyRequestEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPrivacyRequestEnabled;
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000EEB RID: 3819
		public abstract bool IsPrivacyRequestEnabled { [Register("isPrivacyRequestEnabled", "()Z", "GetIsPrivacyRequestEnabledHandler")] get; }

		// Token: 0x06000EEC RID: 3820 RVA: 0x00028F5B File Offset: 0x0002715B
		private static Delegate GetIsScarInitEnabledHandler()
		{
			if (ExperimentsBase.cb_isScarInitEnabled == null)
			{
				ExperimentsBase.cb_isScarInitEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsScarInitEnabled));
			}
			return ExperimentsBase.cb_isScarInitEnabled;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00028F7F File Offset: 0x0002717F
		private static bool n_IsScarInitEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsScarInitEnabled;
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000EEE RID: 3822
		public abstract bool IsScarInitEnabled { [Register("isScarInitEnabled", "()Z", "GetIsScarInitEnabledHandler")] get; }

		// Token: 0x06000EEF RID: 3823 RVA: 0x00028F8E File Offset: 0x0002718E
		private static Delegate GetIsTwoStageInitializationEnabledHandler()
		{
			if (ExperimentsBase.cb_isTwoStageInitializationEnabled == null)
			{
				ExperimentsBase.cb_isTwoStageInitializationEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsTwoStageInitializationEnabled));
			}
			return ExperimentsBase.cb_isTwoStageInitializationEnabled;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00028FB2 File Offset: 0x000271B2
		private static bool n_IsTwoStageInitializationEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTwoStageInitializationEnabled;
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000EF1 RID: 3825
		public abstract bool IsTwoStageInitializationEnabled { [Register("isTwoStageInitializationEnabled", "()Z", "GetIsTwoStageInitializationEnabledHandler")] get; }

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00028FC1 File Offset: 0x000271C1
		private static Delegate GetIsUpdatePiiFieldsHandler()
		{
			if (ExperimentsBase.cb_isUpdatePiiFields == null)
			{
				ExperimentsBase.cb_isUpdatePiiFields = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsUpdatePiiFields));
			}
			return ExperimentsBase.cb_isUpdatePiiFields;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00028FE5 File Offset: 0x000271E5
		private static bool n_IsUpdatePiiFields(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsUpdatePiiFields;
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000EF4 RID: 3828
		public abstract bool IsUpdatePiiFields { [Register("isUpdatePiiFields", "()Z", "GetIsUpdatePiiFieldsHandler")] get; }

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00028FF4 File Offset: 0x000271F4
		private static Delegate GetIsWebAssetAdCachingHandler()
		{
			if (ExperimentsBase.cb_isWebAssetAdCaching == null)
			{
				ExperimentsBase.cb_isWebAssetAdCaching = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsWebAssetAdCaching));
			}
			return ExperimentsBase.cb_isWebAssetAdCaching;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00029018 File Offset: 0x00027218
		private static bool n_IsWebAssetAdCaching(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsWebAssetAdCaching;
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000EF7 RID: 3831
		public abstract bool IsWebAssetAdCaching { [Register("isWebAssetAdCaching", "()Z", "GetIsWebAssetAdCachingHandler")] get; }

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00029027 File Offset: 0x00027227
		private static Delegate GetIsWebGestureNotRequiredHandler()
		{
			if (ExperimentsBase.cb_isWebGestureNotRequired == null)
			{
				ExperimentsBase.cb_isWebGestureNotRequired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentsBase.n_IsWebGestureNotRequired));
			}
			return ExperimentsBase.cb_isWebGestureNotRequired;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0002904B File Offset: 0x0002724B
		private static bool n_IsWebGestureNotRequired(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsWebGestureNotRequired;
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000EFA RID: 3834
		public abstract bool IsWebGestureNotRequired { [Register("isWebGestureNotRequired", "()Z", "GetIsWebGestureNotRequiredHandler")] get; }

		// Token: 0x06000EFB RID: 3835 RVA: 0x0002905A File Offset: 0x0002725A
		private static Delegate GetGetNextSessionExperimentsHandler()
		{
			if (ExperimentsBase.cb_getNextSessionExperiments == null)
			{
				ExperimentsBase.cb_getNextSessionExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentsBase.n_GetNextSessionExperiments));
			}
			return ExperimentsBase.cb_getNextSessionExperiments;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0002907E File Offset: 0x0002727E
		private static IntPtr n_GetNextSessionExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentsBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextSessionExperiments);
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000EFD RID: 3837
		public abstract JSONObject NextSessionExperiments { [Register("getNextSessionExperiments", "()Lorg/json/JSONObject;", "GetGetNextSessionExperimentsHandler")] get; }

		// Token: 0x04000373 RID: 883
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ExperimentsBase", typeof(ExperimentsBase));

		// Token: 0x04000374 RID: 884
		private static Delegate cb_shouldNativeTokenAwaitPrivacy;

		// Token: 0x04000375 RID: 885
		private static Delegate cb_getCurrentSessionExperiments;

		// Token: 0x04000376 RID: 886
		private static Delegate cb_getExperimentTags;

		// Token: 0x04000377 RID: 887
		private static Delegate cb_getExperimentsAsJson;

		// Token: 0x04000378 RID: 888
		private static Delegate cb_isForwardExperimentsToWebViewEnabled;

		// Token: 0x04000379 RID: 889
		private static Delegate cb_isNativeTokenEnabled;

		// Token: 0x0400037A RID: 890
		private static Delegate cb_isNativeWebViewCacheEnabled;

		// Token: 0x0400037B RID: 891
		private static Delegate cb_isNewInitFlowEnabled;

		// Token: 0x0400037C RID: 892
		private static Delegate cb_isNewLifecycleTimer;

		// Token: 0x0400037D RID: 893
		private static Delegate cb_isPrivacyRequestEnabled;

		// Token: 0x0400037E RID: 894
		private static Delegate cb_isScarInitEnabled;

		// Token: 0x0400037F RID: 895
		private static Delegate cb_isTwoStageInitializationEnabled;

		// Token: 0x04000380 RID: 896
		private static Delegate cb_isUpdatePiiFields;

		// Token: 0x04000381 RID: 897
		private static Delegate cb_isWebAssetAdCaching;

		// Token: 0x04000382 RID: 898
		private static Delegate cb_isWebGestureNotRequired;

		// Token: 0x04000383 RID: 899
		private static Delegate cb_getNextSessionExperiments;
	}
}
