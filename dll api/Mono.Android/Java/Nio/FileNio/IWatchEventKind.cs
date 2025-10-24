using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x02000385 RID: 901
	[Register("java/nio/file/WatchEvent$Kind", "", "Java.Nio.FileNio.IWatchEventKindInvoker", ApiSince = 26)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IWatchEventKind : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060027F6 RID: 10230
		string Name();

		// Token: 0x060027F7 RID: 10231
		Class Type();
	}
}
