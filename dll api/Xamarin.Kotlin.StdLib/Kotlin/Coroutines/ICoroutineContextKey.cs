using System;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Coroutines
{
	// Token: 0x0200025D RID: 605
	[Register("kotlin/coroutines/CoroutineContext$Key", "", "Kotlin.Coroutines.ICoroutineContextKeyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E extends kotlin.coroutines.CoroutineContext.Element"
	})]
	public interface ICoroutineContextKey : IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
