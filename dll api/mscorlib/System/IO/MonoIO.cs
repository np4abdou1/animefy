using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.IO
{
	// Token: 0x02000561 RID: 1377
	internal static class MonoIO
	{
		// Token: 0x06002919 RID: 10521 RVA: 0x000A3C9F File Offset: 0x000A1E9F
		public static Exception GetException(MonoIOError error)
		{
			if (error == MonoIOError.ERROR_ACCESS_DENIED)
			{
				return new UnauthorizedAccessException("Access to the path is denied.");
			}
			if (error != MonoIOError.ERROR_FILE_EXISTS)
			{
				return MonoIO.GetException(string.Empty, error);
			}
			return new IOException("Cannot create a file that already exist.", -2147024816);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000A3CD4 File Offset: 0x000A1ED4
		public static Exception GetException(string path, MonoIOError error)
		{
			if (error <= MonoIOError.ERROR_FILE_EXISTS)
			{
				if (error <= MonoIOError.ERROR_NOT_SAME_DEVICE)
				{
					switch (error)
					{
					case MonoIOError.ERROR_FILE_NOT_FOUND:
						return new FileNotFoundException(string.Format("Could not find file \"{0}\"", path), path);
					case MonoIOError.ERROR_PATH_NOT_FOUND:
						return new DirectoryNotFoundException(string.Format("Could not find a part of the path \"{0}\"", path));
					case MonoIOError.ERROR_TOO_MANY_OPEN_FILES:
						if (MonoIO.dump_handles)
						{
							MonoIO.DumpHandles();
						}
						return new IOException("Too many open files", (int)((MonoIOError)(-2147024896) | error));
					case MonoIOError.ERROR_ACCESS_DENIED:
						return new UnauthorizedAccessException(string.Format("Access to the path \"{0}\" is denied.", path));
					case MonoIOError.ERROR_INVALID_HANDLE:
						return new IOException(string.Format("Invalid handle to path \"{0}\"", path), (int)((MonoIOError)(-2147024896) | error));
					default:
						if (error == MonoIOError.ERROR_INVALID_DRIVE)
						{
							return new IOException(string.Format("Could not find the drive  '{0}'. The drive might not be ready or might not be mapped.", path), (int)((MonoIOError)(-2147024896) | error));
						}
						if (error == MonoIOError.ERROR_NOT_SAME_DEVICE)
						{
							return new IOException("Source and destination are not on the same device", (int)((MonoIOError)(-2147024896) | error));
						}
						break;
					}
				}
				else
				{
					switch (error)
					{
					case MonoIOError.ERROR_WRITE_FAULT:
						return new IOException(string.Format("Write fault on path {0}", path), (int)((MonoIOError)(-2147024896) | error));
					case MonoIOError.ERROR_READ_FAULT:
					case MonoIOError.ERROR_GEN_FAILURE:
						break;
					case MonoIOError.ERROR_SHARING_VIOLATION:
						return new IOException(string.Format("Sharing violation on path {0}", path), (int)((MonoIOError)(-2147024896) | error));
					case MonoIOError.ERROR_LOCK_VIOLATION:
						return new IOException(string.Format("Lock violation on path {0}", path), (int)((MonoIOError)(-2147024896) | error));
					default:
						if (error == MonoIOError.ERROR_HANDLE_DISK_FULL)
						{
							return new IOException(string.Format("Disk full. Path {0}", path), (int)((MonoIOError)(-2147024896) | error));
						}
						if (error == MonoIOError.ERROR_FILE_EXISTS)
						{
							return new IOException(string.Format("Could not create file \"{0}\". File already exists.", path), (int)((MonoIOError)(-2147024896) | error));
						}
						break;
					}
				}
			}
			else if (error <= MonoIOError.ERROR_DIR_NOT_EMPTY)
			{
				if (error == MonoIOError.ERROR_CANNOT_MAKE)
				{
					return new IOException(string.Format("Path {0} is a directory", path), (int)((MonoIOError)(-2147024896) | error));
				}
				if (error == MonoIOError.ERROR_INVALID_PARAMETER)
				{
					return new IOException(string.Format("Invalid parameter", Array.Empty<object>()), (int)((MonoIOError)(-2147024896) | error));
				}
				if (error == MonoIOError.ERROR_DIR_NOT_EMPTY)
				{
					return new IOException(string.Format("Directory {0} is not empty", path), (int)((MonoIOError)(-2147024896) | error));
				}
			}
			else
			{
				if (error == MonoIOError.ERROR_FILENAME_EXCED_RANGE)
				{
					return new PathTooLongException(string.Format("Path is too long. Path: {0}", path));
				}
				if (error == MonoIOError.ERROR_DIRECTORY)
				{
					return new IOException("The directory name is invalid", (int)((MonoIOError)(-2147024896) | error));
				}
				if (error == MonoIOError.ERROR_ENCRYPTION_FAILED)
				{
					return new IOException("Encryption failed", (int)((MonoIOError)(-2147024896) | error));
				}
			}
			return new IOException(string.Format("Win32 IO returned {0}. Path: {1}", error, path), (int)((MonoIOError)(-2147024896) | error));
		}

		// Token: 0x0600291B RID: 10523
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetCurrentDirectory(out MonoIOError error);

		// Token: 0x0600291C RID: 10524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern MonoFileType GetFileType(IntPtr handle, out MonoIOError error);

		// Token: 0x0600291D RID: 10525 RVA: 0x000A3F48 File Offset: 0x000A2148
		public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error)
		{
			bool flag = false;
			MonoFileType fileType;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				fileType = MonoIO.GetFileType(safeHandle.DangerousGetHandle(), out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return fileType;
		}

		// Token: 0x0600291E RID: 10526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error);

		// Token: 0x0600291F RID: 10527 RVA: 0x000A3F8C File Offset: 0x000A218C
		public unsafe static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			char* ptr = filename;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return MonoIO.Open(ptr, mode, access, share, options, out error);
		}

		// Token: 0x06002920 RID: 10528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Cancel_internal(IntPtr handle, out MonoIOError error);

		// Token: 0x06002921 RID: 10529 RVA: 0x000A3FB8 File Offset: 0x000A21B8
		internal static bool Cancel(SafeHandle safeHandle, out MonoIOError error)
		{
			bool flag = false;
			bool result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = MonoIO.Cancel_internal(safeHandle.DangerousGetHandle(), out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06002922 RID: 10530
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Close(IntPtr handle, out MonoIOError error);

		// Token: 0x06002923 RID: 10531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error);

		// Token: 0x06002924 RID: 10532 RVA: 0x000A3FFC File Offset: 0x000A21FC
		public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error)
		{
			bool flag = false;
			int result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = MonoIO.Read(safeHandle.DangerousGetHandle(), dest, dest_offset, count, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06002925 RID: 10533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error);

		// Token: 0x06002926 RID: 10534 RVA: 0x000A4044 File Offset: 0x000A2244
		public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error)
		{
			bool flag = false;
			int result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = MonoIO.Write(safeHandle.DangerousGetHandle(), src, src_offset, count, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06002927 RID: 10535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error);

		// Token: 0x06002928 RID: 10536 RVA: 0x000A408C File Offset: 0x000A228C
		public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			bool flag = false;
			long result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = MonoIO.Seek(safeHandle.DangerousGetHandle(), offset, origin, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06002929 RID: 10537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long GetLength(IntPtr handle, out MonoIOError error);

		// Token: 0x0600292A RID: 10538 RVA: 0x000A40D0 File Offset: 0x000A22D0
		public static long GetLength(SafeHandle safeHandle, out MonoIOError error)
		{
			bool flag = false;
			long length;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				length = MonoIO.GetLength(safeHandle.DangerousGetHandle(), out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return length;
		}

		// Token: 0x0600292B RID: 10539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SetLength(IntPtr handle, long length, out MonoIOError error);

		// Token: 0x0600292C RID: 10540 RVA: 0x000A4114 File Offset: 0x000A2314
		public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error)
		{
			bool flag = false;
			bool result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = MonoIO.SetLength(safeHandle.DangerousGetHandle(), length, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600292D RID: 10541
		public static extern IntPtr ConsoleOutput { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600292E RID: 10542
		public static extern IntPtr ConsoleInput { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600292F RID: 10543
		public static extern IntPtr ConsoleError { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002930 RID: 10544
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error);

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002931 RID: 10545
		public static extern char VolumeSeparatorChar { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002932 RID: 10546
		public static extern char DirectorySeparatorChar { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002933 RID: 10547
		public static extern char AltDirectorySeparatorChar { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002934 RID: 10548
		public static extern char PathSeparator { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002935 RID: 10549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DumpHandles();

		// Token: 0x04001561 RID: 5473
		public static readonly IntPtr InvalidHandle = (IntPtr)(-1L);

		// Token: 0x04001562 RID: 5474
		private static bool dump_handles = Environment.GetEnvironmentVariable("MONO_DUMP_HANDLES_ON_ERROR_TOO_MANY_OPEN_FILES") != null;
	}
}
