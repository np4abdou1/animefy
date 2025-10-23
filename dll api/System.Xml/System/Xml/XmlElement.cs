using System;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Represents an element.</summary>
	// Token: 0x02000140 RID: 320
	public class XmlElement : XmlLinkedNode
	{
		// Token: 0x06000B47 RID: 2887 RVA: 0x00048C40 File Offset: 0x00046E40
		internal XmlElement(XmlName name, bool empty, XmlDocument doc) : base(doc)
		{
			this.parentNode = null;
			if (!doc.IsLoading)
			{
				XmlDocument.CheckName(name.Prefix);
				XmlDocument.CheckName(name.LocalName);
			}
			if (name.LocalName.Length == 0)
			{
				throw new ArgumentException(Res.GetString("The local name for elements or attributes cannot be null or an empty string."));
			}
			this.name = name;
			if (empty)
			{
				this.lastChild = this;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlElement" /> class.</summary>
		/// <param name="prefix">The namespace prefix; see the <see cref="P:System.Xml.XmlElement.Prefix" /> property.</param>
		/// <param name="localName">The local name; see the <see cref="P:System.Xml.XmlElement.LocalName" /> property.</param>
		/// <param name="namespaceURI">The namespace URI; see the <see cref="P:System.Xml.XmlElement.NamespaceURI" /> property.</param>
		/// <param name="doc">The parent XML document.</param>
		// Token: 0x06000B48 RID: 2888 RVA: 0x00048CA7 File Offset: 0x00046EA7
		protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc) : this(doc.AddXmlName(prefix, localName, namespaceURI, null), true, doc)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00048CBD File Offset: 0x00046EBD
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00048CC5 File Offset: 0x00046EC5
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
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself (and its attributes if the node is an <see langword="XmlElement" />). </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000B4B RID: 2891 RVA: 0x00048CD0 File Offset: 0x00046ED0
		public override XmlNode CloneNode(bool deep)
		{
			XmlDocument ownerDocument = this.OwnerDocument;
			bool isLoading = ownerDocument.IsLoading;
			ownerDocument.IsLoading = true;
			XmlElement xmlElement = ownerDocument.CreateElement(this.Prefix, this.LocalName, this.NamespaceURI);
			ownerDocument.IsLoading = isLoading;
			if (xmlElement.IsEmpty != this.IsEmpty)
			{
				xmlElement.IsEmpty = this.IsEmpty;
			}
			if (this.HasAttributes)
			{
				foreach (object obj in this.Attributes)
				{
					XmlAttribute xmlAttribute = (XmlAttribute)obj;
					XmlAttribute xmlAttribute2 = (XmlAttribute)xmlAttribute.CloneNode(true);
					if (xmlAttribute is XmlUnspecifiedAttribute && !xmlAttribute.Specified)
					{
						((XmlUnspecifiedAttribute)xmlAttribute2).SetSpecified(false);
					}
					xmlElement.Attributes.InternalAppendAttribute(xmlAttribute2);
				}
			}
			if (deep)
			{
				xmlElement.CopyChildren(ownerDocument, this, deep);
			}
			return xmlElement;
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>The qualified name of the node. For <see langword="XmlElement" /> nodes, this is the tag name of the element.</returns>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00048DC8 File Offset: 0x00046FC8
		public override string Name
		{
			get
			{
				return this.name.Name;
			}
		}

		/// <summary>Gets the local name of the current node.</summary>
		/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is book for the element &lt;bk:book&gt;.</returns>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00048DD5 File Offset: 0x00046FD5
		public override string LocalName
		{
			get
			{
				return this.name.LocalName;
			}
		}

		/// <summary>Gets the namespace URI of this node.</summary>
		/// <returns>The namespace URI of this node. If there is no namespace URI, this property returns String.Empty.</returns>
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00048DE2 File Offset: 0x00046FE2
		public override string NamespaceURI
		{
			get
			{
				return this.name.NamespaceURI;
			}
		}

		/// <summary>Gets or sets the namespace prefix of this node.</summary>
		/// <returns>The namespace prefix of this node. If there is no prefix, this property returns String.Empty.</returns>
		/// <exception cref="T:System.ArgumentException">This node is read-only </exception>
		/// <exception cref="T:System.Xml.XmlException">The specified prefix contains an invalid character.The specified prefix is malformed.The namespaceURI of this node is <see langword="null" />.The specified prefix is "xml" and the namespaceURI of this node is different from http://www.w3.org/XML/1998/namespace. </exception>
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00048DEF File Offset: 0x00046FEF
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00048DFC File Offset: 0x00046FFC
		public override string Prefix
		{
			get
			{
				return this.name.Prefix;
			}
			set
			{
				this.name = this.name.OwnerDocument.AddXmlName(value, this.LocalName, this.NamespaceURI, this.SchemaInfo);
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>The node type. For <see langword="XmlElement" /> nodes, this value is XmlNodeType.Element.</returns>
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Element;
			}
		}

		/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
		/// <returns>The <see langword="XmlNode" /> that is the parent of the current node. If a node has just been created and not yet added to the tree, or if it has been removed from the tree, the parent is <see langword="null" />. For all other nodes, the value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. The following table describes the possible return values for the <see langword="ParentNode" /> property.</returns>
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00048E27 File Offset: 0x00047027
		public override XmlNode ParentNode
		{
			get
			{
				return this.parentNode;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.</summary>
		/// <returns>The <see langword="XmlDocument" /> to which this element belongs.</returns>
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00048E2F File Offset: 0x0004702F
		public override XmlDocument OwnerDocument
		{
			get
			{
				return this.name.OwnerDocument;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00048E3C File Offset: 0x0004703C
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
				doc.BeforeEvent(insertEventArgsForLoad);
			}
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			if (this.lastChild == null || this.lastChild == this)
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

		/// <summary>Gets or sets the tag format of the element.</summary>
		/// <returns>Returns <see langword="true" /> if the element is to be serialized in the short tag format "&lt;item/&gt;"; <see langword="false" /> for the long format "&lt;item&gt;&lt;/item&gt;".When setting this property, if set to <see langword="true" />, the children of the element are removed and the element is serialized in the short tag format. If set to <see langword="false" />, the value of the property is changed (regardless of whether or not the element has content); if the element is empty, it is serialized in the long format.This property is a Microsoft extension to the Document Object Model (DOM).</returns>
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00048ED7 File Offset: 0x000470D7
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00048EE2 File Offset: 0x000470E2
		public bool IsEmpty
		{
			get
			{
				return this.lastChild == this;
			}
			set
			{
				if (value)
				{
					if (this.lastChild != this)
					{
						this.RemoveAllChildren();
						this.lastChild = this;
						return;
					}
				}
				else if (this.lastChild == this)
				{
					this.lastChild = null;
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00048F0E File Offset: 0x0004710E
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x00048F21 File Offset: 0x00047121
		internal override XmlLinkedNode LastNode
		{
			get
			{
				if (this.lastChild != this)
				{
					return this.lastChild;
				}
				return null;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00048F2C File Offset: 0x0004712C
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
			}
			return false;
		}

		/// <summary>Gets an <see cref="T:System.Xml.XmlAttributeCollection" /> containing the list of attributes for this node.</summary>
		/// <returns>
		///     <see cref="T:System.Xml.XmlAttributeCollection" /> containing the list of attributes for this node.</returns>
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00048F80 File Offset: 0x00047180
		public override XmlAttributeCollection Attributes
		{
			get
			{
				if (this.attributes == null)
				{
					object objLock = this.OwnerDocument.objLock;
					lock (objLock)
					{
						if (this.attributes == null)
						{
							this.attributes = new XmlAttributeCollection(this);
						}
					}
				}
				return this.attributes;
			}
		}

		/// <summary>Gets a <see langword="boolean" /> value indicating whether the current node has any attributes.</summary>
		/// <returns>
		///     <see langword="true" /> if the current node has attributes; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00048FE4 File Offset: 0x000471E4
		public virtual bool HasAttributes
		{
			get
			{
				return this.attributes != null && this.attributes.Count > 0;
			}
		}

		/// <summary>Returns the value for the attribute with the specified name.</summary>
		/// <param name="name">The name of the attribute to retrieve. This is a qualified name. It is matched against the <see langword="Name" /> property of the matching node. </param>
		/// <returns>The value of the specified attribute. An empty string is returned if a matching attribute is not found or if the attribute does not have a specified or default value.</returns>
		// Token: 0x06000B5D RID: 2909 RVA: 0x00049000 File Offset: 0x00047200
		public virtual string GetAttribute(string name)
		{
			XmlAttribute attributeNode = this.GetAttributeNode(name);
			if (attributeNode != null)
			{
				return attributeNode.Value;
			}
			return string.Empty;
		}

		/// <summary>Sets the value of the attribute with the specified name.</summary>
		/// <param name="name">The name of the attribute to create or alter. This is a qualified name. If the name contains a colon it is parsed into prefix and local name components. </param>
		/// <param name="value">The value to set for the attribute. </param>
		/// <exception cref="T:System.Xml.XmlException">The specified name contains an invalid character. </exception>
		/// <exception cref="T:System.ArgumentException">The node is read-only. </exception>
		// Token: 0x06000B5E RID: 2910 RVA: 0x00049024 File Offset: 0x00047224
		public virtual void SetAttribute(string name, string value)
		{
			XmlAttribute xmlAttribute = this.GetAttributeNode(name);
			if (xmlAttribute == null)
			{
				xmlAttribute = this.OwnerDocument.CreateAttribute(name);
				xmlAttribute.Value = value;
				this.Attributes.InternalAppendAttribute(xmlAttribute);
				return;
			}
			xmlAttribute.Value = value;
		}

		/// <summary>Returns the <see langword="XmlAttribute" /> with the specified name.</summary>
		/// <param name="name">The name of the attribute to retrieve. This is a qualified name. It is matched against the <see langword="Name" /> property of the matching node. </param>
		/// <returns>The specified <see langword="XmlAttribute" /> or <see langword="null" /> if a matching attribute was not found.</returns>
		// Token: 0x06000B5F RID: 2911 RVA: 0x00049065 File Offset: 0x00047265
		public virtual XmlAttribute GetAttributeNode(string name)
		{
			if (this.HasAttributes)
			{
				return this.Attributes[name];
			}
			return null;
		}

		/// <summary>Adds the specified <see cref="T:System.Xml.XmlAttribute" />.</summary>
		/// <param name="newAttr">The <see langword="XmlAttribute" /> node to add to the attribute collection for this element. </param>
		/// <returns>If the attribute replaces an existing attribute with the same name, the old <see langword="XmlAttribute" /> is returned; otherwise, <see langword="null" /> is returned.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="newAttr" /> was created from a different document than the one that created this node. Or this node is read-only. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <paramref name="newAttr" /> is already an attribute of another <see langword="XmlElement" /> object. You must explicitly clone <see langword="XmlAttribute" /> nodes to re-use them in other <see langword="XmlElement" /> objects. </exception>
		// Token: 0x06000B60 RID: 2912 RVA: 0x0004907D File Offset: 0x0004727D
		public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr)
		{
			if (newAttr.OwnerElement != null)
			{
				throw new InvalidOperationException(Res.GetString("The 'Attribute' node cannot be inserted because it is already an attribute of another element."));
			}
			return (XmlAttribute)this.Attributes.SetNamedItem(newAttr);
		}

		/// <summary>Returns the value for the attribute with the specified local name and namespace URI.</summary>
		/// <param name="localName">The local name of the attribute to retrieve. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute to retrieve. </param>
		/// <returns>The value of the specified attribute. An empty string is returned if a matching attribute is not found or if the attribute does not have a specified or default value.</returns>
		// Token: 0x06000B61 RID: 2913 RVA: 0x000490A8 File Offset: 0x000472A8
		public virtual string GetAttribute(string localName, string namespaceURI)
		{
			XmlAttribute attributeNode = this.GetAttributeNode(localName, namespaceURI);
			if (attributeNode != null)
			{
				return attributeNode.Value;
			}
			return string.Empty;
		}

		/// <summary>Sets the value of the attribute with the specified local name and namespace URI.</summary>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute. </param>
		/// <param name="value">The value to set for the attribute. </param>
		/// <returns>The attribute value.</returns>
		// Token: 0x06000B62 RID: 2914 RVA: 0x000490D0 File Offset: 0x000472D0
		public virtual string SetAttribute(string localName, string namespaceURI, string value)
		{
			XmlAttribute xmlAttribute = this.GetAttributeNode(localName, namespaceURI);
			if (xmlAttribute == null)
			{
				xmlAttribute = this.OwnerDocument.CreateAttribute(string.Empty, localName, namespaceURI);
				xmlAttribute.Value = value;
				this.Attributes.InternalAppendAttribute(xmlAttribute);
			}
			else
			{
				xmlAttribute.Value = value;
			}
			return value;
		}

		/// <summary>Returns the <see cref="T:System.Xml.XmlAttribute" /> with the specified local name and namespace URI.</summary>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute. </param>
		/// <returns>The specified <see langword="XmlAttribute" /> or <see langword="null" /> if a matching attribute was not found.</returns>
		// Token: 0x06000B63 RID: 2915 RVA: 0x0004911A File Offset: 0x0004731A
		public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI)
		{
			if (this.HasAttributes)
			{
				return this.Attributes[localName, namespaceURI];
			}
			return null;
		}

		/// <summary>Adds the specified <see cref="T:System.Xml.XmlAttribute" />.</summary>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute. </param>
		/// <returns>The <see langword="XmlAttribute" /> to add.</returns>
		// Token: 0x06000B64 RID: 2916 RVA: 0x00049134 File Offset: 0x00047334
		public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI)
		{
			XmlAttribute xmlAttribute = this.GetAttributeNode(localName, namespaceURI);
			if (xmlAttribute == null)
			{
				xmlAttribute = this.OwnerDocument.CreateAttribute(string.Empty, localName, namespaceURI);
				this.Attributes.InternalAppendAttribute(xmlAttribute);
			}
			return xmlAttribute;
		}

		/// <summary>Determines whether the current node has an attribute with the specified name.</summary>
		/// <param name="name">The name of the attribute to find. This is a qualified name. It is matched against the <see langword="Name" /> property of the matching node. </param>
		/// <returns>
		///     <see langword="true" /> if the current node has the specified attribute; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000B65 RID: 2917 RVA: 0x0004916E File Offset: 0x0004736E
		public virtual bool HasAttribute(string name)
		{
			return this.GetAttributeNode(name) != null;
		}

		/// <summary>Saves the current node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B66 RID: 2918 RVA: 0x0004917C File Offset: 0x0004737C
		public override void WriteTo(XmlWriter w)
		{
			if (base.GetType() == typeof(XmlElement))
			{
				XmlElement.WriteElementTo(w, this);
				return;
			}
			this.WriteStartElement(w);
			if (this.IsEmpty)
			{
				w.WriteEndElement();
				return;
			}
			this.WriteContentTo(w);
			w.WriteFullEndElement();
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000491CC File Offset: 0x000473CC
		private static void WriteElementTo(XmlWriter writer, XmlElement e)
		{
			XmlNode xmlNode = e;
			XmlNode xmlNode2 = e;
			for (;;)
			{
				e = (xmlNode2 as XmlElement);
				if (e != null && e.GetType() == typeof(XmlElement))
				{
					e.WriteStartElement(writer);
					if (e.IsEmpty)
					{
						writer.WriteEndElement();
					}
					else
					{
						if (e.lastChild != null)
						{
							xmlNode2 = e.FirstChild;
							continue;
						}
						writer.WriteFullEndElement();
					}
				}
				else
				{
					xmlNode2.WriteTo(writer);
				}
				while (xmlNode2 != xmlNode && xmlNode2 == xmlNode2.ParentNode.LastChild)
				{
					xmlNode2 = xmlNode2.ParentNode;
					writer.WriteFullEndElement();
				}
				if (xmlNode2 == xmlNode)
				{
					break;
				}
				xmlNode2 = xmlNode2.NextSibling;
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00049268 File Offset: 0x00047468
		private void WriteStartElement(XmlWriter w)
		{
			w.WriteStartElement(this.Prefix, this.LocalName, this.NamespaceURI);
			if (this.HasAttributes)
			{
				XmlAttributeCollection xmlAttributeCollection = this.Attributes;
				for (int i = 0; i < xmlAttributeCollection.Count; i++)
				{
					xmlAttributeCollection[i].WriteTo(w);
				}
			}
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B69 RID: 2921 RVA: 0x000492BC File Offset: 0x000474BC
		public override void WriteContentTo(XmlWriter w)
		{
			for (XmlNode xmlNode = this.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				xmlNode.WriteTo(w);
			}
		}

		/// <summary>Removes all specified attributes from the element. Default attributes are not removed.</summary>
		// Token: 0x06000B6A RID: 2922 RVA: 0x000492E3 File Offset: 0x000474E3
		public virtual void RemoveAllAttributes()
		{
			if (this.HasAttributes)
			{
				this.attributes.RemoveAll();
			}
		}

		/// <summary>Removes all specified attributes and children of the current node. Default attributes are not removed.</summary>
		// Token: 0x06000B6B RID: 2923 RVA: 0x000492F8 File Offset: 0x000474F8
		public override void RemoveAll()
		{
			base.RemoveAll();
			this.RemoveAllAttributes();
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00049306 File Offset: 0x00047506
		internal void RemoveAllChildren()
		{
			base.RemoveAll();
		}

		/// <summary>Gets the post schema validation infoset that has been assigned to this node as a result of schema validation.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object containing the post schema validation infoset of this node.</returns>
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00048CBD File Offset: 0x00046EBD
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets or sets the markup representing just the children of this node.</summary>
		/// <returns>The markup of the children of this node.</returns>
		/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed. </exception>
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00048439 File Offset: 0x00046639
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x0004930E File Offset: 0x0004750E
		public override string InnerXml
		{
			get
			{
				return base.InnerXml;
			}
			set
			{
				this.RemoveAllChildren();
				new XmlLoader().LoadInnerXmlElement(this, value);
			}
		}

		/// <summary>Gets or sets the concatenated values of the node and all its children.</summary>
		/// <returns>The concatenated values of the node and all its children.</returns>
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00049322 File Offset: 0x00047522
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0004932C File Offset: 0x0004752C
		public override string InnerText
		{
			get
			{
				return base.InnerText;
			}
			set
			{
				XmlLinkedNode lastNode = this.LastNode;
				if (lastNode != null && lastNode.NodeType == XmlNodeType.Text && lastNode.next == lastNode)
				{
					lastNode.Value = value;
					return;
				}
				this.RemoveAllChildren();
				this.AppendChild(this.OwnerDocument.CreateTextNode(value));
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlNode" /> immediately following this element.</summary>
		/// <returns>The <see langword="XmlNode" /> immediately following this element.</returns>
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00049376 File Offset: 0x00047576
		public override XmlNode NextSibling
		{
			get
			{
				if (this.parentNode != null && this.parentNode.LastNode != this)
				{
					return this.next;
				}
				return null;
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00046A06 File Offset: 0x00044C06
		internal override void SetParent(XmlNode node)
		{
			this.parentNode = node;
		}

		// Token: 0x040008A1 RID: 2209
		private XmlName name;

		// Token: 0x040008A2 RID: 2210
		private XmlAttributeCollection attributes;

		// Token: 0x040008A3 RID: 2211
		private XmlLinkedNode lastChild;
	}
}
