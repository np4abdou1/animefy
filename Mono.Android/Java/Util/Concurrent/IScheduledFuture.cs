using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000357 RID: 855
	[Register("java/util/concurrent/ScheduledFuture", "", "Java.Util.Concurrent.IScheduledFutureInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IScheduledFuture : IDelayed, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable, IFuture
	{
	}
}
