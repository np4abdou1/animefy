using System;
using Android.Runtime;
using Java.Interop;

namespace Android.OS
{
	// Token: 0x020001E4 RID: 484
	[Register("android/os/IBinder$DeathRecipient", "", "Android.OS.IBinderDeathRecipientInvoker")]
	public interface IBinderDeathRecipient : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011A3 RID: 4515
		void BinderDied();
	}
}
