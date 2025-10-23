using System;

namespace System.Collections.Specialized
{
	/// <summary>Describes the action that caused a <see cref="E:System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged" /> event. </summary>
	// Token: 0x020002CB RID: 715
	public enum NotifyCollectionChangedAction
	{
		/// <summary>An item was added to the collection.</summary>
		// Token: 0x04000D36 RID: 3382
		Add,
		/// <summary>An item was removed from the collection.</summary>
		// Token: 0x04000D37 RID: 3383
		Remove,
		/// <summary>An item was replaced in the collection.</summary>
		// Token: 0x04000D38 RID: 3384
		Replace,
		/// <summary>An item was moved within the collection.</summary>
		// Token: 0x04000D39 RID: 3385
		Move,
		/// <summary>The content of the collection was cleared.</summary>
		// Token: 0x04000D3A RID: 3386
		Reset
	}
}
