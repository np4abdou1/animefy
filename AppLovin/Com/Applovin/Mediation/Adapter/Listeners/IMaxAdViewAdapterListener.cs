using System;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x0200011A RID: 282
	[Register("com/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener", "", "Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker")]
	public interface IMaxAdViewAdapterListener : IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C0E RID: 3086
		[Register("onAdViewAdClicked", "()V", "GetOnAdViewAdClickedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdClicked();

		// Token: 0x06000C0F RID: 3087
		[Register("onAdViewAdClicked", "(Landroid/os/Bundle;)V", "GetOnAdViewAdClicked_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdClicked(Bundle p0);

		// Token: 0x06000C10 RID: 3088
		[Register("onAdViewAdCollapsed", "()V", "GetOnAdViewAdCollapsedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdCollapsed();

		// Token: 0x06000C11 RID: 3089
		[Register("onAdViewAdDisplayFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdDisplayFailed(MaxAdapterError p0);

		// Token: 0x06000C12 RID: 3090
		[Register("onAdViewAdDisplayed", "()V", "GetOnAdViewAdDisplayedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdDisplayed();

		// Token: 0x06000C13 RID: 3091
		[Register("onAdViewAdDisplayed", "(Landroid/os/Bundle;)V", "GetOnAdViewAdDisplayed_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdDisplayed(Bundle p0);

		// Token: 0x06000C14 RID: 3092
		[Register("onAdViewAdExpanded", "()V", "GetOnAdViewAdExpandedHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdExpanded();

		// Token: 0x06000C15 RID: 3093
		[Register("onAdViewAdHidden", "()V", "GetOnAdViewAdHiddenHandler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdHidden();

		// Token: 0x06000C16 RID: 3094
		[Register("onAdViewAdHidden", "(Landroid/os/Bundle;)V", "GetOnAdViewAdHidden_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdHidden(Bundle p0);

		// Token: 0x06000C17 RID: 3095
		[Register("onAdViewAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V", "GetOnAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdLoadFailed(MaxAdapterError p0);

		// Token: 0x06000C18 RID: 3096
		[Register("onAdViewAdLoaded", "(Landroid/view/View;)V", "GetOnAdViewAdLoaded_Landroid_view_View_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdLoaded(View p0);

		// Token: 0x06000C19 RID: 3097
		[Register("onAdViewAdLoaded", "(Landroid/view/View;Landroid/os/Bundle;)V", "GetOnAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxAdViewAdapterListenerInvoker, AppLovin")]
		void OnAdViewAdLoaded(View p0, Bundle p1);
	}
}
