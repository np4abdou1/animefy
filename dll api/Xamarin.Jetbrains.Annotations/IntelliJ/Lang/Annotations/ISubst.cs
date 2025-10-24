using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000059 RID: 89
	[Register("org/intellij/lang/annotations/Subst", "", "IntelliJ.Lang.Annotations.ISubstInvoker")]
	public interface ISubst : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060002E4 RID: 740
		[NullableContext(2)]
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:IntelliJ.Lang.Annotations.ISubstInvoker, Xamarin.Jetbrains.Annotations")]
		string Value();
	}
}
