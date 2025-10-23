using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x02000297 RID: 663
	[Register("android/content/DialogInterface", "", "Android.Content.IDialogInterfaceInvoker")]
	public interface IDialogInterface : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001933 RID: 6451
		void Cancel();

		// Token: 0x06001934 RID: 6452
		void Dismiss();
	}
}
