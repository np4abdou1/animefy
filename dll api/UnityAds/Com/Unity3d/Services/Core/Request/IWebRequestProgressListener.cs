using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A7 RID: 167
	[Register("com/unity3d/services/core/request/IWebRequestProgressListener", "", "Com.Unity3d.Services.Core.Request.IWebRequestProgressListenerInvoker")]
	public interface IWebRequestProgressListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005FC RID: 1532
		[Register("onRequestProgress", "(Ljava/lang/String;JJ)V", "GetOnRequestProgress_Ljava_lang_String_JJHandler:Com.Unity3d.Services.Core.Request.IWebRequestProgressListenerInvoker, UnityAds")]
		void OnRequestProgress(string p0, long p1, long p2);

		// Token: 0x060005FD RID: 1533
		[Register("onRequestStart", "(Ljava/lang/String;JILjava/util/Map;)V", "GetOnRequestStart_Ljava_lang_String_JILjava_util_Map_Handler:Com.Unity3d.Services.Core.Request.IWebRequestProgressListenerInvoker, UnityAds")]
		void OnRequestStart(string p0, long p1, int p2, IDictionary<string, IList<string>> p3);
	}
}
