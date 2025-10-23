using System;

namespace System.Xml
{
	// Token: 0x0200015F RID: 351
	internal struct LineInfo
	{
		// Token: 0x06000D00 RID: 3328 RVA: 0x0004EC7D File Offset: 0x0004CE7D
		public LineInfo(int lineNo, int linePos)
		{
			this.lineNo = lineNo;
			this.linePos = linePos;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0004EC7D File Offset: 0x0004CE7D
		public void Set(int lineNo, int linePos)
		{
			this.lineNo = lineNo;
			this.linePos = linePos;
		}

		// Token: 0x040008F6 RID: 2294
		internal int lineNo;

		// Token: 0x040008F7 RID: 2295
		internal int linePos;
	}
}
