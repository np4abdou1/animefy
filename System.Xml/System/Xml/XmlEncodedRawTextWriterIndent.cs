using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x02000067 RID: 103
	internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00013372 File Offset: 0x00011572
		public XmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings) : base(writer, settings)
		{
			this.Init(settings);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00013383 File Offset: 0x00011583
		public XmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings) : base(stream, settings)
		{
			this.Init(settings);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00013394 File Offset: 0x00011594
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (!this.mixedContent && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			base.WriteDocType(name, pubid, sysid, subset);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000133C0 File Offset: 0x000115C0
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

		// Token: 0x06000362 RID: 866 RVA: 0x00013411 File Offset: 0x00011611
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

		// Token: 0x06000363 RID: 867 RVA: 0x00013445 File Offset: 0x00011645
		internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
			this.conformanceLevel = currentConformanceLevel;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00013450 File Offset: 0x00011650
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

		// Token: 0x06000365 RID: 869 RVA: 0x000134B0 File Offset: 0x000116B0
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

		// Token: 0x06000366 RID: 870 RVA: 0x0001350F File Offset: 0x0001170F
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this.newLineOnAttributes)
			{
				this.WriteIndent();
			}
			base.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00013528 File Offset: 0x00011728
		public override void WriteCData(string text)
		{
			this.mixedContent = true;
			base.WriteCData(text);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00013538 File Offset: 0x00011738
		public override void WriteComment(string text)
		{
			if (!this.mixedContent && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			base.WriteComment(text);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0001355D File Offset: 0x0001175D
		public override void WriteProcessingInstruction(string target, string text)
		{
			if (!this.mixedContent && this.textPos != this.bufPos)
			{
				this.WriteIndent();
			}
			base.WriteProcessingInstruction(target, text);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00013583 File Offset: 0x00011783
		public override void WriteEntityRef(string name)
		{
			this.mixedContent = true;
			base.WriteEntityRef(name);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00013593 File Offset: 0x00011793
		public override void WriteCharEntity(char ch)
		{
			this.mixedContent = true;
			base.WriteCharEntity(ch);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000135A3 File Offset: 0x000117A3
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.mixedContent = true;
			base.WriteSurrogateCharEntity(lowChar, highChar);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000135B4 File Offset: 0x000117B4
		public override void WriteWhitespace(string ws)
		{
			this.mixedContent = true;
			base.WriteWhitespace(ws);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000135C4 File Offset: 0x000117C4
		public override void WriteString(string text)
		{
			this.mixedContent = true;
			base.WriteString(text);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000135D4 File Offset: 0x000117D4
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteChars(buffer, index, count);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000135E6 File Offset: 0x000117E6
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteRaw(buffer, index, count);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000135F8 File Offset: 0x000117F8
		public override void WriteRaw(string data)
		{
			this.mixedContent = true;
			base.WriteRaw(data);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00013608 File Offset: 0x00011808
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.mixedContent = true;
			base.WriteBase64(buffer, index, count);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001361C File Offset: 0x0001181C
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

		// Token: 0x06000374 RID: 884 RVA: 0x000136B4 File Offset: 0x000118B4
		private void WriteIndent()
		{
			base.RawText(this.newLineChars);
			for (int i = this.indentLevel; i > 0; i--)
			{
				base.RawText(this.indentChars);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000136EC File Offset: 0x000118EC
		public override Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset)
		{
			XmlEncodedRawTextWriterIndent.<WriteDocTypeAsync>d__31 <WriteDocTypeAsync>d__;
			<WriteDocTypeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteDocTypeAsync>d__.<>4__this = this;
			<WriteDocTypeAsync>d__.name = name;
			<WriteDocTypeAsync>d__.pubid = pubid;
			<WriteDocTypeAsync>d__.sysid = sysid;
			<WriteDocTypeAsync>d__.subset = subset;
			<WriteDocTypeAsync>d__.<>1__state = -1;
			<WriteDocTypeAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriterIndent.<WriteDocTypeAsync>d__31>(ref <WriteDocTypeAsync>d__);
			return <WriteDocTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00013750 File Offset: 0x00011950
		public override Task WriteStartElementAsync(string prefix, string localName, string ns)
		{
			XmlEncodedRawTextWriterIndent.<WriteStartElementAsync>d__32 <WriteStartElementAsync>d__;
			<WriteStartElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartElementAsync>d__.<>4__this = this;
			<WriteStartElementAsync>d__.prefix = prefix;
			<WriteStartElementAsync>d__.localName = localName;
			<WriteStartElementAsync>d__.ns = ns;
			<WriteStartElementAsync>d__.<>1__state = -1;
			<WriteStartElementAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriterIndent.<WriteStartElementAsync>d__32>(ref <WriteStartElementAsync>d__);
			return <WriteStartElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000137AC File Offset: 0x000119AC
		internal override Task WriteEndElementAsync(string prefix, string localName, string ns)
		{
			XmlEncodedRawTextWriterIndent.<WriteEndElementAsync>d__33 <WriteEndElementAsync>d__;
			<WriteEndElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteEndElementAsync>d__.<>4__this = this;
			<WriteEndElementAsync>d__.prefix = prefix;
			<WriteEndElementAsync>d__.localName = localName;
			<WriteEndElementAsync>d__.ns = ns;
			<WriteEndElementAsync>d__.<>1__state = -1;
			<WriteEndElementAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriterIndent.<WriteEndElementAsync>d__33>(ref <WriteEndElementAsync>d__);
			return <WriteEndElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00013808 File Offset: 0x00011A08
		internal override Task WriteFullEndElementAsync(string prefix, string localName, string ns)
		{
			XmlEncodedRawTextWriterIndent.<WriteFullEndElementAsync>d__34 <WriteFullEndElementAsync>d__;
			<WriteFullEndElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteFullEndElementAsync>d__.<>4__this = this;
			<WriteFullEndElementAsync>d__.prefix = prefix;
			<WriteFullEndElementAsync>d__.localName = localName;
			<WriteFullEndElementAsync>d__.ns = ns;
			<WriteFullEndElementAsync>d__.<>1__state = -1;
			<WriteFullEndElementAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriterIndent.<WriteFullEndElementAsync>d__34>(ref <WriteFullEndElementAsync>d__);
			return <WriteFullEndElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00013864 File Offset: 0x00011A64
		protected internal override Task WriteStartAttributeAsync(string prefix, string localName, string ns)
		{
			XmlEncodedRawTextWriterIndent.<WriteStartAttributeAsync>d__35 <WriteStartAttributeAsync>d__;
			<WriteStartAttributeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartAttributeAsync>d__.<>4__this = this;
			<WriteStartAttributeAsync>d__.prefix = prefix;
			<WriteStartAttributeAsync>d__.localName = localName;
			<WriteStartAttributeAsync>d__.ns = ns;
			<WriteStartAttributeAsync>d__.<>1__state = -1;
			<WriteStartAttributeAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriterIndent.<WriteStartAttributeAsync>d__35>(ref <WriteStartAttributeAsync>d__);
			return <WriteStartAttributeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000138BF File Offset: 0x00011ABF
		public override Task WriteCDataAsync(string text)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteCDataAsync(text);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000138D8 File Offset: 0x00011AD8
		public override Task WriteCommentAsync(string text)
		{
			XmlEncodedRawTextWriterIndent.<WriteCommentAsync>d__37 <WriteCommentAsync>d__;
			<WriteCommentAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCommentAsync>d__.<>4__this = this;
			<WriteCommentAsync>d__.text = text;
			<WriteCommentAsync>d__.<>1__state = -1;
			<WriteCommentAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriterIndent.<WriteCommentAsync>d__37>(ref <WriteCommentAsync>d__);
			return <WriteCommentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00013924 File Offset: 0x00011B24
		public override Task WriteProcessingInstructionAsync(string target, string text)
		{
			XmlEncodedRawTextWriterIndent.<WriteProcessingInstructionAsync>d__38 <WriteProcessingInstructionAsync>d__;
			<WriteProcessingInstructionAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteProcessingInstructionAsync>d__.<>4__this = this;
			<WriteProcessingInstructionAsync>d__.target = target;
			<WriteProcessingInstructionAsync>d__.text = text;
			<WriteProcessingInstructionAsync>d__.<>1__state = -1;
			<WriteProcessingInstructionAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriterIndent.<WriteProcessingInstructionAsync>d__38>(ref <WriteProcessingInstructionAsync>d__);
			return <WriteProcessingInstructionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00013977 File Offset: 0x00011B77
		public override Task WriteEntityRefAsync(string name)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteEntityRefAsync(name);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0001398D File Offset: 0x00011B8D
		public override Task WriteCharEntityAsync(char ch)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteCharEntityAsync(ch);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000139A3 File Offset: 0x00011BA3
		public override Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteSurrogateCharEntityAsync(lowChar, highChar);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000139BA File Offset: 0x00011BBA
		public override Task WriteWhitespaceAsync(string ws)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteWhitespaceAsync(ws);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000139D0 File Offset: 0x00011BD0
		public override Task WriteStringAsync(string text)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteStringAsync(text);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000139E6 File Offset: 0x00011BE6
		public override Task WriteCharsAsync(char[] buffer, int index, int count)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteCharsAsync(buffer, index, count);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000139FE File Offset: 0x00011BFE
		public override Task WriteRawAsync(char[] buffer, int index, int count)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteRawAsync(buffer, index, count);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00013A16 File Offset: 0x00011C16
		public override Task WriteRawAsync(string data)
		{
			base.CheckAsyncCall();
			this.mixedContent = true;
			return base.WriteRawAsync(data);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00013A2C File Offset: 0x00011C2C
		private Task WriteIndentAsync()
		{
			XmlEncodedRawTextWriterIndent.<WriteIndentAsync>d__48 <WriteIndentAsync>d__;
			<WriteIndentAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteIndentAsync>d__.<>4__this = this;
			<WriteIndentAsync>d__.<>1__state = -1;
			<WriteIndentAsync>d__.<>t__builder.Start<XmlEncodedRawTextWriterIndent.<WriteIndentAsync>d__48>(ref <WriteIndentAsync>d__);
			return <WriteIndentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000247 RID: 583
		protected int indentLevel;

		// Token: 0x04000248 RID: 584
		protected bool newLineOnAttributes;

		// Token: 0x04000249 RID: 585
		protected string indentChars;

		// Token: 0x0400024A RID: 586
		protected bool mixedContent;

		// Token: 0x0400024B RID: 587
		private BitStack mixedContentStack;

		// Token: 0x0400024C RID: 588
		protected ConformanceLevel conformanceLevel;
	}
}
