using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001A9 RID: 425
	[Register("android/text/Spanned", "", "Android.Text.ISpannedInvoker")]
	public interface ISpanned : ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable
	{
		// Token: 0x06000F01 RID: 3841
		int GetSpanEnd(Java.Lang.Object tag);

		// Token: 0x06000F02 RID: 3842
		[return: GeneratedEnum]
		SpanTypes GetSpanFlags(Java.Lang.Object tag);

		// Token: 0x06000F03 RID: 3843
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object[] GetSpans(int start, int end, Class type);

		// Token: 0x06000F04 RID: 3844
		int GetSpanStart(Java.Lang.Object tag);

		// Token: 0x06000F05 RID: 3845
		int NextSpanTransition(int start, int limit, Class type);
	}
}
