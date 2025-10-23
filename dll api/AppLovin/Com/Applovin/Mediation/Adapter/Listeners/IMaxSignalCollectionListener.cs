using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000124 RID: 292
	[Register("com/applovin/mediation/adapter/listeners/MaxSignalCollectionListener", "", "Com.Applovin.Mediation.Adapter.Listeners.IMaxSignalCollectionListenerInvoker")]
	public interface IMaxSignalCollectionListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000D0B RID: 3339
		[Register("onSignalCollected", "(Ljava/lang/String;)V", "GetOnSignalCollected_Ljava_lang_String_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxSignalCollectionListenerInvoker, AppLovin")]
		void OnSignalCollected(string p0);

		// Token: 0x06000D0C RID: 3340
		[Register("onSignalCollectionFailed", "(Ljava/lang/String;)V", "GetOnSignalCollectionFailed_Ljava_lang_String_Handler:Com.Applovin.Mediation.Adapter.Listeners.IMaxSignalCollectionListenerInvoker, AppLovin")]
		void OnSignalCollectionFailed(string p0);
	}
}
