using System;
using System.Collections.Generic;
using System.IO.Enumeration;

namespace System.IO
{
	/// <summary>Exposes static methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000541 RID: 1345
	public static class Directory
	{
		/// <summary>Creates all directories and subdirectories in the specified path unless they already exist.</summary>
		/// <param name="path">The directory to create. </param>
		/// <returns>An object that represents the directory at the specified path. This object is returned regardless of whether a directory at the specified path already exists.</returns>
		/// <exception cref="T:System.IO.IOException">The directory specified by <paramref name="path" /> is a file.-or-The network name is not known.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.-or-
		///         <paramref name="path" /> is prefixed with, or contains, only a colon character (:).</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> contains a colon character (:) that is not part of a drive label ("C:\").</exception>
		// Token: 0x060027CD RID: 10189 RVA: 0x0009F74E File Offset: 0x0009D94E
		public static DirectoryInfo CreateDirectory(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Path cannot be the empty string or all whitespace.", "path");
			}
			string fullPath = Path.GetFullPath(path);
			FileSystem.CreateDirectory(fullPath);
			return new DirectoryInfo(fullPath, null, null, false);
		}

		/// <summary>Determines whether the given path refers to an existing directory on disk.</summary>
		/// <param name="path">The path to test. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="path" /> refers to an existing directory; <see langword="false" /> if the directory does not exist or an error occurs when trying to determine if the specified directory exists.</returns>
		// Token: 0x060027CE RID: 10190 RVA: 0x0009F78C File Offset: 0x0009D98C
		public static bool Exists(string path)
		{
			try
			{
				if (path == null)
				{
					return false;
				}
				if (path.Length == 0)
				{
					return false;
				}
				return FileSystem.DirectoryExists(Path.GetFullPath(path));
			}
			catch (ArgumentException)
			{
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
			return false;
		}

		/// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory.</summary>
		/// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
		/// <param name="searchPattern">The search string to match against the names of files in <paramref name="path" />.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions.</param>
		/// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern, or an empty array if no files are found.</returns>
		/// <exception cref="T:System.IO.IOException">
		///         <paramref name="path" /> is a file name.-or-A network error has occurred. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using <see cref="M:System.IO.Path.GetInvalidPathChars" />.-or- 
		///         <paramref name="searchPattern" /> doesn't contain a valid pattern. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> or <paramref name="searchPattern" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is not found or is invalid (for example, it is on an unmapped drive). </exception>
		// Token: 0x060027CF RID: 10191 RVA: 0x0009F7F4 File Offset: 0x0009D9F4
		public static string[] GetFiles(string path, string searchPattern)
		{
			return Directory.GetFiles(path, searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x0009F802 File Offset: 0x0009DA02
		public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Files, enumerationOptions).ToArray<string>();
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0009F814 File Offset: 0x0009DA14
		internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (searchPattern == null)
			{
				throw new ArgumentNullException("searchPattern");
			}
			FileSystemEnumerableFactory.NormalizeInputs(ref path, ref searchPattern, options);
			switch (searchTarget)
			{
			case SearchTarget.Files:
				return FileSystemEnumerableFactory.UserFiles(path, searchPattern, options);
			case SearchTarget.Directories:
				return FileSystemEnumerableFactory.UserDirectories(path, searchPattern, options);
			case SearchTarget.Both:
				return FileSystemEnumerableFactory.UserEntries(path, searchPattern, options);
			default:
				throw new ArgumentOutOfRangeException("searchTarget");
			}
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0009F882 File Offset: 0x0009DA82
		internal static string InternalGetDirectoryRoot(string path)
		{
			if (path == null)
			{
				return null;
			}
			return path.Substring(0, PathInternal.GetRootLength(path));
		}

		/// <summary>Gets the current working directory of the application.</summary>
		/// <returns>A string that contains the path of the current working directory, and does not end with a backslash (\).</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.NotSupportedException">The operating system is Windows CE, which does not have current directory functionality.This method is available in the .NET Compact Framework, but is not currently supported.</exception>
		// Token: 0x060027D3 RID: 10195 RVA: 0x0009F89B File Offset: 0x0009DA9B
		public static string GetCurrentDirectory()
		{
			return Environment.CurrentDirectory;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x0009F8A4 File Offset: 0x0009DAA4
		internal static string InsecureGetCurrentDirectory()
		{
			MonoIOError monoIOError;
			string currentDirectory = MonoIO.GetCurrentDirectory(out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(monoIOError);
			}
			return currentDirectory;
		}
	}
}
