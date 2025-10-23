using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000081 RID: 129
	[Register("kotlin/SubclassOptInRequired", "", "Kotlin.ISubclassOptInRequiredInvoker")]
	public interface ISubclassOptInRequired : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000370 RID: 880
		[NullableContext(2)]
		[Register("markerClass", "()Ljava/lang/Class;", "GetMarkerClassHandler:Kotlin.ISubclassOptInRequiredInvoker, Xamarin.Kotlin.StdLib")]
		Class MarkerClass();
	}
}
