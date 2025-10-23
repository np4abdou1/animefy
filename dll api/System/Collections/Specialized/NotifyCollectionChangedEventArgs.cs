using System;

namespace System.Collections.Specialized
{
	/// <summary>Provides data for the <see cref="E:System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged" /> event.</summary>
	// Token: 0x020002CC RID: 716
	public class NotifyCollectionChangedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" /> class that describes a <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" /> change.</summary>
		/// <param name="action">The action that caused the event. This must be set to <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />.</param>
		// Token: 0x0600132B RID: 4907 RVA: 0x0005A793 File Offset: 0x00058993
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
		{
			if (action != NotifyCollectionChangedAction.Reset)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Reset), "action");
			}
			this.InitializeAdd(action, null, -1);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" /> class that describes a one-item change.</summary>
		/// <param name="action">The action that caused the event. This can be set to <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />, <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Add" />, or <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Remove" />.</param>
		/// <param name="changedItem">The item that is affected by the change.</param>
		/// <param name="index">The index where the change occurred.</param>
		/// <exception cref="T:System.ArgumentException">If <paramref name="action" /> is not Reset, Add, or Remove, or if <paramref name="action" /> is Reset and either <paramref name="changedItems" /> is not null or <paramref name="index" /> is not -1.</exception>
		// Token: 0x0600132C RID: 4908 RVA: 0x0005A7D4 File Offset: 0x000589D4
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
		{
			if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
			{
				throw new ArgumentException("Constructor only supports either a Reset, Add, or Remove action.", "action");
			}
			if (action != NotifyCollectionChangedAction.Reset)
			{
				this.InitializeAddOrRemove(action, new object[]
				{
					changedItem
				}, index);
				return;
			}
			if (changedItem != null)
			{
				throw new ArgumentException("Reset action must be initialized with no changed items.", "action");
			}
			if (index != -1)
			{
				throw new ArgumentException("Reset action must be initialized with index -1.", "action");
			}
			this.InitializeAdd(action, null, -1);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" /> class that describes a one-item <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" /> change.</summary>
		/// <param name="action">The action that caused the event. This can be set to <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" />.</param>
		/// <param name="newItem">The new item that is replacing the original item.</param>
		/// <param name="oldItem">The original item that is replaced.</param>
		/// <param name="index">The index of the item being replaced.</param>
		/// <exception cref="T:System.ArgumentException">If <paramref name="action" /> is not Replace.</exception>
		// Token: 0x0600132D RID: 4909 RVA: 0x0005A858 File Offset: 0x00058A58
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
		{
			if (action != NotifyCollectionChangedAction.Replace)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Replace), "action");
			}
			this.InitializeMoveOrReplace(action, new object[]
			{
				newItem
			}, new object[]
			{
				oldItem
			}, index, index);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" /> class that describes a multi-item <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" /> change.</summary>
		/// <param name="action">The action that caused the event. This can only be set to <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" />.</param>
		/// <param name="newItems">The new items that are replacing the original items.</param>
		/// <param name="oldItems">The original items that are replaced.</param>
		/// <param name="startingIndex">The index of the first item of the items that are being replaced.</param>
		/// <exception cref="T:System.ArgumentException">If <paramref name="action" /> is not Replace.</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="oldItems" /> or <paramref name="newItems" /> is null.</exception>
		// Token: 0x0600132E RID: 4910 RVA: 0x0005A8B8 File Offset: 0x00058AB8
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
		{
			if (action != NotifyCollectionChangedAction.Replace)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Replace), "action");
			}
			if (newItems == null)
			{
				throw new ArgumentNullException("newItems");
			}
			if (oldItems == null)
			{
				throw new ArgumentNullException("oldItems");
			}
			this.InitializeMoveOrReplace(action, newItems, oldItems, startingIndex, startingIndex);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0005A921 File Offset: 0x00058B21
		private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
			if (action == NotifyCollectionChangedAction.Add)
			{
				this.InitializeAdd(action, changedItems, startingIndex);
				return;
			}
			if (action == NotifyCollectionChangedAction.Remove)
			{
				this.InitializeRemove(action, changedItems, startingIndex);
			}
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0005A93D File Offset: 0x00058B3D
		private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex)
		{
			this._action = action;
			this._newItems = ((newItems == null) ? null : new ReadOnlyList(newItems));
			this._newStartingIndex = newStartingIndex;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0005A95F File Offset: 0x00058B5F
		private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex)
		{
			this._action = action;
			this._oldItems = ((oldItems == null) ? null : new ReadOnlyList(oldItems));
			this._oldStartingIndex = oldStartingIndex;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0005A981 File Offset: 0x00058B81
		private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex)
		{
			this.InitializeAdd(action, newItems, startingIndex);
			this.InitializeRemove(action, oldItems, oldStartingIndex);
		}

		// Token: 0x04000D3B RID: 3387
		private NotifyCollectionChangedAction _action;

		// Token: 0x04000D3C RID: 3388
		private IList _newItems;

		// Token: 0x04000D3D RID: 3389
		private IList _oldItems;

		// Token: 0x04000D3E RID: 3390
		private int _newStartingIndex = -1;

		// Token: 0x04000D3F RID: 3391
		private int _oldStartingIndex = -1;
	}
}
