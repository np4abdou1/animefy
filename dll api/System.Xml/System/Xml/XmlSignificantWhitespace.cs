using System;

namespace System.Xml
{
	/// <summary>Represents white space between markup in a mixed content node or white space within an xml:space= 'preserve' scope. This is also referred to as significant white space.</summary>
	// Token: 0x02000155 RID: 341
	public class XmlSignificantWhitespace : XmlCharacterData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlSignificantWhitespace" /> class.</summary>
		/// <param name="strData">The white space characters of the node.</param>
		/// <param name="doc">The <see cref="T:System.Xml.XmlDocument" /> object.</param>
		// Token: 0x06000CB6 RID: 3254 RVA: 0x0004E769 File Offset: 0x0004C969
		protected internal XmlSignificantWhitespace(string strData, XmlDocument doc) : base(strData, doc)
		{
			if (!doc.IsLoading && !base.CheckOnData(strData))
			{
				throw new ArgumentException(Res.GetString("The string for white space contains an invalid character."));
			}
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For <see langword="XmlSignificantWhitespace" /> nodes, this property returns <see langword="#significant-whitespace" />.</returns>
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0004E794 File Offset: 0x0004C994
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strSignificantWhitespaceName;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For <see langword="XmlSignificantWhitespace" /> nodes, this property returns <see langword="#significant-whitespace" />.</returns>
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0004E794 File Offset: 0x0004C994
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strSignificantWhitespaceName;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>For <see langword="XmlSignificantWhitespace" /> nodes, this value is XmlNodeType.SignificantWhitespace.</returns>
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0004E7A1 File Offset: 0x0004C9A1
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.SignificantWhitespace;
			}
		}

		/// <summary>Gets the parent of the current node.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> parent node of the current node.</returns>
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0004E7A8 File Offset: 0x0004C9A8
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

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. For significant white space nodes, the cloned node always includes the data value, regardless of the parameter setting. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000CBB RID: 3259 RVA: 0x0004E801 File Offset: 0x0004CA01
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateSignificantWhitespace(this.Data);
		}

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The white space characters found in the node.</returns>
		/// <exception cref="T:System.ArgumentException">Setting <see langword="Value" /> to invalid white space characters. </exception>
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00047089 File Offset: 0x00045289
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x0004E814 File Offset: 0x0004CA14
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

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CBE RID: 3262 RVA: 0x0004E836 File Offset: 0x0004CA36
		public override void WriteTo(XmlWriter w)
		{
			w.WriteString(this.Data);
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CBF RID: 3263 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}
	}
}
