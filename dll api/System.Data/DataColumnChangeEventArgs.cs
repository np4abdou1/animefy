using System;

namespace System.Data
{
	/// <summary>Provides data for the <see cref="E:System.Data.DataTable.ColumnChanging" /> event.</summary>
	// Token: 0x02000013 RID: 19
	public class DataColumnChangeEventArgs : EventArgs
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00005C99 File Offset: 0x00003E99
		internal DataColumnChangeEventArgs(DataRow row)
		{
			this.<Row>k__BackingField = row;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataColumnChangeEventArgs" /> class.</summary>
		/// <param name="row">The <see cref="T:System.Data.DataRow" /> of the column with the changing value. </param>
		/// <param name="column">The <see cref="T:System.Data.DataColumn" /> with the changing value. </param>
		/// <param name="value">The new value. </param>
		// Token: 0x06000102 RID: 258 RVA: 0x00005CA8 File Offset: 0x00003EA8
		public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value)
		{
			this.<Row>k__BackingField = row;
			this._column = column;
			this.ProposedValue = value;
		}

		/// <summary>Gets or sets the proposed new value for the column.</summary>
		/// <returns>The proposed value, of type <see cref="T:System.Object" />.</returns>
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00005CC5 File Offset: 0x00003EC5
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00005CCD File Offset: 0x00003ECD
		public object ProposedValue { get; set; }

		// Token: 0x06000105 RID: 261 RVA: 0x00005CD6 File Offset: 0x00003ED6
		internal void InitializeColumnChangeEvent(DataColumn column, object value)
		{
			this._column = column;
			this.ProposedValue = value;
		}

		// Token: 0x0400004D RID: 77
		private DataColumn _column;
	}
}
