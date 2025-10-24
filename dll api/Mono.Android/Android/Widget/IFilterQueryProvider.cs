using System;
using Android.Database;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000CF RID: 207
	[Register("android/widget/FilterQueryProvider", "", "Android.Widget.IFilterQueryProviderInvoker")]
	public interface IFilterQueryProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000446 RID: 1094
		ICursor RunQuery(ICharSequence constraint);
	}
}
