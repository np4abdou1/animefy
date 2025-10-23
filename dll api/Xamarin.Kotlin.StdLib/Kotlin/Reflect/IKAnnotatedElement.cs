using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Reflect
{
	// Token: 0x020000FC RID: 252
	[Register("kotlin/reflect/KAnnotatedElement", "", "Kotlin.Reflect.IKAnnotatedElementInvoker")]
	public interface IKAnnotatedElement : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000AE6 RID: 2790
		[Nullable(1)]
		IList<IAnnotation> Annotations { [NullableContext(1)] [Register("getAnnotations", "()Ljava/util/List;", "GetGetAnnotationsHandler:Kotlin.Reflect.IKAnnotatedElementInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
