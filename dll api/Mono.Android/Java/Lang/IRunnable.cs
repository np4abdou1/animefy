using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E0 RID: 992
	[Register("java/lang/Runnable", "", "Java.Lang.IRunnableInvoker")]
	public interface IRunnable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002B98 RID: 11160
		void Run();
	}
}
