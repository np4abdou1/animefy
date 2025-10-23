using System;
using Android.Runtime;
using Java.Interop;

namespace Java.IO
{
	// Token: 0x02000417 RID: 1047
	[Register("java/io/Closeable", "", "Java.IO.ICloseableInvoker")]
	public interface ICloseable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002DE6 RID: 11750
		void Close();
	}
}
