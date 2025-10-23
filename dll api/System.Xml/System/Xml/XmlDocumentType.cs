using System;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Represents the document type declaration.</summary>
	// Token: 0x0200013E RID: 318
	public class XmlDocumentType : XmlLinkedNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlDocumentType" /> class.</summary>
		/// <param name="name">The qualified name; see the <see cref="P:System.Xml.XmlDocumentType.Name" /> property.</param>
		/// <param name="publicId">The public identifier; see the <see cref="P:System.Xml.XmlDocumentType.PublicId" /> property.</param>
		/// <param name="systemId">The system identifier; see the <see cref="P:System.Xml.XmlDocumentType.SystemId" /> property.</param>
		/// <param name="internalSubset">The DTD internal subset; see the <see cref="P:System.Xml.XmlDocumentType.InternalSubset" /> property.</param>
		/// <param name="doc">The parent document.</param>
		// Token: 0x06000B34 RID: 2868 RVA: 0x00048ADC File Offset: 0x00046CDC
		protected internal XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) : base(doc)
		{
			this.name = name;
			this.publicId = publicId;
			this.systemId = systemId;
			this.namespaces = true;
			this.internalSubset = internalSubset;
			if (!doc.IsLoading)
			{
				doc.IsLoading = true;
				new XmlLoader().ParseDocumentType(this);
				doc.IsLoading = false;
			}
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For DocumentType nodes, this property returns the name of the document type.</returns>
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00048B39 File Offset: 0x00046D39
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For DocumentType nodes, this property returns the name of the document type.</returns>
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00048B39 File Offset: 0x00046D39
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>For DocumentType nodes, this value is XmlNodeType.DocumentType.</returns>
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00048B41 File Offset: 0x00046D41
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.DocumentType;
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. For document type nodes, the cloned node always includes the subtree, regardless of the parameter setting. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000B38 RID: 2872 RVA: 0x00048B45 File Offset: 0x00046D45
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateDocumentType(this.name, this.publicId, this.systemId, this.internalSubset);
		}

		/// <summary>Gets a value indicating whether the node is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the node is read-only; otherwise <see langword="false" />.Because DocumentType nodes are read-only, this property always returns <see langword="true" />.</returns>
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets the collection of <see cref="T:System.Xml.XmlEntity" /> nodes declared in the document type declaration.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlNamedNodeMap" /> containing the <see langword="XmlEntity" /> nodes. The returned <see langword="XmlNamedNodeMap" /> is read-only.</returns>
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00048B6A File Offset: 0x00046D6A
		public XmlNamedNodeMap Entities
		{
			get
			{
				if (this.entities == null)
				{
					this.entities = new XmlNamedNodeMap(this);
				}
				return this.entities;
			}
		}

		/// <summary>Gets the collection of <see cref="T:System.Xml.XmlNotation" /> nodes present in the document type declaration.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlNamedNodeMap" /> containing the <see langword="XmlNotation" /> nodes. The returned <see langword="XmlNamedNodeMap" /> is read-only.</returns>
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00048B86 File Offset: 0x00046D86
		public XmlNamedNodeMap Notations
		{
			get
			{
				if (this.notations == null)
				{
					this.notations = new XmlNamedNodeMap(this);
				}
				return this.notations;
			}
		}

		/// <summary>Gets the value of the public identifier on the DOCTYPE declaration.</summary>
		/// <returns>The public identifier on the DOCTYPE. If there is no public identifier, <see langword="null" /> is returned.</returns>
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00048BA2 File Offset: 0x00046DA2
		public string PublicId
		{
			get
			{
				return this.publicId;
			}
		}

		/// <summary>Gets the value of the system identifier on the DOCTYPE declaration.</summary>
		/// <returns>The system identifier on the DOCTYPE. If there is no system identifier, <see langword="null" /> is returned.</returns>
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00048BAA File Offset: 0x00046DAA
		public string SystemId
		{
			get
			{
				return this.systemId;
			}
		}

		/// <summary>Gets the value of the document type definition (DTD) internal subset on the DOCTYPE declaration.</summary>
		/// <returns>The DTD internal subset on the DOCTYPE. If there is no DTD internal subset, String.Empty is returned.</returns>
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x00048BB2 File Offset: 0x00046DB2
		public string InternalSubset
		{
			get
			{
				return this.internalSubset;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00048BBA File Offset: 0x00046DBA
		internal bool ParseWithNamespaces
		{
			get
			{
				return this.namespaces;
			}
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B40 RID: 2880 RVA: 0x00048BC2 File Offset: 0x00046DC2
		public override void WriteTo(XmlWriter w)
		{
			w.WriteDocType(this.name, this.publicId, this.systemId, this.internalSubset);
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. For <see langword="XmlDocumentType" /> nodes, this method has no effect.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B41 RID: 2881 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00048BE2 File Offset: 0x00046DE2
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00048BEA File Offset: 0x00046DEA
		internal SchemaInfo DtdSchemaInfo
		{
			get
			{
				return this.schemaInfo;
			}
			set
			{
				this.schemaInfo = value;
			}
		}

		// Token: 0x04000899 RID: 2201
		private string name;

		// Token: 0x0400089A RID: 2202
		private string publicId;

		// Token: 0x0400089B RID: 2203
		private string systemId;

		// Token: 0x0400089C RID: 2204
		private string internalSubset;

		// Token: 0x0400089D RID: 2205
		private bool namespaces;

		// Token: 0x0400089E RID: 2206
		private XmlNamedNodeMap entities;

		// Token: 0x0400089F RID: 2207
		private XmlNamedNodeMap notations;

		// Token: 0x040008A0 RID: 2208
		private SchemaInfo schemaInfo;
	}
}
