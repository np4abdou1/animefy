using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000031 RID: 49
	[Register("com/google/errorprone/annotations/NoAllocation", "", "Xamarin.Google.ErrorProne.Annotations.INoAllocationInvoker")]
	public interface INoAllocation : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
