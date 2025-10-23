using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Nio.Channels
{
	// Token: 0x0200039F RID: 927
	[Register("java/nio/channels/InterruptibleChannel", "", "Java.Nio.Channels.IInterruptibleChannelInvoker")]
	public interface IInterruptibleChannel : IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600290C RID: 10508
		void Close();
	}
}
