using System;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x02000287 RID: 647
	[Register("android/content/ComponentCallbacks", "", "Android.Content.IComponentCallbacksInvoker")]
	public interface IComponentCallbacks : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060018D6 RID: 6358
		void OnConfigurationChanged(Configuration newConfig);

		// Token: 0x060018D7 RID: 6359
		void OnLowMemory();
	}
}
