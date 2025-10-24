using System;

namespace System.Xml
{
	/// <summary>Represents a CDATA section.</summary>
	// Token: 0x02000136 RID: 310
	public class XmlCDataSection : XmlCharacterData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlCDataSection" /> class.</summary>
		/// <param name="data">
		///       <see cref="T:System.String" /> that contains character data.</param>
		/// <param name="doc">
		///       <see cref="T:System.Xml.XmlDocument" /> object.</param>
		// Token: 0x06000A91 RID: 2705 RVA: 0x00046FE8 File Offset: 0x000451E8
		protected internal XmlCDataSection(string data, XmlDocument doc) : base(data, doc)
		{
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For CDATA nodes, the name is <see langword="#cdata-section" />.</returns>
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00046FF2 File Offset: 0x000451F2
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strCDataSectionName;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For CDATA nodes, the local name is <see langword="#cdata-section" />.</returns>
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00046FF2 File Offset: 0x000451F2
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strCDataSectionName;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>The node type. For CDATA nodes, the value is XmlNodeType.CDATA.</returns>
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00046FFF File Offset: 0x000451FF
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.CDATA;
			}
		}

		/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
		/// <returns>The <see langword="XmlNode" /> that is the parent of the current node. If a node has just been created and not yet added to the tree, or if it has been removed from the tree, the parent is <see langword="null" />. For all other nodes, the value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. The following table describes the possible return values for the <see langword="ParentNode" /> property.</returns>
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00047004 File Offset: 0x00045204
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
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. Because CDATA nodes do not have children, regardless of the parameter setting, the cloned node will always include the data content. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000A96 RID: 2710 RVA: 0x00047058 File Offset: 0x00045258
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateCDataSection(this.Data);
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000A97 RID: 2711 RVA: 0x0004706B File Offset: 0x0004526B
		public override void WriteTo(XmlWriter w)
		{
			w.WriteCData(this.Data);
		}

		/// <summary>Saves the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000A98 RID: 2712 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}
	}
}
