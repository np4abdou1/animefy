using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200004C RID: 76
	[Register("com/adcolony/sdk/AdColonyCustomMessageListener", "", "Com.Adcolony.Sdk.IAdColonyCustomMessageListenerInvoker")]
	public interface IAdColonyCustomMessageListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000405 RID: 1029
		[Register("onAdColonyCustomMessage", "(Lcom/adcolony/sdk/AdColonyCustomMessage;)V", "GetOnAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_Handler:Com.Adcolony.Sdk.IAdColonyCustomMessageListenerInvoker, AdColony")]
		void OnAdColonyCustomMessage(AdColonyCustomMessage p0);
	}
}
