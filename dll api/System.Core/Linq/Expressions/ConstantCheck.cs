using System;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x0200007E RID: 126
	internal static class ConstantCheck
	{
		// Token: 0x0600036E RID: 878 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		internal static bool IsNull(Expression e)
		{
			ExpressionType nodeType = e.NodeType;
			if (nodeType != ExpressionType.Constant)
			{
				return nodeType == ExpressionType.Default && e.Type.IsNullableOrReferenceType();
			}
			return ((ConstantExpression)e).Value == null;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000FD14 File Offset: 0x0000DF14
		internal static AnalyzeTypeIsResult AnalyzeTypeIs(TypeBinaryExpression typeIs)
		{
			return ConstantCheck.AnalyzeTypeIs(typeIs.Expression, typeIs.TypeOperand);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000FD28 File Offset: 0x0000DF28
		private static AnalyzeTypeIsResult AnalyzeTypeIs(Expression operand, Type testType)
		{
			Type type = operand.Type;
			if (type == typeof(void))
			{
				if (!(testType == typeof(void)))
				{
					return AnalyzeTypeIsResult.KnownFalse;
				}
				return AnalyzeTypeIsResult.KnownTrue;
			}
			else
			{
				if (testType == typeof(void) || testType.IsPointer)
				{
					return AnalyzeTypeIsResult.KnownFalse;
				}
				Type nonNullableType = type.GetNonNullableType();
				if (!testType.GetNonNullableType().IsAssignableFrom(nonNullableType))
				{
					return AnalyzeTypeIsResult.Unknown;
				}
				if (type.IsValueType && !type.IsNullableType())
				{
					return AnalyzeTypeIsResult.KnownTrue;
				}
				return AnalyzeTypeIsResult.KnownAssignable;
			}
		}
	}
}
