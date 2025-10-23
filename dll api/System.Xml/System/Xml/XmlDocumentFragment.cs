using System;

namespace System.Xml
{
	/// <summary>Represents a lightweight object that is useful for tree insert operations.</summary>
	// Token: 0x0200013D RID: 317
	public class XmlDocumentFragment : XmlNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlDocumentFragment" /> class.</summary>
		/// <param name="ownerDocument">The XML document that is the source of the fragment.</param>
		// Token: 0x06000B23 RID: 2851 RVA: 0x00048944 File Offset: 0x00046B44
		protected internal XmlDocumentFragment(XmlDocument ownerDocument)
		{
			if (ownerDocument == null)
			{
				throw new ArgumentException(Res.GetString("Cannot create a node without an owner document."));
			}
			this.parentNode = ownerDocument;
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For <see langword="XmlDocumentFragment" />, the name is <see langword="#document-fragment" />.</returns>
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00048966 File Offset: 0x00046B66
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strDocumentFragmentName;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For <see langword="XmlDocumentFragment" /> nodes, the local name is <see langword="#document-fragment" />.</returns>
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00048966 File Offset: 0x00046B66
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strDocumentFragmentName;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>For <see langword="XmlDocumentFragment" /> nodes, this value is XmlNodeType.DocumentFragment.</returns>
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00048973 File Offset: 0x00046B73
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.DocumentFragment;
			}
		}

		/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
		/// <returns>The parent of this node.For <see langword="XmlDocumentFragment" /> nodes, this property is always <see langword="null" />.</returns>
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0001520A File Offset: 0x0001340A
		public override XmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.</summary>
		/// <returns>The <see langword="XmlDocument" /> to which this node belongs.</returns>
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00048977 File Offset: 0x00046B77
		public override XmlDocument OwnerDocument
		{
			get
			{
				return (XmlDocument)this.parentNode;
			}
		}

		/// <summary>Gets or sets the markup representing the children of this node.</summary>
		/// <returns>The markup of the children of this node.</returns>
		/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed. </exception>
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00048439 File Offset: 0x00046639
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00048984 File Offset: 0x00046B84
		public override string InnerXml
		{
			get
			{
				return base.InnerXml;
			}
			set
			{
				this.RemoveAll();
				new XmlLoader().ParsePartialContent(this, value, XmlNodeType.Element);
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000B2B RID: 2859 RVA: 0x0004899C File Offset: 0x00046B9C
		public override XmlNode CloneNode(bool deep)
		{
			XmlDocument ownerDocument = this.OwnerDocument;
			XmlDocumentFragment xmlDocumentFragment = ownerDocument.CreateDocumentFragment();
			if (deep)
			{
				xmlDocumentFragment.CopyChildren(ownerDocument, this, deep);
			}
			return xmlDocumentFragment;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x000489C4 File Offset: 0x00046BC4
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x000489CC File Offset: 0x00046BCC
		internal override XmlLinkedNode LastNode
		{
			get
			{
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000489D8 File Offset: 0x00046BD8
		internal override bool IsValidChildType(XmlNodeType type)
		{
			switch (type)
			{
			case XmlNodeType.Element:
			case XmlNodeType.Text:
			case XmlNodeType.CDATA:
			case XmlNodeType.EntityReference:
			case XmlNodeType.ProcessingInstruction:
			case XmlNodeType.Comment:
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				return true;
			case XmlNodeType.XmlDeclaration:
			{
				XmlNode firstChild = this.FirstChild;
				return firstChild == null || firstChild.NodeType != XmlNodeType.XmlDeclaration;
			}
			}
			return false;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00048A4E File Offset: 0x00046C4E
		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return newChild.NodeType != XmlNodeType.XmlDeclaration || (refChild == null && this.LastNode == null);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00048A6A File Offset: 0x00046C6A
		internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			return newChild.NodeType != XmlNodeType.XmlDeclaration || refChild == null || refChild == this.FirstChild;
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B32 RID: 2866 RVA: 0x000484E5 File Offset: 0x000466E5
		public override void WriteTo(XmlWriter w)
		{
			this.WriteContentTo(w);
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B33 RID: 2867 RVA: 0x00048A88 File Offset: 0x00046C88
		public override void WriteContentTo(XmlWriter w)
		{
			foreach (object obj in this)
			{
				((XmlNode)obj).WriteTo(w);
			}
		}

		// Token: 0x04000898 RID: 2200
		private XmlLinkedNode lastChild;
	}
}
