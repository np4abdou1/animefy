using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x02000008 RID: 8
	[Register("javax/inject/Named", "", "JavaX.Inject.INamedInvoker")]
	public interface INamed : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000023 RID: 35
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:JavaX.Inject.INamedInvoker, Xamarin.JavaX.Inject")]
		string Value();
	}
}
