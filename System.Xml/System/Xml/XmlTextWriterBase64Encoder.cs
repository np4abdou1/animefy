using System;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x0200000D RID: 13
	internal class XmlTextWriterBase64Encoder : Base64Encoder
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002B29 File Offset: 0x00000D29
		internal XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder)
		{
			this.xmlTextEncoder = xmlTextEncoder;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002B38 File Offset: 0x00000D38
		internal override void WriteChars(char[] chars, int index, int count)
		{
			this.xmlTextEncoder.WriteRaw(chars, index, count);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002B48 File Offset: 0x00000D48
		internal override Task WriteCharsAsync(char[] chars, int index, int count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000029 RID: 41
		private XmlTextEncoder xmlTextEncoder;
	}
}
