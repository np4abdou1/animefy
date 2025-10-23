using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x02000091 RID: 145
	[NullableContext(1)]
	[Register("kotlinx/coroutines/selects/SelectBuilder", "", "Xamarin.KotlinX.Coroutines.Selects.ISelectBuilderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface ISelectBuilder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000663 RID: 1635
		[Register("invoke", "(Lkotlinx/coroutines/selects/SelectClause0;Lkotlin/jvm/functions/Function1;)V", "GetInvoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_Handler:Xamarin.KotlinX.Coroutines.Selects.ISelectBuilderInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void Invoke(ISelectClause0 p0, IFunction1 block);

		// Token: 0x06000664 RID: 1636
		[Register("invoke", "(Lkotlinx/coroutines/selects/SelectClause1;Lkotlin/jvm/functions/Function2;)V", "GetInvoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_Handler:Xamarin.KotlinX.Coroutines.Selects.ISelectBuilderInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[JavaTypeParameters(new string[]
		{
			"Q"
		})]
		void Invoke(ISelectClause1 p0, IFunction2 block);

		// Token: 0x06000665 RID: 1637
		[Register("invoke", "(Lkotlinx/coroutines/selects/SelectClause2;Lkotlin/jvm/functions/Function2;)V", "GetInvoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_Handler:Xamarin.KotlinX.Coroutines.Selects.ISelectBuilderInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[JavaTypeParameters(new string[]
		{
			"P",
			"Q"
		})]
		void Invoke(ISelectClause2 p0, IFunction2 block);

		// Token: 0x06000666 RID: 1638
		[Register("invoke", "(Lkotlinx/coroutines/selects/SelectClause2;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)V", "GetInvoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler:Xamarin.KotlinX.Coroutines.Selects.ISelectBuilderInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[JavaTypeParameters(new string[]
		{
			"P",
			"Q"
		})]
		void Invoke(ISelectClause2 p0, [Nullable(2)] Java.Lang.Object param, IFunction2 block);

		// Token: 0x06000667 RID: 1639
		[Obsolete("deprecated")]
		[Register("onTimeout", "(JLkotlin/jvm/functions/Function1;)V", "GetOnTimeout_JLkotlin_jvm_functions_Function1_Handler:Xamarin.KotlinX.Coroutines.Selects.ISelectBuilderInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void OnTimeout(long timeMillis, IFunction1 block);
	}
}
