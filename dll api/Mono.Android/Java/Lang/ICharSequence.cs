using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003D0 RID: 976
	[Register("java/lang/CharSequence", "", "Java.Lang.ICharSequenceInvoker")]
	public interface ICharSequence : IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable
	{
		// Token: 0x06002B10 RID: 11024
		char CharAt(int index);

		// Token: 0x06002B11 RID: 11025
		int Length();

		// Token: 0x06002B12 RID: 11026
		ICharSequence SubSequenceFormatted(int start, int end);

		// Token: 0x06002B13 RID: 11027
		string ToString();
	}
}
