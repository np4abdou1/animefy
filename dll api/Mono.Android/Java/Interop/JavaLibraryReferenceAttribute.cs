using System;
using Android;

namespace Java.Interop
{
	// Token: 0x02000437 RID: 1079
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class JavaLibraryReferenceAttribute : ReferenceFilesAttribute
	{
		// Token: 0x06002F11 RID: 12049 RVA: 0x000831E0 File Offset: 0x000813E0
		public JavaLibraryReferenceAttribute(string filename)
		{
			this.LibraryFileName = filename;
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x000831EF File Offset: 0x000813EF
		// (set) Token: 0x06002F13 RID: 12051 RVA: 0x000831F7 File Offset: 0x000813F7
		public string LibraryFileName { get; private set; }
	}
}
