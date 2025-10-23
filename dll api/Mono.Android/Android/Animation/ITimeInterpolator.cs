using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Animation
{
	// Token: 0x02000251 RID: 593
	[Register("android/animation/TimeInterpolator", "", "Android.Animation.ITimeInterpolatorInvoker")]
	public interface ITimeInterpolator : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001589 RID: 5513
		float GetInterpolation(float input);
	}
}
