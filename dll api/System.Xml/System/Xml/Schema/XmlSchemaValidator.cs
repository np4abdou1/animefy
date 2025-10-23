using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.XmlConfiguration;

namespace System.Xml.Schema
{
	/// <summary>Represents an XML Schema Definition Language (XSD) Schema validation engine. The <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> class cannot be inherited.</summary>
	// Token: 0x02000328 RID: 808
	public sealed class XmlSchemaValidator
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> class.</summary>
		/// <param name="nameTable">An <see cref="T:System.Xml.XmlNameTable" /> object containing element and attribute names as atomized strings.</param>
		/// <param name="schemas">An <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object containing the XML Schema Definition Language (XSD) schemas used for validation.</param>
		/// <param name="namespaceResolver">An <see cref="T:System.Xml.IXmlNamespaceResolver" /> object used for resolving namespaces encountered during validation.</param>
		/// <param name="validationFlags">An <see cref="T:System.Xml.Schema.XmlSchemaValidationFlags" /> value specifying schema validation options.</param>
		/// <exception cref="T:System.ArgumentNullException">One or more of the parameters specified are <see langword="null" />.</exception>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">An error occurred while compiling schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> parameter.</exception>
		// Token: 0x06001AAC RID: 6828 RVA: 0x0009AF80 File Offset: 0x00099180
		public XmlSchemaValidator(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags)
		{
			if (nameTable == null)
			{
				throw new ArgumentNullException("nameTable");
			}
			if (schemas == null)
			{
				throw new ArgumentNullException("schemas");
			}
			if (namespaceResolver == null)
			{
				throw new ArgumentNullException("namespaceResolver");
			}
			this.nameTable = nameTable;
			this.nsResolver = namespaceResolver;
			this.validationFlags = validationFlags;
			if ((validationFlags & XmlSchemaValidationFlags.ProcessInlineSchema) != XmlSchemaValidationFlags.None || (validationFlags & XmlSchemaValidationFlags.ProcessSchemaLocation) != XmlSchemaValidationFlags.None)
			{
				this.schemaSet = new XmlSchemaSet(nameTable);
				this.schemaSet.ValidationEventHandler += schemas.GetEventHandler();
				this.schemaSet.CompilationSettings = schemas.CompilationSettings;
				this.schemaSet.XmlResolver = schemas.GetResolver();
				this.schemaSet.Add(schemas);
				this.validatedNamespaces = new Hashtable();
			}
			else
			{
				this.schemaSet = schemas;
			}
			this.Init();
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0009B060 File Offset: 0x00099260
		private void Init()
		{
			this.validationStack = new HWStack(10);
			this.attPresence = new Hashtable();
			this.Push(XmlQualifiedName.Empty);
			this.dummyPositionInfo = new PositionInfo();
			this.positionInfo = this.dummyPositionInfo;
			this.validationEventSender = this;
			this.currentState = ValidatorState.None;
			this.textValue = new StringBuilder(100);
			this.xmlResolver = XmlReaderSection.CreateDefaultResolver();
			this.contextQName = new XmlQualifiedName();
			this.Reset();
			this.RecompileSchemaSet();
			this.NsXs = this.nameTable.Add("http://www.w3.org/2001/XMLSchema");
			this.NsXsi = this.nameTable.Add("http://www.w3.org/2001/XMLSchema-instance");
			this.NsXmlNs = this.nameTable.Add("http://www.w3.org/2000/xmlns/");
			this.NsXml = this.nameTable.Add("http://www.w3.org/XML/1998/namespace");
			this.xsiTypeString = this.nameTable.Add("type");
			this.xsiNilString = this.nameTable.Add("nil");
			this.xsiSchemaLocationString = this.nameTable.Add("schemaLocation");
			this.xsiNoNamespaceSchemaLocationString = this.nameTable.Add("noNamespaceSchemaLocation");
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0009B194 File Offset: 0x00099394
		private void Reset()
		{
			this.isRoot = true;
			this.rootHasSchema = true;
			while (this.validationStack.Length > 1)
			{
				this.validationStack.Pop();
			}
			this.startIDConstraint = -1;
			this.partialValidationType = null;
			if (this.IDs != null)
			{
				this.IDs.Clear();
			}
			if (this.ProcessSchemaHints)
			{
				this.validatedNamespaces.Clear();
			}
		}

		/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> object used to resolve xs:import and xs:include elements as well as xsi:schemaLocation and xsi:noNamespaceSchemaLocation attributes.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlResolver" /> object; the default is an <see cref="T:System.Xml.XmlUrlResolver" /> object.</returns>
		// Token: 0x1700066A RID: 1642
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0009B1FF File Offset: 0x000993FF
		public XmlResolver XmlResolver
		{
			set
			{
				this.xmlResolver = value;
			}
		}

		/// <summary>Gets or sets the line number information for the XML node being validated.</summary>
		/// <returns>An <see cref="T:System.Xml.IXmlLineInfo" /> object.</returns>
		// Token: 0x1700066B RID: 1643
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x0009B208 File Offset: 0x00099408
		public IXmlLineInfo LineInfoProvider
		{
			set
			{
				if (value == null)
				{
					this.positionInfo = this.dummyPositionInfo;
					return;
				}
				this.positionInfo = value;
			}
		}

		/// <summary>Gets or sets the source URI for the XML node being validated.</summary>
		/// <returns>A <see cref="T:System.Uri" /> object representing the source URI for the XML node being validated; the default is <see langword="null" />.</returns>
		// Token: 0x1700066C RID: 1644
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0009B221 File Offset: 0x00099421
		public Uri SourceUri
		{
			set
			{
				this.sourceUri = value;
				this.sourceUriString = this.sourceUri.ToString();
			}
		}

		/// <summary>Gets or sets the object sent as the sender object of a validation event.</summary>
		/// <returns>An <see cref="T:System.Object" />; the default is this <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object.</returns>
		// Token: 0x1700066D RID: 1645
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x0009B23B File Offset: 0x0009943B
		public object ValidationEventSender
		{
			set
			{
				this.validationEventSender = value;
			}
		}

		/// <summary>The <see cref="T:System.Xml.Schema.ValidationEventHandler" /> that receives schema validation warnings and errors encountered during schema validation.</summary>
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06001AB3 RID: 6835 RVA: 0x0009B244 File Offset: 0x00099444
		// (remove) Token: 0x06001AB4 RID: 6836 RVA: 0x0009B25D File Offset: 0x0009945D
		public event ValidationEventHandler ValidationEventHandler
		{
			add
			{
				this.eventHandler = (ValidationEventHandler)Delegate.Combine(this.eventHandler, value);
			}
			remove
			{
				this.eventHandler = (ValidationEventHandler)Delegate.Remove(this.eventHandler, value);
			}
		}

		/// <summary>Adds an XML Schema Definition Language (XSD) schema to the set of schemas used for validation.</summary>
		/// <param name="schema">An <see cref="T:System.Xml.Schema.XmlSchema" /> object to add to the set of schemas used for validation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchema" /> parameter specified is <see langword="null" />.</exception>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The target namespace of the <see cref="T:System.Xml.Schema.XmlSchema" /> parameter matches that of any element or attribute already encountered by the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object.</exception>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">The <see cref="T:System.Xml.Schema.XmlSchema" /> parameter is invalid.</exception>
		// Token: 0x06001AB5 RID: 6837 RVA: 0x0009B278 File Offset: 0x00099478
		public void AddSchema(XmlSchema schema)
		{
			if (schema == null)
			{
				throw new ArgumentNullException("schema");
			}
			if ((this.validationFlags & XmlSchemaValidationFlags.ProcessInlineSchema) == XmlSchemaValidationFlags.None)
			{
				return;
			}
			string text = schema.TargetNamespace;
			if (text == null)
			{
				text = string.Empty;
			}
			Hashtable schemaLocations = this.schemaSet.SchemaLocations;
			DictionaryEntry[] array = new DictionaryEntry[schemaLocations.Count];
			schemaLocations.CopyTo(array, 0);
			if (this.validatedNamespaces[text] != null && this.schemaSet.FindSchemaByNSAndUrl(schema.BaseUri, text, array) == null)
			{
				this.SendValidationEvent("An element or attribute information item has already been validated from the '{0}' namespace. It is an error if 'xsi:schemaLocation', 'xsi:noNamespaceSchemaLocation', or an inline schema occurs for that namespace.", text, XmlSeverityType.Error);
			}
			if (schema.ErrorCount == 0)
			{
				try
				{
					this.schemaSet.Add(schema);
					this.RecompileSchemaSet();
				}
				catch (XmlSchemaException ex)
				{
					this.SendValidationEvent("Cannot load the schema for the namespace '{0}' - {1}", new string[]
					{
						schema.BaseUri.ToString(),
						ex.Message
					}, ex);
				}
				for (int i = 0; i < schema.ImportedSchemas.Count; i++)
				{
					XmlSchema xmlSchema = (XmlSchema)schema.ImportedSchemas[i];
					text = xmlSchema.TargetNamespace;
					if (text == null)
					{
						text = string.Empty;
					}
					if (this.validatedNamespaces[text] != null && this.schemaSet.FindSchemaByNSAndUrl(xmlSchema.BaseUri, text, array) == null)
					{
						this.SendValidationEvent("An element or attribute information item has already been validated from the '{0}' namespace. It is an error if 'xsi:schemaLocation', 'xsi:noNamespaceSchemaLocation', or an inline schema occurs for that namespace.", text, XmlSeverityType.Error);
						this.schemaSet.RemoveRecursive(schema);
						return;
					}
				}
			}
		}

		/// <summary>Initializes the state of the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object.</summary>
		/// <exception cref="T:System.InvalidOperationException">Calling the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.Initialize" /> method is valid immediately after the construction of an <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object or after a call to <see cref="M:System.Xml.Schema.XmlSchemaValidator.EndValidation" /> only.</exception>
		// Token: 0x06001AB6 RID: 6838 RVA: 0x0009B3D4 File Offset: 0x000995D4
		public void Initialize()
		{
			if (this.currentState != ValidatorState.None && this.currentState != ValidatorState.Finish)
			{
				string name = "The transition from the '{0}' method to the '{1}' method is not allowed.";
				object[] args = new string[]
				{
					XmlSchemaValidator.MethodNames[(int)this.currentState],
					XmlSchemaValidator.MethodNames[1]
				};
				throw new InvalidOperationException(Res.GetString(name, args));
			}
			this.currentState = ValidatorState.Start;
			this.Reset();
		}

		/// <summary>Initializes the state of the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object using the <see cref="T:System.Xml.Schema.XmlSchemaObject" /> specified for partial validation.</summary>
		/// <param name="partialValidationType">An <see cref="T:System.Xml.Schema.XmlSchemaElement" />, <see cref="T:System.Xml.Schema.XmlSchemaAttribute" />, or <see cref="T:System.Xml.Schema.XmlSchemaType" /> object used to initialize the validation context of the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object for partial validation.</param>
		/// <exception cref="T:System.InvalidOperationException">Calling the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.Initialize" /> method is valid immediately after the construction of an <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object or after a call to <see cref="M:System.Xml.Schema.XmlSchemaValidator.EndValidation" /> only.</exception>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> parameter is not an <see cref="T:System.Xml.Schema.XmlSchemaElement" />, <see cref="T:System.Xml.Schema.XmlSchemaAttribute" />, or <see cref="T:System.Xml.Schema.XmlSchemaType" /> object.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> parameter cannot be <see langword="null" />.</exception>
		// Token: 0x06001AB7 RID: 6839 RVA: 0x0009B434 File Offset: 0x00099634
		public void Initialize(XmlSchemaObject partialValidationType)
		{
			if (this.currentState != ValidatorState.None && this.currentState != ValidatorState.Finish)
			{
				string name = "The transition from the '{0}' method to the '{1}' method is not allowed.";
				object[] args = new string[]
				{
					XmlSchemaValidator.MethodNames[(int)this.currentState],
					XmlSchemaValidator.MethodNames[1]
				};
				throw new InvalidOperationException(Res.GetString(name, args));
			}
			if (partialValidationType == null)
			{
				throw new ArgumentNullException("partialValidationType");
			}
			if (!(partialValidationType is XmlSchemaElement) && !(partialValidationType is XmlSchemaAttribute) && !(partialValidationType is XmlSchemaType))
			{
				throw new ArgumentException(Res.GetString("The partial validation type has to be 'XmlSchemaElement', 'XmlSchemaAttribute', or 'XmlSchemaType'."));
			}
			this.currentState = ValidatorState.Start;
			this.Reset();
			this.partialValidationType = partialValidationType;
		}

		/// <summary>Validates the element in the current context with the xsi:Type, xsi:Nil, xsi:SchemaLocation, and xsi:NoNamespaceSchemaLocation attribute values specified.</summary>
		/// <param name="localName">The local name of the element to validate.</param>
		/// <param name="namespaceUri">The namespace URI of the element to validate.</param>
		/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set on successful validation of the element's name. This parameter can be <see langword="null" />.</param>
		/// <param name="xsiType">The xsi:Type attribute value of the element. This parameter can be <see langword="null" />.</param>
		/// <param name="xsiNil">The xsi:Nil attribute value of the element. This parameter can be <see langword="null" />.</param>
		/// <param name="xsiSchemaLocation">The xsi:SchemaLocation attribute value of the element. This parameter can be <see langword="null" />.</param>
		/// <param name="xsiNoNamespaceSchemaLocation">The xsi:NoNamespaceSchemaLocation attribute value of the element. This parameter can be <see langword="null" />.</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The element's name is not valid in the current context.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateElement" /> method was not called in the correct sequence. For example, the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateElement" /> method is called after calling <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" />.</exception>
		// Token: 0x06001AB8 RID: 6840 RVA: 0x0009B4D0 File Offset: 0x000996D0
		public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
		{
			if (localName == null)
			{
				throw new ArgumentNullException("localName");
			}
			if (namespaceUri == null)
			{
				throw new ArgumentNullException("namespaceUri");
			}
			this.CheckStateTransition(ValidatorState.Element, XmlSchemaValidator.MethodNames[4]);
			this.ClearPSVI();
			this.contextQName.Init(localName, namespaceUri);
			XmlQualifiedName xmlQualifiedName = this.contextQName;
			bool flag;
			object particle = this.ValidateElementContext(xmlQualifiedName, out flag);
			SchemaElementDecl schemaElementDecl = this.FastGetElementDecl(xmlQualifiedName, particle);
			this.Push(xmlQualifiedName);
			if (flag)
			{
				this.context.Validity = XmlSchemaValidity.Invalid;
			}
			if ((this.validationFlags & XmlSchemaValidationFlags.ProcessSchemaLocation) != XmlSchemaValidationFlags.None && this.xmlResolver != null)
			{
				this.ProcessSchemaLocations(xsiSchemaLocation, xsiNoNamespaceSchemaLocation);
			}
			if (this.processContents != XmlSchemaContentProcessing.Skip)
			{
				if (schemaElementDecl == null && this.partialValidationType == null)
				{
					schemaElementDecl = this.compiledSchemaInfo.GetElementDecl(xmlQualifiedName);
				}
				bool declFound = schemaElementDecl != null;
				if (xsiType != null || xsiNil != null)
				{
					schemaElementDecl = this.CheckXsiTypeAndNil(schemaElementDecl, xsiType, xsiNil, ref declFound);
				}
				if (schemaElementDecl == null)
				{
					this.ThrowDeclNotFoundWarningOrError(declFound);
				}
			}
			this.context.ElementDecl = schemaElementDecl;
			XmlSchemaElement schemaElement = null;
			XmlSchemaType schemaType = null;
			if (schemaElementDecl != null)
			{
				this.CheckElementProperties();
				this.attPresence.Clear();
				this.context.NeedValidateChildren = (this.processContents != XmlSchemaContentProcessing.Skip);
				this.ValidateStartElementIdentityConstraints();
				schemaElementDecl.ContentValidator.InitValidation(this.context);
				schemaType = schemaElementDecl.SchemaType;
				schemaElement = this.GetSchemaElement();
			}
			if (schemaInfo != null)
			{
				schemaInfo.SchemaType = schemaType;
				schemaInfo.SchemaElement = schemaElement;
				schemaInfo.IsNil = this.context.IsNill;
				schemaInfo.Validity = this.context.Validity;
			}
			if (this.ProcessSchemaHints && this.validatedNamespaces[namespaceUri] == null)
			{
				this.validatedNamespaces.Add(namespaceUri, namespaceUri);
			}
			if (this.isRoot)
			{
				this.isRoot = false;
			}
		}

		/// <summary>Validates the attribute name, namespace URI, and value in the current element context.</summary>
		/// <param name="localName">The local name of the attribute to validate.</param>
		/// <param name="namespaceUri">The namespace URI of the attribute to validate.</param>
		/// <param name="attributeValue">An <see cref="T:System.Xml.Schema.XmlValueGetter" /><see langword="delegate" /> used to pass the attribute's value as a Common Language Runtime (CLR) type compatible with the XML Schema Definition Language (XSD) type of the attribute.</param>
		/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set on successful validation of the attribute. This parameter and can be <see langword="null" />.</param>
		/// <returns>The validated attribute's value.</returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The attribute is not valid in the current element context.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" /> method was not called in the correct sequence. For example, calling <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" /> after calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo)" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">One or more of the parameters specified are <see langword="null" />.</exception>
		// Token: 0x06001AB9 RID: 6841 RVA: 0x0009B679 File Offset: 0x00099879
		public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo)
		{
			if (attributeValue == null)
			{
				throw new ArgumentNullException("attributeValue");
			}
			return this.ValidateAttribute(localName, namespaceUri, attributeValue, null, schemaInfo);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0009B698 File Offset: 0x00099898
		private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo)
		{
			if (lName == null)
			{
				throw new ArgumentNullException("localName");
			}
			if (ns == null)
			{
				throw new ArgumentNullException("namespaceUri");
			}
			ValidatorState validatorState = (this.validationStack.Length > 1) ? ValidatorState.Attribute : ValidatorState.TopLevelAttribute;
			this.CheckStateTransition(validatorState, XmlSchemaValidator.MethodNames[(int)validatorState]);
			object obj = null;
			this.attrValid = true;
			XmlSchemaValidity validity = XmlSchemaValidity.NotKnown;
			XmlSchemaAttribute xmlSchemaAttribute = null;
			XmlSchemaSimpleType memberType = null;
			ns = this.nameTable.Add(ns);
			if (Ref.Equal(ns, this.NsXmlNs))
			{
				return null;
			}
			SchemaAttDef schemaAttDef = null;
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(lName, ns);
			if (this.attPresence[xmlQualifiedName] != null)
			{
				this.SendValidationEvent("The '{0}' attribute has already been validated and is a duplicate attribute.", xmlQualifiedName.ToString());
				if (schemaInfo != null)
				{
					schemaInfo.Clear();
				}
				return null;
			}
			if (!Ref.Equal(ns, this.NsXsi))
			{
				XmlSchemaObject xmlSchemaObject = (this.currentState == ValidatorState.TopLevelAttribute) ? this.partialValidationType : null;
				AttributeMatchState attributeMatchState;
				schemaAttDef = this.compiledSchemaInfo.GetAttributeXsd(elementDecl, xmlQualifiedName, xmlSchemaObject, out attributeMatchState);
				switch (attributeMatchState)
				{
				case AttributeMatchState.AttributeFound:
					break;
				case AttributeMatchState.AnyIdAttributeFound:
					if (this.wildID != null)
					{
						this.SendValidationEvent("It is an error if more than one attribute whose type is xs:ID or is derived from xs:ID, matches an attribute wildcard on an element.", string.Empty);
						goto IL_3F5;
					}
					this.wildID = schemaAttDef;
					if ((elementDecl.SchemaType as XmlSchemaComplexType).ContainsIdAttribute(false))
					{
						this.SendValidationEvent("It is an error if there is a member of the attribute uses of a type definition with type xs:ID or derived from xs:ID and another attribute with type xs:ID matches an attribute wildcard.", string.Empty);
						goto IL_3F5;
					}
					break;
				case AttributeMatchState.UndeclaredElementAndAttribute:
					if ((schemaAttDef = this.CheckIsXmlAttribute(xmlQualifiedName)) == null)
					{
						if (elementDecl == null && this.processContents == XmlSchemaContentProcessing.Strict && xmlQualifiedName.Namespace.Length != 0 && this.compiledSchemaInfo.Contains(xmlQualifiedName.Namespace))
						{
							this.attrValid = false;
							this.SendValidationEvent("The '{0}' attribute is not declared.", xmlQualifiedName.ToString());
							goto IL_3F5;
						}
						if (this.processContents != XmlSchemaContentProcessing.Skip)
						{
							this.SendValidationEvent("Could not find schema information for the attribute '{0}'.", xmlQualifiedName.ToString(), XmlSeverityType.Warning);
							goto IL_3F5;
						}
						goto IL_3F5;
					}
					break;
				case AttributeMatchState.UndeclaredAttribute:
					if ((schemaAttDef = this.CheckIsXmlAttribute(xmlQualifiedName)) == null)
					{
						this.attrValid = false;
						this.SendValidationEvent("The '{0}' attribute is not declared.", xmlQualifiedName.ToString());
						goto IL_3F5;
					}
					break;
				case AttributeMatchState.AnyAttributeLax:
					this.SendValidationEvent("Could not find schema information for the attribute '{0}'.", xmlQualifiedName.ToString(), XmlSeverityType.Warning);
					goto IL_3F5;
				case AttributeMatchState.AnyAttributeSkip:
					goto IL_3F5;
				case AttributeMatchState.ProhibitedAnyAttribute:
					if ((schemaAttDef = this.CheckIsXmlAttribute(xmlQualifiedName)) == null)
					{
						this.attrValid = false;
						this.SendValidationEvent("The '{0}' attribute is not allowed.", xmlQualifiedName.ToString());
						goto IL_3F5;
					}
					break;
				case AttributeMatchState.ProhibitedAttribute:
					this.attrValid = false;
					this.SendValidationEvent("The '{0}' attribute is not allowed.", xmlQualifiedName.ToString());
					goto IL_3F5;
				case AttributeMatchState.AttributeNameMismatch:
					this.attrValid = false;
					this.SendValidationEvent("The attribute name '{0}' does not match the name '{1}' of the 'XmlSchemaAttribute' set as a partial validation type.", new string[]
					{
						xmlQualifiedName.ToString(),
						((XmlSchemaAttribute)xmlSchemaObject).QualifiedName.ToString()
					});
					goto IL_3F5;
				case AttributeMatchState.ValidateAttributeInvalidCall:
					this.currentState = ValidatorState.Start;
					this.attrValid = false;
					this.SendValidationEvent("If the partial validation type is 'XmlSchemaElement' or 'XmlSchemaType', the 'ValidateAttribute' method cannot be called.", string.Empty);
					goto IL_3F5;
				default:
					goto IL_3F5;
				}
				xmlSchemaAttribute = schemaAttDef.SchemaAttribute;
				if (elementDecl != null)
				{
					this.attPresence.Add(xmlQualifiedName, schemaAttDef);
				}
				object obj2;
				if (attributeValueGetter != null)
				{
					obj2 = attributeValueGetter();
				}
				else
				{
					obj2 = attributeStringValue;
				}
				obj = this.CheckAttributeValue(obj2, schemaAttDef);
				XmlSchemaDatatype datatype = schemaAttDef.Datatype;
				if (datatype.Variety == XmlSchemaDatatypeVariety.Union && obj != null)
				{
					XsdSimpleValue xsdSimpleValue = obj as XsdSimpleValue;
					memberType = xsdSimpleValue.XmlType;
					datatype = xsdSimpleValue.XmlType.Datatype;
					obj = xsdSimpleValue.TypedValue;
				}
				this.CheckTokenizedTypes(datatype, obj, true);
				if (this.HasIdentityConstraints)
				{
					this.AttributeIdentityConstraints(xmlQualifiedName.Name, xmlQualifiedName.Namespace, obj, obj2.ToString(), datatype);
				}
			}
			else
			{
				lName = this.nameTable.Add(lName);
				if (Ref.Equal(lName, this.xsiTypeString) || Ref.Equal(lName, this.xsiNilString) || Ref.Equal(lName, this.xsiSchemaLocationString) || Ref.Equal(lName, this.xsiNoNamespaceSchemaLocationString))
				{
					this.attPresence.Add(xmlQualifiedName, SchemaAttDef.Empty);
				}
				else
				{
					this.attrValid = false;
					this.SendValidationEvent("The attribute '{0}' does not match one of the four allowed attributes in the 'xsi' namespace.", xmlQualifiedName.ToString());
				}
			}
			IL_3F5:
			if (!this.attrValid)
			{
				validity = XmlSchemaValidity.Invalid;
			}
			else if (schemaAttDef != null)
			{
				validity = XmlSchemaValidity.Valid;
			}
			if (schemaInfo != null)
			{
				schemaInfo.SchemaAttribute = xmlSchemaAttribute;
				schemaInfo.SchemaType = ((xmlSchemaAttribute == null) ? null : xmlSchemaAttribute.AttributeSchemaType);
				schemaInfo.MemberType = memberType;
				schemaInfo.IsDefault = false;
				schemaInfo.Validity = validity;
			}
			if (this.ProcessSchemaHints && this.validatedNamespaces[ns] == null)
			{
				this.validatedNamespaces.Add(ns, ns);
			}
			return obj;
		}

		/// <summary>Verifies whether all the required attributes in the element context are present and prepares the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object to validate the child content of the element.</summary>
		/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set on successful verification that all the required attributes in the element context are present. This parameter can be <see langword="null" />.</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">One or more of the required attributes in the current element context were not found.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.Xml.Schema.XmlSchemaValidator.ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo)" /> method was not called in the correct sequence. For example, calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo)" /> after calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">One or more of the parameters specified are <see langword="null" />.</exception>
		// Token: 0x06001ABB RID: 6843 RVA: 0x0009BB08 File Offset: 0x00099D08
		public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo)
		{
			this.CheckStateTransition(ValidatorState.EndOfAttributes, XmlSchemaValidator.MethodNames[6]);
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			if (elementDecl != null && elementDecl.HasRequiredAttribute)
			{
				this.context.CheckRequiredAttribute = false;
				this.CheckRequiredAttributes(elementDecl);
			}
			if (schemaInfo != null)
			{
				schemaInfo.Validity = this.context.Validity;
			}
		}

		/// <summary>Validates whether the text returned by the <see cref="T:System.Xml.Schema.XmlValueGetter" /> object specified is allowed in the current element context, and accumulates the text for validation if the current element has simple content.</summary>
		/// <param name="elementValue">An <see cref="T:System.Xml.Schema.XmlValueGetter" /><see langword="delegate" /> used to pass the text value as a Common Language Runtime (CLR) type compatible with the XML Schema Definition Language (XSD) type of the attribute.</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The text <see langword="string" /> specified is not allowed in the current element context.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateText" /> method was not called in the correct sequence. For example, the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateText" /> method is called after calling <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The text <see langword="string" /> parameter cannot be <see langword="null" />.</exception>
		// Token: 0x06001ABC RID: 6844 RVA: 0x0009BB61 File Offset: 0x00099D61
		public void ValidateText(XmlValueGetter elementValue)
		{
			if (elementValue == null)
			{
				throw new ArgumentNullException("elementValue");
			}
			this.ValidateText(null, elementValue);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0009BB7C File Offset: 0x00099D7C
		private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter)
		{
			ValidatorState validatorState = (this.validationStack.Length > 1) ? ValidatorState.Text : ValidatorState.TopLevelTextOrWS;
			this.CheckStateTransition(validatorState, XmlSchemaValidator.MethodNames[(int)validatorState]);
			if (this.context.NeedValidateChildren)
			{
				if (this.context.IsNill)
				{
					this.SendValidationEvent("Element '{0}' must have no character or element children.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
					return;
				}
				switch (this.context.ElementDecl.ContentValidator.ContentType)
				{
				case XmlSchemaContentType.TextOnly:
					if (elementValueGetter != null)
					{
						this.SaveTextValue(elementValueGetter());
						return;
					}
					this.SaveTextValue(elementStringValue);
					return;
				case XmlSchemaContentType.Empty:
					this.SendValidationEvent("The element cannot contain text. Content model is empty.", string.Empty);
					return;
				case XmlSchemaContentType.ElementOnly:
				{
					string str = (elementValueGetter != null) ? elementValueGetter().ToString() : elementStringValue;
					if (!this.xmlCharType.IsOnlyWhitespace(str))
					{
						ArrayList arrayList = this.context.ElementDecl.ContentValidator.ExpectedParticles(this.context, false, this.schemaSet);
						if (arrayList == null || arrayList.Count == 0)
						{
							this.SendValidationEvent("The element {0} cannot contain text.", XmlSchemaValidator.BuildElementName(this.context.LocalName, this.context.Namespace));
							return;
						}
						this.SendValidationEvent("The element {0} cannot contain text. List of possible elements expected: {1}.", new string[]
						{
							XmlSchemaValidator.BuildElementName(this.context.LocalName, this.context.Namespace),
							XmlSchemaValidator.PrintExpectedElements(arrayList, true)
						});
						return;
					}
					break;
				}
				case XmlSchemaContentType.Mixed:
					if (this.context.ElementDecl.DefaultValueTyped != null)
					{
						if (elementValueGetter != null)
						{
							this.SaveTextValue(elementValueGetter());
							return;
						}
						this.SaveTextValue(elementStringValue);
					}
					break;
				default:
					return;
				}
			}
		}

		/// <summary>Validates whether the white space returned by the <see cref="T:System.Xml.Schema.XmlValueGetter" /> object specified is allowed in the current element context, and accumulates the white space for validation if the current element has simple content.</summary>
		/// <param name="elementValue">An <see cref="T:System.Xml.Schema.XmlValueGetter" /><see langword="delegate" /> used to pass the white space value as a Common Language Runtime (CLR) type compatible with the XML Schema Definition Language (XSD) type of the attribute.</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">White space is not allowed in the current element context.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateWhitespace" /> method was not called in the correct sequence. For example, if the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateWhitespace" /> method is called after calling <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" />.</exception>
		// Token: 0x06001ABE RID: 6846 RVA: 0x0009BD1F File Offset: 0x00099F1F
		public void ValidateWhitespace(XmlValueGetter elementValue)
		{
			if (elementValue == null)
			{
				throw new ArgumentNullException("elementValue");
			}
			this.ValidateWhitespace(null, elementValue);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0009BD38 File Offset: 0x00099F38
		private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter)
		{
			ValidatorState validatorState = (this.validationStack.Length > 1) ? ValidatorState.Whitespace : ValidatorState.TopLevelTextOrWS;
			this.CheckStateTransition(validatorState, XmlSchemaValidator.MethodNames[(int)validatorState]);
			if (this.context.NeedValidateChildren)
			{
				if (this.context.IsNill)
				{
					this.SendValidationEvent("Element '{0}' must have no character or element children.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
				}
				switch (this.context.ElementDecl.ContentValidator.ContentType)
				{
				case XmlSchemaContentType.TextOnly:
					if (elementValueGetter != null)
					{
						this.SaveTextValue(elementValueGetter());
						return;
					}
					this.SaveTextValue(elementStringValue);
					return;
				case XmlSchemaContentType.Empty:
					this.SendValidationEvent("The element cannot contain white space. Content model is empty.", string.Empty);
					return;
				case XmlSchemaContentType.ElementOnly:
					break;
				case XmlSchemaContentType.Mixed:
					if (this.context.ElementDecl.DefaultValueTyped != null)
					{
						if (elementValueGetter != null)
						{
							this.SaveTextValue(elementValueGetter());
							return;
						}
						this.SaveTextValue(elementStringValue);
					}
					break;
				default:
					return;
				}
			}
		}

		/// <summary>Verifies if the text content of the element is valid according to its data type for elements with simple content, and verifies if the content of the current element is complete for elements with complex content.</summary>
		/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set on successful validation of the element. This parameter can be <see langword="null" />.</param>
		/// <returns>The parsed, typed text value of the element if the element has simple content.</returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The element's content is not valid.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateEndElement" /> method was not called in the correct sequence. For example, if the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateEndElement" /> method is called after calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" />.</exception>
		// Token: 0x06001AC0 RID: 6848 RVA: 0x0009BE28 File Offset: 0x0009A028
		public object ValidateEndElement(XmlSchemaInfo schemaInfo)
		{
			return this.InternalValidateEndElement(schemaInfo, null);
		}

		/// <summary>Skips validation of the current element content and prepares the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object to validate content in the parent element's context.</summary>
		/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set if the current element content is successfully skipped. This parameter can be <see langword="null" />.</param>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" /> method was not called in the correct sequence. For example, calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" /> after calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" />.</exception>
		// Token: 0x06001AC1 RID: 6849 RVA: 0x0009BE34 File Offset: 0x0009A034
		public void SkipToEndElement(XmlSchemaInfo schemaInfo)
		{
			if (this.validationStack.Length <= 1)
			{
				throw new InvalidOperationException(Res.GetString("The call to the '{0}' method does not match a corresponding call to 'ValidateElement' method.", new object[]
				{
					XmlSchemaValidator.MethodNames[10]
				}));
			}
			this.CheckStateTransition(ValidatorState.SkipToEndElement, XmlSchemaValidator.MethodNames[10]);
			if (schemaInfo != null)
			{
				SchemaElementDecl elementDecl = this.context.ElementDecl;
				if (elementDecl != null)
				{
					schemaInfo.SchemaType = elementDecl.SchemaType;
					schemaInfo.SchemaElement = this.GetSchemaElement();
				}
				else
				{
					schemaInfo.SchemaType = null;
					schemaInfo.SchemaElement = null;
				}
				schemaInfo.MemberType = null;
				schemaInfo.IsNil = this.context.IsNill;
				schemaInfo.IsDefault = this.context.IsDefault;
				schemaInfo.Validity = this.context.Validity;
			}
			this.context.ValidationSkipped = true;
			this.currentState = ValidatorState.SkipToEndElement;
			this.Pop();
		}

		/// <summary>Ends validation and checks identity constraints for the entire XML document.</summary>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">An identity constraint error was found in the XML document.</exception>
		// Token: 0x06001AC2 RID: 6850 RVA: 0x0009BF0E File Offset: 0x0009A10E
		public void EndValidation()
		{
			if (this.validationStack.Length > 1)
			{
				throw new InvalidOperationException(Res.GetString("The 'EndValidation' method cannot not be called when all the elements have not been validated. 'ValidateEndElement' calls corresponding to 'ValidateElement' calls might be missing."));
			}
			this.CheckStateTransition(ValidatorState.Finish, XmlSchemaValidator.MethodNames[11]);
			this.CheckForwardRefs();
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0009BF44 File Offset: 0x0009A144
		internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData)
		{
			this.currentState = ValidatorState.Attribute;
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			if (elementDecl != null && elementDecl.HasDefaultAttribute)
			{
				for (int i = 0; i < elementDecl.DefaultAttDefs.Count; i++)
				{
					SchemaAttDef schemaAttDef = (SchemaAttDef)elementDecl.DefaultAttDefs[i];
					if (!this.attPresence.Contains(schemaAttDef.Name) && schemaAttDef.DefaultValueTyped != null)
					{
						string text = this.nameTable.Add(schemaAttDef.Name.Namespace);
						string text2 = string.Empty;
						if (text.Length > 0)
						{
							text2 = this.GetDefaultAttributePrefix(text);
							if (text2 == null || text2.Length == 0)
							{
								this.SendValidationEvent("Default attribute '{0}' for element '{1}' could not be applied as the attribute namespace is not mapped to a prefix in the instance document.", new string[]
								{
									schemaAttDef.Name.ToString(),
									XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace)
								});
								goto IL_242;
							}
						}
						XmlSchemaDatatype datatype = schemaAttDef.Datatype;
						if (createNodeData)
						{
							ValidatingReaderNodeData validatingReaderNodeData = new ValidatingReaderNodeData();
							validatingReaderNodeData.LocalName = this.nameTable.Add(schemaAttDef.Name.Name);
							validatingReaderNodeData.Namespace = text;
							validatingReaderNodeData.Prefix = this.nameTable.Add(text2);
							validatingReaderNodeData.NodeType = XmlNodeType.Attribute;
							AttributePSVIInfo attributePSVIInfo = new AttributePSVIInfo();
							XmlSchemaInfo attributeSchemaInfo = attributePSVIInfo.attributeSchemaInfo;
							if (schemaAttDef.Datatype.Variety == XmlSchemaDatatypeVariety.Union)
							{
								XsdSimpleValue xsdSimpleValue = schemaAttDef.DefaultValueTyped as XsdSimpleValue;
								attributeSchemaInfo.MemberType = xsdSimpleValue.XmlType;
								datatype = xsdSimpleValue.XmlType.Datatype;
								attributePSVIInfo.typedAttributeValue = xsdSimpleValue.TypedValue;
							}
							else
							{
								attributePSVIInfo.typedAttributeValue = schemaAttDef.DefaultValueTyped;
							}
							attributeSchemaInfo.IsDefault = true;
							attributeSchemaInfo.Validity = XmlSchemaValidity.Valid;
							attributeSchemaInfo.SchemaType = schemaAttDef.SchemaType;
							attributeSchemaInfo.SchemaAttribute = schemaAttDef.SchemaAttribute;
							validatingReaderNodeData.RawValue = attributeSchemaInfo.XmlType.ValueConverter.ToString(attributePSVIInfo.typedAttributeValue);
							validatingReaderNodeData.AttInfo = attributePSVIInfo;
							defaultAttributes.Add(validatingReaderNodeData);
						}
						else
						{
							defaultAttributes.Add(schemaAttDef.SchemaAttribute);
						}
						this.CheckTokenizedTypes(datatype, schemaAttDef.DefaultValueTyped, true);
						if (this.HasIdentityConstraints)
						{
							this.AttributeIdentityConstraints(schemaAttDef.Name.Name, schemaAttDef.Name.Namespace, schemaAttDef.DefaultValueTyped, schemaAttDef.DefaultValueRaw, datatype);
						}
					}
					IL_242:;
				}
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0009C1A8 File Offset: 0x0009A3A8
		internal XmlSchemaSet SchemaSet
		{
			get
			{
				return this.schemaSet;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0009C1B0 File Offset: 0x0009A3B0
		internal XmlSchemaValidationFlags ValidationFlags
		{
			get
			{
				return this.validationFlags;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0009C1B8 File Offset: 0x0009A3B8
		internal XmlSchemaContentType CurrentContentType
		{
			get
			{
				if (this.context.ElementDecl == null)
				{
					return XmlSchemaContentType.Empty;
				}
				return this.context.ElementDecl.ContentValidator.ContentType;
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0009C1DE File Offset: 0x0009A3DE
		internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo)
		{
			this.dtdSchemaInfo = dtdSchemaInfo;
			this.checkEntity = true;
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0009C1EE File Offset: 0x0009A3EE
		private bool StrictlyAssessed
		{
			get
			{
				return (this.processContents == XmlSchemaContentProcessing.Strict || this.processContents == XmlSchemaContentProcessing.Lax) && this.context.ElementDecl != null && !this.context.ValidationSkipped;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0009C21F File Offset: 0x0009A41F
		private bool HasSchema
		{
			get
			{
				if (this.isRoot)
				{
					this.isRoot = false;
					if (!this.compiledSchemaInfo.Contains(this.context.Namespace))
					{
						this.rootHasSchema = false;
					}
				}
				return this.rootHasSchema;
			}
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0009C255 File Offset: 0x0009A455
		internal string GetConcatenatedValue()
		{
			return this.textValue.ToString();
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0009C264 File Offset: 0x0009A464
		private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue)
		{
			if (this.validationStack.Length <= 1)
			{
				throw new InvalidOperationException(Res.GetString("The call to the '{0}' method does not match a corresponding call to 'ValidateElement' method.", new object[]
				{
					XmlSchemaValidator.MethodNames[9]
				}));
			}
			this.CheckStateTransition(ValidatorState.EndElement, XmlSchemaValidator.MethodNames[9]);
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			XmlSchemaSimpleType xmlSchemaSimpleType = null;
			XmlSchemaType schemaType = null;
			XmlSchemaElement schemaElement = null;
			string text = string.Empty;
			if (elementDecl != null)
			{
				if (this.context.CheckRequiredAttribute && elementDecl.HasRequiredAttribute)
				{
					this.CheckRequiredAttributes(elementDecl);
				}
				if (!this.context.IsNill && this.context.NeedValidateChildren)
				{
					switch (elementDecl.ContentValidator.ContentType)
					{
					case XmlSchemaContentType.TextOnly:
						if (typedValue == null)
						{
							text = this.textValue.ToString();
							typedValue = this.ValidateAtomicValue(text, out xmlSchemaSimpleType);
						}
						else
						{
							typedValue = this.ValidateAtomicValue(typedValue, out xmlSchemaSimpleType);
						}
						break;
					case XmlSchemaContentType.ElementOnly:
						if (typedValue != null)
						{
							throw new InvalidOperationException(Res.GetString("It is invalid to call the 'ValidateEndElement' overload that takes in a 'typedValue' for elements with complex content."));
						}
						break;
					case XmlSchemaContentType.Mixed:
						if (elementDecl.DefaultValueTyped != null && typedValue == null)
						{
							text = this.textValue.ToString();
							typedValue = this.CheckMixedValueConstraint(text);
						}
						break;
					}
					if (!elementDecl.ContentValidator.CompleteValidation(this.context))
					{
						XmlSchemaValidator.CompleteValidationError(this.context, this.eventHandler, this.nsResolver, this.sourceUriString, this.positionInfo.LineNumber, this.positionInfo.LinePosition, this.schemaSet);
						this.context.Validity = XmlSchemaValidity.Invalid;
					}
				}
				if (this.HasIdentityConstraints)
				{
					XmlSchemaType xmlSchemaType = (xmlSchemaSimpleType == null) ? elementDecl.SchemaType : xmlSchemaSimpleType;
					this.EndElementIdentityConstraints(typedValue, text, xmlSchemaType.Datatype);
				}
				schemaType = elementDecl.SchemaType;
				schemaElement = this.GetSchemaElement();
			}
			if (schemaInfo != null)
			{
				schemaInfo.SchemaType = schemaType;
				schemaInfo.SchemaElement = schemaElement;
				schemaInfo.MemberType = xmlSchemaSimpleType;
				schemaInfo.IsNil = this.context.IsNill;
				schemaInfo.IsDefault = this.context.IsDefault;
				if (this.context.Validity == XmlSchemaValidity.NotKnown && this.StrictlyAssessed)
				{
					this.context.Validity = XmlSchemaValidity.Valid;
				}
				schemaInfo.Validity = this.context.Validity;
			}
			this.Pop();
			return typedValue;
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0009C494 File Offset: 0x0009A694
		private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
		{
			bool flag = false;
			if (xsiNoNamespaceSchemaLocation != null)
			{
				flag = true;
				this.LoadSchema(string.Empty, xsiNoNamespaceSchemaLocation);
			}
			if (xsiSchemaLocation != null)
			{
				object obj;
				Exception ex = XmlSchemaValidator.dtStringArray.TryParseValue(xsiSchemaLocation, this.nameTable, this.nsResolver, out obj);
				if (ex != null)
				{
					this.SendValidationEvent("The attribute '{0}' has an invalid value '{1}' according to its schema type '{2}' - {3}", new string[]
					{
						"schemaLocation",
						xsiSchemaLocation,
						XmlSchemaValidator.dtStringArray.TypeCodeString,
						ex.Message
					}, ex);
					return;
				}
				string[] array = (string[])obj;
				flag = true;
				try
				{
					for (int i = 0; i < array.Length - 1; i += 2)
					{
						this.LoadSchema(array[i], array[i + 1]);
					}
				}
				catch (XmlSchemaException e)
				{
					this.SendValidationEvent(e);
				}
			}
			if (flag)
			{
				this.RecompileSchemaSet();
			}
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0009C560 File Offset: 0x0009A760
		private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext)
		{
			object obj = null;
			int num = 0;
			invalidElementInContext = false;
			if (this.context.NeedValidateChildren)
			{
				if (this.context.IsNill)
				{
					this.SendValidationEvent("Element '{0}' must have no character or element children.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
					return null;
				}
				if (this.context.ElementDecl.ContentValidator.ContentType == XmlSchemaContentType.Mixed && this.context.ElementDecl.Presence == SchemaDeclBase.Use.Fixed)
				{
					this.SendValidationEvent("Although the '{0}' element's content type is mixed, it cannot have element children, because it has a fixed value constraint in the schema.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
					return null;
				}
				XmlQualifiedName xmlQualifiedName = elementName;
				bool flag = false;
				for (;;)
				{
					obj = this.context.ElementDecl.ContentValidator.ValidateElement(xmlQualifiedName, this.context, out num);
					if (obj != null)
					{
						goto IL_111;
					}
					if (num == -2)
					{
						break;
					}
					flag = true;
					XmlSchemaElement substitutionGroupHead = this.GetSubstitutionGroupHead(xmlQualifiedName);
					if (substitutionGroupHead == null)
					{
						goto IL_111;
					}
					xmlQualifiedName = substitutionGroupHead.QualifiedName;
				}
				this.SendValidationEvent("Element '{0}' cannot appear more than once if content model type is \"all\".", elementName.ToString());
				invalidElementInContext = true;
				this.processContents = (this.context.ProcessContents = XmlSchemaContentProcessing.Skip);
				return null;
				IL_111:
				if (flag)
				{
					XmlSchemaElement xmlSchemaElement = obj as XmlSchemaElement;
					if (xmlSchemaElement == null)
					{
						obj = null;
					}
					else if (xmlSchemaElement.RefName.IsEmpty)
					{
						this.SendValidationEvent("The element {0} cannot substitute for a local element {1} expected in that position.", XmlSchemaValidator.BuildElementName(elementName), XmlSchemaValidator.BuildElementName(xmlSchemaElement.QualifiedName));
						invalidElementInContext = true;
						this.processContents = (this.context.ProcessContents = XmlSchemaContentProcessing.Skip);
					}
					else
					{
						obj = this.compiledSchemaInfo.GetElement(elementName);
						this.context.NeedValidateChildren = true;
					}
				}
				if (obj == null)
				{
					XmlSchemaValidator.ElementValidationError(elementName, this.context, this.eventHandler, this.nsResolver, this.sourceUriString, this.positionInfo.LineNumber, this.positionInfo.LinePosition, this.schemaSet);
					invalidElementInContext = true;
					this.processContents = (this.context.ProcessContents = XmlSchemaContentProcessing.Skip);
				}
			}
			return obj;
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0009C74C File Offset: 0x0009A94C
		private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member)
		{
			XmlSchemaElement element = this.compiledSchemaInfo.GetElement(member);
			if (element != null)
			{
				XmlQualifiedName substitutionGroup = element.SubstitutionGroup;
				if (!substitutionGroup.IsEmpty)
				{
					XmlSchemaElement element2 = this.compiledSchemaInfo.GetElement(substitutionGroup);
					if (element2 != null)
					{
						if ((element2.BlockResolved & XmlSchemaDerivationMethod.Substitution) != XmlSchemaDerivationMethod.Empty)
						{
							this.SendValidationEvent("Element '{0}' cannot substitute in place of head element '{1}' because it has block='substitution'.", new string[]
							{
								member.ToString(),
								substitutionGroup.ToString()
							});
							return null;
						}
						if (!XmlSchemaType.IsDerivedFrom(element.ElementSchemaType, element2.ElementSchemaType, element2.BlockResolved))
						{
							this.SendValidationEvent("Member element {0}'s type cannot be derived by restriction or extension from head element {1}'s type, because it has block='restriction' or 'extension'.", new string[]
							{
								member.ToString(),
								substitutionGroup.ToString()
							});
							return null;
						}
						return element2;
					}
				}
			}
			return null;
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0009C7FC File Offset: 0x0009A9FC
		private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType)
		{
			object obj = null;
			memberType = null;
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			if (!this.context.IsNill)
			{
				if (stringValue.Length == 0 && elementDecl.DefaultValueTyped != null)
				{
					SchemaElementDecl elementDeclBeforeXsi = this.context.ElementDeclBeforeXsi;
					if (elementDeclBeforeXsi != null && elementDeclBeforeXsi != elementDecl)
					{
						if (elementDecl.Datatype.TryParseValue(elementDecl.DefaultValueRaw, this.nameTable, this.nsResolver, out obj) != null)
						{
							this.SendValidationEvent("The default value '{0}' of element '{1}' is invalid according to the type specified by xsi:type.", new string[]
							{
								elementDecl.DefaultValueRaw,
								XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace)
							});
						}
						else
						{
							this.context.IsDefault = true;
						}
					}
					else
					{
						this.context.IsDefault = true;
						obj = elementDecl.DefaultValueTyped;
					}
				}
				else
				{
					obj = this.CheckElementValue(stringValue);
				}
				XsdSimpleValue xsdSimpleValue = obj as XsdSimpleValue;
				XmlSchemaDatatype datatype = elementDecl.Datatype;
				if (xsdSimpleValue != null)
				{
					memberType = xsdSimpleValue.XmlType;
					obj = xsdSimpleValue.TypedValue;
					datatype = memberType.Datatype;
				}
				this.CheckTokenizedTypes(datatype, obj, false);
			}
			return obj;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0009C910 File Offset: 0x0009AB10
		private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType)
		{
			memberType = null;
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			object obj = null;
			if (!this.context.IsNill)
			{
				SchemaDeclBase schemaDeclBase = elementDecl;
				XmlSchemaDatatype datatype = elementDecl.Datatype;
				Exception ex = datatype.TryParseValue(parsedValue, this.nameTable, this.nsResolver, out obj);
				if (ex != null)
				{
					string text = parsedValue as string;
					if (text == null)
					{
						text = XmlSchemaDatatype.ConcatenatedToString(parsedValue);
					}
					this.SendValidationEvent("The '{0}' element is invalid - The value '{1}' is invalid according to its datatype '{2}' - {3}", new string[]
					{
						XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace),
						text,
						this.GetTypeName(schemaDeclBase),
						ex.Message
					}, ex);
					return null;
				}
				if (!schemaDeclBase.CheckValue(obj))
				{
					this.SendValidationEvent("The value of the '{0}' element does not equal its fixed value.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
				}
				if (datatype.Variety == XmlSchemaDatatypeVariety.Union)
				{
					XsdSimpleValue xsdSimpleValue = obj as XsdSimpleValue;
					memberType = xsdSimpleValue.XmlType;
					obj = xsdSimpleValue.TypedValue;
					datatype = memberType.Datatype;
				}
				this.CheckTokenizedTypes(datatype, obj, false);
			}
			return obj;
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0009CA28 File Offset: 0x0009AC28
		private string GetTypeName(SchemaDeclBase decl)
		{
			string text = decl.SchemaType.QualifiedName.ToString();
			if (text.Length == 0)
			{
				text = decl.Datatype.TypeCodeString;
			}
			return text;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0009CA5C File Offset: 0x0009AC5C
		private void SaveTextValue(object value)
		{
			string value2 = value.ToString();
			this.textValue.Append(value2);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0009CA80 File Offset: 0x0009AC80
		private void Push(XmlQualifiedName elementName)
		{
			this.context = (ValidationState)this.validationStack.Push();
			if (this.context == null)
			{
				this.context = new ValidationState();
				this.validationStack.AddToTop(this.context);
			}
			this.context.LocalName = elementName.Name;
			this.context.Namespace = elementName.Namespace;
			this.context.HasMatched = false;
			this.context.IsNill = false;
			this.context.IsDefault = false;
			this.context.CheckRequiredAttribute = true;
			this.context.ValidationSkipped = false;
			this.context.Validity = XmlSchemaValidity.NotKnown;
			this.context.NeedValidateChildren = false;
			this.context.ProcessContents = this.processContents;
			this.context.ElementDeclBeforeXsi = null;
			this.context.Constr = null;
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0009CB68 File Offset: 0x0009AD68
		private void Pop()
		{
			ValidationState validationState = (ValidationState)this.validationStack.Pop();
			if (this.startIDConstraint == this.validationStack.Length)
			{
				this.startIDConstraint = -1;
			}
			this.context = (ValidationState)this.validationStack.Peek();
			if (validationState.Validity == XmlSchemaValidity.Invalid)
			{
				this.context.Validity = XmlSchemaValidity.Invalid;
			}
			if (validationState.ValidationSkipped)
			{
				this.context.ValidationSkipped = true;
			}
			this.processContents = this.context.ProcessContents;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0009CBF0 File Offset: 0x0009ADF0
		private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle)
		{
			SchemaElementDecl schemaElementDecl = null;
			if (particle != null)
			{
				XmlSchemaElement xmlSchemaElement = particle as XmlSchemaElement;
				if (xmlSchemaElement != null)
				{
					schemaElementDecl = xmlSchemaElement.ElementDecl;
				}
				else
				{
					XmlSchemaAny xmlSchemaAny = (XmlSchemaAny)particle;
					this.processContents = xmlSchemaAny.ProcessContentsCorrect;
				}
			}
			if (schemaElementDecl == null && this.processContents != XmlSchemaContentProcessing.Skip)
			{
				if (this.isRoot && this.partialValidationType != null)
				{
					if (this.partialValidationType is XmlSchemaElement)
					{
						XmlSchemaElement xmlSchemaElement2 = (XmlSchemaElement)this.partialValidationType;
						if (elementName.Equals(xmlSchemaElement2.QualifiedName))
						{
							schemaElementDecl = xmlSchemaElement2.ElementDecl;
						}
						else
						{
							this.SendValidationEvent("The element name '{0}' does not match the name '{1}' of the 'XmlSchemaElement' set as a partial validation type.", elementName.ToString(), xmlSchemaElement2.QualifiedName.ToString());
						}
					}
					else if (this.partialValidationType is XmlSchemaType)
					{
						schemaElementDecl = ((XmlSchemaType)this.partialValidationType).ElementDecl;
					}
					else
					{
						this.SendValidationEvent("If the partial validation type is 'XmlSchemaAttribute', the 'ValidateElement' method cannot be called.", string.Empty);
					}
				}
				else
				{
					schemaElementDecl = this.compiledSchemaInfo.GetElementDecl(elementName);
				}
			}
			return schemaElementDecl;
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0009CCE0 File Offset: 0x0009AEE0
		private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound)
		{
			XmlQualifiedName xmlQualifiedName = XmlQualifiedName.Empty;
			if (xsiType != null)
			{
				object obj = null;
				Exception ex = XmlSchemaValidator.dtQName.TryParseValue(xsiType, this.nameTable, this.nsResolver, out obj);
				if (ex != null)
				{
					this.SendValidationEvent("The attribute '{0}' has an invalid value '{1}' according to its schema type '{2}' - {3}", new string[]
					{
						"type",
						xsiType,
						XmlSchemaValidator.dtQName.TypeCodeString,
						ex.Message
					}, ex);
				}
				else
				{
					xmlQualifiedName = (obj as XmlQualifiedName);
				}
			}
			if (elementDecl != null)
			{
				if (elementDecl.IsNillable)
				{
					if (xsiNil != null)
					{
						this.context.IsNill = XmlConvert.ToBoolean(xsiNil);
						if (this.context.IsNill && elementDecl.Presence == SchemaDeclBase.Use.Fixed)
						{
							this.SendValidationEvent("There must be no fixed value when an attribute is 'xsi:nil' and has a value of 'true'.");
						}
					}
				}
				else if (xsiNil != null)
				{
					this.SendValidationEvent("If the 'nillable' attribute is false in the schema, the 'xsi:nil' attribute must not be present in the instance.");
				}
			}
			if (xmlQualifiedName.IsEmpty)
			{
				if (elementDecl != null && elementDecl.IsAbstract)
				{
					this.SendValidationEvent("The element '{0}' is abstract or its type is abstract.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
					elementDecl = null;
				}
			}
			else
			{
				SchemaElementDecl schemaElementDecl = this.compiledSchemaInfo.GetTypeDecl(xmlQualifiedName);
				XmlSeverityType severity = XmlSeverityType.Warning;
				if (this.HasSchema && this.processContents == XmlSchemaContentProcessing.Strict)
				{
					severity = XmlSeverityType.Error;
				}
				if (schemaElementDecl == null && xmlQualifiedName.Namespace == this.NsXs)
				{
					XmlSchemaType xmlSchemaType = DatatypeImplementation.GetSimpleTypeFromXsdType(xmlQualifiedName);
					if (xmlSchemaType == null)
					{
						xmlSchemaType = XmlSchemaType.GetBuiltInComplexType(xmlQualifiedName);
					}
					if (xmlSchemaType != null)
					{
						schemaElementDecl = xmlSchemaType.ElementDecl;
					}
				}
				if (schemaElementDecl == null)
				{
					this.SendValidationEvent("This is an invalid xsi:type '{0}'.", xmlQualifiedName.ToString(), severity);
					elementDecl = null;
				}
				else
				{
					declFound = true;
					if (schemaElementDecl.IsAbstract)
					{
						this.SendValidationEvent("The xsi:type '{0}' cannot be abstract.", xmlQualifiedName.ToString(), severity);
						elementDecl = null;
					}
					else if (elementDecl != null && !XmlSchemaType.IsDerivedFrom(schemaElementDecl.SchemaType, elementDecl.SchemaType, elementDecl.Block))
					{
						this.SendValidationEvent("The xsi:type attribute value '{0}' is not valid for the element '{1}', either because it is not a type validly derived from the type in the schema, or because it has xsi:type derivation blocked.", new string[]
						{
							xmlQualifiedName.ToString(),
							XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace)
						});
						elementDecl = null;
					}
					else
					{
						if (elementDecl != null)
						{
							schemaElementDecl = schemaElementDecl.Clone();
							schemaElementDecl.Constraints = elementDecl.Constraints;
							schemaElementDecl.DefaultValueRaw = elementDecl.DefaultValueRaw;
							schemaElementDecl.DefaultValueTyped = elementDecl.DefaultValueTyped;
							schemaElementDecl.Block = elementDecl.Block;
						}
						this.context.ElementDeclBeforeXsi = elementDecl;
						elementDecl = schemaElementDecl;
					}
				}
			}
			return elementDecl;
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0009CF2C File Offset: 0x0009B12C
		private void ThrowDeclNotFoundWarningOrError(bool declFound)
		{
			if (declFound)
			{
				this.processContents = (this.context.ProcessContents = XmlSchemaContentProcessing.Skip);
				this.context.NeedValidateChildren = false;
				return;
			}
			if (this.HasSchema && this.processContents == XmlSchemaContentProcessing.Strict)
			{
				this.processContents = (this.context.ProcessContents = XmlSchemaContentProcessing.Skip);
				this.context.NeedValidateChildren = false;
				this.SendValidationEvent("The '{0}' element is not declared.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
				return;
			}
			this.SendValidationEvent("Could not find schema information for the element '{0}'.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace), XmlSeverityType.Warning);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0009CFDE File Offset: 0x0009B1DE
		private void CheckElementProperties()
		{
			if (this.context.ElementDecl.IsAbstract)
			{
				this.SendValidationEvent("The element '{0}' is abstract or its type is abstract.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0009D018 File Offset: 0x0009B218
		private void ValidateStartElementIdentityConstraints()
		{
			if (this.ProcessIdentityConstraints && this.context.ElementDecl.Constraints != null)
			{
				this.AddIdentityConstraints();
			}
			if (this.HasIdentityConstraints)
			{
				this.ElementIdentityConstraints();
			}
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0009D048 File Offset: 0x0009B248
		private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName)
		{
			SchemaAttDef result = null;
			if (Ref.Equal(attQName.Namespace, this.NsXml) && (this.validationFlags & XmlSchemaValidationFlags.AllowXmlAttributes) != XmlSchemaValidationFlags.None)
			{
				if (!this.compiledSchemaInfo.Contains(this.NsXml))
				{
					this.AddXmlNamespaceSchema();
				}
				this.compiledSchemaInfo.AttributeDecls.TryGetValue(attQName, out result);
			}
			return result;
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0009D0A4 File Offset: 0x0009B2A4
		private void AddXmlNamespaceSchema()
		{
			XmlSchemaSet xmlSchemaSet = new XmlSchemaSet();
			xmlSchemaSet.Add(Preprocessor.GetBuildInSchema());
			xmlSchemaSet.Compile();
			this.schemaSet.Add(xmlSchemaSet);
			this.RecompileSchemaSet();
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0009D0DC File Offset: 0x0009B2DC
		internal object CheckMixedValueConstraint(string elementValue)
		{
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			if (this.context.IsNill)
			{
				return null;
			}
			if (elementValue.Length == 0)
			{
				this.context.IsDefault = true;
				return elementDecl.DefaultValueTyped;
			}
			if (elementDecl.Presence == SchemaDeclBase.Use.Fixed && !elementValue.Equals(elementDecl.DefaultValueRaw))
			{
				this.SendValidationEvent("The value of the '{0}' element does not equal its fixed value.", elementDecl.Name.ToString());
			}
			return elementValue;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0009D150 File Offset: 0x0009B350
		private void LoadSchema(string uri, string url)
		{
			XmlReader xmlReader = null;
			try
			{
				Uri uri2 = this.xmlResolver.ResolveUri(this.sourceUri, url);
				Stream input = (Stream)this.xmlResolver.GetEntity(uri2, null, null);
				XmlReaderSettings readerSettings = this.schemaSet.ReaderSettings;
				readerSettings.CloseInput = true;
				readerSettings.XmlResolver = this.xmlResolver;
				xmlReader = XmlReader.Create(input, readerSettings, uri2.ToString());
				this.schemaSet.Add(uri, xmlReader, this.validatedNamespaces);
				while (xmlReader.Read())
				{
				}
			}
			catch (XmlSchemaException ex)
			{
				this.SendValidationEvent("Cannot load the schema for the namespace '{0}' - {1}", new string[]
				{
					uri,
					ex.Message
				}, ex);
			}
			catch (Exception ex2)
			{
				this.SendValidationEvent("Cannot load the schema for the namespace '{0}' - {1}", new string[]
				{
					uri,
					ex2.Message
				}, ex2, XmlSeverityType.Warning);
			}
			finally
			{
				if (xmlReader != null)
				{
					xmlReader.Close();
				}
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0009D248 File Offset: 0x0009B448
		internal void RecompileSchemaSet()
		{
			if (!this.schemaSet.IsCompiled)
			{
				try
				{
					this.schemaSet.Compile();
				}
				catch (XmlSchemaException e)
				{
					this.SendValidationEvent(e);
				}
			}
			this.compiledSchemaInfo = this.schemaSet.CompiledInfo;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0009D29C File Offset: 0x0009B49C
		private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue)
		{
			switch (ttype)
			{
			case XmlTokenizedType.ID:
				if (this.ProcessIdentityConstraints)
				{
					if (this.FindId(name) != null)
					{
						if (attrValue)
						{
							this.attrValid = false;
						}
						this.SendValidationEvent("'{0}' is already used as an ID.", name);
						return;
					}
					if (this.IDs == null)
					{
						this.IDs = new Hashtable();
					}
					this.IDs.Add(name, this.context.LocalName);
					return;
				}
				break;
			case XmlTokenizedType.IDREF:
				if (this.ProcessIdentityConstraints && this.FindId(name) == null)
				{
					this.idRefListHead = new IdRefNode(this.idRefListHead, name, this.positionInfo.LineNumber, this.positionInfo.LinePosition);
					return;
				}
				break;
			case XmlTokenizedType.IDREFS:
				break;
			case XmlTokenizedType.ENTITY:
				this.ProcessEntity(name);
				break;
			default:
				return;
			}
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0009D35C File Offset: 0x0009B55C
		private object CheckAttributeValue(object value, SchemaAttDef attdef)
		{
			object obj = null;
			XmlSchemaDatatype datatype = attdef.Datatype;
			string text = value as string;
			Exception ex;
			if (text != null)
			{
				ex = datatype.TryParseValue(text, this.nameTable, this.nsResolver, out obj);
				if (ex != null)
				{
					goto IL_78;
				}
			}
			else
			{
				ex = datatype.TryParseValue(value, this.nameTable, this.nsResolver, out obj);
				if (ex != null)
				{
					goto IL_78;
				}
			}
			if (!attdef.CheckValue(obj))
			{
				this.attrValid = false;
				this.SendValidationEvent("The value of the '{0}' attribute does not equal its fixed value.", attdef.Name.ToString());
			}
			return obj;
			IL_78:
			this.attrValid = false;
			if (text == null)
			{
				text = XmlSchemaDatatype.ConcatenatedToString(value);
			}
			this.SendValidationEvent("The '{0}' attribute is invalid - The value '{1}' is invalid according to its datatype '{2}' - {3}", new string[]
			{
				attdef.Name.ToString(),
				text,
				this.GetTypeName(attdef),
				ex.Message
			}, ex);
			return null;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0009D42C File Offset: 0x0009B62C
		private object CheckElementValue(string stringValue)
		{
			object obj = null;
			SchemaDeclBase elementDecl = this.context.ElementDecl;
			Exception ex = elementDecl.Datatype.TryParseValue(stringValue, this.nameTable, this.nsResolver, out obj);
			if (ex != null)
			{
				this.SendValidationEvent("The '{0}' element is invalid - The value '{1}' is invalid according to its datatype '{2}' - {3}", new string[]
				{
					XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace),
					stringValue,
					this.GetTypeName(elementDecl),
					ex.Message
				}, ex);
				return null;
			}
			if (!elementDecl.CheckValue(obj))
			{
				this.SendValidationEvent("The value of the '{0}' element does not equal its fixed value.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
			}
			return obj;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0009D4E0 File Offset: 0x0009B6E0
		private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue)
		{
			if (typedValue == null)
			{
				return;
			}
			XmlTokenizedType tokenizedType = dtype.TokenizedType;
			if (tokenizedType == XmlTokenizedType.ENTITY || tokenizedType == XmlTokenizedType.ID || tokenizedType == XmlTokenizedType.IDREF)
			{
				if (dtype.Variety == XmlSchemaDatatypeVariety.List)
				{
					string[] array = (string[])typedValue;
					for (int i = 0; i < array.Length; i++)
					{
						this.ProcessTokenizedType(dtype.TokenizedType, array[i], attrValue);
					}
					return;
				}
				this.ProcessTokenizedType(dtype.TokenizedType, (string)typedValue, attrValue);
			}
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0009D546 File Offset: 0x0009B746
		private object FindId(string name)
		{
			if (this.IDs != null)
			{
				return this.IDs[name];
			}
			return null;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0009D560 File Offset: 0x0009B760
		private void CheckForwardRefs()
		{
			IdRefNode next;
			for (IdRefNode idRefNode = this.idRefListHead; idRefNode != null; idRefNode = next)
			{
				if (this.FindId(idRefNode.Id) == null)
				{
					this.SendValidationEvent(new XmlSchemaValidationException("Reference to undeclared ID is '{0}'.", idRefNode.Id, this.sourceUriString, idRefNode.LineNo, idRefNode.LinePos), XmlSeverityType.Error);
				}
				next = idRefNode.Next;
				idRefNode.Next = null;
			}
			this.idRefListHead = null;
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0009D5C5 File Offset: 0x0009B7C5
		private bool HasIdentityConstraints
		{
			get
			{
				return this.ProcessIdentityConstraints && this.startIDConstraint != -1;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0009D5DD File Offset: 0x0009B7DD
		internal bool ProcessIdentityConstraints
		{
			get
			{
				return (this.validationFlags & XmlSchemaValidationFlags.ProcessIdentityConstraints) > XmlSchemaValidationFlags.None;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0009D5EA File Offset: 0x0009B7EA
		internal bool ReportValidationWarnings
		{
			get
			{
				return (this.validationFlags & XmlSchemaValidationFlags.ReportValidationWarnings) > XmlSchemaValidationFlags.None;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0009D5F7 File Offset: 0x0009B7F7
		internal bool ProcessSchemaHints
		{
			get
			{
				return (this.validationFlags & XmlSchemaValidationFlags.ProcessInlineSchema) != XmlSchemaValidationFlags.None || (this.validationFlags & XmlSchemaValidationFlags.ProcessSchemaLocation) > XmlSchemaValidationFlags.None;
			}
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0009D610 File Offset: 0x0009B810
		private void CheckStateTransition(ValidatorState toState, string methodName)
		{
			if (XmlSchemaValidator.ValidStates[(int)this.currentState, (int)toState])
			{
				this.currentState = toState;
				return;
			}
			object[] args;
			if (this.currentState == ValidatorState.None)
			{
				string name = "It is invalid to call the '{0}' method in the current state of the validator. The '{1}' method must be called before proceeding with validation.";
				args = new string[]
				{
					methodName,
					XmlSchemaValidator.MethodNames[1]
				};
				throw new InvalidOperationException(Res.GetString(name, args));
			}
			string name2 = "The transition from the '{0}' method to the '{1}' method is not allowed.";
			args = new string[]
			{
				XmlSchemaValidator.MethodNames[(int)this.currentState],
				methodName
			};
			throw new InvalidOperationException(Res.GetString(name2, args));
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0009D690 File Offset: 0x0009B890
		private void ClearPSVI()
		{
			if (this.textValue != null)
			{
				this.textValue.Length = 0;
			}
			this.attPresence.Clear();
			this.wildID = null;
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0009D6B8 File Offset: 0x0009B8B8
		private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl)
		{
			foreach (SchemaAttDef schemaAttDef in currentElementDecl.AttDefs.Values)
			{
				if (this.attPresence[schemaAttDef.Name] == null && (schemaAttDef.Presence == SchemaDeclBase.Use.Required || schemaAttDef.Presence == SchemaDeclBase.Use.RequiredFixed))
				{
					this.SendValidationEvent("The required attribute '{0}' is missing.", schemaAttDef.Name.ToString());
				}
			}
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0009D744 File Offset: 0x0009B944
		private XmlSchemaElement GetSchemaElement()
		{
			SchemaElementDecl elementDeclBeforeXsi = this.context.ElementDeclBeforeXsi;
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			if (elementDeclBeforeXsi != null && elementDeclBeforeXsi.SchemaElement != null)
			{
				XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)elementDeclBeforeXsi.SchemaElement.Clone(null);
				xmlSchemaElement.SchemaTypeName = XmlQualifiedName.Empty;
				xmlSchemaElement.SchemaType = elementDecl.SchemaType;
				xmlSchemaElement.SetElementType(elementDecl.SchemaType);
				xmlSchemaElement.ElementDecl = elementDecl;
				return xmlSchemaElement;
			}
			return elementDecl.SchemaElement;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0009D7B8 File Offset: 0x0009B9B8
		internal string GetDefaultAttributePrefix(string attributeNS)
		{
			IEnumerable<KeyValuePair<string, string>> namespacesInScope = this.nsResolver.GetNamespacesInScope(XmlNamespaceScope.All);
			string text = null;
			foreach (KeyValuePair<string, string> keyValuePair in namespacesInScope)
			{
				if (Ref.Equal(this.nameTable.Add(keyValuePair.Value), attributeNS))
				{
					text = keyValuePair.Key;
					if (text.Length != 0)
					{
						return text;
					}
				}
			}
			return text;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0009D838 File Offset: 0x0009BA38
		private void AddIdentityConstraints()
		{
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			this.context.Constr = new ConstraintStruct[elementDecl.Constraints.Length];
			int num = 0;
			for (int i = 0; i < elementDecl.Constraints.Length; i++)
			{
				this.context.Constr[num++] = new ConstraintStruct(elementDecl.Constraints[i]);
			}
			for (int j = 0; j < this.context.Constr.Length; j++)
			{
				if (this.context.Constr[j].constraint.Role == CompiledIdentityConstraint.ConstraintRole.Keyref)
				{
					bool flag = false;
					for (int k = this.validationStack.Length - 1; k >= ((this.startIDConstraint >= 0) ? this.startIDConstraint : (this.validationStack.Length - 1)); k--)
					{
						if (((ValidationState)this.validationStack[k]).Constr != null)
						{
							ConstraintStruct[] constr = ((ValidationState)this.validationStack[k]).Constr;
							for (int l = 0; l < constr.Length; l++)
							{
								if (constr[l].constraint.name == this.context.Constr[j].constraint.refer)
								{
									flag = true;
									if (constr[l].keyrefTable == null)
									{
										constr[l].keyrefTable = new Hashtable();
									}
									this.context.Constr[j].qualifiedTable = constr[l].keyrefTable;
									break;
								}
							}
							if (flag)
							{
								break;
							}
						}
					}
					if (!flag)
					{
						this.SendValidationEvent("The Keyref '{0}' cannot find the referred key or unique in scope.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
					}
				}
			}
			if (this.startIDConstraint == -1)
			{
				this.startIDConstraint = this.validationStack.Length - 1;
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0009DA14 File Offset: 0x0009BC14
		private void ElementIdentityConstraints()
		{
			SchemaElementDecl elementDecl = this.context.ElementDecl;
			string localName = this.context.LocalName;
			string @namespace = this.context.Namespace;
			for (int i = this.startIDConstraint; i < this.validationStack.Length; i++)
			{
				if (((ValidationState)this.validationStack[i]).Constr != null)
				{
					ConstraintStruct[] constr = ((ValidationState)this.validationStack[i]).Constr;
					for (int j = 0; j < constr.Length; j++)
					{
						if (constr[j].axisSelector.MoveToStartElement(localName, @namespace))
						{
							constr[j].axisSelector.PushKS(this.positionInfo.LineNumber, this.positionInfo.LinePosition);
						}
						for (int k = 0; k < constr[j].axisFields.Count; k++)
						{
							LocatedActiveAxis locatedActiveAxis = (LocatedActiveAxis)constr[j].axisFields[k];
							if (locatedActiveAxis.MoveToStartElement(localName, @namespace) && elementDecl != null)
							{
								if (elementDecl.Datatype == null || elementDecl.ContentValidator.ContentType == XmlSchemaContentType.Mixed)
								{
									this.SendValidationEvent("The field '{0}' is expecting an element or attribute with simple type or simple content.", localName);
								}
								else
								{
									locatedActiveAxis.isMatched = true;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0009DB5C File Offset: 0x0009BD5C
		private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype)
		{
			for (int i = this.startIDConstraint; i < this.validationStack.Length; i++)
			{
				if (((ValidationState)this.validationStack[i]).Constr != null)
				{
					ConstraintStruct[] constr = ((ValidationState)this.validationStack[i]).Constr;
					for (int j = 0; j < constr.Length; j++)
					{
						for (int k = 0; k < constr[j].axisFields.Count; k++)
						{
							LocatedActiveAxis locatedActiveAxis = (LocatedActiveAxis)constr[j].axisFields[k];
							if (locatedActiveAxis.MoveToAttribute(name, ns))
							{
								if (locatedActiveAxis.Ks[locatedActiveAxis.Column] != null)
								{
									this.SendValidationEvent("The field '{0}' is expecting at the most one value.", name);
								}
								else
								{
									locatedActiveAxis.Ks[locatedActiveAxis.Column] = new TypedObject(obj, sobj, datatype);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0009DC48 File Offset: 0x0009BE48
		private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype)
		{
			string localName = this.context.LocalName;
			string @namespace = this.context.Namespace;
			for (int i = this.validationStack.Length - 1; i >= this.startIDConstraint; i--)
			{
				if (((ValidationState)this.validationStack[i]).Constr != null)
				{
					ConstraintStruct[] constr = ((ValidationState)this.validationStack[i]).Constr;
					for (int j = 0; j < constr.Length; j++)
					{
						for (int k = 0; k < constr[j].axisFields.Count; k++)
						{
							LocatedActiveAxis locatedActiveAxis = (LocatedActiveAxis)constr[j].axisFields[k];
							if (locatedActiveAxis.isMatched)
							{
								locatedActiveAxis.isMatched = false;
								if (locatedActiveAxis.Ks[locatedActiveAxis.Column] != null)
								{
									this.SendValidationEvent("The field '{0}' is expecting at the most one value.", localName);
								}
								else if (LocalAppContextSwitches.IgnoreEmptyKeySequences)
								{
									if (typedValue != null && stringValue.Length != 0)
									{
										locatedActiveAxis.Ks[locatedActiveAxis.Column] = new TypedObject(typedValue, stringValue, datatype);
									}
								}
								else if (typedValue != null)
								{
									locatedActiveAxis.Ks[locatedActiveAxis.Column] = new TypedObject(typedValue, stringValue, datatype);
								}
							}
							locatedActiveAxis.EndElement(localName, @namespace);
						}
						if (constr[j].axisSelector.EndElement(localName, @namespace))
						{
							KeySequence keySequence = constr[j].axisSelector.PopKS();
							switch (constr[j].constraint.Role)
							{
							case CompiledIdentityConstraint.ConstraintRole.Unique:
								if (keySequence.IsQualified())
								{
									if (constr[j].qualifiedTable.Contains(keySequence))
									{
										this.SendValidationEvent(new XmlSchemaValidationException("There is a duplicate key sequence '{0}' for the '{1}' key or unique identity constraint.", new string[]
										{
											keySequence.ToString(),
											constr[j].constraint.name.ToString()
										}, this.sourceUriString, keySequence.PosLine, keySequence.PosCol));
									}
									else
									{
										constr[j].qualifiedTable.Add(keySequence, keySequence);
									}
								}
								break;
							case CompiledIdentityConstraint.ConstraintRole.Key:
								if (!keySequence.IsQualified())
								{
									this.SendValidationEvent(new XmlSchemaValidationException("The identity constraint '{0}' validation has failed. Either a key is missing or the existing key has an empty node.", constr[j].constraint.name.ToString(), this.sourceUriString, keySequence.PosLine, keySequence.PosCol));
								}
								else if (constr[j].qualifiedTable.Contains(keySequence))
								{
									this.SendValidationEvent(new XmlSchemaValidationException("There is a duplicate key sequence '{0}' for the '{1}' key or unique identity constraint.", new string[]
									{
										keySequence.ToString(),
										constr[j].constraint.name.ToString()
									}, this.sourceUriString, keySequence.PosLine, keySequence.PosCol));
								}
								else
								{
									constr[j].qualifiedTable.Add(keySequence, keySequence);
								}
								break;
							case CompiledIdentityConstraint.ConstraintRole.Keyref:
								if (constr[j].qualifiedTable != null && keySequence.IsQualified() && !constr[j].qualifiedTable.Contains(keySequence))
								{
									constr[j].qualifiedTable.Add(keySequence, keySequence);
								}
								break;
							}
						}
					}
				}
			}
			ConstraintStruct[] constr2 = ((ValidationState)this.validationStack[this.validationStack.Length - 1]).Constr;
			if (constr2 != null)
			{
				for (int l = 0; l < constr2.Length; l++)
				{
					if (constr2[l].constraint.Role != CompiledIdentityConstraint.ConstraintRole.Keyref && constr2[l].keyrefTable != null)
					{
						foreach (object obj in constr2[l].keyrefTable.Keys)
						{
							KeySequence keySequence2 = (KeySequence)obj;
							if (!constr2[l].qualifiedTable.Contains(keySequence2))
							{
								this.SendValidationEvent(new XmlSchemaValidationException("The key sequence '{0}' in '{1}' Keyref fails to refer to some key.", new string[]
								{
									keySequence2.ToString(),
									constr2[l].constraint.name.ToString()
								}, this.sourceUriString, keySequence2.PosLine, keySequence2.PosCol));
							}
						}
					}
				}
			}
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0009E084 File Offset: 0x0009C284
		internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
		{
			if (context.ElementDecl != null)
			{
				ContentValidator contentValidator = context.ElementDecl.ContentValidator;
				XmlSchemaContentType contentType = contentValidator.ContentType;
				if (contentType == XmlSchemaContentType.ElementOnly || (contentType == XmlSchemaContentType.Mixed && contentValidator != ContentValidator.Mixed && contentValidator != ContentValidator.Any))
				{
					bool flag = schemaSet != null;
					ArrayList arrayList;
					if (flag)
					{
						arrayList = contentValidator.ExpectedParticles(context, false, schemaSet);
					}
					else
					{
						arrayList = contentValidator.ExpectedElements(context, false);
					}
					if (arrayList == null || arrayList.Count == 0)
					{
						if (context.TooComplex)
						{
							XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element {0} has invalid child element {1} - {2}", new string[]
							{
								XmlSchemaValidator.BuildElementName(context.LocalName, context.Namespace),
								XmlSchemaValidator.BuildElementName(name),
								Res.GetString("Content model validation resulted in a large number of states, possibly due to large occurrence ranges. Therefore, content model may not be validated accurately.")
							}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
							return;
						}
						XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element {0} has invalid child element {1}.", new string[]
						{
							XmlSchemaValidator.BuildElementName(context.LocalName, context.Namespace),
							XmlSchemaValidator.BuildElementName(name)
						}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
						return;
					}
					else
					{
						if (context.TooComplex)
						{
							XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element {0} has invalid child element {1}. List of possible elements expected: {2}. {3}", new string[]
							{
								XmlSchemaValidator.BuildElementName(context.LocalName, context.Namespace),
								XmlSchemaValidator.BuildElementName(name),
								XmlSchemaValidator.PrintExpectedElements(arrayList, flag),
								Res.GetString("Content model validation resulted in a large number of states, possibly due to large occurrence ranges. Therefore, content model may not be validated accurately.")
							}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
							return;
						}
						XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element {0} has invalid child element {1}. List of possible elements expected: {2}.", new string[]
						{
							XmlSchemaValidator.BuildElementName(context.LocalName, context.Namespace),
							XmlSchemaValidator.BuildElementName(name),
							XmlSchemaValidator.PrintExpectedElements(arrayList, flag)
						}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
						return;
					}
				}
				else
				{
					if (contentType == XmlSchemaContentType.Empty)
					{
						XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element '{0}' cannot contain child element '{1}' because the parent element's content model is empty.", new string[]
						{
							XmlSchemaValidator.QNameString(context.LocalName, context.Namespace),
							name.ToString()
						}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
						return;
					}
					if (!contentValidator.IsOpen)
					{
						XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element '{0}' cannot contain child element '{1}' because the parent element's content model is text only.", new string[]
						{
							XmlSchemaValidator.QNameString(context.LocalName, context.Namespace),
							name.ToString()
						}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
					}
				}
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0009E2B0 File Offset: 0x0009C4B0
		internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
		{
			ArrayList arrayList = null;
			bool flag = schemaSet != null;
			if (context.ElementDecl != null)
			{
				if (flag)
				{
					arrayList = context.ElementDecl.ContentValidator.ExpectedParticles(context, true, schemaSet);
				}
				else
				{
					arrayList = context.ElementDecl.ContentValidator.ExpectedElements(context, true);
				}
			}
			if (arrayList == null || arrayList.Count == 0)
			{
				if (context.TooComplex)
				{
					XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element {0} has incomplete content - {2}", new string[]
					{
						XmlSchemaValidator.BuildElementName(context.LocalName, context.Namespace),
						Res.GetString("Content model validation resulted in a large number of states, possibly due to large occurrence ranges. Therefore, content model may not be validated accurately.")
					}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
				}
				XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element {0} has incomplete content.", XmlSchemaValidator.BuildElementName(context.LocalName, context.Namespace), sourceUri, lineNo, linePos), XmlSeverityType.Error);
				return;
			}
			if (context.TooComplex)
			{
				XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element {0} has incomplete content. List of possible elements expected: {1}. {2}", new string[]
				{
					XmlSchemaValidator.BuildElementName(context.LocalName, context.Namespace),
					XmlSchemaValidator.PrintExpectedElements(arrayList, flag),
					Res.GetString("Content model validation resulted in a large number of states, possibly due to large occurrence ranges. Therefore, content model may not be validated accurately.")
				}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
				return;
			}
			XmlSchemaValidator.SendValidationEvent(eventHandler, sender, new XmlSchemaValidationException("The element {0} has incomplete content. List of possible elements expected: {1}.", new string[]
			{
				XmlSchemaValidator.BuildElementName(context.LocalName, context.Namespace),
				XmlSchemaValidator.PrintExpectedElements(arrayList, flag)
			}, sourceUri, lineNo, linePos), XmlSeverityType.Error);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0009E400 File Offset: 0x0009C600
		internal static string PrintExpectedElements(ArrayList expected, bool getParticles)
		{
			if (getParticles)
			{
				string name = "{0}as well as";
				object[] args = new string[]
				{
					" "
				};
				string @string = Res.GetString(name, args);
				XmlSchemaParticle xmlSchemaParticle = null;
				ArrayList arrayList = new ArrayList();
				StringBuilder stringBuilder = new StringBuilder();
				if (expected.Count == 1)
				{
					xmlSchemaParticle = (expected[0] as XmlSchemaParticle);
				}
				else
				{
					for (int i = 1; i < expected.Count; i++)
					{
						XmlSchemaParticle xmlSchemaParticle2 = expected[i - 1] as XmlSchemaParticle;
						xmlSchemaParticle = (expected[i] as XmlSchemaParticle);
						XmlQualifiedName qualifiedName = xmlSchemaParticle2.GetQualifiedName();
						if (qualifiedName.Namespace != xmlSchemaParticle.GetQualifiedName().Namespace)
						{
							arrayList.Add(qualifiedName);
							XmlSchemaValidator.PrintNamesWithNS(arrayList, stringBuilder);
							arrayList.Clear();
							stringBuilder.Append(@string);
						}
						else
						{
							arrayList.Add(qualifiedName);
						}
					}
				}
				arrayList.Add(xmlSchemaParticle.GetQualifiedName());
				XmlSchemaValidator.PrintNamesWithNS(arrayList, stringBuilder);
				return stringBuilder.ToString();
			}
			return XmlSchemaValidator.PrintNames(expected);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0009E4F4 File Offset: 0x0009C6F4
		private static string PrintNames(ArrayList expected)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("'");
			stringBuilder.Append(expected[0].ToString());
			for (int i = 1; i < expected.Count; i++)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(expected[i].ToString());
			}
			stringBuilder.Append("'");
			return stringBuilder.ToString();
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0009E568 File Offset: 0x0009C768
		private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder)
		{
			XmlQualifiedName xmlQualifiedName = expected[0] as XmlQualifiedName;
			if (expected.Count == 1)
			{
				if (xmlQualifiedName.Name == "*")
				{
					XmlSchemaValidator.EnumerateAny(builder, xmlQualifiedName.Namespace);
					return;
				}
				if (xmlQualifiedName.Namespace.Length != 0)
				{
					builder.Append(Res.GetString("'{0}' in namespace '{1}'", new object[]
					{
						xmlQualifiedName.Name,
						xmlQualifiedName.Namespace
					}));
					return;
				}
				builder.Append(Res.GetString("'{0}'", new object[]
				{
					xmlQualifiedName.Name
				}));
				return;
			}
			else
			{
				bool flag = false;
				bool flag2 = true;
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < expected.Count; i++)
				{
					xmlQualifiedName = (expected[i] as XmlQualifiedName);
					if (xmlQualifiedName.Name == "*")
					{
						flag = true;
					}
					else
					{
						if (flag2)
						{
							flag2 = false;
						}
						else
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append(xmlQualifiedName.Name);
					}
				}
				if (flag)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append(Res.GetString("any element"));
					return;
				}
				if (xmlQualifiedName.Namespace.Length != 0)
				{
					builder.Append(Res.GetString("'{0}' in namespace '{1}'", new object[]
					{
						stringBuilder.ToString(),
						xmlQualifiedName.Namespace
					}));
					return;
				}
				builder.Append(Res.GetString("'{0}'", new object[]
				{
					stringBuilder.ToString()
				}));
				return;
			}
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0009E6E0 File Offset: 0x0009C8E0
		private static void EnumerateAny(StringBuilder builder, string namespaces)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (namespaces == "##any" || namespaces == "##other")
			{
				stringBuilder.Append(namespaces);
			}
			else
			{
				string[] array = XmlConvert.SplitString(namespaces);
				stringBuilder.Append(array[0]);
				for (int i = 1; i < array.Length; i++)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append(array[i]);
				}
			}
			builder.Append(Res.GetString("any element in namespace '{0}'", new object[]
			{
				stringBuilder.ToString()
			}));
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0009E76C File Offset: 0x0009C96C
		internal static string QNameString(string localName, string ns)
		{
			if (ns.Length == 0)
			{
				return localName;
			}
			return ns + ":" + localName;
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0009E784 File Offset: 0x0009C984
		internal static string BuildElementName(XmlQualifiedName qname)
		{
			return XmlSchemaValidator.BuildElementName(qname.Name, qname.Namespace);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0009E797 File Offset: 0x0009C997
		internal static string BuildElementName(string localName, string ns)
		{
			if (ns.Length != 0)
			{
				return Res.GetString("'{0}' in namespace '{1}'", new object[]
				{
					localName,
					ns
				});
			}
			return Res.GetString("'{0}'", new object[]
			{
				localName
			});
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0009E7D0 File Offset: 0x0009C9D0
		private void ProcessEntity(string name)
		{
			if (!this.checkEntity)
			{
				return;
			}
			IDtdEntityInfo dtdEntityInfo = null;
			if (this.dtdSchemaInfo != null)
			{
				dtdEntityInfo = this.dtdSchemaInfo.LookupEntity(name);
			}
			if (dtdEntityInfo == null)
			{
				this.SendValidationEvent("Reference to an undeclared entity, '{0}'.", name);
				return;
			}
			if (dtdEntityInfo.IsUnparsedEntity)
			{
				this.SendValidationEvent("Reference to an unparsed entity, '{0}'.", name);
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0009E821 File Offset: 0x0009CA21
		private void SendValidationEvent(string code)
		{
			this.SendValidationEvent(code, string.Empty);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0009E82F File Offset: 0x0009CA2F
		private void SendValidationEvent(string code, string[] args)
		{
			this.SendValidationEvent(new XmlSchemaValidationException(code, args, this.sourceUriString, this.positionInfo.LineNumber, this.positionInfo.LinePosition));
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0009E85A File Offset: 0x0009CA5A
		private void SendValidationEvent(string code, string arg)
		{
			this.SendValidationEvent(new XmlSchemaValidationException(code, arg, this.sourceUriString, this.positionInfo.LineNumber, this.positionInfo.LinePosition));
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0009E885 File Offset: 0x0009CA85
		private void SendValidationEvent(string code, string arg1, string arg2)
		{
			this.SendValidationEvent(new XmlSchemaValidationException(code, new string[]
			{
				arg1,
				arg2
			}, this.sourceUriString, this.positionInfo.LineNumber, this.positionInfo.LinePosition));
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0009E8BD File Offset: 0x0009CABD
		private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity)
		{
			if (severity != XmlSeverityType.Warning || this.ReportValidationWarnings)
			{
				this.SendValidationEvent(new XmlSchemaValidationException(code, args, innerException, this.sourceUriString, this.positionInfo.LineNumber, this.positionInfo.LinePosition), severity);
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0009E8F8 File Offset: 0x0009CAF8
		private void SendValidationEvent(string code, string[] args, Exception innerException)
		{
			this.SendValidationEvent(new XmlSchemaValidationException(code, args, innerException, this.sourceUriString, this.positionInfo.LineNumber, this.positionInfo.LinePosition), XmlSeverityType.Error);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0009E925 File Offset: 0x0009CB25
		private void SendValidationEvent(XmlSchemaValidationException e)
		{
			this.SendValidationEvent(e, XmlSeverityType.Error);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0009E92F File Offset: 0x0009CB2F
		private void SendValidationEvent(XmlSchemaException e)
		{
			this.SendValidationEvent(new XmlSchemaValidationException(e.GetRes, e.Args, e.SourceUri, e.LineNumber, e.LinePosition), XmlSeverityType.Error);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0009E95B File Offset: 0x0009CB5B
		private void SendValidationEvent(string code, string msg, XmlSeverityType severity)
		{
			if (severity != XmlSeverityType.Warning || this.ReportValidationWarnings)
			{
				this.SendValidationEvent(new XmlSchemaValidationException(code, msg, this.sourceUriString, this.positionInfo.LineNumber, this.positionInfo.LinePosition), severity);
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0009E994 File Offset: 0x0009CB94
		private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity)
		{
			bool flag = false;
			if (severity == XmlSeverityType.Error)
			{
				flag = true;
				this.context.Validity = XmlSchemaValidity.Invalid;
			}
			if (!flag)
			{
				if (this.ReportValidationWarnings && this.eventHandler != null)
				{
					this.eventHandler(this.validationEventSender, new ValidationEventArgs(e, severity));
				}
				return;
			}
			if (this.eventHandler != null)
			{
				this.eventHandler(this.validationEventSender, new ValidationEventArgs(e, severity));
				return;
			}
			throw e;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0009EA02 File Offset: 0x0009CC02
		internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity)
		{
			if (eventHandler != null)
			{
				eventHandler(sender, new ValidationEventArgs(e, severity));
				return;
			}
			if (severity == XmlSeverityType.Error)
			{
				throw e;
			}
		}

		// Token: 0x0400115C RID: 4444
		private XmlSchemaSet schemaSet;

		// Token: 0x0400115D RID: 4445
		private XmlSchemaValidationFlags validationFlags;

		// Token: 0x0400115E RID: 4446
		private int startIDConstraint = -1;

		// Token: 0x0400115F RID: 4447
		private bool isRoot;

		// Token: 0x04001160 RID: 4448
		private bool rootHasSchema;

		// Token: 0x04001161 RID: 4449
		private bool attrValid;

		// Token: 0x04001162 RID: 4450
		private bool checkEntity;

		// Token: 0x04001163 RID: 4451
		private SchemaInfo compiledSchemaInfo;

		// Token: 0x04001164 RID: 4452
		private IDtdInfo dtdSchemaInfo;

		// Token: 0x04001165 RID: 4453
		private Hashtable validatedNamespaces;

		// Token: 0x04001166 RID: 4454
		private HWStack validationStack;

		// Token: 0x04001167 RID: 4455
		private ValidationState context;

		// Token: 0x04001168 RID: 4456
		private ValidatorState currentState;

		// Token: 0x04001169 RID: 4457
		private Hashtable attPresence;

		// Token: 0x0400116A RID: 4458
		private SchemaAttDef wildID;

		// Token: 0x0400116B RID: 4459
		private Hashtable IDs;

		// Token: 0x0400116C RID: 4460
		private IdRefNode idRefListHead;

		// Token: 0x0400116D RID: 4461
		private XmlQualifiedName contextQName;

		// Token: 0x0400116E RID: 4462
		private string NsXs;

		// Token: 0x0400116F RID: 4463
		private string NsXsi;

		// Token: 0x04001170 RID: 4464
		private string NsXmlNs;

		// Token: 0x04001171 RID: 4465
		private string NsXml;

		// Token: 0x04001172 RID: 4466
		private XmlSchemaObject partialValidationType;

		// Token: 0x04001173 RID: 4467
		private StringBuilder textValue;

		// Token: 0x04001174 RID: 4468
		private ValidationEventHandler eventHandler;

		// Token: 0x04001175 RID: 4469
		private object validationEventSender;

		// Token: 0x04001176 RID: 4470
		private XmlNameTable nameTable;

		// Token: 0x04001177 RID: 4471
		private IXmlLineInfo positionInfo;

		// Token: 0x04001178 RID: 4472
		private IXmlLineInfo dummyPositionInfo;

		// Token: 0x04001179 RID: 4473
		private XmlResolver xmlResolver;

		// Token: 0x0400117A RID: 4474
		private Uri sourceUri;

		// Token: 0x0400117B RID: 4475
		private string sourceUriString;

		// Token: 0x0400117C RID: 4476
		private IXmlNamespaceResolver nsResolver;

		// Token: 0x0400117D RID: 4477
		private XmlSchemaContentProcessing processContents = XmlSchemaContentProcessing.Strict;

		// Token: 0x0400117E RID: 4478
		private string xsiTypeString;

		// Token: 0x0400117F RID: 4479
		private string xsiNilString;

		// Token: 0x04001180 RID: 4480
		private string xsiSchemaLocationString;

		// Token: 0x04001181 RID: 4481
		private string xsiNoNamespaceSchemaLocationString;

		// Token: 0x04001182 RID: 4482
		private static readonly XmlSchemaDatatype dtQName = XmlSchemaDatatype.FromXmlTokenizedTypeXsd(XmlTokenizedType.QName);

		// Token: 0x04001183 RID: 4483
		private static readonly XmlSchemaDatatype dtCDATA = XmlSchemaDatatype.FromXmlTokenizedType(XmlTokenizedType.CDATA);

		// Token: 0x04001184 RID: 4484
		private static readonly XmlSchemaDatatype dtStringArray = XmlSchemaValidator.dtCDATA.DeriveByList(null);

		// Token: 0x04001185 RID: 4485
		private static XmlSchemaParticle[] EmptyParticleArray = new XmlSchemaParticle[0];

		// Token: 0x04001186 RID: 4486
		private static XmlSchemaAttribute[] EmptyAttributeArray = new XmlSchemaAttribute[0];

		// Token: 0x04001187 RID: 4487
		private XmlCharType xmlCharType = XmlCharType.Instance;

		// Token: 0x04001188 RID: 4488
		internal static bool[,] ValidStates = new bool[,]
		{
			{
				true,
				true,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false
			},
			{
				false,
				true,
				true,
				true,
				true,
				false,
				false,
				false,
				false,
				false,
				false,
				true
			},
			{
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				true
			},
			{
				false,
				false,
				false,
				true,
				true,
				false,
				false,
				false,
				false,
				false,
				false,
				true
			},
			{
				false,
				false,
				false,
				true,
				false,
				true,
				true,
				false,
				false,
				true,
				true,
				false
			},
			{
				false,
				false,
				false,
				false,
				false,
				true,
				true,
				false,
				false,
				true,
				true,
				false
			},
			{
				false,
				false,
				false,
				false,
				true,
				false,
				false,
				true,
				true,
				true,
				true,
				false
			},
			{
				false,
				false,
				false,
				false,
				true,
				false,
				false,
				true,
				true,
				true,
				true,
				false
			},
			{
				false,
				false,
				false,
				false,
				true,
				false,
				false,
				true,
				true,
				true,
				true,
				false
			},
			{
				false,
				false,
				false,
				true,
				true,
				false,
				false,
				true,
				true,
				true,
				true,
				true
			},
			{
				false,
				false,
				false,
				true,
				true,
				false,
				false,
				true,
				true,
				true,
				true,
				true
			},
			{
				false,
				true,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false,
				false
			}
		};

		// Token: 0x04001189 RID: 4489
		private static string[] MethodNames = new string[]
		{
			"None",
			"Initialize",
			"top-level ValidateAttribute",
			"top-level ValidateText or ValidateWhitespace",
			"ValidateElement",
			"ValidateAttribute",
			"ValidateEndOfAttributes",
			"ValidateText",
			"ValidateWhitespace",
			"ValidateEndElement",
			"SkipToEndElement",
			"EndValidation"
		};
	}
}
