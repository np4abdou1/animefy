using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CB RID: 459
	[NullableContext(1)]
	[Nullable(0)]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00043251 File Offset: 0x00041451
		private XDocument Document
		{
			get
			{
				return (XDocument)base.WrappedNode;
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0004325E File Offset: 0x0004145E
		public XDocumentWrapper(XDocument document) : base(document)
		{
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00043268 File Offset: 0x00041468
		public override List<IXmlNode> ChildNodes
		{
			get
			{
				List<IXmlNode> childNodes = base.ChildNodes;
				if (this.Document.Declaration != null && (childNodes.Count == 0 || childNodes[0].NodeType != XmlNodeType.XmlDeclaration))
				{
					childNodes.Insert(0, new XDeclarationWrapper(this.Document.Declaration));
				}
				return childNodes;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x000432B9 File Offset: 0x000414B9
		protected override bool HasChildNodes
		{
			get
			{
				return base.HasChildNodes || this.Document.Declaration != null;
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000432D3 File Offset: 0x000414D3
		public IXmlNode CreateComment([Nullable(2)] string text)
		{
			return new XObjectWrapper(new XComment(text));
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000432E0 File Offset: 0x000414E0
		public IXmlNode CreateTextNode([Nullable(2)] string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x000432ED File Offset: 0x000414ED
		public IXmlNode CreateCDataSection([Nullable(2)] string data)
		{
			return new XObjectWrapper(new XCData(data));
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x000432E0 File Offset: 0x000414E0
		public IXmlNode CreateWhitespace([Nullable(2)] string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000432E0 File Offset: 0x000414E0
		public IXmlNode CreateSignificantWhitespace([Nullable(2)] string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x000432FA File Offset: 0x000414FA
		public IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone)
		{
			return new XDeclarationWrapper(new XDeclaration(version, encoding, standalone));
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00043309 File Offset: 0x00041509
		[NullableContext(2)]
		[return: Nullable(1)]
		public IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset)
		{
			return new XDocumentTypeWrapper(new XDocumentType(name, publicId, systemId, internalSubset));
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0004331A File Offset: 0x0004151A
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return new XProcessingInstructionWrapper(new XProcessingInstruction(target, data));
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00043328 File Offset: 0x00041528
		public IXmlElement CreateElement(string elementName)
		{
			return new XElementWrapper(new XElement(elementName));
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0004333A File Offset: 0x0004153A
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return new XElementWrapper(new XElement(XName.Get(MiscellaneousUtils.GetLocalName(qualifiedName), namespaceUri)));
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00043352 File Offset: 0x00041552
		public IXmlNode CreateAttribute(string name, string value)
		{
			return new XAttributeWrapper(new XAttribute(name, value));
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00043365 File Offset: 0x00041565
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return new XAttributeWrapper(new XAttribute(XName.Get(MiscellaneousUtils.GetLocalName(qualifiedName), namespaceUri), value));
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0004337E File Offset: 0x0004157E
		[Nullable(2)]
		public IXmlElement DocumentElement
		{
			[NullableContext(2)]
			get
			{
				if (this.Document.Root == null)
				{
					return null;
				}
				return new XElementWrapper(this.Document.Root);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000433A0 File Offset: 0x000415A0
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			XDeclarationWrapper xdeclarationWrapper = newChild as XDeclarationWrapper;
			if (xdeclarationWrapper != null)
			{
				this.Document.Declaration = xdeclarationWrapper.Declaration;
				return xdeclarationWrapper;
			}
			return base.AppendChild(newChild);
		}
	}
}
