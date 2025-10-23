using System;
using System.Threading;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000660 RID: 1632
	internal sealed class RuntimeThread
	{
		// Token: 0x0600311C RID: 12572 RVA: 0x000C5B2B File Offset: 0x000C3D2B
		private RuntimeThread(Thread t)
		{
			this.thread = t;
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x000C5B3A File Offset: 0x000C3D3A
		public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize)
		{
			return new RuntimeThread(new Thread(start, maxStackSize));
		}

		// Token: 0x170007E8 RID: 2024
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x000C5B48 File Offset: 0x000C3D48
		public bool IsBackground
		{
			set
			{
				this.thread.IsBackground = value;
			}
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x000C5B56 File Offset: 0x000C3D56
		public void Start(object state)
		{
			this.thread.Start(state);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000C5B64 File Offset: 0x000C3D64
		public static void Sleep(int millisecondsTimeout)
		{
			Thread.Sleep(millisecondsTimeout);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000C5B6C File Offset: 0x000C3D6C
		public static bool Yield()
		{
			return Thread.Yield();
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000C5B73 File Offset: 0x000C3D73
		public static bool SpinWait(int iterations)
		{
			Thread.SpinWait(iterations);
			return true;
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x0000B18D File Offset: 0x0000938D
		public static int GetCurrentProcessorId()
		{
			return 1;
		}

		// Token: 0x0400196E RID: 6510
		internal static readonly int OptimalMaxSpinWaitsPerSpinIteration = 64;

		// Token: 0x0400196F RID: 6511
		private readonly Thread thread;
	}
}
