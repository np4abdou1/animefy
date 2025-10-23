using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Java.Nio.FileNio
{
	// Token: 0x0200038B RID: 907
	[Register("java/nio/file/WatchKey", "", "Java.Nio.FileNio.IWatchKeyInvoker", ApiSince = 26)]
	public interface IWatchKey : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002826 RID: 10278
		bool IsValid { get; }

		// Token: 0x06002827 RID: 10279
		void Cancel();

		// Token: 0x06002828 RID: 10280
		IList<IWatchEvent> PollEvents();

		// Token: 0x06002829 RID: 10281
		bool Reset();

		// Token: 0x0600282A RID: 10282
		IWatchable Watchable();
	}
}
