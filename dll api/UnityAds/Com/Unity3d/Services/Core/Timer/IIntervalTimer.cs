using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000090 RID: 144
	[Register("com/unity3d/services/core/timer/IIntervalTimer", "", "Com.Unity3d.Services.Core.Timer.IIntervalTimerInvoker")]
	public interface IIntervalTimer : IBaseTimer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600054C RID: 1356
		[Register("onNextInterval", "()V", "GetOnNextIntervalHandler:Com.Unity3d.Services.Core.Timer.IIntervalTimerInvoker, UnityAds")]
		void OnNextInterval();
	}
}
