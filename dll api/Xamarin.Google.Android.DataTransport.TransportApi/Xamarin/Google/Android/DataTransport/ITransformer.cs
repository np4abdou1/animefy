using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x0200000D RID: 13
	[Register("com/google/android/datatransport/Transformer", "", "Xamarin.Google.Android.DataTransport.ITransformerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"U"
	})]
	public interface ITransformer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000046 RID: 70
		[Register("apply", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetApply_Ljava_lang_Object_Handler:Xamarin.Google.Android.DataTransport.ITransformerInvoker, Xamarin.Google.Android.DataTransport.TransportApi")]
		Java.Lang.Object Apply(Java.Lang.Object p0);
	}
}
