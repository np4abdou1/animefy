using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x020002A1 RID: 673
	[NullableContext(1)]
	[Register("kotlin/ranges/OpenEndRange", "", "Kotlin.Ranges.IOpenEndRangeInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends java.lang.Comparable<? super T>"
	})]
	public interface IOpenEndRange : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001E56 RID: 7766
		Java.Lang.Object EndExclusive { [Register("getEndExclusive", "()Ljava/lang/Comparable;", "GetGetEndExclusiveHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001E57 RID: 7767
		bool IsEmpty { [Register("isEmpty", "()Z", "GetIsEmptyHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001E58 RID: 7768
		Java.Lang.Object Start { [Register("getStart", "()Ljava/lang/Comparable;", "GetGetStartHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06001E59 RID: 7769
		[Register("contains", "(Ljava/lang/Comparable;)Z", "GetContains_Ljava_lang_Comparable_Handler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")]
		bool Contains(Java.Lang.Object value);
	}
}
