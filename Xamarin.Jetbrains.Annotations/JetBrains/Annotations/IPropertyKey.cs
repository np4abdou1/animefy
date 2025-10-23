using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x0200002A RID: 42
	[Register("org/jetbrains/annotations/PropertyKey", "", "JetBrains.Annotations.IPropertyKeyInvoker")]
	public interface IPropertyKey : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000145 RID: 325
		[NullableContext(2)]
		[Register("resourceBundle", "()Ljava/lang/String;", "GetResourceBundleHandler:JetBrains.Annotations.IPropertyKeyInvoker, Xamarin.Jetbrains.Annotations")]
		string ResourceBundle();
	}
}
