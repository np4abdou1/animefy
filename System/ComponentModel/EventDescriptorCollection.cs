using System;
using System.Collections;
using System.Collections.Generic;

namespace System.ComponentModel
{
	/// <summary>Represents a collection of <see cref="T:System.ComponentModel.EventDescriptor" /> objects.</summary>
	// Token: 0x02000262 RID: 610
	public class EventDescriptorCollection : ICollection, IEnumerable, IList
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptorCollection" /> class with the given array of <see cref="T:System.ComponentModel.EventDescriptor" /> objects.</summary>
		/// <param name="events">An array of type <see cref="T:System.ComponentModel.EventDescriptor" /> that provides the events for this collection. </param>
		// Token: 0x06001045 RID: 4165 RVA: 0x0004FB23 File Offset: 0x0004DD23
		public EventDescriptorCollection(EventDescriptor[] events)
		{
			if (events == null)
			{
				this._events = Array.Empty<EventDescriptor>();
			}
			else
			{
				this._events = events;
				this.Count = events.Length;
			}
			this._eventsOwned = true;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptorCollection" /> class with the given array of <see cref="T:System.ComponentModel.EventDescriptor" /> objects. The collection is optionally read-only.</summary>
		/// <param name="events">An array of type <see cref="T:System.ComponentModel.EventDescriptor" /> that provides the events for this collection. </param>
		/// <param name="readOnly">
		///       <see langword="true" /> to specify a read-only collection; otherwise, <see langword="false" />.</param>
		// Token: 0x06001046 RID: 4166 RVA: 0x0004FB52 File Offset: 0x0004DD52
		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly) : this(events)
		{
			this._readOnly = readOnly;
		}

		/// <summary>Gets the number of event descriptors in the collection.</summary>
		/// <returns>The number of event descriptors in the collection.</returns>
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0004FB62 File Offset: 0x0004DD62
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x0004FB6A File Offset: 0x0004DD6A
		public int Count { get; private set; }

		/// <summary>Gets or sets the event with the specified index number.</summary>
		/// <param name="index">The zero-based index number of the <see cref="T:System.ComponentModel.EventDescriptor" /> to get or set. </param>
		/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> with the specified index number.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="index" /> is not a valid index for <see cref="P:System.ComponentModel.EventDescriptorCollection.Item(System.Int32)" />. </exception>
		// Token: 0x17000343 RID: 835
		public virtual EventDescriptor this[int index]
		{
			get
			{
				if (index >= this.Count)
				{
					throw new IndexOutOfRangeException();
				}
				this.EnsureEventsOwned();
				return this._events[index];
			}
		}

		/// <summary>Gets or sets the event with the specified name.</summary>
		/// <param name="name">The name of the <see cref="T:System.ComponentModel.EventDescriptor" /> to get or set. </param>
		/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> with the specified name, or <see langword="null" /> if the event does not exist.</returns>
		// Token: 0x17000344 RID: 836
		public virtual EventDescriptor this[string name]
		{
			get
			{
				return this.Find(name, false);
			}
		}

		/// <summary>Adds an <see cref="T:System.ComponentModel.EventDescriptor" /> to the end of the collection.</summary>
		/// <param name="value">An <see cref="T:System.ComponentModel.EventDescriptor" /> to add to the collection. </param>
		/// <returns>The position of the <see cref="T:System.ComponentModel.EventDescriptor" /> within the collection.</returns>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x0600104B RID: 4171 RVA: 0x0004FB9C File Offset: 0x0004DD9C
		public int Add(EventDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.EnsureSize(this.Count + 1);
			EventDescriptor[] events = this._events;
			int count = this.Count;
			this.Count = count + 1;
			events[count] = value;
			return this.Count - 1;
		}

		/// <summary>Removes all objects from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x0600104C RID: 4172 RVA: 0x0004FBE6 File Offset: 0x0004DDE6
		public void Clear()
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.Count = 0;
		}

		/// <summary>Returns whether the collection contains the given <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to find within the collection. </param>
		/// <returns>
		///     <see langword="true" /> if the collection contains the <paramref name="value" /> parameter given; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600104D RID: 4173 RVA: 0x0004FBFD File Offset: 0x0004DDFD
		public bool Contains(EventDescriptor value)
		{
			return this.IndexOf(value) >= 0;
		}

		/// <summary>Copies the elements of the collection to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from collection. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		// Token: 0x0600104E RID: 4174 RVA: 0x0004FC0C File Offset: 0x0004DE0C
		void ICollection.CopyTo(Array array, int index)
		{
			this.EnsureEventsOwned();
			Array.Copy(this._events, 0, array, index, this.Count);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0004FC28 File Offset: 0x0004DE28
		private void EnsureEventsOwned()
		{
			if (!this._eventsOwned)
			{
				this._eventsOwned = true;
				if (this._events != null)
				{
					EventDescriptor[] array = new EventDescriptor[this.Count];
					Array.Copy(this._events, 0, array, 0, this.Count);
					this._events = array;
				}
			}
			if (this._needSort)
			{
				this._needSort = false;
				this.InternalSort(this._namedSort);
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0004FC90 File Offset: 0x0004DE90
		private void EnsureSize(int sizeNeeded)
		{
			if (sizeNeeded <= this._events.Length)
			{
				return;
			}
			if (this._events.Length == 0)
			{
				this.Count = 0;
				this._events = new EventDescriptor[sizeNeeded];
				return;
			}
			this.EnsureEventsOwned();
			EventDescriptor[] array = new EventDescriptor[Math.Max(sizeNeeded, this._events.Length * 2)];
			Array.Copy(this._events, 0, array, 0, this.Count);
			this._events = array;
		}

		/// <summary>Gets the description of the event with the specified name in the collection.</summary>
		/// <param name="name">The name of the event to get from the collection. </param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> if you want to ignore the case of the event; otherwise, <see langword="false" />. </param>
		/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> with the specified name, or <see langword="null" /> if the event does not exist.</returns>
		// Token: 0x06001051 RID: 4177 RVA: 0x0004FD00 File Offset: 0x0004DF00
		public virtual EventDescriptor Find(string name, bool ignoreCase)
		{
			EventDescriptor result = null;
			if (ignoreCase)
			{
				for (int i = 0; i < this.Count; i++)
				{
					if (string.Equals(this._events[i].Name, name, StringComparison.OrdinalIgnoreCase))
					{
						result = this._events[i];
						break;
					}
				}
			}
			else
			{
				for (int j = 0; j < this.Count; j++)
				{
					if (string.Equals(this._events[j].Name, name, StringComparison.Ordinal))
					{
						result = this._events[j];
						break;
					}
				}
			}
			return result;
		}

		/// <summary>Returns the index of the given <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to find within the collection. </param>
		/// <returns>The index of the given <see cref="T:System.ComponentModel.EventDescriptor" /> within the collection.</returns>
		// Token: 0x06001052 RID: 4178 RVA: 0x0004FD79 File Offset: 0x0004DF79
		public int IndexOf(EventDescriptor value)
		{
			return Array.IndexOf<EventDescriptor>(this._events, value, 0, this.Count);
		}

		/// <summary>Inserts an <see cref="T:System.ComponentModel.EventDescriptor" /> to the collection at a specified index.</summary>
		/// <param name="index">The index within the collection in which to insert the <paramref name="value" /> parameter. </param>
		/// <param name="value">An <see cref="T:System.ComponentModel.EventDescriptor" /> to insert into the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001053 RID: 4179 RVA: 0x0004FD90 File Offset: 0x0004DF90
		public void Insert(int index, EventDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.EnsureSize(this.Count + 1);
			if (index < this.Count)
			{
				Array.Copy(this._events, index, this._events, index + 1, this.Count - index);
			}
			this._events[index] = value;
			int count = this.Count;
			this.Count = count + 1;
		}

		/// <summary>Removes the specified <see cref="T:System.ComponentModel.EventDescriptor" /> from the collection.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to remove from the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001054 RID: 4180 RVA: 0x0004FDF8 File Offset: 0x0004DFF8
		public void Remove(EventDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			int num = this.IndexOf(value);
			if (num != -1)
			{
				this.RemoveAt(num);
			}
		}

		/// <summary>Removes the <see cref="T:System.ComponentModel.EventDescriptor" /> at the specified index from the collection.</summary>
		/// <param name="index">The index of the <see cref="T:System.ComponentModel.EventDescriptor" /> to remove. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001055 RID: 4181 RVA: 0x0004FE28 File Offset: 0x0004E028
		public void RemoveAt(int index)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			if (index < this.Count - 1)
			{
				Array.Copy(this._events, index + 1, this._events, index, this.Count - index - 1);
			}
			this._events[this.Count - 1] = null;
			int count = this.Count;
			this.Count = count - 1;
		}

		/// <summary>Gets an enumerator for this <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</summary>
		/// <returns>An enumerator that implements <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06001056 RID: 4182 RVA: 0x0004FE8D File Offset: 0x0004E08D
		public IEnumerator GetEnumerator()
		{
			if (this._events.Length == this.Count)
			{
				return this._events.GetEnumerator();
			}
			return new EventDescriptorCollection.ArraySubsetEnumerator(this._events, this.Count);
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />. The specified order is applied first, followed by the default sort for this collection, which is usually alphabetical.</summary>
		/// <param name="names">An array of strings describing the order in which to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in this collection. </param>
		// Token: 0x06001057 RID: 4183 RVA: 0x0004FEBC File Offset: 0x0004E0BC
		protected void InternalSort(string[] names)
		{
			if (this._events.Length == 0)
			{
				return;
			}
			this.InternalSort(this._comparer);
			if (names != null && names.Length != 0)
			{
				List<EventDescriptor> list = new List<EventDescriptor>(this._events);
				int num = 0;
				int num2 = this._events.Length;
				for (int i = 0; i < names.Length; i++)
				{
					for (int j = 0; j < num2; j++)
					{
						EventDescriptor eventDescriptor = list[j];
						if (eventDescriptor != null && eventDescriptor.Name.Equals(names[i]))
						{
							this._events[num++] = eventDescriptor;
							list[j] = null;
							break;
						}
					}
				}
				for (int k = 0; k < num2; k++)
				{
					if (list[k] != null)
					{
						this._events[num++] = list[k];
					}
				}
			}
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />, using the specified <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="sorter">A comparer to use to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in this collection. </param>
		// Token: 0x06001058 RID: 4184 RVA: 0x0004FF87 File Offset: 0x0004E187
		protected void InternalSort(IComparer sorter)
		{
			if (sorter == null)
			{
				TypeDescriptor.SortDescriptorArray(this);
				return;
			}
			Array.Sort(this._events, sorter);
		}

		/// <summary>Gets a value indicating whether access to the collection is synchronized.</summary>
		/// <returns>
		///     <see langword="true" /> if access to the collection is synchronized; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x000023F6 File Offset: 0x000005F6
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x000022FE File Offset: 0x000004FE
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the number of elements contained in the collection.</summary>
		/// <returns>The number of elements contained in the collection.</returns>
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x0004FF9F File Offset: 0x0004E19F
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x0600105C RID: 4188 RVA: 0x0004FFA7 File Offset: 0x0004E1A7
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="index" /> is less than 0. -or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.ComponentModel.EventDescriptorCollection.Count" />.</exception>
		// Token: 0x17000348 RID: 840
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				if (this._readOnly)
				{
					throw new NotSupportedException();
				}
				if (index >= this.Count)
				{
					throw new IndexOutOfRangeException();
				}
				this.EnsureEventsOwned();
				this._events[index] = (EventDescriptor)value;
			}
		}

		/// <summary>Adds an item to the collection.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to add to the collection.</param>
		/// <returns>The position into which the new element was inserted.</returns>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x0600105F RID: 4191 RVA: 0x0004FFEB File Offset: 0x0004E1EB
		int IList.Add(object value)
		{
			return this.Add((EventDescriptor)value);
		}

		/// <summary>Determines whether the collection contains a specific value.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the collection.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Object" /> is found in the collection; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001060 RID: 4192 RVA: 0x0004FFF9 File Offset: 0x0004E1F9
		bool IList.Contains(object value)
		{
			return this.Contains((EventDescriptor)value);
		}

		/// <summary>Removes all the items from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001061 RID: 4193 RVA: 0x00050007 File Offset: 0x0004E207
		void IList.Clear()
		{
			this.Clear();
		}

		/// <summary>Determines the index of a specific item in the collection.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the collection.</param>
		/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
		// Token: 0x06001062 RID: 4194 RVA: 0x0005000F File Offset: 0x0004E20F
		int IList.IndexOf(object value)
		{
			return this.IndexOf((EventDescriptor)value);
		}

		/// <summary>Inserts an item to the collection at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert into the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001063 RID: 4195 RVA: 0x0005001D File Offset: 0x0004E21D
		void IList.Insert(int index, object value)
		{
			this.Insert(index, (EventDescriptor)value);
		}

		/// <summary>Removes the first occurrence of a specific object from the collection.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001064 RID: 4196 RVA: 0x0005002C File Offset: 0x0004E22C
		void IList.Remove(object value)
		{
			this.Remove((EventDescriptor)value);
		}

		/// <summary>Removes the item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001065 RID: 4197 RVA: 0x0005003A File Offset: 0x0004E23A
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00050043 File Offset: 0x0004E243
		bool IList.IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the collection has a fixed size; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00050043 File Offset: 0x0004E243
		bool IList.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x04000C4C RID: 3148
		private EventDescriptor[] _events;

		// Token: 0x04000C4D RID: 3149
		private string[] _namedSort;

		// Token: 0x04000C4E RID: 3150
		private readonly IComparer _comparer;

		// Token: 0x04000C4F RID: 3151
		private bool _eventsOwned;

		// Token: 0x04000C50 RID: 3152
		private bool _needSort;

		// Token: 0x04000C51 RID: 3153
		private readonly bool _readOnly;

		/// <summary>Specifies an empty collection to use, rather than creating a new one with no items. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C52 RID: 3154
		public static readonly EventDescriptorCollection Empty = new EventDescriptorCollection(null, true);

		// Token: 0x02000263 RID: 611
		private class ArraySubsetEnumerator : IEnumerator
		{
			// Token: 0x06001069 RID: 4201 RVA: 0x00050059 File Offset: 0x0004E259
			public ArraySubsetEnumerator(Array array, int count)
			{
				this._array = array;
				this._total = count;
				this._current = -1;
			}

			// Token: 0x0600106A RID: 4202 RVA: 0x00050076 File Offset: 0x0004E276
			public bool MoveNext()
			{
				if (this._current < this._total - 1)
				{
					this._current++;
					return true;
				}
				return false;
			}

			// Token: 0x0600106B RID: 4203 RVA: 0x00050099 File Offset: 0x0004E299
			public void Reset()
			{
				this._current = -1;
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x0600106C RID: 4204 RVA: 0x000500A2 File Offset: 0x0004E2A2
			public object Current
			{
				get
				{
					if (this._current == -1)
					{
						throw new InvalidOperationException();
					}
					return this._array.GetValue(this._current);
				}
			}

			// Token: 0x04000C54 RID: 3156
			private readonly Array _array;

			// Token: 0x04000C55 RID: 3157
			private readonly int _total;

			// Token: 0x04000C56 RID: 3158
			private int _current;
		}
	}
}
