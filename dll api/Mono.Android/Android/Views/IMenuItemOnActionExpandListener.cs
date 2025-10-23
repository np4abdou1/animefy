using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x0200011C RID: 284
	[Register("android/view/MenuItem$OnActionExpandListener", "", "Android.Views.IMenuItemOnActionExpandListenerInvoker")]
	public interface IMenuItemOnActionExpandListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060007CF RID: 1999
		bool OnMenuItemActionCollapse(IMenuItem item);

		// Token: 0x060007D0 RID: 2000
		bool OnMenuItemActionExpand(IMenuItem item);
	}
}
