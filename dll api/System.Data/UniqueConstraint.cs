using System;
using System.ComponentModel;

namespace System.Data
{
	/// <summary>Represents a restriction on a set of columns in which all values must be unique.</summary>
	// Token: 0x02000096 RID: 150
	[DefaultProperty("ConstraintName")]
	public class UniqueConstraint : Constraint
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified name and <see cref="T:System.Data.DataColumn" />.</summary>
		/// <param name="name">The name of the constraint. </param>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to constrain. </param>
		// Token: 0x060008D0 RID: 2256 RVA: 0x0002C6AC File Offset: 0x0002A8AC
		public UniqueConstraint(string name, DataColumn column)
		{
			this.Create(name, new DataColumn[]
			{
				column
			});
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified <see cref="T:System.Data.DataColumn" />.</summary>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to constrain. </param>
		// Token: 0x060008D1 RID: 2257 RVA: 0x0002C6D4 File Offset: 0x0002A8D4
		public UniqueConstraint(DataColumn column)
		{
			this.Create(null, new DataColumn[]
			{
				column
			});
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified name and array of <see cref="T:System.Data.DataColumn" /> objects.</summary>
		/// <param name="name">The name of the constraint. </param>
		/// <param name="columns">The array of <see cref="T:System.Data.DataColumn" /> objects to constrain. </param>
		// Token: 0x060008D2 RID: 2258 RVA: 0x0002C6FA File Offset: 0x0002A8FA
		public UniqueConstraint(string name, DataColumn[] columns)
		{
			this.Create(name, columns);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the given array of <see cref="T:System.Data.DataColumn" /> objects.</summary>
		/// <param name="columns">The array of <see cref="T:System.Data.DataColumn" /> objects to constrain. </param>
		// Token: 0x060008D3 RID: 2259 RVA: 0x0002C70A File Offset: 0x0002A90A
		public UniqueConstraint(DataColumn[] columns)
		{
			this.Create(null, columns);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified name, an array of <see cref="T:System.Data.DataColumn" /> objects to constrain, and a value specifying whether the constraint is a primary key.</summary>
		/// <param name="name">The name of the constraint. </param>
		/// <param name="columnNames">An array of <see cref="T:System.Data.DataColumn" /> objects to constrain. </param>
		/// <param name="isPrimaryKey">
		///       <see langword="true" /> to indicate that the constraint is a primary key; otherwise, <see langword="false" />. </param>
		// Token: 0x060008D4 RID: 2260 RVA: 0x0002C71A File Offset: 0x0002A91A
		[Browsable(false)]
		public UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey)
		{
			this._constraintName = name;
			this._columnNames = columnNames;
			this._bPrimaryKey = isPrimaryKey;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified name, the <see cref="T:System.Data.DataColumn" /> to constrain, and a value specifying whether the constraint is a primary key.</summary>
		/// <param name="name">The name of the constraint. </param>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to constrain. </param>
		/// <param name="isPrimaryKey">
		///       <see langword="true" /> to indicate that the constraint is a primary key; otherwise, <see langword="false" />. </param>
		// Token: 0x060008D5 RID: 2261 RVA: 0x0002C738 File Offset: 0x0002A938
		public UniqueConstraint(string name, DataColumn column, bool isPrimaryKey)
		{
			DataColumn[] columns = new DataColumn[]
			{
				column
			};
			this._bPrimaryKey = isPrimaryKey;
			this.Create(name, columns);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the <see cref="T:System.Data.DataColumn" /> to constrain, and a value specifying whether the constraint is a primary key.</summary>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to constrain. </param>
		/// <param name="isPrimaryKey">
		///       <see langword="true" /> to indicate that the constraint is a primary key; otherwise, <see langword="false" />. </param>
		// Token: 0x060008D6 RID: 2262 RVA: 0x0002C768 File Offset: 0x0002A968
		public UniqueConstraint(DataColumn column, bool isPrimaryKey)
		{
			DataColumn[] columns = new DataColumn[]
			{
				column
			};
			this._bPrimaryKey = isPrimaryKey;
			this.Create(null, columns);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with the specified name, an array of <see cref="T:System.Data.DataColumn" /> objects to constrain, and a value specifying whether the constraint is a primary key.</summary>
		/// <param name="name">The name of the constraint. </param>
		/// <param name="columns">An array of <see cref="T:System.Data.DataColumn" /> objects to constrain. </param>
		/// <param name="isPrimaryKey">
		///       <see langword="true" /> to indicate that the constraint is a primary key; otherwise, <see langword="false" />. </param>
		// Token: 0x060008D7 RID: 2263 RVA: 0x0002C795 File Offset: 0x0002A995
		public UniqueConstraint(string name, DataColumn[] columns, bool isPrimaryKey)
		{
			this._bPrimaryKey = isPrimaryKey;
			this.Create(name, columns);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.UniqueConstraint" /> class with an array of <see cref="T:System.Data.DataColumn" /> objects to constrain, and a value specifying whether the constraint is a primary key.</summary>
		/// <param name="columns">An array of <see cref="T:System.Data.DataColumn" /> objects to constrain. </param>
		/// <param name="isPrimaryKey">
		///       <see langword="true" /> to indicate that the constraint is a primary key; otherwise, <see langword="false" />. </param>
		// Token: 0x060008D8 RID: 2264 RVA: 0x0002C7AC File Offset: 0x0002A9AC
		public UniqueConstraint(DataColumn[] columns, bool isPrimaryKey)
		{
			this._bPrimaryKey = isPrimaryKey;
			this.Create(null, columns);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0002C7C3 File Offset: 0x0002A9C3
		internal string[] ColumnNames
		{
			get
			{
				return this._key.GetColumnNames();
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0002C7D0 File Offset: 0x0002A9D0
		internal Index ConstraintIndex
		{
			get
			{
				return this._constraintIndex;
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		internal void ConstraintIndexClear()
		{
			if (this._constraintIndex != null)
			{
				this._constraintIndex.RemoveRef();
				this._constraintIndex = null;
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0002C7F5 File Offset: 0x0002A9F5
		internal void ConstraintIndexInitialize()
		{
			if (this._constraintIndex == null)
			{
				this._constraintIndex = this._key.GetSortIndex();
				this._constraintIndex.AddRef();
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0002C81B File Offset: 0x0002AA1B
		internal override void CheckState()
		{
			this.NonVirtualCheckState();
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0002C823 File Offset: 0x0002AA23
		private void NonVirtualCheckState()
		{
			this._key.CheckState();
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000057B2 File Offset: 0x000039B2
		internal override void CheckCanAddToCollection(ConstraintCollection constraints)
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0002C830 File Offset: 0x0002AA30
		internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
		{
			if (!this.Equals(constraints.Table._primaryKey))
			{
				ParentForeignKeyConstraintEnumerator parentForeignKeyConstraintEnumerator = new ParentForeignKeyConstraintEnumerator(this.Table.DataSet, this.Table);
				while (parentForeignKeyConstraintEnumerator.GetNext())
				{
					ForeignKeyConstraint foreignKeyConstraint = parentForeignKeyConstraintEnumerator.GetForeignKeyConstraint();
					if (this._key.ColumnsEqual(foreignKeyConstraint.ParentKey))
					{
						if (!fThrowException)
						{
							return false;
						}
						throw ExceptionBuilder.NeededForForeignKeyConstraint(this, foreignKeyConstraint);
					}
				}
				return true;
			}
			if (!fThrowException)
			{
				return false;
			}
			throw ExceptionBuilder.RemovePrimaryKey(constraints.Table);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0002C8AA File Offset: 0x0002AAAA
		internal override bool CanEnableConstraint()
		{
			return !this.Table.EnforceConstraints || this.ConstraintIndex.CheckUnique();
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
		internal override bool IsConstraintViolated()
		{
			bool result = false;
			Index constraintIndex = this.ConstraintIndex;
			if (constraintIndex.HasDuplicates)
			{
				object[] uniqueKeyValues = constraintIndex.GetUniqueKeyValues();
				for (int i = 0; i < uniqueKeyValues.Length; i++)
				{
					Range range = constraintIndex.FindRecords((object[])uniqueKeyValues[i]);
					if (1 < range.Count)
					{
						DataRow[] rows = constraintIndex.GetRows(range);
						string text = ExceptionBuilder.UniqueConstraintViolationText(this._key.ColumnsReference, (object[])uniqueKeyValues[i]);
						for (int j = 0; j < rows.Length; j++)
						{
							rows[j].RowError = text;
							foreach (DataColumn column in this._key.ColumnsReference)
							{
								rows[j].SetColumnError(column, text);
							}
						}
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0002C99C File Offset: 0x0002AB9C
		internal override void CheckConstraint(DataRow row, DataRowAction action)
		{
			if (this.Table.EnforceConstraints && (action == DataRowAction.Add || action == DataRowAction.Change || (action == DataRowAction.Rollback && row._tempRecord != -1)) && row.HaveValuesChanged(this.ColumnsReference) && this.ConstraintIndex.IsKeyRecordInIndex(row.GetDefaultRecord()))
			{
				object[] columnValues = row.GetColumnValues(this.ColumnsReference);
				throw ExceptionBuilder.ConstraintViolation(this.ColumnsReference, columnValues);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0002CA07 File Offset: 0x0002AC07
		internal override bool ContainsColumn(DataColumn column)
		{
			return this._key.ContainsColumn(column);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000253DF File Offset: 0x000235DF
		internal override Constraint Clone(DataSet destination)
		{
			return this.Clone(destination, false);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0002CA18 File Offset: 0x0002AC18
		internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
		{
			int num;
			if (ignorNSforTableLookup)
			{
				num = destination.Tables.IndexOf(this.Table.TableName);
			}
			else
			{
				num = destination.Tables.IndexOf(this.Table.TableName, this.Table.Namespace, false);
			}
			if (num < 0)
			{
				return null;
			}
			DataTable dataTable = destination.Tables[num];
			int num2 = this.ColumnsReference.Length;
			DataColumn[] array = new DataColumn[num2];
			for (int i = 0; i < num2; i++)
			{
				DataColumn dataColumn = this.ColumnsReference[i];
				num = dataTable.Columns.IndexOf(dataColumn.ColumnName);
				if (num < 0)
				{
					return null;
				}
				array[i] = dataTable.Columns[num];
			}
			UniqueConstraint uniqueConstraint = new UniqueConstraint(this.ConstraintName, array);
			foreach (object key in base.ExtendedProperties.Keys)
			{
				uniqueConstraint.ExtendedProperties[key] = base.ExtendedProperties[key];
			}
			return uniqueConstraint;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002CB44 File Offset: 0x0002AD44
		internal UniqueConstraint Clone(DataTable table)
		{
			int num = this.ColumnsReference.Length;
			DataColumn[] array = new DataColumn[num];
			for (int i = 0; i < num; i++)
			{
				DataColumn dataColumn = this.ColumnsReference[i];
				int num2 = table.Columns.IndexOf(dataColumn.ColumnName);
				if (num2 < 0)
				{
					return null;
				}
				array[i] = table.Columns[num2];
			}
			UniqueConstraint uniqueConstraint = new UniqueConstraint(this.ConstraintName, array);
			foreach (object key in base.ExtendedProperties.Keys)
			{
				uniqueConstraint.ExtendedProperties[key] = base.ExtendedProperties[key];
			}
			return uniqueConstraint;
		}

		/// <summary>Gets the array of columns that this constraint affects.</summary>
		/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects.</returns>
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0002CC18 File Offset: 0x0002AE18
		[ReadOnly(true)]
		public virtual DataColumn[] Columns
		{
			get
			{
				return this._key.ToArray();
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0002CC25 File Offset: 0x0002AE25
		internal DataColumn[] ColumnsReference
		{
			get
			{
				return this._key.ColumnsReference;
			}
		}

		/// <summary>Gets a value indicating whether or not the constraint is on a primary key.</summary>
		/// <returns>
		///     <see langword="true" />, if the constraint is on a primary key; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0002CC32 File Offset: 0x0002AE32
		public bool IsPrimaryKey
		{
			get
			{
				return this.Table != null && this == this.Table._primaryKey;
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002CC4C File Offset: 0x0002AE4C
		private void Create(string constraintName, DataColumn[] columns)
		{
			for (int i = 0; i < columns.Length; i++)
			{
				if (columns[i].Computed)
				{
					throw ExceptionBuilder.ExpressionInConstraint(columns[i]);
				}
			}
			this._key = new DataKey(columns, true);
			this.ConstraintName = constraintName;
			this.NonVirtualCheckState();
		}

		/// <summary>Compares this constraint to a second to determine if both are identical.</summary>
		/// <param name="key2">The object to which this <see cref="T:System.Data.UniqueConstraint" /> is compared. </param>
		/// <returns>
		///     <see langword="true" />, if the contraints are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x060008EC RID: 2284 RVA: 0x0002CC94 File Offset: 0x0002AE94
		public override bool Equals(object key2)
		{
			return key2 is UniqueConstraint && this.Key.ColumnsEqual(((UniqueConstraint)key2).Key);
		}

		/// <summary>Gets the hash code of this instance of the <see cref="T:System.Data.UniqueConstraint" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060008ED RID: 2285 RVA: 0x00025806 File Offset: 0x00023A06
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x17000154 RID: 340
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x0002CCC4 File Offset: 0x0002AEC4
		internal override bool InCollection
		{
			set
			{
				base.InCollection = value;
				if (this._key.ColumnsReference.Length == 1)
				{
					this._key.ColumnsReference[0].InternalUnique(value);
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0002CCF0 File Offset: 0x0002AEF0
		internal DataKey Key
		{
			get
			{
				return this._key;
			}
		}

		/// <summary>Gets the table to which this constraint belongs.</summary>
		/// <returns>The <see cref="T:System.Data.DataTable" /> to which the constraint belongs.</returns>
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0002CCF8 File Offset: 0x0002AEF8
		[ReadOnly(true)]
		public override DataTable Table
		{
			get
			{
				if (this._key.HasValue)
				{
					return this._key.Table;
				}
				return null;
			}
		}

		// Token: 0x04000301 RID: 769
		private DataKey _key;

		// Token: 0x04000302 RID: 770
		private Index _constraintIndex;

		// Token: 0x04000303 RID: 771
		internal bool _bPrimaryKey;

		// Token: 0x04000304 RID: 772
		internal string _constraintName;

		// Token: 0x04000305 RID: 773
		internal string[] _columnNames;
	}
}
