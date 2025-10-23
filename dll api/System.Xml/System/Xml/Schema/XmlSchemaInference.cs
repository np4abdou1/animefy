using System;
using System.Collections;

namespace System.Xml.Schema
{
	/// <summary>Infers an XML Schema Definition Language (XSD) schema from an XML document. The <see cref="T:System.Xml.Schema.XmlSchemaInference" /> class cannot be inherited.</summary>
	// Token: 0x0200029F RID: 671
	public sealed class XmlSchemaInference
	{
		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaInference.InferenceOption" /> value that affects schema occurrence declarations inferred from the XML document.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaInference.InferenceOption" /> object.</returns>
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0007A566 File Offset: 0x00078766
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x0007A55D File Offset: 0x0007875D
		public XmlSchemaInference.InferenceOption Occurrence
		{
			get
			{
				return this.occurrence;
			}
			set
			{
				this.occurrence = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaInference.InferenceOption" /> value that affects types inferred from the XML document.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaInference.InferenceOption" /> object.</returns>
		// Token: 0x170004C8 RID: 1224
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x0007A56E File Offset: 0x0007876E
		public XmlSchemaInference.InferenceOption TypeInference
		{
			set
			{
				this.typeInference = value;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaInference" /> class.</summary>
		// Token: 0x06001532 RID: 5426 RVA: 0x0007A578 File Offset: 0x00078778
		public XmlSchemaInference()
		{
			this.nametable = new NameTable();
			this.NamespaceManager = new XmlNamespaceManager(this.nametable);
			this.NamespaceManager.AddNamespace("xs", "http://www.w3.org/2001/XMLSchema");
			this.schemaList = new ArrayList();
		}

		/// <summary>Infers an XML Schema Definition Language (XSD) schema from the XML document contained in the <see cref="T:System.Xml.XmlReader" /> object specified.</summary>
		/// <param name="instanceDocument">An <see cref="T:System.Xml.XmlReader" /> object containing the XML document to infer a schema from.</param>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object containing the inferred schemas.</returns>
		/// <exception cref="T:System.Xml.XmlException">The XML document is not well-formed.</exception>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaInferenceException">The <see cref="T:System.Xml.XmlReader" /> object is not positioned on the root node or on an element. An error occurs during the schema inference process.</exception>
		// Token: 0x06001533 RID: 5427 RVA: 0x0007A5C7 File Offset: 0x000787C7
		public XmlSchemaSet InferSchema(XmlReader instanceDocument)
		{
			return this.InferSchema1(instanceDocument, new XmlSchemaSet(this.nametable));
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0007A5DC File Offset: 0x000787DC
		internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas)
		{
			if (instanceDocument == null)
			{
				throw new ArgumentNullException("instanceDocument");
			}
			this.rootSchema = null;
			this.xtr = instanceDocument;
			schemas.Compile();
			this.schemaSet = schemas;
			while (this.xtr.NodeType != XmlNodeType.Element && this.xtr.Read())
			{
			}
			if (this.xtr.NodeType != XmlNodeType.Element)
			{
				throw new XmlSchemaInferenceException("There is no element to infer schema.", 0, 0);
			}
			this.TargetNamespace = this.xtr.NamespaceURI;
			if (this.xtr.NamespaceURI == "http://www.w3.org/2001/XMLSchema")
			{
				throw new XmlSchemaInferenceException("The supplied xml instance is a schema or contains an inline schema. This class cannot infer a schema for a schema.", 0, 0);
			}
			XmlSchemaElement xse = null;
			foreach (object obj in schemas.GlobalElements.Values)
			{
				XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)obj;
				if (xmlSchemaElement.Name == this.xtr.LocalName && xmlSchemaElement.QualifiedName.Namespace == this.xtr.NamespaceURI)
				{
					this.rootSchema = (xmlSchemaElement.Parent as XmlSchema);
					xse = xmlSchemaElement;
					break;
				}
			}
			if (this.rootSchema == null)
			{
				xse = this.AddElement(this.xtr.LocalName, this.xtr.Prefix, this.xtr.NamespaceURI, null, null, -1);
			}
			else
			{
				this.InferElement(xse, false, this.rootSchema);
			}
			foreach (object obj2 in this.NamespaceManager)
			{
				string text = (string)obj2;
				if (!text.Equals("xml") && !text.Equals("xmlns"))
				{
					string text2 = this.NamespaceManager.LookupNamespace(this.nametable.Get(text));
					if (text2.Length != 0)
					{
						this.rootSchema.Namespaces.Add(text, text2);
					}
				}
			}
			schemas.Reprocess(this.rootSchema);
			schemas.Compile();
			return schemas;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0007A804 File Offset: 0x00078A04
		private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes)
		{
			if (childURI == "http://www.w3.org/2001/XMLSchema")
			{
				throw new XmlSchemaInferenceException("The supplied xml instance is a schema or contains an inline schema. This class cannot infer a schema for a schema.", 0, 0);
			}
			int lineNumber = -1;
			XmlSchema xmlSchema = null;
			bool flag = true;
			ICollection attributes;
			ICollection collection;
			if (compiledAttributes.Count > 0)
			{
				attributes = compiledAttributes.Values;
				collection = addLocation;
			}
			else
			{
				attributes = addLocation;
				collection = null;
			}
			XmlSchemaAttribute result;
			if (childURI == "http://www.w3.org/XML/1998/namespace")
			{
				XmlSchemaAttribute xmlSchemaAttribute = this.FindAttributeRef(attributes, localName, childURI);
				if (xmlSchemaAttribute == null && collection != null)
				{
					xmlSchemaAttribute = this.FindAttributeRef(collection, localName, childURI);
				}
				if (xmlSchemaAttribute == null)
				{
					xmlSchemaAttribute = new XmlSchemaAttribute();
					xmlSchemaAttribute.RefName = new XmlQualifiedName(localName, childURI);
					if (bCreatingNewType && this.Occurrence == XmlSchemaInference.InferenceOption.Restricted)
					{
						xmlSchemaAttribute.Use = XmlSchemaUse.Required;
					}
					else
					{
						xmlSchemaAttribute.Use = XmlSchemaUse.Optional;
					}
					addLocation.Add(xmlSchemaAttribute);
				}
				result = xmlSchemaAttribute;
			}
			else
			{
				if (childURI.Length == 0)
				{
					xmlSchema = parentSchema;
					flag = false;
				}
				else if (childURI != null && !this.schemaSet.Contains(childURI))
				{
					xmlSchema = new XmlSchema();
					xmlSchema.AttributeFormDefault = XmlSchemaForm.Unqualified;
					xmlSchema.ElementFormDefault = XmlSchemaForm.Qualified;
					if (childURI.Length != 0)
					{
						xmlSchema.TargetNamespace = childURI;
					}
					this.schemaSet.Add(xmlSchema);
					if (prefix.Length != 0 && string.Compare(prefix, "xml", StringComparison.OrdinalIgnoreCase) != 0)
					{
						this.NamespaceManager.AddNamespace(prefix, childURI);
					}
				}
				else
				{
					ArrayList arrayList = this.schemaSet.Schemas(childURI) as ArrayList;
					if (arrayList != null && arrayList.Count > 0)
					{
						xmlSchema = (arrayList[0] as XmlSchema);
					}
				}
				if (childURI.Length != 0)
				{
					XmlSchemaAttribute xmlSchemaAttribute2 = this.FindAttributeRef(attributes, localName, childURI);
					if (xmlSchemaAttribute2 == null & collection != null)
					{
						xmlSchemaAttribute2 = this.FindAttributeRef(collection, localName, childURI);
					}
					if (xmlSchemaAttribute2 == null)
					{
						xmlSchemaAttribute2 = new XmlSchemaAttribute();
						xmlSchemaAttribute2.RefName = new XmlQualifiedName(localName, childURI);
						if (bCreatingNewType && this.Occurrence == XmlSchemaInference.InferenceOption.Restricted)
						{
							xmlSchemaAttribute2.Use = XmlSchemaUse.Required;
						}
						else
						{
							xmlSchemaAttribute2.Use = XmlSchemaUse.Optional;
						}
						addLocation.Add(xmlSchemaAttribute2);
					}
					result = xmlSchemaAttribute2;
					XmlSchemaAttribute xmlSchemaAttribute3 = this.FindAttribute(xmlSchema.Items, localName);
					if (xmlSchemaAttribute3 == null)
					{
						xmlSchemaAttribute3 = new XmlSchemaAttribute();
						xmlSchemaAttribute3.Name = localName;
						xmlSchemaAttribute3.SchemaTypeName = this.RefineSimpleType(attrValue, ref lineNumber);
						xmlSchemaAttribute3.LineNumber = lineNumber;
						xmlSchema.Items.Add(xmlSchemaAttribute3);
					}
					else
					{
						if (xmlSchemaAttribute3.Parent == null)
						{
							lineNumber = xmlSchemaAttribute3.LineNumber;
						}
						else
						{
							lineNumber = XmlSchemaInference.GetSchemaType(xmlSchemaAttribute3.SchemaTypeName);
							xmlSchemaAttribute3.Parent = null;
						}
						xmlSchemaAttribute3.SchemaTypeName = this.RefineSimpleType(attrValue, ref lineNumber);
						xmlSchemaAttribute3.LineNumber = lineNumber;
					}
				}
				else
				{
					XmlSchemaAttribute xmlSchemaAttribute3 = this.FindAttribute(attributes, localName);
					if (xmlSchemaAttribute3 == null && collection != null)
					{
						xmlSchemaAttribute3 = this.FindAttribute(collection, localName);
					}
					if (xmlSchemaAttribute3 == null)
					{
						xmlSchemaAttribute3 = new XmlSchemaAttribute();
						xmlSchemaAttribute3.Name = localName;
						xmlSchemaAttribute3.SchemaTypeName = this.RefineSimpleType(attrValue, ref lineNumber);
						xmlSchemaAttribute3.LineNumber = lineNumber;
						if (bCreatingNewType && this.Occurrence == XmlSchemaInference.InferenceOption.Restricted)
						{
							xmlSchemaAttribute3.Use = XmlSchemaUse.Required;
						}
						else
						{
							xmlSchemaAttribute3.Use = XmlSchemaUse.Optional;
						}
						addLocation.Add(xmlSchemaAttribute3);
						if (xmlSchema.AttributeFormDefault != XmlSchemaForm.Unqualified)
						{
							xmlSchemaAttribute3.Form = XmlSchemaForm.Unqualified;
						}
					}
					else
					{
						if (xmlSchemaAttribute3.Parent == null)
						{
							lineNumber = xmlSchemaAttribute3.LineNumber;
						}
						else
						{
							lineNumber = XmlSchemaInference.GetSchemaType(xmlSchemaAttribute3.SchemaTypeName);
							xmlSchemaAttribute3.Parent = null;
						}
						xmlSchemaAttribute3.SchemaTypeName = this.RefineSimpleType(attrValue, ref lineNumber);
						xmlSchemaAttribute3.LineNumber = lineNumber;
					}
					result = xmlSchemaAttribute3;
				}
			}
			string @namespace = null;
			if (flag && childURI != parentSchema.TargetNamespace)
			{
				for (int i = 0; i < parentSchema.Includes.Count; i++)
				{
					XmlSchemaImport xmlSchemaImport = parentSchema.Includes[i] as XmlSchemaImport;
					if (xmlSchemaImport != null && xmlSchemaImport.Namespace == childURI)
					{
						flag = false;
					}
				}
				if (flag)
				{
					XmlSchemaImport xmlSchemaImport2 = new XmlSchemaImport();
					xmlSchemaImport2.Schema = xmlSchema;
					if (childURI.Length != 0)
					{
						@namespace = childURI;
					}
					xmlSchemaImport2.Namespace = @namespace;
					parentSchema.Includes.Add(xmlSchemaImport2);
				}
			}
			return result;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0007ABC4 File Offset: 0x00078DC4
		private XmlSchema CreateXmlSchema(string targetNS)
		{
			XmlSchema xmlSchema = new XmlSchema();
			xmlSchema.AttributeFormDefault = XmlSchemaForm.Unqualified;
			xmlSchema.ElementFormDefault = XmlSchemaForm.Qualified;
			xmlSchema.TargetNamespace = targetNS;
			this.schemaSet.Add(xmlSchema);
			return xmlSchema;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0007ABFC File Offset: 0x00078DFC
		private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection)
		{
			if (childURI == "http://www.w3.org/2001/XMLSchema")
			{
				throw new XmlSchemaInferenceException("The supplied xml instance is a schema or contains an inline schema. This class cannot infer a schema for a schema.", 0, 0);
			}
			XmlSchema xmlSchema = null;
			bool bCreatingNewType = true;
			if (childURI == string.Empty)
			{
				childURI = null;
			}
			XmlSchemaElement xmlSchemaElement;
			if (parentSchema != null && childURI == parentSchema.TargetNamespace)
			{
				xmlSchemaElement = new XmlSchemaElement();
				xmlSchemaElement.Name = localName;
				xmlSchema = parentSchema;
				if (xmlSchema.ElementFormDefault != XmlSchemaForm.Qualified && addLocation != null)
				{
					xmlSchemaElement.Form = XmlSchemaForm.Qualified;
				}
			}
			else if (this.schemaSet.Contains(childURI))
			{
				xmlSchemaElement = this.FindGlobalElement(childURI, localName, out xmlSchema);
				if (xmlSchemaElement == null)
				{
					ArrayList arrayList = this.schemaSet.Schemas(childURI) as ArrayList;
					if (arrayList != null && arrayList.Count > 0)
					{
						xmlSchema = (arrayList[0] as XmlSchema);
					}
					xmlSchemaElement = new XmlSchemaElement();
					xmlSchemaElement.Name = localName;
					xmlSchema.Items.Add(xmlSchemaElement);
				}
				else
				{
					bCreatingNewType = false;
				}
			}
			else
			{
				xmlSchema = this.CreateXmlSchema(childURI);
				if (prefix.Length != 0)
				{
					this.NamespaceManager.AddNamespace(prefix, childURI);
				}
				xmlSchemaElement = new XmlSchemaElement();
				xmlSchemaElement.Name = localName;
				xmlSchema.Items.Add(xmlSchemaElement);
			}
			if (parentSchema == null)
			{
				parentSchema = xmlSchema;
				this.rootSchema = parentSchema;
			}
			if (childURI != parentSchema.TargetNamespace)
			{
				bool flag = true;
				for (int i = 0; i < parentSchema.Includes.Count; i++)
				{
					XmlSchemaImport xmlSchemaImport = parentSchema.Includes[i] as XmlSchemaImport;
					if (xmlSchemaImport != null && xmlSchemaImport.Namespace == childURI)
					{
						flag = false;
					}
				}
				if (flag)
				{
					XmlSchemaImport xmlSchemaImport2 = new XmlSchemaImport();
					xmlSchemaImport2.Schema = xmlSchema;
					xmlSchemaImport2.Namespace = childURI;
					parentSchema.Includes.Add(xmlSchemaImport2);
				}
			}
			XmlSchemaElement result = xmlSchemaElement;
			if (addLocation != null)
			{
				if (childURI == parentSchema.TargetNamespace)
				{
					if (this.Occurrence == XmlSchemaInference.InferenceOption.Relaxed)
					{
						xmlSchemaElement.MinOccurs = 0m;
					}
					if (positionWithinCollection == -1)
					{
						positionWithinCollection = addLocation.Add(xmlSchemaElement);
					}
					else
					{
						addLocation.Insert(positionWithinCollection, xmlSchemaElement);
					}
				}
				else
				{
					XmlSchemaElement xmlSchemaElement2 = new XmlSchemaElement();
					xmlSchemaElement2.RefName = new XmlQualifiedName(localName, childURI);
					if (this.Occurrence == XmlSchemaInference.InferenceOption.Relaxed)
					{
						xmlSchemaElement2.MinOccurs = 0m;
					}
					if (positionWithinCollection == -1)
					{
						positionWithinCollection = addLocation.Add(xmlSchemaElement2);
					}
					else
					{
						addLocation.Insert(positionWithinCollection, xmlSchemaElement2);
					}
					result = xmlSchemaElement2;
				}
			}
			this.InferElement(xmlSchemaElement, bCreatingNewType, xmlSchema);
			return result;
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0007AE50 File Offset: 0x00079050
		internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema)
		{
			bool isEmptyElement = this.xtr.IsEmptyElement;
			int num = -1;
			Hashtable hashtable = new Hashtable();
			XmlSchemaType effectiveSchemaType = this.GetEffectiveSchemaType(xse, bCreatingNewType);
			XmlSchemaComplexType xmlSchemaComplexType = effectiveSchemaType as XmlSchemaComplexType;
			if (this.xtr.MoveToFirstAttribute())
			{
				this.ProcessAttributes(ref xse, effectiveSchemaType, bCreatingNewType, parentSchema);
			}
			else if (!bCreatingNewType && xmlSchemaComplexType != null)
			{
				this.MakeExistingAttributesOptional(xmlSchemaComplexType, null);
			}
			if (xmlSchemaComplexType == null || xmlSchemaComplexType == XmlSchemaComplexType.AnyType)
			{
				xmlSchemaComplexType = (xse.SchemaType as XmlSchemaComplexType);
			}
			if (isEmptyElement)
			{
				if (!bCreatingNewType)
				{
					if (xmlSchemaComplexType != null)
					{
						if (xmlSchemaComplexType.Particle != null)
						{
							xmlSchemaComplexType.Particle.MinOccurs = 0m;
							return;
						}
						if (xmlSchemaComplexType.ContentModel != null)
						{
							XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension = this.CheckSimpleContentExtension(xmlSchemaComplexType);
							xmlSchemaSimpleContentExtension.BaseTypeName = XmlSchemaInference.ST_string;
							xmlSchemaSimpleContentExtension.LineNumber = 262144;
							return;
						}
					}
					else if (!xse.SchemaTypeName.IsEmpty)
					{
						xse.LineNumber = 262144;
						xse.SchemaTypeName = XmlSchemaInference.ST_string;
						return;
					}
				}
				else
				{
					xse.LineNumber = 262144;
				}
				return;
			}
			bool flag = false;
			for (;;)
			{
				this.xtr.Read();
				if (this.xtr.NodeType == XmlNodeType.Whitespace)
				{
					flag = true;
				}
				if (this.xtr.NodeType == XmlNodeType.EntityReference)
				{
					break;
				}
				if (this.xtr.EOF || this.xtr.NodeType == XmlNodeType.EndElement || this.xtr.NodeType == XmlNodeType.CDATA || this.xtr.NodeType == XmlNodeType.Element || this.xtr.NodeType == XmlNodeType.Text)
				{
					goto IL_15A;
				}
			}
			throw new XmlSchemaInferenceException("Inference cannot handle entity references. Pass in an 'XmlReader' that expands entities.", 0, 0);
			IL_15A:
			if (this.xtr.NodeType != XmlNodeType.EndElement)
			{
				int num2 = 0;
				bool flag2 = false;
				IL_7D7:
				while (!this.xtr.EOF && this.xtr.NodeType != XmlNodeType.EndElement)
				{
					bool flag3 = false;
					num2++;
					if (this.xtr.NodeType == XmlNodeType.Text || this.xtr.NodeType == XmlNodeType.CDATA)
					{
						if (xmlSchemaComplexType != null)
						{
							if (xmlSchemaComplexType.Particle != null)
							{
								xmlSchemaComplexType.IsMixed = true;
								if (num2 == 1)
								{
									do
									{
										this.xtr.Read();
									}
									while (!this.xtr.EOF && (this.xtr.NodeType == XmlNodeType.CDATA || this.xtr.NodeType == XmlNodeType.Text || this.xtr.NodeType == XmlNodeType.Comment || this.xtr.NodeType == XmlNodeType.ProcessingInstruction || this.xtr.NodeType == XmlNodeType.Whitespace || this.xtr.NodeType == XmlNodeType.SignificantWhitespace || this.xtr.NodeType == XmlNodeType.XmlDeclaration));
									flag3 = true;
									if (this.xtr.NodeType == XmlNodeType.EndElement)
									{
										xmlSchemaComplexType.Particle.MinOccurs = 0m;
									}
								}
							}
							else if (xmlSchemaComplexType.ContentModel != null)
							{
								XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension2 = this.CheckSimpleContentExtension(xmlSchemaComplexType);
								if (this.xtr.NodeType == XmlNodeType.Text && num2 == 1)
								{
									int lineNumber = -1;
									if (xse.Parent == null)
									{
										lineNumber = xmlSchemaSimpleContentExtension2.LineNumber;
									}
									else
									{
										lineNumber = XmlSchemaInference.GetSchemaType(xmlSchemaSimpleContentExtension2.BaseTypeName);
										xse.Parent = null;
									}
									xmlSchemaSimpleContentExtension2.BaseTypeName = this.RefineSimpleType(this.xtr.Value, ref lineNumber);
									xmlSchemaSimpleContentExtension2.LineNumber = lineNumber;
								}
								else
								{
									xmlSchemaSimpleContentExtension2.BaseTypeName = XmlSchemaInference.ST_string;
									xmlSchemaSimpleContentExtension2.LineNumber = 262144;
								}
							}
							else
							{
								XmlSchemaSimpleContent xmlSchemaSimpleContent = new XmlSchemaSimpleContent();
								xmlSchemaComplexType.ContentModel = xmlSchemaSimpleContent;
								XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension3 = new XmlSchemaSimpleContentExtension();
								xmlSchemaSimpleContent.Content = xmlSchemaSimpleContentExtension3;
								this.MoveAttributes(xmlSchemaComplexType, xmlSchemaSimpleContentExtension3, bCreatingNewType);
								if (this.xtr.NodeType == XmlNodeType.Text)
								{
									int lineNumber2;
									if (!bCreatingNewType)
									{
										lineNumber2 = 262144;
									}
									else
									{
										lineNumber2 = -1;
									}
									xmlSchemaSimpleContentExtension3.BaseTypeName = this.RefineSimpleType(this.xtr.Value, ref lineNumber2);
									xmlSchemaSimpleContentExtension3.LineNumber = lineNumber2;
								}
								else
								{
									xmlSchemaSimpleContentExtension3.BaseTypeName = XmlSchemaInference.ST_string;
									xmlSchemaSimpleContentExtension3.LineNumber = 262144;
								}
							}
						}
						else if (num2 > 1)
						{
							xse.SchemaTypeName = XmlSchemaInference.ST_string;
							xse.LineNumber = 262144;
						}
						else
						{
							int num3 = -1;
							if (bCreatingNewType)
							{
								if (this.xtr.NodeType == XmlNodeType.Text)
								{
									xse.SchemaTypeName = this.RefineSimpleType(this.xtr.Value, ref num3);
									xse.LineNumber = num3;
								}
								else
								{
									xse.SchemaTypeName = XmlSchemaInference.ST_string;
									xse.LineNumber = 262144;
								}
							}
							else if (this.xtr.NodeType == XmlNodeType.Text)
							{
								if (xse.Parent == null)
								{
									num3 = xse.LineNumber;
								}
								else
								{
									num3 = XmlSchemaInference.GetSchemaType(xse.SchemaTypeName);
									if (num3 == -1 && xse.LineNumber == 262144)
									{
										num3 = 262144;
									}
									xse.Parent = null;
								}
								xse.SchemaTypeName = this.RefineSimpleType(this.xtr.Value, ref num3);
								xse.LineNumber = num3;
							}
							else
							{
								xse.SchemaTypeName = XmlSchemaInference.ST_string;
								xse.LineNumber = 262144;
							}
						}
					}
					else if (this.xtr.NodeType == XmlNodeType.Element)
					{
						XmlQualifiedName key = new XmlQualifiedName(this.xtr.LocalName, this.xtr.NamespaceURI);
						bool setMaxoccurs = false;
						if (hashtable.Contains(key))
						{
							setMaxoccurs = true;
						}
						else
						{
							hashtable.Add(key, null);
						}
						if (xmlSchemaComplexType == null)
						{
							xmlSchemaComplexType = new XmlSchemaComplexType();
							xse.SchemaType = xmlSchemaComplexType;
							if (!xse.SchemaTypeName.IsEmpty)
							{
								xmlSchemaComplexType.IsMixed = true;
								xse.SchemaTypeName = XmlQualifiedName.Empty;
							}
						}
						if (xmlSchemaComplexType.ContentModel != null)
						{
							XmlSchemaSimpleContentExtension scExtension = this.CheckSimpleContentExtension(xmlSchemaComplexType);
							this.MoveAttributes(scExtension, xmlSchemaComplexType);
							xmlSchemaComplexType.ContentModel = null;
							xmlSchemaComplexType.IsMixed = true;
							if (xmlSchemaComplexType.Particle != null)
							{
								throw new XmlSchemaInferenceException("Particle cannot exist along with 'ContentModel'.", 0, 0);
							}
							xmlSchemaComplexType.Particle = new XmlSchemaSequence();
							flag2 = true;
							this.AddElement(this.xtr.LocalName, this.xtr.Prefix, this.xtr.NamespaceURI, parentSchema, ((XmlSchemaSequence)xmlSchemaComplexType.Particle).Items, -1);
							num = 0;
							if (!bCreatingNewType)
							{
								xmlSchemaComplexType.Particle.MinOccurs = 0m;
							}
						}
						else if (xmlSchemaComplexType.Particle == null)
						{
							xmlSchemaComplexType.Particle = new XmlSchemaSequence();
							flag2 = true;
							this.AddElement(this.xtr.LocalName, this.xtr.Prefix, this.xtr.NamespaceURI, parentSchema, ((XmlSchemaSequence)xmlSchemaComplexType.Particle).Items, -1);
							if (!bCreatingNewType)
							{
								((XmlSchemaSequence)xmlSchemaComplexType.Particle).MinOccurs = 0m;
							}
							num = 0;
						}
						else
						{
							bool flag4 = false;
							this.FindMatchingElement(bCreatingNewType || flag2, this.xtr, xmlSchemaComplexType, ref num, ref flag4, parentSchema, setMaxoccurs);
						}
					}
					else if (this.xtr.NodeType == XmlNodeType.Text)
					{
						if (xmlSchemaComplexType == null)
						{
							throw new XmlSchemaInferenceException("Complex type expected to exist with at least one 'Element' at this point.", 0, 0);
						}
						xmlSchemaComplexType.IsMixed = true;
					}
					while (this.xtr.NodeType != XmlNodeType.EntityReference)
					{
						if (!flag3)
						{
							this.xtr.Read();
						}
						else
						{
							flag3 = false;
						}
						if (this.xtr.EOF || this.xtr.NodeType == XmlNodeType.EndElement || this.xtr.NodeType == XmlNodeType.CDATA || this.xtr.NodeType == XmlNodeType.Element || this.xtr.NodeType == XmlNodeType.Text)
						{
							goto IL_7D7;
						}
					}
					throw new XmlSchemaInferenceException("Inference cannot handle entity references. Pass in an 'XmlReader' that expands entities.", 0, 0);
				}
				if (num != -1)
				{
					while (++num < ((XmlSchemaSequence)xmlSchemaComplexType.Particle).Items.Count)
					{
						if (((XmlSchemaSequence)xmlSchemaComplexType.Particle).Items[num].GetType() != typeof(XmlSchemaElement))
						{
							throw new XmlSchemaInferenceException("sequence expected to contain elements only. Schema was not created using this tool.", 0, 0);
						}
						((XmlSchemaElement)((XmlSchemaSequence)xmlSchemaComplexType.Particle).Items[num]).MinOccurs = 0m;
					}
				}
				return;
			}
			if (flag)
			{
				if (xmlSchemaComplexType != null)
				{
					if (xmlSchemaComplexType.ContentModel != null)
					{
						XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension4 = this.CheckSimpleContentExtension(xmlSchemaComplexType);
						xmlSchemaSimpleContentExtension4.BaseTypeName = XmlSchemaInference.ST_string;
						xmlSchemaSimpleContentExtension4.LineNumber = 262144;
					}
					else if (bCreatingNewType)
					{
						XmlSchemaSimpleContent xmlSchemaSimpleContent2 = new XmlSchemaSimpleContent();
						xmlSchemaComplexType.ContentModel = xmlSchemaSimpleContent2;
						XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension5 = new XmlSchemaSimpleContentExtension();
						xmlSchemaSimpleContent2.Content = xmlSchemaSimpleContentExtension5;
						this.MoveAttributes(xmlSchemaComplexType, xmlSchemaSimpleContentExtension5, bCreatingNewType);
						xmlSchemaSimpleContentExtension5.BaseTypeName = XmlSchemaInference.ST_string;
						xmlSchemaSimpleContentExtension5.LineNumber = 262144;
					}
					else
					{
						xmlSchemaComplexType.IsMixed = true;
					}
				}
				else
				{
					xse.SchemaTypeName = XmlSchemaInference.ST_string;
					xse.LineNumber = 262144;
				}
			}
			if (bCreatingNewType)
			{
				xse.LineNumber = 262144;
				return;
			}
			if (xmlSchemaComplexType != null)
			{
				if (xmlSchemaComplexType.Particle != null)
				{
					xmlSchemaComplexType.Particle.MinOccurs = 0m;
					return;
				}
				if (xmlSchemaComplexType.ContentModel != null)
				{
					XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension6 = this.CheckSimpleContentExtension(xmlSchemaComplexType);
					xmlSchemaSimpleContentExtension6.BaseTypeName = XmlSchemaInference.ST_string;
					xmlSchemaSimpleContentExtension6.LineNumber = 262144;
					return;
				}
			}
			else if (!xse.SchemaTypeName.IsEmpty)
			{
				xse.LineNumber = 262144;
				xse.SchemaTypeName = XmlSchemaInference.ST_string;
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0007B6D3 File Offset: 0x000798D3
		private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct)
		{
			XmlSchemaSimpleContent xmlSchemaSimpleContent = ct.ContentModel as XmlSchemaSimpleContent;
			if (xmlSchemaSimpleContent == null)
			{
				throw new XmlSchemaInferenceException("Expected simple content. Schema was not created using this tool.", 0, 0);
			}
			XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension = xmlSchemaSimpleContent.Content as XmlSchemaSimpleContentExtension;
			if (xmlSchemaSimpleContentExtension == null)
			{
				throw new XmlSchemaInferenceException("Expected 'Extension' within 'SimpleContent'. Schema was not created using this tool.", 0, 0);
			}
			return xmlSchemaSimpleContentExtension;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0007B70C File Offset: 0x0007990C
		private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType)
		{
			XmlSchemaType xmlSchemaType = null;
			if (!bCreatingNewType && elem.ElementSchemaType != null)
			{
				xmlSchemaType = elem.ElementSchemaType;
			}
			else if (elem.SchemaType != null)
			{
				xmlSchemaType = elem.SchemaType;
			}
			else if (elem.SchemaTypeName != XmlQualifiedName.Empty)
			{
				xmlSchemaType = (this.schemaSet.GlobalTypes[elem.SchemaTypeName] as XmlSchemaType);
				if (xmlSchemaType == null)
				{
					xmlSchemaType = XmlSchemaType.GetBuiltInSimpleType(elem.SchemaTypeName);
				}
				if (xmlSchemaType == null)
				{
					xmlSchemaType = XmlSchemaType.GetBuiltInComplexType(elem.SchemaTypeName);
				}
			}
			return xmlSchemaType;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0007B790 File Offset: 0x00079990
		internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs)
		{
			if (xtr.NamespaceURI == "http://www.w3.org/2001/XMLSchema")
			{
				throw new XmlSchemaInferenceException("The supplied xml instance is a schema or contains an inline schema. This class cannot infer a schema for a schema.", 0, 0);
			}
			bool flag = lastUsedSeqItem == -1;
			XmlSchemaObjectCollection xmlSchemaObjectCollection = new XmlSchemaObjectCollection();
			if (!(ct.Particle.GetType() == typeof(XmlSchemaSequence)))
			{
				throw new XmlSchemaInferenceException("The supplied schema contains particles other than Sequence and Choice. Only schemas generated by this tool are supported.", 0, 0);
			}
			string text = xtr.NamespaceURI;
			if (text.Length == 0)
			{
				text = null;
			}
			XmlSchemaSequence xmlSchemaSequence = (XmlSchemaSequence)ct.Particle;
			if (xmlSchemaSequence.Items.Count < 1 && !bCreatingNewType)
			{
				lastUsedSeqItem = 0;
				XmlSchemaElement xmlSchemaElement = this.AddElement(xtr.LocalName, xtr.Prefix, xtr.NamespaceURI, parentSchema, xmlSchemaSequence.Items, -1);
				xmlSchemaElement.MinOccurs = 0m;
				return xmlSchemaElement;
			}
			if (xmlSchemaSequence.Items[0].GetType() == typeof(XmlSchemaChoice))
			{
				XmlSchemaChoice xmlSchemaChoice = (XmlSchemaChoice)xmlSchemaSequence.Items[0];
				for (int i = 0; i < xmlSchemaChoice.Items.Count; i++)
				{
					XmlSchemaElement xmlSchemaElement2 = xmlSchemaChoice.Items[i] as XmlSchemaElement;
					if (xmlSchemaElement2 == null)
					{
						throw new XmlSchemaInferenceException("Expected Element. Schema was not generated using this tool.", 0, 0);
					}
					if (xmlSchemaElement2.Name == xtr.LocalName && parentSchema.TargetNamespace == text)
					{
						this.InferElement(xmlSchemaElement2, false, parentSchema);
						this.SetMinMaxOccurs(xmlSchemaElement2, setMaxoccurs);
						return xmlSchemaElement2;
					}
					if (xmlSchemaElement2.RefName.Name == xtr.LocalName && xmlSchemaElement2.RefName.Namespace == xtr.NamespaceURI)
					{
						XmlSchemaElement xmlSchemaElement3 = this.FindGlobalElement(text, xtr.LocalName, out parentSchema);
						this.InferElement(xmlSchemaElement3, false, parentSchema);
						this.SetMinMaxOccurs(xmlSchemaElement2, setMaxoccurs);
						return xmlSchemaElement3;
					}
				}
				return this.AddElement(xtr.LocalName, xtr.Prefix, xtr.NamespaceURI, parentSchema, xmlSchemaChoice.Items, -1);
			}
			int j = 0;
			if (lastUsedSeqItem >= 0)
			{
				j = lastUsedSeqItem;
			}
			XmlSchemaElement xmlSchemaElement4 = (xmlSchemaSequence.Items[j] as XmlSchemaParticle) as XmlSchemaElement;
			if (xmlSchemaElement4 == null)
			{
				throw new XmlSchemaInferenceException("Expected Element. Schema was not generated using this tool.", 0, 0);
			}
			if (xmlSchemaElement4.Name == xtr.LocalName && parentSchema.TargetNamespace == text)
			{
				if (!flag)
				{
					xmlSchemaElement4.MaxOccurs = decimal.MaxValue;
				}
				lastUsedSeqItem = j;
				this.InferElement(xmlSchemaElement4, false, parentSchema);
				this.SetMinMaxOccurs(xmlSchemaElement4, false);
				return xmlSchemaElement4;
			}
			if (xmlSchemaElement4.RefName.Name == xtr.LocalName && xmlSchemaElement4.RefName.Namespace == xtr.NamespaceURI)
			{
				if (!flag)
				{
					xmlSchemaElement4.MaxOccurs = decimal.MaxValue;
				}
				lastUsedSeqItem = j;
				XmlSchemaElement xse = this.FindGlobalElement(text, xtr.LocalName, out parentSchema);
				this.InferElement(xse, false, parentSchema);
				this.SetMinMaxOccurs(xmlSchemaElement4, false);
				return xmlSchemaElement4;
			}
			if (flag && xmlSchemaElement4.MinOccurs != 0m)
			{
				xmlSchemaObjectCollection.Add(xmlSchemaElement4);
			}
			for (j++; j < xmlSchemaSequence.Items.Count; j++)
			{
				xmlSchemaElement4 = ((xmlSchemaSequence.Items[j] as XmlSchemaParticle) as XmlSchemaElement);
				if (xmlSchemaElement4 == null)
				{
					throw new XmlSchemaInferenceException("Expected Element. Schema was not generated using this tool.", 0, 0);
				}
				if (xmlSchemaElement4.Name == xtr.LocalName && parentSchema.TargetNamespace == text)
				{
					lastUsedSeqItem = j;
					for (int k = 0; k < xmlSchemaObjectCollection.Count; k++)
					{
						((XmlSchemaElement)xmlSchemaObjectCollection[k]).MinOccurs = 0m;
					}
					this.InferElement(xmlSchemaElement4, false, parentSchema);
					this.SetMinMaxOccurs(xmlSchemaElement4, setMaxoccurs);
					return xmlSchemaElement4;
				}
				if (xmlSchemaElement4.RefName.Name == xtr.LocalName && xmlSchemaElement4.RefName.Namespace == xtr.NamespaceURI)
				{
					lastUsedSeqItem = j;
					for (int l = 0; l < xmlSchemaObjectCollection.Count; l++)
					{
						((XmlSchemaElement)xmlSchemaObjectCollection[l]).MinOccurs = 0m;
					}
					XmlSchemaElement xmlSchemaElement5 = this.FindGlobalElement(text, xtr.LocalName, out parentSchema);
					this.InferElement(xmlSchemaElement5, false, parentSchema);
					this.SetMinMaxOccurs(xmlSchemaElement4, setMaxoccurs);
					return xmlSchemaElement5;
				}
				xmlSchemaObjectCollection.Add(xmlSchemaElement4);
			}
			XmlSchemaElement xse2 = null;
			XmlSchemaElement xmlSchemaElement6;
			if (parentSchema.TargetNamespace == text)
			{
				xmlSchemaElement6 = this.FindElement(xmlSchemaSequence.Items, xtr.LocalName);
				xse2 = xmlSchemaElement6;
			}
			else
			{
				xmlSchemaElement6 = this.FindElementRef(xmlSchemaSequence.Items, xtr.LocalName, xtr.NamespaceURI);
				if (xmlSchemaElement6 != null)
				{
					xse2 = this.FindGlobalElement(text, xtr.LocalName, out parentSchema);
				}
			}
			if (xmlSchemaElement6 != null)
			{
				XmlSchemaChoice xmlSchemaChoice2 = new XmlSchemaChoice();
				xmlSchemaChoice2.MaxOccurs = decimal.MaxValue;
				this.SetMinMaxOccurs(xmlSchemaElement6, setMaxoccurs);
				this.InferElement(xse2, false, parentSchema);
				for (int m = 0; m < xmlSchemaSequence.Items.Count; m++)
				{
					xmlSchemaChoice2.Items.Add(this.CreateNewElementforChoice((XmlSchemaElement)xmlSchemaSequence.Items[m]));
				}
				xmlSchemaSequence.Items.Clear();
				xmlSchemaSequence.Items.Add(xmlSchemaChoice2);
				return xmlSchemaElement6;
			}
			string localName = xtr.LocalName;
			string prefix = xtr.Prefix;
			string namespaceURI = xtr.NamespaceURI;
			XmlSchema parentSchema2 = parentSchema;
			XmlSchemaObjectCollection items = xmlSchemaSequence.Items;
			int num = lastUsedSeqItem + 1;
			lastUsedSeqItem = num;
			xmlSchemaElement6 = this.AddElement(localName, prefix, namespaceURI, parentSchema2, items, num);
			if (!bCreatingNewType)
			{
				xmlSchemaElement6.MinOccurs = 0m;
			}
			return xmlSchemaElement6;
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0007BD2C File Offset: 0x00079F2C
		internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema)
		{
			XmlSchemaObjectCollection xmlSchemaObjectCollection = new XmlSchemaObjectCollection();
			XmlSchemaComplexType xmlSchemaComplexType = effectiveSchemaType as XmlSchemaComplexType;
			while (!(this.xtr.NamespaceURI == "http://www.w3.org/2001/XMLSchema"))
			{
				if (this.xtr.NamespaceURI == "http://www.w3.org/2000/xmlns/")
				{
					if (this.xtr.Prefix == "xmlns")
					{
						this.NamespaceManager.AddNamespace(this.xtr.LocalName, this.xtr.Value);
					}
				}
				else if (this.xtr.NamespaceURI == "http://www.w3.org/2001/XMLSchema-instance")
				{
					string localName = this.xtr.LocalName;
					if (localName == "nil")
					{
						xse.IsNillable = true;
					}
					else if (localName != "type" && localName != "schemaLocation" && localName != "noNamespaceSchemaLocation")
					{
						throw new XmlSchemaInferenceException("The attribute '{0}' does not match one of the four allowed attributes in the 'xsi' namespace.", localName);
					}
				}
				else
				{
					if (xmlSchemaComplexType == null || xmlSchemaComplexType == XmlSchemaComplexType.AnyType)
					{
						xmlSchemaComplexType = new XmlSchemaComplexType();
						xse.SchemaType = xmlSchemaComplexType;
					}
					if (effectiveSchemaType != null && effectiveSchemaType.Datatype != null && !xse.SchemaTypeName.IsEmpty)
					{
						XmlSchemaSimpleContent xmlSchemaSimpleContent = new XmlSchemaSimpleContent();
						xmlSchemaComplexType.ContentModel = xmlSchemaSimpleContent;
						XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension = new XmlSchemaSimpleContentExtension();
						xmlSchemaSimpleContent.Content = xmlSchemaSimpleContentExtension;
						xmlSchemaSimpleContentExtension.BaseTypeName = xse.SchemaTypeName;
						xmlSchemaSimpleContentExtension.LineNumber = xse.LineNumber;
						xse.LineNumber = 0;
						xse.SchemaTypeName = XmlQualifiedName.Empty;
					}
					XmlSchemaAttribute xmlSchemaAttribute;
					if (xmlSchemaComplexType.ContentModel != null)
					{
						XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension2 = this.CheckSimpleContentExtension(xmlSchemaComplexType);
						xmlSchemaAttribute = this.AddAttribute(this.xtr.LocalName, this.xtr.Prefix, this.xtr.NamespaceURI, this.xtr.Value, bCreatingNewType, parentSchema, xmlSchemaSimpleContentExtension2.Attributes, xmlSchemaComplexType.AttributeUses);
					}
					else
					{
						xmlSchemaAttribute = this.AddAttribute(this.xtr.LocalName, this.xtr.Prefix, this.xtr.NamespaceURI, this.xtr.Value, bCreatingNewType, parentSchema, xmlSchemaComplexType.Attributes, xmlSchemaComplexType.AttributeUses);
					}
					if (xmlSchemaAttribute != null)
					{
						xmlSchemaObjectCollection.Add(xmlSchemaAttribute);
					}
				}
				if (!this.xtr.MoveToNextAttribute())
				{
					if (!bCreatingNewType && xmlSchemaComplexType != null)
					{
						this.MakeExistingAttributesOptional(xmlSchemaComplexType, xmlSchemaObjectCollection);
					}
					return;
				}
			}
			throw new XmlSchemaInferenceException("The supplied xml instance is a schema or contains an inline schema. This class cannot infer a schema for a schema.", 0, 0);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0007BF80 File Offset: 0x0007A180
		private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct)
		{
			for (int i = 0; i < scExtension.Attributes.Count; i++)
			{
				ct.Attributes.Add(scExtension.Attributes[i]);
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0007BFBC File Offset: 0x0007A1BC
		private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType)
		{
			ICollection collection;
			if (!bCreatingNewType && ct.AttributeUses.Count > 0)
			{
				collection = ct.AttributeUses.Values;
			}
			else
			{
				collection = ct.Attributes;
			}
			foreach (object obj in collection)
			{
				XmlSchemaAttribute item = (XmlSchemaAttribute)obj;
				simpleContentExtension.Attributes.Add(item);
			}
			ct.Attributes.Clear();
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0007C048 File Offset: 0x0007A248
		internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName)
		{
			foreach (object obj in attributes)
			{
				XmlSchemaAttribute xmlSchemaAttribute = ((XmlSchemaObject)obj) as XmlSchemaAttribute;
				if (xmlSchemaAttribute != null && xmlSchemaAttribute.Name == attrName)
				{
					return xmlSchemaAttribute;
				}
			}
			return null;
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0007C0B4 File Offset: 0x0007A2B4
		internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema)
		{
			IEnumerable enumerable = this.schemaSet.Schemas(namespaceURI);
			parentSchema = null;
			foreach (object obj in enumerable)
			{
				XmlSchema xmlSchema = (XmlSchema)obj;
				XmlSchemaElement xmlSchemaElement = this.FindElement(xmlSchema.Items, localName);
				if (xmlSchemaElement != null)
				{
					parentSchema = xmlSchema;
					return xmlSchemaElement;
				}
			}
			return null;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0007C130 File Offset: 0x0007A330
		internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName)
		{
			for (int i = 0; i < elements.Count; i++)
			{
				XmlSchemaElement xmlSchemaElement = elements[i] as XmlSchemaElement;
				if (xmlSchemaElement != null && xmlSchemaElement.RefName != null && xmlSchemaElement.Name == elementName)
				{
					return xmlSchemaElement;
				}
			}
			return null;
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0007C180 File Offset: 0x0007A380
		internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI)
		{
			foreach (object obj in attributes)
			{
				XmlSchemaAttribute xmlSchemaAttribute = ((XmlSchemaObject)obj) as XmlSchemaAttribute;
				if (xmlSchemaAttribute != null && xmlSchemaAttribute.RefName.Name == attributeName && xmlSchemaAttribute.RefName.Namespace == nsURI)
				{
					return xmlSchemaAttribute;
				}
			}
			return null;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0007C204 File Offset: 0x0007A404
		internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI)
		{
			for (int i = 0; i < elements.Count; i++)
			{
				XmlSchemaElement xmlSchemaElement = elements[i] as XmlSchemaElement;
				if (xmlSchemaElement != null && xmlSchemaElement.RefName != null && xmlSchemaElement.RefName.Name == elementName && xmlSchemaElement.RefName.Namespace == nsURI)
				{
					return xmlSchemaElement;
				}
			}
			return null;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0007C26C File Offset: 0x0007A46C
		internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance)
		{
			if (ct == null)
			{
				throw new XmlSchemaInferenceException("Expected ComplexType. Schema was not generated using this tool.", 0, 0);
			}
			if (ct.ContentModel != null)
			{
				XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension = this.CheckSimpleContentExtension(ct);
				this.SwitchUseToOptional(xmlSchemaSimpleContentExtension.Attributes, attributesInInstance);
				return;
			}
			this.SwitchUseToOptional(ct.Attributes, attributesInInstance);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0007C2B4 File Offset: 0x0007A4B4
		private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance)
		{
			for (int i = 0; i < attributes.Count; i++)
			{
				XmlSchemaAttribute xmlSchemaAttribute = attributes[i] as XmlSchemaAttribute;
				if (xmlSchemaAttribute != null)
				{
					if (attributesInInstance != null)
					{
						if (xmlSchemaAttribute.RefName.Name.Length == 0)
						{
							if (this.FindAttribute(attributesInInstance, xmlSchemaAttribute.Name) == null)
							{
								xmlSchemaAttribute.Use = XmlSchemaUse.Optional;
							}
						}
						else if (this.FindAttributeRef(attributesInInstance, xmlSchemaAttribute.RefName.Name, xmlSchemaAttribute.RefName.Namespace) == null)
						{
							xmlSchemaAttribute.Use = XmlSchemaUse.Optional;
						}
					}
					else
					{
						xmlSchemaAttribute.Use = XmlSchemaUse.Optional;
					}
				}
			}
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0007C340 File Offset: 0x0007A540
		internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags)
		{
			bool flag = false;
			s = s.Trim();
			if (iTypeFlags == 262144 || this.typeInference == XmlSchemaInference.InferenceOption.Relaxed)
			{
				return XmlSchemaInference.ST_string;
			}
			iTypeFlags &= XmlSchemaInference.InferSimpleType(s, ref flag);
			if (iTypeFlags == 262144)
			{
				return XmlSchemaInference.ST_string;
			}
			if (flag)
			{
				if ((iTypeFlags & 2) != 0)
				{
					try
					{
						XmlConvert.ToSByte(s);
						if ((iTypeFlags & 4) != 0)
						{
							return XmlSchemaInference.ST_unsignedByte;
						}
						return XmlSchemaInference.ST_byte;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -3;
				}
				if ((iTypeFlags & 4) != 0)
				{
					try
					{
						XmlConvert.ToByte(s);
						return XmlSchemaInference.ST_unsignedByte;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -5;
				}
				if ((iTypeFlags & 8) != 0)
				{
					try
					{
						XmlConvert.ToInt16(s);
						if ((iTypeFlags & 16) != 0)
						{
							return XmlSchemaInference.ST_unsignedShort;
						}
						return XmlSchemaInference.ST_short;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -9;
				}
				if ((iTypeFlags & 16) != 0)
				{
					try
					{
						XmlConvert.ToUInt16(s);
						return XmlSchemaInference.ST_unsignedShort;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -17;
				}
				if ((iTypeFlags & 32) != 0)
				{
					try
					{
						XmlConvert.ToInt32(s);
						if ((iTypeFlags & 64) != 0)
						{
							return XmlSchemaInference.ST_unsignedInt;
						}
						return XmlSchemaInference.ST_int;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -33;
				}
				if ((iTypeFlags & 64) != 0)
				{
					try
					{
						XmlConvert.ToUInt32(s);
						return XmlSchemaInference.ST_unsignedInt;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -65;
				}
				if ((iTypeFlags & 128) != 0)
				{
					try
					{
						XmlConvert.ToInt64(s);
						if ((iTypeFlags & 256) != 0)
						{
							return XmlSchemaInference.ST_unsignedLong;
						}
						return XmlSchemaInference.ST_long;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -129;
				}
				if ((iTypeFlags & 256) != 0)
				{
					try
					{
						XmlConvert.ToUInt64(s);
						return XmlSchemaInference.ST_unsignedLong;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -257;
				}
				if ((iTypeFlags & 4096) != 0)
				{
					try
					{
						double value = XmlConvert.ToDouble(s);
						if ((iTypeFlags & 512) != 0)
						{
							return XmlSchemaInference.ST_integer;
						}
						if ((iTypeFlags & 1024) != 0)
						{
							return XmlSchemaInference.ST_decimal;
						}
						if ((iTypeFlags & 2048) != 0)
						{
							try
							{
								if (string.Compare(XmlConvert.ToString(XmlConvert.ToSingle(s)), XmlConvert.ToString(value), StringComparison.OrdinalIgnoreCase) == 0)
								{
									return XmlSchemaInference.ST_float;
								}
							}
							catch (FormatException)
							{
							}
							catch (OverflowException)
							{
							}
						}
						iTypeFlags &= -2049;
						return XmlSchemaInference.ST_double;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -4097;
				}
				if ((iTypeFlags & 2048) != 0)
				{
					try
					{
						XmlConvert.ToSingle(s);
						if ((iTypeFlags & 512) != 0)
						{
							return XmlSchemaInference.ST_integer;
						}
						if ((iTypeFlags & 1024) != 0)
						{
							return XmlSchemaInference.ST_decimal;
						}
						return XmlSchemaInference.ST_float;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags &= -2049;
				}
				if ((iTypeFlags & 512) != 0)
				{
					return XmlSchemaInference.ST_integer;
				}
				if ((iTypeFlags & 1024) != 0)
				{
					return XmlSchemaInference.ST_decimal;
				}
				if (iTypeFlags == 393216)
				{
					try
					{
						XmlConvert.ToDateTime(s, XmlDateTimeSerializationMode.RoundtripKind);
						return XmlSchemaInference.ST_gYearMonth;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags = 262144;
					return XmlSchemaInference.ST_string;
				}
				if (iTypeFlags == 270336)
				{
					try
					{
						XmlConvert.ToTimeSpan(s);
						return XmlSchemaInference.ST_duration;
					}
					catch (FormatException)
					{
					}
					catch (OverflowException)
					{
					}
					iTypeFlags = 262144;
					return XmlSchemaInference.ST_string;
				}
				if (iTypeFlags == 262145)
				{
					return XmlSchemaInference.ST_boolean;
				}
			}
			int num = iTypeFlags;
			if (num <= 4096)
			{
				if (num <= 64)
				{
					if (num <= 8)
					{
						switch (num)
						{
						case 1:
							return XmlSchemaInference.ST_boolean;
						case 2:
							return XmlSchemaInference.ST_byte;
						case 3:
							break;
						case 4:
							return XmlSchemaInference.ST_unsignedByte;
						default:
							if (num == 8)
							{
								return XmlSchemaInference.ST_short;
							}
							break;
						}
					}
					else
					{
						if (num == 16)
						{
							return XmlSchemaInference.ST_unsignedShort;
						}
						if (num == 32)
						{
							return XmlSchemaInference.ST_int;
						}
						if (num == 64)
						{
							return XmlSchemaInference.ST_unsignedInt;
						}
					}
				}
				else if (num <= 512)
				{
					if (num == 128)
					{
						return XmlSchemaInference.ST_long;
					}
					if (num == 256)
					{
						return XmlSchemaInference.ST_unsignedLong;
					}
					if (num == 512)
					{
						return XmlSchemaInference.ST_integer;
					}
				}
				else
				{
					if (num == 1024)
					{
						return XmlSchemaInference.ST_decimal;
					}
					if (num == 2048)
					{
						return XmlSchemaInference.ST_float;
					}
					if (num == 4096)
					{
						return XmlSchemaInference.ST_double;
					}
				}
			}
			else if (num <= 262144)
			{
				if (num <= 32768)
				{
					if (num == 8192)
					{
						return XmlSchemaInference.ST_duration;
					}
					if (num == 16384)
					{
						return XmlSchemaInference.ST_dateTime;
					}
					if (num == 32768)
					{
						return XmlSchemaInference.ST_time;
					}
				}
				else
				{
					if (num == 65536)
					{
						return XmlSchemaInference.ST_date;
					}
					if (num == 131072)
					{
						return XmlSchemaInference.ST_gYearMonth;
					}
					if (num == 262144)
					{
						return XmlSchemaInference.ST_string;
					}
				}
			}
			else if (num <= 268288)
			{
				if (num == 262145)
				{
					return XmlSchemaInference.ST_boolean;
				}
				if (num == 266240)
				{
					return XmlSchemaInference.ST_double;
				}
				if (num == 268288)
				{
					return XmlSchemaInference.ST_float;
				}
			}
			else
			{
				if (num == 278528)
				{
					return XmlSchemaInference.ST_dateTime;
				}
				if (num == 294912)
				{
					return XmlSchemaInference.ST_time;
				}
				if (num == 327680)
				{
					return XmlSchemaInference.ST_date;
				}
			}
			return XmlSchemaInference.ST_string;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0007CAFC File Offset: 0x0007ACFC
		internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck)
		{
			bool flag = false;
			bool flag2 = false;
			bool bDate = false;
			bool bTime = false;
			bool flag3 = false;
			if (s.Length == 0)
			{
				return 262144;
			}
			int num = 0;
			char c = s[num];
			if (c <= 'N')
			{
				switch (c)
				{
				case '+':
				{
					flag2 = true;
					num++;
					if (num == s.Length)
					{
						return 262144;
					}
					char c2 = s[num];
					if (c2 == '.')
					{
						goto IL_100;
					}
					if (c2 == 'P')
					{
						goto IL_30B;
					}
					if (s[num] < '0' || s[num] > '9')
					{
						return 262144;
					}
					goto IL_72A;
				}
				case ',':
				case '/':
					return 262144;
				case '-':
				{
					flag = true;
					num++;
					if (num == s.Length)
					{
						return 262144;
					}
					char c2 = s[num];
					if (c2 == '.')
					{
						goto IL_100;
					}
					if (c2 != 'I')
					{
						if (c2 == 'P')
						{
							goto IL_30B;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						goto IL_72A;
					}
					break;
				}
				case '.':
					goto IL_100;
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					goto IL_72A;
				default:
					if (c != 'I')
					{
						if (c != 'N')
						{
							return 262144;
						}
						if (s == "NaN")
						{
							return 268288;
						}
						return 262144;
					}
					break;
				}
				if (s.Substring(num) == "INF")
				{
					return 268288;
				}
				return 262144;
				IL_100:
				bNeedsRangeCheck = true;
				num++;
				if (num == s.Length)
				{
					if (num == 1 || (num == 2 && (flag2 || flag)))
					{
						return 262144;
					}
					return 269312;
				}
				else
				{
					char c2 = s[num];
					if (c2 != 'E' && c2 != 'e')
					{
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						for (;;)
						{
							num++;
							if (num == s.Length)
							{
								break;
							}
							c2 = s[num];
							if (c2 == 'E' || c2 == 'e')
							{
								goto IL_1AC;
							}
							if (s[num] < '0' || s[num] > '9')
							{
								return 262144;
							}
						}
						return 269312;
					}
					IL_1AC:
					num++;
					if (num == s.Length)
					{
						return 262144;
					}
					c2 = s[num];
					if (c2 != '+' && c2 != '-')
					{
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
					}
					else
					{
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
					}
					for (;;)
					{
						num++;
						if (num == s.Length)
						{
							break;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
					}
					return 268288;
				}
				IL_72A:
				num++;
				if (num == s.Length)
				{
					bNeedsRangeCheck = true;
					if (flag || flag2)
					{
						return 269994;
					}
					if (s == "0" || s == "1")
					{
						return 270335;
					}
					return 270334;
				}
				else
				{
					char c2 = s[num];
					if (c2 == '.')
					{
						goto IL_100;
					}
					if (c2 == 'E' || c2 == 'e')
					{
						bNeedsRangeCheck = true;
						return 268288;
					}
					if (s[num] < '0' || s[num] > '9')
					{
						return 262144;
					}
					num++;
					if (num == s.Length)
					{
						bNeedsRangeCheck = true;
						if (flag || flag2)
						{
							return 269994;
						}
						return 270334;
					}
					else
					{
						c2 = s[num];
						if (c2 <= ':')
						{
							if (c2 == '.')
							{
								goto IL_100;
							}
							if (c2 == ':')
							{
								bTime = true;
								goto IL_C8C;
							}
						}
						else if (c2 == 'E' || c2 == 'e')
						{
							bNeedsRangeCheck = true;
							return 268288;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							bNeedsRangeCheck = true;
							if (flag || flag2)
							{
								return 269994;
							}
							return 270334;
						}
						else
						{
							c2 = s[num];
							if (c2 == '.')
							{
								goto IL_100;
							}
							if (c2 == 'E' || c2 == 'e')
							{
								bNeedsRangeCheck = true;
								return 268288;
							}
							if (s[num] < '0' || s[num] > '9')
							{
								return 262144;
							}
							for (;;)
							{
								num++;
								if (num == s.Length)
								{
									break;
								}
								c2 = s[num];
								if (c2 <= '.')
								{
									if (c2 == '-')
									{
										goto IL_8F2;
									}
									if (c2 == '.')
									{
										goto IL_100;
									}
								}
								else if (c2 == 'E' || c2 == 'e')
								{
									goto IL_8F6;
								}
								if (s[num] < '0' || s[num] > '9')
								{
									return 262144;
								}
							}
							bNeedsRangeCheck = true;
							if (flag || flag2)
							{
								return 269994;
							}
							return 270334;
							IL_8F2:
							bDate = true;
							num++;
							if (num == s.Length)
							{
								return 262144;
							}
							if (s[num] < '0' || s[num] > '9')
							{
								return 262144;
							}
							num++;
							if (num == s.Length)
							{
								return 262144;
							}
							if (s[num] < '0' || s[num] > '9')
							{
								return 262144;
							}
							num++;
							if (num == s.Length)
							{
								bNeedsRangeCheck = true;
								return 393216;
							}
							c2 = s[num];
							if (c2 <= '-')
							{
								if (c2 == '+')
								{
									flag3 = true;
									goto IL_AD8;
								}
								if (c2 == '-')
								{
									num++;
									if (num == s.Length)
									{
										return 262144;
									}
									if (s[num] < '0' || s[num] > '9')
									{
										return 262144;
									}
									num++;
									if (num == s.Length)
									{
										return 262144;
									}
									if (s[num] < '0' || s[num] > '9')
									{
										return 262144;
									}
									num++;
									if (num == s.Length)
									{
										return XmlSchemaInference.DateTime(s, bDate, bTime);
									}
									c2 = s[num];
									if (c2 <= ':')
									{
										if (c2 == '+' || c2 == '-')
										{
											goto IL_AD8;
										}
										if (c2 == ':')
										{
											flag3 = true;
											goto IL_B68;
										}
									}
									else if (c2 != 'T')
									{
										if (c2 == 'Z' || c2 == 'z')
										{
											goto IL_AAC;
										}
									}
									else
									{
										bTime = true;
										num++;
										if (num == s.Length)
										{
											return 262144;
										}
										if (s[num] < '0' || s[num] > '9')
										{
											return 262144;
										}
										num++;
										if (num == s.Length)
										{
											return 262144;
										}
										if (s[num] < '0' || s[num] > '9')
										{
											return 262144;
										}
										num++;
										if (num == s.Length)
										{
											return 262144;
										}
										if (s[num] != ':')
										{
											return 262144;
										}
										goto IL_C8C;
									}
									return 262144;
								}
							}
							else if (c2 == 'Z' || c2 == 'z')
							{
								flag3 = true;
								goto IL_AAC;
							}
							return 262144;
							IL_8F6:
							bNeedsRangeCheck = true;
							return 268288;
						}
						IL_AAC:
						num++;
						if (num != s.Length)
						{
							return 262144;
						}
						if (flag3)
						{
							bNeedsRangeCheck = true;
							return 393216;
						}
						return XmlSchemaInference.DateTime(s, bDate, bTime);
						IL_AD8:
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] != ':')
						{
							return 262144;
						}
						IL_B68:
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num != s.Length)
						{
							return 262144;
						}
						if (flag3)
						{
							bNeedsRangeCheck = true;
							return 393216;
						}
						return XmlSchemaInference.DateTime(s, bDate, bTime);
						IL_C8C:
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] != ':')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							return 262144;
						}
						if (s[num] < '0' || s[num] > '9')
						{
							return 262144;
						}
						num++;
						if (num == s.Length)
						{
							return XmlSchemaInference.DateTime(s, bDate, bTime);
						}
						c2 = s[num];
						switch (c2)
						{
						case '+':
						case '-':
							goto IL_AD8;
						case ',':
							break;
						case '.':
							num++;
							if (num == s.Length)
							{
								return 262144;
							}
							if (s[num] < '0' || s[num] > '9')
							{
								return 262144;
							}
							for (;;)
							{
								num++;
								if (num == s.Length)
								{
									break;
								}
								c2 = s[num];
								if (c2 <= '-')
								{
									if (c2 == '+' || c2 == '-')
									{
										goto IL_AD8;
									}
								}
								else if (c2 == 'Z' || c2 == 'z')
								{
									goto IL_AAC;
								}
								if (s[num] < '0' || s[num] > '9')
								{
									return 262144;
								}
							}
							return XmlSchemaInference.DateTime(s, bDate, bTime);
						default:
							if (c2 == 'Z' || c2 == 'z')
							{
								goto IL_AAC;
							}
							break;
						}
						return 262144;
					}
				}
			}
			else if (c != 'P')
			{
				if (c != 'f' && c != 't')
				{
					return 262144;
				}
				if (s == "true")
				{
					return 262145;
				}
				if (s == "false")
				{
					return 262145;
				}
				return 262144;
			}
			IL_30B:
			num++;
			if (num == s.Length)
			{
				return 262144;
			}
			if (s[num] != 'T')
			{
				if (s[num] < '0' || s[num] > '9')
				{
					return 262144;
				}
				for (;;)
				{
					num++;
					if (num == s.Length)
					{
						break;
					}
					char c2 = s[num];
					if (c2 == 'D')
					{
						goto IL_4BD;
					}
					if (c2 == 'M')
					{
						goto IL_437;
					}
					if (c2 == 'Y')
					{
						goto IL_3A4;
					}
					if (s[num] < '0' || s[num] > '9')
					{
						return 262144;
					}
				}
				return 262144;
				IL_3A4:
				num++;
				if (num == s.Length)
				{
					bNeedsRangeCheck = true;
					return 270336;
				}
				if (s[num] == 'T')
				{
					goto IL_4E8;
				}
				if (s[num] < '0' || s[num] > '9')
				{
					return 262144;
				}
				for (;;)
				{
					num++;
					if (num == s.Length)
					{
						break;
					}
					char c2 = s[num];
					if (c2 == 'D')
					{
						goto IL_4BD;
					}
					if (c2 == 'M')
					{
						goto IL_437;
					}
					if (s[num] < '0' || s[num] > '9')
					{
						return 262144;
					}
				}
				return 262144;
				IL_437:
				num++;
				if (num == s.Length)
				{
					bNeedsRangeCheck = true;
					return 270336;
				}
				if (s[num] == 'T')
				{
					goto IL_4E8;
				}
				if (s[num] < '0' || s[num] > '9')
				{
					return 262144;
				}
				for (;;)
				{
					num++;
					if (num == s.Length)
					{
						break;
					}
					if (s[num] == 'D')
					{
						goto IL_4BD;
					}
					if (s[num] < '0' || s[num] > '9')
					{
						return 262144;
					}
				}
				return 262144;
				IL_4BD:
				num++;
				if (num == s.Length)
				{
					bNeedsRangeCheck = true;
					return 270336;
				}
				if (s[num] != 'T')
				{
					return 262144;
				}
			}
			IL_4E8:
			num++;
			if (num == s.Length)
			{
				return 262144;
			}
			if (s[num] < '0' || s[num] > '9')
			{
				return 262144;
			}
			for (;;)
			{
				num++;
				if (num == s.Length)
				{
					break;
				}
				char c2 = s[num];
				if (c2 <= 'H')
				{
					if (c2 == '.')
					{
						goto IL_694;
					}
					if (c2 == 'H')
					{
						goto IL_583;
					}
				}
				else
				{
					if (c2 == 'M')
					{
						goto IL_610;
					}
					if (c2 == 'S')
					{
						goto IL_70B;
					}
				}
				if (s[num] < '0' || s[num] > '9')
				{
					return 262144;
				}
			}
			return 262144;
			IL_583:
			num++;
			if (num == s.Length)
			{
				bNeedsRangeCheck = true;
				return 270336;
			}
			if (s[num] < '0' || s[num] > '9')
			{
				return 262144;
			}
			for (;;)
			{
				num++;
				if (num == s.Length)
				{
					break;
				}
				char c2 = s[num];
				if (c2 == '.')
				{
					goto IL_694;
				}
				if (c2 == 'M')
				{
					goto IL_610;
				}
				if (c2 == 'S')
				{
					goto IL_70B;
				}
				if (s[num] < '0' || s[num] > '9')
				{
					return 262144;
				}
			}
			return 262144;
			IL_610:
			num++;
			if (num == s.Length)
			{
				bNeedsRangeCheck = true;
				return 270336;
			}
			if (s[num] < '0' || s[num] > '9')
			{
				return 262144;
			}
			for (;;)
			{
				num++;
				if (num == s.Length)
				{
					break;
				}
				char c2 = s[num];
				if (c2 == '.')
				{
					goto IL_694;
				}
				if (c2 == 'S')
				{
					goto IL_70B;
				}
				if (s[num] < '0' || s[num] > '9')
				{
					return 262144;
				}
			}
			return 262144;
			IL_694:
			num++;
			if (num == s.Length)
			{
				bNeedsRangeCheck = true;
				return 270336;
			}
			if (s[num] < '0' || s[num] > '9')
			{
				return 262144;
			}
			for (;;)
			{
				num++;
				if (num == s.Length)
				{
					break;
				}
				if (s[num] == 'S')
				{
					goto IL_70B;
				}
				if (s[num] < '0' || s[num] > '9')
				{
					return 262144;
				}
			}
			return 262144;
			IL_70B:
			num++;
			if (num == s.Length)
			{
				bNeedsRangeCheck = true;
				return 270336;
			}
			return 262144;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0007D988 File Offset: 0x0007BB88
		internal static int DateTime(string s, bool bDate, bool bTime)
		{
			try
			{
				XmlConvert.ToDateTime(s, XmlDateTimeSerializationMode.RoundtripKind);
			}
			catch (FormatException)
			{
				return 262144;
			}
			if (bDate && bTime)
			{
				return 278528;
			}
			if (bDate)
			{
				return 327680;
			}
			if (bTime)
			{
				return 294912;
			}
			return 262144;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0007D9DC File Offset: 0x0007BBDC
		private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement)
		{
			XmlSchemaElement xmlSchemaElement = new XmlSchemaElement();
			xmlSchemaElement.Annotation = copyElement.Annotation;
			xmlSchemaElement.Block = copyElement.Block;
			xmlSchemaElement.DefaultValue = copyElement.DefaultValue;
			xmlSchemaElement.Final = copyElement.Final;
			xmlSchemaElement.FixedValue = copyElement.FixedValue;
			xmlSchemaElement.Form = copyElement.Form;
			xmlSchemaElement.Id = copyElement.Id;
			if (copyElement.IsNillable)
			{
				xmlSchemaElement.IsNillable = copyElement.IsNillable;
			}
			xmlSchemaElement.LineNumber = copyElement.LineNumber;
			xmlSchemaElement.LinePosition = copyElement.LinePosition;
			xmlSchemaElement.Name = copyElement.Name;
			xmlSchemaElement.Namespaces = copyElement.Namespaces;
			xmlSchemaElement.RefName = copyElement.RefName;
			xmlSchemaElement.SchemaType = copyElement.SchemaType;
			xmlSchemaElement.SchemaTypeName = copyElement.SchemaTypeName;
			xmlSchemaElement.SourceUri = copyElement.SourceUri;
			xmlSchemaElement.SubstitutionGroup = copyElement.SubstitutionGroup;
			xmlSchemaElement.UnhandledAttributes = copyElement.UnhandledAttributes;
			if (copyElement.MinOccurs != 1m && this.Occurrence == XmlSchemaInference.InferenceOption.Relaxed)
			{
				xmlSchemaElement.MinOccurs = copyElement.MinOccurs;
			}
			if (copyElement.MaxOccurs != 1m)
			{
				xmlSchemaElement.MaxOccurs = copyElement.MaxOccurs;
			}
			return xmlSchemaElement;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0007DB18 File Offset: 0x0007BD18
		private static int GetSchemaType(XmlQualifiedName qname)
		{
			if (qname == XmlSchemaInference.SimpleTypes[0])
			{
				return 262145;
			}
			if (qname == XmlSchemaInference.SimpleTypes[1])
			{
				return 269994;
			}
			if (qname == XmlSchemaInference.SimpleTypes[2])
			{
				return 270334;
			}
			if (qname == XmlSchemaInference.SimpleTypes[3])
			{
				return 269992;
			}
			if (qname == XmlSchemaInference.SimpleTypes[4])
			{
				return 270328;
			}
			if (qname == XmlSchemaInference.SimpleTypes[5])
			{
				return 269984;
			}
			if (qname == XmlSchemaInference.SimpleTypes[6])
			{
				return 270304;
			}
			if (qname == XmlSchemaInference.SimpleTypes[7])
			{
				return 269952;
			}
			if (qname == XmlSchemaInference.SimpleTypes[8])
			{
				return 270208;
			}
			if (qname == XmlSchemaInference.SimpleTypes[9])
			{
				return 269824;
			}
			if (qname == XmlSchemaInference.SimpleTypes[10])
			{
				return 269312;
			}
			if (qname == XmlSchemaInference.SimpleTypes[11])
			{
				return 268288;
			}
			if (qname == XmlSchemaInference.SimpleTypes[12])
			{
				return 266240;
			}
			if (qname == XmlSchemaInference.SimpleTypes[13])
			{
				return 270336;
			}
			if (qname == XmlSchemaInference.SimpleTypes[14])
			{
				return 278528;
			}
			if (qname == XmlSchemaInference.SimpleTypes[15])
			{
				return 294912;
			}
			if (qname == XmlSchemaInference.SimpleTypes[16])
			{
				return 65536;
			}
			if (qname == XmlSchemaInference.SimpleTypes[17])
			{
				return 131072;
			}
			if (qname == XmlSchemaInference.SimpleTypes[18])
			{
				return 262144;
			}
			if (qname == null || qname.IsEmpty)
			{
				return -1;
			}
			throw new XmlSchemaInferenceException("Inference can only handle simple built-in types for 'SchemaType'.", 0, 0);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0007DCE0 File Offset: 0x0007BEE0
		internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs)
		{
			if (this.Occurrence == XmlSchemaInference.InferenceOption.Relaxed)
			{
				if (setMaxOccurs || el.MaxOccurs > 1m)
				{
					el.MaxOccurs = decimal.MaxValue;
				}
				el.MinOccurs = 0m;
				return;
			}
			if (el.MinOccurs > 1m)
			{
				el.MinOccurs = 1m;
			}
		}

		// Token: 0x04000DA6 RID: 3494
		internal static XmlQualifiedName ST_boolean = new XmlQualifiedName("boolean", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DA7 RID: 3495
		internal static XmlQualifiedName ST_byte = new XmlQualifiedName("byte", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DA8 RID: 3496
		internal static XmlQualifiedName ST_unsignedByte = new XmlQualifiedName("unsignedByte", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DA9 RID: 3497
		internal static XmlQualifiedName ST_short = new XmlQualifiedName("short", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DAA RID: 3498
		internal static XmlQualifiedName ST_unsignedShort = new XmlQualifiedName("unsignedShort", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DAB RID: 3499
		internal static XmlQualifiedName ST_int = new XmlQualifiedName("int", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DAC RID: 3500
		internal static XmlQualifiedName ST_unsignedInt = new XmlQualifiedName("unsignedInt", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DAD RID: 3501
		internal static XmlQualifiedName ST_long = new XmlQualifiedName("long", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DAE RID: 3502
		internal static XmlQualifiedName ST_unsignedLong = new XmlQualifiedName("unsignedLong", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DAF RID: 3503
		internal static XmlQualifiedName ST_integer = new XmlQualifiedName("integer", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB0 RID: 3504
		internal static XmlQualifiedName ST_decimal = new XmlQualifiedName("decimal", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB1 RID: 3505
		internal static XmlQualifiedName ST_float = new XmlQualifiedName("float", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB2 RID: 3506
		internal static XmlQualifiedName ST_double = new XmlQualifiedName("double", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB3 RID: 3507
		internal static XmlQualifiedName ST_duration = new XmlQualifiedName("duration", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB4 RID: 3508
		internal static XmlQualifiedName ST_dateTime = new XmlQualifiedName("dateTime", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB5 RID: 3509
		internal static XmlQualifiedName ST_time = new XmlQualifiedName("time", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB6 RID: 3510
		internal static XmlQualifiedName ST_date = new XmlQualifiedName("date", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB7 RID: 3511
		internal static XmlQualifiedName ST_gYearMonth = new XmlQualifiedName("gYearMonth", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB8 RID: 3512
		internal static XmlQualifiedName ST_string = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DB9 RID: 3513
		internal static XmlQualifiedName ST_anySimpleType = new XmlQualifiedName("anySimpleType", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000DBA RID: 3514
		internal static XmlQualifiedName[] SimpleTypes = new XmlQualifiedName[]
		{
			XmlSchemaInference.ST_boolean,
			XmlSchemaInference.ST_byte,
			XmlSchemaInference.ST_unsignedByte,
			XmlSchemaInference.ST_short,
			XmlSchemaInference.ST_unsignedShort,
			XmlSchemaInference.ST_int,
			XmlSchemaInference.ST_unsignedInt,
			XmlSchemaInference.ST_long,
			XmlSchemaInference.ST_unsignedLong,
			XmlSchemaInference.ST_integer,
			XmlSchemaInference.ST_decimal,
			XmlSchemaInference.ST_float,
			XmlSchemaInference.ST_double,
			XmlSchemaInference.ST_duration,
			XmlSchemaInference.ST_dateTime,
			XmlSchemaInference.ST_time,
			XmlSchemaInference.ST_date,
			XmlSchemaInference.ST_gYearMonth,
			XmlSchemaInference.ST_string
		};

		// Token: 0x04000DBB RID: 3515
		private XmlSchema rootSchema;

		// Token: 0x04000DBC RID: 3516
		private XmlSchemaSet schemaSet;

		// Token: 0x04000DBD RID: 3517
		private XmlReader xtr;

		// Token: 0x04000DBE RID: 3518
		private NameTable nametable;

		// Token: 0x04000DBF RID: 3519
		private string TargetNamespace;

		// Token: 0x04000DC0 RID: 3520
		private XmlNamespaceManager NamespaceManager;

		// Token: 0x04000DC1 RID: 3521
		private ArrayList schemaList;

		// Token: 0x04000DC2 RID: 3522
		private XmlSchemaInference.InferenceOption occurrence;

		// Token: 0x04000DC3 RID: 3523
		private XmlSchemaInference.InferenceOption typeInference;

		/// <summary>Affects occurrence and type information inferred by the <see cref="T:System.Xml.Schema.XmlSchemaInference" /> class for elements and attributes in an XML document. </summary>
		// Token: 0x020002A0 RID: 672
		public enum InferenceOption
		{
			/// <summary>Indicates that a more restrictive schema declaration should be inferred for a particular element or attribute.</summary>
			// Token: 0x04000DC5 RID: 3525
			Restricted,
			/// <summary>Indicates that a less restrictive schema declaration should be inferred for a particular element or attribute.</summary>
			// Token: 0x04000DC6 RID: 3526
			Relaxed
		}
	}
}
