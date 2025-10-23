using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000026 RID: 38
	[Register("org/jetbrains/annotations/NotNull", "", "JetBrains.Annotations.INotNullInvoker")]
	public interface INotNull : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600010F RID: 271
		[NullableContext(2)]
		[Register("exception", "()Ljava/lang/Class;", "GetExceptionHandler:JetBrains.Annotations.INotNullInvoker, Xamarin.Jetbrains.Annotations")]
		Class Exception();

		// Token: 0x06000110 RID: 272
		[NullableContext(2)]
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:JetBrains.Annotations.INotNullInvoker, Xamarin.Jetbrains.Annotations")]
		string Value();
	}
}
