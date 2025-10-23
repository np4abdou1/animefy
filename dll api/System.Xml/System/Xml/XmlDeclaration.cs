using System;
using System.Text;

namespace System.Xml
{
	/// <summary>Represents the XML declaration node &lt;?xml version='1.0'...?&gt;.</summary>
	// Token: 0x0200013B RID: 315
	public class XmlDeclaration : XmlLinkedNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlDeclaration" /> class.</summary>
		/// <param name="version">The XML version; see the <see cref="P:System.Xml.XmlDeclaration.Version" /> property.</param>
		/// <param name="encoding">The encoding scheme; see the <see cref="P:System.Xml.XmlDeclaration.Encoding" /> property.</param>
		/// <param name="standalone">Indicates whether the XML document depends on an external DTD; see the <see cref="P:System.Xml.XmlDeclaration.Standalone" /> property.</param>
		/// <param name="doc">The parent XML document.</param>
		// Token: 0x06000AB3 RID: 2739 RVA: 0x000472B4 File Offset: 0x000454B4
		protected internal XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc) : base(doc)
		{
			if (!this.IsValidXmlVersion(version))
			{
				throw new ArgumentException(Res.GetString("Wrong XML version information. The XML must match production \"VersionNum ::= '1.' [0-9]+\"."));
			}
			if (standalone != null && standalone.Length > 0 && standalone != "yes" && standalone != "no")
			{
				throw new ArgumentException(Res.GetString("Wrong value for the XML declaration standalone attribute of '{0}'.", new object[]
				{
					standalone
				}));
			}
			this.Encoding = encoding;
			this.Standalone = standalone;
			this.Version = version;
		}

		/// <summary>Gets the XML version of the document.</summary>
		/// <returns>The value is always <see langword="1.0" />.</returns>
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00047337 File Offset: 0x00045537
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x0004733F File Offset: 0x0004553F
		public string Version
		{
			get
			{
				return this.version;
			}
			internal set
			{
				this.version = value;
			}
		}

		/// <summary>Gets or sets the encoding level of the XML document.</summary>
		/// <returns>The valid character encoding name. The most commonly supported character encoding names for XML are the following: Category Encoding Names Unicode UTF-8, UTF-16 ISO 10646 ISO-10646-UCS-2, ISO-10646-UCS-4 ISO 8859 ISO-8859-n (where "n" is a digit from 1 to 9) JIS X-0208-1997 ISO-2022-JP, Shift_JIS, EUC-JP This value is optional. If a value is not set, this property returns String.Empty.If an encoding attribute is not included, UTF-8 encoding is assumed when the document is written or saved out.</returns>
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00047348 File Offset: 0x00045548
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00047350 File Offset: 0x00045550
		public string Encoding
		{
			get
			{
				return this.encoding;
			}
			set
			{
				this.encoding = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>Gets or sets the value of the standalone attribute.</summary>
		/// <returns>Valid values are <see langword="yes" /> if all entity declarations required by the XML document are contained within the document or <see langword="no" /> if an external document type definition (DTD) is required. If a standalone attribute is not present in the XML declaration, this property returns String.Empty.</returns>
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00047363 File Offset: 0x00045563
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x0004736C File Offset: 0x0004556C
		public string Standalone
		{
			get
			{
				return this.standalone;
			}
			set
			{
				if (value == null)
				{
					this.standalone = string.Empty;
					return;
				}
				if (value.Length == 0 || value == "yes" || value == "no")
				{
					this.standalone = value;
					return;
				}
				throw new ArgumentException(Res.GetString("Wrong value for the XML declaration standalone attribute of '{0}'.", new object[]
				{
					value
				}));
			}
		}

		/// <summary>Gets or sets the value of the <see langword="XmlDeclaration" />.</summary>
		/// <returns>The contents of the <see langword="XmlDeclaration" /> (that is, everything between &lt;?xml and ?&gt;).</returns>
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00046700 File Offset: 0x00044900
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00046708 File Offset: 0x00044908
		public override string Value
		{
			get
			{
				return this.InnerText;
			}
			set
			{
				this.InnerText = value;
			}
		}

		/// <summary>Gets or sets the concatenated values of the <see langword="XmlDeclaration" />.</summary>
		/// <returns>The concatenated values of the <see langword="XmlDeclaration" /> (that is, everything between &lt;?xml and ?&gt;).</returns>
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x000473CC File Offset: 0x000455CC
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00047460 File Offset: 0x00045660
		public override string InnerText
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder("version=\"" + this.Version + "\"");
				if (this.Encoding.Length > 0)
				{
					stringBuilder.Append(" encoding=\"");
					stringBuilder.Append(this.Encoding);
					stringBuilder.Append("\"");
				}
				if (this.Standalone.Length > 0)
				{
					stringBuilder.Append(" standalone=\"");
					stringBuilder.Append(this.Standalone);
					stringBuilder.Append("\"");
				}
				return stringBuilder.ToString();
			}
			set
			{
				string text = null;
				string text2 = null;
				string text3 = null;
				string text4 = this.Encoding;
				string text5 = this.Standalone;
				string text6 = this.Version;
				XmlLoader.ParseXmlDeclarationValue(value, out text, out text2, out text3);
				try
				{
					if (text != null && !this.IsValidXmlVersion(text))
					{
						throw new ArgumentException(Res.GetString("Wrong XML version information. The XML must match production \"VersionNum ::= '1.' [0-9]+\"."));
					}
					this.Version = text;
					if (text2 != null)
					{
						this.Encoding = text2;
					}
					if (text3 != null)
					{
						this.Standalone = text3;
					}
				}
				catch
				{
					this.Encoding = text4;
					this.Standalone = text5;
					this.Version = text6;
					throw;
				}
			}
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For <see langword="XmlDeclaration" /> nodes, the name is <see langword="xml" />.</returns>
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000474FC File Offset: 0x000456FC
		public override string Name
		{
			get
			{
				return "xml";
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For <see langword="XmlDeclaration" /> nodes, the local name is <see langword="xml" />.</returns>
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00047503 File Offset: 0x00045703
		public override string LocalName
		{
			get
			{
				return this.Name;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>For <see langword="XmlDeclaration" /> nodes, this value is XmlNodeType.XmlDeclaration.</returns>
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0004750B File Offset: 0x0004570B
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.XmlDeclaration;
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. Because <see langword="XmlDeclaration" /> nodes do not have children, the cloned node always includes the data value, regardless of the parameter setting. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000AC1 RID: 2753 RVA: 0x0004750F File Offset: 0x0004570F
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateXmlDeclaration(this.Version, this.Encoding, this.Standalone);
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000AC2 RID: 2754 RVA: 0x0004752E File Offset: 0x0004572E
		public override void WriteTo(XmlWriter w)
		{
			w.WriteProcessingInstruction(this.Name, this.InnerText);
		}

		/// <summary>Saves the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. Because <see langword="XmlDeclaration" /> nodes do not have children, this method has no effect.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000AC3 RID: 2755 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00047542 File Offset: 0x00045742
		private bool IsValidXmlVersion(string ver)
		{
			return ver.Length >= 3 && ver[0] == '1' && ver[1] == '.' && XmlCharType.IsOnlyDigits(ver, 2, ver.Length - 2);
		}

		// Token: 0x04000869 RID: 2153
		private string version;

		// Token: 0x0400086A RID: 2154
		private string encoding;

		// Token: 0x0400086B RID: 2155
		private string standalone;
	}
}
