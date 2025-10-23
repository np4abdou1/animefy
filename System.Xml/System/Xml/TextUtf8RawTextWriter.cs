using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x02000044 RID: 68
	internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
	{
		// Token: 0x060001EF RID: 495 RVA: 0x0000AE12 File Offset: 0x00009012
		public TextUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) : base(stream, settings)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00008574 File Offset: 0x00006774
		internal override void StartElementContent()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000AE1C File Offset: 0x0000901C
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.inAttributeValue = true;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000AE25 File Offset: 0x00009025
		public override void WriteEndAttribute()
		{
			this.inAttributeValue = false;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000A216 File Offset: 0x00008416
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000AE2E File Offset: 0x0000902E
		public override void WriteCData(string text)
		{
			base.WriteRaw(text);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteComment(string text)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000AE37 File Offset: 0x00009037
		public override void WriteWhitespace(string ws)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(ws);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000AE37 File Offset: 0x00009037
		public override void WriteString(string textBlock)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(textBlock);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000AE48 File Offset: 0x00009048
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(buffer, index, count);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000AE48 File Offset: 0x00009048
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(buffer, index, count);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000AE37 File Offset: 0x00009037
		public override void WriteRaw(string data)
		{
			if (!this.inAttributeValue)
			{
				base.WriteRaw(data);
			}
		}
	}
}
