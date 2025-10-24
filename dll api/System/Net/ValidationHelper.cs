using System;

namespace System.Net
{
	// Token: 0x02000156 RID: 342
	internal static class ValidationHelper
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x0003360B File Offset: 0x0003180B
		public static string MakeStringNull(string stringValue)
		{
			if (stringValue == null || stringValue.Length == 0)
			{
				return null;
			}
			return stringValue;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0003361B File Offset: 0x0003181B
		public static bool IsBlankString(string stringValue)
		{
			return stringValue == null || stringValue.Length == 0;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0002C17C File Offset: 0x0002A37C
		public static bool ValidateTcpPort(int port)
		{
			return port >= 0 && port <= 65535;
		}

		// Token: 0x040006E1 RID: 1761
		public static string[] EmptyArray = new string[0];

		// Token: 0x040006E2 RID: 1762
		internal static readonly char[] InvalidMethodChars = new char[]
		{
			' ',
			'\r',
			'\n',
			'\t'
		};

		// Token: 0x040006E3 RID: 1763
		internal static readonly char[] InvalidParamChars = new char[]
		{
			'(',
			')',
			'<',
			'>',
			'@',
			',',
			';',
			':',
			'\\',
			'"',
			'\'',
			'/',
			'[',
			']',
			'?',
			'=',
			'{',
			'}',
			' ',
			'\t',
			'\r',
			'\n'
		};
	}
}
