using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Net;
using Java.Util;

namespace Java.Nio.FileNio
{
	// Token: 0x02000381 RID: 897
	[Register("java/nio/file/Path", "", "Java.Nio.FileNio.IPathInvoker", ApiSince = 26)]
	public interface IPath : Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable, IIterable, IWatchable
	{
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002769 RID: 10089
		IPath FileName { get; }

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600276A RID: 10090
		FileSystem FileSystem { get; }

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600276B RID: 10091
		bool IsAbsolute { get; }

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600276C RID: 10092
		int NameCount { get; }

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600276D RID: 10093
		IPath Parent { get; }

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600276E RID: 10094
		IPath Root { get; }

		// Token: 0x0600276F RID: 10095
		int CompareTo(IPath other);

		// Token: 0x06002770 RID: 10096
		bool EndsWith(string other);

		// Token: 0x06002771 RID: 10097
		bool EndsWith(IPath other);

		// Token: 0x06002772 RID: 10098
		bool Equals(Java.Lang.Object other);

		// Token: 0x06002773 RID: 10099
		IPath GetName(int index);

		// Token: 0x06002774 RID: 10100
		int GetHashCode();

		// Token: 0x06002775 RID: 10101
		IIterator Iterator();

		// Token: 0x06002776 RID: 10102
		IPath Normalize();

		// Token: 0x06002777 RID: 10103
		IWatchKey Register(IWatchService watcher, params IWatchEventKind[] events);

		// Token: 0x06002778 RID: 10104
		IWatchKey Register(IWatchService watcher, IWatchEventKind[] events, params IWatchEventModifier[] modifiers);

		// Token: 0x06002779 RID: 10105
		IPath Relativize(IPath other);

		// Token: 0x0600277A RID: 10106
		IPath Resolve(string other);

		// Token: 0x0600277B RID: 10107
		IPath Resolve(IPath other);

		// Token: 0x0600277C RID: 10108
		IPath ResolveSibling(string other);

		// Token: 0x0600277D RID: 10109
		IPath ResolveSibling(IPath other);

		// Token: 0x0600277E RID: 10110
		bool StartsWith(string other);

		// Token: 0x0600277F RID: 10111
		bool StartsWith(IPath other);

		// Token: 0x06002780 RID: 10112
		IPath Subpath(int beginIndex, int endIndex);

		// Token: 0x06002781 RID: 10113
		IPath ToAbsolutePath();

		// Token: 0x06002782 RID: 10114
		File ToFile();

		// Token: 0x06002783 RID: 10115
		IPath ToRealPath(params LinkOption[] options);

		// Token: 0x06002784 RID: 10116
		string ToString();

		// Token: 0x06002785 RID: 10117
		URI ToUri();
	}
}
