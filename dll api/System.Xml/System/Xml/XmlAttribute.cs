using System;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Represents an attribute. Valid and default values for the attribute are defined in a document type definition (DTD) or schema.</summary>
	// Token: 0x02000134 RID: 308
	public class XmlAttribute : XmlNode
	{
		// Token: 0x06000A52 RID: 2642 RVA: 0x000465CC File Offset: 0x000447CC
		internal XmlAttribute(XmlName name, XmlDocument doc) : base(doc)
		{
			this.parentNode = null;
			if (!doc.IsLoading)
			{
				XmlDocument.CheckName(name.Prefix);
				XmlDocument.CheckName(name.LocalName);
			}
			if (name.LocalName.Length == 0)
			{
				throw new ArgumentException(Res.GetString("The attribute local name cannot be empty."));
			}
			this.name = name;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00046629 File Offset: 0x00044829
		internal int LocalNameHash
		{
			get
			{
				return this.name.HashCode;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlAttribute" /> class.</summary>
		/// <param name="prefix">The namespace prefix.</param>
		/// <param name="localName">The local name of the attribute.</param>
		/// <param name="namespaceURI">The namespace uniform resource identifier (URI).</param>
		/// <param name="doc">The parent XML document.</param>
		// Token: 0x06000A54 RID: 2644 RVA: 0x00046636 File Offset: 0x00044836
		protected internal XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) : this(doc.AddAttrXmlName(prefix, localName, namespaceURI, null), doc)
		{
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0004664B File Offset: 0x0004484B
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00046653 File Offset: 0x00044853
		internal XmlName XmlName
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself </param>
		/// <returns>The duplicate node.</returns>
		// Token: 0x06000A57 RID: 2647 RVA: 0x0004665C File Offset: 0x0004485C
		public override XmlNode CloneNode(bool deep)
		{
			XmlDocument ownerDocument = this.OwnerDocument;
			XmlAttribute xmlAttribute = ownerDocument.CreateAttribute(this.Prefix, this.LocalName, this.NamespaceURI);
			xmlAttribute.CopyChildren(ownerDocument, this, true);
			return xmlAttribute;
		}

		/// <summary>Gets the parent of this node. For <see langword="XmlAttribute" /> nodes, this property always returns <see langword="null" />.</summary>
		/// <returns>For <see langword="XmlAttribute" /> nodes, this property always returns <see langword="null" />.</returns>
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0001520A File Offset: 0x0001340A
		public override XmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>The qualified name of the attribute node.</returns>
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00046691 File Offset: 0x00044891
		public override string Name
		{
			get
			{
				return this.name.Name;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>The name of the attribute node with the prefix removed. In the following example &lt;book bk:genre= 'novel'&gt;, the <see langword="LocalName" /> of the attribute is <see langword="genre" />.</returns>
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0004669E File Offset: 0x0004489E
		public override string LocalName
		{
			get
			{
				return this.name.LocalName;
			}
		}

		/// <summary>Gets the namespace URI of this node.</summary>
		/// <returns>The namespace URI of this node. If the attribute is not explicitly given a namespace, this property returns String.Empty.</returns>
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x000466AB File Offset: 0x000448AB
		public override string NamespaceURI
		{
			get
			{
				return this.name.NamespaceURI;
			}
		}

		/// <summary>Gets or sets the namespace prefix of this node.</summary>
		/// <returns>The namespace prefix of this node. If there is no prefix, this property returns String.Empty.</returns>
		/// <exception cref="T:System.ArgumentException">This node is read-only.</exception>
		/// <exception cref="T:System.Xml.XmlException">The specified prefix contains an invalid character.The specified prefix is malformed.The namespaceURI of this node is <see langword="null" />.The specified prefix is "xml", and the namespaceURI of this node is different from "http://www.w3.org/XML/1998/namespace".This node is an attribute, the specified prefix is "xmlns", and the namespaceURI of this node is different from "http://www.w3.org/2000/xmlns/".This node is an attribute, and the qualifiedName of this node is "xmlns" [Namespaces].</exception>
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000466B8 File Offset: 0x000448B8
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x000466C5 File Offset: 0x000448C5
		public override string Prefix
		{
			get
			{
				return this.name.Prefix;
			}
			set
			{
				this.name = this.name.OwnerDocument.AddAttrXmlName(value, this.LocalName, this.NamespaceURI, this.SchemaInfo);
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>The node type for <see langword="XmlAttribute" /> nodes is XmlNodeType.Attribute.</returns>
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000466F0 File Offset: 0x000448F0
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Attribute;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.</summary>
		/// <returns>An XML document to which this node belongs.</returns>
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000466F3 File Offset: 0x000448F3
		public override XmlDocument OwnerDocument
		{
			get
			{
				return this.name.OwnerDocument;
			}
		}

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. For <see langword="XmlAttribute" /> nodes, this property is the value of attribute.</returns>
		/// <exception cref="T:System.ArgumentException">The node is read-only and a set operation is called.</exception>
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00046700 File Offset: 0x00044900
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00046708 File Offset: 0x00044908
		public override string Value
		{
			get
			{
				return this.InnerText;
			}
			set
			{
				this.InnerText = value;
			}
		}

		/// <summary>Gets the post-schema-validation-infoset that has been assigned to this node as a result of schema validation.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> containing the post-schema-validation-infoset of this node.</returns>
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0004664B File Offset: 0x0004484B
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Sets the concatenated values of the node and all its children.</summary>
		/// <returns>The concatenated values of the node and all its children. For attribute nodes, this property has the same functionality as the <see cref="P:System.Xml.XmlAttribute.Value" /> property.</returns>
		// Token: 0x170001C0 RID: 448
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00046714 File Offset: 0x00044914
		public override string InnerText
		{
			set
			{
				if (this.PrepareOwnerElementInElementIdAttrMap())
				{
					string innerText = base.InnerText;
					base.InnerText = value;
					this.ResetOwnerElementInElementIdAttrMap(innerText);
					return;
				}
				base.InnerText = value;
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00046748 File Offset: 0x00044948
		internal bool PrepareOwnerElementInElementIdAttrMap()
		{
			if (this.OwnerDocument.DtdSchemaInfo != null)
			{
				XmlElement ownerElement = this.OwnerElement;
				if (ownerElement != null)
				{
					return ownerElement.Attributes.PrepareParentInElementIdAttrMap(this.Prefix, this.LocalName);
				}
			}
			return false;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00046788 File Offset: 0x00044988
		internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText)
		{
			XmlElement ownerElement = this.OwnerElement;
			if (ownerElement != null)
			{
				ownerElement.Attributes.ResetParentInElementIdAttrMap(oldInnerText, this.InnerText);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000467B4 File Offset: 0x000449B4
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
				doc.BeforeEvent(insertEventArgsForLoad);
			}
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			if (this.lastChild == null)
			{
				xmlLinkedNode.next = xmlLinkedNode;
				this.lastChild = xmlLinkedNode;
				xmlLinkedNode.SetParentForLoad(this);
			}
			else
			{
				XmlLinkedNode xmlLinkedNode2 = this.lastChild;
				xmlLinkedNode.next = xmlLinkedNode2.next;
				xmlLinkedNode2.next = xmlLinkedNode;
				this.lastChild = xmlLinkedNode;
				if (xmlLinkedNode2.IsText && xmlLinkedNode.IsText)
				{
					XmlNode.NestTextNodes(xmlLinkedNode2, xmlLinkedNode);
				}
				else
				{
					xmlLinkedNode.SetParentForLoad(this);
				}
			}
			if (insertEventArgsForLoad != null)
			{
				doc.AfterEvent(insertEventArgsForLoad);
			}
			return xmlLinkedNode;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00046846 File Offset: 0x00044A46
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x0004684E File Offset: 0x00044A4E
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

		// Token: 0x06000A6A RID: 2666 RVA: 0x00046857 File Offset: 0x00044A57
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return type == XmlNodeType.Text || type == XmlNodeType.EntityReference;
		}

		/// <summary>Gets a value indicating whether the attribute value was explicitly set.</summary>
		/// <returns>
		///     <see langword="true" /> if this attribute was explicitly given a value in the original instance document; otherwise, <see langword="false" />. A value of <see langword="false" /> indicates that the value of the attribute came from the DTD.</returns>
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public virtual bool Specified
		{
			get
			{
				return true;
			}
		}

		/// <summary>Inserts the specified node immediately before the specified reference node.</summary>
		/// <param name="newChild">The <see cref="T:System.Xml.XmlNode" /> to insert.</param>
		/// <param name="refChild">The <see cref="T:System.Xml.XmlNode" /> that is the reference node. The <paramref name="newChild" /> is placed before this node.</param>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> inserted.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only.</exception>
		// Token: 0x06000A6C RID: 2668 RVA: 0x00046864 File Offset: 0x00044A64
		public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.InsertBefore(newChild, refChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.InsertBefore(newChild, refChild);
			}
			return result;
		}

		/// <summary>Inserts the specified node immediately after the specified reference node.</summary>
		/// <param name="newChild">The <see cref="T:System.Xml.XmlNode" /> to insert.</param>
		/// <param name="refChild">The <see cref="T:System.Xml.XmlNode" /> that is the reference node. The <paramref name="newChild" /> is placed after the <paramref name="refChild" />.</param>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> inserted.</returns>
		/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only.</exception>
		// Token: 0x06000A6D RID: 2669 RVA: 0x0004689C File Offset: 0x00044A9C
		public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.InsertAfter(newChild, refChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.InsertAfter(newChild, refChild);
			}
			return result;
		}

		/// <summary>Removes the specified child node.</summary>
		/// <param name="oldChild">The <see cref="T:System.Xml.XmlNode" /> to remove.</param>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> removed.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="oldChild" /> is not a child of this node. Or this node is read-only.</exception>
		// Token: 0x06000A6E RID: 2670 RVA: 0x000468D4 File Offset: 0x00044AD4
		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.RemoveChild(oldChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.RemoveChild(oldChild);
			}
			return result;
		}

		/// <summary>Adds the specified node to the beginning of the list of child nodes for this node.</summary>
		/// <param name="newChild">The <see cref="T:System.Xml.XmlNode" /> to add. If it is an <see cref="T:System.Xml.XmlDocumentFragment" />, the entire contents of the document fragment are moved into the child list of this node.</param>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> added.</returns>
		/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only.</exception>
		// Token: 0x06000A6F RID: 2671 RVA: 0x0004690C File Offset: 0x00044B0C
		public override XmlNode PrependChild(XmlNode newChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.PrependChild(newChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.PrependChild(newChild);
			}
			return result;
		}

		/// <summary>Adds the specified node to the end of the list of child nodes, of this node.</summary>
		/// <param name="newChild">The <see cref="T:System.Xml.XmlNode" /> to add.</param>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> added.</returns>
		/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only.</exception>
		// Token: 0x06000A70 RID: 2672 RVA: 0x00046944 File Offset: 0x00044B44
		public override XmlNode AppendChild(XmlNode newChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.AppendChild(newChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.AppendChild(newChild);
			}
			return result;
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlElement" /> to which the attribute belongs.</summary>
		/// <returns>The <see langword="XmlElement" /> that the attribute belongs to or <see langword="null" /> if this attribute is not part of an <see langword="XmlElement" />.</returns>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0004697A File Offset: 0x00044B7A
		public virtual XmlElement OwnerElement
		{
			get
			{
				return this.parentNode as XmlElement;
			}
		}

		/// <summary>Sets the value of the attribute.</summary>
		/// <returns>The attribute value.</returns>
		/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed.</exception>
		// Token: 0x170001C5 RID: 453
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00046987 File Offset: 0x00044B87
		public override string InnerXml
		{
			set
			{
				this.RemoveAll();
				new XmlLoader().LoadInnerXmlAttribute(this, value);
			}
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save.</param>
		// Token: 0x06000A73 RID: 2675 RVA: 0x0004699B File Offset: 0x00044B9B
		public override void WriteTo(XmlWriter w)
		{
			w.WriteStartAttribute(this.Prefix, this.LocalName, this.NamespaceURI);
			this.WriteContentTo(w);
			w.WriteEndAttribute();
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save.</param>
		// Token: 0x06000A74 RID: 2676 RVA: 0x000469C4 File Offset: 0x00044BC4
		public override void WriteContentTo(XmlWriter w)
		{
			for (XmlNode xmlNode = this.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				xmlNode.WriteTo(w);
			}
		}

		/// <summary>Gets the base Uniform Resource Identifier (URI) of the node.</summary>
		/// <returns>The location from which the node was loaded or String.Empty if the node has no base URI. Attribute nodes have the same base URI as their owner element. If an attribute node does not have an owner element, <see langword="BaseURI" /> returns String.Empty.</returns>
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x000469EB File Offset: 0x00044BEB
		public override string BaseURI
		{
			get
			{
				if (this.OwnerElement != null)
				{
					return this.OwnerElement.BaseURI;
				}
				return string.Empty;
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00046A06 File Offset: 0x00044C06
		internal override void SetParent(XmlNode node)
		{
			this.parentNode = node;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00046A0F File Offset: 0x00044C0F
		internal override XmlSpace XmlSpace
		{
			get
			{
				if (this.OwnerElement != null)
				{
					return this.OwnerElement.XmlSpace;
				}
				return XmlSpace.None;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00046A26 File Offset: 0x00044C26
		internal override string XmlLang
		{
			get
			{
				if (this.OwnerElement != null)
				{
					return this.OwnerElement.XmlLang;
				}
				return string.Empty;
			}
		}

		// Token: 0x04000862 RID: 2146
		private XmlName name;

		// Token: 0x04000863 RID: 2147
		private XmlLinkedNode lastChild;
	}
}
