using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	/// <summary>Provides culture-specific information about the format of date and time values.</summary>
	// Token: 0x0200057D RID: 1405
	[Serializable]
	public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
	{
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x000A7C19 File Offset: 0x000A5E19
		private string CultureName
		{
			get
			{
				if (this._name == null)
				{
					this._name = this._cultureData.CultureName;
				}
				return this._name;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000A7C3A File Offset: 0x000A5E3A
		private CultureInfo Culture
		{
			get
			{
				if (this._cultureInfo == null)
				{
					this._cultureInfo = CultureInfo.GetCultureInfo(this.CultureName);
				}
				return this._cultureInfo;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x000A7C5B File Offset: 0x000A5E5B
		private string LanguageName
		{
			get
			{
				if (this._langName == null)
				{
					this._langName = this._cultureData.SISO639LANGNAME;
				}
				return this._langName;
			}
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000A7C7C File Offset: 0x000A5E7C
		private string[] internalGetAbbreviatedDayOfWeekNames()
		{
			return this.abbreviatedDayNames ?? this.internalGetAbbreviatedDayOfWeekNamesCore();
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x000A7C8E File Offset: 0x000A5E8E
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetAbbreviatedDayOfWeekNamesCore()
		{
			this.abbreviatedDayNames = this._cultureData.AbbreviatedDayNames(this.Calendar.ID);
			return this.abbreviatedDayNames;
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000A7CB2 File Offset: 0x000A5EB2
		private string[] internalGetDayOfWeekNames()
		{
			return this.dayNames ?? this.internalGetDayOfWeekNamesCore();
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000A7CC4 File Offset: 0x000A5EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetDayOfWeekNamesCore()
		{
			this.dayNames = this._cultureData.DayNames(this.Calendar.ID);
			return this.dayNames;
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000A7CE8 File Offset: 0x000A5EE8
		private string[] internalGetAbbreviatedMonthNames()
		{
			return this.abbreviatedMonthNames ?? this.internalGetAbbreviatedMonthNamesCore();
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x000A7CFA File Offset: 0x000A5EFA
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetAbbreviatedMonthNamesCore()
		{
			this.abbreviatedMonthNames = this._cultureData.AbbreviatedMonthNames(this.Calendar.ID);
			return this.abbreviatedMonthNames;
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x000A7D1E File Offset: 0x000A5F1E
		private string[] internalGetMonthNames()
		{
			return this.monthNames ?? this.internalGetMonthNamesCore();
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x000A7D30 File Offset: 0x000A5F30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetMonthNamesCore()
		{
			this.monthNames = this._cultureData.MonthNames(this.Calendar.ID);
			return this.monthNames;
		}

		/// <summary>Initializes a new writable instance of the <see cref="T:System.Globalization.DateTimeFormatInfo" /> class that is culture-independent (invariant).</summary>
		// Token: 0x06002A0F RID: 10767 RVA: 0x000A7D54 File Offset: 0x000A5F54
		public DateTimeFormatInfo()
		{
			this._cultureData = CultureInfo.InvariantCulture._cultureData;
			this.calendar = GregorianCalendar.GetDefaultInstance();
			this.InitializeOverridableProperties(this._cultureData, this.calendar.ID);
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x000A7DAE File Offset: 0x000A5FAE
		internal DateTimeFormatInfo(CultureData cultureData, Calendar cal)
		{
			this._cultureData = cultureData;
			this.Calendar = cal;
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x000A7DDC File Offset: 0x000A5FDC
		private void InitializeOverridableProperties(CultureData cultureData, int calendarId)
		{
			if (this.firstDayOfWeek == -1)
			{
				this.firstDayOfWeek = cultureData.IFIRSTDAYOFWEEK;
			}
			if (this.calendarWeekRule == -1)
			{
				this.calendarWeekRule = cultureData.IFIRSTWEEKOFYEAR;
			}
			if (this.amDesignator == null)
			{
				this.amDesignator = cultureData.SAM1159;
			}
			if (this.pmDesignator == null)
			{
				this.pmDesignator = cultureData.SPM2359;
			}
			if (this.timeSeparator == null)
			{
				this.timeSeparator = cultureData.TimeSeparator;
			}
			if (this.dateSeparator == null)
			{
				this.dateSeparator = cultureData.DateSeparator(calendarId);
			}
			this.allLongTimePatterns = this._cultureData.LongTimes;
			this.allShortTimePatterns = this._cultureData.ShortTimes;
			this.allLongDatePatterns = cultureData.LongDates(calendarId);
			this.allShortDatePatterns = cultureData.ShortDates(calendarId);
			this.allYearMonthPatterns = cultureData.YearMonths(calendarId);
		}

		/// <summary>Gets the default read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object that is culture-independent (invariant).</summary>
		/// <returns>A read-only object that is culture-independent (invariant).</returns>
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x000A7EAD File Offset: 0x000A60AD
		public static DateTimeFormatInfo InvariantInfo
		{
			get
			{
				if (DateTimeFormatInfo.s_invariantInfo == null)
				{
					DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
					dateTimeFormatInfo.Calendar.SetReadOnlyState(true);
					dateTimeFormatInfo._isReadOnly = true;
					DateTimeFormatInfo.s_invariantInfo = dateTimeFormatInfo;
				}
				return DateTimeFormatInfo.s_invariantInfo;
			}
		}

		/// <summary>Gets a read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object that formats values based on the current culture.</summary>
		/// <returns>A read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object based on the <see cref="T:System.Globalization.CultureInfo" /> object for the current thread.</returns>
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000A7EE0 File Offset: 0x000A60E0
		public static DateTimeFormatInfo CurrentInfo
		{
			get
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				if (!currentCulture._isInherited)
				{
					DateTimeFormatInfo dateTimeInfo = currentCulture.dateTimeInfo;
					if (dateTimeInfo != null)
					{
						return dateTimeInfo;
					}
				}
				return (DateTimeFormatInfo)currentCulture.GetFormat(typeof(DateTimeFormatInfo));
			}
		}

		/// <summary>Returns the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object associated with the specified <see cref="T:System.IFormatProvider" />.</summary>
		/// <param name="provider">The <see cref="T:System.IFormatProvider" /> that gets the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.-or- 
		///       <see langword="null" /> to get <see cref="P:System.Globalization.DateTimeFormatInfo.CurrentInfo" />. </param>
		/// <returns>A <see cref="T:System.Globalization.DateTimeFormatInfo" /> object associated with <see cref="T:System.IFormatProvider" />.</returns>
		// Token: 0x06002A14 RID: 10772 RVA: 0x000A7F20 File Offset: 0x000A6120
		public static DateTimeFormatInfo GetInstance(IFormatProvider provider)
		{
			if (provider == null)
			{
				return DateTimeFormatInfo.CurrentInfo;
			}
			CultureInfo cultureInfo = provider as CultureInfo;
			if (cultureInfo != null && !cultureInfo._isInherited)
			{
				return cultureInfo.DateTimeFormat;
			}
			DateTimeFormatInfo dateTimeFormatInfo = provider as DateTimeFormatInfo;
			if (dateTimeFormatInfo != null)
			{
				return dateTimeFormatInfo;
			}
			DateTimeFormatInfo dateTimeFormatInfo2 = provider.GetFormat(typeof(DateTimeFormatInfo)) as DateTimeFormatInfo;
			if (dateTimeFormatInfo2 == null)
			{
				return DateTimeFormatInfo.CurrentInfo;
			}
			return dateTimeFormatInfo2;
		}

		/// <summary>Returns an object of the specified type that provides a date and time  formatting service.</summary>
		/// <param name="formatType">The type of the required formatting service. </param>
		/// <returns>The current  object, if <paramref name="formatType" /> is the same as the type of the current <see cref="T:System.Globalization.DateTimeFormatInfo" />; otherwise, <see langword="null" />.</returns>
		// Token: 0x06002A15 RID: 10773 RVA: 0x000A7F7B File Offset: 0x000A617B
		public object GetFormat(Type formatType)
		{
			if (!(formatType == typeof(DateTimeFormatInfo)))
			{
				return null;
			}
			return this;
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <returns>A new <see cref="T:System.Globalization.DateTimeFormatInfo" /> object copied from the original <see cref="T:System.Globalization.DateTimeFormatInfo" />.</returns>
		// Token: 0x06002A16 RID: 10774 RVA: 0x000A7F92 File Offset: 0x000A6192
		public object Clone()
		{
			DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)base.MemberwiseClone();
			dateTimeFormatInfo.calendar = (Calendar)this.Calendar.Clone();
			dateTimeFormatInfo._isReadOnly = false;
			return dateTimeFormatInfo;
		}

		/// <summary>Gets or sets the string designator for hours that are "ante meridiem" (before noon).</summary>
		/// <returns>The string designator for hours that are ante meridiem. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "AM".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x000A7FBC File Offset: 0x000A61BC
		public string AMDesignator
		{
			get
			{
				if (this.amDesignator == null)
				{
					this.amDesignator = this._cultureData.SAM1159;
				}
				return this.amDesignator;
			}
		}

		/// <summary>Gets or sets the calendar to use for the current culture.</summary>
		/// <returns>The calendar to use for the current culture. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is a <see cref="T:System.Globalization.GregorianCalendar" /> object.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a <see cref="T:System.Globalization.Calendar" /> object that is not valid for the current culture. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x000A7FDD File Offset: 0x000A61DD
		// (set) Token: 0x06002A19 RID: 10777 RVA: 0x000A7FE8 File Offset: 0x000A61E8
		public Calendar Calendar
		{
			get
			{
				return this.calendar;
			}
			set
			{
				if (GlobalizationMode.Invariant)
				{
					throw new PlatformNotSupportedException();
				}
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Object cannot be null.");
				}
				if (value == this.calendar)
				{
					return;
				}
				for (int i = 0; i < this.OptionalCalendars.Length; i++)
				{
					if (this.OptionalCalendars[i] == (CalendarId)value.ID)
					{
						if (this.calendar != null)
						{
							this.m_eraNames = null;
							this.m_abbrevEraNames = null;
							this.m_abbrevEnglishEraNames = null;
							this.monthDayPattern = null;
							this.dayNames = null;
							this.abbreviatedDayNames = null;
							this.m_superShortDayNames = null;
							this.monthNames = null;
							this.abbreviatedMonthNames = null;
							this.genitiveMonthNames = null;
							this.m_genitiveAbbreviatedMonthNames = null;
							this.leapYearMonthNames = null;
							this.formatFlags = DateTimeFormatFlags.NotInitialized;
							this.allShortDatePatterns = null;
							this.allLongDatePatterns = null;
							this.allYearMonthPatterns = null;
							this.dateTimeOffsetPattern = null;
							this.longDatePattern = null;
							this.shortDatePattern = null;
							this.yearMonthPattern = null;
							this.fullDateTimePattern = null;
							this.generalShortTimePattern = null;
							this.generalLongTimePattern = null;
							this.dateSeparator = null;
							this.ClearTokenHashTable();
						}
						this.calendar = value;
						this.InitializeOverridableProperties(this._cultureData, this.calendar.ID);
						return;
					}
				}
				throw new ArgumentOutOfRangeException("value", "Not a valid calendar for the given culture.");
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000A8146 File Offset: 0x000A6346
		private CalendarId[] OptionalCalendars
		{
			get
			{
				if (this.optionalCalendars == null)
				{
					this.optionalCalendars = this._cultureData.GetCalendarIds();
				}
				return this.optionalCalendars;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000A8167 File Offset: 0x000A6367
		internal string[] EraNames
		{
			get
			{
				if (this.m_eraNames == null)
				{
					this.m_eraNames = this._cultureData.EraNames(this.Calendar.ID);
				}
				return this.m_eraNames;
			}
		}

		/// <summary>Returns the string containing the name of the specified era.</summary>
		/// <param name="era">The integer representing the era. </param>
		/// <returns>A string containing the name of the era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="era" /> does not represent a valid era in the calendar specified in the <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" /> property. </exception>
		// Token: 0x06002A1C RID: 10780 RVA: 0x000A8193 File Offset: 0x000A6393
		public string GetEraName(int era)
		{
			if (era == 0)
			{
				era = this.Calendar.CurrentEraValue;
			}
			if (--era < this.EraNames.Length && era >= 0)
			{
				return this.m_eraNames[era];
			}
			throw new ArgumentOutOfRangeException("era", "Era value was not valid.");
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000A81D1 File Offset: 0x000A63D1
		internal string[] AbbreviatedEraNames
		{
			get
			{
				if (this.m_abbrevEraNames == null)
				{
					this.m_abbrevEraNames = this._cultureData.AbbrevEraNames(this.Calendar.ID);
				}
				return this.m_abbrevEraNames;
			}
		}

		/// <summary>Returns the string containing the abbreviated name of the specified era, if an abbreviation exists.</summary>
		/// <param name="era">The integer representing the era. </param>
		/// <returns>A string containing the abbreviated name of the specified era, if an abbreviation exists.-or- A string containing the full name of the era, if an abbreviation does not exist.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="era" /> does not represent a valid era in the calendar specified in the <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" /> property. </exception>
		// Token: 0x06002A1E RID: 10782 RVA: 0x000A8200 File Offset: 0x000A6400
		public string GetAbbreviatedEraName(int era)
		{
			if (this.AbbreviatedEraNames.Length == 0)
			{
				return this.GetEraName(era);
			}
			if (era == 0)
			{
				era = this.Calendar.CurrentEraValue;
			}
			if (--era < this.m_abbrevEraNames.Length && era >= 0)
			{
				return this.m_abbrevEraNames[era];
			}
			throw new ArgumentOutOfRangeException("era", "Era value was not valid.");
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000A825A File Offset: 0x000A645A
		internal string[] AbbreviatedEnglishEraNames
		{
			get
			{
				if (this.m_abbrevEnglishEraNames == null)
				{
					this.m_abbrevEnglishEraNames = this._cultureData.AbbreviatedEnglishEraNames(this.Calendar.ID);
				}
				return this.m_abbrevEnglishEraNames;
			}
		}

		/// <summary>Gets or sets the string that separates the components of a date, that is, the year, month, and day.</summary>
		/// <returns>The string that separates the components of a date, that is, the year, month, and day. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "/".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000A8286 File Offset: 0x000A6486
		public string DateSeparator
		{
			get
			{
				if (this.dateSeparator == null)
				{
					this.dateSeparator = this._cultureData.DateSeparator(this.Calendar.ID);
				}
				return this.dateSeparator;
			}
		}

		/// <summary>Gets or sets the custom format string for a long date and long time value.</summary>
		/// <returns>The custom format string for a long date and long time value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x000A82B2 File Offset: 0x000A64B2
		public string FullDateTimePattern
		{
			get
			{
				if (this.fullDateTimePattern == null)
				{
					this.fullDateTimePattern = this.LongDatePattern + " " + this.LongTimePattern;
				}
				return this.fullDateTimePattern;
			}
		}

		/// <summary>Gets or sets the custom format string for a long date value.</summary>
		/// <returns>The custom format string for a long date value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000A82DE File Offset: 0x000A64DE
		public string LongDatePattern
		{
			get
			{
				if (this.longDatePattern == null)
				{
					this.longDatePattern = this.UnclonedLongDatePatterns[0];
				}
				return this.longDatePattern;
			}
		}

		/// <summary>Gets or sets the custom format string for a long time value.</summary>
		/// <returns>The format pattern for a long time value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x000A82FC File Offset: 0x000A64FC
		public string LongTimePattern
		{
			get
			{
				if (this.longTimePattern == null)
				{
					this.longTimePattern = this.UnclonedLongTimePatterns[0];
				}
				return this.longTimePattern;
			}
		}

		/// <summary>Gets or sets the custom format string for a month and day value.</summary>
		/// <returns>The custom format string for a month and day value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000A831A File Offset: 0x000A651A
		public string MonthDayPattern
		{
			get
			{
				if (this.monthDayPattern == null)
				{
					this.monthDayPattern = this._cultureData.MonthDay(this.Calendar.ID);
				}
				return this.monthDayPattern;
			}
		}

		/// <summary>Gets or sets the string designator for hours that are "post meridiem" (after noon).</summary>
		/// <returns>The string designator for hours that are "post meridiem" (after noon). The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "PM".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000A8346 File Offset: 0x000A6546
		public string PMDesignator
		{
			get
			{
				if (this.pmDesignator == null)
				{
					this.pmDesignator = this._cultureData.SPM2359;
				}
				return this.pmDesignator;
			}
		}

		/// <summary>Gets the custom format string for a time value that is based on the Internet Engineering Task Force (IETF) Request for Comments (RFC) 1123 specification.</summary>
		/// <returns>The custom format string for a time value that is based on the IETF RFC 1123 specification.</returns>
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000A8367 File Offset: 0x000A6567
		public string RFC1123Pattern
		{
			get
			{
				return "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";
			}
		}

		/// <summary>Gets or sets the custom format string for a short date value.</summary>
		/// <returns>The custom format string for a short date value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000A836E File Offset: 0x000A656E
		public string ShortDatePattern
		{
			get
			{
				if (this.shortDatePattern == null)
				{
					this.shortDatePattern = this.UnclonedShortDatePatterns[0];
				}
				return this.shortDatePattern;
			}
		}

		/// <summary>Gets or sets the custom format string for a short time value.</summary>
		/// <returns>The custom format string for a short time value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x000A838C File Offset: 0x000A658C
		public string ShortTimePattern
		{
			get
			{
				if (this.shortTimePattern == null)
				{
					this.shortTimePattern = this.UnclonedShortTimePatterns[0];
				}
				return this.shortTimePattern;
			}
		}

		/// <summary>Gets the custom format string for a sortable date and time value.</summary>
		/// <returns>The custom format string for a sortable date and time value.</returns>
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000A83AA File Offset: 0x000A65AA
		public string SortableDateTimePattern
		{
			get
			{
				return "yyyy'-'MM'-'dd'T'HH':'mm':'ss";
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x000A83B1 File Offset: 0x000A65B1
		internal string GeneralShortTimePattern
		{
			get
			{
				if (this.generalShortTimePattern == null)
				{
					this.generalShortTimePattern = this.ShortDatePattern + " " + this.ShortTimePattern;
				}
				return this.generalShortTimePattern;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x000A83DD File Offset: 0x000A65DD
		internal string GeneralLongTimePattern
		{
			get
			{
				if (this.generalLongTimePattern == null)
				{
					this.generalLongTimePattern = this.ShortDatePattern + " " + this.LongTimePattern;
				}
				return this.generalLongTimePattern;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x000A840C File Offset: 0x000A660C
		internal string DateTimeOffsetPattern
		{
			get
			{
				if (this.dateTimeOffsetPattern == null)
				{
					string str = this.ShortDatePattern + " " + this.LongTimePattern;
					bool flag = false;
					bool flag2 = false;
					char c = '\'';
					int num = 0;
					while (!flag && num < this.LongTimePattern.Length)
					{
						char c2 = this.LongTimePattern[num];
						if (c2 <= '%')
						{
							if (c2 == '"')
							{
								goto IL_6A;
							}
							if (c2 == '%')
							{
								goto IL_96;
							}
						}
						else
						{
							if (c2 == '\'')
							{
								goto IL_6A;
							}
							if (c2 == '\\')
							{
								goto IL_96;
							}
							if (c2 == 'z')
							{
								flag = !flag2;
							}
						}
						IL_9C:
						num++;
						continue;
						IL_6A:
						if (flag2 && c == this.LongTimePattern[num])
						{
							flag2 = false;
							goto IL_9C;
						}
						if (!flag2)
						{
							c = this.LongTimePattern[num];
							flag2 = true;
							goto IL_9C;
						}
						goto IL_9C;
						IL_96:
						num++;
						goto IL_9C;
					}
					if (!flag)
					{
						str += " zzz";
					}
					this.dateTimeOffsetPattern = str;
				}
				return this.dateTimeOffsetPattern;
			}
		}

		/// <summary>Gets or sets the string that separates the components of time, that is, the hour, minutes, and seconds.</summary>
		/// <returns>The string that separates the components of time. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is ":".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x000A84EC File Offset: 0x000A66EC
		public string TimeSeparator
		{
			get
			{
				if (this.timeSeparator == null)
				{
					this.timeSeparator = this._cultureData.TimeSeparator;
				}
				return this.timeSeparator;
			}
		}

		/// <summary>Gets the custom format string for a universal, sortable date and time string.</summary>
		/// <returns>The custom format string for a universal, sortable date and time string.</returns>
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x000A850D File Offset: 0x000A670D
		public string UniversalSortableDateTimePattern
		{
			get
			{
				return "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";
			}
		}

		/// <summary>Gets or sets the custom format string for a year and month value.</summary>
		/// <returns>The custom format string for a year and month value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000A8514 File Offset: 0x000A6714
		public string YearMonthPattern
		{
			get
			{
				if (this.yearMonthPattern == null)
				{
					this.yearMonthPattern = this.UnclonedYearMonthPatterns[0];
				}
				return this.yearMonthPattern;
			}
		}

		/// <summary>Gets or sets a one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific abbreviated names of the days of the week.</summary>
		/// <returns>A one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific abbreviated names of the days of the week. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", and "Sat".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 7. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x000A8532 File Offset: 0x000A6732
		public string[] AbbreviatedDayNames
		{
			get
			{
				return (string[])this.internalGetAbbreviatedDayOfWeekNames().Clone();
			}
		}

		/// <summary>Gets or sets a one-dimensional string array that contains the culture-specific full names of the days of the week.</summary>
		/// <returns>A one-dimensional string array that contains the culture-specific full names of the days of the week. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", and "Saturday".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 7. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000A8544 File Offset: 0x000A6744
		public string[] DayNames
		{
			get
			{
				return (string[])this.internalGetDayOfWeekNames().Clone();
			}
		}

		/// <summary>Gets or sets a one-dimensional string array that contains the culture-specific abbreviated names of the months.</summary>
		/// <returns>A one-dimensional string array with 13 elements that contains the culture-specific abbreviated names of the months. For 12-month calendars, the 13th element of the array is an empty string. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", and "".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 13. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002A32 RID: 10802 RVA: 0x000A8556 File Offset: 0x000A6756
		public string[] AbbreviatedMonthNames
		{
			get
			{
				return (string[])this.internalGetAbbreviatedMonthNames().Clone();
			}
		}

		/// <summary>Gets or sets a one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific full names of the months.</summary>
		/// <returns>A one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific full names of the months. In a 12-month calendar, the 13th element of the array is an empty string. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", and "".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 13. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002A33 RID: 10803 RVA: 0x000A8568 File Offset: 0x000A6768
		public string[] MonthNames
		{
			get
			{
				return (string[])this.internalGetMonthNames().Clone();
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x000A857A File Offset: 0x000A677A
		internal bool HasSpacesInMonthNames
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseSpacesInMonthNames) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x000A8587 File Offset: 0x000A6787
		internal bool HasSpacesInDayNames
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseSpacesInDayNames) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000A8598 File Offset: 0x000A6798
		internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			string[] array;
			if (style != MonthNameStyles.Genitive)
			{
				if (style != MonthNameStyles.LeapYear)
				{
					array = (abbreviated ? this.internalGetAbbreviatedMonthNames() : this.internalGetMonthNames());
				}
				else
				{
					array = this.internalGetLeapYearMonthNames();
				}
			}
			else
			{
				array = this.internalGetGenitiveMonthNames(abbreviated);
			}
			if (month < 1 || month > array.Length)
			{
				throw new ArgumentOutOfRangeException("month", SR.Format("Valid values are between {0} and {1}, inclusive.", 1, array.Length));
			}
			return array[month - 1];
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000A8608 File Offset: 0x000A6808
		private string[] internalGetGenitiveMonthNames(bool abbreviated)
		{
			if (abbreviated)
			{
				if (this.m_genitiveAbbreviatedMonthNames == null)
				{
					this.m_genitiveAbbreviatedMonthNames = this._cultureData.AbbreviatedGenitiveMonthNames(this.Calendar.ID);
				}
				return this.m_genitiveAbbreviatedMonthNames;
			}
			if (this.genitiveMonthNames == null)
			{
				this.genitiveMonthNames = this._cultureData.GenitiveMonthNames(this.Calendar.ID);
			}
			return this.genitiveMonthNames;
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000A866D File Offset: 0x000A686D
		internal string[] internalGetLeapYearMonthNames()
		{
			if (this.leapYearMonthNames == null)
			{
				this.leapYearMonthNames = this._cultureData.LeapYearMonthNames(this.Calendar.ID);
			}
			return this.leapYearMonthNames;
		}

		/// <summary>Returns the culture-specific abbreviated name of the specified day of the week based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <param name="dayofweek">A <see cref="T:System.DayOfWeek" /> value. </param>
		/// <returns>The culture-specific abbreviated name of the day of the week represented by <paramref name="dayofweek" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="dayofweek" /> is not a valid <see cref="T:System.DayOfWeek" /> value. </exception>
		// Token: 0x06002A39 RID: 10809 RVA: 0x000A8699 File Offset: 0x000A6899
		public string GetAbbreviatedDayName(DayOfWeek dayofweek)
		{
			if (dayofweek < DayOfWeek.Sunday || dayofweek > DayOfWeek.Saturday)
			{
				throw new ArgumentOutOfRangeException("dayofweek", SR.Format("Valid values are between {0} and {1}, inclusive.", DayOfWeek.Sunday, DayOfWeek.Saturday));
			}
			return this.internalGetAbbreviatedDayOfWeekNames()[(int)dayofweek];
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000A86CC File Offset: 0x000A68CC
		private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString)
		{
			string[] array = new string[patterns1.Length * patterns2.Length];
			int num = 0;
			for (int i = 0; i < patterns1.Length; i++)
			{
				for (int j = 0; j < patterns2.Length; j++)
				{
					array[num++] = patterns1[i] + connectString + patterns2[j];
				}
			}
			return array;
		}

		/// <summary>Returns all the patterns in which date and time values can be formatted using the specified standard format string.</summary>
		/// <param name="format">A standard format string. </param>
		/// <returns>An array containing the standard patterns in which date and time values can be formatted using the specified format string.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="format" /> is not a valid standard format string. </exception>
		// Token: 0x06002A3B RID: 10811 RVA: 0x000A8718 File Offset: 0x000A6918
		public string[] GetAllDateTimePatterns(char format)
		{
			if (format <= 'U')
			{
				switch (format)
				{
				case 'D':
					return this.AllLongDatePatterns;
				case 'E':
					goto IL_1AF;
				case 'F':
					break;
				case 'G':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllShortDatePatterns, this.AllLongTimePatterns, " ");
				default:
					switch (format)
					{
					case 'M':
						goto IL_13D;
					case 'N':
					case 'P':
					case 'Q':
					case 'S':
						goto IL_1AF;
					case 'O':
						goto IL_14F;
					case 'R':
						goto IL_160;
					case 'T':
						return this.AllLongTimePatterns;
					case 'U':
						break;
					default:
						goto IL_1AF;
					}
					break;
				}
				return DateTimeFormatInfo.GetCombinedPatterns(this.AllLongDatePatterns, this.AllLongTimePatterns, " ");
			}
			if (format != 'Y')
			{
				switch (format)
				{
				case 'd':
					return this.AllShortDatePatterns;
				case 'e':
					goto IL_1AF;
				case 'f':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllLongDatePatterns, this.AllShortTimePatterns, " ");
				case 'g':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllShortDatePatterns, this.AllShortTimePatterns, " ");
				default:
					switch (format)
					{
					case 'm':
						goto IL_13D;
					case 'n':
					case 'p':
					case 'q':
					case 'v':
					case 'w':
					case 'x':
						goto IL_1AF;
					case 'o':
						goto IL_14F;
					case 'r':
						goto IL_160;
					case 's':
						return new string[]
						{
							"yyyy'-'MM'-'dd'T'HH':'mm':'ss"
						};
					case 't':
						return this.AllShortTimePatterns;
					case 'u':
						return new string[]
						{
							this.UniversalSortableDateTimePattern
						};
					case 'y':
						break;
					default:
						goto IL_1AF;
					}
					break;
				}
			}
			return this.AllYearMonthPatterns;
			IL_13D:
			return new string[]
			{
				this.MonthDayPattern
			};
			IL_14F:
			return new string[]
			{
				"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"
			};
			IL_160:
			return new string[]
			{
				"ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"
			};
			IL_1AF:
			throw new ArgumentException(SR.Format("Format specifier '{0}' was invalid.", format), "format");
		}

		/// <summary>Returns the culture-specific full name of the specified day of the week based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <param name="dayofweek">A <see cref="T:System.DayOfWeek" /> value. </param>
		/// <returns>The culture-specific full name of the day of the week represented by <paramref name="dayofweek" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="dayofweek" /> is not a valid <see cref="T:System.DayOfWeek" /> value. </exception>
		// Token: 0x06002A3C RID: 10812 RVA: 0x000A88F0 File Offset: 0x000A6AF0
		public string GetDayName(DayOfWeek dayofweek)
		{
			if (dayofweek < DayOfWeek.Sunday || dayofweek > DayOfWeek.Saturday)
			{
				throw new ArgumentOutOfRangeException("dayofweek", SR.Format("Valid values are between {0} and {1}, inclusive.", DayOfWeek.Sunday, DayOfWeek.Saturday));
			}
			return this.internalGetDayOfWeekNames()[(int)dayofweek];
		}

		/// <summary>Returns the culture-specific abbreviated name of the specified month based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <param name="month">An integer from 1 through 13 representing the name of the month to retrieve. </param>
		/// <returns>The culture-specific abbreviated name of the month represented by <paramref name="month" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="month" /> is less than 1 or greater than 13. </exception>
		// Token: 0x06002A3D RID: 10813 RVA: 0x000A8923 File Offset: 0x000A6B23
		public string GetAbbreviatedMonthName(int month)
		{
			if (month < 1 || month > 13)
			{
				throw new ArgumentOutOfRangeException("month", SR.Format("Valid values are between {0} and {1}, inclusive.", 1, 13));
			}
			return this.internalGetAbbreviatedMonthNames()[month - 1];
		}

		/// <summary>Returns the culture-specific full name of the specified month based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <param name="month">An integer from 1 through 13 representing the name of the month to retrieve. </param>
		/// <returns>The culture-specific full name of the month represented by <paramref name="month" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="month" /> is less than 1 or greater than 13. </exception>
		// Token: 0x06002A3E RID: 10814 RVA: 0x000A895A File Offset: 0x000A6B5A
		public string GetMonthName(int month)
		{
			if (month < 1 || month > 13)
			{
				throw new ArgumentOutOfRangeException("month", SR.Format("Valid values are between {0} and {1}, inclusive.", 1, 13));
			}
			return this.internalGetMonthNames()[month - 1];
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000A8994 File Offset: 0x000A6B94
		private static string[] GetMergedPatterns(string[] patterns, string defaultPattern)
		{
			if (defaultPattern == patterns[0])
			{
				return (string[])patterns.Clone();
			}
			int num = 0;
			while (num < patterns.Length && !(defaultPattern == patterns[num]))
			{
				num++;
			}
			string[] array;
			if (num < patterns.Length)
			{
				array = (string[])patterns.Clone();
				array[num] = array[0];
			}
			else
			{
				array = new string[patterns.Length + 1];
				Array.Copy(patterns, 0, array, 1, patterns.Length);
			}
			array[0] = defaultPattern;
			return array;
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000A8A07 File Offset: 0x000A6C07
		private string[] AllYearMonthPatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedYearMonthPatterns, this.YearMonthPattern);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000A8A1A File Offset: 0x000A6C1A
		private string[] AllShortDatePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedShortDatePatterns, this.ShortDatePattern);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000A8A2D File Offset: 0x000A6C2D
		private string[] AllShortTimePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedShortTimePatterns, this.ShortTimePattern);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x000A8A40 File Offset: 0x000A6C40
		private string[] AllLongDatePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedLongDatePatterns, this.LongDatePattern);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000A8A53 File Offset: 0x000A6C53
		private string[] AllLongTimePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedLongTimePatterns, this.LongTimePattern);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x000A8A66 File Offset: 0x000A6C66
		private string[] UnclonedYearMonthPatterns
		{
			get
			{
				if (this.allYearMonthPatterns == null)
				{
					this.allYearMonthPatterns = this._cultureData.YearMonths(this.Calendar.ID);
				}
				return this.allYearMonthPatterns;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000A8A92 File Offset: 0x000A6C92
		private string[] UnclonedShortDatePatterns
		{
			get
			{
				if (this.allShortDatePatterns == null)
				{
					this.allShortDatePatterns = this._cultureData.ShortDates(this.Calendar.ID);
				}
				return this.allShortDatePatterns;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000A8ABE File Offset: 0x000A6CBE
		private string[] UnclonedLongDatePatterns
		{
			get
			{
				if (this.allLongDatePatterns == null)
				{
					this.allLongDatePatterns = this._cultureData.LongDates(this.Calendar.ID);
				}
				return this.allLongDatePatterns;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000A8AEA File Offset: 0x000A6CEA
		private string[] UnclonedShortTimePatterns
		{
			get
			{
				if (this.allShortTimePatterns == null)
				{
					this.allShortTimePatterns = this._cultureData.ShortTimes;
				}
				return this.allShortTimePatterns;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000A8B0B File Offset: 0x000A6D0B
		private string[] UnclonedLongTimePatterns
		{
			get
			{
				if (this.allLongTimePatterns == null)
				{
					this.allLongTimePatterns = this._cultureData.LongTimes;
				}
				return this.allLongTimePatterns;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x000A8B2C File Offset: 0x000A6D2C
		public bool IsReadOnly
		{
			get
			{
				return GlobalizationMode.Invariant || this._isReadOnly;
			}
		}

		/// <summary>Gets or sets a string array of month names associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <returns>A string array of month names.</returns>
		/// <exception cref="T:System.ArgumentException">In a set operation, the array is multidimensional or has a length that is not exactly 13.</exception>
		/// <exception cref="T:System.ArgumentNullException">In a set operation, the array or one of its elements is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000A8B3D File Offset: 0x000A6D3D
		public string[] MonthGenitiveNames
		{
			get
			{
				return (string[])this.internalGetGenitiveMonthNames(false).Clone();
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000A8B50 File Offset: 0x000A6D50
		internal string FullTimeSpanPositivePattern
		{
			get
			{
				if (this._fullTimeSpanPositivePattern == null)
				{
					CultureData cultureData;
					if (this._cultureData.UseUserOverride)
					{
						cultureData = CultureData.GetCultureData(this._cultureData.CultureName, false);
					}
					else
					{
						cultureData = this._cultureData;
					}
					string numberDecimalSeparator = new NumberFormatInfo(cultureData).NumberDecimalSeparator;
					this._fullTimeSpanPositivePattern = "d':'h':'mm':'ss'" + numberDecimalSeparator + "'FFFFFFF";
				}
				return this._fullTimeSpanPositivePattern;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000A8BB5 File Offset: 0x000A6DB5
		internal string FullTimeSpanNegativePattern
		{
			get
			{
				if (this._fullTimeSpanNegativePattern == null)
				{
					this._fullTimeSpanNegativePattern = "'-'" + this.FullTimeSpanPositivePattern;
				}
				return this._fullTimeSpanNegativePattern;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x000A8BDB File Offset: 0x000A6DDB
		internal CompareInfo CompareInfo
		{
			get
			{
				if (this._compareInfo == null)
				{
					this._compareInfo = CompareInfo.GetCompareInfo(this._cultureData.SCOMPAREINFO);
				}
				return this._compareInfo;
			}
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x000A8C04 File Offset: 0x000A6E04
		internal static void ValidateStyles(DateTimeStyles style, string parameterName)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) != DateTimeStyles.None)
			{
				throw new ArgumentException("An undefined DateTimeStyles value is being used.", parameterName);
			}
			if ((style & DateTimeStyles.AssumeLocal) != DateTimeStyles.None && (style & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
			{
				throw new ArgumentException("The DateTimeStyles values AssumeLocal and AssumeUniversal cannot be used together.", parameterName);
			}
			if ((style & DateTimeStyles.RoundtripKind) != DateTimeStyles.None && (style & (DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal)) != DateTimeStyles.None)
			{
				throw new ArgumentException("The DateTimeStyles value RoundtripKind cannot be used with the values AssumeLocal, AssumeUniversal or AdjustToUniversal.", parameterName);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000A8C59 File Offset: 0x000A6E59
		internal DateTimeFormatFlags FormatFlags
		{
			get
			{
				if (this.formatFlags == DateTimeFormatFlags.NotInitialized)
				{
					return this.InitializeFormatFlags();
				}
				return this.formatFlags;
			}
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x000A8C74 File Offset: 0x000A6E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DateTimeFormatFlags InitializeFormatFlags()
		{
			this.formatFlags = (DateTimeFormatFlags)(DateTimeFormatInfoScanner.GetFormatFlagGenitiveMonth(this.MonthNames, this.internalGetGenitiveMonthNames(false), this.AbbreviatedMonthNames, this.internalGetGenitiveMonthNames(true)) | DateTimeFormatInfoScanner.GetFormatFlagUseSpaceInMonthNames(this.MonthNames, this.internalGetGenitiveMonthNames(false), this.AbbreviatedMonthNames, this.internalGetGenitiveMonthNames(true)) | DateTimeFormatInfoScanner.GetFormatFlagUseSpaceInDayNames(this.DayNames, this.AbbreviatedDayNames) | DateTimeFormatInfoScanner.GetFormatFlagUseHebrewCalendar(this.Calendar.ID));
			return this.formatFlags;
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000A8CF0 File Offset: 0x000A6EF0
		internal bool HasForceTwoDigitYears
		{
			get
			{
				CalendarId calendarId = (CalendarId)this.calendar.ID;
				return calendarId - CalendarId.JAPAN <= 1;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000A8D13 File Offset: 0x000A6F13
		internal bool HasYearMonthAdjustment
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseHebrewRule) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000A8D20 File Offset: 0x000A6F20
		internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
		{
			if ((this.FormatFlags & DateTimeFormatFlags.UseHebrewRule) != DateTimeFormatFlags.None)
			{
				if (year < 1000)
				{
					year += 5000;
				}
				if (year < this.Calendar.GetYear(this.Calendar.MinSupportedDateTime) || year > this.Calendar.GetYear(this.Calendar.MaxSupportedDateTime))
				{
					return false;
				}
				if (parsedMonthName && !this.Calendar.IsLeapYear(year))
				{
					if (month >= 8)
					{
						month--;
					}
					else if (month == 7)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000A8DA8 File Offset: 0x000A6FA8
		internal static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			DateTimeFormatInfo dateTimeFormat = DateTimeFormatInfo.s_jajpDTFI;
			if (dateTimeFormat == null && !GlobalizationMode.Invariant)
			{
				dateTimeFormat = new CultureInfo("ja-JP", false).DateTimeFormat;
				dateTimeFormat.Calendar = JapaneseCalendar.GetDefaultInstance();
				DateTimeFormatInfo.s_jajpDTFI = dateTimeFormat;
			}
			return dateTimeFormat;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x000A8DEC File Offset: 0x000A6FEC
		internal static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			DateTimeFormatInfo dateTimeFormat = DateTimeFormatInfo.s_zhtwDTFI;
			if (dateTimeFormat == null && !GlobalizationMode.Invariant)
			{
				dateTimeFormat = new CultureInfo("zh-TW", false).DateTimeFormat;
				dateTimeFormat.Calendar = TaiwanCalendar.GetDefaultInstance();
				DateTimeFormatInfo.s_zhtwDTFI = dateTimeFormat;
			}
			return dateTimeFormat;
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000A8E30 File Offset: 0x000A7030
		private void ClearTokenHashTable()
		{
			this._dtfiTokenHash = null;
			this.formatFlags = DateTimeFormatFlags.NotInitialized;
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x000A8E40 File Offset: 0x000A7040
		internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable()
		{
			DateTimeFormatInfo.TokenHashValue[] array = this._dtfiTokenHash;
			if (array == null)
			{
				array = new DateTimeFormatInfo.TokenHashValue[199];
				if (!GlobalizationMode.Invariant)
				{
					this.LanguageName.Equals("ko");
				}
				string b = this.TimeSeparator.Trim();
				if ("," != b)
				{
					this.InsertHash(array, ",", TokenType.IgnorableSymbol, 0);
				}
				if ("." != b)
				{
					this.InsertHash(array, ".", TokenType.IgnorableSymbol, 0);
				}
				if (!GlobalizationMode.Invariant && "시" != b && "時" != b && "时" != b)
				{
					this.InsertHash(array, this.TimeSeparator, TokenType.SEP_Time, 0);
				}
				this.InsertHash(array, this.AMDesignator, (TokenType)1027, 0);
				this.InsertHash(array, this.PMDesignator, (TokenType)1284, 1);
				bool flag = false;
				if (!GlobalizationMode.Invariant)
				{
					this.PopulateSpecialTokenHashTable(array, ref flag);
				}
				if (!GlobalizationMode.Invariant && this.LanguageName.Equals("ky"))
				{
					this.InsertHash(array, "-", TokenType.IgnorableSymbol, 0);
				}
				else
				{
					this.InsertHash(array, "-", TokenType.SEP_DateOrOffset, 0);
				}
				if (!flag)
				{
					this.InsertHash(array, this.DateSeparator, TokenType.SEP_Date, 0);
				}
				this.AddMonthNames(array, null);
				for (int i = 1; i <= 13; i++)
				{
					this.InsertHash(array, this.GetAbbreviatedMonthName(i), TokenType.MonthToken, i);
				}
				if ((this.FormatFlags & DateTimeFormatFlags.UseGenitiveMonth) != DateTimeFormatFlags.None)
				{
					for (int j = 1; j <= 13; j++)
					{
						string str = this.internalGetMonthName(j, MonthNameStyles.Genitive, false);
						this.InsertHash(array, str, TokenType.MonthToken, j);
					}
				}
				if ((this.FormatFlags & DateTimeFormatFlags.UseLeapYearMonth) != DateTimeFormatFlags.None)
				{
					for (int k = 1; k <= 13; k++)
					{
						string str2 = this.internalGetMonthName(k, MonthNameStyles.LeapYear, false);
						this.InsertHash(array, str2, TokenType.MonthToken, k);
					}
				}
				for (int l = 0; l < 7; l++)
				{
					string str3 = this.GetDayName((DayOfWeek)l);
					this.InsertHash(array, str3, TokenType.DayOfWeekToken, l);
					str3 = this.GetAbbreviatedDayName((DayOfWeek)l);
					this.InsertHash(array, str3, TokenType.DayOfWeekToken, l);
				}
				int[] eras = this.calendar.Eras;
				for (int m = 1; m <= eras.Length; m++)
				{
					this.InsertHash(array, this.GetEraName(m), TokenType.EraToken, m);
					this.InsertHash(array, this.GetAbbreviatedEraName(m), TokenType.EraToken, m);
				}
				this.InsertHash(array, DateTimeFormatInfo.InvariantInfo.AMDesignator, (TokenType)1027, 0);
				this.InsertHash(array, DateTimeFormatInfo.InvariantInfo.PMDesignator, (TokenType)1284, 1);
				for (int n = 1; n <= 12; n++)
				{
					string str4 = DateTimeFormatInfo.InvariantInfo.GetMonthName(n);
					this.InsertHash(array, str4, TokenType.MonthToken, n);
					str4 = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(n);
					this.InsertHash(array, str4, TokenType.MonthToken, n);
				}
				for (int num = 0; num < 7; num++)
				{
					string str5 = DateTimeFormatInfo.InvariantInfo.GetDayName((DayOfWeek)num);
					this.InsertHash(array, str5, TokenType.DayOfWeekToken, num);
					str5 = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedDayName((DayOfWeek)num);
					this.InsertHash(array, str5, TokenType.DayOfWeekToken, num);
				}
				for (int num2 = 0; num2 < this.AbbreviatedEnglishEraNames.Length; num2++)
				{
					this.InsertHash(array, this.AbbreviatedEnglishEraNames[num2], TokenType.EraToken, num2 + 1);
				}
				this.InsertHash(array, "T", TokenType.SEP_LocalTimeMark, 0);
				this.InsertHash(array, "GMT", TokenType.TimeZoneToken, 0);
				this.InsertHash(array, "Z", TokenType.TimeZoneToken, 0);
				this.InsertHash(array, "/", TokenType.SEP_Date, 0);
				this.InsertHash(array, ":", TokenType.SEP_Time, 0);
				this._dtfiTokenHash = array;
			}
			return array;
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000A91E0 File Offset: 0x000A73E0
		private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol)
		{
			if (this.LanguageName.Equals("sq"))
			{
				this.InsertHash(temp, "." + this.AMDesignator, (TokenType)1027, 0);
				this.InsertHash(temp, "." + this.PMDesignator, (TokenType)1284, 1);
			}
			this.InsertHash(temp, "年", TokenType.SEP_YearSuff, 0);
			this.InsertHash(temp, "년", TokenType.SEP_YearSuff, 0);
			this.InsertHash(temp, "月", TokenType.SEP_MonthSuff, 0);
			this.InsertHash(temp, "월", TokenType.SEP_MonthSuff, 0);
			this.InsertHash(temp, "日", TokenType.SEP_DaySuff, 0);
			this.InsertHash(temp, "일", TokenType.SEP_DaySuff, 0);
			this.InsertHash(temp, "時", TokenType.SEP_HourSuff, 0);
			this.InsertHash(temp, "时", TokenType.SEP_HourSuff, 0);
			this.InsertHash(temp, "分", TokenType.SEP_MinuteSuff, 0);
			this.InsertHash(temp, "秒", TokenType.SEP_SecondSuff, 0);
			if (!AppContextSwitches.EnforceLegacyJapaneseDateParsing && this.Calendar.ID == 3)
			{
				this.InsertHash(temp, "元", TokenType.YearNumberToken, 1);
				this.InsertHash(temp, "(", TokenType.IgnorableSymbol, 0);
				this.InsertHash(temp, ")", TokenType.IgnorableSymbol, 0);
			}
			if (this.LanguageName.Equals("ko"))
			{
				this.InsertHash(temp, "시", TokenType.SEP_HourSuff, 0);
				this.InsertHash(temp, "분", TokenType.SEP_MinuteSuff, 0);
				this.InsertHash(temp, "초", TokenType.SEP_SecondSuff, 0);
			}
			string[] dateWordsOfDTFI = new DateTimeFormatInfoScanner().GetDateWordsOfDTFI(this);
			DateTimeFormatFlags dateTimeFormatFlags = this.FormatFlags;
			if (dateWordsOfDTFI != null)
			{
				for (int i = 0; i < dateWordsOfDTFI.Length; i++)
				{
					char c = dateWordsOfDTFI[i][0];
					if (c != '')
					{
						if (c != '')
						{
							this.InsertHash(temp, dateWordsOfDTFI[i], TokenType.DateWordToken, 0);
							if (this.LanguageName.Equals("eu"))
							{
								this.InsertHash(temp, "." + dateWordsOfDTFI[i], TokenType.DateWordToken, 0);
							}
						}
						else
						{
							string text = dateWordsOfDTFI[i].Substring(1);
							this.InsertHash(temp, text, TokenType.IgnorableSymbol, 0);
							if (this.DateSeparator.Trim(null).Equals(text))
							{
								useDateSepAsIgnorableSymbol = true;
							}
						}
					}
					else
					{
						string monthPostfix = dateWordsOfDTFI[i].Substring(1);
						this.AddMonthNames(temp, monthPostfix);
					}
				}
			}
			if (this.LanguageName.Equals("ja"))
			{
				for (int j = 0; j < 7; j++)
				{
					string str = "(" + this.GetAbbreviatedDayName((DayOfWeek)j) + ")";
					this.InsertHash(temp, str, TokenType.DayOfWeekToken, j);
				}
				if (!DateTimeFormatInfo.IsJapaneseCalendar(this.Calendar))
				{
					DateTimeFormatInfo japaneseCalendarDTFI = DateTimeFormatInfo.GetJapaneseCalendarDTFI();
					for (int k = 1; k <= japaneseCalendarDTFI.Calendar.Eras.Length; k++)
					{
						this.InsertHash(temp, japaneseCalendarDTFI.GetEraName(k), TokenType.JapaneseEraToken, k);
						this.InsertHash(temp, japaneseCalendarDTFI.GetAbbreviatedEraName(k), TokenType.JapaneseEraToken, k);
						this.InsertHash(temp, japaneseCalendarDTFI.AbbreviatedEnglishEraNames[k - 1], TokenType.JapaneseEraToken, k);
					}
					return;
				}
			}
			else if (this.CultureName.Equals("zh-TW"))
			{
				DateTimeFormatInfo taiwanCalendarDTFI = DateTimeFormatInfo.GetTaiwanCalendarDTFI();
				for (int l = 1; l <= taiwanCalendarDTFI.Calendar.Eras.Length; l++)
				{
					if (taiwanCalendarDTFI.GetEraName(l).Length > 0)
					{
						this.InsertHash(temp, taiwanCalendarDTFI.GetEraName(l), TokenType.TEraToken, l);
					}
				}
			}
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000A9555 File Offset: 0x000A7755
		private static bool IsJapaneseCalendar(Calendar calendar)
		{
			if (GlobalizationMode.Invariant)
			{
				throw new PlatformNotSupportedException();
			}
			return calendar.GetType() == typeof(JapaneseCalendar);
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x000A957C File Offset: 0x000A777C
		private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix)
		{
			for (int i = 1; i <= 13; i++)
			{
				string text = this.GetMonthName(i);
				if (text.Length > 0)
				{
					if (monthPostfix != null)
					{
						this.InsertHash(temp, text + monthPostfix, TokenType.MonthToken, i);
					}
					else
					{
						this.InsertHash(temp, text, TokenType.MonthToken, i);
					}
				}
				text = this.GetAbbreviatedMonthName(i);
				this.InsertHash(temp, text, TokenType.MonthToken, i);
			}
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000A95D8 File Offset: 0x000A77D8
		private unsafe static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
		{
			number = -1;
			badFormat = false;
			int index = str.Index;
			if (!HebrewNumber.IsDigit((char)(*str.Value[index])))
			{
				return false;
			}
			HebrewNumberParsingContext hebrewNumberParsingContext = new HebrewNumberParsingContext(0);
			HebrewNumberParsingState hebrewNumberParsingState;
			for (;;)
			{
				hebrewNumberParsingState = HebrewNumber.ParseByChar((char)(*str.Value[index++]), ref hebrewNumberParsingContext);
				if (hebrewNumberParsingState <= HebrewNumberParsingState.NotHebrewDigit)
				{
					break;
				}
				if (index >= str.Value.Length || hebrewNumberParsingState == HebrewNumberParsingState.FoundEndOfHebrewNumber)
				{
					goto IL_5C;
				}
			}
			return false;
			IL_5C:
			if (hebrewNumberParsingState != HebrewNumberParsingState.FoundEndOfHebrewNumber)
			{
				return false;
			}
			str.Advance(index - str.Index);
			number = hebrewNumberParsingContext.result;
			return true;
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000A965F File Offset: 0x000A785F
		private static bool IsHebrewChar(char ch)
		{
			return ch >= '֐' && ch <= '׿';
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000A9678 File Offset: 0x000A7878
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
		{
			return !AppContextSwitches.EnforceLegacyJapaneseDateParsing && this.Calendar.ID == 3 && (nextCh == "元"[0] || (tokenString == "元" && nextCh == "年"[0]));
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000A96C8 File Offset: 0x000A78C8
		internal unsafe bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
		{
			tokenType = TokenType.UnknownToken;
			tokenValue = 0;
			char c = str.m_current;
			bool flag = char.IsLetter(c);
			if (flag)
			{
				c = this.Culture.TextInfo.ToLower(c);
				bool flag2;
				if (!GlobalizationMode.Invariant && DateTimeFormatInfo.IsHebrewChar(c) && TokenMask == TokenType.RegularTokenMask && DateTimeFormatInfo.TryParseHebrewNumber(ref str, out flag2, out tokenValue))
				{
					if (flag2)
					{
						tokenType = TokenType.UnknownToken;
						return false;
					}
					tokenType = TokenType.HebrewNumber;
					return true;
				}
			}
			int num = (int)(c % 'Ç');
			int num2 = (int)('\u0001' + c % 'Å');
			int num3 = str.Length - str.Index;
			int num4 = 0;
			DateTimeFormatInfo.TokenHashValue[] array = this._dtfiTokenHash;
			if (array == null)
			{
				array = this.CreateTokenHashTable();
			}
			DateTimeFormatInfo.TokenHashValue tokenHashValue;
			int count;
			for (;;)
			{
				tokenHashValue = array[num];
				if (tokenHashValue == null)
				{
					return false;
				}
				if ((tokenHashValue.tokenType & TokenMask) > (TokenType)0 && tokenHashValue.tokenString.Length <= num3)
				{
					bool flag3 = true;
					if (flag)
					{
						int num5 = str.Index + tokenHashValue.tokenString.Length;
						if (num5 > str.Length)
						{
							flag3 = false;
						}
						else if (num5 < str.Length)
						{
							char c2 = (char)(*str.Value[num5]);
							flag3 = (!char.IsLetter(c2) || this.IsAllowedJapaneseTokenFollowedByNonSpaceLetter(tokenHashValue.tokenString, c2));
						}
					}
					if (flag3 && ((tokenHashValue.tokenString.Length == 1 && *str.Value[str.Index] == (ushort)tokenHashValue.tokenString[0]) || this.Culture.CompareInfo.Compare(str.Value.Slice(str.Index, tokenHashValue.tokenString.Length), tokenHashValue.tokenString, CompareOptions.IgnoreCase) == 0))
					{
						break;
					}
					if ((tokenHashValue.tokenType == TokenType.MonthToken && this.HasSpacesInMonthNames) || (tokenHashValue.tokenType == TokenType.DayOfWeekToken && this.HasSpacesInDayNames))
					{
						count = 0;
						if (str.MatchSpecifiedWords(tokenHashValue.tokenString, true, ref count))
						{
							goto Block_19;
						}
					}
				}
				num4++;
				num += num2;
				if (num >= 199)
				{
					num -= 199;
				}
				if (num4 >= 199)
				{
					return false;
				}
			}
			tokenType = (tokenHashValue.tokenType & TokenMask);
			tokenValue = tokenHashValue.tokenValue;
			str.Advance(tokenHashValue.tokenString.Length);
			return true;
			Block_19:
			tokenType = (tokenHashValue.tokenType & TokenMask);
			tokenValue = tokenHashValue.tokenValue;
			str.Advance(count);
			return true;
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x000A9910 File Offset: 0x000A7B10
		private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
			DateTimeFormatInfo.TokenHashValue tokenHashValue = hashTable[hashcode];
			hashTable[hashcode] = new DateTimeFormatInfo.TokenHashValue(str, tokenType, tokenValue);
			while (++pos < 199)
			{
				hashcode += hashProbe;
				if (hashcode >= 199)
				{
					hashcode -= 199;
				}
				DateTimeFormatInfo.TokenHashValue tokenHashValue2 = hashTable[hashcode];
				if (tokenHashValue2 == null || this.Culture.TextInfo.ToLower(tokenHashValue2.tokenString[0]) == ch)
				{
					hashTable[hashcode] = tokenHashValue;
					if (tokenHashValue2 == null)
					{
						return;
					}
					tokenHashValue = tokenHashValue2;
				}
			}
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000A998C File Offset: 0x000A7B8C
		private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue)
		{
			if (str == null || str.Length == 0)
			{
				return;
			}
			int num = 0;
			if (char.IsWhiteSpace(str[0]) || char.IsWhiteSpace(str[str.Length - 1]))
			{
				str = str.Trim(null);
				if (str.Length == 0)
				{
					return;
				}
			}
			char c = this.Culture.TextInfo.ToLower(str[0]);
			int num2 = (int)(c % 'Ç');
			int num3 = (int)('\u0001' + c % 'Å');
			DateTimeFormatInfo.TokenHashValue tokenHashValue;
			for (;;)
			{
				tokenHashValue = hashTable[num2];
				if (tokenHashValue == null)
				{
					break;
				}
				if (str.Length >= tokenHashValue.tokenString.Length && this.CompareStringIgnoreCaseOptimized(str, 0, tokenHashValue.tokenString.Length, tokenHashValue.tokenString, 0, tokenHashValue.tokenString.Length))
				{
					goto Block_6;
				}
				num++;
				num2 += num3;
				if (num2 >= 199)
				{
					num2 -= 199;
				}
				if (num >= 199)
				{
					return;
				}
			}
			hashTable[num2] = new DateTimeFormatInfo.TokenHashValue(str, tokenType, tokenValue);
			return;
			Block_6:
			if (str.Length > tokenHashValue.tokenString.Length)
			{
				this.InsertAtCurrentHashNode(hashTable, str, c, tokenType, tokenValue, num, num2, num3);
				return;
			}
			int tokenType2 = (int)tokenHashValue.tokenType;
			if (((tokenType2 & 255) == 0 && (tokenType & TokenType.RegularTokenMask) != (TokenType)0) || ((tokenType2 & 65280) == 0 && (tokenType & TokenType.SeparatorTokenMask) != (TokenType)0))
			{
				tokenHashValue.tokenType |= tokenType;
				if (tokenValue != 0)
				{
					tokenHashValue.tokenValue = tokenValue;
				}
			}
			return;
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000A9AEE File Offset: 0x000A7CEE
		private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			return (length1 == 1 && length2 == 1 && string1[offset1] == string2[offset2]) || this.Culture.CompareInfo.Compare(string1, offset1, length1, string2, offset2, length2, CompareOptions.IgnoreCase) == 0;
		}

		// Token: 0x040015ED RID: 5613
		private static volatile DateTimeFormatInfo s_invariantInfo;

		// Token: 0x040015EE RID: 5614
		[NonSerialized]
		private CultureData _cultureData;

		// Token: 0x040015EF RID: 5615
		private string _name;

		// Token: 0x040015F0 RID: 5616
		[NonSerialized]
		private string _langName;

		// Token: 0x040015F1 RID: 5617
		[NonSerialized]
		private CompareInfo _compareInfo;

		// Token: 0x040015F2 RID: 5618
		[NonSerialized]
		private CultureInfo _cultureInfo;

		// Token: 0x040015F3 RID: 5619
		private string amDesignator;

		// Token: 0x040015F4 RID: 5620
		private string pmDesignator;

		// Token: 0x040015F5 RID: 5621
		private string dateSeparator;

		// Token: 0x040015F6 RID: 5622
		private string generalShortTimePattern;

		// Token: 0x040015F7 RID: 5623
		private string generalLongTimePattern;

		// Token: 0x040015F8 RID: 5624
		private string timeSeparator;

		// Token: 0x040015F9 RID: 5625
		private string monthDayPattern;

		// Token: 0x040015FA RID: 5626
		private string dateTimeOffsetPattern;

		// Token: 0x040015FB RID: 5627
		private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";

		// Token: 0x040015FC RID: 5628
		private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

		// Token: 0x040015FD RID: 5629
		private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";

		// Token: 0x040015FE RID: 5630
		private Calendar calendar;

		// Token: 0x040015FF RID: 5631
		private int firstDayOfWeek = -1;

		// Token: 0x04001600 RID: 5632
		private int calendarWeekRule = -1;

		// Token: 0x04001601 RID: 5633
		private string fullDateTimePattern;

		// Token: 0x04001602 RID: 5634
		private string[] abbreviatedDayNames;

		// Token: 0x04001603 RID: 5635
		private string[] m_superShortDayNames;

		// Token: 0x04001604 RID: 5636
		private string[] dayNames;

		// Token: 0x04001605 RID: 5637
		private string[] abbreviatedMonthNames;

		// Token: 0x04001606 RID: 5638
		private string[] monthNames;

		// Token: 0x04001607 RID: 5639
		private string[] genitiveMonthNames;

		// Token: 0x04001608 RID: 5640
		private string[] m_genitiveAbbreviatedMonthNames;

		// Token: 0x04001609 RID: 5641
		private string[] leapYearMonthNames;

		// Token: 0x0400160A RID: 5642
		private string longDatePattern;

		// Token: 0x0400160B RID: 5643
		private string shortDatePattern;

		// Token: 0x0400160C RID: 5644
		private string yearMonthPattern;

		// Token: 0x0400160D RID: 5645
		private string longTimePattern;

		// Token: 0x0400160E RID: 5646
		private string shortTimePattern;

		// Token: 0x0400160F RID: 5647
		private string[] allYearMonthPatterns;

		// Token: 0x04001610 RID: 5648
		private string[] allShortDatePatterns;

		// Token: 0x04001611 RID: 5649
		private string[] allLongDatePatterns;

		// Token: 0x04001612 RID: 5650
		private string[] allShortTimePatterns;

		// Token: 0x04001613 RID: 5651
		private string[] allLongTimePatterns;

		// Token: 0x04001614 RID: 5652
		private string[] m_eraNames;

		// Token: 0x04001615 RID: 5653
		private string[] m_abbrevEraNames;

		// Token: 0x04001616 RID: 5654
		private string[] m_abbrevEnglishEraNames;

		// Token: 0x04001617 RID: 5655
		private CalendarId[] optionalCalendars;

		// Token: 0x04001618 RID: 5656
		private const int DEFAULT_ALL_DATETIMES_SIZE = 132;

		// Token: 0x04001619 RID: 5657
		internal bool _isReadOnly;

		// Token: 0x0400161A RID: 5658
		private DateTimeFormatFlags formatFlags = DateTimeFormatFlags.NotInitialized;

		// Token: 0x0400161B RID: 5659
		private static readonly char[] s_monthSpaces = new char[]
		{
			' ',
			'\u00a0'
		};

		// Token: 0x0400161C RID: 5660
		internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

		// Token: 0x0400161D RID: 5661
		internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";

		// Token: 0x0400161E RID: 5662
		private string _fullTimeSpanPositivePattern;

		// Token: 0x0400161F RID: 5663
		private string _fullTimeSpanNegativePattern;

		// Token: 0x04001620 RID: 5664
		internal const DateTimeStyles InvalidDateTimeStyles = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind);

		// Token: 0x04001621 RID: 5665
		[NonSerialized]
		private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash;

		// Token: 0x04001622 RID: 5666
		private const int TOKEN_HASH_SIZE = 199;

		// Token: 0x04001623 RID: 5667
		private const int SECOND_PRIME = 197;

		// Token: 0x04001624 RID: 5668
		private const string dateSeparatorOrTimeZoneOffset = "-";

		// Token: 0x04001625 RID: 5669
		private const string invariantDateSeparator = "/";

		// Token: 0x04001626 RID: 5670
		private const string invariantTimeSeparator = ":";

		// Token: 0x04001627 RID: 5671
		internal const string IgnorablePeriod = ".";

		// Token: 0x04001628 RID: 5672
		internal const string IgnorableComma = ",";

		// Token: 0x04001629 RID: 5673
		internal const string CJKYearSuff = "年";

		// Token: 0x0400162A RID: 5674
		internal const string CJKMonthSuff = "月";

		// Token: 0x0400162B RID: 5675
		internal const string CJKDaySuff = "日";

		// Token: 0x0400162C RID: 5676
		internal const string KoreanYearSuff = "년";

		// Token: 0x0400162D RID: 5677
		internal const string KoreanMonthSuff = "월";

		// Token: 0x0400162E RID: 5678
		internal const string KoreanDaySuff = "일";

		// Token: 0x0400162F RID: 5679
		internal const string KoreanHourSuff = "시";

		// Token: 0x04001630 RID: 5680
		internal const string KoreanMinuteSuff = "분";

		// Token: 0x04001631 RID: 5681
		internal const string KoreanSecondSuff = "초";

		// Token: 0x04001632 RID: 5682
		internal const string CJKHourSuff = "時";

		// Token: 0x04001633 RID: 5683
		internal const string ChineseHourSuff = "时";

		// Token: 0x04001634 RID: 5684
		internal const string CJKMinuteSuff = "分";

		// Token: 0x04001635 RID: 5685
		internal const string CJKSecondSuff = "秒";

		// Token: 0x04001636 RID: 5686
		internal const string JapaneseEraStart = "元";

		// Token: 0x04001637 RID: 5687
		internal const string LocalTimeMark = "T";

		// Token: 0x04001638 RID: 5688
		internal const string GMTName = "GMT";

		// Token: 0x04001639 RID: 5689
		internal const string ZuluName = "Z";

		// Token: 0x0400163A RID: 5690
		internal const string KoreanLangName = "ko";

		// Token: 0x0400163B RID: 5691
		internal const string JapaneseLangName = "ja";

		// Token: 0x0400163C RID: 5692
		internal const string EnglishLangName = "en";

		// Token: 0x0400163D RID: 5693
		private static volatile DateTimeFormatInfo s_jajpDTFI;

		// Token: 0x0400163E RID: 5694
		private static volatile DateTimeFormatInfo s_zhtwDTFI;

		// Token: 0x0200057E RID: 1406
		internal class TokenHashValue
		{
			// Token: 0x06002A64 RID: 10852 RVA: 0x000A9B44 File Offset: 0x000A7D44
			internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
			{
				this.tokenString = tokenString;
				this.tokenType = tokenType;
				this.tokenValue = tokenValue;
			}

			// Token: 0x0400163F RID: 5695
			internal string tokenString;

			// Token: 0x04001640 RID: 5696
			internal TokenType tokenType;

			// Token: 0x04001641 RID: 5697
			internal int tokenValue;
		}
	}
}
