using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x0200019A RID: 410
	[Register("android/text/Editable", "", "Android.Text.IEditableInvoker")]
	public interface IEditable : IGetChars, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable, ISpannable, ISpanned, IAppendable
	{
		// Token: 0x06000E5A RID: 3674
		IAppendable Append(char text);

		// Token: 0x06000E5B RID: 3675
		IAppendable Append(ICharSequence text);

		// Token: 0x06000E5C RID: 3676
		IAppendable Append(ICharSequence text, int start, int end);

		// Token: 0x06000E5D RID: 3677
		void Clear();

		// Token: 0x06000E5E RID: 3678
		void ClearSpans();

		// Token: 0x06000E5F RID: 3679
		IEditable Delete(int st, int en);

		// Token: 0x06000E60 RID: 3680
		IInputFilter[] GetFilters();

		// Token: 0x06000E61 RID: 3681
		IEditable Insert(int where, ICharSequence text);

		// Token: 0x06000E62 RID: 3682
		IEditable Insert(int where, ICharSequence text, int start, int end);

		// Token: 0x06000E63 RID: 3683
		IEditable Replace(int st, int en, ICharSequence text);

		// Token: 0x06000E64 RID: 3684
		IEditable Replace(int st, int en, ICharSequence source, int start, int end);

		// Token: 0x06000E65 RID: 3685
		void SetFilters(IInputFilter[] filters);
	}
}
