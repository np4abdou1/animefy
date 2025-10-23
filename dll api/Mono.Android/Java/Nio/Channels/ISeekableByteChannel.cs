using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Nio.Channels
{
	// Token: 0x020003A5 RID: 933
	[Register("java/nio/channels/SeekableByteChannel", "", "Java.Nio.Channels.ISeekableByteChannelInvoker", ApiSince = 24)]
	public interface ISeekableByteChannel : IByteChannel, IReadableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IWritableByteChannel
	{
		// Token: 0x0600293A RID: 10554
		long Position();

		// Token: 0x0600293B RID: 10555
		ISeekableByteChannel Position(long newPosition);

		// Token: 0x0600293C RID: 10556
		int Read(ByteBuffer dst);

		// Token: 0x0600293D RID: 10557
		long Size();

		// Token: 0x0600293E RID: 10558
		ISeekableByteChannel Truncate(long size);

		// Token: 0x0600293F RID: 10559
		int Write(ByteBuffer src);
	}
}
