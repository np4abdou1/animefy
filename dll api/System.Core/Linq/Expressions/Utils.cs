using System;

namespace System.Linq.Expressions
{
	// Token: 0x020000D0 RID: 208
	internal static class Utils
	{
		// Token: 0x060006A9 RID: 1705 RVA: 0x00014BD4 File Offset: 0x00012DD4
		public static ConstantExpression Constant(bool value)
		{
			if (!value)
			{
				return Utils.s_false;
			}
			return Utils.s_true;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00014BE4 File Offset: 0x00012DE4
		public static ConstantExpression Constant(int value)
		{
			switch (value)
			{
			case -1:
				return Utils.s_m1;
			case 0:
				return Utils.s_0;
			case 1:
				return Utils.s_1;
			case 2:
				return Utils.s_2;
			case 3:
				return Utils.s_3;
			default:
				return Expression.Constant(value);
			}
		}

		// Token: 0x040001CC RID: 460
		public static readonly object BoxedFalse = false;

		// Token: 0x040001CD RID: 461
		public static readonly object BoxedTrue = true;

		// Token: 0x040001CE RID: 462
		public static readonly object BoxedIntM1 = -1;

		// Token: 0x040001CF RID: 463
		public static readonly object BoxedInt0 = 0;

		// Token: 0x040001D0 RID: 464
		public static readonly object BoxedInt1 = 1;

		// Token: 0x040001D1 RID: 465
		public static readonly object BoxedInt2 = 2;

		// Token: 0x040001D2 RID: 466
		public static readonly object BoxedInt3 = 3;

		// Token: 0x040001D3 RID: 467
		public static readonly object BoxedDefaultSByte = 0;

		// Token: 0x040001D4 RID: 468
		public static readonly object BoxedDefaultChar = '\0';

		// Token: 0x040001D5 RID: 469
		public static readonly object BoxedDefaultInt16 = 0;

		// Token: 0x040001D6 RID: 470
		public static readonly object BoxedDefaultInt64 = 0L;

		// Token: 0x040001D7 RID: 471
		public static readonly object BoxedDefaultByte = 0;

		// Token: 0x040001D8 RID: 472
		public static readonly object BoxedDefaultUInt16 = 0;

		// Token: 0x040001D9 RID: 473
		public static readonly object BoxedDefaultUInt32 = 0U;

		// Token: 0x040001DA RID: 474
		public static readonly object BoxedDefaultUInt64 = 0UL;

		// Token: 0x040001DB RID: 475
		public static readonly object BoxedDefaultSingle = 0f;

		// Token: 0x040001DC RID: 476
		public static readonly object BoxedDefaultDouble = 0.0;

		// Token: 0x040001DD RID: 477
		public static readonly object BoxedDefaultDecimal = 0m;

		// Token: 0x040001DE RID: 478
		public static readonly object BoxedDefaultDateTime = default(DateTime);

		// Token: 0x040001DF RID: 479
		private static readonly ConstantExpression s_true = Expression.Constant(Utils.BoxedTrue);

		// Token: 0x040001E0 RID: 480
		private static readonly ConstantExpression s_false = Expression.Constant(Utils.BoxedFalse);

		// Token: 0x040001E1 RID: 481
		private static readonly ConstantExpression s_m1 = Expression.Constant(Utils.BoxedIntM1);

		// Token: 0x040001E2 RID: 482
		private static readonly ConstantExpression s_0 = Expression.Constant(Utils.BoxedInt0);

		// Token: 0x040001E3 RID: 483
		private static readonly ConstantExpression s_1 = Expression.Constant(Utils.BoxedInt1);

		// Token: 0x040001E4 RID: 484
		private static readonly ConstantExpression s_2 = Expression.Constant(Utils.BoxedInt2);

		// Token: 0x040001E5 RID: 485
		private static readonly ConstantExpression s_3 = Expression.Constant(Utils.BoxedInt3);

		// Token: 0x040001E6 RID: 486
		public static readonly DefaultExpression Empty = Expression.Empty();

		// Token: 0x040001E7 RID: 487
		public static readonly ConstantExpression Null = Expression.Constant(null);
	}
}
