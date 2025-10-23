using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	/// <summary>Provides a set of <see langword="static" /> (<see langword="Shared" /> in Visual Basic) methods for querying objects that implement <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
	// Token: 0x02000017 RID: 23
	public static class Enumerable
	{
		/// <summary>Determines whether a sequence contains any elements.</summary>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to check for emptiness.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="true" /> if the source sequence contains any elements; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x06000066 RID: 102 RVA: 0x00003F38 File Offset: 0x00002138
		public static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			bool result;
			using (IEnumerator<TSource> enumerator = source.GetEnumerator())
			{
				result = enumerator.MoveNext();
			}
			return result;
		}

		/// <summary>Determines whether any element of a sequence satisfies a condition.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to apply the predicate to.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="true" /> if any elements in the source sequence pass the test in the specified predicate; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
		// Token: 0x06000067 RID: 103 RVA: 0x00003F80 File Offset: 0x00002180
		public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			foreach (TSource arg in source)
			{
				if (predicate(arg))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Determines whether all elements of a sequence satisfy a condition.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to apply the predicate to.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="true" /> if every element of the source sequence passes the test in the specified predicate, or if the sequence is empty; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
		// Token: 0x06000068 RID: 104 RVA: 0x00003FF0 File Offset: 0x000021F0
		public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			foreach (TSource arg in source)
			{
				if (!predicate(arg))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Filters the elements of an <see cref="T:System.Collections.IEnumerable" /> based on a specified type.</summary>
		/// <param name="source">The <see cref="T:System.Collections.IEnumerable" /> whose elements to filter.</param>
		/// <typeparam name="TResult">The type to filter the elements of the sequence on.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence of type <paramref name="TResult" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x06000069 RID: 105 RVA: 0x00004060 File Offset: 0x00002260
		public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return Enumerable.OfTypeIterator<TResult>(source);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004076 File Offset: 0x00002276
		private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
		{
			foreach (object obj in source)
			{
				if (obj is TResult)
				{
					yield return (TResult)((object)obj);
				}
			}
			IEnumerator enumerator = null;
			yield break;
			yield break;
		}

		/// <summary>Casts the elements of an <see cref="T:System.Collections.IEnumerable" /> to the specified type.</summary>
		/// <param name="source">The <see cref="T:System.Collections.IEnumerable" /> that contains the elements to be cast to type <paramref name="TResult" />.</param>
		/// <typeparam name="TResult">The type to cast the elements of <paramref name="source" /> to.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains each element of the source sequence cast to the specified type.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">An element in the sequence cannot be cast to type <paramref name="TResult" />.</exception>
		// Token: 0x0600006B RID: 107 RVA: 0x00004088 File Offset: 0x00002288
		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			IEnumerable<TResult> enumerable = source as IEnumerable<TResult>;
			if (enumerable != null)
			{
				return enumerable;
			}
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return Enumerable.CastIterator<TResult>(source);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000040B5 File Offset: 0x000022B5
		private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			foreach (object obj in source)
			{
				yield return (TResult)((object)obj);
			}
			IEnumerator enumerator = null;
			yield break;
			yield break;
		}

		/// <summary>Concatenates two sequences.</summary>
		/// <param name="first">The first sequence to concatenate.</param>
		/// <param name="second">The sequence to concatenate to the first sequence.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the concatenated elements of the two input sequences.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="first" /> or <paramref name="second" /> is <see langword="null" />.</exception>
		// Token: 0x0600006D RID: 109 RVA: 0x000040C8 File Offset: 0x000022C8
		public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			if (first == null)
			{
				throw Error.ArgumentNull("first");
			}
			if (second == null)
			{
				throw Error.ArgumentNull("second");
			}
			Enumerable.ConcatIterator<TSource> concatIterator = first as Enumerable.ConcatIterator<TSource>;
			if (concatIterator == null)
			{
				return new Enumerable.Concat2Iterator<TSource>(first, second);
			}
			return concatIterator.Concat(second);
		}

		/// <summary>Determines whether a sequence contains a specified element by using the default equality comparer.</summary>
		/// <param name="source">A sequence in which to locate a value.</param>
		/// <param name="value">The value to locate in the sequence.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="true" /> if the source sequence contains an element that has the specified value; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x0600006E RID: 110 RVA: 0x0000410C File Offset: 0x0000230C
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			ICollection<TSource> collection = source as ICollection<TSource>;
			if (collection == null)
			{
				return source.Contains(value, null);
			}
			return collection.Contains(value);
		}

		/// <summary>Determines whether a sequence contains a specified element by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="source">A sequence in which to locate a value.</param>
		/// <param name="value">The value to locate in the sequence.</param>
		/// <param name="comparer">An equality comparer to compare values.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="true" /> if the source sequence contains an element that has the specified value; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x0600006F RID: 111 RVA: 0x00004134 File Offset: 0x00002334
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (comparer == null)
			{
				using (IEnumerator<TSource> enumerator = source.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						TSource x = enumerator.Current;
						if (EqualityComparer<TSource>.Default.Equals(x, value))
						{
							return true;
						}
					}
					return false;
				}
			}
			foreach (TSource x2 in source)
			{
				if (comparer.Equals(x2, value))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Returns the number of elements in a sequence.</summary>
		/// <param name="source">A sequence that contains elements to be counted.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>The number of elements in the input sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">The number of elements in <paramref name="source" /> is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06000070 RID: 112 RVA: 0x000041DC File Offset: 0x000023DC
		public static int Count<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			ICollection<TSource> collection = source as ICollection<TSource>;
			if (collection != null)
			{
				return collection.Count;
			}
			IIListProvider<TSource> iilistProvider = source as IIListProvider<TSource>;
			if (iilistProvider != null)
			{
				return iilistProvider.GetCount(false);
			}
			ICollection collection2 = source as ICollection;
			if (collection2 != null)
			{
				return collection2.Count;
			}
			int num = 0;
			checked
			{
				using (IEnumerator<TSource> enumerator = source.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						num++;
					}
				}
				return num;
			}
		}

		/// <summary>Returns distinct elements from a sequence by using the default equality comparer to compare values.</summary>
		/// <param name="source">The sequence to remove duplicate elements from.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains distinct elements from the source sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x06000071 RID: 113 RVA: 0x00004264 File Offset: 0x00002464
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			return source.Distinct(null);
		}

		/// <summary>Returns distinct elements from a sequence by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</summary>
		/// <param name="source">The sequence to remove duplicate elements from.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains distinct elements from the source sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x06000072 RID: 114 RVA: 0x0000426D File Offset: 0x0000246D
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return new Enumerable.DistinctIterator<TSource>(source, comparer);
		}

		/// <summary>Returns an empty <see cref="T:System.Collections.Generic.IEnumerable`1" /> that has the specified type argument.</summary>
		/// <typeparam name="TResult">The type to assign to the type parameter of the returned generic <see cref="T:System.Collections.Generic.IEnumerable`1" />.</typeparam>
		/// <returns>An empty <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose type argument is <paramref name="TResult" />.</returns>
		// Token: 0x06000073 RID: 115 RVA: 0x00004284 File Offset: 0x00002484
		public static IEnumerable<TResult> Empty<TResult>()
		{
			return Array.Empty<TResult>();
		}

		/// <summary>Returns the first element of a sequence.</summary>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the first element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>The first element in the specified sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception>
		// Token: 0x06000074 RID: 116 RVA: 0x0000428C File Offset: 0x0000248C
		public static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			bool flag;
			TSource result = source.TryGetFirst(out flag);
			if (!flag)
			{
				throw Error.NoElements();
			}
			return result;
		}

		/// <summary>Returns the first element in a sequence that satisfies a specified condition.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>The first element in the sequence that passes the test in the specified predicate function.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">No element satisfies the condition in <paramref name="predicate" />.-or-The source sequence is empty.</exception>
		// Token: 0x06000075 RID: 117 RVA: 0x000042AC File Offset: 0x000024AC
		public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			bool flag;
			TSource result = source.TryGetFirst(predicate, out flag);
			if (!flag)
			{
				throw Error.NoMatch();
			}
			return result;
		}

		/// <summary>Returns the first element of a sequence, or a default value if the sequence contains no elements.</summary>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the first element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="default" />(<paramref name="TSource" />) if <paramref name="source" /> is empty; otherwise, the first element in <paramref name="source" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x06000076 RID: 118 RVA: 0x000042CC File Offset: 0x000024CC
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			bool flag;
			return source.TryGetFirst(out flag);
		}

		/// <summary>Returns the first element of the sequence that satisfies a condition or a default value if no such element is found.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="default" />(<paramref name="TSource" />) if <paramref name="source" /> is empty or if no element passes the test specified by <paramref name="predicate" />; otherwise, the first element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
		// Token: 0x06000077 RID: 119 RVA: 0x000042E4 File Offset: 0x000024E4
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			bool flag;
			return source.TryGetFirst(predicate, out flag);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000042FC File Offset: 0x000024FC
		private static TSource TryGetFirst<TSource>(this IEnumerable<TSource> source, out bool found)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			IPartition<TSource> partition = source as IPartition<TSource>;
			if (partition != null)
			{
				return partition.TryGetFirst(out found);
			}
			IList<TSource> list = source as IList<TSource>;
			if (list != null)
			{
				if (list.Count > 0)
				{
					found = true;
					return list[0];
				}
			}
			else
			{
				using (IEnumerator<TSource> enumerator = source.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						found = true;
						return enumerator.Current;
					}
				}
			}
			found = false;
			return default(TSource);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004390 File Offset: 0x00002590
		private static TSource TryGetFirst<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, out bool found)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			OrderedEnumerable<TSource> orderedEnumerable = source as OrderedEnumerable<TSource>;
			if (orderedEnumerable != null)
			{
				return orderedEnumerable.TryGetFirst(predicate, out found);
			}
			foreach (TSource tsource in source)
			{
				if (predicate(tsource))
				{
					found = true;
					return tsource;
				}
			}
			found = false;
			return default(TSource);
		}

		/// <summary>Groups the elements of a sequence according to a specified key selector function.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to group.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <returns>An IEnumerable&lt;IGrouping&lt;TKey, TSource&gt;&gt; in C# or IEnumerable(Of IGrouping(Of TKey, TSource)) in Visual Basic where each <see cref="T:System.Linq.IGrouping`2" /> object contains a sequence of objects and a key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="keySelector" /> is <see langword="null" />.</exception>
		// Token: 0x0600007A RID: 122 RVA: 0x00004420 File Offset: 0x00002620
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return new GroupedEnumerable<TSource, TKey>(source, keySelector, null);
		}

		/// <summary>Returns the last element of a sequence.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the last element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>The value at the last position in the source sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception>
		// Token: 0x0600007B RID: 123 RVA: 0x0000442C File Offset: 0x0000262C
		public static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			bool flag;
			TSource result = source.TryGetLast(out flag);
			if (!flag)
			{
				throw Error.NoElements();
			}
			return result;
		}

		/// <summary>Returns the last element of a sequence, or a default value if the sequence contains no elements.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the last element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="default" />(<paramref name="TSource" />) if the source sequence is empty; otherwise, the last element in the <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x0600007C RID: 124 RVA: 0x0000444C File Offset: 0x0000264C
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			bool flag;
			return source.TryGetLast(out flag);
		}

		/// <summary>Returns the last element of a sequence that satisfies a condition or a default value if no such element is found.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>
		///     <see langword="default" />(<paramref name="TSource" />) if the sequence is empty or if no elements pass the test in the predicate function; otherwise, the last element that passes the test in the predicate function.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
		// Token: 0x0600007D RID: 125 RVA: 0x00004464 File Offset: 0x00002664
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			bool flag;
			return source.TryGetLast(predicate, out flag);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000447C File Offset: 0x0000267C
		private static TSource TryGetLast<TSource>(this IEnumerable<TSource> source, out bool found)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			IPartition<TSource> partition = source as IPartition<TSource>;
			if (partition != null)
			{
				return partition.TryGetLast(out found);
			}
			IList<TSource> list = source as IList<TSource>;
			if (list != null)
			{
				int count = list.Count;
				if (count > 0)
				{
					found = true;
					return list[count - 1];
				}
			}
			else
			{
				using (IEnumerator<TSource> enumerator = source.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						TSource result;
						do
						{
							result = enumerator.Current;
						}
						while (enumerator.MoveNext());
						found = true;
						return result;
					}
				}
			}
			found = false;
			return default(TSource);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004520 File Offset: 0x00002720
		private static TSource TryGetLast<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, out bool found)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			OrderedEnumerable<TSource> orderedEnumerable = source as OrderedEnumerable<TSource>;
			if (orderedEnumerable != null)
			{
				return orderedEnumerable.TryGetLast(predicate, out found);
			}
			IList<TSource> list = source as IList<TSource>;
			if (list != null)
			{
				for (int i = list.Count - 1; i >= 0; i--)
				{
					TSource tsource = list[i];
					if (predicate(tsource))
					{
						found = true;
						return tsource;
					}
				}
			}
			else
			{
				foreach (TSource tsource2 in source)
				{
					if (predicate(tsource2))
					{
						IEnumerator<TSource> enumerator;
						while (enumerator.MoveNext())
						{
							TSource tsource3 = enumerator.Current;
							if (predicate(tsource3))
							{
								tsource2 = tsource3;
							}
						}
						found = true;
						return tsource2;
					}
				}
			}
			found = false;
			return default(TSource);
		}

		/// <summary>Sorts the elements of a sequence in ascending order according to a key.</summary>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted according to a key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="keySelector" /> is <see langword="null" />.</exception>
		// Token: 0x06000080 RID: 128 RVA: 0x00004610 File Offset: 0x00002810
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return new OrderedEnumerable<TSource, TKey>(source, keySelector, null, false, null);
		}

		/// <summary>Sorts the elements of a sequence in ascending order by using a specified comparer.</summary>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IComparer`1" /> to compare keys.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted according to a key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="keySelector" /> is <see langword="null" />.</exception>
		// Token: 0x06000081 RID: 129 RVA: 0x0000461C File Offset: 0x0000281C
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, false, null);
		}

		/// <summary>Sorts the elements of a sequence in descending order according to a key.</summary>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted in descending order according to a key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="keySelector" /> is <see langword="null" />.</exception>
		// Token: 0x06000082 RID: 130 RVA: 0x00004628 File Offset: 0x00002828
		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return new OrderedEnumerable<TSource, TKey>(source, keySelector, null, true, null);
		}

		/// <summary>Performs a subsequent ordering of the elements in a sequence in descending order, according to a key.</summary>
		/// <param name="source">An <see cref="T:System.Linq.IOrderedEnumerable`1" /> that contains elements to sort.</param>
		/// <param name="keySelector">A function to extract a key from each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted in descending order according to a key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="keySelector" /> is <see langword="null" />.</exception>
		// Token: 0x06000083 RID: 131 RVA: 0x00004634 File Offset: 0x00002834
		public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.CreateOrderedEnumerable<TKey>(keySelector, null, true);
		}

		/// <summary>Projects each element of a sequence into a new form.</summary>
		/// <param name="source">A sequence of values to invoke a transform function on.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the value returned by <paramref name="selector" />.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform function on each element of <paramref name="source" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
		// Token: 0x06000084 RID: 132 RVA: 0x00004650 File Offset: 0x00002850
		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			Enumerable.Iterator<TSource> iterator = source as Enumerable.Iterator<TSource>;
			if (iterator != null)
			{
				return iterator.Select<TResult>(selector);
			}
			IList<TSource> list = source as IList<TSource>;
			if (list != null)
			{
				TSource[] array = source as TSource[];
				if (array != null)
				{
					if (array.Length != 0)
					{
						return new Enumerable.SelectArrayIterator<TSource, TResult>(array, selector);
					}
					return EmptyPartition<TResult>.Instance;
				}
				else
				{
					List<TSource> list2 = source as List<TSource>;
					if (list2 != null)
					{
						return new Enumerable.SelectListIterator<TSource, TResult>(list2, selector);
					}
					return new Enumerable.SelectIListIterator<TSource, TResult>(list, selector);
				}
			}
			else
			{
				IPartition<TSource> partition = source as IPartition<TSource>;
				if (partition == null)
				{
					return new Enumerable.SelectEnumerableIterator<TSource, TResult>(source, selector);
				}
				if (!(partition is EmptyPartition<TSource>))
				{
					return new Enumerable.SelectIPartitionIterator<TSource, TResult>(partition, selector);
				}
				return EmptyPartition<TResult>.Instance;
			}
		}

		/// <summary>Projects each element of a sequence to an <see cref="T:System.Collections.Generic.IEnumerable`1" /> and flattens the resulting sequences into one sequence.</summary>
		/// <param name="source">A sequence of values to project.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the elements of the sequence returned by <paramref name="selector" />.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
		// Token: 0x06000085 RID: 133 RVA: 0x000046FD File Offset: 0x000028FD
		public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return new Enumerable.SelectManySingleSelectorIterator<TSource, TResult>(source, selector);
		}

		/// <summary>Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the single element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>The single element of the input sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The input sequence contains more than one element.-or-The input sequence is empty.</exception>
		// Token: 0x06000086 RID: 134 RVA: 0x00004724 File Offset: 0x00002924
		public static TSource Single<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			IList<TSource> list = source as IList<TSource>;
			if (list != null)
			{
				int count = list.Count;
				if (count == 0)
				{
					throw Error.NoElements();
				}
				if (count == 1)
				{
					return list[0];
				}
			}
			else
			{
				using (IEnumerator<TSource> enumerator = source.GetEnumerator())
				{
					if (!enumerator.MoveNext())
					{
						throw Error.NoElements();
					}
					TSource result = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						return result;
					}
				}
			}
			throw Error.MoreThanOneElement();
		}

		/// <summary>Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return a single element from.</param>
		/// <param name="predicate">A function to test an element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>The single element of the input sequence that satisfies a condition.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">No element satisfies the condition in <paramref name="predicate" />.-or-More than one element satisfies the condition in <paramref name="predicate" />.-or-The source sequence is empty.</exception>
		// Token: 0x06000087 RID: 135 RVA: 0x000047B4 File Offset: 0x000029B4
		public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			foreach (TSource tsource in source)
			{
				if (predicate(tsource))
				{
					IEnumerator<TSource> enumerator;
					while (enumerator.MoveNext())
					{
						if (predicate(enumerator.Current))
						{
							throw Error.MoreThanOneMatch();
						}
					}
					return tsource;
				}
			}
			throw Error.NoMatch();
		}

		/// <summary>Returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the single element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>The single element of the input sequence, or <see langword="default" />(<paramref name="TSource" />) if the sequence contains no elements.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The input sequence contains more than one element.</exception>
		// Token: 0x06000088 RID: 136 RVA: 0x00004844 File Offset: 0x00002A44
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			IList<TSource> list = source as IList<TSource>;
			if (list != null)
			{
				int count = list.Count;
				if (count == 0)
				{
					TSource result = default(TSource);
					return result;
				}
				if (count == 1)
				{
					return list[0];
				}
			}
			else
			{
				using (IEnumerator<TSource> enumerator = source.GetEnumerator())
				{
					if (!enumerator.MoveNext())
					{
						TSource result = default(TSource);
						return result;
					}
					TSource result2 = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						return result2;
					}
				}
			}
			throw Error.MoreThanOneElement();
		}

		/// <summary>Returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return a single element from.</param>
		/// <param name="predicate">A function to test an element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>The single element of the input sequence that satisfies the condition, or <see langword="default" />(<paramref name="TSource" />) if no such element is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
		// Token: 0x06000089 RID: 137 RVA: 0x000048E0 File Offset: 0x00002AE0
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			foreach (TSource tsource in source)
			{
				if (predicate(tsource))
				{
					IEnumerator<TSource> enumerator;
					while (enumerator.MoveNext())
					{
						if (predicate(enumerator.Current))
						{
							throw Error.MoreThanOneMatch();
						}
					}
					return tsource;
				}
			}
			return default(TSource);
		}

		/// <summary>Creates an array from a <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create an array from.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>An array that contains the elements from the input sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x0600008A RID: 138 RVA: 0x00004974 File Offset: 0x00002B74
		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			IIListProvider<TSource> iilistProvider = source as IIListProvider<TSource>;
			if (iilistProvider == null)
			{
				return EnumerableHelpers.ToArray<TSource>(source);
			}
			return iilistProvider.ToArray();
		}

		/// <summary>Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>A <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> is <see langword="null" />.</exception>
		// Token: 0x0600008B RID: 139 RVA: 0x000049A8 File Offset: 0x00002BA8
		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			IIListProvider<TSource> iilistProvider = source as IIListProvider<TSource>;
			if (iilistProvider == null)
			{
				return new List<TSource>(source);
			}
			return iilistProvider.ToList();
		}

		/// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> according to specified key selector and element selector functions.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
		/// <param name="keySelector">A function to extract a key from each element.</param>
		/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <typeparam name="TElement">The type of the value returned by <paramref name="elementSelector" />.</typeparam>
		/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains values of type <paramref name="TElement" /> selected from the input sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="keySelector" /> or <paramref name="elementSelector" /> is <see langword="null" />.-or-
		///         <paramref name="keySelector" /> produces a key that is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
		// Token: 0x0600008C RID: 140 RVA: 0x000049DA File Offset: 0x00002BDA
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return source.ToDictionary(keySelector, elementSelector, null);
		}

		/// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> according to a specified key selector function, a comparer, and an element selector function.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
		/// <param name="keySelector">A function to extract a key from each element.</param>
		/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare keys.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		/// <typeparam name="TElement">The type of the value returned by <paramref name="elementSelector" />.</typeparam>
		/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains values of type <paramref name="TElement" /> selected from the input sequence.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="keySelector" /> or <paramref name="elementSelector" /> is <see langword="null" />.-or-
		///         <paramref name="keySelector" /> produces a key that is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
		// Token: 0x0600008D RID: 141 RVA: 0x000049E8 File Offset: 0x00002BE8
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			if (elementSelector == null)
			{
				throw Error.ArgumentNull("elementSelector");
			}
			int num = 0;
			ICollection<TSource> collection = source as ICollection<TSource>;
			if (collection != null)
			{
				num = collection.Count;
				if (num == 0)
				{
					return new Dictionary<TKey, TElement>(comparer);
				}
				TSource[] array = collection as TSource[];
				if (array != null)
				{
					return Enumerable.ToDictionary<TSource, TKey, TElement>(array, keySelector, elementSelector, comparer);
				}
				List<TSource> list = collection as List<TSource>;
				if (list != null)
				{
					return Enumerable.ToDictionary<TSource, TKey, TElement>(list, keySelector, elementSelector, comparer);
				}
			}
			Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(num, comparer);
			foreach (TSource arg in source)
			{
				dictionary.Add(keySelector(arg), elementSelector(arg));
			}
			return dictionary;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004AC0 File Offset: 0x00002CC0
		private static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(TSource[] source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(source.Length, comparer);
			for (int i = 0; i < source.Length; i++)
			{
				dictionary.Add(keySelector(source[i]), elementSelector(source[i]));
			}
			return dictionary;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004B08 File Offset: 0x00002D08
		private static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(List<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(source.Count, comparer);
			foreach (TSource arg in source)
			{
				dictionary.Add(keySelector(arg), elementSelector(arg));
			}
			return dictionary;
		}

		/// <summary>Produces the set union of two sequences by using the default equality comparer.</summary>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements form the first set for the union.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements form the second set for the union.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements from both input sequences, excluding duplicates.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="first" /> or <paramref name="second" /> is <see langword="null" />.</exception>
		// Token: 0x06000090 RID: 144 RVA: 0x00004B74 File Offset: 0x00002D74
		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return first.Union(second, null);
		}

		/// <summary>Produces the set union of two sequences by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements form the first set for the union.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements form the second set for the union.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements from both input sequences, excluding duplicates.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="first" /> or <paramref name="second" /> is <see langword="null" />.</exception>
		// Token: 0x06000091 RID: 145 RVA: 0x00004B80 File Offset: 0x00002D80
		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			if (first == null)
			{
				throw Error.ArgumentNull("first");
			}
			if (second == null)
			{
				throw Error.ArgumentNull("second");
			}
			Enumerable.UnionIterator<TSource> unionIterator = first as Enumerable.UnionIterator<TSource>;
			if (unionIterator == null || !Utilities.AreEqualityComparersEqual<TSource>(comparer, unionIterator._comparer))
			{
				return new Enumerable.UnionIterator2<TSource>(first, second, comparer);
			}
			return unionIterator.Union(second);
		}

		/// <summary>Filters a sequence of values based on a predicate.</summary>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to filter.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence that satisfy the condition.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
		// Token: 0x06000092 RID: 146 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			Enumerable.Iterator<TSource> iterator = source as Enumerable.Iterator<TSource>;
			if (iterator != null)
			{
				return iterator.Where(predicate);
			}
			TSource[] array = source as TSource[];
			if (array != null)
			{
				if (array.Length != 0)
				{
					return new Enumerable.WhereArrayIterator<TSource>(array, predicate);
				}
				return EmptyPartition<TSource>.Instance;
			}
			else
			{
				List<TSource> list = source as List<TSource>;
				if (list != null)
				{
					return new Enumerable.WhereListIterator<TSource>(list, predicate);
				}
				return new Enumerable.WhereEnumerableIterator<TSource>(source, predicate);
			}
		}

		// Token: 0x02000018 RID: 24
		private sealed class Concat2Iterator<TSource> : Enumerable.ConcatIterator<TSource>
		{
			// Token: 0x06000093 RID: 147 RVA: 0x00004C48 File Offset: 0x00002E48
			internal Concat2Iterator(IEnumerable<TSource> first, IEnumerable<TSource> second)
			{
				this._first = first;
				this._second = second;
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00004C5E File Offset: 0x00002E5E
			public override Enumerable.Iterator<TSource> Clone()
			{
				return new Enumerable.Concat2Iterator<TSource>(this._first, this._second);
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00004C74 File Offset: 0x00002E74
			internal override Enumerable.ConcatIterator<TSource> Concat(IEnumerable<TSource> next)
			{
				bool hasOnlyCollections = next is ICollection<TSource> && this._first is ICollection<TSource> && this._second is ICollection<TSource>;
				return new Enumerable.ConcatNIterator<TSource>(this, next, 2, hasOnlyCollections);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00004CB4 File Offset: 0x00002EB4
			public override int GetCount(bool onlyIfCheap)
			{
				int num;
				if (!EnumerableHelpers.TryGetCount<TSource>(this._first, out num))
				{
					if (onlyIfCheap)
					{
						return -1;
					}
					num = this._first.Count<TSource>();
				}
				int num2;
				if (!EnumerableHelpers.TryGetCount<TSource>(this._second, out num2))
				{
					if (onlyIfCheap)
					{
						return -1;
					}
					num2 = this._second.Count<TSource>();
				}
				return checked(num + num2);
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00004D04 File Offset: 0x00002F04
			internal override IEnumerable<TSource> GetEnumerable(int index)
			{
				if (index == 0)
				{
					return this._first;
				}
				if (index != 1)
				{
					return null;
				}
				return this._second;
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00004D20 File Offset: 0x00002F20
			public override TSource[] ToArray()
			{
				SparseArrayBuilder<TSource> sparseArrayBuilder = new SparseArrayBuilder<TSource>(true);
				bool flag = sparseArrayBuilder.ReserveOrAdd(this._first);
				bool flag2 = sparseArrayBuilder.ReserveOrAdd(this._second);
				TSource[] array = sparseArrayBuilder.ToArray();
				if (flag)
				{
					Marker marker = sparseArrayBuilder.Markers.First();
					EnumerableHelpers.Copy<TSource>(this._first, array, 0, marker.Count);
				}
				if (flag2)
				{
					Marker marker2 = sparseArrayBuilder.Markers.Last();
					EnumerableHelpers.Copy<TSource>(this._second, array, marker2.Index, marker2.Count);
				}
				return array;
			}

			// Token: 0x0400000F RID: 15
			internal readonly IEnumerable<TSource> _first;

			// Token: 0x04000010 RID: 16
			internal readonly IEnumerable<TSource> _second;
		}

		// Token: 0x02000019 RID: 25
		private sealed class ConcatNIterator<TSource> : Enumerable.ConcatIterator<TSource>
		{
			// Token: 0x06000099 RID: 153 RVA: 0x00004DAF File Offset: 0x00002FAF
			internal ConcatNIterator(Enumerable.ConcatIterator<TSource> tail, IEnumerable<TSource> head, int headIndex, bool hasOnlyCollections)
			{
				this._tail = tail;
				this._head = head;
				this._headIndex = headIndex;
				this._hasOnlyCollections = hasOnlyCollections;
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600009A RID: 154 RVA: 0x00004DD4 File Offset: 0x00002FD4
			private Enumerable.ConcatNIterator<TSource> PreviousN
			{
				get
				{
					return this._tail as Enumerable.ConcatNIterator<TSource>;
				}
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00004DE1 File Offset: 0x00002FE1
			public override Enumerable.Iterator<TSource> Clone()
			{
				return new Enumerable.ConcatNIterator<TSource>(this._tail, this._head, this._headIndex, this._hasOnlyCollections);
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00004E00 File Offset: 0x00003000
			internal override Enumerable.ConcatIterator<TSource> Concat(IEnumerable<TSource> next)
			{
				if (this._headIndex == 2147483645)
				{
					return new Enumerable.Concat2Iterator<TSource>(this, next);
				}
				bool hasOnlyCollections = this._hasOnlyCollections && next is ICollection<TSource>;
				return new Enumerable.ConcatNIterator<TSource>(this, next, this._headIndex + 1, hasOnlyCollections);
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00004E48 File Offset: 0x00003048
			public override int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap && !this._hasOnlyCollections)
				{
					return -1;
				}
				int num = 0;
				Enumerable.ConcatNIterator<TSource> concatNIterator = this;
				checked
				{
					Enumerable.ConcatNIterator<TSource> concatNIterator2;
					do
					{
						concatNIterator2 = concatNIterator;
						IEnumerable<TSource> head = concatNIterator2._head;
						ICollection<TSource> collection = head as ICollection<TSource>;
						int num2 = (collection != null) ? collection.Count : head.Count<TSource>();
						num += num2;
					}
					while ((concatNIterator = concatNIterator2.PreviousN) != null);
					return num + concatNIterator2._tail.GetCount(onlyIfCheap);
				}
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00004EA8 File Offset: 0x000030A8
			internal override IEnumerable<TSource> GetEnumerable(int index)
			{
				if (index > this._headIndex)
				{
					return null;
				}
				Enumerable.ConcatNIterator<TSource> concatNIterator = this;
				Enumerable.ConcatNIterator<TSource> concatNIterator2;
				for (;;)
				{
					concatNIterator2 = concatNIterator;
					if (index == concatNIterator2._headIndex)
					{
						break;
					}
					if ((concatNIterator = concatNIterator2.PreviousN) == null)
					{
						goto Block_3;
					}
				}
				return concatNIterator2._head;
				Block_3:
				return concatNIterator2._tail.GetEnumerable(index);
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00004EEA File Offset: 0x000030EA
			public override TSource[] ToArray()
			{
				if (!this._hasOnlyCollections)
				{
					return this.LazyToArray();
				}
				return this.PreallocatingToArray();
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00004F04 File Offset: 0x00003104
			private TSource[] LazyToArray()
			{
				SparseArrayBuilder<TSource> sparseArrayBuilder = new SparseArrayBuilder<TSource>(true);
				ArrayBuilder<int> arrayBuilder = default(ArrayBuilder<int>);
				int num = 0;
				for (;;)
				{
					IEnumerable<TSource> enumerable = this.GetEnumerable(num);
					if (enumerable == null)
					{
						break;
					}
					if (sparseArrayBuilder.ReserveOrAdd(enumerable))
					{
						arrayBuilder.Add(num);
					}
					num++;
				}
				TSource[] array = sparseArrayBuilder.ToArray();
				ArrayBuilder<Marker> markers = sparseArrayBuilder.Markers;
				for (int i = 0; i < markers.Count; i++)
				{
					Marker marker = markers[i];
					EnumerableHelpers.Copy<TSource>(this.GetEnumerable(arrayBuilder[i]), array, marker.Index, marker.Count);
				}
				return array;
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x00004FA4 File Offset: 0x000031A4
			private TSource[] PreallocatingToArray()
			{
				int count = this.GetCount(true);
				if (count == 0)
				{
					return Array.Empty<TSource>();
				}
				TSource[] array = new TSource[count];
				int num = array.Length;
				Enumerable.ConcatNIterator<TSource> concatNIterator = this;
				checked
				{
					Enumerable.ConcatNIterator<TSource> concatNIterator2;
					do
					{
						concatNIterator2 = concatNIterator;
						ICollection<TSource> collection = (ICollection<TSource>)concatNIterator2._head;
						int count2 = collection.Count;
						if (count2 > 0)
						{
							num -= count2;
							collection.CopyTo(array, num);
						}
					}
					while ((concatNIterator = concatNIterator2.PreviousN) != null);
					Enumerable.Concat2Iterator<TSource> concat2Iterator = (Enumerable.Concat2Iterator<TSource>)concatNIterator2._tail;
					ICollection<TSource> collection2 = (ICollection<TSource>)concat2Iterator._second;
					int count3 = collection2.Count;
					if (count3 > 0)
					{
						collection2.CopyTo(array, num - count3);
					}
					if (num > count3)
					{
						((ICollection<TSource>)concat2Iterator._first).CopyTo(array, 0);
					}
					return array;
				}
			}

			// Token: 0x04000011 RID: 17
			private readonly Enumerable.ConcatIterator<TSource> _tail;

			// Token: 0x04000012 RID: 18
			private readonly IEnumerable<TSource> _head;

			// Token: 0x04000013 RID: 19
			private readonly int _headIndex;

			// Token: 0x04000014 RID: 20
			private readonly bool _hasOnlyCollections;
		}

		// Token: 0x0200001A RID: 26
		private abstract class ConcatIterator<TSource> : Enumerable.Iterator<TSource>, IIListProvider<TSource>, IEnumerable<!0>, IEnumerable
		{
			// Token: 0x060000A2 RID: 162 RVA: 0x00005055 File Offset: 0x00003255
			public override void Dispose()
			{
				if (this._enumerator != null)
				{
					this._enumerator.Dispose();
					this._enumerator = null;
				}
				base.Dispose();
			}

			// Token: 0x060000A3 RID: 163
			internal abstract IEnumerable<TSource> GetEnumerable(int index);

			// Token: 0x060000A4 RID: 164
			internal abstract Enumerable.ConcatIterator<TSource> Concat(IEnumerable<TSource> next);

			// Token: 0x060000A5 RID: 165 RVA: 0x00005078 File Offset: 0x00003278
			public override bool MoveNext()
			{
				if (this._state == 1)
				{
					this._enumerator = this.GetEnumerable(0).GetEnumerator();
					this._state = 2;
				}
				if (this._state > 1)
				{
					while (!this._enumerator.MoveNext())
					{
						int state = this._state;
						this._state = state + 1;
						IEnumerable<TSource> enumerable = this.GetEnumerable(state - 1);
						if (enumerable == null)
						{
							this.Dispose();
							return false;
						}
						this._enumerator.Dispose();
						this._enumerator = enumerable.GetEnumerator();
					}
					this._current = this._enumerator.Current;
					return true;
				}
				return false;
			}

			// Token: 0x060000A6 RID: 166
			public abstract int GetCount(bool onlyIfCheap);

			// Token: 0x060000A7 RID: 167
			public abstract TSource[] ToArray();

			// Token: 0x060000A8 RID: 168 RVA: 0x00005110 File Offset: 0x00003310
			public List<TSource> ToList()
			{
				int count = this.GetCount(true);
				List<TSource> list = (count != -1) ? new List<TSource>(count) : new List<TSource>();
				int num = 0;
				for (;;)
				{
					IEnumerable<TSource> enumerable = this.GetEnumerable(num);
					if (enumerable == null)
					{
						break;
					}
					list.AddRange(enumerable);
					num++;
				}
				return list;
			}

			// Token: 0x04000015 RID: 21
			private IEnumerator<TSource> _enumerator;
		}

		// Token: 0x0200001B RID: 27
		private sealed class DistinctIterator<TSource> : Enumerable.Iterator<TSource>, IIListProvider<TSource>, IEnumerable<!0>, IEnumerable
		{
			// Token: 0x060000AA RID: 170 RVA: 0x0000515A File Offset: 0x0000335A
			public DistinctIterator(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
			{
				this._source = source;
				this._comparer = comparer;
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00005170 File Offset: 0x00003370
			public override Enumerable.Iterator<TSource> Clone()
			{
				return new Enumerable.DistinctIterator<TSource>(this._source, this._comparer);
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00005184 File Offset: 0x00003384
			public override bool MoveNext()
			{
				int state = this._state;
				TSource tsource;
				if (state != 1)
				{
					if (state == 2)
					{
						while (this._enumerator.MoveNext())
						{
							tsource = this._enumerator.Current;
							if (this._set.Add(tsource))
							{
								this._current = tsource;
								return true;
							}
						}
					}
					this.Dispose();
					return false;
				}
				this._enumerator = this._source.GetEnumerator();
				if (!this._enumerator.MoveNext())
				{
					this.Dispose();
					return false;
				}
				tsource = this._enumerator.Current;
				this._set = new Set<TSource>(this._comparer);
				this._set.Add(tsource);
				this._current = tsource;
				this._state = 2;
				return true;
			}

			// Token: 0x060000AD RID: 173 RVA: 0x0000523F File Offset: 0x0000343F
			public override void Dispose()
			{
				if (this._enumerator != null)
				{
					this._enumerator.Dispose();
					this._enumerator = null;
					this._set = null;
				}
				base.Dispose();
			}

			// Token: 0x060000AE RID: 174 RVA: 0x00005268 File Offset: 0x00003468
			private Set<TSource> FillSet()
			{
				Set<TSource> set = new Set<TSource>(this._comparer);
				set.UnionWith(this._source);
				return set;
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00005281 File Offset: 0x00003481
			public TSource[] ToArray()
			{
				return this.FillSet().ToArray();
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x0000528E File Offset: 0x0000348E
			public List<TSource> ToList()
			{
				return this.FillSet().ToList();
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x0000529B File Offset: 0x0000349B
			public int GetCount(bool onlyIfCheap)
			{
				if (!onlyIfCheap)
				{
					return this.FillSet().Count;
				}
				return -1;
			}

			// Token: 0x04000016 RID: 22
			private readonly IEnumerable<TSource> _source;

			// Token: 0x04000017 RID: 23
			private readonly IEqualityComparer<TSource> _comparer;

			// Token: 0x04000018 RID: 24
			private Set<TSource> _set;

			// Token: 0x04000019 RID: 25
			private IEnumerator<TSource> _enumerator;
		}

		// Token: 0x0200001C RID: 28
		internal abstract class Iterator<TSource> : IEnumerable<!0>, IEnumerable, IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x060000B2 RID: 178 RVA: 0x000052AD File Offset: 0x000034AD
			protected Iterator()
			{
				this._threadId = Environment.CurrentManagedThreadId;
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x000052C0 File Offset: 0x000034C0
			public TSource Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x060000B4 RID: 180
			public abstract Enumerable.Iterator<TSource> Clone();

			// Token: 0x060000B5 RID: 181 RVA: 0x000052C8 File Offset: 0x000034C8
			public virtual void Dispose()
			{
				this._current = default(TSource);
				this._state = -1;
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x000052DD File Offset: 0x000034DD
			public IEnumerator<TSource> GetEnumerator()
			{
				Enumerable.Iterator iterator = (this._state == 0 && this._threadId == Environment.CurrentManagedThreadId) ? this : this.Clone();
				iterator._state = 1;
				return iterator;
			}

			// Token: 0x060000B7 RID: 183
			public abstract bool MoveNext();

			// Token: 0x060000B8 RID: 184 RVA: 0x00005304 File Offset: 0x00003504
			public virtual IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return new Enumerable.SelectEnumerableIterator<TSource, TResult>(this, selector);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x0000530D File Offset: 0x0000350D
			public virtual IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return new Enumerable.WhereEnumerableIterator<TSource>(this, predicate);
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x060000BA RID: 186 RVA: 0x00005316 File Offset: 0x00003516
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00005323 File Offset: 0x00003523
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060000BC RID: 188 RVA: 0x0000532B File Offset: 0x0000352B
			void IEnumerator.Reset()
			{
				throw Error.NotSupported();
			}

			// Token: 0x0400001A RID: 26
			private readonly int _threadId;

			// Token: 0x0400001B RID: 27
			internal int _state;

			// Token: 0x0400001C RID: 28
			internal TSource _current;
		}

		// Token: 0x0200001D RID: 29
		private sealed class SelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x060000BD RID: 189 RVA: 0x00005332 File Offset: 0x00003532
			public SelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, TResult> selector)
			{
				this._source = source;
				this._selector = selector;
			}

			// Token: 0x060000BE RID: 190 RVA: 0x00005348 File Offset: 0x00003548
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.SelectEnumerableIterator<TSource, TResult>(this._source, this._selector);
			}

			// Token: 0x060000BF RID: 191 RVA: 0x0000535B File Offset: 0x0000355B
			public override void Dispose()
			{
				if (this._enumerator != null)
				{
					this._enumerator.Dispose();
					this._enumerator = null;
				}
				base.Dispose();
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00005380 File Offset: 0x00003580
			public override bool MoveNext()
			{
				int state = this._state;
				if (state != 1)
				{
					if (state != 2)
					{
						return false;
					}
				}
				else
				{
					this._enumerator = this._source.GetEnumerator();
					this._state = 2;
				}
				if (this._enumerator.MoveNext())
				{
					this._current = this._selector(this._enumerator.Current);
					return true;
				}
				this.Dispose();
				return false;
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x000053E8 File Offset: 0x000035E8
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return new Enumerable.SelectEnumerableIterator<TSource, TResult2>(this._source, Utilities.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00005404 File Offset: 0x00003604
			public TResult[] ToArray()
			{
				LargeArrayBuilder<TResult> largeArrayBuilder = new LargeArrayBuilder<TResult>(true);
				foreach (TSource arg in this._source)
				{
					largeArrayBuilder.Add(this._selector(arg));
				}
				return largeArrayBuilder.ToArray();
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x0000546C File Offset: 0x0000366C
			public List<TResult> ToList()
			{
				List<TResult> list = new List<TResult>();
				foreach (TSource arg in this._source)
				{
					list.Add(this._selector(arg));
				}
				return list;
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x000054CC File Offset: 0x000036CC
			public int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap)
				{
					return -1;
				}
				int num = 0;
				checked
				{
					foreach (TSource arg in this._source)
					{
						this._selector(arg);
						num++;
					}
					return num;
				}
			}

			// Token: 0x0400001D RID: 29
			private readonly IEnumerable<TSource> _source;

			// Token: 0x0400001E RID: 30
			private readonly Func<TSource, TResult> _selector;

			// Token: 0x0400001F RID: 31
			private IEnumerator<TSource> _enumerator;
		}

		// Token: 0x0200001E RID: 30
		private sealed class SelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IPartition<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x060000C5 RID: 197 RVA: 0x0000552C File Offset: 0x0000372C
			public SelectArrayIterator(TSource[] source, Func<TSource, TResult> selector)
			{
				this._source = source;
				this._selector = selector;
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x00005542 File Offset: 0x00003742
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.SelectArrayIterator<TSource, TResult>(this._source, this._selector);
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x00005558 File Offset: 0x00003758
			public override bool MoveNext()
			{
				if (this._state < 1 | this._state == this._source.Length + 1)
				{
					this.Dispose();
					return false;
				}
				int state = this._state;
				this._state = state + 1;
				int num = state - 1;
				this._current = this._selector(this._source[num]);
				return true;
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x000055BD File Offset: 0x000037BD
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return new Enumerable.SelectArrayIterator<TSource, TResult2>(this._source, Utilities.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x000055D8 File Offset: 0x000037D8
			public TResult[] ToArray()
			{
				TResult[] array = new TResult[this._source.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this._selector(this._source[i]);
				}
				return array;
			}

			// Token: 0x060000CA RID: 202 RVA: 0x00005620 File Offset: 0x00003820
			public List<TResult> ToList()
			{
				TSource[] source = this._source;
				List<TResult> list = new List<TResult>(source.Length);
				for (int i = 0; i < source.Length; i++)
				{
					list.Add(this._selector(source[i]));
				}
				return list;
			}

			// Token: 0x060000CB RID: 203 RVA: 0x00005664 File Offset: 0x00003864
			public int GetCount(bool onlyIfCheap)
			{
				if (!onlyIfCheap)
				{
					foreach (TSource arg in this._source)
					{
						this._selector(arg);
					}
				}
				return this._source.Length;
			}

			// Token: 0x060000CC RID: 204 RVA: 0x000056A6 File Offset: 0x000038A6
			public TResult TryGetFirst(out bool found)
			{
				found = true;
				return this._selector(this._source[0]);
			}

			// Token: 0x060000CD RID: 205 RVA: 0x000056C2 File Offset: 0x000038C2
			public TResult TryGetLast(out bool found)
			{
				found = true;
				return this._selector(this._source[this._source.Length - 1]);
			}

			// Token: 0x04000020 RID: 32
			private readonly TSource[] _source;

			// Token: 0x04000021 RID: 33
			private readonly Func<TSource, TResult> _selector;
		}

		// Token: 0x0200001F RID: 31
		private sealed class SelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IPartition<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x060000CE RID: 206 RVA: 0x000056E7 File Offset: 0x000038E7
			public SelectListIterator(List<TSource> source, Func<TSource, TResult> selector)
			{
				this._source = source;
				this._selector = selector;
			}

			// Token: 0x060000CF RID: 207 RVA: 0x000056FD File Offset: 0x000038FD
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.SelectListIterator<TSource, TResult>(this._source, this._selector);
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x00005710 File Offset: 0x00003910
			public override bool MoveNext()
			{
				int state = this._state;
				if (state != 1)
				{
					if (state != 2)
					{
						return false;
					}
				}
				else
				{
					this._enumerator = this._source.GetEnumerator();
					this._state = 2;
				}
				if (this._enumerator.MoveNext())
				{
					this._current = this._selector(this._enumerator.Current);
					return true;
				}
				this.Dispose();
				return false;
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x00005778 File Offset: 0x00003978
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return new Enumerable.SelectListIterator<TSource, TResult2>(this._source, Utilities.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00005794 File Offset: 0x00003994
			public TResult[] ToArray()
			{
				int count = this._source.Count;
				if (count == 0)
				{
					return Array.Empty<TResult>();
				}
				TResult[] array = new TResult[count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this._selector(this._source[i]);
				}
				return array;
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x000057EC File Offset: 0x000039EC
			public List<TResult> ToList()
			{
				int count = this._source.Count;
				List<TResult> list = new List<TResult>(count);
				for (int i = 0; i < count; i++)
				{
					list.Add(this._selector(this._source[i]));
				}
				return list;
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00005838 File Offset: 0x00003A38
			public int GetCount(bool onlyIfCheap)
			{
				int count = this._source.Count;
				if (!onlyIfCheap)
				{
					for (int i = 0; i < count; i++)
					{
						this._selector(this._source[i]);
					}
				}
				return count;
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x0000587C File Offset: 0x00003A7C
			public TResult TryGetFirst(out bool found)
			{
				if (this._source.Count != 0)
				{
					found = true;
					return this._selector(this._source[0]);
				}
				found = false;
				return default(TResult);
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x000058C0 File Offset: 0x00003AC0
			public TResult TryGetLast(out bool found)
			{
				int count = this._source.Count;
				if (count != 0)
				{
					found = true;
					return this._selector(this._source[count - 1]);
				}
				found = false;
				return default(TResult);
			}

			// Token: 0x04000022 RID: 34
			private readonly List<TSource> _source;

			// Token: 0x04000023 RID: 35
			private readonly Func<TSource, TResult> _selector;

			// Token: 0x04000024 RID: 36
			private List<TSource>.Enumerator _enumerator;
		}

		// Token: 0x02000020 RID: 32
		private sealed class SelectIListIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IPartition<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x060000D7 RID: 215 RVA: 0x00005905 File Offset: 0x00003B05
			public SelectIListIterator(IList<TSource> source, Func<TSource, TResult> selector)
			{
				this._source = source;
				this._selector = selector;
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x0000591B File Offset: 0x00003B1B
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.SelectIListIterator<TSource, TResult>(this._source, this._selector);
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00005930 File Offset: 0x00003B30
			public override bool MoveNext()
			{
				int state = this._state;
				if (state != 1)
				{
					if (state != 2)
					{
						return false;
					}
				}
				else
				{
					this._enumerator = this._source.GetEnumerator();
					this._state = 2;
				}
				if (this._enumerator.MoveNext())
				{
					this._current = this._selector(this._enumerator.Current);
					return true;
				}
				this.Dispose();
				return false;
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00005998 File Offset: 0x00003B98
			public override void Dispose()
			{
				if (this._enumerator != null)
				{
					this._enumerator.Dispose();
					this._enumerator = null;
				}
				base.Dispose();
			}

			// Token: 0x060000DB RID: 219 RVA: 0x000059BA File Offset: 0x00003BBA
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return new Enumerable.SelectIListIterator<TSource, TResult2>(this._source, Utilities.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
			}

			// Token: 0x060000DC RID: 220 RVA: 0x000059D4 File Offset: 0x00003BD4
			public TResult[] ToArray()
			{
				int count = this._source.Count;
				if (count == 0)
				{
					return Array.Empty<TResult>();
				}
				TResult[] array = new TResult[count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this._selector(this._source[i]);
				}
				return array;
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00005A2C File Offset: 0x00003C2C
			public List<TResult> ToList()
			{
				int count = this._source.Count;
				List<TResult> list = new List<TResult>(count);
				for (int i = 0; i < count; i++)
				{
					list.Add(this._selector(this._source[i]));
				}
				return list;
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00005A78 File Offset: 0x00003C78
			public int GetCount(bool onlyIfCheap)
			{
				int count = this._source.Count;
				if (!onlyIfCheap)
				{
					for (int i = 0; i < count; i++)
					{
						this._selector(this._source[i]);
					}
				}
				return count;
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00005ABC File Offset: 0x00003CBC
			public TResult TryGetFirst(out bool found)
			{
				if (this._source.Count != 0)
				{
					found = true;
					return this._selector(this._source[0]);
				}
				found = false;
				return default(TResult);
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x00005B00 File Offset: 0x00003D00
			public TResult TryGetLast(out bool found)
			{
				int count = this._source.Count;
				if (count != 0)
				{
					found = true;
					return this._selector(this._source[count - 1]);
				}
				found = false;
				return default(TResult);
			}

			// Token: 0x04000025 RID: 37
			private readonly IList<TSource> _source;

			// Token: 0x04000026 RID: 38
			private readonly Func<TSource, TResult> _selector;

			// Token: 0x04000027 RID: 39
			private IEnumerator<TSource> _enumerator;
		}

		// Token: 0x02000021 RID: 33
		private sealed class SelectIPartitionIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IPartition<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x060000E1 RID: 225 RVA: 0x00005B45 File Offset: 0x00003D45
			public SelectIPartitionIterator(IPartition<TSource> source, Func<TSource, TResult> selector)
			{
				this._source = source;
				this._selector = selector;
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00005B5B File Offset: 0x00003D5B
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.SelectIPartitionIterator<TSource, TResult>(this._source, this._selector);
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00005B70 File Offset: 0x00003D70
			public override bool MoveNext()
			{
				int state = this._state;
				if (state != 1)
				{
					if (state != 2)
					{
						return false;
					}
				}
				else
				{
					this._enumerator = this._source.GetEnumerator();
					this._state = 2;
				}
				if (this._enumerator.MoveNext())
				{
					this._current = this._selector(this._enumerator.Current);
					return true;
				}
				this.Dispose();
				return false;
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00005BD8 File Offset: 0x00003DD8
			public override void Dispose()
			{
				if (this._enumerator != null)
				{
					this._enumerator.Dispose();
					this._enumerator = null;
				}
				base.Dispose();
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00005BFA File Offset: 0x00003DFA
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return new Enumerable.SelectIPartitionIterator<TSource, TResult2>(this._source, Utilities.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00005C14 File Offset: 0x00003E14
			public TResult TryGetFirst(out bool found)
			{
				bool flag;
				TSource arg = this._source.TryGetFirst(out flag);
				found = flag;
				if (!flag)
				{
					return default(TResult);
				}
				return this._selector(arg);
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x00005C4C File Offset: 0x00003E4C
			public TResult TryGetLast(out bool found)
			{
				bool flag;
				TSource arg = this._source.TryGetLast(out flag);
				found = flag;
				if (!flag)
				{
					return default(TResult);
				}
				return this._selector(arg);
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00005C84 File Offset: 0x00003E84
			private TResult[] LazyToArray()
			{
				LargeArrayBuilder<TResult> largeArrayBuilder = new LargeArrayBuilder<TResult>(true);
				foreach (TSource arg in this._source)
				{
					largeArrayBuilder.Add(this._selector(arg));
				}
				return largeArrayBuilder.ToArray();
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00005CEC File Offset: 0x00003EEC
			private TResult[] PreallocatingToArray(int count)
			{
				TResult[] array = new TResult[count];
				int num = 0;
				foreach (TSource arg in this._source)
				{
					array[num] = this._selector(arg);
					num++;
				}
				return array;
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00005D54 File Offset: 0x00003F54
			public TResult[] ToArray()
			{
				int count = this._source.GetCount(true);
				if (count == -1)
				{
					return this.LazyToArray();
				}
				if (count != 0)
				{
					return this.PreallocatingToArray(count);
				}
				return Array.Empty<TResult>();
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00005D8C File Offset: 0x00003F8C
			public List<TResult> ToList()
			{
				int count = this._source.GetCount(true);
				List<TResult> list;
				if (count != -1)
				{
					if (count == 0)
					{
						return new List<TResult>();
					}
					list = new List<TResult>(count);
				}
				else
				{
					list = new List<TResult>();
				}
				foreach (TSource arg in this._source)
				{
					list.Add(this._selector(arg));
				}
				return list;
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00005E10 File Offset: 0x00004010
			public int GetCount(bool onlyIfCheap)
			{
				if (!onlyIfCheap)
				{
					foreach (TSource arg in this._source)
					{
						this._selector(arg);
					}
				}
				return this._source.GetCount(onlyIfCheap);
			}

			// Token: 0x04000028 RID: 40
			private readonly IPartition<TSource> _source;

			// Token: 0x04000029 RID: 41
			private readonly Func<TSource, TResult> _selector;

			// Token: 0x0400002A RID: 42
			private IEnumerator<TSource> _enumerator;
		}

		// Token: 0x02000022 RID: 34
		private sealed class SelectManySingleSelectorIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x060000ED RID: 237 RVA: 0x00005E74 File Offset: 0x00004074
			internal SelectManySingleSelectorIterator(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
			{
				this._source = source;
				this._selector = selector;
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00005E8A File Offset: 0x0000408A
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.SelectManySingleSelectorIterator<TSource, TResult>(this._source, this._selector);
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00005E9D File Offset: 0x0000409D
			public override void Dispose()
			{
				if (this._subEnumerator != null)
				{
					this._subEnumerator.Dispose();
					this._subEnumerator = null;
				}
				if (this._sourceEnumerator != null)
				{
					this._sourceEnumerator.Dispose();
					this._sourceEnumerator = null;
				}
				base.Dispose();
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x00005EDC File Offset: 0x000040DC
			public int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap)
				{
					return -1;
				}
				int num = 0;
				checked
				{
					foreach (TSource arg in this._source)
					{
						num += this._selector(arg).Count<TResult>();
					}
					return num;
				}
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x00005F40 File Offset: 0x00004140
			public override bool MoveNext()
			{
				switch (this._state)
				{
				case 1:
					this._sourceEnumerator = this._source.GetEnumerator();
					this._state = 2;
					break;
				case 2:
					break;
				case 3:
					goto IL_6F;
				default:
					goto IL_AA;
				}
				IL_38:
				if (!this._sourceEnumerator.MoveNext())
				{
					goto IL_AA;
				}
				TSource arg = this._sourceEnumerator.Current;
				this._subEnumerator = this._selector(arg).GetEnumerator();
				this._state = 3;
				IL_6F:
				if (!this._subEnumerator.MoveNext())
				{
					this._subEnumerator.Dispose();
					this._subEnumerator = null;
					this._state = 2;
					goto IL_38;
				}
				this._current = this._subEnumerator.Current;
				return true;
				IL_AA:
				this.Dispose();
				return false;
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x00006000 File Offset: 0x00004200
			public TResult[] ToArray()
			{
				SparseArrayBuilder<TResult> sparseArrayBuilder = new SparseArrayBuilder<TResult>(true);
				ArrayBuilder<IEnumerable<TResult>> arrayBuilder = default(ArrayBuilder<IEnumerable<TResult>>);
				foreach (TSource arg in this._source)
				{
					IEnumerable<TResult> enumerable = this._selector(arg);
					if (sparseArrayBuilder.ReserveOrAdd(enumerable))
					{
						arrayBuilder.Add(enumerable);
					}
				}
				TResult[] array = sparseArrayBuilder.ToArray();
				ArrayBuilder<Marker> markers = sparseArrayBuilder.Markers;
				for (int i = 0; i < markers.Count; i++)
				{
					Marker marker = markers[i];
					EnumerableHelpers.Copy<TResult>(arrayBuilder[i], array, marker.Index, marker.Count);
				}
				return array;
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x000060D0 File Offset: 0x000042D0
			public List<TResult> ToList()
			{
				List<TResult> list = new List<TResult>();
				foreach (TSource arg in this._source)
				{
					list.AddRange(this._selector(arg));
				}
				return list;
			}

			// Token: 0x0400002B RID: 43
			private readonly IEnumerable<TSource> _source;

			// Token: 0x0400002C RID: 44
			private readonly Func<TSource, IEnumerable<TResult>> _selector;

			// Token: 0x0400002D RID: 45
			private IEnumerator<TSource> _sourceEnumerator;

			// Token: 0x0400002E RID: 46
			private IEnumerator<TResult> _subEnumerator;
		}

		// Token: 0x02000023 RID: 35
		private abstract class UnionIterator<TSource> : Enumerable.Iterator<TSource>, IIListProvider<TSource>, IEnumerable<!0>, IEnumerable
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x00006130 File Offset: 0x00004330
			protected UnionIterator(IEqualityComparer<TSource> comparer)
			{
				this._comparer = comparer;
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x0000613F File Offset: 0x0000433F
			public sealed override void Dispose()
			{
				if (this._enumerator != null)
				{
					this._enumerator.Dispose();
					this._enumerator = null;
					this._set = null;
				}
				base.Dispose();
			}

			// Token: 0x060000F6 RID: 246
			internal abstract IEnumerable<TSource> GetEnumerable(int index);

			// Token: 0x060000F7 RID: 247
			internal abstract Enumerable.UnionIterator<TSource> Union(IEnumerable<TSource> next);

			// Token: 0x060000F8 RID: 248 RVA: 0x00006168 File Offset: 0x00004368
			private void SetEnumerator(IEnumerator<TSource> enumerator)
			{
				IEnumerator<TSource> enumerator2 = this._enumerator;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				this._enumerator = enumerator;
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00006184 File Offset: 0x00004384
			private void StoreFirst()
			{
				Set<TSource> set = new Set<TSource>(this._comparer);
				TSource tsource = this._enumerator.Current;
				set.Add(tsource);
				this._current = tsource;
				this._set = set;
			}

			// Token: 0x060000FA RID: 250 RVA: 0x000061C0 File Offset: 0x000043C0
			private bool GetNext()
			{
				Set<TSource> set = this._set;
				while (this._enumerator.MoveNext())
				{
					TSource tsource = this._enumerator.Current;
					if (set.Add(tsource))
					{
						this._current = tsource;
						return true;
					}
				}
				return false;
			}

			// Token: 0x060000FB RID: 251 RVA: 0x00006204 File Offset: 0x00004404
			public sealed override bool MoveNext()
			{
				if (this._state == 1)
				{
					for (IEnumerable<TSource> enumerable = this.GetEnumerable(0); enumerable != null; enumerable = this.GetEnumerable(this._state - 1))
					{
						IEnumerator<TSource> enumerator = enumerable.GetEnumerator();
						this._state++;
						if (enumerator.MoveNext())
						{
							this.SetEnumerator(enumerator);
							this.StoreFirst();
							return true;
						}
					}
				}
				else if (this._state > 0)
				{
					while (!this.GetNext())
					{
						IEnumerable<TSource> enumerable2 = this.GetEnumerable(this._state - 1);
						if (enumerable2 == null)
						{
							goto IL_94;
						}
						this.SetEnumerator(enumerable2.GetEnumerator());
						this._state++;
					}
					return true;
				}
				IL_94:
				this.Dispose();
				return false;
			}

			// Token: 0x060000FC RID: 252 RVA: 0x000062AC File Offset: 0x000044AC
			private Set<TSource> FillSet()
			{
				Set<TSource> set = new Set<TSource>(this._comparer);
				int num = 0;
				for (;;)
				{
					IEnumerable<TSource> enumerable = this.GetEnumerable(num);
					if (enumerable == null)
					{
						break;
					}
					set.UnionWith(enumerable);
					num++;
				}
				return set;
			}

			// Token: 0x060000FD RID: 253 RVA: 0x000062E0 File Offset: 0x000044E0
			public TSource[] ToArray()
			{
				return this.FillSet().ToArray();
			}

			// Token: 0x060000FE RID: 254 RVA: 0x000062ED File Offset: 0x000044ED
			public List<TSource> ToList()
			{
				return this.FillSet().ToList();
			}

			// Token: 0x060000FF RID: 255 RVA: 0x000062FA File Offset: 0x000044FA
			public int GetCount(bool onlyIfCheap)
			{
				if (!onlyIfCheap)
				{
					return this.FillSet().Count;
				}
				return -1;
			}

			// Token: 0x0400002F RID: 47
			internal readonly IEqualityComparer<TSource> _comparer;

			// Token: 0x04000030 RID: 48
			private IEnumerator<TSource> _enumerator;

			// Token: 0x04000031 RID: 49
			private Set<TSource> _set;
		}

		// Token: 0x02000024 RID: 36
		private sealed class UnionIterator2<TSource> : Enumerable.UnionIterator<TSource>
		{
			// Token: 0x06000100 RID: 256 RVA: 0x0000630C File Offset: 0x0000450C
			public UnionIterator2(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) : base(comparer)
			{
				this._first = first;
				this._second = second;
			}

			// Token: 0x06000101 RID: 257 RVA: 0x00006323 File Offset: 0x00004523
			public override Enumerable.Iterator<TSource> Clone()
			{
				return new Enumerable.UnionIterator2<TSource>(this._first, this._second, this._comparer);
			}

			// Token: 0x06000102 RID: 258 RVA: 0x0000633C File Offset: 0x0000453C
			internal override IEnumerable<TSource> GetEnumerable(int index)
			{
				if (index == 0)
				{
					return this._first;
				}
				if (index != 1)
				{
					return null;
				}
				return this._second;
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00006356 File Offset: 0x00004556
			internal override Enumerable.UnionIterator<TSource> Union(IEnumerable<TSource> next)
			{
				return new Enumerable.UnionIteratorN<TSource>(new SingleLinkedNode<IEnumerable<TSource>>(this._first).Add(this._second).Add(next), 2, this._comparer);
			}

			// Token: 0x04000032 RID: 50
			private readonly IEnumerable<TSource> _first;

			// Token: 0x04000033 RID: 51
			private readonly IEnumerable<TSource> _second;
		}

		// Token: 0x02000025 RID: 37
		private sealed class UnionIteratorN<TSource> : Enumerable.UnionIterator<TSource>
		{
			// Token: 0x06000104 RID: 260 RVA: 0x00006380 File Offset: 0x00004580
			public UnionIteratorN(SingleLinkedNode<IEnumerable<TSource>> sources, int headIndex, IEqualityComparer<TSource> comparer) : base(comparer)
			{
				this._sources = sources;
				this._headIndex = headIndex;
			}

			// Token: 0x06000105 RID: 261 RVA: 0x00006397 File Offset: 0x00004597
			public override Enumerable.Iterator<TSource> Clone()
			{
				return new Enumerable.UnionIteratorN<TSource>(this._sources, this._headIndex, this._comparer);
			}

			// Token: 0x06000106 RID: 262 RVA: 0x000063B0 File Offset: 0x000045B0
			internal override IEnumerable<TSource> GetEnumerable(int index)
			{
				if (index <= this._headIndex)
				{
					return this._sources.GetNode(this._headIndex - index).Item;
				}
				return null;
			}

			// Token: 0x06000107 RID: 263 RVA: 0x000063D5 File Offset: 0x000045D5
			internal override Enumerable.UnionIterator<TSource> Union(IEnumerable<TSource> next)
			{
				if (this._headIndex == 2147483645)
				{
					return new Enumerable.UnionIterator2<TSource>(this, next, this._comparer);
				}
				return new Enumerable.UnionIteratorN<TSource>(this._sources.Add(next), this._headIndex + 1, this._comparer);
			}

			// Token: 0x04000034 RID: 52
			private readonly SingleLinkedNode<IEnumerable<TSource>> _sources;

			// Token: 0x04000035 RID: 53
			private readonly int _headIndex;
		}

		// Token: 0x02000026 RID: 38
		private sealed class WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource>, IIListProvider<TSource>, IEnumerable<!0>, IEnumerable
		{
			// Token: 0x06000108 RID: 264 RVA: 0x00006411 File Offset: 0x00004611
			public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
			{
				this._source = source;
				this._predicate = predicate;
			}

			// Token: 0x06000109 RID: 265 RVA: 0x00006427 File Offset: 0x00004627
			public override Enumerable.Iterator<TSource> Clone()
			{
				return new Enumerable.WhereEnumerableIterator<TSource>(this._source, this._predicate);
			}

			// Token: 0x0600010A RID: 266 RVA: 0x0000643A File Offset: 0x0000463A
			public override void Dispose()
			{
				if (this._enumerator != null)
				{
					this._enumerator.Dispose();
					this._enumerator = null;
				}
				base.Dispose();
			}

			// Token: 0x0600010B RID: 267 RVA: 0x0000645C File Offset: 0x0000465C
			public int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap)
				{
					return -1;
				}
				int num = 0;
				checked
				{
					foreach (TSource arg in this._source)
					{
						if (this._predicate(arg))
						{
							num++;
						}
					}
					return num;
				}
			}

			// Token: 0x0600010C RID: 268 RVA: 0x000064BC File Offset: 0x000046BC
			public override bool MoveNext()
			{
				int state = this._state;
				if (state != 1)
				{
					if (state != 2)
					{
						return false;
					}
				}
				else
				{
					this._enumerator = this._source.GetEnumerator();
					this._state = 2;
				}
				while (this._enumerator.MoveNext())
				{
					TSource tsource = this._enumerator.Current;
					if (this._predicate(tsource))
					{
						this._current = tsource;
						return true;
					}
				}
				this.Dispose();
				return false;
			}

			// Token: 0x0600010D RID: 269 RVA: 0x0000652B File Offset: 0x0000472B
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return new Enumerable.WhereSelectEnumerableIterator<TSource, TResult>(this._source, this._predicate, selector);
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00006540 File Offset: 0x00004740
			public TSource[] ToArray()
			{
				LargeArrayBuilder<TSource> largeArrayBuilder = new LargeArrayBuilder<TSource>(true);
				foreach (TSource tsource in this._source)
				{
					if (this._predicate(tsource))
					{
						largeArrayBuilder.Add(tsource);
					}
				}
				return largeArrayBuilder.ToArray();
			}

			// Token: 0x0600010F RID: 271 RVA: 0x000065AC File Offset: 0x000047AC
			public List<TSource> ToList()
			{
				List<TSource> list = new List<TSource>();
				foreach (TSource tsource in this._source)
				{
					if (this._predicate(tsource))
					{
						list.Add(tsource);
					}
				}
				return list;
			}

			// Token: 0x06000110 RID: 272 RVA: 0x00006610 File Offset: 0x00004810
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return new Enumerable.WhereEnumerableIterator<TSource>(this._source, Utilities.CombinePredicates<TSource>(this._predicate, predicate));
			}

			// Token: 0x04000036 RID: 54
			private readonly IEnumerable<TSource> _source;

			// Token: 0x04000037 RID: 55
			private readonly Func<TSource, bool> _predicate;

			// Token: 0x04000038 RID: 56
			private IEnumerator<TSource> _enumerator;
		}

		// Token: 0x02000027 RID: 39
		internal sealed class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>, IIListProvider<TSource>, IEnumerable<!0>, IEnumerable
		{
			// Token: 0x06000111 RID: 273 RVA: 0x00006629 File Offset: 0x00004829
			public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
			{
				this._source = source;
				this._predicate = predicate;
			}

			// Token: 0x06000112 RID: 274 RVA: 0x0000663F File Offset: 0x0000483F
			public override Enumerable.Iterator<TSource> Clone()
			{
				return new Enumerable.WhereArrayIterator<TSource>(this._source, this._predicate);
			}

			// Token: 0x06000113 RID: 275 RVA: 0x00006654 File Offset: 0x00004854
			public int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap)
				{
					return -1;
				}
				int num = 0;
				checked
				{
					foreach (TSource arg in this._source)
					{
						if (this._predicate(arg))
						{
							num++;
						}
					}
					return num;
				}
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00006698 File Offset: 0x00004898
			public override bool MoveNext()
			{
				int i = this._state - 1;
				TSource[] source = this._source;
				while (i < source.Length)
				{
					TSource tsource = source[i];
					int state = this._state;
					this._state = state + 1;
					i = state;
					if (this._predicate(tsource))
					{
						this._current = tsource;
						return true;
					}
				}
				this.Dispose();
				return false;
			}

			// Token: 0x06000115 RID: 277 RVA: 0x000066F5 File Offset: 0x000048F5
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return new Enumerable.WhereSelectArrayIterator<TSource, TResult>(this._source, this._predicate, selector);
			}

			// Token: 0x06000116 RID: 278 RVA: 0x0000670C File Offset: 0x0000490C
			public TSource[] ToArray()
			{
				LargeArrayBuilder<TSource> largeArrayBuilder = new LargeArrayBuilder<TSource>(this._source.Length);
				foreach (TSource tsource in this._source)
				{
					if (this._predicate(tsource))
					{
						largeArrayBuilder.Add(tsource);
					}
				}
				return largeArrayBuilder.ToArray();
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00006764 File Offset: 0x00004964
			public List<TSource> ToList()
			{
				List<TSource> list = new List<TSource>();
				foreach (TSource tsource in this._source)
				{
					if (this._predicate(tsource))
					{
						list.Add(tsource);
					}
				}
				return list;
			}

			// Token: 0x06000118 RID: 280 RVA: 0x000067AA File Offset: 0x000049AA
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return new Enumerable.WhereArrayIterator<TSource>(this._source, Utilities.CombinePredicates<TSource>(this._predicate, predicate));
			}

			// Token: 0x04000039 RID: 57
			private readonly TSource[] _source;

			// Token: 0x0400003A RID: 58
			private readonly Func<TSource, bool> _predicate;
		}

		// Token: 0x02000028 RID: 40
		private sealed class WhereListIterator<TSource> : Enumerable.Iterator<TSource>, IIListProvider<TSource>, IEnumerable<!0>, IEnumerable
		{
			// Token: 0x06000119 RID: 281 RVA: 0x000067C3 File Offset: 0x000049C3
			public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
			{
				this._source = source;
				this._predicate = predicate;
			}

			// Token: 0x0600011A RID: 282 RVA: 0x000067D9 File Offset: 0x000049D9
			public override Enumerable.Iterator<TSource> Clone()
			{
				return new Enumerable.WhereListIterator<TSource>(this._source, this._predicate);
			}

			// Token: 0x0600011B RID: 283 RVA: 0x000067EC File Offset: 0x000049EC
			public int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap)
				{
					return -1;
				}
				int num = 0;
				for (int i = 0; i < this._source.Count; i++)
				{
					TSource arg = this._source[i];
					checked
					{
						if (this._predicate(arg))
						{
							num++;
						}
					}
				}
				return num;
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00006838 File Offset: 0x00004A38
			public override bool MoveNext()
			{
				int state = this._state;
				if (state != 1)
				{
					if (state != 2)
					{
						return false;
					}
				}
				else
				{
					this._enumerator = this._source.GetEnumerator();
					this._state = 2;
				}
				while (this._enumerator.MoveNext())
				{
					TSource tsource = this._enumerator.Current;
					if (this._predicate(tsource))
					{
						this._current = tsource;
						return true;
					}
				}
				this.Dispose();
				return false;
			}

			// Token: 0x0600011D RID: 285 RVA: 0x000068A7 File Offset: 0x00004AA7
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return new Enumerable.WhereSelectListIterator<TSource, TResult>(this._source, this._predicate, selector);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x000068BC File Offset: 0x00004ABC
			public TSource[] ToArray()
			{
				LargeArrayBuilder<TSource> largeArrayBuilder = new LargeArrayBuilder<TSource>(this._source.Count);
				for (int i = 0; i < this._source.Count; i++)
				{
					TSource tsource = this._source[i];
					if (this._predicate(tsource))
					{
						largeArrayBuilder.Add(tsource);
					}
				}
				return largeArrayBuilder.ToArray();
			}

			// Token: 0x0600011F RID: 287 RVA: 0x0000691C File Offset: 0x00004B1C
			public List<TSource> ToList()
			{
				List<TSource> list = new List<TSource>();
				for (int i = 0; i < this._source.Count; i++)
				{
					TSource tsource = this._source[i];
					if (this._predicate(tsource))
					{
						list.Add(tsource);
					}
				}
				return list;
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00006968 File Offset: 0x00004B68
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return new Enumerable.WhereListIterator<TSource>(this._source, Utilities.CombinePredicates<TSource>(this._predicate, predicate));
			}

			// Token: 0x0400003B RID: 59
			private readonly List<TSource> _source;

			// Token: 0x0400003C RID: 60
			private readonly Func<TSource, bool> _predicate;

			// Token: 0x0400003D RID: 61
			private List<TSource>.Enumerator _enumerator;
		}

		// Token: 0x02000029 RID: 41
		private sealed class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x06000121 RID: 289 RVA: 0x00006981 File Offset: 0x00004B81
			public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
				this._source = source;
				this._predicate = predicate;
				this._selector = selector;
			}

			// Token: 0x06000122 RID: 290 RVA: 0x0000699E File Offset: 0x00004B9E
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.WhereSelectArrayIterator<TSource, TResult>(this._source, this._predicate, this._selector);
			}

			// Token: 0x06000123 RID: 291 RVA: 0x000069B8 File Offset: 0x00004BB8
			public int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap)
				{
					return -1;
				}
				int num = 0;
				checked
				{
					foreach (TSource arg in this._source)
					{
						if (this._predicate(arg))
						{
							this._selector(arg);
							num++;
						}
					}
					return num;
				}
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00006A0C File Offset: 0x00004C0C
			public override bool MoveNext()
			{
				int i = this._state - 1;
				TSource[] source = this._source;
				while (i < source.Length)
				{
					TSource arg = source[i];
					int state = this._state;
					this._state = state + 1;
					i = state;
					if (this._predicate(arg))
					{
						this._current = this._selector(arg);
						return true;
					}
				}
				this.Dispose();
				return false;
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00006A74 File Offset: 0x00004C74
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return new Enumerable.WhereSelectArrayIterator<TSource, TResult2>(this._source, this._predicate, Utilities.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00006A94 File Offset: 0x00004C94
			public TResult[] ToArray()
			{
				LargeArrayBuilder<TResult> largeArrayBuilder = new LargeArrayBuilder<TResult>(this._source.Length);
				foreach (TSource arg in this._source)
				{
					if (this._predicate(arg))
					{
						largeArrayBuilder.Add(this._selector(arg));
					}
				}
				return largeArrayBuilder.ToArray();
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00006AF8 File Offset: 0x00004CF8
			public List<TResult> ToList()
			{
				List<TResult> list = new List<TResult>();
				foreach (TSource arg in this._source)
				{
					if (this._predicate(arg))
					{
						list.Add(this._selector(arg));
					}
				}
				return list;
			}

			// Token: 0x0400003E RID: 62
			private readonly TSource[] _source;

			// Token: 0x0400003F RID: 63
			private readonly Func<TSource, bool> _predicate;

			// Token: 0x04000040 RID: 64
			private readonly Func<TSource, TResult> _selector;
		}

		// Token: 0x0200002A RID: 42
		private sealed class WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x06000128 RID: 296 RVA: 0x00006B49 File Offset: 0x00004D49
			public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
				this._source = source;
				this._predicate = predicate;
				this._selector = selector;
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00006B66 File Offset: 0x00004D66
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.WhereSelectListIterator<TSource, TResult>(this._source, this._predicate, this._selector);
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00006B80 File Offset: 0x00004D80
			public int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap)
				{
					return -1;
				}
				int num = 0;
				for (int i = 0; i < this._source.Count; i++)
				{
					TSource arg = this._source[i];
					checked
					{
						if (this._predicate(arg))
						{
							this._selector(arg);
							num++;
						}
					}
				}
				return num;
			}

			// Token: 0x0600012B RID: 299 RVA: 0x00006BD8 File Offset: 0x00004DD8
			public override bool MoveNext()
			{
				int state = this._state;
				if (state != 1)
				{
					if (state != 2)
					{
						return false;
					}
				}
				else
				{
					this._enumerator = this._source.GetEnumerator();
					this._state = 2;
				}
				while (this._enumerator.MoveNext())
				{
					TSource arg = this._enumerator.Current;
					if (this._predicate(arg))
					{
						this._current = this._selector(arg);
						return true;
					}
				}
				this.Dispose();
				return false;
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00006C52 File Offset: 0x00004E52
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return new Enumerable.WhereSelectListIterator<TSource, TResult2>(this._source, this._predicate, Utilities.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
			}

			// Token: 0x0600012D RID: 301 RVA: 0x00006C74 File Offset: 0x00004E74
			public TResult[] ToArray()
			{
				LargeArrayBuilder<TResult> largeArrayBuilder = new LargeArrayBuilder<TResult>(this._source.Count);
				for (int i = 0; i < this._source.Count; i++)
				{
					TSource arg = this._source[i];
					if (this._predicate(arg))
					{
						largeArrayBuilder.Add(this._selector(arg));
					}
				}
				return largeArrayBuilder.ToArray();
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00006CE0 File Offset: 0x00004EE0
			public List<TResult> ToList()
			{
				List<TResult> list = new List<TResult>();
				for (int i = 0; i < this._source.Count; i++)
				{
					TSource arg = this._source[i];
					if (this._predicate(arg))
					{
						list.Add(this._selector(arg));
					}
				}
				return list;
			}

			// Token: 0x04000041 RID: 65
			private readonly List<TSource> _source;

			// Token: 0x04000042 RID: 66
			private readonly Func<TSource, bool> _predicate;

			// Token: 0x04000043 RID: 67
			private readonly Func<TSource, TResult> _selector;

			// Token: 0x04000044 RID: 68
			private List<TSource>.Enumerator _enumerator;
		}

		// Token: 0x0200002B RID: 43
		private sealed class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
		{
			// Token: 0x0600012F RID: 303 RVA: 0x00006D37 File Offset: 0x00004F37
			public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
				this._source = source;
				this._predicate = predicate;
				this._selector = selector;
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00006D54 File Offset: 0x00004F54
			public override Enumerable.Iterator<TResult> Clone()
			{
				return new Enumerable.WhereSelectEnumerableIterator<TSource, TResult>(this._source, this._predicate, this._selector);
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00006D6D File Offset: 0x00004F6D
			public override void Dispose()
			{
				if (this._enumerator != null)
				{
					this._enumerator.Dispose();
					this._enumerator = null;
				}
				base.Dispose();
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00006D90 File Offset: 0x00004F90
			public int GetCount(bool onlyIfCheap)
			{
				if (onlyIfCheap)
				{
					return -1;
				}
				int num = 0;
				checked
				{
					foreach (TSource arg in this._source)
					{
						if (this._predicate(arg))
						{
							this._selector(arg);
							num++;
						}
					}
					return num;
				}
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00006E00 File Offset: 0x00005000
			public override bool MoveNext()
			{
				int state = this._state;
				if (state != 1)
				{
					if (state != 2)
					{
						return false;
					}
				}
				else
				{
					this._enumerator = this._source.GetEnumerator();
					this._state = 2;
				}
				while (this._enumerator.MoveNext())
				{
					TSource arg = this._enumerator.Current;
					if (this._predicate(arg))
					{
						this._current = this._selector(arg);
						return true;
					}
				}
				this.Dispose();
				return false;
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00006E7A File Offset: 0x0000507A
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return new Enumerable.WhereSelectEnumerableIterator<TSource, TResult2>(this._source, this._predicate, Utilities.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00006E9C File Offset: 0x0000509C
			public TResult[] ToArray()
			{
				LargeArrayBuilder<TResult> largeArrayBuilder = new LargeArrayBuilder<TResult>(true);
				foreach (TSource arg in this._source)
				{
					if (this._predicate(arg))
					{
						largeArrayBuilder.Add(this._selector(arg));
					}
				}
				return largeArrayBuilder.ToArray();
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00006F14 File Offset: 0x00005114
			public List<TResult> ToList()
			{
				List<TResult> list = new List<TResult>();
				foreach (TSource arg in this._source)
				{
					if (this._predicate(arg))
					{
						list.Add(this._selector(arg));
					}
				}
				return list;
			}

			// Token: 0x04000045 RID: 69
			private readonly IEnumerable<TSource> _source;

			// Token: 0x04000046 RID: 70
			private readonly Func<TSource, bool> _predicate;

			// Token: 0x04000047 RID: 71
			private readonly Func<TSource, TResult> _selector;

			// Token: 0x04000048 RID: 72
			private IEnumerator<TSource> _enumerator;
		}
	}
}
