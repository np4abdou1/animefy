using System;

namespace System.Xml
{
	// Token: 0x0200004A RID: 74
	internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo
	{
		// Token: 0x0600025B RID: 603 RVA: 0x0000B546 File Offset: 0x00009746
		public XmlAsyncCheckReaderWithLineInfo(XmlReader reader) : base(reader)
		{
			this.readerAsIXmlLineInfo = (IXmlLineInfo)reader;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000B55B File Offset: 0x0000975B
		public virtual bool HasLineInfo()
		{
			return this.readerAsIXmlLineInfo.HasLineInfo();
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000B568 File Offset: 0x00009768
		public virtual int LineNumber
		{
			get
			{
				return this.readerAsIXmlLineInfo.LineNumber;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000B575 File Offset: 0x00009775
		public virtual int LinePosition
		{
			get
			{
				return this.readerAsIXmlLineInfo.LinePosition;
			}
		}

		// Token: 0x04000177 RID: 375
		private readonly IXmlLineInfo readerAsIXmlLineInfo;
	}
}
