using System;
using System.Globalization;
using System.Text;

namespace System.Xml
{
	// Token: 0x02000013 RID: 19
	internal abstract class BinXmlDateTime
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003429 File Offset: 0x00001629
		private static void Write2Dig(StringBuilder sb, int val)
		{
			sb.Append((char)(48 + val / 10));
			sb.Append((char)(48 + val % 10));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003449 File Offset: 0x00001649
		private static void Write4DigNeg(StringBuilder sb, int val)
		{
			if (val < 0)
			{
				val = -val;
				sb.Append('-');
			}
			BinXmlDateTime.Write2Dig(sb, val / 100);
			BinXmlDateTime.Write2Dig(sb, val % 100);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003470 File Offset: 0x00001670
		private static void Write3Dec(StringBuilder sb, int val)
		{
			int num = val % 10;
			val /= 10;
			int num2 = val % 10;
			val /= 10;
			int num3 = val;
			sb.Append('.');
			sb.Append((char)(48 + num3));
			sb.Append((char)(48 + num2));
			sb.Append((char)(48 + num));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000034C2 File Offset: 0x000016C2
		private static void WriteDate(StringBuilder sb, int yr, int mnth, int day)
		{
			BinXmlDateTime.Write4DigNeg(sb, yr);
			sb.Append('-');
			BinXmlDateTime.Write2Dig(sb, mnth);
			sb.Append('-');
			BinXmlDateTime.Write2Dig(sb, day);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000034EB File Offset: 0x000016EB
		private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms)
		{
			BinXmlDateTime.Write2Dig(sb, hr);
			sb.Append(':');
			BinXmlDateTime.Write2Dig(sb, min);
			sb.Append(':');
			BinXmlDateTime.Write2Dig(sb, sec);
			if (ms != 0)
			{
				BinXmlDateTime.Write3Dec(sb, ms);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003520 File Offset: 0x00001720
		private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction)
		{
			BinXmlDateTime.Write2Dig(sb, hr);
			sb.Append(':');
			BinXmlDateTime.Write2Dig(sb, min);
			sb.Append(':');
			BinXmlDateTime.Write2Dig(sb, sec);
			if (fraction != 0)
			{
				int i = 7;
				while (fraction % 10 == 0)
				{
					i--;
					fraction /= 10;
				}
				char[] array = new char[i];
				while (i > 0)
				{
					i--;
					array[i] = (char)(fraction % 10 + 48);
					fraction /= 10;
				}
				sb.Append('.');
				sb.Append(array);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000035A4 File Offset: 0x000017A4
		private static void WriteTimeZone(StringBuilder sb, TimeSpan zone)
		{
			bool negTimeZone = true;
			if (zone.Ticks < 0L)
			{
				negTimeZone = false;
				zone = zone.Negate();
			}
			BinXmlDateTime.WriteTimeZone(sb, negTimeZone, zone.Hours, zone.Minutes);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000035DE File Offset: 0x000017DE
		private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min)
		{
			if (hr == 0 && min == 0)
			{
				sb.Append('Z');
				return;
			}
			sb.Append(negTimeZone ? '+' : '-');
			BinXmlDateTime.Write2Dig(sb, hr);
			sb.Append(':');
			BinXmlDateTime.Write2Dig(sb, min);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003618 File Offset: 0x00001818
		private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms)
		{
			if (val >= 0L)
			{
				long num = val / 4L;
				ms = (int)(num % 1000L);
				num /= 1000L;
				sec = (int)(num % 60L);
				num /= 60L;
				min = (int)(num % 60L);
				num /= 60L;
				hr = (int)(num % 24L);
				num /= 24L;
				day = (int)(num % 31L) + 1;
				num /= 31L;
				mnth = (int)(num % 12L) + 1;
				num /= 12L;
				yr = (int)(num - 9999L);
				if (yr >= -9999 && yr <= 9999)
				{
					return;
				}
			}
			throw new XmlException("Arithmetic Overflow.", null);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000036C0 File Offset: 0x000018C0
		private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min)
		{
			if (val >= 0L)
			{
				val /= 4L;
				int num = (int)(val % 1740L) - 840;
				long num2 = val / 1740L;
				if (negTimeZone = (num < 0))
				{
					num = -num;
				}
				min = num % 60;
				hr = num / 60;
				day = (int)(num2 % 31L) + 1;
				num2 /= 31L;
				mnth = (int)(num2 % 12L) + 1;
				yr = (int)(num2 / 12L) - 9999;
				if (yr >= -9999 && yr <= 9999)
				{
					return;
				}
			}
			throw new XmlException("Arithmetic Overflow.", null);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003754 File Offset: 0x00001954
		private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms)
		{
			if (val >= 0L)
			{
				val /= 4L;
				ms = (int)(val % 1000L);
				val /= 1000L;
				sec = (int)(val % 60L);
				val /= 60L;
				min = (int)(val % 60L);
				hr = (int)(val / 60L);
				if (0 <= hr && hr <= 23)
				{
					return;
				}
			}
			throw new XmlException("Arithmetic Overflow.", null);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000037B8 File Offset: 0x000019B8
		public static string XsdDateTimeToString(long val)
		{
			int yr;
			int mnth;
			int day;
			int hr;
			int min;
			int sec;
			int ms;
			BinXmlDateTime.BreakDownXsdDateTime(val, out yr, out mnth, out day, out hr, out min, out sec, out ms);
			StringBuilder stringBuilder = new StringBuilder(20);
			BinXmlDateTime.WriteDate(stringBuilder, yr, mnth, day);
			stringBuilder.Append('T');
			BinXmlDateTime.WriteTime(stringBuilder, hr, min, sec, ms);
			stringBuilder.Append('Z');
			return stringBuilder.ToString();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003810 File Offset: 0x00001A10
		public static string XsdDateToString(long val)
		{
			int yr;
			int mnth;
			int day;
			bool negTimeZone;
			int hr;
			int min;
			BinXmlDateTime.BreakDownXsdDate(val, out yr, out mnth, out day, out negTimeZone, out hr, out min);
			StringBuilder stringBuilder = new StringBuilder(20);
			BinXmlDateTime.WriteDate(stringBuilder, yr, mnth, day);
			BinXmlDateTime.WriteTimeZone(stringBuilder, negTimeZone, hr, min);
			return stringBuilder.ToString();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003850 File Offset: 0x00001A50
		public static string XsdTimeToString(long val)
		{
			int hr;
			int min;
			int sec;
			int ms;
			BinXmlDateTime.BreakDownXsdTime(val, out hr, out min, out sec, out ms);
			StringBuilder stringBuilder = new StringBuilder(16);
			BinXmlDateTime.WriteTime(stringBuilder, hr, min, sec, ms);
			stringBuilder.Append('Z');
			return stringBuilder.ToString();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000388C File Offset: 0x00001A8C
		public static string SqlDateTimeToString(int dateticks, uint timeticks)
		{
			DateTime dateTime = BinXmlDateTime.SqlDateTimeToDateTime(dateticks, timeticks);
			string format = (dateTime.Millisecond != 0) ? "yyyy/MM/dd\\THH:mm:ss.ffff" : "yyyy/MM/dd\\THH:mm:ss";
			return dateTime.ToString(format, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000038C4 File Offset: 0x00001AC4
		public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks)
		{
			DateTime dateTime = new DateTime(1900, 1, 1);
			long num = (long)(timeticks / BinXmlDateTime.SQLTicksPerMillisecond + 0.5);
			return dateTime.Add(new TimeSpan((long)dateticks * 864000000000L + num * 10000L));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003918 File Offset: 0x00001B18
		public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks)
		{
			return BinXmlDateTime.SqlSmallDateTimeToDateTime(dateticks, timeticks).ToString("yyyy/MM/dd\\THH:mm:ss", CultureInfo.InvariantCulture);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000393E File Offset: 0x00001B3E
		public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks)
		{
			return BinXmlDateTime.SqlDateTimeToDateTime((int)dateticks, (uint)((int)timeticks * BinXmlDateTime.SQLTicksPerMinute));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003950 File Offset: 0x00001B50
		public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset)
		{
			long katmaiDateTicks = BinXmlDateTime.GetKatmaiDateTicks(data, ref offset);
			return new DateTime(katmaiDateTicks);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000396C File Offset: 0x00001B6C
		public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset)
		{
			long katmaiTimeTicks = BinXmlDateTime.GetKatmaiTimeTicks(data, ref offset);
			long katmaiDateTicks = BinXmlDateTime.GetKatmaiDateTicks(data, ref offset);
			return new DateTime(katmaiDateTicks + katmaiTimeTicks);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003993 File Offset: 0x00001B93
		public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset)
		{
			return BinXmlDateTime.XsdKatmaiDateTimeToDateTime(data, offset);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000399C File Offset: 0x00001B9C
		public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset)
		{
			return BinXmlDateTime.XsdKatmaiDateTimeOffsetToDateTimeOffset(data, offset);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000039A8 File Offset: 0x00001BA8
		public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset)
		{
			long katmaiTimeTicks = BinXmlDateTime.GetKatmaiTimeTicks(data, ref offset);
			long katmaiDateTicks = BinXmlDateTime.GetKatmaiDateTicks(data, ref offset);
			long katmaiTimeZoneTicks = BinXmlDateTime.GetKatmaiTimeZoneTicks(data, offset);
			return new DateTimeOffset(katmaiDateTicks + katmaiTimeTicks + katmaiTimeZoneTicks, new TimeSpan(katmaiTimeZoneTicks));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000399C File Offset: 0x00001B9C
		public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset)
		{
			return BinXmlDateTime.XsdKatmaiDateTimeOffsetToDateTimeOffset(data, offset);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000039E0 File Offset: 0x00001BE0
		public static string XsdKatmaiDateToString(byte[] data, int offset)
		{
			DateTime dateTime = BinXmlDateTime.XsdKatmaiDateToDateTime(data, offset);
			StringBuilder stringBuilder = new StringBuilder(10);
			BinXmlDateTime.WriteDate(stringBuilder, dateTime.Year, dateTime.Month, dateTime.Day);
			return stringBuilder.ToString();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003A1C File Offset: 0x00001C1C
		public static string XsdKatmaiDateTimeToString(byte[] data, int offset)
		{
			DateTime dt = BinXmlDateTime.XsdKatmaiDateTimeToDateTime(data, offset);
			StringBuilder stringBuilder = new StringBuilder(33);
			BinXmlDateTime.WriteDate(stringBuilder, dt.Year, dt.Month, dt.Day);
			stringBuilder.Append('T');
			BinXmlDateTime.WriteTimeFullPrecision(stringBuilder, dt.Hour, dt.Minute, dt.Second, BinXmlDateTime.GetFractions(dt));
			return stringBuilder.ToString();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003A84 File Offset: 0x00001C84
		public static string XsdKatmaiTimeToString(byte[] data, int offset)
		{
			DateTime dt = BinXmlDateTime.XsdKatmaiTimeToDateTime(data, offset);
			StringBuilder stringBuilder = new StringBuilder(16);
			BinXmlDateTime.WriteTimeFullPrecision(stringBuilder, dt.Hour, dt.Minute, dt.Second, BinXmlDateTime.GetFractions(dt));
			return stringBuilder.ToString();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003AC8 File Offset: 0x00001CC8
		public static string XsdKatmaiDateOffsetToString(byte[] data, int offset)
		{
			DateTimeOffset dateTimeOffset = BinXmlDateTime.XsdKatmaiDateOffsetToDateTimeOffset(data, offset);
			StringBuilder stringBuilder = new StringBuilder(16);
			BinXmlDateTime.WriteDate(stringBuilder, dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day);
			BinXmlDateTime.WriteTimeZone(stringBuilder, dateTimeOffset.Offset);
			return stringBuilder.ToString();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003B14 File Offset: 0x00001D14
		public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset)
		{
			DateTimeOffset dt = BinXmlDateTime.XsdKatmaiDateTimeOffsetToDateTimeOffset(data, offset);
			StringBuilder stringBuilder = new StringBuilder(39);
			BinXmlDateTime.WriteDate(stringBuilder, dt.Year, dt.Month, dt.Day);
			stringBuilder.Append('T');
			BinXmlDateTime.WriteTimeFullPrecision(stringBuilder, dt.Hour, dt.Minute, dt.Second, BinXmlDateTime.GetFractions(dt));
			BinXmlDateTime.WriteTimeZone(stringBuilder, dt.Offset);
			return stringBuilder.ToString();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003B88 File Offset: 0x00001D88
		public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset)
		{
			DateTimeOffset dt = BinXmlDateTime.XsdKatmaiTimeOffsetToDateTimeOffset(data, offset);
			StringBuilder stringBuilder = new StringBuilder(22);
			BinXmlDateTime.WriteTimeFullPrecision(stringBuilder, dt.Hour, dt.Minute, dt.Second, BinXmlDateTime.GetFractions(dt));
			BinXmlDateTime.WriteTimeZone(stringBuilder, dt.Offset);
			return stringBuilder.ToString();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003BD8 File Offset: 0x00001DD8
		private static long GetKatmaiDateTicks(byte[] data, ref int pos)
		{
			int num = pos;
			pos = num + 3;
			return (long)((int)data[num] | (int)data[num + 1] << 8 | (int)data[num + 2] << 16) * 864000000000L;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003C0C File Offset: 0x00001E0C
		private static long GetKatmaiTimeTicks(byte[] data, ref int pos)
		{
			int num = pos;
			byte b = data[num];
			num++;
			long num2;
			if (b <= 2)
			{
				num2 = (long)((int)data[num] | (int)data[num + 1] << 8 | (int)data[num + 2] << 16);
				pos = num + 3;
			}
			else if (b <= 4)
			{
				num2 = (long)((int)data[num] | (int)data[num + 1] << 8 | (int)data[num + 2] << 16);
				num2 |= (long)((long)((ulong)data[num + 3]) << 24);
				pos = num + 4;
			}
			else
			{
				if (b > 7)
				{
					throw new XmlException("Arithmetic Overflow.", null);
				}
				num2 = (long)((int)data[num] | (int)data[num + 1] << 8 | (int)data[num + 2] << 16);
				num2 |= (long)((ulong)data[num + 3] << 24 | (ulong)data[num + 4] << 32);
				pos = num + 5;
			}
			return num2 * (long)BinXmlDateTime.KatmaiTimeScaleMultiplicator[(int)b];
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003CBF File Offset: 0x00001EBF
		private static long GetKatmaiTimeZoneTicks(byte[] data, int pos)
		{
			return (long)((short)((int)data[pos] | (int)data[pos + 1] << 8)) * 600000000L;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003CD8 File Offset: 0x00001ED8
		private static int GetFractions(DateTime dt)
		{
			return (int)(dt.Ticks - new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second).Ticks);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003D28 File Offset: 0x00001F28
		private static int GetFractions(DateTimeOffset dt)
		{
			return (int)(dt.Ticks - new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second).Ticks);
		}

		// Token: 0x04000088 RID: 136
		internal static int[] KatmaiTimeScaleMultiplicator = new int[]
		{
			10000000,
			1000000,
			100000,
			10000,
			1000,
			100,
			10,
			1
		};

		// Token: 0x04000089 RID: 137
		private static readonly double SQLTicksPerMillisecond = 0.3;

		// Token: 0x0400008A RID: 138
		public static readonly int SQLTicksPerSecond = 300;

		// Token: 0x0400008B RID: 139
		public static readonly int SQLTicksPerMinute = BinXmlDateTime.SQLTicksPerSecond * 60;

		// Token: 0x0400008C RID: 140
		public static readonly int SQLTicksPerHour = BinXmlDateTime.SQLTicksPerMinute * 60;

		// Token: 0x0400008D RID: 141
		private static readonly int SQLTicksPerDay = BinXmlDateTime.SQLTicksPerHour * 24;
	}
}
