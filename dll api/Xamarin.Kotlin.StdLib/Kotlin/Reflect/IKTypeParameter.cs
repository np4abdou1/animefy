using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x02000135 RID: 309
	[NullableContext(1)]
	[Register("kotlin/reflect/KTypeParameter", "", "Kotlin.Reflect.IKTypeParameterInvoker")]
	public interface IKTypeParameter : IKClassifier, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600105C RID: 4188
		bool IsReified { [Register("isReified", "()Z", "GetIsReifiedHandler:Kotlin.Reflect.IKTypeParameterInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600105D RID: 4189
		string Name { [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Kotlin.Reflect.IKTypeParameterInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600105E RID: 4190
		IList<IKType> UpperBounds { [Register("getUpperBounds", "()Ljava/util/List;", "GetGetUpperBoundsHandler:Kotlin.Reflect.IKTypeParameterInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600105F RID: 4191
		KVariance Variance { [Register("getVariance", "()Lkotlin/reflect/KVariance;", "GetGetVarianceHandler:Kotlin.Reflect.IKTypeParameterInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
