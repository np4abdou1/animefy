using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200005D RID: 93
	[Register("kotlinx/coroutines/DelicateCoroutinesApi", "", "Xamarin.KotlinX.Coroutines.IDelicateCoroutinesApiInvoker")]
	public interface IDelicateCoroutinesApi : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
