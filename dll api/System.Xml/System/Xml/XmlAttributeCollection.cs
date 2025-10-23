using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Xml
{
	/// <summary>Represents a collection of attributes that can be accessed by name or index.</summary>
	// Token: 0x02000135 RID: 309
	public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
	{
		// Token: 0x06000A79 RID: 2681 RVA: 0x00046A41 File Offset: 0x00044C41
		internal XmlAttributeCollection(XmlNode parent) : base(parent)
		{
		}

		/// <summary>Gets the attribute with the specified index.</summary>
		/// <param name="i">The index of the attribute. </param>
		/// <returns>The <see cref="T:System.Xml.XmlAttribute" /> at the specified index.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index being passed in is out of range. </exception>
		// Token: 0x170001C9 RID: 457
		[IndexerName("ItemOf")]
		public XmlAttribute this[int i]
		{
			get
			{
				XmlAttribute result;
				try
				{
					result = (XmlAttribute)this.nodes[i];
				}
				catch (ArgumentOutOfRangeException)
				{
					throw new IndexOutOfRangeException(Res.GetString("The index being passed in is out of range."));
				}
				return result;
			}
		}

		/// <summary>Gets the attribute with the specified name.</summary>
		/// <param name="name">The qualified name of the attribute. </param>
		/// <returns>The <see cref="T:System.Xml.XmlAttribute" /> with the specified name. If the attribute does not exist, this property returns <see langword="null" />.</returns>
		// Token: 0x170001CA RID: 458
		[IndexerName("ItemOf")]
		public XmlAttribute this[string name]
		{
			get
			{
				int hashCode = XmlName.GetHashCode(name);
				for (int i = 0; i < this.nodes.Count; i++)
				{
					XmlAttribute xmlAttribute = (XmlAttribute)this.nodes[i];
					if (hashCode == xmlAttribute.LocalNameHash && name == xmlAttribute.Name)
					{
						return xmlAttribute;
					}
				}
				return null;
			}
		}

		/// <summary>Gets the attribute with the specified local name and namespace Uniform Resource Identifier (URI).</summary>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute. </param>
		/// <returns>The <see cref="T:System.Xml.XmlAttribute" /> with the specified local name and namespace URI. If the attribute does not exist, this property returns <see langword="null" />.</returns>
		// Token: 0x170001CB RID: 459
		[IndexerName("ItemOf")]
		public XmlAttribute this[string localName, string namespaceURI]
		{
			get
			{
				int hashCode = XmlName.GetHashCode(localName);
				for (int i = 0; i < this.nodes.Count; i++)
				{
					XmlAttribute xmlAttribute = (XmlAttribute)this.nodes[i];
					if (hashCode == xmlAttribute.LocalNameHash && localName == xmlAttribute.LocalName && namespaceURI == xmlAttribute.NamespaceURI)
					{
						return xmlAttribute;
					}
				}
				return null;
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00046B4C File Offset: 0x00044D4C
		internal int FindNodeOffsetNS(XmlAttribute node)
		{
			for (int i = 0; i < this.nodes.Count; i++)
			{
				XmlAttribute xmlAttribute = (XmlAttribute)this.nodes[i];
				if (xmlAttribute.LocalNameHash == node.LocalNameHash && xmlAttribute.LocalName == node.LocalName && xmlAttribute.NamespaceURI == node.NamespaceURI)
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Adds a <see cref="T:System.Xml.XmlNode" /> using its <see cref="P:System.Xml.XmlNode.Name" /> property </summary>
		/// <param name="node">An attribute node to store in this collection. The node will later be accessible using the name of the node. If a node with that name is already present in the collection, it is replaced by the new one; otherwise, the node is appended to the end of the collection. </param>
		/// <returns>If the <paramref name="node" /> replaces an existing node with the same name, the old node is returned; otherwise, the added node is returned.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="node" /> was created from a different <see cref="T:System.Xml.XmlDocument" /> than the one that created this collection.This <see langword="XmlAttributeCollection" /> is read-only. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="node" /> is an <see cref="T:System.Xml.XmlAttribute" /> that is already an attribute of another <see cref="T:System.Xml.XmlElement" /> object. To re-use attributes in other elements, you must clone the <see langword="XmlAttribute" /> objects you want to re-use. </exception>
		// Token: 0x06000A7E RID: 2686 RVA: 0x00046BB8 File Offset: 0x00044DB8
		public override XmlNode SetNamedItem(XmlNode node)
		{
			if (node != null && !(node is XmlAttribute))
			{
				throw new ArgumentException(Res.GetString("An 'Attributes' collection can only contain 'Attribute' objects."));
			}
			int num = base.FindNodeOffset(node.LocalName, node.NamespaceURI);
			if (num == -1)
			{
				return this.InternalAppendAttribute((XmlAttribute)node);
			}
			XmlNode result = base.RemoveNodeAt(num);
			this.InsertNodeAt(num, node);
			return result;
		}

		/// <summary>Inserts the specified attribute as the last node in the collection.</summary>
		/// <param name="node">The <see cref="T:System.Xml.XmlAttribute" /> to insert. </param>
		/// <returns>The <see langword="XmlAttribute" /> to append to the collection.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="node" /> was created from a document different from the one that created this collection. </exception>
		// Token: 0x06000A7F RID: 2687 RVA: 0x00046C14 File Offset: 0x00044E14
		public XmlAttribute Append(XmlAttribute node)
		{
			XmlDocument ownerDocument = node.OwnerDocument;
			if (ownerDocument == null || !ownerDocument.IsLoading)
			{
				if (ownerDocument != null && ownerDocument != this.parent.OwnerDocument)
				{
					throw new ArgumentException(Res.GetString("The named node is from a different document context."));
				}
				if (node.OwnerElement != null)
				{
					this.Detach(node);
				}
				this.AddNode(node);
			}
			else
			{
				base.AddNodeForLoad(node, ownerDocument);
				this.InsertParentIntoElementIdAttrMap(node);
			}
			return node;
		}

		/// <summary>Removes the specified attribute from the collection.</summary>
		/// <param name="node">The <see cref="T:System.Xml.XmlAttribute" /> to remove. </param>
		/// <returns>The node removed or <see langword="null" /> if it is not found in the collection.</returns>
		// Token: 0x06000A80 RID: 2688 RVA: 0x00046C80 File Offset: 0x00044E80
		public XmlAttribute Remove(XmlAttribute node)
		{
			int count = this.nodes.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.nodes[i] == node)
				{
					this.RemoveNodeAt(i);
					return node;
				}
			}
			return null;
		}

		/// <summary>Removes the attribute corresponding to the specified index from the collection.</summary>
		/// <param name="i">The index of the node to remove. The first node has index 0. </param>
		/// <returns>Returns <see langword="null" /> if there is no attribute at the specified index.</returns>
		// Token: 0x06000A81 RID: 2689 RVA: 0x00046CBF File Offset: 0x00044EBF
		public XmlAttribute RemoveAt(int i)
		{
			if (i < 0 || i >= this.Count)
			{
				return null;
			}
			return (XmlAttribute)this.RemoveNodeAt(i);
		}

		/// <summary>Removes all attributes from the collection.</summary>
		// Token: 0x06000A82 RID: 2690 RVA: 0x00046CDC File Offset: 0x00044EDC
		public void RemoveAll()
		{
			int i = this.Count;
			while (i > 0)
			{
				i--;
				this.RemoveAt(i);
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.XmlAttributeCollection.CopyTo(System.Xml.XmlAttribute[],System.Int32)" />.</summary>
		/// <param name="array">The array that is the destination of the objects copied from this collection. </param>
		/// <param name="index">The index in the array where copying begins. </param>
		// Token: 0x06000A83 RID: 2691 RVA: 0x00046D04 File Offset: 0x00044F04
		void ICollection.CopyTo(Array array, int index)
		{
			int i = 0;
			int count = this.Count;
			while (i < count)
			{
				array.SetValue(this.nodes[i], index);
				i++;
				index++;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#IsSynchronized" />.</summary>
		/// <returns>Returns <see langword="true" /> if the collection is synchronized.</returns>
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0000A216 File Offset: 0x00008416
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#SyncRoot" />.</summary>
		/// <returns>Returns the <see cref="T:System.Object" /> that is the root of the collection.</returns>
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00044153 File Offset: 0x00042353
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#Count" />.</summary>
		/// <returns>Returns an <see langword="int" /> that contains the count of the attributes.</returns>
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00046D3C File Offset: 0x00044F3C
		int ICollection.Count
		{
			get
			{
				return base.Count;
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00046D44 File Offset: 0x00044F44
		internal override XmlNode AddNode(XmlNode node)
		{
			this.RemoveDuplicateAttribute((XmlAttribute)node);
			XmlNode result = base.AddNode(node);
			this.InsertParentIntoElementIdAttrMap((XmlAttribute)node);
			return result;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00046D66 File Offset: 0x00044F66
		internal override XmlNode InsertNodeAt(int i, XmlNode node)
		{
			XmlNode result = base.InsertNodeAt(i, node);
			this.InsertParentIntoElementIdAttrMap((XmlAttribute)node);
			return result;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00046D7C File Offset: 0x00044F7C
		internal override XmlNode RemoveNodeAt(int i)
		{
			XmlNode xmlNode = base.RemoveNodeAt(i);
			this.RemoveParentFromElementIdAttrMap((XmlAttribute)xmlNode);
			XmlAttribute defaultAttribute = this.parent.OwnerDocument.GetDefaultAttribute((XmlElement)this.parent, xmlNode.Prefix, xmlNode.LocalName, xmlNode.NamespaceURI);
			if (defaultAttribute != null)
			{
				this.InsertNodeAt(i, defaultAttribute);
			}
			return xmlNode;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00046DD8 File Offset: 0x00044FD8
		internal void Detach(XmlAttribute attr)
		{
			attr.OwnerElement.Attributes.Remove(attr);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00046DEC File Offset: 0x00044FEC
		internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr)
		{
			XmlElement xmlElement = this.parent as XmlElement;
			if (xmlElement != null)
			{
				if (this.parent.OwnerDocument == null)
				{
					return;
				}
				XmlName idinfoByElement = this.parent.OwnerDocument.GetIDInfoByElement(xmlElement.XmlName);
				if (idinfoByElement != null && idinfoByElement.Prefix == attr.XmlName.Prefix && idinfoByElement.LocalName == attr.XmlName.LocalName)
				{
					this.parent.OwnerDocument.AddElementWithId(attr.Value, xmlElement);
				}
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00046E78 File Offset: 0x00045078
		internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr)
		{
			XmlElement xmlElement = this.parent as XmlElement;
			if (xmlElement != null)
			{
				if (this.parent.OwnerDocument == null)
				{
					return;
				}
				XmlName idinfoByElement = this.parent.OwnerDocument.GetIDInfoByElement(xmlElement.XmlName);
				if (idinfoByElement != null && idinfoByElement.Prefix == attr.XmlName.Prefix && idinfoByElement.LocalName == attr.XmlName.LocalName)
				{
					this.parent.OwnerDocument.RemoveElementWithId(attr.Value, xmlElement);
				}
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00046F04 File Offset: 0x00045104
		internal int RemoveDuplicateAttribute(XmlAttribute attr)
		{
			int num = base.FindNodeOffset(attr.LocalName, attr.NamespaceURI);
			if (num != -1)
			{
				XmlAttribute attr2 = (XmlAttribute)this.nodes[num];
				base.RemoveNodeAt(num);
				this.RemoveParentFromElementIdAttrMap(attr2);
			}
			return num;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00046F4C File Offset: 0x0004514C
		internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName)
		{
			XmlElement xmlElement = this.parent as XmlElement;
			XmlName idinfoByElement = this.parent.OwnerDocument.GetIDInfoByElement(xmlElement.XmlName);
			return idinfoByElement != null && idinfoByElement.Prefix == attrPrefix && idinfoByElement.LocalName == attrLocalName;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00046FA0 File Offset: 0x000451A0
		internal void ResetParentInElementIdAttrMap(string oldVal, string newVal)
		{
			XmlElement elem = this.parent as XmlElement;
			XmlDocument ownerDocument = this.parent.OwnerDocument;
			ownerDocument.RemoveElementWithId(oldVal, elem);
			ownerDocument.AddElementWithId(newVal, elem);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00046FD3 File Offset: 0x000451D3
		internal XmlAttribute InternalAppendAttribute(XmlAttribute node)
		{
			XmlNode xmlNode = base.AddNode(node);
			this.InsertParentIntoElementIdAttrMap(node);
			return (XmlAttribute)xmlNode;
		}
	}
}
