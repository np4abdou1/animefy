using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SQLitePCL
{
	// Token: 0x02000028 RID: 40
	internal static class util
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x000031B9 File Offset: 0x000013B9
		public static utf8z to_utf8z(this string s)
		{
			return utf8z.FromString(s);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000031C4 File Offset: 0x000013C4
		public static byte[] to_utf8_with_z(this string sourceText)
		{
			if (sourceText == null)
			{
				return null;
			}
			byte[] array = new byte[Encoding.UTF8.GetByteCount(sourceText) + 1];
			int bytes = Encoding.UTF8.GetBytes(sourceText, 0, sourceText.Length, array, 0);
			array[bytes] = 0;
			return array;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00003204 File Offset: 0x00001404
		private static int my_strlen(IntPtr nativeString)
		{
			int num = 0;
			if (nativeString != IntPtr.Zero)
			{
				while (Marshal.ReadByte(nativeString, num) > 0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00003231 File Offset: 0x00001431
		public static string from_utf8_z(IntPtr nativeString)
		{
			return util.from_utf8(nativeString, util.my_strlen(nativeString));
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00003240 File Offset: 0x00001440
		public unsafe static string from_utf8(IntPtr nativeString, int size)
		{
			string result = null;
			if (nativeString != IntPtr.Zero)
			{
				result = Encoding.UTF8.GetString((byte*)nativeString.ToPointer(), size);
			}
			return result;
		}
	}
}
