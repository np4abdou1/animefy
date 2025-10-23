using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x0200011D RID: 285
	[Register("com/unity3d/services/core/device/IVolumeChangeListener", "", "Com.Unity3d.Services.Core.Device.IVolumeChangeListenerInvoker")]
	public interface IVolumeChangeListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000B49 RID: 2889
		int StreamType { [Register("getStreamType", "()I", "GetGetStreamTypeHandler:Com.Unity3d.Services.Core.Device.IVolumeChangeListenerInvoker, UnityAds")] get; }

		// Token: 0x06000B4A RID: 2890
		[Register("onVolumeChanged", "(I)V", "GetOnVolumeChanged_IHandler:Com.Unity3d.Services.Core.Device.IVolumeChangeListenerInvoker, UnityAds")]
		void OnVolumeChanged(int p0);
	}
}
