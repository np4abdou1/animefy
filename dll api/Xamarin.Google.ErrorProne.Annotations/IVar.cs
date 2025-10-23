using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200003D RID: 61
	[Register("com/google/errorprone/annotations/Var", "", "Xamarin.Google.ErrorProne.Annotations.IVarInvoker")]
	public interface IVar : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
