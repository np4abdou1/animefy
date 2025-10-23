using System;

namespace System.Xml
{
	// Token: 0x0200015D RID: 349
	internal class ReaderPositionInfo : PositionInfo
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x0004EC47 File Offset: 0x0004CE47
		public ReaderPositionInfo(IXmlLineInfo lineInfo)
		{
			this.lineInfo = lineInfo;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0004EC56 File Offset: 0x0004CE56
		public override bool HasLineInfo()
		{
			return this.lineInfo.HasLineInfo();
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0004EC63 File Offset: 0x0004CE63
		public override int LineNumber
		{
			get
			{
				return this.lineInfo.LineNumber;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0004EC70 File Offset: 0x0004CE70
		public override int LinePosition
		{
			get
			{
				return this.lineInfo.LinePosition;
			}
		}

		// Token: 0x040008F5 RID: 2293
		private IXmlLineInfo lineInfo;
	}
}
