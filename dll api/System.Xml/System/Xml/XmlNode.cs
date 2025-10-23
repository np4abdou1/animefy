using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Represents a single node in the XML document. </summary>
	// Token: 0x0200014C RID: 332
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlNode : ICloneable, IEnumerable
	{
		// Token: 0x06000BEF RID: 3055 RVA: 0x0000A20E File Offset: 0x0000840E
		internal XmlNode()
		{
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0004B7F1 File Offset: 0x000499F1
		internal XmlNode(XmlDocument doc)
		{
			if (doc == null)
			{
				throw new ArgumentException(Res.GetString("Cannot create a node without an owner document."));
			}
			this.parentNode = doc;
		}

		/// <summary>Gets the qualified name of the node, when overridden in a derived class.</summary>
		/// <returns>The qualified name of the node. The name returned is dependent on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node: Type Name Attribute The qualified name of the attribute. CDATA #cdata-section Comment #comment Document #document DocumentFragment #document-fragment DocumentType The document type name. Element The qualified name of the element. Entity The name of the entity. EntityReference The name of the entity referenced. Notation The notation name. ProcessingInstruction The target of the processing instruction. Text #text Whitespace #whitespace SignificantWhitespace #significant-whitespace XmlDeclaration #xml-declaration </returns>
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000BF1 RID: 3057
		public abstract string Name { get; }

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node: Type Value Attribute The value of the attribute. CDATASection The content of the CDATA Section. Comment The content of the comment. Document 
		///             <see langword="null" />. DocumentFragment 
		///             <see langword="null" />. DocumentType 
		///             <see langword="null" />. Element 
		///             <see langword="null" />. You can use the <see cref="P:System.Xml.XmlElement.InnerText" /> or <see cref="P:System.Xml.XmlElement.InnerXml" /> properties to access the value of the element node. Entity 
		///             <see langword="null" />. EntityReference 
		///             <see langword="null" />. Notation 
		///             <see langword="null" />. ProcessingInstruction The entire content excluding the target. Text The content of the text node. SignificantWhitespace The white space characters. White space can consist of one or more space characters, carriage returns, line feeds, or tabs. Whitespace The white space characters. White space can consist of one or more space characters, carriage returns, line feeds, or tabs. XmlDeclaration The content of the declaration (that is, everything between &lt;?xml and ?&gt;). </returns>
		/// <exception cref="T:System.ArgumentException">Setting the value of a node that is read-only. </exception>
		/// <exception cref="T:System.InvalidOperationException">Setting the value of a node that is not supposed to have a value (for example, an Element node). </exception>
		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0001520A File Offset: 0x0001340A
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x0004B814 File Offset: 0x00049A14
		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
				throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, Res.GetString("Cannot set a value on node type '{0}'."), this.NodeType.ToString()));
			}
		}

		/// <summary>Gets the type of the current node, when overridden in a derived class.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values.</returns>
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000BF4 RID: 3060
		public abstract XmlNodeType NodeType { get; }

		/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
		/// <returns>The <see langword="XmlNode" /> that is the parent of the current node. If a node has just been created and not yet added to the tree, or if it has been removed from the tree, the parent is <see langword="null" />. For all other nodes, the value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. The following table describes the possible return values for the <see langword="ParentNode" /> property.NodeType Return Value of ParentNode Attribute, Document, DocumentFragment, Entity, Notation Returns <see langword="null" />; these nodes do not have parents. CDATA Returns the element or entity reference containing the CDATA section. Comment Returns the element, entity reference, document type, or document containing the comment. DocumentType Returns the document node. Element Returns the parent node of the element. If the element is the root node in the tree, the parent is the document node. EntityReference Returns the element, attribute, or entity reference containing the entity reference. ProcessingInstruction Returns the document, element, document type, or entity reference containing the processing instruction. Text Returns the parent element, attribute, or entity reference containing the text node. </returns>
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0004B850 File Offset: 0x00049A50
		public virtual XmlNode ParentNode
		{
			get
			{
				if (this.parentNode.NodeType != XmlNodeType.Document)
				{
					return this.parentNode;
				}
				XmlLinkedNode xmlLinkedNode = this.parentNode.FirstChild as XmlLinkedNode;
				if (xmlLinkedNode != null)
				{
					XmlLinkedNode xmlLinkedNode2 = xmlLinkedNode;
					while (xmlLinkedNode2 != this)
					{
						xmlLinkedNode2 = xmlLinkedNode2.next;
						if (xmlLinkedNode2 == null || xmlLinkedNode2 == xmlLinkedNode)
						{
							goto IL_45;
						}
					}
					return this.parentNode;
				}
				IL_45:
				return null;
			}
		}

		/// <summary>Gets all the child nodes of the node.</summary>
		/// <returns>An object that contains all the child nodes of the node.If there are no child nodes, this property returns an empty <see cref="T:System.Xml.XmlNodeList" />.</returns>
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0004B8A3 File Offset: 0x00049AA3
		public virtual XmlNodeList ChildNodes
		{
			get
			{
				return new XmlChildNodes(this);
			}
		}

		/// <summary>Gets the node immediately preceding this node.</summary>
		/// <returns>The preceding <see langword="XmlNode" />. If there is no preceding node, <see langword="null" /> is returned.</returns>
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual XmlNode PreviousSibling
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the node immediately following this node.</summary>
		/// <returns>The next <see langword="XmlNode" />. If there is no next node, <see langword="null" /> is returned.</returns>
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual XmlNode NextSibling
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets an <see cref="T:System.Xml.XmlAttributeCollection" /> containing the attributes of this node.</summary>
		/// <returns>An <see langword="XmlAttributeCollection" /> containing the attributes of the node.If the node is of type XmlNodeType.Element, the attributes of the node are returned. Otherwise, this property returns <see langword="null" />.</returns>
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual XmlAttributeCollection Attributes
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.If the node is an <see cref="T:System.Xml.XmlDocument" /> (NodeType equals XmlNodeType.Document), this property returns <see langword="null" />.</returns>
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0004B8AB File Offset: 0x00049AAB
		public virtual XmlDocument OwnerDocument
		{
			get
			{
				if (this.parentNode.NodeType == XmlNodeType.Document)
				{
					return (XmlDocument)this.parentNode;
				}
				return this.parentNode.OwnerDocument;
			}
		}

		/// <summary>Gets the first child of the node.</summary>
		/// <returns>The first child of the node. If there is no such node, <see langword="null" /> is returned.</returns>
		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0004B8D4 File Offset: 0x00049AD4
		public virtual XmlNode FirstChild
		{
			get
			{
				XmlLinkedNode lastNode = this.LastNode;
				if (lastNode != null)
				{
					return lastNode.next;
				}
				return null;
			}
		}

		/// <summary>Gets the last child of the node.</summary>
		/// <returns>The last child of the node. If there is no such node, <see langword="null" /> is returned.</returns>
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0004B8F3 File Offset: 0x00049AF3
		public virtual XmlNode LastChild
		{
			get
			{
				return this.LastNode;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0000A216 File Offset: 0x00008416
		internal virtual bool IsContainer
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0001520A File Offset: 0x0001340A
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual XmlLinkedNode LastNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0004B8FC File Offset: 0x00049AFC
		internal bool AncestorNode(XmlNode node)
		{
			XmlNode xmlNode = this.ParentNode;
			while (xmlNode != null && xmlNode != this)
			{
				if (xmlNode == node)
				{
					return true;
				}
				xmlNode = xmlNode.ParentNode;
			}
			return false;
		}

		/// <summary>Inserts the specified node immediately before the specified reference node.</summary>
		/// <param name="newChild">The <see langword="XmlNode" /> to insert. </param>
		/// <param name="refChild">The <see langword="XmlNode" /> that is the reference node. The <paramref name="newChild" /> is placed before this node. </param>
		/// <returns>The node being inserted.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only. </exception>
		// Token: 0x06000C01 RID: 3073 RVA: 0x0004B928 File Offset: 0x00049B28
		public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
		{
			if (this == newChild || this.AncestorNode(newChild))
			{
				throw new ArgumentException(Res.GetString("Cannot insert a node or any ancestor of that node as a child of itself."));
			}
			if (refChild == null)
			{
				return this.AppendChild(newChild);
			}
			if (!this.IsContainer)
			{
				throw new InvalidOperationException(Res.GetString("The current node cannot contain other nodes."));
			}
			if (refChild.ParentNode != this)
			{
				throw new ArgumentException(Res.GetString("The reference node is not a child of this node."));
			}
			if (newChild == refChild)
			{
				return newChild;
			}
			XmlDocument ownerDocument = newChild.OwnerDocument;
			XmlDocument ownerDocument2 = this.OwnerDocument;
			if (ownerDocument != null && ownerDocument != ownerDocument2 && ownerDocument != this)
			{
				throw new ArgumentException(Res.GetString("The node to be inserted is from a different document context."));
			}
			if (!this.CanInsertBefore(newChild, refChild))
			{
				throw new InvalidOperationException(Res.GetString("Cannot insert the node in the specified location."));
			}
			if (newChild.ParentNode != null)
			{
				newChild.ParentNode.RemoveChild(newChild);
			}
			if (newChild.NodeType == XmlNodeType.DocumentFragment)
			{
				XmlNode firstChild;
				XmlNode result = firstChild = newChild.FirstChild;
				if (firstChild != null)
				{
					newChild.RemoveChild(firstChild);
					this.InsertBefore(firstChild, refChild);
					this.InsertAfter(newChild, firstChild);
				}
				return result;
			}
			if (!(newChild is XmlLinkedNode) || !this.IsValidChildType(newChild.NodeType))
			{
				throw new InvalidOperationException(Res.GetString("The specified node cannot be inserted as the valid child of this node, because the specified node is the wrong type."));
			}
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			XmlLinkedNode xmlLinkedNode2 = (XmlLinkedNode)refChild;
			string value = newChild.Value;
			XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(newChild, newChild.ParentNode, this, value, value, XmlNodeChangedAction.Insert);
			if (eventArgs != null)
			{
				this.BeforeEvent(eventArgs);
			}
			if (xmlLinkedNode2 == this.FirstChild)
			{
				xmlLinkedNode.next = xmlLinkedNode2;
				this.LastNode.next = xmlLinkedNode;
				xmlLinkedNode.SetParent(this);
				if (xmlLinkedNode.IsText && xmlLinkedNode2.IsText)
				{
					XmlNode.NestTextNodes(xmlLinkedNode, xmlLinkedNode2);
				}
			}
			else
			{
				XmlLinkedNode xmlLinkedNode3 = (XmlLinkedNode)xmlLinkedNode2.PreviousSibling;
				xmlLinkedNode.next = xmlLinkedNode2;
				xmlLinkedNode3.next = xmlLinkedNode;
				xmlLinkedNode.SetParent(this);
				if (xmlLinkedNode3.IsText)
				{
					if (xmlLinkedNode.IsText)
					{
						XmlNode.NestTextNodes(xmlLinkedNode3, xmlLinkedNode);
						if (xmlLinkedNode2.IsText)
						{
							XmlNode.NestTextNodes(xmlLinkedNode, xmlLinkedNode2);
						}
					}
					else if (xmlLinkedNode2.IsText)
					{
						XmlNode.UnnestTextNodes(xmlLinkedNode3, xmlLinkedNode2);
					}
				}
				else if (xmlLinkedNode.IsText && xmlLinkedNode2.IsText)
				{
					XmlNode.NestTextNodes(xmlLinkedNode, xmlLinkedNode2);
				}
			}
			if (eventArgs != null)
			{
				this.AfterEvent(eventArgs);
			}
			return xmlLinkedNode;
		}

		/// <summary>Inserts the specified node immediately after the specified reference node.</summary>
		/// <param name="newChild">The <see langword="XmlNode" /> to insert. </param>
		/// <param name="refChild">The <see langword="XmlNode" /> that is the reference node. The <paramref name="newNode" /> is placed after the <paramref name="refNode" />. </param>
		/// <returns>The node being inserted.</returns>
		/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only. </exception>
		// Token: 0x06000C02 RID: 3074 RVA: 0x0004BB40 File Offset: 0x00049D40
		public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
		{
			if (this == newChild || this.AncestorNode(newChild))
			{
				throw new ArgumentException(Res.GetString("Cannot insert a node or any ancestor of that node as a child of itself."));
			}
			if (refChild == null)
			{
				return this.PrependChild(newChild);
			}
			if (!this.IsContainer)
			{
				throw new InvalidOperationException(Res.GetString("The current node cannot contain other nodes."));
			}
			if (refChild.ParentNode != this)
			{
				throw new ArgumentException(Res.GetString("The reference node is not a child of this node."));
			}
			if (newChild == refChild)
			{
				return newChild;
			}
			XmlDocument ownerDocument = newChild.OwnerDocument;
			XmlDocument ownerDocument2 = this.OwnerDocument;
			if (ownerDocument != null && ownerDocument != ownerDocument2 && ownerDocument != this)
			{
				throw new ArgumentException(Res.GetString("The node to be inserted is from a different document context."));
			}
			if (!this.CanInsertAfter(newChild, refChild))
			{
				throw new InvalidOperationException(Res.GetString("Cannot insert the node in the specified location."));
			}
			if (newChild.ParentNode != null)
			{
				newChild.ParentNode.RemoveChild(newChild);
			}
			if (newChild.NodeType == XmlNodeType.DocumentFragment)
			{
				XmlNode refChild2 = refChild;
				XmlNode firstChild = newChild.FirstChild;
				XmlNode nextSibling;
				for (XmlNode xmlNode = firstChild; xmlNode != null; xmlNode = nextSibling)
				{
					nextSibling = xmlNode.NextSibling;
					newChild.RemoveChild(xmlNode);
					this.InsertAfter(xmlNode, refChild2);
					refChild2 = xmlNode;
				}
				return firstChild;
			}
			if (!(newChild is XmlLinkedNode) || !this.IsValidChildType(newChild.NodeType))
			{
				throw new InvalidOperationException(Res.GetString("The specified node cannot be inserted as the valid child of this node, because the specified node is the wrong type."));
			}
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			XmlLinkedNode xmlLinkedNode2 = (XmlLinkedNode)refChild;
			string value = newChild.Value;
			XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(newChild, newChild.ParentNode, this, value, value, XmlNodeChangedAction.Insert);
			if (eventArgs != null)
			{
				this.BeforeEvent(eventArgs);
			}
			if (xmlLinkedNode2 == this.LastNode)
			{
				xmlLinkedNode.next = xmlLinkedNode2.next;
				xmlLinkedNode2.next = xmlLinkedNode;
				this.LastNode = xmlLinkedNode;
				xmlLinkedNode.SetParent(this);
				if (xmlLinkedNode2.IsText && xmlLinkedNode.IsText)
				{
					XmlNode.NestTextNodes(xmlLinkedNode2, xmlLinkedNode);
				}
			}
			else
			{
				XmlLinkedNode next = xmlLinkedNode2.next;
				xmlLinkedNode.next = next;
				xmlLinkedNode2.next = xmlLinkedNode;
				xmlLinkedNode.SetParent(this);
				if (xmlLinkedNode2.IsText)
				{
					if (xmlLinkedNode.IsText)
					{
						XmlNode.NestTextNodes(xmlLinkedNode2, xmlLinkedNode);
						if (next.IsText)
						{
							XmlNode.NestTextNodes(xmlLinkedNode, next);
						}
					}
					else if (next.IsText)
					{
						XmlNode.UnnestTextNodes(xmlLinkedNode2, next);
					}
				}
				else if (xmlLinkedNode.IsText && next.IsText)
				{
					XmlNode.NestTextNodes(xmlLinkedNode, next);
				}
			}
			if (eventArgs != null)
			{
				this.AfterEvent(eventArgs);
			}
			return xmlLinkedNode;
		}

		/// <summary>Removes specified child node.</summary>
		/// <param name="oldChild">The node being removed. </param>
		/// <returns>The node removed.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="oldChild" /> is not a child of this node. Or this node is read-only. </exception>
		// Token: 0x06000C03 RID: 3075 RVA: 0x0004BD6C File Offset: 0x00049F6C
		public virtual XmlNode RemoveChild(XmlNode oldChild)
		{
			if (!this.IsContainer)
			{
				throw new InvalidOperationException(Res.GetString("The current node cannot contain other nodes, so the node to be removed is not its child."));
			}
			if (oldChild.ParentNode != this)
			{
				throw new ArgumentException(Res.GetString("The node to be removed is not a child of this node."));
			}
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)oldChild;
			string value = xmlLinkedNode.Value;
			XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(xmlLinkedNode, this, null, value, value, XmlNodeChangedAction.Remove);
			if (eventArgs != null)
			{
				this.BeforeEvent(eventArgs);
			}
			XmlLinkedNode lastNode = this.LastNode;
			if (xmlLinkedNode == this.FirstChild)
			{
				if (xmlLinkedNode == lastNode)
				{
					this.LastNode = null;
					xmlLinkedNode.next = null;
					xmlLinkedNode.SetParent(null);
				}
				else
				{
					XmlLinkedNode next = xmlLinkedNode.next;
					if (next.IsText && xmlLinkedNode.IsText)
					{
						XmlNode.UnnestTextNodes(xmlLinkedNode, next);
					}
					lastNode.next = next;
					xmlLinkedNode.next = null;
					xmlLinkedNode.SetParent(null);
				}
			}
			else if (xmlLinkedNode == lastNode)
			{
				XmlLinkedNode xmlLinkedNode2 = (XmlLinkedNode)xmlLinkedNode.PreviousSibling;
				xmlLinkedNode2.next = xmlLinkedNode.next;
				this.LastNode = xmlLinkedNode2;
				xmlLinkedNode.next = null;
				xmlLinkedNode.SetParent(null);
			}
			else
			{
				XmlLinkedNode xmlLinkedNode3 = (XmlLinkedNode)xmlLinkedNode.PreviousSibling;
				XmlLinkedNode next2 = xmlLinkedNode.next;
				if (next2.IsText)
				{
					if (xmlLinkedNode3.IsText)
					{
						XmlNode.NestTextNodes(xmlLinkedNode3, next2);
					}
					else if (xmlLinkedNode.IsText)
					{
						XmlNode.UnnestTextNodes(xmlLinkedNode, next2);
					}
				}
				xmlLinkedNode3.next = next2;
				xmlLinkedNode.next = null;
				xmlLinkedNode.SetParent(null);
			}
			if (eventArgs != null)
			{
				this.AfterEvent(eventArgs);
			}
			return oldChild;
		}

		/// <summary>Adds the specified node to the beginning of the list of child nodes for this node.</summary>
		/// <param name="newChild">The node to add. All the contents of the node to be added are moved into the specified location.</param>
		/// <returns>The node added.</returns>
		/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only. </exception>
		// Token: 0x06000C04 RID: 3076 RVA: 0x0004BED3 File Offset: 0x0004A0D3
		public virtual XmlNode PrependChild(XmlNode newChild)
		{
			return this.InsertBefore(newChild, this.FirstChild);
		}

		/// <summary>Adds the specified node to the end of the list of child nodes, of this node.</summary>
		/// <param name="newChild">The node to add. All the contents of the node to be added are moved into the specified location. </param>
		/// <returns>The node added.</returns>
		/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only. </exception>
		// Token: 0x06000C05 RID: 3077 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
		public virtual XmlNode AppendChild(XmlNode newChild)
		{
			XmlDocument xmlDocument = this.OwnerDocument;
			if (xmlDocument == null)
			{
				xmlDocument = (this as XmlDocument);
			}
			if (!this.IsContainer)
			{
				throw new InvalidOperationException(Res.GetString("The current node cannot contain other nodes."));
			}
			if (this == newChild || this.AncestorNode(newChild))
			{
				throw new ArgumentException(Res.GetString("Cannot insert a node or any ancestor of that node as a child of itself."));
			}
			if (newChild.ParentNode != null)
			{
				newChild.ParentNode.RemoveChild(newChild);
			}
			XmlDocument ownerDocument = newChild.OwnerDocument;
			if (ownerDocument != null && ownerDocument != xmlDocument && ownerDocument != this)
			{
				throw new ArgumentException(Res.GetString("The node to be inserted is from a different document context."));
			}
			if (newChild.NodeType == XmlNodeType.DocumentFragment)
			{
				XmlNode firstChild = newChild.FirstChild;
				XmlNode nextSibling;
				for (XmlNode xmlNode = firstChild; xmlNode != null; xmlNode = nextSibling)
				{
					nextSibling = xmlNode.NextSibling;
					newChild.RemoveChild(xmlNode);
					this.AppendChild(xmlNode);
				}
				return firstChild;
			}
			if (!(newChild is XmlLinkedNode) || !this.IsValidChildType(newChild.NodeType))
			{
				throw new InvalidOperationException(Res.GetString("The specified node cannot be inserted as the valid child of this node, because the specified node is the wrong type."));
			}
			if (!this.CanInsertAfter(newChild, this.LastChild))
			{
				throw new InvalidOperationException(Res.GetString("Cannot insert the node in the specified location."));
			}
			string value = newChild.Value;
			XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(newChild, newChild.ParentNode, this, value, value, XmlNodeChangedAction.Insert);
			if (eventArgs != null)
			{
				this.BeforeEvent(eventArgs);
			}
			XmlLinkedNode lastNode = this.LastNode;
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			if (lastNode == null)
			{
				xmlLinkedNode.next = xmlLinkedNode;
				this.LastNode = xmlLinkedNode;
				xmlLinkedNode.SetParent(this);
			}
			else
			{
				xmlLinkedNode.next = lastNode.next;
				lastNode.next = xmlLinkedNode;
				this.LastNode = xmlLinkedNode;
				xmlLinkedNode.SetParent(this);
				if (lastNode.IsText && xmlLinkedNode.IsText)
				{
					XmlNode.NestTextNodes(lastNode, xmlLinkedNode);
				}
			}
			if (eventArgs != null)
			{
				this.AfterEvent(eventArgs);
			}
			return xmlLinkedNode;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0004C090 File Offset: 0x0004A290
		internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
				doc.BeforeEvent(insertEventArgsForLoad);
			}
			XmlLinkedNode lastNode = this.LastNode;
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			if (lastNode == null)
			{
				xmlLinkedNode.next = xmlLinkedNode;
				this.LastNode = xmlLinkedNode;
				xmlLinkedNode.SetParentForLoad(this);
			}
			else
			{
				xmlLinkedNode.next = lastNode.next;
				lastNode.next = xmlLinkedNode;
				this.LastNode = xmlLinkedNode;
				if (lastNode.IsText && xmlLinkedNode.IsText)
				{
					XmlNode.NestTextNodes(lastNode, xmlLinkedNode);
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

		// Token: 0x06000C07 RID: 3079 RVA: 0x0000A216 File Offset: 0x00008416
		internal virtual bool IsValidChildType(XmlNodeType type)
		{
			return false;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			return true;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return true;
		}

		/// <summary>Gets a value indicating whether this node has any child nodes.</summary>
		/// <returns>
		///     <see langword="true" /> if the node has child nodes; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0004C11D File Offset: 0x0004A31D
		public virtual bool HasChildNodes
		{
			get
			{
				return this.LastNode != null;
			}
		}

		/// <summary>Creates a duplicate of the node, when overridden in a derived class.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. </param>
		/// <returns>The cloned node.</returns>
		/// <exception cref="T:System.InvalidOperationException">Calling this method on a node type that cannot be cloned. </exception>
		// Token: 0x06000C0B RID: 3083
		public abstract XmlNode CloneNode(bool deep);

		// Token: 0x06000C0C RID: 3084 RVA: 0x0004C128 File Offset: 0x0004A328
		internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep)
		{
			for (XmlNode xmlNode = container.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				this.AppendChildForLoad(xmlNode.CloneNode(deep), doc);
			}
		}

		/// <summary>Gets the namespace URI of this node.</summary>
		/// <returns>The namespace URI of this node. If there is no namespace URI, this property returns String.Empty.</returns>
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00015248 File Offset: 0x00013448
		public virtual string NamespaceURI
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>Gets or sets the namespace prefix of this node.</summary>
		/// <returns>The namespace prefix of this node. For example, <see langword="Prefix" /> is bk for the element &lt;bk:book&gt;. If there is no prefix, this property returns String.Empty.</returns>
		/// <exception cref="T:System.ArgumentException">This node is read-only. </exception>
		/// <exception cref="T:System.Xml.XmlException">The specified prefix contains an invalid character.The specified prefix is malformed.The specified prefix is "xml" and the namespaceURI of this node is different from "http://www.w3.org/XML/1998/namespace".This node is an attribute and the specified prefix is "xmlns" and the namespaceURI of this node is different from "http://www.w3.org/2000/xmlns/ ".This node is an attribute and the qualifiedName of this node is "xmlns". </exception>
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00015248 File Offset: 0x00013448
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00008574 File Offset: 0x00006774
		public virtual string Prefix
		{
			get
			{
				return string.Empty;
			}
			set
			{
			}
		}

		/// <summary>Gets the local name of the node, when overridden in a derived class.</summary>
		/// <returns>The name of the node with the prefix removed. For example, <see langword="LocalName" /> is book for the element &lt;bk:book&gt;.The name returned is dependent on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node: Type Name Attribute The local name of the attribute. CDATA #cdata-section Comment #comment Document #document DocumentFragment #document-fragment DocumentType The document type name. Element The local name of the element. Entity The name of the entity. EntityReference The name of the entity referenced. Notation The notation name. ProcessingInstruction The target of the processing instruction. Text #text Whitespace #whitespace SignificantWhitespace #significant-whitespace XmlDeclaration #xml-declaration </returns>
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000C10 RID: 3088
		public abstract string LocalName { get; }

		/// <summary>Gets a value indicating whether the node is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the node is read-only; otherwise <see langword="false" />.</returns>
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0004C157 File Offset: 0x0004A357
		public virtual bool IsReadOnly
		{
			get
			{
				XmlDocument ownerDocument = this.OwnerDocument;
				return XmlNode.HasReadOnlyParent(this);
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0004C168 File Offset: 0x0004A368
		internal static bool HasReadOnlyParent(XmlNode n)
		{
			while (n != null)
			{
				XmlNodeType nodeType = n.NodeType;
				if (nodeType != XmlNodeType.Attribute)
				{
					if (nodeType - XmlNodeType.EntityReference <= 1)
					{
						return true;
					}
					n = n.ParentNode;
				}
				else
				{
					n = ((XmlAttribute)n).OwnerElement;
				}
			}
			return false;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.XmlNode.Clone" />.</summary>
		/// <returns>A copy of the node from which it is called.</returns>
		// Token: 0x06000C13 RID: 3091 RVA: 0x0004C1A5 File Offset: 0x0004A3A5
		object ICloneable.Clone()
		{
			return this.CloneNode(true);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.XmlNode.GetEnumerator" />.</summary>
		/// <returns>Returns an enumerator for the collection.</returns>
		// Token: 0x06000C14 RID: 3092 RVA: 0x0004C1AE File Offset: 0x0004A3AE
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new XmlChildEnumerator(this);
		}

		/// <summary>Get an enumerator that iterates through the child nodes in the current node.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the child nodes in the current node.</returns>
		// Token: 0x06000C15 RID: 3093 RVA: 0x0004C1AE File Offset: 0x0004A3AE
		public IEnumerator GetEnumerator()
		{
			return new XmlChildEnumerator(this);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0004C1B8 File Offset: 0x0004A3B8
		private void AppendChildText(StringBuilder builder)
		{
			for (XmlNode xmlNode = this.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				if (xmlNode.FirstChild == null)
				{
					if (xmlNode.NodeType == XmlNodeType.Text || xmlNode.NodeType == XmlNodeType.CDATA || xmlNode.NodeType == XmlNodeType.Whitespace || xmlNode.NodeType == XmlNodeType.SignificantWhitespace)
					{
						builder.Append(xmlNode.InnerText);
					}
				}
				else
				{
					xmlNode.AppendChildText(builder);
				}
			}
		}

		/// <summary>Gets or sets the concatenated values of the node and all its child nodes.</summary>
		/// <returns>The concatenated values of the node and all its child nodes.</returns>
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0004C21C File Offset: 0x0004A41C
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x0004C270 File Offset: 0x0004A470
		public virtual string InnerText
		{
			get
			{
				XmlNode firstChild = this.FirstChild;
				if (firstChild == null)
				{
					return string.Empty;
				}
				if (firstChild.NextSibling == null)
				{
					XmlNodeType nodeType = firstChild.NodeType;
					if (nodeType - XmlNodeType.Text <= 1 || nodeType - XmlNodeType.Whitespace <= 1)
					{
						return firstChild.Value;
					}
				}
				StringBuilder stringBuilder = new StringBuilder();
				this.AppendChildText(stringBuilder);
				return stringBuilder.ToString();
			}
			set
			{
				XmlNode firstChild = this.FirstChild;
				if (firstChild != null && firstChild.NextSibling == null && firstChild.NodeType == XmlNodeType.Text)
				{
					firstChild.Value = value;
					return;
				}
				this.RemoveAll();
				this.AppendChild(this.OwnerDocument.CreateTextNode(value));
			}
		}

		/// <summary>Gets or sets the markup representing only the child nodes of this node.</summary>
		/// <returns>The markup of the child nodes of this node.
		///       <see langword="InnerXml" /> does not return default attributes.</returns>
		/// <exception cref="T:System.InvalidOperationException">Setting this property on a node that cannot have child nodes. </exception>
		/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed. </exception>
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0004C2BC File Offset: 0x0004A4BC
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00049473 File Offset: 0x00047673
		public virtual string InnerXml
		{
			get
			{
				StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
				XmlDOMTextWriter xmlDOMTextWriter = new XmlDOMTextWriter(stringWriter);
				try
				{
					this.WriteContentTo(xmlDOMTextWriter);
				}
				finally
				{
					xmlDOMTextWriter.Close();
				}
				return stringWriter.ToString();
			}
			set
			{
				throw new InvalidOperationException(Res.GetString("Cannot set the 'InnerXml' for the current node because it is either read-only or cannot have children."));
			}
		}

		/// <summary>Gets the post schema validation infoset that has been assigned to this node as a result of schema validation.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object containing the post schema validation infoset of this node.</returns>
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0004C304 File Offset: 0x0004A504
		public virtual IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return XmlDocument.NotKnownSchemaInfo;
			}
		}

		/// <summary>Gets the base URI of the current node.</summary>
		/// <returns>The location from which the node was loaded or String.Empty if the node has no base URI.</returns>
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0004C30C File Offset: 0x0004A50C
		public virtual string BaseURI
		{
			get
			{
				for (XmlNode xmlNode = this.ParentNode; xmlNode != null; xmlNode = xmlNode.ParentNode)
				{
					XmlNodeType nodeType = xmlNode.NodeType;
					if (nodeType == XmlNodeType.EntityReference)
					{
						return ((XmlEntityReference)xmlNode).ChildBaseURI;
					}
					if (nodeType == XmlNodeType.Document || nodeType == XmlNodeType.Entity || nodeType == XmlNodeType.Attribute)
					{
						return xmlNode.BaseURI;
					}
				}
				return string.Empty;
			}
		}

		/// <summary>Saves the current node to the specified <see cref="T:System.Xml.XmlWriter" />, when overridden in a derived class.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000C1D RID: 3101
		public abstract void WriteTo(XmlWriter w);

		/// <summary>Saves all the child nodes of the node to the specified <see cref="T:System.Xml.XmlWriter" />, when overridden in a derived class.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000C1E RID: 3102
		public abstract void WriteContentTo(XmlWriter w);

		/// <summary>Removes all the child nodes and/or attributes of the current node.</summary>
		// Token: 0x06000C1F RID: 3103 RVA: 0x0004C35C File Offset: 0x0004A55C
		public virtual void RemoveAll()
		{
			XmlNode nextSibling;
			for (XmlNode xmlNode = this.FirstChild; xmlNode != null; xmlNode = nextSibling)
			{
				nextSibling = xmlNode.NextSibling;
				this.RemoveChild(xmlNode);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0004C384 File Offset: 0x0004A584
		internal XmlDocument Document
		{
			get
			{
				if (this.NodeType == XmlNodeType.Document)
				{
					return (XmlDocument)this;
				}
				return this.OwnerDocument;
			}
		}

		/// <summary>Looks up the closest xmlns declaration for the given namespace URI that is in scope for the current node and returns the prefix defined in that declaration.</summary>
		/// <param name="namespaceURI">The namespace URI whose prefix you want to find. </param>
		/// <returns>The prefix for the specified namespace URI.</returns>
		// Token: 0x06000C21 RID: 3105 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
		public virtual string GetPrefixOfNamespace(string namespaceURI)
		{
			string prefixOfNamespaceStrict = this.GetPrefixOfNamespaceStrict(namespaceURI);
			if (prefixOfNamespaceStrict == null)
			{
				return string.Empty;
			}
			return prefixOfNamespaceStrict;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0004C3C0 File Offset: 0x0004A5C0
		internal string GetPrefixOfNamespaceStrict(string namespaceURI)
		{
			XmlDocument document = this.Document;
			if (document != null)
			{
				namespaceURI = document.NameTable.Add(namespaceURI);
				XmlNode xmlNode = this;
				while (xmlNode != null)
				{
					if (xmlNode.NodeType == XmlNodeType.Element)
					{
						XmlElement xmlElement = (XmlElement)xmlNode;
						if (xmlElement.HasAttributes)
						{
							XmlAttributeCollection attributes = xmlElement.Attributes;
							for (int i = 0; i < attributes.Count; i++)
							{
								XmlAttribute xmlAttribute = attributes[i];
								if (xmlAttribute.Prefix.Length == 0)
								{
									if (Ref.Equal(xmlAttribute.LocalName, document.strXmlns) && xmlAttribute.Value == namespaceURI)
									{
										return string.Empty;
									}
								}
								else if (Ref.Equal(xmlAttribute.Prefix, document.strXmlns))
								{
									if (xmlAttribute.Value == namespaceURI)
									{
										return xmlAttribute.LocalName;
									}
								}
								else if (Ref.Equal(xmlAttribute.NamespaceURI, namespaceURI))
								{
									return xmlAttribute.Prefix;
								}
							}
						}
						if (Ref.Equal(xmlNode.NamespaceURI, namespaceURI))
						{
							return xmlNode.Prefix;
						}
						xmlNode = xmlNode.ParentNode;
					}
					else if (xmlNode.NodeType == XmlNodeType.Attribute)
					{
						xmlNode = ((XmlAttribute)xmlNode).OwnerElement;
					}
					else
					{
						xmlNode = xmlNode.ParentNode;
					}
				}
				if (Ref.Equal(document.strReservedXml, namespaceURI))
				{
					return document.strXml;
				}
				if (Ref.Equal(document.strReservedXmlns, namespaceURI))
				{
					return document.strXmlns;
				}
			}
			return null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0004C51F File Offset: 0x0004A71F
		internal virtual void SetParent(XmlNode node)
		{
			if (node == null)
			{
				this.parentNode = this.OwnerDocument;
				return;
			}
			this.parentNode = node;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00046A06 File Offset: 0x00044C06
		internal virtual void SetParentForLoad(XmlNode node)
		{
			this.parentNode = node;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0004C538 File Offset: 0x0004A738
		internal static void SplitName(string name, out string prefix, out string localName)
		{
			int num = name.IndexOf(':');
			if (-1 == num || num == 0 || name.Length - 1 == num)
			{
				prefix = string.Empty;
				localName = name;
				return;
			}
			prefix = name.Substring(0, num);
			localName = name.Substring(num + 1);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0004C580 File Offset: 0x0004A780
		internal virtual XmlNode FindChild(XmlNodeType type)
		{
			for (XmlNode xmlNode = this.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				if (xmlNode.NodeType == type)
				{
					return xmlNode;
				}
			}
			return null;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0004C5AC File Offset: 0x0004A7AC
		internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			XmlDocument ownerDocument = this.OwnerDocument;
			if (ownerDocument == null)
			{
				return null;
			}
			if (!ownerDocument.IsLoading && ((newParent != null && newParent.IsReadOnly) || (oldParent != null && oldParent.IsReadOnly)))
			{
				throw new InvalidOperationException(Res.GetString("This node is read-only. It cannot be modified."));
			}
			return ownerDocument.GetEventArgs(node, oldParent, newParent, oldValue, newValue, action);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0004C602 File Offset: 0x0004A802
		internal virtual void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			if (args != null)
			{
				this.OwnerDocument.BeforeEvent(args);
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0004C613 File Offset: 0x0004A813
		internal virtual void AfterEvent(XmlNodeChangedEventArgs args)
		{
			if (args != null)
			{
				this.OwnerDocument.AfterEvent(args);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0004C624 File Offset: 0x0004A824
		internal virtual XmlSpace XmlSpace
		{
			get
			{
				XmlNode xmlNode = this;
				for (;;)
				{
					XmlElement xmlElement = xmlNode as XmlElement;
					if (xmlElement != null && xmlElement.HasAttribute("xml:space"))
					{
						string a = XmlConvert.TrimString(xmlElement.GetAttribute("xml:space"));
						if (a == "default")
						{
							break;
						}
						if (a == "preserve")
						{
							return XmlSpace.Preserve;
						}
					}
					xmlNode = xmlNode.ParentNode;
					if (xmlNode == null)
					{
						return XmlSpace.None;
					}
				}
				return XmlSpace.Default;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0004C688 File Offset: 0x0004A888
		internal virtual string XmlLang
		{
			get
			{
				XmlNode xmlNode = this;
				XmlElement xmlElement;
				for (;;)
				{
					xmlElement = (xmlNode as XmlElement);
					if (xmlElement != null && xmlElement.HasAttribute("xml:lang"))
					{
						break;
					}
					xmlNode = xmlNode.ParentNode;
					if (xmlNode == null)
					{
						goto Block_3;
					}
				}
				return xmlElement.GetAttribute("xml:lang");
				Block_3:
				return string.Empty;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0000A216 File Offset: 0x00008416
		internal virtual bool IsText
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0004C6CB File Offset: 0x0004A8CB
		internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			nextNode.parentNode = prevNode;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0004C6D4 File Offset: 0x0004A8D4
		internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			nextNode.parentNode = prevNode.ParentNode;
		}

		// Token: 0x040008C7 RID: 2247
		internal XmlNode parentNode;
	}
}
