using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Internal
{
	// Token: 0x02000014 RID: 20
	[Register("com/google/android/gms/common/internal/ICancelToken", "", "Android.Gms.Common.Internal.ICancelTokenInvoker")]
	public interface ICancelToken : IInterface, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600006F RID: 111
		[Register("cancel", "()V", "GetCancelHandler:Android.Gms.Common.Internal.ICancelTokenInvoker, Xamarin.GooglePlayServices.Basement")]
		void Cancel();
	}
}
