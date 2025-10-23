using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000076 RID: 118
	[Register("kotlin/ParameterName", "", "Kotlin.IParameterNameInvoker")]
	public interface IParameterName : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060002E4 RID: 740
		[NullableContext(2)]
		[Register("name", "()Ljava/lang/String;", "GetNameHandler:Kotlin.IParameterNameInvoker, Xamarin.Kotlin.StdLib")]
		string Name();
	}
}
