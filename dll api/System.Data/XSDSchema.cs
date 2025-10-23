﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;

namespace System.Data
{
	// Token: 0x0200009C RID: 156
	internal sealed class XSDSchema : XMLSchema
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0002EA92 File Offset: 0x0002CC92
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x0002EA9A File Offset: 0x0002CC9A
		internal bool FromInference
		{
			get
			{
				return this._fromInference;
			}
			set
			{
				this._fromInference = value;
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0002EAA4 File Offset: 0x0002CCA4
		private void CollectElementsAnnotations(XmlSchema schema)
		{
			ArrayList arrayList = new ArrayList();
			this.CollectElementsAnnotations(schema, arrayList);
			arrayList.Clear();
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList)
		{
			if (schemaList.Contains(schema))
			{
				return;
			}
			schemaList.Add(schema);
			foreach (object obj in schema.Items)
			{
				if (obj is XmlSchemaAnnotation)
				{
					this._annotations.Add((XmlSchemaAnnotation)obj);
				}
				if (obj is XmlSchemaElement)
				{
					XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)obj;
					this._elements.Add(xmlSchemaElement);
					this._elementsTable[xmlSchemaElement.QualifiedName] = xmlSchemaElement;
				}
				if (obj is XmlSchemaAttribute)
				{
					XmlSchemaAttribute xmlSchemaAttribute = (XmlSchemaAttribute)obj;
					this._attributes[xmlSchemaAttribute.QualifiedName] = xmlSchemaAttribute;
				}
				if (obj is XmlSchemaAttributeGroup)
				{
					XmlSchemaAttributeGroup xmlSchemaAttributeGroup = (XmlSchemaAttributeGroup)obj;
					this._attributeGroups[xmlSchemaAttributeGroup.QualifiedName] = xmlSchemaAttributeGroup;
				}
				if (obj is XmlSchemaType)
				{
					if (obj is XmlSchemaSimpleType)
					{
						XSDSchema.GetMsdataAttribute((XmlSchemaType)obj, "targetNamespace");
					}
					XmlSchemaType xmlSchemaType = (XmlSchemaType)obj;
					this._schemaTypes[xmlSchemaType.QualifiedName] = xmlSchemaType;
					XmlSchemaSimpleType xmlSchemaSimpleType = obj as XmlSchemaSimpleType;
					if (xmlSchemaSimpleType != null)
					{
						if (this._udSimpleTypes == null)
						{
							this._udSimpleTypes = new Hashtable();
						}
						this._udSimpleTypes[xmlSchemaType.QualifiedName.ToString()] = xmlSchemaSimpleType;
						DataColumn dataColumn = (DataColumn)this._existingSimpleTypeMap[xmlSchemaType.QualifiedName.ToString()];
						SimpleType simpleType = (dataColumn != null) ? dataColumn.SimpleType : null;
						if (simpleType != null)
						{
							SimpleType simpleType2 = new SimpleType(xmlSchemaSimpleType);
							string text = simpleType.HasConflictingDefinition(simpleType2);
							if (text.Length != 0)
							{
								throw ExceptionBuilder.InvalidDuplicateNamedSimpleTypeDelaration(simpleType2.SimpleTypeQualifiedName, text);
							}
						}
					}
				}
			}
			foreach (XmlSchemaObject xmlSchemaObject in schema.Includes)
			{
				XmlSchemaExternal xmlSchemaExternal = (XmlSchemaExternal)xmlSchemaObject;
				if (!(xmlSchemaExternal is XmlSchemaImport) && xmlSchemaExternal.Schema != null)
				{
					this.CollectElementsAnnotations(xmlSchemaExternal.Schema, schemaList);
				}
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002ED14 File Offset: 0x0002CF14
		internal static string QualifiedName(string name)
		{
			if (name.IndexOf(':') == -1)
			{
				return "xs:" + name;
			}
			return name;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0002ED30 File Offset: 0x0002CF30
		internal static void SetProperties(object instance, XmlAttribute[] attrs)
		{
			if (attrs == null)
			{
				return;
			}
			for (int i = 0; i < attrs.Length; i++)
			{
				if (attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata")
				{
					string localName = attrs[i].LocalName;
					string value = attrs[i].Value;
					if (!(localName == "DefaultValue") && !(localName == "Ordinal") && !(localName == "Locale") && !(localName == "RemotingFormat") && (!(localName == "Expression") || !(instance is DataColumn)))
					{
						if (localName == "DataType")
						{
							DataColumn dataColumn = instance as DataColumn;
							if (dataColumn != null)
							{
								dataColumn.DataType = DataStorage.GetType(value);
							}
						}
						else
						{
							PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(instance)[localName];
							if (propertyDescriptor != null)
							{
								Type propertyType = propertyDescriptor.PropertyType;
								TypeConverter converter = XMLSchema.GetConverter(propertyType);
								object value2;
								if (converter.CanConvertFrom(typeof(string)))
								{
									value2 = converter.ConvertFromInvariantString(value);
								}
								else if (propertyType == typeof(Type))
								{
									value2 = Type.GetType(value);
								}
								else
								{
									if (!(propertyType == typeof(CultureInfo)))
									{
										throw ExceptionBuilder.CannotConvert(value, propertyType.FullName);
									}
									value2 = new CultureInfo(value);
								}
								propertyDescriptor.SetValue(instance, value2);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0002EE98 File Offset: 0x0002D098
		private static void SetExtProperties(object instance, XmlAttribute[] attrs)
		{
			PropertyCollection propertyCollection = null;
			if (attrs == null)
			{
				return;
			}
			for (int i = 0; i < attrs.Length; i++)
			{
				if (attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msprop")
				{
					if (propertyCollection == null)
					{
						propertyCollection = (PropertyCollection)TypeDescriptor.GetProperties(instance)["ExtendedProperties"].GetValue(instance);
					}
					string text = XmlConvert.DecodeName(attrs[i].LocalName);
					if (instance is ForeignKeyConstraint)
					{
						if (!text.StartsWith("fk_", StringComparison.Ordinal))
						{
							goto IL_B4;
						}
						text = text.Substring(3);
					}
					if (instance is DataRelation && text.StartsWith("rel_", StringComparison.Ordinal))
					{
						text = text.Substring(4);
					}
					else if (instance is DataRelation && text.StartsWith("fk_", StringComparison.Ordinal))
					{
						goto IL_B4;
					}
					propertyCollection.Add(text, attrs[i].Value);
				}
				IL_B4:;
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0002EF68 File Offset: 0x0002D168
		private void HandleColumnExpression(object instance, XmlAttribute[] attrs)
		{
			if (attrs == null)
			{
				return;
			}
			DataColumn dataColumn = instance as DataColumn;
			if (dataColumn != null)
			{
				for (int i = 0; i < attrs.Length; i++)
				{
					if (attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata" && attrs[i].LocalName == "Expression")
					{
						if (this._expressions == null)
						{
							this._expressions = new Hashtable();
						}
						this._expressions[dataColumn] = attrs[i].Value;
						this._columnExpressions.Add(dataColumn);
						return;
					}
				}
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0002EFF0 File Offset: 0x0002D1F0
		internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln)
		{
			XmlAttribute[] unhandledAttributes = node.UnhandledAttributes;
			if (unhandledAttributes != null)
			{
				for (int i = 0; i < unhandledAttributes.Length; i++)
				{
					if (unhandledAttributes[i].LocalName == ln && unhandledAttributes[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata")
					{
						return unhandledAttributes[i].Value;
					}
				}
			}
			return null;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0002F044 File Offset: 0x0002D244
		private static void SetExtProperties(object instance, XmlAttributeCollection attrs)
		{
			PropertyCollection propertyCollection = null;
			for (int i = 0; i < attrs.Count; i++)
			{
				if (attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msprop")
				{
					if (propertyCollection == null)
					{
						propertyCollection = (PropertyCollection)TypeDescriptor.GetProperties(instance)["ExtendedProperties"].GetValue(instance);
					}
					string key = XmlConvert.DecodeName(attrs[i].LocalName);
					propertyCollection.Add(key, attrs[i].Value);
				}
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0002F0C0 File Offset: 0x0002D2C0
		internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element)
		{
			string instanceName = this.GetInstanceName(element);
			DataTable table = this._ds.Tables.GetTable(XmlConvert.DecodeName(instanceName), element.QualifiedName.Namespace);
			XSDSchema.SetProperties(table, element.UnhandledAttributes);
			XSDSchema.SetExtProperties(table, element.UnhandledAttributes);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002F110 File Offset: 0x0002D310
		internal void HandleRelation(XmlElement node, bool fNested)
		{
			bool createConstraints = false;
			DataRelationCollection relations = this._ds.Relations;
			string text = XmlConvert.DecodeName(node.GetAttribute("name"));
			for (int i = 0; i < relations.Count; i++)
			{
				if (string.Equals(relations[i].RelationName, text, StringComparison.Ordinal))
				{
					return;
				}
			}
			string text2 = node.GetAttribute("parent", "urn:schemas-microsoft-com:xml-msdata");
			if (text2 == null || text2.Length == 0)
			{
				throw ExceptionBuilder.RelationParentNameMissing(text);
			}
			text2 = XmlConvert.DecodeName(text2);
			string text3 = node.GetAttribute("child", "urn:schemas-microsoft-com:xml-msdata");
			if (text3 == null || text3.Length == 0)
			{
				throw ExceptionBuilder.RelationChildNameMissing(text);
			}
			text3 = XmlConvert.DecodeName(text3);
			string attribute = node.GetAttribute("parentkey", "urn:schemas-microsoft-com:xml-msdata");
			if (attribute == null || attribute.Length == 0)
			{
				throw ExceptionBuilder.RelationTableKeyMissing(text);
			}
			string[] array = attribute.TrimEnd(null).Split(new char[]
			{
				' ',
				'+'
			});
			attribute = node.GetAttribute("childkey", "urn:schemas-microsoft-com:xml-msdata");
			if (attribute == null || attribute.Length == 0)
			{
				throw ExceptionBuilder.RelationChildKeyMissing(text);
			}
			string[] array2 = attribute.TrimEnd(null).Split(new char[]
			{
				' ',
				'+'
			});
			int num = array.Length;
			if (num != array2.Length)
			{
				throw ExceptionBuilder.MismatchKeyLength();
			}
			DataColumn[] array3 = new DataColumn[num];
			DataColumn[] array4 = new DataColumn[num];
			string attribute2 = node.GetAttribute("ParentTableNamespace", "urn:schemas-microsoft-com:xml-msdata");
			string attribute3 = node.GetAttribute("ChildTableNamespace", "urn:schemas-microsoft-com:xml-msdata");
			DataTable tableSmart = this._ds.Tables.GetTableSmart(text2, attribute2);
			if (tableSmart == null)
			{
				throw ExceptionBuilder.ElementTypeNotFound(text2);
			}
			DataTable tableSmart2 = this._ds.Tables.GetTableSmart(text3, attribute3);
			if (tableSmart2 == null)
			{
				throw ExceptionBuilder.ElementTypeNotFound(text3);
			}
			for (int j = 0; j < num; j++)
			{
				array3[j] = tableSmart.Columns[XmlConvert.DecodeName(array[j])];
				if (array3[j] == null)
				{
					throw ExceptionBuilder.ElementTypeNotFound(array[j]);
				}
				array4[j] = tableSmart2.Columns[XmlConvert.DecodeName(array2[j])];
				if (array4[j] == null)
				{
					throw ExceptionBuilder.ElementTypeNotFound(array2[j]);
				}
			}
			DataRelation dataRelation = new DataRelation(text, array3, array4, createConstraints);
			dataRelation.Nested = fNested;
			XSDSchema.SetExtProperties(dataRelation, node.Attributes);
			this._ds.Relations.Add(dataRelation);
			if (this.FromInference && dataRelation.Nested)
			{
				this._tableDictionary[dataRelation.ParentTable].Add(dataRelation.ChildTable);
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		private bool HasAttributes(XmlSchemaObjectCollection attributes)
		{
			foreach (XmlSchemaObject xmlSchemaObject in attributes)
			{
				if (xmlSchemaObject is XmlSchemaAttribute)
				{
					return true;
				}
				if (xmlSchemaObject is XmlSchemaAttributeGroup)
				{
					return true;
				}
				if (xmlSchemaObject is XmlSchemaAttributeGroupRef)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0002F410 File Offset: 0x0002D610
		private bool IsDatasetParticle(XmlSchemaParticle pt)
		{
			XmlSchemaObjectCollection particleItems = this.GetParticleItems(pt);
			if (particleItems == null)
			{
				return false;
			}
			bool flag = this.FromInference && pt is XmlSchemaChoice;
			foreach (XmlSchemaObject xmlSchemaObject in particleItems)
			{
				XmlSchemaAnnotated xmlSchemaAnnotated = (XmlSchemaAnnotated)xmlSchemaObject;
				if (xmlSchemaAnnotated is XmlSchemaElement)
				{
					if (flag && pt.MaxOccurs > 1m && ((XmlSchemaElement)xmlSchemaAnnotated).SchemaType is XmlSchemaComplexType)
					{
						((XmlSchemaElement)xmlSchemaAnnotated).MaxOccurs = pt.MaxOccurs;
					}
					if ((((XmlSchemaElement)xmlSchemaAnnotated).RefName.Name.Length == 0 || (this.FromInference && (!(((XmlSchemaElement)xmlSchemaAnnotated).MaxOccurs != 1m) || ((XmlSchemaElement)xmlSchemaAnnotated).SchemaType is XmlSchemaComplexType))) && !this.IsTable((XmlSchemaElement)xmlSchemaAnnotated))
					{
						return false;
					}
				}
				else if (xmlSchemaAnnotated is XmlSchemaParticle && !this.IsDatasetParticle((XmlSchemaParticle)xmlSchemaAnnotated))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0002F548 File Offset: 0x0002D748
		private int DatasetElementCount(XmlSchemaObjectCollection elements)
		{
			int num = 0;
			foreach (XmlSchemaObject xmlSchemaObject in elements)
			{
				XmlSchemaElement element = (XmlSchemaElement)xmlSchemaObject;
				if (this.GetBooleanAttribute(element, "IsDataSet", false))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0002F5AC File Offset: 0x0002D7AC
		private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements)
		{
			foreach (XmlSchemaObject xmlSchemaObject in elements)
			{
				XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)xmlSchemaObject;
				if (this.GetBooleanAttribute(xmlSchemaElement, "IsDataSet", false))
				{
					return xmlSchemaElement;
				}
			}
			if (elements.Count != 1 && (!this.FromInference || elements.Count <= 0))
			{
				return null;
			}
			XmlSchemaElement xmlSchemaElement2 = (XmlSchemaElement)elements[0];
			if (!this.GetBooleanAttribute(xmlSchemaElement2, "IsDataSet", true))
			{
				return null;
			}
			XmlSchemaComplexType xmlSchemaComplexType = xmlSchemaElement2.SchemaType as XmlSchemaComplexType;
			if (xmlSchemaComplexType == null)
			{
				return null;
			}
			while (xmlSchemaComplexType != null)
			{
				if (this.HasAttributes(xmlSchemaComplexType.Attributes))
				{
					return null;
				}
				if (xmlSchemaComplexType.ContentModel is XmlSchemaSimpleContent)
				{
					XmlSchemaAnnotated content = ((XmlSchemaSimpleContent)xmlSchemaComplexType.ContentModel).Content;
					if (content is XmlSchemaSimpleContentExtension)
					{
						XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension = (XmlSchemaSimpleContentExtension)content;
						if (this.HasAttributes(xmlSchemaSimpleContentExtension.Attributes))
						{
							return null;
						}
					}
					else
					{
						XmlSchemaSimpleContentRestriction xmlSchemaSimpleContentRestriction = (XmlSchemaSimpleContentRestriction)content;
						if (this.HasAttributes(xmlSchemaSimpleContentRestriction.Attributes))
						{
							return null;
						}
					}
				}
				XmlSchemaParticle particle = this.GetParticle(xmlSchemaComplexType);
				if (particle != null && !this.IsDatasetParticle(particle))
				{
					return null;
				}
				if (!(xmlSchemaComplexType.BaseXmlSchemaType is XmlSchemaComplexType))
				{
					break;
				}
				xmlSchemaComplexType = (XmlSchemaComplexType)xmlSchemaComplexType.BaseXmlSchemaType;
			}
			return xmlSchemaElement2;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0002F718 File Offset: 0x0002D918
		public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt)
		{
			if (dt.DataSet != null)
			{
				this.LoadSchema(schemaSet, dt.DataSet);
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0002F730 File Offset: 0x0002D930
		public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds)
		{
			this._constraintNodes = new Hashtable();
			this._refTables = new ArrayList();
			this._columnExpressions = new ArrayList();
			this._complexTypes = new ArrayList();
			bool flag = false;
			bool isNewDataSet = ds.Tables.Count == 0;
			if (schemaSet == null)
			{
				return;
			}
			this._schemaSet = schemaSet;
			this._ds = ds;
			ds._fIsSchemaLoading = true;
			using (IEnumerator enumerator = schemaSet.Schemas().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
					this._schemaName = xmlSchema.Id;
					if (this._schemaName == null || this._schemaName.Length == 0)
					{
						this._schemaName = "NewDataSet";
					}
					ds.DataSetName = XmlConvert.DecodeName(this._schemaName);
					string targetNamespace = xmlSchema.TargetNamespace;
					if (ds._namespaceURI == null || ds._namespaceURI.Length == 0)
					{
						ds._namespaceURI = ((targetNamespace == null) ? string.Empty : targetNamespace);
					}
				}
			}
			this._annotations = new XmlSchemaObjectCollection();
			this._elements = new XmlSchemaObjectCollection();
			this._elementsTable = new Hashtable();
			this._attributes = new Hashtable();
			this._attributeGroups = new Hashtable();
			this._schemaTypes = new Hashtable();
			this._tableDictionary = new Dictionary<DataTable, List<DataTable>>();
			this._existingSimpleTypeMap = new Hashtable();
			foreach (object obj in ds.Tables)
			{
				foreach (object obj2 in ((DataTable)obj).Columns)
				{
					DataColumn dataColumn = (DataColumn)obj2;
					if (dataColumn.SimpleType != null && dataColumn.SimpleType.Name != null && dataColumn.SimpleType.Name.Length != 0)
					{
						this._existingSimpleTypeMap[dataColumn.SimpleType.SimpleTypeQualifiedName] = dataColumn;
					}
				}
			}
			foreach (object obj3 in schemaSet.Schemas())
			{
				XmlSchema schema = (XmlSchema)obj3;
				this.CollectElementsAnnotations(schema);
			}
			this._dsElement = this.FindDatasetElement(this._elements);
			if (this._dsElement != null)
			{
				string stringAttribute = this.GetStringAttribute(this._dsElement, "MainDataTable", "");
				if (stringAttribute != null)
				{
					ds.MainTableName = XmlConvert.DecodeName(stringAttribute);
				}
			}
			else
			{
				if (this.FromInference)
				{
					ds._fTopLevelTable = true;
				}
				flag = true;
			}
			List<XmlQualifiedName> list = new List<XmlQualifiedName>();
			if (ds != null && ds._useDataSetSchemaOnly)
			{
				int num = this.DatasetElementCount(this._elements);
				if (num == 0)
				{
					throw ExceptionBuilder.IsDataSetAttributeMissingInSchema();
				}
				if (num > 1)
				{
					throw ExceptionBuilder.TooManyIsDataSetAtributeInSchema();
				}
				XmlSchemaComplexType xmlSchemaComplexType = (XmlSchemaComplexType)this.FindTypeNode(this._dsElement);
				if (xmlSchemaComplexType.Particle != null)
				{
					XmlSchemaObjectCollection particleItems = this.GetParticleItems(xmlSchemaComplexType.Particle);
					if (particleItems != null)
					{
						foreach (XmlSchemaObject xmlSchemaObject in particleItems)
						{
							XmlSchemaElement xmlSchemaElement = ((XmlSchemaAnnotated)xmlSchemaObject) as XmlSchemaElement;
							if (xmlSchemaElement != null && xmlSchemaElement.RefName.Name.Length != 0)
							{
								list.Add(xmlSchemaElement.QualifiedName);
							}
						}
					}
				}
			}
			foreach (XmlSchemaObject xmlSchemaObject2 in this._elements)
			{
				XmlSchemaElement xmlSchemaElement2 = (XmlSchemaElement)xmlSchemaObject2;
				if (xmlSchemaElement2 != this._dsElement && (ds == null || !ds._useDataSetSchemaOnly || this._dsElement == null || this._dsElement.Parent == xmlSchemaElement2.Parent || list.Contains(xmlSchemaElement2.QualifiedName)))
				{
					string instanceName = this.GetInstanceName(xmlSchemaElement2);
					if (this._refTables.Contains(xmlSchemaElement2.QualifiedName.Namespace + ":" + instanceName))
					{
						this.HandleRefTableProperties(this._refTables, xmlSchemaElement2);
					}
					else
					{
						this.HandleTable(xmlSchemaElement2);
					}
				}
			}
			if (this._dsElement != null)
			{
				this.HandleDataSet(this._dsElement, isNewDataSet);
			}
			foreach (XmlSchemaObject xmlSchemaObject3 in this._annotations)
			{
				XmlSchemaAnnotation ann = (XmlSchemaAnnotation)xmlSchemaObject3;
				this.HandleRelations(ann, false);
			}
			for (int i = 0; i < this._columnExpressions.Count; i++)
			{
				DataColumn dataColumn2 = (DataColumn)this._columnExpressions[i];
				dataColumn2.Expression = (string)this._expressions[dataColumn2];
			}
			foreach (object obj4 in ds.Tables)
			{
				DataTable dataTable = (DataTable)obj4;
				if (dataTable.NestedParentRelations.Length == 0 && dataTable.Namespace == ds.Namespace)
				{
					DataRelationCollection childRelations = dataTable.ChildRelations;
					for (int j = 0; j < childRelations.Count; j++)
					{
						if (childRelations[j].Nested && dataTable.Namespace == childRelations[j].ChildTable.Namespace)
						{
							childRelations[j].ChildTable._tableNamespace = null;
						}
					}
					dataTable._tableNamespace = null;
				}
			}
			DataTable dataTable2 = ds.Tables[ds.DataSetName, ds.Namespace];
			if (dataTable2 != null)
			{
				dataTable2._fNestedInDataset = true;
			}
			if (this.FromInference && ds.Tables.Count == 0 && string.Equals(ds.DataSetName, "NewDataSet", StringComparison.Ordinal))
			{
				ds.DataSetName = XmlConvert.DecodeName(((XmlSchemaElement)this._elements[0]).Name);
			}
			ds._fIsSchemaLoading = false;
			if (flag)
			{
				if (ds.Tables.Count > 0)
				{
					ds.Namespace = ds.Tables[0].Namespace;
					ds.Prefix = ds.Tables[0].Prefix;
					return;
				}
				foreach (object obj5 in schemaSet.Schemas())
				{
					XmlSchema xmlSchema2 = (XmlSchema)obj5;
					ds.Namespace = xmlSchema2.TargetNamespace;
				}
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0002FE70 File Offset: 0x0002E070
		private void HandleRelations(XmlSchemaAnnotation ann, bool fNested)
		{
			foreach (object obj in ann.Items)
			{
				if (obj is XmlSchemaAppInfo)
				{
					XmlNode[] markup = ((XmlSchemaAppInfo)obj).Markup;
					for (int i = 0; i < markup.Length; i++)
					{
						if (XMLSchema.FEqualIdentity(markup[i], "Relationship", "urn:schemas-microsoft-com:xml-msdata"))
						{
							this.HandleRelation((XmlElement)markup[i], fNested);
						}
					}
				}
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0002FF08 File Offset: 0x0002E108
		internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt)
		{
			if (pt is XmlSchemaSequence)
			{
				return ((XmlSchemaSequence)pt).Items;
			}
			if (pt is XmlSchemaAll)
			{
				return ((XmlSchemaAll)pt).Items;
			}
			if (pt is XmlSchemaChoice)
			{
				return ((XmlSchemaChoice)pt).Items;
			}
			if (pt is XmlSchemaAny)
			{
				return null;
			}
			if (pt is XmlSchemaElement)
			{
				return new XmlSchemaObjectCollection
				{
					pt
				};
			}
			if (pt is XmlSchemaGroupRef)
			{
				return this.GetParticleItems(((XmlSchemaGroupRef)pt).Particle);
			}
			return null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0002FF8C File Offset: 0x0002E18C
		internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase)
		{
			XmlSchemaObjectCollection particleItems = this.GetParticleItems(pt);
			if (particleItems == null)
			{
				return;
			}
			foreach (XmlSchemaObject xmlSchemaObject in particleItems)
			{
				XmlSchemaAnnotated xmlSchemaAnnotated = (XmlSchemaAnnotated)xmlSchemaObject;
				XmlSchemaElement xmlSchemaElement = xmlSchemaAnnotated as XmlSchemaElement;
				if (xmlSchemaElement != null)
				{
					if (this.FromInference && pt is XmlSchemaChoice && pt.MaxOccurs > 1m && xmlSchemaElement.SchemaType is XmlSchemaComplexType)
					{
						xmlSchemaElement.MaxOccurs = pt.MaxOccurs;
					}
					DataTable dataTable;
					if ((xmlSchemaElement.Name == null && xmlSchemaElement.RefName.Name == table.EncodedTableName && xmlSchemaElement.RefName.Namespace == table.Namespace) || (this.IsTable(xmlSchemaElement) && xmlSchemaElement.Name == table.TableName))
					{
						if (this.FromInference)
						{
							dataTable = this.HandleTable(xmlSchemaElement);
						}
						else
						{
							dataTable = table;
						}
					}
					else
					{
						dataTable = this.HandleTable(xmlSchemaElement);
						if (dataTable == null && this.FromInference && xmlSchemaElement.Name == table.TableName)
						{
							dataTable = table;
						}
					}
					if (dataTable == null)
					{
						if (!this.FromInference || xmlSchemaElement.Name != table.TableName)
						{
							this.HandleElementColumn(xmlSchemaElement, table, isBase);
						}
					}
					else
					{
						DataRelation dataRelation = null;
						if (xmlSchemaElement.Annotation != null)
						{
							this.HandleRelations(xmlSchemaElement.Annotation, true);
						}
						DataRelationCollection childRelations = table.ChildRelations;
						for (int i = 0; i < childRelations.Count; i++)
						{
							if (childRelations[i].Nested && dataTable == childRelations[i].ChildTable)
							{
								dataRelation = childRelations[i];
							}
						}
						if (dataRelation == null)
						{
							tableChildren.Add(dataTable);
							if (this.FromInference && table.UKColumnPositionForInference == -1)
							{
								int num = -1;
								using (IEnumerator enumerator2 = table.Columns.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										if (((DataColumn)enumerator2.Current).ColumnMapping == MappingType.Element)
										{
											num++;
										}
									}
								}
								table.UKColumnPositionForInference = num + 1;
							}
						}
					}
				}
				else
				{
					this.HandleParticle((XmlSchemaParticle)xmlSchemaAnnotated, table, tableChildren, isBase);
				}
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00030214 File Offset: 0x0002E414
		internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase)
		{
			foreach (XmlSchemaObject xmlSchemaObject in attributes)
			{
				if (xmlSchemaObject is XmlSchemaAttribute)
				{
					this.HandleAttributeColumn((XmlSchemaAttribute)xmlSchemaObject, table, isBase);
				}
				else
				{
					XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef = xmlSchemaObject as XmlSchemaAttributeGroupRef;
					XmlSchemaAttributeGroup xmlSchemaAttributeGroup = this._attributeGroups[xmlSchemaAttributeGroupRef.RefName] as XmlSchemaAttributeGroup;
					if (xmlSchemaAttributeGroup != null)
					{
						this.HandleAttributeGroup(xmlSchemaAttributeGroup, table, isBase);
					}
				}
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000302A4 File Offset: 0x0002E4A4
		private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase)
		{
			foreach (XmlSchemaObject xmlSchemaObject in attributeGroup.Attributes)
			{
				if (xmlSchemaObject is XmlSchemaAttribute)
				{
					this.HandleAttributeColumn((XmlSchemaAttribute)xmlSchemaObject, table, isBase);
				}
				else
				{
					XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef = (XmlSchemaAttributeGroupRef)xmlSchemaObject;
					XmlSchemaAttributeGroup xmlSchemaAttributeGroup;
					if (attributeGroup.RedefinedAttributeGroup != null && xmlSchemaAttributeGroupRef.RefName == new XmlQualifiedName(attributeGroup.Name, xmlSchemaAttributeGroupRef.RefName.Namespace))
					{
						xmlSchemaAttributeGroup = attributeGroup.RedefinedAttributeGroup;
					}
					else
					{
						xmlSchemaAttributeGroup = (XmlSchemaAttributeGroup)this._attributeGroups[xmlSchemaAttributeGroupRef.RefName];
					}
					if (xmlSchemaAttributeGroup != null)
					{
						this.HandleAttributeGroup(xmlSchemaAttributeGroup, table, isBase);
					}
				}
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00030370 File Offset: 0x0002E570
		internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable)
		{
			if (this._complexTypes.Contains(ct))
			{
				throw ExceptionBuilder.CircularComplexType(ct.Name);
			}
			bool isBase = false;
			this._complexTypes.Add(ct);
			if (ct.ContentModel != null)
			{
				if (ct.ContentModel is XmlSchemaComplexContent)
				{
					XmlSchemaAnnotated content = ((XmlSchemaComplexContent)ct.ContentModel).Content;
					if (content is XmlSchemaComplexContentExtension)
					{
						XmlSchemaComplexContentExtension xmlSchemaComplexContentExtension = (XmlSchemaComplexContentExtension)content;
						if (!(ct.BaseXmlSchemaType is XmlSchemaComplexType) || !this.FromInference)
						{
							this.HandleAttributes(xmlSchemaComplexContentExtension.Attributes, table, isBase);
						}
						if (ct.BaseXmlSchemaType is XmlSchemaComplexType)
						{
							this.HandleComplexType((XmlSchemaComplexType)ct.BaseXmlSchemaType, table, tableChildren, isNillable);
						}
						else if (xmlSchemaComplexContentExtension.BaseTypeName.Namespace != "http://www.w3.org/2001/XMLSchema")
						{
							this.HandleSimpleContentColumn(xmlSchemaComplexContentExtension.BaseTypeName.ToString(), table, isBase, ct.ContentModel.UnhandledAttributes, isNillable);
						}
						else
						{
							this.HandleSimpleContentColumn(xmlSchemaComplexContentExtension.BaseTypeName.Name, table, isBase, ct.ContentModel.UnhandledAttributes, isNillable);
						}
						if (xmlSchemaComplexContentExtension.Particle != null)
						{
							this.HandleParticle(xmlSchemaComplexContentExtension.Particle, table, tableChildren, isBase);
						}
						if (ct.BaseXmlSchemaType is XmlSchemaComplexType && this.FromInference)
						{
							this.HandleAttributes(xmlSchemaComplexContentExtension.Attributes, table, isBase);
						}
					}
					else
					{
						XmlSchemaComplexContentRestriction xmlSchemaComplexContentRestriction = (XmlSchemaComplexContentRestriction)content;
						if (!this.FromInference)
						{
							this.HandleAttributes(xmlSchemaComplexContentRestriction.Attributes, table, isBase);
						}
						if (xmlSchemaComplexContentRestriction.Particle != null)
						{
							this.HandleParticle(xmlSchemaComplexContentRestriction.Particle, table, tableChildren, isBase);
						}
						if (this.FromInference)
						{
							this.HandleAttributes(xmlSchemaComplexContentRestriction.Attributes, table, isBase);
						}
					}
				}
				else
				{
					XmlSchemaAnnotated content2 = ((XmlSchemaSimpleContent)ct.ContentModel).Content;
					if (content2 is XmlSchemaSimpleContentExtension)
					{
						XmlSchemaSimpleContentExtension xmlSchemaSimpleContentExtension = (XmlSchemaSimpleContentExtension)content2;
						this.HandleAttributes(xmlSchemaSimpleContentExtension.Attributes, table, isBase);
						if (ct.BaseXmlSchemaType is XmlSchemaComplexType)
						{
							this.HandleComplexType((XmlSchemaComplexType)ct.BaseXmlSchemaType, table, tableChildren, isNillable);
						}
						else
						{
							this.HandleSimpleTypeSimpleContentColumn((XmlSchemaSimpleType)ct.BaseXmlSchemaType, xmlSchemaSimpleContentExtension.BaseTypeName.Name, table, isBase, ct.ContentModel.UnhandledAttributes, isNillable);
						}
					}
					else
					{
						XmlSchemaSimpleContentRestriction xmlSchemaSimpleContentRestriction = (XmlSchemaSimpleContentRestriction)content2;
						this.HandleAttributes(xmlSchemaSimpleContentRestriction.Attributes, table, isBase);
					}
				}
			}
			else
			{
				isBase = true;
				if (!this.FromInference)
				{
					this.HandleAttributes(ct.Attributes, table, isBase);
				}
				if (ct.Particle != null)
				{
					this.HandleParticle(ct.Particle, table, tableChildren, isBase);
				}
				if (this.FromInference)
				{
					this.HandleAttributes(ct.Attributes, table, isBase);
					if (isNillable)
					{
						this.HandleSimpleContentColumn("string", table, isBase, null, isNillable);
					}
				}
			}
			this._complexTypes.Remove(ct);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00030624 File Offset: 0x0002E824
		internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct)
		{
			if (ct.ContentModel == null)
			{
				return ct.Particle;
			}
			if (!(ct.ContentModel is XmlSchemaComplexContent))
			{
				return null;
			}
			XmlSchemaAnnotated content = ((XmlSchemaComplexContent)ct.ContentModel).Content;
			if (content is XmlSchemaComplexContentExtension)
			{
				return ((XmlSchemaComplexContentExtension)content).Particle;
			}
			return ((XmlSchemaComplexContentRestriction)content).Particle;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00030680 File Offset: 0x0002E880
		internal DataColumn FindField(DataTable table, string field)
		{
			bool flag = false;
			string text = field;
			if (field.StartsWith("@", StringComparison.Ordinal))
			{
				flag = true;
				text = field.Substring(1);
			}
			string[] array = text.Split(':', StringSplitOptions.None);
			text = array[array.Length - 1];
			text = XmlConvert.DecodeName(text);
			DataColumn dataColumn = table.Columns[text];
			if (dataColumn == null)
			{
				throw ExceptionBuilder.InvalidField(field);
			}
			if ((dataColumn.ColumnMapping == MappingType.Attribute || dataColumn.ColumnMapping == MappingType.Hidden) != flag)
			{
				throw ExceptionBuilder.InvalidField(field);
			}
			return dataColumn;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000306F8 File Offset: 0x0002E8F8
		internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table)
		{
			ArrayList arrayList = new ArrayList();
			foreach (XmlSchemaObject xmlSchemaObject in keyNode.Fields)
			{
				XmlSchemaXPath xmlSchemaXPath = (XmlSchemaXPath)xmlSchemaObject;
				arrayList.Add(this.FindField(table, xmlSchemaXPath.XPath));
			}
			DataColumn[] array = new DataColumn[arrayList.Count];
			arrayList.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0003077C File Offset: 0x0002E97C
		internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal)
		{
			string msdataAttribute = XSDSchema.GetMsdataAttribute(element, attrName);
			if (msdataAttribute == null || msdataAttribute.Length == 0)
			{
				return defVal;
			}
			if (msdataAttribute == "true" || msdataAttribute == "1")
			{
				return true;
			}
			if (msdataAttribute == "false" || msdataAttribute == "0")
			{
				return false;
			}
			throw ExceptionBuilder.InvalidAttributeValue(attrName, msdataAttribute);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000307E0 File Offset: 0x0002E9E0
		internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal)
		{
			string msdataAttribute = XSDSchema.GetMsdataAttribute(element, attrName);
			if (msdataAttribute == null || msdataAttribute.Length == 0)
			{
				return defVal;
			}
			return msdataAttribute;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00030803 File Offset: 0x0002EA03
		internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule)
		{
			if (strRule == "Cascade")
			{
				return AcceptRejectRule.Cascade;
			}
			strRule == "None";
			return AcceptRejectRule.None;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00030821 File Offset: 0x0002EA21
		internal static Rule TranslateRule(string strRule)
		{
			if (strRule == "Cascade")
			{
				return Rule.Cascade;
			}
			if (strRule == "None")
			{
				return Rule.None;
			}
			if (strRule == "SetDefault")
			{
				return Rule.SetDefault;
			}
			if (strRule == "SetNull")
			{
				return Rule.SetNull;
			}
			return Rule.Cascade;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00030860 File Offset: 0x0002EA60
		internal void HandleKeyref(XmlSchemaKeyref keyref)
		{
			string text = XmlConvert.DecodeName(keyref.Refer.Name);
			string text2 = XmlConvert.DecodeName(keyref.Name);
			text2 = this.GetStringAttribute(keyref, "ConstraintName", text2);
			string tableName = this.GetTableName(keyref);
			string msdataAttribute = XSDSchema.GetMsdataAttribute(keyref, "TableNamespace");
			DataTable tableSmart = this._ds.Tables.GetTableSmart(tableName, msdataAttribute);
			if (tableSmart == null)
			{
				return;
			}
			if (text == null || text.Length == 0)
			{
				throw ExceptionBuilder.MissingRefer(text2);
			}
			ConstraintTable constraintTable = (ConstraintTable)this._constraintNodes[text];
			if (constraintTable == null)
			{
				throw ExceptionBuilder.InvalidKey(text2);
			}
			DataColumn[] array = this.BuildKey(constraintTable.constraint, constraintTable.table);
			DataColumn[] array2 = this.BuildKey(keyref, tableSmart);
			ForeignKeyConstraint foreignKeyConstraint = null;
			if (this.GetBooleanAttribute(keyref, "ConstraintOnly", false))
			{
				int num = array2[0].Table.Constraints.InternalIndexOf(text2);
				if (num > -1 && array2[0].Table.Constraints[num].ConstraintName != text2)
				{
					num = -1;
				}
				if (num < 0)
				{
					foreignKeyConstraint = new ForeignKeyConstraint(text2, array, array2);
					array2[0].Table.Constraints.Add(foreignKeyConstraint);
				}
			}
			else
			{
				string text3 = XmlConvert.DecodeName(this.GetStringAttribute(keyref, "RelationName", keyref.Name));
				if (text3 == null || text3.Length == 0)
				{
					text3 = text2;
				}
				int num2 = array2[0].Table.DataSet.Relations.InternalIndexOf(text3);
				if (num2 > -1 && array2[0].Table.DataSet.Relations[num2].RelationName != text3)
				{
					num2 = -1;
				}
				DataRelation dataRelation;
				if (num2 < 0)
				{
					dataRelation = new DataRelation(text3, array, array2);
					XSDSchema.SetExtProperties(dataRelation, keyref.UnhandledAttributes);
					array[0].Table.DataSet.Relations.Add(dataRelation);
					if (this.FromInference && dataRelation.Nested && this._tableDictionary.ContainsKey(dataRelation.ParentTable))
					{
						this._tableDictionary[dataRelation.ParentTable].Add(dataRelation.ChildTable);
					}
					foreignKeyConstraint = dataRelation.ChildKeyConstraint;
					foreignKeyConstraint.ConstraintName = text2;
				}
				else
				{
					dataRelation = array2[0].Table.DataSet.Relations[num2];
				}
				if (this.GetBooleanAttribute(keyref, "IsNested", false))
				{
					dataRelation.Nested = true;
				}
			}
			string msdataAttribute2 = XSDSchema.GetMsdataAttribute(keyref, "AcceptRejectRule");
			string msdataAttribute3 = XSDSchema.GetMsdataAttribute(keyref, "UpdateRule");
			string msdataAttribute4 = XSDSchema.GetMsdataAttribute(keyref, "DeleteRule");
			if (foreignKeyConstraint != null)
			{
				if (msdataAttribute2 != null)
				{
					foreignKeyConstraint.AcceptRejectRule = XSDSchema.TranslateAcceptRejectRule(msdataAttribute2);
				}
				if (msdataAttribute3 != null)
				{
					foreignKeyConstraint.UpdateRule = XSDSchema.TranslateRule(msdataAttribute3);
				}
				if (msdataAttribute4 != null)
				{
					foreignKeyConstraint.DeleteRule = XSDSchema.TranslateRule(msdataAttribute4);
				}
				XSDSchema.SetExtProperties(foreignKeyConstraint, keyref.UnhandledAttributes);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00030B44 File Offset: 0x0002ED44
		internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode)
		{
			string text = XmlConvert.DecodeName(keyNode.Name);
			if (text == null || text.Length == 0)
			{
				throw ExceptionBuilder.MissingAttribute("name");
			}
			if (this._constraintNodes.ContainsKey(text))
			{
				throw ExceptionBuilder.DuplicateConstraintRead(text);
			}
			string tableName = this.GetTableName(keyNode);
			string msdataAttribute = XSDSchema.GetMsdataAttribute(keyNode, "TableNamespace");
			DataTable tableSmart = this._ds.Tables.GetTableSmart(tableName, msdataAttribute);
			if (tableSmart == null)
			{
				return;
			}
			this._constraintNodes.Add(text, new ConstraintTable(tableSmart, keyNode));
			bool booleanAttribute = this.GetBooleanAttribute(keyNode, "PrimaryKey", false);
			text = this.GetStringAttribute(keyNode, "ConstraintName", text);
			DataColumn[] array = this.BuildKey(keyNode, tableSmart);
			if (array.Length != 0)
			{
				UniqueConstraint uniqueConstraint = (UniqueConstraint)array[0].Table.Constraints.FindConstraint(new UniqueConstraint(text, array));
				if (uniqueConstraint == null)
				{
					array[0].Table.Constraints.Add(text, array, booleanAttribute);
					XSDSchema.SetExtProperties(array[0].Table.Constraints[text], keyNode.UnhandledAttributes);
				}
				else
				{
					array = uniqueConstraint.ColumnsReference;
					XSDSchema.SetExtProperties(uniqueConstraint, keyNode.UnhandledAttributes);
					if (booleanAttribute)
					{
						array[0].Table.PrimaryKey = array;
					}
				}
				if (keyNode is XmlSchemaKey)
				{
					for (int i = 0; i < array.Length; i++)
					{
						array[i].AllowDBNull = false;
					}
				}
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00030CA8 File Offset: 0x0002EEA8
		internal DataTable InstantiateSimpleTable(XmlSchemaElement node)
		{
			string text = XmlConvert.DecodeName(this.GetInstanceName(node));
			string @namespace = node.QualifiedName.Namespace;
			DataTable dataTable = this._ds.Tables.GetTable(text, @namespace);
			if (!this.FromInference && dataTable != null)
			{
				throw ExceptionBuilder.DuplicateDeclaration(text);
			}
			if (dataTable == null)
			{
				dataTable = new DataTable(text);
				dataTable.Namespace = @namespace;
				dataTable.Namespace = this.GetStringAttribute(node, "targetNamespace", @namespace);
				if (!this.FromInference)
				{
					dataTable.MinOccurs = node.MinOccurs;
					dataTable.MaxOccurs = node.MaxOccurs;
				}
				else
				{
					string prefix = this.GetPrefix(@namespace);
					if (prefix != null)
					{
						dataTable.Prefix = prefix;
					}
				}
				XSDSchema.SetProperties(dataTable, node.UnhandledAttributes);
				XSDSchema.SetExtProperties(dataTable, node.UnhandledAttributes);
			}
			XmlSchemaComplexType xmlSchemaComplexType = node.SchemaType as XmlSchemaComplexType;
			bool flag = node.ElementSchemaType.BaseXmlSchemaType != null || (xmlSchemaComplexType != null && xmlSchemaComplexType.ContentModel is XmlSchemaSimpleContent);
			if (!this.FromInference || (flag && dataTable.Columns.Count == 0))
			{
				this.HandleElementColumn(node, dataTable, false);
				string text2;
				if (this.FromInference)
				{
					int num = 0;
					text2 = text + "_Text";
					while (dataTable.Columns[text2] != null)
					{
						text2 += num++.ToString();
					}
				}
				else
				{
					text2 = text + "_Column";
				}
				dataTable.Columns[0].ColumnName = text2;
				dataTable.Columns[0].ColumnMapping = MappingType.SimpleContent;
			}
			if (!this.FromInference || this._ds.Tables.GetTable(text, @namespace) == null)
			{
				this._ds.Tables.Add(dataTable);
				if (this.FromInference)
				{
					this._tableDictionary.Add(dataTable, new List<DataTable>());
				}
			}
			if (this._dsElement != null && this._dsElement.Constraints != null)
			{
				foreach (XmlSchemaObject xmlSchemaObject in this._dsElement.Constraints)
				{
					XmlSchemaIdentityConstraint xmlSchemaIdentityConstraint = (XmlSchemaIdentityConstraint)xmlSchemaObject;
					if (!(xmlSchemaIdentityConstraint is XmlSchemaKeyref) && this.GetTableName(xmlSchemaIdentityConstraint) == dataTable.TableName)
					{
						this.HandleConstraint(xmlSchemaIdentityConstraint);
					}
				}
			}
			dataTable._fNestedInDataset = false;
			return dataTable;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00030F10 File Offset: 0x0002F110
		internal string GetInstanceName(XmlSchemaAnnotated node)
		{
			string result = null;
			if (node is XmlSchemaElement)
			{
				XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)node;
				result = ((xmlSchemaElement.Name != null) ? xmlSchemaElement.Name : xmlSchemaElement.RefName.Name);
			}
			else if (node is XmlSchemaAttribute)
			{
				XmlSchemaAttribute xmlSchemaAttribute = (XmlSchemaAttribute)node;
				result = ((xmlSchemaAttribute.Name != null) ? xmlSchemaAttribute.Name : xmlSchemaAttribute.RefName.Name);
			}
			return result;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00030F78 File Offset: 0x0002F178
		internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef)
		{
			string instanceName = this.GetInstanceName(node);
			ArrayList arrayList = new ArrayList();
			string @namespace = node.QualifiedName.Namespace;
			DataTable dataTable = this._ds.Tables.GetTable(XmlConvert.DecodeName(instanceName), @namespace);
			if (!this.FromInference || (this.FromInference && dataTable == null))
			{
				if (dataTable != null)
				{
					if (isRef)
					{
						return dataTable;
					}
					throw ExceptionBuilder.DuplicateDeclaration(instanceName);
				}
				else
				{
					if (isRef)
					{
						this._refTables.Add(@namespace + ":" + instanceName);
					}
					dataTable = new DataTable(XmlConvert.DecodeName(instanceName));
					dataTable.TypeName = node.SchemaTypeName;
					dataTable.Namespace = @namespace;
					dataTable.Namespace = this.GetStringAttribute(node, "targetNamespace", @namespace);
					string text = this.GetStringAttribute(typeNode, "CaseSensitive", "");
					if (text.Length == 0)
					{
						text = this.GetStringAttribute(node, "CaseSensitive", "");
					}
					if (0 < text.Length)
					{
						if (text == "true" || text == "True")
						{
							dataTable.CaseSensitive = true;
						}
						if (text == "false" || text == "False")
						{
							dataTable.CaseSensitive = false;
						}
					}
					text = XSDSchema.GetMsdataAttribute(node, "Locale");
					if (text != null)
					{
						if (0 < text.Length)
						{
							dataTable.Locale = new CultureInfo(text);
						}
						else
						{
							dataTable.Locale = CultureInfo.InvariantCulture;
						}
					}
					if (!this.FromInference)
					{
						dataTable.MinOccurs = node.MinOccurs;
						dataTable.MaxOccurs = node.MaxOccurs;
					}
					else
					{
						string prefix = this.GetPrefix(@namespace);
						if (prefix != null)
						{
							dataTable.Prefix = prefix;
						}
					}
					this._ds.Tables.Add(dataTable);
					if (this.FromInference)
					{
						this._tableDictionary.Add(dataTable, new List<DataTable>());
					}
				}
			}
			this.HandleComplexType(typeNode, dataTable, arrayList, node.IsNillable);
			for (int i = 0; i < dataTable.Columns.Count; i++)
			{
				dataTable.Columns[i].SetOrdinalInternal(i);
			}
			XSDSchema.SetProperties(dataTable, node.UnhandledAttributes);
			XSDSchema.SetExtProperties(dataTable, node.UnhandledAttributes);
			if (this._dsElement != null && this._dsElement.Constraints != null)
			{
				foreach (XmlSchemaObject xmlSchemaObject in this._dsElement.Constraints)
				{
					XmlSchemaIdentityConstraint xmlSchemaIdentityConstraint = (XmlSchemaIdentityConstraint)xmlSchemaObject;
					if (!(xmlSchemaIdentityConstraint is XmlSchemaKeyref) && this.GetTableName(xmlSchemaIdentityConstraint) == dataTable.TableName && (this.GetTableNamespace(xmlSchemaIdentityConstraint) == dataTable.Namespace || this.GetTableNamespace(xmlSchemaIdentityConstraint) == null))
					{
						this.HandleConstraint(xmlSchemaIdentityConstraint);
					}
				}
			}
			foreach (object obj in arrayList)
			{
				DataTable dataTable2 = (DataTable)obj;
				if (dataTable2 != dataTable && dataTable.Namespace == dataTable2.Namespace)
				{
					dataTable2._tableNamespace = null;
				}
				if (this._dsElement != null && this._dsElement.Constraints != null)
				{
					foreach (XmlSchemaObject xmlSchemaObject2 in this._dsElement.Constraints)
					{
						XmlSchemaKeyref xmlSchemaKeyref = ((XmlSchemaIdentityConstraint)xmlSchemaObject2) as XmlSchemaKeyref;
						if (xmlSchemaKeyref != null && this.GetBooleanAttribute(xmlSchemaKeyref, "IsNested", false) && this.GetTableName(xmlSchemaKeyref) == dataTable2.TableName)
						{
							if (dataTable2.DataSet.Tables.InternalIndexOf(dataTable2.TableName) < -1)
							{
								if (this.GetTableNamespace(xmlSchemaKeyref) == dataTable2.Namespace)
								{
									this.HandleKeyref(xmlSchemaKeyref);
								}
							}
							else
							{
								this.HandleKeyref(xmlSchemaKeyref);
							}
						}
					}
				}
				DataRelation dataRelation = null;
				DataRelationCollection childRelations = dataTable.ChildRelations;
				for (int j = 0; j < childRelations.Count; j++)
				{
					if (childRelations[j].Nested && dataTable2 == childRelations[j].ChildTable)
					{
						dataRelation = childRelations[j];
					}
				}
				if (dataRelation == null)
				{
					DataColumn dataColumn2;
					if (this.FromInference)
					{
						int num = dataTable.UKColumnPositionForInference;
						if (num == -1)
						{
							foreach (object obj2 in dataTable.Columns)
							{
								DataColumn dataColumn = (DataColumn)obj2;
								if (dataColumn.ColumnMapping == MappingType.Attribute)
								{
									num = dataColumn.Ordinal;
									break;
								}
							}
						}
						dataColumn2 = dataTable.AddUniqueKey(num);
					}
					else
					{
						dataColumn2 = dataTable.AddUniqueKey();
					}
					DataColumn dataColumn3 = dataTable2.AddForeignKey(dataColumn2);
					if (this.FromInference)
					{
						dataColumn3.Prefix = dataTable2.Prefix;
					}
					dataRelation = new DataRelation(dataTable.TableName + "_" + dataTable2.TableName, dataColumn2, dataColumn3, true);
					dataRelation.Nested = true;
					dataTable2.DataSet.Relations.Add(dataRelation);
					if (this.FromInference && dataRelation.Nested && this._tableDictionary.ContainsKey(dataRelation.ParentTable))
					{
						this._tableDictionary[dataRelation.ParentTable].Add(dataRelation.ChildTable);
					}
				}
			}
			return dataTable;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00031544 File Offset: 0x0002F744
		public static Type XsdtoClr(string xsdTypeName)
		{
			int num = Array.BinarySearch(XSDSchema.s_mapNameTypeXsd, xsdTypeName);
			if (num < 0)
			{
				throw ExceptionBuilder.UndefinedDatatype(xsdTypeName);
			}
			return XSDSchema.s_mapNameTypeXsd[num].type;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00031574 File Offset: 0x0002F774
		private static XSDSchema.NameType FindNameType(string name)
		{
			int num = Array.BinarySearch(XSDSchema.s_mapNameTypeXsd, name);
			if (num < 0)
			{
				throw ExceptionBuilder.UndefinedDatatype(name);
			}
			return XSDSchema.s_mapNameTypeXsd[num];
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000315A0 File Offset: 0x0002F7A0
		private Type ParseDataType(string dt)
		{
			if (XSDSchema.IsXsdType(dt) || this._udSimpleTypes == null)
			{
				return XSDSchema.FindNameType(dt).type;
			}
			XmlSchemaSimpleType xmlSchemaSimpleType = (XmlSchemaSimpleType)this._udSimpleTypes[dt];
			if (xmlSchemaSimpleType == null)
			{
				throw ExceptionBuilder.UndefinedDatatype(dt);
			}
			SimpleType simpleType = new SimpleType(xmlSchemaSimpleType);
			while (simpleType.BaseSimpleType != null)
			{
				simpleType = simpleType.BaseSimpleType;
			}
			return this.ParseDataType(simpleType.BaseType);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00031607 File Offset: 0x0002F807
		internal static bool IsXsdType(string name)
		{
			return Array.BinarySearch(XSDSchema.s_mapNameTypeXsd, name) >= 0;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0003161C File Offset: 0x0002F81C
		internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node)
		{
			XmlSchemaAttribute xmlSchemaAttribute = node as XmlSchemaAttribute;
			XmlSchemaElement xmlSchemaElement = node as XmlSchemaElement;
			bool flag = false;
			if (xmlSchemaAttribute != null)
			{
				flag = true;
			}
			string text = flag ? xmlSchemaAttribute.SchemaTypeName.Name : xmlSchemaElement.SchemaTypeName.Name;
			if ((flag ? xmlSchemaAttribute.SchemaTypeName.Namespace : xmlSchemaElement.SchemaTypeName.Namespace) == "http://www.w3.org/2001/XMLSchema")
			{
				return null;
			}
			XmlSchemaAnnotated result;
			if (text == null || text.Length == 0)
			{
				text = (flag ? xmlSchemaAttribute.RefName.Name : xmlSchemaElement.RefName.Name);
				if (text == null || text.Length == 0)
				{
					result = (flag ? xmlSchemaAttribute.SchemaType : xmlSchemaElement.SchemaType);
				}
				else
				{
					result = (flag ? this.FindTypeNode((XmlSchemaAnnotated)this._attributes[xmlSchemaAttribute.RefName]) : this.FindTypeNode((XmlSchemaAnnotated)this._elementsTable[xmlSchemaElement.RefName]));
				}
			}
			else
			{
				result = (XmlSchemaAnnotated)this._schemaTypes[flag ? ((XmlSchemaAttribute)node).SchemaTypeName : ((XmlSchemaElement)node).SchemaTypeName];
			}
			return result;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0003173C File Offset: 0x0002F93C
		internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable)
		{
			if (this.FromInference && table.XmlText != null)
			{
				return;
			}
			Type type = null;
			SimpleType simpleType = null;
			if (typeNode.QualifiedName.Name != null && typeNode.QualifiedName.Name.Length != 0 && typeNode.QualifiedName.Namespace != "http://www.w3.org/2001/XMLSchema")
			{
				simpleType = new SimpleType(typeNode);
				strType = typeNode.QualifiedName.ToString();
				type = this.ParseDataType(typeNode.QualifiedName.ToString());
			}
			else
			{
				XmlSchemaSimpleType xmlSchemaSimpleType = typeNode.BaseXmlSchemaType as XmlSchemaSimpleType;
				if (xmlSchemaSimpleType != null && xmlSchemaSimpleType.QualifiedName.Namespace != "http://www.w3.org/2001/XMLSchema")
				{
					simpleType = new SimpleType(typeNode);
					SimpleType simpleType2 = simpleType;
					while (simpleType2.BaseSimpleType != null)
					{
						simpleType2 = simpleType2.BaseSimpleType;
					}
					type = this.ParseDataType(simpleType2.BaseType);
					strType = simpleType.Name;
				}
				else
				{
					type = this.ParseDataType(strType);
				}
			}
			string text;
			if (this.FromInference)
			{
				int num = 0;
				text = table.TableName + "_Text";
				while (table.Columns[text] != null)
				{
					text += num++.ToString();
				}
			}
			else
			{
				text = table.TableName + "_text";
			}
			string text2 = text;
			bool flag = true;
			DataColumn dataColumn;
			if (!isBase && table.Columns.Contains(text2, true))
			{
				dataColumn = table.Columns[text2];
				flag = false;
			}
			else
			{
				dataColumn = new DataColumn(text2, type, null, MappingType.SimpleContent);
			}
			XSDSchema.SetProperties(dataColumn, attrs);
			this.HandleColumnExpression(dataColumn, attrs);
			XSDSchema.SetExtProperties(dataColumn, attrs);
			string value = -1.ToString(CultureInfo.CurrentCulture);
			string text3 = null;
			dataColumn.AllowDBNull = isNillable;
			if (attrs != null)
			{
				for (int i = 0; i < attrs.Length; i++)
				{
					if (attrs[i].LocalName == "AllowDBNull" && attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata" && attrs[i].Value == "false")
					{
						dataColumn.AllowDBNull = false;
					}
					if (attrs[i].LocalName == "Ordinal" && attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata")
					{
						value = attrs[i].Value;
					}
					if (attrs[i].LocalName == "DefaultValue" && attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata")
					{
						text3 = attrs[i].Value;
					}
				}
			}
			int num2 = (int)Convert.ChangeType(value, typeof(int), null);
			if (dataColumn.Expression != null && dataColumn.Expression.Length != 0)
			{
				this._columnExpressions.Add(dataColumn);
			}
			if (simpleType != null && simpleType.Name != null && simpleType.Name.Length > 0)
			{
				if (XSDSchema.GetMsdataAttribute(typeNode, "targetNamespace") != null)
				{
					dataColumn.XmlDataType = simpleType.SimpleTypeQualifiedName;
				}
			}
			else
			{
				dataColumn.XmlDataType = strType;
			}
			dataColumn.SimpleType = simpleType;
			if (flag)
			{
				if (this.FromInference)
				{
					dataColumn.Prefix = this.GetPrefix(table.Namespace);
					dataColumn.AllowDBNull = true;
				}
				if (num2 > -1 && num2 < table.Columns.Count)
				{
					table.Columns.AddAt(num2, dataColumn);
				}
				else
				{
					table.Columns.Add(dataColumn);
				}
			}
			if (text3 != null)
			{
				try
				{
					dataColumn.DefaultValue = dataColumn.ConvertXmlToObject(text3);
				}
				catch (FormatException)
				{
					throw ExceptionBuilder.CannotConvert(text3, type.FullName);
				}
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00031AC4 File Offset: 0x0002FCC4
		internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable)
		{
			if (this.FromInference && table.XmlText != null)
			{
				return;
			}
			Type type = null;
			if (strType == null)
			{
				return;
			}
			type = this.ParseDataType(strType);
			string text;
			if (this.FromInference)
			{
				int num = 0;
				text = table.TableName + "_Text";
				while (table.Columns[text] != null)
				{
					text += num++.ToString();
				}
			}
			else
			{
				text = table.TableName + "_text";
			}
			string text2 = text;
			bool flag = true;
			DataColumn dataColumn;
			if (!isBase && table.Columns.Contains(text2, true))
			{
				dataColumn = table.Columns[text2];
				flag = false;
			}
			else
			{
				dataColumn = new DataColumn(text2, type, null, MappingType.SimpleContent);
			}
			XSDSchema.SetProperties(dataColumn, attrs);
			this.HandleColumnExpression(dataColumn, attrs);
			XSDSchema.SetExtProperties(dataColumn, attrs);
			string value = -1.ToString(CultureInfo.CurrentCulture);
			string text3 = null;
			dataColumn.AllowDBNull = isNillable;
			if (attrs != null)
			{
				for (int i = 0; i < attrs.Length; i++)
				{
					if (attrs[i].LocalName == "AllowDBNull" && attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata" && attrs[i].Value == "false")
					{
						dataColumn.AllowDBNull = false;
					}
					if (attrs[i].LocalName == "Ordinal" && attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata")
					{
						value = attrs[i].Value;
					}
					if (attrs[i].LocalName == "DefaultValue" && attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata")
					{
						text3 = attrs[i].Value;
					}
				}
			}
			int num2 = (int)Convert.ChangeType(value, typeof(int), null);
			if (dataColumn.Expression != null && dataColumn.Expression.Length != 0)
			{
				this._columnExpressions.Add(dataColumn);
			}
			dataColumn.XmlDataType = strType;
			dataColumn.SimpleType = null;
			if (this.FromInference)
			{
				dataColumn.Prefix = this.GetPrefix(dataColumn.Namespace);
			}
			if (flag)
			{
				if (this.FromInference)
				{
					dataColumn.AllowDBNull = true;
				}
				if (num2 > -1 && num2 < table.Columns.Count)
				{
					table.Columns.AddAt(num2, dataColumn);
				}
				else
				{
					table.Columns.Add(dataColumn);
				}
			}
			if (text3 != null)
			{
				try
				{
					dataColumn.DefaultValue = dataColumn.ConvertXmlToObject(text3);
				}
				catch (FormatException)
				{
					throw ExceptionBuilder.CannotConvert(text3, type.FullName);
				}
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00031D60 File Offset: 0x0002FF60
		internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase)
		{
			Type type = null;
			XmlSchemaAttribute xmlSchemaAttribute = (attrib.Name != null) ? attrib : ((XmlSchemaAttribute)this._attributes[attrib.RefName]);
			XmlSchemaAnnotated xmlSchemaAnnotated = this.FindTypeNode(xmlSchemaAttribute);
			SimpleType simpleType = null;
			string text;
			if (xmlSchemaAnnotated == null)
			{
				text = xmlSchemaAttribute.SchemaTypeName.Name;
				if (string.IsNullOrEmpty(text))
				{
					text = string.Empty;
					type = typeof(string);
				}
				else if (xmlSchemaAttribute.SchemaTypeName.Namespace != "http://www.w3.org/2001/XMLSchema")
				{
					type = this.ParseDataType(xmlSchemaAttribute.SchemaTypeName.ToString());
				}
				else
				{
					type = this.ParseDataType(xmlSchemaAttribute.SchemaTypeName.Name);
				}
			}
			else if (xmlSchemaAnnotated is XmlSchemaSimpleType)
			{
				XmlSchemaSimpleType xmlSchemaSimpleType = xmlSchemaAnnotated as XmlSchemaSimpleType;
				simpleType = new SimpleType(xmlSchemaSimpleType);
				if (xmlSchemaSimpleType.QualifiedName.Name != null && xmlSchemaSimpleType.QualifiedName.Name.Length != 0 && xmlSchemaSimpleType.QualifiedName.Namespace != "http://www.w3.org/2001/XMLSchema")
				{
					text = xmlSchemaSimpleType.QualifiedName.ToString();
					type = this.ParseDataType(xmlSchemaSimpleType.QualifiedName.ToString());
				}
				else
				{
					type = this.ParseDataType(simpleType.BaseType);
					text = simpleType.Name;
					if (simpleType.Length == 1 && type == typeof(string))
					{
						type = typeof(char);
					}
				}
			}
			else if (xmlSchemaAnnotated is XmlSchemaElement)
			{
				text = ((XmlSchemaElement)xmlSchemaAnnotated).SchemaTypeName.Name;
				type = this.ParseDataType(text);
			}
			else
			{
				if (xmlSchemaAnnotated.Id == null)
				{
					throw ExceptionBuilder.DatatypeNotDefined();
				}
				throw ExceptionBuilder.UndefinedDatatype(xmlSchemaAnnotated.Id);
			}
			string text2 = XmlConvert.DecodeName(this.GetInstanceName(xmlSchemaAttribute));
			bool flag = true;
			DataColumn dataColumn;
			if ((!isBase || this.FromInference) && table.Columns.Contains(text2, true))
			{
				dataColumn = table.Columns[text2];
				flag = false;
				if (this.FromInference)
				{
					if (dataColumn.ColumnMapping != MappingType.Attribute)
					{
						throw ExceptionBuilder.ColumnTypeConflict(dataColumn.ColumnName);
					}
					if ((string.IsNullOrEmpty(attrib.QualifiedName.Namespace) && string.IsNullOrEmpty(dataColumn._columnUri)) || string.Equals(attrib.QualifiedName.Namespace, dataColumn.Namespace, StringComparison.Ordinal))
					{
						return;
					}
					dataColumn = new DataColumn(text2, type, null, MappingType.Attribute);
					flag = true;
				}
			}
			else
			{
				dataColumn = new DataColumn(text2, type, null, MappingType.Attribute);
			}
			XSDSchema.SetProperties(dataColumn, xmlSchemaAttribute.UnhandledAttributes);
			this.HandleColumnExpression(dataColumn, xmlSchemaAttribute.UnhandledAttributes);
			XSDSchema.SetExtProperties(dataColumn, xmlSchemaAttribute.UnhandledAttributes);
			if (dataColumn.Expression != null && dataColumn.Expression.Length != 0)
			{
				this._columnExpressions.Add(dataColumn);
			}
			if (simpleType != null && simpleType.Name != null && simpleType.Name.Length > 0)
			{
				if (XSDSchema.GetMsdataAttribute(xmlSchemaAnnotated, "targetNamespace") != null)
				{
					dataColumn.XmlDataType = simpleType.SimpleTypeQualifiedName;
				}
			}
			else
			{
				dataColumn.XmlDataType = text;
			}
			dataColumn.SimpleType = simpleType;
			dataColumn.AllowDBNull = (attrib.Use != XmlSchemaUse.Required);
			dataColumn.Namespace = attrib.QualifiedName.Namespace;
			dataColumn.Namespace = this.GetStringAttribute(attrib, "targetNamespace", dataColumn.Namespace);
			if (flag)
			{
				if (this.FromInference)
				{
					dataColumn.AllowDBNull = true;
					dataColumn.Prefix = this.GetPrefix(dataColumn.Namespace);
				}
				table.Columns.Add(dataColumn);
			}
			if (attrib.Use == XmlSchemaUse.Prohibited)
			{
				dataColumn.ColumnMapping = MappingType.Hidden;
				dataColumn.AllowDBNull = this.GetBooleanAttribute(xmlSchemaAttribute, "AllowDBNull", true);
				string msdataAttribute = XSDSchema.GetMsdataAttribute(xmlSchemaAttribute, "DefaultValue");
				if (msdataAttribute != null)
				{
					try
					{
						dataColumn.DefaultValue = dataColumn.ConvertXmlToObject(msdataAttribute);
					}
					catch (FormatException)
					{
						throw ExceptionBuilder.CannotConvert(msdataAttribute, type.FullName);
					}
				}
			}
			string text3 = (attrib.Use == XmlSchemaUse.Required) ? XSDSchema.GetMsdataAttribute(xmlSchemaAttribute, "DefaultValue") : xmlSchemaAttribute.DefaultValue;
			if (xmlSchemaAttribute.Use == XmlSchemaUse.Optional && text3 == null)
			{
				text3 = xmlSchemaAttribute.FixedValue;
			}
			if (text3 != null)
			{
				try
				{
					dataColumn.DefaultValue = dataColumn.ConvertXmlToObject(text3);
				}
				catch (FormatException)
				{
					throw ExceptionBuilder.CannotConvert(text3, type.FullName);
				}
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00032194 File Offset: 0x00030394
		internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase)
		{
			Type type = null;
			XmlSchemaElement xmlSchemaElement = (elem.Name != null) ? elem : ((XmlSchemaElement)this._elementsTable[elem.RefName]);
			if (xmlSchemaElement == null)
			{
				return;
			}
			XmlSchemaAnnotated xmlSchemaAnnotated = this.FindTypeNode(xmlSchemaElement);
			string text = null;
			SimpleType simpleType = null;
			if (xmlSchemaAnnotated == null)
			{
				text = xmlSchemaElement.SchemaTypeName.Name;
				if (string.IsNullOrEmpty(text))
				{
					text = string.Empty;
					type = typeof(string);
				}
				else
				{
					type = this.ParseDataType(xmlSchemaElement.SchemaTypeName.Name);
				}
			}
			else if (xmlSchemaAnnotated is XmlSchemaSimpleType)
			{
				XmlSchemaSimpleType node = xmlSchemaAnnotated as XmlSchemaSimpleType;
				simpleType = new SimpleType(node);
				if (((XmlSchemaSimpleType)xmlSchemaAnnotated).Name != null && ((XmlSchemaSimpleType)xmlSchemaAnnotated).Name.Length != 0 && ((XmlSchemaSimpleType)xmlSchemaAnnotated).QualifiedName.Namespace != "http://www.w3.org/2001/XMLSchema")
				{
					XSDSchema.GetMsdataAttribute(xmlSchemaAnnotated, "targetNamespace");
					text = ((XmlSchemaSimpleType)xmlSchemaAnnotated).QualifiedName.ToString();
					type = this.ParseDataType(text);
				}
				else
				{
					for (node = ((simpleType.XmlBaseType != null && simpleType.XmlBaseType.Namespace != "http://www.w3.org/2001/XMLSchema") ? (this._schemaTypes[simpleType.XmlBaseType] as XmlSchemaSimpleType) : null); node != null; node = ((simpleType.XmlBaseType != null && simpleType.XmlBaseType.Namespace != "http://www.w3.org/2001/XMLSchema") ? (this._schemaTypes[simpleType.XmlBaseType] as XmlSchemaSimpleType) : null))
					{
						simpleType.LoadTypeValues(node);
					}
					type = this.ParseDataType(simpleType.BaseType);
					text = simpleType.Name;
					if (simpleType.Length == 1 && type == typeof(string))
					{
						type = typeof(char);
					}
				}
			}
			else if (xmlSchemaAnnotated is XmlSchemaElement)
			{
				text = ((XmlSchemaElement)xmlSchemaAnnotated).SchemaTypeName.Name;
				type = this.ParseDataType(text);
			}
			else if (xmlSchemaAnnotated is XmlSchemaComplexType)
			{
				if (string.IsNullOrEmpty(XSDSchema.GetMsdataAttribute(elem, "DataType")))
				{
					throw ExceptionBuilder.DatatypeNotDefined();
				}
				type = typeof(object);
			}
			else
			{
				if (xmlSchemaAnnotated.Id == null)
				{
					throw ExceptionBuilder.DatatypeNotDefined();
				}
				throw ExceptionBuilder.UndefinedDatatype(xmlSchemaAnnotated.Id);
			}
			string text2 = XmlConvert.DecodeName(this.GetInstanceName(xmlSchemaElement));
			bool flag = true;
			DataColumn dataColumn;
			if ((!isBase || this.FromInference) && table.Columns.Contains(text2, true))
			{
				dataColumn = table.Columns[text2];
				flag = false;
				if (this.FromInference)
				{
					if (dataColumn.ColumnMapping != MappingType.Element)
					{
						throw ExceptionBuilder.ColumnTypeConflict(dataColumn.ColumnName);
					}
					if ((string.IsNullOrEmpty(elem.QualifiedName.Namespace) && string.IsNullOrEmpty(dataColumn._columnUri)) || string.Equals(elem.QualifiedName.Namespace, dataColumn.Namespace, StringComparison.Ordinal))
					{
						return;
					}
					dataColumn = new DataColumn(text2, type, null, MappingType.Element);
					flag = true;
				}
			}
			else
			{
				dataColumn = new DataColumn(text2, type, null, MappingType.Element);
			}
			XSDSchema.SetProperties(dataColumn, xmlSchemaElement.UnhandledAttributes);
			this.HandleColumnExpression(dataColumn, xmlSchemaElement.UnhandledAttributes);
			XSDSchema.SetExtProperties(dataColumn, xmlSchemaElement.UnhandledAttributes);
			if (!string.IsNullOrEmpty(dataColumn.Expression))
			{
				this._columnExpressions.Add(dataColumn);
			}
			if (simpleType != null && simpleType.Name != null && simpleType.Name.Length > 0)
			{
				if (XSDSchema.GetMsdataAttribute(xmlSchemaAnnotated, "targetNamespace") != null)
				{
					dataColumn.XmlDataType = simpleType.SimpleTypeQualifiedName;
				}
			}
			else
			{
				dataColumn.XmlDataType = text;
			}
			dataColumn.SimpleType = simpleType;
			dataColumn.AllowDBNull = (this.FromInference || elem.MinOccurs == 0m || elem.IsNillable);
			if (!elem.RefName.IsEmpty || elem.QualifiedName.Namespace != table.Namespace)
			{
				dataColumn.Namespace = elem.QualifiedName.Namespace;
				dataColumn.Namespace = this.GetStringAttribute(xmlSchemaElement, "targetNamespace", dataColumn.Namespace);
			}
			else if (elem.Form == XmlSchemaForm.Unqualified)
			{
				dataColumn.Namespace = string.Empty;
			}
			else if (elem.Form == XmlSchemaForm.None)
			{
				XmlSchemaObject parent = elem.Parent;
				while (parent.Parent != null)
				{
					parent = parent.Parent;
				}
				if (((XmlSchema)parent).ElementFormDefault == XmlSchemaForm.Unqualified)
				{
					dataColumn.Namespace = string.Empty;
				}
			}
			else
			{
				dataColumn.Namespace = elem.QualifiedName.Namespace;
				dataColumn.Namespace = this.GetStringAttribute(xmlSchemaElement, "targetNamespace", dataColumn.Namespace);
			}
			int num = (int)Convert.ChangeType(this.GetStringAttribute(elem, "Ordinal", -1.ToString(CultureInfo.CurrentCulture)), typeof(int), null);
			if (flag)
			{
				if (num > -1 && num < table.Columns.Count)
				{
					table.Columns.AddAt(num, dataColumn);
				}
				else
				{
					table.Columns.Add(dataColumn);
				}
			}
			if (dataColumn.Namespace == table.Namespace)
			{
				dataColumn._columnUri = null;
			}
			if (this.FromInference)
			{
				dataColumn.Prefix = this.GetPrefix(dataColumn.Namespace);
			}
			string defaultValue = xmlSchemaElement.DefaultValue;
			if (defaultValue != null)
			{
				try
				{
					dataColumn.DefaultValue = dataColumn.ConvertXmlToObject(defaultValue);
				}
				catch (FormatException)
				{
					throw ExceptionBuilder.CannotConvert(defaultValue, type.FullName);
				}
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00032704 File Offset: 0x00030904
		internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet)
		{
			string text = node.Name;
			string @namespace = node.QualifiedName.Namespace;
			int count = this._ds.Tables.Count;
			List<DataTable> list = new List<DataTable>();
			string msdataAttribute = XSDSchema.GetMsdataAttribute(node, "Locale");
			if (msdataAttribute != null)
			{
				if (msdataAttribute.Length != 0)
				{
					this._ds.Locale = new CultureInfo(msdataAttribute);
				}
				else
				{
					this._ds.Locale = CultureInfo.InvariantCulture;
				}
			}
			else if (this.GetBooleanAttribute(node, "UseCurrentLocale", false))
			{
				this._ds.SetLocaleValue(CultureInfo.CurrentCulture, false);
			}
			else
			{
				this._ds.SetLocaleValue(new CultureInfo(1033), false);
			}
			msdataAttribute = XSDSchema.GetMsdataAttribute(node, "DataSetName");
			if (msdataAttribute != null && msdataAttribute.Length != 0)
			{
				text = msdataAttribute;
			}
			msdataAttribute = XSDSchema.GetMsdataAttribute(node, "DataSetNamespace");
			if (msdataAttribute != null && msdataAttribute.Length != 0)
			{
				@namespace = msdataAttribute;
			}
			XSDSchema.SetProperties(this._ds, node.UnhandledAttributes);
			XSDSchema.SetExtProperties(this._ds, node.UnhandledAttributes);
			if (text != null && text.Length != 0)
			{
				this._ds.DataSetName = XmlConvert.DecodeName(text);
			}
			this._ds.Namespace = @namespace;
			if (this.FromInference)
			{
				this._ds.Prefix = this.GetPrefix(this._ds.Namespace);
			}
			XmlSchemaComplexType xmlSchemaComplexType = (XmlSchemaComplexType)this.FindTypeNode(node);
			if (xmlSchemaComplexType.Particle != null)
			{
				XmlSchemaObjectCollection particleItems = this.GetParticleItems(xmlSchemaComplexType.Particle);
				if (particleItems == null)
				{
					return;
				}
				foreach (XmlSchemaObject xmlSchemaObject in particleItems)
				{
					XmlSchemaAnnotated xmlSchemaAnnotated = (XmlSchemaAnnotated)xmlSchemaObject;
					if (xmlSchemaAnnotated is XmlSchemaElement)
					{
						if (((XmlSchemaElement)xmlSchemaAnnotated).RefName.Name.Length != 0)
						{
							if (!this.FromInference)
							{
								continue;
							}
							DataTable table = this._ds.Tables.GetTable(XmlConvert.DecodeName(this.GetInstanceName((XmlSchemaElement)xmlSchemaAnnotated)), node.QualifiedName.Namespace);
							if (table != null)
							{
								list.Add(table);
							}
							bool flag = false;
							if (node.ElementSchemaType != null || !(((XmlSchemaElement)xmlSchemaAnnotated).SchemaType is XmlSchemaComplexType))
							{
								flag = true;
							}
							if (((XmlSchemaElement)xmlSchemaAnnotated).MaxOccurs != 1m && !flag)
							{
								continue;
							}
						}
						DataTable dataTable = this.HandleTable((XmlSchemaElement)xmlSchemaAnnotated);
						if (dataTable != null)
						{
							dataTable._fNestedInDataset = true;
						}
						if (this.FromInference)
						{
							list.Add(dataTable);
						}
					}
					else if (xmlSchemaAnnotated is XmlSchemaChoice)
					{
						XmlSchemaObjectCollection items = ((XmlSchemaChoice)xmlSchemaAnnotated).Items;
						if (items != null)
						{
							foreach (XmlSchemaObject xmlSchemaObject2 in items)
							{
								XmlSchemaAnnotated xmlSchemaAnnotated2 = (XmlSchemaAnnotated)xmlSchemaObject2;
								if (xmlSchemaAnnotated2 is XmlSchemaElement)
								{
									if (((XmlSchemaParticle)xmlSchemaAnnotated).MaxOccurs > 1m && ((XmlSchemaElement)xmlSchemaAnnotated2).SchemaType is XmlSchemaComplexType)
									{
										((XmlSchemaElement)xmlSchemaAnnotated2).MaxOccurs = ((XmlSchemaParticle)xmlSchemaAnnotated).MaxOccurs;
									}
									if (((XmlSchemaElement)xmlSchemaAnnotated2).RefName.Name.Length == 0 || this.FromInference || !(((XmlSchemaElement)xmlSchemaAnnotated2).MaxOccurs != 1m) || ((XmlSchemaElement)xmlSchemaAnnotated2).SchemaType is XmlSchemaComplexType)
									{
										DataTable dataTable2 = this.HandleTable((XmlSchemaElement)xmlSchemaAnnotated2);
										if (this.FromInference)
										{
											list.Add(dataTable2);
										}
										if (dataTable2 != null)
										{
											dataTable2._fNestedInDataset = true;
										}
									}
								}
							}
						}
					}
				}
			}
			if (node.Constraints != null)
			{
				foreach (XmlSchemaObject xmlSchemaObject3 in node.Constraints)
				{
					XmlSchemaKeyref xmlSchemaKeyref = ((XmlSchemaIdentityConstraint)xmlSchemaObject3) as XmlSchemaKeyref;
					if (xmlSchemaKeyref != null && !this.GetBooleanAttribute(xmlSchemaKeyref, "IsNested", false))
					{
						this.HandleKeyref(xmlSchemaKeyref);
					}
				}
			}
			if (this.FromInference && isNewDataSet)
			{
				List<DataTable> tableList = new List<DataTable>(this._ds.Tables.Count);
				foreach (DataTable dt in list)
				{
					this.AddTablesToList(tableList, dt);
				}
				this._ds.Tables.ReplaceFromInference(tableList);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00032BF4 File Offset: 0x00030DF4
		private void AddTablesToList(List<DataTable> tableList, DataTable dt)
		{
			if (!tableList.Contains(dt))
			{
				tableList.Add(dt);
				foreach (DataTable dt2 in this._tableDictionary[dt])
				{
					this.AddTablesToList(tableList, dt2);
				}
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00032C60 File Offset: 0x00030E60
		private string GetPrefix(string ns)
		{
			if (ns == null)
			{
				return null;
			}
			foreach (object obj in this._schemaSet.Schemas())
			{
				XmlQualifiedName[] array = ((XmlSchema)obj).Namespaces.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Namespace == ns)
					{
						return array[i].Name;
					}
				}
			}
			return null;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00032CF8 File Offset: 0x00030EF8
		private string GetNamespaceFromPrefix(string prefix)
		{
			if (prefix == null || prefix.Length == 0)
			{
				return null;
			}
			foreach (object obj in this._schemaSet.Schemas())
			{
				XmlQualifiedName[] array = ((XmlSchema)obj).Namespaces.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Name == prefix)
					{
						return array[i].Namespace;
					}
				}
			}
			return null;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00032D98 File Offset: 0x00030F98
		private string GetTableNamespace(XmlSchemaIdentityConstraint key)
		{
			string xpath = key.Selector.XPath;
			string[] array = xpath.Split('/', StringSplitOptions.None);
			string text = string.Empty;
			string text2 = array[array.Length - 1];
			if (text2 == null || text2.Length == 0)
			{
				throw ExceptionBuilder.InvalidSelector(xpath);
			}
			if (text2.IndexOf(':') != -1)
			{
				text = text2.Substring(0, text2.IndexOf(':'));
				text = XmlConvert.DecodeName(text);
				return this.GetNamespaceFromPrefix(text);
			}
			return XSDSchema.GetMsdataAttribute(key, "TableNamespace");
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00032E10 File Offset: 0x00031010
		private string GetTableName(XmlSchemaIdentityConstraint key)
		{
			string xpath = key.Selector.XPath;
			string[] array = xpath.Split(new char[]
			{
				'/',
				':'
			});
			string text = array[array.Length - 1];
			if (text == null || text.Length == 0)
			{
				throw ExceptionBuilder.InvalidSelector(xpath);
			}
			return XmlConvert.DecodeName(text);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00032E60 File Offset: 0x00031060
		internal bool IsTable(XmlSchemaElement node)
		{
			if (node.MaxOccurs == 0m)
			{
				return false;
			}
			XmlAttribute[] unhandledAttributes = node.UnhandledAttributes;
			if (unhandledAttributes != null)
			{
				foreach (XmlAttribute xmlAttribute in unhandledAttributes)
				{
					if (xmlAttribute.LocalName == "DataType" && xmlAttribute.Prefix == "msdata" && xmlAttribute.NamespaceURI == "urn:schemas-microsoft-com:xml-msdata")
					{
						return false;
					}
				}
			}
			object obj = this.FindTypeNode(node);
			if (node.MaxOccurs > 1m && obj == null)
			{
				return true;
			}
			if (obj == null || !(obj is XmlSchemaComplexType))
			{
				return false;
			}
			if (((XmlSchemaComplexType)obj).IsAbstract)
			{
				throw ExceptionBuilder.CannotInstantiateAbstract(node.Name);
			}
			return true;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00032F1C File Offset: 0x0003111C
		internal DataTable HandleTable(XmlSchemaElement node)
		{
			if (!this.IsTable(node))
			{
				return null;
			}
			object obj = this.FindTypeNode(node);
			if (node.MaxOccurs > 1m && obj == null)
			{
				return this.InstantiateSimpleTable(node);
			}
			DataTable dataTable = this.InstantiateTable(node, (XmlSchemaComplexType)obj, node.RefName != null);
			dataTable._fNestedInDataset = false;
			return dataTable;
		}

		// Token: 0x04000314 RID: 788
		private XmlSchemaSet _schemaSet;

		// Token: 0x04000315 RID: 789
		private XmlSchemaElement _dsElement;

		// Token: 0x04000316 RID: 790
		private DataSet _ds;

		// Token: 0x04000317 RID: 791
		private string _schemaName;

		// Token: 0x04000318 RID: 792
		private ArrayList _columnExpressions;

		// Token: 0x04000319 RID: 793
		private Hashtable _constraintNodes;

		// Token: 0x0400031A RID: 794
		private ArrayList _refTables;

		// Token: 0x0400031B RID: 795
		private ArrayList _complexTypes;

		// Token: 0x0400031C RID: 796
		private XmlSchemaObjectCollection _annotations;

		// Token: 0x0400031D RID: 797
		private XmlSchemaObjectCollection _elements;

		// Token: 0x0400031E RID: 798
		private Hashtable _attributes;

		// Token: 0x0400031F RID: 799
		private Hashtable _elementsTable;

		// Token: 0x04000320 RID: 800
		private Hashtable _attributeGroups;

		// Token: 0x04000321 RID: 801
		private Hashtable _schemaTypes;

		// Token: 0x04000322 RID: 802
		private Hashtable _expressions;

		// Token: 0x04000323 RID: 803
		private Dictionary<DataTable, List<DataTable>> _tableDictionary;

		// Token: 0x04000324 RID: 804
		private Hashtable _udSimpleTypes;

		// Token: 0x04000325 RID: 805
		private Hashtable _existingSimpleTypeMap;

		// Token: 0x04000326 RID: 806
		private bool _fromInference;

		// Token: 0x04000327 RID: 807
		private static readonly XSDSchema.NameType[] s_mapNameTypeXsd = new XSDSchema.NameType[]
		{
			new XSDSchema.NameType("ENTITIES", typeof(string)),
			new XSDSchema.NameType("ENTITY", typeof(string)),
			new XSDSchema.NameType("ID", typeof(string)),
			new XSDSchema.NameType("IDREF", typeof(string)),
			new XSDSchema.NameType("IDREFS", typeof(string)),
			new XSDSchema.NameType("NCName", typeof(string)),
			new XSDSchema.NameType("NMTOKEN", typeof(string)),
			new XSDSchema.NameType("NMTOKENS", typeof(string)),
			new XSDSchema.NameType("NOTATION", typeof(string)),
			new XSDSchema.NameType("Name", typeof(string)),
			new XSDSchema.NameType("QName", typeof(string)),
			new XSDSchema.NameType("anyType", typeof(object)),
			new XSDSchema.NameType("anyURI", typeof(Uri)),
			new XSDSchema.NameType("base64Binary", typeof(byte[])),
			new XSDSchema.NameType("boolean", typeof(bool)),
			new XSDSchema.NameType("byte", typeof(sbyte)),
			new XSDSchema.NameType("date", typeof(DateTime)),
			new XSDSchema.NameType("dateTime", typeof(DateTime)),
			new XSDSchema.NameType("decimal", typeof(decimal)),
			new XSDSchema.NameType("double", typeof(double)),
			new XSDSchema.NameType("duration", typeof(TimeSpan)),
			new XSDSchema.NameType("float", typeof(float)),
			new XSDSchema.NameType("gDay", typeof(DateTime)),
			new XSDSchema.NameType("gMonth", typeof(DateTime)),
			new XSDSchema.NameType("gMonthDay", typeof(DateTime)),
			new XSDSchema.NameType("gYear", typeof(DateTime)),
			new XSDSchema.NameType("gYearMonth", typeof(DateTime)),
			new XSDSchema.NameType("hexBinary", typeof(byte[])),
			new XSDSchema.NameType("int", typeof(int)),
			new XSDSchema.NameType("integer", typeof(long)),
			new XSDSchema.NameType("language", typeof(string)),
			new XSDSchema.NameType("long", typeof(long)),
			new XSDSchema.NameType("negativeInteger", typeof(long)),
			new XSDSchema.NameType("nonNegativeInteger", typeof(ulong)),
			new XSDSchema.NameType("nonPositiveInteger", typeof(long)),
			new XSDSchema.NameType("normalizedString", typeof(string)),
			new XSDSchema.NameType("positiveInteger", typeof(ulong)),
			new XSDSchema.NameType("short", typeof(short)),
			new XSDSchema.NameType("string", typeof(string)),
			new XSDSchema.NameType("time", typeof(DateTime)),
			new XSDSchema.NameType("unsignedByte", typeof(byte)),
			new XSDSchema.NameType("unsignedInt", typeof(uint)),
			new XSDSchema.NameType("unsignedLong", typeof(ulong)),
			new XSDSchema.NameType("unsignedShort", typeof(ushort))
		};

		// Token: 0x0200009D RID: 157
		private sealed class NameType : IComparable
		{
			// Token: 0x0600094C RID: 2380 RVA: 0x000333B4 File Offset: 0x000315B4
			public NameType(string n, Type t)
			{
				this.name = n;
				this.type = t;
			}

			// Token: 0x0600094D RID: 2381 RVA: 0x000333CA File Offset: 0x000315CA
			public int CompareTo(object obj)
			{
				return string.Compare(this.name, (string)obj, StringComparison.Ordinal);
			}

			// Token: 0x04000328 RID: 808
			public readonly string name;

			// Token: 0x04000329 RID: 809
			public readonly Type type;
		}
	}
}
