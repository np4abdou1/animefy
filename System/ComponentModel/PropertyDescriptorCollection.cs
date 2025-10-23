using System;
using System.Collections;
using System.Collections.Generic;

namespace System.ComponentModel
{
	/// <summary>Represents a collection of <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects.</summary>
	// Token: 0x0200027B RID: 635
	public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> class.</summary>
		/// <param name="properties">An array of type <see cref="T:System.ComponentModel.PropertyDescriptor" /> that provides the properties for this collection. </param>
		// Token: 0x060010EF RID: 4335 RVA: 0x00050BBC File Offset: 0x0004EDBC
		public PropertyDescriptorCollection(PropertyDescriptor[] properties)
		{
			if (properties == null)
			{
				this._properties = Array.Empty<PropertyDescriptor>();
				this.Count = 0;
			}
			else
			{
				this._properties = properties;
				this.Count = properties.Length;
			}
			this._propsOwned = true;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> class, which is optionally read-only.</summary>
		/// <param name="properties">An array of type <see cref="T:System.ComponentModel.PropertyDescriptor" /> that provides the properties for this collection.</param>
		/// <param name="readOnly">If <see langword="true" />, specifies that the collection cannot be modified.</param>
		// Token: 0x060010F0 RID: 4336 RVA: 0x00050C08 File Offset: 0x0004EE08
		public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly) : this(properties)
		{
			this._readOnly = readOnly;
		}

		/// <summary>Gets the number of property descriptors in the collection.</summary>
		/// <returns>The number of property descriptors in the collection.</returns>
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00050C18 File Offset: 0x0004EE18
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x00050C20 File Offset: 0x0004EE20
		public int Count { get; private set; }

		/// <summary>Gets or sets the <see cref="T:System.ComponentModel.PropertyDescriptor" /> at the specified index number.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to get or set. </param>
		/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified index number.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">The <paramref name="index" /> parameter is not a valid index for <see cref="P:System.ComponentModel.PropertyDescriptorCollection.Item(System.Int32)" />. </exception>
		// Token: 0x1700036F RID: 879
		public virtual PropertyDescriptor this[int index]
		{
			get
			{
				if (index >= this.Count)
				{
					throw new IndexOutOfRangeException();
				}
				this.EnsurePropsOwned();
				return this._properties[index];
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified name.</summary>
		/// <param name="name">The name of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to get from the collection. </param>
		/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified name, or <see langword="null" /> if the property does not exist.</returns>
		// Token: 0x17000370 RID: 880
		public virtual PropertyDescriptor this[string name]
		{
			get
			{
				return this.Find(name, false);
			}
		}

		/// <summary>Adds the specified <see cref="T:System.ComponentModel.PropertyDescriptor" /> to the collection.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to add to the collection. </param>
		/// <returns>The index of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> that was added to the collection.</returns>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060010F5 RID: 4341 RVA: 0x00050C54 File Offset: 0x0004EE54
		public int Add(PropertyDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.EnsureSize(this.Count + 1);
			PropertyDescriptor[] properties = this._properties;
			int count = this.Count;
			this.Count = count + 1;
			properties[count] = value;
			return this.Count - 1;
		}

		/// <summary>Removes all <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060010F6 RID: 4342 RVA: 0x00050C9E File Offset: 0x0004EE9E
		public void Clear()
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.Count = 0;
			this._cachedFoundProperties = null;
		}

		/// <summary>Returns whether the collection contains the given <see cref="T:System.ComponentModel.PropertyDescriptor" />.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to find in the collection. </param>
		/// <returns>
		///     <see langword="true" /> if the collection contains the given <see cref="T:System.ComponentModel.PropertyDescriptor" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010F7 RID: 4343 RVA: 0x00050CBC File Offset: 0x0004EEBC
		public bool Contains(PropertyDescriptor value)
		{
			return this.IndexOf(value) >= 0;
		}

		/// <summary>Copies the entire collection to an array, starting at the specified index number.</summary>
		/// <param name="array">An array of <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects to copy elements of the collection to. </param>
		/// <param name="index">The index of the <paramref name="array" /> parameter at which copying begins. </param>
		// Token: 0x060010F8 RID: 4344 RVA: 0x00050CCB File Offset: 0x0004EECB
		public void CopyTo(Array array, int index)
		{
			this.EnsurePropsOwned();
			Array.Copy(this._properties, 0, array, index, this.Count);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00050CE8 File Offset: 0x0004EEE8
		private void EnsurePropsOwned()
		{
			if (!this._propsOwned)
			{
				this._propsOwned = true;
				if (this._properties != null)
				{
					PropertyDescriptor[] array = new PropertyDescriptor[this.Count];
					Array.Copy(this._properties, 0, array, 0, this.Count);
					this._properties = array;
				}
			}
			if (this._needSort)
			{
				this._needSort = false;
				this.InternalSort(this._namedSort);
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00050D50 File Offset: 0x0004EF50
		private void EnsureSize(int sizeNeeded)
		{
			if (sizeNeeded <= this._properties.Length)
			{
				return;
			}
			if (this._properties.Length == 0)
			{
				this.Count = 0;
				this._properties = new PropertyDescriptor[sizeNeeded];
				return;
			}
			this.EnsurePropsOwned();
			PropertyDescriptor[] array = new PropertyDescriptor[Math.Max(sizeNeeded, this._properties.Length * 2)];
			Array.Copy(this._properties, 0, array, 0, this.Count);
			this._properties = array;
		}

		/// <summary>Returns the <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified name, using a Boolean to indicate whether to ignore case.</summary>
		/// <param name="name">The name of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to return from the collection. </param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> if you want to ignore the case of the property name; otherwise, <see langword="false" />. </param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified name, or <see langword="null" /> if the property does not exist.</returns>
		// Token: 0x060010FB RID: 4347 RVA: 0x00050DC0 File Offset: 0x0004EFC0
		public virtual PropertyDescriptor Find(string name, bool ignoreCase)
		{
			object internalSyncObject = this._internalSyncObject;
			PropertyDescriptor result;
			lock (internalSyncObject)
			{
				PropertyDescriptor propertyDescriptor = null;
				if (this._cachedFoundProperties == null || this._cachedIgnoreCase != ignoreCase)
				{
					this._cachedIgnoreCase = ignoreCase;
					if (ignoreCase)
					{
						this._cachedFoundProperties = new Hashtable(StringComparer.OrdinalIgnoreCase);
					}
					else
					{
						this._cachedFoundProperties = new Hashtable();
					}
				}
				object obj = this._cachedFoundProperties[name];
				if (obj != null)
				{
					result = (PropertyDescriptor)obj;
				}
				else
				{
					for (int i = 0; i < this.Count; i++)
					{
						if (ignoreCase)
						{
							if (string.Equals(this._properties[i].Name, name, StringComparison.OrdinalIgnoreCase))
							{
								this._cachedFoundProperties[name] = this._properties[i];
								propertyDescriptor = this._properties[i];
								break;
							}
						}
						else if (this._properties[i].Name.Equals(name))
						{
							this._cachedFoundProperties[name] = this._properties[i];
							propertyDescriptor = this._properties[i];
							break;
						}
					}
					result = propertyDescriptor;
				}
			}
			return result;
		}

		/// <summary>Returns the index of the given <see cref="T:System.ComponentModel.PropertyDescriptor" />.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to return the index of. </param>
		/// <returns>The index of the given <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		// Token: 0x060010FC RID: 4348 RVA: 0x00050EE0 File Offset: 0x0004F0E0
		public int IndexOf(PropertyDescriptor value)
		{
			return Array.IndexOf<PropertyDescriptor>(this._properties, value, 0, this.Count);
		}

		/// <summary>Adds the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to the collection at the specified index number.</summary>
		/// <param name="index">The index at which to add the <paramref name="value" /> parameter to the collection. </param>
		/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to add to the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060010FD RID: 4349 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		public void Insert(int index, PropertyDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.EnsureSize(this.Count + 1);
			if (index < this.Count)
			{
				Array.Copy(this._properties, index, this._properties, index + 1, this.Count - index);
			}
			this._properties[index] = value;
			int count = this.Count;
			this.Count = count + 1;
		}

		/// <summary>Removes the specified <see cref="T:System.ComponentModel.PropertyDescriptor" /> from the collection.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to remove from the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060010FE RID: 4350 RVA: 0x00050F60 File Offset: 0x0004F160
		public void Remove(PropertyDescriptor value)
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

		/// <summary>Removes the <see cref="T:System.ComponentModel.PropertyDescriptor" /> at the specified index from the collection.</summary>
		/// <param name="index">The index of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to remove from the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060010FF RID: 4351 RVA: 0x00050F90 File Offset: 0x0004F190
		public void RemoveAt(int index)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			if (index < this.Count - 1)
			{
				Array.Copy(this._properties, index + 1, this._properties, index, this.Count - index - 1);
			}
			this._properties[this.Count - 1] = null;
			int count = this.Count;
			this.Count = count - 1;
		}

		/// <summary>Sorts the members of this collection. The specified order is applied first, followed by the default sort for this collection, which is usually alphabetical.</summary>
		/// <param name="names">An array of strings describing the order in which to sort the <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects in this collection. </param>
		// Token: 0x06001100 RID: 4352 RVA: 0x00050FF8 File Offset: 0x0004F1F8
		protected void InternalSort(string[] names)
		{
			if (this._properties.Length == 0)
			{
				return;
			}
			this.InternalSort(this._comparer);
			if (names != null && names.Length != 0)
			{
				List<PropertyDescriptor> list = new List<PropertyDescriptor>(this._properties);
				int num = 0;
				int num2 = this._properties.Length;
				for (int i = 0; i < names.Length; i++)
				{
					for (int j = 0; j < num2; j++)
					{
						PropertyDescriptor propertyDescriptor = list[j];
						if (propertyDescriptor != null && propertyDescriptor.Name.Equals(names[i]))
						{
							this._properties[num++] = propertyDescriptor;
							list[j] = null;
							break;
						}
					}
				}
				for (int k = 0; k < num2; k++)
				{
					if (list[k] != null)
					{
						this._properties[num++] = list[k];
					}
				}
			}
		}

		/// <summary>Sorts the members of this collection, using the specified <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="sorter">A comparer to use to sort the <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects in this collection. </param>
		// Token: 0x06001101 RID: 4353 RVA: 0x000510C3 File Offset: 0x0004F2C3
		protected void InternalSort(IComparer sorter)
		{
			if (sorter == null)
			{
				TypeDescriptor.SortDescriptorArray(this);
				return;
			}
			Array.Sort(this._properties, sorter);
		}

		/// <summary>Returns an enumerator for this class.</summary>
		/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06001102 RID: 4354 RVA: 0x000510DC File Offset: 0x0004F2DC
		public virtual IEnumerator GetEnumerator()
		{
			this.EnsurePropsOwned();
			if (this._properties.Length != this.Count)
			{
				PropertyDescriptor[] array = new PropertyDescriptor[this.Count];
				Array.Copy(this._properties, 0, array, 0, this.Count);
				return array.GetEnumerator();
			}
			return this._properties.GetEnumerator();
		}

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the collection is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x000023F6 File Offset: 0x000005F6
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x000022FE File Offset: 0x000004FE
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the number of elements contained in the collection.</summary>
		/// <returns>The number of elements contained in the collection.</returns>
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00051131 File Offset: 0x0004F331
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Removes all items from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001106 RID: 4358 RVA: 0x00051139 File Offset: 0x0004F339
		void IList.Clear()
		{
			this.Clear();
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.IDictionary" />. </summary>
		// Token: 0x06001107 RID: 4359 RVA: 0x00051139 File Offset: 0x0004F339
		void IDictionary.Clear()
		{
			this.Clear();
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />. </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x06001108 RID: 4360 RVA: 0x00051141 File Offset: 0x0004F341
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Removes the item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001109 RID: 4361 RVA: 0x00051149 File Offset: 0x0004F349
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		/// <summary>Adds an element with the provided key and value to the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">The <see cref="T:System.Object" /> to use as the key of the element to add.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to use as the value of the element to add.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is <see langword="null" />.</exception>
		// Token: 0x0600110A RID: 4362 RVA: 0x00051154 File Offset: 0x0004F354
		void IDictionary.Add(object key, object value)
		{
			PropertyDescriptor propertyDescriptor = value as PropertyDescriptor;
			if (propertyDescriptor == null)
			{
				throw new ArgumentException("value");
			}
			this.Add(propertyDescriptor);
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.IDictionary" /> contains an element with the specified key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.IDictionary" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> contains an element with the key; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600110B RID: 4363 RVA: 0x0005117E File Offset: 0x0004F37E
		bool IDictionary.Contains(object key)
		{
			return key is string && this[(string)key] != null;
		}

		/// <summary>Returns an enumerator for this class.</summary>
		/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x0600110C RID: 4364 RVA: 0x00051199 File Offset: 0x0004F399
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new PropertyDescriptorCollection.PropertyDescriptorEnumerator(this);
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> has a fixed size; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000511A1 File Offset: 0x0004F3A1
		bool IDictionary.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x000511A1 File Offset: 0x0004F3A1
		bool IDictionary.IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Gets or sets the element with the specified key. </summary>
		/// <param name="key">The key of the element to get or set. </param>
		/// <returns>The element with the specified key.</returns>
		// Token: 0x17000376 RID: 886
		object IDictionary.this[object key]
		{
			get
			{
				if (key is string)
				{
					return this[(string)key];
				}
				return null;
			}
			set
			{
				if (this._readOnly)
				{
					throw new NotSupportedException();
				}
				if (value != null && !(value is PropertyDescriptor))
				{
					throw new ArgumentException("value");
				}
				int num = -1;
				if (key is int)
				{
					num = (int)key;
					if (num < 0 || num >= this.Count)
					{
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					if (!(key is string))
					{
						throw new ArgumentException("key");
					}
					for (int i = 0; i < this.Count; i++)
					{
						if (this._properties[i].Name.Equals((string)key))
						{
							num = i;
							break;
						}
					}
				}
				if (num == -1)
				{
					this.Add((PropertyDescriptor)value);
					return;
				}
				this.EnsurePropsOwned();
				this._properties[num] = (PropertyDescriptor)value;
				if (this._cachedFoundProperties != null && key is string)
				{
					this._cachedFoundProperties[key] = value;
				}
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys of the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys of the <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000512A0 File Offset: 0x0004F4A0
		ICollection IDictionary.Keys
		{
			get
			{
				string[] array = new string[this.Count];
				for (int i = 0; i < this.Count; i++)
				{
					array[i] = this._properties[i].Name;
				}
				return array;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x000512DC File Offset: 0x0004F4DC
		ICollection IDictionary.Values
		{
			get
			{
				if (this._properties.Length != this.Count)
				{
					PropertyDescriptor[] array = new PropertyDescriptor[this.Count];
					Array.Copy(this._properties, 0, array, 0, this.Count);
					return array;
				}
				return (ICollection)this._properties.Clone();
			}
		}

		/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.IDictionary" />. </summary>
		/// <param name="key">The key of the element to remove.</param>
		// Token: 0x06001113 RID: 4371 RVA: 0x0005132C File Offset: 0x0004F52C
		void IDictionary.Remove(object key)
		{
			if (key is string)
			{
				PropertyDescriptor propertyDescriptor = this[(string)key];
				if (propertyDescriptor != null)
				{
					((IList)this).Remove(propertyDescriptor);
				}
			}
		}

		/// <summary>Adds an item to the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The item to add to the collection.</param>
		/// <returns>The position into which the new element was inserted.</returns>
		// Token: 0x06001114 RID: 4372 RVA: 0x00051358 File Offset: 0x0004F558
		int IList.Add(object value)
		{
			return this.Add((PropertyDescriptor)value);
		}

		/// <summary>Determines whether the collection contains a specific value.</summary>
		/// <param name="value">The item to locate in the collection.</param>
		/// <returns>
		///     <see langword="true" /> if the item is found in the collection; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001115 RID: 4373 RVA: 0x00051366 File Offset: 0x0004F566
		bool IList.Contains(object value)
		{
			return this.Contains((PropertyDescriptor)value);
		}

		/// <summary>Determines the index of a specified item in the collection.</summary>
		/// <param name="value">The item to locate in the collection.</param>
		/// <returns>The index of <paramref name="value" /> if found in the list, otherwise -1.</returns>
		// Token: 0x06001116 RID: 4374 RVA: 0x00051374 File Offset: 0x0004F574
		int IList.IndexOf(object value)
		{
			return this.IndexOf((PropertyDescriptor)value);
		}

		/// <summary>Inserts an item into the collection at a specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The item to insert into the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06001117 RID: 4375 RVA: 0x00051382 File Offset: 0x0004F582
		void IList.Insert(int index, object value)
		{
			this.Insert(index, (PropertyDescriptor)value);
		}

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x000511A1 File Offset: 0x0004F3A1
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
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x000511A1 File Offset: 0x0004F3A1
		bool IList.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Removes the first occurrence of a specified value from the collection.</summary>
		/// <param name="value">The item to remove from the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x0600111A RID: 4378 RVA: 0x00051391 File Offset: 0x0004F591
		void IList.Remove(object value)
		{
			this.Remove((PropertyDescriptor)value);
		}

		/// <summary>Gets or sets an item from the collection at a specified index.</summary>
		/// <param name="index">The zero-based index of the item to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.ComponentModel.PropertyDescriptor" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="index" /> is less than 0. -or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.ComponentModel.EventDescriptorCollection.Count" />.</exception>
		// Token: 0x1700037B RID: 891
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
				if (value != null && !(value is PropertyDescriptor))
				{
					throw new ArgumentException("value");
				}
				this.EnsurePropsOwned();
				this._properties[index] = (PropertyDescriptor)value;
			}
		}

		/// <summary>Specifies an empty collection that you can use instead of creating a new one with no items. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C7C RID: 3196
		public static readonly PropertyDescriptorCollection Empty = new PropertyDescriptorCollection(null, true);

		// Token: 0x04000C7D RID: 3197
		private IDictionary _cachedFoundProperties;

		// Token: 0x04000C7E RID: 3198
		private bool _cachedIgnoreCase;

		// Token: 0x04000C7F RID: 3199
		private PropertyDescriptor[] _properties;

		// Token: 0x04000C80 RID: 3200
		private readonly string[] _namedSort;

		// Token: 0x04000C81 RID: 3201
		private readonly IComparer _comparer;

		// Token: 0x04000C82 RID: 3202
		private bool _propsOwned;

		// Token: 0x04000C83 RID: 3203
		private bool _needSort;

		// Token: 0x04000C84 RID: 3204
		private bool _readOnly;

		// Token: 0x04000C85 RID: 3205
		private readonly object _internalSyncObject = new object();

		// Token: 0x0200027C RID: 636
		private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x0600111E RID: 4382 RVA: 0x0005140A File Offset: 0x0004F60A
			public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner)
			{
				this._owner = owner;
			}

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x0600111F RID: 4383 RVA: 0x00051420 File Offset: 0x0004F620
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x06001120 RID: 4384 RVA: 0x00051430 File Offset: 0x0004F630
			public DictionaryEntry Entry
			{
				get
				{
					PropertyDescriptor propertyDescriptor = this._owner[this._index];
					return new DictionaryEntry(propertyDescriptor.Name, propertyDescriptor);
				}
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06001121 RID: 4385 RVA: 0x0005145B File Offset: 0x0004F65B
			public object Key
			{
				get
				{
					return this._owner[this._index].Name;
				}
			}

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x06001122 RID: 4386 RVA: 0x0005145B File Offset: 0x0004F65B
			public object Value
			{
				get
				{
					return this._owner[this._index].Name;
				}
			}

			// Token: 0x06001123 RID: 4387 RVA: 0x00051473 File Offset: 0x0004F673
			public bool MoveNext()
			{
				if (this._index < this._owner.Count - 1)
				{
					this._index++;
					return true;
				}
				return false;
			}

			// Token: 0x06001124 RID: 4388 RVA: 0x0005149B File Offset: 0x0004F69B
			public void Reset()
			{
				this._index = -1;
			}

			// Token: 0x04000C87 RID: 3207
			private PropertyDescriptorCollection _owner;

			// Token: 0x04000C88 RID: 3208
			private int _index = -1;
		}
	}
}
