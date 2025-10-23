using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Media
{
	// Token: 0x020001FF RID: 511
	[Register("android/media/AudioRouting$OnRoutingChangedListener", "", "Android.Media.IAudioRoutingOnRoutingChangedListenerInvoker", ApiSince = 24)]
	public interface IAudioRoutingOnRoutingChangedListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001277 RID: 4727
		void OnRoutingChanged(IAudioRouting router);
	}
}
