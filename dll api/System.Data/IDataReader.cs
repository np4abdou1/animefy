using System;

namespace System.Data
{
	/// <summary>Provides a means of reading one or more forward-only streams of result sets obtained by executing a command at a data source, and is implemented by .NET Framework data providers that access relational databases.</summary>
	// Token: 0x02000070 RID: 112
	public interface IDataReader : IDisposable, IDataRecord
	{
		/// <summary>Gets a value indicating whether the data reader is closed.</summary>
		/// <returns>
		///     <see langword="true" /> if the data reader is closed; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060007B1 RID: 1969
		bool IsClosed { get; }

		/// <summary>Closes the <see cref="T:System.Data.IDataReader" /> Object.</summary>
		// Token: 0x060007B2 RID: 1970
		void Close();

		/// <summary>Returns a <see cref="T:System.Data.DataTable" /> that describes the column metadata of the <see cref="T:System.Data.IDataReader" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataTable" /> that describes the column metadata.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Data.IDataReader" /> is closed. </exception>
		// Token: 0x060007B3 RID: 1971
		DataTable GetSchemaTable();

		/// <summary>Advances the data reader to the next result, when reading the results of batch SQL statements.</summary>
		/// <returns>
		///     <see langword="true" /> if there are more rows; otherwise, <see langword="false" />.</returns>
		// Token: 0x060007B4 RID: 1972
		bool NextResult();

		/// <summary>Advances the <see cref="T:System.Data.IDataReader" /> to the next record.</summary>
		/// <returns>
		///     <see langword="true" /> if there are more rows; otherwise, <see langword="false" />.</returns>
		// Token: 0x060007B5 RID: 1973
		bool Read();
	}
}
