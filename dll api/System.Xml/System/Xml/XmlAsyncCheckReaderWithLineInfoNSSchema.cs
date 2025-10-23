using System;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x0200004C RID: 76
	internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo
	{
		// Token: 0x06000263 RID: 611 RVA: 0x0000B5C1 File Offset: 0x000097C1
		public XmlAsyncCheckReaderWithLineInfoNSSchema(XmlReader reader) : base(reader)
		{
			this.readerAsIXmlSchemaInfo = (IXmlSchemaInfo)reader;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000B5D6 File Offset: 0x000097D6
		XmlSchemaValidity IXmlSchemaInfo.Validity
		{
			get
			{
				return this.readerAsIXmlSchemaInfo.Validity;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000B5E3 File Offset: 0x000097E3
		bool IXmlSchemaInfo.IsDefault
		{
			get
			{
				return this.readerAsIXmlSchemaInfo.IsDefault;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000B5F0 File Offset: 0x000097F0
		bool IXmlSchemaInfo.IsNil
		{
			get
			{
				return this.readerAsIXmlSchemaInfo.IsNil;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000B5FD File Offset: 0x000097FD
		XmlSchemaSimpleType IXmlSchemaInfo.MemberType
		{
			get
			{
				return this.readerAsIXmlSchemaInfo.MemberType;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000B60A File Offset: 0x0000980A
		XmlSchemaType IXmlSchemaInfo.SchemaType
		{
			get
			{
				return this.readerAsIXmlSchemaInfo.SchemaType;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000B617 File Offset: 0x00009817
		XmlSchemaElement IXmlSchemaInfo.SchemaElement
		{
			get
			{
				return this.readerAsIXmlSchemaInfo.SchemaElement;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000B624 File Offset: 0x00009824
		XmlSchemaAttribute IXmlSchemaInfo.SchemaAttribute
		{
			get
			{
				return this.readerAsIXmlSchemaInfo.SchemaAttribute;
			}
		}

		// Token: 0x04000179 RID: 377
		private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo;
	}
}
