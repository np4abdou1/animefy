using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Nio.Channels
{
	// Token: 0x0200039D RID: 925
	[Register("java/nio/channels/GatheringByteChannel", "", "Java.Nio.Channels.IGatheringByteChannelInvoker")]
	public interface IGatheringByteChannel : IWritableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060028F9 RID: 10489
		long Write(ByteBuffer[] srcs);

		// Token: 0x060028FA RID: 10490
		long Write(ByteBuffer[] srcs, int offset, int length);
	}
}
