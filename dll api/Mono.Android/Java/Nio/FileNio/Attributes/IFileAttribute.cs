using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio.Attributes
{
	// Token: 0x02000393 RID: 915
	[Register("java/nio/file/attribute/FileAttribute", "", "Java.Nio.FileNio.Attributes.IFileAttributeInvoker", ApiSince = 26)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IFileAttribute : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002892 RID: 10386
		string Name();

		// Token: 0x06002893 RID: 10387
		Java.Lang.Object Value();
	}
}
