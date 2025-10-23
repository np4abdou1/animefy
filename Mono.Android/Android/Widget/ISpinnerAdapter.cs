using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Android.Widget
{
	// Token: 0x020000D6 RID: 214
	[Register("android/widget/SpinnerAdapter", "", "Android.Widget.ISpinnerAdapterInvoker")]
	public interface ISpinnerAdapter : IAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000485 RID: 1157
		View GetDropDownView(int position, View convertView, ViewGroup parent);
	}
}
