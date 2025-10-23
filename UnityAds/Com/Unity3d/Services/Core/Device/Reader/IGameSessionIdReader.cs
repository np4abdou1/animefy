using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200013D RID: 317
	[Register("com/unity3d/services/core/device/reader/IGameSessionIdReader", "", "Com.Unity3d.Services.Core.Device.Reader.IGameSessionIdReaderInvoker")]
	public interface IGameSessionIdReader : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000CA6 RID: 3238
		Long GameSessionId { [Register("getGameSessionId", "()Ljava/lang/Long;", "GetGetGameSessionIdHandler:Com.Unity3d.Services.Core.Device.Reader.IGameSessionIdReaderInvoker, UnityAds")] get; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000CA7 RID: 3239
		Long GameSessionIdAndStore { [Register("getGameSessionIdAndStore", "()Ljava/lang/Long;", "GetGetGameSessionIdAndStoreHandler:Com.Unity3d.Services.Core.Device.Reader.IGameSessionIdReaderInvoker, UnityAds")] get; }
	}
}
