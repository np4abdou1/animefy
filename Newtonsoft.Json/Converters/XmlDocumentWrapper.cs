using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001BF RID: 447
	[NullableContext(1)]
	[Nullable(0)]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x06000F07 RID: 3847 RVA: 0x00042CCA File Offset: 0x00040ECA
		public XmlDocumentWrapper(XmlDocument document) : base(document)
		{
			this._document = document;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00042CDA File Offset: 0x00040EDA
		public IXmlNode CreateComment([Nullable(2)] string data)
		{
			return new XmlNodeWrapper(this._document.CreateComment(data));
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00042CED File Offset: 0x00040EED
		public IXmlNode CreateTextNode([Nullable(2)] string text)
		{
			return new XmlNodeWrapper(this._document.CreateTextNode(text));
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00042D00 File Offset: 0x00040F00
		public IXmlNode CreateCDataSection([Nullable(2)] string data)
		{
			return new XmlNodeWrapper(this._document.CreateCDataSection(data));
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00042D13 File Offset: 0x00040F13
		public IXmlNode CreateWhitespace([Nullable(2)] string text)
		{
			return new XmlNodeWrapper(this._document.CreateWhitespace(text));
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00042D26 File Offset: 0x00040F26
		public IXmlNode CreateSignificantWhitespace([Nullable(2)] string text)
		{
			return new XmlNodeWrapper(this._document.CreateSignificantWhitespace(text));
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00042D39 File Offset: 0x00040F39
		public IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone)
		{
			return new XmlDeclarationWrapper(this._document.CreateXmlDeclaration(version, encoding, standalone));
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00042D4E File Offset: 0x00040F4E
		[NullableContext(2)]
		[return: Nullable(1)]
		public IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset)
		{
			return new XmlDocumentTypeWrapper(this._document.CreateDocumentType(name, publicId, systemId, null));
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00042D64 File Offset: 0x00040F64
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return new XmlNodeWrapper(this._document.CreateProcessingInstruction(target, data));
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00042D78 File Offset: 0x00040F78
		public IXmlElement CreateElement(string elementName)
		{
			return new XmlElementWrapper(this._document.CreateElement(elementName));
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00042D8B File Offset: 0x00040F8B
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return new XmlElementWrapper(this._document.CreateElement(qualifiedName, namespaceUri));
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00042D9F File Offset: 0x00040F9F
		public IXmlNode CreateAttribute(string name, [Nullable(2)] string value)
		{
			return new XmlNodeWrapper(this._document.CreateAttribute(name))
			{
				Value = value
			};
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00042DB9 File Offset: 0x00040FB9
		public IXmlNode CreateAttribute(string qualifiedName, [Nullable(2)] string namespaceUri, [Nullable(2)] string value)
		{
			return new XmlNodeWrapper(this._document.CreateAttribute(qualifiedName, namespaceUri))
			{
				Value = value
			};
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00042DD4 File Offset: 0x00040FD4
		[Nullable(2)]
		public IXmlElement DocumentElement
		{
			[NullableContext(2)]
			get
			{
				if (this._document.DocumentElement == null)
				{
					return null;
				}
				return new XmlElementWrapper(this._document.DocumentElement);
			}
		}

		// Token: 0x04000813 RID: 2067
		private readonly XmlDocument _document;
	}
}
