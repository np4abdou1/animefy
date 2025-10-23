using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System.Dynamic.Utils
{
	// Token: 0x02000137 RID: 311
	internal static class CollectionExtensions
	{
		// Token: 0x060009D5 RID: 2517 RVA: 0x00025090 File Offset: 0x00023290
		public static TrueReadOnlyCollection<T> AddFirst<T>(this ReadOnlyCollection<T> list, T item)
		{
			T[] array = new T[list.Count + 1];
			array[0] = item;
			list.CopyTo(array, 1);
			return new TrueReadOnlyCollection<T>(array);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000250C4 File Offset: 0x000232C4
		public static T[] AddFirst<T>(this T[] array, T item)
		{
			T[] array2 = new T[array.Length + 1];
			array2[0] = item;
			array.CopyTo(array2, 1);
			return array2;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000250F0 File Offset: 0x000232F0
		public static T[] AddLast<T>(this T[] array, T item)
		{
			T[] array2 = new T[array.Length + 1];
			array.CopyTo(array2, 0);
			array2[array.Length] = item;
			return array2;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002511C File Offset: 0x0002331C
		public static T[] RemoveFirst<T>(this T[] array)
		{
			T[] array2 = new T[array.Length - 1];
			Array.Copy(array, 1, array2, 0, array2.Length);
			return array2;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00025144 File Offset: 0x00023344
		public static T[] RemoveLast<T>(this T[] array)
		{
			T[] array2 = new T[array.Length - 1];
			Array.Copy(array, 0, array2, 0, array2.Length);
			return array2;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0002516C File Offset: 0x0002336C
		public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> enumerable)
		{
			if (enumerable == null)
			{
				return EmptyReadOnlyCollection<T>.Instance;
			}
			TrueReadOnlyCollection<T> trueReadOnlyCollection = enumerable as TrueReadOnlyCollection<T>;
			if (trueReadOnlyCollection != null)
			{
				return trueReadOnlyCollection;
			}
			ReadOnlyCollectionBuilder<T> readOnlyCollectionBuilder = enumerable as ReadOnlyCollectionBuilder<T>;
			if (readOnlyCollectionBuilder != null)
			{
				return readOnlyCollectionBuilder.ToReadOnlyCollection();
			}
			T[] array = enumerable.ToArray<T>();
			if (array.Length != 0)
			{
				return new TrueReadOnlyCollection<T>(array);
			}
			return EmptyReadOnlyCollection<T>.Instance;
		}
	}
}
