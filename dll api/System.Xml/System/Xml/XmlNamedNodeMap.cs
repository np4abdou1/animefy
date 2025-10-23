using System;
using System.Collections;

namespace System.Xml
{
	/// <summary>Represents a collection of nodes that can be accessed by name or index.</summary>
	// Token: 0x02000149 RID: 329
	public class XmlNamedNodeMap : IEnumerable
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x0004B293 File Offset: 0x00049493
		internal XmlNamedNodeMap(XmlNode parent)
		{
			this.parent = parent;
		}

		/// <summary>Retrieves an <see cref="T:System.Xml.XmlNode" /> specified by name.</summary>
		/// <param name="name">The qualified name of the node to retrieve. It is matched against the <see cref="P:System.Xml.XmlNode.Name" /> property of the matching node.</param>
		/// <returns>An <see langword="XmlNode" /> with the specified name or <see langword="null" /> if a matching node is not found.</returns>
		// Token: 0x06000BDA RID: 3034 RVA: 0x0004B2A4 File Offset: 0x000494A4
		public virtual XmlNode GetNamedItem(string name)
		{
			int num = this.FindNodeOffset(name);
			if (num >= 0)
			{
				return (XmlNode)this.nodes[num];
			}
			return null;
		}

		/// <summary>Adds an <see cref="T:System.Xml.XmlNode" /> using its <see cref="P:System.Xml.XmlNode.Name" /> property.</summary>
		/// <param name="node">An <see langword="XmlNode" /> to store in the <see langword="XmlNamedNodeMap" />. If a node with that name is already present in the map, it is replaced by the new one.</param>
		/// <returns>If the <paramref name="node" /> replaces an existing node with the same name, the old node is returned; otherwise, <see langword="null" /> is returned.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="node" /> was created from a different <see cref="T:System.Xml.XmlDocument" /> than the one that created the <see langword="XmlNamedNodeMap" />; or the <see langword="XmlNamedNodeMap" /> is read-only.</exception>
		// Token: 0x06000BDB RID: 3035 RVA: 0x0004B2D0 File Offset: 0x000494D0
		public virtual XmlNode SetNamedItem(XmlNode node)
		{
			if (node == null)
			{
				return null;
			}
			int num = this.FindNodeOffset(node.LocalName, node.NamespaceURI);
			if (num == -1)
			{
				this.AddNode(node);
				return null;
			}
			return this.ReplaceNodeAt(num, node);
		}

		/// <summary>Gets the number of nodes in the <see langword="XmlNamedNodeMap" />.</summary>
		/// <returns>The number of nodes.</returns>
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0004B30B File Offset: 0x0004950B
		public virtual int Count
		{
			get
			{
				return this.nodes.Count;
			}
		}

		/// <summary>Provides support for the "foreach" style iteration over the collection of nodes in the <see langword="XmlNamedNodeMap" />.</summary>
		/// <returns>An enumerator object.</returns>
		// Token: 0x06000BDD RID: 3037 RVA: 0x0004B318 File Offset: 0x00049518
		public virtual IEnumerator GetEnumerator()
		{
			return this.nodes.GetEnumerator();
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0004B328 File Offset: 0x00049528
		internal int FindNodeOffset(string name)
		{
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				XmlNode xmlNode = (XmlNode)this.nodes[i];
				if (name == xmlNode.Name)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0004B36C File Offset: 0x0004956C
		internal int FindNodeOffset(string localName, string namespaceURI)
		{
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				XmlNode xmlNode = (XmlNode)this.nodes[i];
				if (xmlNode.LocalName == localName && xmlNode.NamespaceURI == namespaceURI)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0004B3C0 File Offset: 0x000495C0
		internal virtual XmlNode AddNode(XmlNode node)
		{
			XmlNode oldParent;
			if (node.NodeType == XmlNodeType.Attribute)
			{
				oldParent = ((XmlAttribute)node).OwnerElement;
			}
			else
			{
				oldParent = node.ParentNode;
			}
			string value = node.Value;
			XmlNodeChangedEventArgs eventArgs = this.parent.GetEventArgs(node, oldParent, this.parent, value, value, XmlNodeChangedAction.Insert);
			if (eventArgs != null)
			{
				this.parent.BeforeEvent(eventArgs);
			}
			this.nodes.Add(node);
			node.SetParent(this.parent);
			if (eventArgs != null)
			{
				this.parent.AfterEvent(eventArgs);
			}
			return node;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0004B440 File Offset: 0x00049640
		internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(node, this.parent);
			if (insertEventArgsForLoad != null)
			{
				doc.BeforeEvent(insertEventArgsForLoad);
			}
			this.nodes.Add(node);
			node.SetParent(this.parent);
			if (insertEventArgsForLoad != null)
			{
				doc.AfterEvent(insertEventArgsForLoad);
			}
			return node;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0004B488 File Offset: 0x00049688
		internal virtual XmlNode RemoveNodeAt(int i)
		{
			XmlNode xmlNode = (XmlNode)this.nodes[i];
			string value = xmlNode.Value;
			XmlNodeChangedEventArgs eventArgs = this.parent.GetEventArgs(xmlNode, this.parent, null, value, value, XmlNodeChangedAction.Remove);
			if (eventArgs != null)
			{
				this.parent.BeforeEvent(eventArgs);
			}
			this.nodes.RemoveAt(i);
			xmlNode.SetParent(null);
			if (eventArgs != null)
			{
				this.parent.AfterEvent(eventArgs);
			}
			return xmlNode;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0004B4F7 File Offset: 0x000496F7
		internal XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			XmlNode result = this.RemoveNodeAt(i);
			this.InsertNodeAt(i, node);
			return result;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0004B50C File Offset: 0x0004970C
		internal virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			XmlNode oldParent;
			if (node.NodeType == XmlNodeType.Attribute)
			{
				oldParent = ((XmlAttribute)node).OwnerElement;
			}
			else
			{
				oldParent = node.ParentNode;
			}
			string value = node.Value;
			XmlNodeChangedEventArgs eventArgs = this.parent.GetEventArgs(node, oldParent, this.parent, value, value, XmlNodeChangedAction.Insert);
			if (eventArgs != null)
			{
				this.parent.BeforeEvent(eventArgs);
			}
			this.nodes.Insert(i, node);
			node.SetParent(this.parent);
			if (eventArgs != null)
			{
				this.parent.AfterEvent(eventArgs);
			}
			return node;
		}

		// Token: 0x040008C2 RID: 2242
		internal XmlNode parent;

		// Token: 0x040008C3 RID: 2243
		internal XmlNamedNodeMap.SmallXmlNodeList nodes;

		// Token: 0x0200014A RID: 330
		internal struct SmallXmlNodeList
		{
			// Token: 0x17000250 RID: 592
			// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0004B590 File Offset: 0x00049790
			public int Count
			{
				get
				{
					if (this.field == null)
					{
						return 0;
					}
					ArrayList arrayList = this.field as ArrayList;
					if (arrayList != null)
					{
						return arrayList.Count;
					}
					return 1;
				}
			}

			// Token: 0x17000251 RID: 593
			public object this[int index]
			{
				get
				{
					if (this.field == null)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					ArrayList arrayList = this.field as ArrayList;
					if (arrayList != null)
					{
						return arrayList[index];
					}
					if (index != 0)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					return this.field;
				}
			}

			// Token: 0x06000BE7 RID: 3047 RVA: 0x0004B60C File Offset: 0x0004980C
			public void Add(object value)
			{
				if (this.field == null)
				{
					if (value == null)
					{
						this.field = new ArrayList
						{
							null
						};
						return;
					}
					this.field = value;
					return;
				}
				else
				{
					ArrayList arrayList = this.field as ArrayList;
					if (arrayList != null)
					{
						arrayList.Add(value);
						return;
					}
					this.field = new ArrayList
					{
						this.field,
						value
					};
					return;
				}
			}

			// Token: 0x06000BE8 RID: 3048 RVA: 0x0004B67C File Offset: 0x0004987C
			public void RemoveAt(int index)
			{
				if (this.field == null)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				ArrayList arrayList = this.field as ArrayList;
				if (arrayList != null)
				{
					arrayList.RemoveAt(index);
					return;
				}
				if (index != 0)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				this.field = null;
			}

			// Token: 0x06000BE9 RID: 3049 RVA: 0x0004B6C8 File Offset: 0x000498C8
			public void Insert(int index, object value)
			{
				if (this.field == null)
				{
					if (index != 0)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					this.Add(value);
					return;
				}
				else
				{
					ArrayList arrayList = this.field as ArrayList;
					if (arrayList != null)
					{
						arrayList.Insert(index, value);
						return;
					}
					if (index == 0)
					{
						this.field = new ArrayList
						{
							value,
							this.field
						};
						return;
					}
					if (index == 1)
					{
						this.field = new ArrayList
						{
							this.field,
							value
						};
						return;
					}
					throw new ArgumentOutOfRangeException("index");
				}
			}

			// Token: 0x06000BEA RID: 3050 RVA: 0x0004B764 File Offset: 0x00049964
			public IEnumerator GetEnumerator()
			{
				if (this.field == null)
				{
					return XmlDocument.EmptyEnumerator;
				}
				ArrayList arrayList = this.field as ArrayList;
				if (arrayList != null)
				{
					return arrayList.GetEnumerator();
				}
				return new XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator(this.field);
			}

			// Token: 0x040008C4 RID: 2244
			private object field;

			// Token: 0x0200014B RID: 331
			private class SingleObjectEnumerator : IEnumerator
			{
				// Token: 0x06000BEB RID: 3051 RVA: 0x0004B7A0 File Offset: 0x000499A0
				public SingleObjectEnumerator(object value)
				{
					this.loneValue = value;
				}

				// Token: 0x17000252 RID: 594
				// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0004B7B6 File Offset: 0x000499B6
				public object Current
				{
					get
					{
						if (this.position != 0)
						{
							throw new InvalidOperationException();
						}
						return this.loneValue;
					}
				}

				// Token: 0x06000BED RID: 3053 RVA: 0x0004B7CC File Offset: 0x000499CC
				public bool MoveNext()
				{
					if (this.position < 0)
					{
						this.position = 0;
						return true;
					}
					this.position = 1;
					return false;
				}

				// Token: 0x06000BEE RID: 3054 RVA: 0x0004B7E8 File Offset: 0x000499E8
				public void Reset()
				{
					this.position = -1;
				}

				// Token: 0x040008C5 RID: 2245
				private object loneValue;

				// Token: 0x040008C6 RID: 2246
				private int position = -1;
			}
		}
	}
}
