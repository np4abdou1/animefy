using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x02000043 RID: 67
	internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x0000ADBF File Offset: 0x00008FBF
		public TextEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) : base(writer, settings)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000ADC9 File Offset: 0x00008FC9
		public TextEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) : base(stream, settings)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00008574 File Offset: 0x00006774
		internal override void StartElementContent()
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000ADD3 File Offset: 0x00008FD3
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.inAttributeValue = true;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public override void WriteEndAttribute()
		{
			this.inAttributeValue = false;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000A216 File Offset: 0x00008416
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000ADE5 File Offset: 0x00008FE5
		public override void WriteCData(string text)
		{
			base.WriteRaw(text);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteComment(string text)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000ADEE File Offset: 0x00008FEE
		public override void WriteWhitespace(string ws)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(ws);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000ADEE File Offset: 0x00008FEE
		public override void WriteString(string textBlock)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(textBlock);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000ADFF File Offset: 0x00008FFF
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(buffer, index, count);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000ADFF File Offset: 0x00008FFF
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(buffer, index, count);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000ADEE File Offset: 0x00008FEE
		public override void WriteRaw(string data)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(data);
			}
		}
	}
}
