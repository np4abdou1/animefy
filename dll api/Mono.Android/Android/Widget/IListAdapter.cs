using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Widget
{
	// Token: 0x020000D1 RID: 209
	[Register("android/widget/ListAdapter", "", "Android.Widget.IListAdapterInvoker")]
	public interface IListAdapter : IAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000452 RID: 1106
		bool AreAllItemsEnabled();

		// Token: 0x06000453 RID: 1107
		bool IsEnabled(int position);
	}
}
