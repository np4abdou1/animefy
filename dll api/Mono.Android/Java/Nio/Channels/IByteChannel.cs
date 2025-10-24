using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Nio.Channels
{
	// Token: 0x02000399 RID: 921
	[Register("java/nio/channels/ByteChannel", "", "Java.Nio.Channels.IByteChannelInvoker")]
	public interface IByteChannel : IReadableByteChannel, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IWritableByteChannel
	{
	}
}
