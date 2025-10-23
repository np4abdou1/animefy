using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000C6 RID: 198
	[Register("kotlin/time/ComparableTimeMark", "", "Kotlin.Time.IComparableTimeMarkInvoker")]
	public interface IComparableTimeMark : Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable, ITimeMark
	{
		// Token: 0x060005C7 RID: 1479
		[NullableContext(1)]
		[Register("compareTo", "(Lkotlin/time/ComparableTimeMark;)I", "GetCompareTo_Lkotlin_time_ComparableTimeMark_Handler:Kotlin.Time.IComparableTimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		int CompareTo(IComparableTimeMark other);

		// Token: 0x060005C8 RID: 1480
		[NullableContext(2)]
		[Register("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler:Kotlin.Time.IComparableTimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		bool Equals(Java.Lang.Object other);

		// Token: 0x060005C9 RID: 1481
		[Register("hashCode", "()I", "GetGetHashCodeHandler:Kotlin.Time.IComparableTimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		int GetHashCode();

		// Token: 0x060005CA RID: 1482
		[NullableContext(1)]
		[Register("minus-LRDsOJo", "(J)Lkotlin/time/ComparableTimeMark;", "GetMinus_JHandler:Kotlin.Time.IComparableTimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		ITimeMark Minus(long p0);

		// Token: 0x060005CB RID: 1483
		[NullableContext(1)]
		[Register("minus-UwyO8pc", "(Lkotlin/time/ComparableTimeMark;)J", "GetMinus_Lkotlin_time_ComparableTimeMark_Handler:Kotlin.Time.IComparableTimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		long Minus(IComparableTimeMark other);

		// Token: 0x060005CC RID: 1484
		[NullableContext(1)]
		[Register("plus-LRDsOJo", "(J)Lkotlin/time/ComparableTimeMark;", "GetPlus_JHandler:Kotlin.Time.IComparableTimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		ITimeMark Plus(long p0);
	}
}
