using System;

namespace System.Data.SqlTypes
{
	// Token: 0x020000AC RID: 172
	internal static class SQLResource
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0003BC1F File Offset: 0x00039E1F
		internal static string NullString
		{
			get
			{
				return "Null";
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0003BC26 File Offset: 0x00039E26
		internal static string ArithOverflowMessage
		{
			get
			{
				return "Arithmetic Overflow.";
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0003BC2D File Offset: 0x00039E2D
		internal static string DivideByZeroMessage
		{
			get
			{
				return "Divide by zero error encountered.";
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0003BC34 File Offset: 0x00039E34
		internal static string NullValueMessage
		{
			get
			{
				return "Data is Null. This method or property cannot be called on Null values.";
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0003BC3B File Offset: 0x00039E3B
		internal static string TruncationMessage
		{
			get
			{
				return "Numeric arithmetic causes truncation.";
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0003BC42 File Offset: 0x00039E42
		internal static string DateTimeOverflowMessage
		{
			get
			{
				return "SqlDateTime overflow. Must be between 1/1/1753 12:00:00 AM and 12/31/9999 11:59:59 PM.";
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0003BC49 File Offset: 0x00039E49
		internal static string ConcatDiffCollationMessage
		{
			get
			{
				return "Two strings to be concatenated have different collation.";
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0003BC50 File Offset: 0x00039E50
		internal static string CompareDiffCollationMessage
		{
			get
			{
				return "Two strings to be compared have different collation.";
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0003BC57 File Offset: 0x00039E57
		internal static string ConversionOverflowMessage
		{
			get
			{
				return "Conversion overflows.";
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0003BC5E File Offset: 0x00039E5E
		internal static string InvalidDateTimeMessage
		{
			get
			{
				return "Invalid SqlDateTime.";
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0003BC65 File Offset: 0x00039E65
		internal static string TimeZoneSpecifiedMessage
		{
			get
			{
				return "A time zone was specified. SqlDateTime does not support time zones.";
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0003BC6C File Offset: 0x00039E6C
		internal static string InvalidArraySizeMessage
		{
			get
			{
				return "Invalid array size.";
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0003BC73 File Offset: 0x00039E73
		internal static string InvalidPrecScaleMessage
		{
			get
			{
				return "Invalid numeric precision/scale.";
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0003BC7A File Offset: 0x00039E7A
		internal static string FormatMessage
		{
			get
			{
				return "The input wasn't in a correct format.";
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0003BC81 File Offset: 0x00039E81
		internal static string ClosedXmlReaderMessage
		{
			get
			{
				return "Invalid attempt to access a closed XmlReader.";
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0003BC88 File Offset: 0x00039E88
		internal static string InvalidOpStreamClosed(string method)
		{
			return SR.Format("Invalid attempt to call {0} when the stream is closed.", method);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0003BC95 File Offset: 0x00039E95
		internal static string InvalidOpStreamNonWritable(string method)
		{
			return SR.Format("Invalid attempt to call {0} when the stream non-writable.", method);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0003BCA2 File Offset: 0x00039EA2
		internal static string InvalidOpStreamNonReadable(string method)
		{
			return SR.Format("Invalid attempt to call {0} when the stream non-readable.", method);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0003BCAF File Offset: 0x00039EAF
		internal static string InvalidOpStreamNonSeekable(string method)
		{
			return SR.Format("Invalid attempt to call {0} when the stream is non-seekable.", method);
		}
	}
}
