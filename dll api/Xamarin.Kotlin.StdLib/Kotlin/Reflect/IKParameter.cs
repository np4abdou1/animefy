using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x0200011D RID: 285
	[Register("kotlin/reflect/KParameter", "", "Kotlin.Reflect.IKParameterInvoker")]
	public interface IKParameter : IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000E0F RID: 3599
		int Index { [Register("getIndex", "()I", "GetGetIndexHandler:Kotlin.Reflect.IKParameterInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000E10 RID: 3600
		bool IsOptional { [Register("isOptional", "()Z", "GetIsOptionalHandler:Kotlin.Reflect.IKParameterInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000E11 RID: 3601
		bool IsVararg { [Register("isVararg", "()Z", "GetIsVarargHandler:Kotlin.Reflect.IKParameterInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000E12 RID: 3602
		[Nullable(1)]
		KParameterKind Kind { [NullableContext(1)] [Register("getKind", "()Lkotlin/reflect/KParameter$Kind;", "GetGetKindHandler:Kotlin.Reflect.IKParameterInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000E13 RID: 3603
		[Nullable(2)]
		string Name { [NullableContext(2)] [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Kotlin.Reflect.IKParameterInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000E14 RID: 3604
		[Nullable(1)]
		IKType Type { [NullableContext(1)] [Register("getType", "()Lkotlin/reflect/KType;", "GetGetTypeHandler:Kotlin.Reflect.IKParameterInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
