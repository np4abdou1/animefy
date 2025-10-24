using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000DB RID: 219
	[Register("com/unity3d/services/core/misc/IJsonStorageReader", "", "Com.Unity3d.Services.Core.Misc.IJsonStorageReaderInvoker")]
	public interface IJsonStorageReader : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600088E RID: 2190
		JSONObject Data { [Register("getData", "()Lorg/json/JSONObject;", "GetGetDataHandler:Com.Unity3d.Services.Core.Misc.IJsonStorageReaderInvoker, UnityAds")] get; }

		// Token: 0x0600088F RID: 2191
		[Register("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler:Com.Unity3d.Services.Core.Misc.IJsonStorageReaderInvoker, UnityAds")]
		Java.Lang.Object Get(string p0);
	}
}
