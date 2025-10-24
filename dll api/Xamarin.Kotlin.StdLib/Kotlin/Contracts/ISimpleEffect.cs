using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Contracts
{
	// Token: 0x0200027E RID: 638
	[Register("kotlin/contracts/SimpleEffect", "", "Kotlin.Contracts.ISimpleEffectInvoker")]
	public interface ISimpleEffect : IEffect, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001CBB RID: 7355
		[NullableContext(1)]
		[Register("implies", "(Z)Lkotlin/contracts/ConditionalEffect;", "GetImplies_ZHandler:Kotlin.Contracts.ISimpleEffectInvoker, Xamarin.Kotlin.StdLib")]
		IConditionalEffect Implies(bool booleanExpression);
	}
}
