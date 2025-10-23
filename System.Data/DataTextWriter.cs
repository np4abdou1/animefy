using System;
using System.IO;
using System.Xml;

namespace System.Data
{
	// Token: 0x020000AA RID: 170
	internal sealed class DataTextWriter : XmlWriter
	{
		// Token: 0x060009D0 RID: 2512 RVA: 0x0003B887 File Offset: 0x00039A87
		internal static XmlWriter CreateWriter(XmlWriter xw)
		{
			return new DataTextWriter(xw);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0003B88F File Offset: 0x00039A8F
		private DataTextWriter(XmlWriter w)
		{
			this._xmltextWriter = w;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0003B8A0 File Offset: 0x00039AA0
		internal Stream BaseStream
		{
			get
			{
				XmlTextWriter xmlTextWriter = this._xmltextWriter as XmlTextWriter;
				if (xmlTextWriter != null)
				{
					return xmlTextWriter.BaseStream;
				}
				return null;
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0003B8C4 File Offset: 0x00039AC4
		public override void WriteStartDocument()
		{
			this._xmltextWriter.WriteStartDocument();
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0003B8D1 File Offset: 0x00039AD1
		public override void WriteStartDocument(bool standalone)
		{
			this._xmltextWriter.WriteStartDocument(standalone);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0003B8DF File Offset: 0x00039ADF
		public override void WriteEndDocument()
		{
			this._xmltextWriter.WriteEndDocument();
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0003B8EC File Offset: 0x00039AEC
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			this._xmltextWriter.WriteDocType(name, pubid, sysid, subset);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0003B8FE File Offset: 0x00039AFE
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			this._xmltextWriter.WriteStartElement(prefix, localName, ns);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0003B90E File Offset: 0x00039B0E
		public override void WriteEndElement()
		{
			this._xmltextWriter.WriteEndElement();
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0003B91B File Offset: 0x00039B1B
		public override void WriteFullEndElement()
		{
			this._xmltextWriter.WriteFullEndElement();
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0003B928 File Offset: 0x00039B28
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this._xmltextWriter.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0003B938 File Offset: 0x00039B38
		public override void WriteEndAttribute()
		{
			this._xmltextWriter.WriteEndAttribute();
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0003B945 File Offset: 0x00039B45
		public override void WriteCData(string text)
		{
			this._xmltextWriter.WriteCData(text);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0003B953 File Offset: 0x00039B53
		public override void WriteComment(string text)
		{
			this._xmltextWriter.WriteComment(text);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0003B961 File Offset: 0x00039B61
		public override void WriteProcessingInstruction(string name, string text)
		{
			this._xmltextWriter.WriteProcessingInstruction(name, text);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0003B970 File Offset: 0x00039B70
		public override void WriteEntityRef(string name)
		{
			this._xmltextWriter.WriteEntityRef(name);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0003B97E File Offset: 0x00039B7E
		public override void WriteCharEntity(char ch)
		{
			this._xmltextWriter.WriteCharEntity(ch);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0003B98C File Offset: 0x00039B8C
		public override void WriteWhitespace(string ws)
		{
			this._xmltextWriter.WriteWhitespace(ws);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0003B99A File Offset: 0x00039B9A
		public override void WriteString(string text)
		{
			this._xmltextWriter.WriteString(text);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0003B9A8 File Offset: 0x00039BA8
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this._xmltextWriter.WriteSurrogateCharEntity(lowChar, highChar);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0003B9B7 File Offset: 0x00039BB7
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this._xmltextWriter.WriteChars(buffer, index, count);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0003B9C7 File Offset: 0x00039BC7
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this._xmltextWriter.WriteRaw(buffer, index, count);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0003B9D7 File Offset: 0x00039BD7
		public override void WriteRaw(string data)
		{
			this._xmltextWriter.WriteRaw(data);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0003B9E5 File Offset: 0x00039BE5
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this._xmltextWriter.WriteBase64(buffer, index, count);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0003B9F5 File Offset: 0x00039BF5
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			this._xmltextWriter.WriteBinHex(buffer, index, count);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0003BA05 File Offset: 0x00039C05
		public override WriteState WriteState
		{
			get
			{
				return this._xmltextWriter.WriteState;
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0003BA12 File Offset: 0x00039C12
		public override void Close()
		{
			this._xmltextWriter.Close();
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0003BA1F File Offset: 0x00039C1F
		public override void Flush()
		{
			this._xmltextWriter.Flush();
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0003BA2C File Offset: 0x00039C2C
		public override string LookupPrefix(string ns)
		{
			return this._xmltextWriter.LookupPrefix(ns);
		}

		// Token: 0x04000380 RID: 896
		private XmlWriter _xmltextWriter;
	}
}
