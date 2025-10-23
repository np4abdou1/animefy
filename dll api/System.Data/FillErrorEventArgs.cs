using System;

namespace System.Data
{
	/// <summary>Provides data for the <see cref="E:System.Data.Common.DataAdapter.FillError" /> event of a <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
	// Token: 0x02000051 RID: 81
	public class FillErrorEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.FillErrorEventArgs" /> class.</summary>
		/// <param name="dataTable">The <see cref="T:System.Data.DataTable" /> being updated. </param>
		/// <param name="values">The values for the row being updated. </param>
		// Token: 0x0600067B RID: 1659 RVA: 0x0001D86F File Offset: 0x0001BA6F
		public FillErrorEventArgs(DataTable dataTable, object[] values)
		{
			this._dataTable = dataTable;
			this._values = values;
			if (this._values == null)
			{
				this._values = Array.Empty<object>();
			}
		}

		/// <summary>Gets or sets a value indicating whether to continue the fill operation despite the error.</summary>
		/// <returns>
		///     <see langword="true" /> if the fill operation should continue; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001D898 File Offset: 0x0001BA98
		public bool Continue
		{
			get
			{
				return this._continueFlag;
			}
		}

		/// <summary>Gets the errors being handled.</summary>
		/// <returns>The errors being handled.</returns>
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0001D8A0 File Offset: 0x0001BAA0
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
		public Exception Errors
		{
			get
			{
				return this._errors;
			}
			set
			{
				this._errors = value;
			}
		}

		// Token: 0x0400018E RID: 398
		private bool _continueFlag;

		// Token: 0x0400018F RID: 399
		private DataTable _dataTable;

		// Token: 0x04000190 RID: 400
		private Exception _errors;

		// Token: 0x04000191 RID: 401
		private object[] _values;
	}
}
