using System;

namespace System.Data
{
	// Token: 0x02000017 RID: 23
	internal sealed class DataError
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00006D4F File Offset: 0x00004F4F
		internal DataError()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006D62 File Offset: 0x00004F62
		internal DataError(string rowError)
		{
			this.SetText(rowError);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00006D7C File Offset: 0x00004F7C
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00006D84 File Offset: 0x00004F84
		internal string Text
		{
			get
			{
				return this._rowError;
			}
			set
			{
				this.SetText(value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006D8D File Offset: 0x00004F8D
		internal bool HasErrors
		{
			get
			{
				return this._rowError.Length != 0 || this._count != 0;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006DA8 File Offset: 0x00004FA8
		internal void SetColumnError(DataColumn column, string error)
		{
			if (error == null || error.Length == 0)
			{
				this.Clear(column);
				return;
			}
			if (this._errorList == null)
			{
				this._errorList = new DataError.ColumnError[1];
			}
			int num = this.IndexOf(column);
			this._errorList[num]._column = column;
			this._errorList[num]._error = error;
			column._errors++;
			if (num == this._count)
			{
				this._count++;
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006E30 File Offset: 0x00005030
		internal string GetColumnError(DataColumn column)
		{
			for (int i = 0; i < this._count; i++)
			{
				if (this._errorList[i]._column == column)
				{
					return this._errorList[i]._error;
				}
			}
			return string.Empty;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006E7C File Offset: 0x0000507C
		internal void Clear(DataColumn column)
		{
			if (this._count == 0)
			{
				return;
			}
			for (int i = 0; i < this._count; i++)
			{
				if (this._errorList[i]._column == column)
				{
					Array.Copy(this._errorList, i + 1, this._errorList, i, this._count - i - 1);
					this._count--;
					column._errors--;
				}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006EF4 File Offset: 0x000050F4
		internal void Clear()
		{
			for (int i = 0; i < this._count; i++)
			{
				this._errorList[i]._column._errors--;
			}
			this._count = 0;
			this._rowError = string.Empty;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006F44 File Offset: 0x00005144
		internal DataColumn[] GetColumnsInError()
		{
			DataColumn[] array = new DataColumn[this._count];
			for (int i = 0; i < this._count; i++)
			{
				array[i] = this._errorList[i]._column;
			}
			return array;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006F83 File Offset: 0x00005183
		private void SetText(string errorText)
		{
			if (errorText == null)
			{
				errorText = string.Empty;
			}
			this._rowError = errorText;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006F98 File Offset: 0x00005198
		internal int IndexOf(DataColumn column)
		{
			for (int i = 0; i < this._count; i++)
			{
				if (this._errorList[i]._column == column)
				{
					return i;
				}
			}
			if (this._count >= this._errorList.Length)
			{
				DataError.ColumnError[] array = new DataError.ColumnError[Math.Min(this._count * 2, column.Table.Columns.Count)];
				Array.Copy(this._errorList, 0, array, 0, this._count);
				this._errorList = array;
			}
			return this._count;
		}

		// Token: 0x0400005D RID: 93
		private string _rowError = string.Empty;

		// Token: 0x0400005E RID: 94
		private int _count;

		// Token: 0x0400005F RID: 95
		private DataError.ColumnError[] _errorList;

		// Token: 0x02000018 RID: 24
		internal struct ColumnError
		{
			// Token: 0x04000060 RID: 96
			internal DataColumn _column;

			// Token: 0x04000061 RID: 97
			internal string _error;
		}
	}
}
