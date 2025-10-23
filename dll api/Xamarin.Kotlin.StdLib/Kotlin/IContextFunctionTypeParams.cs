using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000057 RID: 87
	[Register("kotlin/ContextFunctionTypeParams", "", "Kotlin.IContextFunctionTypeParamsInvoker")]
	public interface IContextFunctionTypeParams : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000173 RID: 371
		[Register("count", "()I", "GetCountHandler:Kotlin.IContextFunctionTypeParamsInvoker, Xamarin.Kotlin.StdLib")]
		int Count();
	}
}
