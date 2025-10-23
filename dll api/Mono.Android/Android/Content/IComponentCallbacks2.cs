using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x02000289 RID: 649
	[Register("android/content/ComponentCallbacks2", "", "Android.Content.IComponentCallbacks2Invoker")]
	public interface IComponentCallbacks2 : IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060018E6 RID: 6374
		void OnTrimMemory([GeneratedEnum] TrimMemory level);
	}
}
