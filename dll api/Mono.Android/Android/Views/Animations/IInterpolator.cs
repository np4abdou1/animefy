using System;
using Android.Animation;
using Android.Runtime;
using Java.Interop;

namespace Android.Views.Animations
{
	// Token: 0x02000185 RID: 389
	[Register("android/view/animation/Interpolator", "", "Android.Views.Animations.IInterpolatorInvoker")]
	public interface IInterpolator : ITimeInterpolator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000D90 RID: 3472
		float GetInterpolation(float input);
	}
}
