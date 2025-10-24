using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A3 RID: 675
	[Register("com/unity3d/scar/adapter/common/IUnityAdsError", "", "Com.Unity3d.Scar.Adapter.Common.IUnityAdsErrorInvoker")]
	public interface IUnityAdsError : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x060026AB RID: 9899
		int Code { [Register("getCode", "()I", "GetGetCodeHandler:Com.Unity3d.Scar.Adapter.Common.IUnityAdsErrorInvoker, UnityAds")] get; }

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060026AC RID: 9900
		string Description { [Register("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Com.Unity3d.Scar.Adapter.Common.IUnityAdsErrorInvoker, UnityAds")] get; }

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060026AD RID: 9901
		string Domain { [Register("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler:Com.Unity3d.Scar.Adapter.Common.IUnityAdsErrorInvoker, UnityAds")] get; }
	}
}
