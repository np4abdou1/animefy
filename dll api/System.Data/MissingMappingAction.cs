﻿using System;

namespace System.Data
{
	/// <summary>Determines the action that occurs when a mapping is missing from a source table or a source column.</summary>
	// Token: 0x02000078 RID: 120
	public enum MissingMappingAction
	{
		/// <summary>The source column or source table is created and added to the <see cref="T:System.Data.DataSet" /> using its original name.</summary>
		// Token: 0x04000274 RID: 628
		Passthrough = 1,
		/// <summary>The column or table not having a mapping is ignored. Returns <see langword="null" />.</summary>
		// Token: 0x04000275 RID: 629
		Ignore,
		/// <summary>An <see cref="T:System.InvalidOperationException" /> is generated if the specified column mapping is missing.</summary>
		// Token: 0x04000276 RID: 630
		Error
	}
}
