using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x02000292 RID: 658
	[Register("android/content/DialogInterface$OnKeyListener", "", "Android.Content.IDialogInterfaceOnKeyListenerInvoker")]
	public interface IDialogInterfaceOnKeyListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600191A RID: 6426
		bool OnKey(IDialogInterface dialog, [GeneratedEnum] Keycode keyCode, KeyEvent e);
	}
}
