using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace System.IO.Enumeration
{
	// Token: 0x02000574 RID: 1396
	public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		// Token: 0x06002997 RID: 10647 RVA: 0x000A5C30 File Offset: 0x000A3E30
		public FileSystemEnumerator(string directory, EnumerationOptions options = null)
		{
			if (directory == null)
			{
				throw new ArgumentNullException("directory");
			}
			this._originalRootDirectory = directory;
			this._rootDirectory = PathInternal.TrimEndingDirectorySeparator(Path.GetFullPath(directory));
			this._options = (options ?? EnumerationOptions.Default);
			this._directoryHandle = this.CreateDirectoryHandle(this._rootDirectory, false);
			if (this._directoryHandle == IntPtr.Zero)
			{
				this._lastEntryFound = true;
			}
			this._currentPath = this._rootDirectory;
			try
			{
				this._pathBuffer = ArrayPool<char>.Shared.Rent(4096);
				int readDirRBufferSize = Interop.Sys.GetReadDirRBufferSize();
				this._entryBuffer = ((readDirRBufferSize > 0) ? ArrayPool<byte>.Shared.Rent(readDirRBufferSize) : null);
			}
			catch
			{
				this.CloseDirectoryHandle();
				throw;
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000A5D0C File Offset: 0x000A3F0C
		private bool InternalContinueOnError(Interop.ErrorInfo info, bool ignoreNotFound = false)
		{
			return (ignoreNotFound && FileSystemEnumerator<TResult>.IsDirectoryNotFound(info)) || (this._options.IgnoreInaccessible && FileSystemEnumerator<TResult>.IsAccessError(info)) || this.ContinueOnError(info.RawErrno);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000A5D3D File Offset: 0x000A3F3D
		private static bool IsDirectoryNotFound(Interop.ErrorInfo info)
		{
			return info.Error == Interop.Error.ENOTDIR || info.Error == Interop.Error.ENOENT;
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000A5D5D File Offset: 0x000A3F5D
		private static bool IsAccessError(Interop.ErrorInfo info)
		{
			return info.Error == Interop.Error.EACCES || info.Error == Interop.Error.EBADF || info.Error == Interop.Error.EPERM;
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000A5D8C File Offset: 0x000A3F8C
		private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false)
		{
			IntPtr intPtr = Interop.Sys.OpenDir(path);
			if (!(intPtr == IntPtr.Zero))
			{
				return intPtr;
			}
			Interop.ErrorInfo lastErrorInfo = Interop.Sys.GetLastErrorInfo();
			if (this.InternalContinueOnError(lastErrorInfo, ignoreNotFound))
			{
				return IntPtr.Zero;
			}
			throw Interop.GetExceptionForIoErrno(lastErrorInfo, path, true);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000A5DD0 File Offset: 0x000A3FD0
		private void CloseDirectoryHandle()
		{
			IntPtr intPtr = Interlocked.Exchange(ref this._directoryHandle, IntPtr.Zero);
			if (intPtr != IntPtr.Zero)
			{
				Interop.Sys.CloseDir(intPtr);
			}
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x000A5E04 File Offset: 0x000A4004
		public unsafe bool MoveNext()
		{
			if (this._lastEntryFound)
			{
				return false;
			}
			FileSystemEntry fileSystemEntry = default(FileSystemEntry);
			object @lock = this._lock;
			bool result;
			lock (@lock)
			{
				if (this._lastEntryFound)
				{
					result = false;
				}
				else
				{
					byte[] entryBuffer;
					byte* entryBufferPtr;
					if ((entryBuffer = this._entryBuffer) == null || entryBuffer.Length == 0)
					{
						entryBufferPtr = null;
					}
					else
					{
						entryBufferPtr = &entryBuffer[0];
					}
					for (;;)
					{
						this.FindNextEntry(entryBufferPtr, (this._entryBuffer == null) ? 0 : this._entryBuffer.Length);
						if (this._lastEntryFound)
						{
							break;
						}
						FileAttributes fileAttributes = FileSystemEntry.Initialize(ref fileSystemEntry, this._entry, this._currentPath, this._rootDirectory, this._originalRootDirectory, new Span<char>(this._pathBuffer));
						bool flag2 = (fileAttributes & FileAttributes.Directory) > (FileAttributes)0;
						bool flag3 = false;
						if (flag2 && *this._entry.Name == 46 && (this._entry.Name[1] == 0 || (this._entry.Name[1] == 46 && this._entry.Name[2] == 0)))
						{
							if (!this._options.ReturnSpecialDirectories)
							{
								continue;
							}
							flag3 = true;
						}
						if (!flag3 && this._options.AttributesToSkip != (FileAttributes)0)
						{
							if ((this._options.AttributesToSkip & FileAttributes.ReadOnly) != (FileAttributes)0)
							{
								fileAttributes = fileSystemEntry.Attributes;
							}
							if ((this._options.AttributesToSkip & fileAttributes) != (FileAttributes)0)
							{
								continue;
							}
						}
						if (flag2 && !flag3 && this._options.RecurseSubdirectories && this.ShouldRecurseIntoEntry(ref fileSystemEntry))
						{
							if (this._pending == null)
							{
								this._pending = new Queue<string>();
							}
							this._pending.Enqueue(Path.Join(this._currentPath, fileSystemEntry.FileName));
						}
						if (this.ShouldIncludeEntry(ref fileSystemEntry))
						{
							goto Block_21;
						}
					}
					return false;
					Block_21:
					this._current = this.TransformEntry(ref fileSystemEntry);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000A6008 File Offset: 0x000A4208
		private unsafe void FindNextEntry()
		{
			byte[] array;
			byte* entryBufferPtr;
			if ((array = this._entryBuffer) == null || array.Length == 0)
			{
				entryBufferPtr = null;
			}
			else
			{
				entryBufferPtr = &array[0];
			}
			this.FindNextEntry(entryBufferPtr, (this._entryBuffer == null) ? 0 : this._entryBuffer.Length);
			array = null;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000A6050 File Offset: 0x000A4250
		private unsafe void FindNextEntry(byte* entryBufferPtr, int bufferLength)
		{
			int num = Interop.Sys.ReadDirR(this._directoryHandle, entryBufferPtr, bufferLength, out this._entry);
			if (num == -1)
			{
				this.DirectoryFinished();
				return;
			}
			if (num == 0)
			{
				return;
			}
			if (this.InternalContinueOnError(new Interop.ErrorInfo(num), false))
			{
				this.DirectoryFinished();
				return;
			}
			throw Interop.GetExceptionForIoErrno(new Interop.ErrorInfo(num), this._currentPath, true);
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000A60AC File Offset: 0x000A42AC
		private bool DequeueNextDirectory()
		{
			this._directoryHandle = IntPtr.Zero;
			while (this._directoryHandle == IntPtr.Zero)
			{
				if (this._pending == null || this._pending.Count == 0)
				{
					return false;
				}
				this._currentPath = this._pending.Dequeue();
				this._directoryHandle = this.CreateDirectoryHandle(this._currentPath, true);
			}
			return true;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000A6114 File Offset: 0x000A4314
		private void InternalDispose(bool disposing)
		{
			if (this._lock != null)
			{
				object @lock = this._lock;
				lock (@lock)
				{
					this._lastEntryFound = true;
					this._pending = null;
					this.CloseDirectoryHandle();
					if (this._pathBuffer != null)
					{
						ArrayPool<char>.Shared.Return(this._pathBuffer, false);
					}
					this._pathBuffer = null;
					if (this._entryBuffer != null)
					{
						ArrayPool<byte>.Shared.Return(this._entryBuffer, false);
					}
					this._entryBuffer = null;
				}
			}
			this.Dispose(disposing);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x0000B18D File Offset: 0x0000938D
		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry)
		{
			return true;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x0000B18D File Offset: 0x0000938D
		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
		{
			return true;
		}

		// Token: 0x060029A4 RID: 10660
		protected abstract TResult TransformEntry(ref FileSystemEntry entry);

		// Token: 0x060029A5 RID: 10661 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory)
		{
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected virtual bool ContinueOnError(int error)
		{
			return false;
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x000A61B4 File Offset: 0x000A43B4
		public TResult Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x000A61BC File Offset: 0x000A43BC
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000A61C9 File Offset: 0x000A43C9
		private void DirectoryFinished()
		{
			this._entry = default(Interop.Sys.DirectoryEntry);
			this.CloseDirectoryHandle();
			this.OnDirectoryFinished(this._currentPath);
			if (!this.DequeueNextDirectory())
			{
				this._lastEntryFound = true;
				return;
			}
			this.FindNextEntry();
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x0002AD12 File Offset: 0x00028F12
		public void Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x000A6204 File Offset: 0x000A4404
		public void Dispose()
		{
			this.InternalDispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000A6214 File Offset: 0x000A4414
		~FileSystemEnumerator()
		{
			this.InternalDispose(false);
		}

		// Token: 0x040015B0 RID: 5552
		private readonly string _originalRootDirectory;

		// Token: 0x040015B1 RID: 5553
		private readonly string _rootDirectory;

		// Token: 0x040015B2 RID: 5554
		private readonly EnumerationOptions _options;

		// Token: 0x040015B3 RID: 5555
		private readonly object _lock = new object();

		// Token: 0x040015B4 RID: 5556
		private string _currentPath;

		// Token: 0x040015B5 RID: 5557
		private IntPtr _directoryHandle;

		// Token: 0x040015B6 RID: 5558
		private bool _lastEntryFound;

		// Token: 0x040015B7 RID: 5559
		private Queue<string> _pending;

		// Token: 0x040015B8 RID: 5560
		private Interop.Sys.DirectoryEntry _entry;

		// Token: 0x040015B9 RID: 5561
		private TResult _current;

		// Token: 0x040015BA RID: 5562
		private char[] _pathBuffer;

		// Token: 0x040015BB RID: 5563
		private byte[] _entryBuffer;
	}
}
