using System;

namespace System.IO
{
	// Token: 0x0200052C RID: 1324
	internal static class PathInternal
	{
		// Token: 0x0600270D RID: 9997 RVA: 0x0009BFB4 File Offset: 0x0009A1B4
		internal unsafe static int GetRootLength(ReadOnlySpan<char> path)
		{
			if (path.Length <= 0 || !PathInternal.IsDirectorySeparator((char)(*path[0])))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x0009BFD3 File Offset: 0x0009A1D3
		internal static bool IsDirectorySeparator(char c)
		{
			return c == '/';
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x0009BFDA File Offset: 0x0009A1DA
		internal unsafe static bool EndsInDirectorySeparator(ReadOnlySpan<char> path)
		{
			return path.Length > 0 && PathInternal.IsDirectorySeparator((char)(*path[path.Length - 1]));
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x0009BFFE File Offset: 0x0009A1FE
		internal unsafe static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path)
		{
			return path.Length > 0 && PathInternal.IsDirectorySeparator((char)(*path[0]));
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x0009C01A File Offset: 0x0009A21A
		internal static string TrimEndingDirectorySeparator(string path)
		{
			if (!PathInternal.EndsInDirectorySeparator(path) || PathInternal.IsRoot(path))
			{
				return path;
			}
			return path.Substring(0, path.Length - 1);
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x0009C047 File Offset: 0x0009A247
		internal static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path)
		{
			if (!PathInternal.EndsInDirectorySeparator(path) || PathInternal.IsRoot(path))
			{
				return path;
			}
			return path.Slice(0, path.Length - 1);
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x0009C06C File Offset: 0x0009A26C
		internal static bool IsRoot(ReadOnlySpan<char> path)
		{
			return path.Length == PathInternal.GetRootLength(path);
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x0009C07D File Offset: 0x0009A27D
		internal static bool IsCaseSensitive
		{
			get
			{
				return PathInternal.s_isCaseSensitive;
			}
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x0009C084 File Offset: 0x0009A284
		private static bool GetIsCaseSensitive()
		{
			bool result;
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "CASESENSITIVETEST" + Guid.NewGuid().ToString("N"));
				using (new FileStream(text, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
				{
					result = !File.Exists(text.ToLowerInvariant());
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public static bool IsPartiallyQualified(string path)
		{
			return false;
		}

		// Token: 0x04001452 RID: 5202
		private static readonly bool s_isCaseSensitive = PathInternal.GetIsCaseSensitive();
	}
}
