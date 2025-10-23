using System;

namespace System.ComponentModel
{
	/// <summary>Provides a simple list of delegates. This class cannot be inherited.</summary>
	// Token: 0x0200023D RID: 573
	public sealed class EventHandlerList : IDisposable
	{
		// Token: 0x06000FA1 RID: 4001 RVA: 0x0004D5C6 File Offset: 0x0004B7C6
		internal EventHandlerList(Component parent)
		{
			this._parent = parent;
		}

		/// <summary>Gets or sets the delegate for the specified object.</summary>
		/// <param name="key">An object to find in the list. </param>
		/// <returns>The delegate for the specified key, or <see langword="null" /> if a delegate does not exist.</returns>
		// Token: 0x1700031F RID: 799
		public Delegate this[object key]
		{
			get
			{
				EventHandlerList.ListEntry listEntry = null;
				if (this._parent == null || this._parent.CanRaiseEventsInternal)
				{
					listEntry = this.Find(key);
				}
				if (listEntry == null)
				{
					return null;
				}
				return listEntry._handler;
			}
		}

		/// <summary>Adds a delegate to the list.</summary>
		/// <param name="key">The object that owns the event. </param>
		/// <param name="value">The delegate to add to the list. </param>
		// Token: 0x06000FA3 RID: 4003 RVA: 0x0004D610 File Offset: 0x0004B810
		public void AddHandler(object key, Delegate value)
		{
			EventHandlerList.ListEntry listEntry = this.Find(key);
			if (listEntry != null)
			{
				listEntry._handler = Delegate.Combine(listEntry._handler, value);
				return;
			}
			this._head = new EventHandlerList.ListEntry(key, value, this._head);
		}

		/// <summary>Disposes the delegate list.</summary>
		// Token: 0x06000FA4 RID: 4004 RVA: 0x0004D64E File Offset: 0x0004B84E
		public void Dispose()
		{
			this._head = null;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0004D658 File Offset: 0x0004B858
		private EventHandlerList.ListEntry Find(object key)
		{
			EventHandlerList.ListEntry listEntry = this._head;
			while (listEntry != null && listEntry._key != key)
			{
				listEntry = listEntry._next;
			}
			return listEntry;
		}

		/// <summary>Removes a delegate from the list.</summary>
		/// <param name="key">The object that owns the event. </param>
		/// <param name="value">The delegate to remove from the list. </param>
		// Token: 0x06000FA6 RID: 4006 RVA: 0x0004D684 File Offset: 0x0004B884
		public void RemoveHandler(object key, Delegate value)
		{
			EventHandlerList.ListEntry listEntry = this.Find(key);
			if (listEntry != null)
			{
				listEntry._handler = Delegate.Remove(listEntry._handler, value);
			}
		}

		// Token: 0x04000C1A RID: 3098
		private EventHandlerList.ListEntry _head;

		// Token: 0x04000C1B RID: 3099
		private Component _parent;

		// Token: 0x0200023E RID: 574
		private sealed class ListEntry
		{
			// Token: 0x06000FA7 RID: 4007 RVA: 0x0004D6AE File Offset: 0x0004B8AE
			public ListEntry(object key, Delegate handler, EventHandlerList.ListEntry next)
			{
				this._next = next;
				this._key = key;
				this._handler = handler;
			}

			// Token: 0x04000C1C RID: 3100
			internal EventHandlerList.ListEntry _next;

			// Token: 0x04000C1D RID: 3101
			internal object _key;

			// Token: 0x04000C1E RID: 3102
			internal Delegate _handler;
		}
	}
}
