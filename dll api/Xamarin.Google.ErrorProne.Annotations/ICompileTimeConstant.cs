using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000015 RID: 21
	[Register("com/google/errorprone/annotations/CompileTimeConstant", "", "Xamarin.Google.ErrorProne.Annotations.ICompileTimeConstantInvoker")]
	public interface ICompileTimeConstant : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
