using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x02000170 RID: 368
	[Register("kotlin/jvm/Throws", "", "Kotlin.Jvm.IThrowsInvoker")]
	public interface IThrows : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060012F0 RID: 4848
		[Register("exceptionClasses", "()[Ljava/lang/Class;", "GetExceptionClassesHandler:Kotlin.Jvm.IThrowsInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		Class[] ExceptionClasses();
	}
}
