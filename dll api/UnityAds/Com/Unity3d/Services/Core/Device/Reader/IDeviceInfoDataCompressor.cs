using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000137 RID: 311
	[Register("com/unity3d/services/core/device/reader/IDeviceInfoDataCompressor", "", "Com.Unity3d.Services.Core.Device.Reader.IDeviceInfoDataCompressorInvoker")]
	public interface IDeviceInfoDataCompressor : IDeviceInfoDataContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C75 RID: 3189
		[Register("compressDeviceInfo", "(Ljava/util/Map;)[B", "GetCompressDeviceInfo_Ljava_util_Map_Handler:Com.Unity3d.Services.Core.Device.Reader.IDeviceInfoDataCompressorInvoker, UnityAds")]
		byte[] CompressDeviceInfo(IDictionary<string, Java.Lang.Object> p0);
	}
}
