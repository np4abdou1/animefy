using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000024 RID: 36
	[Register("com/google/android/datatransport/runtime/EncodedDestination", "", "Xamarin.Google.Android.DataTransport.Runtime.IEncodedDestinationInvoker")]
	public interface IEncodedDestination : IDestination, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F8 RID: 248
		ICollection<Encoding> SupportedEncodings { [Register("getSupportedEncodings", "()Ljava/util/Set;", "GetGetSupportedEncodingsHandler:Xamarin.Google.Android.DataTransport.Runtime.IEncodedDestinationInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")] get; }
	}
}
