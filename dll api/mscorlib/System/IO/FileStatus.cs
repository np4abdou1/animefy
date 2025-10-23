using System;

namespace System.IO
{
	// Token: 0x02000546 RID: 1350
	internal struct FileStatus
	{
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x0009FBF9 File Offset: 0x0009DDF9
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x0009FC01 File Offset: 0x0009DE01
		internal bool InitiallyDirectory { readonly get; private set; }

		// Token: 0x060027F7 RID: 10231 RVA: 0x0009FC0A File Offset: 0x0009DE0A
		internal static void Initialize(ref FileStatus status, bool isDirectory)
		{
			status.InitiallyDirectory = isDirectory;
			status._fileStatusInitialized = -1;
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0009FC1C File Offset: 0x0009DE1C
		internal bool IsReadOnly(ReadOnlySpan<char> path, bool continueOnError = false)
		{
			this.EnsureStatInitialized(path, continueOnError);
			Interop.Sys.Permissions permissions;
			Interop.Sys.Permissions permissions2;
			if (this._fileStatus.Uid == Interop.Sys.GetEUid())
			{
				permissions = Interop.Sys.Permissions.S_IRUSR;
				permissions2 = Interop.Sys.Permissions.S_IWUSR;
			}
			else if (this._fileStatus.Gid == Interop.Sys.GetEGid())
			{
				permissions = Interop.Sys.Permissions.S_IRGRP;
				permissions2 = Interop.Sys.Permissions.S_IWGRP;
			}
			else
			{
				permissions = Interop.Sys.Permissions.S_IROTH;
				permissions2 = Interop.Sys.Permissions.S_IWOTH;
			}
			return (this._fileStatus.Mode & (int)permissions) != 0 && (this._fileStatus.Mode & (int)permissions2) == 0;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x0009FC90 File Offset: 0x0009DE90
		public unsafe FileAttributes GetAttributes(ReadOnlySpan<char> path, ReadOnlySpan<char> fileName)
		{
			this.EnsureStatInitialized(path, false);
			if (!this._exists)
			{
				return (FileAttributes)(-1);
			}
			FileAttributes fileAttributes = (FileAttributes)0;
			if (this.IsReadOnly(path, false))
			{
				fileAttributes |= FileAttributes.ReadOnly;
			}
			if ((this._fileStatus.Mode & 61440) == 40960)
			{
				fileAttributes |= FileAttributes.ReparsePoint;
			}
			if (this._isDirectory)
			{
				fileAttributes |= FileAttributes.Directory;
			}
			if (fileName.Length > 0 && (*fileName[0] == 46 || (this._fileStatus.UserFlags & 32768U) == 32768U))
			{
				fileAttributes |= FileAttributes.Hidden;
			}
			if (fileAttributes == (FileAttributes)0)
			{
				return FileAttributes.Normal;
			}
			return fileAttributes;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x0009FD29 File Offset: 0x0009DF29
		internal bool GetExists(ReadOnlySpan<char> path)
		{
			if (this._fileStatusInitialized == -1)
			{
				this.Refresh(path);
			}
			return this._exists && this.InitiallyDirectory == this._isDirectory;
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x0009FD53 File Offset: 0x0009DF53
		internal long GetLength(ReadOnlySpan<char> path, bool continueOnError = false)
		{
			this.EnsureStatInitialized(path, continueOnError);
			return this._fileStatus.Size;
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x0009FD68 File Offset: 0x0009DF68
		public void Refresh(ReadOnlySpan<char> path)
		{
			this._isDirectory = false;
			path = PathInternal.TrimEndingDirectorySeparator(path);
			if (Interop.Sys.LStat(path, out this._fileStatus) >= 0)
			{
				this._exists = true;
				this._isDirectory = ((this._fileStatus.Mode & 61440) == 16384);
				Interop.Sys.FileStatus fileStatus;
				if ((this._fileStatus.Mode & 61440) == 40960 && Interop.Sys.Stat(path, out fileStatus) >= 0)
				{
					this._isDirectory = ((fileStatus.Mode & 61440) == 16384);
				}
				this._fileStatusInitialized = 0;
				return;
			}
			Interop.ErrorInfo lastErrorInfo = Interop.Sys.GetLastErrorInfo();
			if (lastErrorInfo.Error == Interop.Error.ENOENT || lastErrorInfo.Error == Interop.Error.ENOTDIR)
			{
				this._fileStatusInitialized = 0;
				this._exists = false;
				return;
			}
			this._fileStatusInitialized = lastErrorInfo.RawErrno;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x0009FE3A File Offset: 0x0009E03A
		internal void EnsureStatInitialized(ReadOnlySpan<char> path, bool continueOnError = false)
		{
			if (this._fileStatusInitialized == -1)
			{
				this.Refresh(path);
			}
			if (this._fileStatusInitialized != 0 && !continueOnError)
			{
				int fileStatusInitialized = this._fileStatusInitialized;
				this._fileStatusInitialized = -1;
				throw Interop.GetExceptionForIoErrno(new Interop.ErrorInfo(fileStatusInitialized), new string(path), false);
			}
		}

		// Token: 0x040014D4 RID: 5332
		private Interop.Sys.FileStatus _fileStatus;

		// Token: 0x040014D5 RID: 5333
		private int _fileStatusInitialized;

		// Token: 0x040014D7 RID: 5335
		internal bool _isDirectory;

		// Token: 0x040014D8 RID: 5336
		private bool _exists;
	}
}
