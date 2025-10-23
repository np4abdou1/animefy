using System;

namespace System.Xml
{
	/// <summary>Represents an entity declaration, such as &lt;!ENTITY... &gt;.</summary>
	// Token: 0x02000141 RID: 321
	public class XmlEntity : XmlNode
	{
		// Token: 0x06000B74 RID: 2932 RVA: 0x00049398 File Offset: 0x00047598
		internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) : base(doc)
		{
			this.name = doc.NameTable.Add(name);
			this.publicId = publicId;
			this.systemId = systemId;
			this.notationName = notationName;
			this.unparsedReplacementStr = strdata;
			this.childrenFoliating = false;
		}

		/// <summary>Creates a duplicate of this node. Entity nodes cannot be cloned. Calling this method on an <see cref="T:System.Xml.XmlEntity" /> object throws an exception.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself.</param>
		/// <returns>Returns a copy of the <see cref="T:System.Xml.XmlNode" /> from which the method is called.</returns>
		/// <exception cref="T:System.InvalidOperationException">Entity nodes cannot be cloned. Calling this method on an <see cref="T:System.Xml.XmlEntity" /> object throws an exception.</exception>
		// Token: 0x06000B75 RID: 2933 RVA: 0x000493E5 File Offset: 0x000475E5
		public override XmlNode CloneNode(bool deep)
		{
			throw new InvalidOperationException(Res.GetString("'Entity' and 'Notation' nodes cannot be cloned."));
		}

		/// <summary>Gets a value indicating whether the node is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the node is read-only; otherwise <see langword="false" />.Because <see langword="XmlEntity" /> nodes are read-only, this property always returns <see langword="true" />.</returns>
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets the name of the node.</summary>
		/// <returns>The name of the entity.</returns>
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x000493F6 File Offset: 0x000475F6
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the name of the node without the namespace prefix.</summary>
		/// <returns>For <see langword="XmlEntity" /> nodes, this property returns the name of the entity.</returns>
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x000493F6 File Offset: 0x000475F6
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the concatenated values of the entity node and all its children.</summary>
		/// <returns>The concatenated values of the node and all its children.</returns>
		/// <exception cref="T:System.InvalidOperationException">Attempting to set the property. </exception>
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00049322 File Offset: 0x00047522
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x000493FE File Offset: 0x000475FE
		public override string InnerText
		{
			get
			{
				return base.InnerText;
			}
			set
			{
				throw new InvalidOperationException(Res.GetString("The 'InnerText' of an 'Entity' node is read-only and cannot be set."));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0004940F File Offset: 0x0004760F
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x00049439 File Offset: 0x00047639
		internal override XmlLinkedNode LastNode
		{
			get
			{
				if (this.lastChild == null && !this.childrenFoliating)
				{
					this.childrenFoliating = true;
					new XmlLoader().ExpandEntity(this);
				}
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00049442 File Offset: 0x00047642
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return type == XmlNodeType.Text || type == XmlNodeType.Element || type == XmlNodeType.ProcessingInstruction || type == XmlNodeType.Comment || type == XmlNodeType.CDATA || type == XmlNodeType.Whitespace || type == XmlNodeType.SignificantWhitespace || type == XmlNodeType.EntityReference;
		}

		/// <summary>Gets the type of the node.</summary>
		/// <returns>The node type. For <see langword="XmlEntity" /> nodes, the value is XmlNodeType.Entity.</returns>
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00049468 File Offset: 0x00047668
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Entity;
			}
		}

		/// <summary>Gets the value of the system identifier on the entity declaration.</summary>
		/// <returns>The system identifier on the entity. If there is no system identifier, <see langword="null" /> is returned.</returns>
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0004946B File Offset: 0x0004766B
		public string SystemId
		{
			get
			{
				return this.systemId;
			}
		}

		/// <summary>Gets the markup representing the children of this node.</summary>
		/// <returns>For <see langword="XmlEntity" /> nodes, String.Empty is returned.</returns>
		/// <exception cref="T:System.InvalidOperationException">Attempting to set the property. </exception>
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00015248 File Offset: 0x00013448
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00049473 File Offset: 0x00047673
		public override string InnerXml
		{
			get
			{
				return string.Empty;
			}
			set
			{
				throw new InvalidOperationException(Res.GetString("Cannot set the 'InnerXml' for the current node because it is either read-only or cannot have children."));
			}
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />. For <see langword="XmlEntity" /> nodes, this method has no effect.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B83 RID: 2947 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteTo(XmlWriter w)
		{
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. For <see langword="XmlEntity" /> nodes, this method has no effect.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B84 RID: 2948 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		/// <summary>Gets the base Uniform Resource Identifier (URI) of the current node.</summary>
		/// <returns>The location from which the node was loaded.</returns>
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00049484 File Offset: 0x00047684
		public override string BaseURI
		{
			get
			{
				return this.baseURI;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0004948C File Offset: 0x0004768C
		internal void SetBaseURI(string inBaseURI)
		{
			this.baseURI = inBaseURI;
		}

		// Token: 0x040008A4 RID: 2212
		private string publicId;

		// Token: 0x040008A5 RID: 2213
		private string systemId;

		// Token: 0x040008A6 RID: 2214
		private string notationName;

		// Token: 0x040008A7 RID: 2215
		private string name;

		// Token: 0x040008A8 RID: 2216
		private string unparsedReplacementStr;

		// Token: 0x040008A9 RID: 2217
		private string baseURI;

		// Token: 0x040008AA RID: 2218
		private XmlLinkedNode lastChild;

		// Token: 0x040008AB RID: 2219
		private bool childrenFoliating;
	}
}
