using System;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x0200000C RID: 12
	internal class XmlRawWriterBase64Encoder : Base64Encoder
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002AFA File Offset: 0x00000CFA
		internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter)
		{
			this.rawWriter = rawWriter;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002B09 File Offset: 0x00000D09
		internal override void WriteChars(char[] chars, int index, int count)
		{
			this.rawWriter.WriteRaw(chars, index, count);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002B19 File Offset: 0x00000D19
		internal override Task WriteCharsAsync(char[] chars, int index, int count)
		{
			return this.rawWriter.WriteRawAsync(chars, index, count);
		}

		// Token: 0x04000028 RID: 40
		private XmlRawWriter rawWriter;
	}
}
