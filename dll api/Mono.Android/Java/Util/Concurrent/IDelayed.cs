using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x0200034D RID: 845
	[Register("java/util/concurrent/Delayed", "", "Java.Util.Concurrent.IDelayedInvoker")]
	public interface IDelayed : Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600253D RID: 9533
		long GetDelay(TimeUnit unit);
	}
}
