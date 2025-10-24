using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace System.Xml.Schema
{
	/// <summary>Contains a cache of XML Schema definition language (XSD) schemas.</summary>
	// Token: 0x02000316 RID: 790
	public class XmlSchemaSet
	{
		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00098D18 File Offset: 0x00096F18
		internal object InternalSyncObject
		{
			get
			{
				if (this.internalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange<object>(ref this.internalSyncObject, value, null);
				}
				return this.internalSyncObject;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> class.</summary>
		// Token: 0x06001A1A RID: 6682 RVA: 0x00098D47 File Offset: 0x00096F47
		public XmlSchemaSet() : this(new NameTable())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <param name="nameTable">The <see cref="T:System.Xml.XmlNameTable" /> object to use.</param>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.XmlNameTable" /> object passed as a parameter is <see langword="null" />.</exception>
		// Token: 0x06001A1B RID: 6683 RVA: 0x00098D54 File Offset: 0x00096F54
		public XmlSchemaSet(XmlNameTable nameTable)
		{
			if (nameTable == null)
			{
				throw new ArgumentNullException("nameTable");
			}
			this.nameTable = nameTable;
			this.schemas = new SortedList();
			this.schemaLocations = new Hashtable();
			this.chameleonSchemas = new Hashtable();
			this.targetNamespaces = new Hashtable();
			this.internalEventHandler = new ValidationEventHandler(this.InternalValidationCallback);
			this.eventHandler = this.internalEventHandler;
			this.readerSettings = new XmlReaderSettings();
			if (this.readerSettings.GetXmlResolver() == null)
			{
				this.readerSettings.XmlResolver = new XmlUrlResolver();
				this.readerSettings.IsXmlResolverSet = false;
			}
			this.readerSettings.NameTable = nameTable;
			this.readerSettings.DtdProcessing = DtdProcessing.Prohibit;
			this.compilationSettings = new XmlSchemaCompilationSettings();
			this.cachedCompiledInfo = new SchemaInfo();
			this.compileAll = true;
		}

		/// <summary>Specifies an event handler for receiving information about XML Schema definition language (XSD) schema validation errors.</summary>
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06001A1C RID: 6684 RVA: 0x00098E30 File Offset: 0x00097030
		// (remove) Token: 0x06001A1D RID: 6685 RVA: 0x00098E84 File Offset: 0x00097084
		public event ValidationEventHandler ValidationEventHandler
		{
			add
			{
				this.eventHandler = (ValidationEventHandler)Delegate.Remove(this.eventHandler, this.internalEventHandler);
				this.eventHandler = (ValidationEventHandler)Delegate.Combine(this.eventHandler, value);
				if (this.eventHandler == null)
				{
					this.eventHandler = this.internalEventHandler;
				}
			}
			remove
			{
				this.eventHandler = (ValidationEventHandler)Delegate.Remove(this.eventHandler, value);
				if (this.eventHandler == null)
				{
					this.eventHandler = this.internalEventHandler;
				}
			}
		}

		/// <summary>Gets a value that indicates whether the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> have been compiled.</summary>
		/// <returns>
		///     <see langword="true" /> if the schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> have been compiled since the last time a schema was added or removed from the <see cref="T:System.Xml.Schema.XmlSchemaSet" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00098EB1 File Offset: 0x000970B1
		public bool IsCompiled
		{
			get
			{
				return this.isCompiled;
			}
		}

		/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> used to resolve namespaces or locations referenced in include and import elements of a schema.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlResolver" /> used to resolve namespaces or locations referenced in include and import elements of a schema.</returns>
		// Token: 0x1700063A RID: 1594
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x00098EB9 File Offset: 0x000970B9
		public XmlResolver XmlResolver
		{
			set
			{
				this.readerSettings.XmlResolver = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaCompilationSettings" /> for the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaCompilationSettings" /> for the <see cref="T:System.Xml.Schema.XmlSchemaSet" />. The default is an <see cref="T:System.Xml.Schema.XmlSchemaCompilationSettings" /> instance with the <see cref="P:System.Xml.Schema.XmlSchemaCompilationSettings.EnableUpaCheck" /> property set to <see langword="true" />.</returns>
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00098EC7 File Offset: 0x000970C7
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x00098ECF File Offset: 0x000970CF
		public XmlSchemaCompilationSettings CompilationSettings
		{
			get
			{
				return this.compilationSettings;
			}
			set
			{
				this.compilationSettings = value;
			}
		}

		/// <summary>Gets the number of logical XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <returns>The number of logical schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00098ED8 File Offset: 0x000970D8
		public int Count
		{
			get
			{
				return this.schemas.Count;
			}
		}

		/// <summary>Gets all the global elements in all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <returns>The collection of global elements.</returns>
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00098EE5 File Offset: 0x000970E5
		public XmlSchemaObjectTable GlobalElements
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

		/// <summary>Gets all the global attributes in all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <returns>The collection of global attributes.</returns>
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00098F00 File Offset: 0x00097100
		public XmlSchemaObjectTable GlobalAttributes
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

		/// <summary>Gets all of the global simple and complex types in all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <returns>The collection of global simple and complex types.</returns>
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00098F1B File Offset: 0x0009711B
		public XmlSchemaObjectTable GlobalTypes
		{
			get
			{
				if (this.schemaTypes == null)
				{
					this.schemaTypes = new XmlSchemaObjectTable();
				}
				return this.schemaTypes;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x00098F36 File Offset: 0x00097136
		internal XmlSchemaObjectTable SubstitutionGroups
		{
			get
			{
				if (this.substitutionGroups == null)
				{
					this.substitutionGroups = new XmlSchemaObjectTable();
				}
				return this.substitutionGroups;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00098F51 File Offset: 0x00097151
		internal Hashtable SchemaLocations
		{
			get
			{
				return this.schemaLocations;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00098F59 File Offset: 0x00097159
		internal XmlSchemaObjectTable TypeExtensions
		{
			get
			{
				if (this.typeExtensions == null)
				{
					this.typeExtensions = new XmlSchemaObjectTable();
				}
				return this.typeExtensions;
			}
		}

		/// <summary>Adds all the XML Schema definition language (XSD) schemas in the given <see cref="T:System.Xml.Schema.XmlSchemaSet" /> to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemas">The <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object.</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">A schema in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> is not valid.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object passed as a parameter is <see langword="null" />.</exception>
		// Token: 0x06001A29 RID: 6697 RVA: 0x00098F74 File Offset: 0x00097174
		public void Add(XmlSchemaSet schemas)
		{
			if (schemas == null)
			{
				throw new ArgumentNullException("schemas");
			}
			if (this == schemas)
			{
				return;
			}
			bool flag = false;
			bool flag2 = false;
			try
			{
				for (;;)
				{
					Monitor.TryEnter(this.InternalSyncObject, ref flag);
					if (flag)
					{
						Monitor.TryEnter(schemas.InternalSyncObject, ref flag2);
						if (flag2)
						{
							break;
						}
						Monitor.Exit(this.InternalSyncObject);
						flag = false;
						Thread.Yield();
					}
				}
				if (schemas.IsCompiled)
				{
					this.CopyFromCompiledSet(schemas);
				}
				else
				{
					bool flag3 = false;
					foreach (object obj in schemas.SortedSchemas.Values)
					{
						XmlSchema xmlSchema = (XmlSchema)obj;
						string text = xmlSchema.TargetNamespace;
						if (text == null)
						{
							text = string.Empty;
						}
						if (!this.schemas.ContainsKey(xmlSchema.SchemaId) && this.FindSchemaByNSAndUrl(xmlSchema.BaseUri, text, null) == null && this.Add(xmlSchema.TargetNamespace, xmlSchema) == null)
						{
							flag3 = true;
							break;
						}
					}
					if (flag3)
					{
						foreach (object obj2 in schemas.SortedSchemas.Values)
						{
							XmlSchema xmlSchema2 = (XmlSchema)obj2;
							this.schemas.Remove(xmlSchema2.SchemaId);
							this.schemaLocations.Remove(xmlSchema2.BaseUri);
						}
					}
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this.InternalSyncObject);
				}
				if (flag2)
				{
					Monitor.Exit(schemas.InternalSyncObject);
				}
			}
		}

		/// <summary>Adds the given <see cref="T:System.Xml.Schema.XmlSchema" /> to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schema">The <see cref="T:System.Xml.Schema.XmlSchema" /> object to add to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> object if the schema is valid. If the schema is not valid and a <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified, then <see langword="null" /> is returned and the appropriate validation event is raised. Otherwise, an <see cref="T:System.Xml.Schema.XmlSchemaException" /> is thrown.</returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">The schema is not valid.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchema" /> object passed as a parameter is <see langword="null" />.</exception>
		// Token: 0x06001A2A RID: 6698 RVA: 0x00099150 File Offset: 0x00097350
		public XmlSchema Add(XmlSchema schema)
		{
			if (schema == null)
			{
				throw new ArgumentNullException("schema");
			}
			object obj = this.InternalSyncObject;
			XmlSchema result;
			lock (obj)
			{
				if (this.schemas.ContainsKey(schema.SchemaId))
				{
					result = schema;
				}
				else
				{
					result = this.Add(schema.TargetNamespace, schema);
				}
			}
			return result;
		}

		/// <summary>Removes the specified XML Schema definition language (XSD) schema and all the schemas it imports from the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaToRemove">The <see cref="T:System.Xml.Schema.XmlSchema" /> object to remove from the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.Schema.XmlSchema" /> object and all its imports were successfully removed; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchema" /> passed as a parameter is <see langword="null" />.</exception>
		// Token: 0x06001A2B RID: 6699 RVA: 0x000991C4 File Offset: 0x000973C4
		public bool RemoveRecursive(XmlSchema schemaToRemove)
		{
			if (schemaToRemove == null)
			{
				throw new ArgumentNullException("schemaToRemove");
			}
			if (!this.schemas.ContainsKey(schemaToRemove.SchemaId))
			{
				return false;
			}
			object obj = this.InternalSyncObject;
			lock (obj)
			{
				if (this.schemas.ContainsKey(schemaToRemove.SchemaId))
				{
					Hashtable hashtable = new Hashtable();
					hashtable.Add(this.GetTargetNamespace(schemaToRemove), schemaToRemove);
					for (int i = 0; i < schemaToRemove.ImportedNamespaces.Count; i++)
					{
						string text = (string)schemaToRemove.ImportedNamespaces[i];
						if (hashtable[text] == null)
						{
							hashtable.Add(text, text);
						}
					}
					ArrayList arrayList = new ArrayList();
					for (int j = 0; j < this.schemas.Count; j++)
					{
						XmlSchema xmlSchema = (XmlSchema)this.schemas.GetByIndex(j);
						if (xmlSchema != schemaToRemove && !schemaToRemove.ImportedSchemas.Contains(xmlSchema))
						{
							arrayList.Add(xmlSchema);
						}
					}
					for (int k = 0; k < arrayList.Count; k++)
					{
						XmlSchema xmlSchema = (XmlSchema)arrayList[k];
						if (xmlSchema.ImportedNamespaces.Count > 0)
						{
							foreach (object obj2 in hashtable.Keys)
							{
								string item = (string)obj2;
								if (xmlSchema.ImportedNamespaces.Contains(item))
								{
									this.SendValidationEvent(new XmlSchemaException("The schema could not be removed because other schemas in the set have dependencies on this schema or its imports.", string.Empty), XmlSeverityType.Warning);
									return false;
								}
							}
						}
					}
					this.Remove(schemaToRemove, true);
					for (int l = 0; l < schemaToRemove.ImportedSchemas.Count; l++)
					{
						XmlSchema schema = (XmlSchema)schemaToRemove.ImportedSchemas[l];
						this.Remove(schema, true);
					}
					return true;
				}
			}
			return false;
		}

		/// <summary>Indicates whether an XML Schema definition language (XSD) schema with the specified target namespace URI is in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="targetNamespace">The schema targetNamespace property.</param>
		/// <returns>
		///     <see langword="true" /> if a schema with the specified target namespace URI is in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001A2C RID: 6700 RVA: 0x00099400 File Offset: 0x00097600
		public bool Contains(string targetNamespace)
		{
			if (targetNamespace == null)
			{
				targetNamespace = string.Empty;
			}
			return this.targetNamespaces[targetNamespace] != null;
		}

		/// <summary>Compiles the XML Schema definition language (XSD) schemas added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> into one logical schema.</summary>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">An error occurred when validating and compiling the schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</exception>
		// Token: 0x06001A2D RID: 6701 RVA: 0x0009941C File Offset: 0x0009761C
		public void Compile()
		{
			if (this.isCompiled)
			{
				return;
			}
			if (this.schemas.Count == 0)
			{
				this.ClearTables();
				this.cachedCompiledInfo = new SchemaInfo();
				this.isCompiled = true;
				this.compileAll = false;
				return;
			}
			object obj = this.InternalSyncObject;
			lock (obj)
			{
				if (!this.isCompiled)
				{
					Compiler compiler = new Compiler(this.nameTable, this.eventHandler, this.schemaForSchema, this.compilationSettings);
					SchemaInfo schemaInfo = new SchemaInfo();
					int i = 0;
					if (!this.compileAll)
					{
						compiler.ImportAllCompiledSchemas(this);
					}
					try
					{
						XmlSchema buildInSchema = Preprocessor.GetBuildInSchema();
						i = 0;
						while (i < this.schemas.Count)
						{
							XmlSchema xmlSchema = (XmlSchema)this.schemas.GetByIndex(i);
							Monitor.Enter(xmlSchema);
							if (!xmlSchema.IsPreprocessed)
							{
								this.SendValidationEvent(new XmlSchemaException("All schemas in the set should be successfully preprocessed prior to compilation.", string.Empty), XmlSeverityType.Error);
								this.isCompiled = false;
								return;
							}
							if (!xmlSchema.IsCompiledBySet)
							{
								goto IL_FD;
							}
							if (this.compileAll)
							{
								if (xmlSchema != buildInSchema)
								{
									goto IL_FD;
								}
								compiler.Prepare(xmlSchema, false);
							}
							IL_106:
							i++;
							continue;
							IL_FD:
							compiler.Prepare(xmlSchema, true);
							goto IL_106;
						}
						this.isCompiled = compiler.Execute(this, schemaInfo);
						if (this.isCompiled)
						{
							if (!this.compileAll)
							{
								schemaInfo.Add(this.cachedCompiledInfo, this.eventHandler);
							}
							this.compileAll = false;
							this.cachedCompiledInfo = schemaInfo;
						}
					}
					finally
					{
						if (i == this.schemas.Count)
						{
							i--;
						}
						for (int j = i; j >= 0; j--)
						{
							XmlSchema xmlSchema2 = (XmlSchema)this.schemas.GetByIndex(j);
							if (xmlSchema2 == Preprocessor.GetBuildInSchema())
							{
								Monitor.Exit(xmlSchema2);
							}
							else
							{
								xmlSchema2.IsCompiledBySet = this.isCompiled;
								Monitor.Exit(xmlSchema2);
							}
						}
					}
				}
			}
		}

		/// <summary>Reprocesses an XML Schema definition language (XSD) schema that already exists in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schema">The schema to reprocess.</param>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> object if the schema is a valid schema. If the schema is not valid and a <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified, <see langword="null" /> is returned and the appropriate validation event is raised. Otherwise, an <see cref="T:System.Xml.Schema.XmlSchemaException" /> is thrown.</returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaException">The schema is not valid.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchema" /> object passed as a parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Xml.Schema.XmlSchema" /> object passed as a parameter does not already exist in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</exception>
		// Token: 0x06001A2E RID: 6702 RVA: 0x0009962C File Offset: 0x0009782C
		public XmlSchema Reprocess(XmlSchema schema)
		{
			if (schema == null)
			{
				throw new ArgumentNullException("schema");
			}
			if (!this.schemas.ContainsKey(schema.SchemaId))
			{
				throw new ArgumentException(Res.GetString("Schema does not exist in the set."), "schema");
			}
			XmlSchema xmlSchema = schema;
			object obj = this.InternalSyncObject;
			XmlSchema result;
			lock (obj)
			{
				this.RemoveSchemaFromGlobalTables(schema);
				this.RemoveSchemaFromCaches(schema);
				if (schema.BaseUri != null)
				{
					this.schemaLocations.Remove(schema.BaseUri);
				}
				string targetNamespace = this.GetTargetNamespace(schema);
				if (this.Schemas(targetNamespace).Count == 0)
				{
					this.targetNamespaces.Remove(targetNamespace);
				}
				this.isCompiled = false;
				this.compileAll = true;
				if (schema.ErrorCount != 0)
				{
					result = xmlSchema;
				}
				else if (this.PreprocessSchema(ref schema, schema.TargetNamespace))
				{
					if (this.targetNamespaces[targetNamespace] == null)
					{
						this.targetNamespaces.Add(targetNamespace, targetNamespace);
					}
					if (this.schemaForSchema == null && targetNamespace == "http://www.w3.org/2001/XMLSchema" && schema.SchemaTypes[DatatypeImplementation.QnAnyType] != null)
					{
						this.schemaForSchema = schema;
					}
					for (int i = 0; i < schema.ImportedSchemas.Count; i++)
					{
						XmlSchema xmlSchema2 = (XmlSchema)schema.ImportedSchemas[i];
						if (!this.schemas.ContainsKey(xmlSchema2.SchemaId))
						{
							this.schemas.Add(xmlSchema2.SchemaId, xmlSchema2);
						}
						targetNamespace = this.GetTargetNamespace(xmlSchema2);
						if (this.targetNamespaces[targetNamespace] == null)
						{
							this.targetNamespaces.Add(targetNamespace, targetNamespace);
						}
						if (this.schemaForSchema == null && targetNamespace == "http://www.w3.org/2001/XMLSchema" && schema.SchemaTypes[DatatypeImplementation.QnAnyType] != null)
						{
							this.schemaForSchema = schema;
						}
					}
					result = schema;
				}
				else
				{
					result = xmlSchema;
				}
			}
			return result;
		}

		/// <summary>Copies all the <see cref="T:System.Xml.Schema.XmlSchema" /> objects from the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> to the given array, starting at the given index.</summary>
		/// <param name="schemas">The array to copy the objects to.</param>
		/// <param name="index">The index in the array where copying will begin.</param>
		// Token: 0x06001A2F RID: 6703 RVA: 0x0009983C File Offset: 0x00097A3C
		public void CopyTo(XmlSchema[] schemas, int index)
		{
			if (schemas == null)
			{
				throw new ArgumentNullException("schemas");
			}
			if (index < 0 || index > schemas.Length - 1)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			this.schemas.Values.CopyTo(schemas, index);
		}

		/// <summary>Returns a collection of all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing all the schemas that have been added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />. If no schemas have been added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />, an empty <see cref="T:System.Collections.ICollection" /> object is returned.</returns>
		// Token: 0x06001A30 RID: 6704 RVA: 0x00099875 File Offset: 0x00097A75
		public ICollection Schemas()
		{
			return this.schemas.Values;
		}

		/// <summary>Returns a collection of all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> that belong to the given namespace.</summary>
		/// <param name="targetNamespace">The schema targetNamespace property.</param>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing all the schemas that have been added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> that belong to the given namespace. If no schemas have been added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />, an empty <see cref="T:System.Collections.ICollection" /> object is returned.</returns>
		// Token: 0x06001A31 RID: 6705 RVA: 0x00099884 File Offset: 0x00097A84
		public ICollection Schemas(string targetNamespace)
		{
			ArrayList arrayList = new ArrayList();
			if (targetNamespace == null)
			{
				targetNamespace = string.Empty;
			}
			for (int i = 0; i < this.schemas.Count; i++)
			{
				XmlSchema xmlSchema = (XmlSchema)this.schemas.GetByIndex(i);
				if (this.GetTargetNamespace(xmlSchema) == targetNamespace)
				{
					arrayList.Add(xmlSchema);
				}
			}
			return arrayList;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000998E1 File Offset: 0x00097AE1
		private XmlSchema Add(string targetNamespace, XmlSchema schema)
		{
			if (schema == null || schema.ErrorCount != 0)
			{
				return null;
			}
			if (this.PreprocessSchema(ref schema, targetNamespace))
			{
				this.AddSchemaToSet(schema);
				this.isCompiled = false;
				return schema;
			}
			return null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0009990C File Offset: 0x00097B0C
		internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (targetNamespace == null)
			{
				targetNamespace = string.Empty;
			}
			if (validatedNamespaces[targetNamespace] != null)
			{
				if (this.FindSchemaByNSAndUrl(new Uri(reader.BaseURI, UriKind.RelativeOrAbsolute), targetNamespace, null) != null)
				{
					return;
				}
				throw new XmlSchemaException("An element or attribute information item has already been validated from the '{0}' namespace. It is an error if 'xsi:schemaLocation', 'xsi:noNamespaceSchemaLocation', or an inline schema occurs for that namespace.", targetNamespace);
			}
			else
			{
				XmlSchema xmlSchema;
				if (this.IsSchemaLoaded(new Uri(reader.BaseURI, UriKind.RelativeOrAbsolute), targetNamespace, out xmlSchema))
				{
					return;
				}
				xmlSchema = this.ParseSchema(targetNamespace, reader);
				DictionaryEntry[] array = new DictionaryEntry[this.schemaLocations.Count];
				this.schemaLocations.CopyTo(array, 0);
				this.Add(targetNamespace, xmlSchema);
				if (xmlSchema.ImportedSchemas.Count > 0)
				{
					for (int i = 0; i < xmlSchema.ImportedSchemas.Count; i++)
					{
						XmlSchema xmlSchema2 = (XmlSchema)xmlSchema.ImportedSchemas[i];
						string text = xmlSchema2.TargetNamespace;
						if (text == null)
						{
							text = string.Empty;
						}
						if (validatedNamespaces[text] != null && this.FindSchemaByNSAndUrl(xmlSchema2.BaseUri, text, array) == null)
						{
							this.RemoveRecursive(xmlSchema);
							throw new XmlSchemaException("An element or attribute information item has already been validated from the '{0}' namespace. It is an error if 'xsi:schemaLocation', 'xsi:noNamespaceSchemaLocation', or an inline schema occurs for that namespace.", text);
						}
					}
				}
				return;
			}
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00099A1C File Offset: 0x00097C1C
		internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable)
		{
			if (schemaUri == null || schemaUri.OriginalString.Length == 0)
			{
				return null;
			}
			XmlSchema xmlSchema = null;
			if (locationsTable == null)
			{
				xmlSchema = (XmlSchema)this.schemaLocations[schemaUri];
			}
			else
			{
				for (int i = 0; i < locationsTable.Length; i++)
				{
					if (schemaUri.Equals(locationsTable[i].Key))
					{
						xmlSchema = (XmlSchema)locationsTable[i].Value;
						break;
					}
				}
			}
			if (xmlSchema != null)
			{
				string a = (xmlSchema.TargetNamespace == null) ? string.Empty : xmlSchema.TargetNamespace;
				if (a == ns)
				{
					return xmlSchema;
				}
				if (a == string.Empty)
				{
					ChameleonKey key = new ChameleonKey(ns, xmlSchema);
					xmlSchema = (XmlSchema)this.chameleonSchemas[key];
				}
				else
				{
					xmlSchema = null;
				}
			}
			return xmlSchema;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00099AE0 File Offset: 0x00097CE0
		private void AddSchemaToSet(XmlSchema schema)
		{
			this.schemas.Add(schema.SchemaId, schema);
			string targetNamespace = this.GetTargetNamespace(schema);
			if (this.targetNamespaces[targetNamespace] == null)
			{
				this.targetNamespaces.Add(targetNamespace, targetNamespace);
			}
			if (this.schemaForSchema == null && targetNamespace == "http://www.w3.org/2001/XMLSchema" && schema.SchemaTypes[DatatypeImplementation.QnAnyType] != null)
			{
				this.schemaForSchema = schema;
			}
			for (int i = 0; i < schema.ImportedSchemas.Count; i++)
			{
				XmlSchema xmlSchema = (XmlSchema)schema.ImportedSchemas[i];
				if (!this.schemas.ContainsKey(xmlSchema.SchemaId))
				{
					this.schemas.Add(xmlSchema.SchemaId, xmlSchema);
				}
				targetNamespace = this.GetTargetNamespace(xmlSchema);
				if (this.targetNamespaces[targetNamespace] == null)
				{
					this.targetNamespaces.Add(targetNamespace, targetNamespace);
				}
				if (this.schemaForSchema == null && targetNamespace == "http://www.w3.org/2001/XMLSchema" && schema.SchemaTypes[DatatypeImplementation.QnAnyType] != null)
				{
					this.schemaForSchema = schema;
				}
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00099C04 File Offset: 0x00097E04
		private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve)
		{
			foreach (object obj in substitutionGroupsTable.Values)
			{
				XmlSchemaSubstitutionGroup xmlSchemaSubstitutionGroup = (XmlSchemaSubstitutionGroup)obj;
				if (resolve)
				{
					this.ResolveSubstitutionGroup(xmlSchemaSubstitutionGroup, substitutionGroupsTable);
				}
				XmlQualifiedName examplar = xmlSchemaSubstitutionGroup.Examplar;
				XmlSchemaSubstitutionGroup xmlSchemaSubstitutionGroup2 = (XmlSchemaSubstitutionGroup)this.substitutionGroups[examplar];
				if (xmlSchemaSubstitutionGroup2 != null)
				{
					for (int i = 0; i < xmlSchemaSubstitutionGroup.Members.Count; i++)
					{
						if (!xmlSchemaSubstitutionGroup2.Members.Contains(xmlSchemaSubstitutionGroup.Members[i]))
						{
							xmlSchemaSubstitutionGroup2.Members.Add(xmlSchemaSubstitutionGroup.Members[i]);
						}
					}
				}
				else
				{
					this.AddToTable(this.substitutionGroups, examplar, xmlSchemaSubstitutionGroup);
				}
			}
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00099CE4 File Offset: 0x00097EE4
		private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable)
		{
			List<XmlSchemaElement> list = null;
			XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)this.elements[substitutionGroup.Examplar];
			if (substitutionGroup.Members.Contains(xmlSchemaElement))
			{
				return;
			}
			for (int i = 0; i < substitutionGroup.Members.Count; i++)
			{
				XmlSchemaElement xmlSchemaElement2 = (XmlSchemaElement)substitutionGroup.Members[i];
				XmlSchemaSubstitutionGroup xmlSchemaSubstitutionGroup = (XmlSchemaSubstitutionGroup)substTable[xmlSchemaElement2.QualifiedName];
				if (xmlSchemaSubstitutionGroup != null)
				{
					this.ResolveSubstitutionGroup(xmlSchemaSubstitutionGroup, substTable);
					for (int j = 0; j < xmlSchemaSubstitutionGroup.Members.Count; j++)
					{
						XmlSchemaElement xmlSchemaElement3 = (XmlSchemaElement)xmlSchemaSubstitutionGroup.Members[j];
						if (xmlSchemaElement3 != xmlSchemaElement2)
						{
							if (list == null)
							{
								list = new List<XmlSchemaElement>();
							}
							list.Add(xmlSchemaElement3);
						}
					}
				}
			}
			if (list != null)
			{
				for (int k = 0; k < list.Count; k++)
				{
					substitutionGroup.Members.Add(list[k]);
				}
			}
			substitutionGroup.Members.Add(xmlSchemaElement);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00099DE4 File Offset: 0x00097FE4
		internal XmlSchema Remove(XmlSchema schema, bool forceCompile)
		{
			if (schema == null)
			{
				throw new ArgumentNullException("schema");
			}
			object obj = this.InternalSyncObject;
			lock (obj)
			{
				if (this.schemas.ContainsKey(schema.SchemaId))
				{
					if (forceCompile)
					{
						this.RemoveSchemaFromGlobalTables(schema);
						this.RemoveSchemaFromCaches(schema);
					}
					this.schemas.Remove(schema.SchemaId);
					if (schema.BaseUri != null)
					{
						this.schemaLocations.Remove(schema.BaseUri);
					}
					string targetNamespace = this.GetTargetNamespace(schema);
					if (this.Schemas(targetNamespace).Count == 0)
					{
						this.targetNamespaces.Remove(targetNamespace);
					}
					if (forceCompile)
					{
						this.isCompiled = false;
						this.compileAll = true;
					}
					return schema;
				}
			}
			return null;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00099EC4 File Offset: 0x000980C4
		private void ClearTables()
		{
			this.GlobalElements.Clear();
			this.GlobalAttributes.Clear();
			this.GlobalTypes.Clear();
			this.SubstitutionGroups.Clear();
			this.TypeExtensions.Clear();
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00099F00 File Offset: 0x00098100
		internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace)
		{
			Preprocessor preprocessor = new Preprocessor(this.nameTable, this.GetSchemaNames(this.nameTable), this.eventHandler, this.compilationSettings);
			preprocessor.XmlResolver = this.readerSettings.GetXmlResolver_CheckConfig();
			preprocessor.ReaderSettings = this.readerSettings;
			preprocessor.SchemaLocations = this.schemaLocations;
			preprocessor.ChameleonSchemas = this.chameleonSchemas;
			bool result = preprocessor.Execute(schema, targetNamespace, true);
			schema = preprocessor.RootSchema;
			return result;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00099F78 File Offset: 0x00098178
		internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader)
		{
			XmlNameTable nt = reader.NameTable;
			SchemaNames schemaNames = this.GetSchemaNames(nt);
			Parser parser = new Parser(SchemaType.XSD, nt, schemaNames, this.eventHandler);
			parser.XmlResolver = this.readerSettings.GetXmlResolver_CheckConfig();
			try
			{
				parser.Parse(reader, targetNamespace);
			}
			catch (XmlSchemaException e)
			{
				this.SendValidationEvent(e, XmlSeverityType.Error);
				return null;
			}
			return parser.XmlSchema;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00099FE8 File Offset: 0x000981E8
		internal void CopyFromCompiledSet(XmlSchemaSet otherSet)
		{
			SortedList sortedSchemas = otherSet.SortedSchemas;
			bool flag = this.schemas.Count == 0;
			ArrayList arrayList = new ArrayList();
			SchemaInfo schemaInfo = new SchemaInfo();
			for (int i = 0; i < sortedSchemas.Count; i++)
			{
				XmlSchema xmlSchema = (XmlSchema)sortedSchemas.GetByIndex(i);
				Uri baseUri = xmlSchema.BaseUri;
				if (this.schemas.ContainsKey(xmlSchema.SchemaId) || (baseUri != null && baseUri.OriginalString.Length != 0 && this.schemaLocations[baseUri] != null))
				{
					arrayList.Add(xmlSchema);
				}
				else
				{
					this.schemas.Add(xmlSchema.SchemaId, xmlSchema);
					if (baseUri != null && baseUri.OriginalString.Length != 0)
					{
						this.schemaLocations.Add(baseUri, xmlSchema);
					}
					string targetNamespace = this.GetTargetNamespace(xmlSchema);
					if (this.targetNamespaces[targetNamespace] == null)
					{
						this.targetNamespaces.Add(targetNamespace, targetNamespace);
					}
				}
			}
			this.VerifyTables();
			foreach (object obj in otherSet.GlobalElements.Values)
			{
				XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)obj;
				if (!this.AddToTable(this.elements, xmlSchemaElement.QualifiedName, xmlSchemaElement))
				{
					goto IL_26E;
				}
			}
			foreach (object obj2 in otherSet.GlobalAttributes.Values)
			{
				XmlSchemaAttribute xmlSchemaAttribute = (XmlSchemaAttribute)obj2;
				if (!this.AddToTable(this.attributes, xmlSchemaAttribute.QualifiedName, xmlSchemaAttribute))
				{
					goto IL_26E;
				}
			}
			foreach (object obj3 in otherSet.GlobalTypes.Values)
			{
				XmlSchemaType xmlSchemaType = (XmlSchemaType)obj3;
				if (!this.AddToTable(this.schemaTypes, xmlSchemaType.QualifiedName, xmlSchemaType))
				{
					goto IL_26E;
				}
			}
			this.ProcessNewSubstitutionGroups(otherSet.SubstitutionGroups, false);
			schemaInfo.Add(this.cachedCompiledInfo, this.eventHandler);
			schemaInfo.Add(otherSet.CompiledInfo, this.eventHandler);
			this.cachedCompiledInfo = schemaInfo;
			if (flag)
			{
				this.isCompiled = true;
				this.compileAll = false;
			}
			return;
			IL_26E:
			foreach (object obj4 in sortedSchemas.Values)
			{
				XmlSchema xmlSchema2 = (XmlSchema)obj4;
				if (!arrayList.Contains(xmlSchema2))
				{
					this.Remove(xmlSchema2, false);
				}
			}
			foreach (object obj5 in otherSet.GlobalElements.Values)
			{
				XmlSchemaElement xmlSchemaElement2 = (XmlSchemaElement)obj5;
				if (!arrayList.Contains((XmlSchema)xmlSchemaElement2.Parent))
				{
					this.elements.Remove(xmlSchemaElement2.QualifiedName);
				}
			}
			foreach (object obj6 in otherSet.GlobalAttributes.Values)
			{
				XmlSchemaAttribute xmlSchemaAttribute2 = (XmlSchemaAttribute)obj6;
				if (!arrayList.Contains((XmlSchema)xmlSchemaAttribute2.Parent))
				{
					this.attributes.Remove(xmlSchemaAttribute2.QualifiedName);
				}
			}
			foreach (object obj7 in otherSet.GlobalTypes.Values)
			{
				XmlSchemaType xmlSchemaType2 = (XmlSchemaType)obj7;
				if (!arrayList.Contains((XmlSchema)xmlSchemaType2.Parent))
				{
					this.schemaTypes.Remove(xmlSchemaType2.QualifiedName);
				}
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0009A444 File Offset: 0x00098644
		internal SchemaInfo CompiledInfo
		{
			get
			{
				return this.cachedCompiledInfo;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x0009A44C File Offset: 0x0009864C
		internal XmlReaderSettings ReaderSettings
		{
			get
			{
				return this.readerSettings;
			}
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0009A454 File Offset: 0x00098654
		internal XmlResolver GetResolver()
		{
			return this.readerSettings.GetXmlResolver_CheckConfig();
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0009A461 File Offset: 0x00098661
		internal ValidationEventHandler GetEventHandler()
		{
			return this.eventHandler;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0009A469 File Offset: 0x00098669
		internal SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			if (this.nameTable != nt)
			{
				return new SchemaNames(nt);
			}
			if (this.schemaNames == null)
			{
				this.schemaNames = new SchemaNames(this.nameTable);
			}
			return this.schemaNames;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0009A49C File Offset: 0x0009869C
		internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema)
		{
			schema = null;
			if (targetNamespace == null)
			{
				targetNamespace = string.Empty;
			}
			if (this.GetSchemaByUri(schemaUri, out schema))
			{
				if (!this.schemas.ContainsKey(schema.SchemaId) || (targetNamespace.Length != 0 && !(targetNamespace == schema.TargetNamespace)))
				{
					if (schema.TargetNamespace == null)
					{
						XmlSchema xmlSchema = this.FindSchemaByNSAndUrl(schemaUri, targetNamespace, null);
						if (xmlSchema != null && this.schemas.ContainsKey(xmlSchema.SchemaId))
						{
							schema = xmlSchema;
						}
						else
						{
							schema = this.Add(targetNamespace, schema);
						}
					}
					else if (targetNamespace.Length != 0 && targetNamespace != schema.TargetNamespace)
					{
						this.SendValidationEvent(new XmlSchemaException("The targetNamespace parameter '{0}' should be the same value as the targetNamespace '{1}' of the schema.", new string[]
						{
							targetNamespace,
							schema.TargetNamespace
						}), XmlSeverityType.Error);
						schema = null;
					}
					else
					{
						this.AddSchemaToSet(schema);
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0009A585 File Offset: 0x00098785
		internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema)
		{
			schema = null;
			if (schemaUri == null || schemaUri.OriginalString.Length == 0)
			{
				return false;
			}
			schema = (XmlSchema)this.schemaLocations[schemaUri];
			return schema != null;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0009A5BC File Offset: 0x000987BC
		internal string GetTargetNamespace(XmlSchema schema)
		{
			if (schema.TargetNamespace != null)
			{
				return schema.TargetNamespace;
			}
			return string.Empty;
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x0009A5D2 File Offset: 0x000987D2
		internal SortedList SortedSchemas
		{
			get
			{
				return this.schemas;
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0009A5DC File Offset: 0x000987DC
		private void RemoveSchemaFromCaches(XmlSchema schema)
		{
			List<XmlSchema> list = new List<XmlSchema>();
			schema.GetExternalSchemasList(list, schema);
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].BaseUri != null && list[i].BaseUri.OriginalString.Length != 0)
				{
					this.schemaLocations.Remove(list[i].BaseUri);
				}
				IEnumerable keys = this.chameleonSchemas.Keys;
				ArrayList arrayList = new ArrayList();
				foreach (object obj in keys)
				{
					ChameleonKey chameleonKey = (ChameleonKey)obj;
					if (chameleonKey.chameleonLocation.Equals(list[i].BaseUri) && (chameleonKey.originalSchema == null || chameleonKey.originalSchema == list[i]))
					{
						arrayList.Add(chameleonKey);
					}
				}
				for (int j = 0; j < arrayList.Count; j++)
				{
					this.chameleonSchemas.Remove(arrayList[j]);
				}
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0009A70C File Offset: 0x0009890C
		private void RemoveSchemaFromGlobalTables(XmlSchema schema)
		{
			if (this.schemas.Count == 0)
			{
				return;
			}
			this.VerifyTables();
			foreach (object obj in schema.Elements.Values)
			{
				XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)obj;
				if ((XmlSchemaElement)this.elements[xmlSchemaElement.QualifiedName] == xmlSchemaElement)
				{
					this.elements.Remove(xmlSchemaElement.QualifiedName);
				}
			}
			foreach (object obj2 in schema.Attributes.Values)
			{
				XmlSchemaAttribute xmlSchemaAttribute = (XmlSchemaAttribute)obj2;
				if ((XmlSchemaAttribute)this.attributes[xmlSchemaAttribute.QualifiedName] == xmlSchemaAttribute)
				{
					this.attributes.Remove(xmlSchemaAttribute.QualifiedName);
				}
			}
			foreach (object obj3 in schema.SchemaTypes.Values)
			{
				XmlSchemaType xmlSchemaType = (XmlSchemaType)obj3;
				if ((XmlSchemaType)this.schemaTypes[xmlSchemaType.QualifiedName] == xmlSchemaType)
				{
					this.schemaTypes.Remove(xmlSchemaType.QualifiedName);
				}
			}
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0009A888 File Offset: 0x00098A88
		private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item)
		{
			if (qname.Name.Length == 0)
			{
				return true;
			}
			XmlSchemaObject xmlSchemaObject = table[qname];
			if (xmlSchemaObject == null)
			{
				table.Add(qname, item);
				return true;
			}
			if (xmlSchemaObject == item || xmlSchemaObject.SourceUri == item.SourceUri)
			{
				return true;
			}
			string res = string.Empty;
			if (item is XmlSchemaComplexType)
			{
				res = "The complexType '{0}' has already been declared.";
			}
			else if (item is XmlSchemaSimpleType)
			{
				res = "The simpleType '{0}' has already been declared.";
			}
			else if (item is XmlSchemaElement)
			{
				res = "The global element '{0}' has already been declared.";
			}
			else if (item is XmlSchemaAttribute)
			{
				if (qname.Namespace == "http://www.w3.org/XML/1998/namespace")
				{
					XmlSchemaObject xmlSchemaObject2 = Preprocessor.GetBuildInSchema().Attributes[qname];
					if (xmlSchemaObject == xmlSchemaObject2)
					{
						table.Insert(qname, item);
						return true;
					}
					if (item == xmlSchemaObject2)
					{
						return true;
					}
				}
				res = "The global attribute '{0}' has already been declared.";
			}
			this.SendValidationEvent(new XmlSchemaException(res, qname.ToString()), XmlSeverityType.Error);
			return false;
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0009A964 File Offset: 0x00098B64
		private void VerifyTables()
		{
			if (this.elements == null)
			{
				this.elements = new XmlSchemaObjectTable();
			}
			if (this.attributes == null)
			{
				this.attributes = new XmlSchemaObjectTable();
			}
			if (this.schemaTypes == null)
			{
				this.schemaTypes = new XmlSchemaObjectTable();
			}
			if (this.substitutionGroups == null)
			{
				this.substitutionGroups = new XmlSchemaObjectTable();
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0009A9BD File Offset: 0x00098BBD
		private void InternalValidationCallback(object sender, ValidationEventArgs e)
		{
			if (e.Severity == XmlSeverityType.Error)
			{
				throw e.Exception;
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0009A9CE File Offset: 0x00098BCE
		private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
			if (this.eventHandler != null)
			{
				this.eventHandler(this, new ValidationEventArgs(e, severity));
				return;
			}
			throw e;
		}

		// Token: 0x0400110B RID: 4363
		private XmlNameTable nameTable;

		// Token: 0x0400110C RID: 4364
		private SchemaNames schemaNames;

		// Token: 0x0400110D RID: 4365
		private SortedList schemas;

		// Token: 0x0400110E RID: 4366
		private ValidationEventHandler internalEventHandler;

		// Token: 0x0400110F RID: 4367
		private ValidationEventHandler eventHandler;

		// Token: 0x04001110 RID: 4368
		private bool isCompiled;

		// Token: 0x04001111 RID: 4369
		private Hashtable schemaLocations;

		// Token: 0x04001112 RID: 4370
		private Hashtable chameleonSchemas;

		// Token: 0x04001113 RID: 4371
		private Hashtable targetNamespaces;

		// Token: 0x04001114 RID: 4372
		private bool compileAll;

		// Token: 0x04001115 RID: 4373
		private SchemaInfo cachedCompiledInfo;

		// Token: 0x04001116 RID: 4374
		private XmlReaderSettings readerSettings;

		// Token: 0x04001117 RID: 4375
		private XmlSchema schemaForSchema;

		// Token: 0x04001118 RID: 4376
		private XmlSchemaCompilationSettings compilationSettings;

		// Token: 0x04001119 RID: 4377
		internal XmlSchemaObjectTable elements;

		// Token: 0x0400111A RID: 4378
		internal XmlSchemaObjectTable attributes;

		// Token: 0x0400111B RID: 4379
		internal XmlSchemaObjectTable schemaTypes;

		// Token: 0x0400111C RID: 4380
		internal XmlSchemaObjectTable substitutionGroups;

		// Token: 0x0400111D RID: 4381
		private XmlSchemaObjectTable typeExtensions;

		// Token: 0x0400111E RID: 4382
		private object internalSyncObject;
	}
}
