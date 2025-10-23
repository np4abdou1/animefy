using System;

namespace System.Xml
{
	/// <summary>Represents the text content of an element or attribute.</summary>
	// Token: 0x02000156 RID: 342
	public class XmlText : XmlCharacterData
	{
		// Token: 0x06000CC1 RID: 3265 RVA: 0x0004E844 File Offset: 0x0004CA44
		internal XmlText(string strData) : this(strData, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlText" /> class.</summary>
		/// <param name="strData">The content of the node; see the <see cref="P:System.Xml.XmlText.Value" /> property.</param>
		/// <param name="doc">The parent XML document.</param>
		// Token: 0x06000CC2 RID: 3266 RVA: 0x00046FE8 File Offset: 0x000451E8
		protected internal XmlText(string strData, XmlDocument doc) : base(strData, doc)
		{
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For text nodes, this property returns <see langword="#text" />.</returns>
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0004E84E File Offset: 0x0004CA4E
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strTextName;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For text nodes, this property returns <see langword="#text" />.</returns>
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0004E84E File Offset: 0x0004CA4E
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strTextName;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>For text nodes, this value is XmlNodeType.Text.</returns>
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0004E85B File Offset: 0x0004CA5B
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Text;
			}
		}

		/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
		/// <returns>The <see langword="XmlNode" /> that is the parent of the current node. If a node has just been created and not yet added to the tree, or if it has been removed from the tree, the parent is <see langword="null" />. For all other nodes, the value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. The following table describes the possible return values for the <see langword="ParentNode" /> property.</returns>
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0004E860 File Offset: 0x0004CA60
		public override XmlNode ParentNode
		{
			get
			{
				XmlNodeType nodeType = this.parentNode.NodeType;
				if (nodeType - XmlNodeType.Text > 1)
				{
					if (nodeType == XmlNodeType.Document)
					{
						return null;
					}
					if (nodeType - XmlNodeType.Whitespace > 1)
					{
						return this.parentNode;
					}
				}
				XmlNode parentNode = this.parentNode.parentNode;
				while (parentNode.IsText)
				{
					parentNode = parentNode.parentNode;
				}
				return parentNode;
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000CC7 RID: 3271 RVA: 0x0004E8B4 File Offset: 0x0004CAB4
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateTextNode(this.Data);
		}

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The content of the text node.</returns>
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00047089 File Offset: 0x00045289
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x0004E8C8 File Offset: 0x0004CAC8
		public override string Value
		{
			get
			{
				return this.Data;
			}
			set
			{
				this.Data = value;
				XmlNode parentNode = this.parentNode;
				if (parentNode != null && parentNode.NodeType == XmlNodeType.Attribute)
				{
					XmlUnspecifiedAttribute xmlUnspecifiedAttribute = parentNode as XmlUnspecifiedAttribute;
					if (xmlUnspecifiedAttribute != null && !xmlUnspecifiedAttribute.Specified)
					{
						xmlUnspecifiedAttribute.SetSpecified(true);
					}
				}
			}
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CCA RID: 3274 RVA: 0x0004E836 File Offset: 0x0004CA36
		public override void WriteTo(XmlWriter w)
		{
			w.WriteString(this.Data);
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. <see langword="XmlText" /> nodes do not have children, so this method has no effect.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CCB RID: 3275 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}
	}
}
