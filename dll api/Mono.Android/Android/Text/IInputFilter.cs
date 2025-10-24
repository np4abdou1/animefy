using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001A0 RID: 416
	[Register("android/text/InputFilter", "", "Android.Text.IInputFilterInvoker")]
	public interface IInputFilter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000EBE RID: 3774
		ICharSequence FilterFormatted(ICharSequence source, int start, int end, ISpanned dest, int dstart, int dend);
	}
}
