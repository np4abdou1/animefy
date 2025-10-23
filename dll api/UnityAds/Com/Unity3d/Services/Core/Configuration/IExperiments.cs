using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Org.Json;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000164 RID: 356
	[Register("com/unity3d/services/core/configuration/IExperiments", "", "Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker")]
	public interface IExperiments : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000F51 RID: 3921
		JSONObject CurrentSessionExperiments { [Register("getCurrentSessionExperiments", "()Lorg/json/JSONObject;", "GetGetCurrentSessionExperimentsHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000F52 RID: 3922
		IDictionary<string, string> ExperimentTags { [Register("getExperimentTags", "()Ljava/util/Map;", "GetGetExperimentTagsHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000F53 RID: 3923
		JSONObject ExperimentsAsJson { [Register("getExperimentsAsJson", "()Lorg/json/JSONObject;", "GetGetExperimentsAsJsonHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000F54 RID: 3924
		bool IsForwardExperimentsToWebViewEnabled { [Register("isForwardExperimentsToWebViewEnabled", "()Z", "GetIsForwardExperimentsToWebViewEnabledHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000F55 RID: 3925
		bool IsNativeTokenEnabled { [Register("isNativeTokenEnabled", "()Z", "GetIsNativeTokenEnabledHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000F56 RID: 3926
		bool IsNativeWebViewCacheEnabled { [Register("isNativeWebViewCacheEnabled", "()Z", "GetIsNativeWebViewCacheEnabledHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000F57 RID: 3927
		bool IsNewInitFlowEnabled { [Register("isNewInitFlowEnabled", "()Z", "GetIsNewInitFlowEnabledHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000F58 RID: 3928
		bool IsNewLifecycleTimer { [Register("isNewLifecycleTimer", "()Z", "GetIsNewLifecycleTimerHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000F59 RID: 3929
		bool IsPrivacyRequestEnabled { [Register("isPrivacyRequestEnabled", "()Z", "GetIsPrivacyRequestEnabledHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000F5A RID: 3930
		bool IsScarInitEnabled { [Register("isScarInitEnabled", "()Z", "GetIsScarInitEnabledHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F5B RID: 3931
		bool IsTwoStageInitializationEnabled { [Register("isTwoStageInitializationEnabled", "()Z", "GetIsTwoStageInitializationEnabledHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F5C RID: 3932
		bool IsUpdatePiiFields { [Register("isUpdatePiiFields", "()Z", "GetIsUpdatePiiFieldsHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F5D RID: 3933
		bool IsWebAssetAdCaching { [Register("isWebAssetAdCaching", "()Z", "GetIsWebAssetAdCachingHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F5E RID: 3934
		bool IsWebGestureNotRequired { [Register("isWebGestureNotRequired", "()Z", "GetIsWebGestureNotRequiredHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000F5F RID: 3935
		JSONObject NextSessionExperiments { [Register("getNextSessionExperiments", "()Lorg/json/JSONObject;", "GetGetNextSessionExperimentsHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")] get; }

		// Token: 0x06000F60 RID: 3936
		[Register("shouldNativeTokenAwaitPrivacy", "()Z", "GetShouldNativeTokenAwaitPrivacyHandler:Com.Unity3d.Services.Core.Configuration.IExperimentsInvoker, UnityAds")]
		bool ShouldNativeTokenAwaitPrivacy();
	}
}
