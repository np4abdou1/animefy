using System;
using System.Collections.Generic;

namespace System.Xml
{
	// Token: 0x02000038 RID: 56
	internal class QueryOutputWriter : XmlRawWriter
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x0000A224 File Offset: 0x00008424
		public QueryOutputWriter(XmlRawWriter writer, XmlWriterSettings settings)
		{
			this.wrapped = writer;
			this.systemId = settings.DocTypeSystem;
			this.publicId = settings.DocTypePublic;
			if (settings.OutputMethod == XmlOutputMethod.Xml)
			{
				if (this.systemId != null)
				{
					this.outputDocType = true;
					this.checkWellFormedDoc = true;
				}
				if (settings.AutoXmlDeclaration && settings.Standalone == XmlStandalone.Yes)
				{
					this.checkWellFormedDoc = true;
				}
				if (settings.CDataSectionElements.Count > 0)
				{
					this.bitsCData = new BitStack();
					this.lookupCDataElems = new Dictionary<XmlQualifiedName, int>();
					this.qnameCData = new XmlQualifiedName();
					foreach (XmlQualifiedName key in settings.CDataSectionElements)
					{
						this.lookupCDataElems[key] = 0;
					}
					this.bitsCData.PushBit(false);
					return;
				}
			}
			else if (settings.OutputMethod == XmlOutputMethod.Html && (this.systemId != null || this.publicId != null))
			{
				this.outputDocType = true;
			}
		}

		// Token: 0x17000045 RID: 69
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000A33C File Offset: 0x0000853C
		internal override IXmlNamespaceResolver NamespaceResolver
		{
			set
			{
				this.resolver = value;
				this.wrapped.NamespaceResolver = value;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000A351 File Offset: 0x00008551
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			this.wrapped.WriteXmlDeclaration(standalone);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000A35F File Offset: 0x0000855F
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			this.wrapped.WriteXmlDeclaration(xmldecl);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000A36D File Offset: 0x0000856D
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (this.publicId == null && this.systemId == null)
			{
				this.wrapped.WriteDocType(name, pubid, sysid, subset);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000A390 File Offset: 0x00008590
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			this.EndCDataSection();
			if (this.checkWellFormedDoc)
			{
				if (this.depth == 0 && this.hasDocElem)
				{
					throw new XmlException("Document cannot have multiple document elements.", string.Empty);
				}
				this.depth++;
				this.hasDocElem = true;
			}
			if (this.outputDocType)
			{
				this.wrapped.WriteDocType((prefix.Length != 0) ? (prefix + ":" + localName) : localName, this.publicId, this.systemId, null);
				this.outputDocType = false;
			}
			this.wrapped.WriteStartElement(prefix, localName, ns);
			if (this.lookupCDataElems != null)
			{
				this.qnameCData.Init(localName, ns);
				this.bitsCData.PushBit(this.lookupCDataElems.ContainsKey(this.qnameCData));
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000A45D File Offset: 0x0000865D
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			this.EndCDataSection();
			this.wrapped.WriteEndElement(prefix, localName, ns);
			if (this.checkWellFormedDoc)
			{
				this.depth--;
			}
			if (this.lookupCDataElems != null)
			{
				this.bitsCData.PopBit();
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000A49D File Offset: 0x0000869D
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			this.EndCDataSection();
			this.wrapped.WriteFullEndElement(prefix, localName, ns);
			if (this.checkWellFormedDoc)
			{
				this.depth--;
			}
			if (this.lookupCDataElems != null)
			{
				this.bitsCData.PopBit();
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000A4DD File Offset: 0x000086DD
		internal override void StartElementContent()
		{
			this.wrapped.StartElementContent();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000A4EA File Offset: 0x000086EA
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.inAttr = true;
			this.wrapped.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000A501 File Offset: 0x00008701
		public override void WriteEndAttribute()
		{
			this.inAttr = false;
			this.wrapped.WriteEndAttribute();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000A515 File Offset: 0x00008715
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			this.wrapped.WriteNamespaceDeclaration(prefix, ns);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000A524 File Offset: 0x00008724
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				return this.wrapped.SupportsNamespaceDeclarationInChunks;
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000A531 File Offset: 0x00008731
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			this.wrapped.WriteStartNamespaceDeclaration(prefix);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000A53F File Offset: 0x0000873F
		internal override void WriteEndNamespaceDeclaration()
		{
			this.wrapped.WriteEndNamespaceDeclaration();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000A54C File Offset: 0x0000874C
		public override void WriteCData(string text)
		{
			this.wrapped.WriteCData(text);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000A55A File Offset: 0x0000875A
		public override void WriteComment(string text)
		{
			this.EndCDataSection();
			this.wrapped.WriteComment(text);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000A56E File Offset: 0x0000876E
		public override void WriteProcessingInstruction(string name, string text)
		{
			this.EndCDataSection();
			this.wrapped.WriteProcessingInstruction(name, text);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000A583 File Offset: 0x00008783
		public override void WriteWhitespace(string ws)
		{
			if (!this.inAttr && (this.inCDataSection || this.StartCDataSection()))
			{
				this.wrapped.WriteCData(ws);
				return;
			}
			this.wrapped.WriteWhitespace(ws);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000A5B6 File Offset: 0x000087B6
		public override void WriteString(string text)
		{
			if (!this.inAttr && (this.inCDataSection || this.StartCDataSection()))
			{
				this.wrapped.WriteCData(text);
				return;
			}
			this.wrapped.WriteString(text);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000A5E9 File Offset: 0x000087E9
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (!this.inAttr && (this.inCDataSection || this.StartCDataSection()))
			{
				this.wrapped.WriteCData(new string(buffer, index, count));
				return;
			}
			this.wrapped.WriteChars(buffer, index, count);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000A625 File Offset: 0x00008825
		public override void WriteEntityRef(string name)
		{
			this.EndCDataSection();
			this.wrapped.WriteEntityRef(name);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000A639 File Offset: 0x00008839
		public override void WriteCharEntity(char ch)
		{
			this.EndCDataSection();
			this.wrapped.WriteCharEntity(ch);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000A64D File Offset: 0x0000884D
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.EndCDataSection();
			this.wrapped.WriteSurrogateCharEntity(lowChar, highChar);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000A662 File Offset: 0x00008862
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			if (!this.inAttr && (this.inCDataSection || this.StartCDataSection()))
			{
				this.wrapped.WriteCData(new string(buffer, index, count));
				return;
			}
			this.wrapped.WriteRaw(buffer, index, count);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000A69E File Offset: 0x0000889E
		public override void WriteRaw(string data)
		{
			if (!this.inAttr && (this.inCDataSection || this.StartCDataSection()))
			{
				this.wrapped.WriteCData(data);
				return;
			}
			this.wrapped.WriteRaw(data);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000A6D1 File Offset: 0x000088D1
		public override void Close()
		{
			this.wrapped.Close();
			if (this.checkWellFormedDoc && !this.hasDocElem)
			{
				throw new XmlException("Document does not have a root element.", string.Empty);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000A6FE File Offset: 0x000088FE
		public override void Flush()
		{
			this.wrapped.Flush();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000A70B File Offset: 0x0000890B
		private bool StartCDataSection()
		{
			if (this.lookupCDataElems != null && this.bitsCData.PeekBit())
			{
				this.inCDataSection = true;
				return true;
			}
			return false;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000A72C File Offset: 0x0000892C
		private void EndCDataSection()
		{
			this.inCDataSection = false;
		}

		// Token: 0x0400012A RID: 298
		private XmlRawWriter wrapped;

		// Token: 0x0400012B RID: 299
		private bool inCDataSection;

		// Token: 0x0400012C RID: 300
		private Dictionary<XmlQualifiedName, int> lookupCDataElems;

		// Token: 0x0400012D RID: 301
		private BitStack bitsCData;

		// Token: 0x0400012E RID: 302
		private XmlQualifiedName qnameCData;

		// Token: 0x0400012F RID: 303
		private bool outputDocType;

		// Token: 0x04000130 RID: 304
		private bool checkWellFormedDoc;

		// Token: 0x04000131 RID: 305
		private bool hasDocElem;

		// Token: 0x04000132 RID: 306
		private bool inAttr;

		// Token: 0x04000133 RID: 307
		private string systemId;

		// Token: 0x04000134 RID: 308
		private string publicId;

		// Token: 0x04000135 RID: 309
		private int depth;
	}
}
