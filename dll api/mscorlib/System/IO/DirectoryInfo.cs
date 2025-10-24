using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Exposes instance methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000542 RID: 1346
	[Serializable]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		// Token: 0x060027D5 RID: 10197 RVA: 0x0009F8C2 File Offset: 0x0009DAC2
		internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			this.Init(originalPath, fullPath, fileName, isNormalized);
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x0009F8D8 File Offset: 0x0009DAD8
		private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			if (originalPath == null)
			{
				throw new ArgumentNullException("path");
			}
			this.OriginalPath = originalPath;
			fullPath = (fullPath ?? originalPath);
			fullPath = (isNormalized ? fullPath : Path.GetFullPath(fullPath));
			this._name = (fileName ?? (PathInternal.IsRoot(fullPath) ? fullPath : Path.GetFileName(PathInternal.TrimEndingDirectorySeparator(fullPath.AsSpan()))).ToString());
			this.FullPath = fullPath;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0009F957 File Offset: 0x0009DB57
		private DirectoryInfo(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
