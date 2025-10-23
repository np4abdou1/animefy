using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Media
{
	// Token: 0x02000203 RID: 515
	[Register("android/media/VolumeAutomation", "", "Android.Media.IVolumeAutomationInvoker", ApiSince = 26)]
	public interface IVolumeAutomation : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600129F RID: 4767
		VolumeShaper CreateVolumeShaper(VolumeShaper.Configuration configuration);
	}
}
