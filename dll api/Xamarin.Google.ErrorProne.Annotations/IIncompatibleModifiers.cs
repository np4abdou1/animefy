using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000023 RID: 35
	[Register("com/google/errorprone/annotations/IncompatibleModifiers", "", "Xamarin.Google.ErrorProne.Annotations.IIncompatibleModifiersInvoker")]
	public interface IIncompatibleModifiers : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000FF RID: 255
		[Register("modifier", "()[Lcom/google/errorprone/annotations/Modifier;", "GetModifierHandler:Xamarin.Google.ErrorProne.Annotations.IIncompatibleModifiersInvoker, Xamarin.Google.ErrorProne.Annotations")]
		Modifier[] Modifier();
	}
}
