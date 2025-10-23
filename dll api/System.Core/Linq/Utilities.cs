using System;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x02000046 RID: 70
	internal static class Utilities
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x000083D0 File Offset: 0x000065D0
		public static bool AreEqualityComparersEqual<TSource>(IEqualityComparer<TSource> left, IEqualityComparer<TSource> right)
		{
			if (left == right)
			{
				return true;
			}
			EqualityComparer<TSource> @default = EqualityComparer<TSource>.Default;
			if (left == null)
			{
				return right == @default || right.Equals(@default);
			}
			if (right == null)
			{
				return left == @default || left.Equals(@default);
			}
			return left.Equals(right);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00008412 File Offset: 0x00006612
		public static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			return (TSource x) => predicate1(x) && predicate2(x);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00008432 File Offset: 0x00006632
		public static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			return (TSource x) => selector2(selector1(x));
		}
	}
}
