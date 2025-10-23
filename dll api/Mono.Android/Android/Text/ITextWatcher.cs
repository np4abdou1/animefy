using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001AC RID: 428
	[Register("android/text/TextWatcher", "", "Android.Text.ITextWatcherInvoker")]
	public interface ITextWatcher : INoCopySpan, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F29 RID: 3881
		void AfterTextChanged(IEditable s);

		// Token: 0x06000F2A RID: 3882
		void BeforeTextChanged(ICharSequence s, int start, int count, int after);

		// Token: 0x06000F2B RID: 3883
		void OnTextChanged(ICharSequence s, int start, int before, int count);
	}
}
