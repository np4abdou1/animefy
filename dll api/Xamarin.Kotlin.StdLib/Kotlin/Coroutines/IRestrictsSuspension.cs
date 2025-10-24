using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Coroutines
{
	// Token: 0x02000261 RID: 609
	[Register("kotlin/coroutines/RestrictsSuspension", "", "Kotlin.Coroutines.IRestrictsSuspensionInvoker")]
	public interface IRestrictsSuspension : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
