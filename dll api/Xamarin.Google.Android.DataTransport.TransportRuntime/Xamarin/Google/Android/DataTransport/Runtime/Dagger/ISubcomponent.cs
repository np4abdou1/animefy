using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B7 RID: 183
	[Register("com/google/android/datatransport/runtime/dagger/Subcomponent", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.ISubcomponentInvoker")]
	public interface ISubcomponent : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060006B7 RID: 1719
		[Register("modules", "()[Ljava/lang/Class;", "GetModulesHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.ISubcomponentInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Class[] Modules();
	}
}
