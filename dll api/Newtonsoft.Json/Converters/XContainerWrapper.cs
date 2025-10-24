using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CF RID: 463
	[NullableContext(1)]
	[Nullable(0)]
	internal class XContainerWrapper : XObjectWrapper
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x000434BC File Offset: 0x000416BC
		private XContainer Container
		{
			get
			{
				return (XContainer)base.WrappedNode;
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000433DE File Offset: 0x000415DE
		public XContainerWrapper(XContainer container) : base(container)
		{
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000434CC File Offset: 0x000416CC
		public override List<IXmlNode> ChildNodes
		{
			get
			{
				if (this._childNodes == null)
				{
					if (!this.HasChildNodes)
					{
						this._childNodes = XmlNodeConverter.EmptyChildNodes;
					}
					else
					{
						this._childNodes = new List<IXmlNode>();
						foreach (XNode node in this.Container.Nodes())
						{
							this._childNodes.Add(XContainerWrapper.WrapNode(node));
						}
					}
				}
				return this._childNodes;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00043558 File Offset: 0x00041758
		protected virtual bool HasChildNodes
		{
			get
			{
				return this.Container.LastNode != null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00043568 File Offset: 0x00041768
		[Nullable(2)]
		public override IXmlNode ParentNode
		{
			[NullableContext(2)]
			get
			{
				if (this.Container.Parent == null)
				{
					return null;
				}
				return XContainerWrapper.WrapNode(this.Container.Parent);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0004358C File Offset: 0x0004178C
		internal static IXmlNode WrapNode(XObject node)
		{
			XDocument xdocument = node as XDocument;
			if (xdocument != null)
			{
				return new XDocumentWrapper(xdocument);
			}
			XElement xelement = node as XElement;
			if (xelement != null)
			{
				return new XElementWrapper(xelement);
			}
			XContainer xcontainer = node as XContainer;
			if (xcontainer != null)
			{
				return new XContainerWrapper(xcontainer);
			}
			XProcessingInstruction xprocessingInstruction = node as XProcessingInstruction;
			if (xprocessingInstruction != null)
			{
				return new XProcessingInstructionWrapper(xprocessingInstruction);
			}
			XText xtext = node as XText;
			if (xtext != null)
			{
				return new XTextWrapper(xtext);
			}
			XComment xcomment = node as XComment;
			if (xcomment != null)
			{
				return new XCommentWrapper(xcomment);
			}
			XAttribute xattribute = node as XAttribute;
			if (xattribute != null)
			{
				return new XAttributeWrapper(xattribute);
			}
			XDocumentType xdocumentType = node as XDocumentType;
			if (xdocumentType != null)
			{
				return new XDocumentTypeWrapper(xdocumentType);
			}
			return new XObjectWrapper(node);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00043633 File Offset: 0x00041833
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			this.Container.Add(newChild.WrappedNode);
			this._childNodes = null;
			return newChild;
		}

		// Token: 0x0400081C RID: 2076
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IXmlNode> _childNodes;
	}
}
