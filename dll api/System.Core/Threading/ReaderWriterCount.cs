using System;

namespace System.Threading
{
	// Token: 0x02000151 RID: 337
	internal class ReaderWriterCount
	{
		// Token: 0x0400032F RID: 815
		public long lockID;

		// Token: 0x04000330 RID: 816
		public int readercount;

		// Token: 0x04000331 RID: 817
		public int writercount;

		// Token: 0x04000332 RID: 818
		public int upgradecount;

		// Token: 0x04000333 RID: 819
		public ReaderWriterCount next;
	}
}
