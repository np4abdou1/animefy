using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x02000133 RID: 307
	[Register("kotlin/reflect/KType", "", "Kotlin.Reflect.IKTypeInvoker")]
	public interface IKType : IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001044 RID: 4164
		[Nullable(1)]
		IList<KTypeProjection> Arguments { [NullableContext(1)] [Register("getArguments", "()Ljava/util/List;", "GetGetArgumentsHandler:Kotlin.Reflect.IKTypeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001045 RID: 4165
		[Nullable(2)]
		IKClassifier Classifier { [NullableContext(2)] [Register("getClassifier", "()Lkotlin/reflect/KClassifier;", "GetGetClassifierHandler:Kotlin.Reflect.IKTypeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001046 RID: 4166
		bool IsMarkedNullable { [Register("isMarkedNullable", "()Z", "GetIsMarkedNullableHandler:Kotlin.Reflect.IKTypeInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
