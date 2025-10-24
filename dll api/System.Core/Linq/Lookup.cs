using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace System.Linq
{
	/// <summary>Represents a collection of keys each mapped to one or more values.</summary>
	/// <typeparam name="TKey">The type of the keys in the <see cref="T:System.Linq.Lookup`2" />.</typeparam>
	/// <typeparam name="TElement">The type of the elements of each <see cref="T:System.Collections.Generic.IEnumerable`1" /> value in the <see cref="T:System.Linq.Lookup`2" />.</typeparam>
	// Token: 0x02000035 RID: 53
	[DefaultMember("Item")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(SystemLinq_LookupDebugView<, >))]
	public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable, IIListProvider<IGrouping<TKey, TElement>>
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00007528 File Offset: 0x00005728
		internal static Lookup<TKey, TElement> Create(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			Lookup<TKey, TElement> lookup = new Lookup<TKey, TElement>(comparer);
			foreach (TElement telement in source)
			{
				lookup.GetGrouping(keySelector(telement), true).Add(telement);
			}
			return lookup;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007588 File Offset: 0x00005788
		private Lookup(IEqualityComparer<TKey> comparer)
		{
			this._comparer = (comparer ?? EqualityComparer<TKey>.Default);
			this._groupings = new Grouping<TKey, TElement>[7];
		}

		/// <summary>Gets the number of key/value collection pairs in the <see cref="T:System.Linq.Lookup`2" />.</summary>
		/// <returns>The number of key/value collection pairs in the <see cref="T:System.Linq.Lookup`2" />.</returns>
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000075AC File Offset: 0x000057AC
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		/// <summary>Returns a generic enumerator that iterates through the <see cref="T:System.Linq.Lookup`2" />.</summary>
		/// <returns>An enumerator for the <see cref="T:System.Linq.Lookup`2" />.</returns>
		// Token: 0x06000169 RID: 361 RVA: 0x000075B4 File Offset: 0x000057B4
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			Grouping<TKey, TElement> g = this._lastGrouping;
			if (g != null)
			{
				do
				{
					g = g._next;
					yield return g;
				}
				while (g != this._lastGrouping);
			}
			yield break;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000075C4 File Offset: 0x000057C4
		IGrouping<TKey, TElement>[] IIListProvider<IGrouping<!0, !1>>.ToArray()
		{
			IGrouping<TKey, TElement>[] array = new IGrouping<TKey, TElement>[this._count];
			int num = 0;
			Grouping<TKey, TElement> grouping = this._lastGrouping;
			if (grouping != null)
			{
				do
				{
					grouping = grouping._next;
					array[num] = grouping;
					num++;
				}
				while (grouping != this._lastGrouping);
			}
			return array;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007604 File Offset: 0x00005804
		List<IGrouping<TKey, TElement>> IIListProvider<IGrouping<!0, !1>>.ToList()
		{
			List<IGrouping<TKey, TElement>> list = new List<IGrouping<TKey, TElement>>(this._count);
			Grouping<TKey, TElement> grouping = this._lastGrouping;
			if (grouping != null)
			{
				do
				{
					grouping = grouping._next;
					list.Add(grouping);
				}
				while (grouping != this._lastGrouping);
			}
			return list;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000075AC File Offset: 0x000057AC
		int IIListProvider<IGrouping<!0, !1>>.GetCount(bool onlyIfCheap)
		{
			return this._count;
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Linq.Lookup`2" />. This class cannot be inherited.</summary>
		/// <returns>An enumerator for the <see cref="T:System.Linq.Lookup`2" />.</returns>
		// Token: 0x0600016D RID: 365 RVA: 0x0000763F File Offset: 0x0000583F
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007647 File Offset: 0x00005847
		private int InternalGetHashCode(TKey key)
		{
			if (key != null)
			{
				return this._comparer.GetHashCode(key) & int.MaxValue;
			}
			return 0;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00007668 File Offset: 0x00005868
		internal Grouping<TKey, TElement> GetGrouping(TKey key, bool create)
		{
			int num = this.InternalGetHashCode(key);
			for (Grouping<TKey, TElement> grouping = this._groupings[num % this._groupings.Length]; grouping != null; grouping = grouping._hashNext)
			{
				if (grouping._hashCode == num && this._comparer.Equals(grouping._key, key))
				{
					return grouping;
				}
			}
			if (create)
			{
				if (this._count == this._groupings.Length)
				{
					this.Resize();
				}
				int num2 = num % this._groupings.Length;
				Grouping<TKey, TElement> grouping2 = new Grouping<TKey, TElement>();
				grouping2._key = key;
				grouping2._hashCode = num;
				grouping2._elements = new TElement[1];
				grouping2._hashNext = this._groupings[num2];
				this._groupings[num2] = grouping2;
				if (this._lastGrouping == null)
				{
					grouping2._next = grouping2;
				}
				else
				{
					grouping2._next = this._lastGrouping._next;
					this._lastGrouping._next = grouping2;
				}
				this._lastGrouping = grouping2;
				this._count++;
				return grouping2;
			}
			return null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007760 File Offset: 0x00005960
		private void Resize()
		{
			int num = checked(this._count * 2 + 1);
			Grouping<TKey, TElement>[] array = new Grouping<TKey, TElement>[num];
			Grouping<TKey, TElement> grouping = this._lastGrouping;
			do
			{
				grouping = grouping._next;
				int num2 = grouping._hashCode % num;
				grouping._hashNext = array[num2];
				array[num2] = grouping;
			}
			while (grouping != this._lastGrouping);
			this._groupings = array;
		}

		// Token: 0x04000064 RID: 100
		private readonly IEqualityComparer<TKey> _comparer;

		// Token: 0x04000065 RID: 101
		private Grouping<TKey, TElement>[] _groupings;

		// Token: 0x04000066 RID: 102
		private Grouping<TKey, TElement> _lastGrouping;

		// Token: 0x04000067 RID: 103
		private int _count;
	}
}
