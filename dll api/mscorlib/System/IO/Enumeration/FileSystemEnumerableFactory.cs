using System;
using System.Collections.Generic;

namespace System.IO.Enumeration
{
	// Token: 0x0200056F RID: 1391
	internal static class FileSystemEnumerableFactory
	{
		// Token: 0x06002986 RID: 10630 RVA: 0x000A590C File Offset: 0x000A3B0C
		internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options)
		{
			if (Path.IsPathRooted(expression))
			{
				throw new ArgumentException("Second path fragment must not be a drive or UNC name.", "expression");
			}
			ReadOnlySpan<char> directoryName = Path.GetDirectoryName(expression.AsSpan());
			if (directoryName.Length != 0)
			{
				directory = Path.Join(directory, directoryName);
				expression = expression.Substring(directoryName.Length + 1);
			}
			MatchType matchType = options.MatchType;
			if (matchType == MatchType.Simple)
			{
				return;
			}
			if (matchType != MatchType.Win32)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			if (string.IsNullOrEmpty(expression) || expression == "." || expression == "*.*")
			{
				expression = "*";
				return;
			}
			if (Path.DirectorySeparatorChar != '\\' && expression.IndexOfAny(FileSystemEnumerableFactory.s_unixEscapeChars) != -1)
			{
				expression = expression.Replace("\\", "\\\\");
				expression = expression.Replace("\"", "\\\"");
				expression = expression.Replace(">", "\\>");
				expression = expression.Replace("<", "\\<");
			}
			expression = FileSystemName.TranslateWin32Expression(expression);
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000A5A24 File Offset: 0x000A3C24
		private static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options)
		{
			bool ignoreCase = (options.MatchCasing == MatchCasing.PlatformDefault && !PathInternal.IsCaseSensitive) || options.MatchCasing == MatchCasing.CaseInsensitive;
			MatchType matchType = options.MatchType;
			if (matchType == MatchType.Simple)
			{
				return FileSystemName.MatchesSimpleExpression(expression, name, ignoreCase);
			}
			if (matchType != MatchType.Win32)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			return FileSystemName.MatchesWin32Expression(expression, name, ignoreCase);
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000A5A84 File Offset: 0x000A3C84
		internal static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options)
		{
			return new FileSystemEnumerable<string>(directory, delegate(ref FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}, options)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return !entry.IsDirectory && FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000A5AE4 File Offset: 0x000A3CE4
		internal static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options)
		{
			return new FileSystemEnumerable<string>(directory, delegate(ref FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}, options)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return entry.IsDirectory && FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000A5B44 File Offset: 0x000A3D44
		internal static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options)
		{
			return new FileSystemEnumerable<string>(directory, delegate(ref FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}, options)
			{
				ShouldIncludePredicate = delegate(ref FileSystemEntry entry)
				{
					return FileSystemEnumerableFactory.MatchesPattern(expression, entry.FileName, options);
				}
			};
		}

		// Token: 0x040015A5 RID: 5541
		private static readonly char[] s_unixEscapeChars = new char[]
		{
			'\\',
			'"',
			'<',
			'>'
		};
	}
}
