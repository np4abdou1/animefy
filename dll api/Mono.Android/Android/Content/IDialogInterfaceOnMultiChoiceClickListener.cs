using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x02000294 RID: 660
	[Register("android/content/DialogInterface$OnMultiChoiceClickListener", "", "Android.Content.IDialogInterfaceOnMultiChoiceClickListenerInvoker")]
	public interface IDialogInterfaceOnMultiChoiceClickListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001926 RID: 6438
		void OnClick(IDialogInterface dialog, int which, bool isChecked);
	}
}
