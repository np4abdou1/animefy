using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Nio.FileNio
{
	// Token: 0x02000383 RID: 899
	[Register("java/nio/file/Watchable", "", "Java.Nio.FileNio.IWatchableInvoker", ApiSince = 26)]
	public interface IWatchable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060027E6 RID: 10214
		IWatchKey Register(IWatchService watcher, params IWatchEventKind[] events);

		// Token: 0x060027E7 RID: 10215
		IWatchKey Register(IWatchService watcher, IWatchEventKind[] events, params IWatchEventModifier[] modifiers);
	}
}
