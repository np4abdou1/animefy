using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Widget
{
	// Token: 0x020000CD RID: 205
	[Register("android/widget/Filterable", "", "Android.Widget.IFilterableInvoker")]
	public interface IFilterable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600043A RID: 1082
		Filter Filter { get; }
	}
}
