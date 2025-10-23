using System;
using System.Security;
using Microsoft.Win32;

namespace System.IO
{
	// Token: 0x02000556 RID: 1366
	internal static class __Error
	{
		// Token: 0x06002882 RID: 10370 RVA: 0x000A11CE File Offset: 0x0009F3CE
		internal static void EndOfFile()
		{
			throw new EndOfStreamException(Environment.GetResourceString("Unable to read beyond the end of the stream."));
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000A11DF File Offset: 0x0009F3DF
		internal static void FileNotOpen()
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a closed file."));
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000A11F1 File Offset: 0x0009F3F1
		internal static void ReaderClosed()
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot read from a closed TextReader."));
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000A1204 File Offset: 0x0009F404
		[SecurityCritical]
		internal static string GetDisplayablePath(string path, bool isInvalidPath)
		{
			if (string.IsNullOrEmpty(path))
			{
				return string.Empty;
			}
			if (path.Length < 2)
			{
				return path;
			}
			if (PathInternal.IsPartiallyQualified(path) && !isInvalidPath)
			{
				return path;
			}
			bool flag = false;
			try
			{
				if (!isInvalidPath)
				{
					flag = true;
				}
			}
			catch (SecurityException)
			{
			}
			catch (ArgumentException)
			{
			}
			catch (NotSupportedException)
			{
			}
			if (!flag)
			{
				if (Path.IsDirectorySeparator(path[path.Length - 1]))
				{
					path = Environment.GetResourceString("<Path discovery permission to the specified directory was denied.>");
				}
				else
				{
					path = Path.GetFileName(path);
				}
			}
			return path;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000A12A0 File Offset: 0x0009F4A0
		[SecurityCritical]
		internal static void WinIOError(int errorCode, string maybeFullPath)
		{
			bool isInvalidPath = errorCode == 123 || errorCode == 161;
			string displayablePath = __Error.GetDisplayablePath(maybeFullPath, isInvalidPath);
			if (errorCode <= 80)
			{
				if (errorCode <= 15)
				{
					switch (errorCode)
					{
					case 2:
						if (displayablePath.Length == 0)
						{
							throw new FileNotFoundException(Environment.GetResourceString("Unable to find the specified file."));
						}
						throw new FileNotFoundException(Environment.GetResourceString("Could not find file '{0}'.", new object[]
						{
							displayablePath
						}), displayablePath);
					case 3:
						if (displayablePath.Length == 0)
						{
							throw new DirectoryNotFoundException(Environment.GetResourceString("Could not find a part of the path."));
						}
						throw new DirectoryNotFoundException(Environment.GetResourceString("Could not find a part of the path '{0}'.", new object[]
						{
							displayablePath
						}));
					case 4:
						break;
					case 5:
						if (displayablePath.Length == 0)
						{
							throw new UnauthorizedAccessException(Environment.GetResourceString("Access to the path is denied."));
						}
						throw new UnauthorizedAccessException(Environment.GetResourceString("Access to the path '{0}' is denied.", new object[]
						{
							displayablePath
						}));
					default:
						if (errorCode == 15)
						{
							throw new DriveNotFoundException(Environment.GetResourceString("Could not find the drive '{0}'. The drive might not be ready or might not be mapped.", new object[]
							{
								displayablePath
							}));
						}
						break;
					}
				}
				else if (errorCode != 32)
				{
					if (errorCode == 80)
					{
						if (displayablePath.Length != 0)
						{
							throw new IOException(Environment.GetResourceString("The file '{0}' already exists.", new object[]
							{
								displayablePath
							}), Win32Native.MakeHRFromErrorCode(errorCode));
						}
					}
				}
				else
				{
					if (displayablePath.Length == 0)
					{
						throw new IOException(Environment.GetResourceString("The process cannot access the file because it is being used by another process."), Win32Native.MakeHRFromErrorCode(errorCode));
					}
					throw new IOException(Environment.GetResourceString("The process cannot access the file '{0}' because it is being used by another process.", new object[]
					{
						displayablePath
					}), Win32Native.MakeHRFromErrorCode(errorCode));
				}
			}
			else if (errorCode <= 183)
			{
				if (errorCode == 87)
				{
					throw new IOException(Win32Native.GetMessage(errorCode), Win32Native.MakeHRFromErrorCode(errorCode));
				}
				if (errorCode == 183)
				{
					if (displayablePath.Length != 0)
					{
						throw new IOException(Environment.GetResourceString("Cannot create \"{0}\" because a file or directory with the same name already exists.", new object[]
						{
							displayablePath
						}), Win32Native.MakeHRFromErrorCode(errorCode));
					}
				}
			}
			else
			{
				if (errorCode == 206)
				{
					throw new PathTooLongException(Environment.GetResourceString("The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters."));
				}
				if (errorCode == 995)
				{
					throw new OperationCanceledException();
				}
			}
			throw new IOException(Win32Native.GetMessage(errorCode), Win32Native.MakeHRFromErrorCode(errorCode));
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000A14C0 File Offset: 0x0009F6C0
		internal static void WriterClosed()
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot write to a closed TextWriter."));
		}
	}
}
