using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Analytics.Interfaces
{
	// Token: 0x020001C7 RID: 455
	[Register("com/unity3d/services/analytics/interfaces/IAnalytics", "", "Com.Unity3d.Services.Analytics.Interfaces.IAnalyticsInvoker")]
	public interface IAnalytics : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001452 RID: 5202
		[Register("onAddExtras", "(Ljava/lang/String;)V", "GetOnAddExtras_Ljava_lang_String_Handler:Com.Unity3d.Services.Analytics.Interfaces.IAnalyticsInvoker, UnityAds")]
		void OnAddExtras(string p0);
	}
}
