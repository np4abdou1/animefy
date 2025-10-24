using System;

namespace System.ComponentModel
{
	/// <summary>Specifies how the collection is changed.</summary>
	// Token: 0x02000251 RID: 593
	public enum CollectionChangeAction
	{
		/// <summary>Specifies that an element was added to the collection.</summary>
		// Token: 0x04000C35 RID: 3125
		Add = 1,
		/// <summary>Specifies that an element was removed from the collection.</summary>
		// Token: 0x04000C36 RID: 3126
		Remove,
		/// <summary>Specifies that the entire collection has changed. This is caused by using methods that manipulate the entire collection, such as <see cref="M:System.Collections.CollectionBase.Clear" />.</summary>
		// Token: 0x04000C37 RID: 3127
		Refresh
	}
}
