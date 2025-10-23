using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000059 RID: 89
	[Register("kotlin/Deprecated", "", "Kotlin.IDeprecatedInvoker")]
	public interface IDeprecated : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600018C RID: 396
		[NullableContext(2)]
		[Register("level", "()Lkotlin/DeprecationLevel;", "GetLevelHandler:Kotlin.IDeprecatedInvoker, Xamarin.Kotlin.StdLib")]
		DeprecationLevel Level();

		// Token: 0x0600018D RID: 397
		[NullableContext(2)]
		[Register("message", "()Ljava/lang/String;", "GetMessageHandler:Kotlin.IDeprecatedInvoker, Xamarin.Kotlin.StdLib")]
		string Message();

		// Token: 0x0600018E RID: 398
		[NullableContext(2)]
		[Register("replaceWith", "()Lkotlin/ReplaceWith;", "GetReplaceWithHandler:Kotlin.IDeprecatedInvoker, Xamarin.Kotlin.StdLib")]
		IReplaceWith ReplaceWith();
	}
}
