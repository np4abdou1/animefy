using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x0200029C RID: 668
	[NullableContext(1)]
	[Register("kotlin/ranges/ClosedRange", "", "Kotlin.Ranges.IClosedRangeInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends java.lang.Comparable<? super T>"
	})]
	public interface IClosedRange : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001E13 RID: 7699
		Java.Lang.Object EndInclusive { [Register("getEndInclusive", "()Ljava/lang/Comparable;", "GetGetEndInclusiveHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001E14 RID: 7700
		bool IsEmpty { [Register("isEmpty", "()Z", "GetIsEmptyHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001E15 RID: 7701
		Java.Lang.Object Start { [Register("getStart", "()Ljava/lang/Comparable;", "GetGetStartHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06001E16 RID: 7702
		[Register("contains", "(Ljava/lang/Comparable;)Z", "GetContains_Ljava_lang_Comparable_Handler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")]
		bool Contains(Java.Lang.Object value);
	}
}
