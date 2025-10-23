using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x02000093 RID: 147
	[NullableContext(1)]
	[Register("kotlinx/coroutines/selects/SelectClause", "", "Xamarin.KotlinX.Coroutines.Selects.ISelectClauseInvoker")]
	public interface ISelectClause : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000680 RID: 1664
		Java.Lang.Object ClauseObject { [Register("getClauseObject", "()Ljava/lang/Object;", "GetGetClauseObjectHandler:Xamarin.KotlinX.Coroutines.Selects.ISelectClauseInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000681 RID: 1665
		[Nullable(2)]
		IFunction3 OnCancellationConstructor { [NullableContext(2)] [Register("getOnCancellationConstructor", "()Lkotlin/jvm/functions/Function3;", "GetGetOnCancellationConstructorHandler:Xamarin.KotlinX.Coroutines.Selects.ISelectClauseInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000682 RID: 1666
		IFunction3 ProcessResFunc { [Register("getProcessResFunc", "()Lkotlin/jvm/functions/Function3;", "GetGetProcessResFuncHandler:Xamarin.KotlinX.Coroutines.Selects.ISelectClauseInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000683 RID: 1667
		IFunction3 RegFunc { [Register("getRegFunc", "()Lkotlin/jvm/functions/Function3;", "GetGetRegFuncHandler:Xamarin.KotlinX.Coroutines.Selects.ISelectClauseInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }
	}
}
