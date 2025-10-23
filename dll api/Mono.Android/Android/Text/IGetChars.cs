using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x0200019D RID: 413
	[Register("android/text/GetChars", "", "Android.Text.IGetCharsInvoker")]
	public interface IGetChars : ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable
	{
		// Token: 0x06000EA6 RID: 3750
		void GetChars(int start, int end, char[] dest, int destoff);
	}
}
