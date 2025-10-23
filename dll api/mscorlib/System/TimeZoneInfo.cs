using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;

namespace System
{
	/// <summary>Represents any time zone in the world.</summary>
	// Token: 0x02000157 RID: 343
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[Serializable]
	public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
	{
		// Token: 0x06000D8C RID: 3468 RVA: 0x00038FAC File Offset: 0x000371AC
		internal static bool UtcOffsetOutOfRange(TimeSpan offset)
		{
			return offset.TotalHours < -14.0 || offset.TotalHours > 14.0;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00038FD4 File Offset: 0x000371D4
		private static TimeZoneInfo CreateLocal()
		{
			return TimeZoneInfo.AndroidTimeZones.Local;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal static void DumpTimeZoneDataToFile(string id, byte[] buffer)
		{
		}

		/// <summary>Gets the time difference between the current time zone's standard time and Coordinated Universal Time (UTC).</summary>
		/// <returns>An object that indicates the time difference between the current time zone's standard time and Coordinated Universal Time (UTC).</returns>
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00038FDB File Offset: 0x000371DB
		public TimeSpan BaseUtcOffset
		{
			get
			{
				return this.baseUtcOffset;
			}
		}

		/// <summary>Gets the general display name that represents the time zone.</summary>
		/// <returns>The time zone's general display name.</returns>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00038FE3 File Offset: 0x000371E3
		public string DisplayName
		{
			get
			{
				return this.displayName;
			}
		}

		/// <summary>Gets the time zone identifier.</summary>
		/// <returns>The time zone identifier.</returns>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00038FEB File Offset: 0x000371EB
		public string Id
		{
			get
			{
				return this.id;
			}
		}

		/// <summary>Gets a <see cref="T:System.TimeZoneInfo" /> object that represents the local time zone.</summary>
		/// <returns>An object that represents the local time zone.</returns>
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00038FF4 File Offset: 0x000371F4
		public static TimeZoneInfo Local
		{
			get
			{
				TimeZoneInfo timeZoneInfo = TimeZoneInfo.local;
				if (timeZoneInfo == null)
				{
					timeZoneInfo = TimeZoneInfo.CreateLocal();
					if (timeZoneInfo == null)
					{
						throw new TimeZoneNotFoundException();
					}
					if (Interlocked.CompareExchange<TimeZoneInfo>(ref TimeZoneInfo.local, timeZoneInfo, null) != null)
					{
						timeZoneInfo = TimeZoneInfo.local;
					}
				}
				return timeZoneInfo;
			}
		}

		/// <summary>Gets a value indicating whether the time zone has any daylight saving time rules.</summary>
		/// <returns>
		///     <see langword="true" /> if the time zone supports daylight saving time; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0003902E File Offset: 0x0003722E
		public bool SupportsDaylightSavingTime
		{
			get
			{
				return this.supportsDaylightSavingTime;
			}
		}

		/// <summary>Gets a <see cref="T:System.TimeZoneInfo" /> object that represents the Coordinated Universal Time (UTC) zone.</summary>
		/// <returns>An object that represents the Coordinated Universal Time (UTC) zone.</returns>
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00039036 File Offset: 0x00037236
		public static TimeZoneInfo Utc
		{
			get
			{
				if (TimeZoneInfo.utc == null)
				{
					TimeZoneInfo.utc = TimeZoneInfo.CreateCustomTimeZone("UTC", new TimeSpan(0L), "UTC", "UTC");
				}
				return TimeZoneInfo.utc;
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00039064 File Offset: 0x00037264
		private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = DateTimeKind.Unspecified)
		{
			long num = date.Ticks + ticks;
			if (num < DateTime.MinValue.Ticks)
			{
				result = DateTime.SpecifyKind(DateTime.MinValue, kind);
				return false;
			}
			if (num > DateTime.MaxValue.Ticks)
			{
				result = DateTime.SpecifyKind(DateTime.MaxValue, kind);
				return false;
			}
			result = new DateTime(num, kind);
			return true;
		}

		/// <summary>Clears cached time zone data.</summary>
		// Token: 0x06000D96 RID: 3478 RVA: 0x000390C9 File Offset: 0x000372C9
		public static void ClearCachedData()
		{
			TimeZoneInfo.local = null;
			TimeZoneInfo.utc = null;
			TimeZoneInfo.systemTimeZones = null;
		}

		/// <summary>Converts a time from one time zone to another.</summary>
		/// <param name="dateTime">The date and time to convert.</param>
		/// <param name="sourceTimeZone">The time zone of <paramref name="dateTime" />.</param>
		/// <param name="destinationTimeZone">The time zone to convert <paramref name="dateTime" /> to.</param>
		/// <returns>The date and time in the destination time zone that corresponds to the <paramref name="dateTime" /> parameter in the source time zone.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateTime" /> parameter is <see cref="F:System.DateTimeKind.Local" />, but the <paramref name="sourceTimeZone" /> parameter does not equal <see cref="F:System.DateTimeKind.Local" />. For more information, see the Remarks section. -or-The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateTime" /> parameter is <see cref="F:System.DateTimeKind.Utc" />, but the <paramref name="sourceTimeZone" /> parameter does not equal <see cref="P:System.TimeZoneInfo.Utc" />.-or-The <paramref name="dateTime" /> parameter is an invalid time (that is, it represents a time that does not exist because of a time zone's adjustment rules).</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="sourceTimeZone" /> parameter is <see langword="null" />.-or-The <paramref name="destinationTimeZone" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000D97 RID: 3479 RVA: 0x000390E0 File Offset: 0x000372E0
		public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone)
		{
			if (sourceTimeZone == null)
			{
				throw new ArgumentNullException("sourceTimeZone");
			}
			if (destinationTimeZone == null)
			{
				throw new ArgumentNullException("destinationTimeZone");
			}
			if (dateTime.Kind == DateTimeKind.Local && sourceTimeZone != TimeZoneInfo.Local)
			{
				throw new ArgumentException("Kind property of dateTime is Local but the sourceTimeZone does not equal TimeZoneInfo.Local");
			}
			if (dateTime.Kind == DateTimeKind.Utc && sourceTimeZone != TimeZoneInfo.Utc)
			{
				throw new ArgumentException("Kind property of dateTime is Utc but the sourceTimeZone does not equal TimeZoneInfo.Utc");
			}
			if (sourceTimeZone.IsInvalidTime(dateTime))
			{
				throw new ArgumentException("dateTime parameter is an invalid time");
			}
			if (dateTime.Kind == DateTimeKind.Local && sourceTimeZone == TimeZoneInfo.Local && destinationTimeZone == TimeZoneInfo.Local)
			{
				return dateTime;
			}
			DateTime dateTime2 = TimeZoneInfo.ConvertTimeToUtc(dateTime, sourceTimeZone);
			if (destinationTimeZone != TimeZoneInfo.Utc)
			{
				dateTime2 = TimeZoneInfo.ConvertTimeFromUtc(dateTime2, destinationTimeZone);
				if (dateTime.Kind == DateTimeKind.Unspecified)
				{
					return DateTime.SpecifyKind(dateTime2, DateTimeKind.Unspecified);
				}
			}
			return dateTime2;
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x000391A0 File Offset: 0x000373A0
		private DateTime ConvertTimeFromUtc(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Local)
			{
				throw new ArgumentException("Kind property of dateTime is Local");
			}
			if (this == TimeZoneInfo.Utc)
			{
				return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
			}
			TimeSpan utcOffset = this.GetUtcOffset(dateTime);
			DateTimeKind kind = (this == TimeZoneInfo.Local) ? DateTimeKind.Local : DateTimeKind.Unspecified;
			DateTime result;
			if (!TimeZoneInfo.TryAddTicks(dateTime, utcOffset.Ticks, out result, kind))
			{
				return DateTime.SpecifyKind(DateTime.MaxValue, kind);
			}
			return result;
		}

		/// <summary>Converts a Coordinated Universal Time (UTC) to the time in a specified time zone.</summary>
		/// <param name="dateTime">The Coordinated Universal Time (UTC).</param>
		/// <param name="destinationTimeZone">The time zone to convert <paramref name="dateTime" /> to.</param>
		/// <returns>The date and time in the destination time zone. Its <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Utc" /> if <paramref name="destinationTimeZone" /> is <see cref="P:System.TimeZoneInfo.Utc" />; otherwise, its <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Unspecified" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of <paramref name="dateTime" /> is <see cref="F:System.DateTimeKind.Local" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destinationTimeZone" /> is <see langword="null" />.</exception>
		// Token: 0x06000D99 RID: 3481 RVA: 0x00039206 File Offset: 0x00037406
		public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone)
		{
			if (destinationTimeZone == null)
			{
				throw new ArgumentNullException("destinationTimeZone");
			}
			return destinationTimeZone.ConvertTimeFromUtc(dateTime);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0003921D File Offset: 0x0003741D
		internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			return TimeZoneInfo.ConvertTimeToUtc(dateTime, TimeZoneInfo.Local, flags);
		}

		/// <summary>Converts the time in a specified time zone to Coordinated Universal Time (UTC).</summary>
		/// <param name="dateTime">The date and time to convert.</param>
		/// <param name="sourceTimeZone">The time zone of <paramref name="dateTime" />.</param>
		/// <returns>The Coordinated Universal Time (UTC) that corresponds to the <paramref name="dateTime" /> parameter. The <see cref="T:System.DateTime" /> object's <see cref="P:System.DateTime.Kind" /> property is always set to <see cref="F:System.DateTimeKind.Utc" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="dateTime" />
		///         <see langword=".Kind" /> is <see cref="F:System.DateTimeKind.Utc" /> and <paramref name="sourceTimeZone" /> does not equal <see cref="P:System.TimeZoneInfo.Utc" />.-or-
		///         <paramref name="dateTime" />
		///         <see langword=".Kind" /> is <see cref="F:System.DateTimeKind.Local" /> and <paramref name="sourceTimeZone" /> does not equal <see cref="P:System.TimeZoneInfo.Local" />.-or-
		///         <paramref name="sourceTimeZone" />
		///         <see langword=".IsInvalidDateTime(" />
		///         <paramref name="dateTime" />
		///         <see langword=")" /> returns <see langword="true" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sourceTimeZone" /> is <see langword="null" />.</exception>
		// Token: 0x06000D9B RID: 3483 RVA: 0x0003922B File Offset: 0x0003742B
		public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone)
		{
			return TimeZoneInfo.ConvertTimeToUtc(dateTime, sourceTimeZone, TimeZoneInfoOptions.None);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00039238 File Offset: 0x00037438
		private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags)
		{
			if ((flags & TimeZoneInfoOptions.NoThrowOnInvalidTime) == (TimeZoneInfoOptions)0)
			{
				if (sourceTimeZone == null)
				{
					throw new ArgumentNullException("sourceTimeZone");
				}
				if (dateTime.Kind == DateTimeKind.Utc && sourceTimeZone != TimeZoneInfo.Utc)
				{
					throw new ArgumentException("Kind property of dateTime is Utc but the sourceTimeZone does not equal TimeZoneInfo.Utc");
				}
				if (dateTime.Kind == DateTimeKind.Local && sourceTimeZone != TimeZoneInfo.Local)
				{
					throw new ArgumentException("Kind property of dateTime is Local but the sourceTimeZone does not equal TimeZoneInfo.Local");
				}
				if (sourceTimeZone.IsInvalidTime(dateTime))
				{
					throw new ArgumentException("dateTime parameter is an invalid time");
				}
			}
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				return dateTime;
			}
			bool flag;
			TimeSpan utcOffset = sourceTimeZone.GetUtcOffset(dateTime, out flag, false);
			DateTime result;
			TimeZoneInfo.TryAddTicks(dateTime, -utcOffset.Ticks, out result, DateTimeKind.Utc);
			return result;
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x000392D0 File Offset: 0x000374D0
		internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
		{
			bool flag;
			return TimeZoneInfo.GetUtcOffsetFromUtc(time, TimeZoneInfo.Local, out flag, out isAmbiguousLocalDst);
		}

		/// <summary>Creates a custom time zone with a specified identifier, an offset from Coordinated Universal Time (UTC), a display name, and a standard time display name.</summary>
		/// <param name="id">The time zone's identifier.</param>
		/// <param name="baseUtcOffset">An object that represents the time difference between this time zone and Coordinated Universal Time (UTC).</param>
		/// <param name="displayName">The display name of the new time zone.   </param>
		/// <param name="standardDisplayName">The name of the new time zone's standard time.</param>
		/// <returns>The new time zone.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="id" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="id" /> parameter is an empty string ("").-or-The <paramref name="baseUtcOffset" /> parameter does not represent a whole number of minutes.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="baseUtcOffset" /> parameter is greater than 14 hours or less than -14 hours.</exception>
		// Token: 0x06000D9E RID: 3486 RVA: 0x000392EB File Offset: 0x000374EB
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
		{
			return TimeZoneInfo.CreateCustomTimeZone(id, baseUtcOffset, displayName, standardDisplayName, null, null, true);
		}

		/// <summary>Creates a custom time zone with a specified identifier, an offset from Coordinated Universal Time (UTC), a display name, a standard time name, a daylight saving time name, and daylight saving time rules.</summary>
		/// <param name="id">The time zone's identifier.</param>
		/// <param name="baseUtcOffset">An object that represents the time difference between this time zone and Coordinated Universal Time (UTC).</param>
		/// <param name="displayName">The display name of the new time zone.   </param>
		/// <param name="standardDisplayName">The new time zone's standard time name.</param>
		/// <param name="daylightDisplayName">The daylight saving time name of the new time zone.   </param>
		/// <param name="adjustmentRules">An array that augments the base UTC offset for a particular period. </param>
		/// <returns>A <see cref="T:System.TimeZoneInfo" /> object that represents the new time zone.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="id" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="id" /> parameter is an empty string ("").-or-The <paramref name="baseUtcOffset" /> parameter does not represent a whole number of minutes.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="baseUtcOffset" /> parameter is greater than 14 hours or less than -14 hours.</exception>
		/// <exception cref="T:System.InvalidTimeZoneException">The adjustment rules specified in the <paramref name="adjustmentRules" /> parameter overlap.-or-The adjustment rules specified in the <paramref name="adjustmentRules" /> parameter are not in chronological order.-or-One or more elements in <paramref name="adjustmentRules" /> are <see langword="null" />.-or-A date can have multiple adjustment rules applied to it.-or-The sum of the <paramref name="baseUtcOffset" /> parameter and the <see cref="P:System.TimeZoneInfo.AdjustmentRule.DaylightDelta" /> value of one or more objects in the <paramref name="adjustmentRules" /> array is greater than 14 hours or less than -14 hours.</exception>
		// Token: 0x06000D9F RID: 3487 RVA: 0x000392F9 File Offset: 0x000374F9
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules)
		{
			return TimeZoneInfo.CreateCustomTimeZone(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName, adjustmentRules, false);
		}

		/// <summary>Creates a custom time zone with a specified identifier, an offset from Coordinated Universal Time (UTC), a display name, a standard time name, a daylight saving time name, daylight saving time rules, and a value that indicates whether the returned object reflects daylight saving time information.</summary>
		/// <param name="id">The time zone's identifier.</param>
		/// <param name="baseUtcOffset">A <see cref="T:System.TimeSpan" /> object that represents the time difference between this time zone and Coordinated Universal Time (UTC).</param>
		/// <param name="displayName">The display name of the new time zone.   </param>
		/// <param name="standardDisplayName">The standard time name of the new time zone.</param>
		/// <param name="daylightDisplayName">The daylight saving time name of the new time zone.   </param>
		/// <param name="adjustmentRules">An array of <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> objects that augment the base UTC offset for a particular period.</param>
		/// <param name="disableDaylightSavingTime">
		///       <see langword="true" /> to discard any daylight saving time-related information present in <paramref name="adjustmentRules" /> with the new object; otherwise, <see langword="false" />.</param>
		/// <returns>The new time zone. If the <paramref name="disableDaylightSavingTime" /> parameter is <see langword="true" />, the returned object has no daylight saving time data.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="id" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="id" /> parameter is an empty string ("").-or-The <paramref name="baseUtcOffset" /> parameter does not represent a whole number of minutes.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="baseUtcOffset" /> parameter is greater than 14 hours or less than -14 hours.</exception>
		/// <exception cref="T:System.InvalidTimeZoneException">The adjustment rules specified in the <paramref name="adjustmentRules" /> parameter overlap.-or-The adjustment rules specified in the <paramref name="adjustmentRules" /> parameter are not in chronological order.-or-One or more elements in <paramref name="adjustmentRules" /> are <see langword="null" />.-or-A date can have multiple adjustment rules applied to it.-or-The sum of the <paramref name="baseUtcOffset" /> parameter and the <see cref="P:System.TimeZoneInfo.AdjustmentRule.DaylightDelta" /> value of one or more objects in the <paramref name="adjustmentRules" /> array is greater than 14 hours or less than -14 hours.</exception>
		// Token: 0x06000DA0 RID: 3488 RVA: 0x00039309 File Offset: 0x00037509
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
		{
			return new TimeZoneInfo(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName, adjustmentRules, disableDaylightSavingTime);
		}

		/// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo" /> object and another object are equal.</summary>
		/// <param name="obj">A second object to compare with the current object.  </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.TimeZoneInfo" /> object that is equal to the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000DA1 RID: 3489 RVA: 0x0003931A File Offset: 0x0003751A
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TimeZoneInfo);
		}

		/// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo" /> object and another <see cref="T:System.TimeZoneInfo" /> object are equal.</summary>
		/// <param name="other">A second object to compare with the current object.  </param>
		/// <returns>
		///     <see langword="true" /> if the two <see cref="T:System.TimeZoneInfo" /> objects are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000DA2 RID: 3490 RVA: 0x00039328 File Offset: 0x00037528
		public bool Equals(TimeZoneInfo other)
		{
			return other != null && other.Id == this.Id && this.HasSameRules(other);
		}

		/// <summary>Retrieves an array of <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> objects that apply to the current <see cref="T:System.TimeZoneInfo" /> object.</summary>
		/// <returns>An array of objects for this time zone.</returns>
		/// <exception cref="T:System.OutOfMemoryException">The system does not have enough memory to make an in-memory copy of the adjustment rules.</exception>
		// Token: 0x06000DA3 RID: 3491 RVA: 0x0003934B File Offset: 0x0003754B
		public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules()
		{
			if (!this.supportsDaylightSavingTime || this.adjustmentRules == null)
			{
				return new TimeZoneInfo.AdjustmentRule[0];
			}
			return (TimeZoneInfo.AdjustmentRule[])this.adjustmentRules.Clone();
		}

		/// <summary>Serves as a hash function for hashing algorithms and data structures such as hash tables.</summary>
		/// <returns>A 32-bit signed integer that serves as the hash code for this <see cref="T:System.TimeZoneInfo" /> object.</returns>
		// Token: 0x06000DA4 RID: 3492 RVA: 0x00039374 File Offset: 0x00037574
		public override int GetHashCode()
		{
			int num = this.Id.GetHashCode();
			foreach (TimeZoneInfo.AdjustmentRule adjustmentRule in this.GetAdjustmentRules())
			{
				num ^= adjustmentRule.GetHashCode();
			}
			return num;
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the current <see cref="T:System.TimeZoneInfo" /> object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data.</param>
		/// <param name="context">The destination for this serialization (see <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000DA5 RID: 3493 RVA: 0x000393B0 File Offset: 0x000375B0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("Id", this.id);
			info.AddValue("DisplayName", this.displayName);
			info.AddValue("StandardName", this.standardDisplayName);
			info.AddValue("DaylightName", this.daylightDisplayName);
			info.AddValue("BaseUtcOffset", this.baseUtcOffset);
			info.AddValue("AdjustmentRules", this.adjustmentRules);
			info.AddValue("SupportsDaylightSavingTime", this.SupportsDaylightSavingTime);
		}

		/// <summary>Calculates the offset or difference between the time in this time zone and Coordinated Universal Time (UTC) for a particular date and time.</summary>
		/// <param name="dateTime">The date and time to determine the offset for.   </param>
		/// <returns>An object that indicates the time difference between the two time zones.</returns>
		// Token: 0x06000DA6 RID: 3494 RVA: 0x00039448 File Offset: 0x00037648
		public TimeSpan GetUtcOffset(DateTime dateTime)
		{
			bool flag;
			return this.GetUtcOffset(dateTime, out flag, false);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00039460 File Offset: 0x00037660
		private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST, bool forOffset = false)
		{
			isDST = false;
			TimeZoneInfo timeZoneInfo = this;
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				timeZoneInfo = TimeZoneInfo.Utc;
			}
			if (dateTime.Kind == DateTimeKind.Local)
			{
				timeZoneInfo = TimeZoneInfo.Local;
			}
			bool flag;
			TimeSpan utcOffsetHelper = TimeZoneInfo.GetUtcOffsetHelper(dateTime, timeZoneInfo, out flag, forOffset);
			if (timeZoneInfo == this)
			{
				isDST = flag;
				return utcOffsetHelper;
			}
			DateTime dateTime2;
			if (!TimeZoneInfo.TryAddTicks(dateTime, -utcOffsetHelper.Ticks, out dateTime2, DateTimeKind.Utc))
			{
				return this.BaseUtcOffset;
			}
			return TimeZoneInfo.GetUtcOffsetHelper(dateTime2, this, out isDST, forOffset);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000394CC File Offset: 0x000376CC
		private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST, bool forOffset = false)
		{
			if (dateTime.Kind == DateTimeKind.Local && tz != TimeZoneInfo.Local)
			{
				throw new Exception();
			}
			isDST = false;
			if (tz == TimeZoneInfo.Utc)
			{
				return TimeSpan.Zero;
			}
			TimeSpan result;
			if (tz.TryGetTransitionOffset(dateTime, out result, out isDST, forOffset))
			{
				return result;
			}
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				TimeZoneInfo.AdjustmentRule applicableRule = tz.GetApplicableRule(dateTime);
				if (applicableRule != null && tz.IsInDST(applicableRule, dateTime))
				{
					isDST = true;
					return tz.BaseUtcOffset + applicableRule.DaylightDelta;
				}
				return tz.BaseUtcOffset;
			}
			else
			{
				DateTime dateTime2;
				if (!TimeZoneInfo.TryAddTicks(dateTime, -tz.BaseUtcOffset.Ticks, out dateTime2, DateTimeKind.Utc))
				{
					return tz.BaseUtcOffset;
				}
				TimeZoneInfo.AdjustmentRule applicableRule2 = tz.GetApplicableRule(dateTime2);
				DateTime minValue = DateTime.MinValue;
				if (applicableRule2 != null && !TimeZoneInfo.TryAddTicks(dateTime2, -applicableRule2.DaylightDelta.Ticks, out minValue, DateTimeKind.Utc))
				{
					return tz.BaseUtcOffset;
				}
				if (applicableRule2 == null || !tz.IsInDST(applicableRule2, dateTime))
				{
					return tz.BaseUtcOffset;
				}
				if (forOffset)
				{
					isDST = true;
				}
				if (tz.IsInDST(applicableRule2, minValue))
				{
					isDST = true;
					return tz.BaseUtcOffset + applicableRule2.DaylightDelta;
				}
				return tz.BaseUtcOffset;
			}
		}

		/// <summary>Indicates whether the current object and another <see cref="T:System.TimeZoneInfo" /> object have the same adjustment rules.</summary>
		/// <param name="other">A second object to compare with the current <see cref="T:System.TimeZoneInfo" /> object.   </param>
		/// <returns>
		///     <see langword="true" /> if the two time zones have identical adjustment rules and an identical base offset; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="other" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000DA9 RID: 3497 RVA: 0x000395E4 File Offset: 0x000377E4
		public bool HasSameRules(TimeZoneInfo other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			if (this.adjustmentRules == null != (other.adjustmentRules == null))
			{
				return false;
			}
			if (this.adjustmentRules == null)
			{
				return true;
			}
			if (this.BaseUtcOffset != other.BaseUtcOffset)
			{
				return false;
			}
			if (this.adjustmentRules.Length != other.adjustmentRules.Length)
			{
				return false;
			}
			for (int i = 0; i < this.adjustmentRules.Length; i++)
			{
				if (!this.adjustmentRules[i].Equals(other.adjustmentRules[i]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Determines whether a particular date and time in a particular time zone is ambiguous and can be mapped to two or more Coordinated Universal Time (UTC) times.</summary>
		/// <param name="dateTime">A date and time value.   </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="dateTime" /> parameter is ambiguous; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateTime" /> value is <see cref="F:System.DateTimeKind.Local" /> and <paramref name="dateTime" /> is an invalid time.</exception>
		// Token: 0x06000DAA RID: 3498 RVA: 0x00039678 File Offset: 0x00037878
		public bool IsAmbiguousTime(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Local && this.IsInvalidTime(dateTime))
			{
				throw new ArgumentException("Kind is Local and time is Invalid");
			}
			if (this == TimeZoneInfo.Utc)
			{
				return false;
			}
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				dateTime = this.ConvertTimeFromUtc(dateTime);
			}
			if (dateTime.Kind == DateTimeKind.Local && this != TimeZoneInfo.Local)
			{
				dateTime = TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Local, this);
			}
			TimeZoneInfo.AdjustmentRule applicableRule = this.GetApplicableRule(dateTime);
			if (applicableRule != null)
			{
				DateTime dateTime2 = TimeZoneInfo.TransitionPoint(applicableRule.DaylightTransitionEnd, dateTime.Year);
				if (dateTime > dateTime2 - applicableRule.DaylightDelta && dateTime <= dateTime2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0003971E File Offset: 0x0003791E
		private bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime)
		{
			return this.IsInDSTForYear(rule, dateTime, dateTime.Year) || (dateTime.Year > 1 && this.IsInDSTForYear(rule, dateTime, dateTime.Year - 1));
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00039750 File Offset: 0x00037950
		private bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year)
		{
			DateTime dateTime2 = TimeZoneInfo.TransitionPoint(rule.DaylightTransitionStart, year);
			DateTime dateTime3 = TimeZoneInfo.TransitionPoint(rule.DaylightTransitionEnd, year + ((rule.DaylightTransitionStart.Month < rule.DaylightTransitionEnd.Month) ? 0 : 1));
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				dateTime2 -= this.BaseUtcOffset;
				dateTime3 -= this.BaseUtcOffset;
			}
			dateTime3 -= rule.DaylightDelta;
			return dateTime >= dateTime2 && dateTime < dateTime3;
		}

		/// <summary>Indicates whether a particular date and time is invalid.</summary>
		/// <param name="dateTime">A date and time value.   </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="dateTime" /> is invalid; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000DAD RID: 3501 RVA: 0x000397E0 File Offset: 0x000379E0
		public bool IsInvalidTime(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				return false;
			}
			if (dateTime.Kind == DateTimeKind.Local && this != TimeZoneInfo.Local)
			{
				return false;
			}
			TimeZoneInfo.AdjustmentRule applicableRule = this.GetApplicableRule(dateTime);
			if (applicableRule != null)
			{
				DateTime dateTime2 = TimeZoneInfo.TransitionPoint(applicableRule.DaylightTransitionStart, dateTime.Year);
				if (dateTime >= dateTime2 && dateTime < dateTime2 + applicableRule.DaylightDelta)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Runs when the deserialization of an object has been completed.</summary>
		/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.TimeZoneInfo" /> object contains invalid or corrupted data.</exception>
		// Token: 0x06000DAE RID: 3502 RVA: 0x0003984C File Offset: 0x00037A4C
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				TimeZoneInfo.Validate(this.id, this.baseUtcOffset, this.adjustmentRules);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException("invalid serialization data", innerException);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00039890 File Offset: 0x00037A90
		private static void Validate(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules)
		{
			if (id == null)
			{
				throw new ArgumentNullException("id");
			}
			if (id == string.Empty)
			{
				throw new ArgumentException("id parameter is an empty string");
			}
			if (baseUtcOffset.Ticks % 600000000L != 0L)
			{
				throw new ArgumentException("baseUtcOffset parameter does not represent a whole number of minutes");
			}
			if (baseUtcOffset > new TimeSpan(14, 0, 0) || baseUtcOffset < new TimeSpan(-14, 0, 0))
			{
				throw new ArgumentOutOfRangeException("baseUtcOffset parameter is greater than 14 hours or less than -14 hours");
			}
			if (adjustmentRules != null && adjustmentRules.Length != 0)
			{
				TimeZoneInfo.AdjustmentRule adjustmentRule = null;
				foreach (TimeZoneInfo.AdjustmentRule adjustmentRule2 in adjustmentRules)
				{
					if (adjustmentRule2 == null)
					{
						throw new InvalidTimeZoneException("one or more elements in adjustmentRules are null");
					}
					if (baseUtcOffset + adjustmentRule2.DaylightDelta < new TimeSpan(-14, 0, 0) || baseUtcOffset + adjustmentRule2.DaylightDelta > new TimeSpan(14, 0, 0))
					{
						throw new InvalidTimeZoneException("Sum of baseUtcOffset and DaylightDelta of one or more object in adjustmentRules array is greater than 14 or less than -14 hours;");
					}
					if (adjustmentRule != null && adjustmentRule.DateStart > adjustmentRule2.DateStart)
					{
						throw new InvalidTimeZoneException("adjustment rules specified in adjustmentRules parameter are not in chronological order");
					}
					if (adjustmentRule != null && adjustmentRule.DateEnd > adjustmentRule2.DateStart)
					{
						throw new InvalidTimeZoneException("some adjustment rules in the adjustmentRules parameter overlap");
					}
					if (adjustmentRule != null && adjustmentRule.DateEnd == adjustmentRule2.DateStart)
					{
						throw new InvalidTimeZoneException("a date can have multiple adjustment rules applied to it");
					}
					adjustmentRule = adjustmentRule2;
				}
			}
		}

		/// <summary>Returns the current <see cref="T:System.TimeZoneInfo" /> object's display name.</summary>
		/// <returns>The value of the <see cref="P:System.TimeZoneInfo.DisplayName" /> property of the current <see cref="T:System.TimeZoneInfo" /> object.</returns>
		// Token: 0x06000DB0 RID: 3504 RVA: 0x000399EA File Offset: 0x00037BEA
		public override string ToString()
		{
			return this.DisplayName;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000399F4 File Offset: 0x00037BF4
		private TimeZoneInfo(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.id = (string)info.GetValue("Id", typeof(string));
			this.displayName = (string)info.GetValue("DisplayName", typeof(string));
			this.standardDisplayName = (string)info.GetValue("StandardName", typeof(string));
			this.daylightDisplayName = (string)info.GetValue("DaylightName", typeof(string));
			this.baseUtcOffset = (TimeSpan)info.GetValue("BaseUtcOffset", typeof(TimeSpan));
			this.adjustmentRules = (TimeZoneInfo.AdjustmentRule[])info.GetValue("AdjustmentRules", typeof(TimeZoneInfo.AdjustmentRule[]));
			this.supportsDaylightSavingTime = (bool)info.GetValue("SupportsDaylightSavingTime", typeof(bool));
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00039AF8 File Offset: 0x00037CF8
		private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
		{
			if (id == null)
			{
				throw new ArgumentNullException("id");
			}
			if (id == string.Empty)
			{
				throw new ArgumentException("id parameter is an empty string");
			}
			if (baseUtcOffset.Ticks % 600000000L != 0L)
			{
				throw new ArgumentException("baseUtcOffset parameter does not represent a whole number of minutes");
			}
			if (baseUtcOffset > new TimeSpan(14, 0, 0) || baseUtcOffset < new TimeSpan(-14, 0, 0))
			{
				throw new ArgumentOutOfRangeException("baseUtcOffset parameter is greater than 14 hours or less than -14 hours");
			}
			bool flag = !disableDaylightSavingTime;
			if (adjustmentRules != null && adjustmentRules.Length != 0)
			{
				TimeZoneInfo.AdjustmentRule adjustmentRule = null;
				foreach (TimeZoneInfo.AdjustmentRule adjustmentRule2 in adjustmentRules)
				{
					if (adjustmentRule2 == null)
					{
						throw new InvalidTimeZoneException("one or more elements in adjustmentRules are null");
					}
					if (baseUtcOffset + adjustmentRule2.DaylightDelta < new TimeSpan(-14, 0, 0) || baseUtcOffset + adjustmentRule2.DaylightDelta > new TimeSpan(14, 0, 0))
					{
						throw new InvalidTimeZoneException("Sum of baseUtcOffset and DaylightDelta of one or more object in adjustmentRules array is greater than 14 or less than -14 hours;");
					}
					if (adjustmentRule != null && adjustmentRule.DateStart > adjustmentRule2.DateStart)
					{
						throw new InvalidTimeZoneException("adjustment rules specified in adjustmentRules parameter are not in chronological order");
					}
					if (adjustmentRule != null && adjustmentRule.DateEnd > adjustmentRule2.DateStart)
					{
						throw new InvalidTimeZoneException("some adjustment rules in the adjustmentRules parameter overlap");
					}
					if (adjustmentRule != null && adjustmentRule.DateEnd == adjustmentRule2.DateStart)
					{
						throw new InvalidTimeZoneException("a date can have multiple adjustment rules applied to it");
					}
					adjustmentRule = adjustmentRule2;
				}
			}
			else
			{
				flag = false;
			}
			this.id = id;
			this.baseUtcOffset = baseUtcOffset;
			this.displayName = (displayName ?? id);
			this.standardDisplayName = (standardDisplayName ?? id);
			this.daylightDisplayName = daylightDisplayName;
			this.supportsDaylightSavingTime = flag;
			this.adjustmentRules = adjustmentRules;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00039CAC File Offset: 0x00037EAC
		private TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime)
		{
			DateTime dateTime2 = dateTime;
			if (dateTime.Kind == DateTimeKind.Local && this != TimeZoneInfo.Local)
			{
				if (!TimeZoneInfo.TryAddTicks(dateTime2.ToUniversalTime(), this.BaseUtcOffset.Ticks, out dateTime2, DateTimeKind.Unspecified))
				{
					return null;
				}
			}
			else if (dateTime.Kind == DateTimeKind.Utc && this != TimeZoneInfo.Utc && !TimeZoneInfo.TryAddTicks(dateTime2, this.BaseUtcOffset.Ticks, out dateTime2, DateTimeKind.Unspecified))
			{
				return null;
			}
			dateTime2 = dateTime2.Date;
			if (this.adjustmentRules != null)
			{
				foreach (TimeZoneInfo.AdjustmentRule adjustmentRule in this.adjustmentRules)
				{
					if (adjustmentRule.DateStart > dateTime2)
					{
						return null;
					}
					if (!(adjustmentRule.DateEnd < dateTime2))
					{
						return adjustmentRule;
					}
				}
			}
			return null;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00039D6C File Offset: 0x00037F6C
		private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst, bool forOffset = false)
		{
			offset = this.BaseUtcOffset;
			isDst = false;
			if (this.transitions == null)
			{
				return false;
			}
			DateTime dateTime2 = dateTime;
			if (dateTime.Kind == DateTimeKind.Local && this != TimeZoneInfo.Local && !TimeZoneInfo.TryAddTicks(dateTime2.ToUniversalTime(), this.BaseUtcOffset.Ticks, out dateTime2, DateTimeKind.Utc))
			{
				return false;
			}
			bool flag = false;
			if (dateTime.Kind != DateTimeKind.Utc)
			{
				if (!TimeZoneInfo.TryAddTicks(dateTime2, -this.BaseUtcOffset.Ticks, out dateTime2, DateTimeKind.Utc))
				{
					return false;
				}
			}
			else
			{
				flag = true;
			}
			TimeZoneInfo.AdjustmentRule applicableRule = this.GetApplicableRule(dateTime2);
			if (applicableRule != null)
			{
				DateTime dateTime3 = TimeZoneInfo.TransitionPoint(applicableRule.DaylightTransitionStart, dateTime2.Year);
				DateTime dateTime4 = TimeZoneInfo.TransitionPoint(applicableRule.DaylightTransitionEnd, dateTime2.Year);
				TimeZoneInfo.TryAddTicks(dateTime3, -this.BaseUtcOffset.Ticks, out dateTime3, DateTimeKind.Utc);
				TimeZoneInfo.TryAddTicks(dateTime4, -this.BaseUtcOffset.Ticks, out dateTime4, DateTimeKind.Utc);
				if (dateTime2 >= dateTime3 && dateTime2 <= dateTime4)
				{
					if (forOffset)
					{
						isDst = true;
					}
					offset = this.baseUtcOffset;
					if (flag || dateTime2 >= new DateTime(dateTime3.Ticks + applicableRule.DaylightDelta.Ticks, DateTimeKind.Utc))
					{
						offset += applicableRule.DaylightDelta;
						isDst = true;
					}
					if (dateTime2 >= new DateTime(dateTime4.Ticks - applicableRule.DaylightDelta.Ticks, DateTimeKind.Utc))
					{
						offset = this.baseUtcOffset;
						isDst = false;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00039F00 File Offset: 0x00038100
		private static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year)
		{
			if (transition.IsFixedDateRule)
			{
				int num = DateTime.DaysInMonth(year, transition.Month);
				int day = (transition.Day <= num) ? transition.Day : num;
				return new DateTime(year, transition.Month, day) + transition.TimeOfDay.TimeOfDay;
			}
			DayOfWeek dayOfWeek = new DateTime(year, transition.Month, 1).DayOfWeek;
			int num2 = 1 + (transition.Week - 1) * 7 + (transition.DayOfWeek - dayOfWeek + 7) % 7;
			if (num2 > DateTime.DaysInMonth(year, transition.Month))
			{
				num2 -= 7;
			}
			if (num2 < 1)
			{
				num2 += 7;
			}
			return new DateTime(year, transition.Month, num2) + transition.TimeOfDay.TimeOfDay;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00039FD0 File Offset: 0x000381D0
		private static TimeZoneInfo.AdjustmentRule[] ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules)
		{
			if (adjustmentRules == null || adjustmentRules.Count == 0)
			{
				return null;
			}
			TimeZoneInfo.AdjustmentRule adjustmentRule = null;
			foreach (TimeZoneInfo.AdjustmentRule adjustmentRule2 in adjustmentRules.ToArray())
			{
				if (adjustmentRule != null && adjustmentRule.DateEnd > adjustmentRule2.DateStart)
				{
					adjustmentRules.Remove(adjustmentRule2);
				}
				adjustmentRule = adjustmentRule2;
			}
			return adjustmentRules.ToArray();
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0003A02B File Offset: 0x0003822B
		private static int SwapInt32(int i)
		{
			return (i >> 24 & 255) | (i >> 8 & 65280) | (i << 8 & 16711680) | (i & 255) << 24;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0003A058 File Offset: 0x00038258
		private static int ReadBigEndianInt32(byte[] buffer, int start)
		{
			int num = BitConverter.ToInt32(buffer, start);
			if (!BitConverter.IsLittleEndian)
			{
				return num;
			}
			return TimeZoneInfo.SwapInt32(num);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0003A07C File Offset: 0x0003827C
		private static long ReadBigEndianInt64(byte[] buffer, int start)
		{
			byte[] array = new byte[8];
			for (int i = 0; i < 8; i++)
			{
				array[i] = buffer[start + i];
			}
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse<byte>(array);
			}
			return BitConverter.ToInt64(array, 0);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0003A0B8 File Offset: 0x000382B8
		private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length)
		{
			int num = TimeZoneInfo.ReadBigEndianInt32(buffer, 20);
			int num2 = TimeZoneInfo.ReadBigEndianInt32(buffer, 24);
			int num3 = TimeZoneInfo.ReadBigEndianInt32(buffer, 28);
			int num4 = TimeZoneInfo.ReadBigEndianInt32(buffer, 32);
			int num5 = TimeZoneInfo.ReadBigEndianInt32(buffer, 36);
			int num6 = TimeZoneInfo.ReadBigEndianInt32(buffer, 40);
			byte b = buffer[4];
			int num7 = 0;
			int num8 = 4;
			if (b == 50 || b == 51)
			{
				num7 += 44 + (num8 * num4 + num4 + 6 * num5 + (num8 + 4) * num3 + num2 + num + num6);
				num = TimeZoneInfo.ReadBigEndianInt32(buffer, 20 + num7);
				num2 = TimeZoneInfo.ReadBigEndianInt32(buffer, 24 + num7);
				num3 = TimeZoneInfo.ReadBigEndianInt32(buffer, 28 + num7);
				num4 = TimeZoneInfo.ReadBigEndianInt32(buffer, 32 + num7);
				num5 = TimeZoneInfo.ReadBigEndianInt32(buffer, 36 + num7);
				num6 = TimeZoneInfo.ReadBigEndianInt32(buffer, 40 + num7);
				num8 = 8;
			}
			if (length < 44 + num4 * 5 + num5 * 6 + num6 + num3 * 8 + num2 + num)
			{
				throw new InvalidTimeZoneException();
			}
			Dictionary<int, string> abbreviations = TimeZoneInfo.ParseAbbreviations(buffer, num7 + 44 + num8 * num4 + num4 + 6 * num5, num6);
			Dictionary<int, TimeType> dictionary = TimeZoneInfo.ParseTimesTypes(buffer, num7 + 44 + num8 * num4 + num4, num5, abbreviations);
			List<KeyValuePair<DateTime, TimeType>> list = TimeZoneInfo.ParseTransitions(buffer, num7 + 44, num4, num8, dictionary);
			if (dictionary.Count == 0)
			{
				throw new InvalidTimeZoneException();
			}
			if (dictionary.Count == 1 && dictionary[0].IsDst)
			{
				throw new InvalidTimeZoneException();
			}
			TimeSpan timeSpan = new TimeSpan(0L);
			TimeSpan timeSpan2 = new TimeSpan(0L);
			string text = null;
			string a = null;
			bool flag = false;
			DateTime d = DateTime.MinValue;
			List<TimeZoneInfo.AdjustmentRule> list2 = new List<TimeZoneInfo.AdjustmentRule>();
			bool flag2 = false;
			for (int i = 0; i < list.Count; i++)
			{
				KeyValuePair<DateTime, TimeType> keyValuePair = list[i];
				DateTime key = keyValuePair.Key;
				TimeType value = keyValuePair.Value;
				if (!value.IsDst)
				{
					if (text != value.Name)
					{
						text = value.Name;
					}
					if (timeSpan.TotalSeconds != (double)value.Offset)
					{
						timeSpan = new TimeSpan(0, 0, value.Offset);
						if (list2.Count > 0)
						{
							flag2 = true;
						}
						list2 = new List<TimeZoneInfo.AdjustmentRule>();
						flag = false;
					}
					if (flag)
					{
						d += timeSpan;
						DateTime dateTime = key + timeSpan + timeSpan2;
						if (dateTime.Date == new DateTime(dateTime.Year, 1, 1) && dateTime.Year > d.Year)
						{
							dateTime -= new TimeSpan(24, 0, 0);
						}
						if (d.AddYears(1) < dateTime)
						{
							flag2 = true;
						}
						DateTime dateStart;
						if (d.Month < 7)
						{
							dateStart = new DateTime(d.Year, 1, 1);
						}
						else
						{
							dateStart = new DateTime(d.Year, 7, 1);
						}
						DateTime dateEnd;
						if (dateTime.Month >= 7)
						{
							dateEnd = new DateTime(dateTime.Year, 12, 31);
						}
						else
						{
							dateEnd = new DateTime(dateTime.Year, 6, 30);
						}
						TimeZoneInfo.TransitionTime transitionTime = TimeZoneInfo.TransitionTime.CreateFixedDateRule(new DateTime(1, 1, 1) + d.TimeOfDay, d.Month, d.Day);
						TimeZoneInfo.TransitionTime transitionTime2 = TimeZoneInfo.TransitionTime.CreateFixedDateRule(new DateTime(1, 1, 1) + dateTime.TimeOfDay, dateTime.Month, dateTime.Day);
						if (transitionTime != transitionTime2)
						{
							list2.Add(TimeZoneInfo.AdjustmentRule.CreateAdjustmentRule(dateStart, dateEnd, timeSpan2, transitionTime, transitionTime2));
						}
					}
					flag = false;
				}
				else
				{
					if (a != value.Name)
					{
						a = value.Name;
					}
					if (timeSpan2.TotalSeconds != (double)value.Offset - timeSpan.TotalSeconds)
					{
						timeSpan2 = new TimeSpan(0, 0, value.Offset) - timeSpan;
						if (timeSpan2.Ticks % 600000000L != 0L)
						{
							timeSpan2 = TimeSpan.FromMinutes((double)((long)(timeSpan2.TotalMinutes + 0.5)));
						}
					}
					d = key;
					flag = true;
				}
			}
			TimeZoneInfo timeZoneInfo;
			if (list2.Count == 0 && !flag2)
			{
				if (text == null)
				{
					TimeType timeType = dictionary[0];
					text = timeType.Name;
					timeSpan = new TimeSpan(0, 0, timeType.Offset);
				}
				timeZoneInfo = TimeZoneInfo.CreateCustomTimeZone(id, timeSpan, id, text);
			}
			else
			{
				timeZoneInfo = TimeZoneInfo.CreateCustomTimeZone(id, timeSpan, id, text, a, TimeZoneInfo.ValidateRules(list2));
			}
			if (flag2 && list.Count > 0)
			{
				timeZoneInfo.transitions = list;
			}
			timeZoneInfo.supportsDaylightSavingTime = (list2.Count > 0);
			return timeZoneInfo;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0003A51C File Offset: 0x0003871C
		private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count)
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			int num = 0;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < count; i++)
			{
				char c = (char)buffer[index + i];
				if (c != '\0')
				{
					stringBuilder.Append(c);
				}
				else
				{
					dictionary.Add(num, stringBuilder.ToString());
					for (int j = 1; j <= stringBuilder.Length; j++)
					{
						dictionary.Add(num + j, stringBuilder.ToString(j, stringBuilder.Length - j));
					}
					num = i + 1;
					stringBuilder = new StringBuilder();
				}
			}
			return dictionary;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0003A5A4 File Offset: 0x000387A4
		private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations)
		{
			Dictionary<int, TimeType> dictionary = new Dictionary<int, TimeType>(count);
			for (int i = 0; i < count; i++)
			{
				int num = TimeZoneInfo.ReadBigEndianInt32(buffer, index + 6 * i);
				num = num / 60 * 60;
				byte b = buffer[index + 6 * i + 4];
				byte key = buffer[index + 6 * i + 5];
				dictionary.Add(i, new TimeType(num, b > 0, abbreviations[(int)key]));
			}
			return dictionary;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0003A608 File Offset: 0x00038808
		private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, int timeValuesLength, Dictionary<int, TimeType> time_types)
		{
			List<KeyValuePair<DateTime, TimeType>> list = new List<KeyValuePair<DateTime, TimeType>>(count);
			for (int i = 0; i < count; i++)
			{
				long unix_time;
				if (timeValuesLength == 8)
				{
					unix_time = TimeZoneInfo.ReadBigEndianInt64(buffer, index + timeValuesLength * i);
				}
				else
				{
					unix_time = (long)TimeZoneInfo.ReadBigEndianInt32(buffer, index + timeValuesLength * i);
				}
				DateTime key = TimeZoneInfo.DateTimeFromUnixTime(unix_time);
				byte key2 = buffer[index + timeValuesLength * count + i];
				list.Add(new KeyValuePair<DateTime, TimeType>(key, time_types[(int)key2]));
			}
			return list;
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0003A674 File Offset: 0x00038874
		private static DateTime DateTimeFromUnixTime(long unix_time)
		{
			if (unix_time < -62135596800L)
			{
				return DateTime.MinValue;
			}
			if (unix_time <= 253402300799L)
			{
				return DateTimeOffset.FromUnixTimeSeconds(unix_time).UtcDateTime;
			}
			return DateTime.MaxValue;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0003A6B4 File Offset: 0x000388B4
		internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			bool flag;
			return TimeZoneInfo.Local.GetUtcOffset(dateTime, out flag, false);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0003A6D0 File Offset: 0x000388D0
		internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			bool flag;
			return this.GetUtcOffset(dateTime, out flag, false);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0003A6E7 File Offset: 0x000388E7
		internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
		{
			isDaylightSavings = false;
			isAmbiguousLocalDst = false;
			TimeSpan timeSpan = zone.BaseUtcOffset;
			if (zone.IsAmbiguousTime(time))
			{
				isAmbiguousLocalDst = true;
			}
			return zone.GetUtcOffset(time, out isDaylightSavings, false);
		}

		// Token: 0x040004D7 RID: 1239
		private TimeSpan baseUtcOffset;

		// Token: 0x040004D8 RID: 1240
		private string daylightDisplayName;

		// Token: 0x040004D9 RID: 1241
		private string displayName;

		// Token: 0x040004DA RID: 1242
		private string id;

		// Token: 0x040004DB RID: 1243
		private static TimeZoneInfo local;

		// Token: 0x040004DC RID: 1244
		private List<KeyValuePair<DateTime, TimeType>> transitions;

		// Token: 0x040004DD RID: 1245
		private string standardDisplayName;

		// Token: 0x040004DE RID: 1246
		private bool supportsDaylightSavingTime;

		// Token: 0x040004DF RID: 1247
		private static TimeZoneInfo utc;

		// Token: 0x040004E0 RID: 1248
		private TimeZoneInfo.AdjustmentRule[] adjustmentRules;

		// Token: 0x040004E1 RID: 1249
		private static ReadOnlyCollection<TimeZoneInfo> systemTimeZones;

		/// <summary>Provides information about a time zone adjustment, such as the transition to and from daylight saving time.</summary>
		// Token: 0x02000158 RID: 344
		[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
		[Serializable]
		public sealed class AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback
		{
			/// <summary>Gets the date when the adjustment rule takes effect.</summary>
			/// <returns>A <see cref="T:System.DateTime" /> value that indicates when the adjustment rule takes effect.</returns>
			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0003A70B File Offset: 0x0003890B
			public DateTime DateStart
			{
				get
				{
					return this.m_dateStart;
				}
			}

			/// <summary>Gets the date when the adjustment rule ceases to be in effect.</summary>
			/// <returns>A <see cref="T:System.DateTime" /> value that indicates the end date of the adjustment rule.</returns>
			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0003A713 File Offset: 0x00038913
			public DateTime DateEnd
			{
				get
				{
					return this.m_dateEnd;
				}
			}

			/// <summary>Gets the amount of time that is required to form the time zone's daylight saving time. This amount of time is added to the time zone's offset from Coordinated Universal Time (UTC).</summary>
			/// <returns>A <see cref="T:System.TimeSpan" /> object that indicates the amount of time to add to the standard time changes as a result of the adjustment rule.</returns>
			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0003A71B File Offset: 0x0003891B
			public TimeSpan DaylightDelta
			{
				get
				{
					return this.m_daylightDelta;
				}
			}

			/// <summary>Gets information about the annual transition from standard time to daylight saving time.</summary>
			/// <returns>A <see cref="T:System.TimeZoneInfo.TransitionTime" /> object that defines the annual transition from a time zone's standard time to daylight saving time.</returns>
			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0003A723 File Offset: 0x00038923
			public TimeZoneInfo.TransitionTime DaylightTransitionStart
			{
				get
				{
					return this.m_daylightTransitionStart;
				}
			}

			/// <summary>Gets information about the annual transition from daylight saving time back to standard time.</summary>
			/// <returns>A <see cref="T:System.TimeZoneInfo.TransitionTime" /> object that defines the annual transition from daylight saving time back to the time zone's standard time.</returns>
			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0003A72B File Offset: 0x0003892B
			public TimeZoneInfo.TransitionTime DaylightTransitionEnd
			{
				get
				{
					return this.m_daylightTransitionEnd;
				}
			}

			/// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> object is equal to a second <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> object.</summary>
			/// <param name="other">The object to compare with the current object.</param>
			/// <returns>
			///     <see langword="true" /> if both <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> objects have equal values; otherwise, <see langword="false" />.</returns>
			// Token: 0x06000DC7 RID: 3527 RVA: 0x0003A734 File Offset: 0x00038934
			public bool Equals(TimeZoneInfo.AdjustmentRule other)
			{
				return other != null && this.m_dateStart == other.m_dateStart && this.m_dateEnd == other.m_dateEnd && this.m_daylightDelta == other.m_daylightDelta && this.m_baseUtcOffsetDelta == other.m_baseUtcOffsetDelta && this.m_daylightTransitionEnd.Equals(other.m_daylightTransitionEnd) && this.m_daylightTransitionStart.Equals(other.m_daylightTransitionStart);
			}

			/// <summary>Serves as a hash function for hashing algorithms and data structures such as hash tables.</summary>
			/// <returns>A 32-bit signed integer that serves as the hash code for the current <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> object.</returns>
			// Token: 0x06000DC8 RID: 3528 RVA: 0x0003A7B9 File Offset: 0x000389B9
			public override int GetHashCode()
			{
				return this.m_dateStart.GetHashCode();
			}

			// Token: 0x06000DC9 RID: 3529 RVA: 0x00003ACD File Offset: 0x00001CCD
			private AdjustmentRule()
			{
			}

			/// <summary>Creates a new adjustment rule for a particular time zone.</summary>
			/// <param name="dateStart">The effective date of the adjustment rule. If the value of the <paramref name="dateStart" /> parameter is <see langword="DateTime.MinValue.Date" />, this is the first adjustment rule in effect for a time zone.   </param>
			/// <param name="dateEnd">The last date that the adjustment rule is in force. If the value of the <paramref name="dateEnd" /> parameter is <see langword="DateTime.MaxValue.Date" />, the adjustment rule has no end date.</param>
			/// <param name="daylightDelta">The time change that results from the adjustment. This value is added to the time zone's <see cref="P:System.TimeZoneInfo.BaseUtcOffset" /> property to obtain the correct daylight offset from Coordinated Universal Time (UTC). This value can range from -14 to 14. </param>
			/// <param name="daylightTransitionStart">An object that defines the start of daylight saving time.</param>
			/// <param name="daylightTransitionEnd">An object that defines the end of daylight saving time.   </param>
			/// <returns>An object that represents the new adjustment rule.</returns>
			/// <exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateStart" /> or <paramref name="dateEnd" /> parameter does not equal <see cref="F:System.DateTimeKind.Unspecified" />.-or-The <paramref name="daylightTransitionStart" /> parameter is equal to the <paramref name="daylightTransitionEnd" /> parameter.-or-The <paramref name="dateStart" /> or <paramref name="dateEnd" /> parameter includes a time of day value.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="dateEnd" /> is earlier than <paramref name="dateStart" />.-or-
			///         <paramref name="daylightDelta" /> is less than -14 or greater than 14.-or-The <see cref="P:System.TimeSpan.Milliseconds" /> property of the <paramref name="daylightDelta" /> parameter is not equal to 0.-or-The <see cref="P:System.TimeSpan.Ticks" /> property of the <paramref name="daylightDelta" /> parameter does not equal a whole number of seconds.</exception>
			// Token: 0x06000DCA RID: 3530 RVA: 0x0003A7C8 File Offset: 0x000389C8
			public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				TimeZoneInfo.AdjustmentRule.ValidateAdjustmentRule(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd);
				return new TimeZoneInfo.AdjustmentRule
				{
					m_dateStart = dateStart,
					m_dateEnd = dateEnd,
					m_daylightDelta = daylightDelta,
					m_daylightTransitionStart = daylightTransitionStart,
					m_daylightTransitionEnd = daylightTransitionEnd,
					m_baseUtcOffsetDelta = TimeSpan.Zero
				};
			}

			// Token: 0x06000DCB RID: 3531 RVA: 0x0003A814 File Offset: 0x00038A14
			private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				if (dateStart.Kind != DateTimeKind.Unspecified)
				{
					throw new ArgumentException(Environment.GetResourceString("The supplied DateTime must have the Kind property set to DateTimeKind.Unspecified."), "dateStart");
				}
				if (dateEnd.Kind != DateTimeKind.Unspecified)
				{
					throw new ArgumentException(Environment.GetResourceString("The supplied DateTime must have the Kind property set to DateTimeKind.Unspecified."), "dateEnd");
				}
				if (daylightTransitionStart.Equals(daylightTransitionEnd))
				{
					throw new ArgumentException(Environment.GetResourceString("The DaylightTransitionStart property must not equal the DaylightTransitionEnd property."), "daylightTransitionEnd");
				}
				if (dateStart > dateEnd)
				{
					throw new ArgumentException(Environment.GetResourceString("The DateStart property must come before the DateEnd property."), "dateStart");
				}
				if (TimeZoneInfo.UtcOffsetOutOfRange(daylightDelta))
				{
					throw new ArgumentOutOfRangeException("daylightDelta", daylightDelta, Environment.GetResourceString("The TimeSpan parameter must be within plus or minus 14.0 hours."));
				}
				if (daylightDelta.Ticks % 600000000L != 0L)
				{
					throw new ArgumentException(Environment.GetResourceString("The TimeSpan parameter cannot be specified more precisely than whole minutes."), "daylightDelta");
				}
				if (dateStart.TimeOfDay != TimeSpan.Zero)
				{
					throw new ArgumentException(Environment.GetResourceString("The supplied DateTime includes a TimeOfDay setting.   This is not supported."), "dateStart");
				}
				if (dateEnd.TimeOfDay != TimeSpan.Zero)
				{
					throw new ArgumentException(Environment.GetResourceString("The supplied DateTime includes a TimeOfDay setting.   This is not supported."), "dateEnd");
				}
			}

			/// <summary>Runs when the deserialization of a <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> object is completed.</summary>
			/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.   </param>
			// Token: 0x06000DCC RID: 3532 RVA: 0x0003A934 File Offset: 0x00038B34
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				try
				{
					TimeZoneInfo.AdjustmentRule.ValidateAdjustmentRule(this.m_dateStart, this.m_dateEnd, this.m_daylightDelta, this.m_daylightTransitionStart, this.m_daylightTransitionEnd);
				}
				catch (ArgumentException innerException)
				{
					throw new SerializationException(Environment.GetResourceString("An error occurred while deserializing the object.  The serialized data is corrupt."), innerException);
				}
			}

			/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data that is required to serialize this object.</summary>
			/// <param name="info">The object to populate with data.</param>
			/// <param name="context">The destination for this serialization (see <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
			// Token: 0x06000DCD RID: 3533 RVA: 0x0003A988 File Offset: 0x00038B88
			[SecurityCritical]
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				info.AddValue("DateStart", this.m_dateStart);
				info.AddValue("DateEnd", this.m_dateEnd);
				info.AddValue("DaylightDelta", this.m_daylightDelta);
				info.AddValue("DaylightTransitionStart", this.m_daylightTransitionStart);
				info.AddValue("DaylightTransitionEnd", this.m_daylightTransitionEnd);
				info.AddValue("BaseUtcOffsetDelta", this.m_baseUtcOffsetDelta);
			}

			// Token: 0x06000DCE RID: 3534 RVA: 0x0003AA20 File Offset: 0x00038C20
			private AdjustmentRule(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				this.m_dateStart = (DateTime)info.GetValue("DateStart", typeof(DateTime));
				this.m_dateEnd = (DateTime)info.GetValue("DateEnd", typeof(DateTime));
				this.m_daylightDelta = (TimeSpan)info.GetValue("DaylightDelta", typeof(TimeSpan));
				this.m_daylightTransitionStart = (TimeZoneInfo.TransitionTime)info.GetValue("DaylightTransitionStart", typeof(TimeZoneInfo.TransitionTime));
				this.m_daylightTransitionEnd = (TimeZoneInfo.TransitionTime)info.GetValue("DaylightTransitionEnd", typeof(TimeZoneInfo.TransitionTime));
				object valueNoThrow = info.GetValueNoThrow("BaseUtcOffsetDelta", typeof(TimeSpan));
				if (valueNoThrow != null)
				{
					this.m_baseUtcOffsetDelta = (TimeSpan)valueNoThrow;
				}
			}

			// Token: 0x040004E2 RID: 1250
			private DateTime m_dateStart;

			// Token: 0x040004E3 RID: 1251
			private DateTime m_dateEnd;

			// Token: 0x040004E4 RID: 1252
			private TimeSpan m_daylightDelta;

			// Token: 0x040004E5 RID: 1253
			private TimeZoneInfo.TransitionTime m_daylightTransitionStart;

			// Token: 0x040004E6 RID: 1254
			private TimeZoneInfo.TransitionTime m_daylightTransitionEnd;

			// Token: 0x040004E7 RID: 1255
			private TimeSpan m_baseUtcOffsetDelta;
		}

		/// <summary>Provides information about a specific time change, such as the change from daylight saving time to standard time or vice versa, in a particular time zone.</summary>
		// Token: 0x02000159 RID: 345
		[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
		[Serializable]
		public readonly struct TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback
		{
			// Token: 0x06000DCF RID: 3535 RVA: 0x0003AB06 File Offset: 0x00038D06
			internal TransitionTime(bool isFixedDateRule, DateTime timeOfDay, DayOfWeek dayOfWeek, byte day, byte week, byte month)
			{
				this.m_isFixedDateRule = isFixedDateRule;
				this.m_timeOfDay = timeOfDay;
				this.m_dayOfWeek = dayOfWeek;
				this.m_day = day;
				this.m_week = week;
				this.m_month = month;
			}

			/// <summary>Gets the hour, minute, and second at which the time change occurs.</summary>
			/// <returns>The time of day at which the time change occurs.</returns>
			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0003AB35 File Offset: 0x00038D35
			public DateTime TimeOfDay
			{
				get
				{
					return this.m_timeOfDay;
				}
			}

			/// <summary>Gets the month in which the time change occurs.</summary>
			/// <returns>The month in which the time change occurs.</returns>
			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0003AB3D File Offset: 0x00038D3D
			public int Month
			{
				get
				{
					return (int)this.m_month;
				}
			}

			/// <summary>Gets the week of the month in which a time change occurs.</summary>
			/// <returns>The week of the month in which the time change occurs.</returns>
			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0003AB45 File Offset: 0x00038D45
			public int Week
			{
				get
				{
					return (int)this.m_week;
				}
			}

			/// <summary>Gets the day on which the time change occurs.</summary>
			/// <returns>The day on which the time change occurs.</returns>
			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0003AB4D File Offset: 0x00038D4D
			public int Day
			{
				get
				{
					return (int)this.m_day;
				}
			}

			/// <summary>Gets the day of the week on which the time change occurs.</summary>
			/// <returns>The day of the week on which the time change occurs.</returns>
			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0003AB55 File Offset: 0x00038D55
			public DayOfWeek DayOfWeek
			{
				get
				{
					return this.m_dayOfWeek;
				}
			}

			/// <summary>Gets a value indicating whether the time change occurs at a fixed date and time (such as November 1) or a floating date and time (such as the last Sunday of October).</summary>
			/// <returns>
			///     <see langword="true" /> if the time change rule is fixed-date; <see langword="false" /> if the time change rule is floating-date.</returns>
			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0003AB5D File Offset: 0x00038D5D
			public bool IsFixedDateRule
			{
				get
				{
					return this.m_isFixedDateRule;
				}
			}

			/// <summary>Determines whether an object has identical values to the current <see cref="T:System.TimeZoneInfo.TransitionTime" /> object.</summary>
			/// <param name="obj">An object to compare with the current <see cref="T:System.TimeZoneInfo.TransitionTime" /> object.   </param>
			/// <returns>
			///     <see langword="true" /> if the two objects are equal; otherwise, <see langword="false" />.</returns>
			// Token: 0x06000DD6 RID: 3542 RVA: 0x0003AB65 File Offset: 0x00038D65
			public override bool Equals(object obj)
			{
				return obj is TimeZoneInfo.TransitionTime && this.Equals((TimeZoneInfo.TransitionTime)obj);
			}

			/// <summary>Determines whether two specified <see cref="T:System.TimeZoneInfo.TransitionTime" /> objects are not equal.</summary>
			/// <param name="t1">The first object to compare.</param>
			/// <param name="t2">The second object to compare.</param>
			/// <returns>
			///     <see langword="true" /> if <paramref name="t1" /> and <paramref name="t2" /> have any different member values; otherwise, <see langword="false" />.</returns>
			// Token: 0x06000DD7 RID: 3543 RVA: 0x0003AB7D File Offset: 0x00038D7D
			public static bool operator !=(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2)
			{
				return !t1.Equals(t2);
			}

			/// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo.TransitionTime" /> object has identical values to a second <see cref="T:System.TimeZoneInfo.TransitionTime" /> object.</summary>
			/// <param name="other">An object to compare to the current instance. </param>
			/// <returns>
			///     <see langword="true" /> if the two objects have identical property values; otherwise, <see langword="false" />.</returns>
			// Token: 0x06000DD8 RID: 3544 RVA: 0x0003AB8C File Offset: 0x00038D8C
			public bool Equals(TimeZoneInfo.TransitionTime other)
			{
				bool flag = this.m_isFixedDateRule == other.m_isFixedDateRule && this.m_timeOfDay == other.m_timeOfDay && this.m_month == other.m_month;
				if (flag)
				{
					if (other.m_isFixedDateRule)
					{
						flag = (this.m_day == other.m_day);
					}
					else
					{
						flag = (this.m_week == other.m_week && this.m_dayOfWeek == other.m_dayOfWeek);
					}
				}
				return flag;
			}

			/// <summary>Serves as a hash function for hashing algorithms and data structures such as hash tables.</summary>
			/// <returns>A 32-bit signed integer that serves as the hash code for this <see cref="T:System.TimeZoneInfo.TransitionTime" /> object.</returns>
			// Token: 0x06000DD9 RID: 3545 RVA: 0x0003AC09 File Offset: 0x00038E09
			public override int GetHashCode()
			{
				return (int)this.m_month ^ (int)this.m_week << 8;
			}

			/// <summary>Defines a time change that uses a fixed-date rule (that is, a time change that occurs on a specific day of a specific month). </summary>
			/// <param name="timeOfDay">The time at which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.TimeOfDay" /> property. For details, see Remarks.</param>
			/// <param name="month">The month in which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.Month" /> property. </param>
			/// <param name="day">The day of the month on which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.Day" /> property. </param>
			/// <returns>Data about the time change.</returns>
			/// <exception cref="T:System.ArgumentException">The <paramref name="timeOfDay" /> parameter has a non-default date component.-or-The <paramref name="timeOfDay" /> parameter's <see cref="P:System.DateTime.Kind" /> property is not <see cref="F:System.DateTimeKind.Unspecified" />.-or-The <paramref name="timeOfDay" /> parameter does not represent a whole number of milliseconds.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="month" /> parameter is less than 1 or greater than 12.-or-The <paramref name="day" /> parameter is less than 1 or greater than 31.</exception>
			// Token: 0x06000DDA RID: 3546 RVA: 0x0003AC1A File Offset: 0x00038E1A
			public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
			{
				return TimeZoneInfo.TransitionTime.CreateTransitionTime(timeOfDay, month, 1, day, DayOfWeek.Sunday, true);
			}

			// Token: 0x06000DDB RID: 3547 RVA: 0x0003AC27 File Offset: 0x00038E27
			private static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
			{
				TimeZoneInfo.TransitionTime.ValidateTransitionTime(timeOfDay, month, week, day, dayOfWeek);
				return new TimeZoneInfo.TransitionTime(isFixedDateRule, timeOfDay, dayOfWeek, (byte)day, (byte)week, (byte)month);
			}

			// Token: 0x06000DDC RID: 3548 RVA: 0x0003AC44 File Offset: 0x00038E44
			private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
			{
				if (timeOfDay.Kind != DateTimeKind.Unspecified)
				{
					throw new ArgumentException(Environment.GetResourceString("The supplied DateTime must have the Kind property set to DateTimeKind.Unspecified."), "timeOfDay");
				}
				if (month < 1 || month > 12)
				{
					throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("The Month parameter must be in the range 1 through 12."));
				}
				if (day < 1 || day > 31)
				{
					throw new ArgumentOutOfRangeException("day", Environment.GetResourceString("The Day parameter must be in the range 1 through 31."));
				}
				if (week < 1 || week > 5)
				{
					throw new ArgumentOutOfRangeException("week", Environment.GetResourceString("The Week parameter must be in the range 1 through 5."));
				}
				if (dayOfWeek < DayOfWeek.Sunday || dayOfWeek > DayOfWeek.Saturday)
				{
					throw new ArgumentOutOfRangeException("dayOfWeek", Environment.GetResourceString("The DayOfWeek enumeration must be in the range 0 through 6."));
				}
				if (timeOfDay.Year != 1 || timeOfDay.Month != 1 || timeOfDay.Day != 1 || timeOfDay.Ticks % 10000L != 0L)
				{
					throw new ArgumentException(Environment.GetResourceString("The supplied DateTime must have the Year, Month, and Day properties set to 1.  The time cannot be specified more precisely than whole milliseconds."), "timeOfDay");
				}
			}

			/// <summary>Runs when the deserialization of an object has been completed.</summary>
			/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.   </param>
			// Token: 0x06000DDD RID: 3549 RVA: 0x0003AD2C File Offset: 0x00038F2C
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				try
				{
					TimeZoneInfo.TransitionTime.ValidateTransitionTime(this.m_timeOfDay, (int)this.m_month, (int)this.m_week, (int)this.m_day, this.m_dayOfWeek);
				}
				catch (ArgumentException innerException)
				{
					throw new SerializationException(Environment.GetResourceString("An error occurred while deserializing the object.  The serialized data is corrupt."), innerException);
				}
			}

			/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data that is required to serialize this object.</summary>
			/// <param name="info">The object to populate with data.</param>
			/// <param name="context">The destination for this serialization (see <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
			// Token: 0x06000DDE RID: 3550 RVA: 0x0003AD80 File Offset: 0x00038F80
			[SecurityCritical]
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				info.AddValue("TimeOfDay", this.m_timeOfDay);
				info.AddValue("Month", this.m_month);
				info.AddValue("Week", this.m_week);
				info.AddValue("Day", this.m_day);
				info.AddValue("DayOfWeek", this.m_dayOfWeek);
				info.AddValue("IsFixedDateRule", this.m_isFixedDateRule);
			}

			// Token: 0x06000DDF RID: 3551 RVA: 0x0003AE08 File Offset: 0x00039008
			private TransitionTime(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				this.m_timeOfDay = (DateTime)info.GetValue("TimeOfDay", typeof(DateTime));
				this.m_month = (byte)info.GetValue("Month", typeof(byte));
				this.m_week = (byte)info.GetValue("Week", typeof(byte));
				this.m_day = (byte)info.GetValue("Day", typeof(byte));
				this.m_dayOfWeek = (DayOfWeek)info.GetValue("DayOfWeek", typeof(DayOfWeek));
				this.m_isFixedDateRule = (bool)info.GetValue("IsFixedDateRule", typeof(bool));
			}

			// Token: 0x040004E8 RID: 1256
			private readonly DateTime m_timeOfDay;

			// Token: 0x040004E9 RID: 1257
			private readonly byte m_month;

			// Token: 0x040004EA RID: 1258
			private readonly byte m_week;

			// Token: 0x040004EB RID: 1259
			private readonly byte m_day;

			// Token: 0x040004EC RID: 1260
			private readonly DayOfWeek m_dayOfWeek;

			// Token: 0x040004ED RID: 1261
			private readonly bool m_isFixedDateRule;
		}

		// Token: 0x0200015A RID: 346
		private sealed class ZoneInfoDB : IAndroidTimeZoneDB
		{
			// Token: 0x06000DE0 RID: 3552 RVA: 0x0003AEE4 File Offset: 0x000390E4
			public ZoneInfoDB(string zoneInfoDB = null)
			{
				this.zoneRoot = (zoneInfoDB ?? TimeZoneInfo.ZoneInfoDB.ZoneDirectoryName);
				try
				{
					this.version = TimeZoneInfo.ZoneInfoDB.ReadVersion(Path.Combine(this.zoneRoot, "zoneinfo.version"));
				}
				catch
				{
					this.version = "2007h";
				}
				try
				{
					this.ReadDatabase(Path.Combine(this.zoneRoot, "zoneinfo.idx"), out this.names, out this.starts, out this.lengths, out this.offsets);
				}
				catch
				{
					this.names = new string[0];
					this.starts = new int[0];
					this.lengths = new int[0];
					this.offsets = new int[0];
				}
			}

			// Token: 0x06000DE1 RID: 3553 RVA: 0x0003AFB4 File Offset: 0x000391B4
			private static string ReadVersion(string path)
			{
				string result;
				using (StreamReader streamReader = new StreamReader(path, Encoding.GetEncoding("iso-8859-1")))
				{
					result = streamReader.ReadToEnd().Trim();
				}
				return result;
			}

			// Token: 0x06000DE2 RID: 3554 RVA: 0x0003AFFC File Offset: 0x000391FC
			private void ReadDatabase(string path, out string[] names, out int[] starts, out int[] lengths, out int[] offsets)
			{
				using (FileStream fileStream = File.OpenRead(path))
				{
					byte[] array = new byte[40];
					int num = (int)(fileStream.Length / 52L);
					char[] array2 = new char[40];
					names = new string[num];
					starts = new int[num];
					lengths = new int[num];
					offsets = new int[num];
					for (int i = 0; i < num; i++)
					{
						TimeZoneInfo.ZoneInfoDB.Fill(fileStream, array, array.Length);
						int num2 = 0;
						while (num2 < array.Length && array[num2] != 0)
						{
							array2[num2] = (char)(array[num2] & byte.MaxValue);
							num2++;
						}
						names[i] = new string(array2, 0, num2);
						starts[i] = TimeZoneInfo.ZoneInfoDB.ReadInt32(fileStream, array);
						lengths[i] = TimeZoneInfo.ZoneInfoDB.ReadInt32(fileStream, array);
						offsets[i] = TimeZoneInfo.ZoneInfoDB.ReadInt32(fileStream, array);
					}
				}
			}

			// Token: 0x06000DE3 RID: 3555 RVA: 0x0003B0E0 File Offset: 0x000392E0
			private static void Fill(Stream stream, byte[] nbuf, int required)
			{
				int num = 0;
				int num2 = 0;
				while (num2 < required && (num = stream.Read(nbuf, num2, required - num2)) > 0)
				{
					num2 += num;
				}
				if (num != required)
				{
					throw new EndOfStreamException(string.Concat(new string[]
					{
						"Needed to read ",
						required.ToString(),
						" bytes; read ",
						num.ToString(),
						" bytes"
					}));
				}
			}

			// Token: 0x06000DE4 RID: 3556 RVA: 0x0003B14C File Offset: 0x0003934C
			private static int ReadInt32(Stream stream, byte[] nbuf)
			{
				TimeZoneInfo.ZoneInfoDB.Fill(stream, nbuf, 4);
				return ((int)(nbuf[0] & byte.MaxValue) << 24) + ((int)(nbuf[1] & byte.MaxValue) << 16) + ((int)(nbuf[2] & byte.MaxValue) << 8) + (int)(nbuf[3] & byte.MaxValue);
			}

			// Token: 0x06000DE5 RID: 3557 RVA: 0x0003B188 File Offset: 0x00039388
			public byte[] GetTimeZoneData(string id)
			{
				int num;
				int num2;
				byte[] result;
				using (FileStream timeZoneData = this.GetTimeZoneData(id, out num, out num2))
				{
					if (timeZoneData == null)
					{
						result = null;
					}
					else
					{
						byte[] array = new byte[num2];
						TimeZoneInfo.ZoneInfoDB.Fill(timeZoneData, array, array.Length);
						result = array;
					}
				}
				return result;
			}

			// Token: 0x06000DE6 RID: 3558 RVA: 0x0003B1DC File Offset: 0x000393DC
			private FileStream GetTimeZoneData(string name, out int start, out int length)
			{
				if (name == null)
				{
					start = 0;
					length = 0;
					return null;
				}
				FileInfo fileInfo = new FileInfo(Path.Combine(this.zoneRoot, name));
				if (fileInfo.Exists)
				{
					start = 0;
					length = (int)fileInfo.Length;
					return fileInfo.OpenRead();
				}
				start = (length = 0);
				int num = Array.BinarySearch<string>(this.names, name, StringComparer.Ordinal);
				if (num < 0)
				{
					return null;
				}
				start = this.starts[num];
				length = this.lengths[num];
				FileStream fileStream = File.OpenRead(Path.Combine(this.zoneRoot, "zoneinfo.dat"));
				fileStream.Seek((long)start, SeekOrigin.Begin);
				return fileStream;
			}

			// Token: 0x040004EE RID: 1262
			internal static readonly string ZoneDirectoryName = Environment.GetEnvironmentVariable("ANDROID_ROOT") + "/usr/share/zoneinfo/";

			// Token: 0x040004EF RID: 1263
			private readonly string zoneRoot;

			// Token: 0x040004F0 RID: 1264
			private readonly string version;

			// Token: 0x040004F1 RID: 1265
			private readonly string[] names;

			// Token: 0x040004F2 RID: 1266
			private readonly int[] starts;

			// Token: 0x040004F3 RID: 1267
			private readonly int[] lengths;

			// Token: 0x040004F4 RID: 1268
			private readonly int[] offsets;
		}

		// Token: 0x0200015B RID: 347
		private static class AndroidTimeZones
		{
			// Token: 0x06000DE9 RID: 3561 RVA: 0x0003B29C File Offset: 0x0003949C
			private static IAndroidTimeZoneDB GetDefaultTimeZoneDB()
			{
				string[] paths = AndroidTzData.Paths;
				for (int i = 0; i < paths.Length; i++)
				{
					if (File.Exists(paths[i]))
					{
						return new AndroidTzData(AndroidTzData.Paths);
					}
				}
				if (Directory.Exists(TimeZoneInfo.ZoneInfoDB.ZoneDirectoryName))
				{
					return new TimeZoneInfo.ZoneInfoDB(null);
				}
				return null;
			}

			// Token: 0x06000DEA RID: 3562 RVA: 0x0003B2E8 File Offset: 0x000394E8
			private static TimeZoneInfo _GetTimeZone(string id, string name)
			{
				if (TimeZoneInfo.AndroidTimeZones.db == null)
				{
					return null;
				}
				byte[] timeZoneData = TimeZoneInfo.AndroidTimeZones.db.GetTimeZoneData(name);
				if (timeZoneData == null)
				{
					return null;
				}
				return TimeZoneInfo.ParseTZBuffer(id, timeZoneData, timeZoneData.Length);
			}

			// Token: 0x06000DEB RID: 3563 RVA: 0x0003B31C File Offset: 0x0003951C
			internal static TimeZoneInfo GetTimeZone(string id, string name)
			{
				if (name != null)
				{
					if (name == "GMT" || name == "UTC")
					{
						return new TimeZoneInfo(id, TimeSpan.FromSeconds(0.0), id, name, name, null, true);
					}
					if (name.StartsWith("GMT"))
					{
						return new TimeZoneInfo(id, TimeSpan.FromSeconds((double)TimeZoneInfo.AndroidTimeZones.ParseNumericZone(name)), id, name, name, null, true);
					}
				}
				TimeZoneInfo result;
				try
				{
					result = TimeZoneInfo.AndroidTimeZones._GetTimeZone(id, name);
				}
				catch (Exception)
				{
					result = null;
				}
				return result;
			}

			// Token: 0x06000DEC RID: 3564 RVA: 0x0003B3A8 File Offset: 0x000395A8
			private static int ParseNumericZone(string name)
			{
				if (name == null || !name.StartsWith("GMT") || name.Length <= 3)
				{
					return 0;
				}
				int num;
				if (name[3] == '+')
				{
					num = 1;
				}
				else
				{
					if (name[3] != '-')
					{
						return 0;
					}
					num = -1;
				}
				int num2 = 0;
				bool flag = false;
				int i;
				for (i = 4; i < name.Length; i++)
				{
					char c = name[i];
					if (c == ':')
					{
						i++;
						flag = true;
						break;
					}
					if (c < '0' || c > '9')
					{
						return 0;
					}
					num2 = num2 * 10 + (int)c - 48;
				}
				int num3 = 0;
				while (i < name.Length)
				{
					char c2 = name[i];
					if (c2 < '0' || c2 > '9')
					{
						return 0;
					}
					num3 = num3 * 10 + (int)c2 - 48;
					i++;
				}
				if (flag)
				{
					return num * (num2 * 60 + num3) * 60;
				}
				if (num2 >= 100)
				{
					return num * (num2 / 100 * 60 + num2 % 100) * 60;
				}
				return num * (num2 * 60) * 60;
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000DED RID: 3565 RVA: 0x0003B49F File Offset: 0x0003969F
			internal static TimeZoneInfo Local
			{
				get
				{
					string defaultTimeZoneName = TimeZoneInfo.AndroidTimeZones.GetDefaultTimeZoneName();
					return TimeZoneInfo.AndroidTimeZones.GetTimeZone(defaultTimeZoneName, defaultTimeZoneName);
				}
			}

			// Token: 0x06000DEE RID: 3566
			[DllImport("__Internal")]
			private static extern int monodroid_get_system_property(string name, ref IntPtr value);

			// Token: 0x06000DEF RID: 3567
			[DllImport("__Internal")]
			private static extern void monodroid_free(IntPtr ptr);

			// Token: 0x06000DF0 RID: 3568 RVA: 0x0003B4AC File Offset: 0x000396AC
			private static string GetDefaultTimeZoneName()
			{
				IntPtr zero = IntPtr.Zero;
				int num = 0;
				string text = Environment.GetEnvironmentVariable("__XA_OVERRIDE_TIMEZONE_ID__");
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
				if (Environment.GetEnvironmentVariable("__XA_USE_JAVA_DEFAULT_TIMEZONE_ID__") == null)
				{
					num = TimeZoneInfo.AndroidTimeZones.monodroid_get_system_property("persist.sys.timezone", ref zero);
				}
				if (num > 0 && zero != IntPtr.Zero)
				{
					text = (Marshal.PtrToStringAnsi(zero) ?? string.Empty).Trim();
					TimeZoneInfo.AndroidTimeZones.monodroid_free(zero);
					if (!string.IsNullOrEmpty(text))
					{
						return text;
					}
				}
				text = (AndroidPlatform.GetDefaultTimeZone() ?? string.Empty).Trim();
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
				return null;
			}

			// Token: 0x040004F5 RID: 1269
			private static IAndroidTimeZoneDB db = TimeZoneInfo.AndroidTimeZones.GetDefaultTimeZoneDB();
		}
	}
}
