using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Nio.FileNio.Attributes;

namespace Java.Nio.FileNio
{
	// Token: 0x0200037D RID: 893
	[Register("java/nio/file/FileVisitor", "", "Java.Nio.FileNio.IFileVisitorInvoker", ApiSince = 26)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IFileVisitor : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002749 RID: 10057
		FileVisitResult PostVisitDirectory(Java.Lang.Object dir, IOException exc);

		// Token: 0x0600274A RID: 10058
		FileVisitResult PreVisitDirectory(Java.Lang.Object dir, IBasicFileAttributes attrs);

		// Token: 0x0600274B RID: 10059
		FileVisitResult VisitFile(Java.Lang.Object file, IBasicFileAttributes attrs);

		// Token: 0x0600274C RID: 10060
		FileVisitResult VisitFileFailed(Java.Lang.Object file, IOException exc);
	}
}
