using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace System.Dynamic.Utils
{
	// Token: 0x02000138 RID: 312
	internal static class ContractUtils
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000251B6 File Offset: 0x000233B6
		[ExcludeFromCodeCoverage]
		public static Exception Unreachable
		{
			get
			{
				return new InvalidOperationException("Code supposed to be unreachable");
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000251C2 File Offset: 0x000233C2
		public static void Requires(bool precondition, string paramName)
		{
			if (!precondition)
			{
				throw Error.InvalidArgumentValue(paramName);
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000251CE File Offset: 0x000233CE
		public static void RequiresNotNull(object value, string paramName)
		{
			if (value == null)
			{
				throw new ArgumentNullException(paramName);
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000251DA File Offset: 0x000233DA
		public static void RequiresNotNull(object value, string paramName, int index)
		{
			if (value == null)
			{
				throw new ArgumentNullException(ContractUtils.GetParamName(paramName, index));
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000251EC File Offset: 0x000233EC
		public static void RequiresNotEmpty<T>(ICollection<T> collection, string paramName)
		{
			ContractUtils.RequiresNotNull(collection, paramName);
			if (collection.Count == 0)
			{
				throw Error.NonEmptyCollectionRequired(paramName);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00025204 File Offset: 0x00023404
		public static void RequiresNotNullItems<T>(IList<T> array, string arrayName)
		{
			ContractUtils.RequiresNotNull(array, arrayName);
			int i = 0;
			int count = array.Count;
			while (i < count)
			{
				if (array[i] == null)
				{
					throw new ArgumentNullException(ContractUtils.GetParamName(arrayName, i));
				}
				i++;
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00025246 File Offset: 0x00023446
		private static string GetParamName(string paramName, int index)
		{
			if (index < 0)
			{
				return paramName;
			}
			return string.Format("{0}[{1}]", paramName, index);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002525F File Offset: 0x0002345F
		public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException(countName);
			}
			if (offset < 0 || array.Count - offset < count)
			{
				throw new ArgumentOutOfRangeException(offsetName);
			}
		}
	}
}
