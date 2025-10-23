using System;

namespace System.IO
{
	/// <summary>Specifies how the operating system should open a file.</summary>
	// Token: 0x02000526 RID: 1318
	public enum FileMode
	{
		/// <summary>Specifies that the operating system should create a new file. This requires <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permission. If the file already exists, an <see cref="T:System.IO.IOException" /> exception is thrown.</summary>
		// Token: 0x04001431 RID: 5169
		CreateNew = 1,
		/// <summary>Specifies that the operating system should create a new file. If the file already exists, it will be overwritten. This requires <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permission. <see langword="FileMode.Create" /> is equivalent to requesting that if the file does not exist, use <see cref="F:System.IO.FileMode.CreateNew" />; otherwise, use <see cref="F:System.IO.FileMode.Truncate" />. If the file already exists but is a hidden file, an <see cref="T:System.UnauthorizedAccessException" /> exception is thrown.</summary>
		// Token: 0x04001432 RID: 5170
		Create,
		/// <summary>Specifies that the operating system should open an existing file. The ability to open the file is dependent on the value specified by the <see cref="T:System.IO.FileAccess" /> enumeration. A <see cref="T:System.IO.FileNotFoundException" /> exception is thrown if the file does not exist.</summary>
		// Token: 0x04001433 RID: 5171
		Open,
		/// <summary>Specifies that the operating system should open a file if it exists; otherwise, a new file should be created. If the file is opened with <see langword="FileAccess.Read" />, <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Read" /> permission is required. If the file access is <see langword="FileAccess.Write" />, <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permission is required. If the file is opened with <see langword="FileAccess.ReadWrite" />, both <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Read" /> and <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permissions are required.  </summary>
		// Token: 0x04001434 RID: 5172
		OpenOrCreate,
		/// <summary>Specifies that the operating system should open an existing file. When the file is opened, it should be truncated so that its size is zero bytes. This requires <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permission. Attempts to read from a file opened with <see langword="FileMode.Truncate" /> cause an <see cref="T:System.ArgumentException" /> exception.</summary>
		// Token: 0x04001435 RID: 5173
		Truncate,
		/// <summary>Opens the file if it exists and seeks to the end of the file, or creates a new file. This requires <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Append" /> permission. <see langword="FileMode.Append" /> can be used only in conjunction with <see langword="FileAccess.Write" />. Trying to seek to a position before the end of the file throws an <see cref="T:System.IO.IOException" /> exception, and any attempt to read fails and throws a <see cref="T:System.NotSupportedException" /> exception.</summary>
		// Token: 0x04001436 RID: 5174
		Append
	}
}
