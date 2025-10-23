using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200009E RID: 158
	[Register("com/applovin/sdk/AppLovinVariableService", "", "Com.Applovin.Sdk.IAppLovinVariableServiceInvoker")]
	public interface IAppLovinVariableService : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600053E RID: 1342
		[Register("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinVariableServiceInvoker, AppLovin")]
		bool GetBoolean(string p0);

		// Token: 0x0600053F RID: 1343
		[Register("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler:Com.Applovin.Sdk.IAppLovinVariableServiceInvoker, AppLovin")]
		bool GetBoolean(string p0, bool p1);

		// Token: 0x06000540 RID: 1344
		[Register("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinVariableServiceInvoker, AppLovin")]
		string GetString(string p0);

		// Token: 0x06000541 RID: 1345
		[Register("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinVariableServiceInvoker, AppLovin")]
		string GetString(string p0, string p1);

		// Token: 0x06000542 RID: 1346
		[Register("loadVariables", "()V", "GetLoadVariablesHandler:Com.Applovin.Sdk.IAppLovinVariableServiceInvoker, AppLovin")]
		void LoadVariables();

		// Token: 0x06000543 RID: 1347
		[Register("setOnVariablesUpdateListener", "(Lcom/applovin/sdk/AppLovinVariableService$OnVariablesUpdateListener;)V", "GetSetOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_Handler:Com.Applovin.Sdk.IAppLovinVariableServiceInvoker, AppLovin")]
		void SetOnVariablesUpdateListener(IAppLovinVariableServiceOnVariablesUpdateListener p0);
	}
}
