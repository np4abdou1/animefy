using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000095 RID: 149
	[NullableContext(1)]
	[Nullable(0)]
	internal static class BoxedPrimitives
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x0001AD7F File Offset: 0x00018F7F
		internal static object Get(bool value)
		{
			if (!value)
			{
				return BoxedPrimitives.BooleanFalse;
			}
			return BoxedPrimitives.BooleanTrue;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001AD90 File Offset: 0x00018F90
		internal static object Get(int value)
		{
			object result;
			switch (value)
			{
			case -1:
				result = BoxedPrimitives.Int32_M1;
				break;
			case 0:
				result = BoxedPrimitives.Int32_0;
				break;
			case 1:
				result = BoxedPrimitives.Int32_1;
				break;
			case 2:
				result = BoxedPrimitives.Int32_2;
				break;
			case 3:
				result = BoxedPrimitives.Int32_3;
				break;
			case 4:
				result = BoxedPrimitives.Int32_4;
				break;
			case 5:
				result = BoxedPrimitives.Int32_5;
				break;
			case 6:
				result = BoxedPrimitives.Int32_6;
				break;
			case 7:
				result = BoxedPrimitives.Int32_7;
				break;
			case 8:
				result = BoxedPrimitives.Int32_8;
				break;
			default:
				result = value;
				break;
			}
			return result;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0001AE28 File Offset: 0x00019028
		internal static object Get(long value)
		{
			long num = value - -1L;
			if (num <= 9L)
			{
				switch ((uint)num)
				{
				case 0U:
					return BoxedPrimitives.Int64_M1;
				case 1U:
					return BoxedPrimitives.Int64_0;
				case 2U:
					return BoxedPrimitives.Int64_1;
				case 3U:
					return BoxedPrimitives.Int64_2;
				case 4U:
					return BoxedPrimitives.Int64_3;
				case 5U:
					return BoxedPrimitives.Int64_4;
				case 6U:
					return BoxedPrimitives.Int64_5;
				case 7U:
					return BoxedPrimitives.Int64_6;
				case 8U:
					return BoxedPrimitives.Int64_7;
				case 9U:
					return BoxedPrimitives.Int64_8;
				}
			}
			return value;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001AECD File Offset: 0x000190CD
		internal static object Get(decimal value)
		{
			return value;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001AED8 File Offset: 0x000190D8
		internal static object Get(double value)
		{
			if (value == 0.0)
			{
				if (!double.IsNegativeInfinity(1.0 / value))
				{
					return BoxedPrimitives.DoubleZero;
				}
				return BoxedPrimitives.DoubleNegativeZero;
			}
			else if (double.IsInfinity(value))
			{
				if (!double.IsPositiveInfinity(value))
				{
					return BoxedPrimitives.DoubleNegativeInfinity;
				}
				return BoxedPrimitives.DoublePositiveInfinity;
			}
			else
			{
				if (double.IsNaN(value))
				{
					return BoxedPrimitives.DoubleNaN;
				}
				return value;
			}
		}

		// Token: 0x0400037B RID: 891
		internal static readonly object BooleanTrue = true;

		// Token: 0x0400037C RID: 892
		internal static readonly object BooleanFalse = false;

		// Token: 0x0400037D RID: 893
		internal static readonly object Int32_M1 = -1;

		// Token: 0x0400037E RID: 894
		internal static readonly object Int32_0 = 0;

		// Token: 0x0400037F RID: 895
		internal static readonly object Int32_1 = 1;

		// Token: 0x04000380 RID: 896
		internal static readonly object Int32_2 = 2;

		// Token: 0x04000381 RID: 897
		internal static readonly object Int32_3 = 3;

		// Token: 0x04000382 RID: 898
		internal static readonly object Int32_4 = 4;

		// Token: 0x04000383 RID: 899
		internal static readonly object Int32_5 = 5;

		// Token: 0x04000384 RID: 900
		internal static readonly object Int32_6 = 6;

		// Token: 0x04000385 RID: 901
		internal static readonly object Int32_7 = 7;

		// Token: 0x04000386 RID: 902
		internal static readonly object Int32_8 = 8;

		// Token: 0x04000387 RID: 903
		internal static readonly object Int64_M1 = -1L;

		// Token: 0x04000388 RID: 904
		internal static readonly object Int64_0 = 0L;

		// Token: 0x04000389 RID: 905
		internal static readonly object Int64_1 = 1L;

		// Token: 0x0400038A RID: 906
		internal static readonly object Int64_2 = 2L;

		// Token: 0x0400038B RID: 907
		internal static readonly object Int64_3 = 3L;

		// Token: 0x0400038C RID: 908
		internal static readonly object Int64_4 = 4L;

		// Token: 0x0400038D RID: 909
		internal static readonly object Int64_5 = 5L;

		// Token: 0x0400038E RID: 910
		internal static readonly object Int64_6 = 6L;

		// Token: 0x0400038F RID: 911
		internal static readonly object Int64_7 = 7L;

		// Token: 0x04000390 RID: 912
		internal static readonly object Int64_8 = 8L;

		// Token: 0x04000391 RID: 913
		internal static readonly object DoubleNaN = double.NaN;

		// Token: 0x04000392 RID: 914
		internal static readonly object DoublePositiveInfinity = double.PositiveInfinity;

		// Token: 0x04000393 RID: 915
		internal static readonly object DoubleNegativeInfinity = double.NegativeInfinity;

		// Token: 0x04000394 RID: 916
		internal static readonly object DoubleZero = 0.0;

		// Token: 0x04000395 RID: 917
		internal static readonly object DoubleNegativeZero = --0.0;
	}
}
