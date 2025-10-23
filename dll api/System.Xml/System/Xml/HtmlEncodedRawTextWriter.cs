using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Xml
{
	// Token: 0x02000024 RID: 36
	internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00008552 File Offset: 0x00006752
		public HtmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) : base(writer, settings)
		{
			this.Init(settings);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008563 File Offset: 0x00006763
		public HtmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) : base(stream, settings)
		{
			this.Init(settings);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008574 File Offset: 0x00006774
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008578 File Offset: 0x00006778
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				base.ChangeTextContentMark(false);
			}
			base.RawText("<!DOCTYPE ");
			if (name == "HTML")
			{
				base.RawText("HTML");
			}
			else
			{
				base.RawText("html");
			}
			int bufPos;
			if (pubid != null)
			{
				base.RawText(" PUBLIC \"");
				base.RawText(pubid);
				if (sysid != null)
				{
					base.RawText("\" \"");
					base.RawText(sysid);
				}
				char[] bufChars = this.bufChars;
				bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars[bufPos] = 34;
			}
			else if (sysid != null)
			{
				base.RawText(" SYSTEM \"");
				base.RawText(sysid);
				char[] bufChars2 = this.bufChars;
				bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars2[bufPos] = 34;
			}
			else
			{
				char[] bufChars3 = this.bufChars;
				bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars3[bufPos] = 32;
			}
			if (subset != null)
			{
				char[] bufChars4 = this.bufChars;
				bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars4[bufPos] = 91;
				base.RawText(subset);
				char[] bufChars5 = this.bufChars;
				bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars5[bufPos] = 93;
			}
			char[] bufChars6 = this.bufChars;
			bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars6[bufPos] = 62;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000086B8 File Offset: 0x000068B8
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			this.elementScope.Push((byte)this.currentElementProperties);
			if (ns.Length == 0)
			{
				if (this.trackTextContent && this.inTextContent)
				{
					base.ChangeTextContentMark(false);
				}
				this.currentElementProperties = (ElementProperties)HtmlEncodedRawTextWriter.elementPropertySearch.FindCaseInsensitiveString(localName);
				char[] bufChars = this.bufChars;
				int bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars[bufPos] = 60;
				base.RawText(localName);
				this.attrEndPos = this.bufPos;
				return;
			}
			this.currentElementProperties = ElementProperties.HAS_NS;
			base.WriteStartElement(prefix, localName, ns);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000874C File Offset: 0x0000694C
		internal override void StartElementContent()
		{
			char[] bufChars = this.bufChars;
			int bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars[bufPos] = 62;
			this.contentPos = this.bufPos;
			if ((this.currentElementProperties & ElementProperties.HEAD) != ElementProperties.DEFAULT)
			{
				this.WriteMetaElement();
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00008790 File Offset: 0x00006990
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			if (ns.Length == 0)
			{
				if (this.trackTextContent && this.inTextContent)
				{
					base.ChangeTextContentMark(false);
				}
				if ((this.currentElementProperties & ElementProperties.EMPTY) == ElementProperties.DEFAULT)
				{
					char[] bufChars = this.bufChars;
					int bufPos = this.bufPos;
					this.bufPos = bufPos + 1;
					bufChars[bufPos] = 60;
					char[] bufChars2 = this.bufChars;
					bufPos = this.bufPos;
					this.bufPos = bufPos + 1;
					bufChars2[bufPos] = 47;
					base.RawText(localName);
					char[] bufChars3 = this.bufChars;
					bufPos = this.bufPos;
					this.bufPos = bufPos + 1;
					bufChars3[bufPos] = 62;
				}
			}
			else
			{
				base.WriteEndElement(prefix, localName, ns);
			}
			this.currentElementProperties = (ElementProperties)this.elementScope.Pop();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008838 File Offset: 0x00006A38
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			if (ns.Length == 0)
			{
				if (this.trackTextContent && this.inTextContent)
				{
					base.ChangeTextContentMark(false);
				}
				if ((this.currentElementProperties & ElementProperties.EMPTY) == ElementProperties.DEFAULT)
				{
					char[] bufChars = this.bufChars;
					int bufPos = this.bufPos;
					this.bufPos = bufPos + 1;
					bufChars[bufPos] = 60;
					char[] bufChars2 = this.bufChars;
					bufPos = this.bufPos;
					this.bufPos = bufPos + 1;
					bufChars2[bufPos] = 47;
					base.RawText(localName);
					char[] bufChars3 = this.bufChars;
					bufPos = this.bufPos;
					this.bufPos = bufPos + 1;
					bufChars3[bufPos] = 62;
				}
			}
			else
			{
				base.WriteFullEndElement(prefix, localName, ns);
			}
			this.currentElementProperties = (ElementProperties)this.elementScope.Pop();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000088E0 File Offset: 0x00006AE0
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (ns.Length == 0)
			{
				if (this.trackTextContent && this.inTextContent)
				{
					base.ChangeTextContentMark(false);
				}
				int bufPos;
				if (this.attrEndPos == this.bufPos)
				{
					char[] bufChars = this.bufChars;
					bufPos = this.bufPos;
					this.bufPos = bufPos + 1;
					bufChars[bufPos] = 32;
				}
				base.RawText(localName);
				if ((this.currentElementProperties & (ElementProperties)7U) != ElementProperties.DEFAULT)
				{
					this.currentAttributeProperties = (AttributeProperties)((ElementProperties)HtmlEncodedRawTextWriter.attributePropertySearch.FindCaseInsensitiveString(localName) & this.currentElementProperties);
					if ((this.currentAttributeProperties & AttributeProperties.BOOLEAN) != AttributeProperties.DEFAULT)
					{
						this.inAttributeValue = true;
						return;
					}
				}
				else
				{
					this.currentAttributeProperties = AttributeProperties.DEFAULT;
				}
				char[] bufChars2 = this.bufChars;
				bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars2[bufPos] = 61;
				char[] bufChars3 = this.bufChars;
				bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars3[bufPos] = 34;
			}
			else
			{
				base.WriteStartAttribute(prefix, localName, ns);
				this.currentAttributeProperties = AttributeProperties.DEFAULT;
			}
			this.inAttributeValue = true;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000089C8 File Offset: 0x00006BC8
		public override void WriteEndAttribute()
		{
			if ((this.currentAttributeProperties & AttributeProperties.BOOLEAN) != AttributeProperties.DEFAULT)
			{
				this.attrEndPos = this.bufPos;
			}
			else
			{
				if (this.endsWithAmpersand)
				{
					this.OutputRestAmps();
					this.endsWithAmpersand = false;
				}
				if (this.trackTextContent && this.inTextContent)
				{
					base.ChangeTextContentMark(false);
				}
				char[] bufChars = this.bufChars;
				int bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufChars[bufPos] = 34;
			}
			this.inAttributeValue = false;
			this.attrEndPos = this.bufPos;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008A48 File Offset: 0x00006C48
		public override void WriteProcessingInstruction(string target, string text)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				base.ChangeTextContentMark(false);
			}
			char[] bufChars = this.bufChars;
			int bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars[bufPos] = 60;
			char[] bufChars2 = this.bufChars;
			bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars2[bufPos] = 63;
			base.RawText(target);
			char[] bufChars3 = this.bufChars;
			bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars3[bufPos] = 32;
			base.WriteCommentOrPi(text, 63);
			char[] bufChars4 = this.bufChars;
			bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars4[bufPos] = 62;
			if (this.bufPos > this.bufLen)
			{
				this.FlushBuffer();
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008AF8 File Offset: 0x00006CF8
		public unsafe override void WriteString(string text)
		{
			if (this.trackTextContent && !this.inTextContent)
			{
				base.ChangeTextContentMark(true);
			}
			fixed (string text2 = text)
			{
				char* ptr = text2;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				char* pSrcEnd = ptr + text.Length;
				if (this.inAttributeValue)
				{
					this.WriteHtmlAttributeTextBlock(ptr, pSrcEnd);
				}
				else
				{
					this.WriteHtmlElementTextBlock(ptr, pSrcEnd);
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteEntityRef(string name)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteCharEntity(char ch)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00008B68 File Offset: 0x00006D68
		public unsafe override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.trackTextContent && !this.inTextContent)
			{
				base.ChangeTextContentMark(true);
			}
			fixed (char* ptr = &buffer[index])
			{
				char* ptr2 = ptr;
				if (this.inAttributeValue)
				{
					base.WriteAttributeTextBlock(ptr2, ptr2 + count);
				}
				else
				{
					base.WriteElementTextBlock(ptr2, ptr2 + count);
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00008BC0 File Offset: 0x00006DC0
		private void Init(XmlWriterSettings settings)
		{
			if (HtmlEncodedRawTextWriter.elementPropertySearch == null)
			{
				HtmlEncodedRawTextWriter.attributePropertySearch = new TernaryTreeReadOnly(HtmlTernaryTree.htmlAttributes);
				HtmlEncodedRawTextWriter.elementPropertySearch = new TernaryTreeReadOnly(HtmlTernaryTree.htmlElements);
			}
			this.elementScope = new ByteStack(10);
			this.uriEscapingBuffer = new byte[5];
			this.currentElementProperties = ElementProperties.DEFAULT;
			this.mediaType = settings.MediaType;
			this.doNotEscapeUriAttributes = settings.DoNotEscapeUriAttributes;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00008C2C File Offset: 0x00006E2C
		protected void WriteMetaElement()
		{
			base.RawText("<META http-equiv=\"Content-Type\"");
			if (this.mediaType == null)
			{
				this.mediaType = "text/html";
			}
			base.RawText(" content=\"");
			base.RawText(this.mediaType);
			base.RawText("; charset=");
			base.RawText(this.encoding.WebName);
			base.RawText("\">");
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00008C95 File Offset: 0x00006E95
		protected unsafe void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			if ((this.currentElementProperties & ElementProperties.NO_ENTITIES) != ElementProperties.DEFAULT)
			{
				base.RawText(pSrc, pSrcEnd);
				return;
			}
			base.WriteElementTextBlock(pSrc, pSrcEnd);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008CB4 File Offset: 0x00006EB4
		protected unsafe void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			if ((this.currentAttributeProperties & (AttributeProperties)7U) != AttributeProperties.DEFAULT)
			{
				if ((this.currentAttributeProperties & AttributeProperties.BOOLEAN) != AttributeProperties.DEFAULT)
				{
					return;
				}
				if ((this.currentAttributeProperties & (AttributeProperties)5U) != AttributeProperties.DEFAULT && !this.doNotEscapeUriAttributes)
				{
					this.WriteUriAttributeText(pSrc, pSrcEnd);
					return;
				}
				this.WriteHtmlAttributeText(pSrc, pSrcEnd);
				return;
			}
			else
			{
				if ((this.currentElementProperties & ElementProperties.HAS_NS) != ElementProperties.DEFAULT)
				{
					base.WriteAttributeTextBlock(pSrc, pSrcEnd);
					return;
				}
				this.WriteHtmlAttributeText(pSrc, pSrcEnd);
				return;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008D1C File Offset: 0x00006F1C
		private unsafe void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd)
		{
			if (this.endsWithAmpersand)
			{
				if ((long)(pSrcEnd - pSrc) > 0L && *pSrc != '{')
				{
					this.OutputRestAmps();
				}
				this.endsWithAmpersand = false;
			}
			char[] array;
			char* ptr;
			if ((array = this.bufChars) == null || array.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array[0];
			}
			char* ptr2 = ptr + this.bufPos;
			char c = '\0';
			for (;;)
			{
				char* ptr3 = ptr2 + (long)(pSrcEnd - pSrc) * 2L / 2L;
				if (ptr3 != ptr + this.bufLen)
				{
					ptr3 = ptr + this.bufLen;
				}
				while (ptr2 < ptr3 && (this.xmlCharType.charProperties[(int)(c = *pSrc)] & 128) != 0)
				{
					*(ptr2++) = c;
					pSrc++;
				}
				if (pSrc >= pSrcEnd)
				{
					break;
				}
				if (ptr2 < ptr3)
				{
					if (c <= '&')
					{
						switch (c)
						{
						case '\t':
							goto IL_13B;
						case '\n':
							ptr2 = XmlEncodedRawTextWriter.LineFeedEntity(ptr2);
							goto IL_166;
						case '\v':
						case '\f':
							break;
						case '\r':
							ptr2 = XmlEncodedRawTextWriter.CarriageReturnEntity(ptr2);
							goto IL_166;
						default:
							if (c == '"')
							{
								ptr2 = XmlEncodedRawTextWriter.QuoteEntity(ptr2);
								goto IL_166;
							}
							if (c == '&')
							{
								if (pSrc + 1 == pSrcEnd)
								{
									this.endsWithAmpersand = true;
								}
								else if (pSrc[1] != '{')
								{
									ptr2 = XmlEncodedRawTextWriter.AmpEntity(ptr2);
									goto IL_166;
								}
								*(ptr2++) = c;
								goto IL_166;
							}
							break;
						}
					}
					else if (c == '\'' || c == '<' || c == '>')
					{
						goto IL_13B;
					}
					base.EncodeChar(ref pSrc, pSrcEnd, ref ptr2);
					continue;
					IL_166:
					pSrc++;
					continue;
					IL_13B:
					*(ptr2++) = c;
					goto IL_166;
				}
				this.bufPos = (int)((long)(ptr2 - ptr));
				this.FlushBuffer();
				ptr2 = ptr + 1;
			}
			this.bufPos = (int)((long)(ptr2 - ptr));
			array = null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008EA8 File Offset: 0x000070A8
		private unsafe void WriteUriAttributeText(char* pSrc, char* pSrcEnd)
		{
			if (this.endsWithAmpersand)
			{
				if ((long)(pSrcEnd - pSrc) > 0L && *pSrc != '{')
				{
					this.OutputRestAmps();
				}
				this.endsWithAmpersand = false;
			}
			char[] array;
			char* ptr;
			if ((array = this.bufChars) == null || array.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array[0];
			}
			char* ptr2 = ptr + this.bufPos;
			char c = '\0';
			for (;;)
			{
				char* ptr3 = ptr2 + (long)(pSrcEnd - pSrc) * 2L / 2L;
				if (ptr3 != ptr + this.bufLen)
				{
					ptr3 = ptr + this.bufLen;
				}
				while (ptr2 < ptr3 && (this.xmlCharType.charProperties[(int)(c = *pSrc)] & 128) != 0 && c < '\u0080')
				{
					*(ptr2++) = c;
					pSrc++;
				}
				if (pSrc >= pSrcEnd)
				{
					break;
				}
				if (ptr2 < ptr3)
				{
					if (c <= '&')
					{
						switch (c)
						{
						case '\t':
							goto IL_14F;
						case '\n':
							ptr2 = XmlEncodedRawTextWriter.LineFeedEntity(ptr2);
							goto IL_1ED;
						case '\v':
						case '\f':
							break;
						case '\r':
							ptr2 = XmlEncodedRawTextWriter.CarriageReturnEntity(ptr2);
							goto IL_1ED;
						default:
							if (c == '"')
							{
								ptr2 = XmlEncodedRawTextWriter.QuoteEntity(ptr2);
								goto IL_1ED;
							}
							if (c == '&')
							{
								if (pSrc + 1 == pSrcEnd)
								{
									this.endsWithAmpersand = true;
								}
								else if (pSrc[1] != '{')
								{
									ptr2 = XmlEncodedRawTextWriter.AmpEntity(ptr2);
									goto IL_1ED;
								}
								*(ptr2++) = c;
								goto IL_1ED;
							}
							break;
						}
					}
					else if (c == '\'' || c == '<' || c == '>')
					{
						goto IL_14F;
					}
					byte[] array2;
					byte* ptr4;
					if ((array2 = this.uriEscapingBuffer) == null || array2.Length == 0)
					{
						ptr4 = null;
					}
					else
					{
						ptr4 = &array2[0];
					}
					byte* ptr5 = ptr4;
					byte* ptr6 = ptr5;
					XmlUtf8RawTextWriter.CharToUTF8(ref pSrc, pSrcEnd, ref ptr6);
					while (ptr5 < ptr6)
					{
						*(ptr2++) = '%';
						*(ptr2++) = "0123456789ABCDEF"[*ptr5 >> 4];
						*(ptr2++) = "0123456789ABCDEF"[(int)(*ptr5 & 15)];
						ptr5++;
					}
					array2 = null;
					continue;
					IL_1ED:
					pSrc++;
					continue;
					IL_14F:
					*(ptr2++) = c;
					goto IL_1ED;
				}
				this.bufPos = (int)((long)(ptr2 - ptr));
				this.FlushBuffer();
				ptr2 = ptr + 1;
			}
			this.bufPos = (int)((long)(ptr2 - ptr));
			array = null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000090BC File Offset: 0x000072BC
		private void OutputRestAmps()
		{
			char[] bufChars = this.bufChars;
			int bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars[bufPos] = 97;
			char[] bufChars2 = this.bufChars;
			bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars2[bufPos] = 109;
			char[] bufChars3 = this.bufChars;
			bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars3[bufPos] = 112;
			char[] bufChars4 = this.bufChars;
			bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufChars4[bufPos] = 59;
		}

		// Token: 0x04000107 RID: 263
		protected ByteStack elementScope;

		// Token: 0x04000108 RID: 264
		protected ElementProperties currentElementProperties;

		// Token: 0x04000109 RID: 265
		private AttributeProperties currentAttributeProperties;

		// Token: 0x0400010A RID: 266
		private bool endsWithAmpersand;

		// Token: 0x0400010B RID: 267
		private byte[] uriEscapingBuffer;

		// Token: 0x0400010C RID: 268
		private string mediaType;

		// Token: 0x0400010D RID: 269
		private bool doNotEscapeUriAttributes;

		// Token: 0x0400010E RID: 270
		protected static TernaryTreeReadOnly elementPropertySearch;

		// Token: 0x0400010F RID: 271
		protected static TernaryTreeReadOnly attributePropertySearch;
	}
}
