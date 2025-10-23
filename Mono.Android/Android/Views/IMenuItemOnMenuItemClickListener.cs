using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x0200011E RID: 286
	[Register("android/view/MenuItem$OnMenuItemClickListener", "", "Android.Views.IMenuItemOnMenuItemClickListenerInvoker")]
	public interface IMenuItemOnMenuItemClickListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060007DF RID: 2015
		bool OnMenuItemClick(IMenuItem item);
	}
}
