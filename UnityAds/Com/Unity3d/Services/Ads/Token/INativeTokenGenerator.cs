using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001D9 RID: 473
	[Register("com/unity3d/services/ads/token/INativeTokenGenerator", "", "Com.Unity3d.Services.Ads.Token.INativeTokenGeneratorInvoker")]
	public interface INativeTokenGenerator : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060015B9 RID: 5561
		[Register("generateToken", "(Lcom/unity3d/services/ads/token/INativeTokenGeneratorListener;)V", "GetGenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_Handler:Com.Unity3d.Services.Ads.Token.INativeTokenGeneratorInvoker, UnityAds")]
		void GenerateToken(INativeTokenGeneratorListener p0);
	}
}
