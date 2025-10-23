using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200013B RID: 315
	[Register("com/unity3d/services/core/device/reader/IDeviceInfoReader", "", "Com.Unity3d.Services.Core.Device.Reader.IDeviceInfoReaderInvoker")]
	public interface IDeviceInfoReader : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000C99 RID: 3225
		IDictionary<string, Java.Lang.Object> DeviceInfoData { [Register("getDeviceInfoData", "()Ljava/util/Map;", "GetGetDeviceInfoDataHandler:Com.Unity3d.Services.Core.Device.Reader.IDeviceInfoReaderInvoker, UnityAds")] get; }
	}
}
