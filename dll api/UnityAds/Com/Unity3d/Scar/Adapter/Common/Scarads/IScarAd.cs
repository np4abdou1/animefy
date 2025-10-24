using System;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common.Scarads
{
	// Token: 0x020002BB RID: 699
	[Register("com/unity3d/scar/adapter/common/scarads/IScarAd", "", "Com.Unity3d.Scar.Adapter.Common.Scarads.IScarAdInvoker")]
	public interface IScarAd : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600278D RID: 10125
		[Register("loadAd", "(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", "GetLoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler:Com.Unity3d.Scar.Adapter.Common.Scarads.IScarAdInvoker, UnityAds")]
		void LoadAd(IScarLoadListener p0);

		// Token: 0x0600278E RID: 10126
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler:Com.Unity3d.Scar.Adapter.Common.Scarads.IScarAdInvoker, UnityAds")]
		void Show(Activity p0);
	}
}
