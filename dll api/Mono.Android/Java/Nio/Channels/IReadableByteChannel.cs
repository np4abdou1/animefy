using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Nio.Channels
{
	// Token: 0x020003A1 RID: 929
	[Register("java/nio/channels/ReadableByteChannel", "", "Java.Nio.Channels.IReadableByteChannelInvoker")]
	public interface IReadableByteChannel : IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002919 RID: 10521
		int Read(ByteBuffer dst);
	}
}
