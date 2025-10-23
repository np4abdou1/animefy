using System;
using Android.Runtime;
using Java.Interop;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x0200008E RID: 142
	[Register("com/unity3d/services/core/timer/IBaseTimer", "", "Com.Unity3d.Services.Core.Timer.IBaseTimerInvoker")]
	public interface IBaseTimer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600052F RID: 1327
		[Register("kill", "()V", "GetKillHandler:Com.Unity3d.Services.Core.Timer.IBaseTimerInvoker, UnityAds")]
		void Kill();

		// Token: 0x06000530 RID: 1328
		[Register("pause", "()Z", "GetPauseHandler:Com.Unity3d.Services.Core.Timer.IBaseTimerInvoker, UnityAds")]
		bool Pause();

		// Token: 0x06000531 RID: 1329
		[Register("resume", "()Z", "GetResumeHandler:Com.Unity3d.Services.Core.Timer.IBaseTimerInvoker, UnityAds")]
		bool Resume();

		// Token: 0x06000532 RID: 1330
		[Register("start", "(Ljava/util/concurrent/ScheduledExecutorService;)V", "GetStart_Ljava_util_concurrent_ScheduledExecutorService_Handler:Com.Unity3d.Services.Core.Timer.IBaseTimerInvoker, UnityAds")]
		void Start(IScheduledExecutorService p0);

		// Token: 0x06000533 RID: 1331
		[Register("stop", "()V", "GetStopHandler:Com.Unity3d.Services.Core.Timer.IBaseTimerInvoker, UnityAds")]
		void Stop();
	}
}
