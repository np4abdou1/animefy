using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000347 RID: 839
	[Register("java/util/concurrent/Callable", "", "Java.Util.Concurrent.ICallableInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface ICallable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002455 RID: 9301
		Java.Lang.Object Call();
	}
}
