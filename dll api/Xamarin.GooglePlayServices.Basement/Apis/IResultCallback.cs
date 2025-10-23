using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200001C RID: 28
	[Register("com/google/android/gms/common/api/ResultCallback", "", "Android.Gms.Common.Apis.IResultCallbackInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R extends com.google.android.gms.common.api.Result"
	})]
	public interface IResultCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000AB RID: 171
		[Register("onResult", "(Lcom/google/android/gms/common/api/Result;)V", "GetOnResult_Lcom_google_android_gms_common_api_Result_Handler:Android.Gms.Common.Apis.IResultCallbackInvoker, Xamarin.GooglePlayServices.Basement")]
		void OnResult(Java.Lang.Object result);
	}
}
