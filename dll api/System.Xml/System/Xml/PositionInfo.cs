using System;

namespace System.Xml
{
	// Token: 0x0200015C RID: 348
	internal class PositionInfo : IXmlLineInfo
	{
		// Token: 0x06000CF4 RID: 3316 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool HasLineInfo()
		{
			return false;
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual int LineNumber
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual int LinePosition
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0004EC24 File Offset: 0x0004CE24
		public static PositionInfo GetPositionInfo(object o)
		{
			IXmlLineInfo xmlLineInfo = o as IXmlLineInfo;
			if (xmlLineInfo != null)
			{
				return new ReaderPositionInfo(xmlLineInfo);
			}
			return new PositionInfo();
		}
	}
}
