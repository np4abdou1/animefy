using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A3 RID: 163
	[Register("com/unity3d/services/core/request/IWebRequestListener", "", "Com.Unity3d.Services.Core.Request.IWebRequestListenerInvoker")]
	public interface IWebRequestListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005E2 RID: 1506
		[Register("onComplete", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)V", "GetOnComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_Handler:Com.Unity3d.Services.Core.Request.IWebRequestListenerInvoker, UnityAds")]
		void OnComplete(string p0, string p1, int p2, IDictionary<string, IList<string>> p3);

		// Token: 0x060005E3 RID: 1507
		[Register("onFailed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnFailed_Ljava_lang_String_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Request.IWebRequestListenerInvoker, UnityAds")]
		void OnFailed(string p0, string p1);
	}
}
