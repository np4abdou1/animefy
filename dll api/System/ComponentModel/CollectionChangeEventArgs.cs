using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.Data.DataColumnCollection.CollectionChanged" /> event.</summary>
	// Token: 0x02000252 RID: 594
	public class CollectionChangeEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> class.</summary>
		/// <param name="action">One of the <see cref="T:System.ComponentModel.CollectionChangeAction" /> values that specifies how the collection changed. </param>
		/// <param name="element">An <see cref="T:System.Object" /> that specifies the instance of the collection where the change occurred. </param>
		// Token: 0x06000FEE RID: 4078 RVA: 0x0004DF58 File Offset: 0x0004C158
		public CollectionChangeEventArgs(CollectionChangeAction action, object element)
		{
			this.Action = action;
			this.Element = element;
		}

		/// <summary>Gets an action that specifies how the collection changed.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.CollectionChangeAction" /> values.</returns>
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0004DF6E File Offset: 0x0004C16E
		public virtual CollectionChangeAction Action { get; }

		/// <summary>Gets the instance of the collection with the change.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the instance of the collection with the change, or <see langword="null" /> if you refresh the collection.</returns>
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0004DF76 File Offset: 0x0004C176
		public virtual object Element { get; }
	}
}
