using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Com.Unity3d.Scar.Adapter.Common.Signals;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x0200029B RID: 667
	[Register("com/unity3d/scar/adapter/common/IScarAdapter", "", "Com.Unity3d.Scar.Adapter.Common.IScarAdapterInvoker")]
	public interface IScarAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002623 RID: 9763
		[Register("getSCARSignals", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Lcom/unity3d/scar/adapter/common/signals/ISignalCollectionListener;)V", "GetGetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_Handler:Com.Unity3d.Scar.Adapter.Common.IScarAdapterInvoker, UnityAds")]
		void GetSCARSignals(Context p0, string[] p1, string[] p2, ISignalCollectionListener p3);

		// Token: 0x06002624 RID: 9764
		[Register("loadInterstitialAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper;)V", "GetLoadInterstitialAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarInterstitialAdListenerWrapper_Handler:Com.Unity3d.Scar.Adapter.Common.IScarAdapterInvoker, UnityAds")]
		void LoadInterstitialAd(Context p0, ScarAdMetadata p1, IScarInterstitialAdListenerWrapper p2);

		// Token: 0x06002625 RID: 9765
		[Register("loadRewardedAd", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper;)V", "GetLoadRewardedAd_Landroid_content_Context_Lcom_unity3d_scar_adapter_common_scarads_ScarAdMetadata_Lcom_unity3d_scar_adapter_common_IScarRewardedAdListenerWrapper_Handler:Com.Unity3d.Scar.Adapter.Common.IScarAdapterInvoker, UnityAds")]
		void LoadRewardedAd(Context p0, ScarAdMetadata p1, IScarRewardedAdListenerWrapper p2);

		// Token: 0x06002626 RID: 9766
		[Register("show", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)V", "GetShow_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Handler:Com.Unity3d.Scar.Adapter.Common.IScarAdapterInvoker, UnityAds")]
		void Show(Activity p0, string p1, string p2);
	}
}
