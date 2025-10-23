using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000093 RID: 147
	[Register("com/applovin/sdk/AppLovinUserSegment", "", "Com.Applovin.Sdk.IAppLovinUserSegmentInvoker")]
	public interface IAppLovinUserSegment : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004FA RID: 1274
		// (set) Token: 0x060004FB RID: 1275
		string Name { [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Applovin.Sdk.IAppLovinUserSegmentInvoker, AppLovin")] get; [Register("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinUserSegmentInvoker, AppLovin")] set; }
	}
}
