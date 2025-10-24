using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000028 RID: 40
	[Register("org/jetbrains/annotations/Nullable", "", "JetBrains.Annotations.INullableInvoker")]
	public interface INullable : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600012C RID: 300
		[NullableContext(2)]
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:JetBrains.Annotations.INullableInvoker, Xamarin.Jetbrains.Annotations")]
		string Value();
	}
}
