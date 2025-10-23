using System;
using Android.Runtime;
using Java.Interop;

namespace Java.IO
{
	// Token: 0x02000419 RID: 1049
	[Register("java/io/Flushable", "", "Java.IO.IFlushableInvoker")]
	public interface IFlushable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002DF2 RID: 11762
		void Flush();
	}
}
