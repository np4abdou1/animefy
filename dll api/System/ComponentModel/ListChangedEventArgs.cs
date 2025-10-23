using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.IBindingList.ListChanged" /> event.</summary>
	// Token: 0x02000274 RID: 628
	public class ListChangedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListChangedEventArgs" /> class given the type of change and the index of the affected item.</summary>
		/// <param name="listChangedType">A <see cref="T:System.ComponentModel.ListChangedType" /> value indicating the type of change.</param>
		/// <param name="newIndex">The index of the item that was added, changed, or removed.</param>
		// Token: 0x060010BF RID: 4287 RVA: 0x0005051A File Offset: 0x0004E71A
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex) : this(listChangedType, newIndex, -1)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListChangedEventArgs" /> class given the type of change, the index of the affected item, and a <see cref="T:System.ComponentModel.PropertyDescriptor" /> describing the affected item.</summary>
		/// <param name="listChangedType">A <see cref="T:System.ComponentModel.ListChangedType" /> value indicating the type of change.</param>
		/// <param name="newIndex">The index of the item that was added or changed.</param>
		/// <param name="propDesc">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> describing the item.</param>
		// Token: 0x060010C0 RID: 4288 RVA: 0x00050525 File Offset: 0x0004E725
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) : this(listChangedType, newIndex)
		{
			this.<PropertyDescriptor>k__BackingField = propDesc;
			this.OldIndex = newIndex;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListChangedEventArgs" /> class given the type of change and the <see cref="T:System.ComponentModel.PropertyDescriptor" /> affected.</summary>
		/// <param name="listChangedType">A <see cref="T:System.ComponentModel.ListChangedType" /> value indicating the type of change.</param>
		/// <param name="propDesc">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> that was added, removed, or changed.</param>
		// Token: 0x060010C1 RID: 4289 RVA: 0x0005053D File Offset: 0x0004E73D
		public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
		{
			this.ListChangedType = listChangedType;
			this.<PropertyDescriptor>k__BackingField = propDesc;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListChangedEventArgs" /> class given the type of change and the old and new index of the item that was moved.</summary>
		/// <param name="listChangedType">A <see cref="T:System.ComponentModel.ListChangedType" /> value indicating the type of change.</param>
		/// <param name="newIndex">The new index of the item that was moved.</param>
		/// <param name="oldIndex">The old index of the item that was moved.</param>
		// Token: 0x060010C2 RID: 4290 RVA: 0x00050553 File Offset: 0x0004E753
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
		{
			this.ListChangedType = listChangedType;
			this.NewIndex = newIndex;
			this.OldIndex = oldIndex;
		}

		/// <summary>Gets the type of change.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.ListChangedType" /> value indicating the type of change.</returns>
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00050570 File Offset: 0x0004E770
		public ListChangedType ListChangedType { get; }

		/// <summary>Gets the index of the item affected by the change.</summary>
		/// <returns>The index of the affected by the change.</returns>
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00050578 File Offset: 0x0004E778
		public int NewIndex { get; }

		/// <summary>Gets the old index of an item that has been moved.</summary>
		/// <returns>The old index of the moved item.</returns>
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00050580 File Offset: 0x0004E780
		public int OldIndex { get; }
	}
}
