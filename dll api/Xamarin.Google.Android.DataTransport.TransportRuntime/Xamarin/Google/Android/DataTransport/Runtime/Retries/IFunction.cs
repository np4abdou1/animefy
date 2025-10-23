using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Retries
{
	// Token: 0x02000061 RID: 97
	[Register("com/google/android/datatransport/runtime/retries/Function", "", "Xamarin.Google.Android.DataTransport.Runtime.Retries.IFunctionInvoker")]
	[JavaTypeParameters(new string[]
	{
		"TInput",
		"TResult",
		"TException extends java.lang.Throwable"
	})]
	public interface IFunction : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000335 RID: 821
		[Register("apply", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetApply_Ljava_lang_Object_Handler:Xamarin.Google.Android.DataTransport.Runtime.Retries.IFunctionInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Java.Lang.Object Apply(Java.Lang.Object p0);
	}
}
