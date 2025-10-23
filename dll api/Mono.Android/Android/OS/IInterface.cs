using System;
using Android.Runtime;
using Java.Interop;

namespace Android.OS
{
	// Token: 0x020001E8 RID: 488
	[Register("android/os/IInterface", "", "Android.OS.IInterfaceInvoker")]
	public interface IInterface : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011DD RID: 4573
		IBinder AsBinder();
	}
}
