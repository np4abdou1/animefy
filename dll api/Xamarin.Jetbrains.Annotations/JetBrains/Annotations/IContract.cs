using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000019 RID: 25
	[Register("org/jetbrains/annotations/Contract", "", "JetBrains.Annotations.IContractInvoker")]
	public interface IContract : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000076 RID: 118
		[NullableContext(2)]
		[Register("mutates", "()Ljava/lang/String;", "GetMutatesHandler:JetBrains.Annotations.IContractInvoker, Xamarin.Jetbrains.Annotations")]
		string Mutates();

		// Token: 0x06000077 RID: 119
		[Register("pure", "()Z", "GetPureHandler:JetBrains.Annotations.IContractInvoker, Xamarin.Jetbrains.Annotations")]
		bool Pure();

		// Token: 0x06000078 RID: 120
		[NullableContext(2)]
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:JetBrains.Annotations.IContractInvoker, Xamarin.Jetbrains.Annotations")]
		string Value();
	}
}
