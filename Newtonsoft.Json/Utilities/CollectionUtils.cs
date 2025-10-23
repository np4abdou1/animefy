using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000096 RID: 150
	[NullableContext(1)]
	[Nullable(0)]
	internal static class CollectionUtils
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x0001B0A8 File Offset: 0x000192A8
		public static bool IsNullOrEmpty<[Nullable(2)] T>(ICollection<T> collection)
		{
			return collection == null || collection.Count == 0;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001B0B8 File Offset: 0x000192B8
		public static void AddRange<[Nullable(2)] T>(this IList<T> initial, IEnumerable<T> collection)
		{
			if (initial == null)
			{
				throw new ArgumentNullException("initial");
			}
			if (collection == null)
			{
				return;
			}
			foreach (T item in collection)
			{
				initial.Add(item);
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001B114 File Offset: 0x00019314
		public static bool IsDictionaryType(Type type)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			return typeof(IDictionary).IsAssignableFrom(type) || ReflectionUtils.ImplementsGenericDefinition(type, typeof(IDictionary<, >)) || ReflectionUtils.ImplementsGenericDefinition(type, typeof(IReadOnlyDictionary<, >));
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001B16C File Offset: 0x0001936C
		[return: Nullable(2)]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			Type constructorArgumentType = typeof(IList<>).MakeGenericType(new Type[]
			{
				collectionItemType
			});
			return CollectionUtils.ResolveEnumerableCollectionConstructor(collectionType, collectionItemType, constructorArgumentType);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001B19C File Offset: 0x0001939C
		[return: Nullable(2)]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			Type left = typeof(IEnumerable<>).MakeGenericType(new Type[]
			{
				collectionItemType
			});
			ConstructorInfo constructorInfo = null;
			foreach (ConstructorInfo constructorInfo2 in collectionType.GetConstructors(BindingFlags.Instance | BindingFlags.Public))
			{
				IList<ParameterInfo> parameters = constructorInfo2.GetParameters();
				if (parameters.Count == 1)
				{
					Type parameterType = parameters[0].ParameterType;
					if (left == parameterType)
					{
						constructorInfo = constructorInfo2;
						break;
					}
					if (constructorInfo == null && parameterType.IsAssignableFrom(constructorArgumentType))
					{
						constructorInfo = constructorInfo2;
					}
				}
			}
			return constructorInfo;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001B229 File Offset: 0x00019429
		public static bool AddDistinct<[Nullable(2)] T>(this IList<T> list, T value)
		{
			return list.AddDistinct(value, EqualityComparer<T>.Default);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001B237 File Offset: 0x00019437
		public static bool AddDistinct<[Nullable(2)] T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			if (list.ContainsValue(value, comparer))
			{
				return false;
			}
			list.Add(value);
			return true;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001B250 File Offset: 0x00019450
		public static bool ContainsValue<[Nullable(2)] TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			if (comparer == null)
			{
				comparer = EqualityComparer<TSource>.Default;
			}
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			foreach (TSource x in source)
			{
				if (comparer.Equals(x, value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001B2BC File Offset: 0x000194BC
		public static bool AddRangeDistinct<[Nullable(2)] T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			bool result = true;
			foreach (T value in values)
			{
				if (!list.AddDistinct(value, comparer))
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001B30C File Offset: 0x0001950C
		public static int IndexOf<[Nullable(2)] T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			int num = 0;
			foreach (T arg in collection)
			{
				if (predicate(arg))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001B364 File Offset: 0x00019564
		public static bool Contains<[Nullable(2)] T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (comparer.Equals(value, list[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001B3A0 File Offset: 0x000195A0
		public static int IndexOfReference<[Nullable(2)] T>(this List<T> list, T item)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (item == list[i])
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001B3D8 File Offset: 0x000195D8
		public static void FastReverse<[Nullable(2)] T>(this List<T> list)
		{
			int i = 0;
			int num = list.Count - 1;
			while (i < num)
			{
				T value = list[i];
				list[i] = list[num];
				list[num] = value;
				i++;
				num--;
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001B41C File Offset: 0x0001961C
		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			IList<int> list = new List<int>();
			IList list2 = values;
			for (;;)
			{
				list.Add(list2.Count);
				if (list.Count == dimensionsCount || list2.Count == 0)
				{
					break;
				}
				IList list3 = list2[0] as IList;
				if (list3 == null)
				{
					break;
				}
				list2 = list3;
			}
			return list;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001B464 File Offset: 0x00019664
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
			int num = indices.Length;
			if (num == multidimensionalArray.Rank)
			{
				multidimensionalArray.SetValue(CollectionUtils.JaggedArrayGetValue(values, indices), indices);
				return;
			}
			int length = multidimensionalArray.GetLength(num);
			if (((IList)CollectionUtils.JaggedArrayGetValue(values, indices)).Count != length)
			{
				throw new Exception("Cannot deserialize non-cubical array as multidimensional array.");
			}
			int[] array = new int[num + 1];
			for (int i = 0; i < num; i++)
			{
				array[i] = indices[i];
			}
			for (int j = 0; j < multidimensionalArray.GetLength(num); j++)
			{
				array[num] = j;
				CollectionUtils.CopyFromJaggedToMultidimensionalArray(values, multidimensionalArray, array);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001B4F4 File Offset: 0x000196F4
		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			IList list = values;
			for (int i = 0; i < indices.Length; i++)
			{
				int index = indices[i];
				if (i == indices.Length - 1)
				{
					return list[index];
				}
				list = (IList)list[index];
			}
			return list;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0001B534 File Offset: 0x00019734
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			IList<int> dimensions = CollectionUtils.GetDimensions(values, rank);
			while (dimensions.Count < rank)
			{
				dimensions.Add(0);
			}
			Array array = Array.CreateInstance(type, dimensions.ToArray<int>());
			CollectionUtils.CopyFromJaggedToMultidimensionalArray(values, array, CollectionUtils.ArrayEmpty<int>());
			return array;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001B575 File Offset: 0x00019775
		public static T[] ArrayEmpty<[Nullable(2)] T>()
		{
			return CollectionUtils.EmptyArrayContainer<T>.Empty;
		}

		// Token: 0x02000097 RID: 151
		[NullableContext(0)]
		private static class EmptyArrayContainer<[Nullable(2)] T>
		{
			// Token: 0x04000396 RID: 918
			[Nullable(1)]
			public static readonly T[] Empty = new T[0];
		}
	}
}
