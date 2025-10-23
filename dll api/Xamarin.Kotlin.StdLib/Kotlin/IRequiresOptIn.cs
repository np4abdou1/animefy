using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x0200007D RID: 125
	[Register("kotlin/RequiresOptIn", "", "Kotlin.IRequiresOptInInvoker")]
	public interface IRequiresOptIn : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600033A RID: 826
		[NullableContext(2)]
		[Register("level", "()Lkotlin/RequiresOptIn$Level;", "GetLevelHandler:Kotlin.IRequiresOptInInvoker, Xamarin.Kotlin.StdLib")]
		RequiresOptInLevel Level();

		// Token: 0x0600033B RID: 827
		[NullableContext(2)]
		[Register("message", "()Ljava/lang/String;", "GetMessageHandler:Kotlin.IRequiresOptInInvoker, Xamarin.Kotlin.StdLib")]
		string Message();
	}
}
