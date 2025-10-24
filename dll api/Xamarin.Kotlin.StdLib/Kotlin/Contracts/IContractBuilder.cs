using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x02000273 RID: 627
	[NullableContext(1)]
	[Register("kotlin/contracts/ContractBuilder", "", "Kotlin.Contracts.IContractBuilderInvoker")]
	public interface IContractBuilder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001C5F RID: 7263
		[Register("callsInPlace", "(Lkotlin/Function;Lkotlin/contracts/InvocationKind;)Lkotlin/contracts/CallsInPlace;", "GetCallsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_Handler:Kotlin.Contracts.IContractBuilderInvoker, Xamarin.Kotlin.StdLib")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		ICallsInPlace CallsInPlace(IFunction lambda, InvocationKind kind);

		// Token: 0x06001C60 RID: 7264
		[Register("returns", "()Lkotlin/contracts/Returns;", "GetReturnsHandler:Kotlin.Contracts.IContractBuilderInvoker, Xamarin.Kotlin.StdLib")]
		IReturns Returns();

		// Token: 0x06001C61 RID: 7265
		[Register("returns", "(Ljava/lang/Object;)Lkotlin/contracts/Returns;", "GetReturns_Ljava_lang_Object_Handler:Kotlin.Contracts.IContractBuilderInvoker, Xamarin.Kotlin.StdLib")]
		IReturns Returns([Nullable(2)] Java.Lang.Object value);

		// Token: 0x06001C62 RID: 7266
		[Register("returnsNotNull", "()Lkotlin/contracts/ReturnsNotNull;", "GetReturnsNotNullHandler:Kotlin.Contracts.IContractBuilderInvoker, Xamarin.Kotlin.StdLib")]
		IReturnsNotNull ReturnsNotNull();
	}
}
