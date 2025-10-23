using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Represents an XML document. You can use this class to load, validate, edit, add, and position XML in a document.</summary>
	// Token: 0x0200013C RID: 316
	public class XmlDocument : XmlNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlDocument" /> class.</summary>
		// Token: 0x06000AC5 RID: 2757 RVA: 0x00047574 File Offset: 0x00045774
		public XmlDocument() : this(new XmlImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see langword="XmlDocument" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <param name="nt">The <see langword="XmlNameTable" /> to use. </param>
		// Token: 0x06000AC6 RID: 2758 RVA: 0x00047581 File Offset: 0x00045781
		public XmlDocument(XmlNameTable nt) : this(new XmlImplementation(nt))
		{
		}

		/// <summary>Initializes a new instance of the <see langword="XmlDocument" /> class with the specified <see cref="T:System.Xml.XmlImplementation" />.</summary>
		/// <param name="imp">The <see langword="XmlImplementation" /> to use. </param>
		// Token: 0x06000AC7 RID: 2759 RVA: 0x00047590 File Offset: 0x00045790
		protected internal XmlDocument(XmlImplementation imp)
		{
			this.implementation = imp;
			this.domNameTable = new DomNameTable(this);
			XmlNameTable nameTable = this.NameTable;
			nameTable.Add(string.Empty);
			this.strDocumentName = nameTable.Add("#document");
			this.strDocumentFragmentName = nameTable.Add("#document-fragment");
			this.strCommentName = nameTable.Add("#comment");
			this.strTextName = nameTable.Add("#text");
			this.strCDataSectionName = nameTable.Add("#cdata-section");
			this.strEntityName = nameTable.Add("#entity");
			this.strID = nameTable.Add("id");
			this.strNonSignificantWhitespaceName = nameTable.Add("#whitespace");
			this.strSignificantWhitespaceName = nameTable.Add("#significant-whitespace");
			this.strXmlns = nameTable.Add("xmlns");
			this.strXml = nameTable.Add("xml");
			this.strSpace = nameTable.Add("space");
			this.strLang = nameTable.Add("lang");
			this.strReservedXmlns = nameTable.Add("http://www.w3.org/2000/xmlns/");
			this.strReservedXml = nameTable.Add("http://www.w3.org/XML/1998/namespace");
			this.strEmpty = nameTable.Add(string.Empty);
			this.baseURI = string.Empty;
			this.objLock = new object();
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000476EF File Offset: 0x000458EF
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x000476F7 File Offset: 0x000458F7
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

		// Token: 0x06000ACA RID: 2762 RVA: 0x00047700 File Offset: 0x00045900
		internal static void CheckName(string name)
		{
			int num = ValidateNames.ParseNmtoken(name, 0);
			if (num < name.Length)
			{
				throw new XmlException("The '{0}' character, hexadecimal value {1}, cannot be included in a name.", XmlException.BuildCharExceptionArgs(name, num));
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00047730 File Offset: 0x00045930
		internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return this.domNameTable.AddName(prefix, localName, namespaceURI, schemaInfo);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00047742 File Offset: 0x00045942
		internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return this.domNameTable.GetName(prefix, localName, namespaceURI, schemaInfo);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00047754 File Offset: 0x00045954
		internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			XmlName xmlName = this.AddXmlName(prefix, localName, namespaceURI, schemaInfo);
			if (!this.IsLoading)
			{
				object prefix2 = xmlName.Prefix;
				object namespaceURI2 = xmlName.NamespaceURI;
				object localName2 = xmlName.LocalName;
				if ((prefix2 == this.strXmlns || (prefix2 == this.strEmpty && localName2 == this.strXmlns)) ^ namespaceURI2 == this.strReservedXmlns)
				{
					throw new ArgumentException(Res.GetString("The namespace declaration attribute has an incorrect 'namespaceURI': '{0}'.", new object[]
					{
						namespaceURI
					}));
				}
			}
			return xmlName;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000477D2 File Offset: 0x000459D2
		internal bool AddIdInfo(XmlName eleName, XmlName attrName)
		{
			if (this.htElementIDAttrDecl == null || this.htElementIDAttrDecl[eleName] == null)
			{
				if (this.htElementIDAttrDecl == null)
				{
					this.htElementIDAttrDecl = new Hashtable();
				}
				this.htElementIDAttrDecl.Add(eleName, attrName);
				return true;
			}
			return false;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00047810 File Offset: 0x00045A10
		private XmlName GetIDInfoByElement_(XmlName eleName)
		{
			XmlName xmlName = this.GetXmlName(eleName.Prefix, eleName.LocalName, string.Empty, null);
			if (xmlName != null)
			{
				return (XmlName)this.htElementIDAttrDecl[xmlName];
			}
			return null;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0004784C File Offset: 0x00045A4C
		internal XmlName GetIDInfoByElement(XmlName eleName)
		{
			if (this.htElementIDAttrDecl == null)
			{
				return null;
			}
			return this.GetIDInfoByElement_(eleName);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00047860 File Offset: 0x00045A60
		private WeakReference GetElement(ArrayList elementList, XmlElement elem)
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in elementList)
			{
				WeakReference weakReference = (WeakReference)obj;
				if (!weakReference.IsAlive)
				{
					arrayList.Add(weakReference);
				}
				else if ((XmlElement)weakReference.Target == elem)
				{
					return weakReference;
				}
			}
			foreach (object obj2 in arrayList)
			{
				WeakReference obj3 = (WeakReference)obj2;
				elementList.Remove(obj3);
			}
			return null;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00047928 File Offset: 0x00045B28
		internal void AddElementWithId(string id, XmlElement elem)
		{
			if (this.htElementIdMap == null || !this.htElementIdMap.Contains(id))
			{
				if (this.htElementIdMap == null)
				{
					this.htElementIdMap = new Hashtable();
				}
				ArrayList arrayList = new ArrayList();
				arrayList.Add(new WeakReference(elem));
				this.htElementIdMap.Add(id, arrayList);
				return;
			}
			ArrayList arrayList2 = (ArrayList)this.htElementIdMap[id];
			if (this.GetElement(arrayList2, elem) == null)
			{
				arrayList2.Add(new WeakReference(elem));
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000479A8 File Offset: 0x00045BA8
		internal void RemoveElementWithId(string id, XmlElement elem)
		{
			if (this.htElementIdMap != null && this.htElementIdMap.Contains(id))
			{
				ArrayList arrayList = (ArrayList)this.htElementIdMap[id];
				WeakReference element = this.GetElement(arrayList, elem);
				if (element != null)
				{
					arrayList.Remove(element);
					if (arrayList.Count == 0)
					{
						this.htElementIdMap.Remove(id);
					}
				}
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. </param>
		/// <returns>The cloned <see langword="XmlDocument" /> node.</returns>
		// Token: 0x06000AD4 RID: 2772 RVA: 0x00047A04 File Offset: 0x00045C04
		public override XmlNode CloneNode(bool deep)
		{
			XmlDocument xmlDocument = this.Implementation.CreateDocument();
			xmlDocument.SetBaseURI(this.baseURI);
			if (deep)
			{
				xmlDocument.ImportChildren(this, xmlDocument, deep);
			}
			return xmlDocument;
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>The node type. For <see langword="XmlDocument" /> nodes, this value is XmlNodeType.Document.</returns>
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00047A36 File Offset: 0x00045C36
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Document;
			}
		}

		/// <summary>Gets the parent node of this node (for nodes that can have parents).</summary>
		/// <returns>Always returns <see langword="null" />.</returns>
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0001520A File Offset: 0x0001340A
		public override XmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the node containing the DOCTYPE declaration.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> containing the DocumentType (DOCTYPE declaration).</returns>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00047A3A File Offset: 0x00045C3A
		public virtual XmlDocumentType DocumentType
		{
			get
			{
				return (XmlDocumentType)this.FindChild(XmlNodeType.DocumentType);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00047A49 File Offset: 0x00045C49
		internal virtual XmlDeclaration Declaration
		{
			get
			{
				if (this.HasChildNodes)
				{
					return this.FirstChild as XmlDeclaration;
				}
				return null;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlImplementation" /> object for the current document.</summary>
		/// <returns>The <see langword="XmlImplementation" /> object for the current document.</returns>
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00047A60 File Offset: 0x00045C60
		public XmlImplementation Implementation
		{
			get
			{
				return this.implementation;
			}
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For <see langword="XmlDocument" /> nodes, the name is #document.</returns>
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00047A68 File Offset: 0x00045C68
		public override string Name
		{
			get
			{
				return this.strDocumentName;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For <see langword="XmlDocument" /> nodes, the local name is #document.</returns>
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00047A68 File Offset: 0x00045C68
		public override string LocalName
		{
			get
			{
				return this.strDocumentName;
			}
		}

		/// <summary>Gets the root <see cref="T:System.Xml.XmlElement" /> for the document.</summary>
		/// <returns>The <see langword="XmlElement" /> that represents the root of the XML document tree. If no root exists, <see langword="null" /> is returned.</returns>
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00047A70 File Offset: 0x00045C70
		public XmlElement DocumentElement
		{
			get
			{
				return (XmlElement)this.FindChild(XmlNodeType.Element);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00047A7E File Offset: 0x00045C7E
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00047A86 File Offset: 0x00045C86
		internal override XmlLinkedNode LastNode
		{
			get
			{
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which the current node belongs.</summary>
		/// <returns>For <see langword="XmlDocument" /> nodes (<see cref="P:System.Xml.XmlDocument.NodeType" /> equals XmlNodeType.Document), this property always returns <see langword="null" />.</returns>
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0001520A File Offset: 0x0001340A
		public override XmlDocument OwnerDocument
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object associated with this <see cref="T:System.Xml.XmlDocument" />.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object containing the XML Schema Definition Language (XSD) schemas associated with this <see cref="T:System.Xml.XmlDocument" />; otherwise, an empty <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object.</returns>
		// Token: 0x170001F1 RID: 497
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00047A8F File Offset: 0x00045C8F
		public XmlSchemaSet Schemas
		{
			set
			{
				this.schemas = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00047A98 File Offset: 0x00045C98
		internal bool CanReportValidity
		{
			get
			{
				return this.reportValidity;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00047AA0 File Offset: 0x00045CA0
		internal bool HasSetResolver
		{
			get
			{
				return this.bSetResolver;
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00047AA8 File Offset: 0x00045CA8
		internal XmlResolver GetResolver()
		{
			return this.resolver;
		}

		/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> to use for resolving external resources.</summary>
		/// <returns>The <see langword="XmlResolver" /> to use.In version 1.1 of the.NET Framework, the caller must be fully trusted in order to specify an <see langword="XmlResolver" />.</returns>
		/// <exception cref="T:System.Xml.XmlException">This property is set to <see langword="null" /> and an external DTD or entity is encountered. </exception>
		// Token: 0x170001F4 RID: 500
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00047AB0 File Offset: 0x00045CB0
		public virtual XmlResolver XmlResolver
		{
			set
			{
				if (value != null)
				{
					try
					{
						new NamedPermissionSet("FullTrust").Demand();
					}
					catch (SecurityException inner)
					{
						throw new SecurityException(Res.GetString("XmlResolver can be set only by fully trusted code."), inner);
					}
				}
				this.resolver = value;
				if (!this.bSetResolver)
				{
					this.bSetResolver = true;
				}
				XmlDocumentType documentType = this.DocumentType;
				if (documentType != null)
				{
					documentType.DtdSchemaInfo = null;
				}
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00047B1C File Offset: 0x00045D1C
		internal override bool IsValidChildType(XmlNodeType type)
		{
			if (type != XmlNodeType.Element)
			{
				switch (type)
				{
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.Comment:
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					return true;
				case XmlNodeType.DocumentType:
					if (this.DocumentType != null)
					{
						throw new InvalidOperationException(Res.GetString("This document already has a 'DocumentType' node."));
					}
					return true;
				case XmlNodeType.XmlDeclaration:
					if (this.Declaration != null)
					{
						throw new InvalidOperationException(Res.GetString("This document already has an 'XmlDeclaration' node."));
					}
					return true;
				}
				return false;
			}
			if (this.DocumentElement != null)
			{
				throw new InvalidOperationException(Res.GetString("This document already has a 'DocumentElement' node."));
			}
			return true;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00047BB4 File Offset: 0x00045DB4
		private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode)
		{
			if (refNode == null)
			{
				return false;
			}
			XmlNode xmlNode = null;
			if (refNode.ParentNode != null)
			{
				xmlNode = refNode.ParentNode.FirstChild;
			}
			while (xmlNode != null)
			{
				if (xmlNode.NodeType == nt)
				{
					return true;
				}
				if (xmlNode == refNode)
				{
					break;
				}
				xmlNode = xmlNode.NextSibling;
			}
			return false;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00047BF8 File Offset: 0x00045DF8
		private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode)
		{
			for (XmlNode xmlNode = refNode; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				if (xmlNode.NodeType == nt)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00047C20 File Offset: 0x00045E20
		internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			if (refChild == null)
			{
				refChild = this.FirstChild;
			}
			if (refChild == null)
			{
				return true;
			}
			XmlNodeType nodeType = newChild.NodeType;
			if (nodeType <= XmlNodeType.Comment)
			{
				if (nodeType != XmlNodeType.Element)
				{
					if (nodeType - XmlNodeType.ProcessingInstruction <= 1)
					{
						return refChild.NodeType != XmlNodeType.XmlDeclaration;
					}
				}
				else if (refChild.NodeType != XmlNodeType.XmlDeclaration)
				{
					return !this.HasNodeTypeInNextSiblings(XmlNodeType.DocumentType, refChild);
				}
			}
			else if (nodeType != XmlNodeType.DocumentType)
			{
				if (nodeType == XmlNodeType.XmlDeclaration)
				{
					return refChild == this.FirstChild;
				}
			}
			else if (refChild.NodeType != XmlNodeType.XmlDeclaration)
			{
				return !this.HasNodeTypeInPrevSiblings(XmlNodeType.Element, refChild.PreviousSibling);
			}
			return false;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00047CAC File Offset: 0x00045EAC
		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			if (refChild == null)
			{
				refChild = this.LastChild;
			}
			if (refChild == null)
			{
				return true;
			}
			XmlNodeType nodeType = newChild.NodeType;
			if (nodeType != XmlNodeType.Element)
			{
				switch (nodeType)
				{
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.Comment:
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					return true;
				case XmlNodeType.DocumentType:
					return !this.HasNodeTypeInPrevSiblings(XmlNodeType.Element, refChild);
				}
				return false;
			}
			return !this.HasNodeTypeInNextSiblings(XmlNodeType.DocumentType, refChild.NextSibling);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlAttribute" /> with the specified <see cref="P:System.Xml.XmlDocument.Name" />.</summary>
		/// <param name="name">The qualified name of the attribute. If the name contains a colon, the <see cref="P:System.Xml.XmlNode.Prefix" /> property reflects the part of the name preceding the first colon and the <see cref="P:System.Xml.XmlDocument.LocalName" /> property reflects the part of the name following the first colon. The <see cref="P:System.Xml.XmlNode.NamespaceURI" /> remains empty unless the prefix is a recognized built-in prefix such as xmlns. In this case <see langword="NamespaceURI" /> has a value of http://www.w3.org/2000/xmlns/. </param>
		/// <returns>The new <see langword="XmlAttribute" />.</returns>
		// Token: 0x06000AEB RID: 2795 RVA: 0x00047D20 File Offset: 0x00045F20
		public XmlAttribute CreateAttribute(string name)
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			XmlNode.SplitName(name, out empty, out empty2);
			this.SetDefaultNamespace(empty, empty2, ref empty3);
			return this.CreateAttribute(empty, empty2, empty3);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00047D5C File Offset: 0x00045F5C
		internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI)
		{
			if (prefix == this.strXmlns || (prefix.Length == 0 && localName == this.strXmlns))
			{
				namespaceURI = this.strReservedXmlns;
				return;
			}
			if (prefix == this.strXml)
			{
				namespaceURI = this.strReservedXml;
			}
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlCDataSection" /> containing the specified data.</summary>
		/// <param name="data">The content of the new <see langword="XmlCDataSection" />. </param>
		/// <returns>The new <see langword="XmlCDataSection" />.</returns>
		// Token: 0x06000AED RID: 2797 RVA: 0x00047DAC File Offset: 0x00045FAC
		public virtual XmlCDataSection CreateCDataSection(string data)
		{
			this.fCDataNodesPresent = true;
			return new XmlCDataSection(data, this);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlComment" /> containing the specified data.</summary>
		/// <param name="data">The content of the new <see langword="XmlComment" />. </param>
		/// <returns>The new <see langword="XmlComment" />.</returns>
		// Token: 0x06000AEE RID: 2798 RVA: 0x00047DBC File Offset: 0x00045FBC
		public virtual XmlComment CreateComment(string data)
		{
			return new XmlComment(data, this);
		}

		/// <summary>Returns a new <see cref="T:System.Xml.XmlDocumentType" /> object.</summary>
		/// <param name="name">Name of the document type. </param>
		/// <param name="publicId">The public identifier of the document type or <see langword="null" />. You can specify a public URI and also a system identifier to identify the location of the external DTD subset.</param>
		/// <param name="systemId">The system identifier of the document type or <see langword="null" />. Specifies the URL of the file location for the external DTD subset.</param>
		/// <param name="internalSubset">The DTD internal subset of the document type or <see langword="null" />. </param>
		/// <returns>The new <see langword="XmlDocumentType" />.</returns>
		// Token: 0x06000AEF RID: 2799 RVA: 0x00047DC5 File Offset: 0x00045FC5
		public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return new XmlDocumentType(name, publicId, systemId, internalSubset, this);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlDocumentFragment" />.</summary>
		/// <returns>The new <see langword="XmlDocumentFragment" />.</returns>
		// Token: 0x06000AF0 RID: 2800 RVA: 0x00047DD2 File Offset: 0x00045FD2
		public virtual XmlDocumentFragment CreateDocumentFragment()
		{
			return new XmlDocumentFragment(this);
		}

		/// <summary>Creates an element with the specified name.</summary>
		/// <param name="name">The qualified name of the element. If the name contains a colon then the <see cref="P:System.Xml.XmlNode.Prefix" /> property reflects the part of the name preceding the colon and the <see cref="P:System.Xml.XmlDocument.LocalName" /> property reflects the part of the name after the colon. The qualified name cannot include a prefix of'xmlns'. </param>
		/// <returns>The new <see langword="XmlElement" />.</returns>
		// Token: 0x06000AF1 RID: 2801 RVA: 0x00047DDC File Offset: 0x00045FDC
		public XmlElement CreateElement(string name)
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			XmlNode.SplitName(name, out empty, out empty2);
			return this.CreateElement(empty, empty2, string.Empty);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00047E0C File Offset: 0x0004600C
		internal void AddDefaultAttributes(XmlElement elem)
		{
			SchemaInfo dtdSchemaInfo = this.DtdSchemaInfo;
			SchemaElementDecl schemaElementDecl = this.GetSchemaElementDecl(elem);
			if (schemaElementDecl != null && schemaElementDecl.AttDefs != null)
			{
				IDictionaryEnumerator dictionaryEnumerator = schemaElementDecl.AttDefs.GetEnumerator();
				while (dictionaryEnumerator.MoveNext())
				{
					SchemaAttDef schemaAttDef = (SchemaAttDef)dictionaryEnumerator.Value;
					if (schemaAttDef.Presence == SchemaDeclBase.Use.Default || schemaAttDef.Presence == SchemaDeclBase.Use.Fixed)
					{
						string attrPrefix = string.Empty;
						string name = schemaAttDef.Name.Name;
						string attrNamespaceURI = string.Empty;
						if (dtdSchemaInfo.SchemaType == SchemaType.DTD)
						{
							attrPrefix = schemaAttDef.Name.Namespace;
						}
						else
						{
							attrPrefix = schemaAttDef.Prefix;
							attrNamespaceURI = schemaAttDef.Name.Namespace;
						}
						XmlAttribute attributeNode = this.PrepareDefaultAttribute(schemaAttDef, attrPrefix, name, attrNamespaceURI);
						elem.SetAttributeNode(attributeNode);
					}
				}
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00047ED4 File Offset: 0x000460D4
		private SchemaElementDecl GetSchemaElementDecl(XmlElement elem)
		{
			SchemaInfo dtdSchemaInfo = this.DtdSchemaInfo;
			if (dtdSchemaInfo != null)
			{
				XmlQualifiedName key = new XmlQualifiedName(elem.LocalName, (dtdSchemaInfo.SchemaType == SchemaType.DTD) ? elem.Prefix : elem.NamespaceURI);
				SchemaElementDecl result;
				if (dtdSchemaInfo.ElementDecls.TryGetValue(key, out result))
				{
					return result;
				}
			}
			return null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00047F24 File Offset: 0x00046124
		private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			this.SetDefaultNamespace(attrPrefix, attrLocalname, ref attrNamespaceURI);
			XmlAttribute xmlAttribute = this.CreateDefaultAttribute(attrPrefix, attrLocalname, attrNamespaceURI);
			xmlAttribute.InnerXml = attdef.DefaultValueRaw;
			XmlUnspecifiedAttribute xmlUnspecifiedAttribute = xmlAttribute as XmlUnspecifiedAttribute;
			if (xmlUnspecifiedAttribute != null)
			{
				xmlUnspecifiedAttribute.SetSpecified(false);
			}
			return xmlAttribute;
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlEntityReference" /> with the specified name.</summary>
		/// <param name="name">The name of the entity reference. </param>
		/// <returns>The new <see langword="XmlEntityReference" />.</returns>
		/// <exception cref="T:System.ArgumentException">The name is invalid (for example, names starting with'#' are invalid.) </exception>
		// Token: 0x06000AF5 RID: 2805 RVA: 0x00047F62 File Offset: 0x00046162
		public virtual XmlEntityReference CreateEntityReference(string name)
		{
			return new XmlEntityReference(name, this);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlProcessingInstruction" /> with the specified name and data.</summary>
		/// <param name="target">The name of the processing instruction. </param>
		/// <param name="data">The data for the processing instruction. </param>
		/// <returns>The new <see langword="XmlProcessingInstruction" />.</returns>
		// Token: 0x06000AF6 RID: 2806 RVA: 0x00047F6B File Offset: 0x0004616B
		public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			return new XmlProcessingInstruction(target, data, this);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlDeclaration" /> node with the specified values.</summary>
		/// <param name="version">The version must be "1.0". </param>
		/// <param name="encoding">The value of the encoding attribute. This is the encoding that is used when you save the <see cref="T:System.Xml.XmlDocument" /> to a file or a stream; therefore, it must be set to a string supported by the <see cref="T:System.Text.Encoding" /> class, otherwise <see cref="M:System.Xml.XmlDocument.Save(System.String)" /> fails. If this is <see langword="null" /> or String.Empty, the <see langword="Save" /> method does not write an encoding attribute on the XML declaration and therefore the default encoding, UTF-8, is used.Note: If the <see langword="XmlDocument" /> is saved to either a <see cref="T:System.IO.TextWriter" /> or an <see cref="T:System.Xml.XmlTextWriter" />, this encoding value is discarded. Instead, the encoding of the <see langword="TextWriter" /> or the <see langword="XmlTextWriter" /> is used. This ensures that the XML written out can be read back using the correct encoding. </param>
		/// <param name="standalone">The value must be either "yes" or "no". If this is <see langword="null" /> or String.Empty, the <see langword="Save" /> method does not write a standalone attribute on the XML declaration. </param>
		/// <returns>The new <see langword="XmlDeclaration" /> node.</returns>
		/// <exception cref="T:System.ArgumentException">The values of <paramref name="version" /> or <paramref name="standalone" /> are something other than the ones specified above. </exception>
		// Token: 0x06000AF7 RID: 2807 RVA: 0x00047F75 File Offset: 0x00046175
		public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return new XmlDeclaration(version, encoding, standalone, this);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlText" /> with the specified text.</summary>
		/// <param name="text">The text for the Text node. </param>
		/// <returns>The new <see langword="XmlText" /> node.</returns>
		// Token: 0x06000AF8 RID: 2808 RVA: 0x00047F80 File Offset: 0x00046180
		public virtual XmlText CreateTextNode(string text)
		{
			return new XmlText(text, this);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlSignificantWhitespace" /> node.</summary>
		/// <param name="text">The string must contain only the following characters &amp;#20; &amp;#10; &amp;#13; and &amp;#9; </param>
		/// <returns>A new <see langword="XmlSignificantWhitespace" /> node.</returns>
		// Token: 0x06000AF9 RID: 2809 RVA: 0x00047F89 File Offset: 0x00046189
		public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text)
		{
			return new XmlSignificantWhitespace(text, this);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlWhitespace" /> node.</summary>
		/// <param name="text">The string must contain only the following characters &amp;#20; &amp;#10; &amp;#13; and &amp;#9; </param>
		/// <returns>A new <see langword="XmlWhitespace" /> node.</returns>
		// Token: 0x06000AFA RID: 2810 RVA: 0x00047F92 File Offset: 0x00046192
		public virtual XmlWhitespace CreateWhitespace(string text)
		{
			return new XmlWhitespace(text, this);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlAttribute" /> with the specified qualified name and <see cref="P:System.Xml.XmlNode.NamespaceURI" />.</summary>
		/// <param name="qualifiedName">The qualified name of the attribute. If the name contains a colon then the <see cref="P:System.Xml.XmlNode.Prefix" /> property will reflect the part of the name preceding the colon and the <see cref="P:System.Xml.XmlDocument.LocalName" /> property will reflect the part of the name after the colon. </param>
		/// <param name="namespaceURI">The namespaceURI of the attribute. If the qualified name includes a prefix of xmlns, then this parameter must be http://www.w3.org/2000/xmlns/. </param>
		/// <returns>The new <see langword="XmlAttribute" />.</returns>
		// Token: 0x06000AFB RID: 2811 RVA: 0x00047F9C File Offset: 0x0004619C
		public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI)
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			XmlNode.SplitName(qualifiedName, out empty, out empty2);
			return this.CreateAttribute(empty, empty2, namespaceURI);
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlElement" /> with the qualified name and <see cref="P:System.Xml.XmlNode.NamespaceURI" />.</summary>
		/// <param name="qualifiedName">The qualified name of the element. If the name contains a colon then the <see cref="P:System.Xml.XmlNode.Prefix" /> property will reflect the part of the name preceding the colon and the <see cref="P:System.Xml.XmlDocument.LocalName" /> property will reflect the part of the name after the colon. The qualified name cannot include a prefix of'xmlns'. </param>
		/// <param name="namespaceURI">The namespace URI of the element. </param>
		/// <returns>The new <see langword="XmlElement" />.</returns>
		// Token: 0x06000AFC RID: 2812 RVA: 0x00047FC8 File Offset: 0x000461C8
		public XmlElement CreateElement(string qualifiedName, string namespaceURI)
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			XmlNode.SplitName(qualifiedName, out empty, out empty2);
			return this.CreateElement(empty, empty2, namespaceURI);
		}

		/// <summary>Imports a node from another document to the current document.</summary>
		/// <param name="node">The node being imported. </param>
		/// <param name="deep">
		///       <see langword="true" /> to perform a deep clone; otherwise, <see langword="false" />. </param>
		/// <returns>The imported <see cref="T:System.Xml.XmlNode" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Calling this method on a node type which cannot be imported. </exception>
		// Token: 0x06000AFD RID: 2813 RVA: 0x00047FF4 File Offset: 0x000461F4
		public virtual XmlNode ImportNode(XmlNode node, bool deep)
		{
			return this.ImportNodeInternal(node, deep);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00048000 File Offset: 0x00046200
		private XmlNode ImportNodeInternal(XmlNode node, bool deep)
		{
			if (node == null)
			{
				throw new InvalidOperationException(Res.GetString("Cannot import a null node."));
			}
			switch (node.NodeType)
			{
			case XmlNodeType.Element:
			{
				XmlNode xmlNode = this.CreateElement(node.Prefix, node.LocalName, node.NamespaceURI);
				this.ImportAttributes(node, xmlNode);
				if (deep)
				{
					this.ImportChildren(node, xmlNode, deep);
					return xmlNode;
				}
				return xmlNode;
			}
			case XmlNodeType.Attribute:
			{
				XmlNode xmlNode = this.CreateAttribute(node.Prefix, node.LocalName, node.NamespaceURI);
				this.ImportChildren(node, xmlNode, true);
				return xmlNode;
			}
			case XmlNodeType.Text:
				return this.CreateTextNode(node.Value);
			case XmlNodeType.CDATA:
				return this.CreateCDataSection(node.Value);
			case XmlNodeType.EntityReference:
				return this.CreateEntityReference(node.Name);
			case XmlNodeType.ProcessingInstruction:
				return this.CreateProcessingInstruction(node.Name, node.Value);
			case XmlNodeType.Comment:
				return this.CreateComment(node.Value);
			case XmlNodeType.DocumentType:
			{
				XmlDocumentType xmlDocumentType = (XmlDocumentType)node;
				return this.CreateDocumentType(xmlDocumentType.Name, xmlDocumentType.PublicId, xmlDocumentType.SystemId, xmlDocumentType.InternalSubset);
			}
			case XmlNodeType.DocumentFragment:
			{
				XmlNode xmlNode = this.CreateDocumentFragment();
				if (deep)
				{
					this.ImportChildren(node, xmlNode, deep);
					return xmlNode;
				}
				return xmlNode;
			}
			case XmlNodeType.Whitespace:
				return this.CreateWhitespace(node.Value);
			case XmlNodeType.SignificantWhitespace:
				return this.CreateSignificantWhitespace(node.Value);
			case XmlNodeType.XmlDeclaration:
			{
				XmlDeclaration xmlDeclaration = (XmlDeclaration)node;
				return this.CreateXmlDeclaration(xmlDeclaration.Version, xmlDeclaration.Encoding, xmlDeclaration.Standalone);
			}
			}
			throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, Res.GetString("Cannot import nodes of type '{0}'."), node.NodeType.ToString()));
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000481E4 File Offset: 0x000463E4
		private void ImportAttributes(XmlNode fromElem, XmlNode toElem)
		{
			int count = fromElem.Attributes.Count;
			for (int i = 0; i < count; i++)
			{
				if (fromElem.Attributes[i].Specified)
				{
					toElem.Attributes.SetNamedItem(this.ImportNodeInternal(fromElem.Attributes[i], true));
				}
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0004823C File Offset: 0x0004643C
		private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep)
		{
			for (XmlNode xmlNode = fromNode.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				toNode.AppendChild(this.ImportNodeInternal(xmlNode, deep));
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
		/// <returns>An <see langword="XmlNameTable" /> enabling you to get the atomized version of a string within the document.</returns>
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0004826B File Offset: 0x0004646B
		public XmlNameTable NameTable
		{
			get
			{
				return this.implementation.NameTable;
			}
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlAttribute" /> with the specified <see cref="P:System.Xml.XmlNode.Prefix" />, <see cref="P:System.Xml.XmlDocument.LocalName" />, and <see cref="P:System.Xml.XmlNode.NamespaceURI" />.</summary>
		/// <param name="prefix">The prefix of the attribute (if any). String.Empty and <see langword="null" /> are equivalent. </param>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute (if any). String.Empty and <see langword="null" /> are equivalent. If <paramref name="prefix" /> is xmlns, then this parameter must be http://www.w3.org/2000/xmlns/; otherwise an exception is thrown. </param>
		/// <returns>The new <see langword="XmlAttribute" />.</returns>
		// Token: 0x06000B02 RID: 2818 RVA: 0x00048278 File Offset: 0x00046478
		public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI)
		{
			return new XmlAttribute(this.AddAttrXmlName(prefix, localName, namespaceURI, null), this);
		}

		/// <summary>Creates a default attribute with the specified prefix, local name and namespace URI.</summary>
		/// <param name="prefix">The prefix of the attribute (if any). </param>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute (if any). </param>
		/// <returns>The new <see cref="T:System.Xml.XmlAttribute" />.</returns>
		// Token: 0x06000B03 RID: 2819 RVA: 0x0004828A File Offset: 0x0004648A
		protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI)
		{
			return new XmlUnspecifiedAttribute(prefix, localName, namespaceURI, this);
		}

		/// <summary>Creates an element with the specified <see cref="P:System.Xml.XmlNode.Prefix" />, <see cref="P:System.Xml.XmlDocument.LocalName" />, and <see cref="P:System.Xml.XmlNode.NamespaceURI" />.</summary>
		/// <param name="prefix">The prefix of the new element (if any). String.Empty and <see langword="null" /> are equivalent. </param>
		/// <param name="localName">The local name of the new element. </param>
		/// <param name="namespaceURI">The namespace URI of the new element (if any). String.Empty and <see langword="null" /> are equivalent. </param>
		/// <returns>The new <see cref="T:System.Xml.XmlElement" />.</returns>
		// Token: 0x06000B04 RID: 2820 RVA: 0x00048298 File Offset: 0x00046498
		public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI)
		{
			XmlElement xmlElement = new XmlElement(this.AddXmlName(prefix, localName, namespaceURI, null), true, this);
			if (!this.IsLoading)
			{
				this.AddDefaultAttributes(xmlElement);
			}
			return xmlElement;
		}

		/// <summary>Gets a value indicating whether the current node is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the current node is read-only; otherwise <see langword="false" />. <see langword="XmlDocument" /> nodes always return <see langword="false" />.</returns>
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0000A216 File Offset: 0x00008416
		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x000482C7 File Offset: 0x000464C7
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x000482E3 File Offset: 0x000464E3
		internal XmlNamedNodeMap Entities
		{
			get
			{
				if (this.entities == null)
				{
					this.entities = new XmlNamedNodeMap(this);
				}
				return this.entities;
			}
			set
			{
				this.entities = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x000482EC File Offset: 0x000464EC
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x000482F4 File Offset: 0x000464F4
		internal bool IsLoading
		{
			get
			{
				return this.isLoading;
			}
			set
			{
				this.isLoading = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x000482FD File Offset: 0x000464FD
		internal bool ActualLoadingStatus
		{
			get
			{
				return this.actualLoadingStatus;
			}
		}

		/// <summary>Creates an <see cref="T:System.Xml.XmlNode" /> object based on the information in the <see cref="T:System.Xml.XmlReader" />. The reader must be positioned on a node or attribute.</summary>
		/// <param name="reader">The XML source </param>
		/// <returns>The new <see langword="XmlNode" /> or <see langword="null" /> if no more nodes exist.</returns>
		/// <exception cref="T:System.NullReferenceException">The reader is positioned on a node type that does not translate to a valid DOM node (for example, EndElement or EndEntity). </exception>
		// Token: 0x06000B0B RID: 2827 RVA: 0x00048308 File Offset: 0x00046508
		public virtual XmlNode ReadNode(XmlReader reader)
		{
			XmlNode result = null;
			try
			{
				this.IsLoading = true;
				result = new XmlLoader().ReadCurrentNode(this, reader);
			}
			finally
			{
				this.IsLoading = false;
			}
			return result;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00048348 File Offset: 0x00046548
		private XmlTextReader SetupReader(XmlTextReader tr)
		{
			tr.XmlValidatingReaderCompatibilityMode = true;
			tr.EntityHandling = EntityHandling.ExpandCharEntities;
			if (this.HasSetResolver)
			{
				tr.XmlResolver = this.GetResolver();
			}
			return tr;
		}

		/// <summary>Loads the XML document from the specified <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="reader">The <see langword="XmlReader" /> used to feed the XML data into the document. </param>
		/// <exception cref="T:System.Xml.XmlException">There is a load or parse error in the XML. In this case, the document remains empty. </exception>
		// Token: 0x06000B0D RID: 2829 RVA: 0x00048370 File Offset: 0x00046570
		public virtual void Load(XmlReader reader)
		{
			try
			{
				this.IsLoading = true;
				this.actualLoadingStatus = true;
				this.RemoveAll();
				this.fEntRefNodesPresent = false;
				this.fCDataNodesPresent = false;
				this.reportValidity = true;
				new XmlLoader().Load(this, reader, this.preserveWhitespace);
			}
			finally
			{
				this.IsLoading = false;
				this.actualLoadingStatus = false;
				this.reportValidity = true;
			}
		}

		/// <summary>Loads the XML document from the specified string.</summary>
		/// <param name="xml">String containing the XML document to load. </param>
		/// <exception cref="T:System.Xml.XmlException">There is a load or parse error in the XML. In this case, the document remains empty. </exception>
		// Token: 0x06000B0E RID: 2830 RVA: 0x000483E0 File Offset: 0x000465E0
		public virtual void LoadXml(string xml)
		{
			XmlTextReader xmlTextReader = this.SetupReader(new XmlTextReader(new StringReader(xml), this.NameTable));
			try
			{
				this.Load(xmlTextReader);
			}
			finally
			{
				xmlTextReader.Close();
			}
		}

		/// <summary>
		///     Throws an <see cref="T:System.InvalidOperationException" /> in all cases.</summary>
		/// <returns>The values of the node and all its child nodes.</returns>
		/// <exception cref="T:System.InvalidOperationException">In all cases.</exception>
		// Token: 0x170001FA RID: 506
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00048428 File Offset: 0x00046628
		public override string InnerText
		{
			set
			{
				throw new InvalidOperationException(Res.GetString("The 'InnerText' of a 'Document' node is read-only and cannot be set."));
			}
		}

		/// <summary>Gets or sets the markup representing the children of the current node.</summary>
		/// <returns>The markup of the children of the current node.</returns>
		/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed. </exception>
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00048439 File Offset: 0x00046639
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00048441 File Offset: 0x00046641
		public override string InnerXml
		{
			get
			{
				return base.InnerXml;
			}
			set
			{
				this.LoadXml(value);
			}
		}

		/// <summary>Saves the XML document to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		/// <exception cref="T:System.Xml.XmlException">The operation would not result in a well formed XML document (for example, no document element or duplicate XML declarations). </exception>
		// Token: 0x06000B12 RID: 2834 RVA: 0x0004844C File Offset: 0x0004664C
		public virtual void Save(XmlWriter w)
		{
			XmlNode xmlNode = this.FirstChild;
			if (xmlNode == null)
			{
				return;
			}
			if (w.WriteState == WriteState.Start)
			{
				if (xmlNode is XmlDeclaration)
				{
					if (this.Standalone.Length == 0)
					{
						w.WriteStartDocument();
					}
					else if (this.Standalone == "yes")
					{
						w.WriteStartDocument(true);
					}
					else if (this.Standalone == "no")
					{
						w.WriteStartDocument(false);
					}
					xmlNode = xmlNode.NextSibling;
				}
				else
				{
					w.WriteStartDocument();
				}
			}
			while (xmlNode != null)
			{
				xmlNode.WriteTo(w);
				xmlNode = xmlNode.NextSibling;
			}
			w.Flush();
		}

		/// <summary>Saves the <see langword="XmlDocument" /> node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B13 RID: 2835 RVA: 0x000484E5 File Offset: 0x000466E5
		public override void WriteTo(XmlWriter w)
		{
			this.WriteContentTo(w);
		}

		/// <summary>Saves all the children of the <see langword="XmlDocument" /> node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="xw">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B14 RID: 2836 RVA: 0x000484F0 File Offset: 0x000466F0
		public override void WriteContentTo(XmlWriter xw)
		{
			foreach (object obj in this)
			{
				((XmlNode)obj).WriteTo(xw);
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00048544 File Offset: 0x00046744
		internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			this.reportValidity = false;
			switch (action)
			{
			case XmlNodeChangedAction.Insert:
				if (this.onNodeInsertingDelegate == null && this.onNodeInsertedDelegate == null)
				{
					return null;
				}
				break;
			case XmlNodeChangedAction.Remove:
				if (this.onNodeRemovingDelegate == null && this.onNodeRemovedDelegate == null)
				{
					return null;
				}
				break;
			case XmlNodeChangedAction.Change:
				if (this.onNodeChangingDelegate == null && this.onNodeChangedDelegate == null)
				{
					return null;
				}
				break;
			}
			return new XmlNodeChangedEventArgs(node, oldParent, newParent, oldValue, newValue, action);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000485B4 File Offset: 0x000467B4
		internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent)
		{
			if (this.onNodeInsertingDelegate == null && this.onNodeInsertedDelegate == null)
			{
				return null;
			}
			string value = node.Value;
			return new XmlNodeChangedEventArgs(node, null, newParent, value, value, XmlNodeChangedAction.Insert);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x000485E8 File Offset: 0x000467E8
		internal override void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			if (args != null)
			{
				switch (args.Action)
				{
				case XmlNodeChangedAction.Insert:
					if (this.onNodeInsertingDelegate != null)
					{
						this.onNodeInsertingDelegate(this, args);
						return;
					}
					break;
				case XmlNodeChangedAction.Remove:
					if (this.onNodeRemovingDelegate != null)
					{
						this.onNodeRemovingDelegate(this, args);
						return;
					}
					break;
				case XmlNodeChangedAction.Change:
					if (this.onNodeChangingDelegate != null)
					{
						this.onNodeChangingDelegate(this, args);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00048654 File Offset: 0x00046854
		internal override void AfterEvent(XmlNodeChangedEventArgs args)
		{
			if (args != null)
			{
				switch (args.Action)
				{
				case XmlNodeChangedAction.Insert:
					if (this.onNodeInsertedDelegate != null)
					{
						this.onNodeInsertedDelegate(this, args);
						return;
					}
					break;
				case XmlNodeChangedAction.Remove:
					if (this.onNodeRemovedDelegate != null)
					{
						this.onNodeRemovedDelegate(this, args);
						return;
					}
					break;
				case XmlNodeChangedAction.Change:
					if (this.onNodeChangedDelegate != null)
					{
						this.onNodeChangedDelegate(this, args);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x000486C0 File Offset: 0x000468C0
		internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			SchemaInfo dtdSchemaInfo = this.DtdSchemaInfo;
			SchemaElementDecl schemaElementDecl = this.GetSchemaElementDecl(elem);
			if (schemaElementDecl != null && schemaElementDecl.AttDefs != null)
			{
				IDictionaryEnumerator dictionaryEnumerator = schemaElementDecl.AttDefs.GetEnumerator();
				while (dictionaryEnumerator.MoveNext())
				{
					SchemaAttDef schemaAttDef = (SchemaAttDef)dictionaryEnumerator.Value;
					if ((schemaAttDef.Presence == SchemaDeclBase.Use.Default || schemaAttDef.Presence == SchemaDeclBase.Use.Fixed) && schemaAttDef.Name.Name == attrLocalname && ((dtdSchemaInfo.SchemaType == SchemaType.DTD && schemaAttDef.Name.Namespace == attrPrefix) || (dtdSchemaInfo.SchemaType != SchemaType.DTD && schemaAttDef.Name.Namespace == attrNamespaceURI)))
					{
						return this.PrepareDefaultAttribute(schemaAttDef, attrPrefix, attrLocalname, attrNamespaceURI);
					}
				}
			}
			return null;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00048780 File Offset: 0x00046980
		internal string Version
		{
			get
			{
				XmlDeclaration declaration = this.Declaration;
				if (declaration != null)
				{
					return declaration.Version;
				}
				return null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000487A0 File Offset: 0x000469A0
		internal string Encoding
		{
			get
			{
				XmlDeclaration declaration = this.Declaration;
				if (declaration != null)
				{
					return declaration.Encoding;
				}
				return null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x000487C0 File Offset: 0x000469C0
		internal string Standalone
		{
			get
			{
				XmlDeclaration declaration = this.Declaration;
				if (declaration != null)
				{
					return declaration.Standalone;
				}
				return null;
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000487E0 File Offset: 0x000469E0
		internal XmlEntity GetEntityNode(string name)
		{
			if (this.DocumentType != null)
			{
				XmlNamedNodeMap xmlNamedNodeMap = this.DocumentType.Entities;
				if (xmlNamedNodeMap != null)
				{
					return (XmlEntity)xmlNamedNodeMap.GetNamedItem(name);
				}
			}
			return null;
		}

		/// <summary>Returns the Post-Schema-Validation-Infoset (PSVI) of the node.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object representing the PSVI of the node.</returns>
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00048814 File Offset: 0x00046A14
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				if (this.reportValidity)
				{
					XmlElement documentElement = this.DocumentElement;
					if (documentElement != null)
					{
						XmlSchemaValidity validity = documentElement.SchemaInfo.Validity;
						if (validity == XmlSchemaValidity.Valid)
						{
							return XmlDocument.ValidSchemaInfo;
						}
						if (validity == XmlSchemaValidity.Invalid)
						{
							return XmlDocument.InvalidSchemaInfo;
						}
					}
				}
				return XmlDocument.NotKnownSchemaInfo;
			}
		}

		/// <summary>Gets the base URI of the current node.</summary>
		/// <returns>The location from which the node was loaded.</returns>
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0004885A File Offset: 0x00046A5A
		public override string BaseURI
		{
			get
			{
				return this.baseURI;
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00048862 File Offset: 0x00046A62
		internal void SetBaseURI(string inBaseURI)
		{
			this.baseURI = inBaseURI;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0004886C File Offset: 0x00046A6C
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			if (!this.IsValidChildType(newChild.NodeType))
			{
				throw new InvalidOperationException(Res.GetString("The specified node cannot be inserted as the valid child of this node, because the specified node is the wrong type."));
			}
			if (!this.CanInsertAfter(newChild, this.LastChild))
			{
				throw new InvalidOperationException(Res.GetString("Cannot insert the node in the specified location."));
			}
			XmlNodeChangedEventArgs insertEventArgsForLoad = this.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
				this.BeforeEvent(insertEventArgsForLoad);
			}
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			if (this.lastChild == null)
			{
				xmlLinkedNode.next = xmlLinkedNode;
			}
			else
			{
				xmlLinkedNode.next = this.lastChild.next;
				this.lastChild.next = xmlLinkedNode;
			}
			this.lastChild = xmlLinkedNode;
			xmlLinkedNode.SetParentForLoad(this);
			if (insertEventArgsForLoad != null)
			{
				this.AfterEvent(insertEventArgsForLoad);
			}
			return xmlLinkedNode;
		}

		// Token: 0x0400086C RID: 2156
		private XmlImplementation implementation;

		// Token: 0x0400086D RID: 2157
		private DomNameTable domNameTable;

		// Token: 0x0400086E RID: 2158
		private XmlLinkedNode lastChild;

		// Token: 0x0400086F RID: 2159
		private XmlNamedNodeMap entities;

		// Token: 0x04000870 RID: 2160
		private Hashtable htElementIdMap;

		// Token: 0x04000871 RID: 2161
		private Hashtable htElementIDAttrDecl;

		// Token: 0x04000872 RID: 2162
		private SchemaInfo schemaInfo;

		// Token: 0x04000873 RID: 2163
		private XmlSchemaSet schemas;

		// Token: 0x04000874 RID: 2164
		private bool reportValidity;

		// Token: 0x04000875 RID: 2165
		private bool actualLoadingStatus;

		// Token: 0x04000876 RID: 2166
		private XmlNodeChangedEventHandler onNodeInsertingDelegate;

		// Token: 0x04000877 RID: 2167
		private XmlNodeChangedEventHandler onNodeInsertedDelegate;

		// Token: 0x04000878 RID: 2168
		private XmlNodeChangedEventHandler onNodeRemovingDelegate;

		// Token: 0x04000879 RID: 2169
		private XmlNodeChangedEventHandler onNodeRemovedDelegate;

		// Token: 0x0400087A RID: 2170
		private XmlNodeChangedEventHandler onNodeChangingDelegate;

		// Token: 0x0400087B RID: 2171
		private XmlNodeChangedEventHandler onNodeChangedDelegate;

		// Token: 0x0400087C RID: 2172
		internal bool fEntRefNodesPresent;

		// Token: 0x0400087D RID: 2173
		internal bool fCDataNodesPresent;

		// Token: 0x0400087E RID: 2174
		private bool preserveWhitespace;

		// Token: 0x0400087F RID: 2175
		private bool isLoading;

		// Token: 0x04000880 RID: 2176
		internal string strDocumentName;

		// Token: 0x04000881 RID: 2177
		internal string strDocumentFragmentName;

		// Token: 0x04000882 RID: 2178
		internal string strCommentName;

		// Token: 0x04000883 RID: 2179
		internal string strTextName;

		// Token: 0x04000884 RID: 2180
		internal string strCDataSectionName;

		// Token: 0x04000885 RID: 2181
		internal string strEntityName;

		// Token: 0x04000886 RID: 2182
		internal string strID;

		// Token: 0x04000887 RID: 2183
		internal string strXmlns;

		// Token: 0x04000888 RID: 2184
		internal string strXml;

		// Token: 0x04000889 RID: 2185
		internal string strSpace;

		// Token: 0x0400088A RID: 2186
		internal string strLang;

		// Token: 0x0400088B RID: 2187
		internal string strEmpty;

		// Token: 0x0400088C RID: 2188
		internal string strNonSignificantWhitespaceName;

		// Token: 0x0400088D RID: 2189
		internal string strSignificantWhitespaceName;

		// Token: 0x0400088E RID: 2190
		internal string strReservedXmlns;

		// Token: 0x0400088F RID: 2191
		internal string strReservedXml;

		// Token: 0x04000890 RID: 2192
		internal string baseURI;

		// Token: 0x04000891 RID: 2193
		private XmlResolver resolver;

		// Token: 0x04000892 RID: 2194
		internal bool bSetResolver;

		// Token: 0x04000893 RID: 2195
		internal object objLock;

		// Token: 0x04000894 RID: 2196
		internal static EmptyEnumerator EmptyEnumerator = new EmptyEnumerator();

		// Token: 0x04000895 RID: 2197
		internal static IXmlSchemaInfo NotKnownSchemaInfo = new XmlSchemaInfo(XmlSchemaValidity.NotKnown);

		// Token: 0x04000896 RID: 2198
		internal static IXmlSchemaInfo ValidSchemaInfo = new XmlSchemaInfo(XmlSchemaValidity.Valid);

		// Token: 0x04000897 RID: 2199
		internal static IXmlSchemaInfo InvalidSchemaInfo = new XmlSchemaInfo(XmlSchemaValidity.Invalid);
	}
}
