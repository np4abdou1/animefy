using System;
using System.Text;

namespace System.Xml
{
	/// <summary>Provides all the context information required by the <see cref="T:System.Xml.XmlReader" /> to parse an XML fragment.</summary>
	// Token: 0x02000073 RID: 115
	public class XmlParserContext
	{
		/// <summary>Initializes a new instance of the <see langword="XmlParserContext" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, <see langword="xml:lang" />, and <see langword="xml:space" /> values.</summary>
		/// <param name="nt">The <see cref="T:System.Xml.XmlNameTable" /> to use to atomize strings. If this is <see langword="null" />, the name table used to construct the <paramref name="nsMgr" /> is used instead. For more information about atomized strings, see <see cref="T:System.Xml.XmlNameTable" />. </param>
		/// <param name="nsMgr">The <see cref="T:System.Xml.XmlNamespaceManager" /> to use for looking up namespace information, or <see langword="null" />. </param>
		/// <param name="xmlLang">The <see langword="xml:lang" /> scope. </param>
		/// <param name="xmlSpace">An <see cref="T:System.Xml.XmlSpace" /> value indicating the <see langword="xml:space" /> scope. </param>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="nt" /> is not the same <see langword="XmlNameTable" /> used to construct <paramref name="nsMgr" />. </exception>
		// Token: 0x060003CF RID: 975 RVA: 0x00014F30 File Offset: 0x00013130
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) : this(nt, nsMgr, null, null, null, null, string.Empty, xmlLang, xmlSpace)
		{
		}

		/// <summary>Initializes a new instance of the <see langword="XmlParserContext" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, base URI, <see langword="xml:lang" />, <see langword="xml:space" />, and document type values.</summary>
		/// <param name="nt">The <see cref="T:System.Xml.XmlNameTable" /> to use to atomize strings. If this is <see langword="null" />, the name table used to construct the <paramref name="nsMgr" /> is used instead. For more information about atomized strings, see <see cref="T:System.Xml.XmlNameTable" />. </param>
		/// <param name="nsMgr">The <see cref="T:System.Xml.XmlNamespaceManager" /> to use for looking up namespace information, or <see langword="null" />. </param>
		/// <param name="docTypeName">The name of the document type declaration. </param>
		/// <param name="pubId">The public identifier. </param>
		/// <param name="sysId">The system identifier. </param>
		/// <param name="internalSubset">The internal DTD subset. The DTD subset is used for entity resolution, not for document validation.</param>
		/// <param name="baseURI">The base URI for the XML fragment (the location from which the fragment was loaded). </param>
		/// <param name="xmlLang">The <see langword="xml:lang" /> scope. </param>
		/// <param name="xmlSpace">An <see cref="T:System.Xml.XmlSpace" /> value indicating the <see langword="xml:space" /> scope. </param>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="nt" /> is not the same <see langword="XmlNameTable" /> used to construct <paramref name="nsMgr" />. </exception>
		// Token: 0x060003D0 RID: 976 RVA: 0x00014F54 File Offset: 0x00013154
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) : this(nt, nsMgr, docTypeName, pubId, sysId, internalSubset, baseURI, xmlLang, xmlSpace, null)
		{
		}

		/// <summary>Initializes a new instance of the <see langword="XmlParserContext" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, base URI, <see langword="xml:lang" />, <see langword="xml:space" />, encoding, and document type values.</summary>
		/// <param name="nt">The <see cref="T:System.Xml.XmlNameTable" /> to use to atomize strings. If this is <see langword="null" />, the name table used to construct the <paramref name="nsMgr" /> is used instead. For more information about atomized strings, see <see cref="T:System.Xml.XmlNameTable" />. </param>
		/// <param name="nsMgr">The <see cref="T:System.Xml.XmlNamespaceManager" /> to use for looking up namespace information, or <see langword="null" />. </param>
		/// <param name="docTypeName">The name of the document type declaration. </param>
		/// <param name="pubId">The public identifier. </param>
		/// <param name="sysId">The system identifier. </param>
		/// <param name="internalSubset">The internal DTD subset. The DTD is used for entity resolution, not for document validation.</param>
		/// <param name="baseURI">The base URI for the XML fragment (the location from which the fragment was loaded). </param>
		/// <param name="xmlLang">The <see langword="xml:lang" /> scope. </param>
		/// <param name="xmlSpace">An <see cref="T:System.Xml.XmlSpace" /> value indicating the <see langword="xml:space" /> scope. </param>
		/// <param name="enc">An <see cref="T:System.Text.Encoding" /> object indicating the encoding setting. </param>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="nt" /> is not the same <see langword="XmlNameTable" /> used to construct <paramref name="nsMgr" />. </exception>
		// Token: 0x060003D1 RID: 977 RVA: 0x00014F78 File Offset: 0x00013178
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
		{
			if (nsMgr != null)
			{
				if (nt == null)
				{
					this._nt = nsMgr.NameTable;
				}
				else
				{
					if (nt != nsMgr.NameTable)
					{
						throw new XmlException("Not the same name table.", string.Empty);
					}
					this._nt = nt;
				}
			}
			else
			{
				this._nt = nt;
			}
			this._nsMgr = nsMgr;
			this._docTypeName = ((docTypeName == null) ? string.Empty : docTypeName);
			this._pubId = ((pubId == null) ? string.Empty : pubId);
			this._sysId = ((sysId == null) ? string.Empty : sysId);
			this._internalSubset = ((internalSubset == null) ? string.Empty : internalSubset);
			this._baseURI = ((baseURI == null) ? string.Empty : baseURI);
			this._xmlLang = ((xmlLang == null) ? string.Empty : xmlLang);
			this._xmlSpace = xmlSpace;
			this._encoding = enc;
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> used to atomize strings. For more information on atomized strings, see <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <returns>The <see langword="XmlNameTable" />.</returns>
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00015091 File Offset: 0x00013291
		public XmlNameTable NameTable
		{
			get
			{
				return this._nt;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.XmlNamespaceManager" />.</summary>
		/// <returns>The <see langword="XmlNamespaceManager" />.</returns>
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00015099 File Offset: 0x00013299
		public XmlNamespaceManager NamespaceManager
		{
			get
			{
				return this._nsMgr;
			}
		}

		/// <summary>Gets or sets the name of the document type declaration.</summary>
		/// <returns>The name of the document type declaration.</returns>
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000150A1 File Offset: 0x000132A1
		public string DocTypeName
		{
			get
			{
				return this._docTypeName;
			}
		}

		/// <summary>Gets or sets the public identifier.</summary>
		/// <returns>The public identifier.</returns>
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x000150A9 File Offset: 0x000132A9
		public string PublicId
		{
			get
			{
				return this._pubId;
			}
		}

		/// <summary>Gets or sets the system identifier.</summary>
		/// <returns>The system identifier.</returns>
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000150B1 File Offset: 0x000132B1
		public string SystemId
		{
			get
			{
				return this._sysId;
			}
		}

		/// <summary>Gets or sets the base URI.</summary>
		/// <returns>The base URI to use to resolve the DTD file.</returns>
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x000150B9 File Offset: 0x000132B9
		public string BaseURI
		{
			get
			{
				return this._baseURI;
			}
		}

		/// <summary>Gets or sets the internal DTD subset.</summary>
		/// <returns>The internal DTD subset. For example, this property returns everything between the square brackets &lt;!DOCTYPE doc [...]&gt;.</returns>
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000150C1 File Offset: 0x000132C1
		public string InternalSubset
		{
			get
			{
				return this._internalSubset;
			}
		}

		/// <summary>Gets or sets the current <see langword="xml:lang" /> scope.</summary>
		/// <returns>The current <see langword="xml:lang" /> scope. If there is no <see langword="xml:lang" /> in scope, <see langword="String.Empty" /> is returned.</returns>
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000150C9 File Offset: 0x000132C9
		public string XmlLang
		{
			get
			{
				return this._xmlLang;
			}
		}

		/// <summary>Gets or sets the current <see langword="xml:space" /> scope.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlSpace" /> value indicating the <see langword="xml:space" /> scope.</returns>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000150D1 File Offset: 0x000132D1
		public XmlSpace XmlSpace
		{
			get
			{
				return this._xmlSpace;
			}
		}

		/// <summary>Gets or sets the encoding type.</summary>
		/// <returns>An <see cref="T:System.Text.Encoding" /> object indicating the encoding type.</returns>
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060003DB RID: 987 RVA: 0x000150D9 File Offset: 0x000132D9
		public Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000150E1 File Offset: 0x000132E1
		internal bool HasDtdInfo
		{
			get
			{
				return this._internalSubset != string.Empty || this._pubId != string.Empty || this._sysId != string.Empty;
			}
		}

		// Token: 0x040002A7 RID: 679
		private XmlNameTable _nt;

		// Token: 0x040002A8 RID: 680
		private XmlNamespaceManager _nsMgr;

		// Token: 0x040002A9 RID: 681
		private string _docTypeName = string.Empty;

		// Token: 0x040002AA RID: 682
		private string _pubId = string.Empty;

		// Token: 0x040002AB RID: 683
		private string _sysId = string.Empty;

		// Token: 0x040002AC RID: 684
		private string _internalSubset = string.Empty;

		// Token: 0x040002AD RID: 685
		private string _xmlLang = string.Empty;

		// Token: 0x040002AE RID: 686
		private XmlSpace _xmlSpace;

		// Token: 0x040002AF RID: 687
		private string _baseURI = string.Empty;

		// Token: 0x040002B0 RID: 688
		private Encoding _encoding;
	}
}
