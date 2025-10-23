using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace System.Data.Common
{
	/// <summary>Contains a description of a mapped relationship between a source table and a <see cref="T:System.Data.DataTable" />. This class is used by a <see cref="T:System.Data.Common.DataAdapter" /> when populating a <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x020000E0 RID: 224
	[TypeConverter(typeof(DataTableMapping.DataTableMappingConverter))]
	public sealed class DataTableMapping : MarshalByRefObject, ICloneable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.Common.DataTableMapping" /> class.</summary>
		// Token: 0x06000F59 RID: 3929 RVA: 0x0004A9B2 File Offset: 0x00048BB2
		public DataTableMapping()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.Common.DataTableMapping" /> class with a source when given a source table name and a <see cref="T:System.Data.DataTable" /> name.</summary>
		/// <param name="sourceTable">The case-sensitive source table name from a data source. </param>
		/// <param name="dataSetTable">The table name from a <see cref="T:System.Data.DataSet" /> to map to. </param>
		// Token: 0x06000F5A RID: 3930 RVA: 0x0004BBB4 File Offset: 0x00049DB4
		public DataTableMapping(string sourceTable, string dataSetTable)
		{
			this.SourceTable = sourceTable;
			this.DataSetTable = dataSetTable;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.Common.DataTableMapping" /> class when given a source table name, a <see cref="T:System.Data.DataTable" /> name, and an array of <see cref="T:System.Data.Common.DataColumnMapping" /> objects.</summary>
		/// <param name="sourceTable">The case-sensitive source table name from a data source. </param>
		/// <param name="dataSetTable">The table name from a <see cref="T:System.Data.DataSet" /> to map to. </param>
		/// <param name="columnMappings">An array of <see cref="T:System.Data.Common.DataColumnMapping" /> objects. </param>
		// Token: 0x06000F5B RID: 3931 RVA: 0x0004BBCA File Offset: 0x00049DCA
		public DataTableMapping(string sourceTable, string dataSetTable, DataColumnMapping[] columnMappings)
		{
			this.SourceTable = sourceTable;
			this.DataSetTable = dataSetTable;
			if (columnMappings != null && columnMappings.Length != 0)
			{
				this.ColumnMappings.AddRange(columnMappings);
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.Common.DataColumnMappingCollection" /> for the <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>A data column mapping collection.</returns>
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0004BBF4 File Offset: 0x00049DF4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataColumnMappingCollection ColumnMappings
		{
			get
			{
				DataColumnMappingCollection dataColumnMappingCollection = this._columnMappings;
				if (dataColumnMappingCollection == null)
				{
					dataColumnMappingCollection = new DataColumnMappingCollection();
					this._columnMappings = dataColumnMappingCollection;
				}
				return dataColumnMappingCollection;
			}
		}

		/// <summary>Gets or sets the table name from a <see cref="T:System.Data.DataSet" />.</summary>
		/// <returns>The table name from a <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0004BC19 File Offset: 0x00049E19
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x0004BC2A File Offset: 0x00049E2A
		[DefaultValue("")]
		public string DataSetTable
		{
			get
			{
				return this._dataSetTableName ?? string.Empty;
			}
			set
			{
				this._dataSetTableName = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0004BC33 File Offset: 0x00049E33
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x0004BC3B File Offset: 0x00049E3B
		internal DataTableMappingCollection Parent
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

		/// <summary>Gets or sets the case-sensitive source table name from a data source.</summary>
		/// <returns>The case-sensitive source table name from a data source.</returns>
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0004BC44 File Offset: 0x00049E44
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x0004BC55 File Offset: 0x00049E55
		[DefaultValue("")]
		public string SourceTable
		{
			get
			{
				return this._sourceTableName ?? string.Empty;
			}
			set
			{
				if (this.Parent != null && ADP.SrcCompare(this._sourceTableName, value) != 0)
				{
					this.Parent.ValidateSourceTable(-1, value);
				}
				this._sourceTableName = value;
			}
		}

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of the current instance.</returns>
		// Token: 0x06000F63 RID: 3939 RVA: 0x0004BC84 File Offset: 0x00049E84
		object ICloneable.Clone()
		{
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping._dataSetTableName = this._dataSetTableName;
			dataTableMapping._sourceTableName = this._sourceTableName;
			if (this._columnMappings != null && 0 < this.ColumnMappings.Count)
			{
				DataColumnMappingCollection columnMappings = dataTableMapping.ColumnMappings;
				foreach (object obj in this.ColumnMappings)
				{
					ICloneable cloneable = (ICloneable)obj;
					columnMappings.Add(cloneable.Clone());
				}
			}
			return dataTableMapping;
		}

		/// <summary>Returns a <see cref="T:System.Data.DataColumn" /> object for a given column name.</summary>
		/// <param name="sourceColumn">The name of the <see cref="T:System.Data.DataColumn" />. </param>
		/// <param name="dataType">The data type for <paramref name="sourceColumn" />.</param>
		/// <param name="dataTable">The table name from a <see cref="T:System.Data.DataSet" /> to map to. </param>
		/// <param name="mappingAction">One of the <see cref="T:System.Data.MissingMappingAction" /> values. </param>
		/// <param name="schemaAction">One of the <see cref="T:System.Data.MissingSchemaAction" /> values. </param>
		/// <returns>A <see cref="T:System.Data.DataColumn" /> object.</returns>
		// Token: 0x06000F64 RID: 3940 RVA: 0x0004BD24 File Offset: 0x00049F24
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public DataColumn GetDataColumn(string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction)
		{
			return DataColumnMappingCollection.GetDataColumn(this._columnMappings, sourceColumn, dataType, dataTable, mappingAction, schemaAction);
		}

		/// <summary>Gets the current <see cref="T:System.Data.DataTable" /> for the specified <see cref="T:System.Data.DataSet" /> using the specified <see cref="T:System.Data.MissingSchemaAction" /> value.</summary>
		/// <param name="dataSet">The <see cref="T:System.Data.DataSet" /> from which to get the <see cref="T:System.Data.DataTable" />. </param>
		/// <param name="schemaAction">One of the <see cref="T:System.Data.MissingSchemaAction" /> values. </param>
		/// <returns>A data table.</returns>
		// Token: 0x06000F65 RID: 3941 RVA: 0x0004BD38 File Offset: 0x00049F38
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public DataTable GetDataTableBySchemaAction(DataSet dataSet, MissingSchemaAction schemaAction)
		{
			if (dataSet == null)
			{
				throw ADP.ArgumentNull("dataSet");
			}
			string dataSetTable = this.DataSetTable;
			if (string.IsNullOrEmpty(dataSetTable))
			{
				return null;
			}
			DataTableCollection tables = dataSet.Tables;
			int num = tables.IndexOf(dataSetTable);
			if (0 <= num && num < tables.Count)
			{
				return tables[num];
			}
			switch (schemaAction)
			{
			case MissingSchemaAction.Add:
			case MissingSchemaAction.AddWithKey:
				return new DataTable(dataSetTable);
			case MissingSchemaAction.Ignore:
				return null;
			case MissingSchemaAction.Error:
				throw ADP.MissingTableSchema(dataSetTable, this.SourceTable);
			default:
				throw ADP.InvalidMissingSchemaAction(schemaAction);
			}
		}

		/// <summary>Converts the current <see cref="P:System.Data.Common.DataTableMapping.SourceTable" /> name to a string.</summary>
		/// <returns>The current <see cref="P:System.Data.Common.DataTableMapping.SourceTable" /> name, as a string.</returns>
		// Token: 0x06000F66 RID: 3942 RVA: 0x0004BDBE File Offset: 0x00049FBE
		public override string ToString()
		{
			return this.SourceTable;
		}

		// Token: 0x040004F8 RID: 1272
		private DataTableMappingCollection _parent;

		// Token: 0x040004F9 RID: 1273
		private DataColumnMappingCollection _columnMappings;

		// Token: 0x040004FA RID: 1274
		private string _dataSetTableName;

		// Token: 0x040004FB RID: 1275
		private string _sourceTableName;

		// Token: 0x020000E1 RID: 225
		internal sealed class DataTableMappingConverter : ExpandableObjectConverter
		{
			// Token: 0x06000F68 RID: 3944 RVA: 0x0004AB59 File Offset: 0x00048D59
			public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			{
				return typeof(InstanceDescriptor) == destinationType || base.CanConvertTo(context, destinationType);
			}

			// Token: 0x06000F69 RID: 3945 RVA: 0x0004BDC8 File Offset: 0x00049FC8
			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
			{
				if (null == destinationType)
				{
					throw ADP.ArgumentNull("destinationType");
				}
				if (typeof(InstanceDescriptor) == destinationType && value is DataTableMapping)
				{
					DataTableMapping dataTableMapping = (DataTableMapping)value;
					DataColumnMapping[] array = new DataColumnMapping[dataTableMapping.ColumnMappings.Count];
					dataTableMapping.ColumnMappings.CopyTo(array, 0);
					object[] arguments = new object[]
					{
						dataTableMapping.SourceTable,
						dataTableMapping.DataSetTable,
						array
					};
					Type[] types = new Type[]
					{
						typeof(string),
						typeof(string),
						typeof(DataColumnMapping[])
					};
					return new InstanceDescriptor(typeof(DataTableMapping).GetConstructor(types), arguments);
				}
				return base.ConvertTo(context, culture, value, destinationType);
			}
		}
	}
}
