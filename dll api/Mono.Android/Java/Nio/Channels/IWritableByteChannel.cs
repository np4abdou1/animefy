using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Nio.Channels
{
	// Token: 0x020003A7 RID: 935
	[Register("java/nio/channels/WritableByteChannel", "", "Java.Nio.Channels.IWritableByteChannelInvoker")]
	public interface IWritableByteChannel : IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600295C RID: 10588
		int Write(ByteBuffer src);
	}
}
