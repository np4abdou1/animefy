using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Text
{
	// Token: 0x020001A4 RID: 420
	[Register("android/text/ParcelableSpan", "", "Android.Text.IParcelableSpanInvoker")]
	public interface IParcelableSpan : IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000ED2 RID: 3794
		int SpanTypeId { get; }
	}
}
