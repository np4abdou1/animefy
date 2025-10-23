using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Window
{
	// Token: 0x0200009E RID: 158
	[Register("android/window/OnBackInvokedDispatcher", "", "Android.Window.IOnBackInvokedDispatcherInvoker", ApiSince = 33)]
	public interface IOnBackInvokedDispatcher : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000275 RID: 629
		void RegisterOnBackInvokedCallback([IntDef(Type = "Android.Window.IOnBackInvokedDispatcher", Fields = new string[]
		{
			"PriorityDefault",
			"PriorityOverlay"
		})] int priority, IOnBackInvokedCallback callback);

		// Token: 0x06000276 RID: 630
		void UnregisterOnBackInvokedCallback(IOnBackInvokedCallback callback);
	}
}
