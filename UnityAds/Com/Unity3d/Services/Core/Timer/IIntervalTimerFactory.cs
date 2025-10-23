using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000092 RID: 146
	[Register("com/unity3d/services/core/timer/IIntervalTimerFactory", "", "Com.Unity3d.Services.Core.Timer.IIntervalTimerFactoryInvoker")]
	public interface IIntervalTimerFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000568 RID: 1384
		[Register("createTimer", "(Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/timer/IIntervalTimerListener;)Lcom/unity3d/services/core/timer/IIntervalTimer;", "GetCreateTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_Handler:Com.Unity3d.Services.Core.Timer.IIntervalTimerFactoryInvoker, UnityAds")]
		IIntervalTimer CreateTimer(Integer p0, Integer p1, IIntervalTimerListener p2);
	}
}
