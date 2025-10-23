using System;

namespace System.Data
{
	// Token: 0x0200006B RID: 107
	internal sealed class Operators
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x00024128 File Offset: 0x00022328
		internal static bool IsArithmetical(int op)
		{
			return op == 15 || op == 16 || op == 17 || op == 18 || op == 20;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00024145 File Offset: 0x00022345
		internal static bool IsLogical(int op)
		{
			return op == 26 || op == 27 || op == 3 || op == 13 || op == 39;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00024161 File Offset: 0x00022361
		internal static bool IsRelational(int op)
		{
			return 7 <= op && op <= 12;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00024171 File Offset: 0x00022371
		internal static int Priority(int op)
		{
			if (op > Operators.s_priority.Length)
			{
				return 24;
			}
			return Operators.s_priority[op];
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00024188 File Offset: 0x00022388
		internal static string ToString(int op)
		{
			string result;
			if (op <= Operators.s_looks.Length)
			{
				result = Operators.s_looks[op];
			}
			else
			{
				result = "Unknown op";
			}
			return result;
		}

		// Token: 0x04000253 RID: 595
		private static readonly int[] s_priority = new int[]
		{
			0,
			20,
			20,
			9,
			12,
			11,
			11,
			13,
			13,
			13,
			13,
			13,
			13,
			10,
			11,
			16,
			16,
			19,
			19,
			18,
			17,
			21,
			8,
			7,
			6,
			9,
			8,
			7,
			2,
			22,
			23,
			23,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24
		};

		// Token: 0x04000254 RID: 596
		private static readonly string[] s_looks = new string[]
		{
			"",
			"-",
			"+",
			"Not",
			"BetweenAnd",
			"In",
			"Between",
			"=",
			">",
			"<",
			">=",
			"<=",
			"<>",
			"Is",
			"Like",
			"+",
			"-",
			"*",
			"/",
			"\\",
			"Mod",
			"**",
			"&",
			"|",
			"^",
			"~",
			"And",
			"Or",
			"Proc",
			"Iff",
			".",
			".",
			"Null",
			"True",
			"False",
			"Date",
			"GenUniqueId()",
			"GenGuid()",
			"Guid {..}",
			"Is Not"
		};
	}
}
