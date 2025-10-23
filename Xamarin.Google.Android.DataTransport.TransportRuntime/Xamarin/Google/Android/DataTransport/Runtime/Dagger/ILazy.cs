using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A7 RID: 167
	[Register("com/google/android/datatransport/runtime/dagger/Lazy", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.ILazyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ILazy : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000613 RID: 1555
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.ILazyInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Java.Lang.Object Get();
	}
}
