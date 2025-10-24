using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Annotation
{
	// Token: 0x0200028E RID: 654
	[Register("kotlin/annotation/Target", "", "Kotlin.Annotation.ITargetInvoker")]
	public interface ITarget : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001D86 RID: 7558
		[Register("allowedTargets", "()[Lkotlin/annotation/AnnotationTarget;", "GetAllowedTargetsHandler:Kotlin.Annotation.ITargetInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		AnnotationTarget[] AllowedTargets();
	}
}
