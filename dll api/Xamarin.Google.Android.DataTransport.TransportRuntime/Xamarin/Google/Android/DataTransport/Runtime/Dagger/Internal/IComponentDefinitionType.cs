using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E1 RID: 225
	[Register("com/google/android/datatransport/runtime/dagger/internal/ComponentDefinitionType", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.IComponentDefinitionTypeInvoker")]
	public interface IComponentDefinitionType : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060007F6 RID: 2038
		[Register("value", "()Ljava/lang/Class;", "GetValueHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.IComponentDefinitionTypeInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Class Value();
	}
}
