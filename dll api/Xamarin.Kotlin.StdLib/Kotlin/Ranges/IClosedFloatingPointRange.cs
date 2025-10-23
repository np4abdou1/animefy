using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x02000299 RID: 665
	[Register("kotlin/ranges/ClosedFloatingPointRange", "", "Kotlin.Ranges.IClosedFloatingPointRangeInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends java.lang.Comparable<? super T>"
	})]
	public interface IClosedFloatingPointRange : IClosedRange, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001DF0 RID: 7664
		bool IsEmpty { [Register("isEmpty", "()Z", "GetIsEmptyHandler:Kotlin.Ranges.IClosedFloatingPointRangeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06001DF1 RID: 7665
		[NullableContext(1)]
		[Register("contains", "(Ljava/lang/Comparable;)Z", "GetContains_Ljava_lang_Comparable_Handler:Kotlin.Ranges.IClosedFloatingPointRangeInvoker, Xamarin.Kotlin.StdLib")]
		bool Contains(Java.Lang.Object value);

		// Token: 0x06001DF2 RID: 7666
		[NullableContext(1)]
		[Register("lessThanOrEquals", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Z", "GetLessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_Handler:Kotlin.Ranges.IClosedFloatingPointRangeInvoker, Xamarin.Kotlin.StdLib")]
		bool LessThanOrEquals(Java.Lang.Object a, Java.Lang.Object b);
	}
}
