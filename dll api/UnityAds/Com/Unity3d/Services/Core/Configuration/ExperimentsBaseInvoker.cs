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
	// Token: 0x0200015B RID: 347
	[Register("com/unity3d/services/core/configuration/ExperimentsBase", DoNotGenerateAcw = true)]
	internal class ExperimentsBaseInvoker : ExperimentsBase
	{
		// Token: 0x06000EFF RID: 3839 RVA: 0x00027EDC File Offset: 0x000260DC
		public ExperimentsBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x000290AD File Offset: 0x000272AD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExperimentsBaseInvoker._members;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x000290B4 File Offset: 0x000272B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExperimentsBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x000290C0 File Offset: 0x000272C0
		public override JSONObject CurrentSessionExperiments
		{
			[Register("getCurrentSessionExperiments", "()Lorg/json/JSONObject;", "GetGetCurrentSessionExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCurrentSessionExperiments.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x000290F4 File Offset: 0x000272F4
		public override IDictionary<string, string> ExperimentTags
		{
			[Register("getExperimentTags", "()Ljava/util/Map;", "GetGetExperimentTagsHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getExperimentTags.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00029128 File Offset: 0x00027328
		public override JSONObject ExperimentsAsJson
		{
			[Register("getExperimentsAsJson", "()Lorg/json/JSONObject;", "GetGetExperimentsAsJsonHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getExperimentsAsJson.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0002915A File Offset: 0x0002735A
		public override bool IsForwardExperimentsToWebViewEnabled
		{
			[Register("isForwardExperimentsToWebViewEnabled", "()Z", "GetIsForwardExperimentsToWebViewEnabledHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isForwardExperimentsToWebViewEnabled.()Z", this, null);
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00029173 File Offset: 0x00027373
		public override bool IsNativeTokenEnabled
		{
			[Register("isNativeTokenEnabled", "()Z", "GetIsNativeTokenEnabledHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isNativeTokenEnabled.()Z", this, null);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0002918C File Offset: 0x0002738C
		public override bool IsNativeWebViewCacheEnabled
		{
			[Register("isNativeWebViewCacheEnabled", "()Z", "GetIsNativeWebViewCacheEnabledHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isNativeWebViewCacheEnabled.()Z", this, null);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x000291A5 File Offset: 0x000273A5
		public override bool IsNewInitFlowEnabled
		{
			[Register("isNewInitFlowEnabled", "()Z", "GetIsNewInitFlowEnabledHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isNewInitFlowEnabled.()Z", this, null);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x000291BE File Offset: 0x000273BE
		public override bool IsNewLifecycleTimer
		{
			[Register("isNewLifecycleTimer", "()Z", "GetIsNewLifecycleTimerHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isNewLifecycleTimer.()Z", this, null);
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000291D7 File Offset: 0x000273D7
		public override bool IsPrivacyRequestEnabled
		{
			[Register("isPrivacyRequestEnabled", "()Z", "GetIsPrivacyRequestEnabledHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isPrivacyRequestEnabled.()Z", this, null);
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x000291F0 File Offset: 0x000273F0
		public override bool IsScarInitEnabled
		{
			[Register("isScarInitEnabled", "()Z", "GetIsScarInitEnabledHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isScarInitEnabled.()Z", this, null);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00029209 File Offset: 0x00027409
		public override bool IsTwoStageInitializationEnabled
		{
			[Register("isTwoStageInitializationEnabled", "()Z", "GetIsTwoStageInitializationEnabledHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isTwoStageInitializationEnabled.()Z", this, null);
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00029222 File Offset: 0x00027422
		public override bool IsUpdatePiiFields
		{
			[Register("isUpdatePiiFields", "()Z", "GetIsUpdatePiiFieldsHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isUpdatePiiFields.()Z", this, null);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0002923B File Offset: 0x0002743B
		public override bool IsWebAssetAdCaching
		{
			[Register("isWebAssetAdCaching", "()Z", "GetIsWebAssetAdCachingHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isWebAssetAdCaching.()Z", this, null);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00029254 File Offset: 0x00027454
		public override bool IsWebGestureNotRequired
		{
			[Register("isWebGestureNotRequired", "()Z", "GetIsWebGestureNotRequiredHandler")]
			get
			{
				return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isWebGestureNotRequired.()Z", this, null);
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00029270 File Offset: 0x00027470
		public override JSONObject NextSessionExperiments
		{
			[Register("getNextSessionExperiments", "()Lorg/json/JSONObject;", "GetGetNextSessionExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getNextSessionExperiments.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x000292A2 File Offset: 0x000274A2
		[Register("shouldNativeTokenAwaitPrivacy", "()Z", "GetShouldNativeTokenAwaitPrivacyHandler")]
		public override bool ShouldNativeTokenAwaitPrivacy()
		{
			return ExperimentsBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("shouldNativeTokenAwaitPrivacy.()Z", this, null);
		}

		// Token: 0x04000384 RID: 900
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ExperimentsBase", typeof(ExperimentsBaseInvoker));
	}
}
