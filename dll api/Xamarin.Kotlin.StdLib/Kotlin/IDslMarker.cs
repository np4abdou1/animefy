using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x0200005D RID: 93
	[Register("kotlin/DslMarker", "", "Kotlin.IDslMarkerInvoker")]
	public interface IDslMarker : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
