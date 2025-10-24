using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003CC RID: 972
	[Register("java/lang/Appendable", "", "Java.Lang.IAppendableInvoker")]
	public interface IAppendable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002AF0 RID: 10992
		IAppendable Append(char c);

		// Token: 0x06002AF1 RID: 10993
		IAppendable Append(ICharSequence csq);

		// Token: 0x06002AF2 RID: 10994
		IAppendable Append(ICharSequence csq, int start, int end);
	}
}
