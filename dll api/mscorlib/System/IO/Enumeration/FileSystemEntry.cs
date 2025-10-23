using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.IO.Enumeration
{
	// Token: 0x02000569 RID: 1385
	public ref struct FileSystemEntry
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x000A5580 File Offset: 0x000A3780
		internal unsafe static FileAttributes Initialize(ref FileSystemEntry entry, Interop.Sys.DirectoryEntry directoryEntry, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory, Span<char> pathBuffer)
		{
			entry._directoryEntry = directoryEntry;
			entry.Directory = directory;
			entry.RootDirectory = rootDirectory;
			entry.OriginalRootDirectory = originalRootDirectory;
			entry._pathBuffer = pathBuffer;
			entry._fullPath = ReadOnlySpan<char>.Empty;
			entry._fileName = ReadOnlySpan<char>.Empty;
			bool flag = false;
			bool flag2 = false;
			Interop.Sys.FileStatus fileStatus;
			if (directoryEntry.InodeType == Interop.Sys.NodeType.DT_DIR)
			{
				flag = true;
			}
			else if ((directoryEntry.InodeType == Interop.Sys.NodeType.DT_LNK || directoryEntry.InodeType == Interop.Sys.NodeType.DT_UNKNOWN) && (Interop.Sys.Stat(entry.FullPath, out fileStatus) >= 0 || Interop.Sys.LStat(entry.FullPath, out fileStatus) >= 0))
			{
				flag = ((fileStatus.Mode & 61440) == 16384);
			}
			Interop.Sys.FileStatus fileStatus2;
			if (directoryEntry.InodeType == Interop.Sys.NodeType.DT_LNK)
			{
				flag2 = true;
			}
			else if (directoryEntry.InodeType == Interop.Sys.NodeType.DT_UNKNOWN && Interop.Sys.LStat(entry.FullPath, out fileStatus2) >= 0)
			{
				flag2 = ((fileStatus2.Mode & 61440) == 40960);
			}
			entry._status = default(FileStatus);
			FileStatus.Initialize(ref entry._status, flag);
			FileAttributes fileAttributes = (FileAttributes)0;
			if (flag2)
			{
				fileAttributes |= FileAttributes.ReparsePoint;
			}
			if (flag)
			{
				fileAttributes |= FileAttributes.Directory;
			}
			if (*directoryEntry.Name == 46)
			{
				fileAttributes |= FileAttributes.Hidden;
			}
			if (fileAttributes == (FileAttributes)0)
			{
				fileAttributes = FileAttributes.Normal;
			}
			entry._initialAttributes = fileAttributes;
			return fileAttributes;
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x000A56A8 File Offset: 0x000A38A8
		private ReadOnlySpan<char> FullPath
		{
			get
			{
				if (this._fullPath.Length == 0)
				{
					int length;
					Path.TryJoin(this.Directory, this.FileName, this._pathBuffer, out length);
					this._fullPath = this._pathBuffer.Slice(0, length);
				}
				return this._fullPath;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000A56FC File Offset: 0x000A38FC
		public unsafe ReadOnlySpan<char> FileName
		{
			get
			{
				if (this._directoryEntry.NameLength != 0 && this._fileName.Length == 0)
				{
					fixed (char* ptr = &this._fileNameBuffer.FixedElementField)
					{
						char* pointer = ptr;
						Span<char> buffer = new Span<char>((void*)pointer, 256);
						this._fileName = this._directoryEntry.GetName(buffer);
					}
				}
				return this._fileName;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x000A575A File Offset: 0x000A395A
		// (set) Token: 0x0600296C RID: 10604 RVA: 0x000A5762 File Offset: 0x000A3962
		public ReadOnlySpan<char> Directory { readonly get; private set; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x000A576B File Offset: 0x000A396B
		// (set) Token: 0x0600296E RID: 10606 RVA: 0x000A5773 File Offset: 0x000A3973
		public ReadOnlySpan<char> RootDirectory { readonly get; private set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x000A577C File Offset: 0x000A397C
		// (set) Token: 0x06002970 RID: 10608 RVA: 0x000A5784 File Offset: 0x000A3984
		public ReadOnlySpan<char> OriginalRootDirectory { readonly get; private set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x000A578D File Offset: 0x000A398D
		public FileAttributes Attributes
		{
			get
			{
				return this._initialAttributes | (this._status.IsReadOnly(this.FullPath, true) ? FileAttributes.ReadOnly : ((FileAttributes)0));
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x000A57AE File Offset: 0x000A39AE
		public bool IsDirectory
		{
			get
			{
				return this._status.InitiallyDirectory;
			}
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000A57BC File Offset: 0x000A39BC
		public string ToSpecifiedFullPath()
		{
			ReadOnlySpan<char> readOnlySpan = this.Directory.Slice(this.RootDirectory.Length);
			if (PathInternal.EndsInDirectorySeparator(this.OriginalRootDirectory) && PathInternal.StartsWithDirectorySeparator(readOnlySpan))
			{
				readOnlySpan = readOnlySpan.Slice(1);
			}
			return Path.Join(this.OriginalRootDirectory, readOnlySpan, this.FileName);
		}

		// Token: 0x04001593 RID: 5523
		internal Interop.Sys.DirectoryEntry _directoryEntry;

		// Token: 0x04001594 RID: 5524
		private FileStatus _status;

		// Token: 0x04001595 RID: 5525
		private Span<char> _pathBuffer;

		// Token: 0x04001596 RID: 5526
		private ReadOnlySpan<char> _fullPath;

		// Token: 0x04001597 RID: 5527
		private ReadOnlySpan<char> _fileName;

		// Token: 0x04001598 RID: 5528
		[FixedBuffer(typeof(char), 256)]
		private FileSystemEntry.<_fileNameBuffer>e__FixedBuffer _fileNameBuffer;

		// Token: 0x04001599 RID: 5529
		private FileAttributes _initialAttributes;

		// Token: 0x0200056A RID: 1386
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(0, Size = 512)]
		public struct <_fileNameBuffer>e__FixedBuffer
		{
			// Token: 0x0400159D RID: 5533
			public char FixedElementField;
		}
	}
}
