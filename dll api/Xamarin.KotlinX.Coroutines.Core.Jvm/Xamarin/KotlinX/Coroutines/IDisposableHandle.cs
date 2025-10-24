using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200005F RID: 95
	[Register("kotlinx/coroutines/DisposableHandle", "", "Xamarin.KotlinX.Coroutines.IDisposableHandleInvoker")]
	public interface IDisposableHandle : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003DC RID: 988
		[Register("dispose", "()V", "GetDisposeHandler:Xamarin.KotlinX.Coroutines.IDisposableHandleInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void Dispose();
	}
}
