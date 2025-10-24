using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x0200004F RID: 79
	internal class XmlEncodedRawTextWriter : XmlRawWriter
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		protected XmlEncodedRawTextWriter(XmlWriterSettings settings)
		{
			this.useAsync = settings.Async;
			this.newLineHandling = settings.NewLineHandling;
			this.omitXmlDeclaration = settings.OmitXmlDeclaration;
			this.newLineChars = settings.NewLineChars;
			this.checkCharacters = settings.CheckCharacters;
			this.closeOutput = settings.CloseOutput;
			this.standalone = settings.Standalone;
			this.outputMethod = settings.OutputMethod;
			this.mergeCDataSections = settings.MergeCDataSections;
			if (this.checkCharacters && this.newLineHandling == NewLineHandling.Replace)
			{
				this.ValidateContentChars(this.newLineChars, "NewLineChars", false);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000C190 File Offset: 0x0000A390
		public XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) : this(settings)
		{
			this.writer = writer;
			this.encoding = writer.Encoding;
			if (settings.Async)
			{
				this.bufLen = 65536;
			}
			this.bufChars = new char[this.bufLen + 32];
			if (settings.AutoXmlDeclaration)
			{
				this.WriteXmlDeclaration(this.standalone);
				this.autoXmlDeclaration = true;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		public XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) : this(settings)
		{
			this.stream = stream;
			this.encoding = settings.Encoding;
			if (settings.Async)
			{
				this.bufLen = 65536;
			}
			this.bufChars = new char[this.bufLen + 32];
			this.bufBytes = new byte[this.bufChars.Length];
			this.bufBytesUsed = 0;
			this.trackTextContent = true;
			this.inTextContent = false;
			this.lastMarkPos = 0;
			this.textContentMarks = new int[64];
			this.textContentMarks[0] = 1;
			this.charEntityFallback = new CharEntityEncoderFallback();
			this.encoding = (Encoding)settings.Encoding.Clone();
			this.encoding.EncoderFallback = this.charEntityFallback;
			this.encoder = this.encoding.GetEncoder();
			if (!stream.CanSeek || stream.Position == 0L)
			{
				byte[] preamble = this.encoding.GetPreamble();
				if (preamble.Length != 0)
				{
					this.stream.Write(preamble, 0, preamble.Length);
				}
			}
			if (settings.AutoXmlDeclaration)
			{
				this.WriteXmlDeclaration(this.standalone);
				this.autoXmlDeclaration = true;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000C320 File Offset: 0x0000A520
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			if (!this.omitXmlDeclaration && !this.autoXmlDeclaration)
			{
				if (this.trackTextContent && this.inTextContent)
				{
					this.ChangeTextContentMark(false);
				}
				this.RawText("<?xml version=\"");
				this.RawText("1.0");
				if (this.encoding != null)
				{
					this.RawText("\" encoding=\"");
					this.RawText(this.encoding.WebName);
				}
				if (standalone != XmlStandalone.Omit)
				{
					this.RawText("\" standalone=\"");
					this.RawText((standalone == XmlStandalone.Yes) ? "yes" : "no");
				}
				this.RawText("\"?>");
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000C3C3 File Offset: 0x0000A5C3
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			if (!this.omitXmlDeclaration && !this.autoXmlDeclaration)
			{
				this.WriteProcessingInstruction("xml", xmldecl);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			this.RawText("<!DOCTYPE ");
			this.RawText(name);
			int num;
			if (pubid != null)
			{
				this.RawText(" PUBLIC \"");
				this.RawText(pubid);
				this.RawText("\" \"");
				if (sysid != null)
				{
					this.RawText(sysid);
				}
				char[] array = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array[num] = 34;
			}
			else if (sysid != null)
			{
				this.RawText(" SYSTEM \"");
				this.RawText(sysid);
				char[] array2 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array2[num] = 34;
			}
			else
			{
				char[] array3 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array3[num] = 32;
			}
			if (subset != null)
			{
				char[] array4 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array4[num] = 91;
				this.RawText(subset);
				char[] array5 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array5[num] = 93;
			}
			char[] array6 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array6[num] = 62;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000C508 File Offset: 0x0000A708
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 60;
			if (prefix != null && prefix.Length != 0)
			{
				this.RawText(prefix);
				char[] array2 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array2[num] = 58;
			}
			this.RawText(localName);
			this.attrEndPos = this.bufPos;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000C588 File Offset: 0x0000A788
		internal override void StartElementContent()
		{
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 62;
			this.contentPos = this.bufPos;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			int num;
			if (this.contentPos != this.bufPos)
			{
				char[] array = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array[num] = 60;
				char[] array2 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array2[num] = 47;
				if (prefix != null && prefix.Length != 0)
				{
					this.RawText(prefix);
					char[] array3 = this.bufChars;
					num = this.bufPos;
					this.bufPos = num + 1;
					array3[num] = 58;
				}
				this.RawText(localName);
				char[] array4 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array4[num] = 62;
				return;
			}
			this.bufPos--;
			char[] array5 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array5[num] = 32;
			char[] array6 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array6[num] = 47;
			char[] array7 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array7[num] = 62;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 60;
			char[] array2 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array2[num] = 47;
			if (prefix != null && prefix.Length != 0)
			{
				this.RawText(prefix);
				char[] array3 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array3[num] = 58;
			}
			this.RawText(localName);
			char[] array4 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array4[num] = 62;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000C778 File Offset: 0x0000A978
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			int num;
			if (this.attrEndPos == this.bufPos)
			{
				char[] array = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array[num] = 32;
			}
			if (prefix != null && prefix.Length > 0)
			{
				this.RawText(prefix);
				char[] array2 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array2[num] = 58;
			}
			this.RawText(localName);
			char[] array3 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array3[num] = 61;
			char[] array4 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array4[num] = 34;
			this.inAttributeValue = true;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000C834 File Offset: 0x0000AA34
		public override void WriteEndAttribute()
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 34;
			this.inAttributeValue = false;
			this.attrEndPos = this.bufPos;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000C885 File Offset: 0x0000AA85
		internal override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
			this.WriteStartNamespaceDeclaration(prefix);
			this.WriteString(namespaceName);
			this.WriteEndNamespaceDeclaration();
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			if (prefix.Length == 0)
			{
				this.RawText(" xmlns=\"");
			}
			else
			{
				this.RawText(" xmlns:");
				this.RawText(prefix);
				char[] array = this.bufChars;
				int num = this.bufPos;
				this.bufPos = num + 1;
				array[num] = 61;
				char[] array2 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array2[num] = 34;
			}
			this.inAttributeValue = true;
			if (this.trackTextContent && !this.inTextContent)
			{
				this.ChangeTextContentMark(true);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000C940 File Offset: 0x0000AB40
		internal override void WriteEndNamespaceDeclaration()
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			this.inAttributeValue = false;
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 34;
			this.attrEndPos = this.bufPos;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000C994 File Offset: 0x0000AB94
		public override void WriteCData(string text)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			int num;
			if (this.mergeCDataSections && this.bufPos == this.cdataPos)
			{
				this.bufPos -= 3;
			}
			else
			{
				char[] array = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array[num] = 60;
				char[] array2 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array2[num] = 33;
				char[] array3 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array3[num] = 91;
				char[] array4 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array4[num] = 67;
				char[] array5 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array5[num] = 68;
				char[] array6 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array6[num] = 65;
				char[] array7 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array7[num] = 84;
				char[] array8 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array8[num] = 65;
				char[] array9 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array9[num] = 91;
			}
			this.WriteCDataSection(text);
			char[] array10 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array10[num] = 93;
			char[] array11 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array11[num] = 93;
			char[] array12 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array12[num] = 62;
			this.textPos = this.bufPos;
			this.cdataPos = this.bufPos;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000CB38 File Offset: 0x0000AD38
		public override void WriteComment(string text)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 60;
			char[] array2 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array2[num] = 33;
			char[] array3 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array3[num] = 45;
			char[] array4 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array4[num] = 45;
			this.WriteCommentOrPi(text, 45);
			char[] array5 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array5[num] = 45;
			char[] array6 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array6[num] = 45;
			char[] array7 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array7[num] = 62;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000CC1C File Offset: 0x0000AE1C
		public override void WriteProcessingInstruction(string name, string text)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 60;
			char[] array2 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array2[num] = 63;
			this.RawText(name);
			if (text.Length > 0)
			{
				char[] array3 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array3[num] = 32;
				this.WriteCommentOrPi(text, 63);
			}
			char[] array4 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array4[num] = 63;
			char[] array5 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array5[num] = 62;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		public override void WriteEntityRef(string name)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 38;
			this.RawText(name);
			char[] array2 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array2[num] = 59;
			if (this.bufPos > this.bufLen)
			{
				this.FlushBuffer();
			}
			this.textPos = this.bufPos;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		public override void WriteCharEntity(char ch)
		{
			int num = (int)ch;
			string s = num.ToString("X", NumberFormatInfo.InvariantInfo);
			if (this.checkCharacters && !this.xmlCharType.IsCharData(ch))
			{
				throw XmlConvert.CreateInvalidCharException(ch, '\0');
			}
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 38;
			char[] array2 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array2[num] = 35;
			char[] array3 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array3[num] = 120;
			this.RawText(s);
			char[] array4 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array4[num] = 59;
			if (this.bufPos > this.bufLen)
			{
				this.FlushBuffer();
			}
			this.textPos = this.bufPos;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000CE44 File Offset: 0x0000B044
		public unsafe override void WriteWhitespace(string ws)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			fixed (string text = ws)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				char* pSrcEnd = ptr + ws.Length;
				if (this.inAttributeValue)
				{
					this.WriteAttributeTextBlock(ptr, pSrcEnd);
				}
				else
				{
					this.WriteElementTextBlock(ptr, pSrcEnd);
				}
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		public unsafe override void WriteString(string text)
		{
			if (this.trackTextContent && !this.inTextContent)
			{
				this.ChangeTextContentMark(true);
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
					this.WriteAttributeTextBlock(ptr, pSrcEnd);
				}
				else
				{
					this.WriteElementTextBlock(ptr, pSrcEnd);
				}
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			int num = XmlCharType.CombineSurrogateChar((int)lowChar, (int)highChar);
			char[] array = this.bufChars;
			int num2 = this.bufPos;
			this.bufPos = num2 + 1;
			array[num2] = 38;
			char[] array2 = this.bufChars;
			num2 = this.bufPos;
			this.bufPos = num2 + 1;
			array2[num2] = 35;
			char[] array3 = this.bufChars;
			num2 = this.bufPos;
			this.bufPos = num2 + 1;
			array3[num2] = 120;
			this.RawText(num.ToString("X", NumberFormatInfo.InvariantInfo));
			char[] array4 = this.bufChars;
			num2 = this.bufPos;
			this.bufPos = num2 + 1;
			array4[num2] = 59;
			this.textPos = this.bufPos;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		public unsafe override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.trackTextContent && !this.inTextContent)
			{
				this.ChangeTextContentMark(true);
			}
			fixed (char* ptr = &buffer[index])
			{
				char* ptr2 = ptr;
				if (this.inAttributeValue)
				{
					this.WriteAttributeTextBlock(ptr2, ptr2 + count);
				}
				else
				{
					this.WriteElementTextBlock(ptr2, ptr2 + count);
				}
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000D00C File Offset: 0x0000B20C
		public unsafe override void WriteRaw(char[] buffer, int index, int count)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			fixed (char* ptr = &buffer[index])
			{
				char* ptr2 = ptr;
				this.WriteRawWithCharChecking(ptr2, ptr2 + count);
			}
			this.textPos = this.bufPos;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000D058 File Offset: 0x0000B258
		public unsafe override void WriteRaw(string data)
		{
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			fixed (string text = data)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				this.WriteRawWithCharChecking(ptr, ptr + data.Length);
			}
			this.textPos = this.bufPos;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		public override void Close()
		{
			try
			{
				this.FlushBuffer();
				this.FlushEncoder();
			}
			finally
			{
				this.writeToNull = true;
				if (this.stream != null)
				{
					try
					{
						this.stream.Flush();
						goto IL_7D;
					}
					finally
					{
						try
						{
							if (this.closeOutput)
							{
								this.stream.Close();
							}
						}
						finally
						{
							this.stream = null;
						}
					}
				}
				if (this.writer != null)
				{
					try
					{
						this.writer.Flush();
					}
					finally
					{
						try
						{
							if (this.closeOutput)
							{
								this.writer.Close();
							}
						}
						finally
						{
							this.writer = null;
						}
					}
				}
				IL_7D:;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000D178 File Offset: 0x0000B378
		public override void Flush()
		{
			this.FlushBuffer();
			this.FlushEncoder();
			if (this.stream != null)
			{
				this.stream.Flush();
				return;
			}
			if (this.writer != null)
			{
				this.writer.Flush();
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
		protected virtual void FlushBuffer()
		{
			try
			{
				if (!this.writeToNull)
				{
					if (this.stream != null)
					{
						if (this.trackTextContent)
						{
							this.charEntityFallback.Reset(this.textContentMarks, this.lastMarkPos);
							if ((this.lastMarkPos & 1) != 0)
							{
								this.textContentMarks[1] = 1;
								this.lastMarkPos = 1;
							}
							else
							{
								this.lastMarkPos = 0;
							}
						}
						this.EncodeChars(1, this.bufPos, true);
					}
					else
					{
						this.writer.Write(this.bufChars, 1, this.bufPos - 1);
					}
				}
			}
			catch
			{
				this.writeToNull = true;
				throw;
			}
			finally
			{
				this.bufChars[0] = this.bufChars[this.bufPos - 1];
				this.textPos = ((this.textPos == this.bufPos) ? 1 : 0);
				this.attrEndPos = ((this.attrEndPos == this.bufPos) ? 1 : 0);
				this.contentPos = 0;
				this.cdataPos = 0;
				this.bufPos = 1;
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream)
		{
			while (startOffset < endOffset)
			{
				if (this.charEntityFallback != null)
				{
					this.charEntityFallback.StartOffset = startOffset;
				}
				int num;
				int num2;
				bool flag;
				this.encoder.Convert(this.bufChars, startOffset, endOffset - startOffset, this.bufBytes, this.bufBytesUsed, this.bufBytes.Length - this.bufBytesUsed, false, out num, out num2, out flag);
				startOffset += num;
				this.bufBytesUsed += num2;
				if (this.bufBytesUsed >= this.bufBytes.Length - 16)
				{
					this.stream.Write(this.bufBytes, 0, this.bufBytesUsed);
					this.bufBytesUsed = 0;
				}
			}
			if (writeAllToStream && this.bufBytesUsed > 0)
			{
				this.stream.Write(this.bufBytes, 0, this.bufBytesUsed);
				this.bufBytesUsed = 0;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000D394 File Offset: 0x0000B594
		private void FlushEncoder()
		{
			if (this.stream != null)
			{
				int num;
				int num2;
				bool flag;
				this.encoder.Convert(this.bufChars, 1, 0, this.bufBytes, 0, this.bufBytes.Length, true, out num, out num2, out flag);
				if (num2 != 0)
				{
					this.stream.Write(this.bufBytes, 0, num2);
				}
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000D3E8 File Offset: 0x0000B5E8
		protected unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
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
			int num = 0;
			for (;;)
			{
				char* ptr3 = ptr2 + (long)(pSrcEnd - pSrc) * 2L / 2L;
				if (ptr3 != ptr + this.bufLen)
				{
					ptr3 = ptr + this.bufLen;
				}
				while (ptr2 < ptr3 && (this.xmlCharType.charProperties[num = (int)(*pSrc)] & 128) != 0)
				{
					*ptr2 = (char)num;
					ptr2++;
					pSrc++;
				}
				if (pSrc >= pSrcEnd)
				{
					break;
				}
				if (ptr2 >= ptr3)
				{
					this.bufPos = (int)((long)(ptr2 - ptr));
					this.FlushBuffer();
					ptr2 = ptr + 1;
				}
				else
				{
					if (num <= 38)
					{
						switch (num)
						{
						case 9:
							if (this.newLineHandling == NewLineHandling.None)
							{
								*ptr2 = (char)num;
								ptr2++;
								goto IL_1D3;
							}
							ptr2 = XmlEncodedRawTextWriter.TabEntity(ptr2);
							goto IL_1D3;
						case 10:
							if (this.newLineHandling == NewLineHandling.None)
							{
								*ptr2 = (char)num;
								ptr2++;
								goto IL_1D3;
							}
							ptr2 = XmlEncodedRawTextWriter.LineFeedEntity(ptr2);
							goto IL_1D3;
						case 11:
						case 12:
							break;
						case 13:
							if (this.newLineHandling == NewLineHandling.None)
							{
								*ptr2 = (char)num;
								ptr2++;
								goto IL_1D3;
							}
							ptr2 = XmlEncodedRawTextWriter.CarriageReturnEntity(ptr2);
							goto IL_1D3;
						default:
							if (num == 34)
							{
								ptr2 = XmlEncodedRawTextWriter.QuoteEntity(ptr2);
								goto IL_1D3;
							}
							if (num == 38)
							{
								ptr2 = XmlEncodedRawTextWriter.AmpEntity(ptr2);
								goto IL_1D3;
							}
							break;
						}
					}
					else
					{
						if (num == 39)
						{
							*ptr2 = (char)num;
							ptr2++;
							goto IL_1D3;
						}
						if (num == 60)
						{
							ptr2 = XmlEncodedRawTextWriter.LtEntity(ptr2);
							goto IL_1D3;
						}
						if (num == 62)
						{
							ptr2 = XmlEncodedRawTextWriter.GtEntity(ptr2);
							goto IL_1D3;
						}
					}
					if (XmlCharType.IsSurrogate(num))
					{
						ptr2 = XmlEncodedRawTextWriter.EncodeSurrogate(pSrc, pSrcEnd, ptr2);
						pSrc += 2;
						continue;
					}
					if (num <= 127 || num >= 65534)
					{
						ptr2 = this.InvalidXmlChar(num, ptr2, true);
						pSrc++;
						continue;
					}
					*ptr2 = (char)num;
					ptr2++;
					pSrc++;
					continue;
					IL_1D3:
					pSrc++;
				}
			}
			this.bufPos = (int)((long)(ptr2 - ptr));
			array = null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		protected unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
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
			int num = 0;
			for (;;)
			{
				char* ptr3 = ptr2 + (long)(pSrcEnd - pSrc) * 2L / 2L;
				if (ptr3 != ptr + this.bufLen)
				{
					ptr3 = ptr + this.bufLen;
				}
				while (ptr2 < ptr3 && (this.xmlCharType.charProperties[num = (int)(*pSrc)] & 128) != 0)
				{
					*ptr2 = (char)num;
					ptr2++;
					pSrc++;
				}
				if (pSrc >= pSrcEnd)
				{
					break;
				}
				if (ptr2 < ptr3)
				{
					if (num <= 38)
					{
						switch (num)
						{
						case 9:
							goto IL_10F;
						case 10:
							if (this.newLineHandling == NewLineHandling.Replace)
							{
								ptr2 = this.WriteNewLine(ptr2);
								goto IL_1D6;
							}
							*ptr2 = (char)num;
							ptr2++;
							goto IL_1D6;
						case 11:
						case 12:
							break;
						case 13:
							switch (this.newLineHandling)
							{
							case NewLineHandling.Replace:
								if (pSrc[1] == '\n')
								{
									pSrc++;
								}
								ptr2 = this.WriteNewLine(ptr2);
								goto IL_1D6;
							case NewLineHandling.Entitize:
								ptr2 = XmlEncodedRawTextWriter.CarriageReturnEntity(ptr2);
								goto IL_1D6;
							case NewLineHandling.None:
								*ptr2 = (char)num;
								ptr2++;
								goto IL_1D6;
							default:
								goto IL_1D6;
							}
							break;
						default:
							if (num == 34)
							{
								goto IL_10F;
							}
							if (num == 38)
							{
								ptr2 = XmlEncodedRawTextWriter.AmpEntity(ptr2);
								goto IL_1D6;
							}
							break;
						}
					}
					else
					{
						if (num == 39)
						{
							goto IL_10F;
						}
						if (num == 60)
						{
							ptr2 = XmlEncodedRawTextWriter.LtEntity(ptr2);
							goto IL_1D6;
						}
						if (num == 62)
						{
							ptr2 = XmlEncodedRawTextWriter.GtEntity(ptr2);
							goto IL_1D6;
						}
					}
					if (XmlCharType.IsSurrogate(num))
					{
						ptr2 = XmlEncodedRawTextWriter.EncodeSurrogate(pSrc, pSrcEnd, ptr2);
						pSrc += 2;
						continue;
					}
					if (num <= 127 || num >= 65534)
					{
						ptr2 = this.InvalidXmlChar(num, ptr2, true);
						pSrc++;
						continue;
					}
					*ptr2 = (char)num;
					ptr2++;
					pSrc++;
					continue;
					IL_1D6:
					pSrc++;
					continue;
					IL_10F:
					*ptr2 = (char)num;
					ptr2++;
					goto IL_1D6;
				}
				this.bufPos = (int)((long)(ptr2 - ptr));
				this.FlushBuffer();
				ptr2 = ptr + 1;
			}
			this.bufPos = (int)((long)(ptr2 - ptr));
			this.textPos = this.bufPos;
			this.contentPos = 0;
			array = null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
		protected unsafe void RawText(string s)
		{
			fixed (string text = s)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				this.RawText(ptr, ptr + s.Length);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000D828 File Offset: 0x0000BA28
		protected unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
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
			char* ptr3 = pSrcBegin;
			int num = 0;
			for (;;)
			{
				char* ptr4 = ptr2 + (long)(pSrcEnd - ptr3) * 2L / 2L;
				if (ptr4 != ptr + this.bufLen)
				{
					ptr4 = ptr + this.bufLen;
				}
				while (ptr2 < ptr4 && (num = (int)(*ptr3)) < 55296)
				{
					ptr3++;
					*ptr2 = (char)num;
					ptr2++;
				}
				if (ptr3 >= pSrcEnd)
				{
					break;
				}
				if (ptr2 >= ptr4)
				{
					this.bufPos = (int)((long)(ptr2 - ptr));
					this.FlushBuffer();
					ptr2 = ptr + 1;
				}
				else if (XmlCharType.IsSurrogate(num))
				{
					ptr2 = XmlEncodedRawTextWriter.EncodeSurrogate(ptr3, pSrcEnd, ptr2);
					ptr3 += 2;
				}
				else if (num <= 127 || num >= 65534)
				{
					ptr2 = this.InvalidXmlChar(num, ptr2, false);
					ptr3++;
				}
				else
				{
					*ptr2 = (char)num;
					ptr2++;
					ptr3++;
				}
			}
			this.bufPos = (int)((long)(ptr2 - ptr));
			array = null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000D934 File Offset: 0x0000BB34
		protected unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
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
			char* ptr2 = pSrcBegin;
			char* ptr3 = ptr + this.bufPos;
			int num = 0;
			for (;;)
			{
				char* ptr4 = ptr3 + (long)(pSrcEnd - ptr2) * 2L / 2L;
				if (ptr4 != ptr + this.bufLen)
				{
					ptr4 = ptr + this.bufLen;
				}
				while (ptr3 < ptr4 && (this.xmlCharType.charProperties[num = (int)(*ptr2)] & 64) != 0)
				{
					*ptr3 = (char)num;
					ptr3++;
					ptr2++;
				}
				if (ptr2 >= pSrcEnd)
				{
					break;
				}
				if (ptr3 < ptr4)
				{
					if (num <= 38)
					{
						switch (num)
						{
						case 9:
							goto IL_DF;
						case 10:
							if (this.newLineHandling == NewLineHandling.Replace)
							{
								ptr3 = this.WriteNewLine(ptr3);
								goto IL_186;
							}
							*ptr3 = (char)num;
							ptr3++;
							goto IL_186;
						case 11:
						case 12:
							break;
						case 13:
							if (this.newLineHandling == NewLineHandling.Replace)
							{
								if (ptr2[1] == '\n')
								{
									ptr2++;
								}
								ptr3 = this.WriteNewLine(ptr3);
								goto IL_186;
							}
							*ptr3 = (char)num;
							ptr3++;
							goto IL_186;
						default:
							if (num == 38)
							{
								goto IL_DF;
							}
							break;
						}
					}
					else if (num == 60 || num == 93)
					{
						goto IL_DF;
					}
					if (XmlCharType.IsSurrogate(num))
					{
						ptr3 = XmlEncodedRawTextWriter.EncodeSurrogate(ptr2, pSrcEnd, ptr3);
						ptr2 += 2;
						continue;
					}
					if (num <= 127 || num >= 65534)
					{
						ptr3 = this.InvalidXmlChar(num, ptr3, false);
						ptr2++;
						continue;
					}
					*ptr3 = (char)num;
					ptr3++;
					ptr2++;
					continue;
					IL_186:
					ptr2++;
					continue;
					IL_DF:
					*ptr3 = (char)num;
					ptr3++;
					goto IL_186;
				}
				this.bufPos = (int)((long)(ptr3 - ptr));
				this.FlushBuffer();
				ptr3 = ptr + 1;
			}
			this.bufPos = (int)((long)(ptr3 - ptr));
			array = null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
		protected unsafe void WriteCommentOrPi(string text, int stopChar)
		{
			if (text.Length == 0)
			{
				if (this.bufPos >= this.bufLen)
				{
					this.FlushBuffer();
				}
				return;
			}
			fixed (string text2 = text)
			{
				char* ptr = text2;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				char[] array;
				char* ptr2;
				if ((array = this.bufChars) == null || array.Length == 0)
				{
					ptr2 = null;
				}
				else
				{
					ptr2 = &array[0];
				}
				char* ptr3 = ptr;
				char* ptr4 = ptr + text.Length;
				char* ptr5 = ptr2 + this.bufPos;
				int num = 0;
				for (;;)
				{
					char* ptr6 = ptr5 + (long)(ptr4 - ptr3) * 2L / 2L;
					if (ptr6 != ptr2 + this.bufLen)
					{
						ptr6 = ptr2 + this.bufLen;
					}
					while (ptr5 < ptr6 && (this.xmlCharType.charProperties[num = (int)(*ptr3)] & 64) != 0 && num != stopChar)
					{
						*ptr5 = (char)num;
						ptr5++;
						ptr3++;
					}
					if (ptr3 >= ptr4)
					{
						break;
					}
					if (ptr5 < ptr6)
					{
						if (num <= 45)
						{
							switch (num)
							{
							case 9:
								goto IL_226;
							case 10:
								if (this.newLineHandling == NewLineHandling.Replace)
								{
									ptr5 = this.WriteNewLine(ptr5);
									goto IL_296;
								}
								*ptr5 = (char)num;
								ptr5++;
								goto IL_296;
							case 11:
							case 12:
								break;
							case 13:
								if (this.newLineHandling == NewLineHandling.Replace)
								{
									if (ptr3[1] == '\n')
									{
										ptr3++;
									}
									ptr5 = this.WriteNewLine(ptr5);
									goto IL_296;
								}
								*ptr5 = (char)num;
								ptr5++;
								goto IL_296;
							default:
								if (num == 38)
								{
									goto IL_226;
								}
								if (num == 45)
								{
									*ptr5 = '-';
									ptr5++;
									if (num == stopChar && (ptr3 + 1 == ptr4 || ptr3[1] == '-'))
									{
										*ptr5 = ' ';
										ptr5++;
										goto IL_296;
									}
									goto IL_296;
								}
								break;
							}
						}
						else
						{
							if (num == 60)
							{
								goto IL_226;
							}
							if (num != 63)
							{
								if (num == 93)
								{
									*ptr5 = ']';
									ptr5++;
									goto IL_296;
								}
							}
							else
							{
								*ptr5 = '?';
								ptr5++;
								if (num == stopChar && ptr3 + 1 < ptr4 && ptr3[1] == '>')
								{
									*ptr5 = ' ';
									ptr5++;
									goto IL_296;
								}
								goto IL_296;
							}
						}
						if (XmlCharType.IsSurrogate(num))
						{
							ptr5 = XmlEncodedRawTextWriter.EncodeSurrogate(ptr3, ptr4, ptr5);
							ptr3 += 2;
							continue;
						}
						if (num <= 127 || num >= 65534)
						{
							ptr5 = this.InvalidXmlChar(num, ptr5, false);
							ptr3++;
							continue;
						}
						*ptr5 = (char)num;
						ptr5++;
						ptr3++;
						continue;
						IL_296:
						ptr3++;
						continue;
						IL_226:
						*ptr5 = (char)num;
						ptr5++;
						goto IL_296;
					}
					this.bufPos = (int)((long)(ptr5 - ptr2));
					this.FlushBuffer();
					ptr5 = ptr2 + 1;
				}
				this.bufPos = (int)((long)(ptr5 - ptr2));
				array = null;
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		protected unsafe void WriteCDataSection(string text)
		{
			if (text.Length == 0)
			{
				if (this.bufPos >= this.bufLen)
				{
					this.FlushBuffer();
				}
				return;
			}
			fixed (string text2 = text)
			{
				char* ptr = text2;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				char[] array;
				char* ptr2;
				if ((array = this.bufChars) == null || array.Length == 0)
				{
					ptr2 = null;
				}
				else
				{
					ptr2 = &array[0];
				}
				char* ptr3 = ptr;
				char* ptr4 = ptr + text.Length;
				char* ptr5 = ptr2 + this.bufPos;
				int num = 0;
				for (;;)
				{
					char* ptr6 = ptr5 + (long)(ptr4 - ptr3) * 2L / 2L;
					if (ptr6 != ptr2 + this.bufLen)
					{
						ptr6 = ptr2 + this.bufLen;
					}
					while (ptr5 < ptr6 && (this.xmlCharType.charProperties[num = (int)(*ptr3)] & 128) != 0 && num != 93)
					{
						*ptr5 = (char)num;
						ptr5++;
						ptr3++;
					}
					if (ptr3 >= ptr4)
					{
						break;
					}
					if (ptr5 < ptr6)
					{
						if (num <= 39)
						{
							switch (num)
							{
							case 9:
								goto IL_210;
							case 10:
								if (this.newLineHandling == NewLineHandling.Replace)
								{
									ptr5 = this.WriteNewLine(ptr5);
									goto IL_280;
								}
								*ptr5 = (char)num;
								ptr5++;
								goto IL_280;
							case 11:
							case 12:
								break;
							case 13:
								if (this.newLineHandling == NewLineHandling.Replace)
								{
									if (ptr3[1] == '\n')
									{
										ptr3++;
									}
									ptr5 = this.WriteNewLine(ptr5);
									goto IL_280;
								}
								*ptr5 = (char)num;
								ptr5++;
								goto IL_280;
							default:
								if (num == 34 || num - 38 <= 1)
								{
									goto IL_210;
								}
								break;
							}
						}
						else
						{
							if (num == 60)
							{
								goto IL_210;
							}
							if (num == 62)
							{
								if (this.hadDoubleBracket && ptr5[-1] == ']')
								{
									ptr5 = XmlEncodedRawTextWriter.RawEndCData(ptr5);
									ptr5 = XmlEncodedRawTextWriter.RawStartCData(ptr5);
								}
								*ptr5 = '>';
								ptr5++;
								goto IL_280;
							}
							if (num == 93)
							{
								if (ptr5[-1] == ']')
								{
									this.hadDoubleBracket = true;
								}
								else
								{
									this.hadDoubleBracket = false;
								}
								*ptr5 = ']';
								ptr5++;
								goto IL_280;
							}
						}
						if (XmlCharType.IsSurrogate(num))
						{
							ptr5 = XmlEncodedRawTextWriter.EncodeSurrogate(ptr3, ptr4, ptr5);
							ptr3 += 2;
							continue;
						}
						if (num <= 127 || num >= 65534)
						{
							ptr5 = this.InvalidXmlChar(num, ptr5, false);
							ptr3++;
							continue;
						}
						*ptr5 = (char)num;
						ptr5++;
						ptr3++;
						continue;
						IL_280:
						ptr3++;
						continue;
						IL_210:
						*ptr5 = (char)num;
						ptr5++;
						goto IL_280;
					}
					this.bufPos = (int)((long)(ptr5 - ptr2));
					this.FlushBuffer();
					ptr5 = ptr2 + 1;
				}
				this.bufPos = (int)((long)(ptr5 - ptr2));
				array = null;
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000E04C File Offset: 0x0000C24C
		private unsafe static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst)
		{
			int num = (int)(*pSrc);
			if (num > 56319)
			{
				throw XmlConvert.CreateInvalidHighSurrogateCharException((char)num);
			}
			if (pSrc + 1 >= pSrcEnd)
			{
				throw new ArgumentException(Res.GetString("The surrogate pair is invalid. Missing a low surrogate character."));
			}
			int num2 = (int)pSrc[1];
			if (num2 >= 56320 && (LocalAppContextSwitches.DontThrowOnInvalidSurrogatePairs || num2 <= 57343))
			{
				*pDst = (char)num;
				pDst[1] = (char)num2;
				pDst += 2;
				return pDst;
			}
			throw XmlConvert.CreateInvalidSurrogatePairException((char)num2, (char)num);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000E0BB File Offset: 0x0000C2BB
		private unsafe char* InvalidXmlChar(int ch, char* pDst, bool entitize)
		{
			if (this.checkCharacters)
			{
				throw XmlConvert.CreateInvalidCharException((char)ch, '\0');
			}
			if (entitize)
			{
				return XmlEncodedRawTextWriter.CharEntity(pDst, (char)ch);
			}
			*pDst = (char)ch;
			pDst++;
			return pDst;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
		internal unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst)
		{
			int num = (int)(*pSrc);
			if (XmlCharType.IsSurrogate(num))
			{
				pDst = XmlEncodedRawTextWriter.EncodeSurrogate(pSrc, pSrcEnd, pDst);
				pSrc += (IntPtr)2 * 2;
				return;
			}
			if (num <= 127 || num >= 65534)
			{
				pDst = this.InvalidXmlChar(num, pDst, false);
				pSrc += 2;
				return;
			}
			*pDst = (short)((ushort)num);
			pDst += 2;
			pSrc += 2;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000E144 File Offset: 0x0000C344
		protected void ChangeTextContentMark(bool value)
		{
			this.inTextContent = value;
			if (this.lastMarkPos + 1 == this.textContentMarks.Length)
			{
				this.GrowTextContentMarks();
			}
			int[] array = this.textContentMarks;
			int num = this.lastMarkPos + 1;
			this.lastMarkPos = num;
			array[num] = this.bufPos;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000E190 File Offset: 0x0000C390
		private void GrowTextContentMarks()
		{
			int[] destinationArray = new int[this.textContentMarks.Length * 2];
			Array.Copy(this.textContentMarks, destinationArray, this.textContentMarks.Length);
			this.textContentMarks = destinationArray;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
		protected unsafe char* WriteNewLine(char* pDst)
		{
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
			this.bufPos = (int)((long)(pDst - ptr));
			this.RawText(this.newLineChars);
			return ptr + this.bufPos;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000E216 File Offset: 0x0000C416
		protected unsafe static char* LtEntity(char* pDst)
		{
			*pDst = '&';
			pDst[1] = 'l';
			pDst[2] = 't';
			pDst[3] = ';';
			return pDst + 4;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000E23A File Offset: 0x0000C43A
		protected unsafe static char* GtEntity(char* pDst)
		{
			*pDst = '&';
			pDst[1] = 'g';
			pDst[2] = 't';
			pDst[3] = ';';
			return pDst + 4;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000E25E File Offset: 0x0000C45E
		protected unsafe static char* AmpEntity(char* pDst)
		{
			*pDst = '&';
			pDst[1] = 'a';
			pDst[2] = 'm';
			pDst[3] = 'p';
			pDst[4] = ';';
			return pDst + 5;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000E28B File Offset: 0x0000C48B
		protected unsafe static char* QuoteEntity(char* pDst)
		{
			*pDst = '&';
			pDst[1] = 'q';
			pDst[2] = 'u';
			pDst[3] = 'o';
			pDst[4] = 't';
			pDst[5] = ';';
			return pDst + 6;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000E2C1 File Offset: 0x0000C4C1
		protected unsafe static char* TabEntity(char* pDst)
		{
			*pDst = '&';
			pDst[1] = '#';
			pDst[2] = 'x';
			pDst[3] = '9';
			pDst[4] = ';';
			return pDst + 5;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000E2EE File Offset: 0x0000C4EE
		protected unsafe static char* LineFeedEntity(char* pDst)
		{
			*pDst = '&';
			pDst[1] = '#';
			pDst[2] = 'x';
			pDst[3] = 'A';
			pDst[4] = ';';
			return pDst + 5;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000E31B File Offset: 0x0000C51B
		protected unsafe static char* CarriageReturnEntity(char* pDst)
		{
			*pDst = '&';
			pDst[1] = '#';
			pDst[2] = 'x';
			pDst[3] = 'D';
			pDst[4] = ';';
			return pDst + 5;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000E348 File Offset: 0x0000C548
		private unsafe static char* CharEntity(char* pDst, char ch)
		{
			int num = (int)ch;
			string text = num.ToString("X", NumberFormatInfo.InvariantInfo);
			*pDst = '&';
			pDst[1] = '#';
			pDst[2] = 'x';
			pDst += 3;
			fixed (string text2 = text)
			{
				char* ptr = text2;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				char* ptr2 = ptr;
				while ((*(pDst++) = *(ptr2++)) != '\0')
				{
				}
			}
			pDst[-1] = ';';
			return pDst;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		protected unsafe static char* RawStartCData(char* pDst)
		{
			*pDst = '<';
			pDst[1] = '!';
			pDst[2] = '[';
			pDst[3] = 'C';
			pDst[4] = 'D';
			pDst[5] = 'A';
			pDst[6] = 'T';
			pDst[7] = 'A';
			pDst[8] = '[';
			return pDst + 9;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000E411 File Offset: 0x0000C611
		protected unsafe static char* RawEndCData(char* pDst)
		{
			*pDst = ']';
			pDst[1] = ']';
			pDst[2] = '>';
			return pDst + 3;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000E42C File Offset: 0x0000C62C
		protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
		{
			if (!allowOnlyWhitespace)
			{
				for (int i = 0; i < chars.Length; i++)
				{
					if (!this.xmlCharType.IsTextChar(chars[i]))
					{
						char c = chars[i];
						if (c <= '&')
						{
							switch (c)
							{
							case '\t':
							case '\n':
							case '\r':
								goto IL_11C;
							case '\v':
							case '\f':
								goto IL_A2;
							default:
								if (c != '&')
								{
									goto IL_A2;
								}
								break;
							}
						}
						else if (c != '<' && c != ']')
						{
							goto IL_A2;
						}
						string name = "'{0}', hexadecimal value {1}, is an invalid character.";
						object[] args = XmlException.BuildCharExceptionArgs(chars, i);
						string @string = Res.GetString(name, args);
						goto IL_12D;
						IL_A2:
						if (XmlCharType.IsHighSurrogate((int)chars[i]))
						{
							if (i + 1 < chars.Length && XmlCharType.IsLowSurrogate((int)chars[i + 1]))
							{
								i++;
								goto IL_11C;
							}
							@string = Res.GetString("The surrogate pair is invalid. Missing a low surrogate character.");
						}
						else
						{
							if (!XmlCharType.IsLowSurrogate((int)chars[i]))
							{
								goto IL_11C;
							}
							@string = Res.GetString("Invalid high surrogate character (0x{0}). A high surrogate character must have a value from range (0xD800 - 0xDBFF).", new object[]
							{
								((uint)chars[i]).ToString("X", CultureInfo.InvariantCulture)
							});
						}
						IL_12D:
						string name2 = "XmlWriterSettings.{0} can contain only valid XML text content characters when XmlWriterSettings.CheckCharacters is true. {1}";
						args = new string[]
						{
							propertyName,
							@string
						};
						throw new ArgumentException(Res.GetString(name2, args));
					}
					IL_11C:;
				}
				return;
			}
			if (!this.xmlCharType.IsOnlyWhitespace(chars))
			{
				throw new ArgumentException(Res.GetString("XmlWriterSettings.{0} can contain only valid XML white space characters when XmlWriterSettings.CheckCharacters and XmlWriterSettings.NewLineOnAttributes are true.", new object[]
				{
					propertyName
				}));
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000E586 File Offset: 0x0000C786
		protected void CheckAsyncCall()
		{
			if (!this.useAsync)
			{
				throw new InvalidOperationException(Res.GetString("Set XmlWriterSettings.Async to true if you want to use Async Methods."));
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		internal override Task WriteXmlDeclarationAsync(XmlStandalone standalone)
		{
			XmlEncodedRawTextWriter.<WriteXmlDeclarationAsync>d__96 <WriteXmlDeclarationAsync>d__;
			<WriteXmlDeclarationAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteXmlDeclarationAsync>d__.<>4__this = this;
			<WriteXmlDeclarationAsync>d__.standalone = standalone;
			<WriteXmlDeclarationAsync>d__.<>1__state = -1;
			<WriteXmlDeclarationAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteXmlDeclarationAsync>d__96>(ref <WriteXmlDeclarationAsync>d__);
			return <WriteXmlDeclarationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000E5EB File Offset: 0x0000C7EB
		internal override Task WriteXmlDeclarationAsync(string xmldecl)
		{
			this.CheckAsyncCall();
			if (!this.omitXmlDeclaration && !this.autoXmlDeclaration)
			{
				return this.WriteProcessingInstructionAsync("xml", xmldecl);
			}
			return AsyncHelper.DoneTask;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000E618 File Offset: 0x0000C818
		public override Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset)
		{
			XmlEncodedRawTextWriter.<WriteDocTypeAsync>d__98 <WriteDocTypeAsync>d__;
			<WriteDocTypeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteDocTypeAsync>d__.<>4__this = this;
			<WriteDocTypeAsync>d__.name = name;
			<WriteDocTypeAsync>d__.pubid = pubid;
			<WriteDocTypeAsync>d__.sysid = sysid;
			<WriteDocTypeAsync>d__.subset = subset;
			<WriteDocTypeAsync>d__.<>1__state = -1;
			<WriteDocTypeAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteDocTypeAsync>d__98>(ref <WriteDocTypeAsync>d__);
			return <WriteDocTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000E67C File Offset: 0x0000C87C
		public override Task WriteStartElementAsync(string prefix, string localName, string ns)
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 60;
			Task task;
			if (prefix != null && prefix.Length != 0)
			{
				task = this.RawTextAsync(prefix + ":" + localName);
			}
			else
			{
				task = this.RawTextAsync(localName);
			}
			return task.CallVoidFuncWhenFinish(new Action(this.WriteStartElementAsync_SetAttEndPos));
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000E6FA File Offset: 0x0000C8FA
		private void WriteStartElementAsync_SetAttEndPos()
		{
			this.attrEndPos = this.bufPos;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000E708 File Offset: 0x0000C908
		internal override Task WriteEndElementAsync(string prefix, string localName, string ns)
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			int num;
			if (this.contentPos == this.bufPos)
			{
				this.bufPos--;
				char[] array = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array[num] = 32;
				char[] array2 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array2[num] = 47;
				char[] array3 = this.bufChars;
				num = this.bufPos;
				this.bufPos = num + 1;
				array3[num] = 62;
				return AsyncHelper.DoneTask;
			}
			char[] array4 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array4[num] = 60;
			char[] array5 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array5[num] = 47;
			if (prefix != null && prefix.Length != 0)
			{
				return this.RawTextAsync(prefix + ":" + localName + ">");
			}
			return this.RawTextAsync(localName + ">");
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000E80C File Offset: 0x0000CA0C
		internal override Task WriteFullEndElementAsync(string prefix, string localName, string ns)
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 60;
			char[] array2 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array2[num] = 47;
			if (prefix != null && prefix.Length != 0)
			{
				return this.RawTextAsync(prefix + ":" + localName + ">");
			}
			return this.RawTextAsync(localName + ">");
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000E8A0 File Offset: 0x0000CAA0
		protected internal override Task WriteStartAttributeAsync(string prefix, string localName, string ns)
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			if (this.attrEndPos == this.bufPos)
			{
				char[] array = this.bufChars;
				int num = this.bufPos;
				this.bufPos = num + 1;
				array[num] = 32;
			}
			Task task;
			if (prefix != null && prefix.Length > 0)
			{
				task = this.RawTextAsync(prefix + ":" + localName);
			}
			else
			{
				task = this.RawTextAsync(localName);
			}
			return task.CallVoidFuncWhenFinish(new Action(this.WriteStartAttribute_SetInAttribute));
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000E930 File Offset: 0x0000CB30
		private void WriteStartAttribute_SetInAttribute()
		{
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 61;
			char[] array2 = this.bufChars;
			num = this.bufPos;
			this.bufPos = num + 1;
			array2[num] = 34;
			this.inAttributeValue = true;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000E978 File Offset: 0x0000CB78
		protected internal override Task WriteEndAttributeAsync()
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 34;
			this.inAttributeValue = false;
			this.attrEndPos = this.bufPos;
			return AsyncHelper.DoneTask;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000E9D4 File Offset: 0x0000CBD4
		internal override Task WriteNamespaceDeclarationAsync(string prefix, string namespaceName)
		{
			XmlEncodedRawTextWriter.<WriteNamespaceDeclarationAsync>d__106 <WriteNamespaceDeclarationAsync>d__;
			<WriteNamespaceDeclarationAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteNamespaceDeclarationAsync>d__.<>4__this = this;
			<WriteNamespaceDeclarationAsync>d__.prefix = prefix;
			<WriteNamespaceDeclarationAsync>d__.namespaceName = namespaceName;
			<WriteNamespaceDeclarationAsync>d__.<>1__state = -1;
			<WriteNamespaceDeclarationAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteNamespaceDeclarationAsync>d__106>(ref <WriteNamespaceDeclarationAsync>d__);
			return <WriteNamespaceDeclarationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000EA28 File Offset: 0x0000CC28
		internal override Task WriteStartNamespaceDeclarationAsync(string prefix)
		{
			XmlEncodedRawTextWriter.<WriteStartNamespaceDeclarationAsync>d__107 <WriteStartNamespaceDeclarationAsync>d__;
			<WriteStartNamespaceDeclarationAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartNamespaceDeclarationAsync>d__.<>4__this = this;
			<WriteStartNamespaceDeclarationAsync>d__.prefix = prefix;
			<WriteStartNamespaceDeclarationAsync>d__.<>1__state = -1;
			<WriteStartNamespaceDeclarationAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteStartNamespaceDeclarationAsync>d__107>(ref <WriteStartNamespaceDeclarationAsync>d__);
			return <WriteStartNamespaceDeclarationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000EA74 File Offset: 0x0000CC74
		internal override Task WriteEndNamespaceDeclarationAsync()
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			this.inAttributeValue = false;
			char[] array = this.bufChars;
			int num = this.bufPos;
			this.bufPos = num + 1;
			array[num] = 34;
			this.attrEndPos = this.bufPos;
			return AsyncHelper.DoneTask;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		public override Task WriteCDataAsync(string text)
		{
			XmlEncodedRawTextWriter.<WriteCDataAsync>d__109 <WriteCDataAsync>d__;
			<WriteCDataAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCDataAsync>d__.<>4__this = this;
			<WriteCDataAsync>d__.text = text;
			<WriteCDataAsync>d__.<>1__state = -1;
			<WriteCDataAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteCDataAsync>d__109>(ref <WriteCDataAsync>d__);
			return <WriteCDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000EB1C File Offset: 0x0000CD1C
		public override Task WriteCommentAsync(string text)
		{
			XmlEncodedRawTextWriter.<WriteCommentAsync>d__110 <WriteCommentAsync>d__;
			<WriteCommentAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCommentAsync>d__.<>4__this = this;
			<WriteCommentAsync>d__.text = text;
			<WriteCommentAsync>d__.<>1__state = -1;
			<WriteCommentAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteCommentAsync>d__110>(ref <WriteCommentAsync>d__);
			return <WriteCommentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000EB68 File Offset: 0x0000CD68
		public override Task WriteProcessingInstructionAsync(string name, string text)
		{
			XmlEncodedRawTextWriter.<WriteProcessingInstructionAsync>d__111 <WriteProcessingInstructionAsync>d__;
			<WriteProcessingInstructionAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteProcessingInstructionAsync>d__.<>4__this = this;
			<WriteProcessingInstructionAsync>d__.name = name;
			<WriteProcessingInstructionAsync>d__.text = text;
			<WriteProcessingInstructionAsync>d__.<>1__state = -1;
			<WriteProcessingInstructionAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteProcessingInstructionAsync>d__111>(ref <WriteProcessingInstructionAsync>d__);
			return <WriteProcessingInstructionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		public override Task WriteEntityRefAsync(string name)
		{
			XmlEncodedRawTextWriter.<WriteEntityRefAsync>d__112 <WriteEntityRefAsync>d__;
			<WriteEntityRefAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteEntityRefAsync>d__.<>4__this = this;
			<WriteEntityRefAsync>d__.name = name;
			<WriteEntityRefAsync>d__.<>1__state = -1;
			<WriteEntityRefAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteEntityRefAsync>d__112>(ref <WriteEntityRefAsync>d__);
			return <WriteEntityRefAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000EC08 File Offset: 0x0000CE08
		public override Task WriteCharEntityAsync(char ch)
		{
			XmlEncodedRawTextWriter.<WriteCharEntityAsync>d__113 <WriteCharEntityAsync>d__;
			<WriteCharEntityAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCharEntityAsync>d__.<>4__this = this;
			<WriteCharEntityAsync>d__.ch = ch;
			<WriteCharEntityAsync>d__.<>1__state = -1;
			<WriteCharEntityAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteCharEntityAsync>d__113>(ref <WriteCharEntityAsync>d__);
			return <WriteCharEntityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000EC53 File Offset: 0x0000CE53
		public override Task WriteWhitespaceAsync(string ws)
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && this.inTextContent)
			{
				this.ChangeTextContentMark(false);
			}
			if (this.inAttributeValue)
			{
				return this.WriteAttributeTextBlockAsync(ws);
			}
			return this.WriteElementTextBlockAsync(ws);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000EC89 File Offset: 0x0000CE89
		public override Task WriteStringAsync(string text)
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && !this.inTextContent)
			{
				this.ChangeTextContentMark(true);
			}
			if (this.inAttributeValue)
			{
				return this.WriteAttributeTextBlockAsync(text);
			}
			return this.WriteElementTextBlockAsync(text);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000ECC0 File Offset: 0x0000CEC0
		public override Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
		{
			XmlEncodedRawTextWriter.<WriteSurrogateCharEntityAsync>d__116 <WriteSurrogateCharEntityAsync>d__;
			<WriteSurrogateCharEntityAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteSurrogateCharEntityAsync>d__.<>4__this = this;
			<WriteSurrogateCharEntityAsync>d__.lowChar = lowChar;
			<WriteSurrogateCharEntityAsync>d__.highChar = highChar;
			<WriteSurrogateCharEntityAsync>d__.<>1__state = -1;
			<WriteSurrogateCharEntityAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteSurrogateCharEntityAsync>d__116>(ref <WriteSurrogateCharEntityAsync>d__);
			return <WriteSurrogateCharEntityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000ED13 File Offset: 0x0000CF13
		public override Task WriteCharsAsync(char[] buffer, int index, int count)
		{
			this.CheckAsyncCall();
			if (this.trackTextContent && !this.inTextContent)
			{
				this.ChangeTextContentMark(true);
			}
			if (this.inAttributeValue)
			{
				return this.WriteAttributeTextBlockAsync(buffer, index, count);
			}
			return this.WriteElementTextBlockAsync(buffer, index, count);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000ED50 File Offset: 0x0000CF50
		public override Task WriteRawAsync(char[] buffer, int index, int count)
		{
			XmlEncodedRawTextWriter.<WriteRawAsync>d__118 <WriteRawAsync>d__;
			<WriteRawAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteRawAsync>d__.<>4__this = this;
			<WriteRawAsync>d__.buffer = buffer;
			<WriteRawAsync>d__.index = index;
			<WriteRawAsync>d__.count = count;
			<WriteRawAsync>d__.<>1__state = -1;
			<WriteRawAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteRawAsync>d__118>(ref <WriteRawAsync>d__);
			return <WriteRawAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		public override Task WriteRawAsync(string data)
		{
			XmlEncodedRawTextWriter.<WriteRawAsync>d__119 <WriteRawAsync>d__;
			<WriteRawAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteRawAsync>d__.<>4__this = this;
			<WriteRawAsync>d__.data = data;
			<WriteRawAsync>d__.<>1__state = -1;
			<WriteRawAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteRawAsync>d__119>(ref <WriteRawAsync>d__);
			return <WriteRawAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000EDF8 File Offset: 0x0000CFF8
		protected virtual Task FlushBufferAsync()
		{
			XmlEncodedRawTextWriter.<FlushBufferAsync>d__121 <FlushBufferAsync>d__;
			<FlushBufferAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FlushBufferAsync>d__.<>4__this = this;
			<FlushBufferAsync>d__.<>1__state = -1;
			<FlushBufferAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<FlushBufferAsync>d__121>(ref <FlushBufferAsync>d__);
			return <FlushBufferAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000EE3C File Offset: 0x0000D03C
		private Task EncodeCharsAsync(int startOffset, int endOffset, bool writeAllToStream)
		{
			XmlEncodedRawTextWriter.<EncodeCharsAsync>d__122 <EncodeCharsAsync>d__;
			<EncodeCharsAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<EncodeCharsAsync>d__.<>4__this = this;
			<EncodeCharsAsync>d__.startOffset = startOffset;
			<EncodeCharsAsync>d__.endOffset = endOffset;
			<EncodeCharsAsync>d__.writeAllToStream = writeAllToStream;
			<EncodeCharsAsync>d__.<>1__state = -1;
			<EncodeCharsAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<EncodeCharsAsync>d__122>(ref <EncodeCharsAsync>d__);
			return <EncodeCharsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000EE98 File Offset: 0x0000D098
		[SecuritySafeCritical]
		protected unsafe int WriteAttributeTextBlockNoFlush(char* pSrc, char* pSrcEnd)
		{
			char* ptr = pSrc;
			char[] array;
			char* ptr2;
			if ((array = this.bufChars) == null || array.Length == 0)
			{
				ptr2 = null;
			}
			else
			{
				ptr2 = &array[0];
			}
			char* ptr3 = ptr2 + this.bufPos;
			int num = 0;
			for (;;)
			{
				char* ptr4 = ptr3 + (long)(pSrcEnd - pSrc) * 2L / 2L;
				if (ptr4 != ptr2 + this.bufLen)
				{
					ptr4 = ptr2 + this.bufLen;
				}
				while (ptr3 < ptr4 && (this.xmlCharType.charProperties[num = (int)(*pSrc)] & 128) != 0)
				{
					*ptr3 = (char)num;
					ptr3++;
					pSrc++;
				}
				if (pSrc >= pSrcEnd)
				{
					goto IL_1EE;
				}
				if (ptr3 >= ptr4)
				{
					break;
				}
				if (num <= 38)
				{
					switch (num)
					{
					case 9:
						if (this.newLineHandling == NewLineHandling.None)
						{
							*ptr3 = (char)num;
							ptr3++;
							goto IL_1E4;
						}
						ptr3 = XmlEncodedRawTextWriter.TabEntity(ptr3);
						goto IL_1E4;
					case 10:
						if (this.newLineHandling == NewLineHandling.None)
						{
							*ptr3 = (char)num;
							ptr3++;
							goto IL_1E4;
						}
						ptr3 = XmlEncodedRawTextWriter.LineFeedEntity(ptr3);
						goto IL_1E4;
					case 11:
					case 12:
						break;
					case 13:
						if (this.newLineHandling == NewLineHandling.None)
						{
							*ptr3 = (char)num;
							ptr3++;
							goto IL_1E4;
						}
						ptr3 = XmlEncodedRawTextWriter.CarriageReturnEntity(ptr3);
						goto IL_1E4;
					default:
						if (num == 34)
						{
							ptr3 = XmlEncodedRawTextWriter.QuoteEntity(ptr3);
							goto IL_1E4;
						}
						if (num == 38)
						{
							ptr3 = XmlEncodedRawTextWriter.AmpEntity(ptr3);
							goto IL_1E4;
						}
						break;
					}
				}
				else
				{
					if (num == 39)
					{
						*ptr3 = (char)num;
						ptr3++;
						goto IL_1E4;
					}
					if (num == 60)
					{
						ptr3 = XmlEncodedRawTextWriter.LtEntity(ptr3);
						goto IL_1E4;
					}
					if (num == 62)
					{
						ptr3 = XmlEncodedRawTextWriter.GtEntity(ptr3);
						goto IL_1E4;
					}
				}
				if (XmlCharType.IsSurrogate(num))
				{
					ptr3 = XmlEncodedRawTextWriter.EncodeSurrogate(pSrc, pSrcEnd, ptr3);
					pSrc += 2;
					continue;
				}
				if (num <= 127 || num >= 65534)
				{
					ptr3 = this.InvalidXmlChar(num, ptr3, true);
					pSrc++;
					continue;
				}
				*ptr3 = (char)num;
				ptr3++;
				pSrc++;
				continue;
				IL_1E4:
				pSrc++;
			}
			this.bufPos = (int)((long)(ptr3 - ptr2));
			return (int)((long)(pSrc - ptr));
			IL_1EE:
			this.bufPos = (int)((long)(ptr3 - ptr2));
			array = null;
			return -1;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		[SecuritySafeCritical]
		protected unsafe int WriteAttributeTextBlockNoFlush(char[] chars, int index, int count)
		{
			if (count == 0)
			{
				return -1;
			}
			fixed (char* ptr = &chars[index])
			{
				char* ptr2 = ptr;
				char* pSrcEnd = ptr2 + count;
				return this.WriteAttributeTextBlockNoFlush(ptr2, pSrcEnd);
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
		[SecuritySafeCritical]
		protected unsafe int WriteAttributeTextBlockNoFlush(string text, int index, int count)
		{
			if (count == 0)
			{
				return -1;
			}
			char* ptr = text;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = ptr + index;
			char* pSrcEnd = ptr2 + count;
			return this.WriteAttributeTextBlockNoFlush(ptr2, pSrcEnd);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000F108 File Offset: 0x0000D308
		protected Task WriteAttributeTextBlockAsync(char[] chars, int index, int count)
		{
			XmlEncodedRawTextWriter.<WriteAttributeTextBlockAsync>d__127 <WriteAttributeTextBlockAsync>d__;
			<WriteAttributeTextBlockAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAttributeTextBlockAsync>d__.<>4__this = this;
			<WriteAttributeTextBlockAsync>d__.chars = chars;
			<WriteAttributeTextBlockAsync>d__.index = index;
			<WriteAttributeTextBlockAsync>d__.count = count;
			<WriteAttributeTextBlockAsync>d__.<>1__state = -1;
			<WriteAttributeTextBlockAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteAttributeTextBlockAsync>d__127>(ref <WriteAttributeTextBlockAsync>d__);
			return <WriteAttributeTextBlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000F164 File Offset: 0x0000D364
		protected Task WriteAttributeTextBlockAsync(string text)
		{
			int num = 0;
			int num2 = text.Length;
			int num3 = this.WriteAttributeTextBlockNoFlush(text, num, num2);
			num += num3;
			num2 -= num3;
			if (num3 >= 0)
			{
				return this._WriteAttributeTextBlockAsync(text, num, num2);
			}
			return AsyncHelper.DoneTask;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000F1A4 File Offset: 0x0000D3A4
		private Task _WriteAttributeTextBlockAsync(string text, int curIndex, int leftCount)
		{
			XmlEncodedRawTextWriter.<_WriteAttributeTextBlockAsync>d__129 <_WriteAttributeTextBlockAsync>d__;
			<_WriteAttributeTextBlockAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<_WriteAttributeTextBlockAsync>d__.<>4__this = this;
			<_WriteAttributeTextBlockAsync>d__.text = text;
			<_WriteAttributeTextBlockAsync>d__.curIndex = curIndex;
			<_WriteAttributeTextBlockAsync>d__.leftCount = leftCount;
			<_WriteAttributeTextBlockAsync>d__.<>1__state = -1;
			<_WriteAttributeTextBlockAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<_WriteAttributeTextBlockAsync>d__129>(ref <_WriteAttributeTextBlockAsync>d__);
			return <_WriteAttributeTextBlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000F200 File Offset: 0x0000D400
		[SecuritySafeCritical]
		protected unsafe int WriteElementTextBlockNoFlush(char* pSrc, char* pSrcEnd, out bool needWriteNewLine)
		{
			needWriteNewLine = false;
			char* ptr = pSrc;
			char[] array;
			char* ptr2;
			if ((array = this.bufChars) == null || array.Length == 0)
			{
				ptr2 = null;
			}
			else
			{
				ptr2 = &array[0];
			}
			char* ptr3 = ptr2 + this.bufPos;
			int num = 0;
			for (;;)
			{
				char* ptr4 = ptr3 + (long)(pSrcEnd - pSrc) * 2L / 2L;
				if (ptr4 != ptr2 + this.bufLen)
				{
					ptr4 = ptr2 + this.bufLen;
				}
				while (ptr3 < ptr4 && (this.xmlCharType.charProperties[num = (int)(*pSrc)] & 128) != 0)
				{
					*ptr3 = (char)num;
					ptr3++;
					pSrc++;
				}
				if (pSrc >= pSrcEnd)
				{
					goto IL_20F;
				}
				if (ptr3 >= ptr4)
				{
					break;
				}
				if (num <= 38)
				{
					switch (num)
					{
					case 9:
						goto IL_11A;
					case 10:
						if (this.newLineHandling == NewLineHandling.Replace)
						{
							goto Block_13;
						}
						*ptr3 = (char)num;
						ptr3++;
						goto IL_205;
					case 11:
					case 12:
						break;
					case 13:
						switch (this.newLineHandling)
						{
						case NewLineHandling.Replace:
							goto IL_176;
						case NewLineHandling.Entitize:
							ptr3 = XmlEncodedRawTextWriter.CarriageReturnEntity(ptr3);
							goto IL_205;
						case NewLineHandling.None:
							*ptr3 = (char)num;
							ptr3++;
							goto IL_205;
						default:
							goto IL_205;
						}
						break;
					default:
						if (num == 34)
						{
							goto IL_11A;
						}
						if (num == 38)
						{
							ptr3 = XmlEncodedRawTextWriter.AmpEntity(ptr3);
							goto IL_205;
						}
						break;
					}
				}
				else
				{
					if (num == 39)
					{
						goto IL_11A;
					}
					if (num == 60)
					{
						ptr3 = XmlEncodedRawTextWriter.LtEntity(ptr3);
						goto IL_205;
					}
					if (num == 62)
					{
						ptr3 = XmlEncodedRawTextWriter.GtEntity(ptr3);
						goto IL_205;
					}
				}
				if (XmlCharType.IsSurrogate(num))
				{
					ptr3 = XmlEncodedRawTextWriter.EncodeSurrogate(pSrc, pSrcEnd, ptr3);
					pSrc += 2;
					continue;
				}
				if (num <= 127 || num >= 65534)
				{
					ptr3 = this.InvalidXmlChar(num, ptr3, true);
					pSrc++;
					continue;
				}
				*ptr3 = (char)num;
				ptr3++;
				pSrc++;
				continue;
				IL_205:
				pSrc++;
				continue;
				IL_11A:
				*ptr3 = (char)num;
				ptr3++;
				goto IL_205;
			}
			this.bufPos = (int)((long)(ptr3 - ptr2));
			return (int)((long)(pSrc - ptr));
			Block_13:
			this.bufPos = (int)((long)(ptr3 - ptr2));
			needWriteNewLine = true;
			return (int)((long)(pSrc - ptr));
			IL_176:
			if (pSrc[1] == '\n')
			{
				pSrc++;
			}
			this.bufPos = (int)((long)(ptr3 - ptr2));
			needWriteNewLine = true;
			return (int)((long)(pSrc - ptr));
			IL_20F:
			this.bufPos = (int)((long)(ptr3 - ptr2));
			this.textPos = this.bufPos;
			this.contentPos = 0;
			array = null;
			return -1;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000F440 File Offset: 0x0000D640
		[SecuritySafeCritical]
		protected unsafe int WriteElementTextBlockNoFlush(char[] chars, int index, int count, out bool needWriteNewLine)
		{
			needWriteNewLine = false;
			if (count == 0)
			{
				this.contentPos = 0;
				return -1;
			}
			fixed (char* ptr = &chars[index])
			{
				char* ptr2 = ptr;
				char* pSrcEnd = ptr2 + count;
				return this.WriteElementTextBlockNoFlush(ptr2, pSrcEnd, out needWriteNewLine);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000F47C File Offset: 0x0000D67C
		[SecuritySafeCritical]
		protected unsafe int WriteElementTextBlockNoFlush(string text, int index, int count, out bool needWriteNewLine)
		{
			needWriteNewLine = false;
			if (count == 0)
			{
				this.contentPos = 0;
				return -1;
			}
			char* ptr = text;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = ptr + index;
			char* pSrcEnd = ptr2 + count;
			return this.WriteElementTextBlockNoFlush(ptr2, pSrcEnd, out needWriteNewLine);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		protected Task WriteElementTextBlockAsync(char[] chars, int index, int count)
		{
			XmlEncodedRawTextWriter.<WriteElementTextBlockAsync>d__133 <WriteElementTextBlockAsync>d__;
			<WriteElementTextBlockAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteElementTextBlockAsync>d__.<>4__this = this;
			<WriteElementTextBlockAsync>d__.chars = chars;
			<WriteElementTextBlockAsync>d__.index = index;
			<WriteElementTextBlockAsync>d__.count = count;
			<WriteElementTextBlockAsync>d__.<>1__state = -1;
			<WriteElementTextBlockAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteElementTextBlockAsync>d__133>(ref <WriteElementTextBlockAsync>d__);
			return <WriteElementTextBlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000F520 File Offset: 0x0000D720
		protected Task WriteElementTextBlockAsync(string text)
		{
			int num = 0;
			int num2 = text.Length;
			bool flag = false;
			int num3 = this.WriteElementTextBlockNoFlush(text, num, num2, out flag);
			num += num3;
			num2 -= num3;
			if (flag)
			{
				return this._WriteElementTextBlockAsync(true, text, num, num2);
			}
			if (num3 >= 0)
			{
				return this._WriteElementTextBlockAsync(false, text, num, num2);
			}
			return AsyncHelper.DoneTask;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000F570 File Offset: 0x0000D770
		private Task _WriteElementTextBlockAsync(bool newLine, string text, int curIndex, int leftCount)
		{
			XmlEncodedRawTextWriter.<_WriteElementTextBlockAsync>d__135 <_WriteElementTextBlockAsync>d__;
			<_WriteElementTextBlockAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<_WriteElementTextBlockAsync>d__.<>4__this = this;
			<_WriteElementTextBlockAsync>d__.newLine = newLine;
			<_WriteElementTextBlockAsync>d__.text = text;
			<_WriteElementTextBlockAsync>d__.curIndex = curIndex;
			<_WriteElementTextBlockAsync>d__.leftCount = leftCount;
			<_WriteElementTextBlockAsync>d__.<>1__state = -1;
			<_WriteElementTextBlockAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<_WriteElementTextBlockAsync>d__135>(ref <_WriteElementTextBlockAsync>d__);
			return <_WriteElementTextBlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		[SecuritySafeCritical]
		protected unsafe int RawTextNoFlush(char* pSrcBegin, char* pSrcEnd)
		{
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
			char* ptr3 = pSrcBegin;
			int num = 0;
			for (;;)
			{
				char* ptr4 = ptr2 + (long)(pSrcEnd - ptr3) * 2L / 2L;
				if (ptr4 != ptr + this.bufLen)
				{
					ptr4 = ptr + this.bufLen;
				}
				while (ptr2 < ptr4 && (num = (int)(*ptr3)) < 55296)
				{
					ptr3++;
					*ptr2 = (char)num;
					ptr2++;
				}
				if (ptr3 >= pSrcEnd)
				{
					goto IL_F9;
				}
				if (ptr2 >= ptr4)
				{
					break;
				}
				if (XmlCharType.IsSurrogate(num))
				{
					ptr2 = XmlEncodedRawTextWriter.EncodeSurrogate(ptr3, pSrcEnd, ptr2);
					ptr3 += 2;
				}
				else if (num <= 127 || num >= 65534)
				{
					ptr2 = this.InvalidXmlChar(num, ptr2, false);
					ptr3++;
				}
				else
				{
					*ptr2 = (char)num;
					ptr2++;
					ptr3++;
				}
			}
			this.bufPos = (int)((long)(ptr2 - ptr));
			return (int)((long)(ptr3 - pSrcBegin));
			IL_F9:
			this.bufPos = (int)((long)(ptr2 - ptr));
			array = null;
			return -1;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		[SecuritySafeCritical]
		protected unsafe int RawTextNoFlush(string text, int index, int count)
		{
			if (count == 0)
			{
				return -1;
			}
			char* ptr = text;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = ptr + index;
			char* pSrcEnd = ptr2 + count;
			return this.RawTextNoFlush(ptr2, pSrcEnd);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000F724 File Offset: 0x0000D924
		protected Task RawTextAsync(string text)
		{
			int num = 0;
			int num2 = text.Length;
			int num3 = this.RawTextNoFlush(text, num, num2);
			num += num3;
			num2 -= num3;
			if (num3 >= 0)
			{
				return this._RawTextAsync(text, num, num2);
			}
			return AsyncHelper.DoneTask;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000F764 File Offset: 0x0000D964
		private Task _RawTextAsync(string text, int curIndex, int leftCount)
		{
			XmlEncodedRawTextWriter.<_RawTextAsync>d__139 <_RawTextAsync>d__;
			<_RawTextAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<_RawTextAsync>d__.<>4__this = this;
			<_RawTextAsync>d__.text = text;
			<_RawTextAsync>d__.curIndex = curIndex;
			<_RawTextAsync>d__.leftCount = leftCount;
			<_RawTextAsync>d__.<>1__state = -1;
			<_RawTextAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<_RawTextAsync>d__139>(ref <_RawTextAsync>d__);
			return <_RawTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		[SecuritySafeCritical]
		protected unsafe int WriteRawWithCharCheckingNoFlush(char* pSrcBegin, char* pSrcEnd, out bool needWriteNewLine)
		{
			needWriteNewLine = false;
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
			char* ptr2 = pSrcBegin;
			char* ptr3 = ptr + this.bufPos;
			int num = 0;
			for (;;)
			{
				char* ptr4 = ptr3 + (long)(pSrcEnd - ptr2) * 2L / 2L;
				if (ptr4 != ptr + this.bufLen)
				{
					ptr4 = ptr + this.bufLen;
				}
				while (ptr3 < ptr4 && (this.xmlCharType.charProperties[num = (int)(*ptr2)] & 64) != 0)
				{
					*ptr3 = (char)num;
					ptr3++;
					ptr2++;
				}
				if (ptr2 >= pSrcEnd)
				{
					goto IL_1CC;
				}
				if (ptr3 >= ptr4)
				{
					break;
				}
				if (num <= 38)
				{
					switch (num)
					{
					case 9:
						goto IL_EB;
					case 10:
						if (this.newLineHandling == NewLineHandling.Replace)
						{
							goto Block_12;
						}
						*ptr3 = (char)num;
						ptr3++;
						goto IL_1C3;
					case 11:
					case 12:
						break;
					case 13:
						if (this.newLineHandling == NewLineHandling.Replace)
						{
							goto Block_10;
						}
						*ptr3 = (char)num;
						ptr3++;
						goto IL_1C3;
					default:
						if (num == 38)
						{
							goto IL_EB;
						}
						break;
					}
				}
				else if (num == 60 || num == 93)
				{
					goto IL_EB;
				}
				if (XmlCharType.IsSurrogate(num))
				{
					ptr3 = XmlEncodedRawTextWriter.EncodeSurrogate(ptr2, pSrcEnd, ptr3);
					ptr2 += 2;
					continue;
				}
				if (num <= 127 || num >= 65534)
				{
					ptr3 = this.InvalidXmlChar(num, ptr3, false);
					ptr2++;
					continue;
				}
				*ptr3 = (char)num;
				ptr3++;
				ptr2++;
				continue;
				IL_1C3:
				ptr2++;
				continue;
				IL_EB:
				*ptr3 = (char)num;
				ptr3++;
				goto IL_1C3;
			}
			this.bufPos = (int)((long)(ptr3 - ptr));
			return (int)((long)(ptr2 - pSrcBegin));
			Block_10:
			if (ptr2[1] == '\n')
			{
				ptr2++;
			}
			this.bufPos = (int)((long)(ptr3 - ptr));
			needWriteNewLine = true;
			return (int)((long)(ptr2 - pSrcBegin));
			Block_12:
			this.bufPos = (int)((long)(ptr3 - ptr));
			needWriteNewLine = true;
			return (int)((long)(ptr2 - pSrcBegin));
			IL_1CC:
			this.bufPos = (int)((long)(ptr3 - ptr));
			array = null;
			return -1;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000F9AC File Offset: 0x0000DBAC
		[SecuritySafeCritical]
		protected unsafe int WriteRawWithCharCheckingNoFlush(char[] chars, int index, int count, out bool needWriteNewLine)
		{
			needWriteNewLine = false;
			if (count == 0)
			{
				return -1;
			}
			fixed (char* ptr = &chars[index])
			{
				char* ptr2 = ptr;
				char* pSrcEnd = ptr2 + count;
				return this.WriteRawWithCharCheckingNoFlush(ptr2, pSrcEnd, out needWriteNewLine);
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
		[SecuritySafeCritical]
		protected unsafe int WriteRawWithCharCheckingNoFlush(string text, int index, int count, out bool needWriteNewLine)
		{
			needWriteNewLine = false;
			if (count == 0)
			{
				return -1;
			}
			char* ptr = text;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = ptr + index;
			char* pSrcEnd = ptr2 + count;
			return this.WriteRawWithCharCheckingNoFlush(ptr2, pSrcEnd, out needWriteNewLine);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000FA20 File Offset: 0x0000DC20
		protected Task WriteRawWithCharCheckingAsync(char[] chars, int index, int count)
		{
			XmlEncodedRawTextWriter.<WriteRawWithCharCheckingAsync>d__143 <WriteRawWithCharCheckingAsync>d__;
			<WriteRawWithCharCheckingAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteRawWithCharCheckingAsync>d__.<>4__this = this;
			<WriteRawWithCharCheckingAsync>d__.chars = chars;
			<WriteRawWithCharCheckingAsync>d__.index = index;
			<WriteRawWithCharCheckingAsync>d__.count = count;
			<WriteRawWithCharCheckingAsync>d__.<>1__state = -1;
			<WriteRawWithCharCheckingAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteRawWithCharCheckingAsync>d__143>(ref <WriteRawWithCharCheckingAsync>d__);
			return <WriteRawWithCharCheckingAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		protected Task WriteRawWithCharCheckingAsync(string text)
		{
			XmlEncodedRawTextWriter.<WriteRawWithCharCheckingAsync>d__144 <WriteRawWithCharCheckingAsync>d__;
			<WriteRawWithCharCheckingAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteRawWithCharCheckingAsync>d__.<>4__this = this;
			<WriteRawWithCharCheckingAsync>d__.text = text;
			<WriteRawWithCharCheckingAsync>d__.<>1__state = -1;
			<WriteRawWithCharCheckingAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteRawWithCharCheckingAsync>d__144>(ref <WriteRawWithCharCheckingAsync>d__);
			return <WriteRawWithCharCheckingAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[SecuritySafeCritical]
		protected unsafe int WriteCommentOrPiNoFlush(string text, int index, int count, int stopChar, out bool needWriteNewLine)
		{
			needWriteNewLine = false;
			if (count == 0)
			{
				return -1;
			}
			char* ptr = text;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = ptr + index;
			char[] array;
			char* ptr3;
			if ((array = this.bufChars) == null || array.Length == 0)
			{
				ptr3 = null;
			}
			else
			{
				ptr3 = &array[0];
			}
			char* ptr4 = ptr2;
			char* ptr5 = ptr4;
			char* ptr6 = ptr2 + count;
			char* ptr7 = ptr3 + this.bufPos;
			int num = 0;
			for (;;)
			{
				char* ptr8 = ptr7 + (long)(ptr6 - ptr4) * 2L / 2L;
				if (ptr8 != ptr3 + this.bufLen)
				{
					ptr8 = ptr3 + this.bufLen;
				}
				while (ptr7 < ptr8 && (this.xmlCharType.charProperties[num = (int)(*ptr4)] & 64) != 0 && num != stopChar)
				{
					*ptr7 = (char)num;
					ptr7++;
					ptr4++;
				}
				if (ptr4 >= ptr6)
				{
					goto IL_2AB;
				}
				if (ptr7 >= ptr8)
				{
					break;
				}
				if (num <= 45)
				{
					switch (num)
					{
					case 9:
						goto IL_230;
					case 10:
						if (this.newLineHandling == NewLineHandling.Replace)
						{
							goto Block_23;
						}
						*ptr7 = (char)num;
						ptr7++;
						goto IL_2A0;
					case 11:
					case 12:
						break;
					case 13:
						if (this.newLineHandling == NewLineHandling.Replace)
						{
							goto Block_21;
						}
						*ptr7 = (char)num;
						ptr7++;
						goto IL_2A0;
					default:
						if (num == 38)
						{
							goto IL_230;
						}
						if (num == 45)
						{
							*ptr7 = '-';
							ptr7++;
							if (num == stopChar && (ptr4 + 1 == ptr6 || ptr4[1] == '-'))
							{
								*ptr7 = ' ';
								ptr7++;
								goto IL_2A0;
							}
							goto IL_2A0;
						}
						break;
					}
				}
				else
				{
					if (num == 60)
					{
						goto IL_230;
					}
					if (num != 63)
					{
						if (num == 93)
						{
							*ptr7 = ']';
							ptr7++;
							goto IL_2A0;
						}
					}
					else
					{
						*ptr7 = '?';
						ptr7++;
						if (num == stopChar && ptr4 + 1 < ptr6 && ptr4[1] == '>')
						{
							*ptr7 = ' ';
							ptr7++;
							goto IL_2A0;
						}
						goto IL_2A0;
					}
				}
				if (XmlCharType.IsSurrogate(num))
				{
					ptr7 = XmlEncodedRawTextWriter.EncodeSurrogate(ptr4, ptr6, ptr7);
					ptr4 += 2;
					continue;
				}
				if (num <= 127 || num >= 65534)
				{
					ptr7 = this.InvalidXmlChar(num, ptr7, false);
					ptr4++;
					continue;
				}
				*ptr7 = (char)num;
				ptr7++;
				ptr4++;
				continue;
				IL_2A0:
				ptr4++;
				continue;
				IL_230:
				*ptr7 = (char)num;
				ptr7++;
				goto IL_2A0;
			}
			this.bufPos = (int)((long)(ptr7 - ptr3));
			return (int)((long)(ptr4 - ptr5));
			Block_21:
			if (ptr4[1] == '\n')
			{
				ptr4++;
			}
			this.bufPos = (int)((long)(ptr7 - ptr3));
			needWriteNewLine = true;
			return (int)((long)(ptr4 - ptr5));
			Block_23:
			this.bufPos = (int)((long)(ptr7 - ptr3));
			needWriteNewLine = true;
			return (int)((long)(ptr4 - ptr5));
			IL_2AB:
			this.bufPos = (int)((long)(ptr7 - ptr3));
			array = null;
			return -1;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000FD94 File Offset: 0x0000DF94
		protected Task WriteCommentOrPiAsync(string text, int stopChar)
		{
			XmlEncodedRawTextWriter.<WriteCommentOrPiAsync>d__146 <WriteCommentOrPiAsync>d__;
			<WriteCommentOrPiAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCommentOrPiAsync>d__.<>4__this = this;
			<WriteCommentOrPiAsync>d__.text = text;
			<WriteCommentOrPiAsync>d__.stopChar = stopChar;
			<WriteCommentOrPiAsync>d__.<>1__state = -1;
			<WriteCommentOrPiAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteCommentOrPiAsync>d__146>(ref <WriteCommentOrPiAsync>d__);
			return <WriteCommentOrPiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
		[SecuritySafeCritical]
		protected unsafe int WriteCDataSectionNoFlush(string text, int index, int count, out bool needWriteNewLine)
		{
			needWriteNewLine = false;
			if (count == 0)
			{
				return -1;
			}
			char* ptr = text;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = ptr + index;
			char[] array;
			char* ptr3;
			if ((array = this.bufChars) == null || array.Length == 0)
			{
				ptr3 = null;
			}
			else
			{
				ptr3 = &array[0];
			}
			char* ptr4 = ptr2;
			char* ptr5 = ptr2 + count;
			char* ptr6 = ptr4;
			char* ptr7 = ptr3 + this.bufPos;
			int num = 0;
			for (;;)
			{
				char* ptr8 = ptr7 + (long)(ptr5 - ptr4) * 2L / 2L;
				if (ptr8 != ptr3 + this.bufLen)
				{
					ptr8 = ptr3 + this.bufLen;
				}
				while (ptr7 < ptr8 && (this.xmlCharType.charProperties[num = (int)(*ptr4)] & 128) != 0 && num != 93)
				{
					*ptr7 = (char)num;
					ptr7++;
					ptr4++;
				}
				if (ptr4 >= ptr5)
				{
					goto IL_292;
				}
				if (ptr7 >= ptr8)
				{
					break;
				}
				if (num <= 39)
				{
					switch (num)
					{
					case 9:
						goto IL_217;
					case 10:
						if (this.newLineHandling == NewLineHandling.Replace)
						{
							goto Block_21;
						}
						*ptr7 = (char)num;
						ptr7++;
						goto IL_287;
					case 11:
					case 12:
						break;
					case 13:
						if (this.newLineHandling == NewLineHandling.Replace)
						{
							goto Block_19;
						}
						*ptr7 = (char)num;
						ptr7++;
						goto IL_287;
					default:
						if (num == 34 || num - 38 <= 1)
						{
							goto IL_217;
						}
						break;
					}
				}
				else
				{
					if (num == 60)
					{
						goto IL_217;
					}
					if (num == 62)
					{
						if (this.hadDoubleBracket && ptr7[-1] == ']')
						{
							ptr7 = XmlEncodedRawTextWriter.RawEndCData(ptr7);
							ptr7 = XmlEncodedRawTextWriter.RawStartCData(ptr7);
						}
						*ptr7 = '>';
						ptr7++;
						goto IL_287;
					}
					if (num == 93)
					{
						if (ptr7[-1] == ']')
						{
							this.hadDoubleBracket = true;
						}
						else
						{
							this.hadDoubleBracket = false;
						}
						*ptr7 = ']';
						ptr7++;
						goto IL_287;
					}
				}
				if (XmlCharType.IsSurrogate(num))
				{
					ptr7 = XmlEncodedRawTextWriter.EncodeSurrogate(ptr4, ptr5, ptr7);
					ptr4 += 2;
					continue;
				}
				if (num <= 127 || num >= 65534)
				{
					ptr7 = this.InvalidXmlChar(num, ptr7, false);
					ptr4++;
					continue;
				}
				*ptr7 = (char)num;
				ptr7++;
				ptr4++;
				continue;
				IL_287:
				ptr4++;
				continue;
				IL_217:
				*ptr7 = (char)num;
				ptr7++;
				goto IL_287;
			}
			this.bufPos = (int)((long)(ptr7 - ptr3));
			return (int)((long)(ptr4 - ptr6));
			Block_19:
			if (ptr4[1] == '\n')
			{
				ptr4++;
			}
			this.bufPos = (int)((long)(ptr7 - ptr3));
			needWriteNewLine = true;
			return (int)((long)(ptr4 - ptr6));
			Block_21:
			this.bufPos = (int)((long)(ptr7 - ptr3));
			needWriteNewLine = true;
			return (int)((long)(ptr4 - ptr6));
			IL_292:
			this.bufPos = (int)((long)(ptr7 - ptr3));
			array = null;
			return -1;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00010098 File Offset: 0x0000E298
		protected Task WriteCDataSectionAsync(string text)
		{
			XmlEncodedRawTextWriter.<WriteCDataSectionAsync>d__148 <WriteCDataSectionAsync>d__;
			<WriteCDataSectionAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCDataSectionAsync>d__.<>4__this = this;
			<WriteCDataSectionAsync>d__.text = text;
			<WriteCDataSectionAsync>d__.<>1__state = -1;
			<WriteCDataSectionAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriter.<WriteCDataSectionAsync>d__148>(ref <WriteCDataSectionAsync>d__);
			return <WriteCDataSectionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000182 RID: 386
		private readonly bool useAsync;

		// Token: 0x04000183 RID: 387
		protected byte[] bufBytes;

		// Token: 0x04000184 RID: 388
		protected Stream stream;

		// Token: 0x04000185 RID: 389
		protected Encoding encoding;

		// Token: 0x04000186 RID: 390
		protected XmlCharType xmlCharType = XmlCharType.Instance;

		// Token: 0x04000187 RID: 391
		protected int bufPos = 1;

		// Token: 0x04000188 RID: 392
		protected int textPos = 1;

		// Token: 0x04000189 RID: 393
		protected int contentPos;

		// Token: 0x0400018A RID: 394
		protected int cdataPos;

		// Token: 0x0400018B RID: 395
		protected int attrEndPos;

		// Token: 0x0400018C RID: 396
		protected int bufLen = 6144;

		// Token: 0x0400018D RID: 397
		protected bool writeToNull;

		// Token: 0x0400018E RID: 398
		protected bool hadDoubleBracket;

		// Token: 0x0400018F RID: 399
		protected bool inAttributeValue;

		// Token: 0x04000190 RID: 400
		protected int bufBytesUsed;

		// Token: 0x04000191 RID: 401
		protected char[] bufChars;

		// Token: 0x04000192 RID: 402
		protected Encoder encoder;

		// Token: 0x04000193 RID: 403
		protected TextWriter writer;

		// Token: 0x04000194 RID: 404
		protected bool trackTextContent;

		// Token: 0x04000195 RID: 405
		protected bool inTextContent;

		// Token: 0x04000196 RID: 406
		private int lastMarkPos;

		// Token: 0x04000197 RID: 407
		private int[] textContentMarks;

		// Token: 0x04000198 RID: 408
		private CharEntityEncoderFallback charEntityFallback;

		// Token: 0x04000199 RID: 409
		protected NewLineHandling newLineHandling;

		// Token: 0x0400019A RID: 410
		protected bool closeOutput;

		// Token: 0x0400019B RID: 411
		protected bool omitXmlDeclaration;

		// Token: 0x0400019C RID: 412
		protected string newLineChars;

		// Token: 0x0400019D RID: 413
		protected bool checkCharacters;

		// Token: 0x0400019E RID: 414
		protected XmlStandalone standalone;

		// Token: 0x0400019F RID: 415
		protected XmlOutputMethod outputMethod;

		// Token: 0x040001A0 RID: 416
		protected bool autoXmlDeclaration;

		// Token: 0x040001A1 RID: 417
		protected bool mergeCDataSections;
	}
}
