using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000035 RID: 53
	[Register("com/google/errorprone/annotations/RequiredModifiers", "", "Xamarin.Google.ErrorProne.Annotations.IRequiredModifiersInvoker")]
	public interface IRequiredModifiers : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060001B4 RID: 436
		[Register("modifier", "()[Lcom/google/errorprone/annotations/Modifier;", "GetModifierHandler:Xamarin.Google.ErrorProne.Annotations.IRequiredModifiersInvoker, Xamarin.Google.ErrorProne.Annotations")]
		Modifier[] Modifier();
	}
}
