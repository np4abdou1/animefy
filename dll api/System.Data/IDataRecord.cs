using System;

namespace System.Data
{
	/// <summary>Provides access to the column values within each row for a <see langword="DataReader" />, and is implemented by .NET Framework data providers that access relational databases.</summary>
	// Token: 0x02000071 RID: 113
	public interface IDataRecord
	{
		/// <summary>Gets the number of columns in the current row.</summary>
		/// <returns>When not positioned in a valid recordset, 0; otherwise, the number of columns in the current record. The default is -1.</returns>
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060007B6 RID: 1974
		int FieldCount { get; }

		/// <summary>Gets the column located at the specified index.</summary>
		/// <param name="i">The zero-based index of the column to get. </param>
		/// <returns>The column located at the specified index as an <see cref="T:System.Object" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount" />. </exception>
		// Token: 0x1700012B RID: 299
		object this[int i]
		{
			get;
		}

		/// <summary>Gets the name for the field to find.</summary>
		/// <param name="i">The index of the field to find. </param>
		/// <returns>The name of the field or the empty string (""), if there is no value to return.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount" />. </exception>
		// Token: 0x060007B8 RID: 1976
		string GetName(int i);

		/// <summary>Gets the data type information for the specified field.</summary>
		/// <param name="i">The index of the field to find. </param>
		/// <returns>The data type information for the specified field.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount" />. </exception>
		// Token: 0x060007B9 RID: 1977
		string GetDataTypeName(int i);

		/// <summary>Gets the <see cref="T:System.Type" /> information corresponding to the type of <see cref="T:System.Object" /> that would be returned from <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)" />.</summary>
		/// <param name="i">The index of the field to find. </param>
		/// <returns>The <see cref="T:System.Type" /> information corresponding to the type of <see cref="T:System.Object" /> that would be returned from <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The index passed was outside the range of 0 through <see cref="P:System.Data.IDataRecord.FieldCount" />. </exception>
		// Token: 0x060007BA RID: 1978
		Type GetFieldType(int i);

		/// <summary>Populates an array of objects with the column values of the current record.</summary>
		/// <param name="values">An array of <see cref="T:System.Object" /> to copy the attribute fields into. </param>
		/// <returns>The number of instances of <see cref="T:System.Object" /> in the array.</returns>
		// Token: 0x060007BB RID: 1979
		int GetValues(object[] values);
	}
}
