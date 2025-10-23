using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x02000011 RID: 17
	[Register("com/google/android/datatransport/TransportFactory", "", "Xamarin.Google.Android.DataTransport.ITransportFactoryInvoker")]
	public interface ITransportFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000064 RID: 100
		[Register("getTransport", "(Ljava/lang/String;Ljava/lang/Class;Lcom/google/android/datatransport/Encoding;Lcom/google/android/datatransport/Transformer;)Lcom/google/android/datatransport/Transport;", "GetGetTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_Handler:Xamarin.Google.Android.DataTransport.ITransportFactoryInvoker, Xamarin.Google.Android.DataTransport.TransportApi")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		ITransport GetTransport(string p0, Class p1, Encoding p2, ITransformer p3);

		// Token: 0x06000065 RID: 101
		[Obsolete("deprecated")]
		[Register("getTransport", "(Ljava/lang/String;Ljava/lang/Class;Lcom/google/android/datatransport/Transformer;)Lcom/google/android/datatransport/Transport;", "GetGetTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_Handler:Xamarin.Google.Android.DataTransport.ITransportFactoryInvoker, Xamarin.Google.Android.DataTransport.TransportApi")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		ITransport GetTransport(string p0, Class p1, ITransformer p2);
	}
}
