using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio.Attributes
{
	// Token: 0x02000391 RID: 913
	[Register("java/nio/file/attribute/BasicFileAttributes", "", "Java.Nio.FileNio.Attributes.IBasicFileAttributesInvoker", ApiSince = 26)]
	public interface IBasicFileAttributes : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002866 RID: 10342
		bool IsDirectory { get; }

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002867 RID: 10343
		bool IsOther { get; }

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002868 RID: 10344
		bool IsRegularFile { get; }

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002869 RID: 10345
		bool IsSymbolicLink { get; }

		// Token: 0x0600286A RID: 10346
		FileTime CreationTime();

		// Token: 0x0600286B RID: 10347
		Java.Lang.Object FileKey();

		// Token: 0x0600286C RID: 10348
		FileTime LastAccessTime();

		// Token: 0x0600286D RID: 10349
		FileTime LastModifiedTime();

		// Token: 0x0600286E RID: 10350
		long Size();
	}
}
