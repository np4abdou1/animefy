using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Provides properties and instance methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of <see cref="T:System.IO.FileStream" /> objects. This class cannot be inherited.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000545 RID: 1349
	[Serializable]
	public sealed class FileInfo : FileSystemInfo
	{
		// Token: 0x060027EC RID: 10220 RVA: 0x0009FB20 File Offset: 0x0009DD20
		private FileInfo()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileInfo" /> class, which acts as a wrapper for a file path.</summary>
		/// <param name="fileName">The fully qualified name of the new file, or the relative file name. Do not end the path with the directory separator character.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="fileName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">The file name is empty, contains only white spaces, or contains invalid characters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Access to <paramref name="fileName" /> is denied. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="fileName" /> contains a colon (:) in the middle of the string. </exception>
		// Token: 0x060027ED RID: 10221 RVA: 0x0009FB28 File Offset: 0x0009DD28
		public FileInfo(string fileName) : this(fileName, null, null, false)
		{
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x0009FB34 File Offset: 0x0009DD34
		internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			if (originalPath == null)
			{
				throw new ArgumentNullException("fileName");
			}
			this.OriginalPath = originalPath;
			fullPath = (fullPath ?? originalPath);
			this.FullPath = (isNormalized ? (fullPath ?? originalPath) : Path.GetFullPath(fullPath));
			this._name = (fileName ?? Path.GetFileName(originalPath));
		}

		/// <summary>Gets the size, in bytes, of the current file.</summary>
		/// <returns>The size of the current file in bytes.</returns>
		/// <exception cref="T:System.IO.IOException">
		///         <see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot update the state of the file or directory. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file does not exist.-or- The <see langword="Length" /> property is called for a directory. </exception>
		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x0009FB8E File Offset: 0x0009DD8E
		public long Length
		{
			get
			{
				if ((base.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
				{
					throw new FileNotFoundException(SR.Format("Could not find file '{0}'.", this.FullPath), this.FullPath);
				}
				return base.LengthCore;
			}
		}

		/// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that writes a new text file.</summary>
		/// <returns>A new <see langword="StreamWriter" />.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The file name is a directory. </exception>
		/// <exception cref="T:System.IO.IOException">The disk is read-only. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x060027F0 RID: 10224 RVA: 0x0009FBBF File Offset: 0x0009DDBF
		public StreamWriter CreateText()
		{
			return new StreamWriter(base.NormalizedPath, false);
		}

		/// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that appends text to the file represented by this instance of the <see cref="T:System.IO.FileInfo" />.</summary>
		/// <returns>A new <see langword="StreamWriter" />.</returns>
		// Token: 0x060027F1 RID: 10225 RVA: 0x0009FBCD File Offset: 0x0009DDCD
		public StreamWriter AppendText()
		{
			return new StreamWriter(base.NormalizedPath, true);
		}

		/// <summary>Creates a read-only <see cref="T:System.IO.FileStream" />.</summary>
		/// <returns>A new read-only <see cref="T:System.IO.FileStream" /> object.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> is read-only or is a directory. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">The file is already open. </exception>
		// Token: 0x060027F2 RID: 10226 RVA: 0x0009FBDB File Offset: 0x0009DDDB
		public FileStream OpenRead()
		{
			return new FileStream(base.NormalizedPath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, false);
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x0009F957 File Offset: 0x0009DB57
		private FileInfo(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Gets the name of the file.</summary>
		/// <returns>The name of the file.</returns>
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x0009FBF1 File Offset: 0x0009DDF1
		public override string Name
		{
			get
			{
				return this._name;
			}
		}
	}
}
