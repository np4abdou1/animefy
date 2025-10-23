using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000039 RID: 57
	[Register("com/google/errorprone/annotations/SuppressPackageLocation", "", "Xamarin.Google.ErrorProne.Annotations.ISuppressPackageLocationInvoker")]
	public interface ISuppressPackageLocation : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
