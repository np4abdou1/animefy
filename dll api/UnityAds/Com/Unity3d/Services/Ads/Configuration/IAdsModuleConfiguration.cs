using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Configuration
{
	// Token: 0x0200021F RID: 543
	[Register("com/unity3d/services/ads/configuration/IAdsModuleConfiguration", "", "Com.Unity3d.Services.Ads.Configuration.IAdsModuleConfigurationInvoker")]
	public interface IAdsModuleConfiguration : IModuleConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x0600198D RID: 6541
		IDictionary<string, Class> AdUnitViewHandlers { [Register("getAdUnitViewHandlers", "()Ljava/util/Map;", "GetGetAdUnitViewHandlersHandler:Com.Unity3d.Services.Ads.Configuration.IAdsModuleConfigurationInvoker, UnityAds")] get; }
	}
}
