using System;
using System.Text;

namespace System.Globalization
{
	// Token: 0x02000586 RID: 1414
	internal class HebrewNumber
	{
		// Token: 0x06002A76 RID: 10870 RVA: 0x000AA368 File Offset: 0x000A8568
		internal static string ToString(int Number)
		{
			char c = '\0';
			StringBuilder stringBuilder = new StringBuilder();
			if (Number > 5000)
			{
				Number -= 5000;
			}
			int num = Number / 100;
			if (num > 0)
			{
				Number -= num * 100;
				for (int i = 0; i < num / 4; i++)
				{
					stringBuilder.Append('ת');
				}
				int num2 = num % 4;
				if (num2 > 0)
				{
					stringBuilder.Append((char)(1510 + num2));
				}
			}
			int num3 = Number / 10;
			Number %= 10;
			switch (num3)
			{
			case 0:
				c = '\0';
				break;
			case 1:
				c = 'י';
				break;
			case 2:
				c = 'כ';
				break;
			case 3:
				c = 'ל';
				break;
			case 4:
				c = 'מ';
				break;
			case 5:
				c = 'נ';
				break;
			case 6:
				c = 'ס';
				break;
			case 7:
				c = 'ע';
				break;
			case 8:
				c = 'פ';
				break;
			case 9:
				c = 'צ';
				break;
			}
			char c2 = (char)((Number > 0) ? (1488 + Number - 1) : 0);
			if (c2 == 'ה' && c == 'י')
			{
				c2 = 'ו';
				c = 'ט';
			}
			if (c2 == 'ו' && c == 'י')
			{
				c2 = 'ז';
				c = 'ט';
			}
			if (c != '\0')
			{
				stringBuilder.Append(c);
			}
			if (c2 != '\0')
			{
				stringBuilder.Append(c2);
			}
			if (stringBuilder.Length > 1)
			{
				stringBuilder.Insert(stringBuilder.Length - 1, '"');
			}
			else
			{
				stringBuilder.Append('\'');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x000AA4F4 File Offset: 0x000A86F4
		internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
		{
			HebrewNumber.HebrewToken hebrewToken;
			if (ch == '\'')
			{
				hebrewToken = HebrewNumber.HebrewToken.SingleQuote;
			}
			else if (ch == '"')
			{
				hebrewToken = HebrewNumber.HebrewToken.DoubleQuote;
			}
			else
			{
				int num = (int)(ch - 'א');
				if (num < 0 || num >= HebrewNumber.s_hebrewValues.Length)
				{
					return HebrewNumberParsingState.NotHebrewDigit;
				}
				hebrewToken = HebrewNumber.s_hebrewValues[num].token;
				if (hebrewToken == HebrewNumber.HebrewToken.Invalid)
				{
					return HebrewNumberParsingState.NotHebrewDigit;
				}
				context.result += (int)HebrewNumber.s_hebrewValues[num].value;
			}
			context.state = HebrewNumber.s_numberPasingState[(int)(context.state * HebrewNumber.HS.X00 + (sbyte)hebrewToken)];
			if (context.state == HebrewNumber.HS._err)
			{
				return HebrewNumberParsingState.InvalidHebrewNumber;
			}
			if (context.state == HebrewNumber.HS.END)
			{
				return HebrewNumberParsingState.FoundEndOfHebrewNumber;
			}
			return HebrewNumberParsingState.ContinueParsing;
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000AA58E File Offset: 0x000A878E
		internal static bool IsDigit(char ch)
		{
			if (ch >= 'א' && ch <= HebrewNumber.s_maxHebrewNumberCh)
			{
				return HebrewNumber.s_hebrewValues[(int)(ch - 'א')].value >= 0;
			}
			return ch == '\'' || ch == '"';
		}

		// Token: 0x0400167F RID: 5759
		private static readonly HebrewNumber.HebrewValue[] s_hebrewValues = new HebrewNumber.HebrewValue[]
		{
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 2),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 3),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 4),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 5),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit6_7, 6),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit6_7, 7),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 8),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit9, 9),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 10),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 20),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 30),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 40),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 50),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 60),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 70),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 80),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 90),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit100, 100),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit200_300, 200),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit200_300, 300),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit400, 400)
		};

		// Token: 0x04001680 RID: 5760
		private static char s_maxHebrewNumberCh = (char)(1488 + HebrewNumber.s_hebrewValues.Length - 1);

		// Token: 0x04001681 RID: 5761
		private static readonly HebrewNumber.HS[] s_numberPasingState = new HebrewNumber.HS[]
		{
			HebrewNumber.HS.S400,
			HebrewNumber.HS.X00,
			HebrewNumber.HS.X00,
			HebrewNumber.HS.X0,
			HebrewNumber.HS.X,
			HebrewNumber.HS.X,
			HebrewNumber.HS.X,
			HebrewNumber.HS.S9,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_400,
			HebrewNumber.HS.S400_X00,
			HebrewNumber.HS.S400_X00,
			HebrewNumber.HS.S400_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS.END,
			HebrewNumber.HS.S400_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_400_100,
			HebrewNumber.HS.S400_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_400_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_X00_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X0_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X0_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.X0_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS.END,
			HebrewNumber.HS.X00_DQ,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_X00_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.S9_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S9_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err
		};

		// Token: 0x02000587 RID: 1415
		private enum HebrewToken : short
		{
			// Token: 0x04001683 RID: 5763
			Invalid = -1,
			// Token: 0x04001684 RID: 5764
			Digit400,
			// Token: 0x04001685 RID: 5765
			Digit200_300,
			// Token: 0x04001686 RID: 5766
			Digit100,
			// Token: 0x04001687 RID: 5767
			Digit10,
			// Token: 0x04001688 RID: 5768
			Digit1,
			// Token: 0x04001689 RID: 5769
			Digit6_7,
			// Token: 0x0400168A RID: 5770
			Digit7,
			// Token: 0x0400168B RID: 5771
			Digit9,
			// Token: 0x0400168C RID: 5772
			SingleQuote,
			// Token: 0x0400168D RID: 5773
			DoubleQuote
		}

		// Token: 0x02000588 RID: 1416
		private struct HebrewValue
		{
			// Token: 0x06002A7A RID: 10874 RVA: 0x000AA7B7 File Offset: 0x000A89B7
			internal HebrewValue(HebrewNumber.HebrewToken token, short value)
			{
				this.token = token;
				this.value = value;
			}

			// Token: 0x0400168E RID: 5774
			internal HebrewNumber.HebrewToken token;

			// Token: 0x0400168F RID: 5775
			internal short value;
		}

		// Token: 0x02000589 RID: 1417
		internal enum HS : sbyte
		{
			// Token: 0x04001691 RID: 5777
			_err = -1,
			// Token: 0x04001692 RID: 5778
			Start,
			// Token: 0x04001693 RID: 5779
			S400,
			// Token: 0x04001694 RID: 5780
			S400_400,
			// Token: 0x04001695 RID: 5781
			S400_X00,
			// Token: 0x04001696 RID: 5782
			S400_X0,
			// Token: 0x04001697 RID: 5783
			X00_DQ,
			// Token: 0x04001698 RID: 5784
			S400_X00_X0,
			// Token: 0x04001699 RID: 5785
			X0_DQ,
			// Token: 0x0400169A RID: 5786
			X,
			// Token: 0x0400169B RID: 5787
			X0,
			// Token: 0x0400169C RID: 5788
			X00,
			// Token: 0x0400169D RID: 5789
			S400_DQ,
			// Token: 0x0400169E RID: 5790
			S400_400_DQ,
			// Token: 0x0400169F RID: 5791
			S400_400_100,
			// Token: 0x040016A0 RID: 5792
			S9,
			// Token: 0x040016A1 RID: 5793
			X00_S9,
			// Token: 0x040016A2 RID: 5794
			S9_DQ,
			// Token: 0x040016A3 RID: 5795
			END = 100
		}
	}
}
