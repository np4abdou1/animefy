using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A1 RID: 161
	[NullableContext(1)]
	[Nullable(0)]
	internal struct DateTimeParser
	{
		// Token: 0x0600053F RID: 1343 RVA: 0x0001CD82 File Offset: 0x0001AF82
		public bool Parse(char[] text, int startIndex, int length)
		{
			this._text = text;
			this._end = startIndex + length;
			return this.ParseDate(startIndex) && this.ParseChar(DateTimeParser.Lzyyyy_MM_dd + startIndex, 'T') && this.ParseTimeAndZoneAndWhitespace(DateTimeParser.Lzyyyy_MM_ddT + startIndex);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
		private bool ParseDate(int start)
		{
			return this.Parse4Digit(start, out this.Year) && 1 <= this.Year && this.ParseChar(start + DateTimeParser.Lzyyyy, '-') && this.Parse2Digit(start + DateTimeParser.Lzyyyy_, out this.Month) && 1 <= this.Month && this.Month <= 12 && this.ParseChar(start + DateTimeParser.Lzyyyy_MM, '-') && this.Parse2Digit(start + DateTimeParser.Lzyyyy_MM_, out this.Day) && 1 <= this.Day && this.Day <= DateTime.DaysInMonth(this.Year, this.Month);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001CE71 File Offset: 0x0001B071
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return this.ParseTime(ref start) && this.ParseZone(start);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001CE88 File Offset: 0x0001B088
		private bool ParseTime(ref int start)
		{
			if (!this.Parse2Digit(start, out this.Hour) || this.Hour > 24 || !this.ParseChar(start + DateTimeParser.LzHH, ':') || !this.Parse2Digit(start + DateTimeParser.LzHH_, out this.Minute) || this.Minute >= 60 || !this.ParseChar(start + DateTimeParser.LzHH_mm, ':') || !this.Parse2Digit(start + DateTimeParser.LzHH_mm_, out this.Second) || this.Second >= 60 || (this.Hour == 24 && (this.Minute != 0 || this.Second != 0)))
			{
				return false;
			}
			start += DateTimeParser.LzHH_mm_ss;
			if (this.ParseChar(start, '.'))
			{
				this.Fraction = 0;
				int num = 0;
				for (;;)
				{
					int num2 = start + 1;
					start = num2;
					if (num2 >= this._end || num >= 7)
					{
						break;
					}
					int num3 = (int)(this._text[start] - '0');
					if (num3 < 0 || num3 > 9)
					{
						break;
					}
					this.Fraction = this.Fraction * 10 + num3;
					num++;
				}
				if (num < 7)
				{
					if (num == 0)
					{
						return false;
					}
					this.Fraction *= DateTimeParser.Power10[7 - num];
				}
				if (this.Hour == 24 && this.Fraction != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		private bool ParseZone(int start)
		{
			if (start < this._end)
			{
				char c = this._text[start];
				if (c == 'Z' || c == 'z')
				{
					this.Zone = ParserTimeZone.Utc;
					start++;
				}
				else
				{
					if (start + 2 < this._end && this.Parse2Digit(start + DateTimeParser.Lz_, out this.ZoneHour) && this.ZoneHour <= 99)
					{
						if (c != '+')
						{
							if (c == '-')
							{
								this.Zone = ParserTimeZone.LocalWestOfUtc;
								start += DateTimeParser.Lz_zz;
							}
						}
						else
						{
							this.Zone = ParserTimeZone.LocalEastOfUtc;
							start += DateTimeParser.Lz_zz;
						}
					}
					if (start < this._end)
					{
						if (this.ParseChar(start, ':'))
						{
							start++;
							if (start + 1 < this._end && this.Parse2Digit(start, out this.ZoneMinute) && this.ZoneMinute <= 99)
							{
								start += 2;
							}
						}
						else if (start + 1 < this._end && this.Parse2Digit(start, out this.ZoneMinute) && this.ZoneMinute <= 99)
						{
							start += 2;
						}
					}
				}
			}
			return start == this._end;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0001D0D4 File Offset: 0x0001B2D4
		private bool Parse4Digit(int start, out int num)
		{
			if (start + 3 < this._end)
			{
				int num2 = (int)(this._text[start] - '0');
				int num3 = (int)(this._text[start + 1] - '0');
				int num4 = (int)(this._text[start + 2] - '0');
				int num5 = (int)(this._text[start + 3] - '0');
				if (0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10 && 0 <= num4 && num4 < 10 && 0 <= num5 && num5 < 10)
				{
					num = ((num2 * 10 + num3) * 10 + num4) * 10 + num5;
					return true;
				}
			}
			num = 0;
			return false;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001D160 File Offset: 0x0001B360
		private bool Parse2Digit(int start, out int num)
		{
			if (start + 1 < this._end)
			{
				int num2 = (int)(this._text[start] - '0');
				int num3 = (int)(this._text[start + 1] - '0');
				if (0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10)
				{
					num = num2 * 10 + num3;
					return true;
				}
			}
			num = 0;
			return false;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001D1B2 File Offset: 0x0001B3B2
		private bool ParseChar(int start, char ch)
		{
			return start < this._end && this._text[start] == ch;
		}

		// Token: 0x040003DA RID: 986
		public int Year;

		// Token: 0x040003DB RID: 987
		public int Month;

		// Token: 0x040003DC RID: 988
		public int Day;

		// Token: 0x040003DD RID: 989
		public int Hour;

		// Token: 0x040003DE RID: 990
		public int Minute;

		// Token: 0x040003DF RID: 991
		public int Second;

		// Token: 0x040003E0 RID: 992
		public int Fraction;

		// Token: 0x040003E1 RID: 993
		public int ZoneHour;

		// Token: 0x040003E2 RID: 994
		public int ZoneMinute;

		// Token: 0x040003E3 RID: 995
		public ParserTimeZone Zone;

		// Token: 0x040003E4 RID: 996
		private char[] _text;

		// Token: 0x040003E5 RID: 997
		private int _end;

		// Token: 0x040003E6 RID: 998
		private static readonly int[] Power10 = new int[]
		{
			-1,
			10,
			100,
			1000,
			10000,
			100000,
			1000000
		};

		// Token: 0x040003E7 RID: 999
		private static readonly int Lzyyyy = "yyyy".Length;

		// Token: 0x040003E8 RID: 1000
		private static readonly int Lzyyyy_ = "yyyy-".Length;

		// Token: 0x040003E9 RID: 1001
		private static readonly int Lzyyyy_MM = "yyyy-MM".Length;

		// Token: 0x040003EA RID: 1002
		private static readonly int Lzyyyy_MM_ = "yyyy-MM-".Length;

		// Token: 0x040003EB RID: 1003
		private static readonly int Lzyyyy_MM_dd = "yyyy-MM-dd".Length;

		// Token: 0x040003EC RID: 1004
		private static readonly int Lzyyyy_MM_ddT = "yyyy-MM-ddT".Length;

		// Token: 0x040003ED RID: 1005
		private static readonly int LzHH = "HH".Length;

		// Token: 0x040003EE RID: 1006
		private static readonly int LzHH_ = "HH:".Length;

		// Token: 0x040003EF RID: 1007
		private static readonly int LzHH_mm = "HH:mm".Length;

		// Token: 0x040003F0 RID: 1008
		private static readonly int LzHH_mm_ = "HH:mm:".Length;

		// Token: 0x040003F1 RID: 1009
		private static readonly int LzHH_mm_ss = "HH:mm:ss".Length;

		// Token: 0x040003F2 RID: 1010
		private static readonly int Lz_ = "-".Length;

		// Token: 0x040003F3 RID: 1011
		private static readonly int Lz_zz = "-zz".Length;

		// Token: 0x040003F4 RID: 1012
		private const short MaxFractionDigits = 7;
	}
}
