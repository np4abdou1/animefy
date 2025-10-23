using System;
using System.Collections;
using System.Globalization;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000146 RID: 326
	internal class XmlLoader
	{
		// Token: 0x06000BA2 RID: 2978 RVA: 0x00049778 File Offset: 0x00047978
		internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace)
		{
			this.doc = doc;
			if (reader.GetType() == typeof(XmlTextReader))
			{
				this.reader = ((XmlTextReader)reader).Impl;
			}
			else
			{
				this.reader = reader;
			}
			this.preserveWhitespace = preserveWhitespace;
			if (doc == null)
			{
				throw new ArgumentException(Res.GetString("The document to be loaded could not be found."));
			}
			if (reader == null)
			{
				throw new ArgumentException(Res.GetString("There is no reader from which to load the document."));
			}
			doc.SetBaseURI(reader.BaseURI);
			if (reader.Settings != null && reader.Settings.ValidationType == ValidationType.Schema)
			{
				doc.Schemas = reader.Settings.Schemas;
			}
			if (this.reader.ReadState != ReadState.Interactive && !this.reader.Read())
			{
				return;
			}
			this.LoadDocSequence(doc);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00049840 File Offset: 0x00047A40
		private void LoadDocSequence(XmlDocument parentDoc)
		{
			XmlNode newChild;
			while ((newChild = this.LoadNode(true)) != null)
			{
				parentDoc.AppendChildForLoad(newChild, parentDoc);
				if (!this.reader.Read())
				{
					return;
				}
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00049874 File Offset: 0x00047A74
		internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader)
		{
			this.doc = doc;
			this.reader = reader;
			this.preserveWhitespace = true;
			if (doc == null)
			{
				throw new ArgumentException(Res.GetString("The document to be loaded could not be found."));
			}
			if (reader == null)
			{
				throw new ArgumentException(Res.GetString("There is no reader from which to load the document."));
			}
			if (reader.ReadState == ReadState.Initial)
			{
				reader.Read();
			}
			if (reader.ReadState == ReadState.Interactive)
			{
				XmlNode xmlNode = this.LoadNode(true);
				if (xmlNode.NodeType != XmlNodeType.Attribute)
				{
					reader.Read();
				}
				return xmlNode;
			}
			return null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000498F0 File Offset: 0x00047AF0
		private XmlNode LoadNode(bool skipOverWhitespace)
		{
			XmlReader xmlReader = this.reader;
			XmlNode xmlNode = null;
			for (;;)
			{
				XmlNode xmlNode2;
				switch (xmlReader.NodeType)
				{
				case XmlNodeType.Element:
				{
					bool isEmptyElement = xmlReader.IsEmptyElement;
					XmlElement xmlElement = this.doc.CreateElement(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);
					xmlElement.IsEmpty = isEmptyElement;
					if (xmlReader.MoveToFirstAttribute())
					{
						XmlAttributeCollection attributes = xmlElement.Attributes;
						do
						{
							XmlAttribute node = this.LoadAttributeNode();
							attributes.Append(node);
						}
						while (xmlReader.MoveToNextAttribute());
						xmlReader.MoveToElement();
					}
					if (!isEmptyElement)
					{
						if (xmlNode != null)
						{
							xmlNode.AppendChildForLoad(xmlElement, this.doc);
						}
						xmlNode = xmlElement;
						goto IL_25B;
					}
					IXmlSchemaInfo schemaInfo = xmlReader.SchemaInfo;
					if (schemaInfo != null)
					{
						xmlElement.XmlName = this.doc.AddXmlName(xmlElement.Prefix, xmlElement.LocalName, xmlElement.NamespaceURI, schemaInfo);
					}
					xmlNode2 = xmlElement;
					goto IL_244;
				}
				case XmlNodeType.Attribute:
					xmlNode2 = this.LoadAttributeNode();
					goto IL_244;
				case XmlNodeType.Text:
					xmlNode2 = this.doc.CreateTextNode(xmlReader.Value);
					goto IL_244;
				case XmlNodeType.CDATA:
					xmlNode2 = this.doc.CreateCDataSection(xmlReader.Value);
					goto IL_244;
				case XmlNodeType.EntityReference:
					xmlNode2 = this.LoadEntityReferenceNode(false);
					goto IL_244;
				case XmlNodeType.ProcessingInstruction:
					xmlNode2 = this.doc.CreateProcessingInstruction(xmlReader.Name, xmlReader.Value);
					goto IL_244;
				case XmlNodeType.Comment:
					xmlNode2 = this.doc.CreateComment(xmlReader.Value);
					goto IL_244;
				case XmlNodeType.DocumentType:
					xmlNode2 = this.LoadDocumentTypeNode();
					goto IL_244;
				case XmlNodeType.Whitespace:
					if (this.preserveWhitespace)
					{
						xmlNode2 = this.doc.CreateWhitespace(xmlReader.Value);
						goto IL_244;
					}
					if (xmlNode == null && !skipOverWhitespace)
					{
						goto Block_13;
					}
					goto IL_25B;
				case XmlNodeType.SignificantWhitespace:
					xmlNode2 = this.doc.CreateSignificantWhitespace(xmlReader.Value);
					goto IL_244;
				case XmlNodeType.EndElement:
				{
					if (xmlNode == null)
					{
						goto Block_7;
					}
					IXmlSchemaInfo schemaInfo = xmlReader.SchemaInfo;
					if (schemaInfo != null)
					{
						XmlElement xmlElement = xmlNode as XmlElement;
						if (xmlElement != null)
						{
							xmlElement.XmlName = this.doc.AddXmlName(xmlElement.Prefix, xmlElement.LocalName, xmlElement.NamespaceURI, schemaInfo);
						}
					}
					if (xmlNode.ParentNode == null)
					{
						return xmlNode;
					}
					xmlNode = xmlNode.ParentNode;
					goto IL_25B;
				}
				case XmlNodeType.EndEntity:
					goto IL_178;
				case XmlNodeType.XmlDeclaration:
					xmlNode2 = this.LoadDeclarationNode();
					goto IL_244;
				}
				break;
				IL_25B:
				if (!xmlReader.Read())
				{
					goto Block_15;
				}
				continue;
				IL_244:
				if (xmlNode != null)
				{
					xmlNode.AppendChildForLoad(xmlNode2, this.doc);
					goto IL_25B;
				}
				return xmlNode2;
			}
			goto IL_238;
			Block_7:
			return null;
			IL_178:
			return null;
			Block_13:
			return null;
			IL_238:
			throw XmlLoader.UnexpectedNodeType(xmlReader.NodeType);
			Block_15:
			if (xmlNode != null)
			{
				while (xmlNode.ParentNode != null)
				{
					xmlNode = xmlNode.ParentNode;
				}
			}
			return xmlNode;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00049B78 File Offset: 0x00047D78
		private XmlAttribute LoadAttributeNode()
		{
			XmlReader xmlReader = this.reader;
			if (xmlReader.IsDefault)
			{
				return this.LoadDefaultAttribute();
			}
			XmlAttribute xmlAttribute = this.doc.CreateAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);
			IXmlSchemaInfo schemaInfo = xmlReader.SchemaInfo;
			if (schemaInfo != null)
			{
				xmlAttribute.XmlName = this.doc.AddAttrXmlName(xmlAttribute.Prefix, xmlAttribute.LocalName, xmlAttribute.NamespaceURI, schemaInfo);
			}
			while (xmlReader.ReadAttributeValue())
			{
				XmlNodeType nodeType = xmlReader.NodeType;
				XmlNode xmlNode;
				if (nodeType != XmlNodeType.Text)
				{
					if (nodeType != XmlNodeType.EntityReference)
					{
						throw XmlLoader.UnexpectedNodeType(xmlReader.NodeType);
					}
					xmlNode = this.doc.CreateEntityReference(xmlReader.LocalName);
					if (xmlReader.CanResolveEntity)
					{
						xmlReader.ResolveEntity();
						this.LoadAttributeValue(xmlNode, false);
						if (xmlNode.FirstChild == null)
						{
							xmlNode.AppendChildForLoad(this.doc.CreateTextNode(string.Empty), this.doc);
						}
					}
				}
				else
				{
					xmlNode = this.doc.CreateTextNode(xmlReader.Value);
				}
				xmlAttribute.AppendChildForLoad(xmlNode, this.doc);
			}
			return xmlAttribute;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00049C8C File Offset: 0x00047E8C
		private XmlAttribute LoadDefaultAttribute()
		{
			XmlReader xmlReader = this.reader;
			XmlAttribute xmlAttribute = this.doc.CreateDefaultAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);
			IXmlSchemaInfo schemaInfo = xmlReader.SchemaInfo;
			if (schemaInfo != null)
			{
				xmlAttribute.XmlName = this.doc.AddAttrXmlName(xmlAttribute.Prefix, xmlAttribute.LocalName, xmlAttribute.NamespaceURI, schemaInfo);
			}
			this.LoadAttributeValue(xmlAttribute, false);
			XmlUnspecifiedAttribute xmlUnspecifiedAttribute = xmlAttribute as XmlUnspecifiedAttribute;
			if (xmlUnspecifiedAttribute != null)
			{
				xmlUnspecifiedAttribute.SetSpecified(false);
			}
			return xmlAttribute;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00049D08 File Offset: 0x00047F08
		private void LoadAttributeValue(XmlNode parent, bool direct)
		{
			XmlReader xmlReader = this.reader;
			while (xmlReader.ReadAttributeValue())
			{
				XmlNodeType nodeType = xmlReader.NodeType;
				XmlNode xmlNode;
				if (nodeType != XmlNodeType.Text)
				{
					if (nodeType != XmlNodeType.EntityReference)
					{
						if (nodeType != XmlNodeType.EndEntity)
						{
							throw XmlLoader.UnexpectedNodeType(xmlReader.NodeType);
						}
						return;
					}
					else
					{
						xmlNode = (direct ? new XmlEntityReference(this.reader.LocalName, this.doc) : this.doc.CreateEntityReference(this.reader.LocalName));
						if (xmlReader.CanResolveEntity)
						{
							xmlReader.ResolveEntity();
							this.LoadAttributeValue(xmlNode, direct);
							if (xmlNode.FirstChild == null)
							{
								xmlNode.AppendChildForLoad(direct ? new XmlText(string.Empty) : this.doc.CreateTextNode(string.Empty), this.doc);
							}
						}
					}
				}
				else
				{
					xmlNode = (direct ? new XmlText(xmlReader.Value, this.doc) : this.doc.CreateTextNode(xmlReader.Value));
				}
				parent.AppendChildForLoad(xmlNode, this.doc);
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00049E0C File Offset: 0x0004800C
		private XmlEntityReference LoadEntityReferenceNode(bool direct)
		{
			XmlEntityReference xmlEntityReference = direct ? new XmlEntityReference(this.reader.Name, this.doc) : this.doc.CreateEntityReference(this.reader.Name);
			if (this.reader.CanResolveEntity)
			{
				this.reader.ResolveEntity();
				while (this.reader.Read() && this.reader.NodeType != XmlNodeType.EndEntity)
				{
					XmlNode xmlNode = direct ? this.LoadNodeDirect() : this.LoadNode(false);
					if (xmlNode != null)
					{
						xmlEntityReference.AppendChildForLoad(xmlNode, this.doc);
					}
				}
				if (xmlEntityReference.LastChild == null)
				{
					xmlEntityReference.AppendChildForLoad(this.doc.CreateTextNode(string.Empty), this.doc);
				}
			}
			return xmlEntityReference;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00049ECC File Offset: 0x000480CC
		private XmlDeclaration LoadDeclarationNode()
		{
			string text = null;
			string encoding = null;
			string standalone = null;
			while (this.reader.MoveToNextAttribute())
			{
				string name = this.reader.Name;
				if (!(name == "version"))
				{
					if (!(name == "encoding"))
					{
						if (name == "standalone")
						{
							standalone = this.reader.Value;
						}
					}
					else
					{
						encoding = this.reader.Value;
					}
				}
				else
				{
					text = this.reader.Value;
				}
			}
			if (text == null)
			{
				XmlLoader.ParseXmlDeclarationValue(this.reader.Value, out text, out encoding, out standalone);
			}
			return this.doc.CreateXmlDeclaration(text, encoding, standalone);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00049F74 File Offset: 0x00048174
		private XmlDocumentType LoadDocumentTypeNode()
		{
			string publicId = null;
			string systemId = null;
			string value = this.reader.Value;
			string localName = this.reader.LocalName;
			while (this.reader.MoveToNextAttribute())
			{
				string name = this.reader.Name;
				if (!(name == "PUBLIC"))
				{
					if (name == "SYSTEM")
					{
						systemId = this.reader.Value;
					}
				}
				else
				{
					publicId = this.reader.Value;
				}
			}
			XmlDocumentType xmlDocumentType = this.doc.CreateDocumentType(localName, publicId, systemId, value);
			IDtdInfo dtdInfo = this.reader.DtdInfo;
			if (dtdInfo != null)
			{
				this.LoadDocumentType(dtdInfo, xmlDocumentType);
			}
			else
			{
				this.ParseDocumentType(xmlDocumentType);
			}
			return xmlDocumentType;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0004A02C File Offset: 0x0004822C
		private XmlNode LoadNodeDirect()
		{
			XmlReader xmlReader = this.reader;
			XmlNode xmlNode = null;
			for (;;)
			{
				XmlNode xmlNode2;
				switch (xmlReader.NodeType)
				{
				case XmlNodeType.Element:
				{
					bool isEmptyElement = this.reader.IsEmptyElement;
					XmlElement xmlElement = new XmlElement(this.reader.Prefix, this.reader.LocalName, this.reader.NamespaceURI, this.doc);
					xmlElement.IsEmpty = isEmptyElement;
					if (this.reader.MoveToFirstAttribute())
					{
						XmlAttributeCollection attributes = xmlElement.Attributes;
						do
						{
							XmlAttribute node = this.LoadAttributeNodeDirect();
							attributes.Append(node);
						}
						while (xmlReader.MoveToNextAttribute());
					}
					if (!isEmptyElement)
					{
						xmlNode.AppendChildForLoad(xmlElement, this.doc);
						xmlNode = xmlElement;
						goto IL_1FC;
					}
					xmlNode2 = xmlElement;
					goto IL_1E7;
				}
				case XmlNodeType.Attribute:
					xmlNode2 = this.LoadAttributeNodeDirect();
					goto IL_1E7;
				case XmlNodeType.Text:
					xmlNode2 = new XmlText(this.reader.Value, this.doc);
					goto IL_1E7;
				case XmlNodeType.CDATA:
					xmlNode2 = new XmlCDataSection(this.reader.Value, this.doc);
					goto IL_1E7;
				case XmlNodeType.EntityReference:
					xmlNode2 = this.LoadEntityReferenceNode(true);
					goto IL_1E7;
				case XmlNodeType.ProcessingInstruction:
					xmlNode2 = new XmlProcessingInstruction(this.reader.Name, this.reader.Value, this.doc);
					goto IL_1E7;
				case XmlNodeType.Comment:
					xmlNode2 = new XmlComment(this.reader.Value, this.doc);
					goto IL_1E7;
				case XmlNodeType.Whitespace:
					if (this.preserveWhitespace)
					{
						xmlNode2 = new XmlWhitespace(this.reader.Value, this.doc);
						goto IL_1E7;
					}
					goto IL_1FC;
				case XmlNodeType.SignificantWhitespace:
					xmlNode2 = new XmlSignificantWhitespace(this.reader.Value, this.doc);
					goto IL_1E7;
				case XmlNodeType.EndElement:
					if (xmlNode.ParentNode == null)
					{
						return xmlNode;
					}
					xmlNode = xmlNode.ParentNode;
					goto IL_1FC;
				case XmlNodeType.EndEntity:
					goto IL_1FC;
				}
				break;
				IL_1FC:
				if (!xmlReader.Read())
				{
					goto Block_7;
				}
				continue;
				IL_1E7:
				if (xmlNode != null)
				{
					xmlNode.AppendChildForLoad(xmlNode2, this.doc);
					goto IL_1FC;
				}
				return xmlNode2;
			}
			throw XmlLoader.UnexpectedNodeType(this.reader.NodeType);
			Block_7:
			return null;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0004A244 File Offset: 0x00048444
		private XmlAttribute LoadAttributeNodeDirect()
		{
			XmlReader xmlReader = this.reader;
			if (xmlReader.IsDefault)
			{
				XmlUnspecifiedAttribute xmlUnspecifiedAttribute = new XmlUnspecifiedAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI, this.doc);
				this.LoadAttributeValue(xmlUnspecifiedAttribute, true);
				xmlUnspecifiedAttribute.SetSpecified(false);
				return xmlUnspecifiedAttribute;
			}
			XmlAttribute xmlAttribute = new XmlAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI, this.doc);
			this.LoadAttributeValue(xmlAttribute, true);
			return xmlAttribute;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0004A2B8 File Offset: 0x000484B8
		internal void ParseDocumentType(XmlDocumentType dtNode)
		{
			XmlDocument ownerDocument = dtNode.OwnerDocument;
			if (ownerDocument.HasSetResolver)
			{
				this.ParseDocumentType(dtNode, true, ownerDocument.GetResolver());
				return;
			}
			this.ParseDocumentType(dtNode, false, null);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0004A2EC File Offset: 0x000484EC
		private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver)
		{
			this.doc = dtNode.OwnerDocument;
			XmlParserContext context = new XmlParserContext(null, new XmlNamespaceManager(this.doc.NameTable), null, null, null, null, this.doc.BaseURI, string.Empty, XmlSpace.None);
			XmlTextReaderImpl xmlTextReaderImpl = new XmlTextReaderImpl("", XmlNodeType.Element, context);
			xmlTextReaderImpl.Namespaces = dtNode.ParseWithNamespaces;
			if (bUseResolver)
			{
				xmlTextReaderImpl.XmlResolver = resolver;
			}
			IDtdParser dtdParser = DtdParser.Create();
			XmlTextReaderImpl.DtdParserProxy adapter = new XmlTextReaderImpl.DtdParserProxy(xmlTextReaderImpl);
			IDtdInfo dtdInfo = dtdParser.ParseFreeFloatingDtd(this.doc.BaseURI, dtNode.Name, dtNode.PublicId, dtNode.SystemId, dtNode.InternalSubset, adapter);
			this.LoadDocumentType(dtdInfo, dtNode);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0004A394 File Offset: 0x00048594
		private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode)
		{
			SchemaInfo schemaInfo = dtdInfo as SchemaInfo;
			if (schemaInfo == null)
			{
				throw new XmlException("An internal error has occurred.", string.Empty);
			}
			dtNode.DtdSchemaInfo = schemaInfo;
			if (schemaInfo != null)
			{
				this.doc.DtdSchemaInfo = schemaInfo;
				if (schemaInfo.Notations != null)
				{
					foreach (SchemaNotation schemaNotation in schemaInfo.Notations.Values)
					{
						dtNode.Notations.SetNamedItem(new XmlNotation(schemaNotation.Name.Name, schemaNotation.Pubid, schemaNotation.SystemLiteral, this.doc));
					}
				}
				if (schemaInfo.GeneralEntities != null)
				{
					foreach (SchemaEntity schemaEntity in schemaInfo.GeneralEntities.Values)
					{
						XmlEntity xmlEntity = new XmlEntity(schemaEntity.Name.Name, schemaEntity.Text, schemaEntity.Pubid, schemaEntity.Url, schemaEntity.NData.IsEmpty ? null : schemaEntity.NData.Name, this.doc);
						xmlEntity.SetBaseURI(schemaEntity.DeclaredURI);
						dtNode.Entities.SetNamedItem(xmlEntity);
					}
				}
				if (schemaInfo.ParameterEntities != null)
				{
					foreach (SchemaEntity schemaEntity2 in schemaInfo.ParameterEntities.Values)
					{
						XmlEntity xmlEntity2 = new XmlEntity(schemaEntity2.Name.Name, schemaEntity2.Text, schemaEntity2.Pubid, schemaEntity2.Url, schemaEntity2.NData.IsEmpty ? null : schemaEntity2.NData.Name, this.doc);
						xmlEntity2.SetBaseURI(schemaEntity2.DeclaredURI);
						dtNode.Entities.SetNamedItem(xmlEntity2);
					}
				}
				this.doc.Entities = dtNode.Entities;
				IDictionaryEnumerator dictionaryEnumerator = schemaInfo.ElementDecls.GetEnumerator();
				if (dictionaryEnumerator != null)
				{
					dictionaryEnumerator.Reset();
					while (dictionaryEnumerator.MoveNext())
					{
						SchemaElementDecl schemaElementDecl = (SchemaElementDecl)dictionaryEnumerator.Value;
						if (schemaElementDecl.AttDefs != null)
						{
							IDictionaryEnumerator dictionaryEnumerator2 = schemaElementDecl.AttDefs.GetEnumerator();
							while (dictionaryEnumerator2.MoveNext())
							{
								SchemaAttDef schemaAttDef = (SchemaAttDef)dictionaryEnumerator2.Value;
								if (schemaAttDef.Datatype.TokenizedType == XmlTokenizedType.ID)
								{
									this.doc.AddIdInfo(this.doc.AddXmlName(schemaElementDecl.Prefix, schemaElementDecl.Name.Name, string.Empty, null), this.doc.AddAttrXmlName(schemaAttDef.Prefix, schemaAttDef.Name.Name, string.Empty, null));
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0004A6A0 File Offset: 0x000488A0
		private XmlParserContext GetContext(XmlNode node)
		{
			string text = null;
			XmlSpace xmlSpace = XmlSpace.None;
			XmlDocumentType documentType = this.doc.DocumentType;
			string baseURI = this.doc.BaseURI;
			Hashtable hashtable = new Hashtable();
			XmlNameTable nameTable = this.doc.NameTable;
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(nameTable);
			bool flag = false;
			while (node != null && node != this.doc)
			{
				if (node is XmlElement && ((XmlElement)node).HasAttributes)
				{
					xmlNamespaceManager.PushScope();
					foreach (object obj in ((XmlElement)node).Attributes)
					{
						XmlAttribute xmlAttribute = (XmlAttribute)obj;
						if (xmlAttribute.Prefix == this.doc.strXmlns && !hashtable.Contains(xmlAttribute.LocalName))
						{
							hashtable.Add(xmlAttribute.LocalName, xmlAttribute.LocalName);
							xmlNamespaceManager.AddNamespace(xmlAttribute.LocalName, xmlAttribute.Value);
						}
						else if (!flag && xmlAttribute.Prefix.Length == 0 && xmlAttribute.LocalName == this.doc.strXmlns)
						{
							xmlNamespaceManager.AddNamespace(string.Empty, xmlAttribute.Value);
							flag = true;
						}
						else if (xmlSpace == XmlSpace.None && xmlAttribute.Prefix == this.doc.strXml && xmlAttribute.LocalName == this.doc.strSpace)
						{
							if (xmlAttribute.Value == "default")
							{
								xmlSpace = XmlSpace.Default;
							}
							else if (xmlAttribute.Value == "preserve")
							{
								xmlSpace = XmlSpace.Preserve;
							}
						}
						else if (text == null && xmlAttribute.Prefix == this.doc.strXml && xmlAttribute.LocalName == this.doc.strLang)
						{
							text = xmlAttribute.Value;
						}
					}
				}
				node = node.ParentNode;
			}
			return new XmlParserContext(nameTable, xmlNamespaceManager, (documentType == null) ? null : documentType.Name, (documentType == null) ? null : documentType.PublicId, (documentType == null) ? null : documentType.SystemId, (documentType == null) ? null : documentType.InternalSubset, baseURI, text, xmlSpace);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0004A908 File Offset: 0x00048B08
		internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt)
		{
			this.doc = parentNode.OwnerDocument;
			XmlParserContext context = this.GetContext(parentNode);
			this.reader = this.CreateInnerXmlReader(innerxmltext, nt, context, this.doc);
			try
			{
				this.preserveWhitespace = true;
				bool isLoading = this.doc.IsLoading;
				this.doc.IsLoading = true;
				if (nt == XmlNodeType.Entity)
				{
					while (this.reader.Read())
					{
						XmlNode newChild;
						if ((newChild = this.LoadNodeDirect()) == null)
						{
							break;
						}
						parentNode.AppendChildForLoad(newChild, this.doc);
					}
				}
				else
				{
					XmlNode newChild2;
					while (this.reader.Read() && (newChild2 = this.LoadNode(true)) != null)
					{
						parentNode.AppendChildForLoad(newChild2, this.doc);
					}
				}
				this.doc.IsLoading = isLoading;
			}
			finally
			{
				this.reader.Close();
			}
			return context.NamespaceManager;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		internal void LoadInnerXmlElement(XmlElement node, string innerxmltext)
		{
			XmlNamespaceManager mgr = this.ParsePartialContent(node, innerxmltext, XmlNodeType.Element);
			if (node.ChildNodes.Count > 0)
			{
				this.RemoveDuplicateNamespace(node, mgr, false);
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0004AA16 File Offset: 0x00048C16
		internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext)
		{
			this.ParsePartialContent(node, innerxmltext, XmlNodeType.Attribute);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0004AA24 File Offset: 0x00048C24
		private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs)
		{
			mgr.PushScope();
			XmlAttributeCollection attributes = elem.Attributes;
			int count = attributes.Count;
			if (fCheckElemAttrs && count > 0)
			{
				for (int i = count - 1; i >= 0; i--)
				{
					XmlAttribute xmlAttribute = attributes[i];
					if (xmlAttribute.Prefix == this.doc.strXmlns)
					{
						string text = mgr.LookupNamespace(xmlAttribute.LocalName);
						if (text != null)
						{
							if (xmlAttribute.Value == text)
							{
								elem.Attributes.RemoveNodeAt(i);
							}
						}
						else
						{
							mgr.AddNamespace(xmlAttribute.LocalName, xmlAttribute.Value);
						}
					}
					else if (xmlAttribute.Prefix.Length == 0 && xmlAttribute.LocalName == this.doc.strXmlns)
					{
						string defaultNamespace = mgr.DefaultNamespace;
						if (defaultNamespace != null)
						{
							if (xmlAttribute.Value == defaultNamespace)
							{
								elem.Attributes.RemoveNodeAt(i);
							}
						}
						else
						{
							mgr.AddNamespace(xmlAttribute.LocalName, xmlAttribute.Value);
						}
					}
				}
			}
			for (XmlNode xmlNode = elem.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				XmlElement xmlElement = xmlNode as XmlElement;
				if (xmlElement != null)
				{
					this.RemoveDuplicateNamespace(xmlElement, mgr, true);
				}
			}
			mgr.PopScope();
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0004AB69 File Offset: 0x00048D69
		private string EntitizeName(string name)
		{
			return "&" + name + ";";
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0004AB7B File Offset: 0x00048D7B
		internal void ExpandEntity(XmlEntity ent)
		{
			this.ParsePartialContent(ent, this.EntitizeName(ent.Name), XmlNodeType.Entity);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0004AB94 File Offset: 0x00048D94
		internal void ExpandEntityReference(XmlEntityReference eref)
		{
			this.doc = eref.OwnerDocument;
			bool isLoading = this.doc.IsLoading;
			this.doc.IsLoading = true;
			string name = eref.Name;
			if (name == "lt")
			{
				eref.AppendChildForLoad(this.doc.CreateTextNode("<"), this.doc);
				this.doc.IsLoading = isLoading;
				return;
			}
			if (name == "gt")
			{
				eref.AppendChildForLoad(this.doc.CreateTextNode(">"), this.doc);
				this.doc.IsLoading = isLoading;
				return;
			}
			if (name == "amp")
			{
				eref.AppendChildForLoad(this.doc.CreateTextNode("&"), this.doc);
				this.doc.IsLoading = isLoading;
				return;
			}
			if (name == "apos")
			{
				eref.AppendChildForLoad(this.doc.CreateTextNode("'"), this.doc);
				this.doc.IsLoading = isLoading;
				return;
			}
			if (!(name == "quot"))
			{
				using (IEnumerator enumerator = this.doc.Entities.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (Ref.Equal(((XmlEntity)enumerator.Current).Name, eref.Name))
						{
							this.ParsePartialContent(eref, this.EntitizeName(eref.Name), XmlNodeType.EntityReference);
							return;
						}
					}
				}
				if (!this.doc.ActualLoadingStatus)
				{
					eref.AppendChildForLoad(this.doc.CreateTextNode(""), this.doc);
					this.doc.IsLoading = isLoading;
					return;
				}
				this.doc.IsLoading = isLoading;
				throw new XmlException("Reference to undeclared parameter entity '{0}'.", eref.Name);
			}
			eref.AppendChildForLoad(this.doc.CreateTextNode("\""), this.doc);
			this.doc.IsLoading = isLoading;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0004ADB0 File Offset: 0x00048FB0
		private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc)
		{
			XmlNodeType xmlNodeType = nt;
			if (xmlNodeType == XmlNodeType.Entity || xmlNodeType == XmlNodeType.EntityReference)
			{
				xmlNodeType = XmlNodeType.Element;
			}
			XmlTextReaderImpl xmlTextReaderImpl = new XmlTextReaderImpl(xmlFragment, xmlNodeType, context);
			xmlTextReaderImpl.XmlValidatingReaderCompatibilityMode = true;
			if (doc.HasSetResolver)
			{
				xmlTextReaderImpl.XmlResolver = doc.GetResolver();
			}
			if (!doc.ActualLoadingStatus)
			{
				xmlTextReaderImpl.DisableUndeclaredEntityCheck = true;
			}
			XmlDocumentType documentType = doc.DocumentType;
			if (documentType != null)
			{
				xmlTextReaderImpl.Namespaces = documentType.ParseWithNamespaces;
				if (documentType.DtdSchemaInfo != null)
				{
					xmlTextReaderImpl.SetDtdInfo(documentType.DtdSchemaInfo);
				}
				else
				{
					IDtdParser dtdParser = DtdParser.Create();
					XmlTextReaderImpl.DtdParserProxy adapter = new XmlTextReaderImpl.DtdParserProxy(xmlTextReaderImpl);
					IDtdInfo dtdInfo = dtdParser.ParseFreeFloatingDtd(context.BaseURI, context.DocTypeName, context.PublicId, context.SystemId, context.InternalSubset, adapter);
					documentType.DtdSchemaInfo = (dtdInfo as SchemaInfo);
					xmlTextReaderImpl.SetDtdInfo(dtdInfo);
				}
			}
			if (nt == XmlNodeType.Entity || nt == XmlNodeType.EntityReference)
			{
				xmlTextReaderImpl.Read();
				xmlTextReaderImpl.ResolveEntity();
			}
			return xmlTextReaderImpl;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0004AE8C File Offset: 0x0004908C
		internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone)
		{
			version = null;
			encoding = null;
			standalone = null;
			XmlTextReaderImpl xmlTextReaderImpl = new XmlTextReaderImpl(strValue, null);
			try
			{
				xmlTextReaderImpl.Read();
				if (xmlTextReaderImpl.MoveToAttribute("version"))
				{
					version = xmlTextReaderImpl.Value;
				}
				if (xmlTextReaderImpl.MoveToAttribute("encoding"))
				{
					encoding = xmlTextReaderImpl.Value;
				}
				if (xmlTextReaderImpl.MoveToAttribute("standalone"))
				{
					standalone = xmlTextReaderImpl.Value;
				}
			}
			finally
			{
				xmlTextReaderImpl.Close();
			}
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0004AF0C File Offset: 0x0004910C
		internal static Exception UnexpectedNodeType(XmlNodeType nodetype)
		{
			return new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, Res.GetString("Unexpected XmlNodeType: '{0}'."), nodetype.ToString()));
		}

		// Token: 0x040008B4 RID: 2228
		private XmlDocument doc;

		// Token: 0x040008B5 RID: 2229
		private XmlReader reader;

		// Token: 0x040008B6 RID: 2230
		private bool preserveWhitespace;
	}
}
