using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Time
{
	// Token: 0x020000D0 RID: 208
	[Register("kotlin/time/TimeSource", "", "Kotlin.Time.ITimeSourceInvoker")]
	public interface ITimeSource : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000645 RID: 1605
		[NullableContext(1)]
		[Register("markNow", "()Lkotlin/time/TimeMark;", "GetMarkNowHandler:Kotlin.Time.ITimeSourceInvoker, Xamarin.Kotlin.StdLib")]
		ITimeMark MarkNow();
	}
}
