using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Nio.Channels
{
	// Token: 0x020003A3 RID: 931
	[Register("java/nio/channels/ScatteringByteChannel", "", "Java.Nio.Channels.IScatteringByteChannelInvoker")]
	public interface IScatteringByteChannel : IReadableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002927 RID: 10535
		long Read(ByteBuffer[] dsts);

		// Token: 0x06002928 RID: 10536
		long Read(ByteBuffer[] dsts, int offset, int length);
	}
}
