using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Hardware
{
	// Token: 0x0200020D RID: 525
	[Register("android/hardware/SensorEventListener", "", "Android.Hardware.ISensorEventListenerInvoker")]
	public interface ISensorEventListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060012EB RID: 4843
		void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy);

		// Token: 0x060012EC RID: 4844
		void OnSensorChanged(SensorEvent e);
	}
}
