using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x02000403 RID: 1027
	[Register("java/lang/reflect/InvocationHandler", "", "Java.Lang.Reflect.IInvocationHandlerInvoker")]
	public interface IInvocationHandler : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002D40 RID: 11584
		Object Invoke(Object proxy, Method method, Object[] args);
	}
}
