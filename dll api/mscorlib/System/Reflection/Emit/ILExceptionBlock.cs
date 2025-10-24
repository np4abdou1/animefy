using System;

namespace System.Reflection.Emit
{
	// Token: 0x02000501 RID: 1281
	internal struct ILExceptionBlock
	{
		// Token: 0x0400122F RID: 4655
		public const int CATCH = 0;

		// Token: 0x04001230 RID: 4656
		public const int FILTER = 1;

		// Token: 0x04001231 RID: 4657
		public const int FINALLY = 2;

		// Token: 0x04001232 RID: 4658
		public const int FAULT = 4;

		// Token: 0x04001233 RID: 4659
		public const int FILTER_START = -1;

		// Token: 0x04001234 RID: 4660
		internal Type extype;

		// Token: 0x04001235 RID: 4661
		internal int type;

		// Token: 0x04001236 RID: 4662
		internal int start;

		// Token: 0x04001237 RID: 4663
		internal int len;

		// Token: 0x04001238 RID: 4664
		internal int filter_offset;
	}
}
