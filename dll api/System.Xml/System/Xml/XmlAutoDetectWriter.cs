using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x0200004E RID: 78
	internal class XmlAutoDetectWriter : XmlRawWriter
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0000BC0C File Offset: 0x00009E0C
		private XmlAutoDetectWriter(XmlWriterSettings writerSettings)
		{
			this.writerSettings = writerSettings.Clone();
			this.writerSettings.ReadOnly = true;
			this.eventCache = new XmlEventCache(string.Empty, true);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000BC3D File Offset: 0x00009E3D
		public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings) : this(writerSettings)
		{
			this.textWriter = textWriter;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000BC4D File Offset: 0x00009E4D
		public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings) : this(writerSettings)
		{
			this.strm = strm;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000BC5D File Offset: 0x00009E5D
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteDocType(name, pubid, sysid, subset);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000BC76 File Offset: 0x00009E76
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (this.wrapped == null)
			{
				if (ns.Length == 0 && XmlAutoDetectWriter.IsHtmlTag(localName))
				{
					this.CreateWrappedWriter(XmlOutputMethod.Html);
				}
				else
				{
					this.CreateWrappedWriter(XmlOutputMethod.Xml);
				}
			}
			this.wrapped.WriteStartElement(prefix, localName, ns);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000BCAE File Offset: 0x00009EAE
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000BCC5 File Offset: 0x00009EC5
		public override void WriteEndAttribute()
		{
			this.wrapped.WriteEndAttribute();
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000BCD2 File Offset: 0x00009ED2
		public override void WriteCData(string text)
		{
			if (this.TextBlockCreatesWriter(text))
			{
				this.wrapped.WriteCData(text);
				return;
			}
			this.eventCache.WriteCData(text);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000BCF6 File Offset: 0x00009EF6
		public override void WriteComment(string text)
		{
			if (this.wrapped == null)
			{
				this.eventCache.WriteComment(text);
				return;
			}
			this.wrapped.WriteComment(text);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000BD19 File Offset: 0x00009F19
		public override void WriteProcessingInstruction(string name, string text)
		{
			if (this.wrapped == null)
			{
				this.eventCache.WriteProcessingInstruction(name, text);
				return;
			}
			this.wrapped.WriteProcessingInstruction(name, text);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000BD3E File Offset: 0x00009F3E
		public override void WriteWhitespace(string ws)
		{
			if (this.wrapped == null)
			{
				this.eventCache.WriteWhitespace(ws);
				return;
			}
			this.wrapped.WriteWhitespace(ws);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000BD61 File Offset: 0x00009F61
		public override void WriteString(string text)
		{
			if (this.TextBlockCreatesWriter(text))
			{
				this.wrapped.WriteString(text);
				return;
			}
			this.eventCache.WriteString(text);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000BD85 File Offset: 0x00009F85
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.WriteString(new string(buffer, index, count));
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000BD95 File Offset: 0x00009F95
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.WriteRaw(new string(buffer, index, count));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000BDA5 File Offset: 0x00009FA5
		public override void WriteRaw(string data)
		{
			if (this.TextBlockCreatesWriter(data))
			{
				this.wrapped.WriteRaw(data);
				return;
			}
			this.eventCache.WriteRaw(data);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000BDC9 File Offset: 0x00009FC9
		public override void WriteEntityRef(string name)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteEntityRef(name);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000BDDE File Offset: 0x00009FDE
		public override void WriteCharEntity(char ch)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteCharEntity(ch);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000BDF3 File Offset: 0x00009FF3
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteSurrogateCharEntity(lowChar, highChar);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000BE09 File Offset: 0x0000A009
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteBase64(buffer, index, count);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000BE20 File Offset: 0x0000A020
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteBinHex(buffer, index, count);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000BE37 File Offset: 0x0000A037
		public override void Close()
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.Close();
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000BE4B File Offset: 0x0000A04B
		public override void Flush()
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.Flush();
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000BE5F File Offset: 0x0000A05F
		public override void WriteValue(string value)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteValue(value);
		}

		// Token: 0x17000077 RID: 119
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000BE74 File Offset: 0x0000A074
		internal override IXmlNamespaceResolver NamespaceResolver
		{
			set
			{
				this.resolver = value;
				if (this.wrapped == null)
				{
					this.eventCache.NamespaceResolver = value;
					return;
				}
				this.wrapped.NamespaceResolver = value;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000BE9E File Offset: 0x0000A09E
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteXmlDeclaration(standalone);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000BEB3 File Offset: 0x0000A0B3
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteXmlDeclaration(xmldecl);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		internal override void StartElementContent()
		{
			this.wrapped.StartElementContent();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000BED5 File Offset: 0x0000A0D5
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			this.wrapped.WriteEndElement(prefix, localName, ns);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000BEE5 File Offset: 0x0000A0E5
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			this.wrapped.WriteFullEndElement(prefix, localName, ns);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000BEF5 File Offset: 0x0000A0F5
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteNamespaceDeclaration(prefix, ns);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000BF0B File Offset: 0x0000A10B
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				return this.wrapped.SupportsNamespaceDeclarationInChunks;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000BF18 File Offset: 0x0000A118
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			this.EnsureWrappedWriter(XmlOutputMethod.Xml);
			this.wrapped.WriteStartNamespaceDeclaration(prefix);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000BF2D File Offset: 0x0000A12D
		internal override void WriteEndNamespaceDeclaration()
		{
			this.wrapped.WriteEndNamespaceDeclaration();
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000BF3C File Offset: 0x0000A13C
		private static bool IsHtmlTag(string tagName)
		{
			return tagName.Length == 4 && (tagName[0] == 'H' || tagName[0] == 'h') && (tagName[1] == 'T' || tagName[1] == 't') && (tagName[2] == 'M' || tagName[2] == 'm') && (tagName[3] == 'L' || tagName[3] == 'l');
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000BFB5 File Offset: 0x0000A1B5
		private void EnsureWrappedWriter(XmlOutputMethod outMethod)
		{
			if (this.wrapped == null)
			{
				this.CreateWrappedWriter(outMethod);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		private bool TextBlockCreatesWriter(string textBlock)
		{
			if (this.wrapped == null)
			{
				if (XmlCharType.Instance.IsOnlyWhitespace(textBlock))
				{
					return false;
				}
				this.CreateWrappedWriter(XmlOutputMethod.Xml);
			}
			return true;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
		private void CreateWrappedWriter(XmlOutputMethod outMethod)
		{
			this.writerSettings.ReadOnly = false;
			this.writerSettings.OutputMethod = outMethod;
			if (outMethod == XmlOutputMethod.Html && this.writerSettings.IndentInternal == TriState.Unknown)
			{
				this.writerSettings.Indent = true;
			}
			this.writerSettings.ReadOnly = true;
			if (this.textWriter != null)
			{
				this.wrapped = ((XmlWellFormedWriter)XmlWriter.Create(this.textWriter, this.writerSettings)).RawWriter;
			}
			else
			{
				this.wrapped = ((XmlWellFormedWriter)XmlWriter.Create(this.strm, this.writerSettings)).RawWriter;
			}
			this.eventCache.EndEvents();
			this.eventCache.EventsToWriter(this.wrapped);
			if (this.onRemove != null)
			{
				this.onRemove(this.wrapped);
			}
		}

		// Token: 0x0400017C RID: 380
		private XmlRawWriter wrapped;

		// Token: 0x0400017D RID: 381
		private OnRemoveWriter onRemove;

		// Token: 0x0400017E RID: 382
		private XmlWriterSettings writerSettings;

		// Token: 0x0400017F RID: 383
		private XmlEventCache eventCache;

		// Token: 0x04000180 RID: 384
		private TextWriter textWriter;

		// Token: 0x04000181 RID: 385
		private Stream strm;
	}
}
