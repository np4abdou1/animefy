using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Window
{
	// Token: 0x0200009C RID: 156
	[Register("android/window/OnBackInvokedCallback", "", "Android.Window.IOnBackInvokedCallbackInvoker", ApiSince = 33)]
	public interface IOnBackInvokedCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000269 RID: 617
		void OnBackInvoked();
	}
}
