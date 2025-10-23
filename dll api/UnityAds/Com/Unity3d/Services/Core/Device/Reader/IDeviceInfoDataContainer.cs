using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000139 RID: 313
	[Register("com/unity3d/services/core/device/reader/IDeviceInfoDataContainer", "", "Com.Unity3d.Services.Core.Device.Reader.IDeviceInfoDataContainerInvoker")]
	public interface IDeviceInfoDataContainer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000C88 RID: 3208
		IDictionary<string, Java.Lang.Object> DeviceInfo { [Register("getDeviceInfo", "()Ljava/util/Map;", "GetGetDeviceInfoHandler:Com.Unity3d.Services.Core.Device.Reader.IDeviceInfoDataContainerInvoker, UnityAds")] get; }

		// Token: 0x06000C89 RID: 3209
		[Register("getDeviceData", "()[B", "GetGetDeviceDataHandler:Com.Unity3d.Services.Core.Device.Reader.IDeviceInfoDataContainerInvoker, UnityAds")]
		byte[] GetDeviceData();
	}
}
