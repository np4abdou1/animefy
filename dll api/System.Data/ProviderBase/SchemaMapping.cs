using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Xml;

namespace System.Data.ProviderBase
{
	// Token: 0x020000CE RID: 206
	internal sealed class SchemaMapping
	{
		// Token: 0x06000E11 RID: 3601 RVA: 0x00046F7C File Offset: 0x0004517C
		internal SchemaMapping(DataAdapter adapter, DataSet dataset, DataTable datatable, DataReaderContainer dataReader, bool keyInfo, SchemaType schemaType, string sourceTableName, bool gettingData, DataColumn parentChapterColumn, object parentChapterValue)
		{
			this._dataSet = dataset;
			this._dataTable = datatable;
			this._adapter = adapter;
			this._dataReader = dataReader;
			if (keyInfo)
			{
				this._schemaTable = dataReader.GetSchemaTable();
			}
			if (adapter.ShouldSerializeFillLoadOption())
			{
				this._loadOption = adapter.FillLoadOption;
			}
			else if (adapter.AcceptChangesDuringFill)
			{
				this._loadOption = (LoadOption)4;
			}
			else
			{
				this._loadOption = (LoadOption)5;
			}
			MissingMappingAction missingMappingAction;
			MissingSchemaAction schemaAction;
			if (SchemaType.Mapped == schemaType)
			{
				missingMappingAction = this._adapter.MissingMappingAction;
				schemaAction = this._adapter.MissingSchemaAction;
				if (!string.IsNullOrEmpty(sourceTableName))
				{
					this._tableMapping = this._adapter.GetTableMappingBySchemaAction(sourceTableName, sourceTableName, missingMappingAction);
				}
				else if (this._dataTable != null)
				{
					int num = this._adapter.IndexOfDataSetTable(this._dataTable.TableName);
					if (-1 != num)
					{
						this._tableMapping = this._adapter.TableMappings[num];
					}
					else
					{
						switch (missingMappingAction)
						{
						case MissingMappingAction.Passthrough:
							this._tableMapping = new DataTableMapping(this._dataTable.TableName, this._dataTable.TableName);
							break;
						case MissingMappingAction.Ignore:
							this._tableMapping = null;
							break;
						case MissingMappingAction.Error:
							throw ADP.MissingTableMappingDestination(this._dataTable.TableName);
						default:
							throw ADP.InvalidMissingMappingAction(missingMappingAction);
						}
					}
				}
			}
			else
			{
				if (SchemaType.Source != schemaType)
				{
					throw ADP.InvalidSchemaType(schemaType);
				}
				missingMappingAction = MissingMappingAction.Passthrough;
				schemaAction = MissingSchemaAction.Add;
				if (!string.IsNullOrEmpty(sourceTableName))
				{
					this._tableMapping = DataTableMappingCollection.GetTableMappingBySchemaAction(null, sourceTableName, sourceTableName, missingMappingAction);
				}
				else if (this._dataTable != null)
				{
					int num2 = this._adapter.IndexOfDataSetTable(this._dataTable.TableName);
					if (-1 != num2)
					{
						this._tableMapping = this._adapter.TableMappings[num2];
					}
					else
					{
						this._tableMapping = new DataTableMapping(this._dataTable.TableName, this._dataTable.TableName);
					}
				}
			}
			if (this._tableMapping != null)
			{
				if (this._dataTable == null)
				{
					this._dataTable = this._tableMapping.GetDataTableBySchemaAction(this._dataSet, schemaAction);
				}
				if (this._dataTable != null)
				{
					this._fieldNames = SchemaMapping.GenerateFieldNames(dataReader);
					if (this._schemaTable == null)
					{
						this._readerDataValues = this.SetupSchemaWithoutKeyInfo(missingMappingAction, schemaAction, gettingData, parentChapterColumn, parentChapterValue);
						return;
					}
					this._readerDataValues = this.SetupSchemaWithKeyInfo(missingMappingAction, schemaAction, gettingData, parentChapterColumn, parentChapterValue);
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x000471CB File Offset: 0x000453CB
		internal DataReaderContainer DataReader
		{
			get
			{
				return this._dataReader;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x000471D3 File Offset: 0x000453D3
		internal DataTable DataTable
		{
			get
			{
				return this._dataTable;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000471DB File Offset: 0x000453DB
		internal object[] DataValues
		{
			get
			{
				return this._readerDataValues;
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000471E4 File Offset: 0x000453E4
		private void MappedChapterIndex()
		{
			int mappedLength = this._mappedLength;
			for (int i = 0; i < mappedLength; i++)
			{
				int num = this._indexMap[i];
				if (0 <= num)
				{
					this._mappedDataValues[num] = this._readerDataValues[i];
					if (this._chapterMap[i])
					{
						this._mappedDataValues[num] = null;
					}
				}
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00047234 File Offset: 0x00045434
		private void MappedChapter()
		{
			int mappedLength = this._mappedLength;
			for (int i = 0; i < mappedLength; i++)
			{
				this._mappedDataValues[i] = this._readerDataValues[i];
				if (this._chapterMap[i])
				{
					this._mappedDataValues[i] = null;
				}
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00047278 File Offset: 0x00045478
		private void MappedIndex()
		{
			int mappedLength = this._mappedLength;
			for (int i = 0; i < mappedLength; i++)
			{
				int num = this._indexMap[i];
				if (0 <= num)
				{
					this._mappedDataValues[num] = this._readerDataValues[i];
				}
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000472B8 File Offset: 0x000454B8
		private void MappedValues()
		{
			int mappedLength = this._mappedLength;
			for (int i = 0; i < mappedLength; i++)
			{
				this._mappedDataValues[i] = this._readerDataValues[i];
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000472E8 File Offset: 0x000454E8
		private object[] GetMappedValues()
		{
			if (this._xmlMap != null)
			{
				for (int i = 0; i < this._xmlMap.Length; i++)
				{
					if (this._xmlMap[i] != 0)
					{
						string text = this._readerDataValues[i] as string;
						if (text == null && this._readerDataValues[i] is SqlString)
						{
							SqlString sqlString = (SqlString)this._readerDataValues[i];
							if (!sqlString.IsNull)
							{
								text = sqlString.Value;
							}
							else if (this._xmlMap[i] == 1)
							{
								this._readerDataValues[i] = SqlXml.Null;
							}
							else
							{
								this._readerDataValues[i] = DBNull.Value;
							}
						}
						if (text != null)
						{
							int num = this._xmlMap[i];
							if (num != 1)
							{
								if (num == 2)
								{
									XmlDocument xmlDocument = new XmlDocument();
									xmlDocument.LoadXml(text);
									this._readerDataValues[i] = xmlDocument;
								}
							}
							else
							{
								XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
								xmlReaderSettings.ConformanceLevel = ConformanceLevel.Fragment;
								XmlReader value = XmlReader.Create(new StringReader(text), xmlReaderSettings, null);
								this._readerDataValues[i] = new SqlXml(value);
							}
						}
					}
				}
			}
			switch (this._mappedMode)
			{
			default:
				return this._readerDataValues;
			case 1:
				this.MappedValues();
				break;
			case 2:
				this.MappedIndex();
				break;
			case 3:
				this.MappedChapter();
				break;
			case 4:
				this.MappedChapterIndex();
				break;
			}
			return this._mappedDataValues;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0004743C File Offset: 0x0004563C
		internal void LoadDataRowWithClear()
		{
			for (int i = 0; i < this._readerDataValues.Length; i++)
			{
				this._readerDataValues[i] = null;
			}
			this.LoadDataRow();
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0004746C File Offset: 0x0004566C
		internal void LoadDataRow()
		{
			try
			{
				this._dataReader.GetValues(this._readerDataValues);
				object[] mappedValues = this.GetMappedValues();
				DataRow dataRow;
				switch (this._loadOption)
				{
				case LoadOption.OverwriteChanges:
				case LoadOption.PreserveChanges:
				case LoadOption.Upsert:
					dataRow = this._dataTable.LoadDataRow(mappedValues, this._loadOption);
					break;
				case (LoadOption)4:
					dataRow = this._dataTable.LoadDataRow(mappedValues, true);
					break;
				case (LoadOption)5:
					dataRow = this._dataTable.LoadDataRow(mappedValues, false);
					break;
				default:
					throw ADP.InvalidLoadOption(this._loadOption);
				}
				if (this._chapterMap != null && this._dataSet != null)
				{
					this.LoadDataRowChapters(dataRow);
				}
			}
			finally
			{
				if (this._chapterMap != null)
				{
					this.FreeDataRowChapters();
				}
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00047534 File Offset: 0x00045734
		private void FreeDataRowChapters()
		{
			for (int i = 0; i < this._chapterMap.Length; i++)
			{
				if (this._chapterMap[i])
				{
					IDisposable disposable = this._readerDataValues[i] as IDisposable;
					if (disposable != null)
					{
						this._readerDataValues[i] = null;
						disposable.Dispose();
					}
				}
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00047580 File Offset: 0x00045780
		internal int LoadDataRowChapters(DataRow dataRow)
		{
			int num = 0;
			int num2 = this._chapterMap.Length;
			for (int i = 0; i < num2; i++)
			{
				if (this._chapterMap[i])
				{
					object obj = this._readerDataValues[i];
					if (obj != null && !Convert.IsDBNull(obj))
					{
						this._readerDataValues[i] = null;
						using (IDataReader dataReader = (IDataReader)obj)
						{
							if (!dataReader.IsClosed)
							{
								DataColumn dataColumn;
								object parentChapterValue;
								if (this._indexMap == null)
								{
									dataColumn = this._dataTable.Columns[i];
									parentChapterValue = dataRow[dataColumn];
								}
								else
								{
									dataColumn = this._dataTable.Columns[this._indexMap[i]];
									parentChapterValue = dataRow[dataColumn];
								}
								string srcTable = this._tableMapping.SourceTable + this._fieldNames[i];
								DataReaderContainer dataReader2 = DataReaderContainer.Create(dataReader, this._dataReader.ReturnProviderSpecificTypes);
								num += this._adapter.FillFromReader(this._dataSet, null, srcTable, dataReader2, 0, 0, dataColumn, parentChapterValue);
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000476A8 File Offset: 0x000458A8
		private int[] CreateIndexMap(int count, int index)
		{
			int[] array = new int[count];
			for (int i = 0; i < index; i++)
			{
				array[i] = i;
			}
			return array;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x000476D0 File Offset: 0x000458D0
		private static string[] GenerateFieldNames(DataReaderContainer dataReader)
		{
			string[] array = new string[dataReader.FieldCount];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = dataReader.GetName(i);
			}
			ADP.BuildSchemaTableInfoTableNames(array);
			return array;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00047708 File Offset: 0x00045908
		private DataColumn[] ResizeColumnArray(DataColumn[] rgcol, int len)
		{
			DataColumn[] array = new DataColumn[len];
			Array.Copy(rgcol, 0, array, 0, len);
			return array;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00047727 File Offset: 0x00045927
		private void AddItemToAllowRollback(ref List<object> items, object value)
		{
			if (items == null)
			{
				items = new List<object>();
			}
			items.Add(value);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0004773C File Offset: 0x0004593C
		private void RollbackAddedItems(List<object> items)
		{
			if (items != null)
			{
				int num = items.Count - 1;
				while (0 <= num)
				{
					if (items[num] != null)
					{
						DataColumn dataColumn = items[num] as DataColumn;
						if (dataColumn != null)
						{
							if (dataColumn.Table != null)
							{
								dataColumn.Table.Columns.Remove(dataColumn);
							}
						}
						else
						{
							DataTable dataTable = items[num] as DataTable;
							if (dataTable != null && dataTable.DataSet != null)
							{
								dataTable.DataSet.Tables.Remove(dataTable);
							}
						}
					}
					num--;
				}
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000477BC File Offset: 0x000459BC
		private object[] SetupSchemaWithoutKeyInfo(MissingMappingAction mappingAction, MissingSchemaAction schemaAction, bool gettingData, DataColumn parentChapterColumn, object chapterValue)
		{
			int[] array = null;
			bool[] array2 = null;
			int num = 0;
			int fieldCount = this._dataReader.FieldCount;
			object[] result = null;
			List<object> items = null;
			try
			{
				DataColumnCollection columns = this._dataTable.Columns;
				columns.EnsureAdditionalCapacity(fieldCount + ((chapterValue != null) ? 1 : 0));
				bool flag = this._dataTable.Columns.Count == 0 && (this._tableMapping.ColumnMappings == null || this._tableMapping.ColumnMappings.Count == 0) && mappingAction == MissingMappingAction.Passthrough;
				for (int i = 0; i < fieldCount; i++)
				{
					bool flag2 = false;
					Type type = this._dataReader.GetFieldType(i);
					if (null == type)
					{
						throw ADP.MissingDataReaderFieldType(i);
					}
					if (typeof(IDataReader).IsAssignableFrom(type))
					{
						if (array2 == null)
						{
							array2 = new bool[fieldCount];
						}
						flag2 = (array2[i] = true);
						type = typeof(int);
					}
					else if (typeof(SqlXml).IsAssignableFrom(type))
					{
						if (this._xmlMap == null)
						{
							this._xmlMap = new int[fieldCount];
						}
						this._xmlMap[i] = 1;
					}
					else if (typeof(XmlReader).IsAssignableFrom(type))
					{
						type = typeof(string);
						if (this._xmlMap == null)
						{
							this._xmlMap = new int[fieldCount];
						}
						this._xmlMap[i] = 2;
					}
					DataColumn dataColumn;
					if (flag)
					{
						dataColumn = DataColumnMapping.CreateDataColumnBySchemaAction(this._fieldNames[i], this._fieldNames[i], this._dataTable, type, schemaAction);
					}
					else
					{
						dataColumn = this._tableMapping.GetDataColumn(this._fieldNames[i], type, this._dataTable, mappingAction, schemaAction);
					}
					if (dataColumn == null)
					{
						if (array == null)
						{
							array = this.CreateIndexMap(fieldCount, i);
						}
						array[i] = -1;
					}
					else
					{
						if (this._xmlMap != null && this._xmlMap[i] != 0)
						{
							if (typeof(SqlXml) == dataColumn.DataType)
							{
								this._xmlMap[i] = 1;
							}
							else if (typeof(XmlDocument) == dataColumn.DataType)
							{
								this._xmlMap[i] = 2;
							}
							else
							{
								this._xmlMap[i] = 0;
								int num2 = 0;
								for (int j = 0; j < this._xmlMap.Length; j++)
								{
									num2 += this._xmlMap[j];
								}
								if (num2 == 0)
								{
									this._xmlMap = null;
								}
							}
						}
						if (dataColumn.Table == null)
						{
							if (flag2)
							{
								dataColumn.AllowDBNull = false;
								dataColumn.AutoIncrement = true;
								dataColumn.ReadOnly = true;
							}
							this.AddItemToAllowRollback(ref items, dataColumn);
							columns.Add(dataColumn);
						}
						else if (flag2 && !dataColumn.AutoIncrement)
						{
							throw ADP.FillChapterAutoIncrement();
						}
						if (array != null)
						{
							array[i] = dataColumn.Ordinal;
						}
						else if (i != dataColumn.Ordinal)
						{
							array = this.CreateIndexMap(fieldCount, i);
							array[i] = dataColumn.Ordinal;
						}
						num++;
					}
				}
				bool flag3 = false;
				DataColumn dataColumn2 = null;
				if (chapterValue != null)
				{
					Type type2 = chapterValue.GetType();
					dataColumn2 = this._tableMapping.GetDataColumn(this._tableMapping.SourceTable, type2, this._dataTable, mappingAction, schemaAction);
					if (dataColumn2 != null)
					{
						if (dataColumn2.Table == null)
						{
							this.AddItemToAllowRollback(ref items, dataColumn2);
							columns.Add(dataColumn2);
							flag3 = (parentChapterColumn != null);
						}
						num++;
					}
				}
				if (0 < num)
				{
					if (this._dataSet != null && this._dataTable.DataSet == null)
					{
						this.AddItemToAllowRollback(ref items, this._dataTable);
						this._dataSet.Tables.Add(this._dataTable);
					}
					if (gettingData)
					{
						if (columns == null)
						{
							columns = this._dataTable.Columns;
						}
						this._indexMap = array;
						this._chapterMap = array2;
						result = this.SetupMapping(fieldCount, columns, dataColumn2, chapterValue);
					}
					else
					{
						this._mappedMode = -1;
					}
				}
				else
				{
					this._dataTable = null;
				}
				if (flag3)
				{
					this.AddRelation(parentChapterColumn, dataColumn2);
				}
			}
			catch (Exception e) when (ADP.IsCatchableOrSecurityExceptionType(e))
			{
				this.RollbackAddedItems(items);
				throw;
			}
			return result;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00047BC8 File Offset: 0x00045DC8
		private object[] SetupSchemaWithKeyInfo(MissingMappingAction mappingAction, MissingSchemaAction schemaAction, bool gettingData, DataColumn parentChapterColumn, object chapterValue)
		{
			DbSchemaRow[] sortedSchemaRows = DbSchemaRow.GetSortedSchemaRows(this._schemaTable, this._dataReader.ReturnProviderSpecificTypes);
			if (sortedSchemaRows.Length == 0)
			{
				this._dataTable = null;
				return null;
			}
			bool flag = (this._dataTable.PrimaryKey.Length == 0 && ((LoadOption)4 <= this._loadOption || this._dataTable.Rows.Count == 0)) || this._dataTable.Columns.Count == 0;
			DataColumn[] array = null;
			int num = 0;
			bool flag2 = true;
			string text = null;
			string text2 = null;
			bool flag3 = false;
			bool flag4 = false;
			int[] array2 = null;
			bool[] array3 = null;
			int num2 = 0;
			object[] result = null;
			List<object> items = null;
			DataColumnCollection columns = this._dataTable.Columns;
			try
			{
				for (int i = 0; i < sortedSchemaRows.Length; i++)
				{
					DbSchemaRow dbSchemaRow = sortedSchemaRows[i];
					int unsortedIndex = dbSchemaRow.UnsortedIndex;
					bool flag5 = false;
					Type type = dbSchemaRow.DataType;
					if (null == type)
					{
						type = this._dataReader.GetFieldType(i);
					}
					if (null == type)
					{
						throw ADP.MissingDataReaderFieldType(i);
					}
					if (typeof(IDataReader).IsAssignableFrom(type))
					{
						if (array3 == null)
						{
							array3 = new bool[sortedSchemaRows.Length];
						}
						flag5 = (array3[unsortedIndex] = true);
						type = typeof(int);
					}
					else if (typeof(SqlXml).IsAssignableFrom(type))
					{
						if (this._xmlMap == null)
						{
							this._xmlMap = new int[sortedSchemaRows.Length];
						}
						this._xmlMap[i] = 1;
					}
					else if (typeof(XmlReader).IsAssignableFrom(type))
					{
						type = typeof(string);
						if (this._xmlMap == null)
						{
							this._xmlMap = new int[sortedSchemaRows.Length];
						}
						this._xmlMap[i] = 2;
					}
					DataColumn dataColumn = null;
					if (!dbSchemaRow.IsHidden)
					{
						dataColumn = this._tableMapping.GetDataColumn(this._fieldNames[i], type, this._dataTable, mappingAction, schemaAction);
					}
					string baseTableName = dbSchemaRow.BaseTableName;
					if (dataColumn == null)
					{
						if (array2 == null)
						{
							array2 = this.CreateIndexMap(sortedSchemaRows.Length, unsortedIndex);
						}
						array2[unsortedIndex] = -1;
						if (dbSchemaRow.IsKey && (flag3 || dbSchemaRow.BaseTableName == text))
						{
							flag = false;
							array = null;
						}
					}
					else
					{
						if (this._xmlMap != null && this._xmlMap[i] != 0)
						{
							if (typeof(SqlXml) == dataColumn.DataType)
							{
								this._xmlMap[i] = 1;
							}
							else if (typeof(XmlDocument) == dataColumn.DataType)
							{
								this._xmlMap[i] = 2;
							}
							else
							{
								this._xmlMap[i] = 0;
								int num3 = 0;
								for (int j = 0; j < this._xmlMap.Length; j++)
								{
									num3 += this._xmlMap[j];
								}
								if (num3 == 0)
								{
									this._xmlMap = null;
								}
							}
						}
						if (dbSchemaRow.IsKey && baseTableName != text)
						{
							if (text == null)
							{
								text = baseTableName;
							}
							else
							{
								flag3 = true;
							}
						}
						if (flag5)
						{
							if (dataColumn.Table == null)
							{
								dataColumn.AllowDBNull = false;
								dataColumn.AutoIncrement = true;
								dataColumn.ReadOnly = true;
							}
							else if (!dataColumn.AutoIncrement)
							{
								throw ADP.FillChapterAutoIncrement();
							}
						}
						else
						{
							if (!flag4 && baseTableName != text2 && !string.IsNullOrEmpty(baseTableName))
							{
								if (text2 == null)
								{
									text2 = baseTableName;
								}
								else
								{
									flag4 = true;
								}
							}
							if ((LoadOption)4 <= this._loadOption)
							{
								if (dbSchemaRow.IsAutoIncrement && DataColumn.IsAutoIncrementType(type))
								{
									dataColumn.AutoIncrement = true;
									if (!dbSchemaRow.AllowDBNull)
									{
										dataColumn.AllowDBNull = false;
									}
								}
								if (type == typeof(string))
								{
									dataColumn.MaxLength = ((dbSchemaRow.Size > 0) ? dbSchemaRow.Size : -1);
								}
								if (dbSchemaRow.IsReadOnly)
								{
									dataColumn.ReadOnly = true;
								}
								if (!dbSchemaRow.AllowDBNull && (!dbSchemaRow.IsReadOnly || dbSchemaRow.IsKey))
								{
									dataColumn.AllowDBNull = false;
								}
								if (dbSchemaRow.IsUnique && !dbSchemaRow.IsKey && !type.IsArray)
								{
									dataColumn.Unique = true;
									if (!dbSchemaRow.AllowDBNull)
									{
										dataColumn.AllowDBNull = false;
									}
								}
							}
							else if (dataColumn.Table == null)
							{
								dataColumn.AutoIncrement = dbSchemaRow.IsAutoIncrement;
								dataColumn.AllowDBNull = dbSchemaRow.AllowDBNull;
								dataColumn.ReadOnly = dbSchemaRow.IsReadOnly;
								dataColumn.Unique = dbSchemaRow.IsUnique;
								if (type == typeof(string) || type == typeof(SqlString))
								{
									dataColumn.MaxLength = dbSchemaRow.Size;
								}
							}
						}
						if (dataColumn.Table == null)
						{
							if ((LoadOption)4 > this._loadOption)
							{
								this.AddAdditionalProperties(dataColumn, dbSchemaRow.DataRow);
							}
							this.AddItemToAllowRollback(ref items, dataColumn);
							columns.Add(dataColumn);
						}
						if (flag && dbSchemaRow.IsKey)
						{
							if (array == null)
							{
								array = new DataColumn[sortedSchemaRows.Length];
							}
							array[num++] = dataColumn;
							if (flag2 && dataColumn.AllowDBNull)
							{
								flag2 = false;
							}
						}
						if (array2 != null)
						{
							array2[unsortedIndex] = dataColumn.Ordinal;
						}
						else if (unsortedIndex != dataColumn.Ordinal)
						{
							array2 = this.CreateIndexMap(sortedSchemaRows.Length, unsortedIndex);
							array2[unsortedIndex] = dataColumn.Ordinal;
						}
						num2++;
					}
				}
				bool flag6 = false;
				DataColumn dataColumn2 = null;
				if (chapterValue != null)
				{
					Type type2 = chapterValue.GetType();
					dataColumn2 = this._tableMapping.GetDataColumn(this._tableMapping.SourceTable, type2, this._dataTable, mappingAction, schemaAction);
					if (dataColumn2 != null)
					{
						if (dataColumn2.Table == null)
						{
							dataColumn2.ReadOnly = true;
							dataColumn2.AllowDBNull = false;
							this.AddItemToAllowRollback(ref items, dataColumn2);
							columns.Add(dataColumn2);
							flag6 = (parentChapterColumn != null);
						}
						num2++;
					}
				}
				if (0 < num2)
				{
					if (this._dataSet != null && this._dataTable.DataSet == null)
					{
						this.AddItemToAllowRollback(ref items, this._dataTable);
						this._dataSet.Tables.Add(this._dataTable);
					}
					if (flag && array != null)
					{
						if (num < array.Length)
						{
							array = this.ResizeColumnArray(array, num);
						}
						if (flag2)
						{
							this._dataTable.PrimaryKey = array;
						}
						else
						{
							UniqueConstraint uniqueConstraint = new UniqueConstraint("", array);
							ConstraintCollection constraints = this._dataTable.Constraints;
							int count = constraints.Count;
							for (int k = 0; k < count; k++)
							{
								if (uniqueConstraint.Equals(constraints[k]))
								{
									uniqueConstraint = null;
									break;
								}
							}
							if (uniqueConstraint != null)
							{
								constraints.Add(uniqueConstraint);
							}
						}
					}
					if (!flag4 && !string.IsNullOrEmpty(text2) && string.IsNullOrEmpty(this._dataTable.TableName))
					{
						this._dataTable.TableName = text2;
					}
					if (gettingData)
					{
						this._indexMap = array2;
						this._chapterMap = array3;
						result = this.SetupMapping(sortedSchemaRows.Length, columns, dataColumn2, chapterValue);
					}
					else
					{
						this._mappedMode = -1;
					}
				}
				else
				{
					this._dataTable = null;
				}
				if (flag6)
				{
					this.AddRelation(parentChapterColumn, dataColumn2);
				}
			}
			catch (Exception e) when (ADP.IsCatchableOrSecurityExceptionType(e))
			{
				this.RollbackAddedItems(items);
				throw;
			}
			return result;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x000482E0 File Offset: 0x000464E0
		private void AddAdditionalProperties(DataColumn targetColumn, DataRow schemaRow)
		{
			DataColumnCollection columns = schemaRow.Table.Columns;
			DataColumn dataColumn = columns[SchemaTableOptionalColumn.DefaultValue];
			if (dataColumn != null)
			{
				targetColumn.DefaultValue = schemaRow[dataColumn];
			}
			dataColumn = columns[SchemaTableOptionalColumn.AutoIncrementSeed];
			if (dataColumn != null)
			{
				object obj = schemaRow[dataColumn];
				if (DBNull.Value != obj)
				{
					targetColumn.AutoIncrementSeed = ((IConvertible)obj).ToInt64(CultureInfo.InvariantCulture);
				}
			}
			dataColumn = columns[SchemaTableOptionalColumn.AutoIncrementStep];
			if (dataColumn != null)
			{
				object obj2 = schemaRow[dataColumn];
				if (DBNull.Value != obj2)
				{
					targetColumn.AutoIncrementStep = ((IConvertible)obj2).ToInt64(CultureInfo.InvariantCulture);
				}
			}
			dataColumn = columns[SchemaTableOptionalColumn.ColumnMapping];
			if (dataColumn != null)
			{
				object obj3 = schemaRow[dataColumn];
				if (DBNull.Value != obj3)
				{
					targetColumn.ColumnMapping = (MappingType)((IConvertible)obj3).ToInt32(CultureInfo.InvariantCulture);
				}
			}
			dataColumn = columns[SchemaTableOptionalColumn.BaseColumnNamespace];
			if (dataColumn != null)
			{
				object obj4 = schemaRow[dataColumn];
				if (DBNull.Value != obj4)
				{
					targetColumn.Namespace = ((IConvertible)obj4).ToString(CultureInfo.InvariantCulture);
				}
			}
			dataColumn = columns[SchemaTableOptionalColumn.Expression];
			if (dataColumn != null)
			{
				object obj5 = schemaRow[dataColumn];
				if (DBNull.Value != obj5)
				{
					targetColumn.Expression = ((IConvertible)obj5).ToString(CultureInfo.InvariantCulture);
				}
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00048424 File Offset: 0x00046624
		private void AddRelation(DataColumn parentChapterColumn, DataColumn chapterColumn)
		{
			if (this._dataSet != null)
			{
				string columnName = chapterColumn.ColumnName;
				DataRelation dataRelation = new DataRelation(columnName, new DataColumn[]
				{
					parentChapterColumn
				}, new DataColumn[]
				{
					chapterColumn
				}, false);
				int num = 1;
				string relationName = columnName;
				DataRelationCollection relations = this._dataSet.Relations;
				while (-1 != relations.IndexOf(relationName))
				{
					relationName = columnName + num.ToString();
					num++;
				}
				dataRelation.RelationName = relationName;
				relations.Add(dataRelation);
			}
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0004849C File Offset: 0x0004669C
		private object[] SetupMapping(int count, DataColumnCollection columnCollection, DataColumn chapterColumn, object chapterValue)
		{
			object[] result = new object[count];
			if (this._indexMap == null)
			{
				int count2 = columnCollection.Count;
				bool flag = this._chapterMap != null;
				if (count != count2 || flag)
				{
					this._mappedDataValues = new object[count2];
					if (flag)
					{
						this._mappedMode = 3;
						this._mappedLength = count;
					}
					else
					{
						this._mappedMode = 1;
						this._mappedLength = Math.Min(count, count2);
					}
				}
				else
				{
					this._mappedMode = 0;
				}
			}
			else
			{
				this._mappedDataValues = new object[columnCollection.Count];
				this._mappedMode = ((this._chapterMap == null) ? 2 : 4);
				this._mappedLength = count;
			}
			if (chapterColumn != null)
			{
				this._mappedDataValues[chapterColumn.Ordinal] = chapterValue;
			}
			return result;
		}

		// Token: 0x0400046F RID: 1135
		private readonly DataSet _dataSet;

		// Token: 0x04000470 RID: 1136
		private DataTable _dataTable;

		// Token: 0x04000471 RID: 1137
		private readonly DataAdapter _adapter;

		// Token: 0x04000472 RID: 1138
		private readonly DataReaderContainer _dataReader;

		// Token: 0x04000473 RID: 1139
		private readonly DataTable _schemaTable;

		// Token: 0x04000474 RID: 1140
		private readonly DataTableMapping _tableMapping;

		// Token: 0x04000475 RID: 1141
		private readonly string[] _fieldNames;

		// Token: 0x04000476 RID: 1142
		private readonly object[] _readerDataValues;

		// Token: 0x04000477 RID: 1143
		private object[] _mappedDataValues;

		// Token: 0x04000478 RID: 1144
		private int[] _indexMap;

		// Token: 0x04000479 RID: 1145
		private bool[] _chapterMap;

		// Token: 0x0400047A RID: 1146
		private int[] _xmlMap;

		// Token: 0x0400047B RID: 1147
		private int _mappedMode;

		// Token: 0x0400047C RID: 1148
		private int _mappedLength;

		// Token: 0x0400047D RID: 1149
		private readonly LoadOption _loadOption;
	}
}
