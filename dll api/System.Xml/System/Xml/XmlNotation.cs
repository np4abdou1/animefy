using System;

namespace System.Xml
{
	/// <summary>Represents a notation declaration, such as &lt;!NOTATION... &gt;.</summary>
	// Token: 0x02000153 RID: 339
	public class XmlNotation : XmlNode
	{
		// Token: 0x06000CA0 RID: 3232 RVA: 0x0004E687 File Offset: 0x0004C887
		internal XmlNotation(string name, string publicId, string systemId, XmlDocument doc) : base(doc)
		{
			this.name = doc.NameTable.Add(name);
			this.publicId = publicId;
			this.systemId = systemId;
		}

		/// <summary>Gets the name of the current node.</summary>
		/// <returns>The name of the notation.</returns>
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0004E6B2 File Offset: 0x0004C8B2
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the name of the current node without the namespace prefix.</summary>
		/// <returns>For <see langword="XmlNotation" /> nodes, this property returns the name of the notation.</returns>
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x0004E6B2 File Offset: 0x0004C8B2
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>The node type. For <see langword="XmlNotation" /> nodes, the value is XmlNodeType.Notation.</returns>
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00008318 File Offset: 0x00006518
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Notation;
			}
		}

		/// <summary>Creates a duplicate of this node. Notation nodes cannot be cloned. Calling this method on an <see cref="T:System.Xml.XmlNotation" /> object throws an exception.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself.</param>
		/// <returns>Returns a <see cref="T:System.Xml.XmlNode" /> copy of the node from which the method is called.</returns>
		/// <exception cref="T:System.InvalidOperationException">Notation nodes cannot be cloned. Calling this method on an <see cref="T:System.Xml.XmlNotation" /> object throws an exception.</exception>
		// Token: 0x06000CA4 RID: 3236 RVA: 0x000493E5 File Offset: 0x000475E5
		public override XmlNode CloneNode(bool deep)
		{
			throw new InvalidOperationException(Res.GetString("'Entity' and 'Notation' nodes cannot be cloned."));
		}

		/// <summary>Gets a value indicating whether the node is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the node is read-only; otherwise <see langword="false" />.Because <see langword="XmlNotation" /> nodes are read-only, this property always returns <see langword="true" />.</returns>
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets the markup representing the children of this node.</summary>
		/// <returns>For <see langword="XmlNotation" /> nodes, String.Empty is returned.</returns>
		/// <exception cref="T:System.InvalidOperationException">Attempting to set the property. </exception>
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00015248 File Offset: 0x00013448
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00049473 File Offset: 0x00047673
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

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />. This method has no effect on <see langword="XmlNotation" /> nodes.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CA8 RID: 3240 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteTo(XmlWriter w)
		{
		}

		/// <summary>Saves the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. This method has no effect on <see langword="XmlNotation" /> nodes.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CA9 RID: 3241 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x040008EA RID: 2282
		private string publicId;

		// Token: 0x040008EB RID: 2283
		private string systemId;

		// Token: 0x040008EC RID: 2284
		private string name;
	}
}
