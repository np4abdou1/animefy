using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data
{
	/// <summary>Represents the schema of a column in a <see cref="T:System.Data.DataTable" />.</summary>
	// Token: 0x0200000F RID: 15
	[ToolboxItem(false)]
	[DesignTimeVisible(false)]
	[DefaultProperty("ColumnName")]
	public class DataColumn : MarshalByValueComponent
	{
		/// <summary>Initializes a new instance of a <see cref="T:System.Data.DataColumn" /> class as type string.</summary>
		// Token: 0x0600006C RID: 108 RVA: 0x0000394D File Offset: 0x00001B4D
		public DataColumn() : this(null, typeof(string), null, MappingType.Element)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataColumn" /> class using the specified column name and data type.</summary>
		/// <param name="columnName">A string that represents the name of the column to be created. If set to <see langword="null" /> or an empty string (""), a default name will be specified when added to the columns collection. </param>
		/// <param name="dataType">A supported <see cref="P:System.Data.DataColumn.DataType" />. </param>
		/// <exception cref="T:System.ArgumentNullException">No <paramref name="dataType" /> was specified. </exception>
		// Token: 0x0600006D RID: 109 RVA: 0x00003962 File Offset: 0x00001B62
		public DataColumn(string columnName, Type dataType) : this(columnName, dataType, null, MappingType.Element)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataColumn" /> class using the specified name, data type, expression, and value that determines whether the column is an attribute.</summary>
		/// <param name="columnName">A string that represents the name of the column to be created. If set to <see langword="null" /> or an empty string (""), a default name will be specified when added to the columns collection. </param>
		/// <param name="dataType">A supported <see cref="P:System.Data.DataColumn.DataType" />. </param>
		/// <param name="expr">The expression used to create this column. For more information, see the <see cref="P:System.Data.DataColumn.Expression" /> property. </param>
		/// <param name="type">One of the <see cref="T:System.Data.MappingType" /> values. </param>
		/// <exception cref="T:System.ArgumentNullException">No <paramref name="dataType" /> was specified. </exception>
		// Token: 0x0600006E RID: 110 RVA: 0x00003970 File Offset: 0x00001B70
		public DataColumn(string columnName, Type dataType, string expr, MappingType type)
		{
			GC.SuppressFinalize(this);
			DataCommonEventSource.Log.Trace<int, string, string, MappingType>("<ds.DataColumn.DataColumn|API> {0}, columnName='{1}', expr='{2}', type={3}", this.ObjectID, columnName, expr, type);
			if (dataType == null)
			{
				throw ExceptionBuilder.ArgumentNull("dataType");
			}
			StorageType storageType = DataStorage.GetStorageType(dataType);
			if (DataStorage.ImplementsINullableValue(storageType, dataType))
			{
				throw ExceptionBuilder.ColumnTypeNotSupported();
			}
			this._columnName = (columnName ?? string.Empty);
			SimpleType simpleType = SimpleType.CreateSimpleType(storageType, dataType);
			if (simpleType != null)
			{
				this.SimpleType = simpleType;
			}
			this.UpdateColumnType(dataType, storageType);
			if (!string.IsNullOrEmpty(expr))
			{
				this.Expression = expr;
			}
			this._columnMapping = type;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003A68 File Offset: 0x00001C68
		private void UpdateColumnType(Type type, StorageType typeCode)
		{
			this._dataType = type;
			this._storageType = typeCode;
			if (StorageType.DateTime != typeCode)
			{
				this._dateTimeMode = DataSetDateTime.UnspecifiedLocal;
			}
			DataStorage.ImplementsInterfaces(typeCode, type, out this._isSqlType, out this._implementsINullable, out this._implementsIXMLSerializable, out this._implementsIChangeTracking, out this._implementsIRevertibleChangeTracking);
			if (!this._isSqlType && this._implementsINullable)
			{
				SqlUdtStorage.GetStaticNullForUdtType(type);
			}
		}

		/// <summary>Gets or sets a value that indicates whether null values are allowed in this column for rows that belong to the table.</summary>
		/// <returns>
		///     <see langword="true" /> if null values values are allowed; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003ACB File Offset: 0x00001CCB
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00003AD4 File Offset: 0x00001CD4
		[DefaultValue(true)]
		public bool AllowDBNull
		{
			get
			{
				return this._allowNull;
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, bool>("<ds.DataColumn.set_AllowDBNull|API> {0}, {1}", this.ObjectID, value);
				try
				{
					if (this._allowNull != value)
					{
						if (this._table != null && !value && this._table.EnforceConstraints)
						{
							this.CheckNotAllowNull();
						}
						this._allowNull = value;
					}
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		/// <summary>Gets or sets a value that indicates whether the column automatically increments the value of the column for new rows added to the table.</summary>
		/// <returns>
		///     <see langword="true" /> if the value of the column increments automatically; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">The column is a computed column. </exception>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003B44 File Offset: 0x00001D44
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00003B5C File Offset: 0x00001D5C
		[DefaultValue(false)]
		[RefreshProperties(RefreshProperties.All)]
		public bool AutoIncrement
		{
			get
			{
				return this._autoInc != null && this._autoInc.Auto;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, bool>("<ds.DataColumn.set_AutoIncrement|API> {0}, {1}", this.ObjectID, value);
				if (this.AutoIncrement != value)
				{
					if (value)
					{
						if (this._expression != null)
						{
							throw ExceptionBuilder.AutoIncrementAndExpression();
						}
						if (!this.DefaultValueIsNull)
						{
							throw ExceptionBuilder.AutoIncrementAndDefaultValue();
						}
						if (!DataColumn.IsAutoIncrementType(this.DataType))
						{
							if (this.HasData)
							{
								throw ExceptionBuilder.AutoIncrementCannotSetIfHasData(this.DataType.Name);
							}
							this.DataType = typeof(int);
						}
					}
					this.AutoInc.Auto = value;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003BE9 File Offset: 0x00001DE9
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00003C0A File Offset: 0x00001E0A
		internal object AutoIncrementCurrent
		{
			get
			{
				if (this._autoInc == null)
				{
					return this.AutoIncrementSeed;
				}
				return this._autoInc.Current;
			}
			set
			{
				if (this.AutoIncrementSeed != BigIntegerStorage.ConvertToBigInteger(value, this.FormatProvider))
				{
					this.AutoInc.SetCurrent(value, this.FormatProvider);
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003C3C File Offset: 0x00001E3C
		internal AutoIncrementValue AutoInc
		{
			get
			{
				AutoIncrementValue result;
				if ((result = this._autoInc) == null)
				{
					result = (this._autoInc = ((this.DataType == typeof(BigInteger)) ? new AutoIncrementBigInteger() : new AutoIncrementInt64()));
				}
				return result;
			}
		}

		/// <summary>Gets or sets the starting value for a column that has its <see cref="P:System.Data.DataColumn.AutoIncrement" /> property set to <see langword="true" />. The default is 0.</summary>
		/// <returns>The starting value for the <see cref="P:System.Data.DataColumn.AutoIncrement" /> feature.</returns>
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003C7F File Offset: 0x00001E7F
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00003C97 File Offset: 0x00001E97
		[DefaultValue(0L)]
		public long AutoIncrementSeed
		{
			get
			{
				if (this._autoInc == null)
				{
					return 0L;
				}
				return this._autoInc.Seed;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, long>("<ds.DataColumn.set_AutoIncrementSeed|API> {0}, {1}", this.ObjectID, value);
				if (this.AutoIncrementSeed != value)
				{
					this.AutoInc.Seed = value;
				}
			}
		}

		/// <summary>Gets or sets the increment used by a column with its <see cref="P:System.Data.DataColumn.AutoIncrement" /> property set to <see langword="true" />.</summary>
		/// <returns>The number by which the value of the column is automatically incremented. The default is 1.</returns>
		/// <exception cref="T:System.ArgumentException">The value set is zero. </exception>
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003CC4 File Offset: 0x00001EC4
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00003CDC File Offset: 0x00001EDC
		[DefaultValue(1L)]
		public long AutoIncrementStep
		{
			get
			{
				if (this._autoInc == null)
				{
					return 1L;
				}
				return this._autoInc.Step;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, long>("<ds.DataColumn.set_AutoIncrementStep|API> {0}, {1}", this.ObjectID, value);
				if (this.AutoIncrementStep != value)
				{
					this.AutoInc.Step = value;
				}
			}
		}

		/// <summary>Gets or sets the caption for the column.</summary>
		/// <returns>The caption of the column. If not set, returns the <see cref="P:System.Data.DataColumn.ColumnName" /> value.</returns>
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003D09 File Offset: 0x00001F09
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00003D20 File Offset: 0x00001F20
		public string Caption
		{
			get
			{
				if (this._caption == null)
				{
					return this._columnName;
				}
				return this._caption;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				if (this._caption == null || string.Compare(this._caption, value, true, this.Locale) != 0)
				{
					this._caption = value;
				}
			}
		}

		/// <summary>Gets or sets the name of the column in the <see cref="T:System.Data.DataColumnCollection" />.</summary>
		/// <returns>The name of the column.</returns>
		/// <exception cref="T:System.ArgumentException">The property is set to <see langword="null" /> or an empty string and the column belongs to a collection. </exception>
		/// <exception cref="T:System.Data.DuplicateNameException">A column with the same name already exists in the collection. The name comparison is not case sensitive. </exception>
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003D50 File Offset: 0x00001F50
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00003D58 File Offset: 0x00001F58
		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue("")]
		public string ColumnName
		{
			get
			{
				return this._columnName;
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, string>("<ds.DataColumn.set_ColumnName|API> {0}, '{1}'", this.ObjectID, value);
				try
				{
					if (value == null)
					{
						value = string.Empty;
					}
					if (string.Compare(this._columnName, value, true, this.Locale) != 0)
					{
						if (this._table != null)
						{
							if (value.Length == 0)
							{
								throw ExceptionBuilder.ColumnNameRequired();
							}
							this._table.Columns.RegisterColumnName(value, this);
							if (this._columnName.Length != 0)
							{
								this._table.Columns.UnregisterName(this._columnName);
							}
						}
						this.RaisePropertyChanging("ColumnName");
						this._columnName = value;
						this._encodedColumnName = null;
						if (this._table != null)
						{
							this._table.Columns.OnColumnPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, this));
						}
					}
					else if (this._columnName != value)
					{
						this.RaisePropertyChanging("ColumnName");
						this._columnName = value;
						this._encodedColumnName = null;
						if (this._table != null)
						{
							this._table.Columns.OnColumnPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, this));
						}
					}
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003E88 File Offset: 0x00002088
		internal string EncodedColumnName
		{
			get
			{
				if (this._encodedColumnName == null)
				{
					this._encodedColumnName = XmlConvert.EncodeLocalName(this.ColumnName);
				}
				return this._encodedColumnName;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003EAC File Offset: 0x000020AC
		internal IFormatProvider FormatProvider
		{
			get
			{
				if (this._table == null)
				{
					return CultureInfo.CurrentCulture;
				}
				return this._table.FormatProvider;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00003ED4 File Offset: 0x000020D4
		internal CultureInfo Locale
		{
			get
			{
				if (this._table == null)
				{
					return CultureInfo.CurrentCulture;
				}
				return this._table.Locale;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003EEF File Offset: 0x000020EF
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		/// <summary>Gets or sets an XML prefix that aliases the namespace of the <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>The XML prefix for the <see cref="T:System.Data.DataTable" /> namespace.</returns>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003EF7 File Offset: 0x000020F7
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00003F00 File Offset: 0x00002100
		[DefaultValue("")]
		public string Prefix
		{
			get
			{
				return this._columnPrefix;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				DataCommonEventSource.Log.Trace<int, string>("<ds.DataColumn.set_Prefix|API> {0}, '{1}'", this.ObjectID, value);
				if (XmlConvert.DecodeName(value) == value && XmlConvert.EncodeName(value) != value)
				{
					throw ExceptionBuilder.InvalidPrefix(value);
				}
				this._columnPrefix = value;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003F58 File Offset: 0x00002158
		internal string GetColumnValueAsString(DataRow row, DataRowVersion version)
		{
			object value = this[row.GetRecordFromVersion(version)];
			if (DataStorage.IsObjectNull(value))
			{
				return null;
			}
			return this.ConvertObjectToXml(value);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003F84 File Offset: 0x00002184
		internal bool Computed
		{
			get
			{
				return this._expression != null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003F8F File Offset: 0x0000218F
		internal DataExpression DataExpression
		{
			get
			{
				return this._expression;
			}
		}

		/// <summary>Gets or sets the type of data stored in the column.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the column data type.</returns>
		/// <exception cref="T:System.ArgumentException">The column already has data stored. </exception>
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003F97 File Offset: 0x00002197
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00003FA0 File Offset: 0x000021A0
		[DefaultValue(typeof(string))]
		[RefreshProperties(RefreshProperties.All)]
		[TypeConverter(typeof(ColumnTypeConverter))]
		public Type DataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				if (this._dataType != value)
				{
					if (this.HasData)
					{
						throw ExceptionBuilder.CantChangeDataType();
					}
					if (value == null)
					{
						throw ExceptionBuilder.NullDataType();
					}
					StorageType storageType = DataStorage.GetStorageType(value);
					if (DataStorage.ImplementsINullableValue(storageType, value))
					{
						throw ExceptionBuilder.ColumnTypeNotSupported();
					}
					if (this._table != null && this.IsInRelation())
					{
						throw ExceptionBuilder.ColumnsTypeMismatch();
					}
					if (storageType == StorageType.BigInteger && this._expression != null)
					{
						throw ExprException.UnsupportedDataType(value);
					}
					if (!this.DefaultValueIsNull)
					{
						try
						{
							if (this._defaultValue is BigInteger)
							{
								this._defaultValue = BigIntegerStorage.ConvertFromBigInteger((BigInteger)this._defaultValue, value, this.FormatProvider);
							}
							else if (typeof(BigInteger) == value)
							{
								this._defaultValue = BigIntegerStorage.ConvertToBigInteger(this._defaultValue, this.FormatProvider);
							}
							else if (typeof(string) == value)
							{
								this._defaultValue = this.DefaultValue.ToString();
							}
							else if (typeof(SqlString) == value)
							{
								this._defaultValue = SqlConvert.ConvertToSqlString(this.DefaultValue);
							}
							else if (typeof(object) != value)
							{
								this.DefaultValue = SqlConvert.ChangeTypeForDefaultValue(this.DefaultValue, value, this.FormatProvider);
							}
						}
						catch (InvalidCastException inner)
						{
							throw ExceptionBuilder.DefaultValueDataType(this.ColumnName, this.DefaultValue.GetType(), value, inner);
						}
						catch (FormatException inner2)
						{
							throw ExceptionBuilder.DefaultValueDataType(this.ColumnName, this.DefaultValue.GetType(), value, inner2);
						}
					}
					if (this.ColumnMapping == MappingType.SimpleContent && value == typeof(char))
					{
						throw ExceptionBuilder.CannotSetSimpleContentType(this.ColumnName, value);
					}
					this.SimpleType = SimpleType.CreateSimpleType(storageType, value);
					if (StorageType.String == storageType)
					{
						this._maxLength = -1;
					}
					this.UpdateColumnType(value, storageType);
					this.XmlDataType = null;
					if (this.AutoIncrement)
					{
						if (!DataColumn.IsAutoIncrementType(value))
						{
							this.AutoIncrement = false;
						}
						if (this._autoInc != null)
						{
							AutoIncrementValue autoInc = this._autoInc;
							this._autoInc = null;
							this.AutoInc.Auto = autoInc.Auto;
							this.AutoInc.Seed = autoInc.Seed;
							this.AutoInc.Step = autoInc.Step;
							if (this._autoInc.DataType == autoInc.DataType)
							{
								this._autoInc.Current = autoInc.Current;
								return;
							}
							if (autoInc.DataType == typeof(long))
							{
								this.AutoInc.Current = (long)autoInc.Current;
								return;
							}
							this.AutoInc.Current = (long)((BigInteger)autoInc.Current);
						}
					}
				}
			}
		}

		/// <summary>Gets or sets the <see langword="DateTimeMode" /> for the column.</summary>
		/// <returns>The <see cref="T:System.Data.DataSetDateTime" /> for the specified column.</returns>
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004288 File Offset: 0x00002488
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00004290 File Offset: 0x00002490
		[DefaultValue(DataSetDateTime.UnspecifiedLocal)]
		[RefreshProperties(RefreshProperties.All)]
		public DataSetDateTime DateTimeMode
		{
			get
			{
				return this._dateTimeMode;
			}
			set
			{
				if (this._dateTimeMode != value)
				{
					if (this.DataType != typeof(DateTime) && value != DataSetDateTime.UnspecifiedLocal)
					{
						throw ExceptionBuilder.CannotSetDateTimeModeForNonDateTimeColumns();
					}
					switch (value)
					{
					case DataSetDateTime.Local:
					case DataSetDateTime.Utc:
						if (this.HasData)
						{
							throw ExceptionBuilder.CantChangeDateTimeMode(this._dateTimeMode, value);
						}
						break;
					case DataSetDateTime.Unspecified:
					case DataSetDateTime.UnspecifiedLocal:
						if (this._dateTimeMode != DataSetDateTime.Unspecified && this._dateTimeMode != DataSetDateTime.UnspecifiedLocal && this.HasData)
						{
							throw ExceptionBuilder.CantChangeDateTimeMode(this._dateTimeMode, value);
						}
						break;
					default:
						throw ExceptionBuilder.InvalidDateTimeMode(value);
					}
					this._dateTimeMode = value;
				}
			}
		}

		/// <summary>Gets or sets the default value for the column when you are creating new rows.</summary>
		/// <returns>A value appropriate to the column's <see cref="P:System.Data.DataColumn.DataType" />.</returns>
		/// <exception cref="T:System.InvalidCastException">When you are adding a row, the default value is not an instance of the column's data type. </exception>
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004330 File Offset: 0x00002530
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000043CC File Offset: 0x000025CC
		[TypeConverter(typeof(DefaultValueTypeConverter))]
		public object DefaultValue
		{
			get
			{
				if (this._defaultValue == DBNull.Value && this._implementsINullable)
				{
					if (this._storage != null)
					{
						this._defaultValue = this._storage._nullValue;
					}
					else if (this._isSqlType)
					{
						this._defaultValue = SqlConvert.ChangeTypeForDefaultValue(this._defaultValue, this._dataType, this.FormatProvider);
					}
					else if (this._implementsINullable)
					{
						PropertyInfo property = this._dataType.GetProperty("Null", BindingFlags.Static | BindingFlags.Public);
						if (property != null)
						{
							this._defaultValue = property.GetValue(null, null);
						}
					}
				}
				return this._defaultValue;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataColumn.set_DefaultValue|API> {0}", this.ObjectID);
				if (this._defaultValue == null || !this.DefaultValue.Equals(value))
				{
					if (this.AutoIncrement)
					{
						throw ExceptionBuilder.DefaultValueAndAutoIncrement();
					}
					object obj = (value == null) ? DBNull.Value : value;
					if (obj != DBNull.Value && this.DataType != typeof(object))
					{
						try
						{
							obj = SqlConvert.ChangeTypeForDefaultValue(obj, this.DataType, this.FormatProvider);
						}
						catch (InvalidCastException inner)
						{
							throw ExceptionBuilder.DefaultValueColumnDataType(this.ColumnName, obj.GetType(), this.DataType, inner);
						}
					}
					this._defaultValue = obj;
					this._defaultValueIsNull = (obj == DBNull.Value || (this.ImplementsINullable && DataStorage.IsObjectSqlNull(obj)));
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000044A8 File Offset: 0x000026A8
		internal bool DefaultValueIsNull
		{
			get
			{
				return this._defaultValueIsNull;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000044B0 File Offset: 0x000026B0
		internal void BindExpression()
		{
			this.DataExpression.Bind(this._table);
		}

		/// <summary>Gets or sets the expression used to filter rows, calculate the values in a column, or create an aggregate column.</summary>
		/// <returns>An expression to calculate the value of a column, or create an aggregate column. The return type of an expression is determined by the <see cref="P:System.Data.DataColumn.DataType" /> of the column.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Data.DataColumn.AutoIncrement" /> or <see cref="P:System.Data.DataColumn.Unique" /> property is set to <see langword="true" />. </exception>
		/// <exception cref="T:System.FormatException">When you are using the CONVERT function, the expression evaluates to a string, but the string does not contain a representation that can be converted to the type parameter. </exception>
		/// <exception cref="T:System.InvalidCastException">When you are using the CONVERT function, the requested cast is not possible. See the Conversion function in the following section for detailed information about possible casts. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">When you use the SUBSTRING function, the start argument is out of range.-Or- When you use the SUBSTRING function, the length argument is out of range. </exception>
		/// <exception cref="T:System.Exception">When you use the LEN function or the TRIM function, the expression does not evaluate to a string. This includes expressions that evaluate to <see cref="T:System.Char" />. </exception>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000044C3 File Offset: 0x000026C3
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000044E0 File Offset: 0x000026E0
		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue("")]
		public string Expression
		{
			get
			{
				if (this._expression != null)
				{
					return this._expression.Expression;
				}
				return "";
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, string>("<ds.DataColumn.set_Expression|API> {0}, '{1}'", this.ObjectID, value);
				if (value == null)
				{
					value = string.Empty;
				}
				try
				{
					DataExpression dataExpression = null;
					if (value.Length > 0)
					{
						DataExpression dataExpression2 = new DataExpression(this._table, value, this._dataType);
						if (dataExpression2.HasValue)
						{
							dataExpression = dataExpression2;
						}
					}
					if (this._expression == null && dataExpression != null)
					{
						if (this.AutoIncrement || this.Unique)
						{
							throw ExceptionBuilder.ExpressionAndUnique();
						}
						if (this._table != null)
						{
							for (int i = 0; i < this._table.Constraints.Count; i++)
							{
								if (this._table.Constraints[i].ContainsColumn(this))
								{
									throw ExceptionBuilder.ExpressionAndConstraint(this, this._table.Constraints[i]);
								}
							}
						}
						bool readOnly = this.ReadOnly;
						try
						{
							this.ReadOnly = true;
						}
						catch (ReadOnlyException e)
						{
							ExceptionBuilder.TraceExceptionForCapture(e);
							this.ReadOnly = readOnly;
							throw ExceptionBuilder.ExpressionAndReadOnly();
						}
					}
					if (this._table != null)
					{
						if (dataExpression != null && dataExpression.DependsOn(this))
						{
							throw ExceptionBuilder.ExpressionCircular();
						}
						this.HandleDependentColumnList(this._expression, dataExpression);
						DataExpression expression = this._expression;
						this._expression = dataExpression;
						try
						{
							if (dataExpression == null)
							{
								for (int j = 0; j < this._table.RecordCapacity; j++)
								{
									this.InitializeRecord(j);
								}
							}
							else
							{
								this._table.EvaluateExpressions(this);
							}
							this._table.ResetInternalIndexes(this);
							this._table.EvaluateDependentExpressions(this);
							return;
						}
						catch (Exception e2) when (ADP.IsCatchableExceptionType(e2))
						{
							ExceptionBuilder.TraceExceptionForCapture(e2);
							try
							{
								this._expression = expression;
								this.HandleDependentColumnList(dataExpression, this._expression);
								if (expression == null)
								{
									for (int k = 0; k < this._table.RecordCapacity; k++)
									{
										this.InitializeRecord(k);
									}
								}
								else
								{
									this._table.EvaluateExpressions(this);
								}
								this._table.ResetInternalIndexes(this);
								this._table.EvaluateDependentExpressions(this);
							}
							catch (Exception e3) when (ADP.IsCatchableExceptionType(e3))
							{
								ExceptionBuilder.TraceExceptionWithoutRethrow(e3);
							}
							throw;
						}
					}
					this._expression = dataExpression;
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		/// <summary>Gets the collection of custom user information associated with a <see cref="T:System.Data.DataColumn" />.</summary>
		/// <returns>A <see cref="T:System.Data.PropertyCollection" /> of custom information.</returns>
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000478C File Offset: 0x0000298C
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000047B1 File Offset: 0x000029B1
		internal bool HasData
		{
			get
			{
				return this._storage != null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000047BC File Offset: 0x000029BC
		internal bool ImplementsINullable
		{
			get
			{
				return this._implementsINullable;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000047C4 File Offset: 0x000029C4
		internal bool ImplementsIChangeTracking
		{
			get
			{
				return this._implementsIChangeTracking;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000047CC File Offset: 0x000029CC
		internal bool ImplementsIRevertibleChangeTracking
		{
			get
			{
				return this._implementsIRevertibleChangeTracking;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000047D4 File Offset: 0x000029D4
		internal bool IsValueType
		{
			get
			{
				return this._storage._isValueType;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000047E1 File Offset: 0x000029E1
		internal bool IsSqlType
		{
			get
			{
				return this._isSqlType;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000047EC File Offset: 0x000029EC
		private void SetMaxLengthSimpleType()
		{
			if (this._simpleType != null)
			{
				this._simpleType.MaxLength = this._maxLength;
				if (this._simpleType.IsPlainString())
				{
					this._simpleType = null;
					return;
				}
				if (this._simpleType.Name != null && this.XmlDataType != null)
				{
					this._simpleType.ConvertToAnnonymousSimpleType();
					this.XmlDataType = null;
					return;
				}
			}
			else if (-1 < this._maxLength)
			{
				this.SimpleType = SimpleType.CreateLimitedStringType(this._maxLength);
			}
		}

		/// <summary>Gets or sets the maximum length of a text column.</summary>
		/// <returns>The maximum length of the column in characters. If the column has no maximum length, the value is –1 (default).</returns>
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004869 File Offset: 0x00002A69
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00004874 File Offset: 0x00002A74
		[DefaultValue(-1)]
		public int MaxLength
		{
			get
			{
				return this._maxLength;
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, int>("<ds.DataColumn.set_MaxLength|API> {0}, {1}", this.ObjectID, value);
				try
				{
					if (this._maxLength != value)
					{
						if (this.ColumnMapping == MappingType.SimpleContent)
						{
							throw ExceptionBuilder.CannotSetMaxLength2(this);
						}
						if (this.DataType != typeof(string) && this.DataType != typeof(SqlString))
						{
							throw ExceptionBuilder.HasToBeStringType(this);
						}
						int maxLength = this._maxLength;
						this._maxLength = Math.Max(value, -1);
						if ((maxLength < 0 || value < maxLength) && this._table != null && this._table.EnforceConstraints && !this.CheckMaxLength())
						{
							this._maxLength = maxLength;
							throw ExceptionBuilder.CannotSetMaxLength(this, value);
						}
						this.SetMaxLengthSimpleType();
					}
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		/// <summary>Gets or sets the namespace of the <see cref="T:System.Data.DataColumn" />.</summary>
		/// <returns>The namespace of the <see cref="T:System.Data.DataColumn" />.</returns>
		/// <exception cref="T:System.ArgumentException">The namespace already has data. </exception>
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004958 File Offset: 0x00002B58
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000498C File Offset: 0x00002B8C
		public string Namespace
		{
			get
			{
				if (this._columnUri != null)
				{
					return this._columnUri;
				}
				if (this.Table != null && this._columnMapping != MappingType.Attribute)
				{
					return this.Table.Namespace;
				}
				return string.Empty;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, string>("<ds.DataColumn.set_Namespace|API> {0}, '{1}'", this.ObjectID, value);
				if (this._columnUri != value)
				{
					if (this._columnMapping != MappingType.SimpleContent)
					{
						this.RaisePropertyChanging("Namespace");
						this._columnUri = value;
						return;
					}
					if (value != this.Namespace)
					{
						throw ExceptionBuilder.CannotChangeNamespace(this.ColumnName);
					}
				}
			}
		}

		/// <summary>Gets the (zero-based) position of the column in the <see cref="T:System.Data.DataColumnCollection" /> collection.</summary>
		/// <returns>The position of the column. Gets -1 if the column is not a member of a collection.</returns>
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000049F3 File Offset: 0x00002BF3
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Ordinal
		{
			get
			{
				return this._ordinal;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000049FC File Offset: 0x00002BFC
		internal void SetOrdinalInternal(int ordinal)
		{
			if (this._ordinal != ordinal)
			{
				if (this.Unique && this._ordinal != -1 && ordinal == -1)
				{
					UniqueConstraint uniqueConstraint = this._table.Constraints.FindKeyConstraint(this);
					if (uniqueConstraint != null)
					{
						this._table.Constraints.Remove(uniqueConstraint);
					}
				}
				if (this._sortIndex != null && -1 == ordinal)
				{
					this._sortIndex.RemoveRef();
					this._sortIndex.RemoveRef();
					this._sortIndex = null;
				}
				int ordinal2 = this._ordinal;
				this._ordinal = ordinal;
				if (ordinal2 == -1 && this._ordinal != -1 && this.Unique)
				{
					UniqueConstraint constraint = new UniqueConstraint(this);
					this._table.Constraints.Add(constraint);
				}
			}
		}

		/// <summary>Gets or sets a value that indicates whether the column allows for changes as soon as a row has been added to the table.</summary>
		/// <returns>
		///     <see langword="true" /> if the column is read only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">The property is set to <see langword="false" /> on a computed column. </exception>
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004AB4 File Offset: 0x00002CB4
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00004ABC File Offset: 0x00002CBC
		[DefaultValue(false)]
		public bool ReadOnly
		{
			get
			{
				return this._readOnly;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, bool>("<ds.DataColumn.set_ReadOnly|API> {0}, {1}", this.ObjectID, value);
				if (this._readOnly != value)
				{
					if (!value && this._expression != null)
					{
						throw ExceptionBuilder.ReadOnlyAndExpression();
					}
					this._readOnly = value;
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004AF8 File Offset: 0x00002CF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Index SortIndex
		{
			get
			{
				if (this._sortIndex == null)
				{
					IndexField[] indexDesc = new IndexField[]
					{
						new IndexField(this, false)
					};
					this._sortIndex = this._table.GetIndex(indexDesc, DataViewRowState.CurrentRows, null);
					this._sortIndex.AddRef();
				}
				return this._sortIndex;
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataTable" /> to which the column belongs to.</summary>
		/// <returns>The <see cref="T:System.Data.DataTable" /> that the <see cref="T:System.Data.DataColumn" /> belongs to.</returns>
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004B48 File Offset: 0x00002D48
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataTable Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004B50 File Offset: 0x00002D50
		internal void SetTable(DataTable table)
		{
			if (this._table != table)
			{
				if (this.Computed && (table == null || (!table.fInitInProgress && (table.DataSet == null || (!table.DataSet._fIsSchemaLoading && !table.DataSet._fInitInProgress)))))
				{
					this.DataExpression.Bind(table);
				}
				if (this.Unique && this._table != null)
				{
					UniqueConstraint uniqueConstraint = table.Constraints.FindKeyConstraint(this);
					if (uniqueConstraint != null)
					{
						table.Constraints.CanRemove(uniqueConstraint, true);
					}
				}
				this._table = table;
				this._storage = null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004BE3 File Offset: 0x00002DE3
		private DataRow GetDataRow(int index)
		{
			return this._table._recordManager[index];
		}

		// Token: 0x17000031 RID: 49
		internal object this[int record]
		{
			get
			{
				return this._storage.Get(record);
			}
			set
			{
				try
				{
					this._storage.Set(record, value);
				}
				catch (Exception ex)
				{
					ExceptionBuilder.TraceExceptionForCapture(ex);
					throw ExceptionBuilder.SetFailed(value, this, this.DataType, ex);
				}
				if (this.AutoIncrement && !this._storage.IsNull(record))
				{
					this.AutoInc.SetCurrentAndIncrement(this._storage.Get(record));
				}
				if (this.Computed)
				{
					DataRow dataRow = this.GetDataRow(record);
					if (dataRow != null)
					{
						dataRow.LastChangedColumn = this;
					}
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004C90 File Offset: 0x00002E90
		internal void InitializeRecord(int record)
		{
			this._storage.Set(record, this.DefaultValue);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004CA4 File Offset: 0x00002EA4
		internal void SetValue(int record, object value)
		{
			try
			{
				this._storage.Set(record, value);
			}
			catch (Exception ex)
			{
				ExceptionBuilder.TraceExceptionForCapture(ex);
				throw ExceptionBuilder.SetFailed(value, this, this.DataType, ex);
			}
			DataRow dataRow = this.GetDataRow(record);
			if (dataRow != null)
			{
				dataRow.LastChangedColumn = this;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004CFC File Offset: 0x00002EFC
		internal void FreeRecord(int record)
		{
			this._storage.Set(record, this._storage._nullValue);
		}

		/// <summary>Gets or sets a value that indicates whether the values in each row of the column must be unique.</summary>
		/// <returns>
		///     <see langword="true" /> if the value must be unique; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">The column is a calculated column. </exception>
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00004D15 File Offset: 0x00002F15
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00004D20 File Offset: 0x00002F20
		[DefaultValue(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Unique
		{
			get
			{
				return this._unique;
			}
			set
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int, bool>("<ds.DataColumn.set_Unique|API> {0}, {1}", this.ObjectID, value);
				try
				{
					if (this._unique != value)
					{
						if (value && this._expression != null)
						{
							throw ExceptionBuilder.UniqueAndExpression();
						}
						UniqueConstraint constraint = null;
						if (this._table != null)
						{
							if (value)
							{
								this.CheckUnique();
							}
							else
							{
								foreach (object obj in this.Table.Constraints)
								{
									UniqueConstraint uniqueConstraint = obj as UniqueConstraint;
									if (uniqueConstraint != null && uniqueConstraint.ColumnsReference.Length == 1 && uniqueConstraint.ColumnsReference[0] == this)
									{
										constraint = uniqueConstraint;
									}
								}
								this._table.Constraints.CanRemove(constraint, true);
							}
						}
						this._unique = value;
						if (this._table != null)
						{
							if (value)
							{
								UniqueConstraint constraint2 = new UniqueConstraint(this);
								this._table.Constraints.Add(constraint2);
							}
							else
							{
								this._table.Constraints.Remove(constraint);
							}
						}
					}
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004E28 File Offset: 0x00003028
		internal void InternalUnique(bool value)
		{
			this._unique = value;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00004E31 File Offset: 0x00003031
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00004E39 File Offset: 0x00003039
		internal string XmlDataType { get; set; } = string.Empty;

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004E42 File Offset: 0x00003042
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00004E4A File Offset: 0x0000304A
		internal SimpleType SimpleType
		{
			get
			{
				return this._simpleType;
			}
			set
			{
				this._simpleType = value;
				if (value != null && value.CanHaveMaxLength())
				{
					this._maxLength = this._simpleType.MaxLength;
				}
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Data.MappingType" /> of the column.</summary>
		/// <returns>One of the <see cref="T:System.Data.MappingType" /> values.</returns>
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00004E6F File Offset: 0x0000306F
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00004E78 File Offset: 0x00003078
		[DefaultValue(MappingType.Element)]
		public virtual MappingType ColumnMapping
		{
			get
			{
				return this._columnMapping;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int, MappingType>("<ds.DataColumn.set_ColumnMapping|API> {0}, {1}", this.ObjectID, value);
				if (value != this._columnMapping)
				{
					if (value == MappingType.SimpleContent && this._table != null)
					{
						int num = 0;
						if (this._columnMapping == MappingType.Element)
						{
							num = 1;
						}
						if (this._dataType == typeof(char))
						{
							throw ExceptionBuilder.CannotSetSimpleContent(this.ColumnName, this._dataType);
						}
						if (this._table.XmlText != null && this._table.XmlText != this)
						{
							throw ExceptionBuilder.CannotAddColumn3();
						}
						if (this._table.ElementColumnCount > num)
						{
							throw ExceptionBuilder.CannotAddColumn4(this.ColumnName);
						}
					}
					this.RaisePropertyChanging("ColumnMapping");
					if (this._table != null)
					{
						if (this._columnMapping == MappingType.SimpleContent)
						{
							this._table._xmlText = null;
						}
						if (value == MappingType.Element)
						{
							DataTable table = this._table;
							int elementColumnCount = table.ElementColumnCount;
							table.ElementColumnCount = elementColumnCount + 1;
						}
						else if (this._columnMapping == MappingType.Element)
						{
							DataTable table2 = this._table;
							int elementColumnCount = table2.ElementColumnCount;
							table2.ElementColumnCount = elementColumnCount - 1;
						}
					}
					this._columnMapping = value;
					if (value == MappingType.SimpleContent)
					{
						this._columnUri = null;
						if (this._table != null)
						{
							this._table.XmlText = this;
						}
						this.SimpleType = null;
					}
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004FB2 File Offset: 0x000031B2
		internal void CheckColumnConstraint(DataRow row, DataRowAction action)
		{
			if (this._table.UpdatingCurrent(row, action))
			{
				this.CheckNullable(row);
				this.CheckMaxLength(row);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004FD4 File Offset: 0x000031D4
		internal bool CheckMaxLength()
		{
			if (0 <= this._maxLength && this.Table != null && 0 < this.Table.Rows.Count)
			{
				foreach (object obj in this.Table.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (dataRow.HasVersion(DataRowVersion.Current) && this._maxLength < this.GetStringLength(dataRow.GetCurrentRecordNo()))
					{
						return false;
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005078 File Offset: 0x00003278
		internal void CheckMaxLength(DataRow dr)
		{
			if (0 <= this._maxLength && this._maxLength < this.GetStringLength(dr.GetDefaultRecord()))
			{
				throw ExceptionBuilder.LongerThanMaxLength(this);
			}
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x060000B7 RID: 183 RVA: 0x000050A0 File Offset: 0x000032A0
		protected internal void CheckNotAllowNull()
		{
			if (this._storage == null)
			{
				return;
			}
			if (this._sortIndex != null)
			{
				if (this._sortIndex.IsKeyInIndex(this._storage._nullValue))
				{
					throw ExceptionBuilder.NullKeyValues(this.ColumnName);
				}
			}
			else
			{
				foreach (object obj in this._table.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (dataRow.RowState != DataRowState.Deleted)
					{
						if (!this._implementsINullable)
						{
							if (dataRow[this] == DBNull.Value)
							{
								throw ExceptionBuilder.NullKeyValues(this.ColumnName);
							}
						}
						else if (DataStorage.IsObjectNull(dataRow[this]))
						{
							throw ExceptionBuilder.NullKeyValues(this.ColumnName);
						}
					}
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005174 File Offset: 0x00003374
		internal void CheckNullable(DataRow row)
		{
			if (!this.AllowDBNull && this._storage.IsNull(row.GetDefaultRecord()))
			{
				throw ExceptionBuilder.NullValues(this.ColumnName);
			}
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x060000B9 RID: 185 RVA: 0x0000519D File Offset: 0x0000339D
		protected void CheckUnique()
		{
			if (!this.SortIndex.CheckUnique())
			{
				throw ExceptionBuilder.NonUniqueValues(this.ColumnName);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000051B8 File Offset: 0x000033B8
		internal int Compare(int record1, int record2)
		{
			return this._storage.Compare(record1, record2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000051C8 File Offset: 0x000033C8
		internal bool CompareValueTo(int record1, object value, bool checkType)
		{
			if (this.CompareValueTo(record1, value) == 0)
			{
				Type type = value.GetType();
				Type type2 = this._storage.Get(record1).GetType();
				if (type == typeof(string) && type2 == typeof(string))
				{
					return string.CompareOrdinal((string)this._storage.Get(record1), (string)value) == 0;
				}
				if (type == type2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000524A File Offset: 0x0000344A
		internal int CompareValueTo(int record1, object value)
		{
			return this._storage.CompareValueTo(record1, value);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005259 File Offset: 0x00003459
		internal object ConvertValue(object value)
		{
			return this._storage.ConvertValue(value);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005267 File Offset: 0x00003467
		internal void Copy(int srcRecordNo, int dstRecordNo)
		{
			this._storage.Copy(srcRecordNo, dstRecordNo);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005278 File Offset: 0x00003478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DataColumn Clone()
		{
			DataColumn dataColumn = (DataColumn)Activator.CreateInstance(base.GetType());
			dataColumn.SimpleType = this.SimpleType;
			dataColumn._allowNull = this._allowNull;
			if (this._autoInc != null)
			{
				dataColumn._autoInc = this._autoInc.Clone();
			}
			dataColumn._caption = this._caption;
			dataColumn.ColumnName = this.ColumnName;
			dataColumn._columnUri = this._columnUri;
			dataColumn._columnPrefix = this._columnPrefix;
			dataColumn.DataType = this.DataType;
			dataColumn._defaultValue = this._defaultValue;
			dataColumn._defaultValueIsNull = (this._defaultValue == DBNull.Value || (dataColumn.ImplementsINullable && DataStorage.IsObjectSqlNull(this._defaultValue)));
			dataColumn._columnMapping = this._columnMapping;
			dataColumn._readOnly = this._readOnly;
			dataColumn.MaxLength = this.MaxLength;
			dataColumn.XmlDataType = this.XmlDataType;
			dataColumn._dateTimeMode = this._dateTimeMode;
			if (this._extendedProperties != null)
			{
				foreach (object key in this._extendedProperties.Keys)
				{
					dataColumn.ExtendedProperties[key] = this._extendedProperties[key];
				}
			}
			return dataColumn;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000053E0 File Offset: 0x000035E0
		internal object GetAggregateValue(int[] records, AggregateType kind)
		{
			if (this._storage != null)
			{
				return this._storage.Aggregate(records, kind);
			}
			if (kind != AggregateType.Count)
			{
				return DBNull.Value;
			}
			return 0;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005409 File Offset: 0x00003609
		private int GetStringLength(int record)
		{
			return this._storage.GetStringLength(record);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005418 File Offset: 0x00003618
		internal void Init(int record)
		{
			if (this.AutoIncrement)
			{
				object value = this._autoInc.Current;
				this._autoInc.MoveAfter();
				this._storage.Set(record, value);
				return;
			}
			this[record] = this._defaultValue;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005460 File Offset: 0x00003660
		internal static bool IsAutoIncrementType(Type dataType)
		{
			return dataType == typeof(int) || dataType == typeof(long) || dataType == typeof(short) || dataType == typeof(decimal) || dataType == typeof(BigInteger) || dataType == typeof(SqlInt32) || dataType == typeof(SqlInt64) || dataType == typeof(SqlInt16) || dataType == typeof(SqlDecimal);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00005512 File Offset: 0x00003712
		internal bool IsCustomType
		{
			get
			{
				if (this._storage == null)
				{
					return DataStorage.IsTypeCustomType(this.DataType);
				}
				return this._storage._isCustomDefinedType;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005533 File Offset: 0x00003733
		internal bool IsValueCustomTypeInstance(object value)
		{
			return DataStorage.IsTypeCustomType(value.GetType()) && !(value is Type);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00005550 File Offset: 0x00003750
		internal bool ImplementsIXMLSerializable
		{
			get
			{
				return this._implementsIXMLSerializable;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005558 File Offset: 0x00003758
		internal bool IsInRelation()
		{
			DataRelationCollection dataRelationCollection = this._table.ParentRelations;
			for (int i = 0; i < dataRelationCollection.Count; i++)
			{
				if (dataRelationCollection[i].ChildKey.ContainsColumn(this))
				{
					return true;
				}
			}
			dataRelationCollection = this._table.ChildRelations;
			for (int j = 0; j < dataRelationCollection.Count; j++)
			{
				if (dataRelationCollection[j].ParentKey.ContainsColumn(this))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000055D4 File Offset: 0x000037D4
		internal bool IsMaxLengthViolated()
		{
			if (this.MaxLength < 0)
			{
				return true;
			}
			bool result = false;
			string text = null;
			foreach (object obj in this.Table.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (dataRow.HasVersion(DataRowVersion.Current))
				{
					object obj2 = dataRow[this];
					if (!this._isSqlType)
					{
						if (obj2 != null && obj2 != DBNull.Value && ((string)obj2).Length > this.MaxLength)
						{
							if (text == null)
							{
								text = ExceptionBuilder.MaxLengthViolationText(this.ColumnName);
							}
							dataRow.RowError = text;
							dataRow.SetColumnError(this, text);
							result = true;
						}
					}
					else if (!DataStorage.IsObjectNull(obj2) && ((SqlString)obj2).Value.Length > this.MaxLength)
					{
						if (text == null)
						{
							text = ExceptionBuilder.MaxLengthViolationText(this.ColumnName);
						}
						dataRow.RowError = text;
						dataRow.SetColumnError(this, text);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000056F4 File Offset: 0x000038F4
		internal bool IsNotAllowDBNullViolated()
		{
			Index sortIndex = this.SortIndex;
			DataRow[] rows = sortIndex.GetRows(sortIndex.FindRecords(DBNull.Value));
			for (int i = 0; i < rows.Length; i++)
			{
				string text = ExceptionBuilder.NotAllowDBNullViolationText(this.ColumnName);
				rows[i].RowError = text;
				rows[i].SetColumnError(this, text);
			}
			return rows.Length != 0;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000574A File Offset: 0x0000394A
		internal void FinishInitInProgress()
		{
			if (this.Computed)
			{
				this.BindExpression();
			}
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="pcevent">Parameter reference.</param>
		// Token: 0x060000CB RID: 203 RVA: 0x0000575A File Offset: 0x0000395A
		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
			PropertyChangedEventHandler propertyChanging = this.PropertyChanging;
			if (propertyChanging == null)
			{
				return;
			}
			propertyChanging(this, pcevent);
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="name">Parameter reference.</param>
		// Token: 0x060000CC RID: 204 RVA: 0x0000576E File Offset: 0x0000396E
		protected internal void RaisePropertyChanging(string name)
		{
			this.OnPropertyChanging(new PropertyChangedEventArgs(name));
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000577C File Offset: 0x0000397C
		private void InsureStorage()
		{
			if (this._storage == null)
			{
				this._storage = DataStorage.CreateStorage(this, this._dataType, this._storageType);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000579E File Offset: 0x0000399E
		internal void SetCapacity(int capacity)
		{
			this.InsureStorage();
			this._storage.SetCapacity(capacity);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000057B2 File Offset: 0x000039B2
		internal void OnSetDataSet()
		{
		}

		/// <summary>Gets the <see cref="P:System.Data.DataColumn.Expression" /> of the column, if one exists.</summary>
		/// <returns>The <see cref="P:System.Data.DataColumn.Expression" /> value, if the property is set; otherwise, the <see cref="P:System.Data.DataColumn.ColumnName" /> property.</returns>
		// Token: 0x060000D0 RID: 208 RVA: 0x000057B4 File Offset: 0x000039B4
		public override string ToString()
		{
			if (this._expression != null)
			{
				return this.ColumnName + " + " + this.Expression;
			}
			return this.ColumnName;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000057DB File Offset: 0x000039DB
		internal object ConvertXmlToObject(string s)
		{
			this.InsureStorage();
			return this._storage.ConvertXmlToObject(s);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000057EF File Offset: 0x000039EF
		internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			this.InsureStorage();
			return this._storage.ConvertXmlToObject(xmlReader, xmlAttrib);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005804 File Offset: 0x00003A04
		internal string ConvertObjectToXml(object value)
		{
			this.InsureStorage();
			return this._storage.ConvertObjectToXml(value);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005818 File Offset: 0x00003A18
		internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
			this.InsureStorage();
			this._storage.ConvertObjectToXml(value, xmlWriter, xmlAttrib);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000582E File Offset: 0x00003A2E
		internal object GetEmptyColumnStore(int recordCount)
		{
			this.InsureStorage();
			return this._storage.GetEmptyStorageInternal(recordCount);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005842 File Offset: 0x00003A42
		internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex)
		{
			this._storage.CopyValueInternal(record, store, nullbits, storeIndex);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005854 File Offset: 0x00003A54
		internal void SetStorage(object store, BitArray nullbits)
		{
			this.InsureStorage();
			this._storage.SetStorageInternal(store, nullbits);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005869 File Offset: 0x00003A69
		internal void AddDependentColumn(DataColumn expressionColumn)
		{
			if (this._dependentColumns == null)
			{
				this._dependentColumns = new List<DataColumn>();
			}
			this._dependentColumns.Add(expressionColumn);
			this._table.AddDependentColumn(expressionColumn);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005896 File Offset: 0x00003A96
		internal void RemoveDependentColumn(DataColumn expressionColumn)
		{
			if (this._dependentColumns != null && this._dependentColumns.Contains(expressionColumn))
			{
				this._dependentColumns.Remove(expressionColumn);
			}
			this._table.RemoveDependentColumn(expressionColumn);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000058C8 File Offset: 0x00003AC8
		internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression)
		{
			if (oldExpression != null)
			{
				foreach (DataColumn dataColumn in oldExpression.GetDependency())
				{
					dataColumn.RemoveDependentColumn(this);
					if (dataColumn._table != this._table)
					{
						this._table.RemoveDependentColumn(this);
					}
				}
				this._table.RemoveDependentColumn(this);
			}
			if (newExpression != null)
			{
				foreach (DataColumn dataColumn2 in newExpression.GetDependency())
				{
					dataColumn2.AddDependentColumn(this);
					if (dataColumn2._table != this._table)
					{
						this._table.AddDependentColumn(this);
					}
				}
				this._table.AddDependentColumn(this);
			}
		}

		// Token: 0x04000023 RID: 35
		private bool _allowNull = true;

		// Token: 0x04000024 RID: 36
		private string _caption;

		// Token: 0x04000025 RID: 37
		private string _columnName;

		// Token: 0x04000026 RID: 38
		private Type _dataType;

		// Token: 0x04000027 RID: 39
		private StorageType _storageType;

		// Token: 0x04000028 RID: 40
		internal object _defaultValue = DBNull.Value;

		// Token: 0x04000029 RID: 41
		private DataSetDateTime _dateTimeMode = DataSetDateTime.UnspecifiedLocal;

		// Token: 0x0400002A RID: 42
		private DataExpression _expression;

		// Token: 0x0400002B RID: 43
		private int _maxLength = -1;

		// Token: 0x0400002C RID: 44
		private int _ordinal = -1;

		// Token: 0x0400002D RID: 45
		private bool _readOnly;

		// Token: 0x0400002E RID: 46
		internal Index _sortIndex;

		// Token: 0x0400002F RID: 47
		internal DataTable _table;

		// Token: 0x04000030 RID: 48
		private bool _unique;

		// Token: 0x04000031 RID: 49
		internal MappingType _columnMapping = MappingType.Element;

		// Token: 0x04000032 RID: 50
		internal int _hashCode;

		// Token: 0x04000033 RID: 51
		internal int _errors;

		// Token: 0x04000034 RID: 52
		private bool _isSqlType;

		// Token: 0x04000035 RID: 53
		private bool _implementsINullable;

		// Token: 0x04000036 RID: 54
		private bool _implementsIChangeTracking;

		// Token: 0x04000037 RID: 55
		private bool _implementsIRevertibleChangeTracking;

		// Token: 0x04000038 RID: 56
		private bool _implementsIXMLSerializable;

		// Token: 0x04000039 RID: 57
		private bool _defaultValueIsNull = true;

		// Token: 0x0400003A RID: 58
		internal List<DataColumn> _dependentColumns;

		// Token: 0x0400003B RID: 59
		internal PropertyCollection _extendedProperties;

		// Token: 0x0400003C RID: 60
		private DataStorage _storage;

		// Token: 0x0400003D RID: 61
		private AutoIncrementValue _autoInc;

		// Token: 0x0400003E RID: 62
		internal string _columnUri;

		// Token: 0x0400003F RID: 63
		private string _columnPrefix = string.Empty;

		// Token: 0x04000040 RID: 64
		internal string _encodedColumnName;

		// Token: 0x04000041 RID: 65
		internal SimpleType _simpleType;

		// Token: 0x04000042 RID: 66
		private static int s_objectTypeCount;

		// Token: 0x04000043 RID: 67
		private readonly int _objectID = Interlocked.Increment(ref DataColumn.s_objectTypeCount);

		// Token: 0x04000045 RID: 69
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanging;
	}
}
