using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Nio.Channels
{
	// Token: 0x0200039B RID: 923
	[Register("java/nio/channels/Channel", "", "Java.Nio.Channels.IChannelInvoker")]
	public interface IChannel : ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060028E9 RID: 10473
		bool IsOpen { get; }

		// Token: 0x060028EA RID: 10474
		void Close();
	}
}
