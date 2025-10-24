using System;

namespace System.Globalization
{
	/// <summary>Defines the formatting options that customize string parsing for the <see cref="Overload:System.TimeSpan.ParseExact" /> and <see cref="Overload:System.TimeSpan.TryParseExact" /> methods.</summary>
	// Token: 0x02000598 RID: 1432
	[Flags]
	public enum TimeSpanStyles
	{
		/// <summary>Indicates that input is interpreted as a negative time interval only if a negative sign is present.</summary>
		// Token: 0x040016F7 RID: 5879
		None = 0,
		/// <summary>Indicates that input is always interpreted as a negative time interval.</summary>
		// Token: 0x040016F8 RID: 5880
		AssumeNegative = 1
	}
}
