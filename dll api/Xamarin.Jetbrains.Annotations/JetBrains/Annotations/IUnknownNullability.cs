using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000030 RID: 48
	[Register("org/jetbrains/annotations/UnknownNullability", "", "JetBrains.Annotations.IUnknownNullabilityInvoker")]
	public interface IUnknownNullability : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000190 RID: 400
		[NullableContext(2)]
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:JetBrains.Annotations.IUnknownNullabilityInvoker, Xamarin.Jetbrains.Annotations")]
		string Value();
	}
}
