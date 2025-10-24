using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	/// <summary>Provides a set of methods and properties that you can use to accurately measure elapsed time.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020000D4 RID: 212
	public class Stopwatch
	{
		/// <summary>Gets the current number of ticks in the timer mechanism.</summary>
		/// <returns>A long integer representing the tick counter value of the underlying timer mechanism.</returns>
		// Token: 0x06000616 RID: 1558
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTimestamp();

		/// <summary>Gets the total elapsed time measured by the current instance.</summary>
		/// <returns>A read-only <see cref="T:System.TimeSpan" /> representing the total elapsed time measured by the current instance.</returns>
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0002535B File Offset: 0x0002355B
		public TimeSpan Elapsed
		{
			get
			{
				if (Stopwatch.IsHighResolution)
				{
					return TimeSpan.FromTicks(this.ElapsedTicks / (Stopwatch.Frequency / 10000000L));
				}
				return TimeSpan.FromTicks(this.ElapsedTicks);
			}
		}

		/// <summary>Gets the total elapsed time measured by the current instance, in milliseconds.</summary>
		/// <returns>A read-only long integer representing the total number of milliseconds measured by the current instance.</returns>
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00025388 File Offset: 0x00023588
		public long ElapsedMilliseconds
		{
			get
			{
				if (Stopwatch.IsHighResolution)
				{
					return this.ElapsedTicks / (Stopwatch.Frequency / 1000L);
				}
				return checked((long)this.Elapsed.TotalMilliseconds);
			}
		}

		/// <summary>Gets the total elapsed time measured by the current instance, in timer ticks.</summary>
		/// <returns>A read-only long integer representing the total number of timer ticks measured by the current instance.</returns>
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x000253BF File Offset: 0x000235BF
		public long ElapsedTicks
		{
			get
			{
				if (!this.is_running)
				{
					return this.elapsed;
				}
				return Stopwatch.GetTimestamp() - this.started + this.elapsed;
			}
		}

		/// <summary>Stops time interval measurement and resets the elapsed time to zero.</summary>
		// Token: 0x0600061B RID: 1563 RVA: 0x000253E3 File Offset: 0x000235E3
		public void Reset()
		{
			this.elapsed = 0L;
			this.is_running = false;
		}

		/// <summary>Starts, or resumes, measuring elapsed time for an interval.</summary>
		// Token: 0x0600061C RID: 1564 RVA: 0x000253F4 File Offset: 0x000235F4
		public void Start()
		{
			if (this.is_running)
			{
				return;
			}
			this.started = Stopwatch.GetTimestamp();
			this.is_running = true;
		}

		/// <summary>Stops measuring elapsed time for an interval.</summary>
		// Token: 0x0600061D RID: 1565 RVA: 0x00025411 File Offset: 0x00023611
		public void Stop()
		{
			if (!this.is_running)
			{
				return;
			}
			this.elapsed += Stopwatch.GetTimestamp() - this.started;
			if (this.elapsed < 0L)
			{
				this.elapsed = 0L;
			}
			this.is_running = false;
		}

		/// <summary>Gets the frequency of the timer as the number of ticks per second. This field is read-only.</summary>
		// Token: 0x0400040B RID: 1035
		public static readonly long Frequency = 10000000L;

		/// <summary>Indicates whether the timer is based on a high-resolution performance counter. This field is read-only.</summary>
		// Token: 0x0400040C RID: 1036
		public static readonly bool IsHighResolution = true;

		// Token: 0x0400040D RID: 1037
		private long elapsed;

		// Token: 0x0400040E RID: 1038
		private long started;

		// Token: 0x0400040F RID: 1039
		private bool is_running;
	}
}
