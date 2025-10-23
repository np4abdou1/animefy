using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000083 RID: 131
	[Register("kotlin/Suppress", "", "Kotlin.ISuppressInvoker")]
	public interface ISuppress : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000389 RID: 905
		[Register("names", "()[Ljava/lang/String;", "GetNamesHandler:Kotlin.ISuppressInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		string[] Names();
	}
}
