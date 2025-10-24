using System;

namespace System.Data
{
	/// <summary>Describes an action performed on a <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x0200002D RID: 45
	[Flags]
	public enum DataRowAction
	{
		/// <summary>The row has not changed.</summary>
		// Token: 0x04000097 RID: 151
		Nothing = 0,
		/// <summary>The row was deleted from the table.</summary>
		// Token: 0x04000098 RID: 152
		Delete = 1,
		/// <summary>The row has changed.</summary>
		// Token: 0x04000099 RID: 153
		Change = 2,
		/// <summary>The most recent change to the row has been rolled back.</summary>
		// Token: 0x0400009A RID: 154
		Rollback = 4,
		/// <summary>The changes to the row have been committed.</summary>
		// Token: 0x0400009B RID: 155
		Commit = 8,
		/// <summary>The row has been added to the table.</summary>
		// Token: 0x0400009C RID: 156
		Add = 16,
		/// <summary>The original version of the row has been changed.</summary>
		// Token: 0x0400009D RID: 157
		ChangeOriginal = 32,
		/// <summary>The original and the current versions of the row have been changed.</summary>
		// Token: 0x0400009E RID: 158
		ChangeCurrentAndOriginal = 64
	}
}
