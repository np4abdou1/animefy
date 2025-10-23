using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000033 RID: 51
	[Register("com/google/errorprone/annotations/OverridingMethodsMustInvokeSuper", "", "Xamarin.Google.ErrorProne.Annotations.IOverridingMethodsMustInvokeSuperInvoker")]
	public interface IOverridingMethodsMustInvokeSuper : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
