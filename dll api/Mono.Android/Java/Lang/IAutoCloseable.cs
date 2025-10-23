using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003CE RID: 974
	[Register("java/lang/AutoCloseable", "", "Java.Lang.IAutoCloseableInvoker")]
	public interface IAutoCloseable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002B04 RID: 11012
		void Close();
	}
}
