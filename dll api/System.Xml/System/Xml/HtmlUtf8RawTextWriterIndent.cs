using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x02000028 RID: 40
	internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00009F3D File Offset: 0x0000813D
		public HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) : base(stream, settings)
		{
			this.Init(settings);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00009F4E File Offset: 0x0000814E
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			base.WriteDocType(name, pubid, sysid, subset);
			this.endBlockPos = this.bufPos;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00009F68 File Offset: 0x00008168
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			this.elementScope.Push((byte)this.currentElementProperties);
			if (ns.Length == 0)
			{
				this.currentElementProperties = (ElementProperties)HtmlUtf8RawTextWriter.elementPropertySearch.FindCaseInsensitiveString(localName);
				if (this.endBlockPos == this.bufPos && (this.currentElementProperties & ElementProperties.BLOCK_WS) != ElementProperties.DEFAULT)
				{
					this.WriteIndent();
				}
				this.indentLevel++;
				byte[] bufBytes = this.bufBytes;
				int bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufBytes[bufPos] = 60;
			}
			else
			{
				this.currentElementProperties = (ElementProperties)192U;
				if (this.endBlockPos == this.bufPos)
				{
					this.WriteIndent();
				}
				this.indentLevel++;
				byte[] bufBytes2 = this.bufBytes;
				int bufPos = this.bufPos;
				this.bufPos = bufPos + 1;
				bufBytes2[bufPos] = 60;
				if (prefix.Length != 0)
				{
					base.RawText(prefix);
					byte[] bufBytes3 = this.bufBytes;
					bufPos = this.bufPos;
					this.bufPos = bufPos + 1;
					bufBytes3[bufPos] = 58;
				}
			}
			base.RawText(localName);
			this.attrEndPos = this.bufPos;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000A06C File Offset: 0x0000826C
		internal override void StartElementContent()
		{
			byte[] bufBytes = this.bufBytes;
			int bufPos = this.bufPos;
			this.bufPos = bufPos + 1;
			bufBytes[bufPos] = 62;
			this.contentPos = this.bufPos;
			if ((this.currentElementProperties & ElementProperties.HEAD) != ElementProperties.DEFAULT)
			{
				this.WriteIndent();
				base.WriteMetaElement();
				this.endBlockPos = this.bufPos;
				return;
			}
			if ((this.currentElementProperties & ElementProperties.BLOCK_WS) != ElementProperties.DEFAULT)
			{
				this.endBlockPos = this.bufPos;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000A0DC File Offset: 0x000082DC
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			this.indentLevel--;
			bool flag = (this.currentElementProperties & ElementProperties.BLOCK_WS) > ElementProperties.DEFAULT;
			if (flag && this.endBlockPos == this.bufPos && this.contentPos != this.bufPos)
			{
				this.WriteIndent();
			}
			base.WriteEndElement(prefix, localName, ns);
			this.contentPos = 0;
			if (flag)
			{
				this.endBlockPos = this.bufPos;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000A148 File Offset: 0x00008348
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (this.newLineOnAttributes)
			{
				base.RawText(this.newLineChars);
				this.indentLevel++;
				this.WriteIndent();
				this.indentLevel--;
			}
			base.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000A194 File Offset: 0x00008394
		protected override void FlushBuffer()
		{
			this.endBlockPos = ((this.endBlockPos == this.bufPos) ? 1 : 0);
			base.FlushBuffer();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000A1B4 File Offset: 0x000083B4
		private void Init(XmlWriterSettings settings)
		{
			this.indentLevel = 0;
			this.indentChars = settings.IndentChars;
			this.newLineOnAttributes = settings.NewLineOnAttributes;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000A1D8 File Offset: 0x000083D8
		private void WriteIndent()
		{
			base.RawText(this.newLineChars);
			for (int i = this.indentLevel; i > 0; i--)
			{
				base.RawText(this.indentChars);
			}
		}

		// Token: 0x0400011F RID: 287
		private int indentLevel;

		// Token: 0x04000120 RID: 288
		private int endBlockPos;

		// Token: 0x04000121 RID: 289
		private string indentChars;

		// Token: 0x04000122 RID: 290
		private bool newLineOnAttributes;
	}
}
