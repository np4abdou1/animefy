using System;
using System.Collections;
using System.Xml;

namespace System.Data
{
	// Token: 0x020000A1 RID: 161
	internal sealed class XmlToDatasetMap
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x00034E08 File Offset: 0x00033008
		public XmlToDatasetMap(DataSet dataSet, XmlNameTable nameTable)
		{
			this.BuildIdentityMap(dataSet, nameTable);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00034E18 File Offset: 0x00033018
		public XmlToDatasetMap(XmlNameTable nameTable, DataSet dataSet)
		{
			this.BuildIdentityMap(nameTable, dataSet);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00034E28 File Offset: 0x00033028
		public XmlToDatasetMap(DataTable dataTable, XmlNameTable nameTable)
		{
			this.BuildIdentityMap(dataTable, nameTable);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00034E38 File Offset: 0x00033038
		public XmlToDatasetMap(XmlNameTable nameTable, DataTable dataTable)
		{
			this.BuildIdentityMap(nameTable, dataTable);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00034E48 File Offset: 0x00033048
		internal static bool IsMappedColumn(DataColumn c)
		{
			return c.ColumnMapping != MappingType.Hidden;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00034E58 File Offset: 0x00033058
		private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable)
		{
			string text = nameTable.Get(table.EncodedTableName);
			string namespaceURI = nameTable.Get(table.Namespace);
			if (text == null)
			{
				return null;
			}
			XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = new XmlToDatasetMap.TableSchemaInfo(table);
			this._tableSchemaMap[new XmlToDatasetMap.XmlNodeIdentety(text, namespaceURI)] = tableSchemaInfo;
			return tableSchemaInfo;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00034EA0 File Offset: 0x000330A0
		private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table)
		{
			string encodedTableName = table.EncodedTableName;
			string text = nameTable.Get(encodedTableName);
			if (text == null)
			{
				text = nameTable.Add(encodedTableName);
			}
			table._encodedTableName = text;
			string text2 = nameTable.Get(table.Namespace);
			if (text2 == null)
			{
				text2 = nameTable.Add(table.Namespace);
			}
			else if (table._tableNamespace != null)
			{
				table._tableNamespace = text2;
			}
			XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = new XmlToDatasetMap.TableSchemaInfo(table);
			this._tableSchemaMap[new XmlToDatasetMap.XmlNodeIdentety(text, text2)] = tableSchemaInfo;
			return tableSchemaInfo;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00034F18 File Offset: 0x00033118
		private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns)
		{
			string text = nameTable.Get(col.EncodedColumnName);
			string namespaceURI = nameTable.Get(col.Namespace);
			if (text == null)
			{
				return false;
			}
			XmlToDatasetMap.XmlNodeIdentety key = new XmlToDatasetMap.XmlNodeIdentety(text, namespaceURI);
			columns[key] = col;
			if (col.ColumnName.StartsWith("xml", StringComparison.OrdinalIgnoreCase))
			{
				this.HandleSpecialColumn(col, nameTable, columns);
			}
			return true;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00034F74 File Offset: 0x00033174
		private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns)
		{
			string array = XmlConvert.EncodeLocalName(col.ColumnName);
			string text = nameTable.Get(array);
			if (text == null)
			{
				text = nameTable.Add(array);
			}
			col._encodedColumnName = text;
			string text2 = nameTable.Get(col.Namespace);
			if (text2 == null)
			{
				text2 = nameTable.Add(col.Namespace);
			}
			else if (col._columnUri != null)
			{
				col._columnUri = text2;
			}
			XmlToDatasetMap.XmlNodeIdentety key = new XmlToDatasetMap.XmlNodeIdentety(text, text2);
			columns[key] = col;
			if (col.ColumnName.StartsWith("xml", StringComparison.OrdinalIgnoreCase))
			{
				this.HandleSpecialColumn(col, nameTable, columns);
			}
			return true;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00035004 File Offset: 0x00033204
		private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable)
		{
			this._tableSchemaMap = new XmlToDatasetMap.XmlNodeIdHashtable(dataSet.Tables.Count);
			foreach (object obj in dataSet.Tables)
			{
				DataTable dataTable = (DataTable)obj;
				XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = this.AddTableSchema(dataTable, nameTable);
				if (tableSchemaInfo != null)
				{
					foreach (object obj2 in dataTable.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj2;
						if (XmlToDatasetMap.IsMappedColumn(dataColumn))
						{
							this.AddColumnSchema(dataColumn, nameTable, tableSchemaInfo.ColumnsSchemaMap);
						}
					}
				}
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000350DC File Offset: 0x000332DC
		private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet)
		{
			this._tableSchemaMap = new XmlToDatasetMap.XmlNodeIdHashtable(dataSet.Tables.Count);
			string text = nameTable.Get(dataSet.Namespace);
			if (text == null)
			{
				text = nameTable.Add(dataSet.Namespace);
			}
			dataSet._namespaceURI = text;
			foreach (object obj in dataSet.Tables)
			{
				DataTable dataTable = (DataTable)obj;
				XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = this.AddTableSchema(nameTable, dataTable);
				if (tableSchemaInfo != null)
				{
					foreach (object obj2 in dataTable.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj2;
						if (XmlToDatasetMap.IsMappedColumn(dataColumn))
						{
							this.AddColumnSchema(nameTable, dataColumn, tableSchemaInfo.ColumnsSchemaMap);
						}
					}
					foreach (object obj3 in dataTable.ChildRelations)
					{
						DataRelation dataRelation = (DataRelation)obj3;
						if (dataRelation.Nested)
						{
							string array = XmlConvert.EncodeLocalName(dataRelation.ChildTable.TableName);
							string text2 = nameTable.Get(array);
							if (text2 == null)
							{
								text2 = nameTable.Add(array);
							}
							string text3 = nameTable.Get(dataRelation.ChildTable.Namespace);
							if (text3 == null)
							{
								text3 = nameTable.Add(dataRelation.ChildTable.Namespace);
							}
							XmlToDatasetMap.XmlNodeIdentety key = new XmlToDatasetMap.XmlNodeIdentety(text2, text3);
							tableSchemaInfo.ColumnsSchemaMap[key] = dataRelation.ChildTable;
						}
					}
				}
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000352D4 File Offset: 0x000334D4
		private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable)
		{
			this._tableSchemaMap = new XmlToDatasetMap.XmlNodeIdHashtable(1);
			XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = this.AddTableSchema(dataTable, nameTable);
			if (tableSchemaInfo != null)
			{
				foreach (object obj in dataTable.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (XmlToDatasetMap.IsMappedColumn(dataColumn))
					{
						this.AddColumnSchema(dataColumn, nameTable, tableSchemaInfo.ColumnsSchemaMap);
					}
				}
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00035358 File Offset: 0x00033558
		private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable)
		{
			ArrayList selfAndDescendants = this.GetSelfAndDescendants(dataTable);
			this._tableSchemaMap = new XmlToDatasetMap.XmlNodeIdHashtable(selfAndDescendants.Count);
			foreach (object obj in selfAndDescendants)
			{
				DataTable dataTable2 = (DataTable)obj;
				XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = this.AddTableSchema(nameTable, dataTable2);
				if (tableSchemaInfo != null)
				{
					foreach (object obj2 in dataTable2.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj2;
						if (XmlToDatasetMap.IsMappedColumn(dataColumn))
						{
							this.AddColumnSchema(nameTable, dataColumn, tableSchemaInfo.ColumnsSchemaMap);
						}
					}
					foreach (object obj3 in dataTable2.ChildRelations)
					{
						DataRelation dataRelation = (DataRelation)obj3;
						if (dataRelation.Nested)
						{
							string array = XmlConvert.EncodeLocalName(dataRelation.ChildTable.TableName);
							string text = nameTable.Get(array);
							if (text == null)
							{
								text = nameTable.Add(array);
							}
							string text2 = nameTable.Get(dataRelation.ChildTable.Namespace);
							if (text2 == null)
							{
								text2 = nameTable.Add(dataRelation.ChildTable.Namespace);
							}
							XmlToDatasetMap.XmlNodeIdentety key = new XmlToDatasetMap.XmlNodeIdentety(text, text2);
							tableSchemaInfo.ColumnsSchemaMap[key] = dataRelation.ChildTable;
						}
					}
				}
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0003552C File Offset: 0x0003372C
		private ArrayList GetSelfAndDescendants(DataTable dt)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(dt);
			for (int i = 0; i < arrayList.Count; i++)
			{
				foreach (object obj in ((DataTable)arrayList[i]).ChildRelations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (!arrayList.Contains(dataRelation.ChildTable))
					{
						arrayList.Add(dataRelation.ChildTable);
					}
				}
			}
			return arrayList;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000355C8 File Offset: 0x000337C8
		public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace)
		{
			XmlNode xmlNode = (node.NodeType == XmlNodeType.Attribute) ? ((XmlAttribute)node).OwnerElement : node.ParentNode;
			while (xmlNode != null && xmlNode.NodeType == XmlNodeType.Element)
			{
				XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = (XmlToDatasetMap.TableSchemaInfo)(fIgnoreNamespace ? this._tableSchemaMap[xmlNode.LocalName] : this._tableSchemaMap[xmlNode]);
				xmlNode = xmlNode.ParentNode;
				if (tableSchemaInfo != null)
				{
					if (fIgnoreNamespace)
					{
						return tableSchemaInfo.ColumnsSchemaMap[node.LocalName];
					}
					return tableSchemaInfo.ColumnsSchemaMap[node];
				}
			}
			return null;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00035658 File Offset: 0x00033858
		public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace)
		{
			if (this._lastTableSchemaInfo == null || this._lastTableSchemaInfo.TableSchema != table)
			{
				this._lastTableSchemaInfo = (XmlToDatasetMap.TableSchemaInfo)(fIgnoreNamespace ? this._tableSchemaMap[table.EncodedTableName] : this._tableSchemaMap[table]);
			}
			if (fIgnoreNamespace)
			{
				return this._lastTableSchemaInfo.ColumnsSchemaMap[dataReader.LocalName];
			}
			return this._lastTableSchemaInfo.ColumnsSchemaMap[dataReader];
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000356D4 File Offset: 0x000338D4
		public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace)
		{
			XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = null;
			if (node.NodeType == XmlNodeType.Element)
			{
				tableSchemaInfo = (XmlToDatasetMap.TableSchemaInfo)(fIgnoreNamespace ? this._tableSchemaMap[node.LocalName] : this._tableSchemaMap[node]);
			}
			if (tableSchemaInfo != null)
			{
				return tableSchemaInfo.TableSchema;
			}
			return this.GetColumnSchema(node, fIgnoreNamespace);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00035728 File Offset: 0x00033928
		public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace)
		{
			XmlToDatasetMap.TableSchemaInfo tableSchemaInfo = (XmlToDatasetMap.TableSchemaInfo)(fIgnoreNamespace ? this._tableSchemaMap[node.LocalName] : this._tableSchemaMap[node]);
			if (tableSchemaInfo != null)
			{
				this._lastTableSchemaInfo = tableSchemaInfo;
				return this._lastTableSchemaInfo.TableSchema;
			}
			return null;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00035774 File Offset: 0x00033974
		private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns)
		{
			string text;
			if ('x' == col.ColumnName[0])
			{
				text = "_x0078_";
			}
			else
			{
				text = "_x0058_";
			}
			text += col.ColumnName.Substring(1);
			if (nameTable.Get(text) == null)
			{
				nameTable.Add(text);
			}
			string namespaceURI = nameTable.Get(col.Namespace);
			XmlToDatasetMap.XmlNodeIdentety key = new XmlToDatasetMap.XmlNodeIdentety(text, namespaceURI);
			columns[key] = col;
		}

		// Token: 0x0400034C RID: 844
		private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap;

		// Token: 0x0400034D RID: 845
		private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo;

		// Token: 0x020000A2 RID: 162
		private sealed class XmlNodeIdentety
		{
			// Token: 0x06000980 RID: 2432 RVA: 0x000357E0 File Offset: 0x000339E0
			public XmlNodeIdentety(string localName, string namespaceURI)
			{
				this.LocalName = localName;
				this.NamespaceURI = namespaceURI;
			}

			// Token: 0x06000981 RID: 2433 RVA: 0x000357F6 File Offset: 0x000339F6
			public override int GetHashCode()
			{
				return this.LocalName.GetHashCode();
			}

			// Token: 0x06000982 RID: 2434 RVA: 0x00035804 File Offset: 0x00033A04
			public override bool Equals(object obj)
			{
				XmlToDatasetMap.XmlNodeIdentety xmlNodeIdentety = (XmlToDatasetMap.XmlNodeIdentety)obj;
				return string.Equals(this.LocalName, xmlNodeIdentety.LocalName, StringComparison.OrdinalIgnoreCase) && string.Equals(this.NamespaceURI, xmlNodeIdentety.NamespaceURI, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x0400034E RID: 846
			public string LocalName;

			// Token: 0x0400034F RID: 847
			public string NamespaceURI;
		}

		// Token: 0x020000A3 RID: 163
		internal sealed class XmlNodeIdHashtable : Hashtable
		{
			// Token: 0x06000983 RID: 2435 RVA: 0x00035840 File Offset: 0x00033A40
			public XmlNodeIdHashtable(int capacity) : base(capacity)
			{
			}

			// Token: 0x17000159 RID: 345
			public object this[XmlNode node]
			{
				get
				{
					this._id.LocalName = node.LocalName;
					this._id.NamespaceURI = node.NamespaceURI;
					return this[this._id];
				}
			}

			// Token: 0x1700015A RID: 346
			public object this[XmlReader dataReader]
			{
				get
				{
					this._id.LocalName = dataReader.LocalName;
					this._id.NamespaceURI = dataReader.NamespaceURI;
					return this[this._id];
				}
			}

			// Token: 0x1700015B RID: 347
			public object this[DataTable table]
			{
				get
				{
					this._id.LocalName = table.EncodedTableName;
					this._id.NamespaceURI = table.Namespace;
					return this[this._id];
				}
			}

			// Token: 0x1700015C RID: 348
			public object this[string name]
			{
				get
				{
					this._id.LocalName = name;
					this._id.NamespaceURI = string.Empty;
					return this[this._id];
				}
			}

			// Token: 0x04000350 RID: 848
			private XmlToDatasetMap.XmlNodeIdentety _id = new XmlToDatasetMap.XmlNodeIdentety(string.Empty, string.Empty);
		}

		// Token: 0x020000A4 RID: 164
		private sealed class TableSchemaInfo
		{
			// Token: 0x06000988 RID: 2440 RVA: 0x00035918 File Offset: 0x00033B18
			public TableSchemaInfo(DataTable tableSchema)
			{
				this.TableSchema = tableSchema;
				this.ColumnsSchemaMap = new XmlToDatasetMap.XmlNodeIdHashtable(tableSchema.Columns.Count);
			}

			// Token: 0x04000351 RID: 849
			public DataTable TableSchema;

			// Token: 0x04000352 RID: 850
			public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap;
		}
	}
}
