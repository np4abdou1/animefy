using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x0200016A RID: 362
	[Register("kotlin/jvm/PurelyImplements", "", "Kotlin.Jvm.IPurelyImplementsInvoker")]
	public interface IPurelyImplements : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060012AD RID: 4781
		[NullableContext(2)]
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:Kotlin.Jvm.IPurelyImplementsInvoker, Xamarin.Kotlin.StdLib")]
		string Value();
	}
}
