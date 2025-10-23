using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001AC RID: 428
	[Register("kotlin/jvm/internal/SourceDebugExtension", "", "Kotlin.Jvm.Internal.ISourceDebugExtensionInvoker")]
	public interface ISourceDebugExtension : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600151B RID: 5403
		[Register("value", "()[Ljava/lang/String;", "GetValueHandler:Kotlin.Jvm.Internal.ISourceDebugExtensionInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		string[] Value();
	}
}
