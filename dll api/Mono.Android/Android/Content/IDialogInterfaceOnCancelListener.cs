using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x0200028B RID: 651
	[Register("android/content/DialogInterface$OnCancelListener", "", "Android.Content.IDialogInterfaceOnCancelListenerInvoker")]
	public interface IDialogInterfaceOnCancelListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060018F4 RID: 6388
		void OnCancel(IDialogInterface dialog);
	}
}
