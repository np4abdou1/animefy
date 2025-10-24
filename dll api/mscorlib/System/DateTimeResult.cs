using System;
using System.Globalization;

namespace System
{
	// Token: 0x020000AF RID: 175
	internal ref struct DateTimeResult
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x0001A518 File Offset: 0x00018718
		internal void Init(ReadOnlySpan<char> originalDateTimeString)
		{
			this.originalDateTimeString = originalDateTimeString;
			this.Year = -1;
			this.Month = -1;
			this.Day = -1;
			this.fraction = -1.0;
			this.era = -1;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0001A54C File Offset: 0x0001874C
		internal void SetDate(int year, int month, int day)
		{
			this.Year = year;
			this.Month = month;
			this.Day = day;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0001A563 File Offset: 0x00018763
		internal void SetBadFormatSpecifierFailure()
		{
			this.SetBadFormatSpecifierFailure(ReadOnlySpan<char>.Empty);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001A570 File Offset: 0x00018770
		internal void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier)
		{
			this.failure = ParseFailureKind.FormatWithFormatSpecifier;
			this.failureMessageID = "Format specifier was invalid.";
			this.failedFormatSpecifier = failedFormatSpecifier;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001A58B File Offset: 0x0001878B
		internal void SetBadDateTimeFailure()
		{
			this.failure = ParseFailureKind.FormatWithOriginalDateTime;
			this.failureMessageID = "String was not recognized as a valid DateTime.";
			this.failureMessageFormatArgument = null;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001A5A6 File Offset: 0x000187A6
		internal void SetFailure(ParseFailureKind failure, string failureMessageID)
		{
			this.failure = failure;
			this.failureMessageID = failureMessageID;
			this.failureMessageFormatArgument = null;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001A5BD File Offset: 0x000187BD
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
			this.failure = failure;
			this.failureMessageID = failureMessageID;
			this.failureMessageFormatArgument = failureMessageFormatArgument;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001A5D4 File Offset: 0x000187D4
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName)
		{
			this.failure = failure;
			this.failureMessageID = failureMessageID;
			this.failureMessageFormatArgument = failureMessageFormatArgument;
			this.failureArgumentName = failureArgumentName;
		}

		// Token: 0x040002A8 RID: 680
		internal int Year;

		// Token: 0x040002A9 RID: 681
		internal int Month;

		// Token: 0x040002AA RID: 682
		internal int Day;

		// Token: 0x040002AB RID: 683
		internal int Hour;

		// Token: 0x040002AC RID: 684
		internal int Minute;

		// Token: 0x040002AD RID: 685
		internal int Second;

		// Token: 0x040002AE RID: 686
		internal double fraction;

		// Token: 0x040002AF RID: 687
		internal int era;

		// Token: 0x040002B0 RID: 688
		internal ParseFlags flags;

		// Token: 0x040002B1 RID: 689
		internal TimeSpan timeZoneOffset;

		// Token: 0x040002B2 RID: 690
		internal Calendar calendar;

		// Token: 0x040002B3 RID: 691
		internal DateTime parsedDate;

		// Token: 0x040002B4 RID: 692
		internal ParseFailureKind failure;

		// Token: 0x040002B5 RID: 693
		internal string failureMessageID;

		// Token: 0x040002B6 RID: 694
		internal object failureMessageFormatArgument;

		// Token: 0x040002B7 RID: 695
		internal string failureArgumentName;

		// Token: 0x040002B8 RID: 696
		internal ReadOnlySpan<char> originalDateTimeString;

		// Token: 0x040002B9 RID: 697
		internal ReadOnlySpan<char> failedFormatSpecifier;
	}
}
