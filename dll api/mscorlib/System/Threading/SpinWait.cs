using System;
using Internal.Runtime.Augments;

namespace System.Threading
{
	/// <summary>Provides support for spin-based waiting.</summary>
	// Token: 0x020001B6 RID: 438
	public struct SpinWait
	{
		/// <summary>Gets the number of times <see cref="M:System.Threading.SpinWait.SpinOnce" /> has been called on this instance.</summary>
		/// <returns>Returns an integer that represents the number of times <see cref="M:System.Threading.SpinWait.SpinOnce" /> has been called on this instance.</returns>
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00044AA0 File Offset: 0x00042CA0
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		/// <summary>Gets whether the next call to <see cref="M:System.Threading.SpinWait.SpinOnce" /> will yield the processor, triggering a forced context switch.</summary>
		/// <returns>Whether the next call to <see cref="M:System.Threading.SpinWait.SpinOnce" /> will yield the processor, triggering a forced context switch.</returns>
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x00044AA8 File Offset: 0x00042CA8
		public bool NextSpinWillYield
		{
			get
			{
				return this._count >= 10 || PlatformHelper.IsSingleProcessor;
			}
		}

		/// <summary>Performs a single spin.</summary>
		// Token: 0x06001093 RID: 4243 RVA: 0x00044ABB File Offset: 0x00042CBB
		public void SpinOnce()
		{
			this.SpinOnceCore(20);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00044AC5 File Offset: 0x00042CC5
		public void SpinOnce(int sleep1Threshold)
		{
			if (sleep1Threshold < -1)
			{
				throw new ArgumentOutOfRangeException("sleep1Threshold", sleep1Threshold, "Number must be either non-negative and less than or equal to Int32.MaxValue or -1.");
			}
			if (sleep1Threshold >= 0 && sleep1Threshold < 10)
			{
				sleep1Threshold = 10;
			}
			this.SpinOnceCore(sleep1Threshold);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00044AF8 File Offset: 0x00042CF8
		private void SpinOnceCore(int sleep1Threshold)
		{
			if ((this._count >= 10 && ((this._count >= sleep1Threshold && sleep1Threshold >= 0) || (this._count - 10) % 2 == 0)) || PlatformHelper.IsSingleProcessor)
			{
				if (this._count >= sleep1Threshold && sleep1Threshold >= 0)
				{
					RuntimeThread.Sleep(1);
				}
				else if (((this._count >= 10) ? ((this._count - 10) / 2) : this._count) % 5 == 4)
				{
					RuntimeThread.Sleep(0);
				}
				else
				{
					RuntimeThread.Yield();
				}
			}
			else
			{
				int num = RuntimeThread.OptimalMaxSpinWaitsPerSpinIteration;
				if (this._count <= 30 && 1 << this._count < num)
				{
					num = 1 << this._count;
				}
				RuntimeThread.SpinWait(num);
			}
			this._count = ((this._count == int.MaxValue) ? 10 : (this._count + 1));
		}

		// Token: 0x04000648 RID: 1608
		internal static readonly int SpinCountforSpinBeforeWait = PlatformHelper.IsSingleProcessor ? 1 : 35;

		// Token: 0x04000649 RID: 1609
		private int _count;
	}
}
