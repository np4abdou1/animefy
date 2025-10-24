using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Nio.FileNio;

namespace Kotlin.IO.Path
{
	// Token: 0x0200022B RID: 555
	[Register("kotlin/io/path/CopyActionContext", "", "Kotlin.IO.Path.ICopyActionContextInvoker")]
	public interface ICopyActionContext : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060019BB RID: 6587
		[NullableContext(1)]
		[Register("copyToIgnoringExistingDirectory", "(Ljava/nio/file/Path;Ljava/nio/file/Path;Z)Lkotlin/io/path/CopyActionResult;", "GetCopyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_ZHandler:Kotlin.IO.Path.ICopyActionContextInvoker, Xamarin.Kotlin.StdLib")]
		CopyActionResult CopyToIgnoringExistingDirectory(IPath p0, IPath target, bool followLinks);
	}
}
