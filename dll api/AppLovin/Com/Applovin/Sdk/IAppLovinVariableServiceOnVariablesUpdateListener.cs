using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200009A RID: 154
	[Register("com/applovin/sdk/AppLovinVariableService$OnVariablesUpdateListener", "", "Com.Applovin.Sdk.IAppLovinVariableServiceOnVariablesUpdateListenerInvoker")]
	public interface IAppLovinVariableServiceOnVariablesUpdateListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600052C RID: 1324
		[Register("onVariablesUpdate", "(Landroid/os/Bundle;)V", "GetOnVariablesUpdate_Landroid_os_Bundle_Handler:Com.Applovin.Sdk.IAppLovinVariableServiceOnVariablesUpdateListenerInvoker, AppLovin")]
		void OnVariablesUpdate(Bundle p0);
	}
}
