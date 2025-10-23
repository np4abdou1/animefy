using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x020000EA RID: 234
	internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x00038486 File Offset: 0x00036686
		public XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) : base(stream, settings)
		{
			this.Init(settings);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00038497 File Offset: 0x00036697
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (!this.mixedContent && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			base.WriteDocType(name, pubid, sysid, subset);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000384C0 File Offset: 0x000366C0
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (!this.mixedContent && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			this.indentLevel++;
			this.mixedContentStack.PushBit(this.mixedContent);
			base.WriteStartElement(prefix, localName, ns);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00038511 File Offset: 0x00036711
		internal override void StartElementContent()
		{
			if (this.indentLevel == 1 && this.conformanceLevel == ConformanceLevel.Document)
			{
				this.mixedContent = false;
			}
			else
			{
				this.mixedContent = this.mixedContentStack.PeekBit();
			}
			base.StartElementContent();
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00038545 File Offset: 0x00036745
		internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
			this.conformanceLevel = currentConformanceLevel;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00038550 File Offset: 0x00036750
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			this.indentLevel--;
			if (!this.mixedContent && this.contentPos != this.bufPos && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			this.mixedContent = this.mixedContentStack.PopBit();
			base.WriteEndElement(prefix, localName, ns);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000385B0 File Offset: 0x000367B0
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			this.indentLevel--;
			if (!this.mixedContent && this.contentPos != this.bufPos && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			this.mixedContent = this.mixedContentStack.PopBit();
			base.WriteFullEndElement(prefix, localName, ns);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0003860F File Offset: 0x0003680F
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this.newLineOnAttributes)
			{
				this.WriteIndent();
			}
			base.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00038628 File Offset: 0x00036828
		public override void WriteCData(string text)
		{
			this.mixedContent = true;
			base.WriteCData(text);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00038638 File Offset: 0x00036838
		public override void WriteComment(string text)
		{
			if (!this.mixedContent && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			base.WriteComment(text);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0003865D File Offset: 0x0003685D
		public override void WriteProcessingInstruction(string target, string text)
		{
			if (!this.mixedContent && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			base.WriteProcessingInstruction(target, text);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00038683 File Offset: 0x00036883
		public override void WriteEntityRef(string name)
		{
			this.mixedContent = true;
			base.WriteEntityRef(name);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00038693 File Offset: 0x00036893
		public override void WriteCharEntity(char ch)
		{
			this.mixedContent = true;
			base.WriteCharEntity(ch);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000386A3 File Offset: 0x000368A3
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.mixedContent = true;
			base.WriteSurrogateCharEntity(lowChar, highChar);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000386B4 File Offset: 0x000368B4
		public override void WriteWhitespace(string ws)
		{
			this.mixedContent = true;
			base.WriteWhitespace(ws);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000386C4 File Offset: 0x000368C4
		public override void WriteString(string text)
		{
			this.mixedContent = true;
			base.WriteString(text);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000386D4 File Offset: 0x000368D4
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteChars(buffer, index, count);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000386E6 File Offset: 0x000368E6
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteRaw(buffer, index, count);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000386F8 File Offset: 0x000368F8
		public override void WriteRaw(string data)
		{
			this.mixedContent = true;
			base.WriteRaw(data);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00038708 File Offset: 0x00036908
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteBase64(buffer, index, count);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0003871C File Offset: 0x0003691C
		private void Init(XmlWriterSettings settings)
		{
			this.indentLevel = 0;
			this.indentChars = settings.IndentChars;
			this.newLineOnAttributes = settings.NewLineOnAttributes;
			this.mixedContentStack = new BitStack();
			if (this.checkCharacters)
			{
				if (this.newLineOnAttributes)
				{
					base.ValidateContentChars(this.indentChars, "IndentChars", true);
					base.ValidateContentChars(this.newLineChars, "NewLineChars", true);
					return;
				}
				base.ValidateContentChars(this.indentChars, "IndentChars", false);
				if (this.newLineHandling != NewLineHandling.Replace)
				{
					base.ValidateContentChars(this.newLineChars, "NewLineChars", false);
				}
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000387B4 File Offset: 0x000369B4
		private void WriteIndent()
		{
			base.RawText(this.newLineChars);
			for (int i = this.indentLevel; i > 0; i--)
			{
				base.RawText(this.indentChars);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000387EC File Offset: 0x000369EC
		public override Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset)
		{
			XmlUtf8RawTextWriterIndent.<WriteDocTypeAsync>d__30 <WriteDocTypeAsync>d__;
			<WriteDocTypeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteDocTypeAsync>d__.<>4__this = this;
			<WriteDocTypeAsync>d__.name = name;
			<WriteDocTypeAsync>d__.pubid = pubid;
			<WriteDocTypeAsync>d__.sysid = sysid;
			<WriteDocTypeAsync>d__.subset = subset;
			<WriteDocTypeAsync>d__.<>1__state = -1;
			<WriteDocTypeAsync>d__.<>t__builder.Start<XmlUtf8RawTextWriterIndent.<WriteDocTypeAsync>d__30>(ref <WriteDocTypeAsync>d__);
			return <WriteDocTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00038850 File Offset: 0x00036A50
		public override Task WriteStartElementAsync(string prefix, string localName, string ns)
		{
			XmlUtf8RawTextWriterIndent.<WriteStartElementAsync>d__31 <WriteStartElementAsync>d__;
			<WriteStartElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartElementAsync>d__.<>4__this = this;
			<WriteStartElementAsync>d__.prefix = prefix;
			<WriteStartElementAsync>d__.localName = localName;
			<WriteStartElementAsync>d__.ns = ns;
			<WriteStartElementAsync>d__.<>1__state = -1;
			<WriteStartElementAsync>d__.<>t__builder.Start<XmlUtf8RawTextWriterIndent.<WriteStartElementAsync>d__31>(ref <WriteStartElementAsync>d__);
			return <WriteStartElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000388AC File Offset: 0x00036AAC
		internal override Task WriteEndElementAsync(string prefix, string localName, string ns)
		{
			XmlUtf8RawTextWriterIndent.<WriteEndElementAsync>d__32 <WriteEndElementAsync>d__;
			<WriteEndElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteEndElementAsync>d__.<>4__this = this;
			<WriteEndElementAsync>d__.prefix = prefix;
			<WriteEndElementAsync>d__.localName = localName;
			<WriteEndElementAsync>d__.ns = ns;
			<WriteEndElementAsync>d__.<>1__state = -1;
			<WriteEndElementAsync>d__.<>t__builder.Start<XmlUtf8RawTextWriterIndent.<WriteEndElementAsync>d__32>(ref <WriteEndElementAsync>d__);
			return <WriteEndElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00038908 File Offset: 0x00036B08
		internal override Task WriteFullEndElementAsync(string prefix, string localName, string ns)
		{
			XmlUtf8RawTextWriterIndent.<WriteFullEndElementAsync>d__33 <WriteFullEndElementAsync>d__;
			<WriteFullEndElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteFullEndElementAsync>d__.<>4__this = this;
			<WriteFullEndElementAsync>d__.prefix = prefix;
			<WriteFullEndElementAsync>d__.localName = localName;
			<WriteFullEndElementAsync>d__.ns = ns;
			<WriteFullEndElementAsync>d__.<>1__state = -1;
			<WriteFullEndElementAsync>d__.<>t__builder.Start<XmlUtf8RawTextWriterIndent.<WriteFullEndElementAsync>d__33>(ref <WriteFullEndElementAsync>d__);
			return <WriteFullEndElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00038964 File Offset: 0x00036B64
		protected internal override Task WriteStartAttributeAsync(string prefix, string localName, string ns)
		{
			XmlUtf8RawTextWriterIndent.<WriteStartAttributeAsync>d__34 <WriteStartAttributeAsync>d__;
			<WriteStartAttributeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartAttributeAsync>d__.<>4__this = this;
			<WriteStartAttributeAsync>d__.prefix = prefix;
			<WriteStartAttributeAsync>d__.localName = localName;
			<WriteStartAttributeAsync>d__.ns = ns;
			<WriteStartAttributeAsync>d__.<>1__state = -1;
			<WriteStartAttributeAsync>d__.<>t__builder.Start<XmlUtf8RawTextWriterIndent.<WriteStartAttributeAsync>d__34>(ref <WriteStartAttributeAsync>d__);
			return <WriteStartAttributeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000389BF File Offset: 0x00036BBF
		public override Task WriteCDataAsync(string text)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteCDataAsync(text);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000389D8 File Offset: 0x00036BD8
		public override Task WriteCommentAsync(string text)
		{
			XmlUtf8RawTextWriterIndent.<WriteCommentAsync>d__36 <WriteCommentAsync>d__;
			<WriteCommentAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCommentAsync>d__.<>4__this = this;
			<WriteCommentAsync>d__.text = text;
			<WriteCommentAsync>d__.<>1__state = -1;
			<WriteCommentAsync>d__.<>t__builder.Start<XmlUtf8RawTextWriterIndent.<WriteCommentAsync>d__36>(ref <WriteCommentAsync>d__);
			return <WriteCommentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00038A24 File Offset: 0x00036C24
		public override Task WriteProcessingInstructionAsync(string target, string text)
		{
			XmlUtf8RawTextWriterIndent.<WriteProcessingInstructionAsync>d__37 <WriteProcessingInstructionAsync>d__;
			<WriteProcessingInstructionAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteProcessingInstructionAsync>d__.<>4__this = this;
			<WriteProcessingInstructionAsync>d__.target = target;
			<WriteProcessingInstructionAsync>d__.text = text;
			<WriteProcessingInstructionAsync>d__.<>1__state = -1;
			<WriteProcessingInstructionAsync>d__.<>t__builder.Start<XmlUtf8RawTextWriterIndent.<WriteProcessingInstructionAsync>d__37>(ref <WriteProcessingInstructionAsync>d__);
			return <WriteProcessingInstructionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00038A77 File Offset: 0x00036C77
		public override Task WriteEntityRefAsync(string name)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteEntityRefAsync(name);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00038A8D File Offset: 0x00036C8D
		public override Task WriteCharEntityAsync(char ch)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteCharEntityAsync(ch);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00038AA3 File Offset: 0x00036CA3
		public override Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteSurrogateCharEntityAsync(lowChar, highChar);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00038ABA File Offset: 0x00036CBA
		public override Task WriteWhitespaceAsync(string ws)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteWhitespaceAsync(ws);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00038AD0 File Offset: 0x00036CD0
		public override Task WriteStringAsync(string text)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteStringAsync(text);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00038AE6 File Offset: 0x00036CE6
		public override Task WriteCharsAsync(char[] buffer, int index, int count)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteCharsAsync(buffer, index, count);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00038AFE File Offset: 0x00036CFE
		public override Task WriteRawAsync(char[] buffer, int index, int count)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteRawAsync(buffer, index, count);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00038B16 File Offset: 0x00036D16
		public override Task WriteRawAsync(string data)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteRawAsync(data);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00038B2C File Offset: 0x00036D2C
		private Task WriteIndentAsync()
		{
			XmlUtf8RawTextWriterIndent.<WriteIndentAsync>d__47 <WriteIndentAsync>d__;
			<WriteIndentAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteIndentAsync>d__.<>4__this = this;
			<WriteIndentAsync>d__.<>1__state = -1;
			<WriteIndentAsync>d__.<>t__builder.Start<XmlUtf8RawTextWriterIndent.<WriteIndentAsync>d__47>(ref <WriteIndentAsync>d__);
			return <WriteIndentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000648 RID: 1608
		protected int indentLevel;

		// Token: 0x04000649 RID: 1609
		protected bool newLineOnAttributes;

		// Token: 0x0400064A RID: 1610
		protected string indentChars;

		// Token: 0x0400064B RID: 1611
		protected bool mixedContent;

		// Token: 0x0400064C RID: 1612
		private BitStack mixedContentStack;

		// Token: 0x0400064D RID: 1613
		protected ConformanceLevel conformanceLevel;
	}
}
