using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Annotation
{
	// Token: 0x0200028C RID: 652
	[Register("kotlin/annotation/Retention", "", "Kotlin.Annotation.IRetentionInvoker")]
	public interface IRetention : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001D6D RID: 7533
		[NullableContext(2)]
		[Register("value", "()Lkotlin/annotation/AnnotationRetention;", "GetValueHandler:Kotlin.Annotation.IRetentionInvoker, Xamarin.Kotlin.StdLib")]
		AnnotationRetention Value();
	}
}
