﻿using System;
using System.Runtime.Serialization;
using System.Text;

namespace System.Collections.Specialized
{
	/// <summary>Represents a collection of associated <see cref="T:System.String" /> keys and <see cref="T:System.String" /> values that can be accessed either with the key or with the index.</summary>
	// Token: 0x020002C5 RID: 709
	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> class that is empty, has the default initial capacity and uses the default case-insensitive hash code provider and the default case-insensitive comparer.</summary>
		// Token: 0x060012D9 RID: 4825 RVA: 0x00059E39 File Offset: 0x00058039
		public NameValueCollection()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> class that is empty, has the specified initial capacity, and uses the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="capacity">The initial number of entries that the <see cref="T:System.Collections.Specialized.NameValueCollection" /> object can contain.</param>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object to use to determine whether two keys are equal and to generate hash codes for the keys in the collection.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero.</exception>
		// Token: 0x060012DA RID: 4826 RVA: 0x00059E41 File Offset: 0x00058041
		public NameValueCollection(int capacity, IEqualityComparer equalityComparer) : base(capacity, equalityComparer)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> class that is serializable and uses the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the new <see cref="T:System.Collections.Specialized.NameValueCollection" /> instance.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the new <see cref="T:System.Collections.Specialized.NameValueCollection" /> instance.</param>
		// Token: 0x060012DB RID: 4827 RVA: 0x00059E4B File Offset: 0x0005804B
		protected NameValueCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Resets the cached arrays of the collection to <see langword="null" />.</summary>
		// Token: 0x060012DC RID: 4828 RVA: 0x00059E55 File Offset: 0x00058055
		protected void InvalidateCachedArrays()
		{
			this._all = null;
			this._allKeys = null;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00059E68 File Offset: 0x00058068
		private static string GetAsOneString(ArrayList list)
		{
			int num = (list != null) ? list.Count : 0;
			if (num == 1)
			{
				return (string)list[0];
			}
			if (num > 1)
			{
				StringBuilder stringBuilder = new StringBuilder((string)list[0]);
				for (int i = 1; i < num; i++)
				{
					stringBuilder.Append(',');
					stringBuilder.Append((string)list[i]);
				}
				return stringBuilder.ToString();
			}
			return null;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00059EDC File Offset: 0x000580DC
		private static string[] GetAsStringArray(ArrayList list)
		{
			int num = (list != null) ? list.Count : 0;
			if (num == 0)
			{
				return null;
			}
			string[] array = new string[num];
			list.CopyTo(0, array, 0, num);
			return array;
		}

		/// <summary>Adds an entry with the specified name and value to the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to add. The key can be <see langword="null" />.</param>
		/// <param name="value">The <see cref="T:System.String" /> value of the entry to add. The value can be <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only. </exception>
		// Token: 0x060012DF RID: 4831 RVA: 0x00059F10 File Offset: 0x00058110
		public virtual void Add(string name, string value)
		{
			if (base.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only.");
			}
			this.InvalidateCachedArrays();
			ArrayList arrayList = (ArrayList)base.BaseGet(name);
			if (arrayList == null)
			{
				arrayList = new ArrayList(1);
				if (value != null)
				{
					arrayList.Add(value);
				}
				base.BaseAdd(name, arrayList);
				return;
			}
			if (value != null)
			{
				arrayList.Add(value);
			}
		}

		/// <summary>Gets the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" /> combined into one comma-separated list.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry that contains the values to get. The key can be <see langword="null" />.</param>
		/// <returns>A <see cref="T:System.String" /> that contains a comma-separated list of the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
		// Token: 0x060012E0 RID: 4832 RVA: 0x00059F6C File Offset: 0x0005816C
		public virtual string Get(string name)
		{
			return NameValueCollection.GetAsOneString((ArrayList)base.BaseGet(name));
		}

		/// <summary>Gets the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry that contains the values to get. The key can be <see langword="null" />.</param>
		/// <returns>A <see cref="T:System.String" /> array that contains the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
		// Token: 0x060012E1 RID: 4833 RVA: 0x00059F7F File Offset: 0x0005817F
		public virtual string[] GetValues(string name)
		{
			return NameValueCollection.GetAsStringArray((ArrayList)base.BaseGet(name));
		}

		/// <summary>Sets the value of an entry in the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to add the new value to. The key can be <see langword="null" />.</param>
		/// <param name="value">The <see cref="T:System.Object" /> that represents the new value to add to the specified entry. The value can be <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060012E2 RID: 4834 RVA: 0x00059F94 File Offset: 0x00058194
		public virtual void Set(string name, string value)
		{
			if (base.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only.");
			}
			this.InvalidateCachedArrays();
			base.BaseSet(name, new ArrayList(1)
			{
				value
			});
		}

		/// <summary>Removes the entries with the specified key from the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to remove. The key can be <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060012E3 RID: 4835 RVA: 0x00059FD1 File Offset: 0x000581D1
		public virtual void Remove(string name)
		{
			this.InvalidateCachedArrays();
			base.BaseRemove(name);
		}

		/// <summary>Gets or sets the entry with the specified key in the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to locate. The key can be <see langword="null" />.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the comma-separated list of values associated with the specified key, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only and the operation attempts to modify the collection. </exception>
		// Token: 0x170003C4 RID: 964
		public string this[string name]
		{
			get
			{
				return this.Get(name);
			}
			set
			{
				this.Set(name, value);
			}
		}

		/// <summary>Gets the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> combined into one comma-separated list.</summary>
		/// <param name="index">The zero-based index of the entry that contains the values to get from the collection.</param>
		/// <returns>A <see cref="T:System.String" /> that contains a comma-separated list of the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
		// Token: 0x060012E6 RID: 4838 RVA: 0x00059FF3 File Offset: 0x000581F3
		public virtual string Get(int index)
		{
			return NameValueCollection.GetAsOneString((ArrayList)base.BaseGet(index));
		}

		/// <summary>Gets the key at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="index">The zero-based index of the key to get from the collection.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the key at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
		// Token: 0x060012E7 RID: 4839 RVA: 0x0005A006 File Offset: 0x00058206
		public virtual string GetKey(int index)
		{
			return base.BaseGetKey(index);
		}

		/// <summary>Gets the entry at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="index">The zero-based index of the entry to locate in the collection.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the comma-separated list of values at the specified index of the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
		// Token: 0x170003C5 RID: 965
		public string this[int index]
		{
			get
			{
				return this.Get(index);
			}
		}

		/// <summary>Gets all the keys in the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <returns>A <see cref="T:System.String" /> array that contains all the keys of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</returns>
		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x0005A018 File Offset: 0x00058218
		public virtual string[] AllKeys
		{
			get
			{
				if (this._allKeys == null)
				{
					this._allKeys = base.BaseGetAllKeys();
				}
				return this._allKeys;
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0005A034 File Offset: 0x00058234
		internal NameValueCollection(DBNull dummy) : base(dummy)
		{
		}

		// Token: 0x04000D27 RID: 3367
		private string[] _all;

		// Token: 0x04000D28 RID: 3368
		private string[] _allKeys;
	}
}
