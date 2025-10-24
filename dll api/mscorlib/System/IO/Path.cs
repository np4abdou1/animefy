using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.IO
{
	/// <summary>Performs operations on <see cref="T:System.String" /> instances that contain file or directory path information. These operations are performed in a cross-platform manner.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000564 RID: 1380
	[ComVisible(true)]
	public static class Path
	{
		/// <summary>Changes the extension of a path string.</summary>
		/// <param name="path">The path information to modify. The path cannot contain any of the characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </param>
		/// <param name="extension">The new extension (with or without a leading period). Specify <see langword="null" /> to remove an existing extension from <paramref name="path" />. </param>
		/// <returns>The modified path information.On Windows-based desktop platforms, if <paramref name="path" /> is <see langword="null" /> or an empty string (""), the path information is returned unmodified. If <paramref name="extension" /> is <see langword="null" />, the returned string contains the specified path with its extension removed. If <paramref name="path" /> has no extension, and <paramref name="extension" /> is not <see langword="null" />, the returned path string contains <paramref name="extension" /> appended to the end of <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		// Token: 0x06002937 RID: 10551 RVA: 0x000A4178 File Offset: 0x000A2378
		public static string ChangeExtension(string path, string extension)
		{
			if (path == null)
			{
				return null;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			int num = Path.findExtension(path);
			if (extension == null)
			{
				if (num >= 0)
				{
					return path.Substring(0, num);
				}
				return path;
			}
			else if (extension.Length == 0)
			{
				if (num >= 0)
				{
					return path.Substring(0, num + 1);
				}
				return path + ".";
			}
			else
			{
				if (path.Length != 0)
				{
					if (extension.Length > 0 && extension[0] != '.')
					{
						extension = "." + extension;
					}
				}
				else
				{
					extension = string.Empty;
				}
				if (num < 0)
				{
					return path + extension;
				}
				if (num > 0)
				{
					return path.Substring(0, num) + extension;
				}
				return extension;
			}
		}

		/// <summary>Combines two strings into a path.</summary>
		/// <param name="path1">The first path to combine. </param>
		/// <param name="path2">The second path to combine. </param>
		/// <returns>The combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If <paramref name="path2" /> contains an absolute path, this method returns <paramref name="path2" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path1" /> or <paramref name="path2" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path1" /> or <paramref name="path2" /> is <see langword="null" />. </exception>
		// Token: 0x06002938 RID: 10552 RVA: 0x000A4234 File Offset: 0x000A2434
		public static string Combine(string path1, string path2)
		{
			if (path1 == null)
			{
				throw new ArgumentNullException("path1");
			}
			if (path2 == null)
			{
				throw new ArgumentNullException("path2");
			}
			if (path1.Length == 0)
			{
				return path2;
			}
			if (path2.Length == 0)
			{
				return path1;
			}
			if (path1.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			if (path2.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			if (Path.IsPathRooted(path2))
			{
				return path2;
			}
			char c = path1[path1.Length - 1];
			if (c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar && c != Path.VolumeSeparatorChar)
			{
				return path1 + Path.DirectorySeparatorStr + path2;
			}
			return path1 + path2;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000A42E8 File Offset: 0x000A24E8
		internal static string CleanPath(string s)
		{
			int length = s.Length;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			char c = s[0];
			if (length > 2 && c == '\\' && s[1] == '\\')
			{
				num3 = 2;
			}
			if (length == 1 && (c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar))
			{
				return s;
			}
			for (int i = num3; i < length; i++)
			{
				char c2 = s[i];
				if (c2 == Path.DirectorySeparatorChar || c2 == Path.AltDirectorySeparatorChar)
				{
					if (Path.DirectorySeparatorChar != Path.AltDirectorySeparatorChar && c2 == Path.AltDirectorySeparatorChar)
					{
						num2++;
					}
					if (i + 1 == length)
					{
						num++;
					}
					else
					{
						c2 = s[i + 1];
						if (c2 == Path.DirectorySeparatorChar || c2 == Path.AltDirectorySeparatorChar)
						{
							num++;
						}
					}
				}
			}
			if (num == 0 && num2 == 0)
			{
				return s;
			}
			char[] array = new char[length - num];
			if (num3 != 0)
			{
				array[0] = '\\';
				array[1] = '\\';
			}
			int j = num3;
			int num4 = num3;
			while (j < length && num4 < array.Length)
			{
				char c3 = s[j];
				if (c3 != Path.DirectorySeparatorChar && c3 != Path.AltDirectorySeparatorChar)
				{
					array[num4++] = c3;
				}
				else if (num4 + 1 != array.Length)
				{
					array[num4++] = Path.DirectorySeparatorChar;
					while (j < length - 1)
					{
						c3 = s[j + 1];
						if (c3 != Path.DirectorySeparatorChar && c3 != Path.AltDirectorySeparatorChar)
						{
							break;
						}
						j++;
					}
				}
				j++;
			}
			return new string(array);
		}

		/// <summary>Returns the directory information for the specified path string.</summary>
		/// <param name="path">The path of a file or directory. </param>
		/// <returns>Directory information for <paramref name="path" />, or <see langword="null" /> if <paramref name="path" /> denotes a root directory or is null. Returns <see cref="F:System.String.Empty" /> if <paramref name="path" /> does not contain directory information.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter contains invalid characters, is empty, or contains only white spaces. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.The <paramref name="path" /> parameter is longer than the system-defined maximum length.</exception>
		// Token: 0x0600293A RID: 10554 RVA: 0x000A4464 File Offset: 0x000A2664
		public static string GetDirectoryName(string path)
		{
			if (path == string.Empty)
			{
				throw new ArgumentException("Invalid path");
			}
			if (path == null || Path.GetPathRoot(path) == path)
			{
				return null;
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException("Argument string consists of whitespace characters only.");
			}
			if (path.IndexOfAny(Path.InvalidPathChars) > -1)
			{
				throw new ArgumentException("Path contains invalid characters");
			}
			int num = path.LastIndexOfAny(Path.PathSeparatorChars);
			if (num == 0)
			{
				num++;
			}
			if (num <= 0)
			{
				return string.Empty;
			}
			string text = path.Substring(0, num);
			int length = text.Length;
			if (length >= 2 && Path.DirectorySeparatorChar == '\\' && text[length - 1] == Path.VolumeSeparatorChar)
			{
				return text + Path.DirectorySeparatorChar.ToString();
			}
			if (length == 1 && Path.DirectorySeparatorChar == '\\' && path.Length >= 2 && path[num] == Path.VolumeSeparatorChar)
			{
				return text + Path.VolumeSeparatorChar.ToString();
			}
			return Path.CleanPath(text);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000A4563 File Offset: 0x000A2763
		public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path)
		{
			return Path.GetDirectoryName(path.ToString()).AsSpan();
		}

		/// <summary>Returns the extension of the specified path string.</summary>
		/// <param name="path">The path string from which to get the extension. </param>
		/// <returns>The extension of the specified path (including the period "."), or <see langword="null" />, or <see cref="F:System.String.Empty" />. If <paramref name="path" /> is <see langword="null" />, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns <see langword="null" />. If <paramref name="path" /> does not have extension information, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.  </exception>
		// Token: 0x0600293C RID: 10556 RVA: 0x000A457C File Offset: 0x000A277C
		public static string GetExtension(string path)
		{
			if (path == null)
			{
				return null;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			int num = Path.findExtension(path);
			if (num > -1 && num < path.Length - 1)
			{
				return path.Substring(num);
			}
			return string.Empty;
		}

		/// <summary>Returns the file name and extension of the specified path string.</summary>
		/// <param name="path">The path string from which to obtain the file name and extension. </param>
		/// <returns>The characters after the last directory character in <paramref name="path" />. If the last character of <paramref name="path" /> is a directory or volume separator character, this method returns <see cref="F:System.String.Empty" />. If <paramref name="path" /> is <see langword="null" />, this method returns <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		// Token: 0x0600293D RID: 10557 RVA: 0x000A45CC File Offset: 0x000A27CC
		public static string GetFileName(string path)
		{
			if (path == null || path.Length == 0)
			{
				return path;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			int num = path.LastIndexOfAny(Path.PathSeparatorChars);
			if (num >= 0)
			{
				return path.Substring(num + 1);
			}
			return path;
		}

		/// <summary>Returns the file name of the specified path string without the extension.</summary>
		/// <param name="path">The path of the file. </param>
		/// <returns>The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.) and all characters following it.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		// Token: 0x0600293E RID: 10558 RVA: 0x000A461A File Offset: 0x000A281A
		public static string GetFileNameWithoutExtension(string path)
		{
			return Path.ChangeExtension(Path.GetFileName(path), null);
		}

		/// <summary>Returns the absolute path for the specified path string.</summary>
		/// <param name="path">The file or directory for which to obtain absolute path information. </param>
		/// <returns>The fully qualified location of <paramref name="path" />, such as "C:\MyFile.txt".</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.-or- The system could not retrieve the absolute path. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> contains a colon (":") that is not part of a volume identifier (for example, "c:\"). </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		// Token: 0x0600293F RID: 10559 RVA: 0x000A4628 File Offset: 0x000A2828
		public static string GetFullPath(string path)
		{
			string result = Path.InsecureGetFullPath(path);
			SecurityManager.EnsureElevatedPermissions();
			return result;
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x000A4635 File Offset: 0x000A2835
		internal static string GetFullPathInternal(string path)
		{
			return Path.InsecureGetFullPath(path);
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000A4640 File Offset: 0x000A2840
		internal static string InsecureGetFullPath(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException(Locale.GetText("The specified path is not of a legal form (empty)."));
			}
			char c = path[path.Length - 1];
			bool flag = true;
			if (path.Length >= 2 && Path.IsDirectorySeparator(path[0]) && Path.IsDirectorySeparator(path[1]))
			{
				if (path.Length == 2 || path.IndexOf(path[0], 2) < 0)
				{
					throw new ArgumentException("UNC paths should be of the form \\\\server\\share.");
				}
				if (path[0] != Path.DirectorySeparatorChar)
				{
					path = path.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
				}
			}
			else if (!Path.IsPathRooted(path))
			{
				int num = 0;
				while ((num = path.IndexOf('.', num)) != -1 && ++num != path.Length && path[num] != Path.DirectorySeparatorChar && path[num] != Path.AltDirectorySeparatorChar)
				{
				}
				flag = (num > 0);
				string text = Directory.InsecureGetCurrentDirectory();
				if (text[text.Length - 1] == Path.DirectorySeparatorChar)
				{
					path = text + path;
				}
				else
				{
					path = text + Path.DirectorySeparatorChar.ToString() + path;
				}
			}
			else if (Path.DirectorySeparatorChar == '\\' && path.Length >= 2 && Path.IsDirectorySeparator(path[0]) && !Path.IsDirectorySeparator(path[1]))
			{
				string text2 = Directory.InsecureGetCurrentDirectory();
				if (text2[1] == Path.VolumeSeparatorChar)
				{
					path = text2.Substring(0, 2) + path;
				}
				else
				{
					path = text2.Substring(0, text2.IndexOf('\\', text2.IndexOfUnchecked("\\\\", 0, text2.Length) + 1));
				}
			}
			if (flag)
			{
				path = Path.CanonicalizePath(path);
			}
			if (Path.IsDirectorySeparator(c) && path[path.Length - 1] != Path.DirectorySeparatorChar)
			{
				path += Path.DirectorySeparatorChar.ToString();
			}
			return path;
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000A4842 File Offset: 0x000A2A42
		internal static bool IsDirectorySeparator(char c)
		{
			return c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar;
		}

		/// <summary>Gets the root directory information of the specified path.</summary>
		/// <param name="path">The path from which to obtain root directory information. </param>
		/// <returns>The root directory of <paramref name="path" />, such as "C:\", or <see langword="null" /> if <paramref name="path" /> is <see langword="null" />, or an empty string if <paramref name="path" /> does not contain root directory information.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.-or- 
		///         <see cref="F:System.String.Empty" /> was passed to <paramref name="path" />. </exception>
		// Token: 0x06002943 RID: 10563 RVA: 0x000A4858 File Offset: 0x000A2A58
		public static string GetPathRoot(string path)
		{
			if (path == null)
			{
				return null;
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException("The specified path is not of a legal form.");
			}
			if (!Path.IsPathRooted(path))
			{
				return string.Empty;
			}
			if (Path.DirectorySeparatorChar == '/')
			{
				if (!Path.IsDirectorySeparator(path[0]))
				{
					return string.Empty;
				}
				return Path.DirectorySeparatorStr;
			}
			else
			{
				int num = 2;
				if (path.Length == 1 && Path.IsDirectorySeparator(path[0]))
				{
					return Path.DirectorySeparatorStr;
				}
				if (path.Length < 2)
				{
					return string.Empty;
				}
				if (Path.IsDirectorySeparator(path[0]) && Path.IsDirectorySeparator(path[1]))
				{
					while (num < path.Length && !Path.IsDirectorySeparator(path[num]))
					{
						num++;
					}
					if (num < path.Length)
					{
						num++;
						while (num < path.Length && !Path.IsDirectorySeparator(path[num]))
						{
							num++;
						}
					}
					return Path.DirectorySeparatorStr + Path.DirectorySeparatorStr + path.Substring(2, num - 2).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
				}
				if (Path.IsDirectorySeparator(path[0]))
				{
					return Path.DirectorySeparatorStr;
				}
				if (path[1] == Path.VolumeSeparatorChar)
				{
					if (path.Length >= 3 && Path.IsDirectorySeparator(path[2]))
					{
						num++;
					}
					return path.Substring(0, num);
				}
				return Directory.GetCurrentDirectory().Substring(0, 2);
			}
		}

		/// <summary>Returns the path of the current user's temporary folder.</summary>
		/// <returns>The path to the temporary folder, ending with a backslash.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions. </exception>
		// Token: 0x06002944 RID: 10564 RVA: 0x000A49C4 File Offset: 0x000A2BC4
		public static string GetTempPath()
		{
			SecurityManager.EnsureElevatedPermissions();
			string temp_path = Path.get_temp_path();
			if (temp_path.Length > 0 && temp_path[temp_path.Length - 1] != Path.DirectorySeparatorChar)
			{
				return temp_path + Path.DirectorySeparatorChar.ToString();
			}
			return temp_path;
		}

		// Token: 0x06002945 RID: 10565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string get_temp_path();

		// Token: 0x06002946 RID: 10566 RVA: 0x000A4A0C File Offset: 0x000A2C0C
		public unsafe static bool IsPathRooted(ReadOnlySpan<char> path)
		{
			if (path.Length == 0)
			{
				return false;
			}
			char c = (char)(*path[0]);
			return c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar || (!Path.dirEqualsVolume && path.Length > 1 && *path[1] == (ushort)Path.VolumeSeparatorChar);
		}

		/// <summary>Gets a value indicating whether the specified path string contains a root.</summary>
		/// <param name="path">The path to test. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="path" /> contains a root; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		// Token: 0x06002947 RID: 10567 RVA: 0x000A4A63 File Offset: 0x000A2C63
		public static bool IsPathRooted(string path)
		{
			if (path == null || path.Length == 0)
			{
				return false;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			return Path.IsPathRooted(path.AsSpan());
		}

		/// <summary>Gets an array containing the characters that are not allowed in file names.</summary>
		/// <returns>An array containing the characters that are not allowed in file names.</returns>
		// Token: 0x06002948 RID: 10568 RVA: 0x000A4A96 File Offset: 0x000A2C96
		public static char[] GetInvalidFileNameChars()
		{
			return new char[]
			{
				'\0',
				'/'
			};
		}

		/// <summary>Gets an array containing the characters that are not allowed in path names.</summary>
		/// <returns>An array containing the characters that are not allowed in path names.</returns>
		// Token: 0x06002949 RID: 10569 RVA: 0x000A4AA3 File Offset: 0x000A2CA3
		public static char[] GetInvalidPathChars()
		{
			return new char[1];
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000A4AAC File Offset: 0x000A2CAC
		private static int findExtension(string path)
		{
			if (path != null)
			{
				int num = path.LastIndexOf('.');
				int num2 = path.LastIndexOfAny(Path.PathSeparatorChars);
				if (num > num2)
				{
					return num;
				}
			}
			return -1;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000A4AD8 File Offset: 0x000A2CD8
		static Path()
		{
			Path.VolumeSeparatorChar = MonoIO.VolumeSeparatorChar;
			Path.DirectorySeparatorChar = MonoIO.DirectorySeparatorChar;
			Path.AltDirectorySeparatorChar = MonoIO.AltDirectorySeparatorChar;
			Path.PathSeparator = MonoIO.PathSeparator;
			Path.InvalidPathChars = Path.GetInvalidPathChars();
			Path.DirectorySeparatorStr = Path.DirectorySeparatorChar.ToString();
			Path.PathSeparatorChars = new char[]
			{
				Path.DirectorySeparatorChar,
				Path.AltDirectorySeparatorChar,
				Path.VolumeSeparatorChar
			};
			Path.dirEqualsVolume = (Path.DirectorySeparatorChar == Path.VolumeSeparatorChar);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000A4B7C File Offset: 0x000A2D7C
		private static string CanonicalizePath(string path)
		{
			if (path == null)
			{
				return path;
			}
			if (path.Length == 0)
			{
				return path;
			}
			string pathRoot = Path.GetPathRoot(path);
			string[] array = path.Split(new char[]
			{
				Path.DirectorySeparatorChar,
				Path.AltDirectorySeparatorChar
			});
			int num = 0;
			bool flag = false;
			int num2 = flag ? 3 : 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (((flag && i == 2) || !(array[i] == ".")) && (i == 0 || array[i].Length != 0))
				{
					if (array[i] == "..")
					{
						if (num > num2)
						{
							num--;
						}
					}
					else
					{
						array[num++] = array[i];
					}
				}
			}
			if (num == 0 || (num == 1 && array[0] == ""))
			{
				return pathRoot;
			}
			string text = string.Join(Path.DirectorySeparatorStr, array, 0, num);
			if (pathRoot != "" && text.Length > 0 && text[0] != '/')
			{
				text = pathRoot + text;
			}
			return text;
		}

		/// <summary>Combines an array of strings into a path.</summary>
		/// <param name="paths">An array of parts of the path.</param>
		/// <returns>The combined paths.</returns>
		/// <exception cref="T:System.ArgumentException">One of the strings in the array contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">One of the strings in the array is <see langword="null" />. </exception>
		// Token: 0x0600294D RID: 10573 RVA: 0x000A4C80 File Offset: 0x000A2E80
		public static string Combine(params string[] paths)
		{
			if (paths == null)
			{
				throw new ArgumentNullException("paths");
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = paths.Length;
			bool flag = false;
			foreach (string text in paths)
			{
				if (text == null)
				{
					throw new ArgumentNullException("One of the paths contains a null value", "paths");
				}
				if (text.Length != 0)
				{
					if (text.IndexOfAny(Path.InvalidPathChars) != -1)
					{
						throw new ArgumentException("Illegal characters in path.");
					}
					if (flag)
					{
						flag = false;
						stringBuilder.Append(Path.DirectorySeparatorStr);
					}
					num--;
					if (Path.IsPathRooted(text))
					{
						stringBuilder.Length = 0;
					}
					stringBuilder.Append(text);
					int length = text.Length;
					if (length > 0 && num > 0)
					{
						char c = text[length - 1];
						if (c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar && c != Path.VolumeSeparatorChar)
						{
							flag = true;
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		/// <summary>Combines three strings into a path.</summary>
		/// <param name="path1">The first path to combine. </param>
		/// <param name="path2">The second path to combine. </param>
		/// <param name="path3">The third path to combine.</param>
		/// <returns>The combined paths.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path1" />, <paramref name="path2" />, or <paramref name="path3" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path1" />, <paramref name="path2" />, or <paramref name="path3" /> is <see langword="null" />. </exception>
		// Token: 0x0600294E RID: 10574 RVA: 0x000A4D74 File Offset: 0x000A2F74
		public static string Combine(string path1, string path2, string path3)
		{
			if (path1 == null)
			{
				throw new ArgumentNullException("path1");
			}
			if (path2 == null)
			{
				throw new ArgumentNullException("path2");
			}
			if (path3 == null)
			{
				throw new ArgumentNullException("path3");
			}
			return Path.Combine(new string[]
			{
				path1,
				path2,
				path3
			});
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x000A4DC4 File Offset: 0x000A2FC4
		public unsafe static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path)
		{
			int length = Path.GetPathRoot(new string(path)).Length;
			int num = path.Length;
			while (--num >= 0)
			{
				if (num < length || Path.IsDirectorySeparator((char)(*path[num])))
				{
					return path.Slice(num + 1, path.Length - num - 1);
				}
			}
			return path;
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000A4E1F File Offset: 0x000A301F
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
		{
			if (path1.Length == 0)
			{
				return new string(path2);
			}
			if (path2.Length == 0)
			{
				return new string(path1);
			}
			return Path.JoinInternal(path1, path2);
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000A4E48 File Offset: 0x000A3048
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
		{
			if (path1.Length == 0)
			{
				return Path.Join(path2, path3);
			}
			if (path2.Length == 0)
			{
				return Path.Join(path1, path3);
			}
			if (path3.Length == 0)
			{
				return Path.Join(path1, path2);
			}
			return Path.JoinInternal(path1, path2, path3);
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000A4E88 File Offset: 0x000A3088
		public unsafe static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten)
		{
			charsWritten = 0;
			if (path1.Length == 0 && path2.Length == 0)
			{
				return true;
			}
			if (path1.Length == 0 || path2.Length == 0)
			{
				ref ReadOnlySpan<char> ptr = ref (path1.Length == 0) ? ref path2 : ref path1;
				if (destination.Length < ptr.Length)
				{
					return false;
				}
				ptr.CopyTo(destination);
				charsWritten = ptr.Length;
				return true;
			}
			else
			{
				bool flag = !PathInternal.EndsInDirectorySeparator(path1) && !PathInternal.StartsWithDirectorySeparator(path2);
				int num = path1.Length + path2.Length + (flag ? 1 : 0);
				if (destination.Length < num)
				{
					return false;
				}
				path1.CopyTo(destination);
				if (flag)
				{
					*destination[path1.Length] = Path.DirectorySeparatorChar;
				}
				path2.CopyTo(destination.Slice(path1.Length + (flag ? 1 : 0)));
				charsWritten = num;
				return true;
			}
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000A4F6C File Offset: 0x000A316C
		private unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second)
		{
			bool flag = PathInternal.IsDirectorySeparator((char)(*first[first.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*second[0]));
			fixed (char* reference = MemoryMarshal.GetReference<char>(first))
			{
				char* value = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(second))
				{
					char* value2 = reference2;
					return string.Create<ValueTuple<IntPtr, int, IntPtr, int, bool>>(first.Length + second.Length + (flag ? 0 : 1), new ValueTuple<IntPtr, int, IntPtr, int, bool>((IntPtr)((void*)value), first.Length, (IntPtr)((void*)value2), second.Length, flag), delegate(Span<char> destination, [TupleElementNames(new string[]
					{
						"First",
						"FirstLength",
						"Second",
						"SecondLength",
						"HasSeparator"
					})] ValueTuple<IntPtr, int, IntPtr, int, bool> state)
					{
						Span<char> span = new Span<char>((void*)state.Item1, state.Item2);
						span.CopyTo(destination);
						if (!state.Item5)
						{
							*destination[state.Item2] = '/';
						}
						span = new Span<char>((void*)state.Item3, state.Item4);
						span.CopyTo(destination.Slice(state.Item2 + (state.Item5 ? 0 : 1)));
					});
				}
			}
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000A5014 File Offset: 0x000A3214
		private unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third)
		{
			bool flag = PathInternal.IsDirectorySeparator((char)(*first[first.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*second[0]));
			bool flag2 = PathInternal.IsDirectorySeparator((char)(*second[second.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*third[0]));
			fixed (char* reference = MemoryMarshal.GetReference<char>(first))
			{
				char* value = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(second))
				{
					char* value2 = reference2;
					fixed (char* reference3 = MemoryMarshal.GetReference<char>(third))
					{
						char* value3 = reference3;
						return string.Create<ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>(first.Length + second.Length + third.Length + (flag ? 0 : 1) + (flag2 ? 0 : 1), new ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>((IntPtr)((void*)value), first.Length, (IntPtr)((void*)value2), second.Length, (IntPtr)((void*)value3), third.Length, flag, new ValueTuple<bool>(flag2)), delegate(Span<char> destination, [TupleElementNames(new string[]
						{
							"First",
							"FirstLength",
							"Second",
							"SecondLength",
							"Third",
							"ThirdLength",
							"FirstHasSeparator",
							"ThirdHasSeparator",
							null
						})] ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>> state)
						{
							Span<char> span = new Span<char>((void*)state.Item1, state.Item2);
							span.CopyTo(destination);
							if (!state.Item7)
							{
								*destination[state.Item2] = '/';
							}
							span = new Span<char>((void*)state.Item3, state.Item4);
							span.CopyTo(destination.Slice(state.Item2 + (state.Item7 ? 0 : 1)));
							if (!state.Rest.Item1)
							{
								*destination[destination.Length - state.Item6 - 1] = '/';
							}
							span = new Span<char>((void*)state.Item5, state.Item6);
							span.CopyTo(destination.Slice(destination.Length - state.Item6));
						});
					}
				}
			}
		}

		/// <summary>Provides a platform-specific array of characters that cannot be specified in path string arguments passed to members of the <see cref="T:System.IO.Path" /> class.</summary>
		/// <returns>A character array of invalid path characters for the current platform.</returns>
		// Token: 0x04001584 RID: 5508
		public static readonly char[] InvalidPathChars;

		/// <summary>Provides a platform-specific alternate character used to separate directory levels in a path string that reflects a hierarchical file system organization.</summary>
		// Token: 0x04001585 RID: 5509
		public static readonly char AltDirectorySeparatorChar;

		/// <summary>Provides a platform-specific character used to separate directory levels in a path string that reflects a hierarchical file system organization.</summary>
		// Token: 0x04001586 RID: 5510
		public static readonly char DirectorySeparatorChar;

		/// <summary>A platform-specific separator character used to separate path strings in environment variables.</summary>
		// Token: 0x04001587 RID: 5511
		public static readonly char PathSeparator;

		// Token: 0x04001588 RID: 5512
		internal static readonly string DirectorySeparatorStr;

		/// <summary>Provides a platform-specific volume separator character.</summary>
		// Token: 0x04001589 RID: 5513
		public static readonly char VolumeSeparatorChar;

		// Token: 0x0400158A RID: 5514
		internal static readonly char[] PathSeparatorChars;

		// Token: 0x0400158B RID: 5515
		private static readonly bool dirEqualsVolume;

		// Token: 0x0400158C RID: 5516
		internal static readonly char[] trimEndCharsWindows = new char[]
		{
			'\t',
			'\n',
			'\v',
			'\f',
			'\r',
			' ',
			'\u0085',
			'\u00a0'
		};

		// Token: 0x0400158D RID: 5517
		internal static readonly char[] trimEndCharsUnix = new char[0];
	}
}
