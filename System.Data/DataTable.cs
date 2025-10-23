using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data
{
	/// <summary>Represents one table of in-memory data.</summary>
	// Token: 0x0200003B RID: 59
	[ToolboxItem(false)]
	[DesignTimeVisible(false)]
	[DefaultProperty("TableName")]
	[DefaultEvent("RowChanging")]
	[XmlSchemaProvider("GetDataTableSchema")]
	[Serializable]
	public class DataTable : MarshalByValueComponent, IListSource, ISupportInitializeNotification, ISupportInitialize, ISerializable, IXmlSerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTable" /> class with no arguments.</summary>
		// Token: 0x06000427 RID: 1063 RVA: 0x00010804 File Offset: 0x0000EA04
		public DataTable()
		{
			GC.SuppressFinalize(this);
			DataCommonEventSource.Log.Trace<int>("<ds.DataTable.DataTable|API> {0}", this.ObjectID);
			this._nextRowID = 1L;
			this._recordManager = new RecordManager(this);
			this._culture = CultureInfo.CurrentCulture;
			this._columnCollection = new DataColumnCollection(this);
			this._constraintCollection = new ConstraintCollection(this);
			this._rowCollection = new DataRowCollection(this);
			this._indexes = new List<Index>();
			this._rowBuilder = new DataRowBuilder(this, -1);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTable" /> class with the specified table name.</summary>
		/// <param name="tableName">The name to give the table. If <paramref name="tableName" /> is <see langword="null" /> or an empty string, a default name is given when added to the <see cref="T:System.Data.DataTableCollection" />. </param>
		// Token: 0x06000428 RID: 1064 RVA: 0x0001091D File Offset: 0x0000EB1D
		public DataTable(string tableName) : this()
		{
			this._tableName = ((tableName == null) ? "" : tableName);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTable" /> class using the specified table name and namespace.</summary>
		/// <param name="tableName">The name to give the table. If <paramref name="tableName" /> is <see langword="null" /> or an empty string, a default name is given when added to the <see cref="T:System.Data.DataTableCollection" />. </param>
		/// <param name="tableNamespace">The namespace for the XML representation of the data stored in the <see langword="DataTable" />. </param>
		// Token: 0x06000429 RID: 1065 RVA: 0x00010936 File Offset: 0x0000EB36
		public DataTable(string tableName, string tableNamespace) : this(tableName)
		{
			this.Namespace = tableNamespace;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTable" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">The data needed to serialize or deserialize an object.</param>
		/// <param name="context">The source and destination of a given serialized stream. </param>
		// Token: 0x0600042A RID: 1066 RVA: 0x00010948 File Offset: 0x0000EB48
		protected DataTable(SerializationInfo info, StreamingContext context) : this()
		{
			bool isSingleTable = context.Context == null || Convert.ToBoolean(context.Context, CultureInfo.InvariantCulture);
			SerializationFormat remotingFormat = SerializationFormat.Xml;
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Name == "DataTable.RemotingFormat")
				{
					remotingFormat = (SerializationFormat)enumerator.Value;
				}
			}
			this.DeserializeDataTable(info, context, isSingleTable, remotingFormat);
		}

		/// <summary>Populates a serialization information object with the data needed to serialize the <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized data associated with the <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the <see cref="T:System.Data.DataTable" />.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (<see langword="Nothing" /> in Visual Basic).</exception>
		// Token: 0x0600042B RID: 1067 RVA: 0x000109B4 File Offset: 0x0000EBB4
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			SerializationFormat remotingFormat = this.RemotingFormat;
			bool isSingleTable = context.Context == null || Convert.ToBoolean(context.Context, CultureInfo.InvariantCulture);
			this.SerializeDataTable(info, context, isSingleTable, remotingFormat);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000109F0 File Offset: 0x0000EBF0
		private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
		{
			info.AddValue("DataTable.RemotingVersion", new Version(2, 0));
			if (remotingFormat != SerializationFormat.Xml)
			{
				info.AddValue("DataTable.RemotingFormat", remotingFormat);
			}
			if (remotingFormat != SerializationFormat.Xml)
			{
				this.SerializeTableSchema(info, context, isSingleTable);
				if (isSingleTable)
				{
					this.SerializeTableData(info, context, 0);
					return;
				}
			}
			else
			{
				string namespaceURI = string.Empty;
				bool flag = false;
				if (this._dataSet == null)
				{
					DataSet dataSet = new DataSet("tmpDataSet");
					dataSet.SetLocaleValue(this._culture, this._cultureUserSet);
					dataSet.CaseSensitive = this.CaseSensitive;
					dataSet._namespaceURI = this.Namespace;
					dataSet.Tables.Add(this);
					flag = true;
				}
				else
				{
					namespaceURI = this.DataSet.Namespace;
					this.DataSet._namespaceURI = this.Namespace;
				}
				info.AddValue("XmlSchema", this._dataSet.GetXmlSchemaForRemoting(this));
				info.AddValue("XmlDiffGram", this._dataSet.GetRemotingDiffGram(this));
				if (flag)
				{
					this._dataSet.Tables.Remove(this);
					return;
				}
				this._dataSet._namespaceURI = namespaceURI;
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00010B04 File Offset: 0x0000ED04
		internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
		{
			if (remotingFormat != SerializationFormat.Xml)
			{
				this.DeserializeTableSchema(info, context, isSingleTable);
				if (isSingleTable)
				{
					this.DeserializeTableData(info, context, 0);
					this.ResetIndexes();
					return;
				}
			}
			else
			{
				string text = (string)info.GetValue("XmlSchema", typeof(string));
				string text2 = (string)info.GetValue("XmlDiffGram", typeof(string));
				if (text != null)
				{
					DataSet dataSet = new DataSet();
					dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(text)));
					DataTable dataTable = dataSet.Tables[0];
					dataTable.CloneTo(this, null, false);
					this.Namespace = dataTable.Namespace;
					if (text2 != null)
					{
						dataSet.Tables.Remove(dataSet.Tables[0]);
						dataSet.Tables.Add(this);
						dataSet.ReadXml(new XmlTextReader(new StringReader(text2)), XmlReadMode.DiffGram);
						dataSet.Tables.Remove(this);
					}
				}
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00010BEC File Offset: 0x0000EDEC
		internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
		{
			info.AddValue("DataTable.TableName", this.TableName);
			info.AddValue("DataTable.Namespace", this.Namespace);
			info.AddValue("DataTable.Prefix", this.Prefix);
			info.AddValue("DataTable.CaseSensitive", this._caseSensitive);
			info.AddValue("DataTable.caseSensitiveAmbient", !this._caseSensitiveUserSet);
			info.AddValue("DataTable.LocaleLCID", this.Locale.LCID);
			info.AddValue("DataTable.MinimumCapacity", this._recordManager.MinimumCapacity);
			info.AddValue("DataTable.NestedInDataSet", this._fNestedInDataset);
			info.AddValue("DataTable.TypeName", this.TypeName.ToString());
			info.AddValue("DataTable.RepeatableElement", this._repeatableElement);
			info.AddValue("DataTable.ExtendedProperties", this.ExtendedProperties);
			info.AddValue("DataTable.Columns.Count", this.Columns.Count);
			if (isSingleTable && !this.CheckForClosureOnExpressionTables(new List<DataTable>
			{
				this
			}))
			{
				throw ExceptionBuilder.CanNotRemoteDataTable();
			}
			IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
			for (int i = 0; i < this.Columns.Count; i++)
			{
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.ColumnName", i), this.Columns[i].ColumnName);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.Namespace", i), this.Columns[i]._columnUri);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.Prefix", i), this.Columns[i].Prefix);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.ColumnMapping", i), this.Columns[i].ColumnMapping);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AllowDBNull", i), this.Columns[i].AllowDBNull);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AutoIncrement", i), this.Columns[i].AutoIncrement);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AutoIncrementStep", i), this.Columns[i].AutoIncrementStep);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AutoIncrementSeed", i), this.Columns[i].AutoIncrementSeed);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.Caption", i), this.Columns[i].Caption);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.DefaultValue", i), this.Columns[i].DefaultValue);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.ReadOnly", i), this.Columns[i].ReadOnly);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.MaxLength", i), this.Columns[i].MaxLength);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.DataType_AssemblyQualifiedName", i), this.Columns[i].DataType.AssemblyQualifiedName);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.XmlDataType", i), this.Columns[i].XmlDataType);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.SimpleType", i), this.Columns[i].SimpleType);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.DateTimeMode", i), this.Columns[i].DateTimeMode);
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AutoIncrementCurrent", i), this.Columns[i].AutoIncrementCurrent);
				if (isSingleTable)
				{
					info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.Expression", i), this.Columns[i].Expression);
				}
				info.AddValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.ExtendedProperties", i), this.Columns[i]._extendedProperties);
			}
			if (isSingleTable)
			{
				this.SerializeConstraints(info, context, 0, false);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00011034 File Offset: 0x0000F234
		internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
		{
			this._tableName = info.GetString("DataTable.TableName");
			this._tableNamespace = info.GetString("DataTable.Namespace");
			this._tablePrefix = info.GetString("DataTable.Prefix");
			bool boolean = info.GetBoolean("DataTable.CaseSensitive");
			this.SetCaseSensitiveValue(boolean, true, false);
			this._caseSensitiveUserSet = !info.GetBoolean("DataTable.caseSensitiveAmbient");
			CultureInfo culture = new CultureInfo((int)info.GetValue("DataTable.LocaleLCID", typeof(int)));
			this.SetLocaleValue(culture, true, false);
			this._cultureUserSet = true;
			this.MinimumCapacity = info.GetInt32("DataTable.MinimumCapacity");
			this._fNestedInDataset = info.GetBoolean("DataTable.NestedInDataSet");
			string @string = info.GetString("DataTable.TypeName");
			this._typeName = new XmlQualifiedName(@string);
			this._repeatableElement = info.GetBoolean("DataTable.RepeatableElement");
			this._extendedProperties = (PropertyCollection)info.GetValue("DataTable.ExtendedProperties", typeof(PropertyCollection));
			int @int = info.GetInt32("DataTable.Columns.Count");
			string[] array = new string[@int];
			IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
			for (int i = 0; i < @int; i++)
			{
				DataColumn dataColumn = new DataColumn();
				dataColumn.ColumnName = info.GetString(string.Format(invariantCulture, "DataTable.DataColumn_{0}.ColumnName", i));
				dataColumn._columnUri = info.GetString(string.Format(invariantCulture, "DataTable.DataColumn_{0}.Namespace", i));
				dataColumn.Prefix = info.GetString(string.Format(invariantCulture, "DataTable.DataColumn_{0}.Prefix", i));
				string typeName = (string)info.GetValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.DataType_AssemblyQualifiedName", i), typeof(string));
				dataColumn.DataType = Type.GetType(typeName, true);
				dataColumn.XmlDataType = (string)info.GetValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.XmlDataType", i), typeof(string));
				dataColumn.SimpleType = (SimpleType)info.GetValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.SimpleType", i), typeof(SimpleType));
				dataColumn.ColumnMapping = (MappingType)info.GetValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.ColumnMapping", i), typeof(MappingType));
				dataColumn.DateTimeMode = (DataSetDateTime)info.GetValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.DateTimeMode", i), typeof(DataSetDateTime));
				dataColumn.AllowDBNull = info.GetBoolean(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AllowDBNull", i));
				dataColumn.AutoIncrement = info.GetBoolean(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AutoIncrement", i));
				dataColumn.AutoIncrementStep = info.GetInt64(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AutoIncrementStep", i));
				dataColumn.AutoIncrementSeed = info.GetInt64(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AutoIncrementSeed", i));
				dataColumn.Caption = info.GetString(string.Format(invariantCulture, "DataTable.DataColumn_{0}.Caption", i));
				dataColumn.DefaultValue = info.GetValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.DefaultValue", i), typeof(object));
				dataColumn.ReadOnly = info.GetBoolean(string.Format(invariantCulture, "DataTable.DataColumn_{0}.ReadOnly", i));
				dataColumn.MaxLength = info.GetInt32(string.Format(invariantCulture, "DataTable.DataColumn_{0}.MaxLength", i));
				dataColumn.AutoIncrementCurrent = info.GetValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.AutoIncrementCurrent", i), typeof(object));
				if (isSingleTable)
				{
					array[i] = info.GetString(string.Format(invariantCulture, "DataTable.DataColumn_{0}.Expression", i));
				}
				dataColumn._extendedProperties = (PropertyCollection)info.GetValue(string.Format(invariantCulture, "DataTable.DataColumn_{0}.ExtendedProperties", i), typeof(PropertyCollection));
				this.Columns.Add(dataColumn);
			}
			if (isSingleTable)
			{
				for (int j = 0; j < @int; j++)
				{
					if (array[j] != null)
					{
						this.Columns[j].Expression = array[j];
					}
				}
			}
			if (isSingleTable)
			{
				this.DeserializeConstraints(info, context, 0, false);
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00011498 File Offset: 0x0000F698
		internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < this.Constraints.Count; i++)
			{
				Constraint constraint = this.Constraints[i];
				UniqueConstraint uniqueConstraint = constraint as UniqueConstraint;
				if (uniqueConstraint != null)
				{
					int[] array = new int[uniqueConstraint.Columns.Length];
					for (int j = 0; j < array.Length; j++)
					{
						array[j] = uniqueConstraint.Columns[j].Ordinal;
					}
					arrayList.Add(new ArrayList
					{
						"U",
						uniqueConstraint.ConstraintName,
						array,
						uniqueConstraint.IsPrimaryKey,
						uniqueConstraint.ExtendedProperties
					});
				}
				else
				{
					ForeignKeyConstraint foreignKeyConstraint = constraint as ForeignKeyConstraint;
					if (allConstraints || (foreignKeyConstraint.Table == this && foreignKeyConstraint.RelatedTable == this))
					{
						int[] array2 = new int[foreignKeyConstraint.RelatedColumns.Length + 1];
						array2[0] = (allConstraints ? this.DataSet.Tables.IndexOf(foreignKeyConstraint.RelatedTable) : 0);
						for (int k = 1; k < array2.Length; k++)
						{
							array2[k] = foreignKeyConstraint.RelatedColumns[k - 1].Ordinal;
						}
						int[] array3 = new int[foreignKeyConstraint.Columns.Length + 1];
						array3[0] = (allConstraints ? this.DataSet.Tables.IndexOf(foreignKeyConstraint.Table) : 0);
						for (int l = 1; l < array3.Length; l++)
						{
							array3[l] = foreignKeyConstraint.Columns[l - 1].Ordinal;
						}
						arrayList.Add(new ArrayList
						{
							"F",
							foreignKeyConstraint.ConstraintName,
							array2,
							array3,
							new int[]
							{
								(int)foreignKeyConstraint.AcceptRejectRule,
								(int)foreignKeyConstraint.UpdateRule,
								(int)foreignKeyConstraint.DeleteRule
							},
							foreignKeyConstraint.ExtendedProperties
						});
					}
				}
			}
			info.AddValue(string.Format(CultureInfo.InvariantCulture, "DataTable_{0}.Constraints", serIndex), arrayList);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000116F0 File Offset: 0x0000F8F0
		internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
		{
			foreach (object obj in ((ArrayList)info.GetValue(string.Format(CultureInfo.InvariantCulture, "DataTable_{0}.Constraints", serIndex), typeof(ArrayList))))
			{
				ArrayList arrayList = (ArrayList)obj;
				if (((string)arrayList[0]).Equals("U"))
				{
					string name = (string)arrayList[1];
					int[] array = (int[])arrayList[2];
					bool isPrimaryKey = (bool)arrayList[3];
					PropertyCollection extendedProperties = (PropertyCollection)arrayList[4];
					DataColumn[] array2 = new DataColumn[array.Length];
					for (int i = 0; i < array.Length; i++)
					{
						array2[i] = this.Columns[array[i]];
					}
					UniqueConstraint uniqueConstraint = new UniqueConstraint(name, array2, isPrimaryKey);
					uniqueConstraint._extendedProperties = extendedProperties;
					this.Constraints.Add(uniqueConstraint);
				}
				else
				{
					string constraintName = (string)arrayList[1];
					int[] array3 = (int[])arrayList[2];
					int[] array4 = (int[])arrayList[3];
					int[] array5 = (int[])arrayList[4];
					PropertyCollection extendedProperties2 = (PropertyCollection)arrayList[5];
					DataTable dataTable = (!allConstraints) ? this : this.DataSet.Tables[array3[0]];
					DataColumn[] array6 = new DataColumn[array3.Length - 1];
					for (int j = 0; j < array6.Length; j++)
					{
						array6[j] = dataTable.Columns[array3[j + 1]];
					}
					DataTable dataTable2 = (!allConstraints) ? this : this.DataSet.Tables[array4[0]];
					DataColumn[] array7 = new DataColumn[array4.Length - 1];
					for (int k = 0; k < array7.Length; k++)
					{
						array7[k] = dataTable2.Columns[array4[k + 1]];
					}
					ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint(constraintName, array6, array7);
					foreignKeyConstraint.AcceptRejectRule = (AcceptRejectRule)array5[0];
					foreignKeyConstraint.UpdateRule = (Rule)array5[1];
					foreignKeyConstraint.DeleteRule = (Rule)array5[2];
					foreignKeyConstraint._extendedProperties = extendedProperties2;
					this.Constraints.Add(foreignKeyConstraint, false);
				}
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00011958 File Offset: 0x0000FB58
		internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
		{
			int count = this.Columns.Count;
			for (int i = 0; i < count; i++)
			{
				info.AddValue(string.Format(CultureInfo.InvariantCulture, "DataTable_{0}.DataColumn_{1}.Expression", serIndex, i), this.Columns[i].Expression);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000119B0 File Offset: 0x0000FBB0
		internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
		{
			int count = this.Columns.Count;
			for (int i = 0; i < count; i++)
			{
				string @string = info.GetString(string.Format(CultureInfo.InvariantCulture, "DataTable_{0}.DataColumn_{1}.Expression", serIndex, i));
				if (@string.Length != 0)
				{
					this.Columns[i].Expression = @string;
				}
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00011A14 File Offset: 0x0000FC14
		internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
		{
			int count = this.Columns.Count;
			int count2 = this.Rows.Count;
			int num = 0;
			int num2 = 0;
			BitArray bitArray = new BitArray(count2 * 3, false);
			int i = 0;
			while (i < count2)
			{
				int num3 = i * 3;
				DataRow dataRow = this.Rows[i];
				DataRowState rowState = dataRow.RowState;
				if (rowState <= DataRowState.Added)
				{
					if (rowState != DataRowState.Unchanged)
					{
						if (rowState != DataRowState.Added)
						{
							goto IL_A1;
						}
						bitArray[num3 + 1] = true;
					}
				}
				else if (rowState != DataRowState.Deleted)
				{
					if (rowState != DataRowState.Modified)
					{
						goto IL_A1;
					}
					bitArray[num3] = true;
					num++;
				}
				else
				{
					bitArray[num3] = true;
					bitArray[num3 + 1] = true;
				}
				if (-1 != dataRow._tempRecord)
				{
					bitArray[num3 + 2] = true;
					num2++;
				}
				i++;
				continue;
				IL_A1:
				throw ExceptionBuilder.InvalidRowState(rowState);
			}
			int num4 = count2 + num + num2;
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			if (num4 > 0)
			{
				for (int j = 0; j < count; j++)
				{
					object emptyColumnStore = this.Columns[j].GetEmptyColumnStore(num4);
					arrayList.Add(emptyColumnStore);
					BitArray value = new BitArray(num4);
					arrayList2.Add(value);
				}
			}
			int num5 = 0;
			Hashtable hashtable = new Hashtable();
			Hashtable hashtable2 = new Hashtable();
			for (int k = 0; k < count2; k++)
			{
				int num6 = this.Rows[k].CopyValuesIntoStore(arrayList, arrayList2, num5);
				this.GetRowAndColumnErrors(k, hashtable, hashtable2);
				num5 += num6;
			}
			IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
			info.AddValue(string.Format(invariantCulture, "DataTable_{0}.Rows.Count", serIndex), count2);
			info.AddValue(string.Format(invariantCulture, "DataTable_{0}.Records.Count", serIndex), num4);
			info.AddValue(string.Format(invariantCulture, "DataTable_{0}.RowStates", serIndex), bitArray);
			info.AddValue(string.Format(invariantCulture, "DataTable_{0}.Records", serIndex), arrayList);
			info.AddValue(string.Format(invariantCulture, "DataTable_{0}.NullBits", serIndex), arrayList2);
			info.AddValue(string.Format(invariantCulture, "DataTable_{0}.RowErrors", serIndex), hashtable);
			info.AddValue(string.Format(invariantCulture, "DataTable_{0}.ColumnErrors", serIndex), hashtable2);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00011C5C File Offset: 0x0000FE5C
		internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
		{
			bool enforceConstraints = this._enforceConstraints;
			bool inDataLoad = this._inDataLoad;
			try
			{
				this._enforceConstraints = false;
				this._inDataLoad = true;
				IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
				int @int = info.GetInt32(string.Format(invariantCulture, "DataTable_{0}.Rows.Count", serIndex));
				int int2 = info.GetInt32(string.Format(invariantCulture, "DataTable_{0}.Records.Count", serIndex));
				BitArray bitArray = (BitArray)info.GetValue(string.Format(invariantCulture, "DataTable_{0}.RowStates", serIndex), typeof(BitArray));
				ArrayList arrayList = (ArrayList)info.GetValue(string.Format(invariantCulture, "DataTable_{0}.Records", serIndex), typeof(ArrayList));
				ArrayList arrayList2 = (ArrayList)info.GetValue(string.Format(invariantCulture, "DataTable_{0}.NullBits", serIndex), typeof(ArrayList));
				Hashtable hashtable = (Hashtable)info.GetValue(string.Format(invariantCulture, "DataTable_{0}.RowErrors", serIndex), typeof(Hashtable));
				hashtable.OnDeserialization(this);
				Hashtable hashtable2 = (Hashtable)info.GetValue(string.Format(invariantCulture, "DataTable_{0}.ColumnErrors", serIndex), typeof(Hashtable));
				hashtable2.OnDeserialization(this);
				if (int2 > 0)
				{
					for (int i = 0; i < this.Columns.Count; i++)
					{
						this.Columns[i].SetStorage(arrayList[i], (BitArray)arrayList2[i]);
					}
					int num = 0;
					DataRow[] array = new DataRow[int2];
					for (int j = 0; j < @int; j++)
					{
						DataRow dataRow = this.NewEmptyRow();
						array[num] = dataRow;
						int num2 = j * 3;
						DataRowState dataRowState = this.ConvertToRowState(bitArray, num2);
						if (dataRowState <= DataRowState.Added)
						{
							if (dataRowState != DataRowState.Unchanged)
							{
								if (dataRowState == DataRowState.Added)
								{
									dataRow._oldRecord = -1;
									dataRow._newRecord = num;
									num++;
								}
							}
							else
							{
								dataRow._oldRecord = num;
								dataRow._newRecord = num;
								num++;
							}
						}
						else if (dataRowState != DataRowState.Deleted)
						{
							if (dataRowState == DataRowState.Modified)
							{
								dataRow._oldRecord = num;
								dataRow._newRecord = num + 1;
								array[num + 1] = dataRow;
								num += 2;
							}
						}
						else
						{
							dataRow._oldRecord = num;
							dataRow._newRecord = -1;
							num++;
						}
						if (bitArray[num2 + 2])
						{
							dataRow._tempRecord = num;
							array[num] = dataRow;
							num++;
						}
						else
						{
							dataRow._tempRecord = -1;
						}
						this.Rows.ArrayAdd(dataRow);
						dataRow.rowID = this._nextRowID;
						this._nextRowID += 1L;
						this.ConvertToRowError(j, hashtable, hashtable2);
					}
					this._recordManager.SetRowCache(array);
					this.ResetIndexes();
				}
			}
			finally
			{
				this._enforceConstraints = enforceConstraints;
				this._inDataLoad = inDataLoad;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00011F54 File Offset: 0x00010154
		private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex)
		{
			bool flag = bitStates[bitIndex];
			bool flag2 = bitStates[bitIndex + 1];
			if (!flag && !flag2)
			{
				return DataRowState.Unchanged;
			}
			if (!flag && flag2)
			{
				return DataRowState.Added;
			}
			if (flag && !flag2)
			{
				return DataRowState.Modified;
			}
			if (flag && flag2)
			{
				return DataRowState.Deleted;
			}
			throw ExceptionBuilder.InvalidRowBitPattern();
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00011F9C File Offset: 0x0001019C
		internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
		{
			DataRow dataRow = this.Rows[rowIndex];
			if (dataRow.HasErrors)
			{
				rowErrors.Add(rowIndex, dataRow.RowError);
				DataColumn[] columnsInError = dataRow.GetColumnsInError();
				if (columnsInError.Length != 0)
				{
					int[] array = new int[columnsInError.Length];
					string[] array2 = new string[columnsInError.Length];
					for (int i = 0; i < columnsInError.Length; i++)
					{
						array[i] = columnsInError[i].Ordinal;
						array2[i] = dataRow.GetColumnError(columnsInError[i]);
					}
					ArrayList arrayList = new ArrayList();
					arrayList.Add(array);
					arrayList.Add(array2);
					colErrors.Add(rowIndex, arrayList);
				}
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00012044 File Offset: 0x00010244
		private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
		{
			DataRow dataRow = this.Rows[rowIndex];
			if (rowErrors.ContainsKey(rowIndex))
			{
				dataRow.RowError = (string)rowErrors[rowIndex];
			}
			if (colErrors.ContainsKey(rowIndex))
			{
				ArrayList arrayList = (ArrayList)colErrors[rowIndex];
				int[] array = (int[])arrayList[0];
				string[] array2 = (string[])arrayList[1];
				for (int i = 0; i < array.Length; i++)
				{
					dataRow.SetColumnError(array[i], array2[i]);
				}
			}
		}

		/// <summary>Indicates whether string comparisons within the table are case-sensitive.</summary>
		/// <returns>
		///     <see langword="true" /> if the comparison is case-sensitive; otherwise <see langword="false" />. The default is set to the parent <see cref="T:System.Data.DataSet" /> object's <see cref="P:System.Data.DataSet.CaseSensitive" /> property, or <see langword="false" /> if the <see cref="T:System.Data.DataTable" /> was created independently of a <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x000120D5 File Offset: 0x000102D5
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x000120E0 File Offset: 0x000102E0
		public bool CaseSensitive
		{
			get
			{
				return this._caseSensitive;
			}
			set
			{
				if (this._caseSensitive != value)
				{
					bool caseSensitive = this._caseSensitive;
					bool caseSensitiveUserSet = this._caseSensitiveUserSet;
					this._caseSensitive = value;
					this._caseSensitiveUserSet = true;
					if (this.DataSet != null && !this.DataSet.ValidateCaseConstraint())
					{
						this._caseSensitive = caseSensitive;
						this._caseSensitiveUserSet = caseSensitiveUserSet;
						throw ExceptionBuilder.CannotChangeCaseLocale();
					}
					this.SetCaseSensitiveValue(value, true, true);
				}
				this._caseSensitiveUserSet = true;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001214C File Offset: 0x0001034C
		internal bool AreIndexEventsSuspended
		{
			get
			{
				return 0 < this._suspendIndexEvents;
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00012158 File Offset: 0x00010358
		internal void RestoreIndexEvents(bool forceReset)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataTable.RestoreIndexEvents|Info> {0}, {1}", this.ObjectID, this._suspendIndexEvents);
			if (0 < this._suspendIndexEvents)
			{
				this._suspendIndexEvents--;
				if (this._suspendIndexEvents == 0)
				{
					Exception ex = null;
					this.SetShadowIndexes();
					try
					{
						int count = this._shadowIndexes.Count;
						for (int i = 0; i < count; i++)
						{
							Index index = this._shadowIndexes[i];
							try
							{
								if (forceReset || index.HasRemoteAggregate)
								{
									index.Reset();
								}
								else
								{
									index.FireResetEvent();
								}
							}
							catch (Exception ex2) when (ADP.IsCatchableExceptionType(ex2))
							{
								ExceptionBuilder.TraceExceptionWithoutRethrow(ex2);
								if (ex == null)
								{
									ex = ex2;
								}
							}
						}
						if (ex != null)
						{
							throw ex;
						}
					}
					finally
					{
						this.RestoreShadowIndexes();
					}
				}
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00012244 File Offset: 0x00010444
		internal void SuspendIndexEvents()
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataTable.SuspendIndexEvents|Info> {0}, {1}", this.ObjectID, this._suspendIndexEvents);
			this._suspendIndexEvents++;
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Data.DataTable" /> is initialized.</summary>
		/// <returns>
		///     <see langword="true" /> to indicate the component has completed initialization; otherwise <see langword="false" />. </returns>
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0001226F File Offset: 0x0001046F
		[Browsable(false)]
		public bool IsInitialized
		{
			get
			{
				return !this.fInitInProgress;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0001227C File Offset: 0x0001047C
		private bool IsTypedDataTable
		{
			get
			{
				byte isTypedDataTable = this._isTypedDataTable;
				if (isTypedDataTable != 0)
				{
					return isTypedDataTable == 1;
				}
				this._isTypedDataTable = ((base.GetType() != typeof(DataTable)) ? 1 : 2);
				return 1 == this._isTypedDataTable;
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000122C8 File Offset: 0x000104C8
		internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes)
		{
			if (userSet || (!this._caseSensitiveUserSet && this._caseSensitive != isCaseSensitive))
			{
				this._caseSensitive = isCaseSensitive;
				if (isCaseSensitive)
				{
					this._compareFlags = CompareOptions.None;
				}
				else
				{
					this._compareFlags = (CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);
				}
				if (resetIndexes)
				{
					this.ResetIndexes();
					foreach (object obj in this.Constraints)
					{
						((Constraint)obj).CheckConstraint();
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0001235C File Offset: 0x0001055C
		private void ResetCaseSensitive()
		{
			this.SetCaseSensitiveValue(this._dataSet != null && this._dataSet.CaseSensitive, true, true);
			this._caseSensitiveUserSet = false;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00012384 File Offset: 0x00010584
		internal bool ShouldSerializeCaseSensitive()
		{
			return this._caseSensitiveUserSet;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001238C File Offset: 0x0001058C
		internal bool SelfNested
		{
			get
			{
				foreach (object obj in this.ParentRelations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (dataRelation.Nested && dataRelation.ParentTable == this)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000123F8 File Offset: 0x000105F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal List<Index> LiveIndexes
		{
			get
			{
				if (!this.AreIndexEventsSuspended)
				{
					int num = this._indexes.Count - 1;
					while (0 <= num)
					{
						Index index = this._indexes[num];
						if (index.RefCount <= 1)
						{
							index.RemoveRef();
						}
						num--;
					}
				}
				return this._indexes;
			}
		}

		/// <summary>Gets or sets the serialization format.</summary>
		/// <returns>A <see cref="T:System.Data.SerializationFormat" /> enumeration specifying either <see langword="Binary" /> or <see langword="Xml" /> serialization.</returns>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00012448 File Offset: 0x00010648
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00012450 File Offset: 0x00010650
		[DefaultValue(SerializationFormat.Xml)]
		public SerializationFormat RemotingFormat
		{
			get
			{
				return this._remotingFormat;
			}
			set
			{
				if (value != SerializationFormat.Binary && value != SerializationFormat.Xml)
				{
					throw ExceptionBuilder.InvalidRemotingFormat(value);
				}
				if (this.DataSet != null && value != this.DataSet.RemotingFormat)
				{
					throw ExceptionBuilder.CanNotSetRemotingFormat();
				}
				this._remotingFormat = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00012483 File Offset: 0x00010683
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0001248B File Offset: 0x0001068B
		internal int UKColumnPositionForInference
		{
			get
			{
				return this._ukColumnPositionForInference;
			}
			set
			{
				this._ukColumnPositionForInference = value;
			}
		}

		/// <summary>Gets the collection of child relations for this <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataRelationCollection" /> that contains the child relations for the table. An empty collection is returned if no <see cref="T:System.Data.DataRelation" /> objects exist.</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00012494 File Offset: 0x00010694
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataRelationCollection ChildRelations
		{
			get
			{
				DataRelationCollection result;
				if ((result = this._childRelationsCollection) == null)
				{
					result = (this._childRelationsCollection = new DataRelationCollection.DataTableRelationCollection(this, false));
				}
				return result;
			}
		}

		/// <summary>Gets the collection of columns that belong to this table.</summary>
		/// <returns>A <see cref="T:System.Data.DataColumnCollection" /> that contains the collection of <see cref="T:System.Data.DataColumn" /> objects for the table. An empty collection is returned if no <see cref="T:System.Data.DataColumn" /> objects exist.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x000124BB File Offset: 0x000106BB
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataColumnCollection Columns
		{
			get
			{
				return this._columnCollection;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000124C3 File Offset: 0x000106C3
		private void ResetColumns()
		{
			this.Columns.Clear();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x000124D0 File Offset: 0x000106D0
		private CompareInfo CompareInfo
		{
			get
			{
				CompareInfo result;
				if ((result = this._compareInfo) == null)
				{
					result = (this._compareInfo = this.Locale.CompareInfo);
				}
				return result;
			}
		}

		/// <summary>Gets the collection of constraints maintained by this table.</summary>
		/// <returns>A <see cref="T:System.Data.ConstraintCollection" /> that contains the collection of <see cref="T:System.Data.Constraint" /> objects for the table. An empty collection is returned if no <see cref="T:System.Data.Constraint" /> objects exist.</returns>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000124FB File Offset: 0x000106FB
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ConstraintCollection Constraints
		{
			get
			{
				return this._constraintCollection;
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00012503 File Offset: 0x00010703
		private void ResetConstraints()
		{
			this.Constraints.Clear();
		}

		/// <summary>Gets the <see cref="T:System.Data.DataSet" /> to which this table belongs.</summary>
		/// <returns>The <see cref="T:System.Data.DataSet" /> to which this table belongs.</returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00012510 File Offset: 0x00010710
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataSet DataSet
		{
			get
			{
				return this._dataSet;
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00012518 File Offset: 0x00010718
		internal void SetDataSet(DataSet dataSet)
		{
			if (this._dataSet != dataSet)
			{
				this._dataSet = dataSet;
				DataColumnCollection columns = this.Columns;
				for (int i = 0; i < columns.Count; i++)
				{
					columns[i].OnSetDataSet();
				}
				if (this.DataSet != null)
				{
					this._defaultView = null;
				}
				if (dataSet != null)
				{
					this._remotingFormat = dataSet.RemotingFormat;
				}
			}
		}

		/// <summary>Gets a customized view of the table that may include a filtered view, or a cursor position.</summary>
		/// <returns>The <see cref="T:System.Data.DataView" /> associated with the <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00012578 File Offset: 0x00010778
		[Browsable(false)]
		public DataView DefaultView
		{
			get
			{
				DataView dataView = this._defaultView;
				if (dataView == null)
				{
					if (this._dataSet != null)
					{
						dataView = this._dataSet.DefaultViewManager.CreateDataView(this);
					}
					else
					{
						dataView = new DataView(this, true);
						dataView.SetIndex2("", DataViewRowState.CurrentRows, null, true);
					}
					dataView = Interlocked.CompareExchange<DataView>(ref this._defaultView, dataView, null);
					if (dataView == null)
					{
						dataView = this._defaultView;
					}
				}
				return dataView;
			}
		}

		/// <summary>Gets or sets the expression that returns a value used to represent this table in the user interface. The <see langword="DisplayExpression" /> property lets you display the name of this table in a user interface.</summary>
		/// <returns>A display string.</returns>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x000125DB File Offset: 0x000107DB
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x000125E3 File Offset: 0x000107E3
		[DefaultValue("")]
		public string DisplayExpression
		{
			get
			{
				return this.DisplayExpressionInternal;
			}
			set
			{
				this._displayExpression = ((!string.IsNullOrEmpty(value)) ? new DataExpression(this, value) : null);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x000125FD File Offset: 0x000107FD
		internal string DisplayExpressionInternal
		{
			get
			{
				if (this._displayExpression == null)
				{
					return string.Empty;
				}
				return this._displayExpression.Expression;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00012618 File Offset: 0x00010818
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0001263E File Offset: 0x0001083E
		internal bool EnforceConstraints
		{
			get
			{
				if (this.SuspendEnforceConstraints)
				{
					return false;
				}
				if (this._dataSet != null)
				{
					return this._dataSet.EnforceConstraints;
				}
				return this._enforceConstraints;
			}
			set
			{
				if (this._dataSet == null && this._enforceConstraints != value)
				{
					if (value)
					{
						this.EnableConstraints();
					}
					this._enforceConstraints = value;
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00012661 File Offset: 0x00010861
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00012669 File Offset: 0x00010869
		internal bool SuspendEnforceConstraints
		{
			get
			{
				return this._suspendEnforceConstraints;
			}
			set
			{
				this._suspendEnforceConstraints = value;
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00012674 File Offset: 0x00010874
		internal void EnableConstraints()
		{
			bool flag = false;
			foreach (object obj in this.Constraints)
			{
				Constraint constraint = (Constraint)obj;
				if (constraint is UniqueConstraint)
				{
					flag |= constraint.IsConstraintViolated();
				}
			}
			foreach (object obj2 in this.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj2;
				if (!dataColumn.AllowDBNull)
				{
					flag |= dataColumn.IsNotAllowDBNullViolated();
				}
				if (dataColumn.MaxLength >= 0)
				{
					flag |= dataColumn.IsMaxLengthViolated();
				}
			}
			if (flag)
			{
				this.EnforceConstraints = false;
				throw ExceptionBuilder.EnforceConstraint();
			}
		}

		/// <summary>Gets the collection of customized user information.</summary>
		/// <returns>A <see cref="T:System.Data.PropertyCollection" /> that contains custom user information.</returns>
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00012754 File Offset: 0x00010954
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			get
			{
				PropertyCollection result;
				if ((result = this._extendedProperties) == null)
				{
					result = (this._extendedProperties = new PropertyCollection());
				}
				return result;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0001277C File Offset: 0x0001097C
		internal IFormatProvider FormatProvider
		{
			get
			{
				if (this._formatProvider == null)
				{
					CultureInfo cultureInfo = this.Locale;
					if (cultureInfo.IsNeutralCulture)
					{
						cultureInfo = CultureInfo.InvariantCulture;
					}
					this._formatProvider = cultureInfo;
				}
				return this._formatProvider;
			}
		}

		/// <summary>Gets a value indicating whether there are errors in any of the rows in any of the tables of the <see cref="T:System.Data.DataSet" /> to which the table belongs.</summary>
		/// <returns>
		///     <see langword="true" /> if errors exist; otherwise <see langword="false" />.</returns>
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x000127B4 File Offset: 0x000109B4
		[Browsable(false)]
		public bool HasErrors
		{
			get
			{
				for (int i = 0; i < this.Rows.Count; i++)
				{
					if (this.Rows[i].HasErrors)
					{
						return true;
					}
				}
				return false;
			}
		}

		/// <summary>Gets or sets the locale information used to compare strings within the table.</summary>
		/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> that contains data about the user's machine locale. The default is the <see cref="T:System.Data.DataSet" /> object's <see cref="T:System.Globalization.CultureInfo" /> (returned by the <see cref="P:System.Data.DataSet.Locale" /> property) to which the <see cref="T:System.Data.DataTable" /> belongs; if the table doesn't belong to a <see cref="T:System.Data.DataSet" />, the default is the current system <see cref="T:System.Globalization.CultureInfo" />.</returns>
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000127ED File Offset: 0x000109ED
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000127F8 File Offset: 0x000109F8
		public CultureInfo Locale
		{
			get
			{
				return this._culture;
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.set_Locale|API> {0}", this.ObjectID);
				try
				{
					bool cultureUserSet = true;
					if (value == null)
					{
						cultureUserSet = false;
						value = ((this._dataSet != null) ? this._dataSet.Locale : this._culture);
					}
					if (this._culture != value && !this._culture.Equals(value))
					{
						bool flag = false;
						bool flag2 = false;
						CultureInfo culture = this._culture;
						bool cultureUserSet2 = this._cultureUserSet;
						try
						{
							this._cultureUserSet = true;
							this.SetLocaleValue(value, true, false);
							if (this.DataSet == null || this.DataSet.ValidateLocaleConstraint())
							{
								flag = false;
								this.SetLocaleValue(value, true, true);
								flag = true;
							}
						}
						catch
						{
							flag2 = true;
							throw;
						}
						finally
						{
							if (!flag)
							{
								try
								{
									this.SetLocaleValue(culture, true, true);
								}
								catch (Exception e) when (ADP.IsCatchableExceptionType(e))
								{
									ADP.TraceExceptionWithoutRethrow(e);
								}
								this._cultureUserSet = cultureUserSet2;
								if (!flag2)
								{
									throw ExceptionBuilder.CannotChangeCaseLocale(null);
								}
							}
						}
						this.SetLocaleValue(value, true, true);
					}
					this._cultureUserSet = cultureUserSet;
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00012948 File Offset: 0x00010B48
		internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes)
		{
			if (userSet || resetIndexes || (!this._cultureUserSet && !this._culture.Equals(culture)))
			{
				this._culture = culture;
				this._compareInfo = null;
				this._formatProvider = null;
				this._hashCodeProvider = null;
				foreach (object obj in this.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					dataColumn._hashCode = this.GetSpecialHashCode(dataColumn.ColumnName);
				}
				if (resetIndexes)
				{
					this.ResetIndexes();
					foreach (object obj2 in this.Constraints)
					{
						((Constraint)obj2).CheckConstraint();
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00012A3C File Offset: 0x00010C3C
		internal bool ShouldSerializeLocale()
		{
			return this._cultureUserSet;
		}

		/// <summary>Gets or sets the initial starting size for this table.</summary>
		/// <returns>The initial starting size in rows of this table. The default is 50.</returns>
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00012A44 File Offset: 0x00010C44
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00012A51 File Offset: 0x00010C51
		[DefaultValue(50)]
		public int MinimumCapacity
		{
			get
			{
				return this._recordManager.MinimumCapacity;
			}
			set
			{
				if (value != this._recordManager.MinimumCapacity)
				{
					this._recordManager.MinimumCapacity = value;
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00012A6D File Offset: 0x00010C6D
		internal int RecordCapacity
		{
			get
			{
				return this._recordManager.RecordCapacity;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00012A7A File Offset: 0x00010C7A
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00012A82 File Offset: 0x00010C82
		internal int ElementColumnCount
		{
			get
			{
				return this._elementColumnCount;
			}
			set
			{
				if (value > 0 && this._xmlText != null)
				{
					throw ExceptionBuilder.TableCannotAddToSimpleContent();
				}
				this._elementColumnCount = value;
			}
		}

		/// <summary>Gets the collection of parent relations for this <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataRelationCollection" /> that contains the parent relations for the table. An empty collection is returned if no <see cref="T:System.Data.DataRelation" /> objects exist.</returns>
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00012AA0 File Offset: 0x00010CA0
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataRelationCollection ParentRelations
		{
			get
			{
				DataRelationCollection result;
				if ((result = this._parentRelationsCollection) == null)
				{
					result = (this._parentRelationsCollection = new DataRelationCollection.DataTableRelationCollection(this, true));
				}
				return result;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00012AC7 File Offset: 0x00010CC7
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00012ACF File Offset: 0x00010CCF
		internal bool MergingData
		{
			get
			{
				return this._mergingData;
			}
			set
			{
				this._mergingData = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00012AD8 File Offset: 0x00010CD8
		internal DataRelation[] NestedParentRelations
		{
			get
			{
				return this._nestedParentRelations;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00012AE0 File Offset: 0x00010CE0
		internal bool SchemaLoading
		{
			get
			{
				return this._schemaLoading;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00012AE8 File Offset: 0x00010CE8
		internal void CacheNestedParent()
		{
			this._nestedParentRelations = this.FindNestedParentRelations();
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00012AF8 File Offset: 0x00010CF8
		private DataRelation[] FindNestedParentRelations()
		{
			List<DataRelation> list = null;
			foreach (object obj in this.ParentRelations)
			{
				DataRelation dataRelation = (DataRelation)obj;
				if (dataRelation.Nested)
				{
					if (list == null)
					{
						list = new List<DataRelation>();
					}
					list.Add(dataRelation);
				}
			}
			if (list != null && list.Count != 0)
			{
				return list.ToArray();
			}
			return Array.Empty<DataRelation>();
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00012B7C File Offset: 0x00010D7C
		internal int NestedParentsCount
		{
			get
			{
				int num = 0;
				using (IEnumerator enumerator = this.ParentRelations.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((DataRelation)enumerator.Current).Nested)
						{
							num++;
						}
					}
				}
				return num;
			}
		}

		/// <summary>Gets or sets an array of columns that function as primary keys for the data table.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects.</returns>
		/// <exception cref="T:System.Data.DataException">The key is a foreign key. </exception>
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00012BDC File Offset: 0x00010DDC
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00012C08 File Offset: 0x00010E08
		[TypeConverter(typeof(PrimaryKeyTypeConverter))]
		public DataColumn[] PrimaryKey
		{
			get
			{
				UniqueConstraint primaryKey = this._primaryKey;
				if (primaryKey != null)
				{
					return primaryKey.Key.ToArray();
				}
				return Array.Empty<DataColumn>();
			}
			set
			{
				UniqueConstraint uniqueConstraint = null;
				if (this.fInitInProgress && value != null)
				{
					this._delayedSetPrimaryKey = value;
					return;
				}
				if (value != null && value.Length != 0)
				{
					int num = 0;
					int num2 = 0;
					while (num2 < value.Length && value[num2] != null)
					{
						num++;
						num2++;
					}
					if (num != 0)
					{
						DataColumn[] array = value;
						if (num != value.Length)
						{
							array = new DataColumn[num];
							for (int i = 0; i < num; i++)
							{
								array[i] = value[i];
							}
						}
						uniqueConstraint = new UniqueConstraint(array);
						if (uniqueConstraint.Table != this)
						{
							throw ExceptionBuilder.TableForeignPrimaryKey();
						}
					}
				}
				if (uniqueConstraint == this._primaryKey || (uniqueConstraint != null && uniqueConstraint.Equals(this._primaryKey)))
				{
					return;
				}
				UniqueConstraint uniqueConstraint2;
				if ((uniqueConstraint2 = (UniqueConstraint)this.Constraints.FindConstraint(uniqueConstraint)) != null)
				{
					uniqueConstraint.ColumnsReference.CopyTo(uniqueConstraint2.Key.ColumnsReference, 0);
					uniqueConstraint = uniqueConstraint2;
				}
				UniqueConstraint primaryKey = this._primaryKey;
				this._primaryKey = null;
				if (primaryKey != null)
				{
					primaryKey.ConstraintIndex.RemoveRef();
					if (this._loadIndex != null)
					{
						this._loadIndex.RemoveRef();
						this._loadIndex = null;
					}
					if (this._loadIndexwithOriginalAdded != null)
					{
						this._loadIndexwithOriginalAdded.RemoveRef();
						this._loadIndexwithOriginalAdded = null;
					}
					if (this._loadIndexwithCurrentDeleted != null)
					{
						this._loadIndexwithCurrentDeleted.RemoveRef();
						this._loadIndexwithCurrentDeleted = null;
					}
					this.Constraints.Remove(primaryKey);
				}
				if (uniqueConstraint != null && uniqueConstraint2 == null)
				{
					this.Constraints.Add(uniqueConstraint);
				}
				this._primaryKey = uniqueConstraint;
				this._primaryIndex = ((uniqueConstraint != null) ? uniqueConstraint.Key.GetIndexDesc() : Array.Empty<IndexField>());
				if (this._primaryKey != null)
				{
					uniqueConstraint.ConstraintIndex.AddRef();
					for (int j = 0; j < uniqueConstraint.ColumnsReference.Length; j++)
					{
						uniqueConstraint.ColumnsReference[j].AllowDBNull = false;
					}
				}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00012DCD File Offset: 0x00010FCD
		private bool ShouldSerializePrimaryKey()
		{
			return this._primaryKey != null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00012DD8 File Offset: 0x00010FD8
		private void ResetPrimaryKey()
		{
			this.PrimaryKey = null;
		}

		/// <summary>Gets the collection of rows that belong to this table.</summary>
		/// <returns>A <see cref="T:System.Data.DataRowCollection" /> that contains <see cref="T:System.Data.DataRow" /> objects; otherwise a null value if no <see cref="T:System.Data.DataRow" /> objects exist.</returns>
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00012DE1 File Offset: 0x00010FE1
		[Browsable(false)]
		public DataRowCollection Rows
		{
			get
			{
				return this._rowCollection;
			}
		}

		/// <summary>Gets or sets the name of the <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>The name of the <see cref="T:System.Data.DataTable" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <see langword="null" /> or empty string ("") is passed in and this table belongs to a collection. </exception>
		/// <exception cref="T:System.Data.DuplicateNameException">The table belongs to a collection that already has a table with the same name. (Comparison is case-sensitive).</exception>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00012DE9 File Offset: 0x00010FE9
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00012DF4 File Offset: 0x00010FF4
		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue("")]
		public string TableName
		{
			get
			{
				return this._tableName;
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, string>("<ds.DataTable.set_TableName|API> {0}, value='{1}'", this.ObjectID, value);
				try
				{
					if (value == null)
					{
						value = string.Empty;
					}
					CultureInfo locale = this.Locale;
					if (string.Compare(this._tableName, value, true, locale) != 0)
					{
						if (this._dataSet != null)
						{
							if (value.Length == 0)
							{
								throw ExceptionBuilder.NoTableName();
							}
							if (string.Compare(value, this._dataSet.DataSetName, true, this._dataSet.Locale) == 0 && !this._fNestedInDataset)
							{
								throw ExceptionBuilder.DatasetConflictingName(this._dataSet.DataSetName);
							}
							DataRelation[] nestedParentRelations = this.NestedParentRelations;
							if (nestedParentRelations.Length == 0)
							{
								this._dataSet.Tables.RegisterName(value, this.Namespace);
							}
							else
							{
								DataRelation[] array = nestedParentRelations;
								for (int i = 0; i < array.Length; i++)
								{
									if (!array[i].ParentTable.Columns.CanRegisterName(value))
									{
										throw ExceptionBuilder.CannotAddDuplicate2(value);
									}
								}
								this._dataSet.Tables.RegisterName(value, this.Namespace);
								foreach (DataRelation dataRelation in nestedParentRelations)
								{
									dataRelation.ParentTable.Columns.RegisterColumnName(value, null);
									dataRelation.ParentTable.Columns.UnregisterName(this.TableName);
								}
							}
							if (this._tableName.Length != 0)
							{
								this._dataSet.Tables.UnregisterName(this._tableName);
							}
						}
						this.RaisePropertyChanging("TableName");
						this._tableName = value;
						this._encodedTableName = null;
					}
					else if (string.Compare(this._tableName, value, false, locale) != 0)
					{
						this.RaisePropertyChanging("TableName");
						this._tableName = value;
						this._encodedTableName = null;
					}
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00012FCC File Offset: 0x000111CC
		internal string EncodedTableName
		{
			get
			{
				string text = this._encodedTableName;
				if (text == null)
				{
					text = XmlConvert.EncodeLocalName(this.TableName);
					this._encodedTableName = text;
				}
				return text;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00012FF8 File Offset: 0x000111F8
		private string GetInheritedNamespace(List<DataTable> visitedTables)
		{
			DataRelation[] nestedParentRelations = this.NestedParentRelations;
			if (nestedParentRelations.Length != 0)
			{
				foreach (DataRelation dataRelation in nestedParentRelations)
				{
					if (dataRelation.ParentTable._tableNamespace != null)
					{
						return dataRelation.ParentTable._tableNamespace;
					}
				}
				int num = 0;
				while (num < nestedParentRelations.Length && (nestedParentRelations[num].ParentTable == this || visitedTables.Contains(nestedParentRelations[num].ParentTable)))
				{
					num++;
				}
				if (num < nestedParentRelations.Length)
				{
					DataTable parentTable = nestedParentRelations[num].ParentTable;
					if (!visitedTables.Contains(parentTable))
					{
						visitedTables.Add(parentTable);
					}
					return parentTable.GetInheritedNamespace(visitedTables);
				}
			}
			if (this.DataSet != null)
			{
				return this.DataSet.Namespace;
			}
			return string.Empty;
		}

		/// <summary>Gets or sets the namespace for the XML representation of the data stored in the <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>The namespace of the <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000130A8 File Offset: 0x000112A8
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x000130C0 File Offset: 0x000112C0
		public string Namespace
		{
			get
			{
				return this._tableNamespace ?? this.GetInheritedNamespace(new List<DataTable>());
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, string>("<ds.DataTable.set_Namespace|API> {0}, value='{1}'", this.ObjectID, value);
				try
				{
					if (value != this._tableNamespace)
					{
						if (this._dataSet != null)
						{
							string text = (value == null) ? this.GetInheritedNamespace(new List<DataTable>()) : value;
							if (text != this.Namespace)
							{
								if (this._dataSet.Tables.Contains(this.TableName, text, true, true))
								{
									throw ExceptionBuilder.DuplicateTableName2(this.TableName, text);
								}
								this.CheckCascadingNamespaceConflict(text);
							}
						}
						this.CheckNamespaceValidityForNestedRelations(value);
						this.DoRaiseNamespaceChange();
					}
					this._tableNamespace = value;
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001317C File Offset: 0x0001137C
		internal bool IsNamespaceInherited()
		{
			return this._tableNamespace == null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00013188 File Offset: 0x00011388
		internal void CheckCascadingNamespaceConflict(string realNamespace)
		{
			foreach (object obj in this.ChildRelations)
			{
				DataRelation dataRelation = (DataRelation)obj;
				if (dataRelation.Nested && dataRelation.ChildTable != this && dataRelation.ChildTable._tableNamespace == null)
				{
					DataTable childTable = dataRelation.ChildTable;
					if (this._dataSet.Tables.Contains(childTable.TableName, realNamespace, false, true))
					{
						throw ExceptionBuilder.DuplicateTableName2(this.TableName, realNamespace);
					}
					childTable.CheckCascadingNamespaceConflict(realNamespace);
				}
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00013230 File Offset: 0x00011430
		internal void CheckNamespaceValidityForNestedRelations(string realNamespace)
		{
			foreach (object obj in this.ChildRelations)
			{
				DataRelation dataRelation = (DataRelation)obj;
				if (dataRelation.Nested)
				{
					if (realNamespace != null)
					{
						dataRelation.ChildTable.CheckNamespaceValidityForNestedParentRelations(realNamespace, this);
					}
					else
					{
						dataRelation.ChildTable.CheckNamespaceValidityForNestedParentRelations(this.GetInheritedNamespace(new List<DataTable>()), this);
					}
				}
			}
			if (realNamespace == null)
			{
				this.CheckNamespaceValidityForNestedParentRelations(this.GetInheritedNamespace(new List<DataTable>()), this);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000132C8 File Offset: 0x000114C8
		internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable)
		{
			foreach (object obj in this.ParentRelations)
			{
				DataRelation dataRelation = (DataRelation)obj;
				if (dataRelation.Nested && dataRelation.ParentTable != parentTable && dataRelation.ParentTable.Namespace != ns)
				{
					throw ExceptionBuilder.InValidNestedRelation(this.TableName);
				}
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001334C File Offset: 0x0001154C
		internal void DoRaiseNamespaceChange()
		{
			this.RaisePropertyChanging("Namespace");
			foreach (object obj in this.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				if (dataColumn._columnUri == null)
				{
					dataColumn.RaisePropertyChanging("Namespace");
				}
			}
			foreach (object obj2 in this.ChildRelations)
			{
				DataRelation dataRelation = (DataRelation)obj2;
				if (dataRelation.Nested && dataRelation.ChildTable != this)
				{
					DataTable childTable = dataRelation.ChildTable;
					dataRelation.ChildTable.DoRaiseNamespaceChange();
				}
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00013420 File Offset: 0x00011620
		private bool ShouldSerializeNamespace()
		{
			return this._tableNamespace != null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001342B File Offset: 0x0001162B
		private void ResetNamespace()
		{
			this.Namespace = null;
		}

		/// <summary>Begins the initialization of a <see cref="T:System.Data.DataTable" /> that is used on a form or used by another component. The initialization occurs at run time. </summary>
		// Token: 0x06000480 RID: 1152 RVA: 0x00013434 File Offset: 0x00011634
		public virtual void BeginInit()
		{
			this.fInitInProgress = true;
		}

		/// <summary>Ends the initialization of a <see cref="T:System.Data.DataTable" /> that is used on a form or used by another component. The initialization occurs at run time.</summary>
		// Token: 0x06000481 RID: 1153 RVA: 0x00013440 File Offset: 0x00011640
		public virtual void EndInit()
		{
			if (this._dataSet == null || !this._dataSet._fInitInProgress)
			{
				this.Columns.FinishInitCollection();
				this.Constraints.FinishInitConstraints();
				foreach (object obj in this.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (dataColumn.Computed)
					{
						dataColumn.Expression = dataColumn.Expression;
					}
				}
			}
			this.fInitInProgress = false;
			if (this._delayedSetPrimaryKey != null)
			{
				this.PrimaryKey = this._delayedSetPrimaryKey;
				this._delayedSetPrimaryKey = null;
			}
			if (this._delayedViews.Count > 0)
			{
				foreach (DataView dataView in this._delayedViews)
				{
					dataView.EndInit();
				}
				this._delayedViews.Clear();
			}
			this.OnInitialized();
		}

		/// <summary>Gets or sets the namespace for the XML representation of the data stored in the <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>The prefix of the <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00013554 File Offset: 0x00011754
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x0001355C File Offset: 0x0001175C
		[DefaultValue("")]
		public string Prefix
		{
			get
			{
				return this._tablePrefix;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				DataCommonEventSource.Log.Trace<int, string>("<ds.DataTable.set_Prefix|API> {0}, value='{1}'", this.ObjectID, value);
				if (XmlConvert.DecodeName(value) == value && XmlConvert.EncodeName(value) != value)
				{
					throw ExceptionBuilder.InvalidPrefix(value);
				}
				this._tablePrefix = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000135B3 File Offset: 0x000117B3
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x000135BC File Offset: 0x000117BC
		internal DataColumn XmlText
		{
			get
			{
				return this._xmlText;
			}
			set
			{
				if (this._xmlText != value)
				{
					if (this._xmlText != null)
					{
						if (value != null)
						{
							throw ExceptionBuilder.MultipleTextOnlyColumns();
						}
						this.Columns.Remove(this._xmlText);
					}
					else if (value != this.Columns[value.ColumnName])
					{
						this.Columns.Add(value);
					}
					this._xmlText = value;
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0001361D File Offset: 0x0001181D
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00013625 File Offset: 0x00011825
		internal decimal MaxOccurs
		{
			get
			{
				return this._maxOccurs;
			}
			set
			{
				this._maxOccurs = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0001362E File Offset: 0x0001182E
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00013636 File Offset: 0x00011836
		internal decimal MinOccurs
		{
			get
			{
				return this._minOccurs;
			}
			set
			{
				this._minOccurs = value;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00013640 File Offset: 0x00011840
		internal void SetKeyValues(DataKey key, object[] keyValues, int record)
		{
			for (int i = 0; i < keyValues.Length; i++)
			{
				key.ColumnsReference[i][record] = keyValues[i];
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00013670 File Offset: 0x00011870
		internal DataRow FindByIndex(Index ndx, object[] key)
		{
			Range range = ndx.FindRecords(key);
			if (!range.IsNull)
			{
				return this._recordManager[ndx.GetRecord(range.Min)];
			}
			return null;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000136A8 File Offset: 0x000118A8
		internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx)
		{
			DataRow result = null;
			if (key.HasValue)
			{
				int record = (row._oldRecord == -1) ? row._newRecord : row._oldRecord;
				object[] keyValues = key.GetKeyValues(record);
				result = this.FindByIndex(ndx, keyValues);
			}
			return result;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000136EB File Offset: 0x000118EB
		private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action)
		{
			if (newRecord != -1)
			{
				this.SetNewRecord(row, newRecord, action, true, true, false);
				this.SetOldRecord(row, oldRecord);
				return;
			}
			this.SetOldRecord(row, oldRecord);
			if (row._newRecord != -1)
			{
				this.SetNewRecord(row, newRecord, action, true, true, false);
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00013728 File Offset: 0x00011928
		internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch)
		{
			if (targetRow == null)
			{
				targetRow = this.NewEmptyRow();
				targetRow._oldRecord = this._recordManager.ImportRecord(row.Table, row._oldRecord);
				targetRow._newRecord = targetRow._oldRecord;
				if (row._oldRecord != row._newRecord)
				{
					targetRow._newRecord = this._recordManager.ImportRecord(row.Table, row._newRecord);
				}
				this.InsertRow(targetRow, -1L);
			}
			else
			{
				int tempRecord = targetRow._tempRecord;
				targetRow._tempRecord = -1;
				try
				{
					DataRowState rowState = targetRow.RowState;
					int num = (rowState == DataRowState.Added) ? targetRow._newRecord : targetRow._oldRecord;
					if (targetRow.RowState == DataRowState.Unchanged && row.RowState == DataRowState.Unchanged)
					{
						int num2 = targetRow._oldRecord;
						int num3 = preserveChanges ? this._recordManager.CopyRecord(this, num2, -1) : targetRow._newRecord;
						num2 = this._recordManager.CopyRecord(row.Table, row._oldRecord, targetRow._oldRecord);
						this.SetMergeRecords(targetRow, num3, num2, DataRowAction.Change);
					}
					else if (row._newRecord == -1)
					{
						int num2 = targetRow._oldRecord;
						int num3;
						if (preserveChanges)
						{
							num3 = ((targetRow.RowState == DataRowState.Unchanged) ? this._recordManager.CopyRecord(this, num2, -1) : targetRow._newRecord);
						}
						else
						{
							num3 = -1;
						}
						num2 = this._recordManager.CopyRecord(row.Table, row._oldRecord, num2);
						if (num != ((rowState == DataRowState.Added) ? num3 : num2))
						{
							this.SetMergeRecords(targetRow, num3, num2, (num3 == -1) ? DataRowAction.Delete : DataRowAction.Change);
							idxSearch.Reset();
							int num4 = (rowState == DataRowState.Added) ? num3 : num2;
						}
						else
						{
							this.SetMergeRecords(targetRow, num3, num2, (num3 == -1) ? DataRowAction.Delete : DataRowAction.Change);
						}
					}
					else
					{
						int num2 = targetRow._oldRecord;
						int num3 = targetRow._newRecord;
						if (targetRow.RowState == DataRowState.Unchanged)
						{
							num3 = this._recordManager.CopyRecord(this, num2, -1);
						}
						num2 = this._recordManager.CopyRecord(row.Table, row._oldRecord, num2);
						if (!preserveChanges)
						{
							num3 = this._recordManager.CopyRecord(row.Table, row._newRecord, num3);
						}
						this.SetMergeRecords(targetRow, num3, num2, DataRowAction.Change);
					}
					if (rowState == DataRowState.Added && targetRow._oldRecord != -1)
					{
						idxSearch.Reset();
					}
				}
				finally
				{
					targetRow._tempRecord = tempRecord;
				}
			}
			if (row.HasErrors)
			{
				if (targetRow.RowError.Length == 0)
				{
					targetRow.RowError = row.RowError;
				}
				else
				{
					DataRow dataRow = targetRow;
					dataRow.RowError = dataRow.RowError + " ]:[ " + row.RowError;
				}
				DataColumn[] columnsInError = row.GetColumnsInError();
				for (int i = 0; i < columnsInError.Length; i++)
				{
					DataColumn column = targetRow.Table.Columns[columnsInError[i].ColumnName];
					targetRow.SetColumnError(column, row.GetColumnError(columnsInError[i]));
				}
			}
			else if (!preserveChanges)
			{
				targetRow.ClearErrors();
			}
			return targetRow;
		}

		/// <summary>Commits all the changes made to this table since the last time <see cref="M:System.Data.DataTable.AcceptChanges" /> was called.</summary>
		// Token: 0x0600048F RID: 1167 RVA: 0x00013A08 File Offset: 0x00011C08
		public void AcceptChanges()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.AcceptChanges|API> {0}", this.ObjectID);
			try
			{
				DataRow[] array = new DataRow[this.Rows.Count];
				this.Rows.CopyTo(array, 0);
				this.SuspendIndexEvents();
				try
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].rowID != -1L)
						{
							array[i].AcceptChanges();
						}
					}
				}
				finally
				{
					this.RestoreIndexEvents(false);
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Creates a new instance of <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>The new expression.</returns>
		// Token: 0x06000490 RID: 1168 RVA: 0x00013AA4 File Offset: 0x00011CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual DataTable CreateInstance()
		{
			return (DataTable)Activator.CreateInstance(base.GetType(), true);
		}

		/// <summary>Clones the structure of the <see cref="T:System.Data.DataTable" />, including all <see cref="T:System.Data.DataTable" /> schemas and constraints.</summary>
		/// <returns>A new <see cref="T:System.Data.DataTable" /> with the same schema as the current <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x06000491 RID: 1169 RVA: 0x00013AB7 File Offset: 0x00011CB7
		public virtual DataTable Clone()
		{
			return this.Clone(null);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00013AC0 File Offset: 0x00011CC0
		internal DataTable Clone(DataSet cloneDS)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int>("<ds.DataTable.Clone|INFO> {0}, cloneDS={1}", this.ObjectID, (cloneDS != null) ? cloneDS.ObjectID : 0);
			DataTable result;
			try
			{
				DataTable dataTable = this.CreateInstance();
				if (dataTable.Columns.Count > 0)
				{
					dataTable.Reset();
				}
				result = this.CloneTo(dataTable, cloneDS, false);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00013B34 File Offset: 0x00011D34
		private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable)
		{
			foreach (object obj in sourceTable.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				if (targetTable.Columns[dataColumn.ColumnName] == null)
				{
					targetTable.Columns.Add(dataColumn.Clone());
				}
			}
			return targetTable;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00013BAC File Offset: 0x00011DAC
		private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap)
		{
			if (visitedMap == null)
			{
				visitedMap = new Hashtable();
			}
			if (visitedMap.Contains(sourceTable))
			{
				return (DataTable)visitedMap[sourceTable];
			}
			DataTable dataTable = ds.Tables[sourceTable.TableName, sourceTable.Namespace];
			if (dataTable != null && dataTable.Columns.Count > 0)
			{
				dataTable = this.IncrementalCloneTo(sourceTable, dataTable);
			}
			else
			{
				if (dataTable == null)
				{
					dataTable = new DataTable();
					ds.Tables.Add(dataTable);
				}
				dataTable = sourceTable.CloneTo(dataTable, ds, true);
			}
			visitedMap[sourceTable] = dataTable;
			foreach (object obj in sourceTable.ChildRelations)
			{
				DataRelation dataRelation = (DataRelation)obj;
				this.CloneHierarchy(dataRelation.ChildTable, ds, visitedMap);
			}
			return dataTable;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00013C8C File Offset: 0x00011E8C
		private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns)
		{
			clone._tableName = this._tableName;
			clone._tableNamespace = this._tableNamespace;
			clone._tablePrefix = this._tablePrefix;
			clone._fNestedInDataset = this._fNestedInDataset;
			clone._culture = this._culture;
			clone._cultureUserSet = this._cultureUserSet;
			clone._compareInfo = this._compareInfo;
			clone._compareFlags = this._compareFlags;
			clone._formatProvider = this._formatProvider;
			clone._hashCodeProvider = this._hashCodeProvider;
			clone._caseSensitive = this._caseSensitive;
			clone._caseSensitiveUserSet = this._caseSensitiveUserSet;
			clone._displayExpression = this._displayExpression;
			clone._typeName = this._typeName;
			clone._repeatableElement = this._repeatableElement;
			clone.MinimumCapacity = this.MinimumCapacity;
			clone.RemotingFormat = this.RemotingFormat;
			DataColumnCollection columns = this.Columns;
			for (int i = 0; i < columns.Count; i++)
			{
				clone.Columns.Add(columns[i].Clone());
			}
			if (!skipExpressionColumns && cloneDS == null)
			{
				for (int j = 0; j < columns.Count; j++)
				{
					clone.Columns[columns[j].ColumnName].Expression = columns[j].Expression;
				}
			}
			DataColumn[] primaryKey = this.PrimaryKey;
			if (primaryKey.Length != 0)
			{
				DataColumn[] array = new DataColumn[primaryKey.Length];
				for (int k = 0; k < primaryKey.Length; k++)
				{
					array[k] = clone.Columns[primaryKey[k].Ordinal];
				}
				clone.PrimaryKey = array;
			}
			for (int l = 0; l < this.Constraints.Count; l++)
			{
				ForeignKeyConstraint foreignKeyConstraint = this.Constraints[l] as ForeignKeyConstraint;
				UniqueConstraint uniqueConstraint = this.Constraints[l] as UniqueConstraint;
				if (foreignKeyConstraint != null)
				{
					if (foreignKeyConstraint.Table == foreignKeyConstraint.RelatedTable)
					{
						ForeignKeyConstraint constraint = foreignKeyConstraint.Clone(clone);
						Constraint constraint2 = clone.Constraints.FindConstraint(constraint);
						if (constraint2 != null)
						{
							constraint2.ConstraintName = this.Constraints[l].ConstraintName;
						}
					}
				}
				else if (uniqueConstraint != null)
				{
					UniqueConstraint uniqueConstraint2 = uniqueConstraint.Clone(clone);
					Constraint constraint3 = clone.Constraints.FindConstraint(uniqueConstraint2);
					if (constraint3 != null)
					{
						constraint3.ConstraintName = this.Constraints[l].ConstraintName;
						foreach (object key in uniqueConstraint2.ExtendedProperties.Keys)
						{
							constraint3.ExtendedProperties[key] = uniqueConstraint2.ExtendedProperties[key];
						}
					}
				}
			}
			for (int m = 0; m < this.Constraints.Count; m++)
			{
				if (!clone.Constraints.Contains(this.Constraints[m].ConstraintName, true))
				{
					ForeignKeyConstraint foreignKeyConstraint2 = this.Constraints[m] as ForeignKeyConstraint;
					UniqueConstraint uniqueConstraint3 = this.Constraints[m] as UniqueConstraint;
					if (foreignKeyConstraint2 != null)
					{
						if (foreignKeyConstraint2.Table == foreignKeyConstraint2.RelatedTable)
						{
							ForeignKeyConstraint foreignKeyConstraint3 = foreignKeyConstraint2.Clone(clone);
							if (foreignKeyConstraint3 != null)
							{
								clone.Constraints.Add(foreignKeyConstraint3);
							}
						}
					}
					else if (uniqueConstraint3 != null)
					{
						clone.Constraints.Add(uniqueConstraint3.Clone(clone));
					}
				}
			}
			if (this._extendedProperties != null)
			{
				foreach (object key2 in this._extendedProperties.Keys)
				{
					clone.ExtendedProperties[key2] = this._extendedProperties[key2];
				}
			}
			return clone;
		}

		/// <summary>Copies both the structure and data for this <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>A new <see cref="T:System.Data.DataTable" /> with the same structure (table schemas and constraints) and data as this <see cref="T:System.Data.DataTable" />.If these classes have been derived, the copy will also be of the same derived classes.
		///     <see cref="M:System.Data.DataTable.Copy" /> creates a new <see cref="T:System.Data.DataTable" /> with the same structure and data as the original <see cref="T:System.Data.DataTable" />. To copy the structure to a new <see cref="T:System.Data.DataTable" />, but not the data, use <see cref="M:System.Data.DataTable.Clone" />.</returns>
		// Token: 0x06000496 RID: 1174 RVA: 0x0001407C File Offset: 0x0001227C
		public DataTable Copy()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.Copy|API> {0}", this.ObjectID);
			DataTable result;
			try
			{
				DataTable dataTable = this.Clone();
				foreach (object obj in this.Rows)
				{
					DataRow row = (DataRow)obj;
					this.CopyRow(dataTable, row);
				}
				result = dataTable;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Occurs when a value is being changed for the specified <see cref="T:System.Data.DataColumn" /> in a <see cref="T:System.Data.DataRow" />.</summary>
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000497 RID: 1175 RVA: 0x00014118 File Offset: 0x00012318
		// (remove) Token: 0x06000498 RID: 1176 RVA: 0x00014146 File Offset: 0x00012346
		public event DataColumnChangeEventHandler ColumnChanging
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_ColumnChanging|API> {0}", this.ObjectID);
				this._onColumnChangingDelegate = (DataColumnChangeEventHandler)Delegate.Combine(this._onColumnChangingDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_ColumnChanging|API> {0}", this.ObjectID);
				this._onColumnChangingDelegate = (DataColumnChangeEventHandler)Delegate.Remove(this._onColumnChangingDelegate, value);
			}
		}

		/// <summary>Occurs after a value has been changed for the specified <see cref="T:System.Data.DataColumn" /> in a <see cref="T:System.Data.DataRow" />.</summary>
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000499 RID: 1177 RVA: 0x00014174 File Offset: 0x00012374
		// (remove) Token: 0x0600049A RID: 1178 RVA: 0x000141A2 File Offset: 0x000123A2
		public event DataColumnChangeEventHandler ColumnChanged
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_ColumnChanged|API> {0}", this.ObjectID);
				this._onColumnChangedDelegate = (DataColumnChangeEventHandler)Delegate.Combine(this._onColumnChangedDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_ColumnChanged|API> {0}", this.ObjectID);
				this._onColumnChangedDelegate = (DataColumnChangeEventHandler)Delegate.Remove(this._onColumnChangedDelegate, value);
			}
		}

		/// <summary>Occurs after the <see cref="T:System.Data.DataTable" /> is initialized.</summary>
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600049B RID: 1179 RVA: 0x000141D0 File Offset: 0x000123D0
		// (remove) Token: 0x0600049C RID: 1180 RVA: 0x000141E9 File Offset: 0x000123E9
		public event EventHandler Initialized
		{
			add
			{
				this._onInitialized = (EventHandler)Delegate.Combine(this._onInitialized, value);
			}
			remove
			{
				this._onInitialized = (EventHandler)Delegate.Remove(this._onInitialized, value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600049D RID: 1181 RVA: 0x00014202 File Offset: 0x00012402
		// (remove) Token: 0x0600049E RID: 1182 RVA: 0x00014230 File Offset: 0x00012430
		internal event PropertyChangedEventHandler PropertyChanging
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_PropertyChanging|INFO> {0}", this.ObjectID);
				this._onPropertyChangingDelegate = (PropertyChangedEventHandler)Delegate.Combine(this._onPropertyChangingDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_PropertyChanging|INFO> {0}", this.ObjectID);
				this._onPropertyChangingDelegate = (PropertyChangedEventHandler)Delegate.Remove(this._onPropertyChangingDelegate, value);
			}
		}

		/// <summary>Occurs after a <see cref="T:System.Data.DataRow" /> has been changed successfully.</summary>
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600049F RID: 1183 RVA: 0x0001425E File Offset: 0x0001245E
		// (remove) Token: 0x060004A0 RID: 1184 RVA: 0x0001428C File Offset: 0x0001248C
		public event DataRowChangeEventHandler RowChanged
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_RowChanged|API> {0}", this.ObjectID);
				this._onRowChangedDelegate = (DataRowChangeEventHandler)Delegate.Combine(this._onRowChangedDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_RowChanged|API> {0}", this.ObjectID);
				this._onRowChangedDelegate = (DataRowChangeEventHandler)Delegate.Remove(this._onRowChangedDelegate, value);
			}
		}

		/// <summary>Occurs when a <see cref="T:System.Data.DataRow" /> is changing.</summary>
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060004A1 RID: 1185 RVA: 0x000142BA File Offset: 0x000124BA
		// (remove) Token: 0x060004A2 RID: 1186 RVA: 0x000142E8 File Offset: 0x000124E8
		public event DataRowChangeEventHandler RowChanging
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_RowChanging|API> {0}", this.ObjectID);
				this._onRowChangingDelegate = (DataRowChangeEventHandler)Delegate.Combine(this._onRowChangingDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_RowChanging|API> {0}", this.ObjectID);
				this._onRowChangingDelegate = (DataRowChangeEventHandler)Delegate.Remove(this._onRowChangingDelegate, value);
			}
		}

		/// <summary>Occurs before a row in the table is about to be deleted.</summary>
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060004A3 RID: 1187 RVA: 0x00014316 File Offset: 0x00012516
		// (remove) Token: 0x060004A4 RID: 1188 RVA: 0x00014344 File Offset: 0x00012544
		public event DataRowChangeEventHandler RowDeleting
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_RowDeleting|API> {0}", this.ObjectID);
				this._onRowDeletingDelegate = (DataRowChangeEventHandler)Delegate.Combine(this._onRowDeletingDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_RowDeleting|API> {0}", this.ObjectID);
				this._onRowDeletingDelegate = (DataRowChangeEventHandler)Delegate.Remove(this._onRowDeletingDelegate, value);
			}
		}

		/// <summary>Occurs after a row in the table has been deleted.</summary>
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060004A5 RID: 1189 RVA: 0x00014372 File Offset: 0x00012572
		// (remove) Token: 0x060004A6 RID: 1190 RVA: 0x000143A0 File Offset: 0x000125A0
		public event DataRowChangeEventHandler RowDeleted
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_RowDeleted|API> {0}", this.ObjectID);
				this._onRowDeletedDelegate = (DataRowChangeEventHandler)Delegate.Combine(this._onRowDeletedDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_RowDeleted|API> {0}", this.ObjectID);
				this._onRowDeletedDelegate = (DataRowChangeEventHandler)Delegate.Remove(this._onRowDeletedDelegate, value);
			}
		}

		/// <summary>Occurs when a <see cref="T:System.Data.DataTable" /> is cleared.</summary>
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060004A7 RID: 1191 RVA: 0x000143CE File Offset: 0x000125CE
		// (remove) Token: 0x060004A8 RID: 1192 RVA: 0x000143FC File Offset: 0x000125FC
		public event DataTableClearEventHandler TableClearing
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_TableClearing|API> {0}", this.ObjectID);
				this._onTableClearingDelegate = (DataTableClearEventHandler)Delegate.Combine(this._onTableClearingDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_TableClearing|API> {0}", this.ObjectID);
				this._onTableClearingDelegate = (DataTableClearEventHandler)Delegate.Remove(this._onTableClearingDelegate, value);
			}
		}

		/// <summary>Occurs after a <see cref="T:System.Data.DataTable" /> is cleared.</summary>
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060004A9 RID: 1193 RVA: 0x0001442A File Offset: 0x0001262A
		// (remove) Token: 0x060004AA RID: 1194 RVA: 0x00014458 File Offset: 0x00012658
		public event DataTableClearEventHandler TableCleared
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.add_TableCleared|API> {0}", this.ObjectID);
				this._onTableClearedDelegate = (DataTableClearEventHandler)Delegate.Combine(this._onTableClearedDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.remove_TableCleared|API> {0}", this.ObjectID);
				this._onTableClearedDelegate = (DataTableClearEventHandler)Delegate.Remove(this._onTableClearedDelegate, value);
			}
		}

		/// <summary>Occurs when a new <see cref="T:System.Data.DataRow" /> is inserted.</summary>
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060004AB RID: 1195 RVA: 0x00014486 File Offset: 0x00012686
		// (remove) Token: 0x060004AC RID: 1196 RVA: 0x0001449F File Offset: 0x0001269F
		public event DataTableNewRowEventHandler TableNewRow
		{
			add
			{
				this._onTableNewRowDelegate = (DataTableNewRowEventHandler)Delegate.Combine(this._onTableNewRowDelegate, value);
			}
			remove
			{
				this._onTableNewRowDelegate = (DataTableNewRowEventHandler)Delegate.Remove(this._onTableNewRowDelegate, value);
			}
		}

		/// <summary>Gets or sets an <see cref="T:System.ComponentModel.ISite" /> for the <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.ISite" /> for the <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0000D288 File Offset: 0x0000B488
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x000144B8 File Offset: 0x000126B8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ISite Site
		{
			get
			{
				return base.Site;
			}
			set
			{
				ISite site = this.Site;
				if (value == null && site != null)
				{
					IContainer container = site.Container;
					if (container != null)
					{
						for (int i = 0; i < this.Columns.Count; i++)
						{
							if (this.Columns[i].Site != null)
							{
								container.Remove(this.Columns[i]);
							}
						}
					}
				}
				base.Site = value;
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00014520 File Offset: 0x00012720
		internal DataRow AddRecords(int oldRecord, int newRecord)
		{
			DataRow dataRow;
			if (oldRecord == -1 && newRecord == -1)
			{
				dataRow = this.NewRow(-1);
				this.AddRow(dataRow);
			}
			else
			{
				dataRow = this.NewEmptyRow();
				dataRow._oldRecord = oldRecord;
				dataRow._newRecord = newRecord;
				this.InsertRow(dataRow, -1L);
			}
			return dataRow;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00014565 File Offset: 0x00012765
		internal void AddRow(DataRow row)
		{
			this.AddRow(row, -1);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0001456F File Offset: 0x0001276F
		internal void AddRow(DataRow row, int proposedID)
		{
			this.InsertRow(row, proposedID, -1);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0001457A File Offset: 0x0001277A
		internal void InsertRow(DataRow row, int proposedID, int pos)
		{
			this.InsertRow(row, (long)proposedID, pos, true);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00014588 File Offset: 0x00012788
		internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent)
		{
			Exception ex = null;
			if (row == null)
			{
				throw ExceptionBuilder.ArgumentNull("row");
			}
			if (row.Table != this)
			{
				throw ExceptionBuilder.RowAlreadyInOtherCollection();
			}
			if (row.rowID != -1L)
			{
				throw ExceptionBuilder.RowAlreadyInTheCollection();
			}
			row.BeginEdit();
			int tempRecord = row._tempRecord;
			row._tempRecord = -1;
			if (proposedID == -1L)
			{
				proposedID = this._nextRowID;
			}
			bool flag;
			if (flag = (this._nextRowID <= proposedID))
			{
				this._nextRowID = checked(proposedID + 1L);
			}
			try
			{
				try
				{
					row.rowID = proposedID;
					this.SetNewRecordWorker(row, tempRecord, DataRowAction.Add, false, false, pos, fireEvent, out ex);
				}
				catch
				{
					if (flag && this._nextRowID == proposedID + 1L)
					{
						this._nextRowID = proposedID;
					}
					row.rowID = -1L;
					row._tempRecord = tempRecord;
					throw;
				}
				if (ex != null)
				{
					throw ex;
				}
				if (this.EnforceConstraints && !this._inLoad)
				{
					int count = this._columnCollection.Count;
					for (int i = 0; i < count; i++)
					{
						DataColumn dataColumn = this._columnCollection[i];
						if (dataColumn.Computed)
						{
							dataColumn.CheckColumnConstraint(row, DataRowAction.Add);
						}
					}
				}
			}
			finally
			{
				row.ResetLastChangedColumn();
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000146BC File Offset: 0x000128BC
		internal void CheckNotModifying(DataRow row)
		{
			if (row._tempRecord != -1)
			{
				row.EndEdit();
			}
		}

		/// <summary>Clears the <see cref="T:System.Data.DataTable" /> of all data.</summary>
		// Token: 0x060004B5 RID: 1205 RVA: 0x000146CD File Offset: 0x000128CD
		public void Clear()
		{
			this.Clear(true);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000146D8 File Offset: 0x000128D8
		internal void Clear(bool clearAll)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, bool>("<ds.DataTable.Clear|INFO> {0}, clearAll={1}", this.ObjectID, clearAll);
			try
			{
				this._rowDiffId = null;
				if (this._dataSet != null)
				{
					this._dataSet.OnClearFunctionCalled(this);
				}
				bool flag = this.Rows.Count != 0;
				DataTableClearEventArgs e = null;
				if (flag)
				{
					e = new DataTableClearEventArgs(this);
					this.OnTableClearing(e);
				}
				if (this._dataSet != null && this._dataSet.EnforceConstraints)
				{
					ParentForeignKeyConstraintEnumerator parentForeignKeyConstraintEnumerator = new ParentForeignKeyConstraintEnumerator(this._dataSet, this);
					while (parentForeignKeyConstraintEnumerator.GetNext())
					{
						parentForeignKeyConstraintEnumerator.GetForeignKeyConstraint().CheckCanClearParentTable(this);
					}
				}
				this._recordManager.Clear(clearAll);
				foreach (object obj in this.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					dataRow._oldRecord = -1;
					dataRow._newRecord = -1;
					dataRow._tempRecord = -1;
					dataRow.rowID = -1L;
					dataRow.RBTreeNodeId = 0;
				}
				this.Rows.ArrayClear();
				this.ResetIndexes();
				if (flag)
				{
					this.OnTableCleared(e);
				}
				foreach (object obj2 in this.Columns)
				{
					DataColumn column = (DataColumn)obj2;
					this.EvaluateDependentExpressions(column);
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00014894 File Offset: 0x00012A94
		internal void CascadeAll(DataRow row, DataRowAction action)
		{
			if (this.DataSet != null && this.DataSet._fEnableCascading)
			{
				ParentForeignKeyConstraintEnumerator parentForeignKeyConstraintEnumerator = new ParentForeignKeyConstraintEnumerator(this._dataSet, this);
				while (parentForeignKeyConstraintEnumerator.GetNext())
				{
					parentForeignKeyConstraintEnumerator.GetForeignKeyConstraint().CheckCascade(row, action);
				}
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000148DC File Offset: 0x00012ADC
		internal void CommitRow(DataRow row)
		{
			DataRowChangeEventArgs args = this.OnRowChanging(null, row, DataRowAction.Commit);
			if (!this._inDataLoad)
			{
				this.CascadeAll(row, DataRowAction.Commit);
			}
			this.SetOldRecord(row, row._newRecord);
			this.OnRowChanged(args, row, DataRowAction.Commit);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001491A File Offset: 0x00012B1A
		internal int Compare(string s1, string s2)
		{
			return this.Compare(s1, s2, null);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00014928 File Offset: 0x00012B28
		internal int Compare(string s1, string s2, CompareInfo comparer)
		{
			if (s1 == s2)
			{
				return 0;
			}
			if (s1 == null)
			{
				return -1;
			}
			if (s2 == null)
			{
				return 1;
			}
			int i = s1.Length;
			int num = s2.Length;
			while (i > 0)
			{
				if (s1[i - 1] != ' ' && s1[i - 1] != '\u3000')
				{
					IL_6C:
					while (num > 0 && (s2[num - 1] == ' ' || s2[num - 1] == '\u3000'))
					{
						num--;
					}
					return (comparer ?? this.CompareInfo).Compare(s1, 0, i, s2, 0, num, this._compareFlags);
				}
				i--;
			}
			goto IL_6C;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000149C1 File Offset: 0x00012BC1
		internal int IndexOf(string s1, string s2)
		{
			return this.CompareInfo.IndexOf(s1, s2, this._compareFlags);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000149D6 File Offset: 0x00012BD6
		internal bool IsSuffix(string s1, string s2)
		{
			return this.CompareInfo.IsSuffix(s1, s2, this._compareFlags);
		}

		/// <summary>Computes the given expression on the current rows that pass the filter criteria.</summary>
		/// <param name="expression">The expression to compute. </param>
		/// <param name="filter">The filter to limit the rows that evaluate in the expression. </param>
		/// <returns>An <see cref="T:System.Object" />, set to the result of the computation. If the expression evaluates to null, the return value will be <see cref="F:System.DBNull.Value" />.</returns>
		// Token: 0x060004BD RID: 1213 RVA: 0x000149EC File Offset: 0x00012BEC
		public object Compute(string expression, string filter)
		{
			DataRow[] rows = this.Select(filter, "", DataViewRowState.CurrentRows);
			return new DataExpression(this, expression).Evaluate(rows);
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IListSource.ContainsListCollection" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the collection is a collection of <see cref="T:System.Collections.IList" /> objects; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x000020BC File Offset: 0x000002BC
		bool IListSource.ContainsListCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00014A18 File Offset: 0x00012C18
		internal void CopyRow(DataTable table, DataRow row)
		{
			int num = -1;
			int newRecord = -1;
			if (row == null)
			{
				return;
			}
			if (row._oldRecord != -1)
			{
				num = table._recordManager.ImportRecord(row.Table, row._oldRecord);
			}
			if (row._newRecord != -1)
			{
				if (row._newRecord != row._oldRecord)
				{
					newRecord = table._recordManager.ImportRecord(row.Table, row._newRecord);
				}
				else
				{
					newRecord = num;
				}
			}
			DataRow dataRow = table.AddRecords(num, newRecord);
			if (row.HasErrors)
			{
				dataRow.RowError = row.RowError;
				DataColumn[] columnsInError = row.GetColumnsInError();
				for (int i = 0; i < columnsInError.Length; i++)
				{
					DataColumn column = dataRow.Table.Columns[columnsInError[i].ColumnName];
					dataRow.SetColumnError(column, row.GetColumnError(columnsInError[i]));
				}
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00014AE4 File Offset: 0x00012CE4
		internal void DeleteRow(DataRow row)
		{
			if (row._newRecord == -1)
			{
				throw ExceptionBuilder.RowAlreadyDeleted();
			}
			this.SetNewRecord(row, -1, DataRowAction.Delete, false, true, false);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00014B01 File Offset: 0x00012D01
		private void CheckPrimaryKey()
		{
			if (this._primaryKey == null)
			{
				throw ExceptionBuilder.TableMissingPrimaryKey();
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00014B11 File Offset: 0x00012D11
		internal DataRow FindByPrimaryKey(object[] values)
		{
			this.CheckPrimaryKey();
			return this.FindRow(this._primaryKey.Key, values);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00014B2B File Offset: 0x00012D2B
		internal DataRow FindByPrimaryKey(object value)
		{
			this.CheckPrimaryKey();
			return this.FindRow(this._primaryKey.Key, value);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00014B48 File Offset: 0x00012D48
		private DataRow FindRow(DataKey key, object[] values)
		{
			Index index = this.GetIndex(this.NewIndexDesc(key));
			Range range = index.FindRecords(values);
			if (range.IsNull)
			{
				return null;
			}
			return this._recordManager[index.GetRecord(range.Min)];
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00014B90 File Offset: 0x00012D90
		private DataRow FindRow(DataKey key, object value)
		{
			Index index = this.GetIndex(this.NewIndexDesc(key));
			Range range = index.FindRecords(value);
			if (range.IsNull)
			{
				return null;
			}
			return this._recordManager[index.GetRecord(range.Min)];
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00014BD8 File Offset: 0x00012DD8
		internal string FormatSortString(IndexField[] indexDesc)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (IndexField indexField in indexDesc)
			{
				if (0 < stringBuilder.Length)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(indexField.Column.ColumnName);
				if (indexField.IsDescending)
				{
					stringBuilder.Append(" DESC");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00014C44 File Offset: 0x00012E44
		internal void FreeRecord(ref int record)
		{
			this._recordManager.FreeRecord(ref record);
		}

		/// <summary>Gets a copy of the <see cref="T:System.Data.DataTable" /> that contains all changes made to it since it was loaded or <see cref="M:System.Data.DataTable.AcceptChanges" /> was last called.</summary>
		/// <returns>A copy of the changes from this <see cref="T:System.Data.DataTable" />, or <see langword="null" /> if no changes are found.</returns>
		// Token: 0x060004C8 RID: 1224 RVA: 0x00014C54 File Offset: 0x00012E54
		public DataTable GetChanges()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.GetChanges|API> {0}", this.ObjectID);
			DataTable result;
			try
			{
				DataTable dataTable = this.Clone();
				for (int i = 0; i < this.Rows.Count; i++)
				{
					DataRow dataRow = this.Rows[i];
					if (dataRow._oldRecord != dataRow._newRecord)
					{
						dataTable.ImportRow(dataRow);
					}
				}
				if (dataTable.Rows.Count == 0)
				{
					result = null;
				}
				else
				{
					result = dataTable;
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Gets a copy of the <see cref="T:System.Data.DataTable" /> containing all changes made to it since it was last loaded, or since <see cref="M:System.Data.DataTable.AcceptChanges" /> was called, filtered by <see cref="T:System.Data.DataRowState" />.</summary>
		/// <param name="rowStates">One of the <see cref="T:System.Data.DataRowState" /> values. </param>
		/// <returns>A filtered copy of the <see cref="T:System.Data.DataTable" /> that can have actions performed on it, and later be merged back in the <see cref="T:System.Data.DataTable" /> using <see cref="M:System.Data.DataSet.Merge(System.Data.DataSet)" />. If no rows of the desired <see cref="T:System.Data.DataRowState" /> are found, the method returns <see langword="null" />.</returns>
		// Token: 0x060004C9 RID: 1225 RVA: 0x00014CF0 File Offset: 0x00012EF0
		public DataTable GetChanges(DataRowState rowStates)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, DataRowState>("<ds.DataTable.GetChanges|API> {0}, rowStates={1}", this.ObjectID, rowStates);
			DataTable result;
			try
			{
				DataTable dataTable = this.Clone();
				for (int i = 0; i < this.Rows.Count; i++)
				{
					DataRow dataRow = this.Rows[i];
					if ((dataRow.RowState & rowStates) != (DataRowState)0)
					{
						dataTable.ImportRow(dataRow);
					}
				}
				if (dataTable.Rows.Count == 0)
				{
					result = null;
				}
				else
				{
					result = dataTable;
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Gets an array of <see cref="T:System.Data.DataRow" /> objects that contain errors.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects that have errors.</returns>
		// Token: 0x060004CA RID: 1226 RVA: 0x00014D88 File Offset: 0x00012F88
		public DataRow[] GetErrors()
		{
			List<DataRow> list = new List<DataRow>();
			for (int i = 0; i < this.Rows.Count; i++)
			{
				DataRow dataRow = this.Rows[i];
				if (dataRow.HasErrors)
				{
					list.Add(dataRow);
				}
			}
			DataRow[] array = this.NewRowArray(list.Count);
			list.CopyTo(array);
			return array;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00014DE2 File Offset: 0x00012FE2
		internal Index GetIndex(IndexField[] indexDesc)
		{
			return this.GetIndex(indexDesc, DataViewRowState.CurrentRows, null);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00014DEE File Offset: 0x00012FEE
		internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter)
		{
			return this.GetIndex(this.ParseSortString(sort), recordStates, rowFilter);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00014E00 File Offset: 0x00013000
		internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter)
		{
			this._indexesLock.EnterUpgradeableReadLock();
			try
			{
				for (int i = 0; i < this._indexes.Count; i++)
				{
					Index index = this._indexes[i];
					if (index != null && index.Equal(indexDesc, recordStates, rowFilter))
					{
						return index;
					}
				}
			}
			finally
			{
				this._indexesLock.ExitUpgradeableReadLock();
			}
			Index index2 = new Index(this, indexDesc, recordStates, rowFilter);
			index2.AddRef();
			return index2;
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IListSource.GetList" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IList" /> that can be bound to a data source from the object.</returns>
		// Token: 0x060004CE RID: 1230 RVA: 0x00014E7C File Offset: 0x0001307C
		IList IListSource.GetList()
		{
			return this.DefaultView;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00014E84 File Offset: 0x00013084
		internal List<DataViewListener> GetListeners()
		{
			return this._dataViewListeners;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00014E8C File Offset: 0x0001308C
		internal int GetSpecialHashCode(string name)
		{
			int num = 0;
			while (num < name.Length && '\u3000' > name[num])
			{
				num++;
			}
			if (name.Length == num)
			{
				if (this._hashCodeProvider == null)
				{
					this._hashCodeProvider = StringComparer.Create(this.Locale, true);
				}
				return this._hashCodeProvider.GetHashCode(name);
			}
			return 0;
		}

		/// <summary>Copies a <see cref="T:System.Data.DataRow" /> into a <see cref="T:System.Data.DataTable" />, preserving any property settings, as well as original and current values.</summary>
		/// <param name="row">The <see cref="T:System.Data.DataRow" /> to be imported. </param>
		// Token: 0x060004D1 RID: 1233 RVA: 0x00014EEC File Offset: 0x000130EC
		public void ImportRow(DataRow row)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.ImportRow|API> {0}", this.ObjectID);
			try
			{
				int num = -1;
				int num2 = -1;
				if (row != null)
				{
					if (row._oldRecord != -1)
					{
						num = this._recordManager.ImportRecord(row.Table, row._oldRecord);
					}
					if (row._newRecord != -1)
					{
						if (row.RowState != DataRowState.Unchanged)
						{
							num2 = this._recordManager.ImportRecord(row.Table, row._newRecord);
						}
						else
						{
							num2 = num;
						}
					}
					if (num != -1 || num2 != -1)
					{
						DataRow dataRow = this.AddRecords(num, num2);
						if (row.HasErrors)
						{
							dataRow.RowError = row.RowError;
							DataColumn[] columnsInError = row.GetColumnsInError();
							for (int i = 0; i < columnsInError.Length; i++)
							{
								DataColumn column = dataRow.Table.Columns[columnsInError[i].ColumnName];
								dataRow.SetColumnError(column, row.GetColumnError(columnsInError[i]));
							}
						}
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00014FF8 File Offset: 0x000131F8
		internal void InsertRow(DataRow row, long proposedID)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int>("<ds.DataTable.InsertRow|INFO> {0}, row={1}", this.ObjectID, row._objectID);
			try
			{
				if (row.Table != this)
				{
					throw ExceptionBuilder.RowAlreadyInOtherCollection();
				}
				if (row.rowID != -1L)
				{
					throw ExceptionBuilder.RowAlreadyInTheCollection();
				}
				if (row._oldRecord == -1 && row._newRecord == -1)
				{
					throw ExceptionBuilder.RowEmpty();
				}
				if (proposedID == -1L)
				{
					proposedID = this._nextRowID;
				}
				row.rowID = proposedID;
				if (this._nextRowID <= proposedID)
				{
					this._nextRowID = checked(proposedID + 1L);
				}
				DataRowChangeEventArgs args = null;
				if (row._newRecord != -1)
				{
					row._tempRecord = row._newRecord;
					row._newRecord = -1;
					try
					{
						args = this.RaiseRowChanging(null, row, DataRowAction.Add, true);
					}
					catch
					{
						row._tempRecord = -1;
						throw;
					}
					row._newRecord = row._tempRecord;
					row._tempRecord = -1;
				}
				if (row._oldRecord != -1)
				{
					this._recordManager[row._oldRecord] = row;
				}
				if (row._newRecord != -1)
				{
					this._recordManager[row._newRecord] = row;
				}
				this.Rows.ArrayAdd(row);
				if (row.RowState == DataRowState.Unchanged)
				{
					this.RecordStateChanged(row._oldRecord, DataViewRowState.None, DataViewRowState.Unchanged);
				}
				else
				{
					this.RecordStateChanged(row._oldRecord, DataViewRowState.None, row.GetRecordState(row._oldRecord), row._newRecord, DataViewRowState.None, row.GetRecordState(row._newRecord));
				}
				if (this._dependentColumns != null && this._dependentColumns.Count > 0)
				{
					this.EvaluateExpressions(row, DataRowAction.Add, null);
				}
				this.RaiseRowChanged(args, row, DataRowAction.Add);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000151BC File Offset: 0x000133BC
		private IndexField[] NewIndexDesc(DataKey key)
		{
			IndexField[] indexDesc = key.GetIndexDesc();
			IndexField[] array = new IndexField[indexDesc.Length];
			Array.Copy(indexDesc, 0, array, 0, indexDesc.Length);
			return array;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000151E7 File Offset: 0x000133E7
		internal int NewRecord()
		{
			return this.NewRecord(-1);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000151F0 File Offset: 0x000133F0
		internal int NewUninitializedRecord()
		{
			return this._recordManager.NewRecordBase();
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00015200 File Offset: 0x00013400
		internal int NewRecordFromArray(object[] value)
		{
			int count = this._columnCollection.Count;
			if (count < value.Length)
			{
				throw ExceptionBuilder.ValueArrayLength();
			}
			int num = this._recordManager.NewRecordBase();
			int result;
			try
			{
				for (int i = 0; i < value.Length; i++)
				{
					if (value[i] != null)
					{
						this._columnCollection[i][num] = value[i];
					}
					else
					{
						this._columnCollection[i].Init(num);
					}
				}
				for (int j = value.Length; j < count; j++)
				{
					this._columnCollection[j].Init(num);
				}
				result = num;
			}
			catch (Exception e) when (ADP.IsCatchableOrSecurityExceptionType(e))
			{
				this.FreeRecord(ref num);
				throw;
			}
			return result;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000152C8 File Offset: 0x000134C8
		internal int NewRecord(int sourceRecord)
		{
			int num = this._recordManager.NewRecordBase();
			int count = this._columnCollection.Count;
			if (-1 == sourceRecord)
			{
				for (int i = 0; i < count; i++)
				{
					this._columnCollection[i].Init(num);
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					this._columnCollection[j].Copy(sourceRecord, num);
				}
			}
			return num;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00015334 File Offset: 0x00013534
		internal DataRow NewEmptyRow()
		{
			this._rowBuilder._record = -1;
			DataRow dataRow = this.NewRowFromBuilder(this._rowBuilder);
			if (this._dataSet != null)
			{
				this.DataSet.OnDataRowCreated(dataRow);
			}
			return dataRow;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001536F File Offset: 0x0001356F
		private DataRow NewUninitializedRow()
		{
			return this.NewRow(this.NewUninitializedRecord());
		}

		/// <summary>Creates a new <see cref="T:System.Data.DataRow" /> with the same schema as the table.</summary>
		/// <returns>A <see cref="T:System.Data.DataRow" /> with the same schema as the <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x060004DA RID: 1242 RVA: 0x00015380 File Offset: 0x00013580
		public DataRow NewRow()
		{
			DataRow dataRow = this.NewRow(-1);
			this.NewRowCreated(dataRow);
			return dataRow;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000153A0 File Offset: 0x000135A0
		internal DataRow CreateEmptyRow()
		{
			DataRow dataRow = this.NewUninitializedRow();
			foreach (object obj in this.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				if (!XmlToDatasetMap.IsMappedColumn(dataColumn))
				{
					if (!dataColumn.AutoIncrement)
					{
						if (dataColumn.AllowDBNull)
						{
							dataRow[dataColumn] = DBNull.Value;
						}
						else if (dataColumn.DefaultValue != null)
						{
							dataRow[dataColumn] = dataColumn.DefaultValue;
						}
					}
					else
					{
						dataColumn.Init(dataRow._tempRecord);
					}
				}
			}
			return dataRow;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00015444 File Offset: 0x00013644
		private void NewRowCreated(DataRow row)
		{
			if (this._onTableNewRowDelegate != null)
			{
				DataTableNewRowEventArgs e = new DataTableNewRowEventArgs(row);
				this.OnTableNewRow(e);
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00015468 File Offset: 0x00013668
		internal DataRow NewRow(int record)
		{
			if (-1 == record)
			{
				record = this.NewRecord(-1);
			}
			this._rowBuilder._record = record;
			DataRow dataRow = this.NewRowFromBuilder(this._rowBuilder);
			this._recordManager[record] = dataRow;
			if (this._dataSet != null)
			{
				this.DataSet.OnDataRowCreated(dataRow);
			}
			return dataRow;
		}

		/// <summary>Creates a new row from an existing row.</summary>
		/// <param name="builder">A <see cref="T:System.Data.DataRowBuilder" /> object. </param>
		/// <returns>A <see cref="T:System.Data.DataRow" /> derived class.</returns>
		// Token: 0x060004DE RID: 1246 RVA: 0x000154BD File Offset: 0x000136BD
		protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataRow(builder);
		}

		/// <summary>Gets the row type.</summary>
		/// <returns>Returns the type of the <see cref="T:System.Data.DataRow" />.</returns>
		// Token: 0x060004DF RID: 1247 RVA: 0x000154C5 File Offset: 0x000136C5
		protected virtual Type GetRowType()
		{
			return typeof(DataRow);
		}

		/// <summary>Returns an array of <see cref="T:System.Data.DataRow" />.</summary>
		/// <param name="size">A <see cref="T:System.Int32" /> value that describes the size of the array.</param>
		/// <returns>The new array.</returns>
		// Token: 0x060004E0 RID: 1248 RVA: 0x000154D4 File Offset: 0x000136D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal DataRow[] NewRowArray(int size)
		{
			if (this.IsTypedDataTable)
			{
				if (size == 0)
				{
					if (this._emptyDataRowArray == null)
					{
						this._emptyDataRowArray = (DataRow[])Array.CreateInstance(this.GetRowType(), 0);
					}
					return this._emptyDataRowArray;
				}
				return (DataRow[])Array.CreateInstance(this.GetRowType(), size);
			}
			else
			{
				if (size != 0)
				{
					return new DataRow[size];
				}
				return Array.Empty<DataRow>();
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00015533 File Offset: 0x00013733
		internal bool NeedColumnChangeEvents
		{
			get
			{
				return this.IsTypedDataTable || this._onColumnChangingDelegate != null || this._onColumnChangedDelegate != null;
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.ColumnChanging" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataColumnChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x060004E2 RID: 1250 RVA: 0x00015550 File Offset: 0x00013750
		protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e)
		{
			if (this._onColumnChangingDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnColumnChanging|INFO> {0}", this.ObjectID);
				this._onColumnChangingDelegate(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.ColumnChanged" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataColumnChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x060004E3 RID: 1251 RVA: 0x0001557C File Offset: 0x0001377C
		protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e)
		{
			if (this._onColumnChangedDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnColumnChanged|INFO> {0}", this.ObjectID);
				this._onColumnChangedDelegate(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged" /> event.</summary>
		/// <param name="pcevent">A <see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> that contains the event data. </param>
		// Token: 0x060004E4 RID: 1252 RVA: 0x000155A8 File Offset: 0x000137A8
		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
			if (this._onPropertyChangingDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnPropertyChanging|INFO> {0}", this.ObjectID);
				this._onPropertyChangingDelegate(this, pcevent);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000155D4 File Offset: 0x000137D4
		internal void OnRemoveColumnInternal(DataColumn column)
		{
			this.OnRemoveColumn(column);
		}

		/// <summary>Notifies the <see cref="T:System.Data.DataTable" /> that a <see cref="T:System.Data.DataColumn" /> is being removed.</summary>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> being removed. </param>
		// Token: 0x060004E6 RID: 1254 RVA: 0x000057B2 File Offset: 0x000039B2
		protected virtual void OnRemoveColumn(DataColumn column)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000155DD File Offset: 0x000137DD
		private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			if (this._onRowChangedDelegate != null || this.IsTypedDataTable)
			{
				if (args == null)
				{
					args = new DataRowChangeEventArgs(eRow, eAction);
				}
				this.OnRowChanged(args);
			}
			return args;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00015603 File Offset: 0x00013803
		private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			if (this._onRowChangingDelegate != null || this.IsTypedDataTable)
			{
				if (args == null)
				{
					args = new DataRowChangeEventArgs(eRow, eAction);
				}
				this.OnRowChanging(args);
			}
			return args;
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.RowChanged" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x060004E9 RID: 1257 RVA: 0x00015629 File Offset: 0x00013829
		protected virtual void OnRowChanged(DataRowChangeEventArgs e)
		{
			if (this._onRowChangedDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnRowChanged|INFO> {0}", this.ObjectID);
				this._onRowChangedDelegate(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.RowChanging" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x060004EA RID: 1258 RVA: 0x00015655 File Offset: 0x00013855
		protected virtual void OnRowChanging(DataRowChangeEventArgs e)
		{
			if (this._onRowChangingDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnRowChanging|INFO> {0}", this.ObjectID);
				this._onRowChangingDelegate(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.RowDeleting" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x060004EB RID: 1259 RVA: 0x00015681 File Offset: 0x00013881
		protected virtual void OnRowDeleting(DataRowChangeEventArgs e)
		{
			if (this._onRowDeletingDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnRowDeleting|INFO> {0}", this.ObjectID);
				this._onRowDeletingDelegate(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.RowDeleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data. </param>
		// Token: 0x060004EC RID: 1260 RVA: 0x000156AD File Offset: 0x000138AD
		protected virtual void OnRowDeleted(DataRowChangeEventArgs e)
		{
			if (this._onRowDeletedDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnRowDeleted|INFO> {0}", this.ObjectID);
				this._onRowDeletedDelegate(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.TableCleared" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataTableClearEventArgs" /> that contains the event data. </param>
		// Token: 0x060004ED RID: 1261 RVA: 0x000156D9 File Offset: 0x000138D9
		protected virtual void OnTableCleared(DataTableClearEventArgs e)
		{
			if (this._onTableClearedDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnTableCleared|INFO> {0}", this.ObjectID);
				this._onTableClearedDelegate(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.TableClearing" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataTableClearEventArgs" /> that contains the event data. </param>
		// Token: 0x060004EE RID: 1262 RVA: 0x00015705 File Offset: 0x00013905
		protected virtual void OnTableClearing(DataTableClearEventArgs e)
		{
			if (this._onTableClearingDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnTableClearing|INFO> {0}", this.ObjectID);
				this._onTableClearingDelegate(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Data.DataTable.TableNewRow" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Data.DataTableNewRowEventArgs" /> that contains the event data. </param>
		// Token: 0x060004EF RID: 1263 RVA: 0x00015731 File Offset: 0x00013931
		protected virtual void OnTableNewRow(DataTableNewRowEventArgs e)
		{
			if (this._onTableNewRowDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnTableNewRow|INFO> {0}", this.ObjectID);
				this._onTableNewRowDelegate(this, e);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0001575D File Offset: 0x0001395D
		private void OnInitialized()
		{
			if (this._onInitialized != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataTable.OnInitialized|INFO> {0}", this.ObjectID);
				this._onInitialized(this, EventArgs.Empty);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00015790 File Offset: 0x00013990
		internal IndexField[] ParseSortString(string sortString)
		{
			IndexField[] array = Array.Empty<IndexField>();
			if (sortString != null && 0 < sortString.Length)
			{
				string[] array2 = sortString.Split(new char[]
				{
					','
				});
				array = new IndexField[array2.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					string text = array2[i].Trim();
					int length = text.Length;
					bool isDescending = false;
					if (length >= 5 && string.Compare(text, length - 4, " ASC", 0, 4, StringComparison.OrdinalIgnoreCase) == 0)
					{
						text = text.Substring(0, length - 4).Trim();
					}
					else if (length >= 6 && string.Compare(text, length - 5, " DESC", 0, 5, StringComparison.OrdinalIgnoreCase) == 0)
					{
						isDescending = true;
						text = text.Substring(0, length - 5).Trim();
					}
					if (text.StartsWith("[", StringComparison.Ordinal))
					{
						if (!text.EndsWith("]", StringComparison.Ordinal))
						{
							throw ExceptionBuilder.InvalidSortString(array2[i]);
						}
						text = text.Substring(1, text.Length - 2);
					}
					DataColumn dataColumn = this.Columns[text];
					if (dataColumn == null)
					{
						throw ExceptionBuilder.ColumnOutOfRange(text);
					}
					array[i] = new IndexField(dataColumn, isDescending);
				}
			}
			return array;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000158B2 File Offset: 0x00013AB2
		internal void RaisePropertyChanging(string name)
		{
			this.OnPropertyChanging(new PropertyChangedEventArgs(name));
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000158C0 File Offset: 0x00013AC0
		internal void RecordChanged(int record)
		{
			this.SetShadowIndexes();
			try
			{
				int count = this._shadowIndexes.Count;
				for (int i = 0; i < count; i++)
				{
					Index index = this._shadowIndexes[i];
					if (0 < index.RefCount)
					{
						index.RecordChanged(record);
					}
				}
			}
			finally
			{
				this.RestoreShadowIndexes();
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00015924 File Offset: 0x00013B24
		internal void RecordChanged(int[] oldIndex, int[] newIndex)
		{
			this.SetShadowIndexes();
			try
			{
				int count = this._shadowIndexes.Count;
				for (int i = 0; i < count; i++)
				{
					Index index = this._shadowIndexes[i];
					if (0 < index.RefCount)
					{
						index.RecordChanged(oldIndex[i], newIndex[i]);
					}
				}
			}
			finally
			{
				this.RestoreShadowIndexes();
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001598C File Offset: 0x00013B8C
		internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState)
		{
			this.SetShadowIndexes();
			try
			{
				int count = this._shadowIndexes.Count;
				for (int i = 0; i < count; i++)
				{
					Index index = this._shadowIndexes[i];
					if (0 < index.RefCount)
					{
						index.RecordStateChanged(record, oldState, newState);
					}
				}
			}
			finally
			{
				this.RestoreShadowIndexes();
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000159F0 File Offset: 0x00013BF0
		internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2)
		{
			this.SetShadowIndexes();
			try
			{
				int count = this._shadowIndexes.Count;
				for (int i = 0; i < count; i++)
				{
					Index index = this._shadowIndexes[i];
					if (0 < index.RefCount)
					{
						if (record1 != -1 && record2 != -1)
						{
							index.RecordStateChanged(record1, oldState1, newState1, record2, oldState2, newState2);
						}
						else if (record1 != -1)
						{
							index.RecordStateChanged(record1, oldState1, newState1);
						}
						else if (record2 != -1)
						{
							index.RecordStateChanged(record2, oldState2, newState2);
						}
					}
				}
			}
			finally
			{
				this.RestoreShadowIndexes();
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00015A84 File Offset: 0x00013C84
		internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version)
		{
			int num = this.LiveIndexes.Count;
			int[] array = new int[num];
			int recordFromVersion = row.GetRecordFromVersion(version);
			DataViewRowState recordState = row.GetRecordState(recordFromVersion);
			while (--num >= 0)
			{
				if (row.HasVersion(version) && (recordState & this._indexes[num].RecordStates) != DataViewRowState.None)
				{
					int index = this._indexes[num].GetIndex(recordFromVersion);
					if (index > -1)
					{
						array[num] = index;
						this._indexes[num].DeleteRecordFromIndex(index);
					}
					else
					{
						array[num] = -1;
					}
				}
				else
				{
					array[num] = -1;
				}
			}
			return array;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00015B1C File Offset: 0x00013D1C
		internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version)
		{
			int num = this.LiveIndexes.Count;
			int[] array = new int[num];
			int recordFromVersion = row.GetRecordFromVersion(version);
			DataViewRowState recordState = row.GetRecordState(recordFromVersion);
			while (--num >= 0)
			{
				if (row.HasVersion(version))
				{
					if ((recordState & this._indexes[num].RecordStates) != DataViewRowState.None)
					{
						array[num] = this._indexes[num].InsertRecordToIndex(recordFromVersion);
					}
					else
					{
						array[num] = -1;
					}
				}
			}
			return array;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00015B90 File Offset: 0x00013D90
		internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue)
		{
			int recordFromVersion = dr.GetRecordFromVersion(version);
			if ((DataStorage.IsTypeCustomType(dc.DataType) && newValue != dc[recordFromVersion]) || !dc.CompareValueTo(recordFromVersion, newValue, true))
			{
				int[] oldIndex = dr.Table.RemoveRecordFromIndexes(dr, version);
				dc.SetValue(recordFromVersion, newValue);
				int[] newIndex = dr.Table.InsertRecordToIndexes(dr, version);
				if (dr.HasVersion(version))
				{
					if (version != DataRowVersion.Original)
					{
						dr.Table.RecordChanged(oldIndex, newIndex);
					}
					if (dc._dependentColumns != null)
					{
						dc.Table.EvaluateDependentExpressions(dc._dependentColumns, dr, version, null);
					}
				}
			}
			dr.ResetLastChangedColumn();
		}

		/// <summary>Rolls back all changes that have been made to the table since it was loaded, or the last time <see cref="M:System.Data.DataTable.AcceptChanges" /> was called.</summary>
		// Token: 0x060004FA RID: 1274 RVA: 0x00015C38 File Offset: 0x00013E38
		public void RejectChanges()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.RejectChanges|API> {0}", this.ObjectID);
			try
			{
				DataRow[] array = new DataRow[this.Rows.Count];
				this.Rows.CopyTo(array, 0);
				for (int i = 0; i < array.Length; i++)
				{
					this.RollbackRow(array[i]);
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00015CB0 File Offset: 0x00013EB0
		internal void RemoveRow(DataRow row, bool check)
		{
			if (row.rowID == -1L)
			{
				throw ExceptionBuilder.RowAlreadyRemoved();
			}
			if (check && this._dataSet != null)
			{
				ParentForeignKeyConstraintEnumerator parentForeignKeyConstraintEnumerator = new ParentForeignKeyConstraintEnumerator(this._dataSet, this);
				while (parentForeignKeyConstraintEnumerator.GetNext())
				{
					parentForeignKeyConstraintEnumerator.GetForeignKeyConstraint().CheckCanRemoveParentRow(row);
				}
			}
			int num = row._oldRecord;
			int newRecord = row._newRecord;
			DataViewRowState recordState = row.GetRecordState(num);
			DataViewRowState recordState2 = row.GetRecordState(newRecord);
			row._oldRecord = -1;
			row._newRecord = -1;
			if (num == newRecord)
			{
				num = -1;
			}
			this.RecordStateChanged(num, recordState, DataViewRowState.None, newRecord, recordState2, DataViewRowState.None);
			this.FreeRecord(ref num);
			this.FreeRecord(ref newRecord);
			row.rowID = -1L;
			this.Rows.ArrayRemove(row);
		}

		/// <summary>Resets the <see cref="T:System.Data.DataTable" /> to its original state. Reset removes all data, indexes, relations, and columns of the table. If a DataSet includes a DataTable, the table will still be part of the DataSet after the table is reset.</summary>
		// Token: 0x060004FC RID: 1276 RVA: 0x00015D60 File Offset: 0x00013F60
		public virtual void Reset()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.Reset|API> {0}", this.ObjectID);
			try
			{
				this.Clear();
				this.ResetConstraints();
				DataRelationCollection dataRelationCollection = this.ParentRelations;
				int i = dataRelationCollection.Count;
				while (i > 0)
				{
					i--;
					dataRelationCollection.RemoveAt(i);
				}
				dataRelationCollection = this.ChildRelations;
				i = dataRelationCollection.Count;
				while (i > 0)
				{
					i--;
					dataRelationCollection.RemoveAt(i);
				}
				this.Columns.Clear();
				this._indexes.Clear();
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00015E04 File Offset: 0x00014004
		internal void ResetIndexes()
		{
			this.ResetInternalIndexes(null);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00015E10 File Offset: 0x00014010
		internal void ResetInternalIndexes(DataColumn column)
		{
			this.SetShadowIndexes();
			try
			{
				int count = this._shadowIndexes.Count;
				for (int i = 0; i < count; i++)
				{
					Index index = this._shadowIndexes[i];
					if (0 < index.RefCount)
					{
						if (column == null)
						{
							index.Reset();
						}
						else
						{
							bool flag = false;
							foreach (IndexField indexField in index._indexFields)
							{
								if (column == indexField.Column)
								{
									flag = true;
									break;
								}
							}
							if (flag)
							{
								index.Reset();
							}
						}
					}
				}
			}
			finally
			{
				this.RestoreShadowIndexes();
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00015EB4 File Offset: 0x000140B4
		internal void RollbackRow(DataRow row)
		{
			row.CancelEdit();
			this.SetNewRecord(row, row._oldRecord, DataRowAction.Rollback, false, true, false);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00015ED0 File Offset: 0x000140D0
		private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			try
			{
				if (this.UpdatingCurrent(eRow, eAction) && (this.IsTypedDataTable || this._onRowChangedDelegate != null))
				{
					args = this.OnRowChanged(args, eRow, eAction);
				}
				else if (DataRowAction.Delete == eAction && eRow._newRecord == -1 && (this.IsTypedDataTable || this._onRowDeletedDelegate != null))
				{
					if (args == null)
					{
						args = new DataRowChangeEventArgs(eRow, eAction);
					}
					this.OnRowDeleted(args);
				}
			}
			catch (Exception e) when (ADP.IsCatchableExceptionType(e))
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e);
			}
			return args;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00015F6C File Offset: 0x0001416C
		private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			if (this.UpdatingCurrent(eRow, eAction) && (this.IsTypedDataTable || this._onRowChangingDelegate != null))
			{
				eRow._inChangingEvent = true;
				try
				{
					return this.OnRowChanging(args, eRow, eAction);
				}
				finally
				{
					eRow._inChangingEvent = false;
				}
			}
			if (DataRowAction.Delete == eAction && eRow._newRecord != -1 && (this.IsTypedDataTable || this._onRowDeletingDelegate != null))
			{
				eRow._inDeletingEvent = true;
				try
				{
					if (args == null)
					{
						args = new DataRowChangeEventArgs(eRow, eAction);
					}
					this.OnRowDeleting(args);
				}
				finally
				{
					eRow._inDeletingEvent = false;
				}
			}
			return args;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00016010 File Offset: 0x00014210
		private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent)
		{
			if (this.EnforceConstraints && !this._inLoad)
			{
				int count = this._columnCollection.Count;
				for (int i = 0; i < count; i++)
				{
					DataColumn dataColumn = this._columnCollection[i];
					if (!dataColumn.Computed || eAction != DataRowAction.Add)
					{
						dataColumn.CheckColumnConstraint(eRow, eAction);
					}
				}
				int count2 = this._constraintCollection.Count;
				for (int j = 0; j < count2; j++)
				{
					this._constraintCollection[j].CheckConstraint(eRow, eAction);
				}
			}
			if (fireEvent)
			{
				args = this.RaiseRowChanging(args, eRow, eAction);
			}
			if (!this._inDataLoad && !this.MergingData && eAction != DataRowAction.Nothing && eAction != DataRowAction.ChangeOriginal)
			{
				this.CascadeAll(eRow, eAction);
			}
			return args;
		}

		/// <summary>Gets an array of all <see cref="T:System.Data.DataRow" /> objects.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects.</returns>
		// Token: 0x06000503 RID: 1283 RVA: 0x000160C7 File Offset: 0x000142C7
		public DataRow[] Select()
		{
			DataCommonEventSource.Log.Trace<int>("<ds.DataTable.Select|API> {0}", this.ObjectID);
			return new Select(this, "", "", DataViewRowState.CurrentRows).SelectRows();
		}

		/// <summary>Gets an array of all <see cref="T:System.Data.DataRow" /> objects that match the filter criteria.</summary>
		/// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects.</returns>
		// Token: 0x06000504 RID: 1284 RVA: 0x000160F5 File Offset: 0x000142F5
		public DataRow[] Select(string filterExpression)
		{
			DataCommonEventSource.Log.Trace<int, string>("<ds.DataTable.Select|API> {0}, filterExpression='{1}'", this.ObjectID, filterExpression);
			return new Select(this, filterExpression, "", DataViewRowState.CurrentRows).SelectRows();
		}

		/// <summary>Gets an array of all <see cref="T:System.Data.DataRow" /> objects that match the filter criteria, in the specified sort order.</summary>
		/// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
		/// <param name="sort">A string specifying the column and sort direction. </param>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects matching the filter expression.</returns>
		// Token: 0x06000505 RID: 1285 RVA: 0x00016120 File Offset: 0x00014320
		public DataRow[] Select(string filterExpression, string sort)
		{
			DataCommonEventSource.Log.Trace<int, string, string>("<ds.DataTable.Select|API> {0}, filterExpression='{1}', sort='{2}'", this.ObjectID, filterExpression, sort);
			return new Select(this, filterExpression, sort, DataViewRowState.CurrentRows).SelectRows();
		}

		/// <summary>Gets an array of all <see cref="T:System.Data.DataRow" /> objects that match the filter in the order of the sort that match the specified state.</summary>
		/// <param name="filterExpression">The criteria to use to filter the rows. For examples on how to filter rows, see DataView RowFilter Syntax [C#].</param>
		/// <param name="sort">A string specifying the column and sort direction. </param>
		/// <param name="recordStates">One of the <see cref="T:System.Data.DataViewRowState" /> values.</param>
		/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects.</returns>
		// Token: 0x06000506 RID: 1286 RVA: 0x00016148 File Offset: 0x00014348
		public DataRow[] Select(string filterExpression, string sort, DataViewRowState recordStates)
		{
			DataCommonEventSource.Log.Trace<int, string, string, DataViewRowState>("<ds.DataTable.Select|API> {0}, filterExpression='{1}', sort='{2}', recordStates={3}", this.ObjectID, filterExpression, sort, recordStates);
			return new Select(this, filterExpression, sort, recordStates).SelectRows();
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00016170 File Offset: 0x00014370
		internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = DataRowAction.Change, bool isInMerge = false, bool fireEvent = true, bool suppressEnsurePropertyChanged = false)
		{
			Exception ex = null;
			this.SetNewRecordWorker(row, proposedRecord, action, isInMerge, suppressEnsurePropertyChanged, -1, fireEvent, out ex);
			if (ex != null)
			{
				throw ex;
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00016198 File Offset: 0x00014398
		private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException)
		{
			deferredException = null;
			if (row._tempRecord != proposedRecord)
			{
				if (!this._inDataLoad)
				{
					row.CheckInTable();
					this.CheckNotModifying(row);
				}
				if (proposedRecord == row._newRecord)
				{
					if (isInMerge)
					{
						this.RaiseRowChanged(null, row, action);
					}
					return;
				}
				row._tempRecord = proposedRecord;
			}
			DataRowChangeEventArgs args = null;
			try
			{
				row._action = action;
				args = this.RaiseRowChanging(null, row, action, fireEvent);
			}
			catch
			{
				row._tempRecord = -1;
				throw;
			}
			finally
			{
				row._action = DataRowAction.Nothing;
			}
			row._tempRecord = -1;
			int num = row._newRecord;
			int num2 = (proposedRecord != -1) ? proposedRecord : ((row.RowState != DataRowState.Unchanged) ? row._oldRecord : -1);
			if (action == DataRowAction.Add)
			{
				if (position == -1)
				{
					this.Rows.ArrayAdd(row);
				}
				else
				{
					this.Rows.ArrayInsert(row, position);
				}
			}
			List<DataRow> list = null;
			if ((action == DataRowAction.Delete || action == DataRowAction.Change) && this._dependentColumns != null && this._dependentColumns.Count > 0)
			{
				list = new List<DataRow>();
				for (int i = 0; i < this.ParentRelations.Count; i++)
				{
					DataRelation dataRelation = this.ParentRelations[i];
					if (dataRelation.ChildTable == row.Table)
					{
						list.InsertRange(list.Count, row.GetParentRows(dataRelation));
					}
				}
				for (int j = 0; j < this.ChildRelations.Count; j++)
				{
					DataRelation dataRelation2 = this.ChildRelations[j];
					if (dataRelation2.ParentTable == row.Table)
					{
						list.InsertRange(list.Count, row.GetChildRows(dataRelation2));
					}
				}
			}
			if (!suppressEnsurePropertyChanged && !row.HasPropertyChanged && row._newRecord != proposedRecord && -1 != proposedRecord && -1 != row._newRecord)
			{
				row.LastChangedColumn = null;
				row.LastChangedColumn = null;
			}
			if (this.LiveIndexes.Count != 0)
			{
				if (-1 == num && -1 != proposedRecord && -1 != row._oldRecord && proposedRecord != row._oldRecord)
				{
					num = row._oldRecord;
				}
				DataViewRowState recordState = row.GetRecordState(num);
				DataViewRowState recordState2 = row.GetRecordState(num2);
				row._newRecord = proposedRecord;
				if (proposedRecord != -1)
				{
					this._recordManager[proposedRecord] = row;
				}
				DataViewRowState recordState3 = row.GetRecordState(num);
				DataViewRowState recordState4 = row.GetRecordState(num2);
				this.RecordStateChanged(num, recordState, recordState3, num2, recordState2, recordState4);
			}
			else
			{
				row._newRecord = proposedRecord;
				if (proposedRecord != -1)
				{
					this._recordManager[proposedRecord] = row;
				}
			}
			row.ResetLastChangedColumn();
			if (-1 != num && num != row._oldRecord && num != row._tempRecord && num != row._newRecord && row == this._recordManager[num])
			{
				this.FreeRecord(ref num);
			}
			if (row.RowState == DataRowState.Detached && row.rowID != -1L)
			{
				this.RemoveRow(row, false);
			}
			if (this._dependentColumns != null && this._dependentColumns.Count > 0)
			{
				try
				{
					this.EvaluateExpressions(row, action, list);
				}
				catch (Exception ex)
				{
					if (action != DataRowAction.Add)
					{
						throw ex;
					}
					deferredException = ex;
				}
			}
			try
			{
				if (fireEvent)
				{
					this.RaiseRowChanged(args, row, action);
				}
			}
			catch (Exception e) when (ADP.IsCatchableExceptionType(e))
			{
				ExceptionBuilder.TraceExceptionWithoutRethrow(e);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000164DC File Offset: 0x000146DC
		internal void SetOldRecord(DataRow row, int proposedRecord)
		{
			if (!this._inDataLoad)
			{
				row.CheckInTable();
				this.CheckNotModifying(row);
			}
			if (proposedRecord == row._oldRecord)
			{
				return;
			}
			int num = row._oldRecord;
			try
			{
				if (this.LiveIndexes.Count != 0)
				{
					if (-1 == num && -1 != proposedRecord && -1 != row._newRecord && proposedRecord != row._newRecord)
					{
						num = row._newRecord;
					}
					DataViewRowState recordState = row.GetRecordState(num);
					DataViewRowState recordState2 = row.GetRecordState(proposedRecord);
					row._oldRecord = proposedRecord;
					if (proposedRecord != -1)
					{
						this._recordManager[proposedRecord] = row;
					}
					DataViewRowState recordState3 = row.GetRecordState(num);
					DataViewRowState recordState4 = row.GetRecordState(proposedRecord);
					this.RecordStateChanged(num, recordState, recordState3, proposedRecord, recordState2, recordState4);
				}
				else
				{
					row._oldRecord = proposedRecord;
					if (proposedRecord != -1)
					{
						this._recordManager[proposedRecord] = row;
					}
				}
			}
			finally
			{
				if (num != -1 && num != row._tempRecord && num != row._oldRecord && num != row._newRecord)
				{
					this.FreeRecord(ref num);
				}
				if (row.RowState == DataRowState.Detached && row.rowID != -1L)
				{
					this.RemoveRow(row, false);
				}
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000165F4 File Offset: 0x000147F4
		private void RestoreShadowIndexes()
		{
			this._shadowCount--;
			if (this._shadowCount == 0)
			{
				this._shadowIndexes = null;
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00016613 File Offset: 0x00014813
		private void SetShadowIndexes()
		{
			if (this._shadowIndexes == null)
			{
				this._shadowIndexes = this.LiveIndexes;
				this._shadowCount = 1;
				return;
			}
			this._shadowCount++;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001663F File Offset: 0x0001483F
		internal void ShadowIndexCopy()
		{
			if (this._shadowIndexes == this._indexes)
			{
				this._shadowIndexes = new List<Index>(this._indexes);
			}
		}

		/// <summary>Gets the <see cref="P:System.Data.DataTable.TableName" /> and <see cref="P:System.Data.DataTable.DisplayExpression" />, if there is one as a concatenated string.</summary>
		/// <returns>A string consisting of the <see cref="P:System.Data.DataTable.TableName" /> and the <see cref="P:System.Data.DataTable.DisplayExpression" /> values.</returns>
		// Token: 0x0600050D RID: 1293 RVA: 0x00016660 File Offset: 0x00014860
		public override string ToString()
		{
			if (this._displayExpression != null)
			{
				return this.TableName + " + " + this.DisplayExpressionInternal;
			}
			return this.TableName;
		}

		/// <summary>Turns off notifications, index maintenance, and constraints while loading data.</summary>
		// Token: 0x0600050E RID: 1294 RVA: 0x00016688 File Offset: 0x00014888
		public void BeginLoadData()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.BeginLoadData|API> {0}", this.ObjectID);
			try
			{
				if (!this._inDataLoad)
				{
					this._inDataLoad = true;
					this._loadIndex = null;
					this._initialLoad = (this.Rows.Count == 0);
					if (this._initialLoad)
					{
						this.SuspendIndexEvents();
					}
					else
					{
						if (this._primaryKey != null)
						{
							this._loadIndex = this._primaryKey.Key.GetSortIndex(DataViewRowState.OriginalRows);
						}
						if (this._loadIndex != null)
						{
							this._loadIndex.AddRef();
						}
					}
					if (this.DataSet != null)
					{
						this._savedEnforceConstraints = this.DataSet.EnforceConstraints;
						this.DataSet.EnforceConstraints = false;
					}
					else
					{
						this.EnforceConstraints = false;
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Turns on notifications, index maintenance, and constraints after loading data.</summary>
		// Token: 0x0600050F RID: 1295 RVA: 0x0001676C File Offset: 0x0001496C
		public void EndLoadData()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.EndLoadData|API> {0}", this.ObjectID);
			try
			{
				if (this._inDataLoad)
				{
					if (this._loadIndex != null)
					{
						this._loadIndex.RemoveRef();
					}
					if (this._loadIndexwithOriginalAdded != null)
					{
						this._loadIndexwithOriginalAdded.RemoveRef();
					}
					if (this._loadIndexwithCurrentDeleted != null)
					{
						this._loadIndexwithCurrentDeleted.RemoveRef();
					}
					this._loadIndex = null;
					this._loadIndexwithOriginalAdded = null;
					this._loadIndexwithCurrentDeleted = null;
					this._inDataLoad = false;
					this.RestoreIndexEvents(false);
					if (this.DataSet != null)
					{
						this.DataSet.EnforceConstraints = this._savedEnforceConstraints;
					}
					else
					{
						this.EnforceConstraints = true;
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Finds and updates a specific row. If no matching row is found, a new row is created using the given values.</summary>
		/// <param name="values">An array of values used to create the new row. </param>
		/// <param name="fAcceptChanges">
		///       <see langword="true" /> to accept changes; otherwise <see langword="false" />. </param>
		/// <returns>The new <see cref="T:System.Data.DataRow" />.</returns>
		/// <exception cref="T:System.ArgumentException">The array is larger than the number of columns in the table. </exception>
		/// <exception cref="T:System.InvalidCastException">A value doesn't match its respective column type. </exception>
		/// <exception cref="T:System.Data.ConstraintException">Adding the row invalidates a constraint. </exception>
		/// <exception cref="T:System.Data.NoNullAllowedException">Attempting to put a null in a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is false. </exception>
		// Token: 0x06000510 RID: 1296 RVA: 0x0001683C File Offset: 0x00014A3C
		public DataRow LoadDataRow(object[] values, bool fAcceptChanges)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, bool>("<ds.DataTable.LoadDataRow|API> {0}, fAcceptChanges={1}", this.ObjectID, fAcceptChanges);
			DataRow result;
			try
			{
				if (this._inDataLoad)
				{
					int num = this.NewRecordFromArray(values);
					DataRow dataRow;
					if (this._loadIndex != null)
					{
						int num2 = this._loadIndex.FindRecord(num);
						if (num2 != -1)
						{
							int record = this._loadIndex.GetRecord(num2);
							dataRow = this._recordManager[record];
							dataRow.CancelEdit();
							if (dataRow.RowState == DataRowState.Deleted)
							{
								this.SetNewRecord(dataRow, dataRow._oldRecord, DataRowAction.Rollback, false, true, false);
							}
							this.SetNewRecord(dataRow, num, DataRowAction.Change, false, true, false);
							if (fAcceptChanges)
							{
								dataRow.AcceptChanges();
							}
							return dataRow;
						}
					}
					dataRow = this.NewRow(num);
					this.AddRow(dataRow);
					if (fAcceptChanges)
					{
						dataRow.AcceptChanges();
					}
					result = dataRow;
				}
				else
				{
					DataRow dataRow = this.UpdatingAdd(values);
					if (fAcceptChanges)
					{
						dataRow.AcceptChanges();
					}
					result = dataRow;
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Finds and updates a specific row. If no matching row is found, a new row is created using the given values.</summary>
		/// <param name="values">An array of values used to create the new row. </param>
		/// <param name="loadOption">Used to determine how the array values are applied to the corresponding values in an existing row. </param>
		/// <returns>The new <see cref="T:System.Data.DataRow" />.</returns>
		// Token: 0x06000511 RID: 1297 RVA: 0x00016934 File Offset: 0x00014B34
		public DataRow LoadDataRow(object[] values, LoadOption loadOption)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, LoadOption>("<ds.DataTable.LoadDataRow|API> {0}, loadOption={1}", this.ObjectID, loadOption);
			DataRow result;
			try
			{
				Index searchIndex = null;
				if (this._primaryKey != null)
				{
					if (loadOption == LoadOption.Upsert)
					{
						if (this._loadIndexwithCurrentDeleted == null)
						{
							this._loadIndexwithCurrentDeleted = this._primaryKey.Key.GetSortIndex(DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
							if (this._loadIndexwithCurrentDeleted != null)
							{
								this._loadIndexwithCurrentDeleted.AddRef();
							}
						}
						searchIndex = this._loadIndexwithCurrentDeleted;
					}
					else
					{
						if (this._loadIndexwithOriginalAdded == null)
						{
							this._loadIndexwithOriginalAdded = this._primaryKey.Key.GetSortIndex(DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedOriginal);
							if (this._loadIndexwithOriginalAdded != null)
							{
								this._loadIndexwithOriginalAdded.AddRef();
							}
						}
						searchIndex = this._loadIndexwithOriginalAdded;
					}
				}
				if (this._inDataLoad && !this.AreIndexEventsSuspended)
				{
					this.SuspendIndexEvents();
				}
				result = this.LoadRow(values, loadOption, searchIndex);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00016A24 File Offset: 0x00014C24
		internal DataRow UpdatingAdd(object[] values)
		{
			Index index = null;
			if (this._primaryKey != null)
			{
				index = this._primaryKey.Key.GetSortIndex(DataViewRowState.OriginalRows);
			}
			if (index == null)
			{
				return this.Rows.Add(values);
			}
			int num = this.NewRecordFromArray(values);
			int num2 = index.FindRecord(num);
			if (num2 != -1)
			{
				int record = index.GetRecord(num2);
				DataRow dataRow = this._recordManager[record];
				dataRow.RejectChanges();
				this.SetNewRecord(dataRow, num, DataRowAction.Change, false, true, false);
				return dataRow;
			}
			DataRow dataRow2 = this.NewRow(num);
			this.Rows.Add(dataRow2);
			return dataRow2;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00016ABC File Offset: 0x00014CBC
		internal bool UpdatingCurrent(DataRow row, DataRowAction action)
		{
			return action == DataRowAction.Add || action == DataRowAction.Change || action == DataRowAction.Rollback || action == DataRowAction.ChangeOriginal || action == DataRowAction.ChangeCurrentAndOriginal;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00016AD8 File Offset: 0x00014CD8
		internal DataColumn AddUniqueKey(int position)
		{
			if (this._colUnique != null)
			{
				return this._colUnique;
			}
			DataColumn[] primaryKey = this.PrimaryKey;
			if (primaryKey.Length == 1)
			{
				return primaryKey[0];
			}
			DataColumn dataColumn = new DataColumn(XMLSchema.GenUniqueColumnName(this.TableName + "_Id", this), typeof(int), null, MappingType.Hidden);
			dataColumn.Prefix = this._tablePrefix;
			dataColumn.AutoIncrement = true;
			dataColumn.AllowDBNull = false;
			dataColumn.Unique = true;
			if (position == -1)
			{
				this.Columns.Add(dataColumn);
			}
			else
			{
				for (int i = this.Columns.Count - 1; i >= position; i--)
				{
					this.Columns[i].SetOrdinalInternal(i + 1);
				}
				this.Columns.AddAt(position, dataColumn);
				dataColumn.SetOrdinalInternal(position);
			}
			if (primaryKey.Length == 0)
			{
				this.PrimaryKey = new DataColumn[]
				{
					dataColumn
				};
			}
			this._colUnique = dataColumn;
			return this._colUnique;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00016BC1 File Offset: 0x00014DC1
		internal DataColumn AddUniqueKey()
		{
			return this.AddUniqueKey(-1);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00016BCC File Offset: 0x00014DCC
		internal DataColumn AddForeignKey(DataColumn parentKey)
		{
			DataColumn dataColumn = new DataColumn(XMLSchema.GenUniqueColumnName(parentKey.ColumnName, this), parentKey.DataType, null, MappingType.Hidden);
			this.Columns.Add(dataColumn);
			return dataColumn;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00016C00 File Offset: 0x00014E00
		internal void UpdatePropertyDescriptorCollectionCache()
		{
			this._propertyDescriptorCollectionCache = null;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00016C0C File Offset: 0x00014E0C
		internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes)
		{
			if (this._propertyDescriptorCollectionCache == null)
			{
				int count = this.Columns.Count;
				int count2 = this.ChildRelations.Count;
				PropertyDescriptor[] array = new PropertyDescriptor[count + count2];
				for (int i = 0; i < count; i++)
				{
					array[i] = new DataColumnPropertyDescriptor(this.Columns[i]);
				}
				for (int j = 0; j < count2; j++)
				{
					array[count + j] = new DataRelationPropertyDescriptor(this.ChildRelations[j]);
				}
				this._propertyDescriptorCollectionCache = new PropertyDescriptorCollection(array);
			}
			return this._propertyDescriptorCollectionCache;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00016C9C File Offset: 0x00014E9C
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00016CB7 File Offset: 0x00014EB7
		internal XmlQualifiedName TypeName
		{
			get
			{
				if (this._typeName != null)
				{
					return (XmlQualifiedName)this._typeName;
				}
				return XmlQualifiedName.Empty;
			}
			set
			{
				this._typeName = value;
			}
		}

		/// <summary>Merge the specified <see cref="T:System.Data.DataTable" /> with the current <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="table">The <see cref="T:System.Data.DataTable" /> to be merged with the current <see cref="T:System.Data.DataTable" />.</param>
		// Token: 0x0600051B RID: 1307 RVA: 0x00016CC0 File Offset: 0x00014EC0
		public void Merge(DataTable table)
		{
			this.Merge(table, false, MissingSchemaAction.Add);
		}

		/// <summary>Merge the specified <see cref="T:System.Data.DataTable" /> with the current <see langword="DataTable" />, indicating whether to preserve changes in the current <see langword="DataTable" />.</summary>
		/// <param name="table">The <see langword="DataTable" /> to be merged with the current <see langword="DataTable" />.</param>
		/// <param name="preserveChanges">
		///       <see langword="true" />, to preserve changes in the current <see langword="DataTable" />; otherwise <see langword="false" />.<see langword="" /></param>
		// Token: 0x0600051C RID: 1308 RVA: 0x00016CCB File Offset: 0x00014ECB
		public void Merge(DataTable table, bool preserveChanges)
		{
			this.Merge(table, preserveChanges, MissingSchemaAction.Add);
		}

		/// <summary>Merge the specified <see cref="T:System.Data.DataTable" /> with the current <see langword="DataTable" />, indicating whether to preserve changes and how to handle missing schema in the current <see langword="DataTable" />.</summary>
		/// <param name="table">The <see cref="T:System.Data.DataTable" /> to be merged with the current <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="preserveChanges">
		///       <see langword="true" />, to preserve changes in the current <see cref="T:System.Data.DataTable" />; otherwise <see langword="false" />.</param>
		/// <param name="missingSchemaAction">One of the <see cref="T:System.Data.MissingSchemaAction" /> values. </param>
		// Token: 0x0600051D RID: 1309 RVA: 0x00016CD8 File Offset: 0x00014ED8
		public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int, bool, MissingSchemaAction>("<ds.DataTable.Merge|API> {0}, table={1}, preserveChanges={2}, missingSchemaAction={3}", this.ObjectID, (table != null) ? table.ObjectID : 0, preserveChanges, missingSchemaAction);
			try
			{
				if (table == null)
				{
					throw ExceptionBuilder.ArgumentNull("table");
				}
				if (missingSchemaAction - MissingSchemaAction.Add > 3)
				{
					throw ADP.InvalidMissingSchemaAction(missingSchemaAction);
				}
				new Merger(this, preserveChanges, missingSchemaAction).MergeTable(table);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Fills a <see cref="T:System.Data.DataTable" /> with values from a data source using the supplied <see cref="T:System.Data.IDataReader" />. If the <see cref="T:System.Data.DataTable" /> already contains rows, the incoming data from the data source is merged with the existing rows.</summary>
		/// <param name="reader">An <see cref="T:System.Data.IDataReader" /> that provides a result set.</param>
		// Token: 0x0600051E RID: 1310 RVA: 0x00016D50 File Offset: 0x00014F50
		public void Load(IDataReader reader)
		{
			this.Load(reader, LoadOption.PreserveChanges, null);
		}

		/// <summary>Fills a <see cref="T:System.Data.DataTable" /> with values from a data source using the supplied <see cref="T:System.Data.IDataReader" />. If the <see langword="DataTable" /> already contains rows, the incoming data from the data source is merged with the existing rows according to the value of the <paramref name="loadOption" /> parameter.</summary>
		/// <param name="reader">An <see cref="T:System.Data.IDataReader" /> that provides one or more result sets.</param>
		/// <param name="loadOption">A value from the <see cref="T:System.Data.LoadOption" /> enumeration that indicates how rows already in the <see cref="T:System.Data.DataTable" /> are combined with incoming rows that share the same primary key. </param>
		// Token: 0x0600051F RID: 1311 RVA: 0x00016D5B File Offset: 0x00014F5B
		public void Load(IDataReader reader, LoadOption loadOption)
		{
			this.Load(reader, loadOption, null);
		}

		/// <summary>Fills a <see cref="T:System.Data.DataTable" /> with values from a data source using the supplied <see cref="T:System.Data.IDataReader" /> using an error-handling delegate.</summary>
		/// <param name="reader">A <see cref="T:System.Data.IDataReader" /> that provides a result set.</param>
		/// <param name="loadOption">A value from the <see cref="T:System.Data.LoadOption" /> enumeration that indicates how rows already in the <see cref="T:System.Data.DataTable" /> are combined with incoming rows that share the same primary key. </param>
		/// <param name="errorHandler">A <see cref="T:System.Data.FillErrorEventHandler" /> delegate to call when an error occurs while loading data.</param>
		// Token: 0x06000520 RID: 1312 RVA: 0x00016D68 File Offset: 0x00014F68
		public virtual void Load(IDataReader reader, LoadOption loadOption, FillErrorEventHandler errorHandler)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, LoadOption>("<ds.DataTable.Load|API> {0}, loadOption={1}", this.ObjectID, loadOption);
			try
			{
				if (this.PrimaryKey.Length == 0)
				{
					DataTableReader dataTableReader = reader as DataTableReader;
					if (dataTableReader != null && dataTableReader.CurrentDataTable == this)
					{
						return;
					}
				}
				LoadAdapter loadAdapter = new LoadAdapter();
				loadAdapter.FillLoadOption = loadOption;
				loadAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				if (errorHandler != null)
				{
					loadAdapter.FillError += errorHandler;
				}
				loadAdapter.FillFromReader(new DataTable[]
				{
					this
				}, reader, 0, 0);
				if (!reader.IsClosed && !reader.NextResult())
				{
					reader.Close();
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00016E10 File Offset: 0x00015010
		private DataRow LoadRow(object[] values, LoadOption loadOption, Index searchIndex)
		{
			DataRow dataRow = null;
			int num2;
			if (searchIndex != null)
			{
				int[] array = Array.Empty<int>();
				if (this._primaryKey != null)
				{
					array = new int[this._primaryKey.ColumnsReference.Length];
					for (int i = 0; i < this._primaryKey.ColumnsReference.Length; i++)
					{
						array[i] = this._primaryKey.ColumnsReference[i].Ordinal;
					}
				}
				object[] array2 = new object[array.Length];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = values[array[j]];
				}
				Range range = searchIndex.FindRecords(array2);
				if (!range.IsNull)
				{
					int num = 0;
					for (int k = range.Min; k <= range.Max; k++)
					{
						int record = searchIndex.GetRecord(k);
						dataRow = this._recordManager[record];
						num2 = this.NewRecordFromArray(values);
						for (int l = 0; l < values.Length; l++)
						{
							if (values[l] == null)
							{
								this._columnCollection[l].Copy(record, num2);
							}
						}
						for (int m = values.Length; m < this._columnCollection.Count; m++)
						{
							this._columnCollection[m].Copy(record, num2);
						}
						if (loadOption != LoadOption.Upsert || dataRow.RowState != DataRowState.Deleted)
						{
							this.SetDataRowWithLoadOption(dataRow, num2, loadOption, true);
						}
						else
						{
							num++;
						}
					}
					if (num == 0)
					{
						return dataRow;
					}
				}
			}
			num2 = this.NewRecordFromArray(values);
			dataRow = this.NewRow(num2);
			DataRowAction eAction;
			if (loadOption - LoadOption.OverwriteChanges > 1)
			{
				if (loadOption != LoadOption.Upsert)
				{
					throw ExceptionBuilder.ArgumentOutOfRange("LoadOption");
				}
				eAction = DataRowAction.Add;
			}
			else
			{
				eAction = DataRowAction.ChangeCurrentAndOriginal;
			}
			DataRowChangeEventArgs args = this.RaiseRowChanging(null, dataRow, eAction);
			this.InsertRow(dataRow, -1L, -1, false);
			if (loadOption - LoadOption.OverwriteChanges > 1)
			{
				if (loadOption != LoadOption.Upsert)
				{
					throw ExceptionBuilder.ArgumentOutOfRange("LoadOption");
				}
			}
			else
			{
				this.SetOldRecord(dataRow, num2);
			}
			this.RaiseRowChanged(args, dataRow, eAction);
			return dataRow;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00016FF8 File Offset: 0x000151F8
		private void SetDataRowWithLoadOption(DataRow dataRow, int recordNo, LoadOption loadOption, bool checkReadOnly)
		{
			bool flag = false;
			if (checkReadOnly)
			{
				foreach (object obj in this.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (dataColumn.ReadOnly && !dataColumn.Computed)
					{
						switch (loadOption)
						{
						case LoadOption.OverwriteChanges:
							if (dataRow[dataColumn, DataRowVersion.Current] != dataColumn[recordNo] || dataRow[dataColumn, DataRowVersion.Original] != dataColumn[recordNo])
							{
								flag = true;
							}
							break;
						case LoadOption.PreserveChanges:
							if (dataRow[dataColumn, DataRowVersion.Original] != dataColumn[recordNo])
							{
								flag = true;
							}
							break;
						case LoadOption.Upsert:
							if (dataRow[dataColumn, DataRowVersion.Current] != dataColumn[recordNo])
							{
								flag = true;
							}
							break;
						}
					}
				}
			}
			DataRowChangeEventArgs args = null;
			DataRowAction dataRowAction = DataRowAction.Nothing;
			int tempRecord = dataRow._tempRecord;
			dataRow._tempRecord = recordNo;
			switch (loadOption)
			{
			case LoadOption.OverwriteChanges:
				dataRowAction = DataRowAction.ChangeCurrentAndOriginal;
				break;
			case LoadOption.PreserveChanges:
				if (dataRow.RowState == DataRowState.Unchanged)
				{
					dataRowAction = DataRowAction.ChangeCurrentAndOriginal;
				}
				else
				{
					dataRowAction = DataRowAction.ChangeOriginal;
				}
				break;
			case LoadOption.Upsert:
			{
				DataRowState rowState = dataRow.RowState;
				if (rowState != DataRowState.Unchanged)
				{
					if (rowState == DataRowState.Deleted)
					{
						break;
					}
				}
				else
				{
					using (IEnumerator enumerator = dataRow.Table.Columns.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							DataColumn dataColumn2 = (DataColumn)obj2;
							if (dataColumn2.Compare(dataRow._newRecord, recordNo) != 0)
							{
								dataRowAction = DataRowAction.Change;
								break;
							}
						}
						break;
					}
				}
				dataRowAction = DataRowAction.Change;
				break;
			}
			default:
				throw ExceptionBuilder.ArgumentOutOfRange("LoadOption");
			}
			try
			{
				args = this.RaiseRowChanging(null, dataRow, dataRowAction);
				if (dataRowAction == DataRowAction.Nothing)
				{
					dataRow._inChangingEvent = true;
					try
					{
						args = this.OnRowChanging(args, dataRow, dataRowAction);
					}
					finally
					{
						dataRow._inChangingEvent = false;
					}
				}
			}
			finally
			{
				if (DataRowState.Detached == dataRow.RowState)
				{
					if (-1 != tempRecord)
					{
						this.FreeRecord(ref tempRecord);
					}
				}
				else if (dataRow._tempRecord != recordNo)
				{
					if (-1 != tempRecord)
					{
						this.FreeRecord(ref tempRecord);
					}
					if (-1 != recordNo)
					{
						this.FreeRecord(ref recordNo);
					}
					recordNo = dataRow._tempRecord;
				}
				else
				{
					dataRow._tempRecord = tempRecord;
				}
			}
			if (dataRow._tempRecord != -1)
			{
				dataRow.CancelEdit();
			}
			switch (loadOption)
			{
			case LoadOption.OverwriteChanges:
				this.SetNewRecord(dataRow, recordNo, DataRowAction.Change, false, false, false);
				this.SetOldRecord(dataRow, recordNo);
				break;
			case LoadOption.PreserveChanges:
				if (dataRow.RowState == DataRowState.Unchanged)
				{
					this.SetOldRecord(dataRow, recordNo);
					this.SetNewRecord(dataRow, recordNo, DataRowAction.Change, false, false, false);
				}
				else
				{
					this.SetOldRecord(dataRow, recordNo);
				}
				break;
			case LoadOption.Upsert:
				if (dataRow.RowState == DataRowState.Unchanged)
				{
					this.SetNewRecord(dataRow, recordNo, DataRowAction.Change, false, false, false);
					if (!dataRow.HasChanges())
					{
						this.SetOldRecord(dataRow, recordNo);
					}
				}
				else
				{
					if (dataRow.RowState == DataRowState.Deleted)
					{
						dataRow.RejectChanges();
					}
					this.SetNewRecord(dataRow, recordNo, DataRowAction.Change, false, false, false);
				}
				break;
			default:
				throw ExceptionBuilder.ArgumentOutOfRange("LoadOption");
			}
			if (flag)
			{
				string text = "ReadOnly Data is Modified.";
				if (dataRow.RowError.Length == 0)
				{
					dataRow.RowError = text;
				}
				else
				{
					dataRow.RowError = dataRow.RowError + " ]:[ " + text;
				}
				foreach (object obj3 in this.Columns)
				{
					DataColumn dataColumn3 = (DataColumn)obj3;
					if (dataColumn3.ReadOnly && !dataColumn3.Computed)
					{
						dataRow.SetColumnError(dataColumn3, text);
					}
				}
			}
			args = this.RaiseRowChanged(args, dataRow, dataRowAction);
			if (dataRowAction == DataRowAction.Nothing)
			{
				dataRow._inChangingEvent = true;
				try
				{
					this.OnRowChanged(args, dataRow, dataRowAction);
				}
				finally
				{
					dataRow._inChangingEvent = false;
				}
			}
		}

		/// <summary>Returns a <see cref="T:System.Data.DataTableReader" /> corresponding to the data within this <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataTableReader" /> containing one result set, corresponding to the source <see cref="T:System.Data.DataTable" /> instance.</returns>
		// Token: 0x06000523 RID: 1315 RVA: 0x000173D8 File Offset: 0x000155D8
		public DataTableReader CreateDataReader()
		{
			return new DataTableReader(this);
		}

		/// <summary>Writes the current contents of the <see cref="T:System.Data.DataTable" /> as XML using the specified <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="stream">The stream to which the data will be written. </param>
		// Token: 0x06000524 RID: 1316 RVA: 0x000173E0 File Offset: 0x000155E0
		public void WriteXml(Stream stream)
		{
			this.WriteXml(stream, XmlWriteMode.IgnoreSchema, false);
		}

		/// <summary>Writes the current contents of the <see cref="T:System.Data.DataTable" /> as XML using the specified <see cref="T:System.IO.Stream" />. To save the data for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="stream">The stream to which the data will be written. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
		// Token: 0x06000525 RID: 1317 RVA: 0x000173EB File Offset: 0x000155EB
		public void WriteXml(Stream stream, bool writeHierarchy)
		{
			this.WriteXml(stream, XmlWriteMode.IgnoreSchema, writeHierarchy);
		}

		/// <summary>Writes the current contents of the <see cref="T:System.Data.DataTable" /> as XML using the specified <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> with which to write the content. </param>
		// Token: 0x06000526 RID: 1318 RVA: 0x000173F6 File Offset: 0x000155F6
		public void WriteXml(TextWriter writer)
		{
			this.WriteXml(writer, XmlWriteMode.IgnoreSchema, false);
		}

		/// <summary>Writes the current contents of the <see cref="T:System.Data.DataTable" /> as XML using the specified <see cref="T:System.IO.TextWriter" />. To save the data for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> with which to write the content. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
		// Token: 0x06000527 RID: 1319 RVA: 0x00017401 File Offset: 0x00015601
		public void WriteXml(TextWriter writer, bool writeHierarchy)
		{
			this.WriteXml(writer, XmlWriteMode.IgnoreSchema, writeHierarchy);
		}

		/// <summary>Writes the current contents of the <see cref="T:System.Data.DataTable" /> as XML using the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> with which to write the contents. </param>
		// Token: 0x06000528 RID: 1320 RVA: 0x0001740C File Offset: 0x0001560C
		public void WriteXml(XmlWriter writer)
		{
			this.WriteXml(writer, XmlWriteMode.IgnoreSchema, false);
		}

		/// <summary>Writes the current contents of the <see cref="T:System.Data.DataTable" /> as XML using the specified <see cref="T:System.Xml.XmlWriter" />. </summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> with which to write the contents. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
		// Token: 0x06000529 RID: 1321 RVA: 0x00017417 File Offset: 0x00015617
		public void WriteXml(XmlWriter writer, bool writeHierarchy)
		{
			this.WriteXml(writer, XmlWriteMode.IgnoreSchema, writeHierarchy);
		}

		/// <summary>Writes the current contents of the <see cref="T:System.Data.DataTable" /> as XML using the specified file.</summary>
		/// <param name="fileName">The file to which to write the XML data.</param>
		// Token: 0x0600052A RID: 1322 RVA: 0x00017422 File Offset: 0x00015622
		public void WriteXml(string fileName)
		{
			this.WriteXml(fileName, XmlWriteMode.IgnoreSchema, false);
		}

		/// <summary>Writes the current contents of the <see cref="T:System.Data.DataTable" /> as XML using the specified file. To save the data for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="fileName">The file to which to write the XML data.</param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
		// Token: 0x0600052B RID: 1323 RVA: 0x0001742D File Offset: 0x0001562D
		public void WriteXml(string fileName, bool writeHierarchy)
		{
			this.WriteXml(fileName, XmlWriteMode.IgnoreSchema, writeHierarchy);
		}

		/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> to the specified file using the specified <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />.</summary>
		/// <param name="stream">The stream to which the data will be written. </param>
		/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values.</param>
		// Token: 0x0600052C RID: 1324 RVA: 0x00017438 File Offset: 0x00015638
		public void WriteXml(Stream stream, XmlWriteMode mode)
		{
			this.WriteXml(stream, mode, false);
		}

		/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> to the specified file using the specified <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />. To save the data for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="stream">The stream to which the data will be written. </param>
		/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
		// Token: 0x0600052D RID: 1325 RVA: 0x00017444 File Offset: 0x00015644
		public void WriteXml(Stream stream, XmlWriteMode mode, bool writeHierarchy)
		{
			if (stream != null)
			{
				this.WriteXml(new XmlTextWriter(stream, null)
				{
					Formatting = Formatting.Indented
				}, mode, writeHierarchy);
			}
		}

		/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.IO.TextWriter" /> and <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> used to write the document. </param>
		/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values. </param>
		// Token: 0x0600052E RID: 1326 RVA: 0x0001746C File Offset: 0x0001566C
		public void WriteXml(TextWriter writer, XmlWriteMode mode)
		{
			this.WriteXml(writer, mode, false);
		}

		/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.IO.TextWriter" /> and <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />. To save the data for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> used to write the document. </param>
		/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
		// Token: 0x0600052F RID: 1327 RVA: 0x00017478 File Offset: 0x00015678
		public void WriteXml(TextWriter writer, XmlWriteMode mode, bool writeHierarchy)
		{
			if (writer != null)
			{
				this.WriteXml(new XmlTextWriter(writer)
				{
					Formatting = Formatting.Indented
				}, mode, writeHierarchy);
			}
		}

		/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.Xml.XmlWriter" /> and <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> used to write the document. </param>
		/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values. </param>
		// Token: 0x06000530 RID: 1328 RVA: 0x0001749F File Offset: 0x0001569F
		public void WriteXml(XmlWriter writer, XmlWriteMode mode)
		{
			this.WriteXml(writer, mode, false);
		}

		/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.Xml.XmlWriter" /> and <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />. To save the data for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> used to write the document. </param>
		/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
		// Token: 0x06000531 RID: 1329 RVA: 0x000174AC File Offset: 0x000156AC
		public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, XmlWriteMode>("<ds.DataTable.WriteXml|API> {0}, mode={1}", this.ObjectID, mode);
			try
			{
				if (this._tableName.Length == 0)
				{
					throw ExceptionBuilder.CanNotSerializeDataTableWithEmptyName();
				}
				if (writer != null)
				{
					if (mode == XmlWriteMode.DiffGram)
					{
						new NewDiffgramGen(this, writeHierarchy).Save(writer, this);
					}
					else if (mode == XmlWriteMode.WriteSchema)
					{
						DataSet dataSet = null;
						string tableNamespace = this._tableNamespace;
						if (this.DataSet == null)
						{
							dataSet = new DataSet();
							dataSet.SetLocaleValue(this._culture, this._cultureUserSet);
							dataSet.CaseSensitive = this.CaseSensitive;
							dataSet.Namespace = this.Namespace;
							dataSet.RemotingFormat = this.RemotingFormat;
							dataSet.Tables.Add(this);
						}
						if (writer != null)
						{
							new XmlDataTreeWriter(this, writeHierarchy).Save(writer, true);
						}
						if (dataSet != null)
						{
							dataSet.Tables.Remove(this);
							this._tableNamespace = tableNamespace;
						}
					}
					else
					{
						new XmlDataTreeWriter(this, writeHierarchy).Save(writer, false);
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> using the specified file and <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />.</summary>
		/// <param name="fileName">The name of the file to which the data will be written. </param>
		/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values. </param>
		// Token: 0x06000532 RID: 1330 RVA: 0x000175B4 File Offset: 0x000157B4
		public void WriteXml(string fileName, XmlWriteMode mode)
		{
			this.WriteXml(fileName, mode, false);
		}

		/// <summary>Writes the current data, and optionally the schema, for the <see cref="T:System.Data.DataTable" /> using the specified file and <see cref="T:System.Data.XmlWriteMode" />. To write the schema, set the value for the <paramref name="mode" /> parameter to <see langword="WriteSchema" />. To save the data for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="fileName">The name of the file to which the data will be written. </param>
		/// <param name="mode">One of the <see cref="T:System.Data.XmlWriteMode" /> values. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the contents of the current table and all its descendants. If <see langword="false" /> (the default value), write the data for the current table only.</param>
		// Token: 0x06000533 RID: 1331 RVA: 0x000175C0 File Offset: 0x000157C0
		public void WriteXml(string fileName, XmlWriteMode mode, bool writeHierarchy)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, string, XmlWriteMode>("<ds.DataTable.WriteXml|API> {0}, fileName='{1}', mode={2}", this.ObjectID, fileName, mode);
			try
			{
				using (XmlTextWriter xmlTextWriter = new XmlTextWriter(fileName, null))
				{
					xmlTextWriter.Formatting = Formatting.Indented;
					xmlTextWriter.WriteStartDocument(true);
					this.WriteXml(xmlTextWriter, mode, writeHierarchy);
					xmlTextWriter.WriteEndDocument();
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema to the specified stream.</summary>
		/// <param name="stream">The stream to which the XML schema will be written. </param>
		// Token: 0x06000534 RID: 1332 RVA: 0x00017640 File Offset: 0x00015840
		public void WriteXmlSchema(Stream stream)
		{
			this.WriteXmlSchema(stream, false);
		}

		/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema to the specified stream. To save the schema for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="stream">The stream to which the XML schema will be written. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the schema of the current table and all its descendants. If <see langword="false" /> (the default value), write the schema for the current table only.</param>
		// Token: 0x06000535 RID: 1333 RVA: 0x0001764C File Offset: 0x0001584C
		public void WriteXmlSchema(Stream stream, bool writeHierarchy)
		{
			if (stream == null)
			{
				return;
			}
			this.WriteXmlSchema(new XmlTextWriter(stream, null)
			{
				Formatting = Formatting.Indented
			}, writeHierarchy);
		}

		/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema using the specified <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> with which to write. </param>
		// Token: 0x06000536 RID: 1334 RVA: 0x00017674 File Offset: 0x00015874
		public void WriteXmlSchema(TextWriter writer)
		{
			this.WriteXmlSchema(writer, false);
		}

		/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema using the specified <see cref="T:System.IO.TextWriter" />. To save the schema for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> with which to write. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the schema of the current table and all its descendants. If <see langword="false" /> (the default value), write the schema for the current table only.</param>
		// Token: 0x06000537 RID: 1335 RVA: 0x00017680 File Offset: 0x00015880
		public void WriteXmlSchema(TextWriter writer, bool writeHierarchy)
		{
			if (writer == null)
			{
				return;
			}
			this.WriteXmlSchema(new XmlTextWriter(writer)
			{
				Formatting = Formatting.Indented
			}, writeHierarchy);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000176A8 File Offset: 0x000158A8
		private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy)
		{
			List<DataTable> list = new List<DataTable>();
			list.Add(dt);
			if (writeHierarchy)
			{
				this.CreateTableList(dt, list);
			}
			return this.CheckForClosureOnExpressionTables(list);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000176D4 File Offset: 0x000158D4
		private bool CheckForClosureOnExpressionTables(List<DataTable> tableList)
		{
			foreach (DataTable dataTable in tableList)
			{
				foreach (object obj in dataTable.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (dataColumn.Expression.Length != 0)
					{
						DataColumn[] dependency = dataColumn.DataExpression.GetDependency();
						for (int i = 0; i < dependency.Length; i++)
						{
							if (!tableList.Contains(dependency[i].Table))
							{
								return false;
							}
						}
					}
				}
			}
			return true;
		}

		/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema using the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to use. </param>
		// Token: 0x0600053A RID: 1338 RVA: 0x000177A8 File Offset: 0x000159A8
		public void WriteXmlSchema(XmlWriter writer)
		{
			this.WriteXmlSchema(writer, false);
		}

		/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema using the specified <see cref="T:System.Xml.XmlWriter" />. To save the schema for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> used to write the document. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the schema of the current table and all its descendants. If <see langword="false" /> (the default value), write the schema for the current table only.</param>
		// Token: 0x0600053B RID: 1339 RVA: 0x000177B4 File Offset: 0x000159B4
		public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataTable.WriteXmlSchema|API> {0}", this.ObjectID);
			try
			{
				if (this._tableName.Length == 0)
				{
					throw ExceptionBuilder.CanNotSerializeDataTableWithEmptyName();
				}
				if (!this.CheckForClosureOnExpressions(this, writeHierarchy))
				{
					throw ExceptionBuilder.CanNotSerializeDataTableHierarchy();
				}
				DataSet dataSet = null;
				string tableNamespace = this._tableNamespace;
				if (this.DataSet == null)
				{
					dataSet = new DataSet();
					dataSet.SetLocaleValue(this._culture, this._cultureUserSet);
					dataSet.CaseSensitive = this.CaseSensitive;
					dataSet.Namespace = this.Namespace;
					dataSet.RemotingFormat = this.RemotingFormat;
					dataSet.Tables.Add(this);
				}
				if (writer != null)
				{
					new XmlTreeGen(SchemaFormat.Public).Save(null, this, writer, writeHierarchy);
				}
				if (dataSet != null)
				{
					dataSet.Tables.Remove(this);
					this._tableNamespace = tableNamespace;
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema to the specified file.</summary>
		/// <param name="fileName">The name of the file to use. </param>
		// Token: 0x0600053C RID: 1340 RVA: 0x0001789C File Offset: 0x00015A9C
		public void WriteXmlSchema(string fileName)
		{
			this.WriteXmlSchema(fileName, false);
		}

		/// <summary>Writes the current data structure of the <see cref="T:System.Data.DataTable" /> as an XML schema to the specified file. To save the schema for the table and all its descendants, set the <paramref name="writeHierarchy" /> parameter to <see langword="true" />.</summary>
		/// <param name="fileName">The name of the file to use. </param>
		/// <param name="writeHierarchy">If <see langword="true" />, write the schema of the current table and all its descendants. If <see langword="false" /> (the default value), write the schema for the current table only.</param>
		// Token: 0x0600053D RID: 1341 RVA: 0x000178A8 File Offset: 0x00015AA8
		public void WriteXmlSchema(string fileName, bool writeHierarchy)
		{
			XmlTextWriter xmlTextWriter = new XmlTextWriter(fileName, null);
			try
			{
				xmlTextWriter.Formatting = Formatting.Indented;
				xmlTextWriter.WriteStartDocument(true);
				this.WriteXmlSchema(xmlTextWriter, writeHierarchy);
				xmlTextWriter.WriteEndDocument();
			}
			finally
			{
				xmlTextWriter.Close();
			}
		}

		/// <summary>Reads XML schema and data into the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="stream">An object that derives from <see cref="T:System.IO.Stream" /></param>
		/// <returns>The <see cref="T:System.Data.XmlReadMode" /> used to read the data.</returns>
		// Token: 0x0600053E RID: 1342 RVA: 0x000178F4 File Offset: 0x00015AF4
		public XmlReadMode ReadXml(Stream stream)
		{
			if (stream == null)
			{
				return XmlReadMode.Auto;
			}
			return this.ReadXml(new XmlTextReader(stream)
			{
				XmlResolver = null
			}, false);
		}

		/// <summary>Reads XML schema and data into the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="reader">The <see cref="T:System.IO.TextReader" /> that will be used to read the data.</param>
		/// <returns>The <see cref="T:System.Data.XmlReadMode" /> used to read the data.</returns>
		// Token: 0x0600053F RID: 1343 RVA: 0x0001791C File Offset: 0x00015B1C
		public XmlReadMode ReadXml(TextReader reader)
		{
			if (reader == null)
			{
				return XmlReadMode.Auto;
			}
			return this.ReadXml(new XmlTextReader(reader)
			{
				XmlResolver = null
			}, false);
		}

		/// <summary>Reads XML schema and data into the <see cref="T:System.Data.DataTable" /> from the specified file.</summary>
		/// <param name="fileName">The name of the file from which to read the data. </param>
		/// <returns>The <see cref="T:System.Data.XmlReadMode" /> used to read the data.</returns>
		// Token: 0x06000540 RID: 1344 RVA: 0x00017944 File Offset: 0x00015B44
		public XmlReadMode ReadXml(string fileName)
		{
			XmlTextReader xmlTextReader = new XmlTextReader(fileName);
			xmlTextReader.XmlResolver = null;
			XmlReadMode result;
			try
			{
				result = this.ReadXml(xmlTextReader, false);
			}
			finally
			{
				xmlTextReader.Close();
			}
			return result;
		}

		/// <summary>Reads XML Schema and Data into the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.Xml.XmlReader" />. </summary>
		/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> that will be used to read the data. </param>
		/// <returns>The <see cref="T:System.Data.XmlReadMode" /> used to read the data.</returns>
		// Token: 0x06000541 RID: 1345 RVA: 0x00017984 File Offset: 0x00015B84
		public XmlReadMode ReadXml(XmlReader reader)
		{
			return this.ReadXml(reader, false);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001798E File Offset: 0x00015B8E
		private void RestoreConstraint(bool originalEnforceConstraint)
		{
			if (this.DataSet != null)
			{
				this.DataSet.EnforceConstraints = originalEnforceConstraint;
				return;
			}
			this.EnforceConstraints = originalEnforceConstraint;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000179AC File Offset: 0x00015BAC
		private bool IsEmptyXml(XmlReader reader)
		{
			if (reader.IsEmptyElement)
			{
				if (reader.AttributeCount == 0 || (reader.LocalName == "diffgram" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-diffgram-v1"))
				{
					return true;
				}
				if (reader.AttributeCount == 1)
				{
					reader.MoveToAttribute(0);
					if (this.Namespace == reader.Value && this.Prefix == reader.LocalName && reader.Prefix == "xmlns" && reader.NamespaceURI == "http://www.w3.org/2000/xmlns/")
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00017A50 File Offset: 0x00015C50
		internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, bool>("<ds.DataTable.ReadXml|INFO> {0}, denyResolving={1}", this.ObjectID, denyResolving);
			XmlReadMode result;
			try
			{
				DataTable.RowDiffIdUsageSection rowDiffIdUsageSection = default(DataTable.RowDiffIdUsageSection);
				try
				{
					bool flag = false;
					bool flag2 = false;
					bool isXdr = false;
					XmlReadMode xmlReadMode = XmlReadMode.Auto;
					rowDiffIdUsageSection.Prepare(this);
					if (reader == null)
					{
						result = xmlReadMode;
					}
					else
					{
						bool enforceConstraints;
						if (this.DataSet != null)
						{
							enforceConstraints = this.DataSet.EnforceConstraints;
							this.DataSet.EnforceConstraints = false;
						}
						else
						{
							enforceConstraints = this.EnforceConstraints;
							this.EnforceConstraints = false;
						}
						if (reader is XmlTextReader)
						{
							((XmlTextReader)reader).WhitespaceHandling = WhitespaceHandling.Significant;
						}
						XmlDocument xmlDocument = new XmlDocument();
						XmlDataLoader xmlDataLoader = null;
						reader.MoveToContent();
						if (this.Columns.Count == 0 && this.IsEmptyXml(reader))
						{
							reader.Read();
							result = xmlReadMode;
						}
						else
						{
							if (reader.NodeType == XmlNodeType.Element)
							{
								int depth = reader.Depth;
								if (reader.LocalName == "diffgram" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-diffgram-v1")
								{
									if (this.Columns.Count != 0)
									{
										this.ReadXmlDiffgram(reader);
										this.ReadEndElement(reader);
										this.RestoreConstraint(enforceConstraints);
										return XmlReadMode.DiffGram;
									}
									if (reader.IsEmptyElement)
									{
										reader.Read();
										return XmlReadMode.DiffGram;
									}
									throw ExceptionBuilder.DataTableInferenceNotSupported();
								}
								else
								{
									if (reader.LocalName == "Schema" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-data")
									{
										this.ReadXDRSchema(reader);
										this.RestoreConstraint(enforceConstraints);
										return XmlReadMode.ReadSchema;
									}
									if (reader.LocalName == "schema" && reader.NamespaceURI == "http://www.w3.org/2001/XMLSchema")
									{
										this.ReadXmlSchema(reader, denyResolving);
										this.RestoreConstraint(enforceConstraints);
										return XmlReadMode.ReadSchema;
									}
									if (reader.LocalName == "schema" && reader.NamespaceURI.StartsWith("http://www.w3.org/", StringComparison.Ordinal))
									{
										if (this.DataSet != null)
										{
											this.DataSet.RestoreEnforceConstraints(enforceConstraints);
										}
										else
										{
											this._enforceConstraints = enforceConstraints;
										}
										throw ExceptionBuilder.DataSetUnsupportedSchema("http://www.w3.org/2001/XMLSchema");
									}
									XmlElement xmlElement = xmlDocument.CreateElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
									if (reader.HasAttributes)
									{
										int attributeCount = reader.AttributeCount;
										for (int i = 0; i < attributeCount; i++)
										{
											reader.MoveToAttribute(i);
											if (reader.NamespaceURI.Equals("http://www.w3.org/2000/xmlns/"))
											{
												xmlElement.SetAttribute(reader.Name, reader.GetAttribute(i));
											}
											else
											{
												XmlAttribute xmlAttribute = xmlElement.SetAttributeNode(reader.LocalName, reader.NamespaceURI);
												xmlAttribute.Prefix = reader.Prefix;
												xmlAttribute.Value = reader.GetAttribute(i);
											}
										}
									}
									reader.Read();
									while (this.MoveToElement(reader, depth))
									{
										if (reader.LocalName == "diffgram" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-diffgram-v1")
										{
											this.ReadXmlDiffgram(reader);
											this.ReadEndElement(reader);
											this.RestoreConstraint(enforceConstraints);
											return XmlReadMode.DiffGram;
										}
										if (!flag2 && !flag && reader.LocalName == "Schema" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-data")
										{
											this.ReadXDRSchema(reader);
											flag2 = true;
											isXdr = true;
										}
										else if (reader.LocalName == "schema" && reader.NamespaceURI == "http://www.w3.org/2001/XMLSchema")
										{
											this.ReadXmlSchema(reader, denyResolving);
											flag2 = true;
										}
										else
										{
											if (reader.LocalName == "schema" && reader.NamespaceURI.StartsWith("http://www.w3.org/", StringComparison.Ordinal))
											{
												if (this.DataSet != null)
												{
													this.DataSet.RestoreEnforceConstraints(enforceConstraints);
												}
												else
												{
													this._enforceConstraints = enforceConstraints;
												}
												throw ExceptionBuilder.DataSetUnsupportedSchema("http://www.w3.org/2001/XMLSchema");
											}
											if (reader.LocalName == "diffgram" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-diffgram-v1")
											{
												this.ReadXmlDiffgram(reader);
												xmlReadMode = XmlReadMode.DiffGram;
											}
											else
											{
												flag = true;
												if (!flag2 && this.Columns.Count == 0)
												{
													XmlNode newChild = xmlDocument.ReadNode(reader);
													xmlElement.AppendChild(newChild);
												}
												else
												{
													if (xmlDataLoader == null)
													{
														xmlDataLoader = new XmlDataLoader(this, isXdr, xmlElement, false);
													}
													xmlDataLoader.LoadData(reader);
													xmlReadMode = (flag2 ? XmlReadMode.ReadSchema : XmlReadMode.IgnoreSchema);
												}
											}
										}
									}
									this.ReadEndElement(reader);
									xmlDocument.AppendChild(xmlElement);
									if (!flag2 && this.Columns.Count == 0)
									{
										if (this.IsEmptyXml(reader))
										{
											reader.Read();
											return xmlReadMode;
										}
										throw ExceptionBuilder.DataTableInferenceNotSupported();
									}
									else if (xmlDataLoader == null)
									{
										xmlDataLoader = new XmlDataLoader(this, isXdr, false);
									}
								}
							}
							this.RestoreConstraint(enforceConstraints);
							result = xmlReadMode;
						}
					}
				}
				finally
				{
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00017F38 File Offset: 0x00016138
		internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving)
		{
			DataTable.RowDiffIdUsageSection rowDiffIdUsageSection = default(DataTable.RowDiffIdUsageSection);
			XmlReadMode result;
			try
			{
				bool flag = false;
				bool flag2 = false;
				bool isXdr = false;
				int depth = -1;
				XmlReadMode xmlReadMode = mode;
				rowDiffIdUsageSection.Prepare(this);
				if (reader == null)
				{
					result = xmlReadMode;
				}
				else
				{
					bool enforceConstraints;
					if (this.DataSet != null)
					{
						enforceConstraints = this.DataSet.EnforceConstraints;
						this.DataSet.EnforceConstraints = false;
					}
					else
					{
						enforceConstraints = this.EnforceConstraints;
						this.EnforceConstraints = false;
					}
					if (reader is XmlTextReader)
					{
						((XmlTextReader)reader).WhitespaceHandling = WhitespaceHandling.Significant;
					}
					XmlDocument xmlDocument = new XmlDocument();
					if (mode != XmlReadMode.Fragment && reader.NodeType == XmlNodeType.Element)
					{
						depth = reader.Depth;
					}
					reader.MoveToContent();
					if (this.Columns.Count == 0 && this.IsEmptyXml(reader))
					{
						reader.Read();
						result = xmlReadMode;
					}
					else
					{
						XmlDataLoader xmlDataLoader = null;
						if (reader.NodeType == XmlNodeType.Element)
						{
							XmlElement xmlElement;
							if (mode == XmlReadMode.Fragment)
							{
								xmlDocument.AppendChild(xmlDocument.CreateElement("ds_sqlXmlWraPPeR"));
								xmlElement = xmlDocument.DocumentElement;
							}
							else
							{
								if (reader.LocalName == "diffgram" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-diffgram-v1")
								{
									if (mode == XmlReadMode.DiffGram || mode == XmlReadMode.IgnoreSchema)
									{
										if (this.Columns.Count == 0)
										{
											if (reader.IsEmptyElement)
											{
												reader.Read();
												return XmlReadMode.DiffGram;
											}
											throw ExceptionBuilder.DataTableInferenceNotSupported();
										}
										else
										{
											this.ReadXmlDiffgram(reader);
											this.ReadEndElement(reader);
										}
									}
									else
									{
										reader.Skip();
									}
									this.RestoreConstraint(enforceConstraints);
									return xmlReadMode;
								}
								if (reader.LocalName == "Schema" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-data")
								{
									if (mode != XmlReadMode.IgnoreSchema && mode != XmlReadMode.InferSchema)
									{
										this.ReadXDRSchema(reader);
									}
									else
									{
										reader.Skip();
									}
									this.RestoreConstraint(enforceConstraints);
									return xmlReadMode;
								}
								if (reader.LocalName == "schema" && reader.NamespaceURI == "http://www.w3.org/2001/XMLSchema")
								{
									if (mode != XmlReadMode.IgnoreSchema && mode != XmlReadMode.InferSchema)
									{
										this.ReadXmlSchema(reader, denyResolving);
									}
									else
									{
										reader.Skip();
									}
									this.RestoreConstraint(enforceConstraints);
									return xmlReadMode;
								}
								if (reader.LocalName == "schema" && reader.NamespaceURI.StartsWith("http://www.w3.org/", StringComparison.Ordinal))
								{
									if (this.DataSet != null)
									{
										this.DataSet.RestoreEnforceConstraints(enforceConstraints);
									}
									else
									{
										this._enforceConstraints = enforceConstraints;
									}
									throw ExceptionBuilder.DataSetUnsupportedSchema("http://www.w3.org/2001/XMLSchema");
								}
								xmlElement = xmlDocument.CreateElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
								if (reader.HasAttributes)
								{
									int attributeCount = reader.AttributeCount;
									for (int i = 0; i < attributeCount; i++)
									{
										reader.MoveToAttribute(i);
										if (reader.NamespaceURI.Equals("http://www.w3.org/2000/xmlns/"))
										{
											xmlElement.SetAttribute(reader.Name, reader.GetAttribute(i));
										}
										else
										{
											XmlAttribute xmlAttribute = xmlElement.SetAttributeNode(reader.LocalName, reader.NamespaceURI);
											xmlAttribute.Prefix = reader.Prefix;
											xmlAttribute.Value = reader.GetAttribute(i);
										}
									}
								}
								reader.Read();
							}
							while (this.MoveToElement(reader, depth))
							{
								if (reader.LocalName == "Schema" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-data")
								{
									if (!flag && !flag2 && mode != XmlReadMode.IgnoreSchema && mode != XmlReadMode.InferSchema)
									{
										this.ReadXDRSchema(reader);
										flag = true;
										isXdr = true;
									}
									else
									{
										reader.Skip();
									}
								}
								else if (reader.LocalName == "schema" && reader.NamespaceURI == "http://www.w3.org/2001/XMLSchema")
								{
									if (mode != XmlReadMode.IgnoreSchema && mode != XmlReadMode.InferSchema)
									{
										this.ReadXmlSchema(reader, denyResolving);
										flag = true;
									}
									else
									{
										reader.Skip();
									}
								}
								else if (reader.LocalName == "diffgram" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-diffgram-v1")
								{
									if (mode == XmlReadMode.DiffGram || mode == XmlReadMode.IgnoreSchema)
									{
										if (this.Columns.Count == 0)
										{
											if (reader.IsEmptyElement)
											{
												reader.Read();
												return XmlReadMode.DiffGram;
											}
											throw ExceptionBuilder.DataTableInferenceNotSupported();
										}
										else
										{
											this.ReadXmlDiffgram(reader);
											xmlReadMode = XmlReadMode.DiffGram;
										}
									}
									else
									{
										reader.Skip();
									}
								}
								else
								{
									if (reader.LocalName == "schema" && reader.NamespaceURI.StartsWith("http://www.w3.org/", StringComparison.Ordinal))
									{
										if (this.DataSet != null)
										{
											this.DataSet.RestoreEnforceConstraints(enforceConstraints);
										}
										else
										{
											this._enforceConstraints = enforceConstraints;
										}
										throw ExceptionBuilder.DataSetUnsupportedSchema("http://www.w3.org/2001/XMLSchema");
									}
									if (mode == XmlReadMode.DiffGram)
									{
										reader.Skip();
									}
									else
									{
										flag2 = true;
										if (mode == XmlReadMode.InferSchema)
										{
											XmlNode newChild = xmlDocument.ReadNode(reader);
											xmlElement.AppendChild(newChild);
										}
										else
										{
											if (this.Columns.Count == 0)
											{
												throw ExceptionBuilder.DataTableInferenceNotSupported();
											}
											if (xmlDataLoader == null)
											{
												xmlDataLoader = new XmlDataLoader(this, isXdr, xmlElement, mode == XmlReadMode.IgnoreSchema);
											}
											xmlDataLoader.LoadData(reader);
										}
									}
								}
							}
							this.ReadEndElement(reader);
							xmlDocument.AppendChild(xmlElement);
							if (xmlDataLoader == null)
							{
								xmlDataLoader = new XmlDataLoader(this, isXdr, mode == XmlReadMode.IgnoreSchema);
							}
							if (mode == XmlReadMode.DiffGram)
							{
								this.RestoreConstraint(enforceConstraints);
								return xmlReadMode;
							}
							if (mode == XmlReadMode.InferSchema && this.Columns.Count == 0)
							{
								throw ExceptionBuilder.DataTableInferenceNotSupported();
							}
						}
						this.RestoreConstraint(enforceConstraints);
						result = xmlReadMode;
					}
				}
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000E546 File Offset: 0x0000C746
		internal void ReadEndElement(XmlReader reader)
		{
			while (reader.NodeType == XmlNodeType.Whitespace)
			{
				reader.Skip();
			}
			if (reader.NodeType == XmlNodeType.None)
			{
				reader.Skip();
				return;
			}
			if (reader.NodeType == XmlNodeType.EndElement)
			{
				reader.ReadEndElement();
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00018470 File Offset: 0x00016670
		internal void ReadXDRSchema(XmlReader reader)
		{
			new XmlDocument().ReadNode(reader);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000E4E8 File Offset: 0x0000C6E8
		internal bool MoveToElement(XmlReader reader, int depth)
		{
			while (!reader.EOF && reader.NodeType != XmlNodeType.EndElement && reader.NodeType != XmlNodeType.Element && reader.Depth > depth)
			{
				reader.Read();
			}
			return reader.NodeType == XmlNodeType.Element;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00018480 File Offset: 0x00016680
		private void ReadXmlDiffgram(XmlReader reader)
		{
			int depth = reader.Depth;
			bool enforceConstraints = this.EnforceConstraints;
			this.EnforceConstraints = false;
			bool flag;
			DataTable dataTable;
			if (this.Rows.Count == 0)
			{
				flag = true;
				dataTable = this;
			}
			else
			{
				flag = false;
				dataTable = this.Clone();
				dataTable.EnforceConstraints = false;
			}
			dataTable.Rows._nullInList = 0;
			reader.MoveToContent();
			if (reader.LocalName != "diffgram" && reader.NamespaceURI != "urn:schemas-microsoft-com:xml-diffgram-v1")
			{
				return;
			}
			reader.Read();
			if (reader.NodeType == XmlNodeType.Whitespace)
			{
				this.MoveToElement(reader, reader.Depth - 1);
			}
			dataTable._fInLoadDiffgram = true;
			if (reader.Depth > depth)
			{
				if (reader.NamespaceURI != "urn:schemas-microsoft-com:xml-diffgram-v1" && reader.NamespaceURI != "urn:schemas-microsoft-com:xml-msdata")
				{
					XmlElement topNode = new XmlDocument().CreateElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
					reader.Read();
					if (reader.Depth - 1 > depth)
					{
						new XmlDataLoader(dataTable, false, topNode, false)
						{
							_isDiffgram = true
						}.LoadData(reader);
					}
					this.ReadEndElement(reader);
				}
				if ((reader.LocalName == "before" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-diffgram-v1") || (reader.LocalName == "errors" && reader.NamespaceURI == "urn:schemas-microsoft-com:xml-diffgram-v1"))
				{
					new XMLDiffLoader().LoadDiffGram(dataTable, reader);
				}
				while (reader.Depth > depth)
				{
					reader.Read();
				}
				this.ReadEndElement(reader);
			}
			if (dataTable.Rows._nullInList > 0)
			{
				throw ExceptionBuilder.RowInsertMissing(dataTable.TableName);
			}
			dataTable._fInLoadDiffgram = false;
			List<DataTable> list = new List<DataTable>();
			list.Add(this);
			this.CreateTableList(this, list);
			for (int i = 0; i < list.Count; i++)
			{
				DataRelation[] nestedParentRelations = list[i].NestedParentRelations;
				foreach (DataRelation dataRelation in nestedParentRelations)
				{
					if (dataRelation != null && dataRelation.ParentTable == list[i])
					{
						foreach (object obj in list[i].Rows)
						{
							DataRow dataRow = (DataRow)obj;
							foreach (DataRelation rel in nestedParentRelations)
							{
								dataRow.CheckForLoops(rel);
							}
						}
					}
				}
			}
			if (!flag)
			{
				this.Merge(dataTable);
			}
			this.EnforceConstraints = enforceConstraints;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001873C File Offset: 0x0001693C
		internal void ReadXSDSchema(XmlReader reader, bool denyResolving)
		{
			XmlSchemaSet xmlSchemaSet = new XmlSchemaSet();
			while (reader.LocalName == "schema" && reader.NamespaceURI == "http://www.w3.org/2001/XMLSchema")
			{
				XmlSchema schema = XmlSchema.Read(reader, null);
				xmlSchemaSet.Add(schema);
				this.ReadEndElement(reader);
			}
			xmlSchemaSet.Compile();
			new XSDSchema().LoadSchema(xmlSchemaSet, this);
		}

		/// <summary>Reads an XML schema into the <see cref="T:System.Data.DataTable" /> using the specified stream.</summary>
		/// <param name="stream">The stream used to read the schema. </param>
		// Token: 0x0600054B RID: 1355 RVA: 0x0001879E File Offset: 0x0001699E
		public void ReadXmlSchema(Stream stream)
		{
			if (stream == null)
			{
				return;
			}
			this.ReadXmlSchema(new XmlTextReader(stream), false);
		}

		/// <summary>Reads an XML schema into the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="reader">The <see cref="T:System.IO.TextReader" /> used to read the schema information. </param>
		// Token: 0x0600054C RID: 1356 RVA: 0x000187B1 File Offset: 0x000169B1
		public void ReadXmlSchema(TextReader reader)
		{
			if (reader == null)
			{
				return;
			}
			this.ReadXmlSchema(new XmlTextReader(reader), false);
		}

		/// <summary>Reads an XML schema into the <see cref="T:System.Data.DataTable" /> from the specified file.</summary>
		/// <param name="fileName">The name of the file from which to read the schema information. </param>
		// Token: 0x0600054D RID: 1357 RVA: 0x000187C4 File Offset: 0x000169C4
		public void ReadXmlSchema(string fileName)
		{
			XmlTextReader xmlTextReader = new XmlTextReader(fileName);
			try
			{
				this.ReadXmlSchema(xmlTextReader, false);
			}
			finally
			{
				xmlTextReader.Close();
			}
		}

		/// <summary>Reads an XML schema into the <see cref="T:System.Data.DataTable" /> using the specified <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> used to read the schema information. </param>
		// Token: 0x0600054E RID: 1358 RVA: 0x000187FC File Offset: 0x000169FC
		public void ReadXmlSchema(XmlReader reader)
		{
			this.ReadXmlSchema(reader, false);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00018808 File Offset: 0x00016A08
		internal void ReadXmlSchema(XmlReader reader, bool denyResolving)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, bool>("<ds.DataTable.ReadXmlSchema|INFO> {0}, denyResolving={1}", this.ObjectID, denyResolving);
			try
			{
				DataSet dataSet = new DataSet();
				SerializationFormat remotingFormat = this.RemotingFormat;
				dataSet.ReadXmlSchema(reader, denyResolving);
				string mainTableName = dataSet.MainTableName;
				if (!string.IsNullOrEmpty(this._tableName) || !string.IsNullOrEmpty(mainTableName))
				{
					DataTable dataTable = null;
					if (!string.IsNullOrEmpty(this._tableName))
					{
						if (!string.IsNullOrEmpty(this.Namespace))
						{
							dataTable = dataSet.Tables[this._tableName, this.Namespace];
						}
						else
						{
							int num = dataSet.Tables.InternalIndexOf(this._tableName);
							if (num > -1)
							{
								dataTable = dataSet.Tables[num];
							}
						}
					}
					else
					{
						string tableNamespace = string.Empty;
						int num2 = mainTableName.IndexOf(':');
						if (num2 > -1)
						{
							tableNamespace = mainTableName.Substring(0, num2);
						}
						string name = mainTableName.Substring(num2 + 1, mainTableName.Length - num2 - 1);
						dataTable = dataSet.Tables[name, tableNamespace];
					}
					if (dataTable == null)
					{
						string tableName = string.Empty;
						if (!string.IsNullOrEmpty(this._tableName))
						{
							tableName = ((this.Namespace.Length > 0) ? (this.Namespace + ":" + this._tableName) : this._tableName);
						}
						else
						{
							tableName = mainTableName;
						}
						throw ExceptionBuilder.TableNotFound(tableName);
					}
					dataTable._remotingFormat = remotingFormat;
					List<DataTable> list = new List<DataTable>();
					list.Add(dataTable);
					this.CreateTableList(dataTable, list);
					List<DataRelation> list2 = new List<DataRelation>();
					this.CreateRelationList(list, list2);
					if (list2.Count == 0)
					{
						if (this.Columns.Count == 0)
						{
							DataTable dataTable2 = dataTable;
							if (dataTable2 != null)
							{
								dataTable2.CloneTo(this, null, false);
							}
							if (this.DataSet == null && this._tableNamespace == null)
							{
								this._tableNamespace = dataTable2.Namespace;
							}
						}
					}
					else
					{
						if (string.IsNullOrEmpty(this.TableName))
						{
							this.TableName = dataTable.TableName;
							if (!string.IsNullOrEmpty(dataTable.Namespace))
							{
								this.Namespace = dataTable.Namespace;
							}
						}
						if (this.DataSet == null)
						{
							DataSet dataSet2 = new DataSet(dataSet.DataSetName);
							dataSet2.SetLocaleValue(dataSet.Locale, dataSet.ShouldSerializeLocale());
							dataSet2.CaseSensitive = dataSet.CaseSensitive;
							dataSet2.Namespace = dataSet.Namespace;
							dataSet2._mainTableName = dataSet._mainTableName;
							dataSet2.RemotingFormat = dataSet.RemotingFormat;
							dataSet2.Tables.Add(this);
						}
						this.CloneHierarchy(dataTable, this.DataSet, null);
						foreach (DataTable dataTable3 in list)
						{
							DataTable dataTable4 = this.DataSet.Tables[dataTable3._tableName, dataTable3.Namespace];
							foreach (object obj in dataSet.Tables[dataTable3._tableName, dataTable3.Namespace].Constraints)
							{
								ForeignKeyConstraint foreignKeyConstraint = ((Constraint)obj) as ForeignKeyConstraint;
								if (foreignKeyConstraint != null && foreignKeyConstraint.Table != foreignKeyConstraint.RelatedTable && list.Contains(foreignKeyConstraint.Table) && list.Contains(foreignKeyConstraint.RelatedTable))
								{
									ForeignKeyConstraint foreignKeyConstraint2 = (ForeignKeyConstraint)foreignKeyConstraint.Clone(dataTable4.DataSet);
									if (!dataTable4.Constraints.Contains(foreignKeyConstraint2.ConstraintName))
									{
										dataTable4.Constraints.Add(foreignKeyConstraint2);
									}
								}
							}
						}
						foreach (DataRelation dataRelation in list2)
						{
							if (!this.DataSet.Relations.Contains(dataRelation.RelationName))
							{
								this.DataSet.Relations.Add(dataRelation.Clone(this.DataSet));
							}
						}
						foreach (DataTable dataTable5 in list)
						{
							foreach (object obj2 in dataTable5.Columns)
							{
								DataColumn dataColumn = (DataColumn)obj2;
								bool flag = false;
								if (dataColumn.Expression.Length != 0)
								{
									DataColumn[] dependency = dataColumn.DataExpression.GetDependency();
									for (int i = 0; i < dependency.Length; i++)
									{
										if (!list.Contains(dependency[i].Table))
										{
											flag = true;
											break;
										}
									}
								}
								if (!flag)
								{
									this.DataSet.Tables[dataTable5.TableName, dataTable5.Namespace].Columns[dataColumn.ColumnName].Expression = dataColumn.Expression;
								}
							}
						}
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00018DA8 File Offset: 0x00016FA8
		private void CreateTableList(DataTable currentTable, List<DataTable> tableList)
		{
			foreach (object obj in currentTable.ChildRelations)
			{
				DataRelation dataRelation = (DataRelation)obj;
				if (!tableList.Contains(dataRelation.ChildTable))
				{
					tableList.Add(dataRelation.ChildTable);
					this.CreateTableList(dataRelation.ChildTable, tableList);
				}
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00018E24 File Offset: 0x00017024
		private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList)
		{
			foreach (DataTable dataTable in tableList)
			{
				foreach (object obj in dataTable.ChildRelations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (tableList.Contains(dataRelation.ChildTable) && tableList.Contains(dataRelation.ParentTable))
					{
						relationList.Add(dataRelation);
					}
				}
			}
		}

		/// <summary>This method returns an <see cref="T:System.Xml.Schema.XmlSchemaSet" /> instance containing the Web Services Description Language (WSDL) that describes the <see cref="T:System.Data.DataTable" /> for Web Services.</summary>
		/// <param name="schemaSet">An <see cref="T:System.Xml.Schema.XmlSchemaSet" /> instance.</param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSet" /> instance.</returns>
		// Token: 0x06000552 RID: 1362 RVA: 0x00018ED0 File Offset: 0x000170D0
		public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny.MinOccurs = 1m;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			return xmlSchemaComplexType;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
		/// <returns> An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.</returns>
		// Token: 0x06000553 RID: 1363 RVA: 0x00018F5F File Offset: 0x0001715F
		XmlSchema IXmlSerializable.GetSchema()
		{
			return this.GetSchema();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
		/// <returns> An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.</returns>
		// Token: 0x06000554 RID: 1364 RVA: 0x00018F68 File Offset: 0x00017168
		protected virtual XmlSchema GetSchema()
		{
			if (base.GetType() == typeof(DataTable))
			{
				return null;
			}
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = new XmlTextWriter(memoryStream, null);
			if (xmlWriter != null)
			{
				new XmlTreeGen(SchemaFormat.WebService).Save(this, xmlWriter);
			}
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</summary>
		/// <param name="reader">An XmlReader.</param>
		// Token: 0x06000555 RID: 1365 RVA: 0x00018FC0 File Offset: 0x000171C0
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			IXmlTextParser xmlTextParser = reader as IXmlTextParser;
			bool normalized = true;
			if (xmlTextParser != null)
			{
				normalized = xmlTextParser.Normalized;
				xmlTextParser.Normalized = false;
			}
			this.ReadXmlSerializable(reader);
			if (xmlTextParser != null)
			{
				xmlTextParser.Normalized = normalized;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" />.</summary>
		/// <param name="writer">An XmlWriter.</param>
		// Token: 0x06000556 RID: 1366 RVA: 0x00018FF8 File Offset: 0x000171F8
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			this.WriteXmlSchema(writer, false);
			this.WriteXml(writer, XmlWriteMode.DiffGram, false);
		}

		/// <summary>Reads from an XML stream.</summary>
		/// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> object.</param>
		// Token: 0x06000557 RID: 1367 RVA: 0x0001900B File Offset: 0x0001720B
		protected virtual void ReadXmlSerializable(XmlReader reader)
		{
			this.ReadXml(reader, XmlReadMode.DiffGram, true);
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00019017 File Offset: 0x00017217
		internal Hashtable RowDiffId
		{
			get
			{
				if (this._rowDiffId == null)
				{
					this._rowDiffId = new Hashtable();
				}
				return this._rowDiffId;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00019032 File Offset: 0x00017232
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0001903A File Offset: 0x0001723A
		internal void AddDependentColumn(DataColumn expressionColumn)
		{
			if (this._dependentColumns == null)
			{
				this._dependentColumns = new List<DataColumn>();
			}
			if (!this._dependentColumns.Contains(expressionColumn))
			{
				this._dependentColumns.Add(expressionColumn);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00019069 File Offset: 0x00017269
		internal void RemoveDependentColumn(DataColumn expressionColumn)
		{
			if (this._dependentColumns != null && this._dependentColumns.Contains(expressionColumn))
			{
				this._dependentColumns.Remove(expressionColumn);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00019090 File Offset: 0x00017290
		internal void EvaluateExpressions()
		{
			if (this._dependentColumns != null && 0 < this._dependentColumns.Count)
			{
				foreach (object obj in this.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (dataRow._oldRecord != -1 && dataRow._oldRecord != dataRow._newRecord)
					{
						this.EvaluateDependentExpressions(this._dependentColumns, dataRow, DataRowVersion.Original, null);
					}
					if (dataRow._newRecord != -1)
					{
						this.EvaluateDependentExpressions(this._dependentColumns, dataRow, DataRowVersion.Current, null);
					}
					if (dataRow._tempRecord != -1)
					{
						this.EvaluateDependentExpressions(this._dependentColumns, dataRow, DataRowVersion.Proposed, null);
					}
				}
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00019160 File Offset: 0x00017360
		internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows)
		{
			if (action == DataRowAction.Add || action == DataRowAction.Change || (action == DataRowAction.Rollback && (row._oldRecord != -1 || row._newRecord != -1)))
			{
				if (row._oldRecord != -1 && row._oldRecord != row._newRecord)
				{
					this.EvaluateDependentExpressions(this._dependentColumns, row, DataRowVersion.Original, cachedRows);
				}
				if (row._newRecord != -1)
				{
					this.EvaluateDependentExpressions(this._dependentColumns, row, DataRowVersion.Current, cachedRows);
				}
				if (row._tempRecord != -1)
				{
					this.EvaluateDependentExpressions(this._dependentColumns, row, DataRowVersion.Proposed, cachedRows);
				}
				return;
			}
			if ((action == DataRowAction.Delete || (action == DataRowAction.Rollback && row._oldRecord == -1 && row._newRecord == -1)) && this._dependentColumns != null)
			{
				foreach (DataColumn dataColumn in this._dependentColumns)
				{
					if (dataColumn.DataExpression != null && dataColumn.DataExpression.HasLocalAggregate() && dataColumn.Table == this)
					{
						for (int i = 0; i < this.Rows.Count; i++)
						{
							DataRow dataRow = this.Rows[i];
							if (dataRow._oldRecord != -1 && dataRow._oldRecord != dataRow._newRecord)
							{
								this.EvaluateDependentExpressions(this._dependentColumns, dataRow, DataRowVersion.Original, null);
							}
						}
						for (int j = 0; j < this.Rows.Count; j++)
						{
							DataRow dataRow2 = this.Rows[j];
							if (dataRow2._tempRecord != -1)
							{
								this.EvaluateDependentExpressions(this._dependentColumns, dataRow2, DataRowVersion.Proposed, null);
							}
						}
						for (int k = 0; k < this.Rows.Count; k++)
						{
							DataRow dataRow3 = this.Rows[k];
							if (dataRow3._newRecord != -1)
							{
								this.EvaluateDependentExpressions(this._dependentColumns, dataRow3, DataRowVersion.Current, null);
							}
						}
						break;
					}
				}
				if (cachedRows != null)
				{
					foreach (DataRow dataRow4 in cachedRows)
					{
						if (dataRow4._oldRecord != -1 && dataRow4._oldRecord != dataRow4._newRecord)
						{
							dataRow4.Table.EvaluateDependentExpressions(dataRow4.Table._dependentColumns, dataRow4, DataRowVersion.Original, null);
						}
						if (dataRow4._newRecord != -1)
						{
							dataRow4.Table.EvaluateDependentExpressions(dataRow4.Table._dependentColumns, dataRow4, DataRowVersion.Current, null);
						}
						if (dataRow4._tempRecord != -1)
						{
							dataRow4.Table.EvaluateDependentExpressions(dataRow4.Table._dependentColumns, dataRow4, DataRowVersion.Proposed, null);
						}
					}
				}
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00019450 File Offset: 0x00017650
		internal void EvaluateExpressions(DataColumn column)
		{
			int count = column._table.Rows.Count;
			if (column.DataExpression.IsTableAggregate() && count > 0)
			{
				object value = column.DataExpression.Evaluate();
				for (int i = 0; i < count; i++)
				{
					DataRow dataRow = column._table.Rows[i];
					if (dataRow._oldRecord != -1 && dataRow._oldRecord != dataRow._newRecord)
					{
						column[dataRow._oldRecord] = value;
					}
					if (dataRow._newRecord != -1)
					{
						column[dataRow._newRecord] = value;
					}
					if (dataRow._tempRecord != -1)
					{
						column[dataRow._tempRecord] = value;
					}
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					DataRow dataRow2 = column._table.Rows[j];
					if (dataRow2._oldRecord != -1 && dataRow2._oldRecord != dataRow2._newRecord)
					{
						column[dataRow2._oldRecord] = column.DataExpression.Evaluate(dataRow2, DataRowVersion.Original);
					}
					if (dataRow2._newRecord != -1)
					{
						column[dataRow2._newRecord] = column.DataExpression.Evaluate(dataRow2, DataRowVersion.Current);
					}
					if (dataRow2._tempRecord != -1)
					{
						column[dataRow2._tempRecord] = column.DataExpression.Evaluate(dataRow2, DataRowVersion.Proposed);
					}
				}
			}
			column.Table.ResetInternalIndexes(column);
			this.EvaluateDependentExpressions(column);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000195CC File Offset: 0x000177CC
		internal void EvaluateDependentExpressions(DataColumn column)
		{
			if (column._dependentColumns != null)
			{
				foreach (DataColumn dataColumn in column._dependentColumns)
				{
					if (dataColumn._table != null && column != dataColumn)
					{
						this.EvaluateExpressions(dataColumn);
					}
				}
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00019634 File Offset: 0x00017834
		internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows)
		{
			if (columns == null)
			{
				return;
			}
			int count = columns.Count;
			for (int i = 0; i < count; i++)
			{
				if (columns[i].Table == this)
				{
					DataColumn dataColumn = columns[i];
					if (dataColumn.DataExpression != null && dataColumn.DataExpression.HasLocalAggregate())
					{
						DataRowVersion dataRowVersion = (version == DataRowVersion.Proposed) ? DataRowVersion.Default : version;
						bool flag = dataColumn.DataExpression.IsTableAggregate();
						object newValue = null;
						if (flag)
						{
							newValue = dataColumn.DataExpression.Evaluate(row, dataRowVersion);
						}
						for (int j = 0; j < this.Rows.Count; j++)
						{
							DataRow dataRow = this.Rows[j];
							if (dataRow.RowState != DataRowState.Deleted && (dataRowVersion != DataRowVersion.Original || (dataRow._oldRecord != -1 && dataRow._oldRecord != dataRow._newRecord)))
							{
								if (!flag)
								{
									newValue = dataColumn.DataExpression.Evaluate(dataRow, dataRowVersion);
								}
								this.SilentlySetValue(dataRow, dataColumn, dataRowVersion, newValue);
							}
						}
					}
					else if (row.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || (row._oldRecord != -1 && row._oldRecord != row._newRecord)))
					{
						this.SilentlySetValue(row, dataColumn, version, (dataColumn.DataExpression == null) ? dataColumn.DefaultValue : dataColumn.DataExpression.Evaluate(row, version));
					}
				}
			}
			count = columns.Count;
			for (int k = 0; k < count; k++)
			{
				DataColumn dataColumn2 = columns[k];
				if (dataColumn2.Table != this || (dataColumn2.DataExpression != null && !dataColumn2.DataExpression.HasLocalAggregate()))
				{
					DataRowVersion dataRowVersion2 = (version == DataRowVersion.Proposed) ? DataRowVersion.Default : version;
					if (cachedRows != null)
					{
						foreach (DataRow dataRow2 in cachedRows)
						{
							if (dataRow2.Table == dataColumn2.Table && (dataRowVersion2 != DataRowVersion.Original || dataRow2._newRecord != dataRow2._oldRecord) && dataRow2 != null && dataRow2.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || dataRow2._oldRecord != -1))
							{
								object newValue2 = dataColumn2.DataExpression.Evaluate(dataRow2, dataRowVersion2);
								this.SilentlySetValue(dataRow2, dataColumn2, dataRowVersion2, newValue2);
							}
						}
					}
					for (int l = 0; l < this.ParentRelations.Count; l++)
					{
						DataRelation dataRelation = this.ParentRelations[l];
						if (dataRelation.ParentTable == dataColumn2.Table)
						{
							foreach (DataRow dataRow3 in row.GetParentRows(dataRelation, version))
							{
								if ((cachedRows == null || !cachedRows.Contains(dataRow3)) && (dataRowVersion2 != DataRowVersion.Original || dataRow3._newRecord != dataRow3._oldRecord) && dataRow3 != null && dataRow3.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || dataRow3._oldRecord != -1))
								{
									object newValue3 = dataColumn2.DataExpression.Evaluate(dataRow3, dataRowVersion2);
									this.SilentlySetValue(dataRow3, dataColumn2, dataRowVersion2, newValue3);
								}
							}
						}
					}
					for (int n = 0; n < this.ChildRelations.Count; n++)
					{
						DataRelation dataRelation2 = this.ChildRelations[n];
						if (dataRelation2.ChildTable == dataColumn2.Table)
						{
							foreach (DataRow dataRow4 in row.GetChildRows(dataRelation2, version))
							{
								if ((cachedRows == null || !cachedRows.Contains(dataRow4)) && (dataRowVersion2 != DataRowVersion.Original || dataRow4._newRecord != dataRow4._oldRecord) && dataRow4 != null && dataRow4.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || dataRow4._oldRecord != -1))
								{
									object newValue4 = dataColumn2.DataExpression.Evaluate(dataRow4, dataRowVersion2);
									this.SilentlySetValue(dataRow4, dataColumn2, dataRowVersion2, newValue4);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x040000DF RID: 223
		private DataSet _dataSet;

		// Token: 0x040000E0 RID: 224
		private DataView _defaultView;

		// Token: 0x040000E1 RID: 225
		internal long _nextRowID;

		// Token: 0x040000E2 RID: 226
		internal readonly DataRowCollection _rowCollection;

		// Token: 0x040000E3 RID: 227
		internal readonly DataColumnCollection _columnCollection;

		// Token: 0x040000E4 RID: 228
		private readonly ConstraintCollection _constraintCollection;

		// Token: 0x040000E5 RID: 229
		private int _elementColumnCount;

		// Token: 0x040000E6 RID: 230
		internal DataRelationCollection _parentRelationsCollection;

		// Token: 0x040000E7 RID: 231
		internal DataRelationCollection _childRelationsCollection;

		// Token: 0x040000E8 RID: 232
		internal readonly RecordManager _recordManager;

		// Token: 0x040000E9 RID: 233
		internal readonly List<Index> _indexes;

		// Token: 0x040000EA RID: 234
		private List<Index> _shadowIndexes;

		// Token: 0x040000EB RID: 235
		private int _shadowCount;

		// Token: 0x040000EC RID: 236
		internal PropertyCollection _extendedProperties;

		// Token: 0x040000ED RID: 237
		private string _tableName = string.Empty;

		// Token: 0x040000EE RID: 238
		internal string _tableNamespace;

		// Token: 0x040000EF RID: 239
		private string _tablePrefix = string.Empty;

		// Token: 0x040000F0 RID: 240
		internal DataExpression _displayExpression;

		// Token: 0x040000F1 RID: 241
		internal bool _fNestedInDataset = true;

		// Token: 0x040000F2 RID: 242
		private CultureInfo _culture;

		// Token: 0x040000F3 RID: 243
		private bool _cultureUserSet;

		// Token: 0x040000F4 RID: 244
		private CompareInfo _compareInfo;

		// Token: 0x040000F5 RID: 245
		private CompareOptions _compareFlags = CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth;

		// Token: 0x040000F6 RID: 246
		private IFormatProvider _formatProvider;

		// Token: 0x040000F7 RID: 247
		private StringComparer _hashCodeProvider;

		// Token: 0x040000F8 RID: 248
		private bool _caseSensitive;

		// Token: 0x040000F9 RID: 249
		private bool _caseSensitiveUserSet;

		// Token: 0x040000FA RID: 250
		internal string _encodedTableName;

		// Token: 0x040000FB RID: 251
		internal DataColumn _xmlText;

		// Token: 0x040000FC RID: 252
		internal DataColumn _colUnique;

		// Token: 0x040000FD RID: 253
		internal bool _textOnly;

		// Token: 0x040000FE RID: 254
		internal decimal _minOccurs = 1m;

		// Token: 0x040000FF RID: 255
		internal decimal _maxOccurs = 1m;

		// Token: 0x04000100 RID: 256
		internal bool _repeatableElement;

		// Token: 0x04000101 RID: 257
		private object _typeName;

		// Token: 0x04000102 RID: 258
		internal UniqueConstraint _primaryKey;

		// Token: 0x04000103 RID: 259
		internal IndexField[] _primaryIndex = Array.Empty<IndexField>();

		// Token: 0x04000104 RID: 260
		private DataColumn[] _delayedSetPrimaryKey;

		// Token: 0x04000105 RID: 261
		private Index _loadIndex;

		// Token: 0x04000106 RID: 262
		private Index _loadIndexwithOriginalAdded;

		// Token: 0x04000107 RID: 263
		private Index _loadIndexwithCurrentDeleted;

		// Token: 0x04000108 RID: 264
		private int _suspendIndexEvents;

		// Token: 0x04000109 RID: 265
		private bool _savedEnforceConstraints;

		// Token: 0x0400010A RID: 266
		private bool _inDataLoad;

		// Token: 0x0400010B RID: 267
		private bool _initialLoad;

		// Token: 0x0400010C RID: 268
		private bool _schemaLoading;

		// Token: 0x0400010D RID: 269
		private bool _enforceConstraints = true;

		// Token: 0x0400010E RID: 270
		internal bool _suspendEnforceConstraints;

		/// <summary>Checks whether initialization is in progress. The initialization occurs at run time.</summary>
		// Token: 0x0400010F RID: 271
		protected internal bool fInitInProgress;

		// Token: 0x04000110 RID: 272
		private bool _inLoad;

		// Token: 0x04000111 RID: 273
		internal bool _fInLoadDiffgram;

		// Token: 0x04000112 RID: 274
		private byte _isTypedDataTable;

		// Token: 0x04000113 RID: 275
		private DataRow[] _emptyDataRowArray;

		// Token: 0x04000114 RID: 276
		private PropertyDescriptorCollection _propertyDescriptorCollectionCache;

		// Token: 0x04000115 RID: 277
		private DataRelation[] _nestedParentRelations = Array.Empty<DataRelation>();

		// Token: 0x04000116 RID: 278
		internal List<DataColumn> _dependentColumns;

		// Token: 0x04000117 RID: 279
		private bool _mergingData;

		// Token: 0x04000118 RID: 280
		private DataRowChangeEventHandler _onRowChangedDelegate;

		// Token: 0x04000119 RID: 281
		private DataRowChangeEventHandler _onRowChangingDelegate;

		// Token: 0x0400011A RID: 282
		private DataRowChangeEventHandler _onRowDeletingDelegate;

		// Token: 0x0400011B RID: 283
		private DataRowChangeEventHandler _onRowDeletedDelegate;

		// Token: 0x0400011C RID: 284
		private DataColumnChangeEventHandler _onColumnChangedDelegate;

		// Token: 0x0400011D RID: 285
		private DataColumnChangeEventHandler _onColumnChangingDelegate;

		// Token: 0x0400011E RID: 286
		private DataTableClearEventHandler _onTableClearingDelegate;

		// Token: 0x0400011F RID: 287
		private DataTableClearEventHandler _onTableClearedDelegate;

		// Token: 0x04000120 RID: 288
		private DataTableNewRowEventHandler _onTableNewRowDelegate;

		// Token: 0x04000121 RID: 289
		private PropertyChangedEventHandler _onPropertyChangingDelegate;

		// Token: 0x04000122 RID: 290
		private EventHandler _onInitialized;

		// Token: 0x04000123 RID: 291
		private readonly DataRowBuilder _rowBuilder;

		// Token: 0x04000124 RID: 292
		private const string KEY_XMLSCHEMA = "XmlSchema";

		// Token: 0x04000125 RID: 293
		private const string KEY_XMLDIFFGRAM = "XmlDiffGram";

		// Token: 0x04000126 RID: 294
		private const string KEY_NAME = "TableName";

		// Token: 0x04000127 RID: 295
		internal readonly List<DataView> _delayedViews = new List<DataView>();

		// Token: 0x04000128 RID: 296
		private readonly List<DataViewListener> _dataViewListeners = new List<DataViewListener>();

		// Token: 0x04000129 RID: 297
		internal Hashtable _rowDiffId;

		// Token: 0x0400012A RID: 298
		internal readonly ReaderWriterLockSlim _indexesLock = new ReaderWriterLockSlim();

		// Token: 0x0400012B RID: 299
		internal int _ukColumnPositionForInference = -1;

		// Token: 0x0400012C RID: 300
		private SerializationFormat _remotingFormat;

		// Token: 0x0400012D RID: 301
		private static int s_objectTypeCount;

		// Token: 0x0400012E RID: 302
		private readonly int _objectID = Interlocked.Increment(ref DataTable.s_objectTypeCount);

		// Token: 0x0200003C RID: 60
		internal struct RowDiffIdUsageSection
		{
			// Token: 0x06000561 RID: 1377 RVA: 0x00019A38 File Offset: 0x00017C38
			internal void Prepare(DataTable table)
			{
				this._targetTable = table;
				table._rowDiffId = null;
			}

			// Token: 0x0400012F RID: 303
			private DataTable _targetTable;
		}

		// Token: 0x0200003D RID: 61
		internal struct DSRowDiffIdUsageSection
		{
			// Token: 0x06000562 RID: 1378 RVA: 0x00019A48 File Offset: 0x00017C48
			internal void Prepare(DataSet ds)
			{
				this._targetDS = ds;
				for (int i = 0; i < ds.Tables.Count; i++)
				{
					ds.Tables[i]._rowDiffId = null;
				}
			}

			// Token: 0x04000130 RID: 304
			private DataSet _targetDS;
		}
	}
}
