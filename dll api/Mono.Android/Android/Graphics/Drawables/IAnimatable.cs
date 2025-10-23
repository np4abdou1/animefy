using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Graphics.Drawables
{
	// Token: 0x0200023B RID: 571
	[Register("android/graphics/drawable/Animatable", "", "Android.Graphics.Drawables.IAnimatableInvoker")]
	public interface IAnimatable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600144E RID: 5198
		bool IsRunning { get; }

		// Token: 0x0600144F RID: 5199
		void Start();

		// Token: 0x06001450 RID: 5200
		void Stop();
	}
}
