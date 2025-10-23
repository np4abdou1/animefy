using System;

namespace System.Data
{
	/// <summary>Describes the version of data in a <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x0200004C RID: 76
	[Flags]
	public enum DataViewRowState
	{
		/// <summary>None.</summary>
		// Token: 0x0400017C RID: 380
		None = 0,
		/// <summary>An unchanged row.</summary>
		// Token: 0x0400017D RID: 381
		Unchanged = 2,
		/// <summary>A new row.</summary>
		// Token: 0x0400017E RID: 382
		Added = 4,
		/// <summary>A deleted row.</summary>
		// Token: 0x0400017F RID: 383
		Deleted = 8,
		/// <summary>A current version of original data that has been modified (see <see langword="ModifiedOriginal" />).</summary>
		// Token: 0x04000180 RID: 384
		ModifiedCurrent = 16,
		/// <summary>The original version of the data that was modified. (Although the data has since been modified, it is available as <see langword="ModifiedCurrent" />).</summary>
		// Token: 0x04000181 RID: 385
		ModifiedOriginal = 32,
		/// <summary>Original rows including unchanged and deleted rows.</summary>
		// Token: 0x04000182 RID: 386
		OriginalRows = 42,
		/// <summary>Current rows including unchanged, new, and modified rows. By default, <see cref="T:System.Data.DataViewRowState" /> is set to CurrentRows.</summary>
		// Token: 0x04000183 RID: 387
		CurrentRows = 22
	}
}
