using System;
using System.ComponentModel;
using System.Data.ProviderBase;
using System.Globalization;
using System.Threading;

namespace System.Data.Common
{
	/// <summary>Represents a set of SQL commands and a database connection that are used to fill the <see cref="T:System.Data.DataSet" /> and update the data source.</summary>
	// Token: 0x020000D7 RID: 215
	public class DataAdapter : Component
	{
		/// <summary>Initializes a new instance of a <see cref="T:System.Data.Common.DataAdapter" /> class.</summary>
		// Token: 0x06000EC2 RID: 3778 RVA: 0x0004A354 File Offset: 0x00048554
		protected DataAdapter()
		{
			GC.SuppressFinalize(this);
		}

		/// <summary>Gets or sets a value indicating whether <see cref="M:System.Data.DataRow.AcceptChanges" /> is called on a <see cref="T:System.Data.DataRow" /> after it is added to the <see cref="T:System.Data.DataTable" /> during any of the Fill operations.</summary>
		/// <returns>
		///     <see langword="true" /> if <see cref="M:System.Data.DataRow.AcceptChanges" /> is called on the <see cref="T:System.Data.DataRow" />; otherwise <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0004A3A0 File Offset: 0x000485A0
		[DefaultValue(true)]
		public bool AcceptChangesDuringFill
		{
			get
			{
				return this._acceptChangesDuringFill;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Data.LoadOption" /> that determines how the adapter fills the <see cref="T:System.Data.DataTable" /> from the <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		/// <returns>A <see cref="T:System.Data.LoadOption" /> value.</returns>
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0004A3A8 File Offset: 0x000485A8
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x0004A3C7 File Offset: 0x000485C7
		[RefreshProperties(RefreshProperties.All)]
		public LoadOption FillLoadOption
		{
			get
			{
				if (this._fillLoadOption == (LoadOption)0)
				{
					return LoadOption.OverwriteChanges;
				}
				return this._fillLoadOption;
			}
			set
			{
				if (value <= LoadOption.Upsert)
				{
					this._fillLoadOption = value;
					return;
				}
				throw ADP.InvalidLoadOption(value);
			}
		}

		/// <summary>Determines whether the <see cref="P:System.Data.Common.DataAdapter.FillLoadOption" /> property should be persisted.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Data.Common.DataAdapter.FillLoadOption" /> property is persisted; otherwise <see langword="false" />.</returns>
		// Token: 0x06000EC6 RID: 3782 RVA: 0x0004A3DB File Offset: 0x000485DB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool ShouldSerializeFillLoadOption()
		{
			return this._fillLoadOption > (LoadOption)0;
		}

		/// <summary>Determines the action to take when incoming data does not have a matching table or column.</summary>
		/// <returns>One of the <see cref="T:System.Data.MissingMappingAction" /> values. The default is <see langword="Passthrough" />.</returns>
		/// <exception cref="T:System.ArgumentException">The value set is not one of the <see cref="T:System.Data.MissingMappingAction" /> values. </exception>
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0004A3E6 File Offset: 0x000485E6
		[DefaultValue(MissingMappingAction.Passthrough)]
		public MissingMappingAction MissingMappingAction
		{
			get
			{
				return this._missingMappingAction;
			}
		}

		/// <summary>Determines the action to take when existing <see cref="T:System.Data.DataSet" /> schema does not match incoming data.</summary>
		/// <returns>One of the <see cref="T:System.Data.MissingSchemaAction" /> values. The default is <see langword="Add" />.</returns>
		/// <exception cref="T:System.ArgumentException">The value set is not one of the <see cref="T:System.Data.MissingSchemaAction" /> values. </exception>
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0004A3EE File Offset: 0x000485EE
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x0004A3F6 File Offset: 0x000485F6
		[DefaultValue(MissingSchemaAction.Add)]
		public MissingSchemaAction MissingSchemaAction
		{
			get
			{
				return this._missingSchemaAction;
			}
			set
			{
				if (value - MissingSchemaAction.Add <= 3)
				{
					this._missingSchemaAction = value;
					return;
				}
				throw ADP.InvalidMissingSchemaAction(value);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0004A40C File Offset: 0x0004860C
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		/// <summary>Gets or sets whether the <see langword="Fill" /> method should return provider-specific values or common CLS-compliant values.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see langword="Fill" /> method should return provider-specific values; otherwise <see langword="false" /> to return common CLS-compliant values.</returns>
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0004A414 File Offset: 0x00048614
		[DefaultValue(false)]
		public virtual bool ReturnProviderSpecificTypes
		{
			get
			{
				return this._returnProviderSpecificTypes;
			}
		}

		/// <summary>Gets a collection that provides the master mapping between a source table and a <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>A collection that provides the master mapping between the returned records and the <see cref="T:System.Data.DataSet" />. The default value is an empty collection.</returns>
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0004A41C File Offset: 0x0004861C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataTableMappingCollection TableMappings
		{
			get
			{
				DataTableMappingCollection dataTableMappingCollection = this._tableMappings;
				if (dataTableMappingCollection == null)
				{
					dataTableMappingCollection = this.CreateTableMappings();
					if (dataTableMappingCollection == null)
					{
						dataTableMappingCollection = new DataTableMappingCollection();
					}
					this._tableMappings = dataTableMappingCollection;
				}
				return dataTableMappingCollection;
			}
		}

		/// <summary>Returned when an error occurs during a fill operation.</summary>
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000ECD RID: 3789 RVA: 0x0004A44B File Offset: 0x0004864B
		// (remove) Token: 0x06000ECE RID: 3790 RVA: 0x0004A465 File Offset: 0x00048665
		public event FillErrorEventHandler FillError
		{
			add
			{
				this._hasFillErrorHandler = true;
				base.Events.AddHandler(DataAdapter.s_eventFillError, value);
			}
			remove
			{
				base.Events.RemoveHandler(DataAdapter.s_eventFillError, value);
			}
		}

		/// <summary>Creates a new <see cref="T:System.Data.Common.DataTableMappingCollection" />.</summary>
		/// <returns>A new table mapping collection.</returns>
		// Token: 0x06000ECF RID: 3791 RVA: 0x0004A478 File Offset: 0x00048678
		protected virtual DataTableMappingCollection CreateTableMappings()
		{
			DataCommonEventSource.Log.Trace<int>("<comm.DataAdapter.CreateTableMappings|API> {0}", this.ObjectID);
			return new DataTableMappingCollection();
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Data.Common.DataAdapter" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06000ED0 RID: 3792 RVA: 0x0004A494 File Offset: 0x00048694
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._tableMappings = null;
			}
			base.Dispose(disposing);
		}

		/// <summary>Adds or refreshes rows in a specified range in the collection of <see cref="T:System.Data.DataTable" /> objects to match those in the data source.</summary>
		/// <param name="dataTables">A collection of <see cref="T:System.Data.DataTable" /> objects to fill with records.</param>
		/// <param name="dataReader">An instance of <see cref="T:System.Data.IDataReader" />.</param>
		/// <param name="startRecord">The zero-based index of the starting record.</param>
		/// <param name="maxRecords">An integer indicating the maximum number of records.</param>
		/// <returns>The number of rows successfully added to or refreshed in the <see cref="T:System.Data.DataTable" />. This does not include rows affected by statements that do not return rows.</returns>
		// Token: 0x06000ED1 RID: 3793 RVA: 0x0004A4A8 File Offset: 0x000486A8
		protected virtual int Fill(DataTable[] dataTables, IDataReader dataReader, int startRecord, int maxRecords)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<comm.DataAdapter.Fill|API> {0}, dataTables[], dataReader, startRecord, maxRecords", this.ObjectID);
			int result;
			try
			{
				ADP.CheckArgumentLength(dataTables, "dataTables");
				if (dataTables == null || dataTables.Length == 0 || dataTables[0] == null)
				{
					throw ADP.FillRequires("dataTable");
				}
				if (dataReader == null)
				{
					throw ADP.FillRequires("dataReader");
				}
				if (1 < dataTables.Length && (startRecord != 0 || maxRecords != 0))
				{
					throw ADP.NotSupported();
				}
				int num = 0;
				bool flag = false;
				DataSet dataSet = dataTables[0].DataSet;
				try
				{
					if (dataSet != null)
					{
						flag = dataSet.EnforceConstraints;
						dataSet.EnforceConstraints = false;
					}
					int num2 = 0;
					while (num2 < dataTables.Length && !dataReader.IsClosed)
					{
						DataReaderContainer dataReaderContainer = DataReaderContainer.Create(dataReader, this.ReturnProviderSpecificTypes);
						if (dataReaderContainer.FieldCount > 0)
						{
							goto IL_BC;
						}
						if (num2 == 0)
						{
							bool flag2;
							do
							{
								flag2 = this.FillNextResult(dataReaderContainer);
							}
							while (flag2 && dataReaderContainer.FieldCount <= 0);
							if (flag2)
							{
								goto IL_BC;
							}
							break;
						}
						IL_E7:
						num2++;
						continue;
						IL_BC:
						if (0 < num2 && !this.FillNextResult(dataReaderContainer))
						{
							break;
						}
						int num3 = this.FillFromReader(null, dataTables[num2], null, dataReaderContainer, startRecord, maxRecords, null, null);
						if (num2 == 0)
						{
							num = num3;
							goto IL_E7;
						}
						goto IL_E7;
					}
				}
				catch (ConstraintException)
				{
					flag = false;
					throw;
				}
				finally
				{
					if (flag)
					{
						dataSet.EnforceConstraints = true;
					}
				}
				result = num;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0004A5F8 File Offset: 0x000487F8
		internal int FillFromReader(DataSet dataset, DataTable datatable, string srcTable, DataReaderContainer dataReader, int startRecord, int maxRecords, DataColumn parentChapterColumn, object parentChapterValue)
		{
			int result = 0;
			int num = 0;
			do
			{
				if (0 < dataReader.FieldCount)
				{
					SchemaMapping schemaMapping = this.FillMapping(dataset, datatable, srcTable, dataReader, num, parentChapterColumn, parentChapterValue);
					num++;
					if (schemaMapping != null && schemaMapping.DataValues != null && schemaMapping.DataTable != null)
					{
						schemaMapping.DataTable.BeginLoadData();
						try
						{
							if (1 == num && (0 < startRecord || 0 < maxRecords))
							{
								result = this.FillLoadDataRowChunk(schemaMapping, startRecord, maxRecords);
							}
							else
							{
								int num2 = this.FillLoadDataRow(schemaMapping);
								if (1 == num)
								{
									result = num2;
								}
							}
						}
						finally
						{
							schemaMapping.DataTable.EndLoadData();
						}
						if (datatable != null)
						{
							break;
						}
					}
				}
			}
			while (this.FillNextResult(dataReader));
			return result;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0004A6A0 File Offset: 0x000488A0
		private int FillLoadDataRowChunk(SchemaMapping mapping, int startRecord, int maxRecords)
		{
			DataReaderContainer dataReader = mapping.DataReader;
			while (0 < startRecord)
			{
				if (!dataReader.Read())
				{
					return 0;
				}
				startRecord--;
			}
			int i = 0;
			if (0 < maxRecords)
			{
				while (i < maxRecords)
				{
					if (!dataReader.Read())
					{
						break;
					}
					if (this._hasFillErrorHandler)
					{
						try
						{
							mapping.LoadDataRowWithClear();
							i++;
							continue;
						}
						catch (Exception e) when (ADP.IsCatchableExceptionType(e))
						{
							ADP.TraceExceptionForCapture(e);
							this.OnFillErrorHandler(e, mapping.DataTable, mapping.DataValues);
							continue;
						}
					}
					mapping.LoadDataRow();
					i++;
				}
			}
			else
			{
				i = this.FillLoadDataRow(mapping);
			}
			return i;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0004A74C File Offset: 0x0004894C
		private int FillLoadDataRow(SchemaMapping mapping)
		{
			int num = 0;
			DataReaderContainer dataReader = mapping.DataReader;
			if (this._hasFillErrorHandler)
			{
				while (dataReader.Read())
				{
					try
					{
						mapping.LoadDataRowWithClear();
						num++;
					}
					catch (Exception e) when (ADP.IsCatchableExceptionType(e))
					{
						ADP.TraceExceptionForCapture(e);
						this.OnFillErrorHandler(e, mapping.DataTable, mapping.DataValues);
					}
				}
			}
			else
			{
				while (dataReader.Read())
				{
					mapping.LoadDataRow();
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0004A7DC File Offset: 0x000489DC
		private SchemaMapping FillMappingInternal(DataSet dataset, DataTable datatable, string srcTable, DataReaderContainer dataReader, int schemaCount, DataColumn parentChapterColumn, object parentChapterValue)
		{
			bool keyInfo = MissingSchemaAction.AddWithKey == this.MissingSchemaAction;
			string sourceTableName = null;
			if (dataset != null)
			{
				sourceTableName = DataAdapter.GetSourceTableName(srcTable, schemaCount);
			}
			return new SchemaMapping(this, dataset, datatable, dataReader, keyInfo, SchemaType.Mapped, sourceTableName, true, parentChapterColumn, parentChapterValue);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0004A814 File Offset: 0x00048A14
		private SchemaMapping FillMapping(DataSet dataset, DataTable datatable, string srcTable, DataReaderContainer dataReader, int schemaCount, DataColumn parentChapterColumn, object parentChapterValue)
		{
			SchemaMapping result = null;
			if (this._hasFillErrorHandler)
			{
				try
				{
					return this.FillMappingInternal(dataset, datatable, srcTable, dataReader, schemaCount, parentChapterColumn, parentChapterValue);
				}
				catch (Exception e) when (ADP.IsCatchableExceptionType(e))
				{
					ADP.TraceExceptionForCapture(e);
					this.OnFillErrorHandler(e, null, null);
					return result;
				}
			}
			result = this.FillMappingInternal(dataset, datatable, srcTable, dataReader, schemaCount, parentChapterColumn, parentChapterValue);
			return result;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0004A88C File Offset: 0x00048A8C
		private bool FillNextResult(DataReaderContainer dataReader)
		{
			bool result = true;
			if (this._hasFillErrorHandler)
			{
				try
				{
					return dataReader.NextResult();
				}
				catch (Exception e) when (ADP.IsCatchableExceptionType(e))
				{
					ADP.TraceExceptionForCapture(e);
					this.OnFillErrorHandler(e, null, null);
					return result;
				}
			}
			result = dataReader.NextResult();
			return result;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0004A8F0 File Offset: 0x00048AF0
		internal DataTableMapping GetTableMappingBySchemaAction(string sourceTableName, string dataSetTableName, MissingMappingAction mappingAction)
		{
			return DataTableMappingCollection.GetTableMappingBySchemaAction(this._tableMappings, sourceTableName, dataSetTableName, mappingAction);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0004A900 File Offset: 0x00048B00
		internal int IndexOfDataSetTable(string dataSetTable)
		{
			if (this._tableMappings != null)
			{
				return this.TableMappings.IndexOfDataSetTable(dataSetTable);
			}
			return -1;
		}

		/// <summary>Invoked when an error occurs during a <see langword="Fill" />.</summary>
		/// <param name="value">A <see cref="T:System.Data.FillErrorEventArgs" /> object.</param>
		// Token: 0x06000EDA RID: 3802 RVA: 0x0004A918 File Offset: 0x00048B18
		protected virtual void OnFillError(FillErrorEventArgs value)
		{
			FillErrorEventHandler fillErrorEventHandler = (FillErrorEventHandler)base.Events[DataAdapter.s_eventFillError];
			if (fillErrorEventHandler == null)
			{
				return;
			}
			fillErrorEventHandler(this, value);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0004A93C File Offset: 0x00048B3C
		private void OnFillErrorHandler(Exception e, DataTable dataTable, object[] dataValues)
		{
			FillErrorEventArgs fillErrorEventArgs = new FillErrorEventArgs(dataTable, dataValues);
			fillErrorEventArgs.Errors = e;
			this.OnFillError(fillErrorEventArgs);
			if (fillErrorEventArgs.Continue)
			{
				return;
			}
			if (fillErrorEventArgs.Errors != null)
			{
				throw fillErrorEventArgs.Errors;
			}
			throw e;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0004A978 File Offset: 0x00048B78
		private static string GetSourceTableName(string srcTable, int index)
		{
			if (index == 0)
			{
				return srcTable;
			}
			return srcTable + index.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x040004A9 RID: 1193
		private static readonly object s_eventFillError = new object();

		// Token: 0x040004AA RID: 1194
		private bool _acceptChangesDuringUpdate = true;

		// Token: 0x040004AB RID: 1195
		private bool _acceptChangesDuringUpdateAfterInsert = true;

		// Token: 0x040004AC RID: 1196
		private bool _hasFillErrorHandler;

		// Token: 0x040004AD RID: 1197
		private bool _returnProviderSpecificTypes;

		// Token: 0x040004AE RID: 1198
		private bool _acceptChangesDuringFill = true;

		// Token: 0x040004AF RID: 1199
		private LoadOption _fillLoadOption;

		// Token: 0x040004B0 RID: 1200
		private MissingMappingAction _missingMappingAction = MissingMappingAction.Passthrough;

		// Token: 0x040004B1 RID: 1201
		private MissingSchemaAction _missingSchemaAction = MissingSchemaAction.Add;

		// Token: 0x040004B2 RID: 1202
		private DataTableMappingCollection _tableMappings;

		// Token: 0x040004B3 RID: 1203
		private static int s_objectTypeCount;

		// Token: 0x040004B4 RID: 1204
		internal readonly int _objectID = Interlocked.Increment(ref DataAdapter.s_objectTypeCount);
	}
}
