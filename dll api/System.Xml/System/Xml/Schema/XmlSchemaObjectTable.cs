using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	/// <summary>Provides the collections for contained elements in the <see cref="T:System.Xml.Schema.XmlSchema" /> class (for example, Attributes, AttributeGroups, Elements, and so on).</summary>
	// Token: 0x0200030B RID: 779
	public class XmlSchemaObjectTable
	{
		// Token: 0x060019E5 RID: 6629 RVA: 0x00098461 File Offset: 0x00096661
		internal XmlSchemaObjectTable()
		{
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0009847F File Offset: 0x0009667F
		internal void Add(XmlQualifiedName name, XmlSchemaObject value)
		{
			this.table.Add(name, value);
			this.entries.Add(new XmlSchemaObjectTable.XmlSchemaObjectEntry(name, value));
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000984A0 File Offset: 0x000966A0
		internal void Insert(XmlQualifiedName name, XmlSchemaObject value)
		{
			XmlSchemaObject xso = null;
			if (this.table.TryGetValue(name, out xso))
			{
				this.table[name] = value;
				int index = this.FindIndexByValue(xso);
				this.entries[index] = new XmlSchemaObjectTable.XmlSchemaObjectEntry(name, value);
				return;
			}
			this.Add(name, value);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000984F0 File Offset: 0x000966F0
		internal void Replace(XmlQualifiedName name, XmlSchemaObject value)
		{
			XmlSchemaObject xso;
			if (this.table.TryGetValue(name, out xso))
			{
				this.table[name] = value;
				int index = this.FindIndexByValue(xso);
				this.entries[index] = new XmlSchemaObjectTable.XmlSchemaObjectEntry(name, value);
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00098535 File Offset: 0x00096735
		internal void Clear()
		{
			this.table.Clear();
			this.entries.Clear();
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00098550 File Offset: 0x00096750
		internal void Remove(XmlQualifiedName name)
		{
			XmlSchemaObject xso;
			if (this.table.TryGetValue(name, out xso))
			{
				this.table.Remove(name);
				int index = this.FindIndexByValue(xso);
				this.entries.RemoveAt(index);
			}
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00098590 File Offset: 0x00096790
		private int FindIndexByValue(XmlSchemaObject xso)
		{
			for (int i = 0; i < this.entries.Count; i++)
			{
				if (this.entries[i].xso == xso)
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Gets the number of items contained in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</summary>
		/// <returns>The number of items contained in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</returns>
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x000985CA File Offset: 0x000967CA
		public int Count
		{
			get
			{
				return this.table.Count;
			}
		}

		/// <summary>Determines if the qualified name specified exists in the collection.</summary>
		/// <param name="name">The <see cref="T:System.Xml.XmlQualifiedName" />.</param>
		/// <returns>
		///     <see langword="true" /> if the qualified name specified exists in the collection; otherwise, <see langword="false" />.</returns>
		// Token: 0x060019ED RID: 6637 RVA: 0x000985D7 File Offset: 0x000967D7
		public bool Contains(XmlQualifiedName name)
		{
			return this.table.ContainsKey(name);
		}

		/// <summary>Returns the element in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> specified by qualified name.</summary>
		/// <param name="name">The <see cref="T:System.Xml.XmlQualifiedName" /> of the element to return.</param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> of the element in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> specified by qualified name.</returns>
		// Token: 0x17000622 RID: 1570
		public XmlSchemaObject this[XmlQualifiedName name]
		{
			get
			{
				XmlSchemaObject result;
				if (this.table.TryGetValue(name, out result))
				{
					return result;
				}
				return null;
			}
		}

		/// <summary>Returns a collection of all the values for all the elements in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</summary>
		/// <returns>A collection of all the values for all the elements in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</returns>
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x00098608 File Offset: 0x00096808
		public ICollection Values
		{
			get
			{
				return new XmlSchemaObjectTable.ValuesCollection(this.entries, this.table.Count);
			}
		}

		/// <summary>Returns an enumerator that can iterate through the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> that can iterate through <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</returns>
		// Token: 0x060019F0 RID: 6640 RVA: 0x00098620 File Offset: 0x00096820
		public IDictionaryEnumerator GetEnumerator()
		{
			return new XmlSchemaObjectTable.XSODictionaryEnumerator(this.entries, this.table.Count, XmlSchemaObjectTable.EnumeratorType.DictionaryEntry);
		}

		// Token: 0x040010EE RID: 4334
		private Dictionary<XmlQualifiedName, XmlSchemaObject> table = new Dictionary<XmlQualifiedName, XmlSchemaObject>();

		// Token: 0x040010EF RID: 4335
		private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries = new List<XmlSchemaObjectTable.XmlSchemaObjectEntry>();

		// Token: 0x0200030C RID: 780
		internal enum EnumeratorType
		{
			// Token: 0x040010F1 RID: 4337
			Keys,
			// Token: 0x040010F2 RID: 4338
			Values,
			// Token: 0x040010F3 RID: 4339
			DictionaryEntry
		}

		// Token: 0x0200030D RID: 781
		internal struct XmlSchemaObjectEntry
		{
			// Token: 0x060019F1 RID: 6641 RVA: 0x00098639 File Offset: 0x00096839
			public XmlSchemaObjectEntry(XmlQualifiedName name, XmlSchemaObject value)
			{
				this.qname = name;
				this.xso = value;
			}

			// Token: 0x040010F4 RID: 4340
			internal XmlQualifiedName qname;

			// Token: 0x040010F5 RID: 4341
			internal XmlSchemaObject xso;
		}

		// Token: 0x0200030E RID: 782
		internal class ValuesCollection : ICollection, IEnumerable
		{
			// Token: 0x060019F2 RID: 6642 RVA: 0x00098649 File Offset: 0x00096849
			internal ValuesCollection(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size)
			{
				this.entries = entries;
				this.size = size;
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0009865F File Offset: 0x0009685F
			public int Count
			{
				get
				{
					return this.size;
				}
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00098667 File Offset: 0x00096867
			public object SyncRoot
			{
				get
				{
					return ((ICollection)this.entries).SyncRoot;
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x060019F5 RID: 6645 RVA: 0x00098674 File Offset: 0x00096874
			public bool IsSynchronized
			{
				get
				{
					return ((ICollection)this.entries).IsSynchronized;
				}
			}

			// Token: 0x060019F6 RID: 6646 RVA: 0x00098684 File Offset: 0x00096884
			public void CopyTo(Array array, int arrayIndex)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException("arrayIndex");
				}
				for (int i = 0; i < this.size; i++)
				{
					array.SetValue(this.entries[i].xso, arrayIndex++);
				}
			}

			// Token: 0x060019F7 RID: 6647 RVA: 0x000986DC File Offset: 0x000968DC
			public IEnumerator GetEnumerator()
			{
				return new XmlSchemaObjectTable.XSOEnumerator(this.entries, this.size, XmlSchemaObjectTable.EnumeratorType.Values);
			}

			// Token: 0x040010F6 RID: 4342
			private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;

			// Token: 0x040010F7 RID: 4343
			private int size;
		}

		// Token: 0x0200030F RID: 783
		internal class XSOEnumerator : IEnumerator
		{
			// Token: 0x060019F8 RID: 6648 RVA: 0x000986F0 File Offset: 0x000968F0
			internal XSOEnumerator(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType)
			{
				this.entries = entries;
				this.size = size;
				this.enumType = enumType;
				this.currentIndex = -1;
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00098714 File Offset: 0x00096914
			public object Current
			{
				get
				{
					if (this.currentIndex == -1)
					{
						throw new InvalidOperationException(Res.GetString("Enumeration has not started. Call MoveNext.", new object[]
						{
							string.Empty
						}));
					}
					if (this.currentIndex >= this.size)
					{
						throw new InvalidOperationException(Res.GetString("Enumeration has already finished.", new object[]
						{
							string.Empty
						}));
					}
					switch (this.enumType)
					{
					case XmlSchemaObjectTable.EnumeratorType.Keys:
						return this.currentKey;
					case XmlSchemaObjectTable.EnumeratorType.Values:
						return this.currentValue;
					case XmlSchemaObjectTable.EnumeratorType.DictionaryEntry:
						return new DictionaryEntry(this.currentKey, this.currentValue);
					default:
						return null;
					}
				}
			}

			// Token: 0x060019FA RID: 6650 RVA: 0x000987B8 File Offset: 0x000969B8
			public bool MoveNext()
			{
				if (this.currentIndex >= this.size - 1)
				{
					this.currentValue = null;
					this.currentKey = null;
					return false;
				}
				this.currentIndex++;
				this.currentValue = this.entries[this.currentIndex].xso;
				this.currentKey = this.entries[this.currentIndex].qname;
				return true;
			}

			// Token: 0x060019FB RID: 6651 RVA: 0x0009882C File Offset: 0x00096A2C
			public void Reset()
			{
				this.currentIndex = -1;
				this.currentValue = null;
				this.currentKey = null;
			}

			// Token: 0x040010F8 RID: 4344
			private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;

			// Token: 0x040010F9 RID: 4345
			private XmlSchemaObjectTable.EnumeratorType enumType;

			// Token: 0x040010FA RID: 4346
			protected int currentIndex;

			// Token: 0x040010FB RID: 4347
			protected int size;

			// Token: 0x040010FC RID: 4348
			protected XmlQualifiedName currentKey;

			// Token: 0x040010FD RID: 4349
			protected XmlSchemaObject currentValue;
		}

		// Token: 0x02000310 RID: 784
		internal class XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x060019FC RID: 6652 RVA: 0x00098843 File Offset: 0x00096A43
			internal XSODictionaryEnumerator(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) : base(entries, size, enumType)
			{
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x060019FD RID: 6653 RVA: 0x00098850 File Offset: 0x00096A50
			public DictionaryEntry Entry
			{
				get
				{
					if (this.currentIndex == -1)
					{
						throw new InvalidOperationException(Res.GetString("Enumeration has not started. Call MoveNext.", new object[]
						{
							string.Empty
						}));
					}
					if (this.currentIndex >= this.size)
					{
						throw new InvalidOperationException(Res.GetString("Enumeration has already finished.", new object[]
						{
							string.Empty
						}));
					}
					return new DictionaryEntry(this.currentKey, this.currentValue);
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x060019FE RID: 6654 RVA: 0x000988C4 File Offset: 0x00096AC4
			public object Key
			{
				get
				{
					if (this.currentIndex == -1)
					{
						throw new InvalidOperationException(Res.GetString("Enumeration has not started. Call MoveNext.", new object[]
						{
							string.Empty
						}));
					}
					if (this.currentIndex >= this.size)
					{
						throw new InvalidOperationException(Res.GetString("Enumeration has already finished.", new object[]
						{
							string.Empty
						}));
					}
					return this.currentKey;
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x060019FF RID: 6655 RVA: 0x0009892C File Offset: 0x00096B2C
			public object Value
			{
				get
				{
					if (this.currentIndex == -1)
					{
						throw new InvalidOperationException(Res.GetString("Enumeration has not started. Call MoveNext.", new object[]
						{
							string.Empty
						}));
					}
					if (this.currentIndex >= this.size)
					{
						throw new InvalidOperationException(Res.GetString("Enumeration has already finished.", new object[]
						{
							string.Empty
						}));
					}
					return this.currentValue;
				}
			}
		}
	}
}
