using System;
using Android.Runtime;
using Java.Interop;
using Java.Nio;

namespace Java.Lang
{
	// Token: 0x020003DE RID: 990
	[Register("java/lang/Readable", "", "Java.Lang.IReadableInvoker")]
	public interface IReadable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002B8C RID: 11148
		int Read(CharBuffer cb);
	}
}
