using System;

namespace System.ComponentModel
{
	/// <summary>Specifies how the list changed.</summary>
	// Token: 0x02000276 RID: 630
	public enum ListChangedType
	{
		/// <summary>Much of the list has changed. Any listening controls should refresh all their data from the list.</summary>
		// Token: 0x04000C66 RID: 3174
		Reset,
		/// <summary>An item added to the list. <see cref="P:System.ComponentModel.ListChangedEventArgs.NewIndex" /> contains the index of the item that was added.</summary>
		// Token: 0x04000C67 RID: 3175
		ItemAdded,
		/// <summary>An item deleted from the list. <see cref="P:System.ComponentModel.ListChangedEventArgs.NewIndex" /> contains the index of the item that was deleted.</summary>
		// Token: 0x04000C68 RID: 3176
		ItemDeleted,
		/// <summary>An item moved within the list. <see cref="P:System.ComponentModel.ListChangedEventArgs.OldIndex" /> contains the previous index for the item, whereas <see cref="P:System.ComponentModel.ListChangedEventArgs.NewIndex" /> contains the new index for the item.</summary>
		// Token: 0x04000C69 RID: 3177
		ItemMoved,
		/// <summary>An item changed in the list. <see cref="P:System.ComponentModel.ListChangedEventArgs.NewIndex" /> contains the index of the item that was changed.</summary>
		// Token: 0x04000C6A RID: 3178
		ItemChanged,
		/// <summary>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> was added, which changed the schema.</summary>
		// Token: 0x04000C6B RID: 3179
		PropertyDescriptorAdded,
		/// <summary>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> was deleted, which changed the schema.</summary>
		// Token: 0x04000C6C RID: 3180
		PropertyDescriptorDeleted,
		/// <summary>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> was changed, which changed the schema.</summary>
		// Token: 0x04000C6D RID: 3181
		PropertyDescriptorChanged
	}
}
