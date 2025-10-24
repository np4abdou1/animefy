using System;
using Android.Gms.Common.Api.Internal;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000062 RID: 98
	[Register("com/google/android/gms/common/api/HasApiKey", "", "Android.Gms.Common.Apis.IHasApiKeyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"O extends com.google.android.gms.common.api.Api.ApiOptions"
	})]
	public interface IHasApiKey : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000459 RID: 1113
		ApiKey ApiKey { [Register("getApiKey", "()Lcom/google/android/gms/common/api/internal/ApiKey;", "GetGetApiKeyHandler:Android.Gms.Common.Apis.IHasApiKeyInvoker, Xamarin.GooglePlayServices.Base")] get; }
	}
}
