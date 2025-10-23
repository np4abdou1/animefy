using System;
using System.Text;

namespace System.Xml.Schema
{
	// Token: 0x02000342 RID: 834
	internal struct XsdDateTime
	{
		// Token: 0x06001CEF RID: 7407 RVA: 0x000A7C5C File Offset: 0x000A5E5C
		public XsdDateTime(string text, XsdDateTimeFlags kinds)
		{
			this = default(XsdDateTime);
			XsdDateTime.Parser parser = default(XsdDateTime.Parser);
			if (!parser.Parse(text, kinds))
			{
				throw new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
				{
					text,
					kinds
				}));
			}
			this.InitiateXsdDateTime(parser);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000A7CAD File Offset: 0x000A5EAD
		private XsdDateTime(XsdDateTime.Parser parser)
		{
			this = default(XsdDateTime);
			this.InitiateXsdDateTime(parser);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000A7CC0 File Offset: 0x000A5EC0
		private void InitiateXsdDateTime(XsdDateTime.Parser parser)
		{
			this.dt = new DateTime(parser.year, parser.month, parser.day, parser.hour, parser.minute, parser.second);
			if (parser.fraction != 0)
			{
				this.dt = this.dt.AddTicks((long)parser.fraction);
			}
			this.extra = (uint)((int)parser.typeCode << 24 | (XsdDateTime.DateTimeTypeCode)((int)parser.kind << 16) | (XsdDateTime.DateTimeTypeCode)(parser.zoneHour << 8) | (XsdDateTime.DateTimeTypeCode)parser.zoneMinute);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000A7D48 File Offset: 0x000A5F48
		internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result)
		{
			XsdDateTime.Parser parser = default(XsdDateTime.Parser);
			if (!parser.Parse(text, kinds))
			{
				result = default(XsdDateTime);
				return false;
			}
			result = new XsdDateTime(parser);
			return true;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000A7D80 File Offset: 0x000A5F80
		public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
		{
			this.dt = dateTime;
			XsdDateTime.DateTimeTypeCode dateTimeTypeCode = (XsdDateTime.DateTimeTypeCode)(Bits.LeastPosition((uint)kinds) - 1);
			int num = 0;
			int num2 = 0;
			DateTimeKind kind = dateTime.Kind;
			XsdDateTime.XsdDateTimeKind xsdDateTimeKind;
			if (kind != DateTimeKind.Unspecified)
			{
				if (kind != DateTimeKind.Utc)
				{
					TimeSpan utcOffset = TimeZoneInfo.Local.GetUtcOffset(dateTime);
					if (utcOffset.Ticks < 0L)
					{
						xsdDateTimeKind = XsdDateTime.XsdDateTimeKind.LocalWestOfZulu;
						num = -utcOffset.Hours;
						num2 = -utcOffset.Minutes;
					}
					else
					{
						xsdDateTimeKind = XsdDateTime.XsdDateTimeKind.LocalEastOfZulu;
						num = utcOffset.Hours;
						num2 = utcOffset.Minutes;
					}
				}
				else
				{
					xsdDateTimeKind = XsdDateTime.XsdDateTimeKind.Zulu;
				}
			}
			else
			{
				xsdDateTimeKind = XsdDateTime.XsdDateTimeKind.Unspecified;
			}
			this.extra = (uint)((int)dateTimeTypeCode << 24 | (XsdDateTime.DateTimeTypeCode)((int)xsdDateTimeKind << 16) | (XsdDateTime.DateTimeTypeCode)(num << 8) | (XsdDateTime.DateTimeTypeCode)num2);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000A7E12 File Offset: 0x000A6012
		public XsdDateTime(DateTimeOffset dateTimeOffset)
		{
			this = new XsdDateTime(dateTimeOffset, XsdDateTimeFlags.DateTime);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000A7E1C File Offset: 0x000A601C
		public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
		{
			this.dt = dateTimeOffset.DateTime;
			TimeSpan timeSpan = dateTimeOffset.Offset;
			XsdDateTime.DateTimeTypeCode dateTimeTypeCode = (XsdDateTime.DateTimeTypeCode)(Bits.LeastPosition((uint)kinds) - 1);
			XsdDateTime.XsdDateTimeKind xsdDateTimeKind;
			if (timeSpan.TotalMinutes < 0.0)
			{
				timeSpan = timeSpan.Negate();
				xsdDateTimeKind = XsdDateTime.XsdDateTimeKind.LocalWestOfZulu;
			}
			else if (timeSpan.TotalMinutes > 0.0)
			{
				xsdDateTimeKind = XsdDateTime.XsdDateTimeKind.LocalEastOfZulu;
			}
			else
			{
				xsdDateTimeKind = XsdDateTime.XsdDateTimeKind.Zulu;
			}
			this.extra = (uint)((int)dateTimeTypeCode << 24 | (XsdDateTime.DateTimeTypeCode)((int)xsdDateTimeKind << 16) | (XsdDateTime.DateTimeTypeCode)(timeSpan.Hours << 8) | (XsdDateTime.DateTimeTypeCode)timeSpan.Minutes);
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000A7E9E File Offset: 0x000A609E
		private XsdDateTime.DateTimeTypeCode InternalTypeCode
		{
			get
			{
				return (XsdDateTime.DateTimeTypeCode)((this.extra & 4278190080U) >> 24);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x000A7EAF File Offset: 0x000A60AF
		private XsdDateTime.XsdDateTimeKind InternalKind
		{
			get
			{
				return (XsdDateTime.XsdDateTimeKind)((this.extra & 16711680U) >> 16);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x000A7EC0 File Offset: 0x000A60C0
		public int Year
		{
			get
			{
				return this.dt.Year;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x000A7ECD File Offset: 0x000A60CD
		public int Month
		{
			get
			{
				return this.dt.Month;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x000A7EDA File Offset: 0x000A60DA
		public int Day
		{
			get
			{
				return this.dt.Day;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x000A7EE7 File Offset: 0x000A60E7
		public int Hour
		{
			get
			{
				return this.dt.Hour;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x000A7EF4 File Offset: 0x000A60F4
		public int Minute
		{
			get
			{
				return this.dt.Minute;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x000A7F01 File Offset: 0x000A6101
		public int Second
		{
			get
			{
				return this.dt.Second;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x000A7F10 File Offset: 0x000A6110
		public int Fraction
		{
			get
			{
				return (int)(this.dt.Ticks - new DateTime(this.dt.Year, this.dt.Month, this.dt.Day, this.dt.Hour, this.dt.Minute, this.dt.Second).Ticks);
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x000A7F79 File Offset: 0x000A6179
		public int ZoneHour
		{
			get
			{
				return (int)((this.extra & 65280U) >> 8);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x000A7F89 File Offset: 0x000A6189
		public int ZoneMinute
		{
			get
			{
				return (int)(this.extra & 255U);
			}
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000A7F98 File Offset: 0x000A6198
		public static implicit operator DateTime(XsdDateTime xdt)
		{
			XsdDateTime.DateTimeTypeCode internalTypeCode = xdt.InternalTypeCode;
			DateTime dateTime;
			if (internalTypeCode != XsdDateTime.DateTimeTypeCode.Time)
			{
				if (internalTypeCode - XsdDateTime.DateTimeTypeCode.GDay <= 1)
				{
					dateTime = new DateTime(DateTime.Now.Year, xdt.Month, xdt.Day);
				}
				else
				{
					dateTime = xdt.dt;
				}
			}
			else
			{
				DateTime now = DateTime.Now;
				TimeSpan value = new DateTime(now.Year, now.Month, now.Day) - new DateTime(xdt.Year, xdt.Month, xdt.Day);
				dateTime = xdt.dt.Add(value);
			}
			switch (xdt.InternalKind)
			{
			case XsdDateTime.XsdDateTimeKind.Zulu:
				dateTime = new DateTime(dateTime.Ticks, DateTimeKind.Utc);
				break;
			case XsdDateTime.XsdDateTimeKind.LocalWestOfZulu:
			{
				long num = dateTime.Ticks + new TimeSpan(xdt.ZoneHour, xdt.ZoneMinute, 0).Ticks;
				if (num > DateTime.MaxValue.Ticks)
				{
					num += TimeZoneInfo.Local.GetUtcOffset(dateTime).Ticks;
					if (num > DateTime.MaxValue.Ticks)
					{
						num = DateTime.MaxValue.Ticks;
					}
					return new DateTime(num, DateTimeKind.Local);
				}
				dateTime = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
				break;
			}
			case XsdDateTime.XsdDateTimeKind.LocalEastOfZulu:
			{
				long num = dateTime.Ticks - new TimeSpan(xdt.ZoneHour, xdt.ZoneMinute, 0).Ticks;
				if (num < DateTime.MinValue.Ticks)
				{
					num += TimeZoneInfo.Local.GetUtcOffset(dateTime).Ticks;
					if (num < DateTime.MinValue.Ticks)
					{
						num = DateTime.MinValue.Ticks;
					}
					return new DateTime(num, DateTimeKind.Local);
				}
				dateTime = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
				break;
			}
			}
			return dateTime;
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000A8168 File Offset: 0x000A6368
		public static implicit operator DateTimeOffset(XsdDateTime xdt)
		{
			XsdDateTime.DateTimeTypeCode internalTypeCode = xdt.InternalTypeCode;
			DateTime dateTime;
			if (internalTypeCode != XsdDateTime.DateTimeTypeCode.Time)
			{
				if (internalTypeCode - XsdDateTime.DateTimeTypeCode.GDay <= 1)
				{
					dateTime = new DateTime(DateTime.Now.Year, xdt.Month, xdt.Day);
				}
				else
				{
					dateTime = xdt.dt;
				}
			}
			else
			{
				DateTime now = DateTime.Now;
				TimeSpan value = new DateTime(now.Year, now.Month, now.Day) - new DateTime(xdt.Year, xdt.Month, xdt.Day);
				dateTime = xdt.dt.Add(value);
			}
			DateTimeOffset result;
			switch (xdt.InternalKind)
			{
			case XsdDateTime.XsdDateTimeKind.Zulu:
				result = new DateTimeOffset(dateTime, new TimeSpan(0L));
				return result;
			case XsdDateTime.XsdDateTimeKind.LocalWestOfZulu:
				result = new DateTimeOffset(dateTime, new TimeSpan(-xdt.ZoneHour, -xdt.ZoneMinute, 0));
				return result;
			case XsdDateTime.XsdDateTimeKind.LocalEastOfZulu:
				result = new DateTimeOffset(dateTime, new TimeSpan(xdt.ZoneHour, xdt.ZoneMinute, 0));
				return result;
			}
			result = new DateTimeOffset(dateTime, TimeZoneInfo.Local.GetUtcOffset(dateTime));
			return result;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000A828C File Offset: 0x000A648C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(64);
			switch (this.InternalTypeCode)
			{
			case XsdDateTime.DateTimeTypeCode.DateTime:
				this.PrintDate(stringBuilder);
				stringBuilder.Append('T');
				this.PrintTime(stringBuilder);
				break;
			case XsdDateTime.DateTimeTypeCode.Time:
				this.PrintTime(stringBuilder);
				break;
			case XsdDateTime.DateTimeTypeCode.Date:
				this.PrintDate(stringBuilder);
				break;
			case XsdDateTime.DateTimeTypeCode.GYearMonth:
			{
				char[] array = new char[XsdDateTime.Lzyyyy_MM];
				this.IntToCharArray(array, 0, this.Year, 4);
				array[XsdDateTime.Lzyyyy] = '-';
				this.ShortToCharArray(array, XsdDateTime.Lzyyyy_, this.Month);
				stringBuilder.Append(array);
				break;
			}
			case XsdDateTime.DateTimeTypeCode.GYear:
			{
				char[] array = new char[XsdDateTime.Lzyyyy];
				this.IntToCharArray(array, 0, this.Year, 4);
				stringBuilder.Append(array);
				break;
			}
			case XsdDateTime.DateTimeTypeCode.GMonthDay:
			{
				char[] array = new char[XsdDateTime.Lz__mm_dd];
				array[0] = '-';
				array[XsdDateTime.Lz_] = '-';
				this.ShortToCharArray(array, XsdDateTime.Lz__, this.Month);
				array[XsdDateTime.Lz__mm] = '-';
				this.ShortToCharArray(array, XsdDateTime.Lz__mm_, this.Day);
				stringBuilder.Append(array);
				break;
			}
			case XsdDateTime.DateTimeTypeCode.GDay:
			{
				char[] array = new char[XsdDateTime.Lz___dd];
				array[0] = '-';
				array[XsdDateTime.Lz_] = '-';
				array[XsdDateTime.Lz__] = '-';
				this.ShortToCharArray(array, XsdDateTime.Lz___, this.Day);
				stringBuilder.Append(array);
				break;
			}
			case XsdDateTime.DateTimeTypeCode.GMonth:
			{
				char[] array = new char[XsdDateTime.Lz__mm__];
				array[0] = '-';
				array[XsdDateTime.Lz_] = '-';
				this.ShortToCharArray(array, XsdDateTime.Lz__, this.Month);
				array[XsdDateTime.Lz__mm] = '-';
				array[XsdDateTime.Lz__mm_] = '-';
				stringBuilder.Append(array);
				break;
			}
			}
			this.PrintZone(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000A8454 File Offset: 0x000A6654
		private void PrintDate(StringBuilder sb)
		{
			char[] array = new char[XsdDateTime.Lzyyyy_MM_dd];
			this.IntToCharArray(array, 0, this.Year, 4);
			array[XsdDateTime.Lzyyyy] = '-';
			this.ShortToCharArray(array, XsdDateTime.Lzyyyy_, this.Month);
			array[XsdDateTime.Lzyyyy_MM] = '-';
			this.ShortToCharArray(array, XsdDateTime.Lzyyyy_MM_, this.Day);
			sb.Append(array);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000A84BC File Offset: 0x000A66BC
		private void PrintTime(StringBuilder sb)
		{
			char[] array = new char[XsdDateTime.LzHH_mm_ss];
			this.ShortToCharArray(array, 0, this.Hour);
			array[XsdDateTime.LzHH] = ':';
			this.ShortToCharArray(array, XsdDateTime.LzHH_, this.Minute);
			array[XsdDateTime.LzHH_mm] = ':';
			this.ShortToCharArray(array, XsdDateTime.LzHH_mm_, this.Second);
			sb.Append(array);
			int num = this.Fraction;
			if (num != 0)
			{
				int num2 = 7;
				while (num % 10 == 0)
				{
					num2--;
					num /= 10;
				}
				array = new char[num2 + 1];
				array[0] = '.';
				this.IntToCharArray(array, 1, num, num2);
				sb.Append(array);
			}
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000A8560 File Offset: 0x000A6760
		private void PrintZone(StringBuilder sb)
		{
			switch (this.InternalKind)
			{
			case XsdDateTime.XsdDateTimeKind.Zulu:
				sb.Append('Z');
				return;
			case XsdDateTime.XsdDateTimeKind.LocalWestOfZulu:
			{
				char[] array = new char[XsdDateTime.Lz_zz_zz];
				array[0] = '-';
				this.ShortToCharArray(array, XsdDateTime.Lz_, this.ZoneHour);
				array[XsdDateTime.Lz_zz] = ':';
				this.ShortToCharArray(array, XsdDateTime.Lz_zz_, this.ZoneMinute);
				sb.Append(array);
				return;
			}
			case XsdDateTime.XsdDateTimeKind.LocalEastOfZulu:
			{
				char[] array = new char[XsdDateTime.Lz_zz_zz];
				array[0] = '+';
				this.ShortToCharArray(array, XsdDateTime.Lz_, this.ZoneHour);
				array[XsdDateTime.Lz_zz] = ':';
				this.ShortToCharArray(array, XsdDateTime.Lz_zz_, this.ZoneMinute);
				sb.Append(array);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000A861E File Offset: 0x000A681E
		private void IntToCharArray(char[] text, int start, int value, int digits)
		{
			while (digits-- != 0)
			{
				text[start + digits] = (char)(value % 10 + 48);
				value /= 10;
			}
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000A863F File Offset: 0x000A683F
		private void ShortToCharArray(char[] text, int start, int value)
		{
			text[start] = (char)(value / 10 + 48);
			text[start + 1] = (char)(value % 10 + 48);
		}

		// Token: 0x040012AC RID: 4780
		private DateTime dt;

		// Token: 0x040012AD RID: 4781
		private uint extra;

		// Token: 0x040012AE RID: 4782
		private static readonly int Lzyyyy = "yyyy".Length;

		// Token: 0x040012AF RID: 4783
		private static readonly int Lzyyyy_ = "yyyy-".Length;

		// Token: 0x040012B0 RID: 4784
		private static readonly int Lzyyyy_MM = "yyyy-MM".Length;

		// Token: 0x040012B1 RID: 4785
		private static readonly int Lzyyyy_MM_ = "yyyy-MM-".Length;

		// Token: 0x040012B2 RID: 4786
		private static readonly int Lzyyyy_MM_dd = "yyyy-MM-dd".Length;

		// Token: 0x040012B3 RID: 4787
		private static readonly int Lzyyyy_MM_ddT = "yyyy-MM-ddT".Length;

		// Token: 0x040012B4 RID: 4788
		private static readonly int LzHH = "HH".Length;

		// Token: 0x040012B5 RID: 4789
		private static readonly int LzHH_ = "HH:".Length;

		// Token: 0x040012B6 RID: 4790
		private static readonly int LzHH_mm = "HH:mm".Length;

		// Token: 0x040012B7 RID: 4791
		private static readonly int LzHH_mm_ = "HH:mm:".Length;

		// Token: 0x040012B8 RID: 4792
		private static readonly int LzHH_mm_ss = "HH:mm:ss".Length;

		// Token: 0x040012B9 RID: 4793
		private static readonly int Lz_ = "-".Length;

		// Token: 0x040012BA RID: 4794
		private static readonly int Lz_zz = "-zz".Length;

		// Token: 0x040012BB RID: 4795
		private static readonly int Lz_zz_ = "-zz:".Length;

		// Token: 0x040012BC RID: 4796
		private static readonly int Lz_zz_zz = "-zz:zz".Length;

		// Token: 0x040012BD RID: 4797
		private static readonly int Lz__ = "--".Length;

		// Token: 0x040012BE RID: 4798
		private static readonly int Lz__mm = "--MM".Length;

		// Token: 0x040012BF RID: 4799
		private static readonly int Lz__mm_ = "--MM-".Length;

		// Token: 0x040012C0 RID: 4800
		private static readonly int Lz__mm__ = "--MM--".Length;

		// Token: 0x040012C1 RID: 4801
		private static readonly int Lz__mm_dd = "--MM-dd".Length;

		// Token: 0x040012C2 RID: 4802
		private static readonly int Lz___ = "---".Length;

		// Token: 0x040012C3 RID: 4803
		private static readonly int Lz___dd = "---dd".Length;

		// Token: 0x040012C4 RID: 4804
		private static readonly XmlTypeCode[] typeCodes = new XmlTypeCode[]
		{
			XmlTypeCode.DateTime,
			XmlTypeCode.Time,
			XmlTypeCode.Date,
			XmlTypeCode.GYearMonth,
			XmlTypeCode.GYear,
			XmlTypeCode.GMonthDay,
			XmlTypeCode.GDay,
			XmlTypeCode.GMonth
		};

		// Token: 0x02000343 RID: 835
		private enum DateTimeTypeCode
		{
			// Token: 0x040012C6 RID: 4806
			DateTime,
			// Token: 0x040012C7 RID: 4807
			Time,
			// Token: 0x040012C8 RID: 4808
			Date,
			// Token: 0x040012C9 RID: 4809
			GYearMonth,
			// Token: 0x040012CA RID: 4810
			GYear,
			// Token: 0x040012CB RID: 4811
			GMonthDay,
			// Token: 0x040012CC RID: 4812
			GDay,
			// Token: 0x040012CD RID: 4813
			GMonth,
			// Token: 0x040012CE RID: 4814
			XdrDateTime
		}

		// Token: 0x02000344 RID: 836
		private enum XsdDateTimeKind
		{
			// Token: 0x040012D0 RID: 4816
			Unspecified,
			// Token: 0x040012D1 RID: 4817
			Zulu,
			// Token: 0x040012D2 RID: 4818
			LocalWestOfZulu,
			// Token: 0x040012D3 RID: 4819
			LocalEastOfZulu
		}

		// Token: 0x02000345 RID: 837
		private struct Parser
		{
			// Token: 0x06001D0A RID: 7434 RVA: 0x000A87CC File Offset: 0x000A69CC
			public bool Parse(string text, XsdDateTimeFlags kinds)
			{
				this.text = text;
				this.length = text.Length;
				int num = 0;
				while (num < this.length && char.IsWhiteSpace(text[num]))
				{
					num++;
				}
				if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.DateTime | XsdDateTimeFlags.Date | XsdDateTimeFlags.XdrDateTimeNoTz | XsdDateTimeFlags.XdrDateTime) && this.ParseDate(num))
				{
					if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.DateTime) && this.ParseChar(num + XsdDateTime.Lzyyyy_MM_dd, 'T') && this.ParseTimeAndZoneAndWhitespace(num + XsdDateTime.Lzyyyy_MM_ddT))
					{
						this.typeCode = XsdDateTime.DateTimeTypeCode.DateTime;
						return true;
					}
					if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.Date) && this.ParseZoneAndWhitespace(num + XsdDateTime.Lzyyyy_MM_dd))
					{
						this.typeCode = XsdDateTime.DateTimeTypeCode.Date;
						return true;
					}
					if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.XdrDateTime) && (this.ParseZoneAndWhitespace(num + XsdDateTime.Lzyyyy_MM_dd) || (this.ParseChar(num + XsdDateTime.Lzyyyy_MM_dd, 'T') && this.ParseTimeAndZoneAndWhitespace(num + XsdDateTime.Lzyyyy_MM_ddT))))
					{
						this.typeCode = XsdDateTime.DateTimeTypeCode.XdrDateTime;
						return true;
					}
					if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.XdrDateTimeNoTz))
					{
						if (!this.ParseChar(num + XsdDateTime.Lzyyyy_MM_dd, 'T'))
						{
							this.typeCode = XsdDateTime.DateTimeTypeCode.XdrDateTime;
							return true;
						}
						if (this.ParseTimeAndWhitespace(num + XsdDateTime.Lzyyyy_MM_ddT))
						{
							this.typeCode = XsdDateTime.DateTimeTypeCode.XdrDateTime;
							return true;
						}
					}
				}
				if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.Time) && this.ParseTimeAndZoneAndWhitespace(num))
				{
					this.year = 1904;
					this.month = 1;
					this.day = 1;
					this.typeCode = XsdDateTime.DateTimeTypeCode.Time;
					return true;
				}
				if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.XdrTimeNoTz) && this.ParseTimeAndWhitespace(num))
				{
					this.year = 1904;
					this.month = 1;
					this.day = 1;
					this.typeCode = XsdDateTime.DateTimeTypeCode.Time;
					return true;
				}
				if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.GYearMonth | XsdDateTimeFlags.GYear) && this.Parse4Dig(num, ref this.year) && 1 <= this.year)
				{
					if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.GYearMonth) && this.ParseChar(num + XsdDateTime.Lzyyyy, '-') && this.Parse2Dig(num + XsdDateTime.Lzyyyy_, ref this.month) && 1 <= this.month && this.month <= 12 && this.ParseZoneAndWhitespace(num + XsdDateTime.Lzyyyy_MM))
					{
						this.day = 1;
						this.typeCode = XsdDateTime.DateTimeTypeCode.GYearMonth;
						return true;
					}
					if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.GYear) && this.ParseZoneAndWhitespace(num + XsdDateTime.Lzyyyy))
					{
						this.month = 1;
						this.day = 1;
						this.typeCode = XsdDateTime.DateTimeTypeCode.GYear;
						return true;
					}
				}
				if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.GMonthDay | XsdDateTimeFlags.GMonth) && this.ParseChar(num, '-') && this.ParseChar(num + XsdDateTime.Lz_, '-') && this.Parse2Dig(num + XsdDateTime.Lz__, ref this.month) && 1 <= this.month && this.month <= 12)
				{
					if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.GMonthDay) && this.ParseChar(num + XsdDateTime.Lz__mm, '-') && this.Parse2Dig(num + XsdDateTime.Lz__mm_, ref this.day) && 1 <= this.day && this.day <= DateTime.DaysInMonth(1904, this.month) && this.ParseZoneAndWhitespace(num + XsdDateTime.Lz__mm_dd))
					{
						this.year = 1904;
						this.typeCode = XsdDateTime.DateTimeTypeCode.GMonthDay;
						return true;
					}
					if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.GMonth) && (this.ParseZoneAndWhitespace(num + XsdDateTime.Lz__mm) || (this.ParseChar(num + XsdDateTime.Lz__mm, '-') && this.ParseChar(num + XsdDateTime.Lz__mm_, '-') && this.ParseZoneAndWhitespace(num + XsdDateTime.Lz__mm__))))
					{
						this.year = 1904;
						this.day = 1;
						this.typeCode = XsdDateTime.DateTimeTypeCode.GMonth;
						return true;
					}
				}
				if (XsdDateTime.Parser.Test(kinds, XsdDateTimeFlags.GDay) && this.ParseChar(num, '-') && this.ParseChar(num + XsdDateTime.Lz_, '-') && this.ParseChar(num + XsdDateTime.Lz__, '-') && this.Parse2Dig(num + XsdDateTime.Lz___, ref this.day) && 1 <= this.day && this.day <= DateTime.DaysInMonth(1904, 1) && this.ParseZoneAndWhitespace(num + XsdDateTime.Lz___dd))
				{
					this.year = 1904;
					this.month = 1;
					this.typeCode = XsdDateTime.DateTimeTypeCode.GDay;
					return true;
				}
				return false;
			}

			// Token: 0x06001D0B RID: 7435 RVA: 0x000A8BFC File Offset: 0x000A6DFC
			private bool ParseDate(int start)
			{
				return this.Parse4Dig(start, ref this.year) && 1 <= this.year && this.ParseChar(start + XsdDateTime.Lzyyyy, '-') && this.Parse2Dig(start + XsdDateTime.Lzyyyy_, ref this.month) && 1 <= this.month && this.month <= 12 && this.ParseChar(start + XsdDateTime.Lzyyyy_MM, '-') && this.Parse2Dig(start + XsdDateTime.Lzyyyy_MM_, ref this.day) && 1 <= this.day && this.day <= DateTime.DaysInMonth(this.year, this.month);
			}

			// Token: 0x06001D0C RID: 7436 RVA: 0x000A8CAD File Offset: 0x000A6EAD
			private bool ParseTimeAndZoneAndWhitespace(int start)
			{
				return this.ParseTime(ref start) && this.ParseZoneAndWhitespace(start);
			}

			// Token: 0x06001D0D RID: 7437 RVA: 0x000A8CC5 File Offset: 0x000A6EC5
			private bool ParseTimeAndWhitespace(int start)
			{
				if (this.ParseTime(ref start))
				{
					while (start < this.length)
					{
						start++;
					}
					return start == this.length;
				}
				return false;
			}

			// Token: 0x06001D0E RID: 7438 RVA: 0x000A8CEC File Offset: 0x000A6EEC
			private bool ParseTime(ref int start)
			{
				if (this.Parse2Dig(start, ref this.hour) && this.hour < 24 && this.ParseChar(start + XsdDateTime.LzHH, ':') && this.Parse2Dig(start + XsdDateTime.LzHH_, ref this.minute) && this.minute < 60 && this.ParseChar(start + XsdDateTime.LzHH_mm, ':') && this.Parse2Dig(start + XsdDateTime.LzHH_mm_, ref this.second) && this.second < 60)
				{
					start += XsdDateTime.LzHH_mm_ss;
					if (this.ParseChar(start, '.'))
					{
						this.fraction = 0;
						int num = 0;
						int num2 = 0;
						for (;;)
						{
							int num3 = start + 1;
							start = num3;
							if (num3 >= this.length)
							{
								break;
							}
							int num4 = (int)(this.text[start] - '0');
							if (9 < num4)
							{
								break;
							}
							if (num < 7)
							{
								this.fraction = this.fraction * 10 + num4;
							}
							else if (num == 7)
							{
								if (5 < num4)
								{
									num2 = 1;
								}
								else if (num4 == 5)
								{
									num2 = -1;
								}
							}
							else if (num2 < 0 && num4 != 0)
							{
								num2 = 1;
							}
							num++;
						}
						if (num < 7)
						{
							if (num == 0)
							{
								return false;
							}
							this.fraction *= XsdDateTime.Parser.Power10[7 - num];
						}
						else
						{
							if (num2 < 0)
							{
								num2 = (this.fraction & 1);
							}
							this.fraction += num2;
						}
					}
					return true;
				}
				this.hour = 0;
				return false;
			}

			// Token: 0x06001D0F RID: 7439 RVA: 0x000A8E5C File Offset: 0x000A705C
			private bool ParseZoneAndWhitespace(int start)
			{
				if (start < this.length)
				{
					char c = this.text[start];
					if (c == 'Z' || c == 'z')
					{
						this.kind = XsdDateTime.XsdDateTimeKind.Zulu;
						start++;
					}
					else if (start + 5 < this.length && this.Parse2Dig(start + XsdDateTime.Lz_, ref this.zoneHour) && this.zoneHour <= 99 && this.ParseChar(start + XsdDateTime.Lz_zz, ':') && this.Parse2Dig(start + XsdDateTime.Lz_zz_, ref this.zoneMinute) && this.zoneMinute <= 99)
					{
						if (c == '-')
						{
							this.kind = XsdDateTime.XsdDateTimeKind.LocalWestOfZulu;
							start += XsdDateTime.Lz_zz_zz;
						}
						else if (c == '+')
						{
							this.kind = XsdDateTime.XsdDateTimeKind.LocalEastOfZulu;
							start += XsdDateTime.Lz_zz_zz;
						}
					}
				}
				while (start < this.length && char.IsWhiteSpace(this.text[start]))
				{
					start++;
				}
				return start == this.length;
			}

			// Token: 0x06001D10 RID: 7440 RVA: 0x000A8F54 File Offset: 0x000A7154
			private bool Parse4Dig(int start, ref int num)
			{
				if (start + 3 < this.length)
				{
					int num2 = (int)(this.text[start] - '0');
					int num3 = (int)(this.text[start + 1] - '0');
					int num4 = (int)(this.text[start + 2] - '0');
					int num5 = (int)(this.text[start + 3] - '0');
					if (0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10 && 0 <= num4 && num4 < 10 && 0 <= num5 && num5 < 10)
					{
						num = ((num2 * 10 + num3) * 10 + num4) * 10 + num5;
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001D11 RID: 7441 RVA: 0x000A8FEC File Offset: 0x000A71EC
			private bool Parse2Dig(int start, ref int num)
			{
				if (start + 1 < this.length)
				{
					int num2 = (int)(this.text[start] - '0');
					int num3 = (int)(this.text[start + 1] - '0');
					if (0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10)
					{
						num = num2 * 10 + num3;
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001D12 RID: 7442 RVA: 0x000A9043 File Offset: 0x000A7243
			private bool ParseChar(int start, char ch)
			{
				return start < this.length && this.text[start] == ch;
			}

			// Token: 0x06001D13 RID: 7443 RVA: 0x000A905F File Offset: 0x000A725F
			private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
			{
				return (left & right) > (XsdDateTimeFlags)0;
			}

			// Token: 0x040012D4 RID: 4820
			public XsdDateTime.DateTimeTypeCode typeCode;

			// Token: 0x040012D5 RID: 4821
			public int year;

			// Token: 0x040012D6 RID: 4822
			public int month;

			// Token: 0x040012D7 RID: 4823
			public int day;

			// Token: 0x040012D8 RID: 4824
			public int hour;

			// Token: 0x040012D9 RID: 4825
			public int minute;

			// Token: 0x040012DA RID: 4826
			public int second;

			// Token: 0x040012DB RID: 4827
			public int fraction;

			// Token: 0x040012DC RID: 4828
			public XsdDateTime.XsdDateTimeKind kind;

			// Token: 0x040012DD RID: 4829
			public int zoneHour;

			// Token: 0x040012DE RID: 4830
			public int zoneMinute;

			// Token: 0x040012DF RID: 4831
			private string text;

			// Token: 0x040012E0 RID: 4832
			private int length;

			// Token: 0x040012E1 RID: 4833
			private static int[] Power10 = new int[]
			{
				-1,
				10,
				100,
				1000,
				10000,
				100000,
				1000000
			};
		}
	}
}
