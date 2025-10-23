using System;
using System.Text;

namespace System.Xml.Schema
{
	// Token: 0x02000346 RID: 838
	internal struct XsdDuration
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x000A9080 File Offset: 0x000A7280
		public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
		{
			if (years < 0)
			{
				throw new ArgumentOutOfRangeException("years");
			}
			if (months < 0)
			{
				throw new ArgumentOutOfRangeException("months");
			}
			if (days < 0)
			{
				throw new ArgumentOutOfRangeException("days");
			}
			if (hours < 0)
			{
				throw new ArgumentOutOfRangeException("hours");
			}
			if (minutes < 0)
			{
				throw new ArgumentOutOfRangeException("minutes");
			}
			if (seconds < 0)
			{
				throw new ArgumentOutOfRangeException("seconds");
			}
			if (nanoseconds < 0 || nanoseconds > 999999999)
			{
				throw new ArgumentOutOfRangeException("nanoseconds");
			}
			this.years = years;
			this.months = months;
			this.days = days;
			this.hours = hours;
			this.minutes = minutes;
			this.seconds = seconds;
			this.nanoseconds = (uint)nanoseconds;
			if (isNegative)
			{
				this.nanoseconds |= 2147483648U;
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000A914F File Offset: 0x000A734F
		public XsdDuration(TimeSpan timeSpan)
		{
			this = new XsdDuration(timeSpan, XsdDuration.DurationType.Duration);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000A915C File Offset: 0x000A735C
		public XsdDuration(TimeSpan timeSpan, XsdDuration.DurationType durationType)
		{
			long ticks = timeSpan.Ticks;
			bool flag;
			ulong num;
			if (ticks < 0L)
			{
				flag = true;
				num = (ulong)(-(ulong)ticks);
			}
			else
			{
				flag = false;
				num = (ulong)ticks;
			}
			if (durationType == XsdDuration.DurationType.YearMonthDuration)
			{
				int num2 = (int)(num / 315360000000000UL);
				int num3 = (int)(num % 315360000000000UL / 25920000000000UL);
				if (num3 == 12)
				{
					num2++;
					num3 = 0;
				}
				this = new XsdDuration(flag, num2, num3, 0, 0, 0, 0, 0);
				return;
			}
			this.nanoseconds = (uint)(num % 10000000UL) * 100U;
			if (flag)
			{
				this.nanoseconds |= 2147483648U;
			}
			this.years = 0;
			this.months = 0;
			this.days = (int)(num / 864000000000UL);
			this.hours = (int)(num / 36000000000UL % 24UL);
			this.minutes = (int)(num / 600000000UL % 60UL);
			this.seconds = (int)(num / 10000000UL % 60UL);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000A924F File Offset: 0x000A744F
		public XsdDuration(string s)
		{
			this = new XsdDuration(s, XsdDuration.DurationType.Duration);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000A925C File Offset: 0x000A745C
		public XsdDuration(string s, XsdDuration.DurationType durationType)
		{
			XsdDuration xsdDuration;
			Exception ex = XsdDuration.TryParse(s, durationType, out xsdDuration);
			if (ex != null)
			{
				throw ex;
			}
			this.years = xsdDuration.Years;
			this.months = xsdDuration.Months;
			this.days = xsdDuration.Days;
			this.hours = xsdDuration.Hours;
			this.minutes = xsdDuration.Minutes;
			this.seconds = xsdDuration.Seconds;
			this.nanoseconds = (uint)xsdDuration.Nanoseconds;
			if (xsdDuration.IsNegative)
			{
				this.nanoseconds |= 2147483648U;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x000A92EE File Offset: 0x000A74EE
		public bool IsNegative
		{
			get
			{
				return (this.nanoseconds & 2147483648U) > 0U;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x000A92FF File Offset: 0x000A74FF
		public int Years
		{
			get
			{
				return this.years;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x000A9307 File Offset: 0x000A7507
		public int Months
		{
			get
			{
				return this.months;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x000A930F File Offset: 0x000A750F
		public int Days
		{
			get
			{
				return this.days;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x000A9317 File Offset: 0x000A7517
		public int Hours
		{
			get
			{
				return this.hours;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x000A931F File Offset: 0x000A751F
		public int Minutes
		{
			get
			{
				return this.minutes;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x000A9327 File Offset: 0x000A7527
		public int Seconds
		{
			get
			{
				return this.seconds;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x000A932F File Offset: 0x000A752F
		public int Nanoseconds
		{
			get
			{
				return (int)(this.nanoseconds & 2147483647U);
			}
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000A933D File Offset: 0x000A753D
		public TimeSpan ToTimeSpan()
		{
			return this.ToTimeSpan(XsdDuration.DurationType.Duration);
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x000A9348 File Offset: 0x000A7548
		public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType)
		{
			TimeSpan result;
			Exception ex = this.TryToTimeSpan(durationType, out result);
			if (ex != null)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000A9365 File Offset: 0x000A7565
		internal Exception TryToTimeSpan(out TimeSpan result)
		{
			return this.TryToTimeSpan(XsdDuration.DurationType.Duration, out result);
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000A9370 File Offset: 0x000A7570
		internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result)
		{
			Exception result2 = null;
			ulong num = 0UL;
			checked
			{
				try
				{
					if (durationType != XsdDuration.DurationType.DayTimeDuration)
					{
						num += ((ulong)this.years + (ulong)this.months / 12UL) * 365UL;
						num += (ulong)this.months % 12UL * 30UL;
					}
					if (durationType != XsdDuration.DurationType.YearMonthDuration)
					{
						num += (ulong)this.days;
						num *= 24UL;
						num += (ulong)this.hours;
						num *= 60UL;
						num += (ulong)this.minutes;
						num *= 60UL;
						num += (ulong)this.seconds;
						num *= 10000000UL;
						num += (ulong)this.Nanoseconds / 100UL;
					}
					else
					{
						num *= 864000000000UL;
					}
					if (this.IsNegative)
					{
						if (num == 9223372036854775808UL)
						{
							result = new TimeSpan(long.MinValue);
						}
						else
						{
							result = new TimeSpan(0L - (long)num);
						}
					}
					else
					{
						result = new TimeSpan((long)num);
					}
					return null;
				}
				catch (OverflowException)
				{
					result = TimeSpan.MinValue;
					result2 = new OverflowException(Res.GetString("Value '{0}' was either too large or too small for {1}.", new object[]
					{
						durationType,
						"TimeSpan"
					}));
				}
				return result2;
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000A94B0 File Offset: 0x000A76B0
		public override string ToString()
		{
			return this.ToString(XsdDuration.DurationType.Duration);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x000A94BC File Offset: 0x000A76BC
		internal string ToString(XsdDuration.DurationType durationType)
		{
			StringBuilder stringBuilder = new StringBuilder(20);
			if (this.IsNegative)
			{
				stringBuilder.Append('-');
			}
			stringBuilder.Append('P');
			if (durationType != XsdDuration.DurationType.DayTimeDuration)
			{
				if (this.years != 0)
				{
					stringBuilder.Append(XmlConvert.ToString(this.years));
					stringBuilder.Append('Y');
				}
				if (this.months != 0)
				{
					stringBuilder.Append(XmlConvert.ToString(this.months));
					stringBuilder.Append('M');
				}
			}
			if (durationType != XsdDuration.DurationType.YearMonthDuration)
			{
				if (this.days != 0)
				{
					stringBuilder.Append(XmlConvert.ToString(this.days));
					stringBuilder.Append('D');
				}
				if (this.hours != 0 || this.minutes != 0 || this.seconds != 0 || this.Nanoseconds != 0)
				{
					stringBuilder.Append('T');
					if (this.hours != 0)
					{
						stringBuilder.Append(XmlConvert.ToString(this.hours));
						stringBuilder.Append('H');
					}
					if (this.minutes != 0)
					{
						stringBuilder.Append(XmlConvert.ToString(this.minutes));
						stringBuilder.Append('M');
					}
					int num = this.Nanoseconds;
					if (this.seconds != 0 || num != 0)
					{
						stringBuilder.Append(XmlConvert.ToString(this.seconds));
						if (num != 0)
						{
							stringBuilder.Append('.');
							int length = stringBuilder.Length;
							stringBuilder.Length += 9;
							int num2 = stringBuilder.Length - 1;
							for (int i = num2; i >= length; i--)
							{
								int num3 = num % 10;
								stringBuilder[i] = (char)(num3 + 48);
								if (num2 == i && num3 == 0)
								{
									num2--;
								}
								num /= 10;
							}
							stringBuilder.Length = num2 + 1;
						}
						stringBuilder.Append('S');
					}
				}
				if (stringBuilder[stringBuilder.Length - 1] == 'P')
				{
					stringBuilder.Append("T0S");
				}
			}
			else if (stringBuilder[stringBuilder.Length - 1] == 'P')
			{
				stringBuilder.Append("0M");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x000A96AE File Offset: 0x000A78AE
		internal static Exception TryParse(string s, out XsdDuration result)
		{
			return XsdDuration.TryParse(s, XsdDuration.DurationType.Duration, out result);
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x000A96B8 File Offset: 0x000A78B8
		internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result)
		{
			XsdDuration.Parts parts = XsdDuration.Parts.HasNone;
			result = default(XsdDuration);
			s = s.Trim();
			int length = s.Length;
			int num = 0;
			int i = 0;
			if (num < length)
			{
				if (s[num] == '-')
				{
					num++;
					result.nanoseconds = 2147483648U;
				}
				else
				{
					result.nanoseconds = 0U;
				}
				if (num < length && s[num++] == 'P')
				{
					int num2;
					if (XsdDuration.TryParseDigits(s, ref num, false, out num2, out i) == null)
					{
						if (num >= length)
						{
							goto IL_2B5;
						}
						if (s[num] == 'Y')
						{
							if (i == 0)
							{
								goto IL_2B5;
							}
							parts |= XsdDuration.Parts.HasYears;
							result.years = num2;
							if (++num == length)
							{
								goto IL_298;
							}
							if (XsdDuration.TryParseDigits(s, ref num, false, out num2, out i) != null)
							{
								goto IL_2D8;
							}
							if (num >= length)
							{
								goto IL_2B5;
							}
						}
						if (s[num] == 'M')
						{
							if (i == 0)
							{
								goto IL_2B5;
							}
							parts |= XsdDuration.Parts.HasMonths;
							result.months = num2;
							if (++num == length)
							{
								goto IL_298;
							}
							if (XsdDuration.TryParseDigits(s, ref num, false, out num2, out i) != null)
							{
								goto IL_2D8;
							}
							if (num >= length)
							{
								goto IL_2B5;
							}
						}
						if (s[num] == 'D')
						{
							if (i == 0)
							{
								goto IL_2B5;
							}
							parts |= XsdDuration.Parts.HasDays;
							result.days = num2;
							if (++num == length)
							{
								goto IL_298;
							}
							if (XsdDuration.TryParseDigits(s, ref num, false, out num2, out i) != null)
							{
								goto IL_2D8;
							}
							if (num >= length)
							{
								goto IL_2B5;
							}
						}
						if (s[num] == 'T')
						{
							if (i != 0)
							{
								goto IL_2B5;
							}
							num++;
							if (XsdDuration.TryParseDigits(s, ref num, false, out num2, out i) != null)
							{
								goto IL_2D8;
							}
							if (num >= length)
							{
								goto IL_2B5;
							}
							if (s[num] == 'H')
							{
								if (i == 0)
								{
									goto IL_2B5;
								}
								parts |= XsdDuration.Parts.HasHours;
								result.hours = num2;
								if (++num == length)
								{
									goto IL_298;
								}
								if (XsdDuration.TryParseDigits(s, ref num, false, out num2, out i) != null)
								{
									goto IL_2D8;
								}
								if (num >= length)
								{
									goto IL_2B5;
								}
							}
							if (s[num] == 'M')
							{
								if (i == 0)
								{
									goto IL_2B5;
								}
								parts |= XsdDuration.Parts.HasMinutes;
								result.minutes = num2;
								if (++num == length)
								{
									goto IL_298;
								}
								if (XsdDuration.TryParseDigits(s, ref num, false, out num2, out i) != null)
								{
									goto IL_2D8;
								}
								if (num >= length)
								{
									goto IL_2B5;
								}
							}
							if (s[num] == '.')
							{
								num++;
								parts |= XsdDuration.Parts.HasSeconds;
								result.seconds = num2;
								if (XsdDuration.TryParseDigits(s, ref num, true, out num2, out i) != null)
								{
									goto IL_2D8;
								}
								if (i == 0)
								{
									num2 = 0;
								}
								while (i > 9)
								{
									num2 /= 10;
									i--;
								}
								while (i < 9)
								{
									num2 *= 10;
									i++;
								}
								result.nanoseconds |= (uint)num2;
								if (num >= length || s[num] != 'S')
								{
									goto IL_2B5;
								}
								if (++num == length)
								{
									goto IL_298;
								}
							}
							else if (s[num] == 'S')
							{
								if (i == 0)
								{
									goto IL_2B5;
								}
								parts |= XsdDuration.Parts.HasSeconds;
								result.seconds = num2;
								if (++num == length)
								{
									goto IL_298;
								}
							}
						}
						if (i != 0 || num != length)
						{
							goto IL_2B5;
						}
						IL_298:
						if (parts != XsdDuration.Parts.HasNone)
						{
							if (durationType == XsdDuration.DurationType.DayTimeDuration)
							{
								if ((parts & (XsdDuration.Parts)3) != XsdDuration.Parts.HasNone)
								{
									goto IL_2B5;
								}
							}
							else if (durationType == XsdDuration.DurationType.YearMonthDuration && (parts & (XsdDuration.Parts)(-4)) != XsdDuration.Parts.HasNone)
							{
								goto IL_2B5;
							}
							return null;
						}
						goto IL_2B5;
					}
					IL_2D8:
					return new OverflowException(Res.GetString("Value '{0}' was either too large or too small for {1}.", new object[]
					{
						s,
						durationType
					}));
				}
			}
			IL_2B5:
			return new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
			{
				s,
				durationType
			}));
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x000A99C0 File Offset: 0x000A7BC0
		private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits)
		{
			int num = offset;
			int length = s.Length;
			result = 0;
			numDigits = 0;
			while (offset < length && s[offset] >= '0' && s[offset] <= '9')
			{
				int num2 = (int)(s[offset] - '0');
				if (result > (2147483647 - num2) / 10)
				{
					if (!eatDigits)
					{
						return "Value '{0}' was either too large or too small for {1}.";
					}
					numDigits = offset - num;
					while (offset < length && s[offset] >= '0' && s[offset] <= '9')
					{
						offset++;
					}
					return null;
				}
				else
				{
					result = result * 10 + num2;
					offset++;
				}
			}
			numDigits = offset - num;
			return null;
		}

		// Token: 0x040012E2 RID: 4834
		private int years;

		// Token: 0x040012E3 RID: 4835
		private int months;

		// Token: 0x040012E4 RID: 4836
		private int days;

		// Token: 0x040012E5 RID: 4837
		private int hours;

		// Token: 0x040012E6 RID: 4838
		private int minutes;

		// Token: 0x040012E7 RID: 4839
		private int seconds;

		// Token: 0x040012E8 RID: 4840
		private uint nanoseconds;

		// Token: 0x02000347 RID: 839
		private enum Parts
		{
			// Token: 0x040012EA RID: 4842
			HasNone,
			// Token: 0x040012EB RID: 4843
			HasYears,
			// Token: 0x040012EC RID: 4844
			HasMonths,
			// Token: 0x040012ED RID: 4845
			HasDays = 4,
			// Token: 0x040012EE RID: 4846
			HasHours = 8,
			// Token: 0x040012EF RID: 4847
			HasMinutes = 16,
			// Token: 0x040012F0 RID: 4848
			HasSeconds = 32
		}

		// Token: 0x02000348 RID: 840
		public enum DurationType
		{
			// Token: 0x040012F2 RID: 4850
			Duration,
			// Token: 0x040012F3 RID: 4851
			YearMonthDuration,
			// Token: 0x040012F4 RID: 4852
			DayTimeDuration
		}
	}
}
