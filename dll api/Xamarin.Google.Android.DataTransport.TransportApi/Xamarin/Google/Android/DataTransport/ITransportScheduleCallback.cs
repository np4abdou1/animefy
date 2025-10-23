using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x02000013 RID: 19
	[Register("com/google/android/datatransport/TransportScheduleCallback", "", "Xamarin.Google.Android.DataTransport.ITransportScheduleCallbackInvoker")]
	public interface ITransportScheduleCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000075 RID: 117
		[Register("onSchedule", "(Ljava/lang/Exception;)V", "GetOnSchedule_Ljava_lang_Exception_Handler:Xamarin.Google.Android.DataTransport.ITransportScheduleCallbackInvoker, Xamarin.Google.Android.DataTransport.TransportApi")]
		void OnSchedule(Java.Lang.Exception p0);
	}
}
