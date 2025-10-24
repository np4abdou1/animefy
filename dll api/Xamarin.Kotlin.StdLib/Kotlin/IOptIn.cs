using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000070 RID: 112
	[Register("kotlin/OptIn", "", "Kotlin.IOptInInvoker")]
	public interface IOptIn : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060002A1 RID: 673
		[Register("markerClass", "()[Ljava/lang/Class;", "GetMarkerClassHandler:Kotlin.IOptInInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		Class[] MarkerClass();
	}
}
