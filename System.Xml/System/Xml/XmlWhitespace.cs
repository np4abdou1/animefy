using System;

namespace System.Xml
{
	/// <summary>Represents white space in element content.</summary>
	// Token: 0x02000158 RID: 344
	public class XmlWhitespace : XmlCharacterData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlWhitespace" /> class.</summary>
		/// <param name="strData">The white space characters of the node.</param>
		/// <param name="doc">The <see cref="T:System.Xml.XmlDocument" /> object.</param>
		// Token: 0x06000CD7 RID: 3287 RVA: 0x0004E769 File Offset: 0x0004C969
		protected internal XmlWhitespace(string strData, XmlDocument doc) : base(strData, doc)
		{
			if (!doc.IsLoading && !base.CheckOnData(strData))
			{
				throw new ArgumentException(Res.GetString("The string for white space contains an invalid character."));
			}
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For <see langword="XmlWhitespace" /> nodes, this property returns <see langword="#whitespace" />.</returns>
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0004E9CD File Offset: 0x0004CBCD
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strNonSignificantWhitespaceName;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For <see langword="XmlWhitespace" /> nodes, this property returns <see langword="#whitespace" />.</returns>
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0004E9CD File Offset: 0x0004CBCD
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strNonSignificantWhitespaceName;
			}
		}

		/// <summary>Gets the type of the node.</summary>
		/// <returns>For <see langword="XmlWhitespace" /> nodes, the value is <see cref="F:System.Xml.XmlNodeType.Whitespace" />.</returns>
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0004E9DA File Offset: 0x0004CBDA
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Whitespace;
			}
		}

		/// <summary>Gets the parent of the current node.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> parent node of the current node.</returns>
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
		public override XmlNode ParentNode
		{
			get
			{
				XmlNodeType nodeType = this.parentNode.NodeType;
				if (nodeType - XmlNodeType.Text > 1)
				{
					if (nodeType == XmlNodeType.Document)
					{
						return base.ParentNode;
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

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The white space characters found in the node.</returns>
		/// <exception cref="T:System.ArgumentException">Setting <see cref="P:System.Xml.XmlWhitespace.Value" /> to invalid white space characters. </exception>
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00047089 File Offset: 0x00045289
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x0004E814 File Offset: 0x0004CA14
		public override string Value
		{
			get
			{
				return this.Data;
			}
			set
			{
				if (base.CheckOnData(value))
				{
					this.Data = value;
					return;
				}
				throw new ArgumentException(Res.GetString("The string for white space contains an invalid character."));
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. For white space nodes, the cloned node always includes the data value, regardless of the parameter setting. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000CDE RID: 3294 RVA: 0x0004EA39 File Offset: 0x0004CC39
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateWhitespace(this.Data);
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see cref="T:System.Xml.XmlWriter" /> to which you want to save.</param>
		// Token: 0x06000CDF RID: 3295 RVA: 0x0004EA4C File Offset: 0x0004CC4C
		public override void WriteTo(XmlWriter w)
		{
			w.WriteWhitespace(this.Data);
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see cref="T:System.Xml.XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CE0 RID: 3296 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}
	}
}
