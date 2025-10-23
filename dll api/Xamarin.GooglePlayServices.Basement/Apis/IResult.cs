using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200001A RID: 26
	[Register("com/google/android/gms/common/api/Result", "", "Android.Gms.Common.Apis.IResultInvoker")]
	public interface IResult : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009E RID: 158
		Statuses Status { [Register("getStatus", "()Lcom/google/android/gms/common/api/Status;", "GetGetStatusHandler:Android.Gms.Common.Apis.IResultInvoker, Xamarin.GooglePlayServices.Basement")] get; }
	}
}
