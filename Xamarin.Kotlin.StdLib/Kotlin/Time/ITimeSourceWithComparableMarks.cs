using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Time
{
	// Token: 0x020000CE RID: 206
	[Register("kotlin/time/TimeSource$WithComparableMarks", "", "Kotlin.Time.ITimeSourceWithComparableMarksInvoker")]
	public interface ITimeSourceWithComparableMarks : ITimeSource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000638 RID: 1592
		[NullableContext(1)]
		[Register("markNow", "()Lkotlin/time/ComparableTimeMark;", "GetMarkNowHandler:Kotlin.Time.ITimeSourceWithComparableMarksInvoker, Xamarin.Kotlin.StdLib")]
		ITimeMark MarkNow();
	}
}
