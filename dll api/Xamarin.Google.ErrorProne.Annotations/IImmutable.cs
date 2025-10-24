using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000021 RID: 33
	[Register("com/google/errorprone/annotations/Immutable", "", "Xamarin.Google.ErrorProne.Annotations.IImmutableInvoker")]
	public interface IImmutable : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000E6 RID: 230
		[Register("containerOf", "()[Ljava/lang/String;", "GetContainerOfHandler:Xamarin.Google.ErrorProne.Annotations.IImmutableInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string[] ContainerOf();
	}
}
