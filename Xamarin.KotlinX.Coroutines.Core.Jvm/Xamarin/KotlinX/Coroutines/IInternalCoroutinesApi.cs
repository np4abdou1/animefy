using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000065 RID: 101
	[Register("kotlinx/coroutines/InternalCoroutinesApi", "", "Xamarin.KotlinX.Coroutines.IInternalCoroutinesApiInvoker")]
	public interface IInternalCoroutinesApi : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
