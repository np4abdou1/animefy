using System;
using System.Linq.Expressions;

namespace System.Dynamic.Utils
{
	// Token: 0x0200013B RID: 315
	internal static class ExpressionVisitorUtils
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x000256A0 File Offset: 0x000238A0
		public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block)
		{
			Expression[] array = null;
			int i = 0;
			int expressionCount = block.ExpressionCount;
			while (i < expressionCount)
			{
				Expression expression = block.GetExpression(i);
				Expression expression2 = visitor.Visit(expression);
				if (array != null)
				{
					array[i] = expression2;
				}
				else if (expression2 != expression)
				{
					array = new Expression[expressionCount];
					for (int j = 0; j < i; j++)
					{
						array[j] = block.GetExpression(j);
					}
					array[i] = expression2;
				}
				i++;
			}
			return array;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002570C File Offset: 0x0002390C
		public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName)
		{
			ParameterExpression[] array = null;
			int i = 0;
			int parameterCount = nodes.ParameterCount;
			while (i < parameterCount)
			{
				ParameterExpression parameter = nodes.GetParameter(i);
				ParameterExpression parameterExpression = visitor.VisitAndConvert<ParameterExpression>(parameter, callerName);
				if (array != null)
				{
					array[i] = parameterExpression;
				}
				else if (parameterExpression != parameter)
				{
					array = new ParameterExpression[parameterCount];
					for (int j = 0; j < i; j++)
					{
						array[j] = nodes.GetParameter(j);
					}
					array[i] = parameterExpression;
				}
				i++;
			}
			return array;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00025778 File Offset: 0x00023978
		public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes)
		{
			Expression[] array = null;
			int i = 0;
			int argumentCount = nodes.ArgumentCount;
			while (i < argumentCount)
			{
				Expression argument = nodes.GetArgument(i);
				Expression expression = visitor.Visit(argument);
				if (array != null)
				{
					array[i] = expression;
				}
				else if (expression != argument)
				{
					array = new Expression[argumentCount];
					for (int j = 0; j < i; j++)
					{
						array[j] = nodes.GetArgument(j);
					}
					array[i] = expression;
				}
				i++;
			}
			return array;
		}
	}
}
