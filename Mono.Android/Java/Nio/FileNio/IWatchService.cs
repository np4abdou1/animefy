using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Util.Concurrent;

namespace Java.Nio.FileNio
{
	// Token: 0x0200038D RID: 909
	[Register("java/nio/file/WatchService", "", "Java.Nio.FileNio.IWatchServiceInvoker", ApiSince = 26)]
	public interface IWatchService : ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002842 RID: 10306
		void Close();

		// Token: 0x06002843 RID: 10307
		IWatchKey Poll();

		// Token: 0x06002844 RID: 10308
		IWatchKey Poll(long timeout, TimeUnit unit);

		// Token: 0x06002845 RID: 10309
		IWatchKey Take();
	}
}
