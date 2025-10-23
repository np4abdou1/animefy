using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000022 RID: 34
	[Register("com/google/android/datatransport/runtime/Destination", "", "Xamarin.Google.Android.DataTransport.Runtime.IDestinationInvoker")]
	public interface IDestination : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E7 RID: 231
		string Name { [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Xamarin.Google.Android.DataTransport.Runtime.IDestinationInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")] get; }

		// Token: 0x060000E8 RID: 232
		[Register("getExtras", "()[B", "GetGetExtrasHandler:Xamarin.Google.Android.DataTransport.Runtime.IDestinationInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		byte[] GetExtras();
	}
}
