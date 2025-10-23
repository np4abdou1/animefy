using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000061 RID: 97
	[Register("kotlinx/coroutines/ExperimentalCoroutinesApi", "", "Xamarin.KotlinX.Coroutines.IExperimentalCoroutinesApiInvoker")]
	public interface IExperimentalCoroutinesApi : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
