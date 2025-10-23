using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Time
{
	// Token: 0x020000CB RID: 203
	[Register("kotlin/time/TimeMark", "", "Kotlin.Time.ITimeMarkInvoker")]
	public interface ITimeMark : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000613 RID: 1555
		bool HasNotPassedNow { [Register("hasNotPassedNow", "()Z", "GetHasNotPassedNowHandler:Kotlin.Time.ITimeMarkInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000614 RID: 1556
		bool HasPassedNow { [Register("hasPassedNow", "()Z", "GetHasPassedNowHandler:Kotlin.Time.ITimeMarkInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000615 RID: 1557
		[Register("elapsedNow-UwyO8pc", "()J", "GetElapsedNowHandler:Kotlin.Time.ITimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		long ElapsedNow();

		// Token: 0x06000616 RID: 1558
		[NullableContext(1)]
		[Register("minus-LRDsOJo", "(J)Lkotlin/time/TimeMark;", "GetMinus_JHandler:Kotlin.Time.ITimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		ITimeMark Minus(long p0);

		// Token: 0x06000617 RID: 1559
		[NullableContext(1)]
		[Register("plus-LRDsOJo", "(J)Lkotlin/time/TimeMark;", "GetPlus_JHandler:Kotlin.Time.ITimeMarkInvoker, Xamarin.Kotlin.StdLib")]
		ITimeMark Plus(long p0);
	}
}
