using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Retries
{
	// Token: 0x02000063 RID: 99
	[Register("com/google/android/datatransport/runtime/retries/RetryStrategy", "", "Xamarin.Google.Android.DataTransport.Runtime.Retries.IRetryStrategyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"TInput",
		"TResult"
	})]
	public interface IRetryStrategy : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000342 RID: 834
		[Register("shouldRetry", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetShouldRetry_Ljava_lang_Object_Ljava_lang_Object_Handler:Xamarin.Google.Android.DataTransport.Runtime.Retries.IRetryStrategyInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Java.Lang.Object ShouldRetry(Java.Lang.Object p0, Java.Lang.Object p1);
	}
}
