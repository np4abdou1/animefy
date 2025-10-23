using System;

namespace Mono.Xml
{
	// Token: 0x0200002E RID: 46
	internal class SmallXmlParserException : SystemException
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000036BF File Offset: 0x000018BF
		public SmallXmlParserException(string msg, int line, int column) : base(string.Format("{0}. At ({1},{2})", msg, line, column))
		{
			this.line = line;
			this.column = column;
		}

		// Token: 0x040000CC RID: 204
		private int line;

		// Token: 0x040000CD RID: 205
		private int column;
	}
}
