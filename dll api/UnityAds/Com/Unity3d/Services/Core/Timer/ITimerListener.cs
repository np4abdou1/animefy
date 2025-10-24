using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000098 RID: 152
	[Register("com/unity3d/services/core/timer/ITimerListener", "", "Com.Unity3d.Services.Core.Timer.ITimerListenerInvoker")]
	public interface ITimerListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600058F RID: 1423
		[Register("onTimerFinished", "()V", "GetOnTimerFinishedHandler:Com.Unity3d.Services.Core.Timer.ITimerListenerInvoker, UnityAds")]
		void OnTimerFinished();
	}
}
