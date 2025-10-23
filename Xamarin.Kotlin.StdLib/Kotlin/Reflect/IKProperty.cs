using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x02000124 RID: 292
	[Register("kotlin/reflect/KProperty", "", "Kotlin.Reflect.IKPropertyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IKProperty : IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000E82 RID: 3714
		[Nullable(1)]
		IKPropertyGetter Getter { [NullableContext(1)] [Register("getGetter", "()Lkotlin/reflect/KProperty$Getter;", "GetGetGetterHandler:Kotlin.Reflect.IKPropertyInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000E83 RID: 3715
		bool IsConst { [Register("isConst", "()Z", "GetIsConstHandler:Kotlin.Reflect.IKPropertyInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000E84 RID: 3716
		bool IsLateinit { [Register("isLateinit", "()Z", "GetIsLateinitHandler:Kotlin.Reflect.IKPropertyInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
