using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000339 RID: 825
	internal sealed class XsdBuilder : SchemaBuilder
	{
		// Token: 0x06001C55 RID: 7253 RVA: 0x000A4290 File Offset: 0x000A2490
		internal XsdBuilder(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
		{
			this.reader = reader;
			this.schema = schema;
			this.xso = schema;
			this.namespaceManager = new XsdBuilder.BuilderNamespaceManager(curmgr, reader);
			this.validationEventHandler = eventhandler;
			this.nameTable = nameTable;
			this.schemaNames = schemaNames;
			this.stateHistory = new HWStack(10);
			this.currentEntry = XsdBuilder.SchemaEntries[0];
			this.positionInfo = PositionInfo.GetPositionInfo(reader);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000A4328 File Offset: 0x000A2528
		internal override bool ProcessElement(string prefix, string name, string ns)
		{
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(name, ns);
			if (this.GetNextState(xmlQualifiedName))
			{
				this.Push();
				this.xso = null;
				this.currentEntry.InitFunc(this, null);
				this.RecordPosition();
				return true;
			}
			if (!this.IsSkipableElement(xmlQualifiedName))
			{
				this.SendValidationEvent("The '{0}' element is not supported in this context.", xmlQualifiedName.ToString());
			}
			return false;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x000A438C File Offset: 0x000A258C
		internal override void ProcessAttribute(string prefix, string name, string ns, string value)
		{
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(name, ns);
			if (this.currentEntry.Attributes != null)
			{
				for (int i = 0; i < this.currentEntry.Attributes.Length; i++)
				{
					XsdBuilder.XsdAttributeEntry xsdAttributeEntry = this.currentEntry.Attributes[i];
					if (this.schemaNames.TokenToQName[(int)xsdAttributeEntry.Attribute].Equals(xmlQualifiedName))
					{
						try
						{
							xsdAttributeEntry.BuildFunc(this, value);
						}
						catch (XmlSchemaException ex)
						{
							ex.SetSource(this.reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition);
							this.SendValidationEvent("The value for the '{0}' attribute is invalid - {1}", new string[]
							{
								name,
								ex.Message
							}, XmlSeverityType.Error);
						}
						return;
					}
				}
			}
			if (!(ns != this.schemaNames.NsXs) || ns.Length == 0)
			{
				this.SendValidationEvent("The '{0}' attribute is not supported in this context.", xmlQualifiedName.ToString());
				return;
			}
			if (ns == this.schemaNames.NsXmlNs)
			{
				if (this.namespaces == null)
				{
					this.namespaces = new Hashtable();
				}
				this.namespaces.Add((name == this.schemaNames.QnXmlNs.Name) ? string.Empty : name, value);
				return;
			}
			XmlAttribute xmlAttribute = new XmlAttribute(prefix, name, ns, this.schema.Document);
			xmlAttribute.Value = value;
			this.unhandledAttributes.Add(xmlAttribute);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x000A4514 File Offset: 0x000A2714
		internal override bool IsContentParsed()
		{
			return this.currentEntry.ParseContent;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x000A4521 File Offset: 0x000A2721
		internal override void ProcessMarkup(XmlNode[] markup)
		{
			this.markup = markup;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x000A452A File Offset: 0x000A272A
		internal override void ProcessCData(string value)
		{
			this.SendValidationEvent("The following text is not allowed in this context: '{0}'.", value);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x000A4538 File Offset: 0x000A2738
		internal override void StartChildren()
		{
			if (this.xso != null)
			{
				if (this.namespaces != null && this.namespaces.Count > 0)
				{
					this.xso.Namespaces.Namespaces = this.namespaces;
					this.namespaces = null;
				}
				if (this.unhandledAttributes.Count != 0)
				{
					this.xso.SetUnhandledAttributes((XmlAttribute[])this.unhandledAttributes.ToArray(typeof(XmlAttribute)));
					this.unhandledAttributes.Clear();
				}
			}
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000A45BD File Offset: 0x000A27BD
		internal override void EndChildren()
		{
			if (this.currentEntry.EndChildFunc != null)
			{
				this.currentEntry.EndChildFunc(this);
			}
			this.Pop();
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000A45E4 File Offset: 0x000A27E4
		private void Push()
		{
			this.stateHistory.Push();
			this.stateHistory[this.stateHistory.Length - 1] = this.currentEntry;
			this.containerStack.Push(this.GetContainer(this.currentEntry.CurrentState));
			this.currentEntry = this.nextEntry;
			if (this.currentEntry.Name != SchemaNames.Token.XsdAnnotation)
			{
				this.hasChild = false;
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000A4659 File Offset: 0x000A2859
		private void Pop()
		{
			this.currentEntry = (XsdBuilder.XsdEntry)this.stateHistory.Pop();
			this.SetContainer(this.currentEntry.CurrentState, this.containerStack.Pop());
			this.hasChild = true;
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x000A4694 File Offset: 0x000A2894
		private SchemaNames.Token CurrentElement
		{
			get
			{
				return this.currentEntry.Name;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x000A46A1 File Offset: 0x000A28A1
		private SchemaNames.Token ParentElement
		{
			get
			{
				return ((XsdBuilder.XsdEntry)this.stateHistory[this.stateHistory.Length - 1]).Name;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x000A46C5 File Offset: 0x000A28C5
		private XmlSchemaObject ParentContainer
		{
			get
			{
				return (XmlSchemaObject)this.containerStack.Peek();
			}
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000A46D8 File Offset: 0x000A28D8
		private XmlSchemaObject GetContainer(XsdBuilder.State state)
		{
			XmlSchemaObject result = null;
			switch (state)
			{
			case XsdBuilder.State.Schema:
				result = this.schema;
				break;
			case XsdBuilder.State.Annotation:
				result = this.annotation;
				break;
			case XsdBuilder.State.Include:
				result = this.include;
				break;
			case XsdBuilder.State.Import:
				result = this.import;
				break;
			case XsdBuilder.State.Element:
				result = this.element;
				break;
			case XsdBuilder.State.Attribute:
				result = this.attribute;
				break;
			case XsdBuilder.State.AttributeGroup:
				result = this.attributeGroup;
				break;
			case XsdBuilder.State.AttributeGroupRef:
				result = this.attributeGroupRef;
				break;
			case XsdBuilder.State.AnyAttribute:
				result = this.anyAttribute;
				break;
			case XsdBuilder.State.Group:
				result = this.group;
				break;
			case XsdBuilder.State.GroupRef:
				result = this.groupRef;
				break;
			case XsdBuilder.State.All:
				result = this.all;
				break;
			case XsdBuilder.State.Choice:
				result = this.choice;
				break;
			case XsdBuilder.State.Sequence:
				result = this.sequence;
				break;
			case XsdBuilder.State.Any:
				result = this.anyElement;
				break;
			case XsdBuilder.State.Notation:
				result = this.notation;
				break;
			case XsdBuilder.State.SimpleType:
				result = this.simpleType;
				break;
			case XsdBuilder.State.ComplexType:
				result = this.complexType;
				break;
			case XsdBuilder.State.ComplexContent:
				result = this.complexContent;
				break;
			case XsdBuilder.State.ComplexContentRestriction:
				result = this.complexContentRestriction;
				break;
			case XsdBuilder.State.ComplexContentExtension:
				result = this.complexContentExtension;
				break;
			case XsdBuilder.State.SimpleContent:
				result = this.simpleContent;
				break;
			case XsdBuilder.State.SimpleContentExtension:
				result = this.simpleContentExtension;
				break;
			case XsdBuilder.State.SimpleContentRestriction:
				result = this.simpleContentRestriction;
				break;
			case XsdBuilder.State.SimpleTypeUnion:
				result = this.simpleTypeUnion;
				break;
			case XsdBuilder.State.SimpleTypeList:
				result = this.simpleTypeList;
				break;
			case XsdBuilder.State.SimpleTypeRestriction:
				result = this.simpleTypeRestriction;
				break;
			case XsdBuilder.State.Unique:
			case XsdBuilder.State.Key:
			case XsdBuilder.State.KeyRef:
				result = this.identityConstraint;
				break;
			case XsdBuilder.State.Selector:
			case XsdBuilder.State.Field:
				result = this.xpath;
				break;
			case XsdBuilder.State.MinExclusive:
			case XsdBuilder.State.MinInclusive:
			case XsdBuilder.State.MaxExclusive:
			case XsdBuilder.State.MaxInclusive:
			case XsdBuilder.State.TotalDigits:
			case XsdBuilder.State.FractionDigits:
			case XsdBuilder.State.Length:
			case XsdBuilder.State.MinLength:
			case XsdBuilder.State.MaxLength:
			case XsdBuilder.State.Enumeration:
			case XsdBuilder.State.Pattern:
			case XsdBuilder.State.WhiteSpace:
				result = this.facet;
				break;
			case XsdBuilder.State.AppInfo:
				result = this.appInfo;
				break;
			case XsdBuilder.State.Documentation:
				result = this.documentation;
				break;
			case XsdBuilder.State.Redefine:
				result = this.redefine;
				break;
			}
			return result;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000A4910 File Offset: 0x000A2B10
		private void SetContainer(XsdBuilder.State state, object container)
		{
			switch (state)
			{
			case XsdBuilder.State.Root:
			case XsdBuilder.State.Schema:
				break;
			case XsdBuilder.State.Annotation:
				this.annotation = (XmlSchemaAnnotation)container;
				return;
			case XsdBuilder.State.Include:
				this.include = (XmlSchemaInclude)container;
				return;
			case XsdBuilder.State.Import:
				this.import = (XmlSchemaImport)container;
				return;
			case XsdBuilder.State.Element:
				this.element = (XmlSchemaElement)container;
				return;
			case XsdBuilder.State.Attribute:
				this.attribute = (XmlSchemaAttribute)container;
				return;
			case XsdBuilder.State.AttributeGroup:
				this.attributeGroup = (XmlSchemaAttributeGroup)container;
				return;
			case XsdBuilder.State.AttributeGroupRef:
				this.attributeGroupRef = (XmlSchemaAttributeGroupRef)container;
				return;
			case XsdBuilder.State.AnyAttribute:
				this.anyAttribute = (XmlSchemaAnyAttribute)container;
				return;
			case XsdBuilder.State.Group:
				this.group = (XmlSchemaGroup)container;
				return;
			case XsdBuilder.State.GroupRef:
				this.groupRef = (XmlSchemaGroupRef)container;
				return;
			case XsdBuilder.State.All:
				this.all = (XmlSchemaAll)container;
				return;
			case XsdBuilder.State.Choice:
				this.choice = (XmlSchemaChoice)container;
				return;
			case XsdBuilder.State.Sequence:
				this.sequence = (XmlSchemaSequence)container;
				return;
			case XsdBuilder.State.Any:
				this.anyElement = (XmlSchemaAny)container;
				return;
			case XsdBuilder.State.Notation:
				this.notation = (XmlSchemaNotation)container;
				return;
			case XsdBuilder.State.SimpleType:
				this.simpleType = (XmlSchemaSimpleType)container;
				return;
			case XsdBuilder.State.ComplexType:
				this.complexType = (XmlSchemaComplexType)container;
				return;
			case XsdBuilder.State.ComplexContent:
				this.complexContent = (XmlSchemaComplexContent)container;
				return;
			case XsdBuilder.State.ComplexContentRestriction:
				this.complexContentRestriction = (XmlSchemaComplexContentRestriction)container;
				return;
			case XsdBuilder.State.ComplexContentExtension:
				this.complexContentExtension = (XmlSchemaComplexContentExtension)container;
				return;
			case XsdBuilder.State.SimpleContent:
				this.simpleContent = (XmlSchemaSimpleContent)container;
				return;
			case XsdBuilder.State.SimpleContentExtension:
				this.simpleContentExtension = (XmlSchemaSimpleContentExtension)container;
				return;
			case XsdBuilder.State.SimpleContentRestriction:
				this.simpleContentRestriction = (XmlSchemaSimpleContentRestriction)container;
				return;
			case XsdBuilder.State.SimpleTypeUnion:
				this.simpleTypeUnion = (XmlSchemaSimpleTypeUnion)container;
				return;
			case XsdBuilder.State.SimpleTypeList:
				this.simpleTypeList = (XmlSchemaSimpleTypeList)container;
				return;
			case XsdBuilder.State.SimpleTypeRestriction:
				this.simpleTypeRestriction = (XmlSchemaSimpleTypeRestriction)container;
				return;
			case XsdBuilder.State.Unique:
			case XsdBuilder.State.Key:
			case XsdBuilder.State.KeyRef:
				this.identityConstraint = (XmlSchemaIdentityConstraint)container;
				return;
			case XsdBuilder.State.Selector:
			case XsdBuilder.State.Field:
				this.xpath = (XmlSchemaXPath)container;
				return;
			case XsdBuilder.State.MinExclusive:
			case XsdBuilder.State.MinInclusive:
			case XsdBuilder.State.MaxExclusive:
			case XsdBuilder.State.MaxInclusive:
			case XsdBuilder.State.TotalDigits:
			case XsdBuilder.State.FractionDigits:
			case XsdBuilder.State.Length:
			case XsdBuilder.State.MinLength:
			case XsdBuilder.State.MaxLength:
			case XsdBuilder.State.Enumeration:
			case XsdBuilder.State.Pattern:
			case XsdBuilder.State.WhiteSpace:
				this.facet = (XmlSchemaFacet)container;
				return;
			case XsdBuilder.State.AppInfo:
				this.appInfo = (XmlSchemaAppInfo)container;
				return;
			case XsdBuilder.State.Documentation:
				this.documentation = (XmlSchemaDocumentation)container;
				return;
			case XsdBuilder.State.Redefine:
				this.redefine = (XmlSchemaRedefine)container;
				break;
			default:
				return;
			}
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000A4B83 File Offset: 0x000A2D83
		private static void BuildAnnotated_Id(XsdBuilder builder, string value)
		{
			builder.xso.IdAttribute = value;
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000A4B91 File Offset: 0x000A2D91
		private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value)
		{
			builder.schema.AttributeFormDefault = (XmlSchemaForm)builder.ParseEnum(value, "attributeFormDefault", XsdBuilder.FormStringValues);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x000A4BAF File Offset: 0x000A2DAF
		private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value)
		{
			builder.schema.ElementFormDefault = (XmlSchemaForm)builder.ParseEnum(value, "elementFormDefault", XsdBuilder.FormStringValues);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x000A4BCD File Offset: 0x000A2DCD
		private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value)
		{
			builder.schema.TargetNamespace = value;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x000A4BDB File Offset: 0x000A2DDB
		private static void BuildSchema_Version(XsdBuilder builder, string value)
		{
			builder.schema.Version = value;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x000A4BE9 File Offset: 0x000A2DE9
		private static void BuildSchema_FinalDefault(XsdBuilder builder, string value)
		{
			builder.schema.FinalDefault = (XmlSchemaDerivationMethod)builder.ParseBlockFinalEnum(value, "finalDefault");
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x000A4C02 File Offset: 0x000A2E02
		private static void BuildSchema_BlockDefault(XsdBuilder builder, string value)
		{
			builder.schema.BlockDefault = (XmlSchemaDerivationMethod)builder.ParseBlockFinalEnum(value, "blockDefault");
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000A4C1B File Offset: 0x000A2E1B
		private static void InitSchema(XsdBuilder builder, string value)
		{
			builder.canIncludeImport = true;
			builder.xso = builder.schema;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x000A4C30 File Offset: 0x000A2E30
		private static void InitInclude(XsdBuilder builder, string value)
		{
			if (!builder.canIncludeImport)
			{
				builder.SendValidationEvent("The 'include' element cannot appear at this location.", null);
			}
			builder.xso = (builder.include = new XmlSchemaInclude());
			builder.schema.Includes.Add(builder.include);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x000A4C7C File Offset: 0x000A2E7C
		private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value)
		{
			builder.include.SchemaLocation = value;
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000A4C8C File Offset: 0x000A2E8C
		private static void InitImport(XsdBuilder builder, string value)
		{
			if (!builder.canIncludeImport)
			{
				builder.SendValidationEvent("The 'import' element cannot appear at this location.", null);
			}
			builder.xso = (builder.import = new XmlSchemaImport());
			builder.schema.Includes.Add(builder.import);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000A4CD8 File Offset: 0x000A2ED8
		private static void BuildImport_Namespace(XsdBuilder builder, string value)
		{
			builder.import.Namespace = value;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000A4CE6 File Offset: 0x000A2EE6
		private static void BuildImport_SchemaLocation(XsdBuilder builder, string value)
		{
			builder.import.SchemaLocation = value;
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000A4CF4 File Offset: 0x000A2EF4
		private static void InitRedefine(XsdBuilder builder, string value)
		{
			if (!builder.canIncludeImport)
			{
				builder.SendValidationEvent("The 'redefine' element cannot appear at this location.", null);
			}
			builder.xso = (builder.redefine = new XmlSchemaRedefine());
			builder.schema.Includes.Add(builder.redefine);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x000A4D40 File Offset: 0x000A2F40
		private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value)
		{
			builder.redefine.SchemaLocation = value;
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x000A4D4E File Offset: 0x000A2F4E
		private static void EndRedefine(XsdBuilder builder)
		{
			builder.canIncludeImport = true;
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x000A4D58 File Offset: 0x000A2F58
		private static void InitAttribute(XsdBuilder builder, string value)
		{
			builder.xso = (builder.attribute = new XmlSchemaAttribute());
			if (builder.ParentElement == SchemaNames.Token.XsdSchema)
			{
				builder.schema.Items.Add(builder.attribute);
			}
			else
			{
				builder.AddAttribute(builder.attribute);
			}
			builder.canIncludeImport = false;
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x000A4DAF File Offset: 0x000A2FAF
		private static void BuildAttribute_Default(XsdBuilder builder, string value)
		{
			builder.attribute.DefaultValue = value;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x000A4DBD File Offset: 0x000A2FBD
		private static void BuildAttribute_Fixed(XsdBuilder builder, string value)
		{
			builder.attribute.FixedValue = value;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000A4DCB File Offset: 0x000A2FCB
		private static void BuildAttribute_Form(XsdBuilder builder, string value)
		{
			builder.attribute.Form = (XmlSchemaForm)builder.ParseEnum(value, "form", XsdBuilder.FormStringValues);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x000A4DE9 File Offset: 0x000A2FE9
		private static void BuildAttribute_Use(XsdBuilder builder, string value)
		{
			builder.attribute.Use = (XmlSchemaUse)builder.ParseEnum(value, "use", XsdBuilder.UseStringValues);
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x000A4E07 File Offset: 0x000A3007
		private static void BuildAttribute_Ref(XsdBuilder builder, string value)
		{
			builder.attribute.RefName = builder.ParseQName(value, "ref");
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x000A4E20 File Offset: 0x000A3020
		private static void BuildAttribute_Name(XsdBuilder builder, string value)
		{
			builder.attribute.Name = value;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x000A4E2E File Offset: 0x000A302E
		private static void BuildAttribute_Type(XsdBuilder builder, string value)
		{
			builder.attribute.SchemaTypeName = builder.ParseQName(value, "type");
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000A4E48 File Offset: 0x000A3048
		private static void InitElement(XsdBuilder builder, string value)
		{
			builder.xso = (builder.element = new XmlSchemaElement());
			builder.canIncludeImport = false;
			SchemaNames.Token parentElement = builder.ParentElement;
			if (parentElement == SchemaNames.Token.XsdSchema)
			{
				builder.schema.Items.Add(builder.element);
				return;
			}
			switch (parentElement)
			{
			case SchemaNames.Token.XsdAll:
				builder.all.Items.Add(builder.element);
				return;
			case SchemaNames.Token.XsdChoice:
				builder.choice.Items.Add(builder.element);
				return;
			case SchemaNames.Token.XsdSequence:
				builder.sequence.Items.Add(builder.element);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x000A4EF1 File Offset: 0x000A30F1
		private static void BuildElement_Abstract(XsdBuilder builder, string value)
		{
			builder.element.IsAbstract = builder.ParseBoolean(value, "abstract");
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x000A4F0A File Offset: 0x000A310A
		private static void BuildElement_Block(XsdBuilder builder, string value)
		{
			builder.element.Block = (XmlSchemaDerivationMethod)builder.ParseBlockFinalEnum(value, "block");
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000A4F23 File Offset: 0x000A3123
		private static void BuildElement_Default(XsdBuilder builder, string value)
		{
			builder.element.DefaultValue = value;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000A4F31 File Offset: 0x000A3131
		private static void BuildElement_Form(XsdBuilder builder, string value)
		{
			builder.element.Form = (XmlSchemaForm)builder.ParseEnum(value, "form", XsdBuilder.FormStringValues);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x000A4F4F File Offset: 0x000A314F
		private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value)
		{
			builder.element.SubstitutionGroup = builder.ParseQName(value, "substitutionGroup");
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000A4F68 File Offset: 0x000A3168
		private static void BuildElement_Final(XsdBuilder builder, string value)
		{
			builder.element.Final = (XmlSchemaDerivationMethod)builder.ParseBlockFinalEnum(value, "final");
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x000A4F81 File Offset: 0x000A3181
		private static void BuildElement_Fixed(XsdBuilder builder, string value)
		{
			builder.element.FixedValue = value;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x000A4F8F File Offset: 0x000A318F
		private static void BuildElement_MaxOccurs(XsdBuilder builder, string value)
		{
			builder.SetMaxOccurs(builder.element, value);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x000A4F9E File Offset: 0x000A319E
		private static void BuildElement_MinOccurs(XsdBuilder builder, string value)
		{
			builder.SetMinOccurs(builder.element, value);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x000A4FAD File Offset: 0x000A31AD
		private static void BuildElement_Name(XsdBuilder builder, string value)
		{
			builder.element.Name = value;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x000A4FBB File Offset: 0x000A31BB
		private static void BuildElement_Nillable(XsdBuilder builder, string value)
		{
			builder.element.IsNillable = builder.ParseBoolean(value, "nillable");
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x000A4FD4 File Offset: 0x000A31D4
		private static void BuildElement_Ref(XsdBuilder builder, string value)
		{
			builder.element.RefName = builder.ParseQName(value, "ref");
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000A4FED File Offset: 0x000A31ED
		private static void BuildElement_Type(XsdBuilder builder, string value)
		{
			builder.element.SchemaTypeName = builder.ParseQName(value, "type");
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x000A5008 File Offset: 0x000A3208
		private static void InitSimpleType(XsdBuilder builder, string value)
		{
			builder.xso = (builder.simpleType = new XmlSchemaSimpleType());
			SchemaNames.Token parentElement = builder.ParentElement;
			if (parentElement <= SchemaNames.Token.XsdElement)
			{
				if (parentElement == SchemaNames.Token.XsdSchema)
				{
					builder.canIncludeImport = false;
					builder.schema.Items.Add(builder.simpleType);
					return;
				}
				if (parentElement != SchemaNames.Token.XsdElement)
				{
					return;
				}
				if (builder.element.SchemaType != null)
				{
					builder.SendValidationEvent("'{0}' is a duplicate XSD element.", "simpleType");
				}
				if (builder.element.Constraints.Count != 0)
				{
					builder.SendValidationEvent("'simpleType' or 'complexType' cannot follow 'unique', 'key' or 'keyref'.", null);
				}
				builder.element.SchemaType = builder.simpleType;
				return;
			}
			else
			{
				if (parentElement != SchemaNames.Token.XsdAttribute)
				{
					switch (parentElement)
					{
					case SchemaNames.Token.XsdSimpleContentRestriction:
						if (builder.simpleContentRestriction.BaseType != null)
						{
							builder.SendValidationEvent("'{0}' is a duplicate XSD element.", "simpleType");
						}
						if (builder.simpleContentRestriction.Attributes.Count != 0 || builder.simpleContentRestriction.AnyAttribute != null || builder.simpleContentRestriction.Facets.Count != 0)
						{
							builder.SendValidationEvent("'simpleType' should be the first child of restriction.", null);
						}
						builder.simpleContentRestriction.BaseType = builder.simpleType;
						return;
					case SchemaNames.Token.XsdSimpleTypeList:
						if (builder.simpleTypeList.ItemType != null)
						{
							builder.SendValidationEvent("'{0}' is a duplicate XSD element.", "simpleType");
						}
						builder.simpleTypeList.ItemType = builder.simpleType;
						return;
					case SchemaNames.Token.XsdSimpleTypeRestriction:
						if (builder.simpleTypeRestriction.BaseType != null)
						{
							builder.SendValidationEvent("'{0}' is a duplicate XSD element.", "simpleType");
						}
						builder.simpleTypeRestriction.BaseType = builder.simpleType;
						return;
					case SchemaNames.Token.XsdSimpleTypeUnion:
						builder.simpleTypeUnion.BaseTypes.Add(builder.simpleType);
						break;
					case SchemaNames.Token.XsdWhitespace:
						break;
					case SchemaNames.Token.XsdRedefine:
						builder.redefine.Items.Add(builder.simpleType);
						return;
					default:
						return;
					}
					return;
				}
				if (builder.attribute.SchemaType != null)
				{
					builder.SendValidationEvent("'{0}' is a duplicate XSD element.", "simpleType");
				}
				builder.attribute.SchemaType = builder.simpleType;
				return;
			}
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x000A51FE File Offset: 0x000A33FE
		private static void BuildSimpleType_Name(XsdBuilder builder, string value)
		{
			builder.simpleType.Name = value;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x000A520C File Offset: 0x000A340C
		private static void BuildSimpleType_Final(XsdBuilder builder, string value)
		{
			builder.simpleType.Final = (XmlSchemaDerivationMethod)builder.ParseBlockFinalEnum(value, "final");
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x000A5228 File Offset: 0x000A3428
		private static void InitSimpleTypeUnion(XsdBuilder builder, string value)
		{
			if (builder.simpleType.Content != null)
			{
				builder.SendValidationEvent("'simpleType' should have only one child 'union', 'list', or 'restriction'.", null);
			}
			builder.xso = (builder.simpleTypeUnion = new XmlSchemaSimpleTypeUnion());
			builder.simpleType.Content = builder.simpleTypeUnion;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x000A5274 File Offset: 0x000A3474
		private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value)
		{
			XmlSchemaDatatype xmlSchemaDatatype = XmlSchemaDatatype.FromXmlTokenizedTypeXsd(XmlTokenizedType.QName).DeriveByList(null);
			try
			{
				builder.simpleTypeUnion.MemberTypes = (XmlQualifiedName[])xmlSchemaDatatype.ParseValue(value, builder.nameTable, builder.namespaceManager);
			}
			catch (XmlSchemaException ex)
			{
				ex.SetSource(builder.reader.BaseURI, builder.positionInfo.LineNumber, builder.positionInfo.LinePosition);
				builder.SendValidationEvent(ex);
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x000A52F8 File Offset: 0x000A34F8
		private static void InitSimpleTypeList(XsdBuilder builder, string value)
		{
			if (builder.simpleType.Content != null)
			{
				builder.SendValidationEvent("'simpleType' should have only one child 'union', 'list', or 'restriction'.", null);
			}
			builder.xso = (builder.simpleTypeList = new XmlSchemaSimpleTypeList());
			builder.simpleType.Content = builder.simpleTypeList;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x000A5343 File Offset: 0x000A3543
		private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value)
		{
			builder.simpleTypeList.ItemTypeName = builder.ParseQName(value, "itemType");
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x000A535C File Offset: 0x000A355C
		private static void InitSimpleTypeRestriction(XsdBuilder builder, string value)
		{
			if (builder.simpleType.Content != null)
			{
				builder.SendValidationEvent("'simpleType' should have only one child 'union', 'list', or 'restriction'.", null);
			}
			builder.xso = (builder.simpleTypeRestriction = new XmlSchemaSimpleTypeRestriction());
			builder.simpleType.Content = builder.simpleTypeRestriction;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x000A53A7 File Offset: 0x000A35A7
		private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value)
		{
			builder.simpleTypeRestriction.BaseTypeName = builder.ParseQName(value, "base");
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000A53C0 File Offset: 0x000A35C0
		private static void InitComplexType(XsdBuilder builder, string value)
		{
			builder.xso = (builder.complexType = new XmlSchemaComplexType());
			SchemaNames.Token parentElement = builder.ParentElement;
			if (parentElement == SchemaNames.Token.XsdSchema)
			{
				builder.canIncludeImport = false;
				builder.schema.Items.Add(builder.complexType);
				return;
			}
			if (parentElement == SchemaNames.Token.XsdElement)
			{
				if (builder.element.SchemaType != null)
				{
					builder.SendValidationEvent("The '{0}' element already exists in the content model.", "complexType");
				}
				if (builder.element.Constraints.Count != 0)
				{
					builder.SendValidationEvent("'simpleType' or 'complexType' cannot follow 'unique', 'key' or 'keyref'.", null);
				}
				builder.element.SchemaType = builder.complexType;
				return;
			}
			if (parentElement != SchemaNames.Token.XsdRedefine)
			{
				return;
			}
			builder.redefine.Items.Add(builder.complexType);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x000A547B File Offset: 0x000A367B
		private static void BuildComplexType_Abstract(XsdBuilder builder, string value)
		{
			builder.complexType.IsAbstract = builder.ParseBoolean(value, "abstract");
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x000A5494 File Offset: 0x000A3694
		private static void BuildComplexType_Block(XsdBuilder builder, string value)
		{
			builder.complexType.Block = (XmlSchemaDerivationMethod)builder.ParseBlockFinalEnum(value, "block");
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x000A54AD File Offset: 0x000A36AD
		private static void BuildComplexType_Final(XsdBuilder builder, string value)
		{
			builder.complexType.Final = (XmlSchemaDerivationMethod)builder.ParseBlockFinalEnum(value, "final");
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x000A54C6 File Offset: 0x000A36C6
		private static void BuildComplexType_Mixed(XsdBuilder builder, string value)
		{
			builder.complexType.IsMixed = builder.ParseBoolean(value, "mixed");
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x000A54DF File Offset: 0x000A36DF
		private static void BuildComplexType_Name(XsdBuilder builder, string value)
		{
			builder.complexType.Name = value;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x000A54F0 File Offset: 0x000A36F0
		private static void InitComplexContent(XsdBuilder builder, string value)
		{
			if (builder.complexType.ContentModel != null || builder.complexType.Particle != null || builder.complexType.Attributes.Count != 0 || builder.complexType.AnyAttribute != null)
			{
				builder.SendValidationEvent("The content model of a complex type must consist of 'annotation' (if present); followed by zero or one of the following: 'simpleContent', 'complexContent', 'group', 'choice', 'sequence', or 'all'; followed by zero or more 'attribute' or 'attributeGroup'; followed by zero or one 'anyAttribute'.", "complexContent");
			}
			builder.xso = (builder.complexContent = new XmlSchemaComplexContent());
			builder.complexType.ContentModel = builder.complexContent;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000A556B File Offset: 0x000A376B
		private static void BuildComplexContent_Mixed(XsdBuilder builder, string value)
		{
			builder.complexContent.IsMixed = builder.ParseBoolean(value, "mixed");
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x000A5584 File Offset: 0x000A3784
		private static void InitComplexContentExtension(XsdBuilder builder, string value)
		{
			if (builder.complexContent.Content != null)
			{
				builder.SendValidationEvent("Complex content restriction or extension should consist of zero or one of 'group', 'choice', 'sequence', or 'all'; followed by zero or more 'attribute' or 'attributeGroup'; followed by zero or one 'anyAttribute'.", "extension");
			}
			builder.xso = (builder.complexContentExtension = new XmlSchemaComplexContentExtension());
			builder.complexContent.Content = builder.complexContentExtension;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x000A55D3 File Offset: 0x000A37D3
		private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value)
		{
			builder.complexContentExtension.BaseTypeName = builder.ParseQName(value, "base");
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x000A55EC File Offset: 0x000A37EC
		private static void InitComplexContentRestriction(XsdBuilder builder, string value)
		{
			builder.xso = (builder.complexContentRestriction = new XmlSchemaComplexContentRestriction());
			builder.complexContent.Content = builder.complexContentRestriction;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000A561E File Offset: 0x000A381E
		private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value)
		{
			builder.complexContentRestriction.BaseTypeName = builder.ParseQName(value, "base");
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x000A5638 File Offset: 0x000A3838
		private static void InitSimpleContent(XsdBuilder builder, string value)
		{
			if (builder.complexType.ContentModel != null || builder.complexType.Particle != null || builder.complexType.Attributes.Count != 0 || builder.complexType.AnyAttribute != null)
			{
				builder.SendValidationEvent("The content model of a complex type must consist of 'annotation' (if present); followed by zero or one of the following: 'simpleContent', 'complexContent', 'group', 'choice', 'sequence', or 'all'; followed by zero or more 'attribute' or 'attributeGroup'; followed by zero or one 'anyAttribute'.", "simpleContent");
			}
			builder.xso = (builder.simpleContent = new XmlSchemaSimpleContent());
			builder.complexType.ContentModel = builder.simpleContent;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000A56B4 File Offset: 0x000A38B4
		private static void InitSimpleContentExtension(XsdBuilder builder, string value)
		{
			if (builder.simpleContent.Content != null)
			{
				builder.SendValidationEvent("The '{0}' element already exists in the content model.", "extension");
			}
			builder.xso = (builder.simpleContentExtension = new XmlSchemaSimpleContentExtension());
			builder.simpleContent.Content = builder.simpleContentExtension;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000A5703 File Offset: 0x000A3903
		private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value)
		{
			builder.simpleContentExtension.BaseTypeName = builder.ParseQName(value, "base");
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000A571C File Offset: 0x000A391C
		private static void InitSimpleContentRestriction(XsdBuilder builder, string value)
		{
			if (builder.simpleContent.Content != null)
			{
				builder.SendValidationEvent("The '{0}' element already exists in the content model.", "restriction");
			}
			builder.xso = (builder.simpleContentRestriction = new XmlSchemaSimpleContentRestriction());
			builder.simpleContent.Content = builder.simpleContentRestriction;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x000A576B File Offset: 0x000A396B
		private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value)
		{
			builder.simpleContentRestriction.BaseTypeName = builder.ParseQName(value, "base");
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x000A5784 File Offset: 0x000A3984
		private static void InitAttributeGroup(XsdBuilder builder, string value)
		{
			builder.canIncludeImport = false;
			builder.xso = (builder.attributeGroup = new XmlSchemaAttributeGroup());
			SchemaNames.Token parentElement = builder.ParentElement;
			if (parentElement == SchemaNames.Token.XsdSchema)
			{
				builder.schema.Items.Add(builder.attributeGroup);
				return;
			}
			if (parentElement != SchemaNames.Token.XsdRedefine)
			{
				return;
			}
			builder.redefine.Items.Add(builder.attributeGroup);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x000A57ED File Offset: 0x000A39ED
		private static void BuildAttributeGroup_Name(XsdBuilder builder, string value)
		{
			builder.attributeGroup.Name = value;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000A57FC File Offset: 0x000A39FC
		private static void InitAttributeGroupRef(XsdBuilder builder, string value)
		{
			builder.xso = (builder.attributeGroupRef = new XmlSchemaAttributeGroupRef());
			builder.AddAttribute(builder.attributeGroupRef);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x000A5829 File Offset: 0x000A3A29
		private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value)
		{
			builder.attributeGroupRef.RefName = builder.ParseQName(value, "ref");
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x000A5844 File Offset: 0x000A3A44
		private static void InitAnyAttribute(XsdBuilder builder, string value)
		{
			builder.xso = (builder.anyAttribute = new XmlSchemaAnyAttribute());
			SchemaNames.Token parentElement = builder.ParentElement;
			if (parentElement != SchemaNames.Token.xsdAttributeGroup)
			{
				if (parentElement == SchemaNames.Token.XsdComplexType)
				{
					if (builder.complexType.ContentModel != null)
					{
						builder.SendValidationEvent("'{0}' and content model are mutually exclusive.", "anyAttribute");
					}
					if (builder.complexType.AnyAttribute != null)
					{
						builder.SendValidationEvent("The '{0}' element already exists in the content model.", "anyAttribute");
					}
					builder.complexType.AnyAttribute = builder.anyAttribute;
					return;
				}
				switch (parentElement)
				{
				case SchemaNames.Token.XsdComplexContentExtension:
					if (builder.complexContentExtension.AnyAttribute != null)
					{
						builder.SendValidationEvent("The '{0}' element already exists in the content model.", "anyAttribute");
					}
					builder.complexContentExtension.AnyAttribute = builder.anyAttribute;
					return;
				case SchemaNames.Token.XsdComplexContentRestriction:
					if (builder.complexContentRestriction.AnyAttribute != null)
					{
						builder.SendValidationEvent("The '{0}' element already exists in the content model.", "anyAttribute");
					}
					builder.complexContentRestriction.AnyAttribute = builder.anyAttribute;
					return;
				case SchemaNames.Token.XsdSimpleContent:
					break;
				case SchemaNames.Token.XsdSimpleContentExtension:
					if (builder.simpleContentExtension.AnyAttribute != null)
					{
						builder.SendValidationEvent("The '{0}' element already exists in the content model.", "anyAttribute");
					}
					builder.simpleContentExtension.AnyAttribute = builder.anyAttribute;
					return;
				case SchemaNames.Token.XsdSimpleContentRestriction:
					if (builder.simpleContentRestriction.AnyAttribute != null)
					{
						builder.SendValidationEvent("The '{0}' element already exists in the content model.", "anyAttribute");
					}
					builder.simpleContentRestriction.AnyAttribute = builder.anyAttribute;
					return;
				default:
					return;
				}
			}
			else
			{
				if (builder.attributeGroup.AnyAttribute != null)
				{
					builder.SendValidationEvent("The '{0}' element already exists in the content model.", "anyAttribute");
				}
				builder.attributeGroup.AnyAttribute = builder.anyAttribute;
			}
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000A59CD File Offset: 0x000A3BCD
		private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value)
		{
			builder.anyAttribute.Namespace = value;
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000A59DB File Offset: 0x000A3BDB
		private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value)
		{
			builder.anyAttribute.ProcessContents = (XmlSchemaContentProcessing)builder.ParseEnum(value, "processContents", XsdBuilder.ProcessContentsStringValues);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x000A59FC File Offset: 0x000A3BFC
		private static void InitGroup(XsdBuilder builder, string value)
		{
			builder.xso = (builder.group = new XmlSchemaGroup());
			builder.canIncludeImport = false;
			SchemaNames.Token parentElement = builder.ParentElement;
			if (parentElement == SchemaNames.Token.XsdSchema)
			{
				builder.schema.Items.Add(builder.group);
				return;
			}
			if (parentElement != SchemaNames.Token.XsdRedefine)
			{
				return;
			}
			builder.redefine.Items.Add(builder.group);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x000A5A65 File Offset: 0x000A3C65
		private static void BuildGroup_Name(XsdBuilder builder, string value)
		{
			builder.group.Name = value;
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x000A5A74 File Offset: 0x000A3C74
		private static void InitGroupRef(XsdBuilder builder, string value)
		{
			builder.xso = (builder.particle = (builder.groupRef = new XmlSchemaGroupRef()));
			builder.AddParticle(builder.groupRef);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x000A5AAA File Offset: 0x000A3CAA
		private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value)
		{
			builder.SetMaxOccurs(builder.particle, value);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000A5AB9 File Offset: 0x000A3CB9
		private static void BuildParticle_MinOccurs(XsdBuilder builder, string value)
		{
			builder.SetMinOccurs(builder.particle, value);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000A5AC8 File Offset: 0x000A3CC8
		private static void BuildGroupRef_Ref(XsdBuilder builder, string value)
		{
			builder.groupRef.RefName = builder.ParseQName(value, "ref");
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000A5AE4 File Offset: 0x000A3CE4
		private static void InitAll(XsdBuilder builder, string value)
		{
			builder.xso = (builder.particle = (builder.all = new XmlSchemaAll()));
			builder.AddParticle(builder.all);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000A5B1C File Offset: 0x000A3D1C
		private static void InitChoice(XsdBuilder builder, string value)
		{
			builder.xso = (builder.particle = (builder.choice = new XmlSchemaChoice()));
			builder.AddParticle(builder.choice);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000A5B54 File Offset: 0x000A3D54
		private static void InitSequence(XsdBuilder builder, string value)
		{
			builder.xso = (builder.particle = (builder.sequence = new XmlSchemaSequence()));
			builder.AddParticle(builder.sequence);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x000A5B8C File Offset: 0x000A3D8C
		private static void InitAny(XsdBuilder builder, string value)
		{
			builder.xso = (builder.particle = (builder.anyElement = new XmlSchemaAny()));
			builder.AddParticle(builder.anyElement);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000A5BC2 File Offset: 0x000A3DC2
		private static void BuildAny_Namespace(XsdBuilder builder, string value)
		{
			builder.anyElement.Namespace = value;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000A5BD0 File Offset: 0x000A3DD0
		private static void BuildAny_ProcessContents(XsdBuilder builder, string value)
		{
			builder.anyElement.ProcessContents = (XmlSchemaContentProcessing)builder.ParseEnum(value, "processContents", XsdBuilder.ProcessContentsStringValues);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000A5BF0 File Offset: 0x000A3DF0
		private static void InitNotation(XsdBuilder builder, string value)
		{
			builder.xso = (builder.notation = new XmlSchemaNotation());
			builder.canIncludeImport = false;
			builder.schema.Items.Add(builder.notation);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000A5C2F File Offset: 0x000A3E2F
		private static void BuildNotation_Name(XsdBuilder builder, string value)
		{
			builder.notation.Name = value;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000A5C3D File Offset: 0x000A3E3D
		private static void BuildNotation_Public(XsdBuilder builder, string value)
		{
			builder.notation.Public = value;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x000A5C4B File Offset: 0x000A3E4B
		private static void BuildNotation_System(XsdBuilder builder, string value)
		{
			builder.notation.System = value;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000A5C5C File Offset: 0x000A3E5C
		private static void InitFacet(XsdBuilder builder, string value)
		{
			switch (builder.CurrentElement)
			{
			case SchemaNames.Token.XsdMinExclusive:
				builder.facet = new XmlSchemaMinExclusiveFacet();
				break;
			case SchemaNames.Token.XsdMinInclusive:
				builder.facet = new XmlSchemaMinInclusiveFacet();
				break;
			case SchemaNames.Token.XsdMaxExclusive:
				builder.facet = new XmlSchemaMaxExclusiveFacet();
				break;
			case SchemaNames.Token.XsdMaxInclusive:
				builder.facet = new XmlSchemaMaxInclusiveFacet();
				break;
			case SchemaNames.Token.XsdTotalDigits:
				builder.facet = new XmlSchemaTotalDigitsFacet();
				break;
			case SchemaNames.Token.XsdFractionDigits:
				builder.facet = new XmlSchemaFractionDigitsFacet();
				break;
			case SchemaNames.Token.XsdLength:
				builder.facet = new XmlSchemaLengthFacet();
				break;
			case SchemaNames.Token.XsdMinLength:
				builder.facet = new XmlSchemaMinLengthFacet();
				break;
			case SchemaNames.Token.XsdMaxLength:
				builder.facet = new XmlSchemaMaxLengthFacet();
				break;
			case SchemaNames.Token.XsdEnumeration:
				builder.facet = new XmlSchemaEnumerationFacet();
				break;
			case SchemaNames.Token.XsdPattern:
				builder.facet = new XmlSchemaPatternFacet();
				break;
			case SchemaNames.Token.XsdWhitespace:
				builder.facet = new XmlSchemaWhiteSpaceFacet();
				break;
			}
			builder.xso = builder.facet;
			if (SchemaNames.Token.XsdSimpleTypeRestriction == builder.ParentElement)
			{
				builder.simpleTypeRestriction.Facets.Add(builder.facet);
				return;
			}
			if (builder.simpleContentRestriction.Attributes.Count != 0 || builder.simpleContentRestriction.AnyAttribute != null)
			{
				builder.SendValidationEvent("Facet should go before 'attribute', 'attributeGroup', or 'anyAttribute'.", null);
			}
			builder.simpleContentRestriction.Facets.Add(builder.facet);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000A5DEA File Offset: 0x000A3FEA
		private static void BuildFacet_Fixed(XsdBuilder builder, string value)
		{
			builder.facet.IsFixed = builder.ParseBoolean(value, "fixed");
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000A5E03 File Offset: 0x000A4003
		private static void BuildFacet_Value(XsdBuilder builder, string value)
		{
			builder.facet.Value = value;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x000A5E14 File Offset: 0x000A4014
		private static void InitIdentityConstraint(XsdBuilder builder, string value)
		{
			if (!builder.element.RefName.IsEmpty)
			{
				builder.SendValidationEvent("When the ref attribute is present, the type attribute and complexType, simpleType, key, keyref, and unique elements cannot be present.", null);
			}
			switch (builder.CurrentElement)
			{
			case SchemaNames.Token.XsdUnique:
				builder.xso = (builder.identityConstraint = new XmlSchemaUnique());
				break;
			case SchemaNames.Token.XsdKey:
				builder.xso = (builder.identityConstraint = new XmlSchemaKey());
				break;
			case SchemaNames.Token.XsdKeyref:
				builder.xso = (builder.identityConstraint = new XmlSchemaKeyref());
				break;
			}
			builder.element.Constraints.Add(builder.identityConstraint);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000A5EB4 File Offset: 0x000A40B4
		private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value)
		{
			builder.identityConstraint.Name = value;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x000A5EC2 File Offset: 0x000A40C2
		private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value)
		{
			if (builder.identityConstraint is XmlSchemaKeyref)
			{
				((XmlSchemaKeyref)builder.identityConstraint).Refer = builder.ParseQName(value, "refer");
				return;
			}
			builder.SendValidationEvent("The '{0}' attribute is not supported in this context.", "refer");
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000A5F00 File Offset: 0x000A4100
		private static void InitSelector(XsdBuilder builder, string value)
		{
			builder.xso = (builder.xpath = new XmlSchemaXPath());
			if (builder.identityConstraint.Selector == null)
			{
				builder.identityConstraint.Selector = builder.xpath;
				return;
			}
			builder.SendValidationEvent("Selector cannot appear twice in one identity constraint.", builder.identityConstraint.Name);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x000A5F56 File Offset: 0x000A4156
		private static void BuildSelector_XPath(XsdBuilder builder, string value)
		{
			builder.xpath.XPath = value;
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000A5F64 File Offset: 0x000A4164
		private static void InitField(XsdBuilder builder, string value)
		{
			builder.xso = (builder.xpath = new XmlSchemaXPath());
			if (builder.identityConstraint.Selector == null)
			{
				builder.SendValidationEvent("Cannot define fields before selector.", builder.identityConstraint.Name);
			}
			builder.identityConstraint.Fields.Add(builder.xpath);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000A5F56 File Offset: 0x000A4156
		private static void BuildField_XPath(XsdBuilder builder, string value)
		{
			builder.xpath.XPath = value;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x000A5FC0 File Offset: 0x000A41C0
		private static void InitAnnotation(XsdBuilder builder, string value)
		{
			if (builder.hasChild && builder.ParentElement != SchemaNames.Token.XsdSchema && builder.ParentElement != SchemaNames.Token.XsdRedefine)
			{
				builder.SendValidationEvent("The 'annotation' element cannot appear at this location.", null);
			}
			builder.xso = (builder.annotation = new XmlSchemaAnnotation());
			builder.ParentContainer.AddAnnotation(builder.annotation);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x000A601C File Offset: 0x000A421C
		private static void InitAppinfo(XsdBuilder builder, string value)
		{
			builder.xso = (builder.appInfo = new XmlSchemaAppInfo());
			builder.annotation.Items.Add(builder.appInfo);
			builder.markup = new XmlNode[0];
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x000A6060 File Offset: 0x000A4260
		private static void BuildAppinfo_Source(XsdBuilder builder, string value)
		{
			builder.appInfo.Source = XsdBuilder.ParseUriReference(value);
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000A6073 File Offset: 0x000A4273
		private static void EndAppinfo(XsdBuilder builder)
		{
			builder.appInfo.Markup = builder.markup;
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000A6088 File Offset: 0x000A4288
		private static void InitDocumentation(XsdBuilder builder, string value)
		{
			builder.xso = (builder.documentation = new XmlSchemaDocumentation());
			builder.annotation.Items.Add(builder.documentation);
			builder.markup = new XmlNode[0];
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000A60CC File Offset: 0x000A42CC
		private static void BuildDocumentation_Source(XsdBuilder builder, string value)
		{
			builder.documentation.Source = XsdBuilder.ParseUriReference(value);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x000A60E0 File Offset: 0x000A42E0
		private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value)
		{
			try
			{
				builder.documentation.Language = value;
			}
			catch (XmlSchemaException ex)
			{
				ex.SetSource(builder.reader.BaseURI, builder.positionInfo.LineNumber, builder.positionInfo.LinePosition);
				builder.SendValidationEvent(ex);
			}
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000A613C File Offset: 0x000A433C
		private static void EndDocumentation(XsdBuilder builder)
		{
			builder.documentation.Markup = builder.markup;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x000A6150 File Offset: 0x000A4350
		private void AddAttribute(XmlSchemaObject value)
		{
			SchemaNames.Token parentElement = this.ParentElement;
			if (parentElement != SchemaNames.Token.xsdAttributeGroup)
			{
				if (parentElement == SchemaNames.Token.XsdComplexType)
				{
					if (this.complexType.ContentModel != null)
					{
						this.SendValidationEvent("'{0}' and content model are mutually exclusive.", "attribute");
					}
					if (this.complexType.AnyAttribute != null)
					{
						this.SendValidationEvent("'anyAttribute' must be the last child.", null);
					}
					this.complexType.Attributes.Add(value);
					return;
				}
				switch (parentElement)
				{
				case SchemaNames.Token.XsdComplexContentExtension:
					if (this.complexContentExtension.AnyAttribute != null)
					{
						this.SendValidationEvent("'anyAttribute' must be the last child.", null);
					}
					this.complexContentExtension.Attributes.Add(value);
					return;
				case SchemaNames.Token.XsdComplexContentRestriction:
					if (this.complexContentRestriction.AnyAttribute != null)
					{
						this.SendValidationEvent("'anyAttribute' must be the last child.", null);
					}
					this.complexContentRestriction.Attributes.Add(value);
					return;
				case SchemaNames.Token.XsdSimpleContent:
					break;
				case SchemaNames.Token.XsdSimpleContentExtension:
					if (this.simpleContentExtension.AnyAttribute != null)
					{
						this.SendValidationEvent("'anyAttribute' must be the last child.", null);
					}
					this.simpleContentExtension.Attributes.Add(value);
					return;
				case SchemaNames.Token.XsdSimpleContentRestriction:
					if (this.simpleContentRestriction.AnyAttribute != null)
					{
						this.SendValidationEvent("'anyAttribute' must be the last child.", null);
					}
					this.simpleContentRestriction.Attributes.Add(value);
					return;
				default:
					return;
				}
			}
			else
			{
				if (this.attributeGroup.AnyAttribute != null)
				{
					this.SendValidationEvent("'anyAttribute' must be the last child.", null);
				}
				this.attributeGroup.Attributes.Add(value);
			}
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000A62B4 File Offset: 0x000A44B4
		private void AddParticle(XmlSchemaParticle particle)
		{
			SchemaNames.Token parentElement = this.ParentElement;
			if (parentElement <= SchemaNames.Token.XsdSequence)
			{
				if (parentElement == SchemaNames.Token.XsdGroup)
				{
					if (this.group.Particle != null)
					{
						this.SendValidationEvent("The content model can only have one of the following; 'all', 'choice', or 'sequence'.", "particle");
					}
					this.group.Particle = (XmlSchemaGroupBase)particle;
					return;
				}
				if (parentElement - SchemaNames.Token.XsdChoice > 1)
				{
					return;
				}
				((XmlSchemaGroupBase)this.ParentContainer).Items.Add(particle);
				return;
			}
			else
			{
				if (parentElement == SchemaNames.Token.XsdComplexType)
				{
					if (this.complexType.ContentModel != null || this.complexType.Attributes.Count != 0 || this.complexType.AnyAttribute != null || this.complexType.Particle != null)
					{
						this.SendValidationEvent("The content model of a complex type must consist of 'annotation' (if present); followed by zero or one of the following: 'simpleContent', 'complexContent', 'group', 'choice', 'sequence', or 'all'; followed by zero or more 'attribute' or 'attributeGroup'; followed by zero or one 'anyAttribute'.", "complexType");
					}
					this.complexType.Particle = particle;
					return;
				}
				if (parentElement == SchemaNames.Token.XsdComplexContentExtension)
				{
					if (this.complexContentExtension.Particle != null || this.complexContentExtension.Attributes.Count != 0 || this.complexContentExtension.AnyAttribute != null)
					{
						this.SendValidationEvent("Complex content restriction or extension should consist of zero or one of 'group', 'choice', 'sequence', or 'all'; followed by zero or more 'attribute' or 'attributeGroup'; followed by zero or one 'anyAttribute'.", "ComplexContentExtension");
					}
					this.complexContentExtension.Particle = particle;
					return;
				}
				if (parentElement != SchemaNames.Token.XsdComplexContentRestriction)
				{
					return;
				}
				if (this.complexContentRestriction.Particle != null || this.complexContentRestriction.Attributes.Count != 0 || this.complexContentRestriction.AnyAttribute != null)
				{
					this.SendValidationEvent("Complex content restriction or extension should consist of zero or one of 'group', 'choice', 'sequence', or 'all'; followed by zero or more 'attribute' or 'attributeGroup'; followed by zero or one 'anyAttribute'.", "ComplexContentExtension");
				}
				this.complexContentRestriction.Particle = particle;
				return;
			}
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000A6424 File Offset: 0x000A4624
		private bool GetNextState(XmlQualifiedName qname)
		{
			if (this.currentEntry.NextStates != null)
			{
				for (int i = 0; i < this.currentEntry.NextStates.Length; i++)
				{
					int num = (int)this.currentEntry.NextStates[i];
					if (this.schemaNames.TokenToQName[(int)XsdBuilder.SchemaEntries[num].Name].Equals(qname))
					{
						this.nextEntry = XsdBuilder.SchemaEntries[num];
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000A6494 File Offset: 0x000A4694
		private bool IsSkipableElement(XmlQualifiedName qname)
		{
			return this.CurrentElement == SchemaNames.Token.XsdDocumentation || this.CurrentElement == SchemaNames.Token.XsdAppInfo;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000A64AC File Offset: 0x000A46AC
		private void SetMinOccurs(XmlSchemaParticle particle, string value)
		{
			try
			{
				particle.MinOccursString = value;
			}
			catch (Exception)
			{
				this.SendValidationEvent("The value for the 'minOccurs' attribute must be xsd:nonNegativeInteger.", null);
			}
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000A64E4 File Offset: 0x000A46E4
		private void SetMaxOccurs(XmlSchemaParticle particle, string value)
		{
			try
			{
				particle.MaxOccursString = value;
			}
			catch (Exception)
			{
				this.SendValidationEvent("The value for the 'maxOccurs' attribute must be xsd:nonNegativeInteger or 'unbounded'.", null);
			}
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000A651C File Offset: 0x000A471C
		private bool ParseBoolean(string value, string attributeName)
		{
			bool result;
			try
			{
				result = XmlConvert.ToBoolean(value);
			}
			catch (Exception)
			{
				this.SendValidationEvent("'{1}' is an invalid value for the '{0}' attribute.", attributeName, value, null);
				result = false;
			}
			return result;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x000A6558 File Offset: 0x000A4758
		private int ParseEnum(string value, string attributeName, string[] values)
		{
			string text = value.Trim();
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i] == text)
				{
					return i + 1;
				}
			}
			this.SendValidationEvent("'{1}' is an invalid value for the '{0}' attribute.", attributeName, text, null);
			return 0;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000A6598 File Offset: 0x000A4798
		private XmlQualifiedName ParseQName(string value, string attributeName)
		{
			XmlQualifiedName result;
			try
			{
				value = XmlComplianceUtil.NonCDataNormalize(value);
				string text;
				result = XmlQualifiedName.Parse(value, this.namespaceManager, out text);
			}
			catch (Exception)
			{
				this.SendValidationEvent("'{1}' is an invalid value for the '{0}' attribute.", attributeName, value, null);
				result = XmlQualifiedName.Empty;
			}
			return result;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x000A65E8 File Offset: 0x000A47E8
		private int ParseBlockFinalEnum(string value, string attributeName)
		{
			int num = 0;
			string[] array = XmlConvert.SplitString(value);
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = false;
				int j = 0;
				while (j < XsdBuilder.DerivationMethodStrings.Length)
				{
					if (array[i] == XsdBuilder.DerivationMethodStrings[j])
					{
						if ((num & XsdBuilder.DerivationMethodValues[j]) != 0 && (num & XsdBuilder.DerivationMethodValues[j]) != XsdBuilder.DerivationMethodValues[j])
						{
							this.SendValidationEvent("'{1}' is an invalid value for the '{0}' attribute.", attributeName, value, null);
							return 0;
						}
						num |= XsdBuilder.DerivationMethodValues[j];
						flag = true;
						break;
					}
					else
					{
						j++;
					}
				}
				if (!flag)
				{
					this.SendValidationEvent("'{1}' is an invalid value for the '{0}' attribute.", attributeName, value, null);
					return 0;
				}
				if (num == 255 && value.Length > 4)
				{
					this.SendValidationEvent("'{1}' is an invalid value for the '{0}' attribute.", attributeName, value, null);
					return 0;
				}
			}
			return num;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00044153 File Offset: 0x00042353
		private static string ParseUriReference(string s)
		{
			return s;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000A66B0 File Offset: 0x000A48B0
		private void SendValidationEvent(string code, string arg0, string arg1, string arg2)
		{
			this.SendValidationEvent(new XmlSchemaException(code, new string[]
			{
				arg0,
				arg1,
				arg2
			}, this.reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition));
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000A66FD File Offset: 0x000A48FD
		private void SendValidationEvent(string code, string msg)
		{
			this.SendValidationEvent(new XmlSchemaException(code, msg, this.reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition));
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000A672D File Offset: 0x000A492D
		private void SendValidationEvent(string code, string[] args, XmlSeverityType severity)
		{
			this.SendValidationEvent(new XmlSchemaException(code, args, this.reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition), severity);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x000A6760 File Offset: 0x000A4960
		private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
			XmlSchema xmlSchema = this.schema;
			int errorCount = xmlSchema.ErrorCount;
			xmlSchema.ErrorCount = errorCount + 1;
			e.SetSchemaObject(this.schema);
			if (this.validationEventHandler != null)
			{
				this.validationEventHandler(null, new ValidationEventArgs(e, severity));
				return;
			}
			if (severity == XmlSeverityType.Error)
			{
				throw e;
			}
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000A67AF File Offset: 0x000A49AF
		private void SendValidationEvent(XmlSchemaException e)
		{
			this.SendValidationEvent(e, XmlSeverityType.Error);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000A67BC File Offset: 0x000A49BC
		private void RecordPosition()
		{
			this.xso.SourceUri = this.reader.BaseURI;
			this.xso.LineNumber = this.positionInfo.LineNumber;
			this.xso.LinePosition = this.positionInfo.LinePosition;
			if (this.xso != this.schema)
			{
				this.xso.Parent = this.ParentContainer;
			}
		}

		// Token: 0x040011F4 RID: 4596
		private static readonly XsdBuilder.State[] SchemaElement = new XsdBuilder.State[]
		{
			XsdBuilder.State.Schema
		};

		// Token: 0x040011F5 RID: 4597
		private static readonly XsdBuilder.State[] SchemaSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.Include,
			XsdBuilder.State.Import,
			XsdBuilder.State.Redefine,
			XsdBuilder.State.ComplexType,
			XsdBuilder.State.SimpleType,
			XsdBuilder.State.Element,
			XsdBuilder.State.Attribute,
			XsdBuilder.State.AttributeGroup,
			XsdBuilder.State.Group,
			XsdBuilder.State.Notation
		};

		// Token: 0x040011F6 RID: 4598
		private static readonly XsdBuilder.State[] AttributeSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleType
		};

		// Token: 0x040011F7 RID: 4599
		private static readonly XsdBuilder.State[] ElementSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleType,
			XsdBuilder.State.ComplexType,
			XsdBuilder.State.Unique,
			XsdBuilder.State.Key,
			XsdBuilder.State.KeyRef
		};

		// Token: 0x040011F8 RID: 4600
		private static readonly XsdBuilder.State[] ComplexTypeSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleContent,
			XsdBuilder.State.ComplexContent,
			XsdBuilder.State.GroupRef,
			XsdBuilder.State.All,
			XsdBuilder.State.Choice,
			XsdBuilder.State.Sequence,
			XsdBuilder.State.Attribute,
			XsdBuilder.State.AttributeGroupRef,
			XsdBuilder.State.AnyAttribute
		};

		// Token: 0x040011F9 RID: 4601
		private static readonly XsdBuilder.State[] SimpleContentSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleContentRestriction,
			XsdBuilder.State.SimpleContentExtension
		};

		// Token: 0x040011FA RID: 4602
		private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.Attribute,
			XsdBuilder.State.AttributeGroupRef,
			XsdBuilder.State.AnyAttribute
		};

		// Token: 0x040011FB RID: 4603
		private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleType,
			XsdBuilder.State.Enumeration,
			XsdBuilder.State.Length,
			XsdBuilder.State.MaxExclusive,
			XsdBuilder.State.MaxInclusive,
			XsdBuilder.State.MaxLength,
			XsdBuilder.State.MinExclusive,
			XsdBuilder.State.MinInclusive,
			XsdBuilder.State.MinLength,
			XsdBuilder.State.Pattern,
			XsdBuilder.State.TotalDigits,
			XsdBuilder.State.FractionDigits,
			XsdBuilder.State.WhiteSpace,
			XsdBuilder.State.Attribute,
			XsdBuilder.State.AttributeGroupRef,
			XsdBuilder.State.AnyAttribute
		};

		// Token: 0x040011FC RID: 4604
		private static readonly XsdBuilder.State[] ComplexContentSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.ComplexContentRestriction,
			XsdBuilder.State.ComplexContentExtension
		};

		// Token: 0x040011FD RID: 4605
		private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.GroupRef,
			XsdBuilder.State.All,
			XsdBuilder.State.Choice,
			XsdBuilder.State.Sequence,
			XsdBuilder.State.Attribute,
			XsdBuilder.State.AttributeGroupRef,
			XsdBuilder.State.AnyAttribute
		};

		// Token: 0x040011FE RID: 4606
		private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.GroupRef,
			XsdBuilder.State.All,
			XsdBuilder.State.Choice,
			XsdBuilder.State.Sequence,
			XsdBuilder.State.Attribute,
			XsdBuilder.State.AttributeGroupRef,
			XsdBuilder.State.AnyAttribute
		};

		// Token: 0x040011FF RID: 4607
		private static readonly XsdBuilder.State[] SimpleTypeSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleTypeList,
			XsdBuilder.State.SimpleTypeRestriction,
			XsdBuilder.State.SimpleTypeUnion
		};

		// Token: 0x04001200 RID: 4608
		private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleType,
			XsdBuilder.State.Enumeration,
			XsdBuilder.State.Length,
			XsdBuilder.State.MaxExclusive,
			XsdBuilder.State.MaxInclusive,
			XsdBuilder.State.MaxLength,
			XsdBuilder.State.MinExclusive,
			XsdBuilder.State.MinInclusive,
			XsdBuilder.State.MinLength,
			XsdBuilder.State.Pattern,
			XsdBuilder.State.TotalDigits,
			XsdBuilder.State.FractionDigits,
			XsdBuilder.State.WhiteSpace
		};

		// Token: 0x04001201 RID: 4609
		private static readonly XsdBuilder.State[] SimpleTypeListSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleType
		};

		// Token: 0x04001202 RID: 4610
		private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.SimpleType
		};

		// Token: 0x04001203 RID: 4611
		private static readonly XsdBuilder.State[] RedefineSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.AttributeGroup,
			XsdBuilder.State.ComplexType,
			XsdBuilder.State.Group,
			XsdBuilder.State.SimpleType
		};

		// Token: 0x04001204 RID: 4612
		private static readonly XsdBuilder.State[] AttributeGroupSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.Attribute,
			XsdBuilder.State.AttributeGroupRef,
			XsdBuilder.State.AnyAttribute
		};

		// Token: 0x04001205 RID: 4613
		private static readonly XsdBuilder.State[] GroupSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.All,
			XsdBuilder.State.Choice,
			XsdBuilder.State.Sequence
		};

		// Token: 0x04001206 RID: 4614
		private static readonly XsdBuilder.State[] AllSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.Element
		};

		// Token: 0x04001207 RID: 4615
		private static readonly XsdBuilder.State[] ChoiceSequenceSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.Element,
			XsdBuilder.State.GroupRef,
			XsdBuilder.State.Choice,
			XsdBuilder.State.Sequence,
			XsdBuilder.State.Any
		};

		// Token: 0x04001208 RID: 4616
		private static readonly XsdBuilder.State[] IdentityConstraintSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation,
			XsdBuilder.State.Selector,
			XsdBuilder.State.Field
		};

		// Token: 0x04001209 RID: 4617
		private static readonly XsdBuilder.State[] AnnotationSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.AppInfo,
			XsdBuilder.State.Documentation
		};

		// Token: 0x0400120A RID: 4618
		private static readonly XsdBuilder.State[] AnnotatedSubelements = new XsdBuilder.State[]
		{
			XsdBuilder.State.Annotation
		};

		// Token: 0x0400120B RID: 4619
		private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaAttributeFormDefault, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSchema_AttributeFormDefault)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaElementFormDefault, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSchema_ElementFormDefault)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaTargetNamespace, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSchema_TargetNamespace)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaVersion, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSchema_Version)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaFinalDefault, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSchema_FinalDefault)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaBlockDefault, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSchema_BlockDefault))
		};

		// Token: 0x0400120C RID: 4620
		private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaDefault, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttribute_Default)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaFixed, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttribute_Fixed)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaForm, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttribute_Form)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaName, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttribute_Name)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaRef, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttribute_Ref)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaType, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttribute_Type)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaUse, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttribute_Use))
		};

		// Token: 0x0400120D RID: 4621
		private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaAbstract, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Abstract)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaBlock, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Block)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaDefault, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Default)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaFinal, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Final)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaFixed, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Fixed)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaForm, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Form)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMaxOccurs, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_MaxOccurs)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMinOccurs, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_MinOccurs)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaName, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Name)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaNillable, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Nillable)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaRef, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Ref)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaSubstitutionGroup, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_SubstitutionGroup)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaType, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildElement_Type))
		};

		// Token: 0x0400120E RID: 4622
		private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaAbstract, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildComplexType_Abstract)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaBlock, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildComplexType_Block)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaFinal, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildComplexType_Final)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMixed, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildComplexType_Mixed)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaName, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildComplexType_Name))
		};

		// Token: 0x0400120F RID: 4623
		private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id))
		};

		// Token: 0x04001210 RID: 4624
		private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaBase, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSimpleContentExtension_Base)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id))
		};

		// Token: 0x04001211 RID: 4625
		private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaBase, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSimpleContentRestriction_Base)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id))
		};

		// Token: 0x04001212 RID: 4626
		private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMixed, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildComplexContent_Mixed))
		};

		// Token: 0x04001213 RID: 4627
		private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaBase, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildComplexContentExtension_Base)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id))
		};

		// Token: 0x04001214 RID: 4628
		private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaBase, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildComplexContentRestriction_Base)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id))
		};

		// Token: 0x04001215 RID: 4629
		private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaFinal, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSimpleType_Final)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaName, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSimpleType_Name))
		};

		// Token: 0x04001216 RID: 4630
		private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaBase, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSimpleTypeRestriction_Base)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id))
		};

		// Token: 0x04001217 RID: 4631
		private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMemberTypes, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSimpleTypeUnion_MemberTypes))
		};

		// Token: 0x04001218 RID: 4632
		private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaItemType, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSimpleTypeList_ItemType))
		};

		// Token: 0x04001219 RID: 4633
		private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaName, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttributeGroup_Name))
		};

		// Token: 0x0400121A RID: 4634
		private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaRef, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAttributeGroupRef_Ref))
		};

		// Token: 0x0400121B RID: 4635
		private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaName, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildGroup_Name))
		};

		// Token: 0x0400121C RID: 4636
		private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMaxOccurs, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildParticle_MaxOccurs)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMinOccurs, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildParticle_MinOccurs)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaRef, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildGroupRef_Ref))
		};

		// Token: 0x0400121D RID: 4637
		private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMaxOccurs, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildParticle_MaxOccurs)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMinOccurs, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildParticle_MinOccurs))
		};

		// Token: 0x0400121E RID: 4638
		private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMaxOccurs, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildParticle_MaxOccurs)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaMinOccurs, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildParticle_MinOccurs)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaNamespace, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAny_Namespace)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaProcessContents, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAny_ProcessContents))
		};

		// Token: 0x0400121F RID: 4639
		private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaName, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildIdentityConstraint_Name)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaRefer, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildIdentityConstraint_Refer))
		};

		// Token: 0x04001220 RID: 4640
		private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaXPath, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildSelector_XPath))
		};

		// Token: 0x04001221 RID: 4641
		private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaXPath, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildField_XPath))
		};

		// Token: 0x04001222 RID: 4642
		private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaName, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildNotation_Name)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaPublic, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildNotation_Public)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaSystem, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildNotation_System))
		};

		// Token: 0x04001223 RID: 4643
		private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaSchemaLocation, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildInclude_SchemaLocation))
		};

		// Token: 0x04001224 RID: 4644
		private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaNamespace, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildImport_Namespace)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaSchemaLocation, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildImport_SchemaLocation))
		};

		// Token: 0x04001225 RID: 4645
		private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaFixed, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildFacet_Fixed)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaValue, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildFacet_Value))
		};

		// Token: 0x04001226 RID: 4646
		private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaNamespace, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnyAttribute_Namespace)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaProcessContents, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnyAttribute_ProcessContents))
		};

		// Token: 0x04001227 RID: 4647
		private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaSource, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildDocumentation_Source)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.XmlLang, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildDocumentation_XmlLang))
		};

		// Token: 0x04001228 RID: 4648
		private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaSource, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAppinfo_Source))
		};

		// Token: 0x04001229 RID: 4649
		private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id)),
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaSchemaLocation, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildRedefine_SchemaLocation))
		};

		// Token: 0x0400122A RID: 4650
		private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes = new XsdBuilder.XsdAttributeEntry[]
		{
			new XsdBuilder.XsdAttributeEntry(SchemaNames.Token.SchemaId, new XsdBuilder.XsdBuildFunction(XsdBuilder.BuildAnnotated_Id))
		};

		// Token: 0x0400122B RID: 4651
		private static readonly XsdBuilder.XsdEntry[] SchemaEntries = new XsdBuilder.XsdEntry[]
		{
			new XsdBuilder.XsdEntry(SchemaNames.Token.Empty, XsdBuilder.State.Root, XsdBuilder.SchemaElement, null, null, null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSchema, XsdBuilder.State.Schema, XsdBuilder.SchemaSubelements, XsdBuilder.SchemaAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSchema), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdAnnotation, XsdBuilder.State.Annotation, XsdBuilder.AnnotationSubelements, XsdBuilder.AnnotationAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitAnnotation), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdInclude, XsdBuilder.State.Include, XsdBuilder.AnnotatedSubelements, XsdBuilder.IncludeAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitInclude), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdImport, XsdBuilder.State.Import, XsdBuilder.AnnotatedSubelements, XsdBuilder.ImportAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitImport), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdElement, XsdBuilder.State.Element, XsdBuilder.ElementSubelements, XsdBuilder.ElementAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitElement), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdAttribute, XsdBuilder.State.Attribute, XsdBuilder.AttributeSubelements, XsdBuilder.AttributeAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitAttribute), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.xsdAttributeGroup, XsdBuilder.State.AttributeGroup, XsdBuilder.AttributeGroupSubelements, XsdBuilder.AttributeGroupAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitAttributeGroup), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.xsdAttributeGroup, XsdBuilder.State.AttributeGroupRef, XsdBuilder.AnnotatedSubelements, XsdBuilder.AttributeGroupRefAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitAttributeGroupRef), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdAnyAttribute, XsdBuilder.State.AnyAttribute, XsdBuilder.AnnotatedSubelements, XsdBuilder.AnyAttributeAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitAnyAttribute), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdGroup, XsdBuilder.State.Group, XsdBuilder.GroupSubelements, XsdBuilder.GroupAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitGroup), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdGroup, XsdBuilder.State.GroupRef, XsdBuilder.AnnotatedSubelements, XsdBuilder.GroupRefAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitGroupRef), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdAll, XsdBuilder.State.All, XsdBuilder.AllSubelements, XsdBuilder.ParticleAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitAll), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdChoice, XsdBuilder.State.Choice, XsdBuilder.ChoiceSequenceSubelements, XsdBuilder.ParticleAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitChoice), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSequence, XsdBuilder.State.Sequence, XsdBuilder.ChoiceSequenceSubelements, XsdBuilder.ParticleAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSequence), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdAny, XsdBuilder.State.Any, XsdBuilder.AnnotatedSubelements, XsdBuilder.AnyAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitAny), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdNotation, XsdBuilder.State.Notation, XsdBuilder.AnnotatedSubelements, XsdBuilder.NotationAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitNotation), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSimpleType, XsdBuilder.State.SimpleType, XsdBuilder.SimpleTypeSubelements, XsdBuilder.SimpleTypeAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSimpleType), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdComplexType, XsdBuilder.State.ComplexType, XsdBuilder.ComplexTypeSubelements, XsdBuilder.ComplexTypeAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitComplexType), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdComplexContent, XsdBuilder.State.ComplexContent, XsdBuilder.ComplexContentSubelements, XsdBuilder.ComplexContentAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitComplexContent), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdComplexContentRestriction, XsdBuilder.State.ComplexContentRestriction, XsdBuilder.ComplexContentRestrictionSubelements, XsdBuilder.ComplexContentRestrictionAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitComplexContentRestriction), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdComplexContentExtension, XsdBuilder.State.ComplexContentExtension, XsdBuilder.ComplexContentExtensionSubelements, XsdBuilder.ComplexContentExtensionAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitComplexContentExtension), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSimpleContent, XsdBuilder.State.SimpleContent, XsdBuilder.SimpleContentSubelements, XsdBuilder.SimpleContentAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSimpleContent), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSimpleContentExtension, XsdBuilder.State.SimpleContentExtension, XsdBuilder.SimpleContentExtensionSubelements, XsdBuilder.SimpleContentExtensionAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSimpleContentExtension), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSimpleContentRestriction, XsdBuilder.State.SimpleContentRestriction, XsdBuilder.SimpleContentRestrictionSubelements, XsdBuilder.SimpleContentRestrictionAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSimpleContentRestriction), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSimpleTypeUnion, XsdBuilder.State.SimpleTypeUnion, XsdBuilder.SimpleTypeUnionSubelements, XsdBuilder.SimpleTypeUnionAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSimpleTypeUnion), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSimpleTypeList, XsdBuilder.State.SimpleTypeList, XsdBuilder.SimpleTypeListSubelements, XsdBuilder.SimpleTypeListAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSimpleTypeList), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSimpleTypeRestriction, XsdBuilder.State.SimpleTypeRestriction, XsdBuilder.SimpleTypeRestrictionSubelements, XsdBuilder.SimpleTypeRestrictionAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSimpleTypeRestriction), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdUnique, XsdBuilder.State.Unique, XsdBuilder.IdentityConstraintSubelements, XsdBuilder.IdentityConstraintAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitIdentityConstraint), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdKey, XsdBuilder.State.Key, XsdBuilder.IdentityConstraintSubelements, XsdBuilder.IdentityConstraintAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitIdentityConstraint), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdKeyref, XsdBuilder.State.KeyRef, XsdBuilder.IdentityConstraintSubelements, XsdBuilder.IdentityConstraintAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitIdentityConstraint), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdSelector, XsdBuilder.State.Selector, XsdBuilder.AnnotatedSubelements, XsdBuilder.SelectorAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitSelector), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdField, XsdBuilder.State.Field, XsdBuilder.AnnotatedSubelements, XsdBuilder.FieldAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitField), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdMinExclusive, XsdBuilder.State.MinExclusive, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdMinInclusive, XsdBuilder.State.MinInclusive, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdMaxExclusive, XsdBuilder.State.MaxExclusive, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdMaxInclusive, XsdBuilder.State.MaxInclusive, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdTotalDigits, XsdBuilder.State.TotalDigits, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdFractionDigits, XsdBuilder.State.FractionDigits, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdLength, XsdBuilder.State.Length, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdMinLength, XsdBuilder.State.MinLength, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdMaxLength, XsdBuilder.State.MaxLength, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdEnumeration, XsdBuilder.State.Enumeration, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdPattern, XsdBuilder.State.Pattern, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdWhitespace, XsdBuilder.State.WhiteSpace, XsdBuilder.AnnotatedSubelements, XsdBuilder.FacetAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitFacet), null, true),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdAppInfo, XsdBuilder.State.AppInfo, null, XsdBuilder.AppinfoAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitAppinfo), new XsdBuilder.XsdEndChildFunction(XsdBuilder.EndAppinfo), false),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdDocumentation, XsdBuilder.State.Documentation, null, XsdBuilder.DocumentationAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitDocumentation), new XsdBuilder.XsdEndChildFunction(XsdBuilder.EndDocumentation), false),
			new XsdBuilder.XsdEntry(SchemaNames.Token.XsdRedefine, XsdBuilder.State.Redefine, XsdBuilder.RedefineSubelements, XsdBuilder.RedefineAttributes, new XsdBuilder.XsdInitFunction(XsdBuilder.InitRedefine), new XsdBuilder.XsdEndChildFunction(XsdBuilder.EndRedefine), true)
		};

		// Token: 0x0400122C RID: 4652
		private static readonly int[] DerivationMethodValues = new int[]
		{
			1,
			2,
			4,
			8,
			16,
			255
		};

		// Token: 0x0400122D RID: 4653
		private static readonly string[] DerivationMethodStrings = new string[]
		{
			"substitution",
			"extension",
			"restriction",
			"list",
			"union",
			"#all"
		};

		// Token: 0x0400122E RID: 4654
		private static readonly string[] FormStringValues = new string[]
		{
			"qualified",
			"unqualified"
		};

		// Token: 0x0400122F RID: 4655
		private static readonly string[] UseStringValues = new string[]
		{
			"optional",
			"prohibited",
			"required"
		};

		// Token: 0x04001230 RID: 4656
		private static readonly string[] ProcessContentsStringValues = new string[]
		{
			"skip",
			"lax",
			"strict"
		};

		// Token: 0x04001231 RID: 4657
		private XmlReader reader;

		// Token: 0x04001232 RID: 4658
		private PositionInfo positionInfo;

		// Token: 0x04001233 RID: 4659
		private XsdBuilder.XsdEntry currentEntry;

		// Token: 0x04001234 RID: 4660
		private XsdBuilder.XsdEntry nextEntry;

		// Token: 0x04001235 RID: 4661
		private bool hasChild;

		// Token: 0x04001236 RID: 4662
		private HWStack stateHistory = new HWStack(10);

		// Token: 0x04001237 RID: 4663
		private Stack containerStack = new Stack();

		// Token: 0x04001238 RID: 4664
		private XmlNameTable nameTable;

		// Token: 0x04001239 RID: 4665
		private SchemaNames schemaNames;

		// Token: 0x0400123A RID: 4666
		private XmlNamespaceManager namespaceManager;

		// Token: 0x0400123B RID: 4667
		private bool canIncludeImport;

		// Token: 0x0400123C RID: 4668
		private XmlSchema schema;

		// Token: 0x0400123D RID: 4669
		private XmlSchemaObject xso;

		// Token: 0x0400123E RID: 4670
		private XmlSchemaElement element;

		// Token: 0x0400123F RID: 4671
		private XmlSchemaAny anyElement;

		// Token: 0x04001240 RID: 4672
		private XmlSchemaAttribute attribute;

		// Token: 0x04001241 RID: 4673
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04001242 RID: 4674
		private XmlSchemaComplexType complexType;

		// Token: 0x04001243 RID: 4675
		private XmlSchemaSimpleType simpleType;

		// Token: 0x04001244 RID: 4676
		private XmlSchemaComplexContent complexContent;

		// Token: 0x04001245 RID: 4677
		private XmlSchemaComplexContentExtension complexContentExtension;

		// Token: 0x04001246 RID: 4678
		private XmlSchemaComplexContentRestriction complexContentRestriction;

		// Token: 0x04001247 RID: 4679
		private XmlSchemaSimpleContent simpleContent;

		// Token: 0x04001248 RID: 4680
		private XmlSchemaSimpleContentExtension simpleContentExtension;

		// Token: 0x04001249 RID: 4681
		private XmlSchemaSimpleContentRestriction simpleContentRestriction;

		// Token: 0x0400124A RID: 4682
		private XmlSchemaSimpleTypeUnion simpleTypeUnion;

		// Token: 0x0400124B RID: 4683
		private XmlSchemaSimpleTypeList simpleTypeList;

		// Token: 0x0400124C RID: 4684
		private XmlSchemaSimpleTypeRestriction simpleTypeRestriction;

		// Token: 0x0400124D RID: 4685
		private XmlSchemaGroup group;

		// Token: 0x0400124E RID: 4686
		private XmlSchemaGroupRef groupRef;

		// Token: 0x0400124F RID: 4687
		private XmlSchemaAll all;

		// Token: 0x04001250 RID: 4688
		private XmlSchemaChoice choice;

		// Token: 0x04001251 RID: 4689
		private XmlSchemaSequence sequence;

		// Token: 0x04001252 RID: 4690
		private XmlSchemaParticle particle;

		// Token: 0x04001253 RID: 4691
		private XmlSchemaAttributeGroup attributeGroup;

		// Token: 0x04001254 RID: 4692
		private XmlSchemaAttributeGroupRef attributeGroupRef;

		// Token: 0x04001255 RID: 4693
		private XmlSchemaNotation notation;

		// Token: 0x04001256 RID: 4694
		private XmlSchemaIdentityConstraint identityConstraint;

		// Token: 0x04001257 RID: 4695
		private XmlSchemaXPath xpath;

		// Token: 0x04001258 RID: 4696
		private XmlSchemaInclude include;

		// Token: 0x04001259 RID: 4697
		private XmlSchemaImport import;

		// Token: 0x0400125A RID: 4698
		private XmlSchemaAnnotation annotation;

		// Token: 0x0400125B RID: 4699
		private XmlSchemaAppInfo appInfo;

		// Token: 0x0400125C RID: 4700
		private XmlSchemaDocumentation documentation;

		// Token: 0x0400125D RID: 4701
		private XmlSchemaFacet facet;

		// Token: 0x0400125E RID: 4702
		private XmlNode[] markup;

		// Token: 0x0400125F RID: 4703
		private XmlSchemaRedefine redefine;

		// Token: 0x04001260 RID: 4704
		private ValidationEventHandler validationEventHandler;

		// Token: 0x04001261 RID: 4705
		private ArrayList unhandledAttributes = new ArrayList();

		// Token: 0x04001262 RID: 4706
		private Hashtable namespaces;

		// Token: 0x0200033A RID: 826
		private enum State
		{
			// Token: 0x04001264 RID: 4708
			Root,
			// Token: 0x04001265 RID: 4709
			Schema,
			// Token: 0x04001266 RID: 4710
			Annotation,
			// Token: 0x04001267 RID: 4711
			Include,
			// Token: 0x04001268 RID: 4712
			Import,
			// Token: 0x04001269 RID: 4713
			Element,
			// Token: 0x0400126A RID: 4714
			Attribute,
			// Token: 0x0400126B RID: 4715
			AttributeGroup,
			// Token: 0x0400126C RID: 4716
			AttributeGroupRef,
			// Token: 0x0400126D RID: 4717
			AnyAttribute,
			// Token: 0x0400126E RID: 4718
			Group,
			// Token: 0x0400126F RID: 4719
			GroupRef,
			// Token: 0x04001270 RID: 4720
			All,
			// Token: 0x04001271 RID: 4721
			Choice,
			// Token: 0x04001272 RID: 4722
			Sequence,
			// Token: 0x04001273 RID: 4723
			Any,
			// Token: 0x04001274 RID: 4724
			Notation,
			// Token: 0x04001275 RID: 4725
			SimpleType,
			// Token: 0x04001276 RID: 4726
			ComplexType,
			// Token: 0x04001277 RID: 4727
			ComplexContent,
			// Token: 0x04001278 RID: 4728
			ComplexContentRestriction,
			// Token: 0x04001279 RID: 4729
			ComplexContentExtension,
			// Token: 0x0400127A RID: 4730
			SimpleContent,
			// Token: 0x0400127B RID: 4731
			SimpleContentExtension,
			// Token: 0x0400127C RID: 4732
			SimpleContentRestriction,
			// Token: 0x0400127D RID: 4733
			SimpleTypeUnion,
			// Token: 0x0400127E RID: 4734
			SimpleTypeList,
			// Token: 0x0400127F RID: 4735
			SimpleTypeRestriction,
			// Token: 0x04001280 RID: 4736
			Unique,
			// Token: 0x04001281 RID: 4737
			Key,
			// Token: 0x04001282 RID: 4738
			KeyRef,
			// Token: 0x04001283 RID: 4739
			Selector,
			// Token: 0x04001284 RID: 4740
			Field,
			// Token: 0x04001285 RID: 4741
			MinExclusive,
			// Token: 0x04001286 RID: 4742
			MinInclusive,
			// Token: 0x04001287 RID: 4743
			MaxExclusive,
			// Token: 0x04001288 RID: 4744
			MaxInclusive,
			// Token: 0x04001289 RID: 4745
			TotalDigits,
			// Token: 0x0400128A RID: 4746
			FractionDigits,
			// Token: 0x0400128B RID: 4747
			Length,
			// Token: 0x0400128C RID: 4748
			MinLength,
			// Token: 0x0400128D RID: 4749
			MaxLength,
			// Token: 0x0400128E RID: 4750
			Enumeration,
			// Token: 0x0400128F RID: 4751
			Pattern,
			// Token: 0x04001290 RID: 4752
			WhiteSpace,
			// Token: 0x04001291 RID: 4753
			AppInfo,
			// Token: 0x04001292 RID: 4754
			Documentation,
			// Token: 0x04001293 RID: 4755
			Redefine
		}

		// Token: 0x0200033B RID: 827
		// (Invoke) Token: 0x06001CE0 RID: 7392
		private delegate void XsdBuildFunction(XsdBuilder builder, string value);

		// Token: 0x0200033C RID: 828
		// (Invoke) Token: 0x06001CE4 RID: 7396
		private delegate void XsdInitFunction(XsdBuilder builder, string value);

		// Token: 0x0200033D RID: 829
		// (Invoke) Token: 0x06001CE8 RID: 7400
		private delegate void XsdEndChildFunction(XsdBuilder builder);

		// Token: 0x0200033E RID: 830
		private sealed class XsdAttributeEntry
		{
			// Token: 0x06001CEB RID: 7403 RVA: 0x000A7BC6 File Offset: 0x000A5DC6
			public XsdAttributeEntry(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build)
			{
				this.Attribute = a;
				this.BuildFunc = build;
			}

			// Token: 0x04001294 RID: 4756
			public SchemaNames.Token Attribute;

			// Token: 0x04001295 RID: 4757
			public XsdBuilder.XsdBuildFunction BuildFunc;
		}

		// Token: 0x0200033F RID: 831
		private sealed class XsdEntry
		{
			// Token: 0x06001CEC RID: 7404 RVA: 0x000A7BDC File Offset: 0x000A5DDC
			public XsdEntry(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent)
			{
				this.Name = n;
				this.CurrentState = state;
				this.NextStates = nextStates;
				this.Attributes = attributes;
				this.InitFunc = init;
				this.EndChildFunc = end;
				this.ParseContent = parseContent;
			}

			// Token: 0x04001296 RID: 4758
			public SchemaNames.Token Name;

			// Token: 0x04001297 RID: 4759
			public XsdBuilder.State CurrentState;

			// Token: 0x04001298 RID: 4760
			public XsdBuilder.State[] NextStates;

			// Token: 0x04001299 RID: 4761
			public XsdBuilder.XsdAttributeEntry[] Attributes;

			// Token: 0x0400129A RID: 4762
			public XsdBuilder.XsdInitFunction InitFunc;

			// Token: 0x0400129B RID: 4763
			public XsdBuilder.XsdEndChildFunction EndChildFunc;

			// Token: 0x0400129C RID: 4764
			public bool ParseContent;
		}

		// Token: 0x02000340 RID: 832
		private class BuilderNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x06001CED RID: 7405 RVA: 0x000A7C19 File Offset: 0x000A5E19
			public BuilderNamespaceManager(XmlNamespaceManager nsMgr, XmlReader reader)
			{
				this.nsMgr = nsMgr;
				this.reader = reader;
			}

			// Token: 0x06001CEE RID: 7406 RVA: 0x000A7C30 File Offset: 0x000A5E30
			public override string LookupNamespace(string prefix)
			{
				string text = this.nsMgr.LookupNamespace(prefix);
				if (text == null)
				{
					text = this.reader.LookupNamespace(prefix);
				}
				return text;
			}

			// Token: 0x0400129D RID: 4765
			private XmlNamespaceManager nsMgr;

			// Token: 0x0400129E RID: 4766
			private XmlReader reader;
		}
	}
}
