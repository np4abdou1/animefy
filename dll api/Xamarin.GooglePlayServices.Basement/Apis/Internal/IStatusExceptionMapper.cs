using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis.Internal
{
	// Token: 0x02000024 RID: 36
	[Register("com/google/android/gms/common/api/internal/StatusExceptionMapper", "", "Android.Gms.Common.Apis.Internal.IStatusExceptionMapperInvoker")]
	public interface IStatusExceptionMapper : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000115 RID: 277
		[Register("getException", "(Lcom/google/android/gms/common/api/Status;)Ljava/lang/Exception;", "GetGetException_Lcom_google_android_gms_common_api_Status_Handler:Android.Gms.Common.Apis.Internal.IStatusExceptionMapperInvoker, Xamarin.GooglePlayServices.Basement")]
		Java.Lang.Exception GetException(Statuses p0);
	}
}
