using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000094 RID: 148
	[Register("com/unity3d/services/core/timer/IIntervalTimerListener", "", "Com.Unity3d.Services.Core.Timer.IIntervalTimerListenerInvoker")]
	public interface IIntervalTimerListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000575 RID: 1397
		[Register("onNextIntervalTriggered", "()V", "GetOnNextIntervalTriggeredHandler:Com.Unity3d.Services.Core.Timer.IIntervalTimerListenerInvoker, UnityAds")]
		void OnNextIntervalTriggered();
	}
}
