using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000F0 RID: 240
	internal sealed class StackSpiller
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x0001ECDC File Offset: 0x0001CEDC
		private StackSpiller.Result RewriteExpression(Expression node, StackSpiller.Stack stack)
		{
			if (node == null)
			{
				return new StackSpiller.Result(StackSpiller.RewriteAction.None, null);
			}
			if (!this._guard.TryEnterOnCurrentStack())
			{
				return this._guard.RunOnEmptyStack<StackSpiller, Expression, StackSpiller.Stack, StackSpiller.Result>((StackSpiller @this, Expression n, StackSpiller.Stack s) => @this.RewriteExpression(n, s), this, node, stack);
			}
			StackSpiller.Result result;
			switch (node.NodeType)
			{
			case ExpressionType.Add:
			case ExpressionType.AddChecked:
			case ExpressionType.And:
			case ExpressionType.ArrayIndex:
			case ExpressionType.Divide:
			case ExpressionType.Equal:
			case ExpressionType.ExclusiveOr:
			case ExpressionType.GreaterThan:
			case ExpressionType.GreaterThanOrEqual:
			case ExpressionType.LeftShift:
			case ExpressionType.LessThan:
			case ExpressionType.LessThanOrEqual:
			case ExpressionType.Modulo:
			case ExpressionType.Multiply:
			case ExpressionType.MultiplyChecked:
			case ExpressionType.NotEqual:
			case ExpressionType.Or:
			case ExpressionType.Power:
			case ExpressionType.RightShift:
			case ExpressionType.Subtract:
			case ExpressionType.SubtractChecked:
				result = this.RewriteBinaryExpression(node, stack);
				break;
			case ExpressionType.AndAlso:
			case ExpressionType.Coalesce:
			case ExpressionType.OrElse:
				result = this.RewriteLogicalBinaryExpression(node, stack);
				break;
			case ExpressionType.ArrayLength:
			case ExpressionType.Convert:
			case ExpressionType.ConvertChecked:
			case ExpressionType.Negate:
			case ExpressionType.UnaryPlus:
			case ExpressionType.NegateChecked:
			case ExpressionType.Not:
			case ExpressionType.TypeAs:
			case ExpressionType.Decrement:
			case ExpressionType.Increment:
			case ExpressionType.Unbox:
			case ExpressionType.OnesComplement:
			case ExpressionType.IsTrue:
			case ExpressionType.IsFalse:
				result = this.RewriteUnaryExpression(node, stack);
				break;
			case ExpressionType.Call:
				result = this.RewriteMethodCallExpression(node, stack);
				break;
			case ExpressionType.Conditional:
				result = this.RewriteConditionalExpression(node, stack);
				break;
			case ExpressionType.Constant:
			case ExpressionType.Parameter:
			case ExpressionType.Quote:
			case ExpressionType.DebugInfo:
			case ExpressionType.Default:
			case ExpressionType.RuntimeVariables:
				result = new StackSpiller.Result(StackSpiller.RewriteAction.None, node);
				break;
			case ExpressionType.Invoke:
				result = this.RewriteInvocationExpression(node, stack);
				break;
			case ExpressionType.Lambda:
				result = StackSpiller.RewriteLambdaExpression(node);
				break;
			case ExpressionType.ListInit:
				result = this.RewriteListInitExpression(node, stack);
				break;
			case ExpressionType.MemberAccess:
				result = this.RewriteMemberExpression(node, stack);
				break;
			case ExpressionType.MemberInit:
				result = this.RewriteMemberInitExpression(node, stack);
				break;
			case ExpressionType.New:
				result = this.RewriteNewExpression(node, stack);
				break;
			case ExpressionType.NewArrayInit:
			case ExpressionType.NewArrayBounds:
				result = this.RewriteNewArrayExpression(node, stack);
				break;
			case ExpressionType.TypeIs:
			case ExpressionType.TypeEqual:
				result = this.RewriteTypeBinaryExpression(node, stack);
				break;
			case ExpressionType.Assign:
				result = this.RewriteAssignBinaryExpression(node, stack);
				break;
			case ExpressionType.Block:
				result = this.RewriteBlockExpression(node, stack);
				break;
			case ExpressionType.Dynamic:
				result = this.RewriteDynamicExpression(node);
				break;
			case ExpressionType.Extension:
				result = this.RewriteExtensionExpression(node, stack);
				break;
			case ExpressionType.Goto:
				result = this.RewriteGotoExpression(node, stack);
				break;
			case ExpressionType.Index:
				result = this.RewriteIndexExpression(node, stack);
				break;
			case ExpressionType.Label:
				result = this.RewriteLabelExpression(node, stack);
				break;
			case ExpressionType.Loop:
				result = this.RewriteLoopExpression(node, stack);
				break;
			case ExpressionType.Switch:
				result = this.RewriteSwitchExpression(node, stack);
				break;
			case ExpressionType.Throw:
				result = this.RewriteThrowUnaryExpression(node, stack);
				break;
			case ExpressionType.Try:
				result = this.RewriteTryExpression(node, stack);
				break;
			case ExpressionType.AddAssign:
			case ExpressionType.AndAssign:
			case ExpressionType.DivideAssign:
			case ExpressionType.ExclusiveOrAssign:
			case ExpressionType.LeftShiftAssign:
			case ExpressionType.ModuloAssign:
			case ExpressionType.MultiplyAssign:
			case ExpressionType.OrAssign:
			case ExpressionType.PowerAssign:
			case ExpressionType.RightShiftAssign:
			case ExpressionType.SubtractAssign:
			case ExpressionType.AddAssignChecked:
			case ExpressionType.MultiplyAssignChecked:
			case ExpressionType.SubtractAssignChecked:
			case ExpressionType.PreIncrementAssign:
			case ExpressionType.PreDecrementAssign:
			case ExpressionType.PostIncrementAssign:
			case ExpressionType.PostDecrementAssign:
				result = this.RewriteReducibleExpression(node, stack);
				break;
			default:
				result = this.RewriteExpression(node.ReduceAndCheck(), stack);
				if (result.Action == StackSpiller.RewriteAction.None)
				{
					result = new StackSpiller.Result(result.Action | StackSpiller.RewriteAction.Copy, result.Node);
				}
				break;
			}
			return result;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0001F012 File Offset: 0x0001D212
		private static Expression MakeBlock(ArrayBuilder<Expression> expressions)
		{
			return new SpilledExpressionBlock(expressions.ToArray());
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0001F020 File Offset: 0x0001D220
		private static Expression MakeBlock(params Expression[] expressions)
		{
			return new SpilledExpressionBlock(expressions);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0001F020 File Offset: 0x0001D220
		private static Expression MakeBlock(IReadOnlyList<Expression> expressions)
		{
			return new SpilledExpressionBlock(expressions);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0001F028 File Offset: 0x0001D228
		private ParameterExpression MakeTemp(Type type)
		{
			return this._tm.Temp(type);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0001F036 File Offset: 0x0001D236
		private int Mark()
		{
			return this._tm.Mark();
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0001F043 File Offset: 0x0001D243
		private void Free(int mark)
		{
			this._tm.Free(mark);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0001F054 File Offset: 0x0001D254
		private ParameterExpression ToTemp(Expression expression, out Expression save, bool byRef)
		{
			Type type = byRef ? expression.Type.MakeByRefType() : expression.Type;
			ParameterExpression parameterExpression = this.MakeTemp(type);
			save = AssignBinaryExpression.Make(parameterExpression, expression, byRef);
			return parameterExpression;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0001F08B File Offset: 0x0001D28B
		internal static LambdaExpression AnalyzeLambda(LambdaExpression lambda)
		{
			return lambda.Accept(new StackSpiller(StackSpiller.Stack.Empty));
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0001F099 File Offset: 0x0001D299
		private StackSpiller(StackSpiller.Stack stack)
		{
			this._startingStack = stack;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
		internal Expression<T> Rewrite<T>(Expression<T> lambda)
		{
			StackSpiller.Result result = this.RewriteExpressionFreeTemps(lambda.Body, this._startingStack);
			this._lambdaRewrite = result.Action;
			if (result.Action != StackSpiller.RewriteAction.None)
			{
				Expression expression = result.Node;
				if (this._tm.Temps.Count > 0)
				{
					expression = Expression.Block(this._tm.Temps, new TrueReadOnlyCollection<Expression>(new Expression[]
					{
						expression
					}));
				}
				return Expression<T>.Create(expression, lambda.Name, lambda.TailCall, new ParameterList(lambda));
			}
			return lambda;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0001F148 File Offset: 0x0001D348
		private StackSpiller.Result RewriteExpressionFreeTemps(Expression expression, StackSpiller.Stack stack)
		{
			int mark = this.Mark();
			StackSpiller.Result result = this.RewriteExpression(expression, stack);
			this.Free(mark);
			return result;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0001F16C File Offset: 0x0001D36C
		private StackSpiller.Result RewriteDynamicExpression(Expression expr)
		{
			IDynamicExpression dynamicExpression = (IDynamicExpression)expr;
			StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, StackSpiller.Stack.NonEmpty, dynamicExpression.ArgumentCount);
			childRewriter.AddArguments(dynamicExpression);
			if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
			{
				StackSpiller.RequireNoRefArgs(dynamicExpression.DelegateType.GetInvokeMethod());
			}
			return childRewriter.Finish(childRewriter.Rewrite ? dynamicExpression.Rewrite(childRewriter[0, -1]) : expr);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		private StackSpiller.Result RewriteIndexAssignment(BinaryExpression node, StackSpiller.Stack stack)
		{
			IndexExpression indexExpression = (IndexExpression)node.Left;
			StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, stack, 2 + indexExpression.ArgumentCount);
			childRewriter.Add(indexExpression.Object);
			childRewriter.AddArguments(indexExpression);
			childRewriter.Add(node.Right);
			if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
			{
				childRewriter.MarkRefInstance(indexExpression.Object);
			}
			if (childRewriter.Rewrite)
			{
				node = new AssignBinaryExpression(new IndexExpression(childRewriter[0], indexExpression.Indexer, childRewriter[1, -2]), childRewriter[-1]);
			}
			return childRewriter.Finish(node);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0001F268 File Offset: 0x0001D468
		private StackSpiller.Result RewriteLogicalBinaryExpression(Expression expr, StackSpiller.Stack stack)
		{
			BinaryExpression binaryExpression = (BinaryExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(binaryExpression.Left, stack);
			StackSpiller.Result result2 = this.RewriteExpression(binaryExpression.Right, stack);
			StackSpiller.Result result3 = this.RewriteExpression(binaryExpression.Conversion, stack);
			StackSpiller.RewriteAction rewriteAction = result.Action | result2.Action | result3.Action;
			if (rewriteAction != StackSpiller.RewriteAction.None)
			{
				expr = BinaryExpression.Create(binaryExpression.NodeType, result.Node, result2.Node, binaryExpression.Type, binaryExpression.Method, (LambdaExpression)result3.Node);
			}
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0001F2F4 File Offset: 0x0001D4F4
		private StackSpiller.Result RewriteReducibleExpression(Expression expr, StackSpiller.Stack stack)
		{
			StackSpiller.Result result = this.RewriteExpression(expr.Reduce(), stack);
			return new StackSpiller.Result(result.Action | StackSpiller.RewriteAction.Copy, result.Node);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0001F324 File Offset: 0x0001D524
		private StackSpiller.Result RewriteBinaryExpression(Expression expr, StackSpiller.Stack stack)
		{
			BinaryExpression binaryExpression = (BinaryExpression)expr;
			StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, stack, 3);
			childRewriter.Add(binaryExpression.Left);
			childRewriter.Add(binaryExpression.Right);
			childRewriter.Add(binaryExpression.Conversion);
			if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
			{
				StackSpiller.RequireNoRefArgs(binaryExpression.Method);
			}
			return childRewriter.Finish(childRewriter.Rewrite ? BinaryExpression.Create(binaryExpression.NodeType, childRewriter[0], childRewriter[1], binaryExpression.Type, binaryExpression.Method, (LambdaExpression)childRewriter[2]) : expr);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0001F3BC File Offset: 0x0001D5BC
		private StackSpiller.Result RewriteVariableAssignment(BinaryExpression node, StackSpiller.Stack stack)
		{
			StackSpiller.Result result = this.RewriteExpression(node.Right, stack);
			if (result.Action != StackSpiller.RewriteAction.None)
			{
				node = new AssignBinaryExpression(node.Left, result.Node);
			}
			return new StackSpiller.Result(result.Action, node);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0001F400 File Offset: 0x0001D600
		private StackSpiller.Result RewriteAssignBinaryExpression(Expression expr, StackSpiller.Stack stack)
		{
			BinaryExpression binaryExpression = (BinaryExpression)expr;
			ExpressionType nodeType = binaryExpression.Left.NodeType;
			if (nodeType <= ExpressionType.Parameter)
			{
				if (nodeType == ExpressionType.MemberAccess)
				{
					return this.RewriteMemberAssignment(binaryExpression, stack);
				}
				if (nodeType == ExpressionType.Parameter)
				{
					return this.RewriteVariableAssignment(binaryExpression, stack);
				}
			}
			else
			{
				if (nodeType == ExpressionType.Extension)
				{
					return this.RewriteExtensionAssignment(binaryExpression, stack);
				}
				if (nodeType == ExpressionType.Index)
				{
					return this.RewriteIndexAssignment(binaryExpression, stack);
				}
			}
			throw Error.InvalidLvalue(binaryExpression.Left.NodeType);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0001F470 File Offset: 0x0001D670
		private StackSpiller.Result RewriteExtensionAssignment(BinaryExpression node, StackSpiller.Stack stack)
		{
			node = new AssignBinaryExpression(node.Left.ReduceExtensions(), node.Right);
			StackSpiller.Result result = this.RewriteAssignBinaryExpression(node, stack);
			return new StackSpiller.Result(result.Action | StackSpiller.RewriteAction.Copy, result.Node);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
		private static StackSpiller.Result RewriteLambdaExpression(Expression expr)
		{
			LambdaExpression lambdaExpression = (LambdaExpression)expr;
			expr = StackSpiller.AnalyzeLambda(lambdaExpression);
			return new StackSpiller.Result((expr == lambdaExpression) ? StackSpiller.RewriteAction.None : StackSpiller.RewriteAction.Copy, expr);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		private StackSpiller.Result RewriteConditionalExpression(Expression expr, StackSpiller.Stack stack)
		{
			ConditionalExpression conditionalExpression = (ConditionalExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(conditionalExpression.Test, stack);
			StackSpiller.Result result2 = this.RewriteExpression(conditionalExpression.IfTrue, stack);
			StackSpiller.Result result3 = this.RewriteExpression(conditionalExpression.IfFalse, stack);
			StackSpiller.RewriteAction rewriteAction = result.Action | result2.Action | result3.Action;
			if (rewriteAction != StackSpiller.RewriteAction.None)
			{
				expr = ConditionalExpression.Make(result.Node, result2.Node, result3.Node, conditionalExpression.Type);
			}
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0001F55C File Offset: 0x0001D75C
		private StackSpiller.Result RewriteMemberAssignment(BinaryExpression node, StackSpiller.Stack stack)
		{
			MemberExpression memberExpression = (MemberExpression)node.Left;
			StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, stack, 2);
			childRewriter.Add(memberExpression.Expression);
			childRewriter.Add(node.Right);
			if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
			{
				childRewriter.MarkRefInstance(memberExpression.Expression);
			}
			if (childRewriter.Rewrite)
			{
				return childRewriter.Finish(new AssignBinaryExpression(MemberExpression.Make(childRewriter[0], memberExpression.Member), childRewriter[1]));
			}
			return new StackSpiller.Result(StackSpiller.RewriteAction.None, node);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0001F5E0 File Offset: 0x0001D7E0
		private StackSpiller.Result RewriteMemberExpression(Expression expr, StackSpiller.Stack stack)
		{
			MemberExpression memberExpression = (MemberExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(memberExpression.Expression, stack);
			if (result.Action != StackSpiller.RewriteAction.None)
			{
				if (result.Action == StackSpiller.RewriteAction.SpillStack && memberExpression.Member is PropertyInfo)
				{
					StackSpiller.RequireNotRefInstance(memberExpression.Expression);
				}
				expr = MemberExpression.Make(result.Node, memberExpression.Member);
			}
			return new StackSpiller.Result(result.Action, expr);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0001F64C File Offset: 0x0001D84C
		private StackSpiller.Result RewriteIndexExpression(Expression expr, StackSpiller.Stack stack)
		{
			IndexExpression indexExpression = (IndexExpression)expr;
			StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, stack, indexExpression.ArgumentCount + 1);
			childRewriter.Add(indexExpression.Object);
			childRewriter.AddArguments(indexExpression);
			if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
			{
				childRewriter.MarkRefInstance(indexExpression.Object);
			}
			if (childRewriter.Rewrite)
			{
				expr = new IndexExpression(childRewriter[0], indexExpression.Indexer, childRewriter[1, -1]);
			}
			return childRewriter.Finish(expr);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		private StackSpiller.Result RewriteMethodCallExpression(Expression expr, StackSpiller.Stack stack)
		{
			MethodCallExpression methodCallExpression = (MethodCallExpression)expr;
			StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, stack, methodCallExpression.ArgumentCount + 1);
			childRewriter.Add(methodCallExpression.Object);
			childRewriter.AddArguments(methodCallExpression);
			if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
			{
				childRewriter.MarkRefInstance(methodCallExpression.Object);
				childRewriter.MarkRefArgs(methodCallExpression.Method, 1);
			}
			if (childRewriter.Rewrite)
			{
				if (methodCallExpression.Object != null)
				{
					expr = new InstanceMethodCallExpressionN(methodCallExpression.Method, childRewriter[0], childRewriter[1, -1]);
				}
				else
				{
					expr = new MethodCallExpressionN(methodCallExpression.Method, childRewriter[1, -1]);
				}
			}
			return childRewriter.Finish(expr);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0001F768 File Offset: 0x0001D968
		private StackSpiller.Result RewriteNewArrayExpression(Expression expr, StackSpiller.Stack stack)
		{
			NewArrayExpression newArrayExpression = (NewArrayExpression)expr;
			if (newArrayExpression.NodeType == ExpressionType.NewArrayInit)
			{
				stack = StackSpiller.Stack.NonEmpty;
			}
			StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, stack, newArrayExpression.Expressions.Count);
			childRewriter.Add(newArrayExpression.Expressions);
			if (childRewriter.Rewrite)
			{
				expr = NewArrayExpression.Make(newArrayExpression.NodeType, newArrayExpression.Type, new TrueReadOnlyCollection<Expression>(childRewriter[0, -1]));
			}
			return childRewriter.Finish(expr);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		private StackSpiller.Result RewriteInvocationExpression(Expression expr, StackSpiller.Stack stack)
		{
			InvocationExpression invocationExpression = (InvocationExpression)expr;
			LambdaExpression lambdaExpression = invocationExpression.LambdaOperand;
			StackSpiller.ChildRewriter childRewriter;
			if (lambdaExpression != null)
			{
				childRewriter = new StackSpiller.ChildRewriter(this, stack, invocationExpression.ArgumentCount);
				childRewriter.AddArguments(invocationExpression);
				if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
				{
					childRewriter.MarkRefArgs(Expression.GetInvokeMethod(invocationExpression.Expression), 0);
				}
				StackSpiller stackSpiller = new StackSpiller(stack);
				lambdaExpression = lambdaExpression.Accept(stackSpiller);
				if (childRewriter.Rewrite || stackSpiller._lambdaRewrite != StackSpiller.RewriteAction.None)
				{
					invocationExpression = new InvocationExpressionN(lambdaExpression, childRewriter[0, -1], invocationExpression.Type);
				}
				StackSpiller.Result result = childRewriter.Finish(invocationExpression);
				return new StackSpiller.Result(result.Action | stackSpiller._lambdaRewrite, result.Node);
			}
			childRewriter = new StackSpiller.ChildRewriter(this, stack, invocationExpression.ArgumentCount + 1);
			childRewriter.Add(invocationExpression.Expression);
			childRewriter.AddArguments(invocationExpression);
			if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
			{
				childRewriter.MarkRefArgs(Expression.GetInvokeMethod(invocationExpression.Expression), 1);
			}
			return childRewriter.Finish(childRewriter.Rewrite ? new InvocationExpressionN(childRewriter[0], childRewriter[1, -1], invocationExpression.Type) : expr);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0001F8EC File Offset: 0x0001DAEC
		private StackSpiller.Result RewriteNewExpression(Expression expr, StackSpiller.Stack stack)
		{
			NewExpression newExpression = (NewExpression)expr;
			StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, stack, newExpression.ArgumentCount);
			childRewriter.AddArguments(newExpression);
			if (childRewriter.Action == StackSpiller.RewriteAction.SpillStack)
			{
				childRewriter.MarkRefArgs(newExpression.Constructor, 0);
			}
			return childRewriter.Finish(childRewriter.Rewrite ? new NewExpression(newExpression.Constructor, childRewriter[0, -1], newExpression.Members) : expr);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0001F958 File Offset: 0x0001DB58
		private StackSpiller.Result RewriteTypeBinaryExpression(Expression expr, StackSpiller.Stack stack)
		{
			TypeBinaryExpression typeBinaryExpression = (TypeBinaryExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(typeBinaryExpression.Expression, stack);
			if (result.Action != StackSpiller.RewriteAction.None)
			{
				expr = new TypeBinaryExpression(result.Node, typeBinaryExpression.TypeOperand, typeBinaryExpression.NodeType);
			}
			return new StackSpiller.Result(result.Action, expr);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0001F9A8 File Offset: 0x0001DBA8
		private StackSpiller.Result RewriteThrowUnaryExpression(Expression expr, StackSpiller.Stack stack)
		{
			UnaryExpression unaryExpression = (UnaryExpression)expr;
			StackSpiller.Result result = this.RewriteExpressionFreeTemps(unaryExpression.Operand, StackSpiller.Stack.Empty);
			StackSpiller.RewriteAction rewriteAction = result.Action;
			if (stack != StackSpiller.Stack.Empty)
			{
				rewriteAction = StackSpiller.RewriteAction.SpillStack;
			}
			if (rewriteAction != StackSpiller.RewriteAction.None)
			{
				expr = new UnaryExpression(ExpressionType.Throw, result.Node, unaryExpression.Type, null);
			}
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		private StackSpiller.Result RewriteUnaryExpression(Expression expr, StackSpiller.Stack stack)
		{
			UnaryExpression unaryExpression = (UnaryExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(unaryExpression.Operand, stack);
			if (result.Action == StackSpiller.RewriteAction.SpillStack)
			{
				StackSpiller.RequireNoRefArgs(unaryExpression.Method);
			}
			if (result.Action != StackSpiller.RewriteAction.None)
			{
				expr = new UnaryExpression(unaryExpression.NodeType, result.Node, unaryExpression.Type, unaryExpression.Method);
			}
			return new StackSpiller.Result(result.Action, expr);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0001FA64 File Offset: 0x0001DC64
		private StackSpiller.Result RewriteListInitExpression(Expression expr, StackSpiller.Stack stack)
		{
			ListInitExpression listInitExpression = (ListInitExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(listInitExpression.NewExpression, stack);
			Expression node = result.Node;
			StackSpiller.RewriteAction rewriteAction = result.Action;
			ReadOnlyCollection<ElementInit> initializers = listInitExpression.Initializers;
			int count = initializers.Count;
			StackSpiller.ChildRewriter[] array = new StackSpiller.ChildRewriter[count];
			for (int i = 0; i < count; i++)
			{
				ElementInit elementInit = initializers[i];
				StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(this, StackSpiller.Stack.NonEmpty, elementInit.Arguments.Count);
				childRewriter.Add(elementInit.Arguments);
				rewriteAction |= childRewriter.Action;
				array[i] = childRewriter;
			}
			switch (rewriteAction)
			{
			case StackSpiller.RewriteAction.None:
				goto IL_1EA;
			case StackSpiller.RewriteAction.Copy:
			{
				ElementInit[] array2 = new ElementInit[count];
				for (int j = 0; j < count; j++)
				{
					StackSpiller.ChildRewriter childRewriter2 = array[j];
					if (childRewriter2.Action == StackSpiller.RewriteAction.None)
					{
						array2[j] = initializers[j];
					}
					else
					{
						array2[j] = new ElementInit(initializers[j].AddMethod, new TrueReadOnlyCollection<Expression>(childRewriter2[0, -1]));
					}
				}
				expr = new ListInitExpression((NewExpression)node, new TrueReadOnlyCollection<ElementInit>(array2));
				goto IL_1EA;
			}
			case StackSpiller.RewriteAction.SpillStack:
			{
				bool flag = StackSpiller.IsRefInstance(listInitExpression.NewExpression);
				ArrayBuilder<Expression> expressions = new ArrayBuilder<Expression>(count + 2 + (flag ? 1 : 0));
				ParameterExpression parameterExpression = this.MakeTemp(node.Type);
				expressions.UncheckedAdd(new AssignBinaryExpression(parameterExpression, node));
				ParameterExpression parameterExpression2 = parameterExpression;
				if (flag)
				{
					parameterExpression2 = this.MakeTemp(parameterExpression.Type.MakeByRefType());
					expressions.UncheckedAdd(new ByRefAssignBinaryExpression(parameterExpression2, parameterExpression));
				}
				for (int k = 0; k < count; k++)
				{
					StackSpiller.ChildRewriter childRewriter3 = array[k];
					StackSpiller.Result result2 = childRewriter3.Finish(new InstanceMethodCallExpressionN(initializers[k].AddMethod, parameterExpression2, childRewriter3[0, -1]));
					expressions.UncheckedAdd(result2.Node);
				}
				expressions.UncheckedAdd(parameterExpression);
				expr = StackSpiller.MakeBlock(expressions);
				goto IL_1EA;
			}
			}
			throw ContractUtils.Unreachable;
			IL_1EA:
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0001FC64 File Offset: 0x0001DE64
		private StackSpiller.Result RewriteMemberInitExpression(Expression expr, StackSpiller.Stack stack)
		{
			MemberInitExpression memberInitExpression = (MemberInitExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(memberInitExpression.NewExpression, stack);
			Expression node = result.Node;
			StackSpiller.RewriteAction rewriteAction = result.Action;
			ReadOnlyCollection<MemberBinding> bindings = memberInitExpression.Bindings;
			int count = bindings.Count;
			StackSpiller.BindingRewriter[] array = new StackSpiller.BindingRewriter[count];
			for (int i = 0; i < count; i++)
			{
				StackSpiller.BindingRewriter bindingRewriter = StackSpiller.BindingRewriter.Create(bindings[i], this, StackSpiller.Stack.NonEmpty);
				array[i] = bindingRewriter;
				rewriteAction |= bindingRewriter.Action;
			}
			switch (rewriteAction)
			{
			case StackSpiller.RewriteAction.None:
				goto IL_175;
			case StackSpiller.RewriteAction.Copy:
			{
				MemberBinding[] array2 = new MemberBinding[count];
				for (int j = 0; j < count; j++)
				{
					array2[j] = array[j].AsBinding();
				}
				expr = new MemberInitExpression((NewExpression)node, new TrueReadOnlyCollection<MemberBinding>(array2));
				goto IL_175;
			}
			case StackSpiller.RewriteAction.SpillStack:
			{
				bool flag = StackSpiller.IsRefInstance(memberInitExpression.NewExpression);
				ArrayBuilder<Expression> expressions = new ArrayBuilder<Expression>(count + 2 + (flag ? 1 : 0));
				ParameterExpression parameterExpression = this.MakeTemp(node.Type);
				expressions.UncheckedAdd(new AssignBinaryExpression(parameterExpression, node));
				ParameterExpression parameterExpression2 = parameterExpression;
				if (flag)
				{
					parameterExpression2 = this.MakeTemp(parameterExpression.Type.MakeByRefType());
					expressions.UncheckedAdd(new ByRefAssignBinaryExpression(parameterExpression2, parameterExpression));
				}
				for (int k = 0; k < count; k++)
				{
					Expression item = array[k].AsExpression(parameterExpression2);
					expressions.UncheckedAdd(item);
				}
				expressions.UncheckedAdd(parameterExpression);
				expr = StackSpiller.MakeBlock(expressions);
				goto IL_175;
			}
			}
			throw ContractUtils.Unreachable;
			IL_175:
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0001FDF0 File Offset: 0x0001DFF0
		private StackSpiller.Result RewriteBlockExpression(Expression expr, StackSpiller.Stack stack)
		{
			BlockExpression blockExpression = (BlockExpression)expr;
			int expressionCount = blockExpression.ExpressionCount;
			StackSpiller.RewriteAction rewriteAction = StackSpiller.RewriteAction.None;
			Expression[] array = null;
			for (int i = 0; i < expressionCount; i++)
			{
				Expression expression = blockExpression.GetExpression(i);
				StackSpiller.Result result = this.RewriteExpression(expression, stack);
				rewriteAction |= result.Action;
				if (array == null && result.Action != StackSpiller.RewriteAction.None)
				{
					array = StackSpiller.Clone<Expression>(blockExpression.Expressions, i);
				}
				if (array != null)
				{
					array[i] = result.Node;
				}
			}
			if (rewriteAction != StackSpiller.RewriteAction.None)
			{
				expr = blockExpression.Rewrite(null, array);
			}
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0001FE7C File Offset: 0x0001E07C
		private StackSpiller.Result RewriteLabelExpression(Expression expr, StackSpiller.Stack stack)
		{
			LabelExpression labelExpression = (LabelExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(labelExpression.DefaultValue, stack);
			if (result.Action != StackSpiller.RewriteAction.None)
			{
				expr = new LabelExpression(labelExpression.Target, result.Node);
			}
			return new StackSpiller.Result(result.Action, expr);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
		private StackSpiller.Result RewriteLoopExpression(Expression expr, StackSpiller.Stack stack)
		{
			LoopExpression loopExpression = (LoopExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(loopExpression.Body, StackSpiller.Stack.Empty);
			StackSpiller.RewriteAction rewriteAction = result.Action;
			if (stack != StackSpiller.Stack.Empty)
			{
				rewriteAction = StackSpiller.RewriteAction.SpillStack;
			}
			if (rewriteAction != StackSpiller.RewriteAction.None)
			{
				expr = new LoopExpression(result.Node, loopExpression.BreakLabel, loopExpression.ContinueLabel);
			}
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001FF1C File Offset: 0x0001E11C
		private StackSpiller.Result RewriteGotoExpression(Expression expr, StackSpiller.Stack stack)
		{
			GotoExpression gotoExpression = (GotoExpression)expr;
			StackSpiller.Result result = this.RewriteExpressionFreeTemps(gotoExpression.Value, StackSpiller.Stack.Empty);
			StackSpiller.RewriteAction rewriteAction = result.Action;
			if (stack != StackSpiller.Stack.Empty)
			{
				rewriteAction = StackSpiller.RewriteAction.SpillStack;
			}
			if (rewriteAction != StackSpiller.RewriteAction.None)
			{
				expr = Expression.MakeGoto(gotoExpression.Kind, gotoExpression.Target, result.Node, gotoExpression.Type);
			}
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0001FF74 File Offset: 0x0001E174
		private StackSpiller.Result RewriteSwitchExpression(Expression expr, StackSpiller.Stack stack)
		{
			SwitchExpression switchExpression = (SwitchExpression)expr;
			StackSpiller.Result result = this.RewriteExpressionFreeTemps(switchExpression.SwitchValue, stack);
			StackSpiller.RewriteAction rewriteAction = result.Action;
			ReadOnlyCollection<SwitchCase> readOnlyCollection = switchExpression.Cases;
			SwitchCase[] array = null;
			for (int i = 0; i < readOnlyCollection.Count; i++)
			{
				SwitchCase switchCase = readOnlyCollection[i];
				Expression[] array2 = null;
				ReadOnlyCollection<Expression> readOnlyCollection2 = switchCase.TestValues;
				for (int j = 0; j < readOnlyCollection2.Count; j++)
				{
					StackSpiller.Result result2 = this.RewriteExpression(readOnlyCollection2[j], stack);
					rewriteAction |= result2.Action;
					if (array2 == null && result2.Action != StackSpiller.RewriteAction.None)
					{
						array2 = StackSpiller.Clone<Expression>(readOnlyCollection2, j);
					}
					if (array2 != null)
					{
						array2[j] = result2.Node;
					}
				}
				StackSpiller.Result result3 = this.RewriteExpression(switchCase.Body, stack);
				rewriteAction |= result3.Action;
				if (result3.Action != StackSpiller.RewriteAction.None || array2 != null)
				{
					if (array2 != null)
					{
						readOnlyCollection2 = new ReadOnlyCollection<Expression>(array2);
					}
					switchCase = new SwitchCase(result3.Node, readOnlyCollection2);
					if (array == null)
					{
						array = StackSpiller.Clone<SwitchCase>(readOnlyCollection, i);
					}
				}
				if (array != null)
				{
					array[i] = switchCase;
				}
			}
			StackSpiller.Result result4 = this.RewriteExpression(switchExpression.DefaultBody, stack);
			rewriteAction |= result4.Action;
			if (rewriteAction != StackSpiller.RewriteAction.None)
			{
				if (array != null)
				{
					readOnlyCollection = new ReadOnlyCollection<SwitchCase>(array);
				}
				expr = new SwitchExpression(switchExpression.Type, result.Node, result4.Node, switchExpression.Comparison, readOnlyCollection);
			}
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000200E0 File Offset: 0x0001E2E0
		private StackSpiller.Result RewriteTryExpression(Expression expr, StackSpiller.Stack stack)
		{
			TryExpression tryExpression = (TryExpression)expr;
			StackSpiller.Result result = this.RewriteExpression(tryExpression.Body, StackSpiller.Stack.Empty);
			ReadOnlyCollection<CatchBlock> readOnlyCollection = tryExpression.Handlers;
			CatchBlock[] array = null;
			StackSpiller.RewriteAction rewriteAction = result.Action;
			if (readOnlyCollection != null)
			{
				for (int i = 0; i < readOnlyCollection.Count; i++)
				{
					StackSpiller.RewriteAction rewriteAction2 = result.Action;
					CatchBlock catchBlock = readOnlyCollection[i];
					Expression filter = catchBlock.Filter;
					if (catchBlock.Filter != null)
					{
						StackSpiller.Result result2 = this.RewriteExpression(catchBlock.Filter, StackSpiller.Stack.Empty);
						rewriteAction |= result2.Action;
						rewriteAction2 |= result2.Action;
						filter = result2.Node;
					}
					StackSpiller.Result result3 = this.RewriteExpression(catchBlock.Body, StackSpiller.Stack.Empty);
					rewriteAction |= result3.Action;
					rewriteAction2 |= result3.Action;
					if (rewriteAction2 != StackSpiller.RewriteAction.None)
					{
						catchBlock = Expression.MakeCatchBlock(catchBlock.Test, catchBlock.Variable, result3.Node, filter);
						if (array == null)
						{
							array = StackSpiller.Clone<CatchBlock>(readOnlyCollection, i);
						}
					}
					if (array != null)
					{
						array[i] = catchBlock;
					}
				}
			}
			StackSpiller.Result result4 = this.RewriteExpression(tryExpression.Fault, StackSpiller.Stack.Empty);
			rewriteAction |= result4.Action;
			StackSpiller.Result result5 = this.RewriteExpression(tryExpression.Finally, StackSpiller.Stack.Empty);
			rewriteAction |= result5.Action;
			if (stack != StackSpiller.Stack.Empty)
			{
				rewriteAction = StackSpiller.RewriteAction.SpillStack;
			}
			if (rewriteAction != StackSpiller.RewriteAction.None)
			{
				if (array != null)
				{
					readOnlyCollection = new ReadOnlyCollection<CatchBlock>(array);
				}
				expr = new TryExpression(tryExpression.Type, result.Node, result5.Node, result4.Node, readOnlyCollection);
			}
			return new StackSpiller.Result(rewriteAction, expr);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0002025C File Offset: 0x0001E45C
		private StackSpiller.Result RewriteExtensionExpression(Expression expr, StackSpiller.Stack stack)
		{
			StackSpiller.Result result = this.RewriteExpression(expr.ReduceExtensions(), stack);
			return new StackSpiller.Result(result.Action | StackSpiller.RewriteAction.Copy, result.Node);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0002028C File Offset: 0x0001E48C
		private static T[] Clone<T>(ReadOnlyCollection<T> original, int max)
		{
			T[] array = new T[original.Count];
			for (int i = 0; i < max; i++)
			{
				array[i] = original[i];
			}
			return array;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000202C0 File Offset: 0x0001E4C0
		private static void RequireNoRefArgs(MethodBase method)
		{
			if (method != null)
			{
				if (method.GetParametersCached().Any((ParameterInfo p) => p.ParameterType.IsByRef))
				{
					throw Error.TryNotSupportedForMethodsWithRefArgs(method);
				}
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000202FE File Offset: 0x0001E4FE
		private static void RequireNotRefInstance(Expression instance)
		{
			if (StackSpiller.IsRefInstance(instance))
			{
				throw Error.TryNotSupportedForValueTypeInstances(instance.Type);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00020314 File Offset: 0x0001E514
		private static bool IsRefInstance(Expression instance)
		{
			return instance != null && instance.Type.IsValueType && instance.Type.GetTypeCode() == TypeCode.Object;
		}

		// Token: 0x0400025E RID: 606
		private readonly StackGuard _guard = new StackGuard();

		// Token: 0x0400025F RID: 607
		private readonly StackSpiller.TempMaker _tm = new StackSpiller.TempMaker();

		// Token: 0x04000260 RID: 608
		private readonly StackSpiller.Stack _startingStack;

		// Token: 0x04000261 RID: 609
		private StackSpiller.RewriteAction _lambdaRewrite;

		// Token: 0x020000F1 RID: 241
		private abstract class BindingRewriter
		{
			// Token: 0x0600084C RID: 2124 RVA: 0x00020336 File Offset: 0x0001E536
			internal BindingRewriter(MemberBinding binding, StackSpiller spiller)
			{
				this._binding = binding;
				this._spiller = spiller;
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x0600084D RID: 2125 RVA: 0x0002034C File Offset: 0x0001E54C
			internal StackSpiller.RewriteAction Action
			{
				get
				{
					return this._action;
				}
			}

			// Token: 0x0600084E RID: 2126
			internal abstract MemberBinding AsBinding();

			// Token: 0x0600084F RID: 2127
			internal abstract Expression AsExpression(Expression target);

			// Token: 0x06000850 RID: 2128 RVA: 0x00020354 File Offset: 0x0001E554
			internal static StackSpiller.BindingRewriter Create(MemberBinding binding, StackSpiller spiller, StackSpiller.Stack stack)
			{
				switch (binding.BindingType)
				{
				case MemberBindingType.Assignment:
					return new StackSpiller.MemberAssignmentRewriter((MemberAssignment)binding, spiller, stack);
				case MemberBindingType.MemberBinding:
					return new StackSpiller.MemberMemberBindingRewriter((MemberMemberBinding)binding, spiller, stack);
				case MemberBindingType.ListBinding:
					return new StackSpiller.ListBindingRewriter((MemberListBinding)binding, spiller, stack);
				default:
					throw Error.UnhandledBinding();
				}
			}

			// Token: 0x06000851 RID: 2129 RVA: 0x000203AC File Offset: 0x0001E5AC
			protected void RequireNoValueProperty()
			{
				PropertyInfo propertyInfo = this._binding.Member as PropertyInfo;
				if (propertyInfo != null && propertyInfo.PropertyType.IsValueType)
				{
					throw Error.CannotAutoInitializeValueTypeMemberThroughProperty(propertyInfo);
				}
			}

			// Token: 0x04000262 RID: 610
			protected readonly MemberBinding _binding;

			// Token: 0x04000263 RID: 611
			protected readonly StackSpiller _spiller;

			// Token: 0x04000264 RID: 612
			protected StackSpiller.RewriteAction _action;
		}

		// Token: 0x020000F2 RID: 242
		private sealed class MemberMemberBindingRewriter : StackSpiller.BindingRewriter
		{
			// Token: 0x06000852 RID: 2130 RVA: 0x000203E8 File Offset: 0x0001E5E8
			internal MemberMemberBindingRewriter(MemberMemberBinding binding, StackSpiller spiller, StackSpiller.Stack stack) : base(binding, spiller)
			{
				this._bindings = binding.Bindings;
				int count = this._bindings.Count;
				this._bindingRewriters = new StackSpiller.BindingRewriter[count];
				for (int i = 0; i < count; i++)
				{
					StackSpiller.BindingRewriter bindingRewriter = StackSpiller.BindingRewriter.Create(this._bindings[i], spiller, stack);
					this._action |= bindingRewriter.Action;
					this._bindingRewriters[i] = bindingRewriter;
				}
			}

			// Token: 0x06000853 RID: 2131 RVA: 0x00020460 File Offset: 0x0001E660
			internal override MemberBinding AsBinding()
			{
				StackSpiller.RewriteAction action = this._action;
				if (action == StackSpiller.RewriteAction.None)
				{
					return this._binding;
				}
				if (action != StackSpiller.RewriteAction.Copy)
				{
					throw ContractUtils.Unreachable;
				}
				int count = this._bindings.Count;
				MemberBinding[] array = new MemberBinding[count];
				for (int i = 0; i < count; i++)
				{
					array[i] = this._bindingRewriters[i].AsBinding();
				}
				return new MemberMemberBinding(this._binding.Member, new TrueReadOnlyCollection<MemberBinding>(array));
			}

			// Token: 0x06000854 RID: 2132 RVA: 0x000204D0 File Offset: 0x0001E6D0
			internal override Expression AsExpression(Expression target)
			{
				base.RequireNoValueProperty();
				Expression expression = MemberExpression.Make(target, this._binding.Member);
				Expression expression2 = this._spiller.MakeTemp(expression.Type);
				int count = this._bindings.Count;
				Expression[] array = new Expression[count + 2];
				array[0] = new AssignBinaryExpression(expression2, expression);
				for (int i = 0; i < count; i++)
				{
					StackSpiller.BindingRewriter bindingRewriter = this._bindingRewriters[i];
					array[i + 1] = bindingRewriter.AsExpression(expression2);
				}
				if (expression2.Type.IsValueType)
				{
					array[count + 1] = Expression.Block(typeof(void), new Expression[]
					{
						new AssignBinaryExpression(MemberExpression.Make(target, this._binding.Member), expression2)
					});
				}
				else
				{
					array[count + 1] = Utils.Empty;
				}
				return StackSpiller.MakeBlock(array);
			}

			// Token: 0x04000265 RID: 613
			private readonly ReadOnlyCollection<MemberBinding> _bindings;

			// Token: 0x04000266 RID: 614
			private readonly StackSpiller.BindingRewriter[] _bindingRewriters;
		}

		// Token: 0x020000F3 RID: 243
		private sealed class ListBindingRewriter : StackSpiller.BindingRewriter
		{
			// Token: 0x06000855 RID: 2133 RVA: 0x000205A4 File Offset: 0x0001E7A4
			internal ListBindingRewriter(MemberListBinding binding, StackSpiller spiller, StackSpiller.Stack stack) : base(binding, spiller)
			{
				this._inits = binding.Initializers;
				int count = this._inits.Count;
				this._childRewriters = new StackSpiller.ChildRewriter[count];
				for (int i = 0; i < count; i++)
				{
					ElementInit elementInit = this._inits[i];
					StackSpiller.ChildRewriter childRewriter = new StackSpiller.ChildRewriter(spiller, stack, elementInit.Arguments.Count);
					childRewriter.Add(elementInit.Arguments);
					this._action |= childRewriter.Action;
					this._childRewriters[i] = childRewriter;
				}
			}

			// Token: 0x06000856 RID: 2134 RVA: 0x00020634 File Offset: 0x0001E834
			internal override MemberBinding AsBinding()
			{
				StackSpiller.RewriteAction action = this._action;
				if (action == StackSpiller.RewriteAction.None)
				{
					return this._binding;
				}
				if (action != StackSpiller.RewriteAction.Copy)
				{
					throw ContractUtils.Unreachable;
				}
				int count = this._inits.Count;
				ElementInit[] array = new ElementInit[count];
				for (int i = 0; i < count; i++)
				{
					StackSpiller.ChildRewriter childRewriter = this._childRewriters[i];
					if (childRewriter.Action == StackSpiller.RewriteAction.None)
					{
						array[i] = this._inits[i];
					}
					else
					{
						array[i] = new ElementInit(this._inits[i].AddMethod, new TrueReadOnlyCollection<Expression>(childRewriter[0, -1]));
					}
				}
				return new MemberListBinding(this._binding.Member, new TrueReadOnlyCollection<ElementInit>(array));
			}

			// Token: 0x06000857 RID: 2135 RVA: 0x000206E4 File Offset: 0x0001E8E4
			internal override Expression AsExpression(Expression target)
			{
				base.RequireNoValueProperty();
				Expression expression = MemberExpression.Make(target, this._binding.Member);
				Expression expression2 = this._spiller.MakeTemp(expression.Type);
				int count = this._inits.Count;
				Expression[] array = new Expression[count + 2];
				array[0] = new AssignBinaryExpression(expression2, expression);
				for (int i = 0; i < count; i++)
				{
					StackSpiller.ChildRewriter childRewriter = this._childRewriters[i];
					StackSpiller.Result result = childRewriter.Finish(new InstanceMethodCallExpressionN(this._inits[i].AddMethod, expression2, childRewriter[0, -1]));
					array[i + 1] = result.Node;
				}
				if (expression2.Type.IsValueType)
				{
					array[count + 1] = Expression.Block(typeof(void), new Expression[]
					{
						new AssignBinaryExpression(MemberExpression.Make(target, this._binding.Member), expression2)
					});
				}
				else
				{
					array[count + 1] = Utils.Empty;
				}
				return StackSpiller.MakeBlock(array);
			}

			// Token: 0x04000267 RID: 615
			private readonly ReadOnlyCollection<ElementInit> _inits;

			// Token: 0x04000268 RID: 616
			private readonly StackSpiller.ChildRewriter[] _childRewriters;
		}

		// Token: 0x020000F4 RID: 244
		private sealed class MemberAssignmentRewriter : StackSpiller.BindingRewriter
		{
			// Token: 0x06000858 RID: 2136 RVA: 0x000207E0 File Offset: 0x0001E9E0
			internal MemberAssignmentRewriter(MemberAssignment binding, StackSpiller spiller, StackSpiller.Stack stack) : base(binding, spiller)
			{
				StackSpiller.Result result = spiller.RewriteExpression(binding.Expression, stack);
				this._action = result.Action;
				this._rhs = result.Node;
			}

			// Token: 0x06000859 RID: 2137 RVA: 0x0002081C File Offset: 0x0001EA1C
			internal override MemberBinding AsBinding()
			{
				StackSpiller.RewriteAction action = this._action;
				if (action == StackSpiller.RewriteAction.None)
				{
					return this._binding;
				}
				if (action != StackSpiller.RewriteAction.Copy)
				{
					throw ContractUtils.Unreachable;
				}
				return new MemberAssignment(this._binding.Member, this._rhs);
			}

			// Token: 0x0600085A RID: 2138 RVA: 0x0002085C File Offset: 0x0001EA5C
			internal override Expression AsExpression(Expression target)
			{
				Expression expression = MemberExpression.Make(target, this._binding.Member);
				Expression expression2 = this._spiller.MakeTemp(expression.Type);
				return StackSpiller.MakeBlock(new Expression[]
				{
					new AssignBinaryExpression(expression2, this._rhs),
					new AssignBinaryExpression(expression, expression2),
					Utils.Empty
				});
			}

			// Token: 0x04000269 RID: 617
			private readonly Expression _rhs;
		}

		// Token: 0x020000F5 RID: 245
		private sealed class ChildRewriter
		{
			// Token: 0x0600085B RID: 2139 RVA: 0x000208B9 File Offset: 0x0001EAB9
			internal ChildRewriter(StackSpiller self, StackSpiller.Stack stack, int count)
			{
				this._self = self;
				this._stack = stack;
				this._expressions = new Expression[count];
			}

			// Token: 0x0600085C RID: 2140 RVA: 0x000208DC File Offset: 0x0001EADC
			internal void Add(Expression expression)
			{
				int expressionsCount;
				if (expression == null)
				{
					Expression[] expressions = this._expressions;
					expressionsCount = this._expressionsCount;
					this._expressionsCount = expressionsCount + 1;
					expressions[expressionsCount] = null;
					return;
				}
				StackSpiller.Result result = this._self.RewriteExpression(expression, this._stack);
				this._action |= result.Action;
				this._stack = StackSpiller.Stack.NonEmpty;
				if (result.Action == StackSpiller.RewriteAction.SpillStack)
				{
					this._lastSpillIndex = this._expressionsCount;
				}
				Expression[] expressions2 = this._expressions;
				expressionsCount = this._expressionsCount;
				this._expressionsCount = expressionsCount + 1;
				expressions2[expressionsCount] = result.Node;
			}

			// Token: 0x0600085D RID: 2141 RVA: 0x00020968 File Offset: 0x0001EB68
			internal void Add(ReadOnlyCollection<Expression> expressions)
			{
				int i = 0;
				int count = expressions.Count;
				while (i < count)
				{
					this.Add(expressions[i]);
					i++;
				}
			}

			// Token: 0x0600085E RID: 2142 RVA: 0x00020998 File Offset: 0x0001EB98
			internal void AddArguments(IArgumentProvider expressions)
			{
				int i = 0;
				int argumentCount = expressions.ArgumentCount;
				while (i < argumentCount)
				{
					this.Add(expressions.GetArgument(i));
					i++;
				}
			}

			// Token: 0x0600085F RID: 2143 RVA: 0x000209C8 File Offset: 0x0001EBC8
			private void EnsureDone()
			{
				if (!this._done)
				{
					this._done = true;
					if (this._action == StackSpiller.RewriteAction.SpillStack)
					{
						Expression[] expressions = this._expressions;
						int num = this._lastSpillIndex + 1;
						List<Expression> list = new List<Expression>(num + 1);
						for (int i = 0; i < num; i++)
						{
							Expression expression = expressions[i];
							if (StackSpiller.ChildRewriter.ShouldSaveToTemp(expression))
							{
								Expression[] array = expressions;
								int num2 = i;
								StackSpiller self = this._self;
								Expression expression2 = expression;
								bool[] byRefs = this._byRefs;
								Expression item;
								array[num2] = self.ToTemp(expression2, out item, byRefs != null && byRefs[i]);
								list.Add(item);
							}
						}
						list.Capacity = list.Count + 1;
						this._comma = list;
					}
				}
			}

			// Token: 0x06000860 RID: 2144 RVA: 0x00020A64 File Offset: 0x0001EC64
			private static bool ShouldSaveToTemp(Expression expression)
			{
				if (expression == null)
				{
					return false;
				}
				ExpressionType nodeType = expression.NodeType;
				if (nodeType <= ExpressionType.MemberAccess)
				{
					if (nodeType != ExpressionType.Constant)
					{
						if (nodeType != ExpressionType.MemberAccess)
						{
							return true;
						}
						FieldInfo fieldInfo = ((MemberExpression)expression).Member as FieldInfo;
						if (!(fieldInfo != null))
						{
							return true;
						}
						if (fieldInfo.IsLiteral)
						{
							return false;
						}
						if (fieldInfo.IsInitOnly && fieldInfo.IsStatic)
						{
							return false;
						}
						return true;
					}
				}
				else if (nodeType != ExpressionType.Default)
				{
					if (nodeType != ExpressionType.RuntimeVariables)
					{
						return true;
					}
					return false;
				}
				return false;
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000861 RID: 2145 RVA: 0x00020AD5 File Offset: 0x0001ECD5
			internal bool Rewrite
			{
				get
				{
					return this._action > StackSpiller.RewriteAction.None;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x06000862 RID: 2146 RVA: 0x00020AE0 File Offset: 0x0001ECE0
			internal StackSpiller.RewriteAction Action
			{
				get
				{
					return this._action;
				}
			}

			// Token: 0x06000863 RID: 2147 RVA: 0x00020AE8 File Offset: 0x0001ECE8
			internal void MarkRefInstance(Expression expr)
			{
				if (StackSpiller.IsRefInstance(expr))
				{
					this.MarkRef(0);
				}
			}

			// Token: 0x06000864 RID: 2148 RVA: 0x00020AFC File Offset: 0x0001ECFC
			internal void MarkRefArgs(MethodBase method, int startIndex)
			{
				ParameterInfo[] parametersCached = method.GetParametersCached();
				int i = 0;
				int num = parametersCached.Length;
				while (i < num)
				{
					if (parametersCached[i].ParameterType.IsByRef)
					{
						this.MarkRef(startIndex + i);
					}
					i++;
				}
			}

			// Token: 0x06000865 RID: 2149 RVA: 0x00020B38 File Offset: 0x0001ED38
			private void MarkRef(int index)
			{
				if (this._byRefs == null)
				{
					this._byRefs = new bool[this._expressions.Length];
				}
				this._byRefs[index] = true;
			}

			// Token: 0x06000866 RID: 2150 RVA: 0x00020B5E File Offset: 0x0001ED5E
			internal StackSpiller.Result Finish(Expression expression)
			{
				this.EnsureDone();
				if (this._action == StackSpiller.RewriteAction.SpillStack)
				{
					this._comma.Add(expression);
					expression = StackSpiller.MakeBlock(this._comma);
				}
				return new StackSpiller.Result(this._action, expression);
			}

			// Token: 0x17000175 RID: 373
			internal Expression this[int index]
			{
				get
				{
					this.EnsureDone();
					if (index < 0)
					{
						index += this._expressions.Length;
					}
					return this._expressions[index];
				}
			}

			// Token: 0x17000176 RID: 374
			internal Expression[] this[int first, int last]
			{
				get
				{
					this.EnsureDone();
					if (last < 0)
					{
						last += this._expressions.Length;
					}
					int num = last - first + 1;
					ContractUtils.RequiresArrayRange<Expression>(this._expressions, first, num, "first", "last");
					if (num == this._expressions.Length)
					{
						return this._expressions;
					}
					Expression[] array = new Expression[num];
					Array.Copy(this._expressions, first, array, 0, num);
					return array;
				}
			}

			// Token: 0x0400026A RID: 618
			private readonly StackSpiller _self;

			// Token: 0x0400026B RID: 619
			private readonly Expression[] _expressions;

			// Token: 0x0400026C RID: 620
			private int _expressionsCount;

			// Token: 0x0400026D RID: 621
			private int _lastSpillIndex;

			// Token: 0x0400026E RID: 622
			private List<Expression> _comma;

			// Token: 0x0400026F RID: 623
			private StackSpiller.RewriteAction _action;

			// Token: 0x04000270 RID: 624
			private StackSpiller.Stack _stack;

			// Token: 0x04000271 RID: 625
			private bool _done;

			// Token: 0x04000272 RID: 626
			private bool[] _byRefs;
		}

		// Token: 0x020000F6 RID: 246
		private sealed class TempMaker
		{
			// Token: 0x17000177 RID: 375
			// (get) Token: 0x06000869 RID: 2153 RVA: 0x00020C1D File Offset: 0x0001EE1D
			internal List<ParameterExpression> Temps { get; } = new List<ParameterExpression>();

			// Token: 0x0600086A RID: 2154 RVA: 0x00020C28 File Offset: 0x0001EE28
			internal ParameterExpression Temp(Type type)
			{
				ParameterExpression parameterExpression;
				if (this._freeTemps != null)
				{
					for (int i = this._freeTemps.Count - 1; i >= 0; i--)
					{
						parameterExpression = this._freeTemps[i];
						if (parameterExpression.Type == type)
						{
							this._freeTemps.RemoveAt(i);
							return this.UseTemp(parameterExpression);
						}
					}
				}
				string str = "$temp$";
				int temp = this._temp;
				this._temp = temp + 1;
				parameterExpression = ParameterExpression.Make(type, str + temp.ToString(), false);
				this.Temps.Add(parameterExpression);
				return this.UseTemp(parameterExpression);
			}

			// Token: 0x0600086B RID: 2155 RVA: 0x00020CC0 File Offset: 0x0001EEC0
			private ParameterExpression UseTemp(ParameterExpression temp)
			{
				if (this._usedTemps == null)
				{
					this._usedTemps = new Stack<ParameterExpression>();
				}
				this._usedTemps.Push(temp);
				return temp;
			}

			// Token: 0x0600086C RID: 2156 RVA: 0x00020CE2 File Offset: 0x0001EEE2
			private void FreeTemp(ParameterExpression temp)
			{
				if (this._freeTemps == null)
				{
					this._freeTemps = new List<ParameterExpression>();
				}
				this._freeTemps.Add(temp);
			}

			// Token: 0x0600086D RID: 2157 RVA: 0x00020D03 File Offset: 0x0001EF03
			internal int Mark()
			{
				Stack<ParameterExpression> usedTemps = this._usedTemps;
				if (usedTemps == null)
				{
					return 0;
				}
				return usedTemps.Count;
			}

			// Token: 0x0600086E RID: 2158 RVA: 0x00020D16 File Offset: 0x0001EF16
			internal void Free(int mark)
			{
				if (this._usedTemps != null)
				{
					while (mark < this._usedTemps.Count)
					{
						this.FreeTemp(this._usedTemps.Pop());
					}
				}
			}

			// Token: 0x04000273 RID: 627
			private int _temp;

			// Token: 0x04000274 RID: 628
			private List<ParameterExpression> _freeTemps;

			// Token: 0x04000275 RID: 629
			private Stack<ParameterExpression> _usedTemps;
		}

		// Token: 0x020000F7 RID: 247
		private enum Stack
		{
			// Token: 0x04000278 RID: 632
			Empty,
			// Token: 0x04000279 RID: 633
			NonEmpty
		}

		// Token: 0x020000F8 RID: 248
		[Flags]
		private enum RewriteAction
		{
			// Token: 0x0400027B RID: 635
			None = 0,
			// Token: 0x0400027C RID: 636
			Copy = 1,
			// Token: 0x0400027D RID: 637
			SpillStack = 3
		}

		// Token: 0x020000F9 RID: 249
		private readonly struct Result
		{
			// Token: 0x06000870 RID: 2160 RVA: 0x00020D54 File Offset: 0x0001EF54
			internal Result(StackSpiller.RewriteAction action, Expression node)
			{
				this.Action = action;
				this.Node = node;
			}

			// Token: 0x0400027E RID: 638
			internal readonly StackSpiller.RewriteAction Action;

			// Token: 0x0400027F RID: 639
			internal readonly Expression Node;
		}
	}
}
