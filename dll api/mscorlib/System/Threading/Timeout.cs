using System;

namespace System.Threading
{
	/// <summary>Contains constants that specify infinite time-out intervals. This class cannot be inherited.</summary>
	// Token: 0x020001B1 RID: 433
	public static class Timeout
	{
		/// <summary>A constant used to specify an infinite waiting period, for methods that accept a <see cref="T:System.TimeSpan" /> parameter.</summary>
		// Token: 0x04000640 RID: 1600
		public static readonly TimeSpan InfiniteTimeSpan = new TimeSpan(0, 0, 0, 0, -1);
	}
}
