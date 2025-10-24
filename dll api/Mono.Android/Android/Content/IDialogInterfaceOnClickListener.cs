using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x0200028D RID: 653
	[Register("android/content/DialogInterface$OnClickListener", "", "Android.Content.IDialogInterfaceOnClickListenerInvoker")]
	public interface IDialogInterfaceOnClickListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001900 RID: 6400
		void OnClick(IDialogInterface dialog, int which);
	}
}
