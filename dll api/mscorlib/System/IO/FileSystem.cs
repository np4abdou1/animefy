using System;
using System.Collections.Generic;

namespace System.IO
{
	// Token: 0x02000547 RID: 1351
	internal static class FileSystem
	{
		// Token: 0x060027FE RID: 10238 RVA: 0x0009FE78 File Offset: 0x0009E078
		public static void DeleteFile(string fullPath)
		{
			if (Interop.Sys.Unlink(fullPath) < 0)
			{
				Interop.ErrorInfo errorInfo = Interop.Sys.GetLastErrorInfo();
				Interop.Error error = errorInfo.Error;
				if (error != Interop.Error.EISDIR)
				{
					if (error == Interop.Error.ENOENT)
					{
						return;
					}
					if (error == Interop.Error.EROFS)
					{
						Interop.ErrorInfo errorInfo2;
						if (!FileSystem.FileExists(PathInternal.TrimEndingDirectorySeparator(fullPath), 32768, out errorInfo2) && errorInfo2.Error == Interop.Error.ENOENT)
						{
							return;
						}
					}
				}
				else
				{
					errorInfo = Interop.Error.EACCES.Info();
				}
				throw Interop.GetExceptionForIoErrno(errorInfo, fullPath, false);
			}
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x0009FEF4 File Offset: 0x0009E0F4
		public static void CreateDirectory(string fullPath)
		{
			int num = fullPath.Length;
			if (num >= 2 && PathInternal.EndsInDirectorySeparator(fullPath))
			{
				num--;
			}
			if (num == 2 && PathInternal.IsDirectorySeparator(fullPath[1]))
			{
				throw new IOException(SR.Format("The specified directory '{0}' cannot be created.", fullPath));
			}
			if (FileSystem.DirectoryExists(fullPath))
			{
				return;
			}
			bool flag = false;
			Stack<string> stack = new Stack<string>();
			int rootLength = PathInternal.GetRootLength(fullPath);
			if (num > rootLength)
			{
				int num2 = num - 1;
				while (num2 >= rootLength && !flag)
				{
					string text = fullPath.Substring(0, num2 + 1);
					if (!FileSystem.DirectoryExists(text))
					{
						stack.Push(text);
					}
					else
					{
						flag = true;
					}
					while (num2 > rootLength && !PathInternal.IsDirectorySeparator(fullPath[num2]))
					{
						num2--;
					}
					num2--;
				}
			}
			if (stack.Count == 0 && !flag)
			{
				if (!FileSystem.DirectoryExists(Directory.InternalGetDirectoryRoot(fullPath)))
				{
					throw Interop.GetExceptionForIoErrno(Interop.Error.ENOENT.Info(), fullPath, true);
				}
				return;
			}
			else
			{
				int num3 = 0;
				Interop.ErrorInfo errorInfo = default(Interop.ErrorInfo);
				string path = fullPath;
				while (stack.Count > 0)
				{
					string text2 = stack.Pop();
					num3 = Interop.Sys.MkDir(text2, 511);
					if (num3 < 0 && errorInfo.Error == Interop.Error.SUCCESS)
					{
						Interop.ErrorInfo lastErrorInfo = Interop.Sys.GetLastErrorInfo();
						if (lastErrorInfo.Error != Interop.Error.EEXIST)
						{
							errorInfo = lastErrorInfo;
						}
						else if (FileSystem.FileExists(text2) || (!FileSystem.DirectoryExists(text2, out lastErrorInfo) && lastErrorInfo.Error == Interop.Error.EACCES))
						{
							errorInfo = lastErrorInfo;
							path = text2;
						}
					}
				}
				if (num3 < 0 && errorInfo.Error != Interop.Error.SUCCESS)
				{
					throw Interop.GetExceptionForIoErrno(errorInfo, path, true);
				}
				return;
			}
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000A0094 File Offset: 0x0009E294
		public static bool DirectoryExists(ReadOnlySpan<char> fullPath)
		{
			Interop.ErrorInfo errorInfo;
			return FileSystem.DirectoryExists(fullPath, out errorInfo);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000A00A9 File Offset: 0x0009E2A9
		private static bool DirectoryExists(ReadOnlySpan<char> fullPath, out Interop.ErrorInfo errorInfo)
		{
			return FileSystem.FileExists(fullPath, 16384, out errorInfo);
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x000A00B8 File Offset: 0x0009E2B8
		public static bool FileExists(ReadOnlySpan<char> fullPath)
		{
			Interop.ErrorInfo errorInfo;
			return FileSystem.FileExists(PathInternal.TrimEndingDirectorySeparator(fullPath), 32768, out errorInfo);
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000A00D8 File Offset: 0x0009E2D8
		private static bool FileExists(ReadOnlySpan<char> fullPath, int fileType, out Interop.ErrorInfo errorInfo)
		{
			errorInfo = default(Interop.ErrorInfo);
			Interop.Sys.FileStatus fileStatus;
			if (Interop.Sys.Stat(fullPath, out fileStatus) < 0 && Interop.Sys.LStat(fullPath, out fileStatus) < 0)
			{
				errorInfo = Interop.Sys.GetLastErrorInfo();
				return false;
			}
			return fileType == 16384 == ((fileStatus.Mode & 61440) == 16384);
		}
	}
}
