using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Nio.FileNio
{
	// Token: 0x02000387 RID: 903
	[Register("java/nio/file/WatchEvent$Modifier", "", "Java.Nio.FileNio.IWatchEventModifierInvoker", ApiSince = 26)]
	public interface IWatchEventModifier : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002806 RID: 10246
		string Name();
	}
}
