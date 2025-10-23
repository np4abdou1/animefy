using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001A6 RID: 422
	[Register("android/text/Spannable", "", "Android.Text.ISpannableInvoker")]
	public interface ISpannable : ISpanned, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable
	{
		// Token: 0x06000EE0 RID: 3808
		void RemoveSpan(Java.Lang.Object what);

		// Token: 0x06000EE1 RID: 3809
		void SetSpan(Java.Lang.Object what, int start, int end, [GeneratedEnum] SpanTypes flags);
	}
}
