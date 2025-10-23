using System;
using Android.Runtime;
using Java.Interop;
using Org.Json;

namespace Com.Unity3d.Services.Store.Gpbl
{
	// Token: 0x0200004A RID: 74
	[Register("com/unity3d/services/store/gpbl/IBillingResponse", "", "Com.Unity3d.Services.Store.Gpbl.IBillingResponseInvoker")]
	public interface IBillingResponse : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000191 RID: 401
		JSONObject OriginalJson { [Register("getOriginalJson", "()Lorg/json/JSONObject;", "GetGetOriginalJsonHandler:Com.Unity3d.Services.Store.Gpbl.IBillingResponseInvoker, UnityAds")] get; }
	}
}
