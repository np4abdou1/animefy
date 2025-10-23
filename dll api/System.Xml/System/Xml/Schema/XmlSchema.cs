using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using System.Xml.XmlConfiguration;

namespace System.Xml.Schema
{
	/// <summary>An in-memory representation of an XML Schema, as specified in the World Wide Web Consortium (W3C) XML Schema Part 1: Structures and XML Schema Part 2: Datatypes specifications.</summary>
	// Token: 0x020002CF RID: 719
	[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
	public class XmlSchema : XmlSchemaObject
	{
		/// <summary>Reads an XML Schema from the supplied <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="reader">The <see langword="TextReader" /> containing the XML Schema to read. </param>
		/// <param name="validationEventHandler">The validation event handler that receives information about the XML Schema syntax errors. </param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchema" /> object representing the XML Schema.</returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">An <see cref="T:System.Xml.Schema.XmlSchemaException" /> is raised if no <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified.</exception>
		// Token: 0x060017BE RID: 6078 RVA: 0x0009558B File Offset: 0x0009378B
		public static XmlSchema Read(TextReader reader, ValidationEventHandler validationEventHandler)
		{
			return XmlSchema.Read(new XmlTextReader(reader), validationEventHandler);
		}

		/// <summary>Reads an XML Schema  from the supplied stream.</summary>
		/// <param name="stream">The supplied data stream. </param>
		/// <param name="validationEventHandler">The validation event handler that receives information about XML Schema syntax errors. </param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchema" /> object representing the XML Schema.</returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">An <see cref="T:System.Xml.Schema.XmlSchemaException" /> is raised if no <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified.</exception>
		// Token: 0x060017BF RID: 6079 RVA: 0x00095599 File Offset: 0x00093799
		public static XmlSchema Read(Stream stream, ValidationEventHandler validationEventHandler)
		{
			return XmlSchema.Read(new XmlTextReader(stream), validationEventHandler);
		}

		/// <summary>Reads an XML Schema from the supplied <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="reader">The <see langword="XmlReader" /> containing the XML Schema to read. </param>
		/// <param name="validationEventHandler">The validation event handler that receives information about the XML Schema syntax errors. </param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchema" /> object representing the XML Schema.</returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">An <see cref="T:System.Xml.Schema.XmlSchemaException" /> is raised if no <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified.</exception>
		// Token: 0x060017C0 RID: 6080 RVA: 0x000955A8 File Offset: 0x000937A8
		public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler)
		{
			XmlNameTable xmlNameTable = reader.NameTable;
			Parser parser = new Parser(SchemaType.XSD, xmlNameTable, new SchemaNames(xmlNameTable), validationEventHandler);
			try
			{
				parser.Parse(reader, null);
			}
			catch (XmlSchemaException ex)
			{
				if (validationEventHandler != null)
				{
					validationEventHandler(null, new ValidationEventArgs(ex));
					return null;
				}
				throw ex;
			}
			return parser.XmlSchema;
		}

		/// <summary>Writes the XML Schema to the supplied data stream.</summary>
		/// <param name="stream">The supplied data stream. </param>
		// Token: 0x060017C1 RID: 6081 RVA: 0x00095608 File Offset: 0x00093808
		public void Write(Stream stream)
		{
			this.Write(stream, null);
		}

		/// <summary>Writes the XML Schema to the supplied <see cref="T:System.IO.Stream" /> using the <see cref="T:System.Xml.XmlNamespaceManager" /> specified.</summary>
		/// <param name="stream">The supplied data stream. </param>
		/// <param name="namespaceManager">The <see cref="T:System.Xml.XmlNamespaceManager" />.</param>
		// Token: 0x060017C2 RID: 6082 RVA: 0x00095614 File Offset: 0x00093814
		public void Write(Stream stream, XmlNamespaceManager namespaceManager)
		{
			this.Write(new XmlTextWriter(stream, null)
			{
				Formatting = Formatting.Indented
			}, namespaceManager);
		}

		/// <summary>Writes the XML Schema to the supplied <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to write to.</param>
		// Token: 0x060017C3 RID: 6083 RVA: 0x00095638 File Offset: 0x00093838
		public void Write(TextWriter writer)
		{
			this.Write(writer, null);
		}

		/// <summary>Writes the XML Schema to the supplied <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to write to.</param>
		/// <param name="namespaceManager">The <see cref="T:System.Xml.XmlNamespaceManager" />. </param>
		// Token: 0x060017C4 RID: 6084 RVA: 0x00095644 File Offset: 0x00093844
		public void Write(TextWriter writer, XmlNamespaceManager namespaceManager)
		{
			this.Write(new XmlTextWriter(writer)
			{
				Formatting = Formatting.Indented
			}, namespaceManager);
		}

		/// <summary>Writes the XML Schema to the supplied <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to write to. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="writer" /> parameter is null.</exception>
		// Token: 0x060017C5 RID: 6085 RVA: 0x00095667 File Offset: 0x00093867
		public void Write(XmlWriter writer)
		{
			this.Write(writer, null);
		}

		/// <summary>Writes the XML Schema to the supplied <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to write to.</param>
		/// <param name="namespaceManager">The <see cref="T:System.Xml.XmlNamespaceManager" />. </param>
		// Token: 0x060017C6 RID: 6086 RVA: 0x00095674 File Offset: 0x00093874
		public void Write(XmlWriter writer, XmlNamespaceManager namespaceManager)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(XmlSchema));
			XmlSerializerNamespaces xmlSerializerNamespaces;
			if (namespaceManager != null)
			{
				xmlSerializerNamespaces = new XmlSerializerNamespaces();
				bool flag = false;
				if (base.Namespaces != null)
				{
					flag = (base.Namespaces.Namespaces["xs"] != null || base.Namespaces.Namespaces.ContainsValue("http://www.w3.org/2001/XMLSchema"));
				}
				if (!flag && namespaceManager.LookupPrefix("http://www.w3.org/2001/XMLSchema") == null && namespaceManager.LookupNamespace("xs") == null)
				{
					xmlSerializerNamespaces.Add("xs", "http://www.w3.org/2001/XMLSchema");
				}
				using (IEnumerator enumerator = namespaceManager.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						string text = (string)obj;
						if (text != "xml" && text != "xmlns")
						{
							xmlSerializerNamespaces.Add(text, namespaceManager.LookupNamespace(text));
						}
					}
					goto IL_17B;
				}
			}
			if (base.Namespaces != null && base.Namespaces.Count > 0)
			{
				Hashtable namespaces = base.Namespaces.Namespaces;
				if (namespaces["xs"] == null && !namespaces.ContainsValue("http://www.w3.org/2001/XMLSchema"))
				{
					namespaces.Add("xs", "http://www.w3.org/2001/XMLSchema");
				}
				xmlSerializerNamespaces = base.Namespaces;
			}
			else
			{
				xmlSerializerNamespaces = new XmlSerializerNamespaces();
				xmlSerializerNamespaces.Add("xs", "http://www.w3.org/2001/XMLSchema");
				if (this.targetNs != null && this.targetNs.Length != 0)
				{
					xmlSerializerNamespaces.Add("tns", this.targetNs);
				}
			}
			IL_17B:
			xmlSerializer.Serialize(writer, this, xmlSerializerNamespaces);
		}

		/// <summary>Compiles the XML Schema Object Model (SOM) into schema information for validation. Used to check the syntactic and semantic structure of the programmatically built SOM. Semantic validation checking is performed during compilation.</summary>
		/// <param name="validationEventHandler">The validation event handler that receives information about XML Schema validation errors. </param>
		// Token: 0x060017C7 RID: 6087 RVA: 0x00095818 File Offset: 0x00093A18
		public void Compile(ValidationEventHandler validationEventHandler)
		{
			SchemaInfo schemaInfo = new SchemaInfo();
			schemaInfo.SchemaType = SchemaType.XSD;
			this.CompileSchema(null, XmlReaderSection.CreateDefaultResolver(), schemaInfo, null, validationEventHandler, this.NameTable, false);
		}

		/// <summary>Compiles the XML Schema Object Model (SOM) into schema information for validation. Used to check the syntactic and semantic structure of the programmatically built SOM. Semantic validation checking is performed during compilation.</summary>
		/// <param name="validationEventHandler">The validation event handler that receives information about the XML Schema validation errors. </param>
		/// <param name="resolver">The <see langword="XmlResolver" /> used to resolve namespaces referenced in <see langword="include" /> and <see langword="import" /> elements. </param>
		// Token: 0x060017C8 RID: 6088 RVA: 0x0009584C File Offset: 0x00093A4C
		public void Compile(ValidationEventHandler validationEventHandler, XmlResolver resolver)
		{
			this.CompileSchema(null, resolver, new SchemaInfo
			{
				SchemaType = SchemaType.XSD
			}, null, validationEventHandler, this.NameTable, false);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0009587C File Offset: 0x00093A7C
		internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel)
		{
			bool result;
			lock (this)
			{
				if (!new SchemaCollectionPreprocessor(nameTable, null, validationEventHandler)
				{
					XmlResolver = resolver
				}.Execute(this, ns, true, xsc))
				{
					result = false;
				}
				else
				{
					SchemaCollectionCompiler schemaCollectionCompiler = new SchemaCollectionCompiler(nameTable, validationEventHandler);
					this.isCompiled = schemaCollectionCompiler.Execute(this, schemaInfo, CompileContentModel);
					this.SetIsCompiled(this.isCompiled);
					result = this.isCompiled;
				}
			}
			return result;
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00095900 File Offset: 0x00093B00
		internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
		{
			Compiler compiler = new Compiler(nameTable, eventHandler, null, compilationSettings);
			compiler.Prepare(this, true);
			this.isCompiledBySet = compiler.Compile();
		}

		/// <summary>Gets or sets the form for attributes declared in the target namespace of the schema.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaForm" /> value that indicates if attributes from the target namespace are required to be qualified with the namespace prefix. The default is <see cref="F:System.Xml.Schema.XmlSchemaForm.None" />.</returns>
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0009592B File Offset: 0x00093B2B
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x00095933 File Offset: 0x00093B33
		[XmlAttribute("attributeFormDefault")]
		[DefaultValue(XmlSchemaForm.None)]
		public XmlSchemaForm AttributeFormDefault
		{
			get
			{
				return this.attributeFormDefault;
			}
			set
			{
				this.attributeFormDefault = value;
			}
		}

		/// <summary>Gets or sets the <see langword="blockDefault" /> attribute which sets the default value of the <see langword="block" /> attribute on element and complex types in the <see langword="targetNamespace" /> of the schema.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> value representing the different methods for preventing derivation. The default value is <see langword="XmlSchemaDerivationMethod.None" />.</returns>
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x0009593C File Offset: 0x00093B3C
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x00095944 File Offset: 0x00093B44
		[XmlAttribute("blockDefault")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
		public XmlSchemaDerivationMethod BlockDefault
		{
			get
			{
				return this.blockDefault;
			}
			set
			{
				this.blockDefault = value;
			}
		}

		/// <summary>Gets or sets the <see langword="finalDefault" /> attribute which sets the default value of the <see langword="final" /> attribute on elements and complex types in the target namespace of the schema.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> value representing the different methods for preventing derivation. The default value is <see langword="XmlSchemaDerivationMethod.None" />.</returns>
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0009594D File Offset: 0x00093B4D
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x00095955 File Offset: 0x00093B55
		[XmlAttribute("finalDefault")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
		public XmlSchemaDerivationMethod FinalDefault
		{
			get
			{
				return this.finalDefault;
			}
			set
			{
				this.finalDefault = value;
			}
		}

		/// <summary>Gets or sets the form for elements declared in the target namespace of the schema.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaForm" /> value that indicates if elements from the target namespace are required to be qualified with the namespace prefix. The default is <see cref="F:System.Xml.Schema.XmlSchemaForm.None" />.</returns>
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0009595E File Offset: 0x00093B5E
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x00095966 File Offset: 0x00093B66
		[XmlAttribute("elementFormDefault")]
		[DefaultValue(XmlSchemaForm.None)]
		public XmlSchemaForm ElementFormDefault
		{
			get
			{
				return this.elementFormDefault;
			}
			set
			{
				this.elementFormDefault = value;
			}
		}

		/// <summary>Gets or sets the Uniform Resource Identifier (URI) of the schema target namespace.</summary>
		/// <returns>The schema target namespace.</returns>
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0009596F File Offset: 0x00093B6F
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00095977 File Offset: 0x00093B77
		[XmlAttribute("targetNamespace", DataType = "anyURI")]
		public string TargetNamespace
		{
			get
			{
				return this.targetNs;
			}
			set
			{
				this.targetNs = value;
			}
		}

		/// <summary>Gets or sets the version of the schema.</summary>
		/// <returns>The version of the schema. The default value is <see langword="String.Empty" />.</returns>
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00095980 File Offset: 0x00093B80
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x00095988 File Offset: 0x00093B88
		[XmlAttribute("version", DataType = "token")]
		public string Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = value;
			}
		}

		/// <summary>Gets the collection of included and imported schemas.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> of the included and imported schemas.</returns>
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00095991 File Offset: 0x00093B91
		[XmlElement("include", typeof(XmlSchemaInclude))]
		[XmlElement("import", typeof(XmlSchemaImport))]
		[XmlElement("redefine", typeof(XmlSchemaRedefine))]
		public XmlSchemaObjectCollection Includes
		{
			get
			{
				return this.includes;
			}
		}

		/// <summary>Gets the collection of schema elements in the schema and is used to add new element types at the <see langword="schema" /> element level.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> of schema elements in the schema.</returns>
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x00095999 File Offset: 0x00093B99
		[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
		[XmlElement("complexType", typeof(XmlSchemaComplexType))]
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("group", typeof(XmlSchemaGroup))]
		[XmlElement("notation", typeof(XmlSchemaNotation))]
		public XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		/// <summary>Indicates if the schema has been compiled.</summary>
		/// <returns>
		///     <see langword="true" /> if schema has been compiled, otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x000959A1 File Offset: 0x00093BA1
		[XmlIgnore]
		public bool IsCompiled
		{
			get
			{
				return this.isCompiled || this.isCompiledBySet;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x000959B3 File Offset: 0x00093BB3
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x000959BB File Offset: 0x00093BBB
		[XmlIgnore]
		internal bool IsCompiledBySet
		{
			get
			{
				return this.isCompiledBySet;
			}
			set
			{
				this.isCompiledBySet = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x000959C4 File Offset: 0x00093BC4
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x000959CC File Offset: 0x00093BCC
		[XmlIgnore]
		internal bool IsPreprocessed
		{
			get
			{
				return this.isPreprocessed;
			}
			set
			{
				this.isPreprocessed = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x000959D5 File Offset: 0x00093BD5
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x000959DD File Offset: 0x00093BDD
		[XmlIgnore]
		internal bool IsRedefined
		{
			get
			{
				return this.isRedefined;
			}
			set
			{
				this.isRedefined = value;
			}
		}

		/// <summary>Gets the post-schema-compilation value for all the attributes in the schema.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all the attributes in the schema.</returns>
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x000959E6 File Offset: 0x00093BE6
		[XmlIgnore]
		public XmlSchemaObjectTable Attributes
		{
			get
			{
				if (this.attributes == null)
				{
					this.attributes = new XmlSchemaObjectTable();
				}
				return this.attributes;
			}
		}

		/// <summary>Gets the post-schema-compilation value of all the global attribute groups in the schema.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all the global attribute groups in the schema.</returns>
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00095A01 File Offset: 0x00093C01
		[XmlIgnore]
		public XmlSchemaObjectTable AttributeGroups
		{
			get
			{
				if (this.attributeGroups == null)
				{
					this.attributeGroups = new XmlSchemaObjectTable();
				}
				return this.attributeGroups;
			}
		}

		/// <summary>Gets the post-schema-compilation value of all schema types in the schema.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> of all schema types in the schema.</returns>
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00095A1C File Offset: 0x00093C1C
		[XmlIgnore]
		public XmlSchemaObjectTable SchemaTypes
		{
			get
			{
				if (this.types == null)
				{
					this.types = new XmlSchemaObjectTable();
				}
				return this.types;
			}
		}

		/// <summary>Gets the post-schema-compilation value for all the elements in the schema.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all the elements in the schema.</returns>
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00095A37 File Offset: 0x00093C37
		[XmlIgnore]
		public XmlSchemaObjectTable Elements
		{
			get
			{
				if (this.elements == null)
				{
					this.elements = new XmlSchemaObjectTable();
				}
				return this.elements;
			}
		}

		/// <summary>Gets or sets the string ID.</summary>
		/// <returns>The ID of the string. The default value is <see langword="String.Empty" />.</returns>
		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00095A52 File Offset: 0x00093C52
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x00095A5A File Offset: 0x00093C5A
		[XmlAttribute("id", DataType = "ID")]
		public string Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		/// <summary>Gets and sets the qualified attributes which do not belong to the schema target namespace.</summary>
		/// <returns>An array of qualified <see cref="T:System.Xml.XmlAttribute" /> objects that do not belong to the schema target namespace.</returns>
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00095A63 File Offset: 0x00093C63
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x00095A6B File Offset: 0x00093C6B
		[XmlAnyAttribute]
		public XmlAttribute[] UnhandledAttributes
		{
			get
			{
				return this.moreAttributes;
			}
			set
			{
				this.moreAttributes = value;
			}
		}

		/// <summary>Gets the post-schema-compilation value of all the groups in the schema.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all the groups in the schema.</returns>
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00095A74 File Offset: 0x00093C74
		[XmlIgnore]
		public XmlSchemaObjectTable Groups
		{
			get
			{
				return this.groups;
			}
		}

		/// <summary>Gets the post-schema-compilation value for all notations in the schema.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all notations in the schema.</returns>
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00095A7C File Offset: 0x00093C7C
		[XmlIgnore]
		public XmlSchemaObjectTable Notations
		{
			get
			{
				return this.notations;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00095A84 File Offset: 0x00093C84
		[XmlIgnore]
		internal XmlSchemaObjectTable IdentityConstraints
		{
			get
			{
				return this.identityConstraints;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x00095A8C File Offset: 0x00093C8C
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x00095A94 File Offset: 0x00093C94
		[XmlIgnore]
		internal Uri BaseUri
		{
			get
			{
				return this.baseUri;
			}
			set
			{
				this.baseUri = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00095A9D File Offset: 0x00093C9D
		[XmlIgnore]
		internal int SchemaId
		{
			get
			{
				if (this.schemaId == -1)
				{
					this.schemaId = Interlocked.Increment(ref XmlSchema.globalIdCounter);
				}
				return this.schemaId;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00095ABE File Offset: 0x00093CBE
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x00095AC6 File Offset: 0x00093CC6
		[XmlIgnore]
		internal bool IsChameleon
		{
			get
			{
				return this.isChameleon;
			}
			set
			{
				this.isChameleon = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00095ACF File Offset: 0x00093CCF
		[XmlIgnore]
		internal Hashtable Ids
		{
			get
			{
				return this.ids;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x00095AD7 File Offset: 0x00093CD7
		[XmlIgnore]
		internal XmlDocument Document
		{
			get
			{
				if (this.document == null)
				{
					this.document = new XmlDocument();
				}
				return this.document;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00095AF2 File Offset: 0x00093CF2
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x00095AFA File Offset: 0x00093CFA
		[XmlIgnore]
		internal int ErrorCount
		{
			get
			{
				return this.errorCount;
			}
			set
			{
				this.errorCount = value;
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00095B04 File Offset: 0x00093D04
		internal new XmlSchema Clone()
		{
			XmlSchema xmlSchema = new XmlSchema();
			xmlSchema.attributeFormDefault = this.attributeFormDefault;
			xmlSchema.elementFormDefault = this.elementFormDefault;
			xmlSchema.blockDefault = this.blockDefault;
			xmlSchema.finalDefault = this.finalDefault;
			xmlSchema.targetNs = this.targetNs;
			xmlSchema.version = this.version;
			xmlSchema.includes = this.includes;
			xmlSchema.Namespaces = base.Namespaces;
			xmlSchema.items = this.items;
			xmlSchema.BaseUri = this.BaseUri;
			SchemaCollectionCompiler.Cleanup(xmlSchema);
			return xmlSchema;
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00095B94 File Offset: 0x00093D94
		internal XmlSchema DeepClone()
		{
			XmlSchema xmlSchema = new XmlSchema();
			xmlSchema.attributeFormDefault = this.attributeFormDefault;
			xmlSchema.elementFormDefault = this.elementFormDefault;
			xmlSchema.blockDefault = this.blockDefault;
			xmlSchema.finalDefault = this.finalDefault;
			xmlSchema.targetNs = this.targetNs;
			xmlSchema.version = this.version;
			xmlSchema.isPreprocessed = this.isPreprocessed;
			for (int i = 0; i < this.items.Count; i++)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaObject item;
				XmlSchemaElement xmlSchemaElement;
				XmlSchemaGroup xmlSchemaGroup;
				if ((xmlSchemaComplexType = (this.items[i] as XmlSchemaComplexType)) != null)
				{
					item = xmlSchemaComplexType.Clone(this);
				}
				else if ((xmlSchemaElement = (this.items[i] as XmlSchemaElement)) != null)
				{
					item = xmlSchemaElement.Clone(this);
				}
				else if ((xmlSchemaGroup = (this.items[i] as XmlSchemaGroup)) != null)
				{
					item = xmlSchemaGroup.Clone(this);
				}
				else
				{
					item = this.items[i].Clone();
				}
				xmlSchema.Items.Add(item);
			}
			for (int j = 0; j < this.includes.Count; j++)
			{
				XmlSchemaExternal item2 = (XmlSchemaExternal)this.includes[j].Clone();
				xmlSchema.Includes.Add(item2);
			}
			xmlSchema.Namespaces = base.Namespaces;
			xmlSchema.BaseUri = this.BaseUri;
			return xmlSchema;
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00095CF1 File Offset: 0x00093EF1
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x00095CF9 File Offset: 0x00093EF9
		[XmlIgnore]
		internal override string IdAttribute
		{
			get
			{
				return this.Id;
			}
			set
			{
				this.Id = value;
			}
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00095D02 File Offset: 0x00093F02
		internal void SetIsCompiled(bool isCompiled)
		{
			this.isCompiled = isCompiled;
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00095A6B File Offset: 0x00093C6B
		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
			this.moreAttributes = moreAttributes;
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00095D0B File Offset: 0x00093F0B
		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			this.items.Add(annotation);
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00095D1A File Offset: 0x00093F1A
		internal XmlNameTable NameTable
		{
			get
			{
				if (this.nameTable == null)
				{
					this.nameTable = new NameTable();
				}
				return this.nameTable;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x00095D35 File Offset: 0x00093F35
		internal ArrayList ImportedSchemas
		{
			get
			{
				if (this.importedSchemas == null)
				{
					this.importedSchemas = new ArrayList();
				}
				return this.importedSchemas;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00095D50 File Offset: 0x00093F50
		internal ArrayList ImportedNamespaces
		{
			get
			{
				if (this.importedNamespaces == null)
				{
					this.importedNamespaces = new ArrayList();
				}
				return this.importedNamespaces;
			}
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00095D6C File Offset: 0x00093F6C
		internal void GetExternalSchemasList(IList extList, XmlSchema schema)
		{
			if (extList.Contains(schema))
			{
				return;
			}
			extList.Add(schema);
			for (int i = 0; i < schema.Includes.Count; i++)
			{
				XmlSchemaExternal xmlSchemaExternal = (XmlSchemaExternal)schema.Includes[i];
				if (xmlSchemaExternal.Schema != null)
				{
					this.GetExternalSchemasList(extList, xmlSchemaExternal.Schema);
				}
			}
		}

		/// <summary>The XML schema namespace. This field is constant.</summary>
		// Token: 0x0400100E RID: 4110
		public const string Namespace = "http://www.w3.org/2001/XMLSchema";

		/// <summary>The XML schema instance namespace. This field is constant. </summary>
		// Token: 0x0400100F RID: 4111
		public const string InstanceNamespace = "http://www.w3.org/2001/XMLSchema-instance";

		// Token: 0x04001010 RID: 4112
		private XmlSchemaForm attributeFormDefault;

		// Token: 0x04001011 RID: 4113
		private XmlSchemaForm elementFormDefault;

		// Token: 0x04001012 RID: 4114
		private XmlSchemaDerivationMethod blockDefault = XmlSchemaDerivationMethod.None;

		// Token: 0x04001013 RID: 4115
		private XmlSchemaDerivationMethod finalDefault = XmlSchemaDerivationMethod.None;

		// Token: 0x04001014 RID: 4116
		private string targetNs;

		// Token: 0x04001015 RID: 4117
		private string version;

		// Token: 0x04001016 RID: 4118
		private XmlSchemaObjectCollection includes = new XmlSchemaObjectCollection();

		// Token: 0x04001017 RID: 4119
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();

		// Token: 0x04001018 RID: 4120
		private string id;

		// Token: 0x04001019 RID: 4121
		private XmlAttribute[] moreAttributes;

		// Token: 0x0400101A RID: 4122
		private bool isCompiled;

		// Token: 0x0400101B RID: 4123
		private bool isCompiledBySet;

		// Token: 0x0400101C RID: 4124
		private bool isPreprocessed;

		// Token: 0x0400101D RID: 4125
		private bool isRedefined;

		// Token: 0x0400101E RID: 4126
		private int errorCount;

		// Token: 0x0400101F RID: 4127
		private XmlSchemaObjectTable attributes;

		// Token: 0x04001020 RID: 4128
		private XmlSchemaObjectTable attributeGroups = new XmlSchemaObjectTable();

		// Token: 0x04001021 RID: 4129
		private XmlSchemaObjectTable elements = new XmlSchemaObjectTable();

		// Token: 0x04001022 RID: 4130
		private XmlSchemaObjectTable types = new XmlSchemaObjectTable();

		// Token: 0x04001023 RID: 4131
		private XmlSchemaObjectTable groups = new XmlSchemaObjectTable();

		// Token: 0x04001024 RID: 4132
		private XmlSchemaObjectTable notations = new XmlSchemaObjectTable();

		// Token: 0x04001025 RID: 4133
		private XmlSchemaObjectTable identityConstraints = new XmlSchemaObjectTable();

		// Token: 0x04001026 RID: 4134
		private static int globalIdCounter = -1;

		// Token: 0x04001027 RID: 4135
		private ArrayList importedSchemas;

		// Token: 0x04001028 RID: 4136
		private ArrayList importedNamespaces;

		// Token: 0x04001029 RID: 4137
		private int schemaId = -1;

		// Token: 0x0400102A RID: 4138
		private Uri baseUri;

		// Token: 0x0400102B RID: 4139
		private bool isChameleon;

		// Token: 0x0400102C RID: 4140
		private Hashtable ids = new Hashtable();

		// Token: 0x0400102D RID: 4141
		private XmlDocument document;

		// Token: 0x0400102E RID: 4142
		private XmlNameTable nameTable;
	}
}
