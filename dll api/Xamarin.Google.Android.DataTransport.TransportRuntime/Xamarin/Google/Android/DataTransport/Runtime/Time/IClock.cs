using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x02000031 RID: 49
	[Register("com/google/android/datatransport/runtime/time/Clock", "", "Xamarin.Google.Android.DataTransport.Runtime.Time.IClockInvoker")]
	public interface IClock : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000186 RID: 390
		long Time { [Register("getTime", "()J", "GetGetTimeHandler:Xamarin.Google.Android.DataTransport.Runtime.Time.IClockInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")] get; }
	}
}
