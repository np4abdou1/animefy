using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x02000164 RID: 356
	[Register("kotlin/jvm/JvmSuppressWildcards", "", "Kotlin.Jvm.IJvmSuppressWildcardsInvoker")]
	public interface IJvmSuppressWildcards : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600126A RID: 4714
		[Register("suppress", "()Z", "GetSuppressHandler:Kotlin.Jvm.IJvmSuppressWildcardsInvoker, Xamarin.Kotlin.StdLib")]
		bool Suppress();
	}
}
