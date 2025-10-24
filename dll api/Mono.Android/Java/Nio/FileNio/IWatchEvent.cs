using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x02000389 RID: 905
	[Register("java/nio/file/WatchEvent", "", "Java.Nio.FileNio.IWatchEventInvoker", ApiSince = 26)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IWatchEvent : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002812 RID: 10258
		Java.Lang.Object Context();

		// Token: 0x06002813 RID: 10259
		int Count();

		// Token: 0x06002814 RID: 10260
		IWatchEventKind Kind();
	}
}
