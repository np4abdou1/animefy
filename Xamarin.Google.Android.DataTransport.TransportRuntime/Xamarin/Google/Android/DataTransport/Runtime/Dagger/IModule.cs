using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000AD RID: 173
	[Register("com/google/android/datatransport/runtime/dagger/Module", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IModuleInvoker")]
	public interface IModule : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000646 RID: 1606
		[Register("includes", "()[Ljava/lang/Class;", "GetIncludesHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.IModuleInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Class[] Includes();

		// Token: 0x06000647 RID: 1607
		[Register("subcomponents", "()[Ljava/lang/Class;", "GetSubcomponentsHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.IModuleInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Class[] Subcomponents();
	}
}
