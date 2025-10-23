using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x0200007A RID: 122
	[Register("kotlin/ReplaceWith", "", "Kotlin.IReplaceWithInvoker")]
	public interface IReplaceWith : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000312 RID: 786
		[NullableContext(2)]
		[Register("expression", "()Ljava/lang/String;", "GetExpressionHandler:Kotlin.IReplaceWithInvoker, Xamarin.Kotlin.StdLib")]
		string Expression();

		// Token: 0x06000313 RID: 787
		[Register("imports", "()[Ljava/lang/String;", "GetImportsHandler:Kotlin.IReplaceWithInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		string[] Imports();
	}
}
