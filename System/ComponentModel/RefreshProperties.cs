using System;

namespace System.ComponentModel
{
	/// <summary>Defines identifiers that indicate the type of a refresh of the Properties window.</summary>
	// Token: 0x020002B1 RID: 689
	public enum RefreshProperties
	{
		/// <summary>No refresh is necessary.</summary>
		// Token: 0x04000D03 RID: 3331
		None,
		/// <summary>The properties should be requeried and the view should be refreshed.</summary>
		// Token: 0x04000D04 RID: 3332
		All,
		/// <summary>The view should be refreshed.</summary>
		// Token: 0x04000D05 RID: 3333
		Repaint
	}
}
