using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x02000290 RID: 656
	[Register("android/content/DialogInterface$OnDismissListener", "", "Android.Content.IDialogInterfaceOnDismissListenerInvoker")]
	public interface IDialogInterfaceOnDismissListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600190E RID: 6414
		void OnDismiss(IDialogInterface dialog);
	}
}
