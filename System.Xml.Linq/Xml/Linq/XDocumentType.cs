using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Represents an XML Document Type Definition (DTD). </summary>
	// Token: 0x02000014 RID: 20
	public class XDocumentType : XNode
	{
		/// <summary>Initializes an instance of the <see cref="T:System.Xml.Linq.XDocumentType" /> class. </summary>
		/// <param name="name">A <see cref="T:System.String" /> that contains the qualified name of the DTD, which is the same as the qualified name of the root element of the XML document.</param>
		/// <param name="publicId">A <see cref="T:System.String" /> that contains the public identifier of an external public DTD.</param>
		/// <param name="systemId">A <see cref="T:System.String" /> that contains the system identifier of an external private DTD.</param>
		/// <param name="internalSubset">A <see cref="T:System.String" /> that contains the internal subset for an internal DTD.</param>
		// Token: 0x06000087 RID: 135 RVA: 0x00004896 File Offset: 0x00002A96
		public XDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			this._name = XmlConvert.VerifyName(name);
			this._publicId = publicId;
			this._systemId = systemId;
			this._internalSubset = internalSubset;
		}

		/// <summary>Initializes an instance of the <see cref="T:System.Xml.Linq.XDocumentType" /> class from another <see cref="T:System.Xml.Linq.XDocumentType" /> object.</summary>
		/// <param name="other">An <see cref="T:System.Xml.Linq.XDocumentType" /> object to copy from.</param>
		// Token: 0x06000088 RID: 136 RVA: 0x000048C0 File Offset: 0x00002AC0
		public XDocumentType(XDocumentType other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this._name = other._name;
			this._publicId = other._publicId;
			this._systemId = other._systemId;
			this._internalSubset = other._internalSubset;
		}

		/// <summary>Gets or sets the internal subset for this Document Type Definition (DTD).</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the internal subset for this Document Type Definition (DTD).</returns>
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004911 File Offset: 0x00002B11
		public string InternalSubset
		{
			get
			{
				return this._internalSubset;
			}
		}

		/// <summary>Gets or sets the name for this Document Type Definition (DTD).</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the name for this Document Type Definition (DTD).</returns>
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004919 File Offset: 0x00002B19
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XDocumentType" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.DocumentType" />.</returns>
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004921 File Offset: 0x00002B21
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.DocumentType;
			}
		}

		/// <summary>Gets or sets the public identifier for this Document Type Definition (DTD).</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the public identifier for this Document Type Definition (DTD).</returns>
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004925 File Offset: 0x00002B25
		public string PublicId
		{
			get
			{
				return this._publicId;
			}
		}

		/// <summary>Gets or sets the system identifier for this Document Type Definition (DTD).</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the system identifier for this Document Type Definition (DTD).</returns>
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000492D File Offset: 0x00002B2D
		public string SystemId
		{
			get
			{
				return this._systemId;
			}
		}

		/// <summary>Write this <see cref="T:System.Xml.Linq.XDocumentType" /> to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		// Token: 0x0600008E RID: 142 RVA: 0x00004935 File Offset: 0x00002B35
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteDocType(this._name, this._publicId, this._systemId, this._internalSubset);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004963 File Offset: 0x00002B63
		public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return writer.WriteDocTypeAsync(this._name, this._publicId, this._systemId, this._internalSubset);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000049A1 File Offset: 0x00002BA1
		internal override XNode CloneNode()
		{
			return new XDocumentType(this);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000049AC File Offset: 0x00002BAC
		internal override bool DeepEquals(XNode node)
		{
			XDocumentType xdocumentType = node as XDocumentType;
			return xdocumentType != null && this._name == xdocumentType._name && this._publicId == xdocumentType._publicId && this._systemId == xdocumentType.SystemId && this._internalSubset == xdocumentType._internalSubset;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004A10 File Offset: 0x00002C10
		internal override int GetDeepHashCode()
		{
			return this._name.GetHashCode() ^ ((this._publicId != null) ? this._publicId.GetHashCode() : 0) ^ ((this._systemId != null) ? this._systemId.GetHashCode() : 0) ^ ((this._internalSubset != null) ? this._internalSubset.GetHashCode() : 0);
		}

		// Token: 0x04000045 RID: 69
		private string _name;

		// Token: 0x04000046 RID: 70
		private string _publicId;

		// Token: 0x04000047 RID: 71
		private string _systemId;

		// Token: 0x04000048 RID: 72
		private string _internalSubset;
	}
}
