using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Provides the base class for both <see cref="T:System.IO.FileInfo" /> and <see cref="T:System.IO.DirectoryInfo" /> objects.</summary>
	// Token: 0x02000548 RID: 1352
	[Serializable]
	public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileSystemInfo" /> class.</summary>
		// Token: 0x06002804 RID: 10244 RVA: 0x000A012C File Offset: 0x0009E32C
		protected FileSystemInfo()
		{
			FileStatus.Initialize(ref this._fileStatus, this is DirectoryInfo);
		}

		/// <summary>Gets or sets the attributes for the current file or directory.</summary>
		/// <returns>
		///     <see cref="T:System.IO.FileAttributes" /> of the current <see cref="T:System.IO.FileSystemInfo" />.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">The specified file does not exist. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid; for example, it is on an unmapped drive. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">The caller attempts to set an invalid file attribute. -or-The user attempts to set an attribute value but does not have write permission.</exception>
		/// <exception cref="T:System.IO.IOException">
		///         <see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot initialize the data. </exception>
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x000A0148 File Offset: 0x0009E348
		public FileAttributes Attributes
		{
			get
			{
				return this._fileStatus.GetAttributes(this.FullPath, this.Name);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x000A016B File Offset: 0x0009E36B
		internal bool ExistsCore
		{
			get
			{
				return this._fileStatus.GetExists(this.FullPath);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x000A0183 File Offset: 0x0009E383
		internal long LengthCore
		{
			get
			{
				return this._fileStatus.GetLength(this.FullPath, false);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x000A019C File Offset: 0x0009E39C
		internal string NormalizedPath
		{
			get
			{
				return this.FullPath;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileSystemInfo" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> is null.</exception>
		// Token: 0x06002809 RID: 10249 RVA: 0x000A01A4 File Offset: 0x0009E3A4
		protected FileSystemInfo(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.FullPath = Path.GetFullPathInternal(info.GetString("FullPath"));
			this.OriginalPath = info.GetString("OriginalPath");
			this._name = info.GetString("Name");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name and additional exception information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x0600280A RID: 10250 RVA: 0x000A0200 File Offset: 0x0009E400
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("OriginalPath", this.OriginalPath, typeof(string));
			info.AddValue("FullPath", this.FullPath, typeof(string));
			info.AddValue("Name", this.Name, typeof(string));
		}

		/// <summary>For files, gets the name of the file. For directories, gets the name of the last directory in the hierarchy if a hierarchy exists. Otherwise, the <see langword="Name" /> property gets the name of the directory.</summary>
		/// <returns>A string that is the name of the parent directory, the name of the last directory in the hierarchy, or the name of a file, including the file name extension.</returns>
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x0009FBF1 File Offset: 0x0009DDF1
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		/// <summary>Gets a value indicating whether the file or directory exists.</summary>
		/// <returns>
		///     <see langword="true" /> if the file or directory exists; otherwise, <see langword="false" />.</returns>
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x000A0260 File Offset: 0x0009E460
		public virtual bool Exists
		{
			get
			{
				bool result;
				try
				{
					result = this.ExistsCore;
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000A028C File Offset: 0x0009E48C
		public override string ToString()
		{
			return this.OriginalPath ?? string.Empty;
		}

		// Token: 0x040014D9 RID: 5337
		private FileStatus _fileStatus;

		/// <summary>Represents the fully qualified path of the directory or file.</summary>
		/// <exception cref="T:System.IO.PathTooLongException">The fully qualified path is 260 or more characters.</exception>
		// Token: 0x040014DA RID: 5338
		protected string FullPath;

		/// <summary>The path originally specified by the user, whether relative or absolute.</summary>
		// Token: 0x040014DB RID: 5339
		protected string OriginalPath;

		// Token: 0x040014DC RID: 5340
		internal string _name;
	}
}
