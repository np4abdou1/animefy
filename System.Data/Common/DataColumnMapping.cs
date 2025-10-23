using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace System.Data.Common
{
	/// <summary>Contains a generic column mapping for an object that inherits from <see cref="T:System.Data.Common.DataAdapter" />. This class cannot be inherited.</summary>
	// Token: 0x020000D9 RID: 217
	[TypeConverter(typeof(DataColumnMapping.DataColumnMappingConverter))]
	public sealed class DataColumnMapping : MarshalByRefObject, ICloneable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.Common.DataColumnMapping" /> class.</summary>
		// Token: 0x06000EE0 RID: 3808 RVA: 0x0004A9B2 File Offset: 0x00048BB2
		public DataColumnMapping()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.Common.DataColumnMapping" /> class with the specified source column name and <see cref="T:System.Data.DataSet" /> column name to map to.</summary>
		/// <param name="sourceColumn">The case-sensitive column name from a data source. </param>
		/// <param name="dataSetColumn">The column name, which is not case sensitive, from a <see cref="T:System.Data.DataSet" /> to map to. </param>
		// Token: 0x06000EE1 RID: 3809 RVA: 0x0004A9BA File Offset: 0x00048BBA
		public DataColumnMapping(string sourceColumn, string dataSetColumn)
		{
			this.SourceColumn = sourceColumn;
			this.DataSetColumn = dataSetColumn;
		}

		/// <summary>Gets or sets the name of the column within the <see cref="T:System.Data.DataSet" /> to map to.</summary>
		/// <returns>The name of the column within the <see cref="T:System.Data.DataSet" /> to map to. The name is not case sensitive.</returns>
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0004A9D0 File Offset: 0x00048BD0
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x0004A9E1 File Offset: 0x00048BE1
		[DefaultValue("")]
		public string DataSetColumn
		{
			get
			{
				return this._dataSetColumnName ?? string.Empty;
			}
			set
			{
				this._dataSetColumnName = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0004A9EA File Offset: 0x00048BEA
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x0004A9F2 File Offset: 0x00048BF2
		internal DataColumnMappingCollection Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}

		/// <summary>Gets or sets the name of the column within the data source to map from. The name is case-sensitive.</summary>
		/// <returns>The case-sensitive name of the column in the data source.</returns>
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0004A9FB File Offset: 0x00048BFB
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0004AA0C File Offset: 0x00048C0C
		[DefaultValue("")]
		public string SourceColumn
		{
			get
			{
				return this._sourceColumnName ?? string.Empty;
			}
			set
			{
				if (this.Parent != null && ADP.SrcCompare(this._sourceColumnName, value) != 0)
				{
					this.Parent.ValidateSourceColumn(-1, value);
				}
				this._sourceColumnName = value;
			}
		}

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A copy of the current object.</returns>
		// Token: 0x06000EE8 RID: 3816 RVA: 0x0004AA38 File Offset: 0x00048C38
		object ICloneable.Clone()
		{
			return new DataColumnMapping
			{
				_sourceColumnName = this._sourceColumnName,
				_dataSetColumnName = this._dataSetColumnName
			};
		}

		/// <summary>Gets a <see cref="T:System.Data.DataColumn" /> from the given <see cref="T:System.Data.DataTable" /> using the <see cref="T:System.Data.MissingSchemaAction" /> and the <see cref="P:System.Data.Common.DataColumnMapping.DataSetColumn" /> property.</summary>
		/// <param name="dataTable">The <see cref="T:System.Data.DataTable" /> to get the column from.</param>
		/// <param name="dataType">The <see cref="T:System.Type" /> of the data column.</param>
		/// <param name="schemaAction">One of the <see cref="T:System.Data.MissingSchemaAction" /> values.</param>
		/// <returns>A data column.</returns>
		// Token: 0x06000EE9 RID: 3817 RVA: 0x0004AA57 File Offset: 0x00048C57
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public DataColumn GetDataColumnBySchemaAction(DataTable dataTable, Type dataType, MissingSchemaAction schemaAction)
		{
			return DataColumnMapping.GetDataColumnBySchemaAction(this.SourceColumn, this.DataSetColumn, dataTable, dataType, schemaAction);
		}

		/// <summary>A static version of <see cref="M:System.Data.Common.DataColumnMapping.GetDataColumnBySchemaAction(System.Data.DataTable,System.Type,System.Data.MissingSchemaAction)" /> that can be called without instantiating a <see cref="T:System.Data.Common.DataColumnMapping" /> object.</summary>
		/// <param name="sourceColumn">The case-sensitive column name from a data source. </param>
		/// <param name="dataSetColumn">The column name, which is not case sensitive, from a <see cref="T:System.Data.DataSet" /> to map to. </param>
		/// <param name="dataTable">An instance of <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="dataType">The data type for the column being mapped.</param>
		/// <param name="schemaAction">Determines the action to take when existing <see cref="T:System.Data.DataSet" /> schema does not match incoming data.</param>
		/// <returns>A <see cref="T:System.Data.DataColumn" /> object.</returns>
		// Token: 0x06000EEA RID: 3818 RVA: 0x0004AA70 File Offset: 0x00048C70
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction)
		{
			if (dataTable == null)
			{
				throw ADP.ArgumentNull("dataTable");
			}
			if (string.IsNullOrEmpty(dataSetColumn))
			{
				return null;
			}
			DataColumnCollection columns = dataTable.Columns;
			int num = columns.IndexOf(dataSetColumn);
			if (0 > num || num >= columns.Count)
			{
				return DataColumnMapping.CreateDataColumnBySchemaAction(sourceColumn, dataSetColumn, dataTable, dataType, schemaAction);
			}
			DataColumn dataColumn = columns[num];
			if (!string.IsNullOrEmpty(dataColumn.Expression))
			{
				throw ADP.ColumnSchemaExpression(sourceColumn, dataSetColumn);
			}
			if (null == dataType || dataType.IsArray == dataColumn.DataType.IsArray)
			{
				return dataColumn;
			}
			throw ADP.ColumnSchemaMismatch(sourceColumn, dataType, dataColumn);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0004AB00 File Offset: 0x00048D00
		internal static DataColumn CreateDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction)
		{
			if (string.IsNullOrEmpty(dataSetColumn))
			{
				return null;
			}
			switch (schemaAction)
			{
			case MissingSchemaAction.Add:
			case MissingSchemaAction.AddWithKey:
				return new DataColumn(dataSetColumn, dataType);
			case MissingSchemaAction.Ignore:
				return null;
			case MissingSchemaAction.Error:
				throw ADP.ColumnSchemaMissing(dataSetColumn, dataTable.TableName, sourceColumn);
			default:
				throw ADP.InvalidMissingSchemaAction(schemaAction);
			}
		}

		/// <summary>Converts the current <see cref="P:System.Data.Common.DataColumnMapping.SourceColumn" /> name to a string.</summary>
		/// <returns>The current <see cref="P:System.Data.Common.DataColumnMapping.SourceColumn" /> name as a string.</returns>
		// Token: 0x06000EEC RID: 3820 RVA: 0x0004AB51 File Offset: 0x00048D51
		public override string ToString()
		{
			return this.SourceColumn;
		}

		// Token: 0x040004B5 RID: 1205
		private DataColumnMappingCollection _parent;

		// Token: 0x040004B6 RID: 1206
		private string _dataSetColumnName;

		// Token: 0x040004B7 RID: 1207
		private string _sourceColumnName;

		// Token: 0x020000DA RID: 218
		internal sealed class DataColumnMappingConverter : ExpandableObjectConverter
		{
			// Token: 0x06000EEE RID: 3822 RVA: 0x0004AB59 File Offset: 0x00048D59
			public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			{
				return typeof(InstanceDescriptor) == destinationType || base.CanConvertTo(context, destinationType);
			}

			// Token: 0x06000EEF RID: 3823 RVA: 0x0004AB78 File Offset: 0x00048D78
			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
			{
				if (null == destinationType)
				{
					throw ADP.ArgumentNull("destinationType");
				}
				if (typeof(InstanceDescriptor) == destinationType && value is DataColumnMapping)
				{
					DataColumnMapping dataColumnMapping = (DataColumnMapping)value;
					object[] arguments = new object[]
					{
						dataColumnMapping.SourceColumn,
						dataColumnMapping.DataSetColumn
					};
					Type[] types = new Type[]
					{
						typeof(string),
						typeof(string)
					};
					return new InstanceDescriptor(typeof(DataColumnMapping).GetConstructor(types), arguments);
				}
				return base.ConvertTo(context, culture, value, destinationType);
			}
		}
	}
}
