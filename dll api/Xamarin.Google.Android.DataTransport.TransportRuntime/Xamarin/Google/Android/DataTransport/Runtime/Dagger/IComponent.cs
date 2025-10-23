using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A5 RID: 165
	[Register("com/google/android/datatransport/runtime/dagger/Component", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IComponentInvoker")]
	public interface IComponent : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005F6 RID: 1526
		[Register("dependencies", "()[Ljava/lang/Class;", "GetDependenciesHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.IComponentInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Class[] Dependencies();

		// Token: 0x060005F7 RID: 1527
		[Register("modules", "()[Ljava/lang/Class;", "GetModulesHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.IComponentInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Class[] Modules();
	}
}
