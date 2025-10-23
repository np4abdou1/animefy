using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Media
{
	// Token: 0x02000201 RID: 513
	[Register("android/media/AudioRouting", "", "Android.Media.IAudioRoutingInvoker", ApiSince = 24)]
	public interface IAudioRouting : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001283 RID: 4739
		AudioDeviceInfo PreferredDevice { get; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001284 RID: 4740
		AudioDeviceInfo RoutedDevice { get; }

		// Token: 0x06001285 RID: 4741
		void AddOnRoutingChangedListener(IAudioRoutingOnRoutingChangedListener listener, Handler handler);

		// Token: 0x06001286 RID: 4742
		void RemoveOnRoutingChangedListener(IAudioRoutingOnRoutingChangedListener listener);

		// Token: 0x06001287 RID: 4743
		bool SetPreferredDevice(AudioDeviceInfo deviceInfo);
	}
}
