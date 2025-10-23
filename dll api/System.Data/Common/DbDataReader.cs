using System;
using System.Collections;
using System.ComponentModel;

namespace System.Data.Common
{
	/// <summary>Reads a forward-only stream of rows from a data source.</summary>
	// Token: 0x020000E5 RID: 229
	public abstract class DbDataReader : MarshalByRefObject, IDataReader, IDisposable, IDataRecord, IEnumerable
	{
		/// <summary>Gets the number of columns in the current row.</summary>
		/// <returns>The number of columns in the current row.</returns>
		/// <exception cref="T:System.NotSupportedException">There is no current connection to an instance of SQL Server. </exception>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000FAC RID: 4012
		public abstract int FieldCount { get; }

		/// <summary>Gets a value indicating whether the <see cref="T:System.Data.Common.DbDataReader" /> is closed.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Data.Common.DbDataReader" /> is closed; otherwise <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Data.SqlClient.SqlDataReader" /> is closed. </exception>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000FAD RID: 4013
		public abstract bool IsClosed { get; }

		/// <summary>Gets the number of fields in the <see cref="T:System.Data.Common.DbDataReader" /> that are not hidden.</summary>
		/// <returns>The number of fields that are not hidden.</returns>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0004CCAF File Offset: 0x0004AEAF
		public virtual int VisibleFieldCount
		{
			get
			{
				return this.FieldCount;
			}
		}

		/// <summary>Gets the value of the specified column as an instance of <see cref="T:System.Object" />.</summary>
		/// <param name="ordinal">The zero-based column ordinal.</param>
		/// <returns>The value of the specified column.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount" />. </exception>
		// Token: 0x17000217 RID: 535
		public abstract object this[int ordinal]
		{
			get;
		}

		/// <summary>Closes the <see cref="T:System.Data.Common.DbDataReader" /> object.</summary>
		// Token: 0x06000FB0 RID: 4016 RVA: 0x000057B2 File Offset: 0x000039B2
		public virtual void Close()
		{
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Data.Common.DbDataReader" /> class.</summary>
		// Token: 0x06000FB1 RID: 4017 RVA: 0x0004CCB7 File Offset: 0x0004AEB7
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Releases the managed resources used by the <see cref="T:System.Data.Common.DbDataReader" /> and optionally releases the unmanaged resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		// Token: 0x06000FB2 RID: 4018 RVA: 0x0004CCC0 File Offset: 0x0004AEC0
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close();
			}
		}

		/// <summary>Gets name of the data type of the specified column.</summary>
		/// <param name="ordinal">The zero-based column ordinal.</param>
		/// <returns>A string representing the name of the data type.</returns>
		/// <exception cref="T:System.InvalidCastException">The specified cast is not valid. </exception>
		// Token: 0x06000FB3 RID: 4019
		public abstract string GetDataTypeName(int ordinal);

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the rows in the data reader.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the rows in the data reader.</returns>
		// Token: 0x06000FB4 RID: 4020
		[EditorBrowsable(EditorBrowsableState.Never)]
		public abstract IEnumerator GetEnumerator();

		/// <summary>Gets the data type of the specified column.</summary>
		/// <param name="ordinal">The zero-based column ordinal.</param>
		/// <returns>The data type of the specified column.</returns>
		/// <exception cref="T:System.InvalidCastException">The specified cast is not valid. </exception>
		// Token: 0x06000FB5 RID: 4021
		public abstract Type GetFieldType(int ordinal);

		/// <summary>Gets the name of the column, given the zero-based column ordinal.</summary>
		/// <param name="ordinal">The zero-based column ordinal.</param>
		/// <returns>The name of the specified column.</returns>
		// Token: 0x06000FB6 RID: 4022
		public abstract string GetName(int ordinal);

		/// <summary>Returns a <see cref="T:System.Data.DataTable" /> that describes the column metadata of the <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataTable" /> that describes the column metadata.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Data.SqlClient.SqlDataReader" /> is closed. </exception>
		// Token: 0x06000FB7 RID: 4023 RVA: 0x0004CCCB File Offset: 0x0004AECB
		public virtual DataTable GetSchemaTable()
		{
			throw new NotSupportedException();
		}

		/// <summary>Returns the provider-specific field type of the specified column.</summary>
		/// <param name="ordinal">The zero-based column ordinal.</param>
		/// <returns>The <see cref="T:System.Type" /> object that describes the data type of the specified column.</returns>
		// Token: 0x06000FB8 RID: 4024 RVA: 0x0004CCD2 File Offset: 0x0004AED2
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual Type GetProviderSpecificFieldType(int ordinal)
		{
			return this.GetFieldType(ordinal);
		}

		/// <summary>Gets all provider-specific attribute columns in the collection for the current row.</summary>
		/// <param name="values">An array of <see cref="T:System.Object" /> into which to copy the attribute columns.</param>
		/// <returns>The number of instances of <see cref="T:System.Object" /> in the array.</returns>
		// Token: 0x06000FB9 RID: 4025 RVA: 0x0004CCDB File Offset: 0x0004AEDB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual int GetProviderSpecificValues(object[] values)
		{
			return this.GetValues(values);
		}

		/// <summary>Populates an array of objects with the column values of the current row.</summary>
		/// <param name="values">An array of <see cref="T:System.Object" /> into which to copy the attribute columns.</param>
		/// <returns>The number of instances of <see cref="T:System.Object" /> in the array.</returns>
		// Token: 0x06000FBA RID: 4026
		public abstract int GetValues(object[] values);

		/// <summary>Advances the reader to the next result when reading the results of a batch of statements.</summary>
		/// <returns>
		///     <see langword="true" /> if there are more result sets; otherwise <see langword="false" />.</returns>
		// Token: 0x06000FBB RID: 4027
		public abstract bool NextResult();

		/// <summary>Advances the reader to the next record in a result set.</summary>
		/// <returns>
		///     <see langword="true" /> if there are more rows; otherwise <see langword="false" />.</returns>
		// Token: 0x06000FBC RID: 4028
		public abstract bool Read();
	}
}
