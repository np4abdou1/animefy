using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	/// <summary>Represents a visitor or rewriter for expression trees.</summary>
	// Token: 0x0200008A RID: 138
	public abstract class ExpressionVisitor
	{
		/// <summary>Dispatches the expression to one of the more specialized visit methods in this class.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000473 RID: 1139 RVA: 0x00011B12 File Offset: 0x0000FD12
		public virtual Expression Visit(Expression node)
		{
			if (node == null)
			{
				return null;
			}
			return node.Accept(this);
		}

		/// <summary>Dispatches the list of expressions to one of the more specialized visit methods in this class.</summary>
		/// <param name="nodes">The expressions to visit.</param>
		/// <returns>The modified expression list, if any one of the elements were modified; otherwise, returns the original expression list.</returns>
		// Token: 0x06000474 RID: 1140 RVA: 0x00011B20 File Offset: 0x0000FD20
		public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
		{
			ContractUtils.RequiresNotNull(nodes, "nodes");
			Expression[] array = null;
			int i = 0;
			int count = nodes.Count;
			while (i < count)
			{
				Expression expression = this.Visit(nodes[i]);
				if (array != null)
				{
					array[i] = expression;
				}
				else if (expression != nodes[i])
				{
					array = new Expression[count];
					for (int j = 0; j < i; j++)
					{
						array[j] = nodes[j];
					}
					array[i] = expression;
				}
				i++;
			}
			if (array == null)
			{
				return nodes;
			}
			return new TrueReadOnlyCollection<Expression>(array);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00011BA0 File Offset: 0x0000FDA0
		private Expression[] VisitArguments(IArgumentProvider nodes)
		{
			return ExpressionVisitorUtils.VisitArguments(this, nodes);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00011BA9 File Offset: 0x0000FDA9
		private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName)
		{
			return ExpressionVisitorUtils.VisitParameters(this, nodes, callerName);
		}

		/// <summary>Visits all nodes in the collection using a specified element visitor.</summary>
		/// <param name="nodes">The nodes to visit.</param>
		/// <param name="elementVisitor">A delegate that visits a single element, optionally replacing it with a new element.</param>
		/// <typeparam name="T">The type of the nodes.</typeparam>
		/// <returns>The modified node list, if any of the elements were modified; otherwise, returns the original node list.</returns>
		// Token: 0x06000477 RID: 1143 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
		{
			ContractUtils.RequiresNotNull(nodes, "nodes");
			ContractUtils.RequiresNotNull(elementVisitor, "elementVisitor");
			T[] array = null;
			int i = 0;
			int count = nodes.Count;
			while (i < count)
			{
				T t = elementVisitor(nodes[i]);
				if (array != null)
				{
					array[i] = t;
				}
				else if (t != nodes[i])
				{
					array = new T[count];
					for (int j = 0; j < i; j++)
					{
						array[j] = nodes[j];
					}
					array[i] = t;
				}
				i++;
			}
			if (array == null)
			{
				return nodes;
			}
			return new TrueReadOnlyCollection<T>(array);
		}

		/// <summary>Visits an expression, casting the result back to the original expression type.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <param name="callerName">The name of the calling method; used to report to report a better error message.</param>
		/// <typeparam name="T">The type of the expression.</typeparam>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		/// <exception cref="T:System.InvalidOperationException">The visit method for this node returned a different type.</exception>
		// Token: 0x06000478 RID: 1144 RVA: 0x00011C58 File Offset: 0x0000FE58
		public T VisitAndConvert<T>(T node, string callerName) where T : Expression
		{
			if (node == null)
			{
				return default(T);
			}
			node = (this.Visit(node) as T);
			if (node == null)
			{
				throw Error.MustRewriteToSameNode(callerName, typeof(T), callerName);
			}
			return node;
		}

		/// <summary>Visits an expression, casting the result back to the original expression type.</summary>
		/// <param name="nodes">The expression to visit.</param>
		/// <param name="callerName">The name of the calling method; used to report to report a better error message.</param>
		/// <typeparam name="T">The type of the expression.</typeparam>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		/// <exception cref="T:System.InvalidOperationException">The visit method for this node returned a different type.</exception>
		// Token: 0x06000479 RID: 1145 RVA: 0x00011CAC File Offset: 0x0000FEAC
		public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
		{
			ContractUtils.RequiresNotNull(nodes, "nodes");
			T[] array = null;
			int i = 0;
			int count = nodes.Count;
			while (i < count)
			{
				T t = this.Visit(nodes[i]) as T;
				if (t == null)
				{
					throw Error.MustRewriteToSameNode(callerName, typeof(T), callerName);
				}
				if (array != null)
				{
					array[i] = t;
				}
				else if (t != nodes[i])
				{
					array = new T[count];
					for (int j = 0; j < i; j++)
					{
						array[j] = nodes[j];
					}
					array[i] = t;
				}
				i++;
			}
			if (array == null)
			{
				return nodes;
			}
			return new TrueReadOnlyCollection<T>(array);
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.BinaryExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600047A RID: 1146 RVA: 0x00011D71 File Offset: 0x0000FF71
		protected internal virtual Expression VisitBinary(BinaryExpression node)
		{
			return ExpressionVisitor.ValidateBinary(node, node.Update(this.Visit(node.Left), this.VisitAndConvert<LambdaExpression>(node.Conversion, "VisitBinary"), this.Visit(node.Right)));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.BlockExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600047B RID: 1147 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		protected internal virtual Expression VisitBlock(BlockExpression node)
		{
			Expression[] array = ExpressionVisitorUtils.VisitBlockExpressions(this, node);
			ReadOnlyCollection<ParameterExpression> readOnlyCollection = this.VisitAndConvert<ParameterExpression>(node.Variables, "VisitBlock");
			if (readOnlyCollection == node.Variables && array == null)
			{
				return node;
			}
			return node.Rewrite(readOnlyCollection, array);
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.ConditionalExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600047C RID: 1148 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		protected internal virtual Expression VisitConditional(ConditionalExpression node)
		{
			return node.Update(this.Visit(node.Test), this.Visit(node.IfTrue), this.Visit(node.IfFalse));
		}

		/// <summary>Visits the <see cref="T:System.Linq.Expressions.ConstantExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600047D RID: 1149 RVA: 0x00011E11 File Offset: 0x00010011
		protected internal virtual Expression VisitConstant(ConstantExpression node)
		{
			return node;
		}

		/// <summary>Visits the <see cref="T:System.Linq.Expressions.DefaultExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600047E RID: 1150 RVA: 0x00011E11 File Offset: 0x00010011
		protected internal virtual Expression VisitDefault(DefaultExpression node)
		{
			return node;
		}

		/// <summary>Visits the children of the extension expression.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600047F RID: 1151 RVA: 0x00011E14 File Offset: 0x00010014
		protected internal virtual Expression VisitExtension(Expression node)
		{
			return node.VisitChildren(this);
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.GotoExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000480 RID: 1152 RVA: 0x00011E1D File Offset: 0x0001001D
		protected internal virtual Expression VisitGoto(GotoExpression node)
		{
			return node.Update(this.VisitLabelTarget(node.Target), this.Visit(node.Value));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.InvocationExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000481 RID: 1153 RVA: 0x00011E40 File Offset: 0x00010040
		protected internal virtual Expression VisitInvocation(InvocationExpression node)
		{
			Expression expression = this.Visit(node.Expression);
			Expression[] array = this.VisitArguments(node);
			if (expression == node.Expression && array == null)
			{
				return node;
			}
			return node.Rewrite(expression, array);
		}

		/// <summary>Visits the <see cref="T:System.Linq.Expressions.LabelTarget" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000482 RID: 1154 RVA: 0x00011E11 File Offset: 0x00010011
		protected virtual LabelTarget VisitLabelTarget(LabelTarget node)
		{
			return node;
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.LabelExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000483 RID: 1155 RVA: 0x00011E78 File Offset: 0x00010078
		protected internal virtual Expression VisitLabel(LabelExpression node)
		{
			return node.Update(this.VisitLabelTarget(node.Target), this.Visit(node.DefaultValue));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.Expression`1" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <typeparam name="T">The type of the delegate.</typeparam>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000484 RID: 1156 RVA: 0x00011E98 File Offset: 0x00010098
		protected internal virtual Expression VisitLambda<T>(Expression<T> node)
		{
			Expression expression = this.Visit(node.Body);
			ParameterExpression[] array = this.VisitParameters(node, "VisitLambda");
			if (expression == node.Body && array == null)
			{
				return node;
			}
			return node.Rewrite(expression, array);
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.LoopExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000485 RID: 1157 RVA: 0x00011ED5 File Offset: 0x000100D5
		protected internal virtual Expression VisitLoop(LoopExpression node)
		{
			return node.Update(this.VisitLabelTarget(node.BreakLabel), this.VisitLabelTarget(node.ContinueLabel), this.Visit(node.Body));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MemberExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000486 RID: 1158 RVA: 0x00011F01 File Offset: 0x00010101
		protected internal virtual Expression VisitMember(MemberExpression node)
		{
			return node.Update(this.Visit(node.Expression));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.IndexExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000487 RID: 1159 RVA: 0x00011F18 File Offset: 0x00010118
		protected internal virtual Expression VisitIndex(IndexExpression node)
		{
			Expression expression = this.Visit(node.Object);
			Expression[] array = this.VisitArguments(node);
			if (expression == node.Object && array == null)
			{
				return node;
			}
			return node.Rewrite(expression, array);
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MethodCallExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000488 RID: 1160 RVA: 0x00011F50 File Offset: 0x00010150
		protected internal virtual Expression VisitMethodCall(MethodCallExpression node)
		{
			Expression expression = this.Visit(node.Object);
			Expression[] array = this.VisitArguments(node);
			if (expression == node.Object && array == null)
			{
				return node;
			}
			return node.Rewrite(expression, array);
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.NewArrayExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000489 RID: 1161 RVA: 0x00011F88 File Offset: 0x00010188
		protected internal virtual Expression VisitNewArray(NewArrayExpression node)
		{
			return node.Update(this.Visit(node.Expressions));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.NewExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600048A RID: 1162 RVA: 0x00011F9C File Offset: 0x0001019C
		protected internal virtual Expression VisitNew(NewExpression node)
		{
			Expression[] array = this.VisitArguments(node);
			if (array == null)
			{
				return node;
			}
			return node.Update(array);
		}

		/// <summary>Visits the <see cref="T:System.Linq.Expressions.ParameterExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600048B RID: 1163 RVA: 0x00011E11 File Offset: 0x00010011
		protected internal virtual Expression VisitParameter(ParameterExpression node)
		{
			return node;
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.SwitchCase" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600048C RID: 1164 RVA: 0x00011FBD File Offset: 0x000101BD
		protected virtual SwitchCase VisitSwitchCase(SwitchCase node)
		{
			return node.Update(this.Visit(node.TestValues), this.Visit(node.Body));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.SwitchExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600048D RID: 1165 RVA: 0x00011FDD File Offset: 0x000101DD
		protected internal virtual Expression VisitSwitch(SwitchExpression node)
		{
			return ExpressionVisitor.ValidateSwitch(node, node.Update(this.Visit(node.SwitchValue), ExpressionVisitor.Visit<SwitchCase>(node.Cases, new Func<SwitchCase, SwitchCase>(this.VisitSwitchCase)), this.Visit(node.DefaultBody)));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.CatchBlock" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600048E RID: 1166 RVA: 0x0001201B File Offset: 0x0001021B
		protected virtual CatchBlock VisitCatchBlock(CatchBlock node)
		{
			return node.Update(this.VisitAndConvert<ParameterExpression>(node.Variable, "VisitCatchBlock"), this.Visit(node.Filter), this.Visit(node.Body));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.TryExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x0600048F RID: 1167 RVA: 0x0001204C File Offset: 0x0001024C
		protected internal virtual Expression VisitTry(TryExpression node)
		{
			return node.Update(this.Visit(node.Body), ExpressionVisitor.Visit<CatchBlock>(node.Handlers, new Func<CatchBlock, CatchBlock>(this.VisitCatchBlock)), this.Visit(node.Finally), this.Visit(node.Fault));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.TypeBinaryExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000490 RID: 1168 RVA: 0x0001209B File Offset: 0x0001029B
		protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node)
		{
			return node.Update(this.Visit(node.Expression));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.UnaryExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000491 RID: 1169 RVA: 0x000120AF File Offset: 0x000102AF
		protected internal virtual Expression VisitUnary(UnaryExpression node)
		{
			return ExpressionVisitor.ValidateUnary(node, node.Update(this.Visit(node.Operand)));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MemberInitExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000492 RID: 1170 RVA: 0x000120C9 File Offset: 0x000102C9
		protected internal virtual Expression VisitMemberInit(MemberInitExpression node)
		{
			return node.Update(this.VisitAndConvert<NewExpression>(node.NewExpression, "VisitMemberInit"), ExpressionVisitor.Visit<MemberBinding>(node.Bindings, new Func<MemberBinding, MemberBinding>(this.VisitMemberBinding)));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.ListInitExpression" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000493 RID: 1171 RVA: 0x000120FA File Offset: 0x000102FA
		protected internal virtual Expression VisitListInit(ListInitExpression node)
		{
			return node.Update(this.VisitAndConvert<NewExpression>(node.NewExpression, "VisitListInit"), ExpressionVisitor.Visit<ElementInit>(node.Initializers, new Func<ElementInit, ElementInit>(this.VisitElementInit)));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.ElementInit" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000494 RID: 1172 RVA: 0x0001212B File Offset: 0x0001032B
		protected virtual ElementInit VisitElementInit(ElementInit node)
		{
			return node.Update(this.Visit(node.Arguments));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MemberBinding" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000495 RID: 1173 RVA: 0x00012140 File Offset: 0x00010340
		protected virtual MemberBinding VisitMemberBinding(MemberBinding node)
		{
			switch (node.BindingType)
			{
			case MemberBindingType.Assignment:
				return this.VisitMemberAssignment((MemberAssignment)node);
			case MemberBindingType.MemberBinding:
				return this.VisitMemberMemberBinding((MemberMemberBinding)node);
			case MemberBindingType.ListBinding:
				return this.VisitMemberListBinding((MemberListBinding)node);
			default:
				throw Error.UnhandledBindingType(node.BindingType);
			}
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MemberAssignment" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000496 RID: 1174 RVA: 0x0001219F File Offset: 0x0001039F
		protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment node)
		{
			return node.Update(this.Visit(node.Expression));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MemberMemberBinding" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000497 RID: 1175 RVA: 0x000121B3 File Offset: 0x000103B3
		protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
		{
			return node.Update(ExpressionVisitor.Visit<MemberBinding>(node.Bindings, new Func<MemberBinding, MemberBinding>(this.VisitMemberBinding)));
		}

		/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MemberListBinding" />.</summary>
		/// <param name="node">The expression to visit.</param>
		/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
		// Token: 0x06000498 RID: 1176 RVA: 0x000121D3 File Offset: 0x000103D3
		protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding node)
		{
			return node.Update(ExpressionVisitor.Visit<ElementInit>(node.Initializers, new Func<ElementInit, ElementInit>(this.VisitElementInit)));
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000121F4 File Offset: 0x000103F4
		private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after)
		{
			if (before != after && before.Method == null)
			{
				if (after.Method != null)
				{
					throw Error.MustRewriteWithoutMethod(after.Method, "VisitUnary");
				}
				if (before.Operand != null && after.Operand != null)
				{
					ExpressionVisitor.ValidateChildType(before.Operand.Type, after.Operand.Type, "VisitUnary");
				}
			}
			return after;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00012264 File Offset: 0x00010464
		private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after)
		{
			if (before != after && before.Method == null)
			{
				if (after.Method != null)
				{
					throw Error.MustRewriteWithoutMethod(after.Method, "VisitBinary");
				}
				ExpressionVisitor.ValidateChildType(before.Left.Type, after.Left.Type, "VisitBinary");
				ExpressionVisitor.ValidateChildType(before.Right.Type, after.Right.Type, "VisitBinary");
			}
			return after;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000122E3 File Offset: 0x000104E3
		private static SwitchExpression ValidateSwitch(SwitchExpression before, SwitchExpression after)
		{
			if (before.Comparison == null && after.Comparison != null)
			{
				throw Error.MustRewriteWithoutMethod(after.Comparison, "VisitSwitch");
			}
			return after;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00012313 File Offset: 0x00010513
		private static void ValidateChildType(Type before, Type after, string methodName)
		{
			if (before.IsValueType)
			{
				if (TypeUtils.AreEquivalent(before, after))
				{
					return;
				}
			}
			else if (!after.IsValueType)
			{
				return;
			}
			throw Error.MustRewriteChildToSameType(before, after, methodName);
		}
	}
}
